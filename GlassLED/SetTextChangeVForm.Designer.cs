namespace GlassLED
{
    partial class SetTextChangeVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeVCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // changeVCombo
            // 
            this.changeVCombo.FormattingEnabled = true;
            this.changeVCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.changeVCombo.Location = new System.Drawing.Point(23, 36);
            this.changeVCombo.Name = "changeVCombo";
            this.changeVCombo.Size = new System.Drawing.Size(255, 20);
            this.changeVCombo.TabIndex = 0;
            this.changeVCombo.SelectedIndexChanged += new System.EventHandler(this.changeVCombo_SelectedIndexChanged);
            // 
            // SetTextChangeVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 106);
            this.Controls.Add(this.changeVCombo);
            this.Name = "SetTextChangeVForm";
            this.Text = "텍스트 색상 변경 속도 설정";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox changeVCombo;
    }
}