<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AddCopies
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_AN = New System.Windows.Forms.TextBox()
        Me.Lbl_AN = New System.Windows.Forms.Label()
        Me.Bttn_AddCop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ".........."
        '
        'Tb_AN
        '
        Me.Tb_AN.Location = New System.Drawing.Point(54, 70)
        Me.Tb_AN.Name = "Tb_AN"
        Me.Tb_AN.Size = New System.Drawing.Size(180, 20)
        Me.Tb_AN.TabIndex = 10
        '
        'Lbl_AN
        '
        Me.Lbl_AN.AutoSize = True
        Me.Lbl_AN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AN.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_AN.Location = New System.Drawing.Point(51, 51)
        Me.Lbl_AN.Name = "Lbl_AN"
        Me.Lbl_AN.Size = New System.Drawing.Size(138, 16)
        Me.Lbl_AN.TabIndex = 9
        Me.Lbl_AN.Text = "Accession Number"
        '
        'Bttn_AddCop
        '
        Me.Bttn_AddCop.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_AddCop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_AddCop.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_AddCop.Location = New System.Drawing.Point(130, 110)
        Me.Bttn_AddCop.Name = "Bttn_AddCop"
        Me.Bttn_AddCop.Size = New System.Drawing.Size(104, 30)
        Me.Bttn_AddCop.TabIndex = 24
        Me.Bttn_AddCop.Text = "Add Copies"
        Me.Bttn_AddCop.UseVisualStyleBackColor = False
        '
        'Frm_AddCopies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(284, 155)
        Me.Controls.Add(Me.Bttn_AddCop)
        Me.Controls.Add(Me.Tb_AN)
        Me.Controls.Add(Me.Lbl_AN)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(300, 193)
        Me.MinimumSize = New System.Drawing.Size(300, 193)
        Me.Name = "Frm_AddCopies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Copies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tb_AN As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_AN As System.Windows.Forms.Label
    Friend WithEvents Bttn_AddCop As System.Windows.Forms.Button
End Class
