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
    public partial class frmSelectBrochure : Form
    {
        public frmSelectBrochure()
        {
            InitializeComponent();
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureEmail_Click(object sender, EventArgs e)
        {
           //this.Visible = false;
            this.Close();
            frmEmailSend f = new frmEmailSend();
            f.ShowDialog();
        }


        private void frmSelectBrochure_Load(object sender, EventArgs e)
        {

        }

 

    }
}
