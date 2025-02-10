Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Transection
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")
    Dim dr As OleDbDataReader
    Dim mytable As DataTable
    Dim rownumber As Integer
    Dim myrow As Data.DataRow
    Dim ds As New DataSet()
    Dim da As New OleDbDataAdapter
    Dim b As Double
    Public Sub get_no()
        Try
            cn.Open()
            Dim no As Integer
            Dim cmd As New OleDbCommand("select count(*) from Transection", cn)
            no = cmd.ExecuteScalar

            If (no = 0) Then
                cmbAccno.Text = 1
            Else
                cmbAccno.Text = no + 1
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub show1()
        Dim da As New OleDbDataAdapter("select * from Transection", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Public Sub textblank()
        cmbAccno.Text = ""
        txtFat.Text = ""
        txtTotal_Milk.Text = ""
        txtAmount.Text = ""
    End Sub

    Private Sub btnNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEW.Click
        'Call textblank()
        get_no()
    End Sub

    Private Sub btnINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINSERT.Click
        Try
            cn.Open()
            Dim no As Integer

            If cmbAccno.Text = "" Or DateTimePicker1.Text = "" Or txtFat.Text = "" Or txtTotal_Milk.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                Dim cmd1 As New OleDbCommand("select * from Transection where Accno=" & Trim(cmbAccno.Text) & " ", cn)
                dr = cmd1.ExecuteReader
                If dr.Read Then
                    no = dr(0)
                End If
                If (no = cmbAccno.Text) Then
                    MsgBox("This Acc_no is Exist= " & cmbAccno.Text)
                    cmbAccno.Focus()
                Else

                    Dim cmd As New OleDbCommand("insert into Transection values(" & cmbAccno.Text & ", " & txtFat.Text & "," & txtTotal_Milk.Text & "," & txtAmount.Text & ",'" & DateTimePicker1.Value.Date & "' ) ", cn)
                    cmd.ExecuteNonQuery()
                    'Call textblank()
                    show1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        MsgBox("insert successful completed")
        Call textblank()
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Try
            cn.Open()
            Dim cmd As New OleDbCommand("delete from Transection where Accno=" & cmbAccno.Text & " ", cn)
            cmd.ExecuteNonQuery()
            show1()
            MsgBox("Delete successful completed")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call textblank()
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        Try
            If cmbAccno.Text = "" Or DateTimePicker1.Text = "" Or txtFat.Text = "" Or txtTotal_Milk.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                cn.Open()
                Dim cmd As New OleDbCommand("update Transection set Fat=" & Trim(txtFat.Text) & ",Total_Milk=" & Trim(txtTotal_Milk.Text) & ",Amount=" & Trim(txtAmount.Text) & ",Paydate='" & DateTimePicker1.Value.Date & "' where  Accno=" & cmbAccno.Text & " ", cn)
                cmd.ExecuteNonQuery()
                Call textblank()
                show1()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmbAccno.Enabled = True
        DataGridView1.Refresh()
        cn.Close()
    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Dim f As Integer
        cn.Open()
        f = 0

        If cmbAccno.Text = "" Then
            MsgBox("Please Enter The Value ")
        Else
            Dim cmd As New OleDbCommand("select * from Transection where Accno=" & cmbAccno.Text & " ", cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                f = 1
                cmbAccno.Text = dr(0)
                txtFat.Text = dr(1)
                txtTotal_Milk.Text = dr(2)
                txtAmount.Text = dr(3)
                DateTimePicker1.Text = dr(4).ToString

            End If

            If f = 1 Then
                MsgBox(" You have succefully search")
            Else
                MsgBox(" You have not succefully search")
                cmbAccno.Focus()
            End If

        End If
        cn.Close()
    End Sub
    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub txtTotal_Milk_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal_Milk.Leave
        Try
            If Val(txtFat.Text) >= 5 And Val(txtFat.Text) < 10 Then
                b = txtTotal_Milk.Text
                txtAmount.Text = b * 20
            ElseIf Val(txtFat.Text) >= 10 And Val(txtFat.Text) <= 15 Then
                b = txtTotal_Milk.Text
                txtAmount.Text = b * 30
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal_Milk.TextChanged
        'txtAmount.Text = Val(txtFat.Text) * Val(txtTotal_Milk.Text)
    End Sub

    Private Sub Transection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show1()
        Dim da As New OleDbDataAdapter("select * from Transection", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    'Private Sub txtAccno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccno.TextChanged
    '    If IsNumeric(txtAccno.Text) = False Then
    '        ErrorProvider1.SetError(txtAccno, "Plz Enter Numeric Value ")
    '    Else
    '        ErrorProvider1.SetError(txtAccno, " ")
    '    End If
    'End Sub
End Class