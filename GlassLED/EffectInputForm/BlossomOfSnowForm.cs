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
    public partial class BlossomOfSnowForm : Form
    {
        public static short inputSnowV = 0;
        private TextPage textPage;

        public BlossomOfSnowForm(TextPage textPage)
        {
            InitializeComponent();
            this.textPage = textPage;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int curSnowV = 0;
            try
            {
                curSnowV = int.Parse(inputSnowVTextBox.Text as String);
                if(curSnowV < 0 || curSnowV > 65535)
                {
                    MessageBox.Show("0 ~ 65535 이하의 수를 입력하세요");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("숫자만 입력하세요");
                return;
            }
            inputSnowV = (short)curSnowV;

            this.Close();
        }

        private void cancellButton_Click(object sender, EventArgs e)
        {
            inputSnowV = 0;
            TextPage.effectUse[2] = false;
            textPage.thridEffectButton.BackgroundImage = Properties.Resources.effect2;
            this.Close();
        }
    }
}
