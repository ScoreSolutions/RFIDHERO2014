Imports System.Data
Imports System.Data.SqlClient
Imports PrinterClassDll
Imports System.IO
Imports System
Imports System.Runtime.InteropServices
Imports System.Resources
Imports System.Threading
Imports System.Drawing.Printing
Imports Microsoft.Win32
Imports kioskRFID.Org.Mentalis.Files


Module Modules

    Public Declare Function gethostbyname Lib "ws2_32.dll" (ByVal hostname$) As Integer
    Public Declare Sub CopyMemory Lib "kernel32" Alias "RtlMoveMemory" (ByVal Destination As String, ByVal Source As String, ByVal length As Integer)
    Public Declare Function WSACleanup Lib "ws2_32.dll" () As Integer

    Public Declare Function SendARP Lib "iphlpapi" (ByVal dest As Integer, ByVal host As Integer, ByRef mac As String, ByRef length As Integer) As Integer
    Public Declare Function inet_addr Lib "ws2_32.dll" (ByVal cp As String) As Integer


    '   Public Declare Function Sleep Lip "kernel32.dll"(byval dwMilliseconds as Int32) as Int16
    '******************อจัถรม๎******************************************************************
    'ด๒ฟชดฎฟฺ int WINAPI rf_init_com(int port,long baud);
    Public Declare Function rf_init_com Lib "MasterRD.dll" (ByVal port As Int16, ByVal baud As Int16) As Int16
    Public Declare Function rf_ClosePort Lib "MasterRD.dll" () As Int16

    '******************************************MF1*****************************************
    'int WINAPI rf_request(unsigned short icdev, unsigned char model, unsigned short *TagType);
    Public Declare Function rf_request Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal model As Byte, _
                   ByRef TagType As UShort) As Int16

    'int WINAPI rf_anticoll(unsigned short icdev, unsigned char bcnt, unsigned char *ppSnr,
    'unsigned char* pRLength);
    Public Declare Function rf_anticoll Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal bcnt As Byte, _
                   ByRef ppsnr As Byte, ByRef pRLength As Byte) As Int16

    'int WINAPI rf_select(unsigned short icdev,unsigned char *pSnr,unsigned char srcLen,
    'unsigned char *Size);
    Public Declare Function rf_select Lib "MasterRD.dll" (ByVal icdev As Int16, ByRef pSnr As Byte, _
                   ByVal srclen As Byte, ByRef size As Byte) As Int16

    'int WINAPI rf_M1_authentication2(unsigned short icdev,unsigned char model,unsigned char block,
    'unsigned char *key);
    Public Declare Function rf_M1_authentication2 Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal model As Byte, _
                   ByVal block As Byte, ByRef key As Byte) As Int16

    'int WINAPI rf_M1_read(unsigned short icdev, unsigned char block, unsigned char *ppData,
    'unsigned char *pLen);
    Public Declare Function rf_M1_read Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal block As Byte, _
                   ByRef buff As Byte, ByRef pLen As Byte) As Int16

    'int WINAPI rf_M1_write(unsigned short icdev, unsigned char block, unsigned char *data);
    Public Declare Function rf_M1_write Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal block As Byte, _
                   ByRef buff As Byte) As Int16

    'int WINAPI rf_halt(unsigned short icdev);
    Public Declare Function rf_halt Lib "MasterRD.dll" (ByVal icdev As Int16) As Int16
    'int WINAPI rf_M1_Initval
    Public Declare Function rf_M1_initval Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal block As Byte, ByVal Value As Long) As Int16


    Public Declare Function rf_M1_readval Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal block As Byte, ByRef pValue As Byte) As Int16


    Public Declare Function rf_M1_increment Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal block As Byte, ByVal Value As Long) As Int16


    Public Declare Function rf_M1_decrement Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal block As Byte, ByVal Value As Long) As Int16

    Public Declare Function rf_beep Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal Value As Long) As Int16

    Public Declare Function rf_light Lib "MasterRD.dll" (ByVal icdev As Int16, ByVal color As Long) As Int16

    Public INIFName As String = Application.StartupPath & "\Kiosk.ini"  'Parth ที่ใช้เก็บไฟล์ .ini
    Public CountVDO = 0
    Public MaxCountVDO As Int32 = 120
    Public Mobile As String = ""
    Public CustomerTypeID As Int32 = 0
    Public DefaultCustomerTypeID As Int32 = 0
    Public Campang As String = ""
    Public Campaign_TH As String = ""
    Public Campaign_EN As String = ""
    Public Campaign_Desc1_EN As String = ""
    Public Campaign_Desc2_EN As String = ""
    Public Campaign_Desc1_TH As String = ""
    Public Campaign_Desc2_TH As String = ""
    Public AssetID As String = ""
    Public NetworkType As String = ""
    Public Segment As String = ""
    Public CustomerName As String = ""
    Public Appointment As Boolean = False
    Public CustomerApp As Boolean = False
    Public Lang_TH As Boolean = True
    Public ConnecetionPrimaryDB As Boolean = True
    Public Conn As New SqlConnection
    Public fn5 As New Font("Tahoma", 5, FontStyle.Regular)
    Public fn8 As New Font("Tahoma", 8, FontStyle.Regular)
    Public fn10 As New Font("Tahoma", 10, FontStyle.Regular)
    Public fn11 As New Font("Tahoma", 11, FontStyle.Regular)
    Public fn12 As New Font("Tahoma", 12, FontStyle.Regular)
    Public fn13 As New Font("Tahoma", 13, FontStyle.Regular)
    Public fn14 As New Font("Tahoma", 14, FontStyle.Regular)
    Public fn16 As New Font("Tahoma", 16, FontStyle.Regular)
    Public fn8b As New Font("Tahoma", 8, FontStyle.Bold)
    Public fn9b As New Font("Tahoma", 9, FontStyle.Bold)
    Public fn10b As New Font("Tahoma", 10, FontStyle.Bold)
    Public fn11b As New Font("Tahoma", 11, FontStyle.Bold)
    Public fn12b As New Font("Tahoma", 12, FontStyle.Bold)
    Public fn13b As New Font("Tahoma", 13, FontStyle.Bold)
    Public fn14b As New Font("Tahoma", 14, FontStyle.Bold)
    Public fn16b As New Font("Tahoma", 16, FontStyle.Bold)
    Public fn24b As New Font("Tahoma", 24, FontStyle.Bold)
    Public fn36b As New Font("Tahoma", 36, FontStyle.Bold)
    Public fn42b As New Font("Tahoma", 42, FontStyle.Bold)
    Public lastPrintY As Integer = 0

