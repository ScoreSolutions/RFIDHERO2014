Imports LinqDB.TABLE
Imports System.Net.Mail

Public Class frmSendEmailEBrochureAgent

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            Dim sql As String = "select p.first_name + ' ' + p.last_name customer_name,"
            sql += " p.company_name , mj.customer_email, mj.id ebrochure_send_mail_job_id"
            sql += " from eBROCHURE_SEND_MAIL_JOB mj "
            sql += " inner join ERM_TS_PERSONAL_INFO p on p.id=mj.erm_ts_personal_info_id"
            sql += " where mj.is_send_mail='N'"
            'sql += " and mj.id=12"

            Dim lnq As New EbrochureSendMailJobLinqDB
            Dim dt As New DataTable
            dt = lnq.GetListBySql(sql, Nothing)
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    If Convert.IsDBNull(dr("customer_email")) = False Then
                        Dim CustomerName As String = dr("customer_name")
                        'Dim CompanyName As String = dr("company_name")
                        Dim CustomerEmail As String = dr("customer_email")  '"akkarawat@scoresolutions.co.th;akkarawatp@yahoo.com;akkarawatp@hotmail.com" ' dr("customer_email")
                        'Dim CustomerEmail As String = "akkarawat@scoresolutions.co.th"
                        Dim MailContent As String = ""
                        Dim JobID As Long = Convert.ToInt64(dr("ebrochure_send_mail_job_id"))

                        If CustomerEmail.Trim <> "" Then
                            sql = " select e.name_thai, e.name_eng, ed.file_path"
                            sql += " from eBROCHURE_SEND_MAIL_JOB_ITEM ji "
                            sql += " inner join eBROCHURE e on e.id=ji.ebrochure_id"
                            sql += " inner join eBROCHURE_DOCUMENT ed on e.id=ed.ebrochure_id"
                            sql += " where ji.ebrochure_send_mail_job_id='" & JobID & "'"

                            Dim SendMailComplete As Boolean = False
                            Dim dti As New DataTable
                            Dim lni As New EbrochureSendMailJobItemLinqDB
                            dti = lni.GetListBySql(sql, Nothing)
                            If dti.Rows.Count > 0 Then
                                If SendEmailMessage(CustomerEmail, CustomerName, dti, "rfidhero2014@scoresolutions.co.th", "mail.scoresolutions.co.th", "1qaz@WSX", 25, False) = False Then
                                    If SendEmailMessage(CustomerEmail, CustomerName, dti, "rfidhero2014@hotmail.com", "smtp.live.com", "1qaz@WSX", 25, False) = True Then
                                        SendMailComplete = True
                                    End If
                                Else
                                    SendMailComplete = True
                                End If
                            End If
                            lnq = Nothing
                            dti.Dispose()

                            If SendMailComplete = True Then
                                Dim mLnq As New EbrochureSendMailJobLinqDB
                                mLnq.GetDataByPK(JobID, Nothing)
                                If mLnq.ID > 0 Then
                                    mLnq.IS_SEND_MAIL = "Y"

                                    Dim trans As New LinqDB.Common.Utilities.TransactionDB
                                    Dim re As Boolean = mLnq.UpdateByPK("SendEmailEBrochure.Timer1_Tick", trans.Trans)
                                    If re = True Then
                                        trans.CommitTransaction()
                                    Else
                                        trans.RollbackTransaction()
                                    End If
                                End If
                                mLnq = Nothing
                            End If
                        End If
                    End If
                Next
            End If
            lnq = Nothing
            dt.Dispose()
        Catch ex As Exception

        End Try
        Timer1.Enabled = True
    End Sub

