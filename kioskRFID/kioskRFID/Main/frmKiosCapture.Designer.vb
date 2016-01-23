<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKiosCapture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKiosCapture))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbDisplay = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.gbTag = New System.Windows.Forms.GroupBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pcBG = New System.Windows.Forms.PictureBox()
        Me.pcImage = New System.Windows.Forms.PictureBox()
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.pbSave = New System.Windows.Forms.PictureBox()
        Me.pbCapture = New System.Windows.Forms.PictureBox()
        Me.pbReCapture = New System.Windows.Forms.PictureBox()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTag.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReCapture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "cap"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(560, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(655, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(464, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "recap"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pbDisplay)
        Me.Panel1.Location = New System.Drawing.Point(74, 540)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 480)
        Me.Panel1.TabIndex = 58
        '
        'pbDisplay
        '
        Me.pbDisplay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbDisplay.BackColor = System.Drawing.Color.Transparent
        Me.pbDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDisplay.Location = New System.Drawing.Point(0, 0)
        Me.pbDisplay.Name = "pbDisplay"
        Me.pbDisplay.Size = New System.Drawing.Size(640, 480)
        Me.pbDisplay.TabIndex = 53
        Me.pbDisplay.TabStop = False
        '
        'PrintDocument1
        '
        '
        'gbTag
        '
        Me.gbTag.BackColor = System.Drawing.Color.White
        Me.gbTag.Controls.Add(Me.txtTel)
        Me.gbTag.Controls.Add(Me.txtName)
        Me.gbTag.Controls.Add(Me.txtCompany)
        Me.gbTag.Controls.Add(Me.txtemail)
        Me.gbTag.Controls.Add(Me.Label11)
        Me.gbTag.Controls.Add(Me.Label10)
        Me.gbTag.Controls.Add(Me.Label9)
        Me.gbTag.Controls.Add(Me.Label8)
        Me.gbTag.Controls.Add(Me.Label7)
        Me.gbTag.Controls.Add(Me.PictureBox2)
        Me.gbTag.Location = New System.Drawing.Point(94, 12)
        Me.gbTag.Name = "gbTag"
        Me.gbTag.Size = New System.Drawing.Size(272, 330)
        Me.gbTag.TabIndex = 59
        Me.gbTag.TabStop = False
        '
        'txtTel
        '
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(112, 278)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(148, 14)
        Me.txtTel.TabIndex = 36
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(112, 261)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 14)
        Me.txtName.TabIndex = 35
        '
        'txtCompany
        '
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(112, 220)
        Me.txtCompany.MaxLength = 500
        Me.txtCompany.Multiline = True
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(148, 41)
        Me.txtCompany.TabIndex = 34
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtemail.Location = New System.Drawing.Point(112, 298)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(148, 14)
        Me.txtemail.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "เบอร์โทร : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "ชื่อผู้ลงทะเบียน : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "ชื่อบริษัท : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "email : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = " The Return of RFID HERO 2014"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(37, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(197, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'pcBG
        '
        Me.pcBG.BackColor = System.Drawing.Color.Transparent
        Me.pcBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pcBG.Image = Global.kioskRFID.My.Resources.Resources.new_RFID_hero_resize
        Me.pcBG.Location = New System.Drawing.Point(376, 418)
        Me.pcBG.Name = "pcBG"
        Me.pcBG.Size = New System.Drawing.Size(220, 170)
        Me.pcBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcBG.TabIndex = 54
        Me.pcBG.TabStop = False
        Me.pcBG.Visible = False
        '
        'pcImage
        '
        Me.pcImage.BackColor = System.Drawing.Color.White
        Me.pcImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcImage.Location = New System.Drawing.Point(74, 540)
        Me.pcImage.Name = "pcImage"
        Me.pcImage.Size = New System.Drawing.Size(640, 480)
        Me.pcImage.TabIndex = 47
        Me.pcImage.TabStop = False
        '
        'pbClose
        '
        Me.pbClose.BackgroundImage = CType(resources.GetObject("pbClose.BackgroundImage"), System.Drawing.Image)
        Me.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClose.Location = New System.Drawing.Point(732, 12)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(40, 35)
        Me.pbClose.TabIndex = 37
        Me.pbClose.TabStop = False
        '
        'pbSave
        '
        Me.pbSave.BackColor = System.Drawing.Color.Transparent
        Me.pbSave.BackgroundImage = Global.kioskRFID.My.Resources.Resources.OK_share_btn_011
        Me.pbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSave.Location = New System.Drawing.Point(438, 1045)
        Me.pbSave.Name = "pbSave"
        Me.pbSave.Size = New System.Drawing.Size(140, 50)
        Me.pbSave.TabIndex = 36
        Me.pbSave.TabStop = False
        Me.pbSave.Visible = False
        '
        'pbCapture
        '
        Me.pbCapture.BackColor = System.Drawing.Color.Transparent
        Me.pbCapture.BackgroundImage = Global.kioskRFID.My.Resources.Resources.capture_011
        Me.pbCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCapture.Location = New System.Drawing.Point(280, 1045)
        Me.pbCapture.Name = "pbCapture"
        Me.pbCapture.Size = New System.Drawing.Size(140, 50)
        Me.pbCapture.TabIndex = 35
        Me.pbCapture.TabStop = False
        '
        'pbReCapture
        '
        Me.pbReCapture.BackColor = System.Drawing.Color.Transparent
        Me.pbReCapture.BackgroundImage = Global.kioskRFID.My.Resources.Resources.Recapture_btn_01
        Me.pbReCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbReCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbReCapture.Location = New System.Drawing.Point(280, 1045)
        Me.pbReCapture.Name = "pbReCapture"
        Me.pbReCapture.Size = New System.Drawing.Size(140, 50)
        Me.pbReCapture.TabIndex = 34
        Me.pbReCapture.TabStop = False
        Me.pbReCapture.Visible = False
        '
        'pb
        '
        Me.pb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pb.BackgroundImage = Global.kioskRFID.My.Resources.Resources.BG_04
        Me.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb.Location = New System.Drawing.Point(0, 0)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(800, 1280)
        Me.pb.TabIndex = 31
        Me.pb.TabStop = False
        '
        'frmKiosCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 780)
        Me.Controls.Add(Me.pcBG)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pcImage)
        Me.Controls.Add(Me.pbClose)
        Me.Controls.Add(Me.pbSave)
        Me.Controls.Add(Me.pbCapture)
        Me.Controls.Add(Me.pbReCapture)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.gbTag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKiosCapture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Capture"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTag.ResumeLayout(False)
        Me.gbTag.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReCapture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents pbSave As System.Windows.Forms.PictureBox
    Friend WithEvents pbCapture As System.Windows.Forms.PictureBox
    Friend WithEvents pbReCapture As System.Windows.Forms.PictureBox
    Friend WithEvents pbClose As System.Windows.Forms.PictureBox
    Friend WithEvents pcImage As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pcBG As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents gbTag As System.Windows.Forms.GroupBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDisplay As System.Windows.Forms.PictureBox

End Class
