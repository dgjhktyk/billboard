using System;
using System.Windows.Forms;

namespace GlassLED
{
    public partial class SetTextChangeVForm : Form
    {
        public static string selectedV = "";

        public SetTextChangeVForm()
        {
            InitializeComponent();
        }

        private void changeVCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedV = changeVCombo.SelectedItem as string;
        }
    }
}
