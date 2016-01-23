using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Para.TABLE;
using Linq.TABLE;
using Linq.VIEW;
using Engine.Common;

namespace Engine.Questionnaire
{
    public class QuestionnaireENG
    {
        string _err = "";
        long _answer_id = 0;
        long _questionnaire_id = 0;
        long _question_id = 0;
        long _questionnaire_section_id = 0;

        public string ErrorMessage {
            get { return _err; }
            set { _err = value; }
        }
        public long ANSWER_ID {
            get { return _answer_id; }
            set { _answer_id = value; }
        }
        public long QUESTIONNAIRE_ID {
            get { return _questionnaire_id; }
            set { _questionnaire_id = value; }
        }
        public long QUESTION_ID {
            get { return _question_id; }
            set { _question_id = value; }
        }
        public long QUESTIONNAIRE_SECTION_ID {
            get { return _questionnaire_section_id; }
            set { _questionnaire_section_id = value; }
        }

        public DataTable GetQuestionnaireSectionList(long QuestionnaireID,DbTrans trans) {
            QuestionnaireSectionLinq lnq = new QuestionnaireSectionLinq();
            string sql = "";
            sql += "select qs.id, qs.questionnaire_id, qs.section_name, qs.description, qs.section_type_id, ";
            sql += " st.section_type_name, qs.choice_qty";
            sql += " from questionnaire_section qs ";
            sql += " inner join section_type st on st.id=qs.section_type_id ";
            sql += " where qs.questionnaire_id = " + QuestionnaireID;
            sql += " order by qs.id ";

            return lnq.GetListBySql(sql, trans.Trans);
        }

        public QuestionnaireSectionPara GetQuestionnaireSectionPara(long QuestionnareSectionID, DbTrans trans) {
            QuestionnaireSectionLinq lnq = new QuestionnaireSectionLinq();
            return lnq.GetParameter(QuestionnareSectionID, trans.Trans);
        }

        public QuestionnairePara GetQuestionnarePara(long QuestionnaireID, DbTrans trans) {
            QuestionnaireLinq lnq = new QuestionnaireLinq();
            return lnq.GetParameter(QuestionnaireID, trans.Trans);
        }

        public SectionTypePara GetSectionTypePara(long SectionID, DbTrans trans) {
            SectionTypeLinq lnq = new SectionTypeLinq();
            return lnq.GetParameter(SectionID, trans.Trans);
        }
        public DataTable GetSectionTypeList(long QuestionnaireID, DbTrans trans) {
            SectionTypeLinq lnq = new SectionTypeLinq();
            return lnq.GetDataList("1=1", "id", trans.Trans);
        }

        public DataTable GetQuestionnaireQuestionList(long QuestionnaireSectionID, DbTrans trans) {
            QuestionnaireQuestionsLinq lnq = new QuestionnaireQuestionsLinq();
            return lnq.GetDataList("questionnaire_section_id = " + QuestionnaireSectionID, "id", trans.Trans);
        }

        public QuestionnaireQuestionsPara GetQuestionQuestionPara(long QuestionID, DbTrans trans)
        {
            QuestionnaireQuestionsLinq lnq = new QuestionnaireQuestionsLinq();
            return lnq.GetParameter(QuestionID, trans.Trans);
        }

        public DataTable GetChoiceList(long QuestionID, DbTrans trans) {
            QuestionnaireQuestionsChoiceLinq lnq = new QuestionnaireQuestionsChoiceLinq();
            return lnq.GetDataList("questionnaire_questions_id = " + QuestionID, "id", trans.Trans);
        }

        public QuestionnaireQuestionsChoicePara GetQuestionnaireQuestionChoicePara(long vID, DbTrans trans) {
            QuestionnaireQuestionsChoiceLinq lnq = new QuestionnaireQuestionsChoiceLinq();
            return lnq.GetParameter(vID, trans.Trans);
        }

        public ChoiceTypePara GetChoiceTypePara(long ChoiceTypeID, DbTrans trans) { 
            ChoiceTypeLinq lnq = new ChoiceTypeLinq();
            ChoiceTypePara para = lnq.GetParameter(ChoiceTypeID, trans.Trans);
            return para;
        }

        public DataTable GetChoiceTypeList(DbTrans trans) {
            ChoiceTypeLinq lnq = new ChoiceTypeLinq();
            DataTable dt = lnq.GetDataList("1=1", "id", trans.Trans);
            return dt;
        }

        public DataTable GetQuestionConfig(long QuestionID, DbTrans trans) {
            QuestionChoiceConfigLinq lnq = new QuestionChoiceConfigLinq();
            return lnq.GetDataList("questionnaire_question_id = " + QuestionID, "id", trans.Trans);
        }

        public bool SaveAnswer(AnswerPara para, string UserID, DbTrans trans) {
            bool ret = false;
            try{
                AnswerLinq lnq = new AnswerLinq();
                if(para.ID != 0){
                    lnq.GetDataByPK(para.ID,trans.Trans);
                }
                lnq.ANSWER_NAME=para.ANSWER_NAME;
                lnq.QUESTIONNAIRE_ID=para.QUESTIONNAIRE_ID;
                lnq.ANSWER_DATE = para.ANSWER_DATE;
                lnq.SESSION_ID = para.SESSION_ID;
                if (lnq.ID != 0)
                {
                    ret = lnq.UpdateByPK(UserID, trans.Trans);
                }
                else {
                    ret = lnq.InsertData(UserID, trans.Trans);
                }
                if (ret == false)
                {
                    _err = lnq.ErrorMessage;
                }
                else {
                    _answer_id = lnq.ID;
                }

            }catch (Exception ex){
                _err=ex.Message;
            }

            return ret;
        }