#Region "Print"

    Sub PrintText(ByVal txt As String, ByVal fnt As Font, ByVal align As Int16, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = e.Graphics.MeasureString(txt, fnt).Width
        Dim h As Integer = e.Graphics.MeasureString(txt, fnt).Height
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim brsh As New SolidBrush(Color.FromArgb(0, 0, 0))
        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                x = e.PageSettings.PrintableArea.Width / 2 - w / 2
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - w
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawString(txt, fnt, brsh, x, y)
        'TextRenderer.DrawText(e.Graphics, txt, fnt, New Point(x, y), SystemColors.ControlText)
        lastPrintY = y + h
    End Sub

    Sub PrintImage(ByVal img As Image, ByVal align As Int16, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = img.Width
        Dim h As Integer = img.Height
        Dim x As Integer = 0
        Dim y As Integer = 0

        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                x = e.PageSettings.PrintableArea.Width / 2 - w / 2
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - w
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawImage(img, x, y)

        lastPrintY = y + h
    End Sub

    Sub PrintTextImage(ByVal txt As String, ByVal fnt As Font, ByVal img As Image, ByVal align As Int16, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = img.Width
        Dim h As Integer = img.Height
        Dim ini As New IniReader(INIFName)
        ini.Section = "SETTING"
        'If ini.ReadString("PaperSize") = 60 Then w = 30 : h = 30
        Dim wt As Integer = e.Graphics.MeasureString(txt, fnt).Width
        Dim ht As Integer = e.Graphics.MeasureString(txt, fnt).Height
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim brsh As New SolidBrush(Color.FromArgb(0, 0, 0))
        Dim str As String = ""
        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                x = (e.PageSettings.PrintableArea.Width / 2) - ((w + wt + 5) / 2)
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - (w + wt)
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawImage(img, x, y, w, h)
        If InStr(txt, vbCrLf) Then
            Dim font As Font = fnt
            font = New Font("Tahoma", fnt.Size + 1, FontStyle.Bold)
            e.Graphics.DrawString(txt.Split(vbCrLf)(0), font, brsh, x + w + 5, (h - ht) / 2)
            e.Graphics.DrawString(txt.Split(vbCrLf)(1), fnt, brsh, x + w + 5, (((h - ht) / 2) / 2) + (ht / 3))
        Else
            e.Graphics.DrawString(txt, fnt, brsh, x + w + 5, (h - ht) / 2)
        End If
        lastPrintY = y + h
    End Sub

    Public Sub SetUpFont()
        Dim ini As New IniReader(INIFName)
        ini.Section = "SETTING"
        If ini.ReadString("PaperSize") = 60 Then
            fn8b = New Font("Tahoma", 6, FontStyle.Bold)
            fn10b = New Font("Tahoma", 8, FontStyle.Bold)
            'fn12b = New Font("Tahoma", 8, FontStyle.Bold)
        End If
    End Sub

    Public Enum Align
        Left
        Center
        Right
    End Enum

    Public Function CheckPrinter(ByVal pd As PrintDocument) As Boolean
        Dim ini As New IniReader(INIFName)
        ini.Section = "SETTING"
        pd.PrinterSettings.PrinterName = ini.ReadString("PrinterName")
        If pd.PrinterSettings.IsValid Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Enum PrinterStatus
        PrinterIdle = 3
        PrinterPrinting = 4
        PrinterWarmingUp = 5
    End Enum

    Private Function PrinterStatusToString(ByVal ps As PrinterStatus) As String
        Dim str As String = ""
        Select Case ps
            Case PrinterStatus.PrinterIdle
                Return "idle"
            Case PrinterStatus.PrinterPrinting
                Return "printing"
            Case PrinterStatus.PrinterWarmingUp
                Return "warmup"
            Case Else
                Return "unknown"
        End Select
        Return str
    End Function

    Function CheckStatus() As String
        Dim strPrintServer As String
        strPrintServer = "localhost"
        Dim WMIObject As String, PrinterSet As Object, Printer As Object
        WMIObject = "winmgmts://" & strPrintServer
        PrinterSet = GetObject(WMIObject).InstancesOf("win32_Printer")
        Dim ini As New IniReader(INIFName)
        ini.Section = "SETTING"
        Dim PrinterName As String = ini.ReadString("PrinterName")
        Dim Status As String = ""
        For Each Printer In PrinterSet
            If PrinterName = Printer.Name Then Status = Printer.PrinterStatus : Exit For
        Next Printer
        Return PrinterStatusToString(Status)
    End Function
#End Region
End Module
