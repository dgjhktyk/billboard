using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class PWChangePage : Form
    {
        public PWChangePage()
        {
            InitializeComponent();
        }
       

        private void okButton_Click(object sender, EventArgs e)
        {
            if(expwTextBox.Text == LoginPage.PW)
            {
                string pwd = newpwTextBox.Text;
                LoginPage.PW = pwd;
                File.WriteAllText(LoginPage.file_path, Encryption.GetEncryptedData(LoginPage.PW, LoginPage.key, LoginPage.iv));
                MessageBox.Show("변경 완료");
                this.Close();
            }
            else
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
            }
        }
    }
}
