<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reader
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
        Me.Cb_TYP = New System.Windows.Forms.ComboBox()
        Me.Cb_SEX = New System.Windows.Forms.ComboBox()
        Me.Lbl_TYP = New System.Windows.Forms.Label()
        Me.Lbl_SEX = New System.Windows.Forms.Label()
        Me.Tb_LN = New System.Windows.Forms.TextBox()
        Me.Lbl_LN = New System.Windows.Forms.Label()
        Me.Tb_FN = New System.Windows.Forms.TextBox()
        Me.Lbl_FN = New System.Windows.Forms.Label()
        Me.Tb_NMBR = New System.Windows.Forms.TextBox()
        Me.Lbl_IDN = New System.Windows.Forms.Label()
        Me.Tb_RID = New System.Windows.Forms.TextBox()
        Me.Lbl_RID = New System.Windows.Forms.Label()
        Me.Bttn_Save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cb_TYP
        '
        Me.Cb_TYP.FormattingEnabled = True
        Me.Cb_TYP.Items.AddRange(New Object() {"Teacher", "Student"})
        Me.Cb_TYP.Location = New System.Drawing.Point(225, 133)
        Me.Cb_TYP.Name = "Cb_TYP"
        Me.Cb_TYP.Size = New System.Drawing.Size(158, 21)
        Me.Cb_TYP.TabIndex = 6
        '
        'Cb_SEX
        '
        Me.Cb_SEX.FormattingEnabled = True
        Me.Cb_SEX.Items.AddRange(New Object() {"Male", "Female"})
        Me.Cb_SEX.Location = New System.Drawing.Point(225, 84)
        Me.Cb_SEX.Name = "Cb_SEX"
        Me.Cb_SEX.Size = New System.Drawing.Size(158, 21)
        Me.Cb_SEX.TabIndex = 5
        '
        'Lbl_TYP
        '
        Me.Lbl_TYP.AutoSize = True
        Me.Lbl_TYP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TYP.Location = New System.Drawing.Point(222, 117)
        Me.Lbl_TYP.Name = "Lbl_TYP"
        Me.Lbl_TYP.Size = New System.Drawing.Size(45, 15)
        Me.Lbl_TYP.TabIndex = 22
        Me.Lbl_TYP.Text = "Type :"
        '
        'Lbl_SEX
        '
        Me.Lbl_SEX.AutoSize = True
        Me.Lbl_SEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SEX.Location = New System.Drawing.Point(222, 68)
        Me.Lbl_SEX.Name = "Lbl_SEX"
        Me.Lbl_SEX.Size = New System.Drawing.Size(39, 15)
        Me.Lbl_SEX.TabIndex = 21
        Me.Lbl_SEX.Text = "Sex :"
        '
        'Tb_LN
        '
        Me.Tb_LN.Location = New System.Drawing.Point(35, 133)
        Me.Tb_LN.Name = "Tb_LN"
        Me.Tb_LN.Size = New System.Drawing.Size(158, 20)
        Me.Tb_LN.TabIndex = 3
        '
        'Lbl_LN
        '
        Me.Lbl_LN.AutoSize = True
        Me.Lbl_LN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LN.Location = New System.Drawing.Point(32, 117)
        Me.Lbl_LN.Name = "Lbl_LN"
        Me.Lbl_LN.Size = New System.Drawing.Size(84, 15)
        Me.Lbl_LN.TabIndex = 20
        Me.Lbl_LN.Text = "Last Name :"
        '
        'Tb_FN
        '
        Me.Tb_FN.Location = New System.Drawing.Point(34, 84)
        Me.Tb_FN.Name = "Tb_FN"
        Me.Tb_FN.Size = New System.Drawing.Size(158, 20)
        Me.Tb_FN.TabIndex = 2
        '
        'Lbl_FN
        '
        Me.Lbl_FN.AutoSize = True
        Me.Lbl_FN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FN.Location = New System.Drawing.Point(31, 68)
        Me.Lbl_FN.Name = "Lbl_FN"
        Me.Lbl_FN.Size = New System.Drawing.Size(85, 15)
        Me.Lbl_FN.TabIndex = 16
        Me.Lbl_FN.Text = "First Name :"
        '
        'Tb_NMBR
        '
        Me.Tb_NMBR.Location = New System.Drawing.Point(225, 37)
        Me.Tb_NMBR.Name = "Tb_NMBR"
        Me.Tb_NMBR.Size = New System.Drawing.Size(158, 20)
        Me.Tb_NMBR.TabIndex = 4
        '
        'Lbl_IDN
        '
        Me.Lbl_IDN.AutoSize = True
        Me.Lbl_IDN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_IDN.Location = New System.Drawing.Point(222, 21)
        Me.Lbl_IDN.Name = "Lbl_IDN"
        Me.Lbl_IDN.Size = New System.Drawing.Size(84, 15)
        Me.Lbl_IDN.TabIndex = 13
        Me.Lbl_IDN.Text = "ID Number :"
        '
        'Tb_RID
        '
        Me.Tb_RID.Location = New System.Drawing.Point(35, 37)
        Me.Tb_RID.Name = "Tb_RID"
        Me.Tb_RID.Size = New System.Drawing.Size(158, 20)
        Me.Tb_RID.TabIndex = 1
        '
        'Lbl_RID
        '
        Me.Lbl_RID.AutoSize = True
        Me.Lbl_RID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RID.Location = New System.Drawing.Point(32, 21)
        Me.Lbl_RID.Name = "Lbl_RID"
        Me.Lbl_RID.Size = New System.Drawing.Size(80, 15)
        Me.Lbl_RID.TabIndex = 11
        Me.Lbl_RID.Text = "Reader ID :"
        '
        'Bttn_Save
        '
        Me.Bttn_Save.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Save.ForeColor = System.Drawing.Color.LawnGreen
        Me.Bttn_Save.Location = New System.Drawing.Point(168, 195)
        Me.Bttn_Save.Name = "Bttn_Save"
        Me.Bttn_Save.Size = New System.Drawing.Size(75, 28)
        Me.Bttn_Save.TabIndex = 23
        Me.Bttn_Save.Text = "Save"
        Me.Bttn_Save.UseVisualStyleBackColor = False
        '
        'Frm_Reader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(417, 235)
        Me.Controls.Add(Me.Bttn_Save)
        Me.Controls.Add(Me.Cb_TYP)
        Me.Controls.Add(Me.Cb_SEX)
        Me.Controls.Add(Me.Lbl_TYP)
        Me.Controls.Add(Me.Lbl_SEX)
        Me.Controls.Add(Me.Tb_LN)
        Me.Controls.Add(Me.Lbl_LN)
        Me.Controls.Add(Me.Tb_FN)
        Me.Controls.Add(Me.Lbl_FN)
        Me.Controls.Add(Me.Tb_NMBR)
        Me.Controls.Add(Me.Lbl_IDN)
        Me.Controls.Add(Me.Tb_RID)
        Me.Controls.Add(Me.Lbl_RID)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.MaximumSize = New System.Drawing.Size(433, 273)
        Me.MinimumSize = New System.Drawing.Size(433, 273)
        Me.Name = "Frm_Reader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cb_TYP As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_SEX As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_TYP As System.Windows.Forms.Label
    Friend WithEvents Lbl_SEX As System.Windows.Forms.Label
    Friend WithEvents Tb_LN As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_LN As System.Windows.Forms.Label
    Friend WithEvents Tb_FN As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_FN As System.Windows.Forms.Label
    Friend WithEvents Tb_NMBR As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_IDN As System.Windows.Forms.Label
    Friend WithEvents Tb_RID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_RID As System.Windows.Forms.Label
    Friend WithEvents Bttn_Save As System.Windows.Forms.Button
End Class
