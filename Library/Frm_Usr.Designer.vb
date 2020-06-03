<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Usr
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Usrname = New System.Windows.Forms.Label()
        Me.Bttn_Cnfrm1 = New System.Windows.Forms.Button()
        Me.Tb_CnfrmPass = New System.Windows.Forms.TextBox()
        Me.Lbl_CP = New System.Windows.Forms.Label()
        Me.Tb_NewUser = New System.Windows.Forms.TextBox()
        Me.Lbl_NU = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Bttn_Cnfrm2 = New System.Windows.Forms.Button()
        Me.Lbl_CPPP = New System.Windows.Forms.Label()
        Me.Tb_CPP = New System.Windows.Forms.TextBox()
        Me.Lbl_NP = New System.Windows.Forms.Label()
        Me.Tb_NP = New System.Windows.Forms.TextBox()
        Me.Lbl_CPP = New System.Windows.Forms.Label()
        Me.Tb_CP = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Bttn_Cnfrm3 = New System.Windows.Forms.Button()
        Me.Tb_CPPD = New System.Windows.Forms.TextBox()
        Me.Lbl_CPPD = New System.Windows.Forms.Label()
        Me.Tb_SPPD = New System.Windows.Forms.TextBox()
        Me.Lbl_PPD = New System.Windows.Forms.Label()
        Me.ErrPrvdr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.ErrPrvdr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(352, 310)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Lbl_Usrname)
        Me.TabPage2.Controls.Add(Me.Bttn_Cnfrm1)
        Me.TabPage2.Controls.Add(Me.Tb_CnfrmPass)
        Me.TabPage2.Controls.Add(Me.Lbl_CP)
        Me.TabPage2.Controls.Add(Me.Tb_NewUser)
        Me.TabPage2.Controls.Add(Me.Lbl_NU)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(344, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Change Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(46, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Current User :"
        '
        'Lbl_Usrname
        '
        Me.Lbl_Usrname.AutoSize = True
        Me.Lbl_Usrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Usrname.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Usrname.Location = New System.Drawing.Point(169, 26)
        Me.Lbl_Usrname.Name = "Lbl_Usrname"
        Me.Lbl_Usrname.Size = New System.Drawing.Size(57, 15)
        Me.Lbl_Usrname.TabIndex = 15
        Me.Lbl_Usrname.Text = "----------"
        '
        'Bttn_Cnfrm1
        '
        Me.Bttn_Cnfrm1.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_Cnfrm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Cnfrm1.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Cnfrm1.Location = New System.Drawing.Point(133, 220)
        Me.Bttn_Cnfrm1.Name = "Bttn_Cnfrm1"
        Me.Bttn_Cnfrm1.Size = New System.Drawing.Size(75, 28)
        Me.Bttn_Cnfrm1.TabIndex = 3
        Me.Bttn_Cnfrm1.Text = "Confirm"
        Me.Bttn_Cnfrm1.UseVisualStyleBackColor = False
        '
        'Tb_CnfrmPass
        '
        Me.Tb_CnfrmPass.Location = New System.Drawing.Point(172, 133)
        Me.Tb_CnfrmPass.Name = "Tb_CnfrmPass"
        Me.Tb_CnfrmPass.Size = New System.Drawing.Size(150, 20)
        Me.Tb_CnfrmPass.TabIndex = 2
        Me.Tb_CnfrmPass.UseSystemPasswordChar = True
        '
        'Lbl_CP
        '
        Me.Lbl_CP.AutoSize = True
        Me.Lbl_CP.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CP.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_CP.Location = New System.Drawing.Point(37, 133)
        Me.Lbl_CP.Name = "Lbl_CP"
        Me.Lbl_CP.Size = New System.Drawing.Size(131, 15)
        Me.Lbl_CP.TabIndex = 14
        Me.Lbl_CP.Text = "Confirm Password :"
        '
        'Tb_NewUser
        '
        Me.Tb_NewUser.Location = New System.Drawing.Point(172, 87)
        Me.Tb_NewUser.Name = "Tb_NewUser"
        Me.Tb_NewUser.Size = New System.Drawing.Size(150, 20)
        Me.Tb_NewUser.TabIndex = 1
        '
        'Lbl_NU
        '
        Me.Lbl_NU.AutoSize = True
        Me.Lbl_NU.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_NU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NU.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_NU.Location = New System.Drawing.Point(46, 87)
        Me.Lbl_NU.Name = "Lbl_NU"
        Me.Lbl_NU.Size = New System.Drawing.Size(113, 15)
        Me.Lbl_NU.TabIndex = 11
        Me.Lbl_NU.Text = "New Username :"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage1.Controls.Add(Me.Bttn_Cnfrm2)
        Me.TabPage1.Controls.Add(Me.Lbl_CPPP)
        Me.TabPage1.Controls.Add(Me.Tb_CPP)
        Me.TabPage1.Controls.Add(Me.Lbl_NP)
        Me.TabPage1.Controls.Add(Me.Tb_NP)
        Me.TabPage1.Controls.Add(Me.Lbl_CPP)
        Me.TabPage1.Controls.Add(Me.Tb_CP)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(344, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Change Password"
        '
        'Bttn_Cnfrm2
        '
        Me.Bttn_Cnfrm2.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_Cnfrm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Cnfrm2.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Cnfrm2.Location = New System.Drawing.Point(135, 222)
        Me.Bttn_Cnfrm2.Name = "Bttn_Cnfrm2"
        Me.Bttn_Cnfrm2.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Cnfrm2.TabIndex = 4
        Me.Bttn_Cnfrm2.Text = "Confirm"
        Me.Bttn_Cnfrm2.UseVisualStyleBackColor = False
        '
        'Lbl_CPPP
        '
        Me.Lbl_CPPP.AutoSize = True
        Me.Lbl_CPPP.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_CPPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CPPP.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_CPPP.Location = New System.Drawing.Point(30, 134)
        Me.Lbl_CPPP.Name = "Lbl_CPPP"
        Me.Lbl_CPPP.Size = New System.Drawing.Size(111, 13)
        Me.Lbl_CPPP.TabIndex = 11
        Me.Lbl_CPPP.Text = "Confirm Password:"
        '
        'Tb_CPP
        '
        Me.Tb_CPP.Location = New System.Drawing.Point(148, 127)
        Me.Tb_CPP.Name = "Tb_CPP"
        Me.Tb_CPP.Size = New System.Drawing.Size(150, 20)
        Me.Tb_CPP.TabIndex = 3
        Me.Tb_CPP.UseSystemPasswordChar = True
        '
        'Lbl_NP
        '
        Me.Lbl_NP.AutoSize = True
        Me.Lbl_NP.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_NP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NP.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_NP.Location = New System.Drawing.Point(38, 86)
        Me.Lbl_NP.Name = "Lbl_NP"
        Me.Lbl_NP.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_NP.TabIndex = 9
        Me.Lbl_NP.Text = "New Password :"
        '
        'Tb_NP
        '
        Me.Tb_NP.Location = New System.Drawing.Point(148, 79)
        Me.Tb_NP.Name = "Tb_NP"
        Me.Tb_NP.Size = New System.Drawing.Size(150, 20)
        Me.Tb_NP.TabIndex = 2
        Me.Tb_NP.UseSystemPasswordChar = True
        '
        'Lbl_CPP
        '
        Me.Lbl_CPP.AutoSize = True
        Me.Lbl_CPP.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_CPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CPP.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_CPP.Location = New System.Drawing.Point(28, 40)
        Me.Lbl_CPP.Name = "Lbl_CPP"
        Me.Lbl_CPP.Size = New System.Drawing.Size(114, 13)
        Me.Lbl_CPP.TabIndex = 7
        Me.Lbl_CPP.Text = "Current Password :"
        '
        'Tb_CP
        '
        Me.Tb_CP.Location = New System.Drawing.Point(148, 33)
        Me.Tb_CP.Name = "Tb_CP"
        Me.Tb_CP.Size = New System.Drawing.Size(150, 20)
        Me.Tb_CP.TabIndex = 1
        Me.Tb_CP.UseSystemPasswordChar = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DarkGreen
        Me.TabPage3.Controls.Add(Me.Bttn_Cnfrm3)
        Me.TabPage3.Controls.Add(Me.Tb_CPPD)
        Me.TabPage3.Controls.Add(Me.Lbl_CPPD)
        Me.TabPage3.Controls.Add(Me.Tb_SPPD)
        Me.TabPage3.Controls.Add(Me.Lbl_PPD)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(344, 284)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Change Amount of Penalty"
        '
        'Bttn_Cnfrm3
        '
        Me.Bttn_Cnfrm3.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_Cnfrm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Cnfrm3.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Cnfrm3.Location = New System.Drawing.Point(133, 220)
        Me.Bttn_Cnfrm3.Name = "Bttn_Cnfrm3"
        Me.Bttn_Cnfrm3.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Cnfrm3.TabIndex = 3
        Me.Bttn_Cnfrm3.Text = "Confirm"
        Me.Bttn_Cnfrm3.UseVisualStyleBackColor = False
        '
        'Tb_CPPD
        '
        Me.Tb_CPPD.Location = New System.Drawing.Point(211, 41)
        Me.Tb_CPPD.Name = "Tb_CPPD"
        Me.Tb_CPPD.ReadOnly = True
        Me.Tb_CPPD.Size = New System.Drawing.Size(100, 20)
        Me.Tb_CPPD.TabIndex = 1
        '
        'Lbl_CPPD
        '
        Me.Lbl_CPPD.AutoSize = True
        Me.Lbl_CPPD.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_CPPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CPPD.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_CPPD.Location = New System.Drawing.Point(34, 41)
        Me.Lbl_CPPD.Name = "Lbl_CPPD"
        Me.Lbl_CPPD.Size = New System.Drawing.Size(171, 15)
        Me.Lbl_CPPD.TabIndex = 2
        Me.Lbl_CPPD.Text = "Current Penalty Per Day : "
        '
        'Tb_SPPD
        '
        Me.Tb_SPPD.Location = New System.Drawing.Point(211, 118)
        Me.Tb_SPPD.Name = "Tb_SPPD"
        Me.Tb_SPPD.Size = New System.Drawing.Size(100, 20)
        Me.Tb_SPPD.TabIndex = 2
        '
        'Lbl_PPD
        '
        Me.Lbl_PPD.AutoSize = True
        Me.Lbl_PPD.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_PPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PPD.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_PPD.Location = New System.Drawing.Point(52, 118)
        Me.Lbl_PPD.Name = "Lbl_PPD"
        Me.Lbl_PPD.Size = New System.Drawing.Size(145, 15)
        Me.Lbl_PPD.TabIndex = 0
        Me.Lbl_PPD.Text = "Set Penalty Per Day : "
        '
        'ErrPrvdr
        '
        Me.ErrPrvdr.ContainerControl = Me
        '
        'Frm_Usr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(376, 334)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_Usr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ErrPrvdr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_CPPP As System.Windows.Forms.Label
    Friend WithEvents Tb_CPP As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_NP As System.Windows.Forms.Label
    Friend WithEvents Tb_NP As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_CPP As System.Windows.Forms.Label
    Friend WithEvents Tb_CP As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Tb_CPPD As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_CPPD As System.Windows.Forms.Label
    Friend WithEvents Tb_SPPD As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_PPD As System.Windows.Forms.Label
    Friend WithEvents Bttn_Cnfrm3 As System.Windows.Forms.Button
    Friend WithEvents Bttn_Cnfrm2 As System.Windows.Forms.Button
    Friend WithEvents Bttn_Cnfrm1 As System.Windows.Forms.Button
    Friend WithEvents Tb_CnfrmPass As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_CP As System.Windows.Forms.Label
    Friend WithEvents Tb_NewUser As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_NU As System.Windows.Forms.Label
    Friend WithEvents Lbl_Usrname As System.Windows.Forms.Label
    Friend WithEvents ErrPrvdr As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
