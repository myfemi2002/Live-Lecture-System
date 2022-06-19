namespace CS_Live_Lecture_System
{
    partial class Form3
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgVStudent = new System.Windows.Forms.DataGridView();
            this.dgStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAcademicProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAcademicyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.CmbSemester = new System.Windows.Forms.ComboBox();
            this.CmbAcademicyear = new System.Windows.Forms.ComboBox();
            this.AcademicProgram = new System.Windows.Forms.Label();
            this.CmbAcademicProgram = new System.Windows.Forms.ComboBox();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtStudentNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Academicyear = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnStudentHompages = new System.Windows.Forms.Button();
            this.BtnLectureBroadcast = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRegistedStudents = new System.Windows.Forms.Button();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVStudent)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel);
            this.panel2.Location = new System.Drawing.Point(1, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 584);
            this.panel2.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.CmbGender);
            this.panel.Controls.Add(this.TxtPhone);
            this.panel.Controls.Add(this.dateTimePicker1);
            this.panel.Controls.Add(this.BtnCancel);
            this.panel.Controls.Add(this.BtnExit);
            this.panel.Controls.Add(this.BtnDelete);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.BtnSave);
            this.panel.Controls.Add(this.Gender);
            this.panel.Controls.Add(this.DOB);
            this.panel.Controls.Add(this.Semester);
            this.panel.Controls.Add(this.CmbSemester);
            this.panel.Controls.Add(this.CmbAcademicyear);
            this.panel.Controls.Add(this.AcademicProgram);
            this.panel.Controls.Add(this.CmbAcademicProgram);
            this.panel.Controls.Add(this.CmbDepartment);
            this.panel.Controls.Add(this.TxtSurname);
            this.panel.Controls.Add(this.TxtFirstName);
            this.panel.Controls.Add(this.TxtStudentNumber);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.Department);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.Academicyear);
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.PhoneNo);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1088, 571);
            this.panel.TabIndex = 10;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Select",
            "Male",
            "Female"});
            this.CmbGender.Location = new System.Drawing.Point(496, 74);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(181, 24);
            this.CmbGender.TabIndex = 76;
            this.CmbGender.Text = "Select";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(495, 174);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(189, 22);
            this.TxtPhone.TabIndex = 75;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(495, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 22);
            this.dateTimePicker1.TabIndex = 74;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(701, 519);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(101, 32);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(570, 519);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(101, 32);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(445, 519);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(101, 32);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgVStudent);
            this.panel4.Location = new System.Drawing.Point(20, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1061, 244);
            this.panel4.TabIndex = 73;
            // 
            // dgVStudent
            // 
            this.dgVStudent.AllowUserToDeleteRows = false;
            this.dgVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgStudentID,
            this.dgStudentNumber,
            this.dgFirstName,
            this.dgSurname,
            this.dgGender,
            this.dgDOB,
            this.dgPhoneNo,
            this.dgDepartment,
            this.dgAcademicProgram,
            this.dgAcademicyear,
            this.dgSemester});
            this.dgVStudent.Location = new System.Drawing.Point(3, 3);
            this.dgVStudent.Name = "dgVStudent";
            this.dgVStudent.ReadOnly = true;
            this.dgVStudent.Size = new System.Drawing.Size(1042, 234);
            this.dgVStudent.TabIndex = 0;
            this.dgVStudent.DoubleClick += new System.EventHandler(this.dgVStudent_DoubleClick);
            // 
            // dgStudentID
            // 
            this.dgStudentID.DataPropertyName = "StudentID";
            this.dgStudentID.HeaderText = "StudentID";
            this.dgStudentID.Name = "dgStudentID";
            this.dgStudentID.ReadOnly = true;
            this.dgStudentID.Visible = false;
            // 
            // dgStudentNumber
            // 
            this.dgStudentNumber.DataPropertyName = "StudentNumber";
            this.dgStudentNumber.HeaderText = "Student Number";
            this.dgStudentNumber.Name = "dgStudentNumber";
            this.dgStudentNumber.ReadOnly = true;
            // 
            // dgFirstName
            // 
            this.dgFirstName.DataPropertyName = "FirstName";
            this.dgFirstName.HeaderText = "FirstName";
            this.dgFirstName.Name = "dgFirstName";
            this.dgFirstName.ReadOnly = true;
            // 
            // dgSurname
            // 
            this.dgSurname.DataPropertyName = "Surname";
            this.dgSurname.HeaderText = "Surname";
            this.dgSurname.Name = "dgSurname";
            this.dgSurname.ReadOnly = true;
            // 
            // dgGender
            // 
            this.dgGender.DataPropertyName = "Gender";
            this.dgGender.HeaderText = "Gender";
            this.dgGender.Name = "dgGender";
            this.dgGender.ReadOnly = true;
            // 
            // dgDOB
            // 
            this.dgDOB.DataPropertyName = "DOB";
            this.dgDOB.HeaderText = "DOB";
            this.dgDOB.Name = "dgDOB";
            this.dgDOB.ReadOnly = true;
            // 
            // dgPhoneNo
            // 
            this.dgPhoneNo.DataPropertyName = "PhoneNo";
            this.dgPhoneNo.HeaderText = "PhoneNo";
            this.dgPhoneNo.Name = "dgPhoneNo";
            this.dgPhoneNo.ReadOnly = true;
            // 
            // dgDepartment
            // 
            this.dgDepartment.DataPropertyName = "Department";
            this.dgDepartment.HeaderText = "Department";
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.ReadOnly = true;
            // 
            // dgAcademicProgram
            // 
            this.dgAcademicProgram.DataPropertyName = "AcademicProgram";
            this.dgAcademicProgram.HeaderText = "AcademicProgram";
            this.dgAcademicProgram.Name = "dgAcademicProgram";
            this.dgAcademicProgram.ReadOnly = true;
            // 
            // dgAcademicyear
            // 
            this.dgAcademicyear.DataPropertyName = "Academicyear";
            this.dgAcademicyear.HeaderText = "Academicyear";
            this.dgAcademicyear.Name = "dgAcademicyear";
            this.dgAcademicyear.ReadOnly = true;
            // 
            // dgSemester
            // 
            this.dgSemester.DataPropertyName = "Semester";
            this.dgSemester.HeaderText = "Semester";
            this.dgSemester.Name = "dgSemester";
            this.dgSemester.ReadOnly = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(319, 519);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 32);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(393, 83);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(54, 15);
            this.Gender.TabIndex = 72;
            this.Gender.Text = "Gender :";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(393, 129);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(39, 15);
            this.DOB.TabIndex = 71;
            this.DOB.Text = "DOB :";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semester.Location = new System.Drawing.Point(729, 190);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(66, 15);
            this.Semester.TabIndex = 67;
            this.Semester.Text = "Semester :";
            // 
            // CmbSemester
            // 
            this.CmbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSemester.FormattingEnabled = true;
            this.CmbSemester.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester"});
            this.CmbSemester.Location = new System.Drawing.Point(877, 172);
            this.CmbSemester.Name = "CmbSemester";
            this.CmbSemester.Size = new System.Drawing.Size(190, 24);
            this.CmbSemester.TabIndex = 65;
            this.CmbSemester.Text = "Select";
            // 
            // CmbAcademicyear
            // 
            this.CmbAcademicyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAcademicyear.FormattingEnabled = true;
            this.CmbAcademicyear.Items.AddRange(new object[] {
            "2017/2018",
            "2016/2017",
            "2015/2016",
            "2014/2015"});
            this.CmbAcademicyear.Location = new System.Drawing.Point(877, 128);
            this.CmbAcademicyear.Name = "CmbAcademicyear";
            this.CmbAcademicyear.Size = new System.Drawing.Size(190, 24);
            this.CmbAcademicyear.TabIndex = 64;
            this.CmbAcademicyear.Text = "Select";
            // 
            // AcademicProgram
            // 
            this.AcademicProgram.AutoSize = true;
            this.AcademicProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcademicProgram.Location = new System.Drawing.Point(729, 83);
            this.AcademicProgram.Name = "AcademicProgram";
            this.AcademicProgram.Size = new System.Drawing.Size(118, 15);
            this.AcademicProgram.TabIndex = 63;
            this.AcademicProgram.Text = "Academic Program :";
            // 
            // CmbAcademicProgram
            // 
            this.CmbAcademicProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAcademicProgram.FormattingEnabled = true;
            this.CmbAcademicProgram.Items.AddRange(new object[] {
            "Full-Time ND",
            "Daily ND Program",
            "Evening ND Program",
            "Daily PT-HND",
            "Full-Time HND"});
            this.CmbAcademicProgram.Location = new System.Drawing.Point(877, 74);
            this.CmbAcademicProgram.Name = "CmbAcademicProgram";
            this.CmbAcademicProgram.Size = new System.Drawing.Size(190, 24);
            this.CmbAcademicProgram.TabIndex = 61;
            this.CmbAcademicProgram.Text = "Select";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Items.AddRange(new object[] {
            "Select",
            "Accountancy",
            "Agric Engineering",
            "Agricultural Technology",
            "AGE - Post Harvest Option",
            "AGT - Soil Science Technology",
            "Animal Health and Production",
            "Architectural Technology",
            "Banking and Finance",
            "Building Technology",
            "Business Administration",
            "Civil Engineering",
            "Computer Science",
            "Crop Production",
            "Estate Management",
            "Food Science Technology",
            "Insurance",
            "Local Government Studies",
            "Mathematics & Statistics",
            "Mechanical Engineering",
            "Prelim/Remedial Studies",
            "Public Administration",
            "Quantity Surveying",
            "Science Laboratory Technology",
            "Surveying and Geoinformatics",
            "Transport Planning and Management",
            "Urban and Regional Planning"});
            this.CmbDepartment.Location = new System.Drawing.Point(496, 228);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(190, 24);
            this.CmbDepartment.TabIndex = 59;
            this.CmbDepartment.Text = "Select";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurname.Location = new System.Drawing.Point(122, 128);
            this.TxtSurname.Multiline = true;
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(181, 27);
            this.TxtSurname.TabIndex = 56;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(122, 181);
            this.TxtFirstName.Multiline = true;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(181, 27);
            this.TxtFirstName.TabIndex = 55;
            // 
            // TxtStudentNumber
            // 
            this.TxtStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStudentNumber.Location = new System.Drawing.Point(122, 74);
            this.TxtStudentNumber.Multiline = true;
            this.TxtStudentNumber.Name = "TxtStudentNumber";
            this.TxtStudentNumber.Size = new System.Drawing.Size(181, 27);
            this.TxtStudentNumber.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Surname :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "First Name :";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(393, 237);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(78, 15);
            this.Department.TabIndex = 52;
            this.Department.Text = "Department :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Student Number :";
            // 
            // Academicyear
            // 
            this.Academicyear.AutoSize = true;
            this.Academicyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Academicyear.Location = new System.Drawing.Point(729, 137);
            this.Academicyear.Name = "Academicyear";
            this.Academicyear.Size = new System.Drawing.Size(90, 15);
            this.Academicyear.TabIndex = 50;
            this.Academicyear.Text = "Academic year:";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.BtnStudentHompages);
            this.panel7.Controls.Add(this.BtnLectureBroadcast);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.BtnRegistedStudents);
            this.panel7.Location = new System.Drawing.Point(9, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1067, 63);
            this.panel7.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1036, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 13;
            // 
            // BtnStudentHompages
            // 
            this.BtnStudentHompages.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnStudentHompages.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStudentHompages.Location = new System.Drawing.Point(861, 3);
            this.BtnStudentHompages.Name = "BtnStudentHompages";
            this.BtnStudentHompages.Size = new System.Drawing.Size(190, 53);
            this.BtnStudentHompages.TabIndex = 12;
            this.BtnStudentHompages.Text = "Student Hompage";
            this.BtnStudentHompages.UseVisualStyleBackColor = false;
            this.BtnStudentHompages.Click += new System.EventHandler(this.BtnStudentHompages_Click);
            // 
            // BtnLectureBroadcast
            // 
            this.BtnLectureBroadcast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLectureBroadcast.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLectureBroadcast.Location = new System.Drawing.Point(460, -2);
            this.BtnLectureBroadcast.Name = "BtnLectureBroadcast";
            this.BtnLectureBroadcast.Size = new System.Drawing.Size(190, 53);
            this.BtnLectureBroadcast.TabIndex = 10;
            this.BtnLectureBroadcast.Text = "Lecture Broadcast";
            this.BtnLectureBroadcast.UseVisualStyleBackColor = false;
            this.BtnLectureBroadcast.Click += new System.EventHandler(this.BtnLectureBroadcast_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 6;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnRegistedStudents
            // 
            this.BtnRegistedStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistedStudents.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistedStudents.Location = new System.Drawing.Point(9, 3);
            this.BtnRegistedStudents.Name = "BtnRegistedStudents";
            this.BtnRegistedStudents.Size = new System.Drawing.Size(217, 53);
            this.BtnRegistedStudents.TabIndex = 0;
            this.BtnRegistedStudents.Text = "No of Registered Students";
            this.BtnRegistedStudents.UseVisualStyleBackColor = false;
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(393, 174);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(65, 15);
            this.PhoneNo.TabIndex = 44;
            this.PhoneNo.Text = "PhoneNo :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1108, 606);
            this.Controls.Add(this.panel2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVStudent)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnLectureBroadcast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRegistedStudents;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Academicyear;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.ComboBox CmbSemester;
        private System.Windows.Forms.ComboBox CmbAcademicyear;
        private System.Windows.Forms.Label AcademicProgram;
        private System.Windows.Forms.ComboBox CmbAcademicProgram;
        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtStudentNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnStudentHompages;
        private System.Windows.Forms.DataGridView dgVStudent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAcademicProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAcademicyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSemester;
    }
}