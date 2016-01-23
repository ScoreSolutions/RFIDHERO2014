Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Code.Card
Imports System.IO
Imports System.Threading
Imports kioskRFID.Org.Mentalis.Files
Imports System.Drawing.Printing

Public Class frmLoading
    Friend WithEvents m_reader As CodeDualiReader
    Dim INIFName As String = Application.StartupPath & "\Kiosk.ini"
    Dim ini As New IniReader(INIFName)
    Public mID As String = ""
    Dim PrintQueue As Print
    Dim t As Thread
    Dim strCusType As String
    Dim dDate As Date
    Dim printHeight As Integer

    Public Structure Print
        Dim QueueNo As String
        Dim Mobile As String
        Dim WaitingTime As String
        Dim ListService As String
        Dim CountQueue As String
    End Structure

    Private Sub pbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClose.Click
        System.Environment.Exit(0)
    End Sub

    'Private Sub frmLoading_FormClosed1(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    Stops()
    'End Sub

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FormWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim FormHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Size = New Size(FormWidth, FormHeight)
       
        'ConnectReader()
        Timer1.Interval = 500
        Timer1.Enabled = True

    End Sub

    '#Region "DE620"
    '    Public Sub m_reader_CardRemoved(ByVal sender As CardMode, ByVal value As SMARTCARD_DATA)
    '        Console.WriteLine("Card Remove " + sender.ToString())
    '    End Sub

    '    Public Sub m_reader_CardInserted(ByVal sender As CardMode, ByVal value As SMARTCARD_DATA)
    '        Console.WriteLine("Card Insert " + sender.ToString())

    '        If (sender = CardMode.Mifare) Then
    '            UpdateDisplay(value.SC_UID)
    '        End If

    '    End Sub

    '    Private Delegate Sub UpdateTextDelegate(ByVal text As String)
    '    Private Sub UpdateDisplay(ByVal text As String)
    '        If InvokeRequired Then
    '            Dim update As New UpdateTextDelegate(AddressOf UpdateDisplay)
    '            Invoke(update, New Object() {text})
    '        Else

    '            If InsertData(frmRegister.ID, frmRegister.ID, text) Then
    '                'Stops()
    '                PrintInterest()
    '                Me.Close()
    '            End If

    '        End If
    '    End Sub

    '    Sub Start()
    '        Try
    '            m_reader.ReadSmartcardPicture = False 'cbReadPicture.Checked
    '            m_reader.Connect()


    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try

    '    End Sub

    '    Sub Stops()
    '        Try
    '            'm_reader.ReadSmartcardPicture = False 'cbReadPicture.Checked
    '            m_reader.Diconnect()


    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try

    '    End Sub
    '#End Region


    '#Region "102"
    '    Function ConnectReader() As Boolean
    '        Try
    '            ini.Section = "SETTING"
    '            Dim port As Int16, baud As Integer, status As Int16
    '            port = Convert.ToInt32(ini.ReadString("Port"))
    '            baud = Convert.ToInt32(ini.ReadString("baud"))
    '            status = rf_init_com(port, baud)
    '            If (status = 0) Then
    '                'MessageBox.Show("OK")
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            Return False
    '        End Try

    '    End Function

    '    Sub Read()
    '        Dim i As Int16, j As Int16, port As Int16, baud As Int16, buf1(200) As Byte, b1 As Byte, s1 As String

    '        i = rf_request(0, &H52, j)
    '        If (i <> 0) Then
    '            'MessageBox.Show("Request Fail!")
    '            Exit Sub
    '        End If
    '        'Anticollision
    '        i = rf_anticoll(0, 4, buf1(0), b1)
    '        If (i <> 0) Then
    '            'MessageBox.Show("Anticollision Fail!")
    '            Exit Sub
    '        End If
    '        s1 = ""
    '        For i = 0 To b1 - 1
    '            's1 = s1 & Mid("00" & Hex(buf1(i)),  Hex(buf1(i)).Length - 2, 2)
    '            s1 = s1 & IIf(Hex(buf1(i)).Length < 2, "0", "") & Hex(buf1(i))
    '        Next i
    '        mID = s1
    '        If mID <> "" Then
    '            If InsertData(frmRegister.ID, frmRegister.ID, mID) Then
    '                'Stops()
    '                PrintInterest()
    '                Me.Close()
    '            End If
    '        End If
    '        'Select card
    '        i = rf_select(0, buf1(0), 4, b1)
    '        If (i <> 0) Then
    '            'MessageBox.Show("Select card fail!")
    '            'Exit Sub
    '        Else
    '            'MessageBox.Show("Select card succeed!")
    '        End If
    '    End Sub
    '#End Region

    'Function InsertData(ByVal strID As String, ByVal strMobile As String, ByVal strMifareID As String) As Boolean
    '    ' Dim objConn As New SqlConnection("")
    '    Dim iniReader1 As New Org.Mentalis.Files.IniReader(Application.StartupPath & "\kiosk.ini")
    '    Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
    '    servername = iniReader1.ReadString("Database", "ServerName")
    '    dbUserid = iniReader1.ReadString("Database", "Username")
    '    dbUserPassword = iniReader1.ReadString("Database", "Password")
    '    Fromdatabasename = iniReader1.ReadString("Database", "Database")
    '    strconn = "Data Source=" & servername & _
    '                  ";Persist Security Info=True;Password=" & dbUserPassword & _
    '                  ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename
    '    Dim objConn As New SqlConnection(strconn)


    '    Try
    '        If objConn.State = ConnectionState.Closed Then objConn.Open()
    '        Dim strSql As String = ""
    '        strSql = "update ERM_TS_PERSONAL_INFO set MifareId='" & strMifareID & "' " & _
    '                 "where id='" & strID & "' or  replace(mobile_no,'-','')  ='" & strMobile & "' "
    '        Dim objCmd As New SqlCommand(strSql, objConn)
    '        objCmd.ExecuteNonQuery()
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    Finally
    '        objConn.Close()
    '    End Try

    'End Function


