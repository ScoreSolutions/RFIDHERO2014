Public Class Form1
    <System.Runtime.InteropServices.DllImport("gdi32.dll")> _
    Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Error: please request the evaluation license key from Luxand, Inc., comment these lines and assign the key to LicenseKey.
        Please visit http://www.luxand.com/facecrop/ to request the key

        Dim LicenseKey As String
        LicenseKey = ""

        If (0 <> Luxand.fc.Activate(LicenseKey)) Then
            MessageBox.Show("Error activating FaceCrop library")
            Application.Exit()
        End If
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim dlg As OpenFileDialog
        dlg = New OpenFileDialog()
        dlg.Filter = "Windows bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|All files|*.*"
        dlg.Multiselect = False

        If (dlg.ShowDialog() = DialogResult.OK) Then
            Try
                Dim filename As String, face_bitmap As IntPtr, img As Image
                Dim width As Integer, height As Integer, result As Integer

                filename = dlg.FileNames(0)
                face_bitmap = 0

                height = PictureBox1.Height
                width = PictureBox1.Width

                result = Luxand.fc.FaceCrop_FileToHBITMAP(filename, face_bitmap, width, height)

                If (result = Luxand.fc.fcErrorOk) Then
                    img = Image.FromHbitmap(face_bitmap)
                    PictureBox1.Image = img
                    DeleteObject(face_bitmap)
                    GC.Collect()
                ElseIf (result = Luxand.fc.fcErrorFaceNotFound) Then
                    MessageBox.Show("Error: face not found", "Error")
                Else
                    MessageBox.Show("Error: can't open image", "Error")
                End If


            Catch ex As Exception
                MessageBox.Show("Can't open image(s) with error: " + ex.Message.ToString(), "Error")
            End Try
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub


End Class
