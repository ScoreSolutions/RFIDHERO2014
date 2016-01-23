using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Linq.Common.Utilities;

public partial class WebApp_frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {

            divLogin.Style.Add("display", "none");
            div1.Style.Add("display", "block");
            lblerror.Text = "";
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Config.RedirecPage("../WebApp/frmRegister2.aspx", this);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblerror.Text = "";
        if ((txtEmail.Text.Trim()) != "" && (txtEmail.Text.IndexOf("@") < 0))
        {
           
            lblerror.Text = "กรุณาระบุ E-mail ให้ถูกต้อง";
            return;
        }

        if (txtEmail.Text.Trim() == "" && txtMobileNo.Text.Trim() =="")
        {
           
            lblerror.Text = "กรุณาระบุข้อมูลเพื่อค้นหา";
            return;
        }

        Linq.TABLE.ErmTsPersonalInfoLinq lnq = new Linq.TABLE.ErmTsPersonalInfoLinq();
        DataTable dt = new DataTable();
        TransactionDB trans = new  TransactionDB();
        string sql = "select count(*) from ERM_TS_PERSONAL_INFO where 1=1";
        if (txtEmail.Text.Trim() != "")
        {
            sql += " And Email ='" + txtEmail.Text.Trim() + "' ";
        }

         if (txtMobileNo.Text.Trim() != "")
        {
            sql += " And mobile_no ='" + txtMobileNo.Text.Trim() + "' ";
        }
        dt = lnq.GetListBySql(sql, trans.Trans);
        if (dt.Rows[0][0].ToString() == "0")
        {
            lblerror.Text = "ไม่พบข้อมูล กรุณาลงทะเบียนใหม่อีกครั้ง";
            return;
        }

       
        Config.RedirecPage("../WebApp/frmRegister2.aspx?email=" + txtEmail.Text + "&telno=" + txtMobileNo.Text + "", this);
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        divLogin.Style.Add("display", "block");
        div1.Style.Add("display", "none");
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        Config.RedirecPage("../WebApp/frmRegister2.aspx",this);
    }
}