#Region "Print"

    Function PrintInterest() As Boolean
        Try
            Dim p As New PrintDocument
            p.PrintController = New Printing.StandardPrintController
            Dim ini As New IniReader(INIFName)
            ini.Section = "SETTING"
            p.PrinterSettings.PrinterName = ini.ReadString("PrinterName")

            AddHandler p.PrintPage, AddressOf pd_PrintPage
            p.Print()
            lastPrintY = 0
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub pd_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        SetUpFont()
        lastPrintY = 0
        Dim iniReader1 As New Org.Mentalis.Files.IniReader(Application.StartupPath & "\kiosk.ini")
        Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
        servername = iniReader1.ReadString("Database", "ServerName")
        dbUserid = iniReader1.ReadString("Database", "Username")
        dbUserPassword = iniReader1.ReadString("Database", "Password")
        Fromdatabasename = iniReader1.ReadString("Database", "Database")
        strconn = "Data Source=" & servername & _
                      ";Persist Security Info=True;Password=" & dbUserPassword & _
                      ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename
        Dim objConn As New SqlConnection(strconn)
        Try
            If objConn.State = ConnectionState.Closed Then objConn.Open()
            Dim strSql As String = ""
            strSql = "select distinct D.id,B.Company_EN From ERM_TS_INTEREST A Left Join ERM_TS_Booth B on a.interest_code=b.ID " & _
                     "Left Join ERM_TS_PERSONAL_INFO C On A.erm_ts_personal_info_id=C.id Left Join ERM_TS_Booths D On B.Company_EN = D.Company_EN " & _
                     "where (C.id='" & frmRegister.ID & "' or replace(mobile_no,'-','') ='" & frmRegister.ID & _
                     "') and isnull(B.ID,'') <> '' "
            Dim objAdapter As New SqlDataAdapter(strSql, objConn)
            Dim Ds As New DataSet
            objAdapter.Fill(Ds, "Interest")

            PrintText("งาน RFID Hero 2013", fn12b, Align.Center, e)
            PrintText("หัวข้อที่่ท่านสนใจสามารถเข้าชม", fn12b, Align.Center, e)
            PrintText("และรับคำปรึกษาตามบูธต่อไปนี้", fn12b, Align.Center, e)
            'PrintText("", fn14b, Align.Center, e)
            'PrintText("", fn12b, Align.Center, e)
            PrintText("--------------------------------------", fn14, Align.Center, e)
            For Each Drow As DataRow In Ds.Tables("Interest").Rows
                'If (IsDBNull(Drow.Item("ID")) = False Or Drow.Item("ID") = "") And (IsDBNull(Drow.Item("Company_EN")) = False Or Drow.Item("Company_EN") = "") Then
                PrintText(Drow.Item("ID") & " " & Drow.Item("Company_EN"), fn12, Align.Left, e)
                Try
                    strSql = "Insert Into ERM_TS_Trans (ERM_ID,Booth_ID,Interest_Code,Status,Last_Update) Values ('" & _
                                             frmRegister.ID & "','" & Drow.Item("ID") & "','','0',getdate())"
                    Dim objCmd As New SqlCommand(strSql, objConn)
                    objCmd.ExecuteNonQuery()
                Catch ex As Exception

                End Try

                'End If
            Next
            PrintText("--------------------------------------", fn14, Align.Center, e)
            PrintText("หลังจากเสร็จสิ้นการเข้าเยี่ยมชมบูธทั้งหมด", fn10b, Align.Center, e)
            PrintText("ท่านสามารถเข้าแข่งขันเพื่อรับรางวัลได้ที่", fn10, Align.Center, e)
            PrintText("สนามพัทกอล์ฟ", fn10, Align.Center, e)

            'For Each Drow As DataRow In Ds.Tables("Interest").Rows
            '    PrintText("- " & Drow.Item("ID") & " " & Drow.Item("Company_EN"), fn12b, Align.Left, e)
            'Next
        Catch ex As Exception
        Finally
            objConn.Close()
        End Try


        With pd.DefaultPageSettings
            printHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
        End With

        e.HasMorePages = False
    End Sub
#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'mID = ""
        'Read()

        Timer1.Interval = 500
        Timer1.Enabled = True
    End Sub
End Class
