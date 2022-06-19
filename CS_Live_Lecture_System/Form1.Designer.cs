namespace CS_Live_Lecture_System
{
    partial class Form1
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
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonEnter.Location = new System.Drawing.Point(991, 372);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(174, 67);
            this.ButtonEnter.TabIndex = 0;
            this.ButtonEnter.Text = "Enter";
            this.ButtonEnter.UseVisualStyleBackColor = false;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(253, 57);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(723, 24);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Design And Implementation Of Lecture Delivery System Using Streaming Computing";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(449, 297);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(285, 24);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "The Oke-Ogun  Polytechnic,Saki";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(449, 218);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(296, 24);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Department of Computer Science";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(471, 133);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(208, 24);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Amodu Sodiq Ademola";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS_Live_Lecture_System.Properties.Resources.Oke_Ogun_1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1199, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ButtonEnter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnter;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

