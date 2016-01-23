Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.IO

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
 Public Class RFIDHERO2014WebServiceAPI
    Inherits System.Web.Services.WebService

    Dim CustomerImageFolder As String = ConfigurationManager.AppSettings("ImagePath").ToString()
    '<WebMethod()> _
    'Public Function HelloWorld() As String
    '    Return "Hello World"
    'End Function


    <WebMethod()> _
    Public Function SaveImageFile(PersonalInfoID As Long, FileByte() As Byte, FileByteNoLogo() As Byte) As Boolean
        Dim ret As Boolean = False
        Try
            If Directory.Exists(CustomerImageFolder) = False Then
                Directory.CreateDirectory(CustomerImageFolder)
            End If

            Dim FileName As String = CustomerImageFolder & PersonalInfoID.ToString.Trim & ".jpg"
            If File.Exists(FileName) = True Then
                Try
                    File.SetAttributes(FileName, FileAttributes.Normal)
                    File.Delete(FileName)
                Catch ex As Exception
                    Return False
                End Try
            End If

            If Directory.Exists(CustomerImageFolder & "NoLogo\") = False Then
                Directory.CreateDirectory(CustomerImageFolder & "NoLogo\")
            End If
            Dim FileNameNoLogo As String = CustomerImageFolder & "NoLogo\" & PersonalInfoID.ToString.Trim & ".jpg"
            If File.Exists(FileNameNoLogo) = True Then
                Try
                    File.SetAttributes(FileNameNoLogo, FileAttributes.Normal)
                    File.Delete(FileNameNoLogo)
                Catch ex As Exception
                    Return False
                End Try
            End If

            Dim lnq As New Linq.TABLE.ErmTsPersonalInfoLinq
            lnq.GetDataByPK(PersonalInfoID, Nothing)

            If lnq.ID > 0 Then
                lnq.IMAGE_PATH = FileName
                lnq.IMAGE_PATH_NOLOGO = FileNameNoLogo
                lnq.IS_POST_FACEBOOK = "1"
                Dim trans As New Linq.Common.Utilities.TransactionDB

                ret = lnq.UpdateByPK("WebServiceAPI.SaveImageFile", trans.Trans)
                If ret = True Then
                    Try
                        Dim fs As New FileStream(FileName, FileMode.CreateNew)
                        fs.Write(FileByte, 0, FileByte.Length)
                        fs.Close()

                        fs = New FileStream(FileNameNoLogo, FileMode.CreateNew)
                        fs.Write(FileByteNoLogo, 0, FileByteNoLogo.Length)
                        fs.Close()

                        trans.CommitTransaction()
                        ret = True
                    Catch ex As Exception

                        trans.RollbackTransaction()
                        ret = False
                        Try
                            File.SetAttributes(FileName, FileAttributes.Normal)
                            File.Delete(FileName)
                        Catch ex1 As Exception

                        End Try

                        Try
                            File.SetAttributes(FileNameNoLogo, FileAttributes.Normal)
                            File.Delete(FileNameNoLogo)
                        Catch ex2 As Exception

                        End Try
                    End Try
                End If
            End If
            lnq = Nothing

            ret = True
        Catch ex As Exception
            ret = False
        End Try
        Return ret
    End Function

    <WebMethod()> _
    Public Function GetImageFile(PersonalInfoID As Long) As Byte()
        Dim ret() As Byte
        Try
            Dim FileName As String = CustomerImageFolder & PersonalInfoID & ".jpg"
            If File.Exists(FileName) = True Then
                ret = File.ReadAllBytes(FileName)
            End If
        Catch ex As Exception

        End Try
        Return ret
    End Function

    Private Function GetImageFile(PersonalInfoID As Long, ImageFilePath As String) As Byte()
        Dim ret() As Byte
        Try
            If File.Exists(ImageFilePath) = True Then
                ret = File.ReadAllBytes(ImageFilePath)
            End If
        Catch ex As Exception

        End Try
        Return ret
    End Function

    <WebMethod()> _
    Public Function GetNewPersonalImageData() As DataTable
        Dim dt As New DataTable
        Try
            Dim lnq As New Linq.TABLE.ErmTsPersonalInfoLinq
            Dim sql As String = "select id, image_path "
            sql += " from ERM_TS_PERSONAL_INFO"
            sql += " where is_post_facebook='2'"
            dt = lnq.GetListBySql(sql, Nothing)

            If dt.Rows.Count > 0 Then
                dt.Columns.Add("image_file", GetType(Byte()))

                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim FileByte() As Byte = GetImageFile(dt.Rows(i)("id"), dt.Rows(i)("image_path"))
                    If FileByte IsNot Nothing Then
                        dt.Rows(i)("image_file") = FileByte
                    End If
                Next
            End If

            lnq = Nothing
        Catch ex As Exception
            dt = New DataTable
        End Try
        dt.TableName = "GetNewPersonalImageData"
        Return dt
    End Function

    <WebMethod()> _
    Public Function UpdateFacebookStatus(PersonalInfoID As Long) As Boolean
        Dim ret As Boolean = False
        Try
            Dim lnq As New Linq.TABLE.ErmTsPersonalInfoLinq
            lnq.GetDataByPK(PersonalInfoID, Nothing)


            Dim trans As New Linq.Common.Utilities.TransactionDB
            lnq.IS_POST_FACEBOOK = "3"

            ret = lnq.UpdateByPK("WebServiceAPI.UpdateFacebookStatus", trans.Trans)
            If ret = True Then
                trans.CommitTransaction()
            Else
                trans.RollbackTransaction()
            End If
        Catch ex As Exception
            ret = False
        End Try

        Return ret
    End Function


    <WebMethod()> _
    Public Function GetPersonalImageForRecognition() As DataTable
        Dim dt As New DataTable
        Try
            Dim lnq As New Linq.TABLE.ErmTsPersonalInfoLinq
            Dim sql As String = "select id, image_path_nologo "
            sql += " from ERM_TS_PERSONAL_INFO"
            sql += " where is_post_facebook = '1' "
            dt = lnq.GetListBySql(sql, Nothing)

            If dt.Rows.Count > 0 Then
                dt.Columns.Add("image_file", GetType(Byte()))

                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim FileByte() As Byte = GetImageFile(dt.Rows(i)("id"), dt.Rows(i)("image_path_nologo"))
                    If FileByte IsNot Nothing Then
                        dt.Rows(i)("image_file") = FileByte
                    End If
                Next
            End If

            lnq = Nothing
        Catch ex As Exception
            dt = New DataTable
        End Try
        dt.TableName = "GetPersonalImageForRecognition"
        Return dt
    End Function


    <WebMethod()> _
    Public Function UpdateEBrochureStatus(PersonalInfoID As Long) As Boolean
        Dim ret As Boolean = False
        Try
            Dim lnq As New Linq.TABLE.ErmTsPersonalInfoLinq
            lnq.GetDataByPK(PersonalInfoID, Nothing)


            Dim trans As New Linq.Common.Utilities.TransactionDB
            lnq.IS_POST_FACEBOOK = "2"

            ret = lnq.UpdateByPK("WebServiceAPI.UpdateEBrochureStatus", trans.Trans)
            If ret = True Then
                trans.CommitTransaction()
            Else
                trans.RollbackTransaction()
            End If
        Catch ex As Exception
            ret = False
        End Try

        Return ret
    End Function
End Class