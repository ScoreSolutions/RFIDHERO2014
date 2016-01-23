using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LinqDB.TABLE;
using LinqDB.Common.Utilities;
using System.Data.SqlClient;
namespace Kiosk_eBrochure
{
    public partial class frmSelectBrochures : Form
    {
        int x;
        int y;
       string stritem;
     
        public frmSelectBrochures()
        {
            InitializeComponent();
        }

        private void frmSelectBrochures_Load(object sender, EventArgs e)
        {   
            RenderBrochure();
        }

        public void IsVisibelPicture()
        { 
            pictureEmail.Visible = false;
        }

        public void RenderBrochure() {

            int iWidth = 587;
            int iHeight = 800;
            int iy = 224;

            panel1.Location = new Point(40, 322);
            panel1.Height = iHeight;
            panel1.Width = 750;

            iy = iy + iHeight;

            this.Width = 800;
            this.Height = 1224;
            pictureEmail.Location = new Point(221, iy + 100);
       
            
            //245, 653
            TransactionDB trans = new TransactionDB();
            //trans.CreateTransaction();

            EbrochureLinqDB brochure = new EbrochureLinqDB();
            DataTable dt;
            dt = brochure.GetDataList("", "", trans.Trans);
            trans.CommitTransaction();
            x = 0;
            y  =0 ;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                AddItem(dt.Rows[i]["id"] + "", dt.Rows[i]["name_thai"] + "");
                // ++i;
            }
           // AddItem(1, "Service");
            //AddItem2(1, "count_queue");
            //AddItem3(1, "wait_time");
            //AddItem4(1, "app_queue");

            dt.Dispose();
            //FLP.Show();
            panel1.Show();
           
        
        }

