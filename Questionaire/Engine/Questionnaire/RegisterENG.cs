using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Para.TABLE;
using Linq.TABLE;
using Linq.Common.Utilities;

namespace Engine.Questionnaire
{
    public class RegisterENG
    {
        string _err = "";
        public RegisterENG(){
            _err = "";
        }

        public string ErrorMessage {
            get { return _err; }
        }

        public long SavePersonalInfo(ErmTsPersonalInfoPara p,string LoginName, TransactionDB trans) {
            long ret = 0;
            try {
                ErmTsPersonalInfoLinq lnq = new ErmTsPersonalInfoLinq();
                if (p.ID > 0)
                    lnq.GetDataByPK(p.ID, trans.Trans);

                lnq.IDCARD_NO = p.IDCARD_NO;
                lnq.TITLE_NAME = p.TITLE_NAME;
                lnq.FIRST_NAME = p.FIRST_NAME;
                lnq.MIDDLE_NAME = p.MIDDLE_NAME;
                lnq.LAST_NAME = p.LAST_NAME;
                lnq.POSITION_NAME = p.POSITION_NAME;
                lnq.DIVISION = p.DIVISION;
                lnq.COMPANY_NAME = p.COMPANY_NAME;
                lnq.ADDRESS = p.ADDRESS;
                lnq.CITY = p.CITY;
                lnq.STATE = p.STATE;
                lnq.COUNTRY = p.COUNTRY;
                lnq.ZIPCODE = p.ZIPCODE;
                lnq.TELNO = p.TELNO;
                lnq.MOBILE_NO = p.MOBILE_NO;
                lnq.FAXNO = p.FAXNO;
                lnq.EMAIL = p.EMAIL;
                lnq.WEBSITE = p.WEBSITE;
                lnq.REGISTERED_CAPITAL = p.REGISTERED_CAPITAL;
                lnq.ANNUAL_SALE_VALUE_YEAR = p.ANNUAL_SALE_VALUE_YEAR;
                lnq.ANNUAL_SALE_VALUE_VOLUMNS = p.ANNUAL_SALE_VALUE_VOLUMNS;
                lnq.REGISPERIOD = p.REGISPERIOD;
                bool re = false;
                if (lnq.ID > 0)
                    re = lnq.UpdateByPK(LoginName, trans.Trans);
                else
                    re = lnq.InsertData(LoginName, trans.Trans);

                if (re == true)
                    ret = lnq.ID;
            }catch(Exception ex){
                _err = "Engine.Questionnaire.RegisteENG.SavePersonalInfo Exception :" + ex.Message;
                ret=0;
            }
            return ret;
        }

        public bool UpdateIsSendMail(long pId, string LoginName, TransactionDB trans) {
            bool ret = false;
            try {
                ErmTsPersonalInfoLinq erm = new ErmTsPersonalInfoLinq();
                ret = erm.UpdateBySql("update ERM_TS_PERSONAL_INFO set is_send_mail = 'Y' where id='" + pId + "'", trans.Trans);
                erm = null;
            }
            catch (Exception ex) {
                ret = false;
            }
            return ret;
        }

        public bool DeleteInterest(long pId ,TransactionDB trans)
        {
            bool ret = false;
            try
            {

                int rowdelete = 0;
               rowdelete = Linq.Common.Utilities.SqlDB.ExecuteNonQuery("delete from scoresolutions.ERM_TS_INTEREST where erm_ts_personal_info_id ='" + pId + "'");   
               ret = true;
   
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }

        public bool SaveInterest(ErmTsInterestPara p, string LoginName, TransactionDB trans) { 
            bool ret = false;
            try
            {
                ErmTsInterestLinq lnq = new ErmTsInterestLinq();
                if(p.ID>0)
                    lnq.GetDataByPK(p.ID,trans.Trans);

                lnq.ERM_TS_PERSONAL_INFO_ID=p.ERM_TS_PERSONAL_INFO_ID;
                lnq.INTEREST_CODE=p.INTEREST_CODE;
                lnq.INTEREST_NAME=p.INTEREST_NAME;

                if (lnq.ID > 0)
                    ret = lnq.UpdateByPK(LoginName, trans.Trans);
                else
                    ret = lnq.InsertData(LoginName, trans.Trans);
            }
            catch (Exception ex) {
                _err = "Engine.Questionnaire.RegisteENG.SaveInterest Exception :" + ex.Message;
                ret=false;
            }
            return ret;
        }

        public string[] GetAutoCompleteList(string tbName, string fldName, string prefixText) { 
            string str = "" +
                " select distinct " + fldName +
                " from " + tbName +
                " where " + fldName + " like '" + prefixText + "%' " +
                " order by " + fldName;

            List<string> items = new List<string> { };
            DataTable dt = SqlDB.ExecuteTable(str);
            if (dt.Rows.Count > 0) { 
                foreach(DataRow dr in dt.Rows){
                    items.Add(dr[fldName].ToString());
                }
            }
            dt.Dispose();
            return items.ToArray();
        }

        public ErmTsPersonalInfoPara GetRegisterInfo(long vID) {
            ErmTsPersonalInfoPara ret = new ErmTsPersonalInfoPara();
            try
            {
                ErmTsPersonalInfoLinq lnq = new ErmTsPersonalInfoLinq();
                ret = lnq.GetParameter(vID, null);
                lnq = null;
            }
            catch (Exception ex) { }

            return ret;
        }

        public bool chkPersonalInfoByFirstNameLastName(string firstName, string lastName) {
            bool ret = false;
            try {
                DataTable dt = new DataTable();
                ErmTsPersonalInfoLinq lnq = new ErmTsPersonalInfoLinq();
                dt = lnq.GetDataList("first_name='" + firstName + "' and last_name='" + lastName + "' and year(CREATE_ON)=year(getdate())", "", null);
                if (dt.Rows.Count > 0) {
                    ret = true;
                }
                dt.Dispose();
            }
            catch (Exception ex) {
                ret = false;
            }
            return ret;
        }

        public bool chkPersonalInfoByEmail(string eMail)
        {
            bool ret = false;
            try
            {
                DataTable dt = new DataTable();
                ErmTsPersonalInfoLinq lnq = new ErmTsPersonalInfoLinq();
                dt = lnq.GetDataList("Email='" + eMail + "'  and year(CREATE_ON)=year(getdate())", "", null);
                if (dt.Rows.Count > 0)
                {
                    ret = true;
                }
                dt.Dispose();
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }

        public bool chkPersonalInfoByMobileNo(string MobileNo)
        {
            bool ret = false;
            try
            {
                DataTable dt = new DataTable();
                ErmTsPersonalInfoLinq lnq = new ErmTsPersonalInfoLinq();
                dt = lnq.GetDataList("Mobile_No='" + MobileNo + "'  and year(CREATE_ON)=year(getdate())", "", null);
                if (dt.Rows.Count > 0)
                {
                    ret = true;
                }
                dt.Dispose();
            }
            catch (Exception ex)
            {
                ret = false;
            }
            return ret;
        }
    }
}
