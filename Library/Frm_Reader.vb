Imports System.Data.OleDb
Public Class Frm_Reader
    Private db As New OleDbConnection(Connect)
    'Form Closing
    Private Sub Frm_Reader_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Frm_MngReader.Enabled = True
        Frm_MngReader.DgvReader()
    End Sub
    'Save
    Private Sub Bttn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Save.Click

        If AddEdit = 1 Then
            'Adding Readers Information
            If Tb_FN.Text = "" Or Tb_LN.Text = "" Or Tb_RID.Text = "" Or Tb_NMBR.Text = "" Or Cb_SEX.Text = "" Or Cb_TYP.Text = "" Then
                MessageBox.Show("Do not Leave Any Blank Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If MessageBox.Show("Do You Want To Add This Reader?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                Try
                    Dim insrt As New OleDbCommand("insert into Reader Values('" & Tb_RID.Text & "','" & Tb_NMBR.Text & "','" & Tb_FN.Text & "','" & Tb_LN.Text & "','" & Cb_SEX.Text & "','" & Cb_TYP.Text & "')", db)
                    db.Open()
                    insrt.ExecuteNonQuery()
                    db.Close()
                    MessageBox.Show("Reader Info Has Been Successfully Added", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As OleDb.OleDbException
                    MessageBox.Show("The Reader Is Already Existed Please Check Reader ID", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    db.Close()
                End Try
            End If

        ElseIf AddEdit = 2 Then
            'Editing Readers Information
            Tb_RID.ReadOnly = False
            If Tb_FN.Text = "" Or Tb_LN.Text = "" Or Tb_RID.Text = "" Or Tb_NMBR.Text = "" Or Cb_SEX.Text = "" Or Cb_TYP.Text = "" Then
                MessageBox.Show("Do not Leave Any Blank Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If MessageBox.Show("Do You Want To Save The Changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                    Dim updte As New OleDbCommand("Update Reader Set ID_Number = '" & Tb_NMBR.Text & "', FirstName = '" & Tb_FN.Text & "', LastName = '" & Tb_LN.Text & "', Sex = '" & Cb_SEX.Text & "' , Type = '" & Cb_TYP.Text & "' Where Reader_ID = '" & Tb_RID.Text & "' ", db)
                    db.Open()
                    updte.ExecuteNonQuery()
                    db.Close()
                    MessageBox.Show("Reader Info Has Been Successfully Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Frm_MngReader.DgvReader()
        AddEdit = 0
        Me.Close()
    End Sub

    Private Sub Frm_Reader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class