using System;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class TextColorChangeSpeedForm : Form
    {
        public static string selectedV = "1";
        private TextPage textPage;


        public TextColorChangeSpeedForm(TextPage textPage)
        {
            InitializeComponent();
            this.textPage = textPage;
        }

        private void changeVCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedV = changeVCombo.SelectedItem as string;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancellButton_Click(object sender, EventArgs e)
        {
            selectedV = "0";
            TextPage.effectUse[1] = false;
            textPage.seccondEffectButton.BackgroundImage = Properties.Resources.effect1;
            this.Close();
        }
    }
}
