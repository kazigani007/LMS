<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MngBooks
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
        Me.Dgv_Books = New System.Windows.Forms.DataGridView()
        Me.Lbl_BC = New System.Windows.Forms.Label()
        Me.Tb_BC = New System.Windows.Forms.TextBox()
        Me.Tb_Ttl = New System.Windows.Forms.TextBox()
        Me.Lbl_Ttl = New System.Windows.Forms.Label()
        Me.Tb_Pb = New System.Windows.Forms.TextBox()
        Me.Lbl_Pb = New System.Windows.Forms.Label()
        Me.Lbl_Auth = New System.Windows.Forms.Label()
        Me.Link_Auth = New System.Windows.Forms.LinkLabel()
        Me.Dtp_DtPb = New System.Windows.Forms.DateTimePicker()
        Me.Bttn_Cncl = New System.Windows.Forms.Button()
        Me.Bttn_Dlt = New System.Windows.Forms.Button()
        Me.Bttn_Edt = New System.Windows.Forms.Button()
        Me.Bttn_Add = New System.Windows.Forms.Button()
        Me.Lbb_BCopies = New System.Windows.Forms.Label()
        Me.Bttn_AddCop = New System.Windows.Forms.Button()
        Me.Dgv_BookCopies = New System.Windows.Forms.DataGridView()
        Me.Dgv_Authors = New System.Windows.Forms.DataGridView()
        Me.Bttn_DltCop = New System.Windows.Forms.Button()
        Me.Lbl_Book = New System.Windows.Forms.Label()
        Me.Tb_Srch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_DtPb = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Dgv_Books, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_BookCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Authors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_Books
        '
        Me.Dgv_Books.AllowUserToAddRows = False
        Me.Dgv_Books.AllowUserToDeleteRows = False
        Me.Dgv_Books.AllowUserToResizeColumns = False
        Me.Dgv_Books.AllowUserToResizeRows = False
        Me.Dgv_Books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_Books.Location = New System.Drawing.Point(28, 228)
        Me.Dgv_Books.MultiSelect = False
        Me.Dgv_Books.Name = "Dgv_Books"
        Me.Dgv_Books.ReadOnly = True
        Me.Dgv_Books.RowHeadersVisible = False
        Me.Dgv_Books.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_Books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Books.Size = New System.Drawing.Size(471, 338)
        Me.Dgv_Books.TabIndex = 0
        '
        'Lbl_BC
        '
        Me.Lbl_BC.AutoSize = True
        Me.Lbl_BC.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_BC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BC.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_BC.Location = New System.Drawing.Point(23, 11)
        Me.Lbl_BC.Name = "Lbl_BC"
        Me.Lbl_BC.Size = New System.Drawing.Size(84, 15)
        Me.Lbl_BC.TabIndex = 1
        Me.Lbl_BC.Text = "Book Code :"
        '
        'Tb_BC
        '
        Me.Tb_BC.Location = New System.Drawing.Point(26, 36)
        Me.Tb_BC.Name = "Tb_BC"
        Me.Tb_BC.ReadOnly = True
        Me.Tb_BC.Size = New System.Drawing.Size(231, 20)
        Me.Tb_BC.TabIndex = 2
        '
        'Tb_Ttl
        '
        Me.Tb_Ttl.Location = New System.Drawing.Point(26, 88)
        Me.Tb_Ttl.Name = "Tb_Ttl"
        Me.Tb_Ttl.ReadOnly = True
        Me.Tb_Ttl.Size = New System.Drawing.Size(231, 20)
        Me.Tb_Ttl.TabIndex = 6
        '
        'Lbl_Ttl
        '
        Me.Lbl_Ttl.AutoSize = True
        Me.Lbl_Ttl.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_Ttl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ttl.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Ttl.Location = New System.Drawing.Point(23, 63)
        Me.Lbl_Ttl.Name = "Lbl_Ttl"
        Me.Lbl_Ttl.Size = New System.Drawing.Size(43, 15)
        Me.Lbl_Ttl.TabIndex = 5
        Me.Lbl_Ttl.Text = "Title :"
        '
        'Tb_Pb
        '
        Me.Tb_Pb.Location = New System.Drawing.Point(26, 147)
        Me.Tb_Pb.Name = "Tb_Pb"
        Me.Tb_Pb.ReadOnly = True
        Me.Tb_Pb.Size = New System.Drawing.Size(231, 20)
        Me.Tb_Pb.TabIndex = 8
        '
        'Lbl_Pb
        '
        Me.Lbl_Pb.AutoSize = True
        Me.Lbl_Pb.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_Pb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pb.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Pb.Location = New System.Drawing.Point(23, 122)
        Me.Lbl_Pb.Name = "Lbl_Pb"
        Me.Lbl_Pb.Size = New System.Drawing.Size(76, 15)
        Me.Lbl_Pb.TabIndex = 7
        Me.Lbl_Pb.Text = "Publisher :"
        '
        'Lbl_Auth
        '
        Me.Lbl_Auth.AutoSize = True
        Me.Lbl_Auth.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_Auth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Auth.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Auth.Location = New System.Drawing.Point(309, 12)
        Me.Lbl_Auth.Name = "Lbl_Auth"
        Me.Lbl_Auth.Size = New System.Drawing.Size(63, 15)
        Me.Lbl_Auth.TabIndex = 9
        Me.Lbl_Auth.Text = "Authors :"
        '
        'Link_Auth
        '
        Me.Link_Auth.ActiveLinkColor = System.Drawing.Color.Black
        Me.Link_Auth.AutoSize = True
        Me.Link_Auth.BackColor = System.Drawing.Color.LimeGreen
        Me.Link_Auth.Enabled = False
        Me.Link_Auth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Link_Auth.ForeColor = System.Drawing.Color.DarkGreen
        Me.Link_Auth.LinkColor = System.Drawing.Color.MidnightBlue
        Me.Link_Auth.Location = New System.Drawing.Point(458, 12)
        Me.Link_Auth.Name = "Link_Auth"
        Me.Link_Auth.Size = New System.Drawing.Size(111, 15)
        Me.Link_Auth.TabIndex = 10
        Me.Link_Auth.TabStop = True
        Me.Link_Auth.Text = "Manage Authors"
        '
        'Dtp_DtPb
        '
        Me.Dtp_DtPb.Enabled = False
        Me.Dtp_DtPb.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_DtPb.Location = New System.Drawing.Point(312, 144)
        Me.Dtp_DtPb.Name = "Dtp_DtPb"
        Me.Dtp_DtPb.Size = New System.Drawing.Size(231, 20)
        Me.Dtp_DtPb.TabIndex = 12
        '
        'Bttn_Cncl
        '
        Me.Bttn_Cncl.BackColor = System.Drawing.Color.DarkGreen
        Me.Bttn_Cncl.Enabled = False
        Me.Bttn_Cncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Cncl.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Cncl.Location = New System.Drawing.Point(705, 88)
        Me.Bttn_Cncl.Name = "Bttn_Cncl"
        Me.Bttn_Cncl.Size = New System.Drawing.Size(104, 23)
        Me.Bttn_Cncl.TabIndex = 20
        Me.Bttn_Cncl.Text = "Cancel"
        Me.Bttn_Cncl.UseVisualStyleBackColor = False
        '
        'Bttn_Dlt
        '
        Me.Bttn_Dlt.BackColor = System.Drawing.Color.DarkGreen
        Me.Bttn_Dlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Dlt.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Dlt.Location = New System.Drawing.Point(578, 88)
        Me.Bttn_Dlt.Name = "Bttn_Dlt"
        Me.Bttn_Dlt.Size = New System.Drawing.Size(104, 23)
        Me.Bttn_Dlt.TabIndex = 19
        Me.Bttn_Dlt.Text = "Delete Book"
        Me.Bttn_Dlt.UseVisualStyleBackColor = False
        '
        'Bttn_Edt
        '
        Me.Bttn_Edt.BackColor = System.Drawing.Color.DarkGreen
        Me.Bttn_Edt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Edt.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Edt.Location = New System.Drawing.Point(705, 33)
        Me.Bttn_Edt.Name = "Bttn_Edt"
        Me.Bttn_Edt.Size = New System.Drawing.Size(104, 23)
        Me.Bttn_Edt.TabIndex = 18
        Me.Bttn_Edt.Text = "Edit Book"
        Me.Bttn_Edt.UseVisualStyleBackColor = False
        '
        'Bttn_Add
        '
        Me.Bttn_Add.BackColor = System.Drawing.Color.DarkGreen
        Me.Bttn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Add.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Add.Location = New System.Drawing.Point(578, 33)
        Me.Bttn_Add.Name = "Bttn_Add"
        Me.Bttn_Add.Size = New System.Drawing.Size(104, 23)
        Me.Bttn_Add.TabIndex = 17
        Me.Bttn_Add.Text = "Add Book"
        Me.Bttn_Add.UseVisualStyleBackColor = False
        '
        'Lbb_BCopies
        '
        Me.Lbb_BCopies.AutoSize = True
        Me.Lbb_BCopies.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbb_BCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbb_BCopies.ForeColor = System.Drawing.Color.Lime
        Me.Lbb_BCopies.Location = New System.Drawing.Point(520, 203)
        Me.Lbb_BCopies.Name = "Lbb_BCopies"
        Me.Lbb_BCopies.Size = New System.Drawing.Size(122, 22)
        Me.Lbb_BCopies.TabIndex = 22
        Me.Lbb_BCopies.Text = "Book Copies :"
        '
        'Bttn_AddCop
        '
        Me.Bttn_AddCop.BackColor = System.Drawing.Color.DarkGreen
        Me.Bttn_AddCop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_AddCop.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_AddCop.Location = New System.Drawing.Point(578, 143)
        Me.Bttn_AddCop.Name = "Bttn_AddCop"
        Me.Bttn_AddCop.Size = New System.Drawing.Size(104, 23)
        Me.Bttn_AddCop.TabIndex = 23
        Me.Bttn_AddCop.Text = "Add Copies"
        Me.Bttn_AddCop.UseVisualStyleBackColor = False
        '
        'Dgv_BookCopies
        '
        Me.Dgv_BookCopies.AllowUserToAddRows = False
        Me.Dgv_BookCopies.AllowUserToDeleteRows = False
        Me.Dgv_BookCopies.AllowUserToResizeColumns = False
        Me.Dgv_BookCopies.AllowUserToResizeRows = False
        Me.Dgv_BookCopies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_BookCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_BookCopies.Location = New System.Drawing.Point(522, 232)
        Me.Dgv_BookCopies.MultiSelect = False
        Me.Dgv_BookCopies.Name = "Dgv_BookCopies"
        Me.Dgv_BookCopies.ReadOnly = True
        Me.Dgv_BookCopies.RowHeadersVisible = False
        Me.Dgv_BookCopies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_BookCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_BookCopies.Size = New System.Drawing.Size(287, 338)
        Me.Dgv_BookCopies.TabIndex = 24
        '
        'Dgv_Authors
        '
        Me.Dgv_Authors.AllowUserToAddRows = False
        Me.Dgv_Authors.AllowUserToDeleteRows = False
        Me.Dgv_Authors.AllowUserToResizeColumns = False
        Me.Dgv_Authors.AllowUserToResizeRows = False
        Me.Dgv_Authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_Authors.Enabled = False
        Me.Dgv_Authors.Location = New System.Drawing.Point(312, 36)
        Me.Dgv_Authors.MultiSelect = False
        Me.Dgv_Authors.Name = "Dgv_Authors"
        Me.Dgv_Authors.ReadOnly = True
        Me.Dgv_Authors.RowHeadersVisible = False
        Me.Dgv_Authors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_Authors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Authors.Size = New System.Drawing.Size(231, 75)
        Me.Dgv_Authors.TabIndex = 25
        '
        'Bttn_DltCop
        '
        Me.Bttn_DltCop.BackColor = System.Drawing.Color.DarkGreen
        Me.Bttn_DltCop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_DltCop.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_DltCop.Location = New System.Drawing.Point(708, 143)
        Me.Bttn_DltCop.Name = "Bttn_DltCop"
        Me.Bttn_DltCop.Size = New System.Drawing.Size(104, 23)
        Me.Bttn_DltCop.TabIndex = 26
        Me.Bttn_DltCop.Text = "Delete Copies"
        Me.Bttn_DltCop.UseVisualStyleBackColor = False
        '
        'Lbl_Book
        '
        Me.Lbl_Book.AutoSize = True
        Me.Lbl_Book.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Book.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Book.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Book.Location = New System.Drawing.Point(24, 203)
        Me.Lbl_Book.Name = "Lbl_Book"
        Me.Lbl_Book.Size = New System.Drawing.Size(65, 22)
        Me.Lbl_Book.TabIndex = 27
        Me.Lbl_Book.Text = "Books:"
        '
        'Tb_Srch
        '
        Me.Tb_Srch.Location = New System.Drawing.Point(288, 209)
        Me.Tb_Srch.Name = "Tb_Srch"
        Me.Tb_Srch.Size = New System.Drawing.Size(209, 20)
        Me.Tb_Srch.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(235, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Search :"
        '
        'Lbl_DtPb
        '
        Me.Lbl_DtPb.AutoSize = True
        Me.Lbl_DtPb.BackColor = System.Drawing.Color.LimeGreen
        Me.Lbl_DtPb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DtPb.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_DtPb.Location = New System.Drawing.Point(309, 122)
        Me.Lbl_DtPb.Name = "Lbl_DtPb"
        Me.Lbl_DtPb.Size = New System.Drawing.Size(113, 15)
        Me.Lbl_DtPb.TabIndex = 13
        Me.Lbl_DtPb.Text = "Date Published :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.Lbl_DtPb)
        Me.Panel1.Controls.Add(Me.Link_Auth)
        Me.Panel1.Controls.Add(Me.Lbl_BC)
        Me.Panel1.Controls.Add(Me.Lbl_Ttl)
        Me.Panel1.Controls.Add(Me.Lbl_Pb)
        Me.Panel1.Controls.Add(Me.Lbl_Auth)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 189)
        Me.Panel1.TabIndex = 30
        '
        'Frm_MngBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(824, 589)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_Srch)
        Me.Controls.Add(Me.Lbl_Book)
        Me.Controls.Add(Me.Bttn_DltCop)
        Me.Controls.Add(Me.Dgv_Authors)
        Me.Controls.Add(Me.Bttn_AddCop)
        Me.Controls.Add(Me.Lbb_BCopies)
        Me.Controls.Add(Me.Bttn_Cncl)
        Me.Controls.Add(Me.Bttn_Dlt)
        Me.Controls.Add(Me.Bttn_Edt)
        Me.Controls.Add(Me.Bttn_Add)
        Me.Controls.Add(Me.Dtp_DtPb)
        Me.Controls.Add(Me.Tb_Pb)
        Me.Controls.Add(Me.Tb_Ttl)
        Me.Controls.Add(Me.Tb_BC)
        Me.Controls.Add(Me.Dgv_Books)
        Me.Controls.Add(Me.Dgv_BookCopies)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(840, 627)
        Me.MinimumSize = New System.Drawing.Size(840, 627)
        Me.Name = "Frm_MngBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Books"
        CType(Me.Dgv_Books, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_BookCopies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Authors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_Books As System.Windows.Forms.DataGridView
    Friend WithEvents Lbl_BC As System.Windows.Forms.Label
    Friend WithEvents Tb_BC As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Ttl As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ttl As System.Windows.Forms.Label
    Friend WithEvents Tb_Pb As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pb As System.Windows.Forms.Label
    Friend WithEvents Lbl_Auth As System.Windows.Forms.Label
    Friend WithEvents Link_Auth As System.Windows.Forms.LinkLabel
    Friend WithEvents Dtp_DtPb As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bttn_Cncl As System.Windows.Forms.Button
    Friend WithEvents Bttn_Dlt As System.Windows.Forms.Button
    Friend WithEvents Bttn_Edt As System.Windows.Forms.Button
    Friend WithEvents Bttn_Add As System.Windows.Forms.Button
    Friend WithEvents Lbb_BCopies As System.Windows.Forms.Label
    Friend WithEvents Bttn_AddCop As System.Windows.Forms.Button
    Friend WithEvents Dgv_BookCopies As System.Windows.Forms.DataGridView
    Friend WithEvents Dgv_Authors As System.Windows.Forms.DataGridView
    Friend WithEvents Bttn_DltCop As System.Windows.Forms.Button
    Friend WithEvents Lbl_Book As System.Windows.Forms.Label
    Friend WithEvents Tb_Srch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DtPb As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
