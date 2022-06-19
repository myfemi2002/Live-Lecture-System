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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            ////https://www.youtube.com/watch?v=OmY3XNnqT0E
            
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
