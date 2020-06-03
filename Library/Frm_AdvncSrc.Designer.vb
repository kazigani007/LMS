<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AdvncSrc
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
        Me.Dgv_AdvncSrch = New System.Windows.Forms.DataGridView()
        Me.Lbl_Srch = New System.Windows.Forms.Label()
        Me.Tb_Srch = New System.Windows.Forms.TextBox()
        Me.Bttn_Slct = New System.Windows.Forms.Button()
        CType(Me.Dgv_AdvncSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_AdvncSrch
        '
        Me.Dgv_AdvncSrch.AllowUserToAddRows = False
        Me.Dgv_AdvncSrch.AllowUserToDeleteRows = False
        Me.Dgv_AdvncSrch.AllowUserToResizeColumns = False
        Me.Dgv_AdvncSrch.AllowUserToResizeRows = False
        Me.Dgv_AdvncSrch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_AdvncSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_AdvncSrch.Location = New System.Drawing.Point(12, 50)
        Me.Dgv_AdvncSrch.MultiSelect = False
        Me.Dgv_AdvncSrch.Name = "Dgv_AdvncSrch"
        Me.Dgv_AdvncSrch.ReadOnly = True
        Me.Dgv_AdvncSrch.RowHeadersVisible = False
        Me.Dgv_AdvncSrch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_AdvncSrch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_AdvncSrch.Size = New System.Drawing.Size(580, 375)
        Me.Dgv_AdvncSrch.TabIndex = 19
        '
        'Lbl_Srch
        '
        Me.Lbl_Srch.AutoSize = True
        Me.Lbl_Srch.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Srch.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Srch.Location = New System.Drawing.Point(18, 15)
        Me.Lbl_Srch.Name = "Lbl_Srch"
        Me.Lbl_Srch.Size = New System.Drawing.Size(47, 13)
        Me.Lbl_Srch.TabIndex = 20
        Me.Lbl_Srch.Text = "Search :"
        '
        'Tb_Srch
        '
        Me.Tb_Srch.Location = New System.Drawing.Point(81, 12)
        Me.Tb_Srch.Name = "Tb_Srch"
        Me.Tb_Srch.Size = New System.Drawing.Size(162, 20)
        Me.Tb_Srch.TabIndex = 21
        '
        'Bttn_Slct
        '
        Me.Bttn_Slct.BackColor = System.Drawing.Color.LimeGreen
        Me.Bttn_Slct.ForeColor = System.Drawing.Color.DarkGreen
        Me.Bttn_Slct.Location = New System.Drawing.Point(508, 10)
        Me.Bttn_Slct.Name = "Bttn_Slct"
        Me.Bttn_Slct.Size = New System.Drawing.Size(84, 22)
        Me.Bttn_Slct.TabIndex = 22
        Me.Bttn_Slct.Text = "Select"
        Me.Bttn_Slct.UseVisualStyleBackColor = False
        '
        'Frm_AdvncSrc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(604, 437)
        Me.Controls.Add(Me.Bttn_Slct)
        Me.Controls.Add(Me.Tb_Srch)
        Me.Controls.Add(Me.Lbl_Srch)
        Me.Controls.Add(Me.Dgv_AdvncSrch)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.MaximumSize = New System.Drawing.Size(620, 475)
        Me.MinimumSize = New System.Drawing.Size(620, 475)
        Me.Name = "Frm_AdvncSrc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Search"
        CType(Me.Dgv_AdvncSrch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_AdvncSrch As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_Srch As System.Windows.Forms.Label
    Friend WithEvents Tb_Srch As System.Windows.Forms.TextBox
    Friend WithEvents Bttn_Slct As System.Windows.Forms.Button
End Class
