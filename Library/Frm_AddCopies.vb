Imports System.Data.OleDb
Public Class Frm_AddCopies
    Private db As New OleDbConnection(Connect)
    'Adding Copies
    Private Sub addcopies()
        Try
            Dim insrtCopies As New OleDbCommand("Insert Into BookCopies Values('" & Tb_AN.Text & "','" & Frm_MngBooks.Tb_BC.Text & "',YES)", db)
            db.Open()
            insrtCopies.ExecuteNonQuery()
            db.Close()
            Frm_MngBooks.DgvBookCopies()
            MessageBox.Show("The Book Has Been Successfully Added", "Successfully Added ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As OleDb.OleDbException
            db.Close()
            MessageBox.Show("The Book is Already Exist!" & vbNewLine & "Please Check For Accession Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    'Adding Button
    Private Sub Bttn_AddCop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_AddCop.Click
        addcopies()
        NofBooksCopies += 1
    End Sub
    'Form Load
    Private Sub Frm_AddCopies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Frm_MngBooks.Dgv_Books.CurrentRow.Cells(1).Value
    End Sub

    Private Sub Tb_AN_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tb_AN.KeyDown
        If e.KeyCode = Keys.Enter Then
            addcopies()
        End If
    End Sub

    
End Class