Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Local_sale
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
            Dim no As Integer
            cn.Open()

            Dim cmd As New OleDbCommand("select count(*) from Local_sale", cn)
            no = cmd.ExecuteScalar

            If (no = 0) Then
                txtBILLNO.Text = 1
            Else
                txtBILLNO.Text = no + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub
    Sub show1()
        Dim da As New OleDbDataAdapter("select * from Local_sale", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Public Sub textblank()
        txtBILLNO.Text = ""
        txtTotal_milk.Text = ""
        txtFat.Text = ""
        txtAmount.Text = ""
    End Sub

    Private Sub btnINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINSERT.Click
        Try
            cn.Open()
            Dim no As Integer

            If txtBILLNO.Text = "" Or DateTimePicker1.Text = "" Or txtFat.Text = "" Or txtAmount.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                Dim cmd1 As New OleDbCommand("select * from Local_sale where Billno=" & Trim(txtBILLNO.Text) & " ", cn)
                dr = cmd1.ExecuteReader
                If dr.Read Then
                    no = dr(0)
                End If
                If (no = txtBILLNO.Text) Then
                    MsgBox("This Bill_no is Exist= " & txtBILLNO.Text)
                    txtBILLNO.Focus()
                Else

                    Dim cmd As New OleDbCommand("insert into Local_sale values(" & txtBILLNO.Text & ",'" & DateTimePicker1.Value.Date & "'," & txtTotal_milk.Text & "," & txtFat.Text & "," & txtAmount.Text & " ) ", cn)
                    cmd.ExecuteNonQuery()
                    Call textblank()
                    show1()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cn.Close()
        MsgBox("insert successful completed")
        'Call textblank()
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Try
            cn.Open()
            Dim cmd As New OleDbCommand("delete from Local_sale where Billno=" & txtBILLNO.Text & " ", cn)
            cmd.ExecuteNonQuery()
            show1()
            MsgBox("Delete successful completed")
            Call textblank()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        Try
            If txtBILLNO.Text = "" Or DateTimePicker1.Text = "" Or txtTotal_milk.Text = "" Or txtFat.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                cn.Open()
                Dim cmd As New OleDbCommand("update Local_sale set Cdate='" & DateTimePicker1.Value.Date & "',Total_milk=" & txtTotal_milk.Text & ",Fat=" & txtFat.Text & ",Amount=" & txtAmount.Text & " where  Billno=" & txtBILLNO.Text & " ", cn)
                cmd.ExecuteNonQuery()
                Call textblank()
                show1()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtBILLNO.Enabled = True
        DataGridView1.Refresh()
        cn.Close()
    End Sub


    Private Sub btnNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEW.Click
        'Call textblank()
        get_no()
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        txtBILLNO.Text = ""
        txtTotal_milk.Text = ""
        txtFat.Text = ""
        txtAmount.Text = ""
    End Sub

    Private Sub btnVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVIEW.Click
        Try
            cn.Open()
            show1()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnFIRST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFIRST.Click
        Try
            rownumber = 0
            showdata()
            MsgBox("First Record")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnNEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEXT.Click
        Try
            rownumber = rownumber + 1
            If rownumber > mytable.Rows.Count - 1 Then
                rownumber = mytable.Rows.Count - 1
            End If
            showdata()
            MsgBox("Next Record")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub btnLAST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLAST.Click
        Try
            rownumber = mytable.Rows.Count - 1
            showdata()
            MsgBox("Last Record")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Dim f As Integer
        cn.Open()
        f = 0

        If txtBILLNO.Text = "" Then
            MsgBox("Please Enter The Value ")
        Else
            Dim cmd As New OleDbCommand("select * from Local_sale where Billno=" & txtBILLNO.Text & " ", cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                f = 1
                txtBILLNO.Text = dr(0)
                DateTimePicker1.Text = dr(1).ToString
                txtTotal_milk.Text = dr(2)
                txtFat.Text = dr(3)
                txtAmount.Text = dr(4)


            End If

            If f = 1 Then
                MsgBox(" You have succefully search")
            Else
                MsgBox(" You have not succefully search")
                txtBILLNO.Focus()
            End If

        End If
        cn.Close()
    End Sub
    Public Sub showdata()


        Dim da As New OleDbDataAdapter("select * from Local_sale", cn)
        da.Fill(ds, "Local_sale")
        mytable = ds.Tables("Local_sale")
        myrow = mytable.Rows.Item(rownumber)

        txtBILLNO.Text = myrow.Item("Billno").ToString
        DateTimePicker1.Text = myrow.Item("Cdate").ToString
        txtTotal_milk.Text = myrow.Item("Total_milk").ToString
        txtFat.Text = myrow.Item("Fat").ToString
        txtAmount.Text = myrow.Item("Amount").ToString

    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub btnPREVIOU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPREVIOU.Click
        Try
            rownumber = rownumber - 1

            If rownumber < 0 Then

                rownumber = 0


            End If

            showdata()
            MsgBox("Previous Record")
            MsgBox("Record No:[" & rownumber + 1 & "]")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub txtFat_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFat.Leave
        Dim j As New Integer
        Try


            If Val(txtFat.Text) >= 5 And Val(txtFat.Text) < 10 Then
                b = txtTotal_milk.Text
                j = b * 20
                txtAmount.Text = j
            ElseIf Val(txtFat.Text) >= 10 And Val(txtFat.Text) <= 15 Then
                b = txtTotal_milk.Text
                j = b * 30
                txtAmount.Text = j
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFat.TextChanged
        'txtAmount.Text = Val(txtTotal_milk.Text) * Val(txtFat.Text)
       
    End Sub

    Private Sub txtBILLNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBILLNO.TextChanged
        'If IsNumeric(txtBILLNO.Text) = False Then
        '    ErrorProvider1.SetError(txtBILLNO, "Plz Enter Numeric Value ")
        'Else
        '    ErrorProvider1.SetError(txtBILLNO, " ")
        'End If
    End Sub
End Class



