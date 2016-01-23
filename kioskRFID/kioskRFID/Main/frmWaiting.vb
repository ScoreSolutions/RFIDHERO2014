Public Class frmWaiting
    Private _CanCose As String

    Public Property CanClose() As Boolean
        Get
            Return _CanCose
        End Get
        Set(ByVal value As Boolean)
            _CanCose = value
        End Set
    End Property


    Private Sub frmWaiting_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CanClose = False Then
            e.Cancel = True
        End If
    End Sub
End Class