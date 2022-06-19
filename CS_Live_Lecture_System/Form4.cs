using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CS_Live_Lecture_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videoSource;

        private void BtnRegistedStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void BtnStudentHompage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f = new Form5();
            f.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices)
            {
                CmbSelect.Items.Add(Device.Name);
            }
            CmbSelect.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(CaptureDevices[CmbSelect.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnResetAll_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            pictureBox2.Image = null;
            pictureBox2.Invalidate();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if(videoSource.IsRunning==true)

            {
            videoSource.Stop();
            }
            Application.Exit(null);
        }
    }

}
