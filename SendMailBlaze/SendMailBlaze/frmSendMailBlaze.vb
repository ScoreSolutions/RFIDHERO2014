Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net.Mail

Public Class frmSendMailBlaze

    Private Const CON_GS1_2014 As String = "Data Source=localhost;Initial Catalog=GS1_2014;User ID=sa;Password=1qaz@WSX"
    'Private Const CON_RFIDHERO2014 As String = "Data Source=61.19.248.22;Initial Catalog=scoresolutions;User ID=scoresolutions;Password=scs1034"
    Private Const CON_RFIDHERO2014 As String = "Data Source=192.168.1.102;Initial Catalog=RFIDHERO2014;User ID=sa;Password=1qaz@WSX"

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Try
            ProgressBar1.Value = 1
            SendMailLogisticProcessApp()
            MessageBox.Show("Complete")

            'ProgressBar1.Value = 0
            'SendMailGS1_2014()

            'ProgressBar1.Value = 0
            'SendMailRFIDHero2014()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SendMailLogisticProcessApp()
        Try
            Dim conn As New SqlConnection()
            conn.ConnectionString = CON_RFIDHERO2014
            conn.Open()

            Dim sql As String = "select distinct first_name + ' ' + last_name as customer_name , email as customer_email  from ERM_TS_PERSONAL_INFO"

            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1200
            cmd.CommandText = sql
            cmd.Connection = conn

            Dim dt As New DataTable

            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            da.Fill(dt)
            da.Dispose()

            If dt.Rows.Count > 0 Then
                ProgressBar1.Value = 0
                ProgressBar1.Maximum = dt.Rows.Count

                Dim SendComplete As Integer = 0
                Dim SendError As Integer = 0
                For Each dr As DataRow In dt.Rows
                    If Convert.IsDBNull(dr("customer_email")) = False And Convert.IsDBNull(dr("customer_name")) = False Then
                        Dim CustomerEmail As String = dr("customer_email")
                        'Dim CustomerEmail As String = "akkarawatp@yahoo.com;akkarawat@scoresolutions.co.th"
                        Dim CustomerName As String = dr("customer_name")

                        If CustomerEmail.Trim <> "" And CustomerName <> "" Then
                            Dim MailContent As String = MailDetail(CustomerName)
                            Dim MailSubject As String = "โครงการส่งเสริมการปรับกระบวนการจัดการโลจิสติกส์ด้วยการใช้เทคโนโลยี Application ระบบ RFID และ Barcde"

                            Dim ret As Boolean = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "tanapol.acentech@hotmail.com", "smtp.live.com", "Kugsu0103#", 587, True)
                            'Dim ret As Boolean = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "tanapol.acentech@gmail.com", "smtp.gmail.com", "BAnk6796", 587, True)
                            If ret = False Then
                                SendError += 1
                            Else
                                SendComplete += 1
                            End If


                            'Dim ret As Boolean = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "rfidhero2014@scoresolutions.co.th", "mail.scoresolutions.co.th", "1qaz@WSX", 25, False)
                            'If ret = False Then
                            '    ret = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "rfidhero2014@hotmail.com", "smtp.live.com", "1qaz@WSX", 587, True)
                            '    If ret = False Then
                            '        SendError += 1
                            '    Else
                            '        SendComplete += 1
                            '    End If
                            'Else
                            '    SendComplete += 1
                            'End If
                        End If
                    End If

                    System.Threading.Thread.Sleep(25000)
                    ProgressBar1.Value += 1

                    lblProgressSummary.Text = "Total : " & dt.Rows.Count & " Complete:" & SendComplete
                    If SendError > 0 Then
                        lblProgressSummary.Text = lblProgressSummary.Text & "  Error:" & SendError
                    End If
                    Application.DoEvents()
                Next
            End If
        Catch ex As Exception
            CreateLogFile("Exception SendMailLogisticProcessApp : " & ex.Message)
        End Try
    End Sub

    Private Sub SendMailGS1_2014()
        Try
            Dim conn As New SqlConnection()
            conn.ConnectionString = CON_GS1_2014
            conn.Open()

            Dim sql As String = "select invite_person1 customer_name, invite_email1 customer_email"
            sql += " from TS_REGISTER"
            sql += " union"
            sql += " select invite_person2, invite_email2"
            sql += " from TS_REGISTER"

            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1200
            cmd.CommandText = sql
            cmd.Connection = conn

            Dim dt As New DataTable

            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            da.Fill(dt)
            da.Dispose()

            If dt.Rows.Count > 0 Then
                ProgressBar1.Value = 0
                ProgressBar1.Maximum = dt.Rows.Count

                Dim SendComplete As Integer = 0
                Dim SendError As Integer = 0
                For Each dr As DataRow In dt.Rows
                    If Convert.IsDBNull(dr("customer_email")) = False And Convert.IsDBNull(dr("customer_name")) = False Then
                        Dim CustomerEmail As String = dr("customer_email")
                        Dim CustomerName As String = dr("customer_name")

                        'Dim CustomerEmail As String = "kamolchai@hotmail.com"
                        'Dim CustomerName As String = "กมลชัย เรืองจุติโพธิ์พาน"

                        If CustomerEmail.Trim <> "" And CustomerName <> "" Then
                            Dim MailSubject As String = ""
                            Dim MailContent As String = ""
                            Dim ret As Boolean = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "rfidhero2014@scoresolutions.co.th", "mail.scoresolutions.co.th", "1qaz@WSX", 25, False)
                            If ret = False Then
                                ret = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "rfidhero2014@hotmail.com", "smtp.live.com", "1qaz@WSX", 587, True)
                                If ret = False Then
                                    SendError += 1
                                Else
                                    SendComplete += 1
                                End If
                            Else
                                SendComplete += 1
                            End If
                        End If
                    End If
                    ProgressBar1.Value += 1

                    lblProgressSummary.Text = "GS1 2014 Total : " & dt.Rows.Count & " Complete:" & SendComplete
                    If SendError > 0 Then
                        lblProgressSummary.Text = lblProgressSummary.Text & "  Error:" & SendError
                    End If
                    Application.DoEvents()
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SendMailRFIDHero2014()
        Try
            Dim conn As New SqlConnection()
            conn.ConnectionString = CON_RFIDHERO2014
            conn.Open()

            Dim sql As String = "select distinct first_name + ' ' + last_name as customer_name , email as customer_email  from ERM_TS_PERSONAL_INFO"

            Dim cmd As New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 1200
            cmd.CommandText = sql
            cmd.Connection = conn

            Dim dt As New DataTable

            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            da.Fill(dt)
            da.Dispose()

            If dt.Rows.Count > 0 Then
                ProgressBar1.Value = 0
                ProgressBar1.Maximum = dt.Rows.Count

                Dim SendComplete As Integer = 0
                Dim SendError As Integer = 0
                For Each dr As DataRow In dt.Rows
                    If Convert.IsDBNull(dr("customer_email")) = False And Convert.IsDBNull(dr("customer_name")) = False Then
                        Dim CustomerEmail As String = dr("customer_email")
                        'Dim CustomerEmail As String = "akkarawatp@yahoo.com"
                        Dim CustomerName As String = dr("customer_name")

                        If CustomerEmail.Trim <> "" And CustomerName <> "" Then
                            Dim MailSubject As String = ""
                            Dim MailContent As String = ""
                            Dim ret As Boolean = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "rfidhero2014@scoresolutions.co.th", "mail.scoresolutions.co.th", "1qaz@WSX", 25, False)
                            If ret = False Then
                                ret = SendEmail(CustomerEmail, CustomerName, MailSubject, MailContent, "rfidhero2014@hotmail.com", "smtp.live.com", "1qaz@WSX", 587, True)
                                If ret = False Then
                                    SendError += 1
                                Else
                                    SendComplete += 1
                                End If
                            Else
                                SendComplete += 1
                            End If
                        End If
                    End If
                    ProgressBar1.Value += 1

                    lblProgressSummary.Text = "RFIDHero 2014 Total : " & dt.Rows.Count & " Complete:" & SendComplete
                    If SendError > 0 Then
                        lblProgressSummary.Text = lblProgressSummary.Text & "  Error:" & SendError
                    End If
                    Application.DoEvents()
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

