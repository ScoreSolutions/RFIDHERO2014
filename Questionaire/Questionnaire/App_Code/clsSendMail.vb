Imports System.Net.Mail
Imports System.IO
Imports System.Web.HttpServerUtility
Public Class clsSendMail
    Inherits System.Web.UI.Page

#Region "Send Email Message"
    Private Shared Function MailDetail(ByVal CustomerName As String, ByVal Code As String) As String

        Dim strBody As New StringBuilder
        'strBody.Append("<table border='0' cellpadding='0' cellspacing='0' width='100%'>")
        'strBody.Append("    <tr>")
        'strBody.Append("        <td>")

        strBody.Append("<table border='0' cellpadding='0' cellspacing='0' width='100%'>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>เรียนคุณ " & CustomerName & "</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;'>ขอบคุณสำหรับการลงทะเบียน เข้าร่วมงาน The Return of RFID HERO 2014</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>ท่านสามารถดูตารางกิจกรรมการจัดงาน และหัวข้อเสวนาในไฟล์ที่แนบมานี้ พร้อมรับรหัสการลงทะเบียนเข้างาน<a href='http://scoresolutions.co.th/rfidhero2014/webapp/frmRegisterEmailComplete.aspx?id=" & Code & "' target='_blank' >(คลิกที่นี่)</a></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td  style='color:#ff0000;'><b>โปรดนำรหัสที่ท่านได้รับนี้ นำไปลงทะเบียนที่บริเวณจุดรับลงทะเบียนงาน ""The Return of RFID HERO""</b></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td  style='color:#ff0000;'><b>ในวันที่ 14 พฤศจิกายน 2557 เวลา 9:30 – 17:00 น. สถานที่ห้อง 203, ไบเทค บางนา</b></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;'>หากท่านมีข้อสงสัยใด ๆ กรุณาติดต่อ คุณจรรยาพร (เบนซ์) ที่ (+66) 2530-7857,</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr height='30px'>")
        strBody.Append("        <td>&nbsp;</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>Dear " & CustomerName & "</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;'>Thank you for your registration in The Return of RFID HERO 2014.</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>Our event information can be found in your attachment  To get your registration code,<a href='http://scoresolutions.co.th/rfidhero2014/webapp/frmRegisterEmailComplete.aspx?id=" & Code & "' target='_blank' >click here.</a></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td  style='color:#ff0000;'><b>Please be kindly reminded to bring along your registration code on 14th November 2014 from 9:30 – 17:00</b></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td  style='color:#ff0000;'><b>and meet us at the reception booth of ""The Return of RFID HERO"", Hall 203, BITEC Bang Na.</b></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;'>Should you have any inquiries, please kindly contact Ms. Janyaporn (Benz) at  (+66) 2530-7857,</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr height='30px'>")
        strBody.Append("        <td>&nbsp;</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>Regards,</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td><IMG SRC='cid:ATTIMG2' width='95' height='78' /></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>RFID Thailand</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td><a href='http://www.rfidthailand.net/main.php?filename=index' target='_blank' >www.rfidthailand.net</a></td>")
        strBody.Append("    </tr>")
        strBody.Append("</table>")

        strBody.Append("<table border='0' cellpadding='0' cellspacing='0' width='100%'>") 
        strBody.Append("    <tr>")
        strBody.Append("<br/>")
        strBody.Append("<br/>")
        strBody.Append("        <td ><IMG SRC='cid:ATTIMG1' width='511' height='716' /></td>")
        strBody.Append("    </tr>")
        strBody.Append("</table>")

  

        'strBody.Append("        <td><img src=""http://www.rfidthailand.net/images/skin/logo.png"" alt=""RFID_LOGO""></td>")

        Return strBody.ToString
    End Function

    'Private Shared Function SMTPServer() As String
    '    Return "smtp.live.com"
    'End Function

    'Private Shared Function SMTPMailFrom() As String
    '    Return "rfidhero2014@hotmail.com"
    'End Function

    'Private Shared Function SMTPPassword() As String
    '    Return "1qaz@WSX"
    'End Function

    Private Shared Function Subject() As String
        Return "The Return of RFID HERO 2014 -Successful Registration"
    End Function

    Public Shared Function SendEmailMessage(ByVal strTo As String, _
                                            ByVal SMTPMailFrom As String, _
                                            ByVal SMTPServer As String, _
                                            ByVal SMTPPassword As String, _
                                            ByVal strCustomerName As String, _
                                            ByVal strCode As String, _
                                            ByVal AttachmentFiles As String, _
                                            ByVal MailPort As Integer, _
                                            ByVal MailSSL As Boolean, ByVal AttachmentFiles2 As String) As Boolean
        'This procedure overrides the first procedure and accepts a single
        'string for the recipient and file attachement 
        Dim iCnt As Integer = 0
        Try


            Dim MailMsg As New MailMessage '(New MailAddress(strFrom.Trim()), New MailAddress(strTo))
            MailMsg.From = New MailAddress(SMTPMailFrom)
            Dim strMail() As String = strTo.Replace(",", ";").Split(";")
            For i As Integer = 0 To strMail.Length - 1
                MailMsg.To.Add(New MailAddress(strMail(i).Trim()))
            Next
            MailMsg.Subject = Subject()
            MailMsg.Body = MailDetail(strCustomerName, strCode)
            MailMsg.IsBodyHtml = True
            MailMsg.From = New MailAddress(SMTPMailFrom, Subject, System.Text.Encoding.ASCII)
            MailMsg.Headers.Add("Reply-To", "rfidhero@gmail.com")

            Dim att As New Net.Mail.Attachment(AttachmentFiles)
            att.ContentId = "ATTIMG1"
            MailMsg.Attachments.Add(att)

            Dim att2 As New Net.Mail.Attachment(AttachmentFiles2)
            att2.ContentId = "ATTIMG2"
            MailMsg.Attachments.Add(att2)

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

#End Region

End Class