        public bool SaveAnswerResult(AnswerResultPara para, string UserID, DbTrans trans) {
            bool ret = false;
            try
            {
                AnswerResultLinq lnq = new AnswerResultLinq();
                if(para.ID != 0){
                    lnq.GetDataByPK(para.ID,trans.Trans);
                }
                lnq.ANSWER_ID = para.ANSWER_ID;
                lnq.QUESTIONNAIRE_QUESTION_ID = para.QUESTIONNAIRE_QUESTION_ID;
                lnq.CHOICE_TYPE_ID = para.CHOICE_TYPE_ID;
                lnq.RESULT_CHOICE_NAME = para.RESULT_CHOICE_NAME;
                lnq.POINT = para.POINT;
                if (lnq.ID != 0)
                {
                    ret = lnq.UpdateByPK(UserID, trans.Trans);
                }
                else {
                    ret = lnq.InsertData(UserID, trans.Trans);
                }
                if (ret == false) {
                    _err = lnq.ErrorMessage;
                }

            }
            catch (Exception ex) {
                _err = ex.Message;
            }
            return ret;
        }

        public DataTable GetQuestionListDT(long vID, DbTrans trans) { 
            VQuestionListLinq lnq = new VQuestionListLinq();
            DataTable dt = lnq.GetDataList("id = '" + vID + "'", "questionnaire_section_id, questionnaire_question_id", trans.Trans);
            return dt;
        }

        public bool SaveQuestionnaire(QuestionnairePara para, DbTrans trans, string UserID) {
            bool ret = false;
            QuestionnaireLinq lnq = new QuestionnaireLinq();
            if (para.ID != 0)
                lnq.GetDataByPK(para.ID, trans.Trans);

            lnq.QUESTIONNAIRE_NAME = para.QUESTIONNAIRE_NAME;
            lnq.OBJECTIVE = para.OBJECTIVE;
            lnq.DESCRIPTION = para.DESCRIPTION;
            lnq.ACTIVE = para.ACTIVE;

            if (lnq.ID != 0)
                ret = lnq.UpdateByPK(UserID, trans.Trans);
            else 
                ret = lnq.InsertData(UserID, trans.Trans);

            if (ret == false)
                _err = lnq.ErrorMessage;
            else
                _questionnaire_id = lnq.ID;

            return ret;
        }

        public bool SaveQuestion(QuestionnaireQuestionsPara para, DbTrans trans, string UserID) {
            bool ret = false;
            QuestionnaireQuestionsLinq lnq = new QuestionnaireQuestionsLinq();
            if (para.ID != 0)
                lnq.GetDataByPK(para.ID, trans.Trans);

            lnq.QUESTIONNAIRE_SECTION_ID = para.QUESTIONNAIRE_SECTION_ID;
            lnq.QUESTION_NAME = para.QUESTION_NAME;
            lnq.CHOICE_TYPE_ID = para.CHOICE_TYPE_ID;
            lnq.QUESTION_POINT = para.QUESTION_POINT;
            lnq.IS_REQUIRE = para.IS_REQUIRE;
            if (lnq.ID != 0)
                ret = lnq.UpdateByPK(UserID, trans.Trans);
            else
                ret = lnq.InsertData(UserID, trans.Trans);

            if (ret == false)
                _err = lnq.ErrorMessage;
            else
                _question_id = lnq.ID;

            return ret;
        }

        public bool SaveQuestionnaireSection(QuestionnaireSectionPara para, DbTrans trans, string UserID) {
            bool ret = false;
            QuestionnaireSectionLinq lnq = new QuestionnaireSectionLinq();
            if (para.ID != 0)
                lnq.GetDataByPK(para.ID, trans.Trans);

            lnq.QUESTIONNAIRE_ID = para.QUESTIONNAIRE_ID;
            lnq.SECTION_NAME = para.SECTION_NAME;
            lnq.DESCRIPTION = para.DESCRIPTION;
            lnq.SECTION_TYPE_ID = para.SECTION_TYPE_ID;
            lnq.CHOICE_QTY = para.CHOICE_QTY;

            if (lnq.ID != 0)
                ret = lnq.UpdateByPK(UserID, trans.Trans);
            else
                ret = lnq.InsertData(UserID, trans.Trans);

            if (ret == false)
                _err = lnq.ErrorMessage;
            else
                _questionnaire_section_id = lnq.ID;

            return ret;
        }
        public bool SaveQuestionChoice(DataTable dt, DbTrans trans, string LoginName,long QuestionID) {
            bool ret = false;
            if (dt.Rows.Count > 0) {
                foreach (DataRow dr in dt.Rows) {
                    QuestionnaireQuestionsChoiceLinq lnq = new QuestionnaireQuestionsChoiceLinq();
                    if (Convert.ToInt64(dr["id"]) != 0)
                        lnq.GetDataByPK(Convert.ToInt64(dr["id"]),trans.Trans);

                    lnq.QUESTIONNAIRE_QUESTIONS_ID = QuestionID;
                    lnq.CHOICE_NAME = dr["choice_name"].ToString();
                    lnq.IS_DEFAULT = Convert.ToChar(dr["is_default"]);
                    lnq.POINT = Convert.ToDouble(dr["point"]);
                    lnq.IS_OTHER = Convert.ToChar(dr["is_other"]);

                    if (lnq.ID != 0)
                        ret = lnq.UpdateByPK(LoginName, trans.Trans);
                    else
                        ret = lnq.InsertData(LoginName, trans.Trans);

                    if (ret == false)
                    {
                        _err = lnq.ErrorMessage;
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
