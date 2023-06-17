namespace GlassLED
{
    partial class BluetoothPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bluetoothConnectButton = new System.Windows.Forms.Button();
            this.portNumberUpdateButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.bluetoothConnectButton);
            this.panel1.Controls.Add(this.portNumberUpdateButton);
            this.panel1.Controls.Add(this.portComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 711);
            this.panel1.TabIndex = 4;
            // 
            // bluetoothConnectButton
            // 
            this.bluetoothConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bluetoothConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluetoothConnectButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bluetoothConnectButton.Location = new System.Drawing.Point(415, 126);
            this.bluetoothConnectButton.Name = "bluetoothConnectButton";
            this.bluetoothConnectButton.Size = new System.Drawing.Size(114, 49);
            this.bluetoothConnectButton.TabIndex = 6;
            this.bluetoothConnectButton.Text = "연결";
            this.bluetoothConnectButton.UseVisualStyleBackColor = true;
            this.bluetoothConnectButton.Click += new System.EventHandler(this.bluetoothConnectButton_Click);
            // 
            // portNumberUpdateButton
            // 
            this.portNumberUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portNumberUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.portNumberUpdateButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.portNumberUpdateButton.Location = new System.Drawing.Point(415, 71);
            this.portNumberUpdateButton.Name = "portNumberUpdateButton";
            this.portNumberUpdateButton.Size = new System.Drawing.Size(114, 49);
            this.portNumberUpdateButton.TabIndex = 5;
            this.portNumberUpdateButton.Text = "포트 목록 갱신";
            this.portNumberUpdateButton.UseVisualStyleBackColor = true;
            this.portNumberUpdateButton.Click += new System.EventHandler(this.portNumberUpdateButton_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portComboBox.Font = new System.Drawing.Font("굴림", 13F);
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(12, 71);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(397, 25);
            this.portComboBox.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 676);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(850, 23);
            this.progressBar.TabIndex = 7;
            // 
            // BluetoothPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(874, 711);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BluetoothPage";
            this.Text = "BluetoothPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bluetoothConnectButton;
        private System.Windows.Forms.Button portNumberUpdateButton;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}