using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class ModePage : Form
    {

        public static string selectedMode = "";
        string[] modes = { "블루투스", "디스플레이", "와이파이" };

        public ModePage()
        {
            InitializeComponent();
            ModeComboBox.DataSource = modes;
            ModeComboBox.Text = "";
            ModeComboBox.SelectedItem = null;
        }

        private void ModeChangeButton_Click(object sender, EventArgs e)
        {
            if (DidntChooseAnyMode()) return;


            List<byte> dataArea = new List<byte>();

            if (selectedMode == "블루투스")
            {
                if(Constants.CONNECT_MODE == Constants.DISPLAYMODE)
                {
                    Bluetooth.BluetoothConnect();
                    return;
                }
                dataArea.Add(0);
            }
            else if (selectedMode == "디스플레이")
            {
                dataArea.Add(1);
            }
            else if (selectedMode == "와이파이")
            {
                if (Constants.CONNECT_MODE == Constants.DISPLAYMODE)
                {
                    MessageBox.Show("블루투스로 변경한 후에 시도하세요.");
                    return;
                }else if(WiFi.macAddr == "")
                {
                    MessageBox.Show("블루투스로 연결한 후에 시도하세요.");
                    return;
                }
                dataArea.Add(3);
            }

            if (!Comm.IsthereAnyConnect())
            {
                MessageBox.Show("통신 없음");
                return;
            }
            ModeChange(ref dataArea);

            if (selectedMode == "블루투스")
            {
                BluetoothMode();
            }else if (selectedMode == "디스플레이")
            {
                DisplayMode();
            }
            else if (selectedMode == "와이파이")
            {
                WiFiConnect();
            }
        }
        public void WiFiConnect()
        {
            WiFi.MakeDBClient();
            WiFi.EtherNetConnect();
            Constants.PREVCONMODE = Constants.CONNECT_MODE;
            Constants.CONNECT_MODE = Constants.WIFIMODE;
        }
        public void ModeChange(ref List<byte> dataArea)
        {
            dataArea.Insert(0, Constants.CHANGE_MODE);
            Comm.transmit_data(dataArea);
        }

        public static void BluetoothMode()
        {
            Constants.PREVCONMODE = Constants.CONNECT_MODE;
            Constants.CONNECT_MODE = Constants.BLUETOOTHMODE;
        }
        public void DisplayMode()
        {
            Constants.PREVCONMODE = Constants.CONNECT_MODE;
            Constants.CONNECT_MODE = Constants.DISPLAYMODE;
        }

        private void ModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedMode = comboBox.Text;
        }

        private void CurModeButton_Click(object sender, EventArgs e)
        {
            CurModeLabel.Text = Constants.CONNECT_MODE;
        }

        public bool DidntChooseAnyMode()
        {
            if (selectedMode == "")return true;
            else return false;
        }
    }
}
