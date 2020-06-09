﻿Imports System.Data.OleDb
Public Class Frm_MngBooks

    Private dbConnection As New OleDbConnection(Connect)
    'Filling Up DgvBooks
    Private Sub DgvBooks()
        Dim dataAdapter As New OleDbDataAdapter("Select Book_Code As [Book Code] , Book_Title As [Book Title] From Book;", dbConnection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet)
        Dgv_Books.DataSource = dataSet.Tables(0).DefaultView
    End Sub
    'Filling Up DgvBookCopies
    Public Sub DgvBookCopies()
        Try
            Dim dataAdapter As New OleDbDataAdapter("Select Accession_Number As [Accession Number] From BookCopies Where Book_Code = '" & Dgv_Books.CurrentRow.Cells(0).Value & "';", dbConnection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet)
            Dgv_BookCopies.DataSource = dataSet.Tables(0).DefaultView
        Catch ex As NullReferenceException
        End Try
    End Sub
    'Filling Up DgvAuthors
    Private Sub DgvAuthors()
        Try
            Dim dataAdapter As New OleDbDataAdapter("SELECT Author.Author_ID AS ID, [Author.LastName] +' , '+ [Author.FirstName] AS Name FROM Author Inner Join BookAuthor On Author.Author_ID = BookAuthor.Author_ID Where BookAuthor.Book_Code = '" & Dgv_Books.CurrentRow.Cells(0).Value & "';", dbConnection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet)
            Dgv_Authors.DataSource = dataSet.Tables(0).DefaultView
        Catch ex As NullReferenceException
        End Try
    End Sub
    'Current Authors
    Public Sub DgvAuthorsE()
        Dim dataAdapter As New OleDbDataAdapter("SELECT Author.Author_ID AS ID, [Author.LastName] +' , '+ [Author.FirstName] AS Name FROM Author Inner Join BookAuthor On Author.Author_ID = BookAuthor.Author_ID Where BookAuthor.Book_Code = '" & Tb_BC.Text & "';", dbConnection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet)
        Dgv_Authors.DataSource = dataSet.Tables(0).DefaultView
    End Sub
    'Selection Fill to TxtBox
    Private Sub FillSelect()
        Try
            Dim dataAdapter As New OleDbDataAdapter("Select * From Book Where Book_Code = '" & Dgv_Books.CurrentRow.Cells(0).Value & "';", dbConnection)
            Dim dataSet As New DataSet
            dataAdapter.Fill(dataSet)
            If dataSet.Tables(0).DefaultView.Count > 0 Then
                Tb_BC.Text = dataSet.Tables(0).DefaultView.Item(0).Item(0)
                Tb_Ttl.Text = dataSet.Tables(0).DefaultView.Item(0).Item(1)
                Tb_Pb.Text = dataSet.Tables(0).DefaultView.Item(0).Item(2)
                Dtp_DtPb.Text = dataSet.Tables(0).DefaultView.Item(0).Item(3)
            End If
        Catch ex As NullReferenceException

        End Try
    End Sub
    'Search Box
    Private Sub DgvSrch()
        Dim dataAdapter As New OleDbDataAdapter("Select Book_Code As [Book Code] , Book_Title As [Book Title] From Book Where Book_Code Like '%" & Tb_Srch.Text & "%' or Book_Title Like '%" & Tb_Srch.Text & "%';", dbConnection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet)
        Dgv_Books.DataSource = dataSet.Tables(0).DefaultView
    End Sub
    'Selection Changed DgvBooks
    Private Sub Dgv_Books_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv_Books.SelectionChanged
        DgvBookCopies()
        DgvAuthors()
        FillSelect()
    End Sub
    'Form Load
    Private Sub Frm_MngBooks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvBooks()
    End Sub
    'Open Manage Authors
    Private Sub Tb_Auth_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_Auth.LinkClicked
        If Tb_BC.Text = "" Then
            MessageBox.Show("Please Enter the Book Code " & vbNewLine & "Before Managing the Authors", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            DgvAuthorsE()
            Me.Enabled = False
            Frm_MngAuth.Show()
        End If
    End Sub
    'Adding Books
    Private Sub Bttn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Add.Click
        If Bttn_Add.Text = "Add Book" Then
            Bttn_Add.Text = "Save Book"
            Bttn_Cncl.Enabled = True
            Bttn_Dlt.Enabled = False
            Bttn_Edt.Enabled = False
            Bttn_AddCop.Enabled = False
            Bttn_DltCop.Enabled = False
            Tb_BC.ReadOnly = False
            Tb_Ttl.ReadOnly = False
            Tb_Pb.ReadOnly = False
            Link_Auth.Enabled = True
            Dtp_DtPb.Enabled = True
            Tb_BC.ResetText()
            Tb_Ttl.ResetText()
            Tb_Pb.ResetText()
            Dtp_DtPb.Text = Now
            Dgv_BookCopies.Enabled = False
            Dgv_Books.Enabled = False
            DgvAuthorsE()
        ElseIf Bttn_Add.Text = "Save Book" Then
            If Tb_BC.Text = "" Or Tb_Pb.Text = "" Or Tb_Ttl.Text = "" Then
                MessageBox.Show("Do not leave any blank fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                If MessageBox.Show("Do You Want To Add This Book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Try

                    Dim InsrtBook As New OleDbCommand("Insert Into Book Values('" & Tb_BC.Text & "','" & Tb_Ttl.Text & "','" & Tb_Pb.Text & "',#" & Dtp_DtPb.Text & "#)", dbConnection)
                    'Dim InsrtBookCopies As New OleDbCommand("Insert Into BookCopies Values('" & Tb_AN.Text & "','" & Tb_BC.Text & "',Yes);", db)
                    dbConnection.Open()
                    InsrtBook.ExecuteNonQuery()
                    'InsrtBookCopies.ExecuteNonQuery()
                    dbConnection.Close()

                    Bttn_Add.Text = "Add Book"
                    Bttn_Cncl.Enabled = False
                    Bttn_Dlt.Enabled = True
                    Bttn_Edt.Enabled = True
                    Bttn_AddCop.Enabled = True
                    Bttn_DltCop.Enabled = True
                    Tb_BC.ReadOnly = True
                    Tb_Ttl.ReadOnly = True
                    Tb_Pb.ReadOnly = True
                    Link_Auth.Enabled = False
                    Dtp_DtPb.Enabled = False
                    Dgv_BookCopies.Enabled = True
                    Dgv_Books.Enabled = True

                    NoofBooks += 1

                Catch ex As OleDb.OleDbException
                    dbConnection.Close()
                    MessageBox.Show("The Book is Already Exist!" & vbNewLine & "Please Check For Author I.D.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                DgvAuthors()
                DgvBookCopies()
                DgvBooks()
                FillSelect()
            End If
        End If
    End Sub
    'Cancel
    Private Sub Bttn_Cncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Cncl.Click
        Dim cmdDeleteBookAuthor As New OleDbCommand("Delete From BookAuthor Where Book_Code = '" & Tb_BC.Text & "';", dbConnection)
        dbConnection.Open()
        cmdDeleteBookAuthor.ExecuteNonQuery()
        dbConnection.Close()
        Bttn_Add.Text = "Add Book"
        Bttn_Edt.Text = "Edit Book"
        Bttn_Add.Enabled = True
        Bttn_Cncl.Enabled = False
        Bttn_Dlt.Enabled = True
        Bttn_Edt.Enabled = True
        Bttn_AddCop.Enabled = True
        Bttn_DltCop.Enabled = True
        Tb_BC.ReadOnly = True
        Tb_Ttl.ReadOnly = True
        Tb_Pb.ReadOnly = True
        Link_Auth.Enabled = False
        Dtp_DtPb.Enabled = False
        Dgv_BookCopies.Enabled = True
        Dgv_Books.Enabled = True
        DgvAuthors()
        DgvBookCopies()
        DgvBooks()
    End Sub
    'Edit
    Private Sub Bttn_Edt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Edt.Click
        If Bttn_Edt.Text = "Edit Book" Then
            Bttn_Edt.Text = "Save Book"
            Bttn_Add.Enabled = False
            Bttn_AddCop.Enabled = False
            Bttn_Dlt.Enabled = False
            Bttn_DltCop.Enabled = False
            Bttn_Cncl.Enabled = True
            Tb_Pb.ReadOnly = False
            Tb_Ttl.ReadOnly = False
            Link_Auth.Enabled = True
            Dtp_DtPb.Enabled = True
            Dgv_BookCopies.Enabled = False
            Dgv_Books.Enabled = False

        ElseIf Bttn_Edt.Text = "Save Book" Then
            If MessageBox.Show("Do You Want To Edit This Book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim update As New OleDbCommand("Update Book Set Book_Title = '" & Tb_Ttl.Text & "', Book_Publisher = '" & Tb_Pb.Text & "' , Book_DatePublished = #" & Dtp_DtPb.Text & "# Where Book_Code = '" & Tb_BC.Text & "'", dbConnection)
            dbConnection.Open()
            update.ExecuteNonQuery()
            dbConnection.Close()
            Bttn_Edt.Text = "Edit Book"
            Bttn_Add.Enabled = True
            Bttn_AddCop.Enabled = True
            Bttn_Dlt.Enabled = True
            Bttn_DltCop.Enabled = True
            Bttn_Cncl.Enabled = False
            Tb_Pb.ReadOnly = True
            Tb_Ttl.ReadOnly = True
            Link_Auth.Enabled = False
            Dtp_DtPb.Enabled = False
            Dgv_BookCopies.Enabled = True
            Dgv_Books.Enabled = True

            DgvAuthors()
            DgvBookCopies()
            DgvBooks()
            FillSelect()
        End If
    End Sub
    'adding Copies
    Private Sub Bttn_AddCop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_AddCop.Click
        Frm_AddCopies.Show()
    End Sub

    Private Sub Bttn_DltCop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_DltCop.Click
        Dim accession As String = ""
        Dim avail As String = ""

        Dim dataAdapter As New OleDbDataAdapter("SELECT *  FROM BookCopies WHERE Accession_Number = '" & Me.Dgv_BookCopies.CurrentRow.Cells(0).Value & "';", dbConnection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet)
        If dataSet.Tables(0).DefaultView.Count > 0 Then
            accession = dataSet.Tables(0).DefaultView.Item(0).Item(0)
            avail = dataSet.Tables(0).DefaultView.Item(0).Item(2)
        End If

        If (avail = "false" Or avail = "False") Then
            MessageBox.Show("You cannot delete the book copy that has been borrowed.")
        Else
            'code


            If MessageBox.Show("Do You Want To Delete This Copy?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Try
                Dim dleteCopies As New OleDbCommand("DELETE From BookCopies Where Accession_Number = '" & Dgv_BookCopies.CurrentRow.Cells(0).Value & "'", dbConnection)
                dbConnection.Open()
                dleteCopies.ExecuteNonQuery()
                dbConnection.Close()
                DgvBookCopies()

                NofBooksCopies -= 1
            Catch ex As NullReferenceException
            End Try

            'code end
        End If
    End Sub

    Private Sub Tb_Srch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Srch.TextChanged
        DgvBookCopies()
        DgvSrch()
        DgvAuthors()
    End Sub

    Private Sub Bttn_Dlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Dlt.Click
        Dim accession As String = ""
        Dim avail As String = ""
        Dim ctr As Integer = 0


        Try
            Dim dataAdapter As New OleDbDataAdapter("SELECT *  FROM BookCopies WHERE Accession_Number = '" & Me.Dgv_BookCopies.CurrentRow.Cells(0).Value & "';", dbConnection)
            Dim Dtset As New DataSet
            dataAdapter.Fill(Dtset)
            If Dtset.Tables(0).DefaultView.Count > 0 Then
                accession = Dtset.Tables(0).DefaultView.Item(0).Item(0)
                avail = Dtset.Tables(0).DefaultView.Item(0).Item(2)
            End If

        Catch ex As Exception

        End Try

        ctr = Me.Dgv_BookCopies.RowCount.ToString()

        If ctr = 0 Then
            'code
            Dim copies As Integer = 0

            If MessageBox.Show("Do You Want To Delete This Book?" & vbNewLine & "All Copies of The Book Will Be Deleted.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim dleteBook As New OleDbCommand("Delete From Book Where Book_Code = '" & Tb_BC.Text & "'", dbConnection)
            Dim dleteCopies As New OleDbCommand("Delete From BookCopies Where Book_Code = '" & Tb_BC.Text & "'", dbConnection)
            Dim dleteAuthors As New OleDbCommand("Delete From BookAuthor Where Book_Code = '" & Tb_BC.Text & "'", dbConnection)
            dbConnection.Open()
            dleteBook.ExecuteNonQuery()
            dleteCopies.ExecuteNonQuery()
            dleteAuthors.ExecuteNonQuery()
            dbConnection.Close()
            MessageBox.Show("Succesfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            NoofBooks -= 1

            copies = Me.Dgv_BookCopies.RowCount.ToString()

            NofBooksCopies -= copies


            DgvBooks()
            DgvBookCopies()
            DgvAuthors()

            'code end
        ElseIf (avail = "false" Or avail = "False") Then
            MessageBox.Show("You cannot delete the Book. One or more copy of Book has/have been borrowed.")

        Else
            'code
            Dim copies As Integer = 0

            If MessageBox.Show("Do You Want To Delete This Book?" & vbNewLine & "All Copies of The Book Will Be Deleted.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim dleteBook As New OleDbCommand("Delete From Book Where Book_Code = '" & Tb_BC.Text & "'", dbConnection)
            Dim dleteCopies As New OleDbCommand("Delete From BookCopies Where Book_Code = '" & Tb_BC.Text & "'", dbConnection)
            Dim dleteAuthors As New OleDbCommand("Delete From BookAuthor Where Book_Code = '" & Tb_BC.Text & "'", dbConnection)
            dbConnection.Open()
            dleteBook.ExecuteNonQuery()
            dleteCopies.ExecuteNonQuery()
            dleteAuthors.ExecuteNonQuery()
            dbConnection.Close()
            MessageBox.Show("Succesfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            NoofBooks -= 1

            copies = Me.Dgv_BookCopies.RowCount.ToString()

            NofBooksCopies -= copies


            DgvBooks()
            DgvBookCopies()
            DgvAuthors()

            'code end

        End If
    End Sub

    Private Sub Frm_MngBooks_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Frm_Main.DgvBrrwdBooks()
        Frm_Main.DgvHistory()
        Frm_Main.dgvBrrwdBooks2()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
