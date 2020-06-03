<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Lbl_UserName = New System.Windows.Forms.Label()
        Me.Tb_UserName = New System.Windows.Forms.TextBox()
        Me.Tb_Pass = New System.Windows.Forms.TextBox()
        Me.Lbl_Pass = New System.Windows.Forms.Label()
        Me.Bttn_Login = New System.Windows.Forms.Button()
        Me.ErrPrvdr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrPrvdr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbl_UserName
        '
        Me.Lbl_UserName.AutoSize = True
        Me.Lbl_UserName.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_UserName.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_UserName.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_UserName.Location = New System.Drawing.Point(181, 141)
        Me.Lbl_UserName.Name = "Lbl_UserName"
        Me.Lbl_UserName.Size = New System.Drawing.Size(88, 16)
        Me.Lbl_UserName.TabIndex = 0
        Me.Lbl_UserName.Text = "Username :"
        '
        'Tb_UserName
        '
        Me.Tb_UserName.Location = New System.Drawing.Point(281, 140)
        Me.Tb_UserName.Name = "Tb_UserName"
        Me.Tb_UserName.Size = New System.Drawing.Size(206, 20)
        Me.Tb_UserName.TabIndex = 1
        '
        'Tb_Pass
        '
        Me.Tb_Pass.Location = New System.Drawing.Point(281, 181)
        Me.Tb_Pass.Name = "Tb_Pass"
        Me.Tb_Pass.Size = New System.Drawing.Size(206, 20)
        Me.Tb_Pass.TabIndex = 3
        Me.Tb_Pass.UseSystemPasswordChar = True
        '
        'Lbl_Pass
        '
        Me.Lbl_Pass.AutoSize = True
        Me.Lbl_Pass.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_Pass.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pass.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Pass.Location = New System.Drawing.Point(181, 179)
        Me.Lbl_Pass.Name = "Lbl_Pass"
        Me.Lbl_Pass.Size = New System.Drawing.Size(83, 16)
        Me.Lbl_Pass.TabIndex = 2
        Me.Lbl_Pass.Text = "Password :"
        '
        'Bttn_Login
        '
        Me.Bttn_Login.BackColor = System.Drawing.Color.DarkGreen
        Me.Bttn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Login.ForeColor = System.Drawing.Color.Chartreuse
        Me.Bttn_Login.Location = New System.Drawing.Point(520, 219)
        Me.Bttn_Login.Name = "Bttn_Login"
        Me.Bttn_Login.Size = New System.Drawing.Size(80, 31)
        Me.Bttn_Login.TabIndex = 4
        Me.Bttn_Login.Text = "Login"
        Me.Bttn_Login.UseVisualStyleBackColor = False
        '
        'ErrPrvdr
        '
        Me.ErrPrvdr.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 119)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 92)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGreen
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(263, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Library Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(171, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Don Ramon E. Costales Memorial National High School"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(634, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Bttn_Login)
        Me.Controls.Add(Me.Tb_Pass)
        Me.Controls.Add(Me.Lbl_Pass)
        Me.Controls.Add(Me.Tb_UserName)
        Me.Controls.Add(Me.Lbl_UserName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(650, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 300)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ErrPrvdr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_UserName As System.Windows.Forms.Label
    Friend WithEvents Tb_UserName As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pass As System.Windows.Forms.Label
    Friend WithEvents Bttn_Login As System.Windows.Forms.Button
    Friend WithEvents ErrPrvdr As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
