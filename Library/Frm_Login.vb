Imports System.Data.OleDb
Public Class Frm_Login
    Private db As New OleDbConnection(Connect)
    'Login
    Private Sub Login()
        Dim Dgv As New OleDbDataAdapter("Select * From User_s Where UserName = '" & Tb_UserName.Text & "' And Psswrd = '" & Tb_Pass.Text & "';", db)
        Dim Dtset As New DataSet
        Dgv.Fill(Dtset)
        If Dtset.Tables(0).DefaultView.Count > 0 Then
            Me.Hide()
            Frm_Main.Show()
        ElseIf Tb_UserName.Text = "" Then
            ErrPrvdr.SetError(Tb_UserName, "Username Field Cannot Be Left Empty")
        Else
            MessageBox.Show("Username And/Or Password Are Invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    'Login Button
    Private Sub Bttn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Login.Click
        Login()
    End Sub
    'Enter keys
    Private Sub Tb_Pass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tb_Pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub
End Class