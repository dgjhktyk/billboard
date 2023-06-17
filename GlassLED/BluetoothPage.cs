using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class BluetoothPage : Form
    {
        Dictionary<string, string> nameDeviceIdpairs = new Dictionary<string, string>();

        public BluetoothPage()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private async void portNumberUpdateButton_Click(object sender, EventArgs e)
        {
            FreezeUI();
            await Task.Run(() => GetComPorts());
            portComboBox.DataSource = nameDeviceIdpairs.Keys.ToArray();
            MeltUI();
        }

        private void bluetoothConnectButton_Click(object sender, EventArgs e)
        {
            Constants.PREVCONMODE = Constants.CONNECT_MODE;
            Constants.CONNECT_MODE = Constants.BLUETOOTHMODE;
            Bluetooth.selectedPort = nameDeviceIdpairs[(string)portComboBox.SelectedValue];
            Bluetooth.BluetoothConnect();
        }

        public void GetComPorts()
        {
            nameDeviceIdpairs.Clear();
            ManagementObjectSearcher serialSearcher =
                new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_SerialPort");

            var query = from ManagementObject s in serialSearcher.Get()
                        select new { Name = s["Name"], DeviceID = s["DeviceID"], PNPDeviceID = s["PNPDeviceID"] }; // DeviceID -- > PNPDeviceID

            foreach (var port in query)
            {
                var pnpDeviceId = port.PNPDeviceID.ToString();

                if (pnpDeviceId.Contains("BTHENUM"))
                {
                    var bluetoothDeviceAddress = pnpDeviceId.Split('&')[4].Split('_')[0];
                    if (bluetoothDeviceAddress.Length == 12 && bluetoothDeviceAddress != "000000000000")
                    {
                        nameDeviceIdpairs.Add((string)port.Name, (string)port.DeviceID);
                    }
                }
            }
            if (nameDeviceIdpairs.Count == 0)
            {
                MessageBox.Show("이용 가능한 장치가 없습니다.");
                portComboBox.Text = "";
                return;
            }
        }

        public void FreezeUI()
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            portNumberUpdateButton.Enabled = false;
            bluetoothConnectButton.Enabled = false;
        }

        public void MeltUI()
        {
            progressBar.Visible = false;
            portNumberUpdateButton.Enabled = true;
            bluetoothConnectButton.Enabled = true;
        }


    }
}
