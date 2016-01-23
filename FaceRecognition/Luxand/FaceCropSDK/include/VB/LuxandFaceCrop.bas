Attribute VB_Name = "LuxandFaceCrop"
Option Base 0
Option Explicit


Public Const fcErrorOk = 0
Public Const fcErrorFailed = -1
Public Const fcErrorNotActivated = -2
Public Const fcErrorOutOfMemory = -3
Public Const fcErrorInvalidArgument = -4
Public Const fcErrorIOError = -5
Public Const fcErrorImageTooSmall = -6
Public Const fcErrorFaceNotFound = -7
Public Const fcErrorInsufficientBufferSize = -8
Public Const fcUnsupportedImageExtension = -9
Public Const fcCannotOpenFile = -10
Public Const fcCannotCreateFile = -11
Public Const fcBadFileFormat = -12
Public Const fcFileNotFound = -13




Public Enum FcDetectionPerformance
    fcPerformanceRealtime
    fcPerformanceNormal
    fcPerformancePrecise
End Enum

    


Declare Function fcVBPaint Lib "facecrop-vb.dll" (ByVal hDC As Long, ByVal hBitmap As Long, ByVal x As Long, ByVal y As Long, ByRef width As Long, ByRef height As Long) As Long

Declare Function fcVBInitialize Lib "facecrop-vb.dll" () As Long
Declare Function fcVBActivate Lib "facecrop-vb.dll" (ByVal licenseKey As String) As Long
Declare Function fcVBFinalize Lib "facecrop-vb.dll" () As Long
Declare Function fcVBGetLicenseInfo Lib "facecrop-vb.dll" (ByRef licenseInfo As Byte) As Long
Declare Function fcVBGetHardwareID Lib "facecrop-vb.dll" (ByRef hardwareID As Byte) As Long


Declare Function fcVBCreateContextID Lib "facecrop-vb.dll" (ByRef contextID As Long) As Long
Declare Function fcVBFreeContextID Lib "facecrop-vb.dll" (ByVal contextID As Long) As Long

Declare Function fcVBFaceCrop Lib "facecrop-vb.dll" (ByVal inFileName As String, ByVal outFileName As String, ByVal width As Long, ByVal height As Long) As Long
Declare Function fcVBFaceCrop_C Lib "facecrop-vb.dll" (ByVal inFileName As String, ByVal outFileName As String, ByVal width As Long, ByVal height As Long, ByVal contextID As Long) As Long
Declare Function fcVBFaceCrop_FileToHBITMAP Lib "facecrop-vb.dll" (ByVal inFileName As String, ByRef outHBITMAP As Long, ByVal width As Long, ByVal height As Long) As Long
Declare Function fcVBFaceCrop_FileToHBITMAP_C Lib "facecrop-vb.dll" (ByVal inFileName As String, ByRef outHBITMAP As Long, ByVal width As Long, ByVal height As Long, ByVal contextID As Long) As Long
Declare Function fcVBFaceCrop_HBITMAPToHBITMAP Lib "facecrop-vb.dll" (ByRef inHBITMAP As Long, ByRef outHBITMAP As Long, ByVal width As Long, ByVal height As Long) As Long
Declare Function fcVBFaceCrop_HBITMAPToHBITMAP_C Lib "facecrop-vb.dll" (ByRef inHBITMAP As Long, ByRef outHBITMAP As Long, ByVal width As Long, ByVal height As Long, ByVal contextID As Long) As Long

Declare Function fcVBGetFacePosition Lib "facecrop-vb.dll" (ByVal inFileName As String, ByVal width As Long, ByVal height As Long, ByRef x1 As Long, ByRef y1 As Long, ByRef x2 As Long, ByRef y2 As Long) As Long
Declare Function fcVBGetFacePosition_C Lib "facecrop-vb.dll" (ByVal inFileName As String, ByVal width As Long, ByVal height As Long, ByRef x1 As Long, ByRef y1 As Long, ByRef x2 As Long, ByRef y2 As Long, ByVal contextID As Long) As Long
Declare Function fcVBGetFacePosition_HBITMAP Lib "facecrop-vb.dll" (ByRef inHBITMAP As Long, ByVal width As Long, ByVal height As Long, ByRef x1 As Long, ByRef y1 As Long, ByRef x2 As Long, ByRef y2 As Long) As Long
Declare Function fcVBGetFacePosition_HBITMAP_C Lib "facecrop-vb.dll" (ByRef inHBITMAP As Long, ByVal width As Long, ByVal height As Long, ByRef x1 As Long, ByRef y1 As Long, ByRef x2 As Long, ByRef y2 As Long, ByVal contextID As Long) As Long

Declare Function fcVBSetFaceScale Lib "facecrop-vb.dll" (ByVal faceScale As Single) As Long
Declare Function fcVBSetFaceScale_C Lib "facecrop-vb.dll" (ByVal faceScale As Single, ByVal contextID As Long) As Long
Declare Function fcVBSetFaceShift Lib "facecrop-vb.dll" (ByVal shiftX As Single, ByVal shiftY As Single) As Long
Declare Function fcVBSetFaceShift_C Lib "facecrop-vb.dll" (ByVal shiftX As Single, ByVal shiftY As Single, ByVal contextID As Long) As Long
Declare Function fcVBSetDetectionThreshold Lib "facecrop-vb.dll" (ByVal threshold As Long) As Long
Declare Function fcVBSetDetectionThreshold_C Lib "facecrop-vb.dll" (ByVal threshold As Long, ByVal contextID As Long) As Long
Declare Function fcVBSetDetectionPerformance Lib "facecrop-vb.dll" (ByVal level As FcDetectionPerformance) As Long
Declare Function fcVBSetDetectionPerformance_C Lib "facecrop-vb.dll" (ByVal level As FcDetectionPerformance, ByVal contextID As Long) As Long
Declare Function fcVBSetJpegQuality Lib "facecrop-vb.dll" (ByVal quality As Long) As Long
Declare Function fcVBSetJpegQuality_C Lib "facecrop-vb.dll" (ByVal quality As Long, ByVal contextID As Long) As Long

