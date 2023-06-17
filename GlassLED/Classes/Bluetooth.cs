using GodSharp.SerialPort;
using System.Collections.Generic;

using System.Windows.Forms;

namespace GlassLED
{
    internal class Bluetooth
    {
        public static GodSerialPort gsp;
        public static string selectedPort = "";
        public static bool bluetoothConCheck = false;
        public static List<byte> packet = new List<byte>();
        public static bool MakeGSP()
        {
            /* gsp가 데이터 받는 부분 */
            gsp.UseDataReceived(true, (sp, bytes) =>
            {
                DataReceived(ref bytes);
            });

            gsp.WriteTimeout = 1000;
            gsp.Open();

            if (!gsp.IsOpen)
            {
                return false; ;
            }
            return true;
        }
        public static void BluetoothConnect()
        {
            if (gsp != null && gsp.IsOpen && Constants.CONNECT_MODE == Constants.BLUETOOTHMODE)
            {
                MessageBox.Show("이미 블루투스로 연결 상태입니다");
                return;
            }
            if (gsp == null)
            {
                gsp = new GodSerialPort(selectedPort, 115200, 0);
            }else
            {
                gsp.Close();
                gsp = null;
                gsp = new GodSerialPort(selectedPort, 115200, 0);
            }

            if (MakeGSP() == false)
            {
                gsp = null;
                MessageBox.Show("포트 오픈 실패");
                Constants.CONNECT_MODE = Constants.PREVCONMODE;
                return;
            }



            short year = short.Parse(System.DateTime.Now.ToString("yyyy"));
            byte month = byte.Parse(System.DateTime.Now.ToString("MM"));
            byte day = byte.Parse(System.DateTime.Now.ToString("dd"));
            byte hour = byte.Parse(System.DateTime.Now.ToString("hh"));
            byte minute = byte.Parse(System.DateTime.Now.ToString("mm"));
            byte second = byte.Parse(System.DateTime.Now.ToString("ss"));

            List<byte> dataArea = new List<byte>(new byte[8]);
            dataArea[0] = Constants.SET_INIT_BOARD;
            dataArea[1] = (byte)(year >> 8);                    //  년도 앞 2자리
            dataArea[2] = (byte)(year & 0xff);                  //  년도 뒤 2자리
            dataArea[3] = month;                                //  월
            dataArea[4] = day;                                  //  일
            dataArea[5] = hour;                                 //  시간
            dataArea[6] = minute;                               //  분
            dataArea[7] = second;                               //  초

            Comm.transmit_data(dataArea);
        }
 
