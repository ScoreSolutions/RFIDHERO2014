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
    public partial class frmSearchMobile : Form
    {
        public frmSearchMobile()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10) {
                txtNumber.Text = txtNumber.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "9";
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SetUserInfo();
            //if (txtNumber.Text.Length != 10)
            //{
            //    Dialog.frmDialogMsg f = new Dialog.frmDialogMsg();
            //    f.lblText.Text = "กรุณาระบุหมายเลขให้ถูกต้อง";
            //    f.ShowDialog();
            //}
            //else {
            //    SetUserInfo();
            // }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length != 10)
            {
                txtNumber.Text = txtNumber.Text + "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != "") {
                txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1);
            }
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        }

        public void SetUserInfo() {
            try 
            { 
            DataTable dt;
            ErmTsPersonalInfoLinq Userinfo = new ErmTsPersonalInfoLinq();
           // TransactionDB trans = new TransactionDB();

            dt = Userinfo.GetDataList("replace(mobile_no,'-','')='" +  txtNumber.Text + "'", "", null);
         //   trans.CommitTransaction();
            if (dt.Rows.Count > 0)
            {
                LiveFaceScan.userinfo.id = dt.Rows[0]["id"] + "";
                if (Convert.IsDBNull(dt.Rows[0]["first_name"]) == false && Convert.IsDBNull(dt.Rows[0]["last_name"]) == false) {
                    LiveFaceScan.userinfo.fullname = "คุณ" + dt.Rows[0]["first_name"] + " " + dt.Rows[0]["last_name"];
                }
                if (Convert.IsDBNull(dt.Rows[0]["email"]) == false)
                {
                    LiveFaceScan.userinfo.email = dt.Rows[0]["email"] + "";
                }

                if (Convert.IsDBNull(dt.Rows[0]["company_name"]) == false)
                {
                    LiveFaceScan.userinfo.companyname = dt.Rows[0]["company_name"] + "";
                }
                
               

                this.Visible = false;
                //this.Close();
                frmSelectBrochures f = new frmSelectBrochures();
                f.ShowDialog();
            }
            else {
                Dialog.frmDialogMsg f = new Dialog.frmDialogMsg();
                f.lblText.Text = "ไม่พบข้อมูล";
                f.ShowDialog();
            }
            }
            catch (Exception exUserinfo) {
                Dialog.frmDialogMsg f = new Dialog.frmDialogMsg();
                f.lblText.Text = "ไม่พบข้อมูล";
                f.ShowDialog();
            }
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SetUserInfo();
            //if (txtNumber.Text.Length != 10)
            //{
            //    Dialog.frmDialogMsg f = new Dialog.frmDialogMsg();
            //    f.lblText.Text = "กรุณาระบุหมายเลขให้ถูกต้อง";
            //    f.ShowDialog();
            //}
            //else
            //{
            //    SetUserInfo();
            //}
        }

    }
}