        public string GetBrochureName(string id)
        {
            EbrochureLinqDB brochure = new EbrochureLinqDB();
            DataTable dt;
            dt = brochure.GetDataList("id=" + id, "", null);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["name_thai"] + "";
            }
            else
            {
                return "";
            }
        }
           
       
        public void AddItem(string id, string Item)
        {
            Panel p = new Panel();

            string strpath = Application.StartupPath;
            strpath = strpath + "\\images\\view.jpg";
            Image img = Image.FromFile(strpath);
            Label lblImage = new Label();
            lblImage.Image = img;
            lblImage.Name = id + "";
            lblImage.Width = 80;
            lblImage.Height = 120;
            lblImage.Location = new Point(x, 0);

            //string strpath2 = Application.StartupPath;
            //strpath2 = strpath2 + "\\images\\close.gif";
            //Image img2 = Image.FromFile(strpath2);
            //Label lblImage2 = new Label();
            //lblImage2.Image = img2;
            //lblImage2.Width = 60;
            //lblImage2.Height = 60;
          //  lblImage2.Location = new Point(x + 550 , y );

            Label lbl = new Label();
            Font FontCustom = new Font("Microsoft Sans Serif", 25, FontStyle.Bold, GraphicsUnit.Pixel);

            lbl.Width = 650;
            lbl.Height = 120;
            lbl.Image = GetFileImage(id);
            lbl.Name = id + "";   
           // lbl.Text =Item;
            //lbl.Font = FontCustom;
            lbl.AutoSize = false;
            lbl.FlatStyle = FlatStyle.Flat;
            //lbl.BackColor = Color.Ivory;
            lbl.BackColor = Color.Transparent;
            lbl.Enabled = true;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Location = new Point(x + 80);
            p.Width = 740;
            p.Height = 120;
            p.Name = id;
            p.Controls.Add(lblImage);
            p.Controls.Add(lbl);
            p.Location = new Point(x, y);
            //p.Controls.Add(lblImage2);
           //p.AutoSize = true;
           //p.Controls.Add(lblImage);
           //p.Controls.Add(lbl);
          // p.Controls.Add(lblImage2);

      


            panel1.Controls.Add(p);
          //  panel1.Height = 800;
       
            //panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2,this.ClientSize.Height / 2 - panel1.Size.Height / 2);

         
           
           //panel1.Controls.Add(lbl);
     

           
            //FLP.Controls.Add(p);
           // FLP.Controls.Add(lbl);
            lbl.MouseClick += CheckItem;
            lblImage.MouseClick += OpenBrochure;

            y = y + 130;
        }

        public Image GetFileImage( string number) {
            string strpath = Application.StartupPath;
            Image img = Image.FromFile(strpath + "\\images\\assets.jpg");
            switch (number)
            {
                case "1":
                    strpath = strpath + "\\images\\assets.jpg";
                    return Image.FromFile(strpath);;
                case "2":
                    strpath = strpath + "\\images\\document.jpg";
                    return Image.FromFile(strpath);;
                case "3":
                    strpath = strpath + "\\images\\loading.jpg";
                    return Image.FromFile(strpath);;
                case "4":
                    strpath = strpath + "\\images\\vrm.jpg";
                    return Image.FromFile(strpath);;
                case "5":
                    strpath = strpath + "\\images\\Q-Sharp.jpg";
                    return Image.FromFile(strpath);;
                case "6":
                    strpath = strpath + "\\images\\LogisPro.jpg";
                    return Image.FromFile(strpath);;
                default:
                    return img;
            }

       
        }
        public Image GetFileImageSelect(string number)
        {
            string strpath = Application.StartupPath;
            Image img = Image.FromFile(strpath + "\\images\\assets.jpg");
            switch (number)
            {
                case "1":
                    strpath = strpath + "\\images\\assets-check.jpg";
                    return Image.FromFile(strpath); ;
                case "2":
                    strpath = strpath + "\\images\\document-check.jpg";
                    return Image.FromFile(strpath); ;
                case "3":
                    strpath = strpath + "\\images\\loading-check.jpg";
                    return Image.FromFile(strpath); ;
                case "4":
                    strpath = strpath + "\\images\\vrm-check.jpg";
                    return Image.FromFile(strpath); ;
                case "5":
                    strpath = strpath + "\\images\\Q-Sharp-check.jpg";
                    return Image.FromFile(strpath); ;
                case "6":
                    strpath = strpath + "\\images\\LogisPro-check.jpg";
                    return Image.FromFile(strpath); ;
                default:
                    return img;
            }


        }


        public void OpenBrochure(Object Sender, EventArgs e)
        {
            Label lbl = (Label)Sender;
            TransactionDB transList = new TransactionDB();

            EbrochureDocumentLinqDB Document = new EbrochureDocumentLinqDB();
            DataTable dt;
            dt = Document.GetDataList("ebrochure_id=" + lbl.Name, "", transList.Trans);
            transList.CommitTransaction();
            if (dt.Rows.Count > 0) {

                frmOpenBrochure f = new frmOpenBrochure();
                f.ShowContent(dt.Rows[0]["file_path"] + "", GetBrochureName(dt.Rows[0]["ebrochure_id"] + ""));
                f.ShowDialog();
            } 

            
        }

        public void CheckItem(Object Sender, EventArgs e)
        {
            Label lbl = (Label)Sender;
            if (lbl.BackColor == Color.Transparent)
            {

                  lbl.BackColor = Color.LightSeaGreen;
                  lbl.ForeColor = Color.Transparent;
                  lbl.Image = GetFileImageSelect(lbl.Name);

                //  if (stritem == "") {
                //      stritem = lbl.Name;
                //  }
                //  else
                //  {
                //stritem +=","+ lbl.Name;
                //    }

                //Int32 num;
                //num = 0;
                //for (int i = 0; i < FLP.Controls.Count; ++i)
                //{
                //    if (FLP.Controls[i].BackColor == Color.LightSeaGreen) {
                //        num = num + 1;
                //    }
                //}


            }else
            {

                //if (stritem != "") {
                //    stritem.Replace(Convert.ToChar(lbl.Name),"");
                //}
                lbl.BackColor = Color.Transparent;
                 lbl.ForeColor = Color.Black;
                 lbl.Image = GetFileImage(lbl.Name);
               
            }
            
        }

        private void pictureEmail_Click(object sender, EventArgs e)
        {

            //Control[] cnt = panel1.Controls.Find("", true);


            stritem = "";
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                Label lbl;
                Panel pnl;

                try
                {
                    pnl = (Panel)panel1.Controls[i];
                    for (int j = 0; j < pnl.Controls.Count; j++)
                    {
                        try
                        {
                            lbl = (Label)pnl.Controls[j];
                            if (lbl.BackColor == Color.LightSeaGreen)
                            {
                                if (stritem == "")
                                {
                                    stritem = lbl.Name;
                                }
                                else
                                {
                                    stritem += "," + lbl.Name;
                                }

                            }
                        }
                        catch (Exception exx) { }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (stritem == "")
            {
                 MessageBox.Show("กรุณาเลือก Solution ที่ท่านสนใจ");
            }
            else
            {
                SendMail(stritem);
             }

        }

        public void SendMail(string allID) {
            //LiveFaceScan.userinfo.email = "tummax@gmail.com";
            //LiveFaceScan.userinfo.id = 16 + "";
            Boolean ret;
            ret =false;
            EbrochureDocumentLinqDB  eDocument = new EbrochureDocumentLinqDB();
            

          
            TransactionDB trans = new TransactionDB();
            //trans.CreateTransaction();
            string status;
            status = "false";
            string[] strId = allID.Split(',');

            //for (int i = 0; i < strId.Length; i++) {
               EbrochureSendMailJobLinqDB SendMailJob = new EbrochureSendMailJobLinqDB();
                

                //SendMailJob.CREATE_BY = "Admin";
                //SendMailJob.CREATE_ON = DateTime.Now;
                //SendMailJob.UPDATE_BY = "Admin";
                //SendMailJob.UPDATE_ON = DateTime.Now;
                SendMailJob.ERM_TS_PERSONAL_INFO_ID = Convert.ToInt32( LiveFaceScan.userinfo.id);
                SendMailJob.CUSTOMER_EMAIL = LiveFaceScan.userinfo.email;
                SendMailJob.IS_SEND_MAIL = 'N';
                ret = SendMailJob.InsertData("Admin", trans.Trans);

                if (ret == true)
                {
                    //DataTable dt;
                    //dt = eDocument.GetDataList("ebrochure_id=" + strId[0], "", trans.Trans);
                  
                    //for (int j = 0; j < dt.Rows.Count; j++)
                    //{
                      for (int i = 0; i < strId.Length; i++) {
                        EbrochureSendMailJobItemLinqDB SendMailJobItem = new EbrochureSendMailJobItemLinqDB();
                        //SendMailJobItem.CREATE_BY = "Admin";
                        //SendMailJobItem.CREATE_ON = DateTime.Now;
                        //SendMailJob.UPDATE_BY = "Admin";
                        //SendMailJob.UPDATE_ON = DateTime.Now;
                        SendMailJobItem.EBROCHURE_SEND_MAIL_JOB_ID = SendMailJob.ID;
                        SendMailJobItem.EBROCHURE_ID = Convert.ToInt32(strId[i]);
                        ret = SendMailJobItem.InsertData("Admin", trans.Trans);

                        SendMailJobItem = null;
                        }
                }

                SendMailJob = null;
            //}


            if (ret == false)
            {
                trans.RollbackTransaction();
                MessageBox.Show("ไม่สามารถส่ง E-Mail ได้");
            }
            else {
                trans.CommitTransaction();
                this.Visible = false;
                this.Close();

               frmEmailSend f = new frmEmailSend();
                f.MailComplete();
                f.ShowDialog();
     
            }
        }
     
          

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            frmCameraDetect f = new frmCameraDetect();
            f.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            //Control[] cnt = panel1.Controls.Find("", true);


            stritem = "";
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                Label lbl;
                Panel pnl;

                try
                {
                    pnl = (Panel)panel1.Controls[i];
                    for (int j = 0; j < pnl.Controls.Count; j++)
                    {
                        try
                        {
                            lbl = (Label)pnl.Controls[j];
                            if (lbl.BackColor == Color.LightSeaGreen)
                            {
                                if (stritem == "")
                                {
                                    stritem = lbl.Name;
                                }
                                else
                                {
                                    stritem += "," + lbl.Name;
                                }

                            }
                        }
                        catch (Exception exx) { }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (stritem == "")
            {
                MessageBox.Show("กรุณาเลือก Solution ที่ท่านสนใจ");
            }
            else
            {
                SendMail(stritem);
            }

        }
    }
}
