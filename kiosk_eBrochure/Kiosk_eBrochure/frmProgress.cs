using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiosk_eBrochure
{
    public partial class frmProgress : Form
    {
        BackgroundWorker bgw = new BackgroundWorker();
        public frmProgress()
        {
            InitializeComponent();
        }

        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                backgroundWorker.ReportProgress((j * 100) / 100000);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // TODO: do something with final calculation
        }

        private void backgroundWorker_Click(object sender, EventArgs e)
        {

        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
          
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
           
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 100; //some number (this is your variable to change)!!

            for (int i = 0; i <= total; i++) //some number (total)
            {
                //100 ms= 1 s
                System.Threading.Thread.Sleep(100);
                int percents = (i * 100) / total;
                bgw.ReportProgress(percents, i);
                //2 arguments:
                //1. procenteges (from 0 t0 100) - i do a calcumation 
                //2. some current value!
            }

            //frmCameraDetect f = new frmCameraDetect();
            //f.PopulateAllImage();
            //f.ImageDetect();
        }

        void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            label1.Text = String.Format("Progress: {0} %", e.ProgressPercentage);
          //  label2.Text = String.Format("Total items transfered: {0}", e.UserState);
        }

        void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //do the code when bgv completes its work
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
