Imports System.Data
Imports System.Data.SqlClient
Imports AMS
Imports System.IO
Public Class frmRegister

    Dim conn As New SqlConnection
    Dim _id As String
    Private ConfigINI As Profile.Ini
    Public Property ID() As String
        Get
            ID = _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000
        Timer1.Start()

        ConfigINI = New Profile.Ini(Application.StartupPath & "\kiosk.ini")
        Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
        servername = ConfigINI.GetValue("Database", "ServerName", "")
        dbUserid = ConfigINI.GetValue("Database", "Username", "")
        dbUserPassword = ConfigINI.GetValue("Database", "Password", "")
        Fromdatabasename = ConfigINI.GetValue("Database", "Database", "")
        strconn = "Data Source=" & servername & _
                      ";Persist Security Info=True;Password=" & dbUserPassword & _
                      ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename

        conn = New SqlConnection(strconn)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Dim IsFinish As Boolean = False
        Do While IsFinish = False

            Try
                Dim savepath As String = ConfigINI.GetValue("CaptureImage", "savepath", "")
                Dim di As New DirectoryInfo(savepath & "Logo")
                For Each fri As FileInfo In di.GetFiles()
                    Dim filename As String = Replace(fri.Name, fri.Extension, "")
                    Dim webserviceurl As String
                    webserviceurl = ConfigINI.GetValue("Setting", "webserviceurl")
                    Dim ws As New RFIDHERO2014WebServiceAPI.RFIDHERO2014WebServiceAPI
                    ws.Url = webserviceurl
                    Dim buffer_logo As Byte() = File.ReadAllBytes(fri.FullName)
                    Dim buffer_nologo As Byte() = File.ReadAllBytes(fri.Directory.Parent.FullName & "\NoLogo\" & filename & "_nologo.jpg")
                    If ws.SaveImageFile(filename, buffer_logo, buffer_nologo) Then
                        File.Delete(fri.FullName)
                        File.Delete(fri.Directory.Parent.FullName & "\NoLogo\" & filename & "_nologo.jpg")
                    End If
                Next fri
            Catch ex As Exception
                'MessageBox.Show(ex.ToString())
                'Timer1.Enabled = False
                'Exit Sub
            End Try

            Application.DoEvents()
            IsFinish = True
        Loop
        Timer1.Enabled = True
    End Sub

    Function GetInfo(ByVal Number As String) As DataTable
        Dim iniReader1 As New Org.Mentalis.Files.IniReader(Application.StartupPath & "\kiosk.ini")
        Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
        servername = iniReader1.ReadString("Database", "ServerName")
        dbUserid = iniReader1.ReadString("Database", "Username")
        dbUserPassword = iniReader1.ReadString("Database", "Password")
        Fromdatabasename = iniReader1.ReadString("Database", "Database")
        strconn = "Data Source=" & servername & _
                      ";Persist Security Info=True;Password=" & dbUserPassword & _
                      ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename
        conn = New SqlConnection(strconn)
        If conn.State = ConnectionState.Closed Then conn.Open()

        Dim sql As String = "Select * from ERM_TS_PERSONAL_INFO Where ID='" & Number & "' or  replace(mobile_no,'-','') ='" & Number & "' "
        Dim myadapter As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        myadapter.Fill(dt)
        If dt.Rows.Count > 0 Then
            _id = dt.Rows(0).Item("ID").ToString
        Else
            _id = 0
        End If
        conn.Close()
        Return dt
    End Function

    Sub OK()
        Try
            Dim dt As New DataTable
            dt = GetInfo(txtNumber.Text)
            If dt.Rows.Count > 0 Then
                frmKiosCapture.Show()
                txtNumber.Text = ""
                Dim player As New System.Media.SoundPlayer(Application.StartupPath & "\sound.wav")
                player.Play()

            Else
                frmDialogMsg.lblText.Text = "ไม่พบข้อมูล กรุณาลงทะเบียนก่อนค่ะ"
                frmDialogMsg.ShowDialog()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "btnNumberClick"
    Dim k_len As Integer = 10

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "9"
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        OK()
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "0"
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If txtNumber.Text <> "" Then txtNumber.Text = txtNumber.Text.Substring(0, (txtNumber.Text.Length - 1))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OK()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
#End Region

End Class