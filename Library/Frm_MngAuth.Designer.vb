<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MngAuth
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
        Me.Tb_LN = New System.Windows.Forms.TextBox()
        Me.Lb_Ln = New System.Windows.Forms.Label()
        Me.Tb_FN = New System.Windows.Forms.TextBox()
        Me.Lbl_FN = New System.Windows.Forms.Label()
        Me.Tb_AID = New System.Windows.Forms.TextBox()
        Me.Lbl_AID = New System.Windows.Forms.Label()
        Me.Bttn_Add = New System.Windows.Forms.Button()
        Me.Bttn_Edt = New System.Windows.Forms.Button()
        Me.Bttn_Dlt = New System.Windows.Forms.Button()
        Me.Bttn_Cncl = New System.Windows.Forms.Button()
        Me.Dgv_Unassigned = New System.Windows.Forms.DataGridView()
        Me.Dgv_Assigned = New System.Windows.Forms.DataGridView()
        Me.Bttn_Assgn = New System.Windows.Forms.Button()
        Me.Bttn_UnAssgn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Srch = New System.Windows.Forms.TextBox()
        Me.Lbl_Srch = New System.Windows.Forms.Label()
        CType(Me.Dgv_Unassigned, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Assigned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_LN
        '
        Me.Tb_LN.Location = New System.Drawing.Point(12, 226)
        Me.Tb_LN.Name = "Tb_LN"
        Me.Tb_LN.ReadOnly = True
        Me.Tb_LN.Size = New System.Drawing.Size(180, 20)
        Me.Tb_LN.TabIndex = 12
        '
        'Lb_Ln
        '
        Me.Lb_Ln.AutoSize = True
        Me.Lb_Ln.BackColor = System.Drawing.Color.DarkGreen
        Me.Lb_Ln.ForeColor = System.Drawing.Color.Lime
        Me.Lb_Ln.Location = New System.Drawing.Point(9, 209)
        Me.Lb_Ln.Name = "Lb_Ln"
        Me.Lb_Ln.Size = New System.Drawing.Size(64, 13)
        Me.Lb_Ln.TabIndex = 11
        Me.Lb_Ln.Text = "Last Name :"
        '
        'Tb_FN
        '
        Me.Tb_FN.Location = New System.Drawing.Point(12, 167)
        Me.Tb_FN.Name = "Tb_FN"
        Me.Tb_FN.ReadOnly = True
        Me.Tb_FN.Size = New System.Drawing.Size(180, 20)
        Me.Tb_FN.TabIndex = 10
        '
        'Lbl_FN
        '
        Me.Lbl_FN.AutoSize = True
        Me.Lbl_FN.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_FN.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_FN.Location = New System.Drawing.Point(9, 150)
        Me.Lbl_FN.Name = "Lbl_FN"
        Me.Lbl_FN.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_FN.TabIndex = 9
        Me.Lbl_FN.Text = "First Name :"
        '
        'Tb_AID
        '
        Me.Tb_AID.Location = New System.Drawing.Point(12, 114)
        Me.Tb_AID.Name = "Tb_AID"
        Me.Tb_AID.ReadOnly = True
        Me.Tb_AID.Size = New System.Drawing.Size(180, 20)
        Me.Tb_AID.TabIndex = 8
        '
        'Lbl_AID
        '
        Me.Lbl_AID.AutoSize = True
        Me.Lbl_AID.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_AID.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_AID.Location = New System.Drawing.Point(9, 97)
        Me.Lbl_AID.Name = "Lbl_AID"
        Me.Lbl_AID.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_AID.TabIndex = 7
        Me.Lbl_AID.Text = "Authors ID :"
        '
        'Bttn_Add
        '
        Me.Bttn_Add.BackColor = System.Drawing.Color.Green
        Me.Bttn_Add.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Add.Location = New System.Drawing.Point(12, 280)
        Me.Bttn_Add.Name = "Bttn_Add"
        Me.Bttn_Add.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Add.TabIndex = 13
        Me.Bttn_Add.Text = "Add"
        Me.Bttn_Add.UseVisualStyleBackColor = False
        '
        'Bttn_Edt
        '
        Me.Bttn_Edt.BackColor = System.Drawing.Color.Green
        Me.Bttn_Edt.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Edt.Location = New System.Drawing.Point(117, 280)
        Me.Bttn_Edt.Name = "Bttn_Edt"
        Me.Bttn_Edt.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Edt.TabIndex = 14
        Me.Bttn_Edt.Text = "Edit"
        Me.Bttn_Edt.UseVisualStyleBackColor = False
        '
        'Bttn_Dlt
        '
        Me.Bttn_Dlt.BackColor = System.Drawing.Color.Green
        Me.Bttn_Dlt.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Dlt.Location = New System.Drawing.Point(12, 332)
        Me.Bttn_Dlt.Name = "Bttn_Dlt"
        Me.Bttn_Dlt.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Dlt.TabIndex = 15
        Me.Bttn_Dlt.Text = "Delete"
        Me.Bttn_Dlt.UseVisualStyleBackColor = False
        '
        'Bttn_Cncl
        '
        Me.Bttn_Cncl.BackColor = System.Drawing.Color.Green
        Me.Bttn_Cncl.Enabled = False
        Me.Bttn_Cncl.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Cncl.Location = New System.Drawing.Point(117, 332)
        Me.Bttn_Cncl.Name = "Bttn_Cncl"
        Me.Bttn_Cncl.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Cncl.TabIndex = 16
        Me.Bttn_Cncl.Text = "Cancel"
        Me.Bttn_Cncl.UseVisualStyleBackColor = False
        '
        'Dgv_Unassigned
        '
        Me.Dgv_Unassigned.AllowUserToAddRows = False
        Me.Dgv_Unassigned.AllowUserToDeleteRows = False
        Me.Dgv_Unassigned.AllowUserToResizeColumns = False
        Me.Dgv_Unassigned.AllowUserToResizeRows = False
        Me.Dgv_Unassigned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Unassigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Unassigned.Location = New System.Drawing.Point(208, 59)
        Me.Dgv_Unassigned.MultiSelect = False
        Me.Dgv_Unassigned.Name = "Dgv_Unassigned"
        Me.Dgv_Unassigned.ReadOnly = True
        Me.Dgv_Unassigned.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_Unassigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Unassigned.Size = New System.Drawing.Size(286, 307)
        Me.Dgv_Unassigned.TabIndex = 17
        '
        'Dgv_Assigned
        '
        Me.Dgv_Assigned.AllowUserToAddRows = False
        Me.Dgv_Assigned.AllowUserToDeleteRows = False
        Me.Dgv_Assigned.AllowUserToResizeColumns = False
        Me.Dgv_Assigned.AllowUserToResizeRows = False
        Me.Dgv_Assigned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Assigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Assigned.Location = New System.Drawing.Point(555, 59)
        Me.Dgv_Assigned.MultiSelect = False
        Me.Dgv_Assigned.Name = "Dgv_Assigned"
        Me.Dgv_Assigned.ReadOnly = True
        Me.Dgv_Assigned.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_Assigned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Assigned.Size = New System.Drawing.Size(286, 307)
        Me.Dgv_Assigned.TabIndex = 18
        '
        'Bttn_Assgn
        '
        Me.Bttn_Assgn.BackColor = System.Drawing.Color.Green
        Me.Bttn_Assgn.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Assgn.Location = New System.Drawing.Point(500, 150)
        Me.Bttn_Assgn.Name = "Bttn_Assgn"
        Me.Bttn_Assgn.Size = New System.Drawing.Size(49, 23)
        Me.Bttn_Assgn.TabIndex = 19
        Me.Bttn_Assgn.Text = ">>"
        Me.Bttn_Assgn.UseVisualStyleBackColor = False
        '
        'Bttn_UnAssgn
        '
        Me.Bttn_UnAssgn.BackColor = System.Drawing.Color.Green
        Me.Bttn_UnAssgn.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_UnAssgn.Location = New System.Drawing.Point(500, 238)
        Me.Bttn_UnAssgn.Name = "Bttn_UnAssgn"
        Me.Bttn_UnAssgn.Size = New System.Drawing.Size(49, 23)
        Me.Bttn_UnAssgn.TabIndex = 20
        Me.Bttn_UnAssgn.Text = "<<"
        Me.Bttn_UnAssgn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(205, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Authors :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(552, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Assigned Authors :"
        '
        'Tb_Srch
        '
        Me.Tb_Srch.Location = New System.Drawing.Point(384, 37)
        Me.Tb_Srch.Name = "Tb_Srch"
        Me.Tb_Srch.Size = New System.Drawing.Size(110, 20)
        Me.Tb_Srch.TabIndex = 23
        '
        'Lbl_Srch
        '
        Me.Lbl_Srch.AutoSize = True
        Me.Lbl_Srch.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Srch.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Srch.Location = New System.Drawing.Point(334, 40)
        Me.Lbl_Srch.Name = "Lbl_Srch"
        Me.Lbl_Srch.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Srch.TabIndex = 24
        Me.Lbl_Srch.Text = "Search:"
        '
        'Frm_MngAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(856, 378)
        Me.Controls.Add(Me.Lbl_Srch)
        Me.Controls.Add(Me.Tb_Srch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bttn_UnAssgn)
        Me.Controls.Add(Me.Bttn_Assgn)
        Me.Controls.Add(Me.Dgv_Assigned)
        Me.Controls.Add(Me.Dgv_Unassigned)
        Me.Controls.Add(Me.Bttn_Cncl)
        Me.Controls.Add(Me.Bttn_Dlt)
        Me.Controls.Add(Me.Bttn_Edt)
        Me.Controls.Add(Me.Bttn_Add)
        Me.Controls.Add(Me.Tb_LN)
        Me.Controls.Add(Me.Lb_Ln)
        Me.Controls.Add(Me.Tb_FN)
        Me.Controls.Add(Me.Lbl_FN)
        Me.Controls.Add(Me.Tb_AID)
        Me.Controls.Add(Me.Lbl_AID)
        Me.MaximumSize = New System.Drawing.Size(872, 416)
        Me.MinimumSize = New System.Drawing.Size(872, 416)
        Me.Name = "Frm_MngAuth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Authors"
        CType(Me.Dgv_Unassigned, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Assigned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb_LN As System.Windows.Forms.TextBox
    Friend WithEvents Lb_Ln As System.Windows.Forms.Label
    Friend WithEvents Tb_FN As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_FN As System.Windows.Forms.Label
    Friend WithEvents Tb_AID As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_AID As System.Windows.Forms.Label
    Friend WithEvents Bttn_Add As System.Windows.Forms.Button
    Friend WithEvents Bttn_Edt As System.Windows.Forms.Button
    Friend WithEvents Bttn_Dlt As System.Windows.Forms.Button
    Friend WithEvents Bttn_Cncl As System.Windows.Forms.Button
    Friend WithEvents Dgv_Unassigned As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv_Assigned As System.Windows.Forms.DataGridView
    Friend WithEvents Bttn_Assgn As System.Windows.Forms.Button
    Friend WithEvents Bttn_UnAssgn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tb_Srch As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Srch As System.Windows.Forms.Label
End Class
