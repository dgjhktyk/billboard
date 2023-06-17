namespace GlassLED
{
    partial class PWChangePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.expwTextBox = new System.Windows.Forms.TextBox();
            this.newpwTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "기존 비밀번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "변경 비밀번호 :";
            // 
            // expwTextBox
            // 
            this.expwTextBox.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expwTextBox.Location = new System.Drawing.Point(159, 52);
            this.expwTextBox.Name = "expwTextBox";
            this.expwTextBox.Size = new System.Drawing.Size(223, 29);
            this.expwTextBox.TabIndex = 2;
            // 
            // newpwTextBox
            // 
            this.newpwTextBox.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newpwTextBox.Location = new System.Drawing.Point(159, 173);
            this.newpwTextBox.Name = "newpwTextBox";
            this.newpwTextBox.Size = new System.Drawing.Size(223, 29);
            this.newpwTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(115, 239);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(247, 45);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "확인";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // PWChangePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(470, 310);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.newpwTextBox);
            this.Controls.Add(this.expwTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PWChangePage";
            this.Text = "PWChangePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox expwTextBox;
        private System.Windows.Forms.TextBox newpwTextBox;
        private System.Windows.Forms.Button okButton;
    }
}