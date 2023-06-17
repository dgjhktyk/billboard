using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class WiFiPage : Form
    {
        public WiFiPage()
        {
            InitializeComponent();
            ShowingMacAddrLabel.Text = WiFi.macAddr;
        }

        private void WiFiRegButton_Click(object sender, EventArgs e)
        {
            if (Constants.CONNECT_MODE == "")
            {
                MessageBox.Show("일단 블루투스로 먼저 연결하세요");
                return;
            }
            WiFi.WiFiSetting(WiFiNameInputTextBox.Text, WiFiPWInputTextBox.Text);
            MessageBox.Show("WiFi 정보 전송 완료");
        }

        private void WiFiModeStartButton_Click(object sender, EventArgs e)
        {
            if (Constants.CONNECT_MODE == "")
            {
                MessageBox.Show("일단 블루투스로 먼저 연결하세요");
                return;
            }

            WiFi.MakeDBClient();
            WiFi.EtherNetConnect();
            Constants.PREVCONMODE = Constants.CONNECT_MODE;
            Constants.CONNECT_MODE = Constants.WIFIMODE;
            MessageBox.Show("WiFi모드 시작");

        }

        private void UpdateMacAddrButton_Click(object sender, EventArgs e)
        {
            ShowingMacAddrLabel.Text = WiFi.macAddr;
        }
        public void WiFiConnect()
        {
            //WiFi.MakeDBClient();
            WiFi.EtherNetConnect();
            Constants.PREVCONMODE = Constants.CONNECT_MODE;
            Constants.CONNECT_MODE = Constants.WIFIMODE;
        }
    }
}
