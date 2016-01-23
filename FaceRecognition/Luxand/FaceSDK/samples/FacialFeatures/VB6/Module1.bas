Attribute VB_Name = "Module1"
Option Base 0
Option Explicit


Sub Main()
    If (FSDKVB_ActivateLibrary("MDT+qnvcLrZn+3LL6fRZJ/tFjPRk7LR90chU4O8lpR1L0Blmcnu7NKdEwgkDZ5T9BylWzBmu1uuy5sIFJb1w0kPlZdKTNrWLFblWrh++bxp039ehq0yjg9hz4JyJ9693iqiTdgkvVba3B6+c6gXDjoyTrIDGRUz4WafWxQpyT4A=") <> FSDKE_OK) Then
        MsgBox "Please run the License Key Wizard (Start - Luxand - FaceSDK - License Key Wizard)", vbOKOnly, "Error activating FaceSDK"
        Exit Sub
    End If
    
    FSDKVB_Initialize ""
 
    Dim frmMain As New Form1
    frmMain.Show
  
  
End Sub
