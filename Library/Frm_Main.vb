Imports System.Data.OleDb
Public Class Frm_Main

    Private db As New OleDbConnection(Connect)
    Public penalty = 10

    'fill dataGridView
    Public Sub DgvBrrwdBooks()
        Dim Dgv As New OleDbDataAdapter("Select BorrowTransActions.Accession_Number As [Accession Number], Book.Book_Title as [Book Title] , BorrowTransActions.Trans_Date As [Transaction Date] , BorrowTransActions.Due_Date As [Due Date] " &
                                        " From (BorrowTransActions Inner Join BookCopies On BookCopies.Accession_Number = BorrowTransActions.Accession_Number) Inner Join Book On Book.Book_Code = BookCopies.Book_Code" &
                                        " Where BorrowTransActions.Reader_ID = '" & Cb_SrchReaders.Text & "' And BorrowTransActions.Return_Date Is Null ; ", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        Dgv_BrwdBooks.DataSource = Dtset.Tables(0).DefaultView
    End Sub
    'fill dataGridView
    Public Sub DgvHistory()
        Dim Dgv As New OleDbDataAdapter("Select BorrowTransActions.Accession_Number As [Accession Number], Book.Book_Title as [Book Title], [Reader.LastName] + ' , ' +  [Reader.FirstName ] as [Name] , BorrowTransActions.Trans_Date As [Transaction Date] , BorrowTransActions.Due_Date As [Due Date],  BorrowTransActions.Return_Date as [Return Date], BorrowTransActions.Penalty " &
                                        " From ((BorrowTransActions Inner Join BookCopies On BookCopies.Accession_Number = BorrowTransActions.Accession_Number) Inner Join Book On Book.Book_Code = BookCopies.Book_Code)Inner Join Reader On Reader.Reader_ID = BorrowTransActions.Reader_ID", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        Dgv_Transactions.DataSource = Dtset.Tables(0).DefaultView
    End Sub
    'fill dataGridview
    Public Sub dgvBrrwdBooks2()
        Dim Dgv As New OleDbDataAdapter("Select BorrowTransActions.Accession_Number As [Accession Number], Book.Book_Title as [Book Title] , BorrowTransActions.Trans_Date As [Transaction Date] , BorrowTransActions.Due_Date As [Due Date] ,  BorrowTransActions.Return_Date as [Return Date]  " &
                                      " From (BorrowTransActions Inner Join BookCopies On BookCopies.Accession_Number = BorrowTransActions.Accession_Number) Inner Join Book On Book.Book_Code = BookCopies.Book_Code" &
                                      " Where BorrowTransActions.Reader_ID = '" & Tb_RderID.Text & "' and  BorrowTransActions.Return_Date Is Null ;", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        Dgv_BrrwdBooks.DataSource = Dtset.Tables(0).DefaultView
    End Sub
    'fill ComboBox
    Public Sub fillCbox()
        'Fill Cb_SrchReaders
        Dim Dgv1 As New OleDbDataAdapter("SELECT Reader_ID  FROM Reader;", db)
        Dim Dtset1 As New DataSet
        Dgv1.Fill(Dtset1)
        Cb_SrchReaders.DataSource = Dtset1.Tables(0).DefaultView
        Cb_SrchReaders.ValueMember = "Reader_ID"
        'Fill Cb_SrcAcc
        Dim Dgv2 As New OleDbDataAdapter("SELECT Accession_Number  FROM BookCopies;", db)
        Dim Dtset2 As New DataSet
        Dgv2.Fill(Dtset2)
        Cb_SrchAcc.DataSource = Dtset2.Tables(0).DefaultView
        Cb_SrchAcc.ValueMember = "Accession_Number"
    End Sub
    'Load
    Private Sub Frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillCbox()
        Cb_SrchAcc.ResetText()
        Cb_SrchReaders.ResetText()
        Tb_Name.ResetText()
        Tb_Type.ResetText()
        Tb_Title.ResetText()
        Tb_Pub.ResetText()
        Tb_Avail.ResetText()
        DgvBrrwdBooks()
        Tb_RderID.ResetText()
        Frm_Usr.getpnlty()
        Frm_Usr.Tb_CPPD.Text = Frm_Usr.Pnlty
    End Sub
    'FillTextBoxesSearchReaders
    Private Sub Cb_SrchReaders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_SrchReaders.SelectedIndexChanged
        Dim Dgv As New OleDbDataAdapter("SELECT [FirstName] + ' ' + [LastName] as Name , Type  FROM Reader Where Reader_ID = '" & Cb_SrchReaders.Text & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            Tb_Name.Text = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            Tb_Type.Text = Dtset.Tables(0).DefaultView.Item(0).Item(1)
        End If
        ErrPrvder.Clear()
        DgvBrrwdBooks()
    End Sub
    'FillTextBoxesSearchBooks
    Private Sub Cb_SrchAcc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_SrchAcc.SelectedIndexChanged
        Dim Dgv As New OleDbDataAdapter("SELECT Book.Book_Title, Book.Book_Publisher , BookCopies.Available From Book Inner Join BookCopies On BookCopies.Book_Code = Book.Book_Code Where Accession_Number = '" & Cb_SrchAcc.Text & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            Tb_Title.Text = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            Tb_Pub.Text = Dtset.Tables(0).DefaultView.Item(0).Item(1)
            If Dtset.Tables(0).DefaultView.Item(0).Item(2) = "True" Then
                Tb_Avail.Text = "Yes"
            Else
                Tb_Avail.Text = "No"
            End If

        End If
        ErrPrvder.Clear()
    End Sub
    'Button Borrow
    Private Sub Bttn_Borrw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Borrw.Click
        If Tb_Avail.Text = "No" Then
            MessageBox.Show("The Book is Not Available ","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
            Exit Sub
       
        Else
            If Cb_SrchReaders.Text = "" And Cb_SrchReaders.Text = "" Then
                ErrPrvder.SetError(Cb_SrchReaders, "Please Select A Reader")
                Exit Sub
            End If
            If Cb_SrchAcc.Text = "" And Cb_SrchAcc.Text = "" Then
                ErrPrvder.SetError(Cb_SrchAcc, "Please Select A Book")
                Exit Sub
            End If
            If MessageBox.Show("This Book Will Be Borrowed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim insrtBrrw As New OleDbCommand("Insert Into BorrowTransActions(Accession_Number,Reader_ID,Trans_Date,Due_Date) Values('" & Cb_SrchAcc.Text & "','" & Cb_SrchReaders.Text & "',#" & Date.Today & "#,#" & Today.AddDays(3) & "#)", db)
        Dim updteAvail As New OleDbCommand("Update BookCopies Set Available = No Where Accession_Number = '" & Cb_SrchAcc.Text & "' ", db)
        db.Open()
        insrtBrrw.ExecuteNonQuery()
        updteAvail.ExecuteNonQuery()
        db.Close()
        Cb_SrchAcc.ResetText()
        Tb_Title.ResetText()
        Tb_Pub.ResetText()
        Tb_Avail.ResetText()
        DgvBrrwdBooks()
        MessageBox.Show("The Book Has Been Successfully Borrowed", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub
    'Form closing
    Private Sub Frm_Main_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Frm_Login.Show()
        Frm_Login.Tb_Pass.ResetText()
    End Sub
    'Advance search Readers
    Private Sub Bttn_AdvncSrch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_AdvncSrch1.Click
        AdvncSrch = 1
        Me.Enabled = False
        Frm_AdvncSrc.Visible = True
    End Sub
    'Advance search Book
    Private Sub Bttn_AdvncSrch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_AdvncSrch2.Click
        Me.Enabled = False
        Frm_AdvncSrc.Visible = True
    End Sub
    'Show MngBook
    Private Sub TspB_MngBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TspB_MngBook.Click
        Frm_MngBooks.Show()
    End Sub
    'Show MngREader
    Private Sub TspB_MngReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TspB_MngReader.Click
        Frm_MngReader.Show()
    End Sub
    'Logout
    Private Sub TspB_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TspB_Logout.Click
        If MessageBox.Show("Do You Want To Logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Me.Close()
        Frm_Login.Show()
        Frm_Login.Tb_Pass.ResetText()
    End Sub
    'Exit Application
    Private Sub TspB_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TspB_Exit.Click
       
            If MessageBox.Show("Do You Want To Exit Application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Me.Close()

       
        
    End Sub
    'Borrow History Fill
    Private Sub Tp_BrrwHistory_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tp_BrrwHistory.Enter
        DgvHistory()
    End Sub
    'fill textboxes ReaderRB
    Private Sub Cb_ReaderRB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dgv As New OleDbDataAdapter("SELECT [Reader.FirstName] + ' ' + [Reader.LastName] as Name ,  Reader.Type,BorrowTransActions.Due_Date as [Due Date] FROM Reader Inner Join BorrowTransActions On BorrowTransActions.Reader_ID = Reader.Reader_ID  Where Reader.Reader_ID = '" & Tb_RderID.Text & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            Tb_NameRB.Text = Dtset.Tables(0).DefaultView.Item(0).Item(0)
            Tb_TypeRB.Text = Dtset.Tables(0).DefaultView.Item(0).Item(1)
        End If
        dgvBrrwdBooks2()
    End Sub
    'AdvnceSrchRB
    Private Sub Bttn_AdnceSrchRB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_AdnceSrchRB.Click
        AdvncSrch = 2
        Me.Enabled = False
        Frm_AdvncSrc.Visible = True
    End Sub
    'Enter Book Return
    Private Sub Tbc_BookTransactions_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbc_BookRetutn.Enter
        Tb_RderID.ResetText()
        Tb_RderID.ResetText()
    End Sub
    'Return
    Private Sub Bttn_Rturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Rturn.Click
        If Tb_Pnlty.Text <> "None" Then
            MessageBox.Show("The Reader Have A Penalty of " & Tb_Pnlty.Text & " Pesos ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If Tb_NameRB.Text = "" Or Tb_TypeRB.Text = "" Then
            Exit Sub
        End If
        Try
            Dim updte As New OleDbCommand("Update BorrowTransActions Set Return_Date  = #" & Date.Now & "# , Penalty = " & Tb_Pnlty.Text & " Where Accession_Number = '" & Dgv_BrrwdBooks.CurrentRow.Cells(0).Value & "'", db)
            Dim updteAvail As New OleDbCommand("Update BookCopies Set Available = Yes Where Accession_Number = '" & Dgv_BrrwdBooks.CurrentRow.Cells(0).Value & "' ", db)
            db.Open()
            updte.ExecuteNonQuery()
            updteAvail.ExecuteNonQuery()
            db.Close()
            DgvBrrwdBooks()
            dgvBrrwdBooks2()
            MessageBox.Show("The Book Has Been SuccessFully Returned ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As NullReferenceException
            MessageBox.Show("No Borrowed Books", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TspB_MngUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TspB_MngUser.Click
        Frm_Usr.Show()
        Me.Enabled = False
    End Sub

    Public Sub Pnlty()
        Try
            Dim duedate As Date = Dgv_BrrwdBooks.CurrentRow.Cells(3).Value
            Dim dteNow As Date = Now
            Dim day As Integer = dteNow.Subtract(duedate).TotalDays
            If day > 0 Then
                Tb_Pnlty.Text = day * Frm_Usr.Tb_CPPD.Text
            Else
                Tb_Pnlty.Text = "0"
            End If
        Catch ex As InvalidCastException
        End Try
    End Sub

    Private Sub Dgv_BrrwdBooks_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv_BrrwdBooks.SelectionChanged
        Pnlty()
    End Sub

    Private Sub Tp_RtrnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tp_RtrnBook.Click
        Tb_RderID.ResetText()
    End Sub

    Private Sub BtnOK_DueDate_Click(sender As Object, e As EventArgs) Handles BtnOK_DueDate.Click
        Dim DueDate As New Date(DateTimeDueDate.Value.Year, DateTimeDueDate.Value.Month, DateTimeDueDate.Value.Day)
        Dim transDate As Date = Me.Dgv_BrwdBooks.CurrentRow.Cells(3).Value

        If DueDate < transDate Then
            MessageBox.Show("Invalid Due Date")
            DateTimeDueDate.Value = Now

        Else


            Dim UpDueDate As New OleDbCommand("Update BorrowTransActions Set Due_Date = #" & DueDate & "# Where Accession_Number = '" & Me.Dgv_BrwdBooks.CurrentRow.Cells(0).Value & "' ", db)
            db.Open()
            UpDueDate.ExecuteNonQuery()
            db.Close()

            DgvBrrwdBooks()

        End If



    End Sub

    
    Private Sub TSB_GenerateReport_Click(sender As Object, e As EventArgs) Handles TSB_GenerateReport.Click
        Generate_Report.Show()
    End Sub
End Class