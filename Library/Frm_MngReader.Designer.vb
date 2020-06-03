<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MngReader
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
        Me.Dgv_Stdnts = New System.Windows.Forms.DataGridView()
        Me.Tsb_Add = New System.Windows.Forms.ToolStripButton()
        Me.Tsb_Edit = New System.Windows.Forms.ToolStripButton()
        Me.Tsb_Delete = New System.Windows.Forms.ToolStripButton()
        Me.Tsl_Srch = New System.Windows.Forms.ToolStripLabel()
        Me.TsTb_Srch = New System.Windows.Forms.ToolStripTextBox()
        Me.Tstp_ADES = New System.Windows.Forms.ToolStrip()
        CType(Me.Dgv_Stdnts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tstp_ADES.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_Stdnts
        '
        Me.Dgv_Stdnts.AllowUserToAddRows = False
        Me.Dgv_Stdnts.AllowUserToDeleteRows = False
        Me.Dgv_Stdnts.AllowUserToResizeColumns = False
        Me.Dgv_Stdnts.AllowUserToResizeRows = False
        Me.Dgv_Stdnts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Stdnts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dgv_Stdnts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_Stdnts.Location = New System.Drawing.Point(12, 42)
        Me.Dgv_Stdnts.MultiSelect = False
        Me.Dgv_Stdnts.Name = "Dgv_Stdnts"
        Me.Dgv_Stdnts.ReadOnly = True
        Me.Dgv_Stdnts.RowHeadersVisible = False
        Me.Dgv_Stdnts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_Stdnts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Stdnts.Size = New System.Drawing.Size(562, 378)
        Me.Dgv_Stdnts.TabIndex = 13
        '
        'Tsb_Add
        '
        Me.Tsb_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tsb_Add.Image = Global.Library.My.Resources.Resources.Img_Plus
        Me.Tsb_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsb_Add.Name = "Tsb_Add"
        Me.Tsb_Add.Size = New System.Drawing.Size(24, 24)
        Me.Tsb_Add.Text = "Add Reader"
        '
        'Tsb_Edit
        '
        Me.Tsb_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tsb_Edit.Image = Global.Library.My.Resources.Resources.Img_Edit
        Me.Tsb_Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsb_Edit.Name = "Tsb_Edit"
        Me.Tsb_Edit.Size = New System.Drawing.Size(24, 24)
        Me.Tsb_Edit.Text = "Edit Reader"
        '
        'Tsb_Delete
        '
        Me.Tsb_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tsb_Delete.Image = Global.Library.My.Resources.Resources.Img_Eks
        Me.Tsb_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tsb_Delete.Name = "Tsb_Delete"
        Me.Tsb_Delete.Size = New System.Drawing.Size(24, 24)
        Me.Tsb_Delete.Text = "Delete Selected Reader"
        '
        'Tsl_Srch
        '
        Me.Tsl_Srch.BackColor = System.Drawing.Color.White
        Me.Tsl_Srch.ImageTransparentColor = System.Drawing.Color.White
        Me.Tsl_Srch.Name = "Tsl_Srch"
        Me.Tsl_Srch.Size = New System.Drawing.Size(48, 24)
        Me.Tsl_Srch.Text = "Search :"
        '
        'TsTb_Srch
        '
        Me.TsTb_Srch.BackColor = System.Drawing.Color.White
        Me.TsTb_Srch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TsTb_Srch.Name = "TsTb_Srch"
        Me.TsTb_Srch.Size = New System.Drawing.Size(129, 27)
        '
        'Tstp_ADES
        '
        Me.Tstp_ADES.BackColor = System.Drawing.Color.Green
        Me.Tstp_ADES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Tstp_ADES.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tstp_ADES.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsb_Add, Me.Tsb_Edit, Me.Tsb_Delete, Me.Tsl_Srch, Me.TsTb_Srch})
        Me.Tstp_ADES.Location = New System.Drawing.Point(0, 0)
        Me.Tstp_ADES.Name = "Tstp_ADES"
        Me.Tstp_ADES.Size = New System.Drawing.Size(586, 27)
        Me.Tstp_ADES.Stretch = True
        Me.Tstp_ADES.TabIndex = 14
        '
        'Frm_MngReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(586, 432)
        Me.Controls.Add(Me.Tstp_ADES)
        Me.Controls.Add(Me.Dgv_Stdnts)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.MaximumSize = New System.Drawing.Size(602, 470)
        Me.MinimumSize = New System.Drawing.Size(602, 470)
        Me.Name = "Frm_MngReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Reader"
        CType(Me.Dgv_Stdnts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tstp_ADES.ResumeLayout(False)
        Me.Tstp_ADES.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_Stdnts As System.Windows.Forms.DataGridView
    Friend WithEvents Tsb_Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tsb_Edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tsb_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tsl_Srch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TsTb_Srch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Tstp_ADES As System.Windows.Forms.ToolStrip
End Class
