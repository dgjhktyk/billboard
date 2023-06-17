namespace GlassLED
{
    partial class MainPage
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.modePageButton = new System.Windows.Forms.Button();
            this.locSettingPageButton = new System.Windows.Forms.Button();
            this.wifiPageButton = new System.Windows.Forms.Button();
            this.textPageButton = new System.Windows.Forms.Button();
            this.bluetoothConnectButton = new System.Windows.Forms.Button();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuPanel.Controls.Add(this.modePageButton);
            this.menuPanel.Controls.Add(this.locSettingPageButton);
            this.menuPanel.Controls.Add(this.wifiPageButton);
            this.menuPanel.Controls.Add(this.textPageButton);
            this.menuPanel.Controls.Add(this.bluetoothConnectButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(160, 711);
            this.menuPanel.TabIndex = 0;
            // 
            // modePageButton
            // 
            this.modePageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.modePageButton.FlatAppearance.BorderSize = 0;
            this.modePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modePageButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.modePageButton.Location = new System.Drawing.Point(0, 160);
            this.modePageButton.Name = "modePageButton";
            this.modePageButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.modePageButton.Size = new System.Drawing.Size(160, 40);
            this.modePageButton.TabIndex = 4;
            this.modePageButton.Text = "모드 변경";
            this.modePageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modePageButton.UseVisualStyleBackColor = true;
            this.modePageButton.Click += new System.EventHandler(this.modePageButton_Click);
            // 
            // locSettingPageButton
            // 
            this.locSettingPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.locSettingPageButton.FlatAppearance.BorderSize = 0;
            this.locSettingPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locSettingPageButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.locSettingPageButton.Location = new System.Drawing.Point(0, 120);
            this.locSettingPageButton.Name = "locSettingPageButton";
            this.locSettingPageButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.locSettingPageButton.Size = new System.Drawing.Size(160, 40);
            this.locSettingPageButton.TabIndex = 3;
            this.locSettingPageButton.Text = "위치 설정";
            this.locSettingPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locSettingPageButton.UseVisualStyleBackColor = true;
            this.locSettingPageButton.Click += new System.EventHandler(this.locSettingPageButton_Click);
            // 
            // wifiPageButton
            // 
            this.wifiPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.wifiPageButton.FlatAppearance.BorderSize = 0;
            this.wifiPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wifiPageButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.wifiPageButton.Location = new System.Drawing.Point(0, 80);
            this.wifiPageButton.Name = "wifiPageButton";
            this.wifiPageButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.wifiPageButton.Size = new System.Drawing.Size(160, 40);
            this.wifiPageButton.TabIndex = 2;
            this.wifiPageButton.Text = "와이파이";
            this.wifiPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wifiPageButton.UseVisualStyleBackColor = true;
            this.wifiPageButton.Click += new System.EventHandler(this.wifiPageButton_Click);
            // 
            // textPageButton
            // 
            this.textPageButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.textPageButton.FlatAppearance.BorderSize = 0;
            this.textPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textPageButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textPageButton.Location = new System.Drawing.Point(0, 40);
            this.textPageButton.Name = "textPageButton";
            this.textPageButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.textPageButton.Size = new System.Drawing.Size(160, 40);
            this.textPageButton.TabIndex = 1;
            this.textPageButton.Text = "텍스트";
            this.textPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textPageButton.UseVisualStyleBackColor = true;
            this.textPageButton.Click += new System.EventHandler(this.textPageButton_Click);
            // 
            // bluetoothConnectButton
            // 
            this.bluetoothConnectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bluetoothConnectButton.FlatAppearance.BorderSize = 0;
            this.bluetoothConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bluetoothConnectButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bluetoothConnectButton.Location = new System.Drawing.Point(0, 0);
            this.bluetoothConnectButton.Name = "bluetoothConnectButton";
            this.bluetoothConnectButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bluetoothConnectButton.Size = new System.Drawing.Size(160, 40);
            this.bluetoothConnectButton.TabIndex = 0;
            this.bluetoothConnectButton.Text = "블루투스";
            this.bluetoothConnectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bluetoothConnectButton.UseVisualStyleBackColor = true;
            this.bluetoothConnectButton.Click += new System.EventHandler(this.bluetoothConnectButton_Click);
            // 
            // pagePanel
            // 
            this.pagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pagePanel.Location = new System.Drawing.Point(160, 0);
            this.pagePanel.MinimumSize = new System.Drawing.Size(874, 651);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(874, 711);
            this.pagePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pagePanel);
            this.panel1.Controls.Add(this.menuPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 711);
            this.panel1.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 711);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1050, 690);
            this.Name = "MainPage";
            this.Text = "P2SG GLASS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button modePageButton;
        private System.Windows.Forms.Button locSettingPageButton;
        private System.Windows.Forms.Button wifiPageButton;
        private System.Windows.Forms.Button textPageButton;
        private System.Windows.Forms.Button bluetoothConnectButton;
        public System.Windows.Forms.Panel pagePanel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel menuPanel;
    }
}