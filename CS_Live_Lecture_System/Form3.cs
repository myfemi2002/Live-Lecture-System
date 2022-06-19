using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CS_Live_Lecture_System
{
    public partial class Form3 : Form
    {
        Student model = new Student();        
        public Form3()
        {
   
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = TxtStudentNumber ;
            LoadData();
           

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Confirm if you want to exit", "System Down", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Record", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Live_Lecture_SystemEntities db = new Live_Lecture_SystemEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Students.Attach(model);
                        db.Students.Remove(model);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            model.StudentNumber = TxtStudentNumber.Text.Trim();
            model.FirstName = TxtFirstName.Text.Trim();
            model.Surname = TxtSurname.Text.Trim();
            model.Gender = CmbGender.Text.Trim();
            model.Department = CmbDepartment.Text.Trim();
            model.AcademicProgram = CmbAcademicProgram.Text.Trim();
            model.Academicyear = CmbAcademicyear.Text.Trim();
            model.Semester = CmbSemester.Text.Trim();
            model.PhoneNo = TxtPhone.Text.Trim();
            model.DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            using (Live_Lecture_SystemEntities db = new Live_Lecture_SystemEntities())
            {
                if (model.StudentID == 0) //insert
                db.Students.Add(model);
                else
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
               Clear();
               LoadData();
            MessageBox.Show ("Submitted Successfully");

        }
      
        void LoadData()
        {
            dgVStudent.AutoGenerateColumns = false;
            using (Live_Lecture_SystemEntities db = new Live_Lecture_SystemEntities())
            {
                dgVStudent.DataSource = db.Students.ToList<Student>();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
        //    this.Hide();
        //    Form4 f = new Form4();
        //    f.Show();
        }

        private void BtnLectureBroadcast_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f = new Form4();
            f.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        //    //this.Hide();
        //    //Form4 f = new Form4();
        //    //f.Show();
        }


        private void BtnStudentHompages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            TxtStudentNumber.Text = TxtFirstName.Text = TxtSurname.Text = TxtPhone.Text = "";
            BtnSave.Text = "Save";
            BtnDelete.Enabled = false;
            model.StudentID = 0;
        }
        private void dgVStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgVStudent.CurrentRow.Index != -1)
            {
                model.StudentID = Convert.ToInt32(dgVStudent.CurrentRow.Cells["dgStudentID"].Value);
                using (Live_Lecture_SystemEntities db = new Live_Lecture_SystemEntities())
                {
                    model = db.Students.Where(x => x.StudentID == model.StudentID).FirstOrDefault();

                    TxtStudentNumber.Text = model.StudentNumber;
                    TxtFirstName.Text = model.FirstName;
                    TxtSurname.Text = model.Surname;
                    TxtPhone.Text = model.PhoneNo;
                    CmbGender.Text = model.Gender;
                    CmbDepartment.Text = model.Department;
                    CmbAcademicProgram.Text = model.AcademicProgram;
                    CmbAcademicyear.Text = model.Academicyear;
                    CmbSemester.Text = model.Semester;
                }
                BtnSave.Text = "Update";
                BtnDelete.Enabled = true;
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
                    {
                     //For enter number only  

         if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
         {
             e.Handled = false;
         }
         else
         {

             MessageBox.Show("Please Enter Only number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             e.Handled = true;
             }
        }
       } 
   }
} 

