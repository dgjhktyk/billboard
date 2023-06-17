namespace GlassLED
{
    partial class BorderEffectInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.blinkTimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedColorButton = new System.Windows.Forms.Button();
            this.blackColorButton = new System.Windows.Forms.Button();
            this.redColorButton = new System.Windows.Forms.Button();
            this.yellowColorButton = new System.Windows.Forms.Button();
            this.greenColorButton = new System.Windows.Forms.Button();
            this.blueColorButton = new System.Windows.Forms.Button();
            this.purpleColorButton = new System.Windows.Forms.Button();
            this.whiteColorButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "[깜빡거리는 시간]";
            // 
            // blinkTimeInput
            // 
            this.blinkTimeInput.Location = new System.Drawing.Point(118, 143);
            this.blinkTimeInput.Name = "blinkTimeInput";
            this.blinkTimeInput.Size = new System.Drawing.Size(78, 21);
            this.blinkTimeInput.TabIndex = 1;
            this.blinkTimeInput.Text = "500";
            this.blinkTimeInput.TextChanged += new System.EventHandler(this.blinkTimeInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "(단위 ms, 1000ms = 1초)";
            // 
            // selectedColorButton
            // 
            this.selectedColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectedColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedColorButton.Location = new System.Drawing.Point(12, 34);
            this.selectedColorButton.Name = "selectedColorButton";
            this.selectedColorButton.Size = new System.Drawing.Size(21, 24);
            this.selectedColorButton.TabIndex = 5;
            this.selectedColorButton.UseVisualStyleBackColor = true;
            // 
            // blackColorButton
            // 
            this.blackColorButton.BackColor = System.Drawing.Color.Black;
            this.blackColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackColorButton.Location = new System.Drawing.Point(6, 12);
            this.blackColorButton.Name = "blackColorButton";
            this.blackColorButton.Size = new System.Drawing.Size(21, 24);
            this.blackColorButton.TabIndex = 6;
            this.blackColorButton.UseVisualStyleBackColor = false;
            this.blackColorButton.Click += new System.EventHandler(this.blackColorButton_Click);
            // 
            // redColorButton
            // 
            this.redColorButton.BackColor = System.Drawing.Color.Red;
            this.redColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redColorButton.Location = new System.Drawing.Point(33, 12);
            this.redColorButton.Name = "redColorButton";
            this.redColorButton.Size = new System.Drawing.Size(21, 24);
            this.redColorButton.TabIndex = 7;
            this.redColorButton.UseVisualStyleBackColor = false;
            this.redColorButton.Click += new System.EventHandler(this.redColorButton_Click);
            // 
            // yellowColorButton
            // 
            this.yellowColorButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowColorButton.Location = new System.Drawing.Point(60, 12);
            this.yellowColorButton.Name = "yellowColorButton";
            this.yellowColorButton.Size = new System.Drawing.Size(21, 24);
            this.yellowColorButton.TabIndex = 8;
            this.yellowColorButton.UseVisualStyleBackColor = false;
            this.yellowColorButton.Click += new System.EventHandler(this.yellowColorButton_Click);
            // 
            // greenColorButton
            // 
            this.greenColorButton.BackColor = System.Drawing.Color.Lime;
            this.greenColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenColorButton.Location = new System.Drawing.Point(87, 12);
            this.greenColorButton.Name = "greenColorButton";
            this.greenColorButton.Size = new System.Drawing.Size(21, 24);
            this.greenColorButton.TabIndex = 9;
            this.greenColorButton.UseVisualStyleBackColor = false;
            this.greenColorButton.Click += new System.EventHandler(this.greenColorButton_Click);
            // 
            // blueColorButton
            // 
            this.blueColorButton.BackColor = System.Drawing.Color.Blue;
            this.blueColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueColorButton.Location = new System.Drawing.Point(114, 12);
            this.blueColorButton.Name = "blueColorButton";
            this.blueColorButton.Size = new System.Drawing.Size(21, 24);
            this.blueColorButton.TabIndex = 10;
            this.blueColorButton.UseVisualStyleBackColor = false;
            this.blueColorButton.Click += new System.EventHandler(this.blueColorButton_Click);
            // 
            // purpleColorButton
            // 
            this.purpleColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.purpleColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.purpleColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleColorButton.Location = new System.Drawing.Point(141, 12);
            this.purpleColorButton.Name = "purpleColorButton";
            this.purpleColorButton.Size = new System.Drawing.Size(21, 24);
            this.purpleColorButton.TabIndex = 11;
            this.purpleColorButton.UseVisualStyleBackColor = false;
            this.purpleColorButton.Click += new System.EventHandler(this.purpleColorButton_Click);
            // 
            // whiteColorButton
            // 
            this.whiteColorButton.BackColor = System.Drawing.Color.White;
            this.whiteColorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whiteColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whiteColorButton.Location = new System.Drawing.Point(168, 12);
            this.whiteColorButton.Name = "whiteColorButton";
            this.whiteColorButton.Size = new System.Drawing.Size(21, 24);
            this.whiteColorButton.TabIndex = 12;
            this.whiteColorButton.UseVisualStyleBackColor = false;
            this.whiteColorButton.Click += new System.EventHandler(this.whiteColorButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.whiteColorButton);
            this.groupBox1.Controls.Add(this.purpleColorButton);
            this.groupBox1.Controls.Add(this.blueColorButton);
            this.groupBox1.Controls.Add(this.greenColorButton);
            this.groupBox1.Controls.Add(this.yellowColorButton);
            this.groupBox1.Controls.Add(this.redColorButton);
            this.groupBox1.Controls.Add(this.blackColorButton);
            this.groupBox1.Location = new System.Drawing.Point(51, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 52);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "색 선택";
            // 
            // BorderEffectInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectedColorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.blinkTimeInput);
            this.Controls.Add(this.label1);
            this.Name = "BorderEffectInputForm";
            this.Text = "테두리 효과 설정";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blinkTimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectedColorButton;
        private System.Windows.Forms.Button blackColorButton;
        private System.Windows.Forms.Button redColorButton;
        private System.Windows.Forms.Button yellowColorButton;
        private System.Windows.Forms.Button greenColorButton;
        private System.Windows.Forms.Button blueColorButton;
        private System.Windows.Forms.Button purpleColorButton;
        private System.Windows.Forms.Button whiteColorButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}