        public static void DataReceived(ref byte[] bytes)
        {
            if (bytes == null)
                return;
            bool recv_end = false;
            byte recv_step = 0;
            ushort data_chk = 0;
            ushort data_chk2 = 0;
            ushort dataLen = 0;
            ushort dataLen2 = 0;
            ushort dataLenTmp = 0;
            ushort crc_chk = 0;
            ushort crc;

            ushort serRxLen = (ushort)bytes.Length;

            if (serRxLen > 0)
            {
                for (int i = 0; i < serRxLen; i++)
                {
                    if (recv_step == 0)
                    {
                        // STX
                        if (bytes[i] == Constants.STX)
                        {
                            recv_step = 1;
                            dataLen = 0;
                            data_chk = 0;
                            continue;
                        }
                    }
                    else if (recv_step == 1)
                    {
                        if (data_chk == 0)
                        {
                            // data 길이 하위 1바이트
                            dataLen = bytes[i];
                            ++data_chk;
                            continue;
                        }
                        else
                        {
                            // data 길이 상위 1바이트
                            dataLen = (ushort)(dataLen | (bytes[i] << 8));
                            dataLenTmp = dataLen;
                            packet.Clear();
                            data_chk = 0;
                            recv_step = 2;
                            continue;
                        }
                    }
                    else if (recv_step == 2)
                    {
                        if (data_chk2 == 0)
                        {
                            // data 길이 하위 1바이트
                            dataLen2 = bytes[i];
                            ++data_chk2;
                            continue;
                        }
                        else
                        {
                            // data 길이 상위 1바이트
                            dataLen2 = (ushort)(dataLen2 | (bytes[i] << 8));
                            data_chk2 = 0;
                            if (dataLen != dataLen2)
                            {
                                recv_step = 0;
                                dataLen2 = 0;
                                dataLen = 0;
                            }
                            else
                            {
                                recv_step = 3;
                            }
                            continue;
                        }
                    }
                    else if (recv_step == 3)
                    {
                        // data
                        packet.Add(bytes[i]);
                        --dataLenTmp;
                        if (dataLenTmp == 0)
                        {
                            recv_step = 4;
                            continue;
                        }
                    }
                    else if (recv_step == 4)
                    {
                        // crc
                        packet.Add(bytes[i]);
                        ++crc_chk;
                        if (crc_chk >= 2)
                        {
                            crc_chk = 0;
                            recv_step = 5;
                            continue;
                        }
                    }
                    else if (recv_step == 5)
                    {
                        if (bytes[i] == Constants.ETX)
                        {
                            recv_end = true;
                        }
                        else
                        {
                            dataLen = 0;
                            dataLenTmp = 0;
                        }
                        recv_step = 0;
                    }
                }
                if (recv_end == true)
                {
                    crc = crc16_ccitt(packet);
                    if (crc == 0) // crc ok
                    {
                        byte cmd = packet[0];
                        packet.RemoveAt(0);
                        packet.RemoveAt(packet.Count - 1); // crc 제거
                        packet.RemoveAt(packet.Count - 1); // crc 제거
                        cmd_process(cmd, packet);
                    }
                    else
                    {
                        // NACK
                        return;
                    }
                }
            }            
        }

        public static void cmd_process(byte cmd, List<byte> data)
        {
            switch (cmd)
            {
                case Constants.SET_INIT_BOARD:
                    if (data[12] == Constants.SET_MODE_CHANGE && data[14] == 1)
                    {
                        DisplayModeInterupt();
                        return;
                    }
                    MessageBox.Show("블루투스 연결 성공");
                    RequestMacAddr();
                    break;
                case Constants.GET_WIFI_SERVER_KEY:
                    GetMacAddr();
                    break;
            }
        }
        public static ushort crc16_ccitt(List<byte> packet)
        {
            ushort crc = 0;
            foreach (byte b in packet)
            {
                crc = (ushort)((crc << 8) ^ Constants.crc16tab[((crc >> 8) ^ b) & 0x00FF]);
            }
            return crc;
        }

        public static void DisplayModeInterupt()
        {
            if (MessageBox.Show("현재 디스플레이 모드 입니다. 블루투스 모드로 전환 하시겠습니까?", "디스플레이 -> 블루투스", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<byte> dataArea = new List<byte>();
                dataArea.Add(Constants.SET_MODE_BT_NON_DISCONNECT);
                Comm.transmit_data(dataArea);
                Constants.CONNECT_MODE = Constants.BLUETOOTHMODE;
            }
            else
            {
                List<byte> dataArea = new List<byte>();
                dataArea.Add(Constants.CHANGE_MODE);
                dataArea.Add(1);
                Comm.transmit_data(dataArea);
                Constants.CONNECT_MODE = Constants.DISPLAYMODE;
            }
        }

        public static void RequestMacAddr()
        {
            List<byte> dataArea = new List<byte>();
            dataArea.Add(Constants.GET_WIFI_SERVER_KEY);
            Comm.transmit_data(dataArea);
        }

        public static void GetMacAddr()
        {
            WiFi.macAddr = "";
            for (int i = 0; i < 6; i++)
            {
                WiFi.macAddr += packet[i].ToString("X");
            }
            WiFi.macAddr = WiFi.macAddr.ToLower();
        }

        public static void CloseBluetooth()
        {
            gsp.Close();
            gsp = null;
        }

        public static bool BluetoothConCheck()
        {
            if (gsp != null && gsp.IsOpen)
                return true;

            return false;
        }
    }
}


