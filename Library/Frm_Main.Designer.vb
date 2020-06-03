<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
        Me.Tbc_BookRetutn = New System.Windows.Forms.TabControl()
        Me.Tp_BrrwBooks = New System.Windows.Forms.TabPage()
        Me.BtnOK_DueDate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimeDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Bttn_Borrw = New System.Windows.Forms.Button()
        Me.Gb_SrchReaders = New System.Windows.Forms.GroupBox()
        Me.Bttn_AdvncSrch1 = New System.Windows.Forms.Button()
        Me.Tb_Type = New System.Windows.Forms.TextBox()
        Me.Tb_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Type = New System.Windows.Forms.Label()
        Me.Lbl_Nme = New System.Windows.Forms.Label()
        Me.Cb_SrchReaders = New System.Windows.Forms.ComboBox()
        Me.Lbl_SrchR = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dgv_BrwdBooks = New System.Windows.Forms.DataGridView()
        Me.Gb_SrchBooks = New System.Windows.Forms.GroupBox()
        Me.Bttn_AdvncSrch2 = New System.Windows.Forms.Button()
        Me.Tb_Avail = New System.Windows.Forms.TextBox()
        Me.Lbl_Avail = New System.Windows.Forms.Label()
        Me.Tb_Pub = New System.Windows.Forms.TextBox()
        Me.Cb_SrchAcc = New System.Windows.Forms.ComboBox()
        Me.Tb_Title = New System.Windows.Forms.TextBox()
        Me.Lbl_Pub = New System.Windows.Forms.Label()
        Me.Lbl_SrcA = New System.Windows.Forms.Label()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        Me.Tp_BrrwHistory = New System.Windows.Forms.TabPage()
        Me.Dgv_Transactions = New System.Windows.Forms.DataGridView()
        Me.Tp_RtrnBook = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dgv_BrrwdBooks = New System.Windows.Forms.DataGridView()
        Me.Gb_SrchReaderss = New System.Windows.Forms.GroupBox()
        Me.Tb_RderID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_Pnlty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bttn_Rturn = New System.Windows.Forms.Button()
        Me.Bttn_AdnceSrchRB = New System.Windows.Forms.Button()
        Me.Tb_TypeRB = New System.Windows.Forms.TextBox()
        Me.Tb_NameRB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Reader = New System.Windows.Forms.Label()
        Me.Tsp_MainMenu = New System.Windows.Forms.ToolStrip()
        Me.TspB_MngBook = New System.Windows.Forms.ToolStripButton()
        Me.TspB_MngReader = New System.Windows.Forms.ToolStripButton()
        Me.TspB_MngUser = New System.Windows.Forms.ToolStripButton()
        Me.TSB_GenerateReport = New System.Windows.Forms.ToolStripButton()
        Me.TspB_Logout = New System.Windows.Forms.ToolStripButton()
        Me.TspB_Exit = New System.Windows.Forms.ToolStripButton()
        Me.ErrPrvder = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tbc_BookRetutn.SuspendLayout()
        Me.Tp_BrrwBooks.SuspendLayout()
        Me.Gb_SrchReaders.SuspendLayout()
        CType(Me.Dgv_BrwdBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_SrchBooks.SuspendLayout()
        Me.Tp_BrrwHistory.SuspendLayout()
        CType(Me.Dgv_Transactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tp_RtrnBook.SuspendLayout()
        CType(Me.Dgv_BrrwdBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_SrchReaderss.SuspendLayout()
        Me.Tsp_MainMenu.SuspendLayout()
        CType(Me.ErrPrvder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tbc_BookRetutn
        '
        Me.Tbc_BookRetutn.Controls.Add(Me.Tp_BrrwBooks)
        Me.Tbc_BookRetutn.Controls.Add(Me.Tp_BrrwHistory)
        Me.Tbc_BookRetutn.Controls.Add(Me.Tp_RtrnBook)
        Me.Tbc_BookRetutn.Location = New System.Drawing.Point(12, 28)
        Me.Tbc_BookRetutn.Name = "Tbc_BookRetutn"
        Me.Tbc_BookRetutn.SelectedIndex = 0
        Me.Tbc_BookRetutn.Size = New System.Drawing.Size(640, 510)
        Me.Tbc_BookRetutn.TabIndex = 0
        '
        'Tp_BrrwBooks
        '
        Me.Tp_BrrwBooks.BackColor = System.Drawing.Color.DarkGreen
        Me.Tp_BrrwBooks.Controls.Add(Me.BtnOK_DueDate)
        Me.Tp_BrrwBooks.Controls.Add(Me.Label7)
        Me.Tp_BrrwBooks.Controls.Add(Me.DateTimeDueDate)
        Me.Tp_BrrwBooks.Controls.Add(Me.Bttn_Borrw)
        Me.Tp_BrrwBooks.Controls.Add(Me.Gb_SrchReaders)
        Me.Tp_BrrwBooks.Controls.Add(Me.Label3)
        Me.Tp_BrrwBooks.Controls.Add(Me.Dgv_BrwdBooks)
        Me.Tp_BrrwBooks.Controls.Add(Me.Gb_SrchBooks)
        Me.Tp_BrrwBooks.Location = New System.Drawing.Point(4, 22)
        Me.Tp_BrrwBooks.Name = "Tp_BrrwBooks"
        Me.Tp_BrrwBooks.Padding = New System.Windows.Forms.Padding(3)
        Me.Tp_BrrwBooks.Size = New System.Drawing.Size(632, 484)
        Me.Tp_BrrwBooks.TabIndex = 0
        Me.Tp_BrrwBooks.Text = "Borrow Books"
        '
        'BtnOK_DueDate
        '
        Me.BtnOK_DueDate.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnOK_DueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK_DueDate.ForeColor = System.Drawing.Color.Lime
        Me.BtnOK_DueDate.Location = New System.Drawing.Point(345, 286)
        Me.BtnOK_DueDate.Name = "BtnOK_DueDate"
        Me.BtnOK_DueDate.Size = New System.Drawing.Size(36, 32)
        Me.BtnOK_DueDate.TabIndex = 31
        Me.BtnOK_DueDate.Text = "OK"
        Me.BtnOK_DueDate.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkGreen
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(22, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Adjust Due Date :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DateTimeDueDate
        '
        Me.DateTimeDueDate.CustomFormat = ""
        Me.DateTimeDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeDueDate.Location = New System.Drawing.Point(139, 290)
        Me.DateTimeDueDate.Name = "DateTimeDueDate"
        Me.DateTimeDueDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeDueDate.TabIndex = 29
        '
        'Bttn_Borrw
        '
        Me.Bttn_Borrw.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_Borrw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_Borrw.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_Borrw.Location = New System.Drawing.Point(556, 242)
        Me.Bttn_Borrw.Name = "Bttn_Borrw"
        Me.Bttn_Borrw.Size = New System.Drawing.Size(58, 39)
        Me.Bttn_Borrw.TabIndex = 28
        Me.Bttn_Borrw.Text = "Borrow"
        Me.Bttn_Borrw.UseVisualStyleBackColor = False
        '
        'Gb_SrchReaders
        '
        Me.Gb_SrchReaders.BackColor = System.Drawing.Color.DarkGreen
        Me.Gb_SrchReaders.Controls.Add(Me.Bttn_AdvncSrch1)
        Me.Gb_SrchReaders.Controls.Add(Me.Tb_Type)
        Me.Gb_SrchReaders.Controls.Add(Me.Tb_Name)
        Me.Gb_SrchReaders.Controls.Add(Me.Lbl_Type)
        Me.Gb_SrchReaders.Controls.Add(Me.Lbl_Nme)
        Me.Gb_SrchReaders.Controls.Add(Me.Cb_SrchReaders)
        Me.Gb_SrchReaders.Controls.Add(Me.Lbl_SrchR)
        Me.Gb_SrchReaders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_SrchReaders.ForeColor = System.Drawing.Color.Lime
        Me.Gb_SrchReaders.Location = New System.Drawing.Point(22, 25)
        Me.Gb_SrchReaders.Name = "Gb_SrchReaders"
        Me.Gb_SrchReaders.Size = New System.Drawing.Size(528, 112)
        Me.Gb_SrchReaders.TabIndex = 27
        Me.Gb_SrchReaders.TabStop = False
        Me.Gb_SrchReaders.Text = "Search Reader"
        '
        'Bttn_AdvncSrch1
        '
        Me.Bttn_AdvncSrch1.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_AdvncSrch1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_AdvncSrch1.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_AdvncSrch1.Location = New System.Drawing.Point(24, 83)
        Me.Bttn_AdvncSrch1.Name = "Bttn_AdvncSrch1"
        Me.Bttn_AdvncSrch1.Size = New System.Drawing.Size(101, 23)
        Me.Bttn_AdvncSrch1.TabIndex = 28
        Me.Bttn_AdvncSrch1.Text = "Advance Search"
        Me.Bttn_AdvncSrch1.UseVisualStyleBackColor = False
        '
        'Tb_Type
        '
        Me.Tb_Type.Location = New System.Drawing.Point(297, 76)
        Me.Tb_Type.Name = "Tb_Type"
        Me.Tb_Type.ReadOnly = True
        Me.Tb_Type.Size = New System.Drawing.Size(178, 22)
        Me.Tb_Type.TabIndex = 27
        '
        'Tb_Name
        '
        Me.Tb_Name.Location = New System.Drawing.Point(297, 36)
        Me.Tb_Name.Name = "Tb_Name"
        Me.Tb_Name.ReadOnly = True
        Me.Tb_Name.Size = New System.Drawing.Size(178, 22)
        Me.Tb_Name.TabIndex = 26
        '
        'Lbl_Type
        '
        Me.Lbl_Type.AutoSize = True
        Me.Lbl_Type.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Type.Location = New System.Drawing.Point(218, 79)
        Me.Lbl_Type.Name = "Lbl_Type"
        Me.Lbl_Type.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_Type.TabIndex = 25
        Me.Lbl_Type.Text = "Type :"
        '
        'Lbl_Nme
        '
        Me.Lbl_Nme.AutoSize = True
        Me.Lbl_Nme.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Nme.Location = New System.Drawing.Point(218, 36)
        Me.Lbl_Nme.Name = "Lbl_Nme"
        Me.Lbl_Nme.Size = New System.Drawing.Size(54, 16)
        Me.Lbl_Nme.TabIndex = 24
        Me.Lbl_Nme.Text = "Name : "
        '
        'Cb_SrchReaders
        '
        Me.Cb_SrchReaders.FormattingEnabled = True
        Me.Cb_SrchReaders.Location = New System.Drawing.Point(24, 53)
        Me.Cb_SrchReaders.Name = "Cb_SrchReaders"
        Me.Cb_SrchReaders.Size = New System.Drawing.Size(136, 24)
        Me.Cb_SrchReaders.TabIndex = 23
        '
        'Lbl_SrchR
        '
        Me.Lbl_SrchR.AutoSize = True
        Me.Lbl_SrchR.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_SrchR.Location = New System.Drawing.Point(21, 36)
        Me.Lbl_SrchR.Name = "Lbl_SrchR"
        Me.Lbl_SrchR.Size = New System.Drawing.Size(129, 16)
        Me.Lbl_SrchR.TabIndex = 20
        Me.Lbl_SrchR.Text = "Search Readers ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(19, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Borrowed Books :"
        '
        'Dgv_BrwdBooks
        '
        Me.Dgv_BrwdBooks.AllowUserToAddRows = False
        Me.Dgv_BrwdBooks.AllowUserToDeleteRows = False
        Me.Dgv_BrwdBooks.AllowUserToResizeColumns = False
        Me.Dgv_BrwdBooks.AllowUserToResizeRows = False
        Me.Dgv_BrwdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_BrwdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_BrwdBooks.Location = New System.Drawing.Point(22, 338)
        Me.Dgv_BrwdBooks.MultiSelect = False
        Me.Dgv_BrwdBooks.Name = "Dgv_BrwdBooks"
        Me.Dgv_BrwdBooks.ReadOnly = True
        Me.Dgv_BrwdBooks.RowHeadersVisible = False
        Me.Dgv_BrwdBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_BrwdBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_BrwdBooks.Size = New System.Drawing.Size(591, 140)
        Me.Dgv_BrwdBooks.TabIndex = 18
        '
        'Gb_SrchBooks
        '
        Me.Gb_SrchBooks.Controls.Add(Me.Bttn_AdvncSrch2)
        Me.Gb_SrchBooks.Controls.Add(Me.Tb_Avail)
        Me.Gb_SrchBooks.Controls.Add(Me.Lbl_Avail)
        Me.Gb_SrchBooks.Controls.Add(Me.Tb_Pub)
        Me.Gb_SrchBooks.Controls.Add(Me.Cb_SrchAcc)
        Me.Gb_SrchBooks.Controls.Add(Me.Tb_Title)
        Me.Gb_SrchBooks.Controls.Add(Me.Lbl_Pub)
        Me.Gb_SrchBooks.Controls.Add(Me.Lbl_SrcA)
        Me.Gb_SrchBooks.Controls.Add(Me.Lbl_Title)
        Me.Gb_SrchBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_SrchBooks.ForeColor = System.Drawing.Color.Lime
        Me.Gb_SrchBooks.Location = New System.Drawing.Point(22, 155)
        Me.Gb_SrchBooks.Name = "Gb_SrchBooks"
        Me.Gb_SrchBooks.Size = New System.Drawing.Size(528, 129)
        Me.Gb_SrchBooks.TabIndex = 26
        Me.Gb_SrchBooks.TabStop = False
        Me.Gb_SrchBooks.Text = "Search Books"
        '
        'Bttn_AdvncSrch2
        '
        Me.Bttn_AdvncSrch2.BackColor = System.Drawing.Color.ForestGreen
        Me.Bttn_AdvncSrch2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bttn_AdvncSrch2.ForeColor = System.Drawing.Color.Lime
        Me.Bttn_AdvncSrch2.Location = New System.Drawing.Point(23, 95)
        Me.Bttn_AdvncSrch2.Name = "Bttn_AdvncSrch2"
        Me.Bttn_AdvncSrch2.Size = New System.Drawing.Size(101, 23)
        Me.Bttn_AdvncSrch2.TabIndex = 29
        Me.Bttn_AdvncSrch2.Text = "Advance Search"
        Me.Bttn_AdvncSrch2.UseVisualStyleBackColor = False
        '
        'Tb_Avail
        '
        Me.Tb_Avail.Location = New System.Drawing.Point(297, 102)
        Me.Tb_Avail.Name = "Tb_Avail"
        Me.Tb_Avail.ReadOnly = True
        Me.Tb_Avail.Size = New System.Drawing.Size(178, 22)
        Me.Tb_Avail.TabIndex = 33
        '
        'Lbl_Avail
        '
        Me.Lbl_Avail.AutoSize = True
        Me.Lbl_Avail.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Avail.Location = New System.Drawing.Point(218, 105)
        Me.Lbl_Avail.Name = "Lbl_Avail"
        Me.Lbl_Avail.Size = New System.Drawing.Size(79, 16)
        Me.Lbl_Avail.TabIndex = 32
        Me.Lbl_Avail.Text = "Availability :"
        '
        'Tb_Pub
        '
        Me.Tb_Pub.Location = New System.Drawing.Point(297, 58)
        Me.Tb_Pub.Name = "Tb_Pub"
        Me.Tb_Pub.ReadOnly = True
        Me.Tb_Pub.Size = New System.Drawing.Size(178, 22)
        Me.Tb_Pub.TabIndex = 31
        '
        'Cb_SrchAcc
        '
        Me.Cb_SrchAcc.FormattingEnabled = True
        Me.Cb_SrchAcc.Location = New System.Drawing.Point(23, 57)
        Me.Cb_SrchAcc.Name = "Cb_SrchAcc"
        Me.Cb_SrchAcc.Size = New System.Drawing.Size(136, 24)
        Me.Cb_SrchAcc.TabIndex = 24
        '
        'Tb_Title
        '
        Me.Tb_Title.Location = New System.Drawing.Point(297, 18)
        Me.Tb_Title.Name = "Tb_Title"
        Me.Tb_Title.ReadOnly = True
        Me.Tb_Title.Size = New System.Drawing.Size(178, 22)
        Me.Tb_Title.TabIndex = 30
        '
        'Lbl_Pub
        '
        Me.Lbl_Pub.AutoSize = True
        Me.Lbl_Pub.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Pub.Location = New System.Drawing.Point(218, 58)
        Me.Lbl_Pub.Name = "Lbl_Pub"
        Me.Lbl_Pub.Size = New System.Drawing.Size(73, 16)
        Me.Lbl_Pub.TabIndex = 29
        Me.Lbl_Pub.Text = "Publisher  :"
        '
        'Lbl_SrcA
        '
        Me.Lbl_SrcA.AutoSize = True
        Me.Lbl_SrcA.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_SrcA.Location = New System.Drawing.Point(20, 40)
        Me.Lbl_SrcA.Name = "Lbl_SrcA"
        Me.Lbl_SrcA.Size = New System.Drawing.Size(174, 16)
        Me.Lbl_SrcA.TabIndex = 22
        Me.Lbl_SrcA.Text = "Search Accession Number :"
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Title.Location = New System.Drawing.Point(218, 18)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_Title.TabIndex = 28
        Me.Lbl_Title.Text = "Title  : "
        '
        'Tp_BrrwHistory
        '
        Me.Tp_BrrwHistory.BackColor = System.Drawing.Color.DarkGreen
        Me.Tp_BrrwHistory.Controls.Add(Me.Dgv_Transactions)
        Me.Tp_BrrwHistory.Location = New System.Drawing.Point(4, 22)
        Me.Tp_BrrwHistory.Name = "Tp_BrrwHistory"
        Me.Tp_BrrwHistory.Padding = New System.Windows.Forms.Padding(3)
        Me.Tp_BrrwHistory.Size = New System.Drawing.Size(632, 484)
        Me.Tp_BrrwHistory.TabIndex = 1
        Me.Tp_BrrwHistory.Text = "Borrow History"
        '
        'Dgv_Transactions
        '
        Me.Dgv_Transactions.AllowUserToAddRows = False
        Me.Dgv_Transactions.AllowUserToDeleteRows = False
        Me.Dgv_Transactions.AllowUserToResizeColumns = False
        Me.Dgv_Transactions.AllowUserToResizeRows = False
        Me.Dgv_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Transactions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.Dgv_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_Transactions.Location = New System.Drawing.Point(16, 26)
        Me.Dgv_Transactions.MultiSelect = False
        Me.Dgv_Transactions.Name = "Dgv_Transactions"
        Me.Dgv_Transactions.ReadOnly = True
        Me.Dgv_Transactions.RowHeadersVisible = False
        Me.Dgv_Transactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_Transactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Transactions.Size = New System.Drawing.Size(597, 437)
        Me.Dgv_Transactions.TabIndex = 30
        Me.Dgv_Transactions.TabStop = False
        '
        'Tp_RtrnBook
        '
        Me.Tp_RtrnBook.BackColor = System.Drawing.Color.DarkGreen
        Me.Tp_RtrnBook.Controls.Add(Me.Label4)
        Me.Tp_RtrnBook.Controls.Add(Me.Dgv_BrrwdBooks)
        Me.Tp_RtrnBook.Controls.Add(Me.Gb_SrchReaderss)
        Me.Tp_RtrnBook.Location = New System.Drawing.Point(4, 22)
        Me.Tp_RtrnBook.Name = "Tp_RtrnBook"
        Me.Tp_RtrnBook.Padding = New System.Windows.Forms.Padding(3)
        Me.Tp_RtrnBook.Size = New System.Drawing.Size(632, 484)
        Me.Tp_RtrnBook.TabIndex = 2
        Me.Tp_RtrnBook.Text = "Return Book"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(22, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Borrowed Books :"
        '
        'Dgv_BrrwdBooks
        '
        Me.Dgv_BrrwdBooks.AllowUserToAddRows = False
        Me.Dgv_BrrwdBooks.AllowUserToDeleteRows = False
        Me.Dgv_BrrwdBooks.AllowUserToResizeColumns = False
        Me.Dgv_BrrwdBooks.AllowUserToResizeRows = False
        Me.Dgv_BrrwdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_BrrwdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_BrrwdBooks.Location = New System.Drawing.Point(25, 243)
        Me.Dgv_BrrwdBooks.MultiSelect = False
        Me.Dgv_BrrwdBooks.Name = "Dgv_BrrwdBooks"
        Me.Dgv_BrrwdBooks.ReadOnly = True
        Me.Dgv_BrrwdBooks.RowHeadersVisible = False
        Me.Dgv_BrrwdBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgv_BrrwdBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_BrrwdBooks.Size = New System.Drawing.Size(591, 184)
        Me.Dgv_BrrwdBooks.TabIndex = 19
        '
        'Gb_SrchReaderss
        '
        Me.Gb_SrchReaderss.BackColor = System.Drawing.Color.DarkGreen
        Me.Gb_SrchReaderss.Controls.Add(Me.Tb_RderID)
        Me.Gb_SrchReaderss.Controls.Add(Me.Label6)
        Me.Gb_SrchReaderss.Controls.Add(Me.Tb_Pnlty)
        Me.Gb_SrchReaderss.Controls.Add(Me.Label5)
        Me.Gb_SrchReaderss.Controls.Add(Me.Bttn_Rturn)
        Me.Gb_SrchReaderss.Controls.Add(Me.Bttn_AdnceSrchRB)
        Me.Gb_SrchReaderss.Controls.Add(Me.Tb_TypeRB)
        Me.Gb_SrchReaderss.Controls.Add(Me.Tb_NameRB)
        Me.Gb_SrchReaderss.Controls.Add(Me.Label1)
        Me.Gb_SrchReaderss.Controls.Add(Me.Label2)
        Me.Gb_SrchReaderss.Controls.Add(Me.Lbl_Reader)
        Me.Gb_SrchReaderss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gb_SrchReaderss.ForeColor = System.Drawing.Color.Lime
        Me.Gb_SrchReaderss.Location = New System.Drawing.Point(25, 39)
        Me.Gb_SrchReaderss.Name = "Gb_SrchReaderss"
        Me.Gb_SrchReaderss.Size = New System.Drawing.Size(591, 170)
        Me.Gb_SrchReaderss.TabIndex = 28
        Me.Gb_SrchReaderss.TabStop = False
        Me.Gb_SrchReaderss.Text = "Search Reader"
        '
        'Tb_RderID
        '
        Me.Tb_RderID.Location = New System.Drawing.Point(111, 116)
        Me.Tb_RderID.Name = "Tb_RderID"
        Me.Tb_RderID.ReadOnly = True
        Me.Tb_RderID.Size = New System.Drawing.Size(92, 22)
        Me.Tb_RderID.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(29, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Reader ID :"
        '
        'Tb_Pnlty
        '
        Me.Tb_Pnlty.Location = New System.Drawing.Point(297, 116)
        Me.Tb_Pnlty.Name = "Tb_Pnlty"
        Me.Tb_Pnlty.ReadOnly = True
        Me.Tb_Pnlty.Size = New System.Drawing.Size(178, 22)
        Me.Tb_Pnlty.TabIndex = 31
        Me.Tb_Pnlty.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(218, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Penalty :"
        '
        'Bttn_Rturn
        '
        Me.Bttn_Rturn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Bttn_Rturn.Location = New System.Drawing.Point(499, 36)
        Me.Bttn_Rturn.Name = "Bttn_Rturn"
        Me.Bttn_Rturn.Size = New System.Drawing.Size(75, 23)
        Me.Bttn_Rturn.TabIndex = 29
        Me.Bttn_Rturn.Text = "Return"
        Me.Bttn_Rturn.UseVisualStyleBackColor = True
        '
        'Bttn_AdnceSrchRB
        '
        Me.Bttn_AdnceSrchRB.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Bttn_AdnceSrchRB.Location = New System.Drawing.Point(24, 55)
        Me.Bttn_AdnceSrchRB.Name = "Bttn_AdnceSrchRB"
        Me.Bttn_AdnceSrchRB.Size = New System.Drawing.Size(101, 23)
        Me.Bttn_AdnceSrchRB.TabIndex = 28
        Me.Bttn_AdnceSrchRB.Text = "Search"
        Me.Bttn_AdnceSrchRB.UseVisualStyleBackColor = True
        '
        'Tb_TypeRB
        '
        Me.Tb_TypeRB.Location = New System.Drawing.Point(297, 76)
        Me.Tb_TypeRB.Name = "Tb_TypeRB"
        Me.Tb_TypeRB.ReadOnly = True
        Me.Tb_TypeRB.Size = New System.Drawing.Size(178, 22)
        Me.Tb_TypeRB.TabIndex = 27
        '
        'Tb_NameRB
        '
        Me.Tb_NameRB.Location = New System.Drawing.Point(297, 36)
        Me.Tb_NameRB.Name = "Tb_NameRB"
        Me.Tb_NameRB.ReadOnly = True
        Me.Tb_NameRB.Size = New System.Drawing.Size(178, 22)
        Me.Tb_NameRB.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(218, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(218, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Name : "
        '
        'Lbl_Reader
        '
        Me.Lbl_Reader.AutoSize = True
        Me.Lbl_Reader.ForeColor = System.Drawing.Color.Lime
        Me.Lbl_Reader.Location = New System.Drawing.Point(21, 36)
        Me.Lbl_Reader.Name = "Lbl_Reader"
        Me.Lbl_Reader.Size = New System.Drawing.Size(129, 16)
        Me.Lbl_Reader.TabIndex = 20
        Me.Lbl_Reader.Text = "Search Readers ID :"
        '
        'Tsp_MainMenu
        '
        Me.Tsp_MainMenu.BackColor = System.Drawing.Color.LightGreen
        Me.ErrPrvder.SetIconAlignment(Me.Tsp_MainMenu, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.Tsp_MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tsp_MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TspB_MngBook, Me.TspB_MngReader, Me.TspB_MngUser, Me.TSB_GenerateReport, Me.TspB_Logout, Me.TspB_Exit})
        Me.Tsp_MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.Tsp_MainMenu.Name = "Tsp_MainMenu"
        Me.Tsp_MainMenu.Size = New System.Drawing.Size(664, 27)
        Me.Tsp_MainMenu.TabIndex = 1
        Me.Tsp_MainMenu.Text = "ToolStrip1"
        '
        'TspB_MngBook
        '
        Me.TspB_MngBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TspB_MngBook.Image = Global.Library.My.Resources.Resources.Img_Bks
        Me.TspB_MngBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TspB_MngBook.Name = "TspB_MngBook"
        Me.TspB_MngBook.Size = New System.Drawing.Size(24, 24)
        Me.TspB_MngBook.Text = "Manage Books"
        '
        'TspB_MngReader
        '
        Me.TspB_MngReader.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TspB_MngReader.Image = Global.Library.My.Resources.Resources.Img_Reader1
        Me.TspB_MngReader.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TspB_MngReader.Name = "TspB_MngReader"
        Me.TspB_MngReader.Size = New System.Drawing.Size(24, 24)
        Me.TspB_MngReader.Text = "Manage Reader"
        '
        'TspB_MngUser
        '
        Me.TspB_MngUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TspB_MngUser.Image = Global.Library.My.Resources.Resources.Img_Userssjpg
        Me.TspB_MngUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TspB_MngUser.Name = "TspB_MngUser"
        Me.TspB_MngUser.Size = New System.Drawing.Size(24, 24)
        Me.TspB_MngUser.Text = "Manage User"
        '
        'TSB_GenerateReport
        '
        Me.TSB_GenerateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_GenerateReport.Image = CType(resources.GetObject("TSB_GenerateReport.Image"), System.Drawing.Image)
        Me.TSB_GenerateReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_GenerateReport.Name = "TSB_GenerateReport"
        Me.TSB_GenerateReport.Size = New System.Drawing.Size(24, 24)
        Me.TSB_GenerateReport.Text = "Generate Report"
        '
        'TspB_Logout
        '
        Me.TspB_Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TspB_Logout.Image = Global.Library.My.Resources.Resources.Img_Logout
        Me.TspB_Logout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TspB_Logout.Name = "TspB_Logout"
        Me.TspB_Logout.Size = New System.Drawing.Size(24, 24)
        Me.TspB_Logout.Text = "Logout"
        '
        'TspB_Exit
        '
        Me.TspB_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TspB_Exit.Image = Global.Library.My.Resources.Resources.Img_Exit
        Me.TspB_Exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TspB_Exit.Name = "TspB_Exit"
        Me.TspB_Exit.Size = New System.Drawing.Size(24, 24)
        Me.TspB_Exit.Text = "Exit Application"
        '
        'ErrPrvder
        '
        Me.ErrPrvder.ContainerControl = Me
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(664, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.Tsp_MainMenu)
        Me.Controls.Add(Me.Tbc_BookRetutn)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(680, 588)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(680, 588)
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library"
        Me.Tbc_BookRetutn.ResumeLayout(False)
        Me.Tp_BrrwBooks.ResumeLayout(False)
        Me.Tp_BrrwBooks.PerformLayout()
        Me.Gb_SrchReaders.ResumeLayout(False)
        Me.Gb_SrchReaders.PerformLayout()
        CType(Me.Dgv_BrwdBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_SrchBooks.ResumeLayout(False)
        Me.Gb_SrchBooks.PerformLayout()
        Me.Tp_BrrwHistory.ResumeLayout(False)
        CType(Me.Dgv_Transactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tp_RtrnBook.ResumeLayout(False)
        Me.Tp_RtrnBook.PerformLayout()
        CType(Me.Dgv_BrrwdBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_SrchReaderss.ResumeLayout(False)
        Me.Gb_SrchReaderss.PerformLayout()
        Me.Tsp_MainMenu.ResumeLayout(False)
        Me.Tsp_MainMenu.PerformLayout()
        CType(Me.ErrPrvder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tbc_BookRetutn As System.Windows.Forms.TabControl
    Friend WithEvents Tp_BrrwBooks As System.Windows.Forms.TabPage
    Friend WithEvents Tp_BrrwHistory As System.Windows.Forms.TabPage
    Friend WithEvents Tsp_MainMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents TspB_MngBook As System.Windows.Forms.ToolStripButton
    Friend WithEvents TspB_MngReader As System.Windows.Forms.ToolStripButton
    Friend WithEvents TspB_Logout As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tp_RtrnBook As System.Windows.Forms.TabPage
    Friend WithEvents Cb_SrchAcc As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_SrchReaders As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_SrcA As System.Windows.Forms.Label
    Friend WithEvents Lbl_SrchR As System.Windows.Forms.Label
    Friend WithEvents Dgv_BrwdBooks As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Bttn_Borrw As System.Windows.Forms.Button
    Friend WithEvents Gb_SrchReaders As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Type As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nme As System.Windows.Forms.Label
    Friend WithEvents Gb_SrchBooks As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_Type As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Name As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Avail As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Avail As System.Windows.Forms.Label
    Friend WithEvents Tb_Pub As System.Windows.Forms.TextBox
    Friend WithEvents Tb_Title As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Pub As System.Windows.Forms.Label
    Friend WithEvents Lbl_Title As System.Windows.Forms.Label
    Friend WithEvents Bttn_AdvncSrch1 As System.Windows.Forms.Button
    Friend WithEvents Bttn_AdvncSrch2 As System.Windows.Forms.Button
    Friend WithEvents TspB_MngUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrPrvder As System.Windows.Forms.ErrorProvider
    Friend WithEvents TspB_Exit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dgv_Transactions As System.Windows.Forms.DataGridView
    Friend WithEvents Gb_SrchReaderss As System.Windows.Forms.GroupBox
    Friend WithEvents Bttn_AdnceSrchRB As System.Windows.Forms.Button
    Friend WithEvents Tb_TypeRB As System.Windows.Forms.TextBox
    Friend WithEvents Tb_NameRB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Reader As System.Windows.Forms.Label
    Friend WithEvents Bttn_Rturn As System.Windows.Forms.Button
    Friend WithEvents Dgv_BrrwdBooks As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tb_Pnlty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tb_RderID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimeDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnOK_DueDate As System.Windows.Forms.Button
    Friend WithEvents TSB_GenerateReport As System.Windows.Forms.ToolStripButton
End Class
