Imports System.IO
Public Class frmGetCaptureImageAgent

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
            ini.Section = "SETTING"
            Dim WebServiceURL As String = ini.ReadString("WebServiceURL")
            Dim ImagePath As String = ini.ReadString("ImagePath")
            If ImagePath.EndsWith("\") = False Then
                ImagePath = ImagePath & "\"
            End If
            ini = Nothing

            Dim ws As New RFIDHERO2014WebServiceAPI.RFIDHERO2014WebServiceAPI
            ws.Timeout = 10000
            ws.Url = WebServiceURL

            Dim dt As New DataTable
            dt = ws.GetPersonalImageForRecognition()
            If dt.Rows.Count > 0 Then
                If Directory.Exists(ImagePath) = False Then
                    Directory.CreateDirectory(ImagePath)
                End If

                For Each dr As DataRow In dt.Rows
                    Dim id As Long = Convert.ToInt64(dr("id"))
                    Dim FileName As String = ImagePath & id.ToString & ".jpg"
                    If Convert.IsDBNull(dr("image_file")) = False Then
                        Try
                            If File.Exists(FileName) = True Then
                                Try
                                    File.SetAttributes(FileName, FileAttributes.Normal)
                                    File.Delete(FileName)
                                Catch ex As Exception

                                End Try
                            End If

                            Dim FileByte() As Byte = DirectCast(dr("image_file"), Byte())
                            Dim fs As New FileStream(FileName, FileMode.CreateNew)
                            fs.Write(FileByte, 0, FileByte.Length)
                            fs.Close()

                            If ws.UpdateEBrochureStatus(id) = False Then
                                Try
                                    File.SetAttributes(FileName, FileAttributes.Normal)
                                    File.Delete(FileName)
                                Catch ex As Exception

                                End Try
                            End If
                        Catch ex As Exception

                        End Try
                    End If
                Next
            End If
            dt.Dispose()
            ws = Nothing
        Catch ex As Exception

        End Try
        Timer1.Enabled = True
    End Sub

    Private Sub frmGetCaptureImageAgent_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Visible = True
        Else
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub frmGetCaptureImageAgent_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Minimized
        Timer1_Tick(Nothing, Nothing)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
End Class
