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
    public partial class BorderEffectInputForm : Form
    {
        public static byte r = 255;
        public static byte g = 255;
        public static byte b = 255;
        public static short blinkTime = 500;
        private TextPage textPage;

        public BorderEffectInputForm(TextPage textPage)
        {
            InitializeComponent();
            this.textPage = textPage;
        }



        private void blackColorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = blackColorButton.BackColor;
            r = 0;
            g = 0;
            b = 0;
        }

        private void redColorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = redColorButton.BackColor;
            r = 255;
            g = 0;
            b = 0;
        }

        private void yellowColorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = yellowColorButton.BackColor;
            r = 255;
            g = 255;
            b = 0;
        }

        private void greenColorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = greenColorButton.BackColor;
            r = 0;
            g = 255;
            b = 0;
        }

        private void blueColorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = blueColorButton.BackColor;
            r = 0;
            g = 0;
            b = 255;
        }

        private void purpleColorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = purpleColorButton.BackColor;
            r = 128;
            g = 0;
            b = 128;
        }

        private void whiteColorButton_Click(object sender, EventArgs e)
        {
            selectedColorButton.BackColor = whiteColorButton.BackColor;
            r = 255;
            g = 255;
            b = 255;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int curbt;
            try
            {
                curbt = int.Parse(blinkTimeInput.Text);
            }
            catch
            {
                MessageBox.Show("숫자만 입력하세요");
                return;
            }

            if (curbt > 65535 || curbt < 0)
            {
                MessageBox.Show("0 ~ 65535 이하의 수를 입력하세요");
                return;
            }

            blinkTime = (short)curbt;

            this.Close();
        }

        private void cancellButton_Click(object sender, EventArgs e)
        {
            r = 0;
            g = 0;
            b = 0;
            blinkTime = 500;
            TextPage.effectUse[0] = false;
            textPage.firstEffectButton.BackgroundImage = Properties.Resources.effect0;
            this.Close();
        }
    }
}
