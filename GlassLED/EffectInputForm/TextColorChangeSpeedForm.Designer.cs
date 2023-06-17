namespace GlassLED
{
    partial class TextColorChangeSpeedForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancellButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeVCombo
            // 
            this.changeVCombo.FormattingEnabled = true;
            this.changeVCombo.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.changeVCombo.Location = new System.Drawing.Point(23, 36);
            this.changeVCombo.Name = "changeVCombo";
            this.changeVCombo.Size = new System.Drawing.Size(255, 20);
            this.changeVCombo.TabIndex = 0;
            this.changeVCombo.SelectedIndexChanged += new System.EventHandler(this.changeVCombo_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(101, 77);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(95, 24);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "확인";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancellButton
            // 
            this.cancellButton.Location = new System.Drawing.Point(202, 77);
            this.cancellButton.Name = "cancellButton";
            this.cancellButton.Size = new System.Drawing.Size(95, 24);
            this.cancellButton.TabIndex = 2;
            this.cancellButton.Text = "취소";
            this.cancellButton.UseVisualStyleBackColor = true;
            this.cancellButton.Click += new System.EventHandler(this.cancellButton_Click);
            // 
            // TextColorChangeSpeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 113);
            this.Controls.Add(this.cancellButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.changeVCombo);
            this.Name = "TextColorChangeSpeedForm";
            this.Text = "텍스트 색상 변경 속도 설정";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox changeVCombo;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancellButton;
    }
}