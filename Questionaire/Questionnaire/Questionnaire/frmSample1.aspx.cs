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
using Engine.Questionnaire;
using Engine.Common;
using Para.TABLE;

public partial class Questionnaire_frmSample1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DbTrans trans = new DbTrans();
            trans.CreateTransaction();
            DataTable dt;
            //dt.Columns.Add("id");
            //dt.Columns.Add("section_name");
            //for (int i = 0; i <= 5; i++) {
            //    DataRow dr = dt.NewRow();
            //    dr["id"] = (i+1);
            //    dr["section_name"] = "ส่วนที่ " + (i+1) + " กกกกกกกกกกกกกกกกกกก";
            //    dt.Rows.Add(dr);
            //}

            if (Request["id"] != null)
            {
                QuestionnaireENG eng = new QuestionnaireENG();
                QuestionnairePara para = new QuestionnairePara();
                para = eng.GetQuestionnarePara(Convert.ToInt64(Request["id"]), trans);
                txtID.Text = para.ID.ToString();
                lblQusitionnaireName.Text = para.QUESTIONNAIRE_NAME;
                lblQuestionnaireObjective.Text = para.OBJECTIVE;
                lblQuestionnaireDesc.Text = para.DESCRIPTION;

                dt = eng.GetQuestionnaireSectionList(Convert.ToInt64(Request["id"]), trans);
                gvSection.DataSource = dt;
                gvSection.DataBind();
                trans.CommitTransaction();
            }
        }
    }
    protected void gvSection_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (IsPostBack == false)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //DataTable dt = new DataTable();
                //dt.Columns.Add("id");
                //dt.Columns.Add("exam_name");
                //for (int i = 0; i <= 3; i++) {
                //    DataRow dr = dt.NewRow();
                //    dr["id"] = i;
                //    dr["exam_name"] = "ข้อที่ " + (i+1) + "  ขขขขขขขขขขขขขขขขขขข";
                //    dt.Rows.Add(dr);
                //}


                if (e.Row.Cells[0].Text != "")
                {
                    DbTrans trans = new DbTrans();
                    trans.CreateTransaction();
                    long SectionID = Convert.ToInt64(e.Row.Cells[0].Text);
                    QuestionnaireENG eng = new QuestionnaireENG();

                    DataTable dt = eng.GetQuestionnaireQuestionList(SectionID, trans);
                    Config.BuildNoColumn(dt);
                    GridView gvQuestion = (GridView)e.Row.FindControl("gvQuestion");
                    gvQuestion.DataSource = dt;
                    gvQuestion.DataBind();

                    SectionTypePara secPara = eng.GetSectionTypePara(SectionID, trans);
                    if (secPara.ID == 1)
                    {
                        gvQuestion.Columns[3].Visible = false;
                        gvQuestion.Width = Unit.Percentage(100);
                    }
                    else if (secPara.ID == 2)
                    {
                        gvQuestion.Columns[3].Visible = true;
                    }

                    trans.CommitTransaction();
                }
            }
        }
    }

    protected void gvQuestion_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (IsPostBack == false)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DbTrans trans = new DbTrans();
                trans.CreateTransaction();
                long QuestionID = Convert.ToInt64(e.Row.Cells[0].Text);
                QuestionnaireENG eng = new QuestionnaireENG();
                QuestionnaireQuestionsPara para = eng.GetQuestionQuestionPara(QuestionID, trans);
                QuestionnaireSectionPara secPara = eng.GetQuestionnaireSectionPara(para.QUESTIONNAIRE_SECTION_ID, trans);

                if (secPara.SECTION_TYPE_ID == 1)
                {
                    if (para.CHOICE_TYPE_ID == 1)
                    {
                        DataTable dt = eng.GetChoiceList(QuestionID, trans);
                        DataTable dtConfig = eng.GetQuestionConfig(QuestionID, trans);
                        if (dt.Rows.Count > 0)
                        {
                            RadioButtonList rdiChoice = (RadioButtonList)e.Row.Cells[2].FindControl("rdiChoice");
                            foreach (DataRow dr in dtConfig.Rows)
                            {
                                if (dr["config_name"].ToString() == "RepeatDirection")
                                {
                                    rdiChoice.RepeatDirection = (dr["config_value"].ToString() == "Horizontal" ? RepeatDirection.Horizontal : RepeatDirection.Vertical);
                                }
                            }

                            rdiChoice.Visible = true;
                            rdiChoice.DataTextField = "choice_name";
                            rdiChoice.DataValueField = "id";
                            rdiChoice.DataSource = dt;
                            rdiChoice.DataBind();
                            //rdiChoice.SelectedValue=

                            Label lblTextChoiceName = (Label)e.Row.Cells[2].FindControl("lblTextChoiceName");

                            int j = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (dr["is_other"].ToString() == "Y")
                                {
                                    TextBox txtRadioChoice = (TextBox)e.Row.Cells[2].FindControl("txtRadioChoice");
                                    txtRadioChoice.Visible = true;
                                    rdiChoice.AutoPostBack = true;
                                }
                                if (dr["is_default"].ToString() == "Y") {
                                    rdiChoice.Items[j].Selected = true;
                                }
                                j++;
                            }
                        }
                    }
                    else if (para.CHOICE_TYPE_ID == 2) {
                        DataTable dt = eng.GetChoiceList(QuestionID, trans);
                        if (dt.Rows.Count > 0)
                        {
                            CheckBoxList chkChoice = (CheckBoxList)e.Row.Cells[2].FindControl("chkChoice");
                            chkChoice.Visible = true;
                            chkChoice.DataTextField = "choice_name";
                            chkChoice.DataValueField = "id";
                            chkChoice.DataSource = dt;
                            chkChoice.DataBind();

                            int j = 0;
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (dr["is_other"].ToString() == "Y")
                                {
                                    TextBox txtCheckBoxChoice = (TextBox)e.Row.Cells[2].FindControl("txtCheckBoxChoice");
                                    txtCheckBoxChoice.Visible = true;
                                    chkChoice.AutoPostBack = true;
                                }
                                if (dr["is_default"].ToString() == "Y")
                                {
                                    chkChoice.Items[j].Selected = true;
                                }
                                j++;
                            }
                        }
                    }
                    else if (para.CHOICE_TYPE_ID == 3) {
                        TextBox txtChoice = (TextBox)e.Row.Cells[2].FindControl("txtChoice");
                        txtChoice.Visible = true;

                        DataTable dt = eng.GetChoiceList(QuestionID, trans);
                        if (dt.Rows.Count > 0)
                        {
                            Label lblTextChoiceName = (Label)e.Row.Cells[2].FindControl("lblTextChoiceName");
                            lblTextChoiceName.Visible = true;
                            lblTextChoiceName.Text = dt.Rows[0]["choice_name"].ToString();
                        }
                    }
                    else if (para.CHOICE_TYPE_ID == 4)
                    {
                        TextBox txtChoice = (TextBox)e.Row.Cells[2].FindControl("txtChoice");
                        txtChoice.Visible = true;

                        DataTable dt = eng.GetChoiceList(QuestionID, trans);
                        if (dt.Rows.Count > 0)
                        {
                            Label lblTextChoiceName = (Label)e.Row.Cells[2].FindControl("lblTextChoiceName");
                            lblTextChoiceName.Visible = true;
                            lblTextChoiceName.Text = dt.Rows[0]["choice_name"].ToString();
                        }
                    }
                }
                else if (secPara.SECTION_TYPE_ID == 2)
                {
                    RadioButtonList rdiSec2Choice = (RadioButtonList)e.Row.Cells[3].FindControl("rdiSec2Choice");
                    rdiSec2Choice.Visible = true;
                    rdiSec2Choice.Width = 40 * Convert.ToInt16(secPara.CHOICE_QTY);
                    for (int i = 0; i < secPara.CHOICE_QTY; i++)
                    {
                        rdiSec2Choice.Items.Add(new ListItem((i + 1).ToString(), (i + 1).ToString()));
                    }
                }
                trans.CommitTransaction();
            }
        }
    }


    protected void rdiChoice_SelectedIndexChanged(object sender, EventArgs e)
    {
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();
        QuestionnaireENG eng = new QuestionnaireENG();
        RadioButtonList rdiChoice = (RadioButtonList)sender;
        QuestionnaireQuestionsChoicePara para = eng.GetQuestionnaireQuestionChoicePara(Convert.ToInt64(rdiChoice.SelectedValue), trans);
        GridViewRow gRow = (GridViewRow)rdiChoice.Parent.Parent;
        TextBox txtRadioChoice = (TextBox)gRow.Cells[2].FindControl("txtRadioChoice");
        if (para.IS_OTHER == 'Y')
            txtRadioChoice.Enabled = true;
        else
            txtRadioChoice.Enabled = false;

        trans.CommitTransaction();
    }

    protected void chkChoice_SelectedIndexChanged(object sender, EventArgs e)
    {
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();
        QuestionnaireENG eng = new QuestionnaireENG();
        CheckBoxList chkChoice = (CheckBoxList)sender;
        GridViewRow gRow = (GridViewRow)chkChoice.Parent.Parent;
        TextBox txtCheckBoxChoice = (TextBox)gRow.Cells[2].FindControl("txtCheckBoxChoice");
        txtCheckBoxChoice.Enabled = false;
        for (int i = 0; i < chkChoice.Items.Count; i++) {
            if (chkChoice.Items[i].Selected)
            {
                QuestionnaireQuestionsChoicePara para = eng.GetQuestionnaireQuestionChoicePara(Convert.ToInt64(chkChoice.Items[i].Value), trans);
                if (para.IS_OTHER == 'Y')
                    txtCheckBoxChoice.Enabled = true;
            }
        }

        trans.CommitTransaction();
    }

    protected void btnSave_Click(object sender, System.EventArgs e) {
        if (Valid() == true)
        {
            bool ret = false;

            DbTrans trans = new DbTrans();
            trans.CreateTransaction();

            string LoginName = "SYSTEM";

            QuestionnaireENG eng = new QuestionnaireENG();

            AnswerPara ans = new AnswerPara();
            ans.QUESTIONNAIRE_ID =Convert.ToInt64(txtID.Text);
            ans.ANSWER_NAME = "System Admin";
            ans.ANSWER_DATE = DateTime.Now;
            ans.SESSION_ID = Session.SessionID;

            if (eng.SaveAnswer(ans, LoginName, trans) == true)
            {
                for (int m = 0; m < gvSection.Rows.Count; m++)
                {
                    GridView gvQuestion = (GridView)gvSection.Rows[m].Cells[1].FindControl("gvQuestion");
                    for (int i = 0; i < gvQuestion.Rows.Count; i++)
                    {
                        Label lblQuestionName = (Label)gvQuestion.Rows[i].Cells[2].FindControl("lblQuestionName");
                        long QuestionID = Convert.ToInt64(gvQuestion.Rows[i].Cells[0].Text);

                        AnswerResultPara Apara = new AnswerResultPara();
                        //Apara.ANSWER_NAME = 
                        //Apara.QUESTIONNAIRE_ID = Convert.ToInt64(txtID.Text);
                        Apara.ANSWER_ID = eng.ANSWER_ID;
                        Apara.QUESTIONNAIRE_QUESTION_ID = QuestionID;
                        Label lblChoiceTypeID = (Label)gvQuestion.Rows[i].Cells[1].FindControl("lblChoiceTypeID");
                        Label lblQuestionPoint = (Label)gvQuestion.Rows[i].Cells[1].FindControl("lblQuestionPoint");

                        if (lblChoiceTypeID.Text == "1")
                        {
                            //Section
                            long SectionID = Convert.ToInt64(gvSection.Rows[m].Cells[0].Text);
                            QuestionnaireSectionPara QsPara = eng.GetQuestionnaireSectionPara(SectionID, trans);
                            if (QsPara.SECTION_TYPE_ID == 1)
                            {
                                //แบบหลายตัวเลือก ตอบได้ 1 ข้อ สำหรับส่วนที่ 1
                                RadioButtonList rdiChoice = (RadioButtonList)gvQuestion.Rows[i].Cells[2].FindControl("rdiChoice");
                                if (rdiChoice.SelectedValue != "")
                                {
                                    QuestionnaireQuestionsChoicePara ctPara = eng.GetQuestionnaireQuestionChoicePara(Convert.ToInt64(rdiChoice.SelectedValue), trans);
                                    Apara.CHOICE_TYPE_ID = 1;
                                    Apara.RESULT_CHOICE_NAME = rdiChoice.SelectedItem.Text;
                                    Apara.POINT = ctPara.POINT;
                                    if (ctPara.IS_OTHER == 'Y')
                                    {
                                        TextBox txtRadioChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtRadioChoice");
                                        Apara.RESULT_CHOICE_NAME = txtRadioChoice.Text;
                                    }
                                    ret = eng.SaveAnswerResult(Apara, LoginName, trans);
                                }
                            }
                            else if (QsPara.SECTION_TYPE_ID == 2)
                            {
                                //แบบหลายตัวเลือก ตอบได้ 1 ข้อ สำหรับส่วนที่ 2
                                RadioButtonList rdiSec2Choice = (RadioButtonList)gvQuestion.Rows[i].Cells[3].FindControl("rdiSec2Choice");
                                if (rdiSec2Choice.SelectedValue != "")
                                {
                                    Apara.CHOICE_TYPE_ID = 1;
                                    Apara.RESULT_CHOICE_NAME = rdiSec2Choice.SelectedValue;
                                    Apara.POINT = Convert.ToDouble(rdiSec2Choice.SelectedValue);
                                    ret = eng.SaveAnswerResult(Apara, LoginName, trans);
                                }
                            }
                        }
                        else if (lblChoiceTypeID.Text == "2")
                        {
                            //แบบหลายตัวเลือก ตอบได้มากกว่า 1 ข้อ
                            CheckBoxList chkChoice = (CheckBoxList)gvQuestion.Rows[i].Cells[2].FindControl("chkChoice");
                            for (int j = 0; j < chkChoice.Items.Count; j++)
                            {
                                if (chkChoice.Items[j].Selected)
                                {
                                    Apara.CHOICE_TYPE_ID = 2;
                                    Apara.RESULT_CHOICE_NAME = chkChoice.Items[j].Text;
                                    QuestionnaireQuestionsChoicePara ctPara = eng.GetQuestionnaireQuestionChoicePara(Convert.ToInt64(chkChoice.Items[j].Value), trans);
                                    Apara.POINT = ctPara.POINT;
                                    if (ctPara.IS_OTHER == 'Y')
                                    {
                                        TextBox txtCheckBoxChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtCheckBoxChoice");
                                        Apara.RESULT_CHOICE_NAME = txtCheckBoxChoice.Text;
                                    }

                                    ret = eng.SaveAnswerResult(Apara, LoginName, trans);
                                }
                            }
                        }
                        else if (lblChoiceTypeID.Text == "3")
                        {
                            //แบบให้ความเห็น ระบุเป็นข้อความ
                            TextBox txtChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtChoice");
                            Apara.CHOICE_TYPE_ID = 3;
                            Apara.RESULT_CHOICE_NAME = txtChoice.Text;
                            Apara.POINT = Convert.ToInt64(lblQuestionPoint.Text);
                            ret = eng.SaveAnswerResult(Apara, LoginName, trans);
                        }
                        else if (lblChoiceTypeID.Text == "4")
                        {
                            //แบบให้ความเห็น ระบุเป็นตัวเลข
                            TextBox txtChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtChoice");
                            Apara.CHOICE_TYPE_ID = 4;
                            Apara.RESULT_CHOICE_NAME = txtChoice.Text;
                            Apara.POINT = Convert.ToInt64(lblQuestionPoint.Text);
                            ret = eng.SaveAnswerResult(Apara, LoginName, trans);
                        }

                        if (ret == false)
                        {
                            break;
                        }
                    }
                }
                if (ret == true)
                    trans.CommitTransaction();
                else
                {
                    trans.RollbackTransaction();
                    Config.SetAlert("Error!!!", this);
                }
            }
            else
            {
                trans.RollbackTransaction();
                Config.SetAlert("Answer Error!!!", this);
            }
        }
    }

    private bool Valid() {
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();
        bool ret = true;
        for (int m = 0; m < gvSection.Rows.Count; m++)
        {
            GridView gvQuestion = (GridView)gvSection.Rows[m].Cells[1].FindControl("gvQuestion");
            for (int i = 0; i < gvQuestion.Rows.Count; i++)
            {
                Label lblChoiceTypeID = (Label)gvQuestion.Rows[i].Cells[1].FindControl("lblChoiceTypeID");
                Label lblQuestionName = (Label)gvQuestion.Rows[i].Cells[2].FindControl("lblQuestionName");
                long QuestionID = Convert.ToInt64(gvQuestion.Rows[i].Cells[0].Text);
                QuestionnaireENG eng = new QuestionnaireENG();
                QuestionnaireQuestionsPara QuestionPara = eng.GetQuestionQuestionPara(QuestionID,trans);
                if (QuestionPara.IS_REQUIRE == 'Y')
                {
                    if (lblChoiceTypeID.Text == "1")
                    {
                        //Section
                        long SectionID = Convert.ToInt64(gvSection.Rows[m].Cells[0].Text);
                        if (SectionID == 1)
                        {
                            RadioButtonList rdiChoice = (RadioButtonList)gvQuestion.Rows[i].Cells[2].FindControl("rdiChoice");
                            if (rdiChoice.SelectedValue == "")
                            {
                                //แบบหลายตัวเลือก ตอบได้ 1 ข้อ สำหรับส่วนที่ 1
                                ret = false;
                                Config.SetAlert("กรุณาเลือกคำตอบสำหรับ " + lblQuestionName.Text, this);
                            }
                            else { 
                                //กรณีเลือกอื่นๆ ถ้าไม่ได้ระบุอื่นๆ มาให้ Alert
                                DataTable dt = eng.GetChoiceList(QuestionID, trans);
                                foreach (DataRow dr in dt.Rows) {
                                    if (dr["is_other"].ToString() == "Y" && rdiChoice.SelectedValue==dr["id"])
                                    {
                                        TextBox txtRadioChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtRadioChoice");
                                        if (txtRadioChoice.Text.Trim() == "") {
                                            ret = false;
                                            Config.SetAlert("กรุณาเลือกคำตอบสำหรับ " + lblQuestionName.Text, this,txtRadioChoice.ClientID);
                                        }
                                    }
                                }
                            }
                        }
                        else if (SectionID == 2)
                        {
                            RadioButtonList rdiSec2Choice = (RadioButtonList)gvQuestion.Rows[i].Cells[3].FindControl("rdiSec2Choice");
                            if (rdiSec2Choice.SelectedValue == "")
                            {
                                //แบบหลายตัวเลือก ตอบได้ 1 ข้อ สำหรับส่วนที่ 2
                                ret = false;
                                Config.SetAlert("กรุณาเลือกคำตอบสำหรับ " + lblQuestionName.Text, this);
                            }
                        }
                    }
                    else if (lblChoiceTypeID.Text == "2")
                    {
                        //แบบหลายตัวเลือก ตอบได้มากกว่า 1 ข้อ
                        CheckBoxList chkChoice = (CheckBoxList)gvQuestion.Rows[i].Cells[2].FindControl("chkChoice");
                        bool isSelect = false;
                        for (int j = 0; j < chkChoice.Items.Count; j++)
                        {
                            if (chkChoice.Items[j].Selected)
                            {
                                QuestionnaireQuestionsChoicePara qqc = new QuestionnaireQuestionsChoicePara();
                                qqc = eng.GetQuestionnaireQuestionChoicePara(Convert.ToInt64(chkChoice.Items[j].Value), trans);
                                if (qqc.IS_OTHER == 'Y')
                                {
                                    TextBox txtCheckBoxChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtCheckBoxChoice");
                                    if (txtCheckBoxChoice.Text.Trim() != "")
                                        isSelect = true;
                                    else
                                    {
                                        isSelect = false;
                                        break;
                                    }
                                }
                                else 
                                    isSelect = true;
                            }
                        }
                        if (isSelect == false)
                        {
                            ret = false;
                            Config.SetAlert("กรุณาเลือกคำตอบสำหรับ " + lblQuestionName.Text, this);
                        }
                    }
                    else if (lblChoiceTypeID.Text == "3")
                    {
                        //แบบให้ความเห็น ระบุเป็นข้อความ
                        TextBox txtChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtChoice");
                        if (txtChoice.Text.Trim() == "")
                        {
                            ret = false;
                            Config.SetAlert("กรุณาเลือกคำตอบสำหรับ " + lblQuestionName.Text, this);
                        }
                    }
                    else if (lblChoiceTypeID.Text == "4")
                    {
                        //แบบให้ความเห็น ระบุเป็นตัวเลข
                        TextBox txtChoice = (TextBox)gvQuestion.Rows[i].Cells[2].FindControl("txtChoice");
                        if (txtChoice.Text.Trim() == "")
                        {
                            ret = false;
                            Config.SetAlert("กรุณาเลือกคำตอบสำหรับ " + lblQuestionName.Text, this);
                        }
                    }
                }
            }
        }
        trans.CommitTransaction();
        return ret;
    }
}
