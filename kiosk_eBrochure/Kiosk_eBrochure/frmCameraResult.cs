using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LinqDB.Common.Utilities;
using LinqDB.TABLE;

namespace Kiosk_eBrochure
{
    public partial class frmCameraResult : Form
    {
        public frmCameraResult()
        {
            InitializeComponent();
        }

        public void ShowImage2()
        {
            int iWidth = 587;
            int iHeight = 600;
            int iy = 224;
            Image img = Image.FromFile("D:\\Kiosk_Image\\10084.jpg");
            pictureBox1.Image = img;
            pictureBox1.Location = new Point(43, 224);
            pictureBox1.Height = iHeight;
            pictureBox1.Width = 719;

            iy = iy + iHeight;

            this.Width = 800;
            this.Height = 1224;
            lblHeader.Location = new Point(306, iy + 50);
            lblLine1.Location = new Point(227, iy + 100);
            lblLine2.Location = new Point(227, iy + 150);
            lblLine3.Location = new Point(227, iy + 200);
            pictureOK.Location = new Point(210, iy + 300);
        
        }
        public void ShowImage(TFaceRecord DetectFaceFace)
        {
            int iWidth = 587;
            int iHeight = 600;
            int iy = 150;
            Image img = DetectFaceFace.image.ToCLRImage();
            pictureBox1.Image = img;
            pictureBox1.Location = new Point(43, 208); //new Point(43, 208);//23, 397
            pictureBox1.Height = iHeight;
            pictureBox1.Width = 719;
          
            iy = iy + iHeight;

            this.Width = 800;
            this.Height = 1224;
            lblHeader.Location = new Point(306, iy + 50);
            lblLine1.Location = new Point(125, iy + 100);
            lblLine2.Location = new Point(125, iy + 150);
            lblLine3.Location = new Point(125, iy + 200);
            pictureOK.Location = new Point(210, iy + 370);
      
          //  lblLine1.Text ="คุณ" +  GetFileName(DetectFaceFace.ImageFileName);
            //pictureBox1.Height = img.Height;
            // pictureBox1.Width = img.Width;
            // this.Show();
            //  frmMain F = new frmMain();
           SetDetail(GetFileName(DetectFaceFace.ImageFileName));
        }

        public void SetDetail(string id) {
        //       Dim lnq As New EbrochureSendMailJobLinqDB
        //    Dim dt As New DataTable
        //    dt = lnq.GetDataList("is_send_mail='N'", "", Nothing)
        //    If dt.Rows.Count > 0 Then

        //    End If
        //    lnq = Nothing
        //    dt.Dispose()

            ErmTsPersonalInfoLinq Userinfo = new ErmTsPersonalInfoLinq();
            DataTable dt;
            dt = Userinfo.GetDataList("id=" + id,"",null);
            if (dt.Rows.Count > 0) {
                lblLine1.Text = "คุณ"+ dt.Rows[0]["first_name"] + " " + dt.Rows[0]["last_name"];

                //lblLine1.Text = GetTitleName(dt.Rows[0]["title_name"] + "") + dt.Rows[0]["first_name"] + " " + dt.Rows[0]["last_name"];
                lblLine2.Text ="บริษัท:" + dt.Rows[0]["company_name"] + "";
                lblLine3.Text ="E-Mail:"  + dt.Rows[0]["email"] + "";

                LiveFaceScan.userinfo.id = dt.Rows[0]["id"] + "";
                LiveFaceScan.userinfo.fullname = lblLine1.Text;
                LiveFaceScan.userinfo.email = dt.Rows[0]["email"] + "";
                LiveFaceScan.userinfo.companyname = dt.Rows[0]["company_name"] + "";

            }
            dt.Dispose();

        }

        public string GetTitleName(string TitleCode) {

            switch (TitleCode) { 
                case "MR":
                   return "นาย";
                case "MS":
                    return "นาง";
                case "MRS":
                    return "นางสาว";
       
                default:
                    return TitleCode;
            }
        }




        public string GetFileName(string path)
        {
            string[] str = path.Split(new Char[] { '/' });
            if (str.Length > 0)
            {
                return str[str.Length - 1].Replace(".jpg", "");
            }
            else
            {
                return "";
            }

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           this.Close();
            frmSelectBrochures f = new frmSelectBrochures();
            f.ShowDialog();
         
        }

  

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        }

        private void frmCameraResult_Load(object sender, EventArgs e)
        {
           // ShowImage2();
        }

        private void pictureOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmSelectBrochures f = new frmSelectBrochures();
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmSelectBrochures f = new frmSelectBrochures();
            f.ShowDialog();
        }


    }
}
