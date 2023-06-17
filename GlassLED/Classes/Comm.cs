using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassLED
{
    internal class Comm
    {
        public static byte[] packetbyteArray;

        public static ushort crc16_ccitt(List<byte> packet)
        {
            ushort crc = 0;
            foreach (byte b in packet)
            {
                crc = (ushort)((crc << 8) ^ Data.crc16tab[((crc >> 8) ^ b) & 0x00FF]);
            }
            return crc;
        }

        public static void transmit_data(List<byte> data)
        {
            ushort dataLen = (ushort)data.Count;

            List<byte> packet = new List<byte>();

            packet.Add((byte)0x02);                         
            packet.Add((byte)(dataLen));                   
            packet.Add((byte)(dataLen >> 8));           
            packet.Add((byte)(dataLen));                 
            packet.Add((byte)(dataLen >> 8));            

            packet.AddRange(data);

            ushort crc = crc16_ccitt(data);

            packet.Add((byte)(crc >> 8));                   
            packet.Add((byte)(crc & 0xFF));                
            packet.Add((byte)0x03);                      

            Send(Constants.CONNECT_MODE, packet);
        }

        public static async void Send(string curMode, List<byte> packetArray)
        {
            if (curMode == Constants.BLUETOOTHMODE || curMode == Constants.DISPLAYMODE)
            {
                /* 블루투스 전송 */
                /* 블루투스는 문자열이 아니라 그냥 바이트 배열로 보내야함 */
                packetbyteArray = packetArray.ToArray();
                try
                {
                    Bluetooth.gsp.Write(packetbyteArray);
                }
                catch (Exception e)
                {
                    if(e.Message == "쓰기 시간이 초과되었습니다.")
                    {
                        Bluetooth.gsp.Close();
                        Bluetooth.gsp = null;
                    }
                }

            }
            else if (curMode == Constants.WIFIMODE)
            {
                /* DB 입력 */
                /* 파이어베이스는 문자열로 보내야함 */
                string data = String.Join<byte>(",", packetArray);
                try
                {
                    SetResponse response = await WiFi.client.SetAsync("data", data);
                    string result = response.ResultAs<string>();
                }
                catch(System.Net.WebException)
                {
                    MessageBox.Show("PC의 인터넷 연결 상태를 확인해주세요");
                    return;
                }

            }
        }

        public static bool IsthereAnyConnect()
        {
            //한번도 블루투스 연결을 하지 않음
            //if (Bluetooth.gsp == null) return false;

            if (Bluetooth.gsp != null && Bluetooth.gsp.IsOpen == true && (Constants.CONNECT_MODE == Constants.BLUETOOTHMODE)) return true; // 블루투스 연결 상태
            else if ((Constants.CONNECT_MODE == Constants.WIFIMODE) && (WiFi.client != null)) return true; // 와이파이 연결 상태
            else return false; // 연결 없음
        }
    }
}
