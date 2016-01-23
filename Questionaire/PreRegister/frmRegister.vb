Imports System.Text
Imports System.Data
Imports System.IO

Public Class frmRegister

    Private Sub pbClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClose.Click
        Application.Exit()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Valid() = True Then
            Dim Erm As New Para.TABLE.ErmTsPersonalInfoPara
            If lblID.Text <> "0" Then
                Erm.ID = Convert.ToInt64(lblID.Text)
            End If
            Erm.IDCARD_NO = "0"
            'txtIDCardNo.Text;
            If rdiTitleMR.Checked = True Then
                Erm.TITLE_NAME = "MR"
            ElseIf rdiTitleMRS.Checked = True Then
                Erm.TITLE_NAME = "MRS"
            ElseIf rdiTitleMS.Checked = True Then
                Erm.TITLE_NAME = "MS"
            ElseIf rdiTitleOther.Checked = True Then
                Erm.TITLE_NAME = txtTitleOther.Text
            End If

            Erm.FIRST_NAME = txtFirstName.Text
            Erm.MIDDLE_NAME = ""
            ' txtMiddleName.Text;
            Erm.LAST_NAME = txtLastName.Text
            Erm.POSITION_NAME = txtPosition.Text
            Erm.COMPANY_NAME = txtCompany.Text
            Erm.ADDRESS = txtAddress.Text
            Erm.CITY = txtCity.Text
            Erm.STATE = ""
            'txtState.Text;
            Erm.COUNTRY = txtCountry.Text
            Erm.ZIPCODE = txtZipCode.Text
            Erm.TELNO = txtTelNumber.Text
            Erm.FAXNO = txtFaxNumber.Text
            Erm.EMAIL = txtEmail.Text
            Erm.WEBSITE = txtWebsite.Text
            Erm.DIVISION = txtDivision.Text
            Erm.MOBILE_NO = txtMobileNumber.Text
            If chkPerionMorning.Checked AndAlso chkPeriodAfternoon.Checked = True Then
                Erm.REGISPERIOD = "3"
            Else
                If chkPerionMorning.Checked = True Then
                    Erm.REGISPERIOD = "1"
                ElseIf chkPeriodAfternoon.Checked = True Then
                    Erm.REGISPERIOD = "2"
                End If
            End If

            Erm.REGISTERED_CAPITAL = 0
            Erm.ANNUAL_SALE_VALUE_YEAR = DateTime.Today.Year

            If rdAnnualSaleLess20.Checked = True Then
                Erm.ANNUAL_SALE_VALUE_VOLUMNS = "01"
            ElseIf rdAnnualSaleOver20.Checked = True Then
                Erm.ANNUAL_SALE_VALUE_VOLUMNS = "02"
            End If


            Dim Trans As New Linq.Common.Utilities.TransactionDB
            Dim eng As New Engine.Questionnaire.RegisterENG

            Dim id As Long = 0
            id = eng.SavePersonalInfo(Erm, "PreRegister", Trans)

            If id > 0 Then
                Try
                    SaveDetail(chkA01, id, Trans, "", "A")
                    SaveDetail(chkA02, id, Trans, "", "A")
                    SaveDetail(chkA03, id, Trans, "", "A")
                    SaveDetail(chkA04, id, Trans, "", "A")
                    SaveDetail(chkA05, id, Trans, "", "A")
                    SaveDetail(chkA06, id, Trans, "", "A")
                    SaveDetail(chkA07, id, Trans, "", "A")
                    SaveDetail(chkA08, id, Trans, "", "A")
                    SaveDetail(chkA09, id, Trans, "", "A")
                    SaveDetail(chkA10, id, Trans, txtA10.Text, "A")
                    SaveDetail(chkA11, id, Trans, "", "A")
                    SaveDetail(chkA12, id, Trans, "", "A")
                    SaveDetail(chkA13, id, Trans, "", "A")
                    SaveDetail(chkA14, id, Trans, "", "A")
                    SaveDetail(chkA15, id, Trans, "", "A")
                    SaveDetail(chkA16, id, Trans, "", "A")
                    SaveDetail(chkA17, id, Trans, txtA17.Text, "A")

                    SaveDetail(chkB01, id, Trans, "", "B")
                    SaveDetail(chkB02, id, Trans, "", "B")
                    SaveDetail(chkB03, id, Trans, "", "B")
                    SaveDetail(chkB04, id, Trans, txtB04.Text, "B")
                    SaveDetail(chkB05, id, Trans, txtB05.Text, "B")
                    SaveDetail(chkB06, id, Trans, txtB06.Text, "B")
                    SaveDetail(chkB07, id, Trans, "", "B")
                    SaveDetail(chkB08, id, Trans, "", "B")
                    SaveDetail(chkB09, id, Trans, "", "B")
                    SaveDetail(chkB10, id, Trans, "", "B")
                    SaveDetail(chkB11, id, Trans, "", "B")
                    SaveDetail(chkB12, id, Trans, "", "B")
                    SaveDetail(chkB13, id, Trans, "", "B")
                    SaveDetail(chkB14, id, Trans, txtB14.Text, "B")

                    SaveDetail(chkC01, id, Trans, "", "C")
                    SaveDetail(chkC02, id, Trans, "", "C")
                    SaveDetail(chkC03, id, Trans, "", "C")
                    SaveDetail(chkC04, id, Trans, "", "C")
                    SaveDetail(chkC05, id, Trans, "", "C")
                    SaveDetail(chkC06, id, Trans, "", "C")
                    SaveDetail(chkC07, id, Trans, txtC07.Text, "C")

                    SaveDetail(chkD01, id, Trans, "", "D")
                    SaveDetail(chkD02, id, Trans, txtD02.Text, "D")

                    SaveDetail(chkE01, id, Trans, "", "E")
                    SaveDetail(chkE02, id, Trans, "", "E")
                    SaveDetail(chkE03, id, Trans, "", "E")
                    SaveDetail(chkE04, id, Trans, "", "E")
                    SaveDetail(chkE05, id, Trans, "", "E")
                    SaveDetail(chkE06, id, Trans, "", "E")
                    SaveDetail(chkE07, id, Trans, "", "E")
                    SaveDetail(chkE08, id, Trans, "", "E")
                    SaveDetail(chkE09, id, Trans, "", "E")
                    SaveDetail(chkE10, id, Trans, "", "E")
                    SaveDetail(chkE11, id, Trans, "", "E")
                    SaveDetail(chkE12, id, Trans, "", "E")
                    SaveDetail(chkE13, id, Trans, "", "E")
                    SaveDetail(chkE14, id, Trans, "", "E")
                    SaveDetail(chkE15, id, Trans, "", "E")
                    SaveDetail(chkE16, id, Trans, "", "E")
                    SaveDetail(chkE17, id, Trans, "", "E")
                    SaveDetail(chkE18, id, Trans, "", "E")
                    SaveDetail(chkE19, id, Trans, "", "E")

                    Trans.CommitTransaction()
                    MessageBox.Show("ลงทะเบียนเรียบร้อย กรุณาใช้หมายเลขโทรศัพท์มือถือ เพื่อยืนยันที่ Kiosk", "Register Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearForm()
                Catch ex As Exception
                    Trans.RollbackTransaction()
                    MessageBox.Show(ex.Message & vbNewLine & ex.StackTrace)
                End Try
            Else
                Trans.RollbackTransaction()
                MessageBox.Show(eng.ErrorMessage)
            End If
        End If
    End Sub

    Protected Function SaveDetail(ByVal chk As CheckBox, ByVal id As Long, ByVal Trans As Linq.Common.Utilities.TransactionDB, ByVal str As String, ByVal section As String) As Boolean
        Dim ret As Boolean = False

        If chk.Checked = True Then
            Dim InteresCode As String = chk.Text.Substring(0, 2)
            Dim InteresName As String = chk.Text.Substring(3)


            Dim Erm As New Para.TABLE.ErmTsInterestPara
            Erm.ERM_TS_PERSONAL_INFO_ID = id
            Erm.INTEREST_CODE = section & InteresCode
            If str <> "" Then
                InteresName = InteresName & "##" & str
            End If
            Erm.INTEREST_NAME = InteresName
            Dim eng As New Engine.Questionnaire.RegisterENG()
            ret = eng.SaveInterest(Erm, "Register", Trans)
            eng = Nothing
            Erm = Nothing
        End If
        Return ret
    End Function



    Protected Function Valid() As Boolean
        If (rdiTitleMR.Checked = False) AndAlso (rdiTitleMRS.Checked = False) AndAlso (rdiTitleMS.Checked = False) AndAlso (rdiTitleOther.Checked = False) Then
            MessageBox.Show("กรุณาเลือกคำนำหน้าชื่อ")
            rdiTitleMR.Focus()
            Return False
        End If

        If rdiTitleOther.Checked = True Then
            If txtTitleOther.Text = "" Then
                MessageBox.Show("กรุณาระบุคำนำหน้าชื่อ")
                txtTitleOther.Focus()
                Return False
            End If
        End If
        If txtFirstName.Text = "" Then
            MessageBox.Show("กรุณาระบุชื่อ")
            txtFirstName.Focus()
            Return False
        End If
        If txtLastName.Text = "" Then
            MessageBox.Show("กรุณาระบุนามสกุล")
            txtLastName.Focus()
            Return False
        End If

        If txtEmail.Text = "" Then
            MessageBox.Show("กรุณาระบุ E-mail")
            txtEmail.Focus()
            Return False
        Else
            If txtEmail.Text.IndexOf("@") < 0 Then
                MessageBox.Show("กรุณาระบุ E-mail ให้ถูกต้อง")
                txtEmail.SelectAll()
                Return False
            End If
        End If

        If txtFirstName.Text.Length < 2 Then
            MessageBox.Show("กรุณาระบุชื่อให้ถูกต้อง")
            txtFirstName.SelectAll()
            Return False
        End If

        If txtLastName.Text.Length < 2 Then
            MessageBox.Show("กรุณาระบุนามสกุลให้ถูกต้อง")
            txtLastName.SelectAll()
            Return False
        End If

        If txtAddress.Text.Length < 3 Then
            MessageBox.Show("กรุณาระบุที่อยู่")
            txtAddress.SelectAll()
            Return False
        End If

        If txtMobileNumber.Text.Length < 9 Then
            MessageBox.Show("กรุณาระบุหมายเลขโทรศัพท์มือถือ")
            txtMobileNumber.Focus()
            Return False
        End If

        If rdAnnualSaleLess20.Checked = False AndAlso rdAnnualSaleOver20.Checked = False Then
            MessageBox.Show("กรุณาเลือกยอดขายประจำปี")
            rdAnnualSaleLess20.Focus()
            Return False
        End If

        If chkPeriodAfternoon.Checked = False And chkPerionMorning.Checked = False Then
            MessageBox.Show("กรุณาเลือกช่วงเวลาเข้าร่วมงาน")
            chkPerionMorning.Focus()
            Return False
        End If

        If lblID.Text = "0" Then
            Dim eng As New Engine.Questionnaire.RegisterENG
            Dim ret As Boolean = False

            ret = eng.chkPersonalInfoByFirstNameLastName(txtFirstName.Text, txtLastName.Text)
            If ret = True Then
                MessageBox.Show("ชื่อนี้ได้ทำการลงทะเบียนแล้ว")
                txtFaxNumber.SelectAll()
                Return False
            End If

            ret = eng.chkPersonalInfoByEmail(txtEmail.Text)
            If ret = True Then
                MessageBox.Show("อีเมลล์นี้ได้ทำการลงทะเบียนแล้ว")
                txtEmail.SelectAll()
                Return False
            End If

            ret = eng.chkPersonalInfoByMobileNo(txtMobileNumber.Text)
            If ret = True Then
                MessageBox.Show("เบอร์โทรนี้ได้ทำการลงทะเบียนแล้ว")
                txtMobileNumber.SelectAll()
                Return False
            End If
        End If



        Dim intChkA As Integer = 0
        Dim intChkB As Integer = 0
        Dim intChkC As Integer = 0
        Dim intChkD As Integer = 0
        Dim intChkE As Integer = 0


        If chkA01.Checked = True Then
            intChkA += 1
        End If
        If chkA02.Checked = True Then
            intChkA += 1
        End If
        If chkA03.Checked = True Then
            intChkA += 1
        End If
        If chkA04.Checked = True Then
            intChkA += 1
        End If
        If chkA05.Checked = True Then
            intChkA += 1
        End If
        If chkA06.Checked = True Then
            intChkA += 1
        End If
        If chkA07.Checked = True Then
            intChkA += 1
        End If
        If chkA08.Checked = True Then
            intChkA += 1
        End If
        If chkA09.Checked = True Then
            intChkA += 1
        End If
        If chkA10.Checked = True Then
            intChkA += 1
        End If
        If chkA11.Checked = True Then
            intChkA += 1
        End If
        If chkA12.Checked = True Then
            intChkA += 1
        End If
        If chkA13.Checked = True Then
            intChkA += 1
        End If
        If chkA14.Checked = True Then
            intChkA += 1
        End If
        If chkA15.Checked = True Then
            intChkA += 1
        End If
        If chkA16.Checked = True Then
            intChkA += 1
        End If
        If chkA17.Checked = True Then
            intChkA += 1
        End If

        If chkB01.Checked = True Then
            intChkB += 1
        End If
        If chkB02.Checked = True Then
            intChkB += 1
        End If
        If chkB03.Checked = True Then
            intChkB += 1
        End If
        If chkB04.Checked = True Then
            intChkB += 1
        End If
        If chkB05.Checked = True Then
            intChkB += 1
        End If
        If chkB06.Checked = True Then
            intChkB += 1
        End If
        If chkB07.Checked = True Then
            intChkB += 1
        End If
        If chkB08.Checked = True Then
            intChkB += 1
        End If
        If chkB09.Checked = True Then
            intChkB += 1
        End If
        If chkB10.Checked = True Then
            intChkB += 1
        End If
        If chkB11.Checked = True Then
            intChkB += 1
        End If
        If chkB12.Checked = True Then
            intChkB += 1
        End If
        If chkB13.Checked = True Then
            intChkB += 1
        End If
        If chkB14.Checked = True Then
            intChkB += 1
        End If

        If chkC01.Checked = True Then
            intChkC += 1
        End If
        If chkC02.Checked = True Then
            intChkC += 1
        End If
        If chkC03.Checked = True Then
            intChkC += 1
        End If
        If chkC04.Checked = True Then
            intChkC += 1
        End If
        If chkC05.Checked = True Then
            intChkC += 1
        End If
        If chkC06.Checked = True Then
            intChkC += 1
        End If
        If chkC07.Checked = True Then
            intChkC += 1
        End If

        If chkD01.Checked = True Then
            intChkD += 1
        End If
        If chkD02.Checked = True Then
            intChkD += 1
        End If

        If chkE01.Checked = True Then
            intChkE += 1
        End If
        If chkE02.Checked = True Then
            intChkE += 1
        End If
        If chkE03.Checked = True Then
            intChkE += 1
        End If
        If chkE04.Checked = True Then
            intChkE += 1
        End If
        If chkE05.Checked = True Then
            intChkE += 1
        End If
        If chkE06.Checked = True Then
            intChkE += 1
        End If
        If chkE07.Checked = True Then
            intChkE += 1
        End If
        If chkE08.Checked = True Then
            intChkE += 1
        End If
        If chkE09.Checked = True Then
            intChkE += 1
        End If
        If chkE10.Checked = True Then
            intChkE += 1
        End If
        If chkE11.Checked = True Then
            intChkE += 1
        End If
        If chkE12.Checked = True Then
            intChkE += 1
        End If
        If chkE13.Checked = True Then
            intChkE += 1
        End If
        If chkE14.Checked = True Then
            intChkE += 1
        End If
        If chkE15.Checked = True Then
            intChkE += 1
        End If
        If chkE16.Checked = True Then
            intChkE += 1
        End If
        If chkE17.Checked = True Then
            intChkE += 1
        End If
        If chkE18.Checked = True Then
            intChkE += 1
        End If
        If chkE19.Checked = True Then
            intChkE += 1
        End If

        If intChkA = 0 Then
            MessageBox.Show("กรุณาระบุประเภทธุรกิจของท่าน")
            chkA01.Focus()
            Return False
        End If
        If intChkB = 0 Then
            MessageBox.Show("กรุณาระบุช่องทางการได้รับข่าวสาร")
            chkB01.Focus()
            Return False
        End If
        If intChkC = 0 Then
            MessageBox.Show("กรุณาระบุวัตถุประสงค์ของการเข้าชมงาน")
            chkC01.Focus()
            Return False
        End If
        If intChkD = 0 Then
            MessageBox.Show("กรุณาระบุความต้องการการเข้าชม")
            chkD01.Focus()
            Return False
        End If
        If intChkE = 0 Then
            MessageBox.Show("กรุณาระบุประเภทสินค้าหรือบริการที่ท่านสนใจ")
            chkE01.Focus()
            Return False
        End If




        Return True
    End Function

    Private Sub txtMobileNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileNumber.KeyPress
        SetTextNumberKeyPress(e)
    End Sub

    Private Sub txtTelNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelNumber.KeyPress
        SetTextNumberKeyPress(e)
    End Sub
    Private Sub txtFaxNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFaxNumber.KeyPress
        SetTextNumberKeyPress(e)
    End Sub
    Private Sub SetTextNumberKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub chkA10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkA10.CheckedChanged
        SetCheckEnableText(chkA10, txtA10)
    End Sub

    Private Sub chkA17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkA17.CheckedChanged
        SetCheckEnableText(chkA17, txtA17)
    End Sub

    Private Sub SetCheckEnableText(ByVal chk As CheckBox, ByVal txt As TextBox)
        If chk.Checked = True Then
            txt.Enabled = True
        Else
            txt.Enabled = False
            txt.Text = ""
        End If
    End Sub

    Private Sub chkB14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkB14.CheckedChanged
        SetCheckEnableText(chkB14, txtB14)
    End Sub

    Private Sub chkB06_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkB06.CheckedChanged
        SetCheckEnableText(chkB06, txtB06)
    End Sub

    Private Sub chkB05_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkB05.CheckedChanged
        SetCheckEnableText(chkB05, txtB05)
    End Sub

    Private Sub chkB04_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkB04.CheckedChanged
        If chkB04.Checked = True Then
            rdiB04Facebook.Enabled = True
            rdiB04Other.Enabled = True
        Else
            rdiB04Facebook.Enabled = False
            rdiB04Other.Enabled = False
            txtB04.Enabled = False
            txtB04.Text = ""
        End If

        rdiB04Facebook.Checked = False
        rdiB04Other.Checked = False
    End Sub

    Private Sub rdiB04Other_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdiB04Other.CheckedChanged
        If rdiB04Other.Checked = True Then
            txtB04.Enabled = True
        Else
            txtB04.Enabled = False
            txtB04.Text = ""
        End If
    End Sub

    Private Sub chkC07_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkC07.CheckedChanged
        SetCheckEnableText(chkC07, txtC07)
    End Sub
    Private Sub chkD01_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkD01.CheckedChanged
        SetCheckEnableText(chkD02, txtD02)
        If chkD01.Checked = True Then
            chkD02.Checked = False
        End If
    End Sub
    Private Sub chkD02_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkD02.CheckedChanged
        SetCheckEnableText(chkD02, txtD02)
        If chkD02.Checked = True Then
            chkD01.Checked = False
        End If
    End Sub

    Private Sub rdiTitleOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdiTitleOther.CheckedChanged
        If rdiTitleOther.Checked = True Then
            txtTitleOther.Enabled = True
        Else
            txtTitleOther.Enabled = False
            txtTitleOther.Text = ""
        End If
    End Sub

    Private Sub ClearForm()
        lblID.Text = "0"

        rdiTitleMR.Checked = False
        rdiTitleMRS.Checked = False
        rdiTitleMS.Checked = False
        txtTitleOther.Text = ""

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPosition.Text = ""
        txtCompany.Text = ""
        txtCity.Text = ""
        txtCountry.Text = ""
        txtZipCode.Text = ""
        txtTelNumber.Text = ""
        txtFaxNumber.Text = ""
        txtEmail.Text = ""
        txtWebsite.Text = ""
        txtAddress.Text = ""
        txtDivision.Text = ""
        txtMobileNumber.Text = ""
        chkPeriodAfternoon.Checked = False
        chkPerionMorning.Checked = False

        rdAnnualSaleLess20.Checked = False
        rdAnnualSaleOver20.Checked = False

        chkA01.Checked = False
        chkA02.Checked = False
        chkA03.Checked = False
        chkA04.Checked = False
        chkA05.Checked = False
        chkA06.Checked = False
        chkA07.Checked = False
        chkA08.Checked = False
        chkA09.Checked = False
        chkA10.Checked = False
        chkA11.Checked = False
        chkA12.Checked = False
        chkA13.Checked = False
        chkA14.Checked = False
        chkA15.Checked = False
        chkA16.Checked = False
        chkA17.Checked = False

        chkB01.Checked = False
        chkB02.Checked = False
        chkB03.Checked = False
        chkB04.Checked = False
        chkB05.Checked = False
        chkB06.Checked = False
        chkB07.Checked = False
        chkB07.Checked = False
        chkB08.Checked = False
        chkB09.Checked = False
        chkB10.Checked = False
        chkB11.Checked = False
        chkB12.Checked = False
        chkB13.Checked = False
        chkB14.Checked = False
        rdiB04Facebook.Checked = False
        rdiB04Other.Checked = False
        txtB04.Text = ""

        chkC01.Checked = False
        chkC02.Checked = False
        chkC03.Checked = False
        chkC04.Checked = False
        chkC05.Checked = False
        chkC06.Checked = False
        chkC07.Checked = False

        chkD01.Checked = False
        chkD02.Checked = False

        chkE01.Checked = False
        chkE02.Checked = False
        chkE03.Checked = False
        chkE04.Checked = False
        chkE05.Checked = False
        chkE06.Checked = False
        chkE07.Checked = False
        chkE08.Checked = False
        chkE09.Checked = False
        chkE10.Checked = False
        chkE11.Checked = False
        chkE12.Checked = False
        chkE13.Checked = False
        chkE14.Checked = False
        chkE15.Checked = False
        chkE16.Checked = False
        chkE17.Checked = False
        chkE18.Checked = False
        chkE19.Checked = False

        txtA10.Text = ""
        txtA10.Enabled = False
        txtA17.Text = ""
        txtA17.Enabled = False

        txtC07.Text = ""
        txtC07.Enabled = False
        txtD02.Text = ""
        txtD02.Enabled = False
    End Sub

#Region "อ่านบัตรประชาชน"
    Private Delegate Sub myDelegateOne(ByVal data As String)
    'Private myUpdateBoxThaiID As myDelegateOne
    'Private myUpdateBoxSex As myDelegateOne
    Private myUpdateBoxNameThai As myDelegateOne
    'Private myUpdateBoxNameEnglish As myDelegateOne
    'Private myUpdateBoxDateOfBirth As myDelegateOne
    Private myUpdateBoxAddress As myDelegateOne
    'Private myUpdateBoxIssueDate As myDelegateOne
    'Private myUpdateBoxIssuePlace As myDelegateOne
    'Private myUpdateBoxNumber As myDelegateOne

    Private Sub frmRegister_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'myUpdateBoxThaiID = AddressOf WriteBoxThaiID
        'myUpdateBoxSex = AddressOf WriteBoxSex
        myUpdateBoxNameThai = AddressOf WriteBoxNameThai
        'myUpdateBoxNameEnglish = AddressOf WriteBoxNameEnglish
        'myUpdateBoxDateOfBirth = AddressOf WriteBoxDateOfBirth
        myUpdateBoxAddress = AddressOf WriteBoxAddress
        'myUpdateBoxIssueDate = AddressOf WriteBoxIssueDate
        'myUpdateBoxIssuePlace = AddressOf WriteBoxIssuePlace
        'myUpdateBoxNumber = AddressOf WriteBoxNumber

        Try
            LoopRec = 0
            ClearForm()

            If Not SerialPort1.IsOpen Then
                Dim ini As New IniReader(Application.StartupPath & "\Config.ini")
                ini.Section = "IDCardReader"
                SerialPort1.PortName = ini.ReadString("IDCardComPort")
                SerialPort1.BaudRate = ini.ReadString("IDCardBaudRate")
                SerialPort1.Open()
                'buttonConnect.Text = "DISCONNECT"
                SerialPort1.DiscardInBuffer()
            Else
                SerialPort1.Close()
                'buttonConnect.Text = "CONNECT"
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub WriteBoxThaiID(ByVal msg As String)
    '    txtCardID.Text = msg
    'End Sub
    '===================================================================================================
    '         * Write text Sex 
    '         *===================================================================================================

    'Private Sub WriteBoxSex(ByVal msg As String)
    '    'txt.Text = msg
    'End Sub
    '===================================================================================================
    '         * Write text box Name Thai 
    '         *===================================================================================================

    Private Sub WriteBoxNameThai(ByVal msg As String)
        If msg = "" Then
            rdiTitleMR.Checked = False
            rdiTitleMRS.Checked = False
            rdiTitleMS.Checked = False
            rdiTitleOther.Checked = False
            txtTitleOther.Text = ""

            txtFirstName.Text = ""
            txtLastName.Text = ""
        Else
            Dim TitleName As String = msg.Split(" ")(0).Trim
            If TitleName = "นาย" Then
                rdiTitleMR.Checked = True
            ElseIf TitleName = "นาง" Then
                rdiTitleMRS.Checked = True
            ElseIf TitleName = "นางสาว" Or TitleName = "น.ส." Then
                rdiTitleMS.Checked = True
            Else
                rdiTitleOther.Checked = True
                txtTitleOther.Text = TitleName
            End If

            txtFirstName.Text = msg.Split(" ")(1).Trim
            txtLastName.Text = msg.Split(" ")(3).Trim
        End If
    End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxNameEnglish(ByVal msg As String)
    '    If msg = "" Then
    '        txtFName_EN.Text = ""
    '        txtLName_EN.Text = ""
    '    Else
    '        txtFName_EN.Text = msg.Split(" ")(0) & " " & msg.Split(" ")(1)
    '        txtLName_EN.Text = msg.Split(" ")(3)
    '    End If

    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxDateOfBirth(ByVal msg As String)
    '    txtBirthDate.Text = msg
    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    Private Sub WriteBoxAddress(ByVal msg As String)
        If msg.Trim <> "" Then
            Dim Tmp() As String = Split(msg, " ")
            Dim City As String = Tmp(Tmp.Length - 1).Trim
            Dim _Addr As String = msg.Replace(City, "").Trim

            txtAddress.Text = _Addr
            txtCity.Text = Replace(City, "จังหวัด", "")
            txtCountry.Text = "ไทย"
        Else
            txtAddress.Text = ""
            txtCity.Text = ""
            txtCountry.Text = ""
        End If
    End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxIssueDate(ByVal msg As String)
    '    If msg = "" Then
    '        txtIssueDate.Text = ""
    '        txtExpDate.Text = ""
    '    Else
    '        txtIssueDate.Text = msg.Split("-")(0)
    '        txtExpDate.Text = msg.Split("-")(1)
    '    End If

    '    txtCusName.Focus()
    '    txtCusName.Select()
    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxIssuePlace(ByVal msg As String)
    '    'txt.Text = msg
    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxNumber(ByVal msg As String)
    '    'textBoxNumber.Text = msg
    'End Sub
    Dim LengthBuffer As Integer = 255
    Dim LoopRec As Integer = 0

    'Public recieve As Byte() = New Byte(255) {}
    'Public DataID As Byte() = New Byte(255) {}
    'Public DataGPS As Byte() = New Byte(255) {}
    Public BuffComPort As Byte() = New Byte(9999) {}
    Public DataCom As String() = New String(8) {}
    'Public DataThai As String() = New String(8) {}
    Public BuffCom As String = ""

    Public buffer As Integer = 0
    Public Length As Integer = 0
    Public BuffLength As Integer = 0

    Public FlagEnd As Boolean = False
    Public FlagSum As Boolean = False
    Public CheckSum As Byte = &H0
    Public DataSum As Byte = &H0
    Public LengthGPS As Integer = 0
    Public LengthSum As Integer = 0
    Public TimeOut As Integer

    'Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    '    If SerialPort1.IsOpen Then
    '        Dim Len As Integer = SerialPort1.BytesToRead
    '        TimeOut = 1
    '        If Len >= 10000 Then
    '            Len = 0
    '        End If
    '        If BuffLength >= 10000 Then
    '            ' Check length data for limit  
    '            ' Initial Buffer length 
    '            BuffLength = 0
    '        End If

    '        SerialPort1.Read(BuffComPort, BuffLength, Len)
    '        BuffLength += Len
    '        If BuffLength >= 1 Then
    '            'ต้องการ ให้ LoopRec แค่ 6 พอ เพราะ LoopRec=5 คือ ที่อยู่
    '            If Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso LoopRec < 6 Then

    '                BuffCom = Encoding.GetEncoding(&H36A).GetString(BuffComPort, 0, BuffLength)
    '                BuffLength = 0
    '                SerialPort1.DiscardInBuffer()
    '                If BuffCom = "REMOVE" & vbCr Then
    '                    LoopRec = 0
    '                    'Me.Invoke(myUpdateBoxThaiID, "")
    '                    'Me.Invoke(myUpdateBoxSex, "")
    '                    Me.Invoke(myUpdateBoxNameThai, "")
    '                    'Me.Invoke(myUpdateBoxNameEnglish, "")
    '                    'Me.Invoke(myUpdateBoxDateOfBirth, "")
    '                    Me.Invoke(myUpdateBoxAddress, "")
    '                    'Me.Invoke(myUpdateBoxIssueDate, "")
    '                    'Me.Invoke(myUpdateBoxIssuePlace, "")
    '                    'Me.Invoke(myUpdateBoxNumber, "")
    '                    'pcCapture.Image = Nothing
    '                Else
    '                    DataCom(LoopRec) = BuffCom
    '                    LoopRec += 1
    '                End If
    '            ElseIf Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso BuffLength >= 5120 AndAlso LoopRec = 6 Then
    '                'ElseIf Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso LoopRec = 6 Then

    '                'Me.Invoke(myUpdateBoxThaiID, DataCom(0))
    '                'Me.Invoke(myUpdateBoxSex, DataCom(1))
    '                Me.Invoke(myUpdateBoxNameThai, DataCom(2))
    '                'Me.Invoke(myUpdateBoxNameEnglish, DataCom(3))
    '                'Me.Invoke(myUpdateBoxDateOfBirth, DataCom(4))
    '                Me.Invoke(myUpdateBoxAddress, DataCom(5))
    '                'Me.Invoke(myUpdateBoxIssueDate, DataCom(6))
    '                'Me.Invoke(myUpdateBoxIssuePlace, DataCom(7))
    '                'Me.Invoke(myUpdateBoxNumber, DataCom(8))


    '                'Dim picture As New MemoryStream(BuffComPort)
    '                'pcCapture.Image = Image.FromStream(picture)
    '                'pcCapture.SizeMode = PictureBoxSizeMode.StretchImage


    '                SerialPort1.DiscardInBuffer()
    '                BuffLength = 0
    '                LoopRec = 0
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If SerialPort1.IsOpen Then
            Dim Len As Integer = SerialPort1.BytesToRead
            TimeOut = 1
            If Len >= 10000 Then
                Len = 0
            End If
            If BuffLength >= 10000 Then
                ' Check length data for limit  
                ' Initial Buffer length 
                BuffLength = 0
            End If

            SerialPort1.Read(BuffComPort, BuffLength, Len)
            BuffLength += Len
            If BuffLength >= 1 Then
                'ต้องการ ให้ LoopRec แค่ 6 พอ เพราะ LoopRec=5 คือ ที่อยู่
                If Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso LoopRec < 6 Then

                    BuffCom = Encoding.GetEncoding(&H36A).GetString(BuffComPort, 0, BuffLength)
                    BuffLength = 0
                    SerialPort1.DiscardInBuffer()
                    If BuffCom = "REMOVE" & vbCr Then
                        LoopRec = 0
                        'Me.Invoke(myUpdateBoxThaiID, "")
                        'Me.Invoke(myUpdateBoxSex, "")
                        Me.Invoke(myUpdateBoxNameThai, "")
                        'Me.Invoke(myUpdateBoxNameEnglish, "")
                        'Me.Invoke(myUpdateBoxDateOfBirth, "")
                        Me.Invoke(myUpdateBoxAddress, "")
                        'Me.Invoke(myUpdateBoxIssueDate, "")
                        'Me.Invoke(myUpdateBoxIssuePlace, "")
                        'Me.Invoke(myUpdateBoxNumber, "")
                        'pcCapture.Image = Nothing
                    Else
                        'DataCom(LoopRec) = BuffCom
                        If LoopRec = 2 Then
                            Me.Invoke(myUpdateBoxNameThai, BuffCom)
                        ElseIf LoopRec = 5 Then
                            Me.Invoke(myUpdateBoxAddress, BuffCom)
                        End If
                        LoopRec += 1
                    End If
                ElseIf Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso BuffLength >= 5120 AndAlso LoopRec = 6 Then
                    ''ElseIf Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso LoopRec = 6 Then

                    ''Me.Invoke(myUpdateBoxThaiID, DataCom(0))
                    ''Me.Invoke(myUpdateBoxSex, DataCom(1))
                    'Me.Invoke(myUpdateBoxNameThai, DataCom(2))
                    ''Me.Invoke(myUpdateBoxNameEnglish, DataCom(3))
                    ''Me.Invoke(myUpdateBoxDateOfBirth, DataCom(4))
                    'Me.Invoke(myUpdateBoxAddress, DataCom(5))
                    ''Me.Invoke(myUpdateBoxIssueDate, DataCom(6))
                    ''Me.Invoke(myUpdateBoxIssuePlace, DataCom(7))
                    ''Me.Invoke(myUpdateBoxNumber, DataCom(8))


                    ''Dim picture As New MemoryStream(BuffComPort)
                    ''pcCapture.Image = Image.FromStream(picture)
                    ''pcCapture.SizeMode = PictureBoxSizeMode.StretchImage


                    SerialPort1.DiscardInBuffer()
                    BuffLength = 0
                    LoopRec = 0
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub frmRegister_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TopMost = True
    End Sub


    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
End Class
