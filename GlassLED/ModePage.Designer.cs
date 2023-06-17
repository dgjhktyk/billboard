namespace GlassLED
{
    partial class ModePage
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
            this.CurModeLabel = new System.Windows.Forms.Label();
            this.CurModeButton = new System.Windows.Forms.Button();
            this.ModeChangeButton = new System.Windows.Forms.Button();
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CurModeLabel
            // 
            this.CurModeLabel.AutoSize = true;
            this.CurModeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CurModeLabel.Location = new System.Drawing.Point(123, 94);
            this.CurModeLabel.Name = "CurModeLabel";
            this.CurModeLabel.Size = new System.Drawing.Size(0, 12);
            this.CurModeLabel.TabIndex = 7;
            // 
            // CurModeButton
            // 
            this.CurModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurModeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CurModeButton.Location = new System.Drawing.Point(272, 79);
            this.CurModeButton.Name = "CurModeButton";
            this.CurModeButton.Size = new System.Drawing.Size(82, 35);
            this.CurModeButton.TabIndex = 6;
            this.CurModeButton.Text = "현재 모드";
            this.CurModeButton.UseVisualStyleBackColor = true;
            this.CurModeButton.Click += new System.EventHandler(this.CurModeButton_Click);
            // 
            // ModeChangeButton
            // 
            this.ModeChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeChangeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ModeChangeButton.Location = new System.Drawing.Point(272, 38);
            this.ModeChangeButton.Name = "ModeChangeButton";
            this.ModeChangeButton.Size = new System.Drawing.Size(82, 35);
            this.ModeChangeButton.TabIndex = 5;
            this.ModeChangeButton.Text = "모드 변경";
            this.ModeChangeButton.UseVisualStyleBackColor = true;
            this.ModeChangeButton.Click += new System.EventHandler(this.ModeChangeButton_Click);
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeComboBox.Font = new System.Drawing.Font("굴림", 20F);
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Location = new System.Drawing.Point(12, 38);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(254, 35);
            this.ModeComboBox.TabIndex = 4;
            this.ModeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeComboBox_SelectedIndexChanged);
            // 
            // ModePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(874, 711);
            this.Controls.Add(this.CurModeLabel);
            this.Controls.Add(this.CurModeButton);
            this.Controls.Add(this.ModeChangeButton);
            this.Controls.Add(this.ModeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModePage";
            this.Text = "ModePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurModeLabel;
        private System.Windows.Forms.Button CurModeButton;
        private System.Windows.Forms.Button ModeChangeButton;
        private System.Windows.Forms.ComboBox ModeComboBox;
    }
}