#Region "Send Email "
    Private Shared Function SendEmailMessage(ByVal strTo As String, _
                                            ByVal CustomerName As String, _
                                            ByVal dti As DataTable, _
                                            ByVal SMTPMailFrom As String, _
                                            ByVal SMTPServer As String, _
                                            ByVal SMTPPassword As String, _
                                            ByVal MailPort As Integer, _
                                            ByVal MailSSL As Boolean) As Boolean
        'This procedure overrides the first procedure and accepts a single
        'string for the recipient and file attachement 
        Dim iCnt As Integer = 0
        Try
            Dim MailMsg As New MailMessage
            MailMsg.From = New MailAddress(SMTPMailFrom)
            Dim strMail() As String = strTo.Replace(",", ";").Split(";")
            For i As Integer = 0 To strMail.Length - 1
                MailMsg.To.Add(New MailAddress(strMail(i).Trim()))
            Next
            MailMsg.Subject = MailSubject()
            MailMsg.Body = MailBody(CustomerName, dti)
            MailMsg.IsBodyHtml = True
            MailMsg.From = New MailAddress(SMTPMailFrom, "RFID HERO 2014 eBrochure", System.Text.Encoding.ASCII)
            MailMsg.Headers.Add("Reply-To", "rfidhero@gmail.com")

            If dti.Rows.Count > 0 Then
                Dim i As Integer = 1
                For Each dri As DataRow In dti.Rows
                    If Convert.IsDBNull(dri("file_path")) = False Then
                        If IO.File.Exists(dri("file_path")) = True Then
                            Dim att As New Net.Mail.Attachment(dri("file_path"))
                            att.ContentId = "ATTIMG" & i
                            MailMsg.Attachments.Add(att)

                            'Dim att2 As New Net.Mail.Attachment(AttachmentFiles2)
                            'att2.ContentId = "ATTIMG2"
                            'MailMsg.Attachments.Add(att2)
                        End If
                    End If
                    i += 1
                Next
            End If
            
            'Smtpclient to send the mail message
            Dim SmtpMail As New SmtpClient(SMTPServer)
            SmtpMail.EnableSsl = MailSSL
            SmtpMail.Port = MailPort
            SmtpMail.Credentials = New Net.NetworkCredential(SMTPMailFrom, SMTPPassword)
            SmtpMail.Send(MailMsg)

            Return True
            'วิธีการเรียกใช้
            'SendEmailMessage(SMTPMailFrom, strTo, Me.ddlMailType.Text.ToString, strBody, BindValidResults, strLink)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Shared Function MailSubject() As String
        Dim ret As String = "Score Solutions e-Brochure System"
        Return ret
    End Function
    Private Shared Function MailBody(CustomerName As String, dti As DataTable) As String
        Dim strFont As String = "Tahoma;"
        Dim strFontSize As String = "10pt;"

        Dim ret As String = "<table border='0' cellpadding='0' cellspacing='0' width='100%'>"
        ret += "    <tr>"
        ret += "        <td colspan='2' style='font-family:" & strFont & "font-size:" & strFontSize & "'>เรียนคุณ " & CustomerName
        ret += "        </td>"
        ret += "    </tr>"
        ret += "    <tr>"
        ret += "        <td colspan='2' style='font-family:" & strFont & "font-size:" & strFontSize & "'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
        ret += "            บริษัท สกอร์ โซลูชั่น จำกัด ขอขอบพระคุณ ที่ท่านได้ให้ความสนใจ เข้าเยี่ยมชมบูธของบริษัทฯ ในงาน <br /> "
        ret += "            ""The Return of RFID HERO 2014"" บริษัทขอจัดส่งโบว์ชัวร์ ตามที่ท่านได้ให้ความสนใจเลือก โดยมีรายละเอียด ดังต่อไปนี้ <br />"
        ret += "            หากท่านต้องการรายละเอียดเพิ่มเติม สามารถติดต่อขอข้อมูลได้ที่ <br /><br />"
        ret += "            บริษัท สกอร์ โซลูชั่น จำกัด (www.scoresolutions.co.th)  <br />"
        ret += "            โทร. 02-530 7855-7 <br />"
        ret += "            แฟกซ์ 02-530 7857 ต่อ 400 <br />"
        ret += "            หรือติดต่อเราทางอีเมล์ : sales@scoresolutions.co.th"
        ret += "        </td>"
        ret += "    </tr>"

        Dim i As Integer = 1
        For Each dri As DataRow In dti.Rows
            ret += "    <tr><td colspan='2'>&nbsp;</td></tr>"
            ret += "    <tr>"
            ret += "        <td align='center' width='20px' style='font-family:" & strFont & "font-size:" & strFontSize & "' >" & i.ToString() & ".</td>"
            ret += "        <td style='font-family:" & strFont & "font-size:" & strFontSize & "'>" & dri("name_thai") & " (" & dri("name_eng") & ")</td>"
            ret += "    </tr>"
            ret += "    <tr>"
            ret += "        <td colspan='2'><IMG SRC='cid:ATTIMG" & i & "'  /></td>"
            ret += "    </tr>"
            ret += "    <tr><td colspan='2'>&nbsp;</td></tr>"
            i += 1
        Next
        ret += "    <tr>"
        ret += "        <td colspan='2' style='font-family:" & strFont & "font-size:" & strFontSize & "'>"
        ret += "            บริษัทหวังเป็นอย่างยิ่งว่าจะได้รับการติดต่อจากท่านในโอกาสอันใกล้นี้"
        ret += "        </td>"
        ret += "    </tr>"
        ret += "</table>"
        Return ret
    End Function
#End Region

    Private Sub frmSendEmailEBrochureAgent_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1_Tick(Nothing, Nothing)
    End Sub
End Class
