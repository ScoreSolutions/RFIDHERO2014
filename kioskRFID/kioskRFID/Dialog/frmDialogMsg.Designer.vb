<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialogMsg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDialogMsg))
        Me.PanelMsg = New System.Windows.Forms.Panel
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblText = New System.Windows.Forms.Label
        Me.PanelMsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMsg
        '
        Me.PanelMsg.BackgroundImage = CType(resources.GetObject("PanelMsg.BackgroundImage"), System.Drawing.Image)
        Me.PanelMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelMsg.Controls.Add(Me.btnOK)
        Me.PanelMsg.Controls.Add(Me.lblText)
        Me.PanelMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMsg.Location = New System.Drawing.Point(0, 0)
        Me.PanelMsg.Name = "PanelMsg"
        Me.PanelMsg.Size = New System.Drawing.Size(383, 266)
        Me.PanelMsg.TabIndex = 54
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(163, 205)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(71, 58)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Text = "ตกลง"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblText.Location = New System.Drawing.Point(46, 40)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(293, 132)
        Me.lblText.TabIndex = 16
        Me.lblText.Text = "lblText" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ffffffffffffffffff" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ffffffffffffffffffff"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDialogMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(383, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelMsg)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDialogMsg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.PanelMsg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents PanelMsg As System.Windows.Forms.Panel
End Class
