Imports System.Data.OleDb
Public Class Frm_MngAuth
    'CREATING CONNECTION
    Private db As New OleDbConnection(Connect)
    'FILLING UP DATAGRIDVIEW NAME DgvUnAssigned()
    Private Sub DgvUnAssigned()
        Dim Dgv As New OleDbDataAdapter("SELECT Author_ID as ID , [LastName] +' , '+ [FirstName] as Name FROM Author Where LastName Like '%" & Tb_Srch.Text & "%' or Author_ID Like '%" & Tb_Srch.Text & "%' ; ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        Dgv_Unassigned.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    'DATAGRIDVIEW NAME DgvUnAssigned() SELECTING
    Private Sub DgvUnAssigned_Select()
        Try
            Dim Dgv As New OleDbDataAdapter("SELECT * FROM Author WHERE Author_ID = '" & Dgv_Unassigned.CurrentRow.Cells(0).Value & "'; ", db)
            Dim DtSet As New DataSet
            Dgv.Fill(DtSet)
            If DtSet.Tables(0).DefaultView.Count > 0 Then
                Tb_AID.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
                Tb_FN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(1)
                Tb_LN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            End If
        Catch ex As NullReferenceException
        End Try
    End Sub
    'FILLING UP DATAGRIDVIEW NAME DgvAssigned()
    Private Sub DgvAssigned()
        Dim Dgv As New OleDbDataAdapter("SELECT Author.Author_ID As ID , [Author.LastName] +' , '+ [Author.FirstName] AS Name From Author INNER JOIN BookAuthor ON Author.Author_ID = BookAuthor.Author_ID WHERE BookAuthor.Book_Code = '" & Frm_MngBooks.Tb_BC.Text & "' Order BY LastName ASC", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        Dgv_Assigned.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    'FORM LOAD
    Private Sub Frm_MngAuth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvUnAssigned()
        DgvAssigned()
    End Sub
    'FORM CLOSING
    Private Sub Frm_MngAuth_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Frm_MngBooks.Enabled = True
        Frm_MngBooks.DgvAuthorsE()
    End Sub
    'ADDING AUTHOR
    Private Sub Bttn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Add.Click
        If Bttn_Add.Text = "Add" Then
            Bttn_Add.Text = "Save"
            Bttn_Cncl.Enabled = True
            Bttn_Dlt.Enabled = False
            Bttn_Edt.Enabled = False
            Tb_AID.ReadOnly = False
            Tb_FN.ReadOnly = False
            Tb_LN.ReadOnly = False
            Tb_AID.ResetText()
            Tb_FN.ResetText()
            Tb_LN.ResetText()
            Tb_AID.Focus()
            Dgv_Unassigned.Enabled = False
        ElseIf Bttn_Add.Text = "Save" Then
            If MessageBox.Show("Do You Want To Add This Author?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            ElseIf Tb_FN.Text = "" Or Tb_LN.Text = "" Then
                MessageBox.Show("Please Enter First Name Or Last Name Of The Author.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Try
                If Tb_AID.Text = "" Then
                    MessageBox.Show("Please Enter The Author ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Dim Insrt As New OleDbCommand("INSERT INTO Author Values('" & Tb_AID.Text & "','" & Tb_FN.Text & "','" & Tb_LN.Text & "');", db)
                db.Open()
                Insrt.ExecuteNonQuery()
                db.Close()

                Bttn_Add.Text = "Add"
                Bttn_Cncl.Enabled = False
                Bttn_Dlt.Enabled = True
                Bttn_Edt.Enabled = True
                Tb_AID.ReadOnly = True
                Tb_FN.ReadOnly = True
                Tb_LN.ReadOnly = True
                Dgv_Unassigned.Enabled = True

            Catch ex As OleDb.OleDbException
                db.Close()
                MessageBox.Show("The Author is Already Exist!" & vbNewLine & "Please Check For Author I.D.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            DgvUnAssigned()
        End If
    End Sub
    'EDITING AUTHOR
    Private Sub Bttn_Edt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Edt.Click
        If Bttn_Edt.Text = "Edit" Then
            Bttn_Edt.Text = "Save"
            Bttn_Cncl.Enabled = True
            Bttn_Dlt.Enabled = False
            Bttn_Add.Enabled = False
            Tb_AID.ReadOnly = False
            Tb_FN.ReadOnly = False
            Tb_LN.ReadOnly = False
            Tb_AID.Focus()
            Dgv_Unassigned.Enabled = False
        ElseIf Bttn_Edt.Text = "Save" Then

            If MessageBox.Show("Do You Want To Update This Author?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            ElseIf Tb_FN.Text = "" Or Tb_LN.Text = "" Then
                MessageBox.Show("Please Enter First Name Or Last Name Of The Author.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Tb_AID.Text = "" Then
                MessageBox.Show("Please Enter The Author ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim Updte As New OleDbCommand("UPDATE Author Set Author_ID = '" & Tb_AID.Text & "' , FirstName = '" & Tb_FN.Text & "', LastName = '" & Tb_LN.Text & "' Where Author_ID = '" & Dgv_Unassigned.CurrentRow.Cells(0).Value & "';", db)
            db.Open()
            Updte.ExecuteNonQuery()
            db.Close()

            Bttn_Edt.Text = "Edit"
            Bttn_Cncl.Enabled = False
            Bttn_Dlt.Enabled = True
            Bttn_Add.Enabled = True
            Tb_AID.ReadOnly = True
            Tb_FN.ReadOnly = True
            Tb_LN.ReadOnly = True
            Tb_AID.ResetText()
            Tb_FN.ResetText()
            Tb_LN.ResetText()
            Dgv_Unassigned.Enabled = True
            DgvUnAssigned()
        End If

    End Sub
    'Selection Change
    Private Sub Dgv_Unassigned_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv_Unassigned.SelectionChanged
        DgvUnAssigned_Select()
    End Sub
    'Cancel
    Private Sub Bttn_Cncl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Cncl.Click
        Bttn_Edt.Text = "Edit"
        Bttn_Add.Text = "Add"
        Bttn_Cncl.Enabled = False
        Bttn_Dlt.Enabled = True
        Bttn_Add.Enabled = True
        Bttn_Edt.Enabled = True
        Tb_AID.ReadOnly = True
        Tb_FN.ReadOnly = True
        Tb_LN.ReadOnly = True
        Tb_AID.ResetText()
        Tb_FN.ResetText()
        Tb_LN.ResetText()
        Dgv_Unassigned.Enabled = True
        DgvUnAssigned()
    End Sub
    'Delete Author
    Private Sub Bttn_Dlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Dlt.Click
        If MessageBox.Show("The Selected Author Will Be Deleted. " & vbNewLine & "Do You Want To Proceed?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim Dlt1 As New OleDbCommand("DELETE FROM Author Where Author_ID = '" & Dgv_Unassigned.CurrentRow.Cells(0).Value & "'", db)
        Dim Dlt2 As New OleDbCommand("DELETE FROM BookAuthor Where Author_ID = '" & Dgv_Unassigned.CurrentRow.Cells(0).Value & "'", db)
        db.Open()
        Dlt1.ExecuteNonQuery()
        Dlt2.ExecuteNonQuery()
        db.Close()
        DgvUnAssigned()
        DgvAssigned()
    End Sub
    'Assign Author To Book
    Private Sub Bttn_Assgn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Assgn.Click
        If MessageBox.Show("Do You Want To Assign This Author to The Book? ", "Assign", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Try
                Dim insrtAuthor As New OleDbCommand("INSERT INTO BookAuthor(Book_Code,Author_ID) Values('" & Frm_MngBooks.Tb_BC.Text & "','" & Dgv_Unassigned.CurrentRow.Cells(0).Value & "');", db)
                db.Open()
                insrtAuthor.ExecuteNonQuery()
                db.Close()
                DgvUnAssigned()
                DgvAssigned()
            Catch ex As OleDb.OleDbException
                db.Close()
            End Try
        End If
    End Sub
    'Unassign Author To Book
    Private Sub Bttn_UnAssgn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_UnAssgn.Click
        If MessageBox.Show("Do You Want To Unassigned This Author to The Book? ", "Unassign", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else

            Dim Dlt1 As New OleDbCommand("DELETE FROM BookAuthor Where Author_ID = '" & Dgv_Assigned.CurrentRow.Cells(0).Value & "'", db)
            db.Open()
            Dlt1.ExecuteNonQuery()
            db.Close()
            DgvUnAssigned()
            DgvAssigned()
        End If
    End Sub

    Private Sub Tb_Srch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Srch.TextChanged
        DgvUnAssigned()
    End Sub
End Class