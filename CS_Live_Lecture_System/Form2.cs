using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Live_Lecture_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            string username1 = "Admin";
            string Password1 = "Adminpass";
            string Type1 = "Admin";


            string username2 = "Student";
            string Password2 = "Student";
            string Type2 = "Student";

            if(TxtUsername.Text ==username1 && TxtPassword.Text == Password1 && CmbType.Text ==Type1)

            {
            this.Hide();
            Form3 Admin = new Form3();
            Admin.Show();

            }
            else if (TxtUsername.Text ==username2 && TxtPassword.Text == Password2 && CmbType.Text ==Type2)
            {
            this.Hide();
            Form5 Student =new Form5();
            Student.Show();
            } 
            else
            {
            MessageBox.Show("invalid username,password or user Type!");
            }
        }

        private void BtnIExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Confirm if you want to exit", "System Down", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