#Region "Send Email Message"
    Public Shared Function SendEmail(ByVal CustomerEmail As String, _
                                     ByVal CustomerName As String, _
                                     MailSubject As String, _
                                     MailContent As String, _
                                            ByVal SMTPMailFrom As String, _
                                            ByVal SMTPServer As String, _
                                            ByVal SMTPPassword As String, _
                                            ByVal MailPort As Integer, _
                                            ByVal MailSSL As Boolean) As Boolean
        'This procedure overrides the first procedure and accepts a single
        'string for the recipient and file attachement 
        Dim iCnt As Integer = 0
        'CustomerEmail = "Teerawat.kul@thaisummit.co.th"
        Try
            Dim MailMsg As New MailMessage '(New MailAddress(strFrom.Trim()), New MailAddress(strTo))
            MailMsg.From = New MailAddress(SMTPMailFrom)
            Dim strMail() As String = CustomerEmail.Replace(",", ";").Split(";")
            For i As Integer = 0 To strMail.Length - 1
                If strMail(i).Trim() <> "" Then
                    MailMsg.To.Add(New MailAddress(strMail(i).Trim()))
                End If
            Next

            MailMsg.Subject = MailSubject
            MailMsg.Body = MailContent
            MailMsg.IsBodyHtml = True
            MailMsg.From = New MailAddress(SMTPMailFrom, "tanapol.acentech", System.Text.Encoding.GetEncoding("iso-8859-11"))
            'MailMsg.From = New MailAddress(SMTPMailFrom)
            MailMsg.Headers.Add("Reply-To", "tanapol.acentech@gmail.com")

            Dim FileName As String = Application.StartupPath & "\20150206101126.jpg"

            If IO.File.Exists(FileName) = True Then
                Dim att As New Net.Mail.Attachment(FileName)
                att.ContentId = "ATTIMG1"
                MailMsg.Attachments.Add(att)
            End If

            

            'Dim att2 As New Net.Mail.Attachment(Application.StartupPath & "\PrintAdsTheretrunofRFIDHERO.jpg")
            'att2.ContentId = "ATTIMG2"
            'MailMsg.Attachments.Add(att2)

            'Smtpclient to send the mail message
            Dim SmtpMail As New SmtpClient(SMTPServer, MailPort)
            'SmtpMail.Host = SMTPServer
            'SmtpMail.Port = MailPort
            SmtpMail.UseDefaultCredentials = False
            SmtpMail.Credentials = New Net.NetworkCredential(SMTPMailFrom, SMTPPassword)
            SmtpMail.EnableSsl = MailSSL
            SmtpMail.Send(MailMsg)

            Return True
        Catch ex As Exception
            CreateLogFile("Exception SendEmail : " & ex.Message & "####" & CustomerEmail)
            Return False
        End Try
    End Function

    Private Shared Function MailDetail(ByVal CustomerName As String) As String

        Dim strBody As New StringBuilder
        strBody.Append("<table border='0' cellpadding='0' cellspacing='0' width='100%'>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>เรียนเชิญ คุณ" & CustomerName & "</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr><td>&nbsp;</td></tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;'>ขอเรียนเชิญท่านร่วมโครงการส่งเสริมการปรับกระบวนการจัดการโลจิสติกส์ด้วยการใช้เทคโนโลยี Applicatin ระบบ RFID และ Barcode</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td>ฟรี! ไม่มีค่าใช้จ่าย</td>")
        strBody.Append("    </tr>")
        'strBody.Append("    <tr>")
        'strBody.Append("        <td>ภายในงานท่านจะได้พบกับงานแสดง นวัตกรรมทางด้าน RFID ที่สามารถประยุกต์ใช้ในหลายๆ ธุรกิจ ไม่ว่าจะเป็น</td>")
        'strBody.Append("    </tr>")
        'strBody.Append("    <tr>")
        'strBody.Append("        <td>สถาบันการศึกษา, สถานพยาบาล, Logistic and supply chain, งานบริการ ฯลฯ</td>")
        'strBody.Append("    </tr>")
        'strBody.Append("    <tr><td>&nbsp;</td></tr>")
        'strBody.Append("    <tr>")
        'strBody.Append("        <td style='padding-left:50px;font-size:20pt;' ><b><font color='red'>พร้อมเปิดคลินิกให้คำปรึกษาเกี่ยวกับ RFID ฟรี!</font></b></td>")
        'strBody.Append("    </tr>")
        strBody.Append("    <tr><td>&nbsp;</td></tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;'>ในวันศุกร์ ที่ 6 มีนาคม 2558 เวลา 09:00 น. ถึง 17:00 น. ณ โรงแรมอโนมา ราชดำริ ชั้น 3</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr><td>&nbsp;</td></tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;font-size:20pt;color:#002060;' >เรียนเชิญลงทะเบียนออนไลน์ ได้ที่</td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td style='padding-left:50px;font-size:20pt;'><a href='http://www.sclenroll.org'>http://www.sclenroll.org</a></td>")
        strBody.Append("    </tr>")
        strBody.Append("    <tr><td>&nbsp;</td></tr>")
        strBody.Append("    <tr>")
        strBody.Append("        <td><img border=0 width='531' height='744' SRC='cid:ATTIMG1' /></td>")
        strBody.Append("    </tr>")
        'strBody.Append("    <tr><td>&nbsp;</td></tr>")
        'strBody.Append("    <tr>")
        'strBody.Append("        <td><img border=0 width='531' height='744' SRC='cid:ATTIMG2' /></td>")
        'strBody.Append("    </tr>")
        strBody.Append("</table>")
        Return strBody.ToString
    End Function
#End Region


    Private Shared Sub CreateLogFile(ByVal TxtLog As String)
        Dim LogFolder As String = Application.StartupPath & "\ErrorLog\" & DateTime.Now.ToString("yyyyMM") & "\"
        If IO.Directory.Exists(LogFolder) = False Then
            IO.Directory.CreateDirectory(LogFolder)
        End If

        Dim FileName As String = "ErrorLog_" & DateTime.Now.ToString("yyyyMMdd_HH_mm_ss_fff") & ".log"
        Dim objWriter As New System.IO.StreamWriter(LogFolder & FileName, True)
        objWriter.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff") & vbNewLine & TxtLog & vbNewLine)
        objWriter.Close()
    End Sub
End Class
