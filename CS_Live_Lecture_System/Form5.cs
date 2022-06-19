using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CS_Live_Lecture_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videoSource;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void BtnPreviousVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
          if ( openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
              this.listView.Text = openFileDialog1.FileName;
          }

   //         //for listView

   //         if ( openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
   //  {
   //         files  = openFileDialog1.SafeFileNames;    //save only the names
   //         paths = openFileDialog1.FileNames;          //save only the ful paths
   //         for (int i = 0; i<files.Length; i++)
   //{
   //         listView.Items.Add(files[i]);               //Add Songs to the listbox
   //      }
   //  }
        
  }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = TxtDisplaytextpath.Text;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
            //axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listView.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices)
            {
                CmbSelect.Items.Add(Device.Name);
            }
            CmbSelect.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox3.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnStartstudent_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(CaptureDevices[CmbSelect.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void BtnResetAllstudent_Click(object sender, EventArgs e)
        {
            videoSource.Stop();
            pictureBox3.Image = null;
            pictureBox3.Invalidate();
        }

        private void BtnPauseStudent_Click(object sender, EventArgs e)
        {
          videoSource.Stop();
        }
     }
 }
