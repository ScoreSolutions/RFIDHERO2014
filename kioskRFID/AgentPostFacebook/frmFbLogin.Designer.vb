﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFbLogin
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
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top
        Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(579, 313)
        Me.webBrowser1.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.Location = New System.Drawing.Point(0, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(579, 27)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFbLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.webBrowser1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFbLogin"
        Me.Text = "Facebook Login"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents btnExit As System.Windows.Forms.Button
End Class
