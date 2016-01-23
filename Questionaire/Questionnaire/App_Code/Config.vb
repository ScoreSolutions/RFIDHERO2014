Imports Microsoft.VisualBasic
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Configuration
Imports System.Xml.Serialization
Imports System.IO
Imports System.Data
Imports Para.Common
Imports Para.Common.Utilities
Imports Para.TABLE
Imports Engine.Common

Public Class Config

    Public Shared Function GetUserName() As String
        'Dim p As New Page
        'Return p.User.Identity.Name.Trim

        Return "SYSTEM"
    End Function

    Public Shared Sub RedirecPage(ByVal url As String, ByVal frm As Page)
        Dim popupScript As String = "<script language='javascript'>"
        popupScript += "  window.location='" + url + "';  "
        popupScript += " </script>"
        ScriptManager.RegisterStartupScript(frm, GetType(String), "RedirecPage", popupScript, False)
    End Sub

    Public Shared Function ChkLogin() As Boolean
        Dim User As UserProfilePara = GetLogOnUser()
        Return (User.UserName.Trim <> "")
    End Function

    Public Shared Function ChkPermission(ByVal MenuID As Long) As Boolean
        Dim User As UserProfilePara = GetLogOnUser()
        Return True
    End Function

    Public Shared Sub BuildNoColumn(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            dt.Columns.Add("NO")
            Dim i As Integer = 1
            For Each dr As DataRow In dt.Rows
                dr("no") = i & ". "
                i += 1
            Next
        End If
    End Sub

    'Public Shared Function GetLogOnUser() As UserProfilePara
    '    Dim ret As New UserProfilePara
    '    Try
    '        Dim id As FormsIdentity = HttpContext.Current.User.Identity
    '        Dim tik As FormsAuthenticationTicket = id.Ticket
    '        Dim sr As New XmlSerializer(GetType(UserProfilePara))
    '        Dim st As New MemoryStream(Convert.FromBase64String(tik.UserData))
    '        ret = sr.Deserialize(st)
    '    Catch ex As Exception

    '    End Try

    '    Return ret
    'End Function

    Public Shared Function GetLogOnUser() As UserProfilePara
        Dim ret As UserProfilePara
        Try
            ret = HttpContext.Current.Session.Item(Constant.UserProfileSession)
        Catch ex As Exception

        End Try

        Return ret
    End Function

    Public Shared Function GetLoginSession() As LoginSessionPara
        Dim ret As New LoginSessionPara
        Try
            Dim id As FormsIdentity = HttpContext.Current.User.Identity
            Dim tik As FormsAuthenticationTicket = id.Ticket
            Dim sr As New XmlSerializer(GetType(LoginSessionPara))
            Dim st As New MemoryStream(Convert.FromBase64String(tik.UserData))
            ret = sr.Deserialize(st)
        Catch ex As Exception

        End Try

        Return ret
    End Function

    'Public Shared Function GetConfigValue(ByVal configName As String) As String
    '    Dim Proc As New FunctionProcess
    '    Return Proc.GetConfigValue(configName)
    'End Function


    Public Shared Sub SetAlert(ByVal msg As String, ByVal frm As Page)
        Dim popupScript As String = "<script language='javascript'>  alert('" & msg & "');  </script>"
        ScriptManager.RegisterStartupScript(frm, GetType(String), "SetAlert1", popupScript, False)
    End Sub
    Public Shared Sub ShowModalDialog(ByVal url As String, ByVal frm As Page)
        Dim popupScript As String = "<script language='javascript'>"
        popupScript += "  window.showModalDialog('" & url & "', '" & frm.ClientID & "', 'center:yes;resizable:no;dialogWidth:800px;dialogHeight:500px;scrollbars:0;location:0;directories:0;status:0;menubar:0;');  "
        popupScript += " </script>"
        ScriptManager.RegisterStartupScript(frm, GetType(String), "SetAlert1", popupScript, False)
    End Sub

    Public Shared Sub SetAlert(ByVal msg As String, ByVal frm As Page, ByVal ClientID As String)
        Dim popupScript As String = "<script language='javascript'> " & _
        " alert('" & msg & "'); " & _
        " document.getElementById('" & ClientID & "').focus();" & _
        " </script>"
        ScriptManager.RegisterStartupScript(frm, GetType(String), "SetAlert1", popupScript, False)
    End Sub
    Public Shared Function GetUploadPath() As String
        If System.IO.Directory.Exists(ConfigurationSettings.AppSettings("UploadPath").ToString) = False Then
            System.IO.Directory.CreateDirectory(ConfigurationSettings.AppSettings("UploadPath").ToString)
        End If
        Return ConfigurationSettings.AppSettings("UploadPath").ToString
    End Function

    Public Shared Function GetUploadURL() As String

    End Function
    Public Shared Function GetIconURL(ByVal req As HttpRequest) As String
        Return ConfigurationSettings.AppSettings("IconURL").ToString
    End Function
    Public Shared Function getServerPath() As String
        Return ConfigurationManager.AppSettings("UploadPath").ToString
    End Function
    Public Shared Function UploadFile(ByVal FileUpload1 As FileUpload, ByVal fileName As String, ByVal fldName As String) As Boolean
        'Upload and save file at directory
        Dim ret As Boolean = True

        If FileUpload1.HasFile = True Then
            Dim extension As String = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName).ToLower()
            Dim MIMEType As String = ""

            Try
                MIMEType = getMIMEType(FileUpload1.PostedFile.FileName)
                If MIMEType = "" Then
                    Return False
                    Exit Function
                End If

                Dim X As String = Path.GetFileName(fileName)
                X = fldName & X & MIMEType
                'Ex.  D:\ElawUpload\   Document\Contract\   fileName.ext

                If Directory.Exists(fldName) = False Then
                    Directory.CreateDirectory(fldName)
                End If
                FileUpload1.PostedFile.SaveAs(X)
                ret = True
            Catch ex As Exception
                ret = False

            End Try
        End If

        Return ret
    End Function
    Public Shared Function getMIMEType(ByVal vFileName As String) As String
        Dim extension As String = System.IO.Path.GetExtension(vFileName).ToLower()
        Dim MIMEType As String = ""

        Select Case extension
            Case ".jpg", ".jpeg", ".jpe"
                MIMEType = ".jpg"
            Case ".csv", ".xls", ".xlsx", ".pdf", ".doc", ".docx", ".txt", ".png", ".gif"
                MIMEType = extension
            Case ".htm", ".html"
                MIMEType = ".html"
            Case Else
                MIMEType = ""
        End Select

        Return MIMEType

    End Function
    Public Shared Function BaseURL(ByVal req As HttpRequest) As String
        Return req.Url.Host & ConfigurationManager.AppSettings("UploadURL").ToString()
    End Function

    'Public Shared Sub SaveTransLog(ByVal TransDesc As String)
    '    Dim trans As New Func.Common.DbTrans
    '    trans.CreateTransaction()
    '    Try
    '        Dim uPara As LoginSessionPara = GetLoginSession()
    '        Dim para As New LogTransPara
    '        para.LOGIN_HIS_ID = uPara.LOGIN_HISTORY_ID
    '        para.TRANS_DATE = DateTime.Now
    '        para.TRANS_DESC = TransDesc

    '        Dim fnc As New LogFunc
    '        If fnc.SaveTransLog(GetUserName, para, trans) = True Then
    '            trans.CommitTransaction()
    '        Else
    '            trans.RollbackTransaction()
    '            SaveErrorLog(fnc.ErrorMessage)
    '        End If
    '    Catch ex As Exception
    '        trans.RollbackTransaction()
    '        SaveErrorLog(ex.Message)
    '    End Try
    'End Sub

    'Public Shared Sub SaveErrorLog(ByVal ErrDesc As String)
    '    Dim trans As New Func.Common.DbTrans
    '    trans.CreateTransaction()
    '    Try
    '        Dim uPara As LoginSessionPara = GetLoginSession()
    '        Dim para As New LogErrorPara
    '        para.LOGIN_HIS_ID = uPara.LOGIN_HISTORY_ID
    '        para.ERROR_TIME = DateTime.Now
    '        para.ERROR_DESC = ErrDesc

    '        Dim fnc As New LogFunc
    '        If fnc.SaveErrLog(GetUserName, para, trans) = True Then
    '            trans.CommitTransaction()
    '        Else
    '            trans.RollbackTransaction()
    '        End If
    '    Catch ex As Exception
    '        trans.RollbackTransaction()
    '    End Try
    'End Sub

End Class
