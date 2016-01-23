using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Para.TABLE;
using Engine.Questionnaire;

public partial class WebApp_frmRegisterComplete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) {
            if (Request["id"] != null) {
                ErmTsPersonalInfoPara p = new ErmTsPersonalInfoPara();
                RegisterENG eng = new RegisterENG();
                p = eng.GetRegisterInfo(Convert.ToInt64(Request["id"]));
                eng=null;

                if (p.ID>0){
                    if (p.MIDDLE_NAME.Trim() != "")
                        lblName.Text = p.FIRST_NAME + " " + p.MIDDLE_NAME + " " + p.LAST_NAME;
                    else
                        lblName.Text = p.FIRST_NAME + " " + p.LAST_NAME;

                    lblID.Text = p.ID.ToString().PadLeft(6, '0');
                }
                p = null;
            }
        }
    }
}
