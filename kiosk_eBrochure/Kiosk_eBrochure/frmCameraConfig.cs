using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Luxand;
using LinqDB.Common.Utilities;
using System.Diagnostics;
namespace Kiosk_eBrochure
{

    public partial class frmCameraConfig : Form
    {
        String cameraName;
        int count;

        public frmCameraConfig()
        {
            InitializeComponent();
        }

        private void frmCameraConfig_Load(object sender, EventArgs e)
        {
           // textBox1.Text = SqlDB.EnCripPwd("1qaz@WSX");
            PopulateData();
        }

        private void PopulateData()
        {

 
            string[] cameraList;
            FSDKCam.GetCameraList(out cameraList, out count);

            if (0 == count)
            {
                MessageBox.Show("Please attach a camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            for (int c = 0; c < cameraList.Length; ++c)
            {
                cbCameraList.Items.Add(cameraList[c]);
                //cbCameraList.Items.Add(new Item(cameraList[c], c+1));
            }
            if (cameraList.Length > 0)
            {
                cbCameraList.SelectedIndex = 0;
                cameraName = cameraList[0];
                PopolateformatList(cameraName);
            }
            btnOk.Focus();
        }


        private void PopolateformatList(string cameraname)
        {
            FSDKCam.VideoFormatInfo[] formatList;
            FSDKCam.GetVideoFormatList(ref cameraname, out formatList, out count);

            for (int v = 0; v < formatList.Length; ++v)
            {
                cbFormat.Items.Add(formatList[v].Width + "x" + formatList[v].Height + " " + formatList[v].BPP + "bpp");
            }
            if (formatList.Length > 0)
            {
                cbFormat.SelectedIndex = 0;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LiveFaceScan.configfile configfile = new  LiveFaceScan.configfile();
           

            string selected = this.cbCameraList.GetItemText(this.cbCameraList.SelectedItem);
            string cameralist = selected;
            int formatelist = cbFormat.SelectedIndex;
            LiveFaceScan.CameraSetting.CameraName = cameralist;
            LiveFaceScan.CameraSetting.VideoFormat = formatelist;
            LiveFaceScan.CameraSetting.Drive = configfile.GetDrive();
            this.Visible = false;
           // this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.StartPosition = FormStartPosition.CenterScreen;
           // f.Shown += (s, a) => f.WindowState = FormWindowState.Maximized;  
            f.ShowDialog();
           



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
 

            try
            {
                foreach (Process proc in Process.GetProcessesByName("Kiosk_eBrochure"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

            Application.Exit();


        }



    }
}
