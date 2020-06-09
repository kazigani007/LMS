Imports System.Data.OleDb
Public Class Frm_Usr
    Private dbConnection As New OleDbConnection(Connect)
    Public password As String
    Public user As String
    Public Pnlty As Integer
    'Get Username And Password
    Private Sub getUsrPssword()
        Dim dataAdapter As New OleDbDataAdapter("Select * From User_s", dbConnection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet)
        If dataSet.Tables(0).DefaultView.Count > 0 Then
            user = dataSet.Tables(0).DefaultView.Item(0).Item(0)
            password = dataSet.Tables(0).DefaultView.Item(0).Item(1)
        End If
    End Sub

    Public Sub getpnlty()
        Dim dataAdapter As New OleDbDataAdapter("Select * From Pnalty", dbConnection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet)
        If dataSet.Tables(0).DefaultView.Count > 0 Then
            Pnlty = dataSet.Tables(0).DefaultView.Item(0).Item(0)
        End If
    End Sub

    Private Sub Frm_Usr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getUsrPssword()
        Lbl_Usrname.Text = user
        getpnlty()
        Tb_CPPD.Text = Pnlty
       
    End Sub
    'Confirm Change User Name
    Private Sub Bttn_Cnfrm1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Cnfrm1.Click
        If Tb_NewUser.Text = "" Then
            ErrPrvdr.SetError(Tb_NewUser, "The Username Field is Blank.")
            Exit Sub
        End If
        If Tb_CnfrmPass.Text = password Then
            If MessageBox.Show("Do You Want Change The Username?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            Dim UsrrName As New OleDbCommand("Update User_s Set UserName = '" & Tb_NewUser.Text & "'", dbConnection)
            dbConnection.Open()
            UsrrName.ExecuteNonQuery()
            dbConnection.Close()
            getUsrPssword()
            Lbl_Usrname.Text = user
            Tb_NewUser.ResetText()
            Tb_CnfrmPass.ResetText()
            ErrPrvdr.Clear()
            MessageBox.Show("The Username Has Been Change.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Tb_CnfrmPass.Text = "" Then
            ErrPrvdr.SetError(Tb_CnfrmPass, "The Password Field is Blank.")
        Else
            ErrPrvdr.SetError(Tb_CnfrmPass, "Please Check Your Password.")
        End If
    End Sub

    Private Sub Bttn_Cnfrm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Cnfrm2.Click
        If Tb_CP.Text = password Then
            If Tb_NP.Text <> Tb_CPP.Text Then
                ErrPrvdr.SetError(Tb_CPP, "The Password Does Not Match.")
                Exit Sub
            End If
            If Tb_NP.Text = "" Or Tb_CPP.Text = "" Then
                ErrPrvdr.SetError(Tb_CPP, "The Field is Blank.")
                Exit Sub
            End If

            If MessageBox.Show("Do You Want Change The Password?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            Dim updateCommand As New OleDbCommand("Update User_s Set Psswrd = '" & Tb_CPP.Text & "' ", dbConnection)
            dbConnection.Open()
            updateCommand.ExecuteNonQuery()
            dbConnection.Close()
            getUsrPssword()
            Lbl_CP.ResetText()
            Tb_CP.ResetText()
            Tb_NP.ResetText()
            Tb_CPP.ResetText()
            ErrPrvdr.Clear()
            MessageBox.Show("The Password Has Been Change.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ErrPrvdr.SetError(Tb_CP, "Please Check Your Password")
        End If
    End Sub

    Private Sub Bttn_Cnfrm3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bttn_Cnfrm3.Click
        If Tb_SPPD.Text = "" Then
            ErrPrvdr.SetError(Tb_SPPD, "The Field is Blank")
            Exit Sub
        End If
        If MessageBox.Show("Do You Want Change The Penalty?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim updateCommand As New OleDbCommand("Update Pnalty Set Pnlty = " & Tb_SPPD.Text & " ", dbConnection)
        dbConnection.Open()
        updateCommand.ExecuteNonQuery()
        dbConnection.Close()
        getpnlty()
        Tb_CPPD.Text = Pnlty
        Tb_SPPD.ResetText()
    End Sub

    Private Sub Frm_Usr_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        getpnlty()
        Tb_CPPD.Text = Pnlty

        Frm_Main.Enabled = True
    End Sub
End Class