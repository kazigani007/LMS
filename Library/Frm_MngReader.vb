Imports System.Data.OleDb
Public Class Frm_MngReader

    Private db As New OleDbConnection(Connect)

    'Fill Data GridView
    Public Sub DgvReader()
        Dim Dgv As New OleDbDataAdapter("Select Reader_ID as [Reader ID], ID_Number as [ID Number], [LastName]+' , '+[FirstName] as Name , Sex , Type From Reader  Where Reader_ID Like '%" & TsTb_Srch.Text & "%' or LastName Like '%" & TsTb_Srch.Text & "%'", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        Dgv_Stdnts.DataSource = DtSet.Tables(0).DefaultView
    End Sub
    'Fill Textbox
    Private Sub fillReader()
        Dim Dgv As New OleDbDataAdapter("Select Reader_ID, ID_Number, FirstName , LastName, Sex , Type From Reader  Where Reader_Id = '" & Dgv_Stdnts.CurrentRow.Cells(0).Value & "';", db)
        Dim DtSet As New DataSet
        Dgv.Fill(DtSet)
        If DtSet.Tables(0).DefaultView.Count > 0 Then
            Frm_Reader.Tb_RID.Text = DtSet.Tables(0).DefaultView.Item(0).Item(0)
            Frm_Reader.Tb_NMBR.Text = DtSet.Tables(0).DefaultView.Item(0).Item(1)
            Frm_Reader.Tb_FN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(2)
            Frm_Reader.Tb_LN.Text = DtSet.Tables(0).DefaultView.Item(0).Item(3)
            Frm_Reader.Cb_SEX.Text = DtSet.Tables(0).DefaultView.Item(0).Item(4)
            Frm_Reader.Cb_TYP.Text = DtSet.Tables(0).DefaultView.Item(0).Item(5)
        End If
    End Sub
    'Form Load
    Private Sub Frm_MngReader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DgvReader()
    End Sub
    'Add
    Private Sub Tsb_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tsb_Add.Click
        AddEdit = 1
        Frm_Reader.Show()
        Frm_Reader.Tb_FN.ResetText()
        Frm_Reader.Tb_LN.ResetText()
        Frm_Reader.Tb_NMBR.ResetText()
        Frm_Reader.Tb_RID.ResetText()
        Me.Enabled = False
        Frm_Reader.Text = "Add Reader"
    End Sub
    'Edit
    Private Sub Tsb_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tsb_Edit.Click
        AddEdit = 2
        fillReader()
        Frm_Reader.Tb_RID.ReadOnly = True
        Frm_Reader.Show()
        Frm_Reader.Text = "Edit Reader"
        Me.Enabled = False
    End Sub
    'Delete
    Private Sub Tsb_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tsb_Delete.Click
        If MessageBox.Show("Do You Want To Delete The Selected Reader?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim dlte As New OleDbCommand("Delete From Reader Where Reader_ID = '" & Dgv_Stdnts.CurrentRow.Cells(0).Value & "'", db)
        db.Open()
        dlte.ExecuteNonQuery()
        db.Close()
        DgvReader()
    End Sub
    'Closing
    Private Sub Frm_MngReader_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Frm_Main.DgvBrrwdBooks()
        Frm_Main.DgvHistory()
        Frm_Main.dgvBrrwdBooks2()
    End Sub
    'Search
    Private Sub TsTb_Srch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsTb_Srch.TextChanged
        DgvReader()
    End Sub
End Class