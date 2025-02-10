Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Login_master
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Please enter the value")
        Else
            cn.Open()
            Dim i As Integer
            txtusername.Focus()
            Dim cmd As New OleDbCommand("select  count(* ) from Login where Username='" & txtusername.Text & "' and  Password='" & txtpassword.Text & "' ", cn)
            i = cmd.ExecuteScalar
            If (i = 1) Then
                Me.Hide()
                main_form.Show()
                MsgBox("Login Successfull.......", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Login Fail", MsgBoxStyle.OkOnly = MsgBoxStyle.AbortRetryIgnore)

            End If
            cn.Close()
        End If
    End Sub

    Private Sub btnCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCANCEL.Click
        Me.Close()
    End Sub

    Private Sub Login_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
