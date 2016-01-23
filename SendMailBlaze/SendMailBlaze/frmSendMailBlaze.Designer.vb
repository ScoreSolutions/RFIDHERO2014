<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendMailBlaze
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblProgressSummary = New System.Windows.Forms.Label()
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 46)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(615, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'lblProgressSummary
        '
        Me.lblProgressSummary.AutoSize = True
        Me.lblProgressSummary.Location = New System.Drawing.Point(9, 19)
        Me.lblProgressSummary.Name = "lblProgressSummary"
        Me.lblProgressSummary.Size = New System.Drawing.Size(0, 13)
        Me.lblProgressSummary.TabIndex = 1
        '
        'btnSendMail
        '
        Me.btnSendMail.Location = New System.Drawing.Point(508, 76)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(119, 45)
        Me.btnSendMail.TabIndex = 2
        Me.btnSendMail.Text = "Send Mail"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'frmSendMailBlaze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 133)
        Me.Controls.Add(Me.btnSendMail)
        Me.Controls.Add(Me.lblProgressSummary)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "frmSendMailBlaze"
        Me.Text = "Send Mail Blaze"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblProgressSummary As System.Windows.Forms.Label
    Friend WithEvents btnSendMail As System.Windows.Forms.Button

End Class
