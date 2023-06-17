namespace GlassLED
{
    partial class BlossomOfSnowForm
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
            this.inputSnowVTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancellButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "[시간]";
            // 
            // inputSnowVTextBox
            // 
            this.inputSnowVTextBox.Location = new System.Drawing.Point(63, 42);
            this.inputSnowVTextBox.Name = "inputSnowVTextBox";
            this.inputSnowVTextBox.Size = new System.Drawing.Size(81, 21);
            this.inputSnowVTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(113, 134);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(110, 26);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "확인";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancellButton
            // 
            this.cancellButton.Location = new System.Drawing.Point(229, 134);
            this.cancellButton.Name = "cancellButton";
            this.cancellButton.Size = new System.Drawing.Size(110, 26);
            this.cancellButton.TabIndex = 3;
            this.cancellButton.Text = "취소";
            this.cancellButton.UseVisualStyleBackColor = true;
            this.cancellButton.Click += new System.EventHandler(this.cancellButton_Click);
            // 
            // BlossomOfSnowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 172);
            this.Controls.Add(this.cancellButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.inputSnowVTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BlossomOfSnowForm";
            this.Text = "눈꽃 속도 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputSnowVTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancellButton;
    }
}