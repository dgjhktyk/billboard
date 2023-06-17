using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlassLED
{
    internal class Constants
    {
        public const int MAX_SERIAL_BUF = 1024;
        public const int PACKET_SIZE = 1024;
        public const int STX = 0x02;
        public const int ETX = 0x03;
        public const int ACK = 0x06;
        public const int NCK = 0x15;

        /*	패킷 사이즈	*/
        public const int SIZE_STX = 1;
        public const int SIZE_LEN1 = 2;
        public const int SIZE_LEN2 = 2;
        public const int SIZE_CMD = 1;
        public const int SIZE_CRC = 2;
        public const int SIZE_ETX = 1;
        public const int SIZE_FIELD = 5;
        public const int SIZE_PAGE = 1;
        public const int SIZE_SET_DRAW_FIELD = SIZE_FIELD + SIZE_PAGE + SIZE_LEN1;
        public const int SIZE_WIFI_SSID = 1;
        public const int SIZE_WIFI_PW = 1;
        public const int SIZE_WIFI_STATUS = 1;
        public const int SIZE_PKT_DATA = SIZE_STX + SIZE_LEN1 + SIZE_LEN2 + SIZE_CMD + SIZE_CRC + SIZE_ETX;
        public const int SIZE_ACTION = 3;
        public const int SIZE_EFFECT = 9;
        public const int SIZE_OPTION = 1;
        public const int SIZE_PICTURE_SIZE = 4;    // Width 2bytes + Hegiht 2bytes

        /*	패킷 인덱스	*/
        public const int IDX_STX = 0;
        public const int IDX_LEN = IDX_STX + SIZE_STX;
        public const int IDX_CMD = IDX_LEN + SIZE_LEN1 + SIZE_LEN2;
        public const int IDX_CRC = IDX_CMD + SIZE_CMD;
        public const int IDX_ETX = IDX_CRC + SIZE_CRC;

        public const int TRANSMIT_BLUETOOTH = 1;
        public const int TRANSMIT_UART_GPIO = 0;
        public const int TRANSMIT_WIFI_PACKET = 2;

        /* 모드변경 */
        public const byte SET_MODE_CHANGE = 0x20;

        /* 블루투스 */
        public const byte SET_INIT_BOARD = 0xA0;

        /* 와이파이 */
        public const byte SET_WIFI_CONNECT = 0xB1;
        public const byte START_WIFI_MODE = 0x20;

        /* 맥주소 얻기 */
        public const byte GET_WIFI_SERVER_KEY = 0x63;

        /* 미리보기 */
        // 임시 정의
        public const byte PREVIEW_CMD = 0x21;

        /* 저장 */
        public const byte SAVE_TEXT = 0xa1;

        /* 전체 삭제 */
        public const byte DELETE_ALL_PAGE = 0xA6;

        /* 연결 모드 */
        public static string CONNECT_MODE = "";
        public static string BLUETOOTHMODE = "BLUETOOTH";
        public static string WIFIMODE = "WIFIMODE";
        public static string DISPLAYMODE = "DISPLAY";
        public static string PREVCONMODE = "";

        /* 디스플레이모드 -> 블루투스 모드 전환 */
        public static byte SET_MODE_BT_NON_DISCONNECT = 0x27;

        /* 모드 변경 */
        public static byte CHANGE_MODE = 0x20;

        /* 날씨 위치 정보 */
        public static byte SET_DEVICE_LOCATION_XY = 0x25;

        /* 자외선 위치 정보 */
        public static byte SET_RAY_DEVICE_LOCATION_CITY = 0x28;

        /* 시계 */
        public static byte FUNCTION_CLOCK_BIT_MASK = 1;

        /* 날씨 */
        public static byte FUNCTION_WEATHER_BIT_MASK = 2;

        /* 공기 오염 */
        public static byte FUNCTION_AIR_POLLUTION_BIT_MASK = 8;

        /* Func */
        public static byte SET_MATRIX_FUNCTION = 0x42;

        /* 홍콩 */
        public static byte SET_WORLD_WEATHER_DATA = 0x29;

        /* 효과 */
        public static byte[] effectValues = new byte[5] { 1, 2, 4, 8, 16 };

        /* 회전 */
        public static byte SET_ROTATION_LANDSCAPE = 0x96;
        public static byte SET_ROTATION_PORTRAIT = 0x97;

        public static ushort[] crc16tab = new ushort[256]{
        0x0000,0x1021,0x2042,0x3063,0x4084,0x50a5,0x60c6,0x70e7,
        0x8108,0x9129,0xa14a,0xb16b,0xc18c,0xd1ad,0xe1ce,0xf1ef,
        0x1231,0x0210,0x3273,0x2252,0x52b5,0x4294,0x72f7,0x62d6,
        0x9339,0x8318,0xb37b,0xa35a,0xd3bd,0xc39c,0xf3ff,0xe3de,
        0x2462,0x3443,0x0420,0x1401,0x64e6,0x74c7,0x44a4,0x5485,
        0xa56a,0xb54b,0x8528,0x9509,0xe5ee,0xf5cf,0xc5ac,0xd58d,
        0x3653,0x2672,0x1611,0x0630,0x76d7,0x66f6,0x5695,0x46b4,
        0xb75b,0xa77a,0x9719,0x8738,0xf7df,0xe7fe,0xd79d,0xc7bc,
        0x48c4,0x58e5,0x6886,0x78a7,0x0840,0x1861,0x2802,0x3823,
        0xc9cc,0xd9ed,0xe98e,0xf9af,0x8948,0x9969,0xa90a,0xb92b,
        0x5af5,0x4ad4,0x7ab7,0x6a96,0x1a71,0x0a50,0x3a33,0x2a12,
        0xdbfd,0xcbdc,0xfbbf,0xeb9e,0x9b79,0x8b58,0xbb3b,0xab1a,
        0x6ca6,0x7c87,0x4ce4,0x5cc5,0x2c22,0x3c03,0x0c60,0x1c41,
        0xedae,0xfd8f,0xcdec,0xddcd,0xad2a,0xbd0b,0x8d68,0x9d49,
        0x7e97,0x6eb6,0x5ed5,0x4ef4,0x3e13,0x2e32,0x1e51,0x0e70,
        0xff9f,0xefbe,0xdfdd,0xcffc,0xbf1b,0xaf3a,0x9f59,0x8f78,
        0x9188,0x81a9,0xb1ca,0xa1eb,0xd10c,0xc12d,0xf14e,0xe16f,
        0x1080,0x00a1,0x30c2,0x20e3,0x5004,0x4025,0x7046,0x6067,
        0x83b9,0x9398,0xa3fb,0xb3da,0xc33d,0xd31c,0xe37f,0xf35e,
        0x02b1,0x1290,0x22f3,0x32d2,0x4235,0x5214,0x6277,0x7256,
        0xb5ea,0xa5cb,0x95a8,0x8589,0xf56e,0xe54f,0xd52c,0xc50d,
        0x34e2,0x24c3,0x14a0,0x0481,0x7466,0x6447,0x5424,0x4405,
        0xa7db,0xb7fa,0x8799,0x97b8,0xe75f,0xf77e,0xc71d,0xd73c,
        0x26d3,0x36f2,0x0691,0x16b0,0x6657,0x7676,0x4615,0x5634,
        0xd94c,0xc96d,0xf90e,0xe92f,0x99c8,0x89e9,0xb98a,0xa9ab,
        0x5844,0x4865,0x7806,0x6827,0x18c0,0x08e1,0x3882,0x28a3,
        0xcb7d,0xdb5c,0xeb3f,0xfb1e,0x8bf9,0x9bd8,0xabbb,0xbb9a,
        0x4a75,0x5a54,0x6a37,0x7a16,0x0af1,0x1ad0,0x2ab3,0x3a92,
        0xfd2e,0xed0f,0xdd6c,0xcd4d,0xbdaa,0xad8b,0x9de8,0x8dc9,
        0x7c26,0x6c07,0x5c64,0x4c45,0x3ca2,0x2c83,0x1ce0,0x0cc1,
        0xef1f,0xff3e,0xcf5d,0xdf7c,0xaf9b,0xbfba,0x8fd9,0x9ff8,
        0x6e17,0x7e36,0x4e55,0x5e74,0x2e93,0x3eb2,0x0ed1,0x1ef0};
    }
}
