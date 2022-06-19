namespace CS_Live_Lecture_System
{
    partial class Form2
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BtnIExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnSignin = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 454);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(16, 121);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(385, 307);
            this.panel10.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "LOGIN";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.BtnIExit);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.CmbType);
            this.panel11.Controls.Add(this.TxtUsername);
            this.panel11.Controls.Add(this.TxtPassword);
            this.panel11.Controls.Add(this.BtnSignin);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(4, 25);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(373, 257);
            this.panel11.TabIndex = 0;
            // 
            // BtnIExit
            // 
            this.BtnIExit.Location = new System.Drawing.Point(225, 195);
            this.BtnIExit.Name = "BtnIExit";
            this.BtnIExit.Size = new System.Drawing.Size(118, 29);
            this.BtnIExit.TabIndex = 6;
            this.BtnIExit.Text = "Exit";
            this.BtnIExit.UseVisualStyleBackColor = true;
            this.BtnIExit.Click += new System.EventHandler(this.BtnIExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // CmbType
            // 
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.CmbType.Location = new System.Drawing.Point(184, 133);
            this.CmbType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(172, 24);
            this.CmbType.TabIndex = 4;
            this.CmbType.Text = "Select";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(184, 37);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(172, 22);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.Text = "Admin";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(184, 85);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(172, 22);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "Adminpass";
            // 
            // BtnSignin
            // 
            this.BtnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSignin.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignin.Location = new System.Drawing.Point(31, 195);
            this.BtnSignin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSignin.Name = "BtnSignin";
            this.BtnSignin.Size = new System.Drawing.Size(136, 29);
            this.BtnSignin.TabIndex = 3;
            this.BtnSignin.Text = "Sign in";
            this.BtnSignin.UseVisualStyleBackColor = true;
            this.BtnSignin.Click += new System.EventHandler(this.BtnSignin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "PASSWORD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "USERNAME";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(16, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 66);
            this.panel3.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 501);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnSignin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Button BtnIExit;
    }
}