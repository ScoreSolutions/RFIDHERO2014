<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.pb = New System.Windows.Forms.PictureBox()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNumber.BackColor = System.Drawing.Color.White
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNumber.Location = New System.Drawing.Point(122, 577)
        Me.txtNumber.MaxLength = 10
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(530, 76)
        Me.txtNumber.TabIndex = 54
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Timer1
        '
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(760, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 35)
        Me.btnClose.TabIndex = 57
        Me.btnClose.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnClear.BackgroundImage = Global.kioskRFID.My.Resources.Resources.Clear_btn_01
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(481, 953)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(173, 83)
        Me.btnClear.TabIndex = 53
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btn_OK
        '
        Me.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn_OK.BackgroundImage = Global.kioskRFID.My.Resources.Resources.OK_btn_01
        Me.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn_OK.FlatAppearance.BorderSize = 0
        Me.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_OK.Location = New System.Drawing.Point(122, 953)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(173, 83)
        Me.btn_OK.TabIndex = 52
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn0.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn0.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num0_01
        Me.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn0.FlatAppearance.BorderSize = 0
        Me.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn0.Location = New System.Drawing.Point(301, 953)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(173, 83)
        Me.btn0.TabIndex = 47
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn9.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num9_01
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn9.FlatAppearance.BorderSize = 0
        Me.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn9.Location = New System.Drawing.Point(481, 860)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(173, 83)
        Me.btn9.TabIndex = 46
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn8.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num8_01
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn8.FlatAppearance.BorderSize = 0
        Me.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn8.Location = New System.Drawing.Point(301, 860)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(173, 83)
        Me.btn8.TabIndex = 45
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn7.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num7_01
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn7.FlatAppearance.BorderSize = 0
        Me.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn7.Location = New System.Drawing.Point(122, 860)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(173, 83)
        Me.btn7.TabIndex = 44
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn6.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num6_01
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn6.FlatAppearance.BorderSize = 0
        Me.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn6.Location = New System.Drawing.Point(481, 768)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(173, 83)
        Me.btn6.TabIndex = 43
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn5.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num5_01
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn5.FlatAppearance.BorderSize = 0
        Me.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn5.Location = New System.Drawing.Point(301, 768)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(173, 83)
        Me.btn5.TabIndex = 42
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn4.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num4_01
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn4.FlatAppearance.BorderSize = 0
        Me.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn4.Location = New System.Drawing.Point(122, 768)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(173, 83)
        Me.btn4.TabIndex = 41
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn3.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num3_01
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn3.FlatAppearance.BorderSize = 0
        Me.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn3.Location = New System.Drawing.Point(480, 676)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(173, 83)
        Me.btn3.TabIndex = 40
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn2.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num2_01
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn2.FlatAppearance.BorderSize = 0
        Me.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn2.Location = New System.Drawing.Point(301, 676)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(173, 83)
        Me.btn2.TabIndex = 39
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn1.BackgroundImage = Global.kioskRFID.My.Resources.Resources.num1_01
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn1.FlatAppearance.BorderSize = 0
        Me.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn1.Location = New System.Drawing.Point(122, 676)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(173, 83)
        Me.btn1.TabIndex = 38
        Me.btn1.UseVisualStyleBackColor = False
        '
        'pb
        '
        Me.pb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pb.BackgroundImage = Global.kioskRFID.My.Resources.Resources.BG_01
        Me.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb.Location = New System.Drawing.Point(0, 0)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(800, 1280)
        Me.pb.TabIndex = 18
        Me.pb.TabStop = False
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 780)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.pb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RFID"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pb As System.Windows.Forms.PictureBox
End Class
