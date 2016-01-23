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
using Para.VIEW;

public partial class Questionnaire_QuestionnaireForm : System.Web.UI.Page
{
    string _err = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) { 
            if(Request["id"] != null){
                SetQuestionnaireForm(Convert.ToInt64(Request["id"]));
            }
            SetCombo();
        }
    }

    private void SetQuestionnaireForm(long vID) {
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();

        QuestionnaireENG eng = new QuestionnaireENG();
        QuestionnairePara para = eng.GetQuestionnarePara(vID, trans);
        txtID.Text = para.ID.ToString();
        txtQuestionnaireName.Text = para.QUESTIONNAIRE_NAME;
        txtObjective.Text = para.OBJECTIVE;
        txtDesc.Text = para.DESCRIPTION;
        chkActive.Checked = (para.ACTIVE == 'Y');

        if (para.ID != 0){
            TabContainer1.Visible = true;
        }
        DataTable dt = eng.GetQuestionListDT(vID, trans);
        if (dt.Rows.Count > 0) {
            gvQuestion.DataSource = dt;
            gvQuestion.DataBind();
        }

        trans.CommitTransaction();
    }

    private void SetCombo() {
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();
        QuestionnaireENG eng = new QuestionnaireENG();
        DataTable dt = eng.GetQuestionnaireSectionList(Convert.ToInt64(txtID.Text), trans);
        if (dt.Rows.Count > 0) {
            cmbSectionID.SetItemList(dt, "section_name", "id");
        }

        DataTable dtC = eng.GetChoiceTypeList(trans);
        if (dtC.Rows.Count > 0) {
            cmbChoiceTypeID.SetItemList(dtC, "choice_type_name", "id");
        }
        trans.CommitTransaction();
    }
    private void SetSectionTypeCombo() {
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();
        QuestionnaireENG eng = new QuestionnaireENG();
        DataTable dt = eng.GetSectionTypeList(Convert.ToInt64(txtID.Text), trans);
        if (dt.Rows.Count > 0)
        {
            cmbSectionTypeID.SetItemList(dt, "section_type_name", "id");
        }
        trans.CommitTransaction();
    }

    protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
    {
        if (TabContainer1.ActiveTabIndex==0)
        {
            SetCombo();
        }
        else if (TabContainer1.ActiveTabIndex == 1) {
            SetSectionTypeCombo();
            SetSectionList();
        }
    }

    private void SetSectionList() {
        if (txtID.Text != "0")
        {
            DbTrans trans = new DbTrans();
            trans.CreateTransaction();
            QuestionnaireENG eng = new QuestionnaireENG();
            DataTable dt = eng.GetQuestionnaireSectionList(Convert.ToInt64(txtID.Text), trans);
            if (dt.Rows.Count > 0) {
                gvQuestionnaireSection.DataSource = dt;
                gvQuestionnaireSection.DataBind();
            }
            trans.CommitTransaction();
        }
    }

    private void ClearQuestionForm() {
        cmbSectionID.SelectedValue = "0";
        txtQuestionName.Text = "";
        txtQuestionID.Text = "0";
        cmbChoiceTypeID.SelectedValue = "0";
        txtPoint.Text = "";
        chkRequire.Checked = true;

        txtChoiceName.Text = "";
        txtChoicePoint.Text = "";
        chkChoiceDefault.Checked = true;
        chkChoiceOther.Checked = false;
        gvChoiceList.DataSource = null;
        gvChoiceList.DataBind();
        Panel3.Visible = false;
        Session.Remove(SessChoiceList);
    }

    protected void cmbChoiceTypeID_SelectedIndexChanged(object sender, EventArgs e) {
        if (cmbChoiceTypeID.SelectedValue == "1" || cmbChoiceTypeID.SelectedValue == "2") {
            Panel3.Visible = true;
            lblChoceTypeText.Text = cmbChoiceTypeID.SelectedText;
            DbTrans trans = new DbTrans();
            trans.CreateTransaction();

            QuestionnaireENG eng = new QuestionnaireENG();
            DataTable dt = eng.GetChoiceList(Convert.ToInt64(txtQuestionID.Text), trans);
            //DataTable dt = eng.GetChoiceList(1, trans);
            if (dt.Rows.Count > 0) {
                gvChoiceList.DataSource = dt;
                gvChoiceList.DataBind();
            }
            trans.CommitTransaction();
        }else
            Panel3.Visible = false;
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (ValidQuestionnaire() == true) {
            DbTrans trans = new DbTrans();
            trans.CreateTransaction();
            if (SaveQuestionnaire(trans) == true)
            {
                trans.CommitTransaction();
                Config.SetAlert("บันทึกข้อมูลเรียบร้อย", this);
                TabContainer1.Visible = true;
            }
            else {
                trans.RollbackTransaction();
                Config.SetAlert(_err, this);
            }
        }
    }

    private DataTable BuiltChoiceList() {
        DataTable dt = new DataTable();
        dt.Columns.Add("id",typeof(long));
        dt.Columns.Add("questionnaire_questions_id",typeof(long));
        dt.Columns.Add("choice_name");
        dt.Columns.Add("is_default");
        dt.Columns.Add("point", typeof(long));
        dt.Columns.Add("is_other");
        return dt;
    }

    const string SessChoiceList = "SessChoiceList";
    protected void likAddChoice_Click(object sender, EventArgs e) 
    {
        DataTable dt = null;
        if (Session[SessChoiceList] == null)
            dt = BuiltChoiceList();
        else
            dt = (DataTable)Session[SessChoiceList];

        DataRow dr = dt.NewRow();
        dr["id"] = 0;
        dr["questionnaire_questions_id"] = 0;
        dr["choice_name"] = txtChoiceName.Text.Trim();
        dr["point"] = Convert.ToInt64(txtChoicePoint.Text.Trim());
        dr["is_default"] = (chkChoiceDefault.Checked ? "Y" : "N");
        dr["is_other"] = (chkChoiceOther.Checked ? "Y" : "N");
        dt.Rows.Add(dr);
        Session[SessChoiceList] = dt;

        if (dt.Rows.Count > 0)
        {
            trHead.Visible = false;
            gvChoiceList.DataSource = dt;
            gvChoiceList.DataBind();

        }
        else {
            trHead.Visible = true;
            gvChoiceList.DataSource = null;
            gvChoiceList.DataBind();
        }
        txtChoiceName.Text = "";
        txtChoicePoint.Text = "";
        chkChoiceDefault.Checked = true;
        chkChoiceOther.Checked = false;
    }

    protected void likCrearChoice_Click(object sender, EventArgs e)
    { 
        
    }
    

    private bool SaveQuestionnaire(DbTrans trans) {
        bool ret = false;
        QuestionnairePara para = new QuestionnairePara();
        para.ID = Convert.ToInt64(txtID.Text);
        para.QUESTIONNAIRE_NAME = txtQuestionnaireName.Text.Trim();
        para.OBJECTIVE = txtObjective.Text.Trim();
        para.DESCRIPTION = txtDesc.Text.Trim();
        para.ACTIVE = (chkActive.Checked ? 'Y' : 'N');

        QuestionnaireENG eng = new QuestionnaireENG();
        if (eng.SaveQuestionnaire(para, trans, Config.GetUserName()) == true)
        {
            ret = true;
            txtID.Text = eng.QUESTIONNAIRE_ID.ToString();
        }
        else
        {
            ret = false;
            _err = eng.ErrorMessage;
        }

        return ret;
    }

    private bool ValidQuestionnaire() {
        bool ret = true;
        if (txtQuestionnaireName.Text.Trim() == "") {
            ret = false;
            Config.SetAlert("กรุณาระบุชื่อแบบสอบถาม", this, txtQuestionnaireName.ClientID);
        }
        else if (txtObjective.Text.Trim() == "") {
            ret = false;
            Config.SetAlert("กรุณาระบุวัตถุประสงค์ของแบบสอบถาม", this, txtObjective.ClientID);
        }
        else if (txtDesc.Text.Trim() == "")
        {
            ret = false;
            Config.SetAlert("กรุณาระบุวัตถุคำชี้แจงแบบสอบถาม", this, txtDesc.ClientID);
        }
        else if (txtDesc.Text.Trim() == "")
        {
            ret = false;
            Config.SetAlert("กรุณาระบุวัตถุคำชี้แจงแบบสอบถาม", this, txtDesc.ClientID);
        }
        return ret;
    }

    protected void btnAddQuestion_Click(object sender, EventArgs e)
    {
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();
        if (ValidQuestion() == true) {
            if (SaveQuestionnaire(trans) == true){
                QuestionnaireQuestionsPara para = new QuestionnaireQuestionsPara();
                para.ID = Convert.ToInt64(txtQuestionID.Text);
                para.QUESTIONNAIRE_SECTION_ID = Convert.ToInt64(cmbSectionID.SelectedValue);
                para.QUESTION_NAME = txtQuestionName.Text.Trim();
                para.CHOICE_TYPE_ID = Convert.ToInt64(cmbChoiceTypeID.SelectedValue);
                para.QUESTION_POINT = Convert.ToDouble(txtPoint.Text.Trim());
                para.IS_REQUIRE = (chkRequire.Checked ? 'Y' : 'N');

                QuestionnaireENG eng = new QuestionnaireENG();
                bool ret = eng.SaveQuestion(para, trans, Config.GetUserName());
                if (ret == true)
                {
                    if (SaveQuestionChoice(eng.QUESTION_ID, trans) == true)
                    {
                        trans.CommitTransaction();
                        txtQuestionID.Text = eng.QUESTION_ID.ToString();
                        SetQuestionnaireForm(Convert.ToInt64(txtID.Text));
                        ClearQuestionForm();
                        Config.SetAlert("บันทึกข้อมูลเรียบร้อย", this);
                    }
                    else {
                        trans.RollbackTransaction();
                        Config.SetAlert(eng.ErrorMessage, this);
                    }
                }
                else {
                    trans.RollbackTransaction();
                    Config.SetAlert(eng.ErrorMessage, this);
                }
            }
        }
    }
    private bool ValidQuestion() {
        bool ret = true;
        if (cmbSectionID.SelectedValue == "0") {
            ret = false;
            Config.SetAlert("กรุณาเลือกส่วนที่", this, cmbSectionID.ClientID);
        }
        else if (txtQuestionName.Text.Trim() == "") {
            ret = false;
            Config.SetAlert("กรุณาระบุคำถาม", this, txtQuestionName.ClientID);
        }
        else if (cmbChoiceTypeID.SelectedValue == "0") {
            ret = false;
            Config.SetAlert("กรุณาเลือกประเภทคำตอบ", this, cmbChoiceTypeID.ClientID);
        }
        else if (txtPoint.Text.Trim() == "") {
            ret = false;
            Config.SetAlert("กรุณาระบุคะแนน", this, txtPoint.ClientID);
        }

        return ret;
    }

    private bool SaveQuestionChoice(long QuestionID, DbTrans trans) {
        bool ret = true;
        if (cmbChoiceTypeID.SelectedValue == "1" || cmbChoiceTypeID.SelectedValue == "2") {
            if (Session[SessChoiceList] != null)
            {
                DataTable dt = (DataTable)Session[SessChoiceList];
                QuestionnaireENG eng = new QuestionnaireENG();
                ret = eng.SaveQuestionChoice(dt, trans, Config.GetUserName(), QuestionID);
            }
            else
                ret = false;
        }
        return ret;
    }

    private bool ValidSection() {
        bool ret = true;
        if (txtSectionName.Text.Trim() == "") {
            ret = false;
            Config.SetAlert("กรุณาระบุชื่อส่วน", this,txtSectionName.ClientID);
        }
        else if (txtSectionDesc.Text.Trim() == "") {
            ret = false;
            Config.SetAlert("กรุณาระบุคำชี้แจง", this, txtSectionDesc.ClientID);
        }
        else if (cmbSectionTypeID.SelectedValue == "0") {
            ret = false;
            Config.SetAlert("กรุณาเลือกประเภทแบบสอบถาม", this, cmbSectionTypeID.ClientID);
        }else if(cmbSectionTypeID.SelectedValue == "2"){
            if (txtChoiceQty.Text.Trim() == "" || txtChoiceQty.Text.Trim()=="0") {
                ret = false;
                Config.SetAlert("กรุณาระบุจำนวนตัวเลือก", this, txtChoiceQty.ClientID);
            }
        }
        return ret;
    }
    protected void btnAddSection_Click(object sender, EventArgs e) { 
        DbTrans trans = new DbTrans();
        trans.CreateTransaction();
        if (ValidSection() == true)
        {
            if (SaveQuestionnaire(trans) == true) {
                QuestionnaireSectionPara para = new QuestionnaireSectionPara();
                para.ID = Convert.ToInt64(txtQuestionSectionID.Text);
                para.QUESTIONNAIRE_ID = Convert.ToInt64(txtID.Text);
                para.SECTION_NAME = txtSectionName.Text.Trim();
                para.DESCRIPTION = txtSectionDesc.Text.Trim();
                para.SECTION_TYPE_ID = Convert.ToInt64(cmbSectionTypeID.SelectedValue);
                para.CHOICE_QTY = (txtChoiceQty.Text.Trim()=="" ? 0 : Convert.ToInt64(txtChoiceQty.Text));

                QuestionnaireENG eng = new QuestionnaireENG();
                bool ret = eng.SaveQuestionnaireSection(para, trans, Config.GetUserName());
                if (ret == true)
                {
                    trans.CommitTransaction();
                    txtQuestionSectionID.Text = eng.QUESTIONNAIRE_SECTION_ID.ToString();
                    SetQuestionnaireForm(Convert.ToInt64(txtID.Text));
                    SetSectionList();
                    Config.SetAlert("บันทึกข้อมูลเรียบร้อย", this);
                }
                else 
                {
                    trans.RollbackTransaction();
                    Config.SetAlert(eng.ErrorMessage, this);
                }
            }
        }
    }
    protected void cmbSectionTypeID_SelectedIndexChanged(object sender, EventArgs e) {
        if (cmbSectionTypeID.SelectedValue == "2")
            trChoiceQty.Visible = true;
        else
            trChoiceQty.Visible = false;
    }
}
