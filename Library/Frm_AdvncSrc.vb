Imports System.Data.OleDb
Public Class Frm_AdvncSrc
    Private db As New OleDbConnection(Connect)

    Private Sub DgvReader()
        Dim Dgv As New OleDbDataAdapter("Select Reader_ID as [Reader ID], ID_Number as [ID Number], [FirstName]+' '+[LastName] as Name , Sex , Type From Reader Where Reader_ID Like '%" & Tb_Srch.Text & "%' or LastName Like '%" & Tb_Srch.Text & "%' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        Dgv_AdvncSrch.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    Private Sub DgvReaderFill()
        Dim Dgv As New OleDbDataAdapter("Select Reader_ID as [Reader ID], ID_Number as [ID Number], [FirstName]+' '+[LastName] as Name , Sex , Type From Reader Where Reader_ID = '" & Dgv_AdvncSrch.CurrentRow.Cells(0).Value & "' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count Then
            Frm_Main.Cb_SrchReaders.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            Frm_Main.Tb_Name.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            Frm_Main.Tb_Type.Text = DtSet.Tables(0).DefaultView.Item(0).Item(4)
        End If
    End Sub
    Private Sub DgvReaderFill2()
        Dim Dgv As New OleDbDataAdapter("Select Reader_ID as [Reader ID], ID_Number as [ID Number], [FirstName]+' '+[LastName] as Name , Sex , Type From Reader Where Reader_ID = '" & Dgv_AdvncSrch.CurrentRow.Cells(0).Value & "' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count Then
            Frm_Main.Tb_RderID.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            Frm_Main.Tb_NameRB.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            Frm_Main.Tb_TypeRB.Text = DtSet.Tables(0).DefaultView.Item(0).Item(4)
        End If
    End Sub

    Private Sub DgvBooks()
        Dim Dgv As New OleDbDataAdapter("Select BookCopies.Accession_Number As [Accession Number], Book.Book_Code as [Book Code] , Book.Book_Title as Title , Book.Book_Publisher as Publisher , BookCopies.Available From Book Inner Join BookCopies On Book.Book_Code = BookCopies.Book_Code Where BookCopies.Accession_Number Like '%" & Tb_Srch.Text & "%' or Book.Book_Title Like '%" & Tb_Srch.Text & "%' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        Dgv_AdvncSrch.DataSource = DtSet.Tables(0).DefaultView
    End Sub

    Private Sub DgvBooksFill()
        Dim Dgv As New OleDbDataAdapter("Select BookCopies.Accession_Number As [Accession Number], Book.Book_Code as [Book Code] , Book.Book_Title as Title , Book.Book_Publisher as Publisher , BookCopies.Available From Book Inner Join BookCopies On Book.Book_Code = BookCopies.Book_Code Where BookCopies.Accession_Number ='" & Dgv_AdvncSrch.CurrentRow.Cells(0).Value & "' ", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count Then
            Frm_Main.Cb_SrchAcc.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            Frm_Main.Tb_Title.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            Frm_Main.Tb_Pub.Text = DtSet.Tables(0).DefaultView.Item(0).Item(3)
            If DtSet.Tables(0).DefaultView.Item(0).Item(4) = "True" Then
                Frm_Main.Tb_Avail.Text = "Yes"
            End If

        End If
    End Sub

    Private Sub Frm_AdvncSrc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If AdvncSrch = 1 Then
            Me.Text = "Readers"
            DgvReader()
        ElseIf AdvncSrch = 2 Then
            Me.Text = "Readers"
            DgvReader()
        Else
            Me.Text = "Books"
            DgvBooks()
        End If
    End Sub

    Private Sub Frm_AdvncSrc_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Frm_Main.Enabled = True
        AdvncSrch = 0
        Frm_Main.dgvBrrwdBooks2()
    End Sub

    Private Sub Tb_Srch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_Srch.TextChanged
        DgvReader()
        DgvBooks()
    End Sub

    Private Sub Bttn_Slct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Slct.Click
        If AdvncSrch = 1 Then
            DgvReaderFill()
        ElseIf AdvncSrch = 2 Then
            DgvReaderFill2()
        Else
            DgvBooksFill()
        End If
        Me.Close()
    End Sub

    Private Sub Dgv_AdvncSrch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dgv_AdvncSrch.DoubleClick
        If AdvncSrch = 1 Then
            DgvReaderFill()
        ElseIf AdvncSrch = 2 Then
            DgvReaderFill2()
        Else
            DgvBooksFill()
        End If
        Me.Close()
    End Sub

End Class