using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlassLED
{
    internal class WiFi
    {

        //public static Thread FinishCheckOfGetMacAddr = null;
        public static bool isFinishGetMacAddr = false;

        /* 파이어베이스 DB */
        public const string BasePath = "https://frotier-popsign-default-rtdb.firebaseio.com/";
        public const string FireBaseSecret = "ujiDibPqKMFotmZd2WkmJLmr0aRAiRNOxowp2dai";
        public static FirebaseClient client;
        public static string macAddr = "";

        /* 와이파이 등록 */
        public static void WiFiSetting(string ssid, string pw)
        {
            List<byte> dataArea = new List<byte>();
            byte[] buf_ssid = Encoding.UTF8.GetBytes(ssid);
            byte[] buf_pw = Encoding.UTF8.GetBytes(pw);

            dataArea.Add(Constants.SET_WIFI_CONNECT);
            // ssid 저장
            dataArea.Add((byte)buf_ssid.Count());
            foreach (byte b in buf_ssid)
            {
                dataArea.Add((byte)b);
            }

            // pw 저장
            dataArea.Add((byte)buf_pw.Count());
            foreach (byte b in buf_pw)
            {
                dataArea.Add((byte)b);
            }
            Comm.transmit_data(dataArea);
        }

        /* DB Client 생성 */
        public static void MakeDBClient()
        {
            /* DB 설정 */
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = FireBaseSecret,
                BasePath = BasePath + macAddr
            };
            client = new FirebaseClient(config);
        }

        /* 인터넷 연결 */
        public static void EtherNetConnect()
        {
            List<byte> dataArea = new List<byte>();
            dataArea.Add(Constants.START_WIFI_MODE);
            dataArea.Add(3);

            /* 보드 와이파이모드 시작 */
            Comm.transmit_data(dataArea);
        }


    }
}
