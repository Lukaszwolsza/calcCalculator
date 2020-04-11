namespace calcCounter
{
    partial class copyrightsBox
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
            this.loginBoxExitButton = new System.Windows.Forms.Button();
            this.returnMainboxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBoxExitButton
            // 
            this.loginBoxExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.loginBoxExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.loginBoxExitButton.FlatAppearance.BorderSize = 0;
            this.loginBoxExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.loginBoxExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBoxExitButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBoxExitButton.Location = new System.Drawing.Point(515, 361);
            this.loginBoxExitButton.Name = "loginBoxExitButton";
            this.loginBoxExitButton.Size = new System.Drawing.Size(73, 27);
            this.loginBoxExitButton.TabIndex = 8;
            this.loginBoxExitButton.Text = "Exit";
            this.loginBoxExitButton.UseVisualStyleBackColor = false;
            this.loginBoxExitButton.Click += new System.EventHandler(this.loginBoxExitButton_Click);
            // 
            // returnMainboxButton
            // 
            this.returnMainboxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.returnMainboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMainboxButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnMainboxButton.ForeColor = System.Drawing.Color.White;
            this.returnMainboxButton.Location = new System.Drawing.Point(471, 291);
            this.returnMainboxButton.Name = "returnMainboxButton";
            this.returnMainboxButton.Size = new System.Drawing.Size(117, 55);
            this.returnMainboxButton.TabIndex = 15;
            this.returnMainboxButton.Text = "Return to mainbox";
            this.returnMainboxButton.UseVisualStyleBackColor = false;
            this.returnMainboxButton.Click += new System.EventHandler(this.returnMainboxButton_Click);
            // 
            // copyrightsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.returnMainboxButton);
            this.Controls.Add(this.loginBoxExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "copyrightsBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "copyrightsBox";
            this.Load += new System.EventHandler(this.copyrightsBox_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.copyrightsBox_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBoxExitButton;
        private System.Windows.Forms.Button returnMainboxButton;
    }
}