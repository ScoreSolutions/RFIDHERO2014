using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Para.TABLE;
using Linq.Common.Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
 

public partial class WebApp_frmRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) {
            SetData();
        }
    }

    void QueryData(string strEmail, string strTelNo)
    {
        try
        {
            String strServerName = ConfigurationManager.AppSettings["ServerName"];
            String strDbName = ConfigurationManager.AppSettings["DbName"];
            String strDbUserID = ConfigurationManager.AppSettings["DbUserID"];
            String strDbPwd = ConfigurationManager.AppSettings["DbPwd"];

            SqlConnection objConn = new SqlConnection("Data Source=" + strServerName + ";Initial Catalog=" + strDbName + ";User ID=" + strDbUserID + ";password=" + strDbPwd);
            if (objConn.State == ConnectionState.Closed) { objConn.Open(); }
            String strSql = string.Empty;
            strSql = "select A.id as infoid,* From ERM_TS_PERSONAL_INFO A Left Join ERM_TS_INTEREST B On a.id=B.erm_ts_personal_info_id where 1=1 ";
            //if (strEmail == "")
            //{
            //    strSql += " And mobile_no ='" + strTelNo + "' ";
            //}
            //else if (strTelNo == "")
            //{
            //    strSql += " And Email ='" + strEmail + "' ";
            //}
            if (strEmail != "")
            {
                strSql += " And Email ='" + strEmail + "' ";
            }

            if (strTelNo != "")
            {
                strSql += " And mobile_no ='" + strTelNo + "' ";
            }
            DataSet Ds = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(strSql, objConn);
            objAdapter.Fill(Ds, "Data");

            for (int i = 0; i <= Ds.Tables["Data"].Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    lblid.Text = Ds.Tables["Data"].Rows[i]["infoid"].ToString();
                    switch (Ds.Tables["Data"].Rows[i]["title_name"].ToString())
                    {
                        case "MR":
                            rdiTitle.SelectedIndex=0;
                            break;
                        case "MRS":
                            rdiTitle.SelectedIndex = 1;
                            break;
                        case "MS":
                            rdiTitle.SelectedIndex = 2;
                            break;
                        default:
                            rdiTitle.SelectedIndex =3;
                            txtTitleOthers.Text=Ds.Tables["Data"].Rows[i]["title_name"].ToString();
                            txtTitleOthers.Enabled = true;
                            break;
                    }

                    txtFirstName.Text = Ds.Tables["Data"].Rows[i]["first_name"].ToString();
                    txtLastName.Text = Ds.Tables["Data"].Rows[i]["last_name"].ToString();
                    txtPosition.Text = Ds.Tables["Data"].Rows[i]["position_name"].ToString();
                    txtCompany.Text = Ds.Tables["Data"].Rows[i]["company_name"].ToString();
                    txtCity.Text = Ds.Tables["Data"].Rows[i]["city"].ToString();
                    txtCountry.Text = Ds.Tables["Data"].Rows[i]["country"].ToString();
                    txtZipCode.Text = Ds.Tables["Data"].Rows[i]["zipcode"].ToString();
                    txtTelNumber.Text = Ds.Tables["Data"].Rows[i]["telno"].ToString();
                    txtFaxNumber.Text = Ds.Tables["Data"].Rows[i]["faxno"].ToString();
                    txtEmail.Text = Ds.Tables["Data"].Rows[i]["email"].ToString();
                    txtWebSite.Text = Ds.Tables["Data"].Rows[i]["website"].ToString();
                    txtAddress.Text = Ds.Tables["Data"].Rows[i]["address"].ToString();
                    txtDivition.Text = Ds.Tables["Data"].Rows[i]["division"].ToString();
                    txtMobileNo.Text = Ds.Tables["Data"].Rows[i]["mobile_no"].ToString();

                    if (Ds.Tables["Data"].Rows[i]["regisperiod"].ToString() == "1")
                    {
                        rdPeriod.Items[0].Selected = true;
                        rdPeriod.Items[1].Selected = false;
                    }

                    if (Ds.Tables["Data"].Rows[i]["regisperiod"].ToString() == "2")
                    {
                        rdPeriod.Items[0].Selected = false;
                        rdPeriod.Items[1].Selected = true;
                    }


                    if (Ds.Tables["Data"].Rows[i]["regisperiod"].ToString() == "3")
                    {
                        rdPeriod.Items[0].Selected = true;
                        rdPeriod.Items[1].Selected = true;
                    }

                    if (Ds.Tables["Data"].Rows[i]["ANNUAL_SALE_VALUE_VOLUMNS"].ToString() == "01")
                    {
                        rdAnnualSale.Items[0].Selected = true;
                    }
                    if (Ds.Tables["Data"].Rows[i]["ANNUAL_SALE_VALUE_VOLUMNS"].ToString() == "02")
                    {
                        rdAnnualSale.Items[1].Selected = true;
                    }
                    
                    
                }

                string strInterest = Ds.Tables["Data"].Rows[i]["interest_code"].ToString();
                string strInterestname = Ds.Tables["Data"].Rows[i]["interest_name"].ToString();
                string InterestName ="";
                string[] s = Linq.Common.Utilities.SqlDB.SplitText(strInterestname,"##");
                if (s.Length > 1)
                {
                    InterestName = s[1];
                }
                switch (strInterest)
                {
                    case "A01":
                        ChkA01.Checked = true;
                        break;
                    case "A02":
                        ChkA02.Checked = true;
                        break;
                    case "A03":
                        ChkA03.Checked = true;
                        break;
                    case "A04":
                        ChkA04.Checked = true;
                        break;
                    case "A05":
                        ChkA05.Checked = true;
                        break;
                    case "A06":
                        ChkA06.Checked = true;
                        break;
                    case "A07":
                        ChkA07.Checked = true;
                        break;
                    case "A08":
                        ChkA08.Checked = true;
                        break;
                    case "A09":
                        ChkA09.Checked = true;
                        break;
                    case "A10":
                        ChkA10.Checked = true;
                        chkA10_CheckedChanged(null, null);
                        txtA10.Text = InterestName;
                        break;
                    case "A11":
                        ChkA11.Checked = true;
                        break;
                    case "A12":
                        ChkA12.Checked = true;
                        break;
                    case "A13":
                        ChkA13.Checked = true;
                        break;
                    case "A14":
                        ChkA14.Checked = true;
                        break;
                    case "A15":
                        ChkA15.Checked = true;
                        break;
                    case "A16":
                        ChkA16.Checked = true;
                        break;
                    case "A17":
                        ChkA17.Checked = true;
                        chkA17_CheckedChanged(null, null);
                        txtA17.Text = InterestName;
                        break;
                    case "B01":
                        ChkB01.Checked = true;
                        break;
                    case "B02":
                        ChkB02.Checked = true;
                        break;
                    case "B03":
                        ChkB03.Checked = true;
                        break;
                    case "B04":
                        ChkB04.Checked = true;
                        if (InterestName != "")
                        {
                            rdiB04Other.Checked = true;
                            rdiChkB04Facebook.Checked = false;
                            rdiB04Other_CheckedChanged(null, null);
                        }
                        else 
                        { 
                            rdiChkB04Facebook.Checked = true;
                            rdiB04Other.Checked = false;
                            rdiChkB04Facebook_CheckedChanged(null, null);
                        }
                        txtB04.Text = InterestName;
                        break;
                    case "B05":
                        ChkB05.Checked = true;
                        chkB05_CheckedChanged(null, null);
                        txtB05.Text = InterestName;
                        break;
                    case "B06":
                        ChkB06.Checked = true;
                        chkB06_CheckedChanged(null, null);
                        txtB06.Text = InterestName;
                        break;
                    case "B07":
                        ChkB07.Checked = true;
                        break;
                    case "B08":
                        ChkB08.Checked = true;
                        break;
                    case "B09":
                        ChkB09.Checked = true;
                        break;
                    case "B10":
                        ChkB10.Checked = true;
                        break;
                    case "B11":
                        ChkB11.Checked = true;
                        break;
                    case "B12":
                        ChkB12.Checked = true;
                        break;
                    case "B13":
                        ChkB13.Checked = true;
                        break;
                    case "B14":
                        ChkB14.Checked = true;
                        chkB14_CheckedChanged(null, null);
                        txtB14.Text = InterestName;
                        break;
                    case "C01":
                        ChkC01.Checked = true;
                        break;
                    case "C02":
                        ChkC02.Checked = true;
                        break;
                    case "C03":
                        ChkC03.Checked = true;
                        break;
                    case "C04":
                        ChkC04.Checked = true;
                        break;
                    case "C05":
                        ChkC05.Checked = true;
                        break;
                    case "C06":
                        ChkC06.Checked = true;
                        break;
                    case "C07":
                        ChkC07.Checked = true;
                        chkC07_CheckedChanged(null, null);
                        txtC07.Text = InterestName;
                        break;
                    case "D01":
                        ChkD01.Checked = true;
                        chkD01_CheckedChanged(null, null);
                        break;
                    case "D02":
                        ChkD02.Checked = true;
                        chkD02_CheckedChanged(null, null);
                        txtD02.Text = InterestName;
                        break;
                    case "E01":
                        ChkE01.Checked = true;
                        break;
                    case "E02":
                        ChkE02.Checked = true;
                        break;
                    case "E03":
                        ChkE03.Checked = true;
                        break;
                    case "E04":
                        ChkE04.Checked = true;
                        break;
                    case "E05":
                        ChkE05.Checked = true;
                        break;
                    case "E06":
                        ChkE06.Checked = true;
                        break;
                    case "E07":
                        ChkE07.Checked = true;
                        break;
                    case "E08":
                        ChkE08.Checked = true;
                        break;
                    case "E09":
                        ChkE09.Checked = true;
                        break;
                    case "E10":
                        ChkE10.Checked = true;
                        break;
                    case "E11":
                        ChkE11.Checked = true;
                        break;
                    case "E12":
                        ChkE12.Checked = true;
                        break;
                    case "E13":
                        ChkE13.Checked = true;
                        break;
                    case "E14":
                        ChkE14.Checked = true;
                        break;
                    case "E15":
                        ChkE15.Checked = true;
                        break;
                    case "E16":
                        ChkE16.Checked = true;
                        break;
                    case "E17":
                        ChkE17.Checked = true;
                        break;
                    case "E18":
                        ChkE18.Checked = true;
                        break;
                    case "E19":
                        ChkE19.Checked = true;
                        break;
                    default:
                        //Console.WriteLine("Default case");
                        break;
                }
            }

        }
        catch (Exception ex)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "alert('" + ex.ToString() + "');", true);
        }
    }

    #region "sub&function"
         protected void SetData()
            {
                string email = Request.QueryString["email"];
                string telno = Request.QueryString["telno"];

                if (email == null && telno == null) 
                {
                    return;
                }

                if ((email != "") || telno != "") {
                 QueryData(email, telno);
                }
            }
         protected void Clear()
    {
       lblid.Text = "0";
       txtTitleOthers.Text="";
      
       txtFirstName.Text="";
       txtLastName.Text="";
       txtPosition.Text = "";
       txtCompany.Text = "";
       txtCity.Text = "";
       txtCountry.Text = "";
       txtZipCode.Text = "";
       txtTelNumber.Text = "";
       txtFaxNumber.Text = "";
       txtEmail.Text = "";
       txtWebSite.Text = "";
       txtAddress.Text = "";
       txtDivition.Text = "";
       txtMobileNo.Text = "";
       for (int i = 0; i <= rdPeriod.Items.Count-1; i++)
       { 
            rdPeriod.Items[i].Selected = false;
       }

       for (int i = 0; i <= rdAnnualSale.Items.Count-1; i++)
       { 
            rdAnnualSale.Items[i].Selected = false;
       }

       for (int i = 0; i <= rdiTitle.Items.Count-1; i++)
       { 
           rdiTitle.Items[i].Selected = false;
       }

        ChkA01.Checked = false;
        ChkA02.Checked = false;
        ChkA03.Checked = false;
        ChkA04.Checked = false;
        ChkA05.Checked = false;
        ChkA06.Checked = false;
        ChkA07.Checked = false;
        ChkA08.Checked = false;
        ChkA09.Checked = false;
        ChkA10.Checked = false;
        ChkA11.Checked = false;
        ChkA12.Checked = false;
        ChkA13.Checked = false;
        ChkA14.Checked = false;
        ChkA15.Checked = false;
        ChkA16.Checked = false;
        ChkA17.Checked = false;
       
        ChkB01.Checked = false;
        ChkB02.Checked = false;
        ChkB03.Checked = false;
        ChkB04.Checked = false;
        ChkB05.Checked = false;
        ChkB06.Checked = false;
        ChkB07.Checked = false;
        ChkB07.Checked = false;
        ChkB08.Checked = false;
        ChkB09.Checked = false;
        ChkB10.Checked = false;
        ChkB11.Checked = false;
        ChkB12.Checked = false;
        ChkB13.Checked = false;
        ChkB14.Checked = false;
        rdiChkB04Facebook.Checked = false;
        rdiB04Other.Checked = false;
        txtB04.Text = "";

        ChkC01.Checked = false;
        ChkC02.Checked = false;
        ChkC03.Checked = false;
        ChkC04.Checked = false;
        ChkC05.Checked = false;
        ChkC06.Checked = false;
        ChkC07.Checked = false;
        
        ChkD01.Checked = false;
        ChkD02.Checked = false;
        
        ChkE01.Checked = false;
        ChkE02.Checked = false;
        ChkE03.Checked = false;
        ChkE04.Checked = false;
        ChkE05.Checked = false;
        ChkE06.Checked = false;
        ChkE07.Checked = false;
        ChkE08.Checked = false;
        ChkE09.Checked = false;
        ChkE10.Checked = false;
        ChkE11.Checked = false;
        ChkE12.Checked = false;
        ChkE13.Checked = false;
        ChkE14.Checked = false;
        ChkE15.Checked = false;
        ChkE16.Checked = false;
        ChkE17.Checked = false;
        ChkE18.Checked = false;
        ChkE19.Checked = false;
        
        txtA10.Text = "";
        txtA10.Enabled = false;
        txtA17.Text = "";
        txtA17.Enabled = false;
       
        txtC07.Text = "";
        txtC07.Enabled = false;
        txtD02.Text = "";
        txtD02.Enabled = false;
    }
         protected Boolean validate()
         {

             if ((txtFirstName.Text == "") && (txtLastName.Text == ""))
             {
                 Config.SetAlert("กรุณาระบุชื่อ", this);
                 return false;
             }

             if (txtEmail.Text != "")
             {
                 if (txtEmail.Text.IndexOf("@") < 0)
                 {
                     Config.SetAlert("กรุณาระบุ E-mail ให้ถูกต้อง", this);
                     return false;
                 }
             }

             if (txtEmail.Text == "")
             {
                 Config.SetAlert("กรุณาระบุ E-mail", this);
                 return false;
             }

             if (txtFirstName.Text.Length < 2)
             {
                 Config.SetAlert("กรุณาระบุชื่อให้ถูกต้อง", this);
                 return false;
             }

             if (txtLastName.Text.Length < 2)
             {
                 Config.SetAlert("กรุณาระบุนามสกุลให้ถูกต้อง", this);
                 return false;
             }

             if (txtMobileNo.Text.Length < 9)
             {
                 Config.SetAlert("กรุณาระบุเบอร์โทรศัพท์", this);
                 return false;
             }

             if (txtAddress.Text.Length < 3)
             {
                 Config.SetAlert("กรุณาระบุที่อยู่", this);
                 return false;
             }

             if (txtMobileNo.Text.Length < 9)
             {
                 Config.SetAlert("กรุณาระบุเบอร์โทรศัพท์", this);
                 return false;
             }

             if ((rdiTitle.Items[0].Selected == false) && (rdiTitle.Items[1].Selected == false) && (rdiTitle.Items[2].Selected == false) && (rdiTitle.Items[3].Selected == false))
             {
                 Config.SetAlert("กรุณาเลือกคำนำหน้า", this);
                 return false;
             }

             if ((rdAnnualSale.Items[0].Selected == false) && (rdAnnualSale.Items[1].Selected == false))
             {
                 Config.SetAlert("กรุณาเลือกยอดขายประจำปี", this);
                 return false;
             }

             return true;

         }
    #endregion

    #region "EventCheckChange"
    protected void rdiTitle_SelectedIndexChange(object sender, EventArgs e)
    {
        if (rdiTitle.SelectedValue == "OTHERS")
        {
            txtTitleOthers.Enabled = true;
        }
        else
        {
            txtTitleOthers.Enabled = false;
            txtTitleOthers.Text = "";
        }
    }

    protected void chkA10_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkA10.Checked == true)
        {
            txtA10.Enabled = true;
        }
        else
        {
            txtA10.Enabled = false;
            txtA10.Text = "";
        }
    }


    protected void chkA17_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkA17.Checked == true)
        {
            txtA17.Enabled = true;
        }
        else
        {
            txtA17.Enabled = false;
            txtA17.Text = "";
        }
    }



    protected void chkB05_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkB05.Checked == true)
        {
            txtB05.Enabled = true;
        }
        else
        {
            txtB05.Enabled = false;
            txtB05.Text = "";
        }
    }

    protected void chkB04_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkB04.Checked == true)
        {
            rdiChkB04Facebook.Checked = true;
        }
        else
        {
            rdiChkB04Facebook.Checked = false;
            rdiB04Other.Checked = false;
            txtB04.Text = "";
        }
    }

    protected void chkB06_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkB06.Checked == true)
        {
            txtB06.Enabled = true;
        }
        else
        {
            txtB06.Enabled = false;
            txtB06.Text = "";
        }
    }

    protected void chkB14_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkB14.Checked == true)
        {
            txtB14.Enabled = true;
        }
        else
        {
            txtB14.Enabled = false;
            txtB14.Text = "";
        }
    }

    protected void chkC07_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkC07.Checked == true)
        {
            txtC07.Enabled = true;
        }
        else
        {
            txtC07.Enabled = false;
            txtC07.Text = "";
        }
    }

    protected void chkD01_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkD01.Checked == true)
        {
            ChkD02.Checked = false;
            txtD02.Enabled = false;
            txtD02.Text = "";
        }

    }

    protected void chkD02_CheckedChanged(object sender, EventArgs e)
    {
        if (ChkD02.Checked == true)
        {
            txtD02.Enabled = true;
            ChkD01.Checked = false;
        }
        else
        {
            txtD02.Enabled = false;
            txtD02.Text = "";
        }
    }

    protected void rdiB04Other_CheckedChanged(object sender, EventArgs e)
    {
        if (rdiB04Other.Checked == true)
        {
            txtB04.Enabled = true;
        }


    }

    protected void rdiChkB04Facebook_CheckedChanged(object sender, EventArgs e)
    {
        if (rdiChkB04Facebook.Checked == true)
        {
            txtB04.Enabled = false;
            txtB04.Text = "";
        }


    }
    #endregion

 

    protected void btnSave_Click(object sender, EventArgs e)
    {

        if (validate() == false) return;

        String strServerName = ConfigurationManager.AppSettings["ServerName"];
        String strDbName = ConfigurationManager.AppSettings["DbName"];
        String strDbUserID = ConfigurationManager.AppSettings["DbUserID"];
        String strDbPwd = ConfigurationManager.AppSettings["DbPwd"];

        SqlConnection objConn = new SqlConnection("Data Source=" + strServerName +";Initial Catalog=" + strDbName +";User ID=" +strDbUserID + ";password=" + strDbPwd );
        if (objConn.State == ConnectionState.Closed) { objConn.Open(); }


        if (lblid.Text == "0")
        {
            String strSql = "";
            strSql = "Select Count(*) From ERM_TS_Personal_info Where first_name='" + txtFirstName.Text + "' And last_name='" + txtLastName.Text + "'";
            SqlCommand objCmd = new SqlCommand(strSql, objConn);
            String Result = Convert.ToString(objCmd.ExecuteScalar());
            if (Result != "0")
            {
                Config.SetAlert("ชื่อนี้ได้ทำการลงทะเบียนแล้ว", this);
                return;
            }

            strSql = "Select Count(*) From ERM_TS_Personal_info Where Email='" + txtEmail.Text + "' ";
            objCmd = new SqlCommand(strSql, objConn);
            Result = Convert.ToString(objCmd.ExecuteScalar());
            if (Result != "0")
            {
                Config.SetAlert("อีเมลล์นี้ได้ทำการลงทะเบียนแล้ว", this);
                return;
            }

            strSql = "Select Count(*) From ERM_TS_Personal_info Where Mobile_No='" + txtMobileNo.Text + "' ";
            objCmd = new SqlCommand(strSql, objConn);
            Result = Convert.ToString(objCmd.ExecuteScalar());
            if (Result != "0")
            {
                Config.SetAlert("เบอร์โทรนี้ได้ทำการลงทะเบียนแล้ว", this);
                return;
            }
        }    

       

        int intChkA = 0;
        int intChkB = 0;
        int intChkC = 0;
        int intChkD = 0;
        int intChkE = 0;

        if ((rdPeriod.Items[0].Selected == false) && (rdPeriod.Items[1].Selected == false))
        {
            Config.SetAlert("กรุณาเลือกช่วงเวลาเข้าร่วมงาน", this);
            return;
        }

        if (ChkA01.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA02.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA03.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA04.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA05.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA06.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA07.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA08.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA09.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA10.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA11.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA12.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA13.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA14.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA15.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA16.Checked == true)
        {
            intChkA += 1;
        }
        if (ChkA17.Checked == true)
        {
            intChkA += 1;
        }

        if (ChkB01.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB02.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB03.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB04.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB05.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB06.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB07.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB08.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB09.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB10.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB11.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB12.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB13.Checked == true)
        {
            intChkB += 1;
        }
        if (ChkB14.Checked == true)
        {
            intChkB += 1;
        }

        if (ChkC01.Checked == true)
        {
            intChkC += 1;
        }
        if (ChkC02.Checked == true)
        {
            intChkC += 1;
        }
        if (ChkC03.Checked == true)
        {
            intChkC += 1;
        }
        if (ChkC04.Checked == true)
        {
            intChkC += 1;
        }
        if (ChkC05.Checked == true)
        {
            intChkC += 1;
        }
        if (ChkC06.Checked == true)
        {
            intChkC += 1;
        }
        if (ChkC07.Checked == true)
        {
            intChkC += 1;
        }

        if (ChkD01.Checked == true)
        {
            intChkD += 1;
        }
        if (ChkD02.Checked == true)
        {
            intChkD += 1;
        }
        
        if (ChkE01.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE02.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE03.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE04.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE05.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE06.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE07.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE08.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE09.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE10.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE11.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE12.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE13.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE14.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE15.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE16.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE17.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE18.Checked == true)
        {
            intChkE += 1;
        }
        if (ChkE19.Checked == true)
        {
            intChkE += 1;
        }
        

        if (intChkA == 0)
        {
            Config.SetAlert("กรุณาระบุประเภทธุรกิจของท่าน", this);
            return;
        }

        if (intChkB == 0)
        {
            Config.SetAlert("กรุณาระบุช่องทางการได้รับข่าวสาร", this);
            return;
        }

        if (intChkC == 0)
        {
            Config.SetAlert("กรุณาระบุวัตถุประสงค์ของการเข้าชมงาน", this);
            return;
        }

        if (intChkD == 0)
        {
            Config.SetAlert("กรุณาระบุความต้องการการเข้าชม", this);
            return;
        }

        if (intChkE == 0)
        {
            Config.SetAlert("กรุณาระบุประเภทสินค้าหรือบริการที่ท่านสนใจ", this);
            return;
        }

        //Page.Form.DefaultFocus = txtFirstName.ClientID;

        ErmTsPersonalInfoPara Erm = new ErmTsPersonalInfoPara();
        if (lblid.Text != "0")
        {
            Erm.ID =  Convert.ToInt64(lblid.Text);
        }
        Erm.IDCARD_NO = "0"; //txtIDCardNo.Text;
        Erm.TITLE_NAME = rdiTitle.SelectedValue;
        if (rdiTitle.SelectedValue == "OTHERS") 
        {
            Erm.TITLE_NAME = txtTitleOthers.Text;
        }
        Erm.FIRST_NAME = txtFirstName.Text;
        Erm.MIDDLE_NAME = "";// txtMiddleName.Text;
        Erm.LAST_NAME = txtLastName.Text;
        Erm.POSITION_NAME = txtPosition.Text;
        Erm.COMPANY_NAME = txtCompany.Text;
        Erm.ADDRESS = txtAddress.Text;
        Erm.CITY = txtCity.Text;
        Erm.STATE = "";//txtState.Text;
        Erm.COUNTRY = txtCountry.Text;
        Erm.ZIPCODE = txtZipCode.Text;
        Erm.TELNO = txtTelNumber.Text;
        Erm.FAXNO = txtFaxNumber.Text;
        Erm.EMAIL = txtEmail.Text;
        Erm.WEBSITE = txtWebSite.Text;
        Erm.DIVISION = txtDivition.Text;
        Erm.MOBILE_NO = txtMobileNo.Text;
        if ((rdPeriod.Items[0].Selected == true) && (rdPeriod.Items[1].Selected == true))
        {
            Erm.REGISPERIOD = "3";
        }
        else
        {
               Erm.REGISPERIOD = rdPeriod.SelectedValue;
        }
        
        

       // if (txtRegisteredCapital.Text != "")
            Erm.REGISTERED_CAPITAL = 0;//Convert.ToDouble(txtRegisteredCapital.Text);

        Erm.ANNUAL_SALE_VALUE_YEAR = DateTime.Today.Year;
        Erm.ANNUAL_SALE_VALUE_VOLUMNS = rdAnnualSale.SelectedValue;

        TransactionDB Trans = new TransactionDB();
        Engine.Questionnaire.RegisterENG eng = new Engine.Questionnaire.RegisterENG();

        long id;
        id = eng.SavePersonalInfo(Erm, "Register", Trans);
        if (id > 0)
        {

            bool IsDel = true;
            IsDel = eng.DeleteInterest(id, Trans);
            if (IsDel == false)
            {
                Trans.RollbackTransaction();
                ScriptManager.RegisterStartupScript(this, this.GetType(), Guid.NewGuid().ToString(), "alert('ไม่สามารถบันทึกข้อมูลได้');", true);
                return;
            }

            SaveDetail(ChkA01, id, Trans,"","A");
            SaveDetail(ChkA02, id, Trans, "", "A");
            SaveDetail(ChkA03, id, Trans, "", "A");
            SaveDetail(ChkA04, id, Trans, "", "A");
            SaveDetail(ChkA05, id, Trans, "", "A");
            SaveDetail(ChkA06, id, Trans, "", "A");
            SaveDetail(ChkA07, id, Trans, "", "A");
            SaveDetail(ChkA08, id, Trans, "", "A");
            SaveDetail(ChkA09, id, Trans, "", "A");
            SaveDetail(ChkA10, id, Trans, txtA10.Text, "A");
            SaveDetail(ChkA11, id, Trans, "", "A");
            SaveDetail(ChkA12, id, Trans, "", "A");
            SaveDetail(ChkA13, id, Trans, "", "A");
            SaveDetail(ChkA14, id, Trans, "", "A");
            SaveDetail(ChkA15, id, Trans, "", "A");
            SaveDetail(ChkA16, id, Trans, "", "A");
            SaveDetail(ChkA17, id, Trans, txtA17.Text, "A");


            SaveDetail(ChkB01, id, Trans, "", "B");
            SaveDetail(ChkB02, id, Trans, "", "B");
            SaveDetail(ChkB03, id, Trans, "", "B");
            SaveDetail(ChkB04, id, Trans, txtB04.Text, "B");
            SaveDetail(ChkB05, id, Trans, txtB05.Text, "B");
            SaveDetail(ChkB06, id, Trans, txtB06.Text, "B");
            SaveDetail(ChkB07, id, Trans, "", "B");
            SaveDetail(ChkB08, id, Trans, "", "B");
            SaveDetail(ChkB09, id, Trans, "", "B");
            SaveDetail(ChkB10, id, Trans, "", "B");
            SaveDetail(ChkB11, id, Trans, "", "B");
            SaveDetail(ChkB12, id, Trans, "", "B");
            SaveDetail(ChkB13, id, Trans, "", "B");
            SaveDetail(ChkB14, id, Trans, txtB14.Text, "B");

            SaveDetail(ChkC01, id, Trans, "", "C");
            SaveDetail(ChkC02, id, Trans, "", "C");
            SaveDetail(ChkC03, id, Trans, "", "C");
            SaveDetail(ChkC04, id, Trans, "", "C");
            SaveDetail(ChkC05, id, Trans, "", "C");
            SaveDetail(ChkC06, id, Trans, "", "C");
            SaveDetail(ChkC07, id, Trans, txtC07.Text, "C");

            SaveDetail(ChkD01, id, Trans, "", "D");
            SaveDetail(ChkD02, id, Trans, txtD02.Text, "D");

            SaveDetail(ChkE01, id, Trans, "", "E");
            SaveDetail(ChkE02, id, Trans, "", "E");
            SaveDetail(ChkE03, id, Trans, "", "E");
            SaveDetail(ChkE04, id, Trans, "", "E");
            SaveDetail(ChkE05, id, Trans, "", "E");
            SaveDetail(ChkE06, id, Trans, "", "E");
            SaveDetail(ChkE07, id, Trans, "", "E");
            SaveDetail(ChkE08, id, Trans, "", "E");
            SaveDetail(ChkE09, id, Trans, "", "E");
            SaveDetail(ChkE10, id, Trans, "", "E");
            SaveDetail(ChkE11, id, Trans, "", "E");
            SaveDetail(ChkE12, id, Trans, "", "E");
            SaveDetail(ChkE13, id, Trans, "", "E");
            SaveDetail(ChkE14, id, Trans, "", "E");
            SaveDetail(ChkE15, id, Trans, "", "E");
            SaveDetail(ChkE16, id, Trans, "", "E");
            SaveDetail(ChkE17, id, Trans, "", "E");
            SaveDetail(ChkE18, id, Trans, "", "E");
            SaveDetail(ChkE19, id, Trans, "", "E");

            Trans.CommitTransaction();

            bool ret = false;
            ret = clsSendMail.SendEmailMessage(txtEmail.Text, "rfidhero2014@scoresolutions.co.th", "mail.scoresolutions.co.th", "1qaz@WSX", txtFirstName.Text + " " + txtLastName.Text, id.ToString(), Server.MapPath("~/image/PrintAdsTheretrunofRFIDHERO_Resize.jpg"), 25, false, Server.MapPath("~/image/logo.png"));

            if (ret == false)
            {
                ret = clsSendMail.SendEmailMessage(txtEmail.Text, "rfidhero2014@hotmail.com", "smtp.live.com", "1qaz@WSX", txtFirstName.Text + " " + txtLastName.Text, id.ToString(), Server.MapPath("~/image/PrintAdsTheretrunofRFIDHERO_Resize.jpg"), 587, true, Server.MapPath("~/image/logo.png"));
            }

            if (ret == true)
            {
                Trans = new TransactionDB();
                if (eng.UpdateIsSendMail(id, "Register", Trans) == true)
                {
                    Trans.CommitTransaction();
                }
                else
                {
                    Trans.RollbackTransaction();
                }
            }
            eng = null;


            //Response.Redirect("../WebApp/frmRegisterComplete.aspx?id=" + Convert.ToString(id));
            //Config.ShowModalDialog("../WebApp/frmRegisterEmailComplete.aspx?id=" +id, this);
            Config.RedirecPage("../WebApp/frmRegisterEmailComplete.aspx?id=" + id, this);
            Clear();
        }

        else { 
            Trans.RollbackTransaction();
            Config.SetAlert("ไม่สามารถบันทึกข้อมูลได้",this);
             }

    }

    protected bool SaveDetail(CheckBox chk, long id, TransactionDB Trans ,string str,string section) {
        bool ret =false;
        
        if (chk.Checked == true){
        string InteresCode = chk.Text.Substring(0,2);
        string InteresName = chk.Text.Substring(3);
       

        ErmTsInterestPara Erm = new ErmTsInterestPara();
        Erm.ERM_TS_PERSONAL_INFO_ID = id;
        Erm.INTEREST_CODE = section + InteresCode;
       if (str != "")  {InteresName=InteresName + "##" + str;}
       Erm.INTEREST_NAME = InteresName;
       Engine.Questionnaire.RegisterENG eng = new Engine.Questionnaire.RegisterENG();
       ret=  eng.SaveInterest(Erm, "Register", Trans);
    }
        return ret;
    }
 
    protected void btnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Config.RedirecPage("../WebApp/frmMain.aspx", this);
    }
}
