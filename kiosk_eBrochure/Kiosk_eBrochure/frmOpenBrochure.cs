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
    public partial class frmOpenBrochure : Form
    {
        public frmOpenBrochure()
        {
            InitializeComponent();
        }

        private void frmOpenBrochure_Load(object sender, EventArgs e)
        {
            //int iWidth = 587;
            //int iHeight = 600;
            //int iy = 224;

            //panel1.Location = new Point(51, 304);
            //panel1.Height = iHeight;
            //panel1.Width = 719;

            //iy = iy + iHeight;
            lblHeader.Location = new Point(12, 201);
            lblHeader.Height = 39;
            lblHeader.Width = 777;
            pictureBrochure.Location = new Point(12, 257);
            pictureBrochure.Width = 777;
            pictureBrochure.Height = 900;


            this.Width = 800;
            this.Height = 1224;

        }

        public void ShowContent(string path,string BrochureName) {
            Image img = Image.FromFile(path);
            lblHeader.Text = BrochureName;
            pictureBrochure.Image = img;
        }

        private void pictureBrochure_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
