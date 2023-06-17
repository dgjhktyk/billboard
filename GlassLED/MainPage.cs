using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class MainPage : Form
    {
        public static MainPage mainPage;
        private Form activeForm = null;
        LoginPage loginPage = new LoginPage();
        public MainPage()
        {
            InitializeComponent();
            mainPage = this;

            openChildForm(loginPage);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            if(childForm == loginPage)
            {
                panel1.Controls.Add(childForm);
                panel1.Tag = childForm;
            }
            else
            {
                pagePanel.Controls.Add(childForm);
                pagePanel.Tag = childForm;
            }
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName == "GlassLED")
                {
                    process.Kill();
                }
            }
        }

        private void bluetoothConnectButton_Click(object sender, EventArgs e)
        {
            openChildForm(new BluetoothPage());
        }

        private void textPageButton_Click(object sender, EventArgs e)
        {
            openChildForm(new TextPage());

        }

        private void wifiPageButton_Click(object sender, EventArgs e)
        {
            openChildForm(new WiFiPage());

        }

        private void locSettingPageButton_Click(object sender, EventArgs e)
        {
            openChildForm(new LocationSettingPage());

        }

        private void modePageButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ModePage());

        }


        //[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        //protected override void WndProc(ref Message m)
        //{
        //    // Listen for operating system messages.
        //    switch (m.Msg)
        //    {
        //        // The WM_ACTIVATEAPP message occurs when the application
        //        // becomes the active application or becomes inactive.
        //        case 0x0007:
        //            MessageBox.Show("0x0007");
        //            break;
        //        case 0x0017:
        //            MessageBox.Show("0x0017");
        //            break;
        //        case 0x0018:
        //            MessageBox.Show("0x0018");
        //            break;
        //        case 0x0019:
        //            MessageBox.Show("0x0019");
        //            break;
        //        case 0x8000:
        //            MessageBox.Show("0x8000");
        //            break;
        //        case 0x8001:
        //            MessageBox.Show("0x8001");
        //            break;
        //        case 0x8002:
        //            MessageBox.Show("0x8002");
        //            break;
        //        case 0x8003:
        //            MessageBox.Show("0x8003");
        //            break;
        //        case 0x8004:
        //            MessageBox.Show("0x8004");
        //            break;
        //        case 0x8005:
        //            MessageBox.Show("0x8005");
        //            break;
        //        case 0x8006:
        //            MessageBox.Show("0x8006");
        //            break;
        //        case 0xFFFF:
        //            MessageBox.Show("0xFFFF");
        //            break;
        //    }
        //    base.WndProc(ref m);
        //}
    }
}
