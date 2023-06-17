using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class LocationSettingPage : Form
    {
        List<string> suggestions = new List<string>();
        public string selectedLoc = "";
        string inputText = "";

        public LocationSettingPage()
        {
            InitializeComponent();
        }

        public void suggestionsOfWheatherListBox()
        {
            inputText = wheatherDongInputTextBox.Text;
            if (inputText.Last() == '동' || inputText.Last() == '읍' || inputText.Last() == '면')
            {
                inputText = inputText.Remove(inputText.Length - 1);
            }
            suggestions = Data.locNameList.Where(x => x.Contains(inputText)).ToList();
            wheatherListBox.DataSource = suggestions;
        }

        public void suggestionsOfUVListBox()
        {
            if (inputText.Last() == '동' || inputText.Last() == '읍' || inputText.Last() == '면')
            {
                inputText = inputText.Remove(inputText.Length - 1);
            }
            inputText = uvInputTextBox.Text;
            suggestions = Data.locNameList.Where(x => x.Contains(inputText)).ToList();
            uvListBox.DataSource = suggestions;
        }


        private void wheatherSearchButton_Click(object sender, EventArgs e)
        {
            suggestionsOfWheatherListBox();
        }

        private void uvSearchButton_Click(object sender, EventArgs e)
        {
            suggestionsOfUVListBox();
        }

        private void wheatherDongInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                suggestionsOfWheatherListBox();
            }
        }

        private void uvInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                suggestionsOfUVListBox();
            }
        }

        private void wheatherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLoc = wheatherListBox.SelectedItem as string;
        }

        private void uvListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLoc = uvListBox.SelectedItem as string;
        }
        private void WheatherInfoSendButton_Click(object sender, EventArgs e)
        {
            if (!Comm.IsthereAnyConnect())
            {
                MessageBox.Show("통신 없음");
                return;
            }
            Dictionary<string, byte> xyDic = Data.wheatherXYDic[selectedLoc];

            List<byte> dataArea = new List<byte>();
            dataArea.Add(Constants.SET_DEVICE_LOCATION_XY);
            dataArea.Add(xyDic["X"]);
            dataArea.Add(xyDic["Y"]);

            Comm.transmit_data(dataArea);
            MessageBox.Show("전송 완료");
        }

        private void UltraLocationInfoSendButton_Click(object sender, EventArgs e)
        {
            if(!Comm.IsthereAnyConnect())
            {
                MessageBox.Show("통신 없음");
                return;
            }
            List<byte> dataArea = new List<byte>(new byte[5]);

            long regionalCode = (long)Data.ultravioletCodeDic[selectedLoc];
            dataArea.Add(Constants.SET_RAY_DEVICE_LOCATION_CITY);
            dataArea[0] = (byte)((regionalCode >> 32) & (0xFF));
            dataArea[1] = (byte)((regionalCode >> 24) & (0xFF));
            dataArea[2] = (byte)((regionalCode >> 16) & (0xFF));
            dataArea[3] = (byte)((regionalCode >> 8) & (0xFF));
            dataArea[4] = (byte)(regionalCode & 0xFF);

            Comm.transmit_data(dataArea);
            MessageBox.Show("전송 완료");
        }


    }
}
