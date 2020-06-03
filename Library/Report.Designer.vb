<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.DGV_PENALTY = New System.Windows.Forms.DataGridView()
        Me.DGV_MAIN = New System.Windows.Forms.DataGridView()
        Me.DTP_Year = New System.Windows.Forms.DateTimePicker()
        Me.TbPENALTY = New System.Windows.Forms.TextBox()
        Me.Lbl_Nme = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_BC = New System.Windows.Forms.Label()
        Me.DTP_Month = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbAuthor = New System.Windows.Forms.TextBox()
        CType(Me.DGV_PENALTY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_PENALTY
        '
        Me.DGV_PENALTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PENALTY.Location = New System.Drawing.Point(210, 334)
        Me.DGV_PENALTY.Name = "DGV_PENALTY"
        Me.DGV_PENALTY.Size = New System.Drawing.Size(588, 189)
        Me.DGV_PENALTY.TabIndex = 0
        '
        'DGV_MAIN
        '
        Me.DGV_MAIN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_MAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MAIN.Location = New System.Drawing.Point(210, 108)
        Me.DGV_MAIN.Name = "DGV_MAIN"
        Me.DGV_MAIN.Size = New System.Drawing.Size(588, 195)
        Me.DGV_MAIN.TabIndex = 1
        '
        'DTP_Year
        '
        Me.DTP_Year.CustomFormat = "yyyy"
        Me.DTP_Year.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Year.Location = New System.Drawing.Point(107, 361)
        Me.DTP_Year.Name = "DTP_Year"
        Me.DTP_Year.Size = New System.Drawing.Size(97, 20)
        Me.DTP_Year.TabIndex = 3
        '
        'TbPENALTY
        '
        Me.TbPENALTY.Location = New System.Drawing.Point(88, 477)
        Me.TbPENALTY.Name = "TbPENALTY"
        Me.TbPENALTY.Size = New System.Drawing.Size(116, 20)
        Me.TbPENALTY.TabIndex = 4
        '
        'Lbl_Nme
        '
        Me.Lbl_Nme.AutoSize = True
        Me.Lbl_Nme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nme.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Nme.Location = New System.Drawing.Point(33, 335)
        Me.Lbl_Nme.Name = "Lbl_Nme"
        Me.Lbl_Nme.Size = New System.Drawing.Size(61, 16)
        Me.Lbl_Nme.TabIndex = 25
        Me.Lbl_Nme.Text = "Month : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(41, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Year : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(92, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Total Penalty : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.Lbl_BC)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 71)
        Me.Panel1.TabIndex = 28
        '
        'Lbl_BC
        '
        Me.Lbl_BC.AutoSize = True
        Me.Lbl_BC.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BC.ForeColor = System.Drawing.Color.LimeGreen
        Me.Lbl_BC.Location = New System.Drawing.Point(139, 9)
        Me.Lbl_BC.Name = "Lbl_BC"
        Me.Lbl_BC.Size = New System.Drawing.Size(533, 55)
        Me.Lbl_BC.TabIndex = 29
        Me.Lbl_BC.Text = "INVENTORY REPORT"
        '
        'DTP_Month
        '
        Me.DTP_Month.CustomFormat = "m"
        Me.DTP_Month.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Month.Location = New System.Drawing.Point(107, 335)
        Me.DTP_Month.Name = "DTP_Month"
        Me.DTP_Month.Size = New System.Drawing.Size(97, 20)
        Me.DTP_Month.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(210, 305)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(588, 31)
        Me.Panel2.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(181, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "INCOME REPORT"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(210, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(588, 31)
        Me.Panel3.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(181, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "BOOK REPORT"
        '
        'TbSearch
        '
        Me.TbSearch.Location = New System.Drawing.Point(44, 126)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(116, 20)
        Me.TbSearch.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(51, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Search Book : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(43, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Search Author : "
        '
        'TbAuthor
        '
        Me.TbAuthor.Location = New System.Drawing.Point(44, 174)
        Me.TbAuthor.Name = "TbAuthor"
        Me.TbAuthor.Size = New System.Drawing.Size(116, 20)
        Me.TbAuthor.TabIndex = 33
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(803, 530)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TbAuthor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbSearch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Nme)
        Me.Controls.Add(Me.TbPENALTY)
        Me.Controls.Add(Me.DTP_Year)
        Me.Controls.Add(Me.DTP_Month)
        Me.Controls.Add(Me.DGV_MAIN)
        Me.Controls.Add(Me.DGV_PENALTY)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.DGV_PENALTY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_PENALTY As System.Windows.Forms.DataGridView
    Friend WithEvents DGV_MAIN As System.Windows.Forms.DataGridView
    Friend WithEvents DTP_Year As System.Windows.Forms.DateTimePicker
    Friend WithEvents TbPENALTY As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Nme As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_BC As System.Windows.Forms.Label
    Friend WithEvents DTP_Month As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbAuthor As System.Windows.Forms.TextBox
End Class
