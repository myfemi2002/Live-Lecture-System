namespace CS_Live_Lecture_System
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStudentHompage = new System.Windows.Forms.Button();
            this.BtnRegistedStudents = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnResetAll = new System.Windows.Forms.Button();
            this.CmbSelect = new System.Windows.Forms.ComboBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.BtnStudentHompage);
            this.panel7.Controls.Add(this.BtnRegistedStudents);
            this.panel7.Location = new System.Drawing.Point(12, 14);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1322, 63);
            this.panel7.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lecture\'s  Live Broadcast";
            // 
            // BtnStudentHompage
            // 
            this.BtnStudentHompage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnStudentHompage.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentHompage.Location = new System.Drawing.Point(1098, 3);
            this.BtnStudentHompage.Name = "BtnStudentHompage";
            this.BtnStudentHompage.Size = new System.Drawing.Size(188, 52);
            this.BtnStudentHompage.TabIndex = 12;
            this.BtnStudentHompage.Text = "Student Homepage";
            this.BtnStudentHompage.UseVisualStyleBackColor = false;
            this.BtnStudentHompage.Click += new System.EventHandler(this.BtnStudentHompage_Click);
            // 
            // BtnRegistedStudents
            // 
            this.BtnRegistedStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistedStudents.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistedStudents.Location = new System.Drawing.Point(46, 3);
            this.BtnRegistedStudents.Name = "BtnRegistedStudents";
            this.BtnRegistedStudents.Size = new System.Drawing.Size(216, 53);
            this.BtnRegistedStudents.TabIndex = 0;
            this.BtnRegistedStudents.Text = "No of Registered Students";
            this.BtnRegistedStudents.UseVisualStyleBackColor = false;
            this.BtnRegistedStudents.Click += new System.EventHandler(this.BtnRegistedStudents_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 633);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.BtnCapture);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnPause);
            this.panel1.Controls.Add(this.BtnResetAll);
            this.panel1.Controls.Add(this.CmbSelect);
            this.panel1.Controls.Add(this.BtnStart);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 535);
            this.panel1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(974, 488);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(491, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 478);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCapture
            // 
            this.BtnCapture.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapture.Location = new System.Drawing.Point(474, 6);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(99, 23);
            this.BtnCapture.TabIndex = 20;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(894, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(94, 23);
            this.BtnExit.TabIndex = 20;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPause.Location = new System.Drawing.Point(367, 5);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(101, 23);
            this.BtnPause.TabIndex = 20;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnResetAll
            // 
            this.BtnResetAll.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetAll.Location = new System.Drawing.Point(246, 6);
            this.BtnResetAll.Name = "BtnResetAll";
            this.BtnResetAll.Size = new System.Drawing.Size(115, 23);
            this.BtnResetAll.TabIndex = 20;
            this.BtnResetAll.Text = "Reset All";
            this.BtnResetAll.UseVisualStyleBackColor = true;
            this.BtnResetAll.Click += new System.EventHandler(this.BtnResetAll_Click);
            // 
            // CmbSelect
            // 
            this.CmbSelect.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSelect.FormattingEnabled = true;
            this.CmbSelect.Location = new System.Drawing.Point(119, 6);
            this.CmbSelect.Name = "CmbSelect";
            this.CmbSelect.Size = new System.Drawing.Size(121, 22);
            this.CmbSelect.TabIndex = 19;
            this.CmbSelect.Text = "Select";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(14, 6);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(77, 23);
            this.BtnStart.TabIndex = 18;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Location = new System.Drawing.Point(994, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 520);
            this.panel3.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(208, 326);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(105, 186);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "D2021\nD2011\nD2018\nD2011\nD2001\nD2021\nD2011\nD2018\nD2011\nD2001";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 16);
            this.panel4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Student Online";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 326);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 186);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(317, 295);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 656);
            this.Controls.Add(this.panel2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture\'s  Live Broadcast";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnRegistedStudents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button BtnStudentHompage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnResetAll;
        private System.Windows.Forms.ComboBox CmbSelect;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}