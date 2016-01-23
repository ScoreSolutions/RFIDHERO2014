Imports System.IO
Imports System.Data
Imports AMS
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
'Imports Facebook
'Imports Newtonsoft.Json.Linq
Imports System.Configuration
Imports System.Drawing.Printing
Imports System.Data.SqlClient
Imports GenCode128

Public Class frmKiosCapture
    Private ConfigINI As Profile.Ini
    Private webcam As WebCam
    Dim _Number As String
    Dim _IsCapture As Boolean = False
    Dim CamIndex As Integer = 0
   

    Private waitingForm As frmWaiting
    Private Delegate Sub CloseWaitingFormCallback()
    Private Delegate Sub ShowMessageBoxCallback(ByVal str As String, ByVal caption As String, ByVal button As MessageBoxButtons, ByVal icon As MessageBoxIcon)

    Public WriteOnly Property Number() As String
        Set(ByVal value As String)
            _Number = value
        End Set
    End Property
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigINI = New Profile.Ini(Application.StartupPath & "\kiosk.ini")
        pcImage.BringToFront()

        Try
            webcam = New WebCam()
            webcam.InitializeWebCam(pcImage)
            webcam.Start(CamIndex)

            Dim FormWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim FormHeight As Integer = Screen.PrimaryScreen.Bounds.Height
            Dim CaptureHeight As Integer = ConfigINI.GetValue("CaptureImage", "CaptureHeight", "")
            Dim CaptureWidth As Integer = ConfigINI.GetValue("CaptureImage", "CaptureWidth", "")
            Me.Size = New Size(FormWidth, FormHeight)
            pbReCapture.Location = New Point(pbCapture.Location)
            pbClose.Location = New Point(FormWidth - 40, 12)

            webcam.CaptureHeight(CaptureHeight)
            webcam.CaptureWidth(CaptureWidth)

            pbCapture.BringToFront()

        Catch ex As Exception
            Me.Close()
        End Try

    End Sub

    Private Sub pbCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCapture.Click, pbCapture.Click
        CaptureEvent()
    End Sub
    Private Sub pbReCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbReCapture.Click, pbReCapture.Click
        ReCapture()
    End Sub
    Private Sub pbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbSave.Click, pbSave.Click
        Save()

    End Sub

    Private Sub pbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClose.Click
        _IsCapture = False

        pbReCapture.Visible = False
        pbCapture.Visible = True
        pbSave.Visible = False

        webcam.Stop()
        System.Environment.Exit(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CaptureEvent()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Save()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReCapture()
    End Sub

#Region "Sub&Function"

    Sub CaptureEvent()
        pbReCapture.Visible = True
        pbSave.Visible = True
        pbCapture.Visible = False

        Panel1.BringToFront()
        CaptureImage(frmRegister.ID)
        webcam.Stop()

        CombineImage(frmRegister.ID)

        _IsCapture = True
    End Sub

    Sub CaptureImage(ByVal id As String)
        Dim FileName As String = id & ".jpg"
        Dim Path As String = ConfigINI.GetValue("CaptureImage", "path", "")
        If Directory.Exists(Path) = False Then
            Directory.CreateDirectory(Path)
        End If
        Dim Path1 As String = Path & FileName
        pcImage.Image.Save(Path1, System.Drawing.Imaging.ImageFormat.Jpeg)

        Threading.Thread.Sleep(1000)
        Dim bipimag As New MemoryStream(File.ReadAllBytes(Path1))
        Dim imag As Image = New Bitmap(bipimag)
        pbDisplay.BackgroundImageLayout = ImageLayout.Stretch
        pbDisplay.Image = imag
    End Sub

    Private Sub CombineImage(ByVal id As String)
        Dim FileName As String = id & ".jpg"
        Dim FileNameNologo As String = id & "_nologo.jpg"

        Dim Path As String = ConfigINI.GetValue("CaptureImage", "path", "")
        Using character As Image = pbDisplay.Image
            Using bg As Image = New Bitmap(pcBG.Image)

                Using newImage As New Bitmap(640, 480)
                    Using canvas As System.Drawing.Graphics = Graphics.FromImage(newImage)
                        canvas.InterpolationMode = InterpolationMode.HighQualityBicubic
                        canvas.DrawImage(character, New Rectangle(0, 0, 800, pbDisplay.Size.Height), New Rectangle(0, 0, 800, character.Height), GraphicsUnit.Pixel)


                        canvas.DrawImage(bg, New Rectangle(430, 300, pcBG.Size.Width, pcBG.Size.Height), New Rectangle(0, 0, pcBG.Width, pcBG.Height), GraphicsUnit.Pixel)
                        canvas.Save()
                        If Not System.IO.Directory.Exists(Path) Then
                            System.IO.Directory.CreateDirectory(Path)
                        End If

                        newImage.Save(Path & FileName, ImageFormat.Png)
                        pbDisplay.Image.Save(Path & FileNameNologo, ImageFormat.Png)
                        'canvas.Dispose()
                    End Using
                End Using
            End Using
        End Using

        Dim bipimag As New MemoryStream(File.ReadAllBytes(Path & FileName))
        Dim imag2 As Image = New Bitmap(bipimag)
        pbDisplay.BackgroundImageLayout = ImageLayout.Stretch
        pbDisplay.Image = imag2

    End Sub

    Public Function CaptureScreen() As Bitmap
        Dim Width As Integer = 640
        Dim Height As Integer = 480
        Dim x As Integer = 74
        Dim y As Integer = 418

        Dim tempBmp As New Bitmap(Width, _
                          Height, _
                          System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim grp As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(tempBmp)
        grp.CopyFromScreen(x, y, _
                           0, 0, Screen.PrimaryScreen.Bounds.Size, _
                           System.Drawing.CopyPixelOperation.SourceCopy)

        Return tempBmp
    End Function

    Sub ReCapture()
        webcam.Start(CamIndex)
        pbCapture.Visible = True
        pbReCapture.Visible = False
        pbSave.Visible = False

        pcImage.BringToFront()
        pbCapture.BringToFront()

        Dim FileName As String = frmRegister.ID & ".jpg"
        Dim FileNameNologo As String = frmRegister.ID & "_nologo.jpg"
        Dim Path As String = ConfigINI.GetValue("CaptureImage", "path", "")
        File.Delete(Path & FileName)
        File.Delete(Path & FileNameNologo)
    End Sub

    Sub Save()
        If _IsCapture = False Then

            Exit Sub
        End If

        Try

            Dim FileName As String = frmRegister.ID & ".jpg"
            Dim FileNameNologo As String = frmRegister.ID & "_nologo.jpg"
            Dim Path As String = ConfigINI.GetValue("CaptureImage", "path", "")
            Dim savepath As String = ConfigINI.GetValue("CaptureImage", "savepath", "")

            Try
                If Directory.Exists(savepath & "Logo") = False Then
                    Directory.CreateDirectory(savepath & "Logo")
                End If
                If Directory.Exists(savepath & "NoLogo") = False Then
                    Directory.CreateDirectory(savepath & "NoLogo")
                End If

                If File.Exists(savepath & "Logo\" & FileName) = True Then
                    File.Delete(savepath & "Logo\" & FileName)
                End If
                File.Copy(Path & FileName, savepath & "Logo\" & FileName)
                File.Delete(Path & FileName)

                If File.Exists(savepath & "NoLogo\" & FileNameNologo) = True Then
                    File.Delete(savepath & "NoLogo\" & FileNameNologo)
                End If
                File.Copy(Path & FileNameNologo, savepath & "NoLogo\" & FileNameNologo)
                File.Delete(Path & FileNameNologo)
            Catch ex As Exception

            End Try

            _IsCapture = False
            pbReCapture.Visible = False
            pbCapture.Visible = True
            pbSave.Visible = False

            '== print and close form
            If GetStatusForPrint() = 0 Then
                Dim IsPrintFinish As Boolean = False
                While IsPrintFinish = False
                    PrintInterest()
                    Application.DoEvents()
                    IsPrintFinish = True
                End While
            End If

            frmRegister.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


#End Region

#Region "Print"

    Function GetDataForPrint() As DataSet
        Dim Ds As New DataSet
        ConfigINI = New Profile.Ini(Application.StartupPath & "\kiosk.ini")
        Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
        servername = ConfigINI.GetValue("Database", "ServerName", "")
        dbUserid = ConfigINI.GetValue("Database", "Username", "")
        dbUserPassword = ConfigINI.GetValue("Database", "Password", "")
        Fromdatabasename = ConfigINI.GetValue("Database", "Database", "")
        strconn = "Data Source=" & servername & _
                      ";Persist Security Info=True;Password=" & dbUserPassword & _
                      ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename
        Dim objConn As New SqlConnection(strconn)
        Try
            If objConn.State = ConnectionState.Closed Then objConn.Open()
            Dim strSql As String = "select id,isnull(first_name,'') + ' ' + isnull(middle_name,'') + ' ' + isnull(last_name,'') as name" & _
                                 ",isnull(telno,'') telno,isnull(email,'') email,isnull(company_name,'') company_name,isnull(mobile_no,'') mobile_no from ERM_TS_PERSONAL_INFO where id='" & frmRegister.ID & "'"
            Dim objAdapter As New SqlDataAdapter(strSql, objConn)
            objAdapter.Fill(Ds, "REGISTER")
        Catch ex As Exception
        End Try
        objConn.Close()
        Return Ds
    End Function

    Function GetStatusForPrint() As Integer
        Dim Ds As New DataSet
        ConfigINI = New Profile.Ini(Application.StartupPath & "\kiosk.ini")
        Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
        servername = ConfigINI.GetValue("Database", "ServerName", "")
        dbUserid = ConfigINI.GetValue("Database", "Username", "")
        dbUserPassword = ConfigINI.GetValue("Database", "Password", "")
        Fromdatabasename = ConfigINI.GetValue("Database", "Database", "")
        strconn = "Data Source=" & servername & _
                      ";Persist Security Info=True;Password=" & dbUserPassword & _
                      ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename
        Dim objConn As New SqlConnection(strconn)
        Dim status As Integer = 0
        Try
            If objConn.State = ConnectionState.Closed Then objConn.Open()
            Dim strSql As String = "select isnull(is_post_facebook,0) is_post_facebook from ERM_TS_PERSONAL_INFO where id='" & frmRegister.ID & "'"
            Dim objAdapter As New SqlDataAdapter(strSql, objConn)
            objAdapter.Fill(Ds, "REGISTER")
            If Ds.Tables("REGISTER").Rows.Count > 0 Then
                status = Ds.Tables("REGISTER").Rows(0)("is_post_facebook")
            End If
        Catch ex As Exception
        End Try
        objConn.Close()

        Return status
    End Function

    Dim printHeight As Integer

    Function PrintInterest() As Boolean
        Try
            Dim p As New PrintDocument
            p.PrintController = New Printing.StandardPrintController
            Dim PrinterName As String = ConfigINI.GetValue("SETTING", "PrinterName", "")
            p.PrinterSettings.PrinterName = PrinterName

            AddHandler p.PrintPage, AddressOf PrintDocument1_PrintPage
            p.Print()

            lastPrintY = 0

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'SetUpFont()
        lastPrintY = 0

        Try

            Dim Ds As New DataSet
            Ds = GetDataForPrint()

            For Each Drow As DataRow In Ds.Tables("REGISTER").Rows
                Dim id As String = Drow.Item("id").ToString
                Dim name As String = Drow.Item("name").ToString
                Dim email As String = Drow.Item("email").ToString
                Dim mobile_no As String = Drow.Item("mobile_no").ToString
                Dim company_name As String = Drow.Item("company_name").ToString

                'Dim _qrcode As String = id & "|" & name & "|" & email & "|" & telno & "|" & company_name
                'Dim NameByte() As Byte = System.Text.Encoding.GetEncoding("iso-8859-11").GetBytes(name)
                'Dim deName As System.Text.Decoder
                'deName.
                Dim _qrcode As String = id & "|" & email


                Dim obj As New WolfSoftware.Library_NET.BarcodeControl
                obj.Unlock("Phantom 2008", "WSFCX-0100-100883561")
                obj.CurrentCode = 1014
                obj.DataToEncode = _qrcode 'Convert.ToBase64String(ByteCode) 

                Dim pic As New Bitmap(obj.GetCode(300))
                pic.SetResolution(1080, 1080)
                PictureBox2.Image = pic
                PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
                txtCompany.Text = company_name
                txtemail.Text = email
                txtName.Text = name
                txtTel.Text = mobile_no

                Dim pic2 As New Bitmap(gbTag.ClientRectangle.Width, gbTag.ClientRectangle.Height)
                gbTag.DrawToBitmap(pic2, gbTag.ClientRectangle)

                PrintImage(pic2, Align.Center, e)
            Next
            Ds.Dispose()
        Catch ex As Exception
        Finally
        End Try

        With PrintDocument1.DefaultPageSettings
            printHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
        End With

        e.HasMorePages = False

    End Sub

    'Sub PrintText(name As String, email As String, telno As String, company_name As String, e As System.Drawing.Printing.PrintPageEventArgs)
    '    '## QRCode
    '    'Dim path As String = Application.StartupPath() & "\temp"
    '    'If Directory.Exists(path) = False Then
    '    '    Directory.CreateDirectory(path)
    '    'End If

    '    'If File.Exists(path & "\QRCode.jpg") Then
    '    '    File.Delete(path & "\QRCode.jpg")
    '    'End If

    '    Dim _qrcode As String = name & "|" & email & "|" & telno & "|" & company_name
    '    Dim obj As New WolfSoftware.Library_NET.BarcodeControl
    '    obj.Unlock("Phantom 2008", "WSFCX-0100-100883561")
    '    obj.CurrentCode = 1014
    '    obj.DataToEncode = _qrcode

    '    Dim pic As New Bitmap(obj.GetCode(300)) 'The bitmap you created
    '    pic.SetResolution(1080, 1080)
    '    PictureBox2.Image = pic
    '    PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    '    txtCompany.Text = company_name
    '    txtemail.Text = email
    '    txtName.Text = name
    '    txtTel.Text = telno

    '    Dim g As Graphics = Graphics.FromImage(pic)
    '    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
    '    g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit

    '    Dim pic2 As New Bitmap(gbTag.ClientRectangle.Width, gbTag.ClientRectangle.Height) 'The bitmap you created
    '    gbTag.DrawToBitmap(pic2, gbTag.ClientRectangle)

    '    'Dim QRCodePath As String = GenQRCode(_qrcode)
    '    PrintImage(pic2, Align.Center, e)
    '    '## QRCode

    'End Sub
#End Region
   
End Class
