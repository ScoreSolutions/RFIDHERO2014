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
    public partial class frmEmailSend : Form
    {
        public frmEmailSend()
        {
            InitializeComponent();
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        }

        public void MailComplete() 
        {
            lblLine2.Text = LiveFaceScan.userinfo.email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        }

  

        private void pictureOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        }

        private void frmEmailSend_Load(object sender, EventArgs e)
        {
            this.Width = 800;
            this.Height = 1224;
            //231, 688
            pictureOK.Location = new Point(200, 1000);
        }
    }
}
