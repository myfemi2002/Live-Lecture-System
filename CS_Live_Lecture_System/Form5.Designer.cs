namespace CS_Live_Lecture_System
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPreviousVideo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPauseStudent = new System.Windows.Forms.Button();
            this.BtnResetAllstudent = new System.Windows.Forms.Button();
            this.CmbSelect = new System.Windows.Forms.ComboBox();
            this.BtnStartstudent = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1326, 608);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 587);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel3.Location = new System.Drawing.Point(12, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1297, 484);
            this.panel3.TabIndex = 16;
            // 
            // BtnPause
            // 
            this.BtnPause.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPause.Image = global::CS_Live_Lecture_System.Properties.Resources.Uiconstock_Classy_Media_Pause;
            this.BtnPause.Location = new System.Drawing.Point(75, -2);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(32, 30);
            this.BtnPause.TabIndex = 22;
            this.BtnPause.UseVisualStyleBackColor = false;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStop.Image = global::CS_Live_Lecture_System.Properties.Resources.Uiconstock_Classy_Media_Stop;
            this.BtnStop.Location = new System.Drawing.Point(37, 0);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(32, 30);
            this.BtnStop.TabIndex = 21;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPlay.Image = global::CS_Live_Lecture_System.Properties.Resources.Uiconstock_Classy_Media_Play;
            this.BtnPlay.Location = new System.Drawing.Point(-2, -3);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(32, 33);
            this.BtnPlay.TabIndex = 20;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.BtnExit);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(12, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1292, 63);
            this.panel6.TabIndex = 4;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(1179, 11);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(60, 41);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPreviousVideo
            // 
            this.BtnPreviousVideo.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousVideo.Location = new System.Drawing.Point(-2, -2);
            this.BtnPreviousVideo.Name = "BtnPreviousVideo";
            this.BtnPreviousVideo.Size = new System.Drawing.Size(354, 41);
            this.BtnPreviousVideo.TabIndex = 7;
            this.BtnPreviousVideo.Text = "Watch Previous Lectures";
            this.BtnPreviousVideo.UseVisualStyleBackColor = true;
            this.BtnPreviousVideo.Click += new System.EventHandler(this.BtnPreviousVideo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student HomePage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Online Student";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(936, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(354, 316);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.BtnPause);
            this.panel7.Controls.Add(this.BtnPlay);
            this.panel7.Controls.Add(this.BtnStop);
            this.panel7.Location = new System.Drawing.Point(936, 289);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(109, 30);
            this.panel7.TabIndex = 18;
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(-2, 32);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(354, 113);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(3, 388);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(181, 16);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.BtnPreviousVideo);
            this.panel4.Controls.Add(this.listView);
            this.panel4.Location = new System.Drawing.Point(936, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 152);
            this.panel4.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 437);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // BtnPauseStudent
            // 
            this.BtnPauseStudent.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPauseStudent.Location = new System.Drawing.Point(530, 3);
            this.BtnPauseStudent.Name = "BtnPauseStudent";
            this.BtnPauseStudent.Size = new System.Drawing.Size(87, 22);
            this.BtnPauseStudent.TabIndex = 26;
            this.BtnPauseStudent.Text = "Pause";
            this.BtnPauseStudent.UseVisualStyleBackColor = true;
            this.BtnPauseStudent.Click += new System.EventHandler(this.BtnPauseStudent_Click);
            // 
            // BtnResetAllstudent
            // 
            this.BtnResetAllstudent.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetAllstudent.Location = new System.Drawing.Point(419, 3);
            this.BtnResetAllstudent.Name = "BtnResetAllstudent";
            this.BtnResetAllstudent.Size = new System.Drawing.Size(84, 22);
            this.BtnResetAllstudent.TabIndex = 27;
            this.BtnResetAllstudent.Text = "Reset All";
            this.BtnResetAllstudent.UseVisualStyleBackColor = true;
            this.BtnResetAllstudent.Click += new System.EventHandler(this.BtnResetAllstudent_Click);
            // 
            // CmbSelect
            // 
            this.CmbSelect.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSelect.FormattingEnabled = true;
            this.CmbSelect.Location = new System.Drawing.Point(177, 3);
            this.CmbSelect.Name = "CmbSelect";
            this.CmbSelect.Size = new System.Drawing.Size(194, 22);
            this.CmbSelect.TabIndex = 23;
            this.CmbSelect.Text = "Select";
            // 
            // BtnStartstudent
            // 
            this.BtnStartstudent.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartstudent.Location = new System.Drawing.Point(41, 2);
            this.BtnStartstudent.Name = "BtnStartstudent";
            this.BtnStartstudent.Size = new System.Drawing.Size(69, 22);
            this.BtnStartstudent.TabIndex = 22;
            this.BtnStartstudent.Text = "Start";
            this.BtnStartstudent.UseVisualStyleBackColor = true;
            this.BtnStartstudent.Click += new System.EventHandler(this.BtnStartstudent_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.BtnStartstudent);
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Controls.Add(this.CmbSelect);
            this.panel8.Controls.Add(this.BtnResetAllstudent);
            this.panel8.Controls.Add(this.BtnPauseStudent);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(932, 474);
            this.panel8.TabIndex = 29;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(5, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(906, 427);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 633);
            this.Controls.Add(this.panel2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student HomePage";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnPreviousVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnStartstudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CmbSelect;
        private System.Windows.Forms.Button BtnResetAllstudent;
        private System.Windows.Forms.Button BtnPauseStudent;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}