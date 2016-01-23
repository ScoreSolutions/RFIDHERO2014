VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   Caption         =   "Luxand FaceCrop Sample"
   ClientHeight    =   6000
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   4500
   LinkTopic       =   "Form1"
   ScaleHeight     =   400
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   300
   StartUpPosition =   3  'Windows Default
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   2760
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      ForeColor       =   &H80000008&
      Height          =   6015
      Left            =   0
      ScaleHeight     =   540.067
      ScaleMode       =   0  'User
      ScaleWidth      =   297
      TabIndex        =   0
      Top             =   0
      Width           =   4455
   End
   Begin VB.Menu mnuOpenFile 
      Caption         =   "Open File..."
      Index           =   0
   End
   Begin VB.Menu mnuExit 
      Caption         =   "Exit"
      Index           =   1
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Long) As Long

Private Sub Form_Load()
    Error: please request the evaluation license key from Luxand, Inc., comment these lines and assign the key to LicenseKey. Please visit http://www.luxand.com/facecrop/ to request the key

    Dim licenseKey As String
    licenseKey = ""

    fcVBActivate licenseKey
End Sub

Private Sub mnuExit_Click(Index As Integer)
    Unload Me
End Sub

Private Sub mnuOpenFile_Click(Index As Integer)
    CommonDialog1.Filter = "JPEG (*.jpg)|*.jpg|Windows bitmap (*.bmp)|*.bmp|All files|*.*"
    CommonDialog1.ShowOpen
        
    Dim fn As String
    fn = CommonDialog1.FileName
    
    'Picture1.Picture = LoadPicture(fn)
    
    Dim hBitmapFace As Long
    Dim result As Long
    result = fcVBFaceCrop_FileToHBITMAP(fn, hBitmapFace, Picture1.width, Picture1.height)
    
    Select Case result
        Case fcErrorOk:
            fcVBPaint Picture1.hDC, hBitmapFace, 0, 0, Picture1.width, Picture1.height
            DeleteObject hBitmapFace
        Case fcErrorFaceNotFound:
            MsgBox "Error: face not found"
        Case Else:
            MsgBox "Error: can't open image"
    End Select
    
End Sub

