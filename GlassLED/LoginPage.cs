using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class LoginPage : Form
    {

        public static byte[] key = new byte[] { 66, 178, 206, 246, 134, 160, 101, 78, 20, 159, 118, 25, 49, 225, 145, 114, 177, 174, 206, 238, 186, 158, 153, 51, 89, 182, 243, 214, 187, 200, 156, 210 };
        public static byte[] iv = new byte[] { 151, 15, 177, 176, 64, 117, 139, 150, 239, 53, 33, 111, 54, 77, 219, 76 };



        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
        public static string file_path = path + @"\info.txt";
        PWChangePage pWChangePage;
        public static string PW = "";
        public LoginPage()
        {
            InitializeComponent();
            ReadFile();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (pwTextBox.Text == PW)
            {
                MainPage.mainPage.menuPanel.Dock = DockStyle.Left;
                MainPage.mainPage.pagePanel.Dock = DockStyle.Fill;
                this.Close();
            }
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
            }
        }

        private void pwChange_Click(object sender, EventArgs e)
        {
            pWChangePage = new PWChangePage();
            pWChangePage.Show();
        }

        public void ReadFile()
        {
            string StrByte;

            if (File.Exists(file_path))
            {
                StrByte = File.ReadAllText(file_path);
                PW = Encryption.GetDecryptedData(StrByte, key, iv);
            }
            else
            {
                PW = "admin";
                File.WriteAllText(file_path, Encryption.GetEncryptedData(PW, key, iv));
            }
        }

        private void LoginPage_Resize(object sender, EventArgs e)
        {

            Point center = new Point();
            center.X = Size.Width / 2 - pictureBox2.Width/2;
            center.Y = Size.Height / 2 - pictureBox2.Height/2 - 150;
            pictureBox2.Location = center;
            
        }
    
    }
}
