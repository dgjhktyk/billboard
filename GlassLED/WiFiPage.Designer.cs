namespace GlassLED
{
    partial class WiFiPage
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
            this.UpdateMacAddrButton = new System.Windows.Forms.Button();
            this.ShowingMacAddrLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WiFiModeStartButton = new System.Windows.Forms.Button();
            this.WiFiRegButton = new System.Windows.Forms.Button();
            this.WiFiPWInputTextBox = new System.Windows.Forms.TextBox();
            this.WiFiNameInputTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateMacAddrButton
            // 
            this.UpdateMacAddrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateMacAddrButton.Location = new System.Drawing.Point(12, 537);
            this.UpdateMacAddrButton.Name = "UpdateMacAddrButton";
            this.UpdateMacAddrButton.Size = new System.Drawing.Size(586, 43);
            this.UpdateMacAddrButton.TabIndex = 17;
            this.UpdateMacAddrButton.Text = "Mac주소 가져오기";
            this.UpdateMacAddrButton.UseVisualStyleBackColor = true;
            this.UpdateMacAddrButton.Click += new System.EventHandler(this.UpdateMacAddrButton_Click);
            // 
            // ShowingMacAddrLabel
            // 
            this.ShowingMacAddrLabel.AutoSize = true;
            this.ShowingMacAddrLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ShowingMacAddrLabel.Location = new System.Drawing.Point(110, 514);
            this.ShowingMacAddrLabel.Name = "ShowingMacAddrLabel";
            this.ShowingMacAddrLabel.Size = new System.Drawing.Size(0, 12);
            this.ShowingMacAddrLabel.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(10, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "장치 Mac 주소 :";
            // 
            // WiFiModeStartButton
            // 
            this.WiFiModeStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WiFiModeStartButton.Location = new System.Drawing.Point(12, 348);
            this.WiFiModeStartButton.Name = "WiFiModeStartButton";
            this.WiFiModeStartButton.Size = new System.Drawing.Size(586, 66);
            this.WiFiModeStartButton.TabIndex = 14;
            this.WiFiModeStartButton.Text = "WiFi 모드 시작";
            this.WiFiModeStartButton.UseVisualStyleBackColor = true;
            this.WiFiModeStartButton.Click += new System.EventHandler(this.WiFiModeStartButton_Click);
            // 
            // WiFiRegButton
            // 
            this.WiFiRegButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WiFiRegButton.Location = new System.Drawing.Point(12, 276);
            this.WiFiRegButton.Name = "WiFiRegButton";
            this.WiFiRegButton.Size = new System.Drawing.Size(586, 66);
            this.WiFiRegButton.TabIndex = 13;
            this.WiFiRegButton.Text = "WiFi 등록";
            this.WiFiRegButton.UseVisualStyleBackColor = true;
            this.WiFiRegButton.Click += new System.EventHandler(this.WiFiRegButton_Click);
            // 
            // WiFiPWInputTextBox
            // 
            this.WiFiPWInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WiFiPWInputTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.WiFiPWInputTextBox.Location = new System.Drawing.Point(96, 108);
            this.WiFiPWInputTextBox.Name = "WiFiPWInputTextBox";
            this.WiFiPWInputTextBox.Size = new System.Drawing.Size(502, 30);
            this.WiFiPWInputTextBox.TabIndex = 12;
            // 
            // WiFiNameInputTextBox
            // 
            this.WiFiNameInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WiFiNameInputTextBox.Font = new System.Drawing.Font("굴림", 15F);
            this.WiFiNameInputTextBox.Location = new System.Drawing.Point(96, 58);
            this.WiFiNameInputTextBox.Name = "WiFiNameInputTextBox";
            this.WiFiNameInputTextBox.Size = new System.Drawing.Size(502, 30);
            this.WiFiNameInputTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "WiFi PW   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "WiFi 이름 :";
            // 
            // WiFiPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(874, 711);
            this.Controls.Add(this.UpdateMacAddrButton);
            this.Controls.Add(this.ShowingMacAddrLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WiFiModeStartButton);
            this.Controls.Add(this.WiFiRegButton);
            this.Controls.Add(this.WiFiPWInputTextBox);
            this.Controls.Add(this.WiFiNameInputTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WiFiPage";
            this.Text = "WiFiPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateMacAddrButton;
        private System.Windows.Forms.Label ShowingMacAddrLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button WiFiModeStartButton;
        private System.Windows.Forms.Button WiFiRegButton;
        private System.Windows.Forms.TextBox WiFiPWInputTextBox;
        private System.Windows.Forms.TextBox WiFiNameInputTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}