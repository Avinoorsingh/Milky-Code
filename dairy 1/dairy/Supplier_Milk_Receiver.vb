Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Supplier_Milk_Receiver
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")
    Dim dr As OleDbDataReader
    Dim mytable As DataTable
    Dim rownumber As Integer
    Dim myrow As Data.DataRow
    Dim ds As New DataSet()
    Dim da As New OleDbDataAdapter
    Dim b As New Integer
    Dim no As Integer
    Public Sub get_no()
        'Try
        '    cn.Open()
        '    Dim no As Integer
        '    Dim cmd As New OleDbCommand("select count(*) from Supplier_Milk_Receiver", cn)
        '    no = cmd.ExecuteScalar

        '    If (no = 0) Then
        '        cmb_suppno.Text = 1
        '    Else
        '        cmb_suppno.Text = no + 1
        '    End If
        '    cn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Sub show1()
        Dim da As New OleDbDataAdapter("select * from Supplier_Milk_Receiver", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub btnNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEW.Click
        'Call textblank()
        'get_no()
        Try
            cn.Open()
            Dim no As Integer
            Dim cmd As New OleDbCommand("select count(*) from Supplier_Milk_Receiver", cn)
            no = cmd.ExecuteScalar

            If (no = 0) Then
                cmb_sno.Text = 1
            Else
                cmb_sno.Text = no + 1
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub textblank()
        cmb_sno.Text = ""
        txtFat.Text = ""
        txtQuantity.Text = ""
        txtAmount.Text = ""
        txtTotal_Milk.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            Dim cmd As New OleDbCommand("select count(*) from Supplier_Milk_Receiver", cn)
            no = cmd.ExecuteScalar

            If (no = 0) Then
                cmb_sno.Text = 1
            Else
                cmb_sno.Text = no + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            cn.Open()
            Dim cmd As New OleDbCommand("delete from Supplier_Milk_Receiver where Sno=" & cmb_sno.Text & " ", cn)
            cmd.ExecuteNonQuery()
            Call textblank()
            show1()
            MsgBox("Delete successful completed")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call textblank()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            cn.Open()
            If cmb_sno.Text = "" Or txtFat.Text = "" Or txtQuantity.Text = "" Or txtAmount.Text = "" Or txtTotal_Milk.Text = "" Then
                MsgBox("Please enter the value ")
            Else

                Dim cmd As New OleDbCommand("update Supplier_Milk_Receiver set CDate='" & DateTimePicker1.Value.Date & "',Fat=" & txtFat.Text & ",Quantity=" & txtQuantity.Text & ",Amount=" & txtAmount.Text & ",Total_milk=" & txtTotal_Milk.Text & " where  sno=" & cmb_sno.Text & " ", cn)
                cmd.ExecuteNonQuery()
                Call textblank()
                show1()
                MsgBox("update successful completed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cmb_sno.Enabled = True
        DataGridView1.Refresh()
        cn.Close()
    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Try
            cn.Open()
            Dim f As Integer
            f = 0

            If cmb_sno.Text = "" Then
                MsgBox("Please Enter The Value ")
            Else
                Dim cmd As New OleDbCommand("select * from  Supplier_Milk_Receiver where Sno=" & cmb_sno.Text & " ", cn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    f = 1
                    DateTimePicker1.Text = dr(0).ToString
                    cmb_sno.Text = dr(1)
                    txtFat.Text = dr(2)
                    txtQuantity.Text = dr(3)
                    txtAmount.Text = dr(4)
                    txtTotal_Milk.Text = dr(5)

                End If

                If f = 1 Then
                    MsgBox(" You have succefully search")
                Else
                    MsgBox(" You have not succefully search")
                    cmb_sno.Focus()
                End If
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        cmb_sno.Text = ""
        txtFat.Text = ""
        txtQuantity.Text = ""
        txtAmount.Text = ""
        txtTotal_Milk.Text = ""
    End Sub

    Private Sub btnVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVIEW.Click
        show1()
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

    Private Sub btnPREVIOU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPREVIOU.Click
        Try
            rownumber = rownumber - 1
            If rownumber < 0 Then
                rownumber = 0
            End If
            showdata()
            MsgBox("Previous Record")
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
    Public Sub showdata()
        Dim da As New OleDbDataAdapter("select * from Supplier_Milk_Receiver", cn)
        da.Fill(ds, "Supplier_Milk_Receiver")
        mytable = ds.Tables("Supplier_Milk_Receiver")
        myrow = mytable.Rows.Item(rownumber)
        cmb_sno.Text = myrow.Item("Sno").ToString
        txtFat.Text = myrow.Item("Fat").ToString
        txtQuantity.Text = myrow.Item("Quantity").ToString
        txtAmount.Text = myrow.Item("Amount").ToString
        txtTotal_Milk.Text = myrow.Item("Total_Milk").ToString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub Supplier_Milk_Receiver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show1()
        Dim da As New OleDbDataAdapter("select * from Supplier_Milk_Receiver", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub txtQuantity_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity.Leave
        Dim j As New Integer
        Try
            If Val(txtFat.Text) >= 5 And Val(txtFat.Text) < 10 Then
                b = txtQuantity.Text
                j = b * 20
                txtAmount.Text = j
            ElseIf Val(txtFat.Text) >= 10 And Val(txtFat.Text) <= 15 Then
                b = txtQuantity.Text
                j = b * 30
                txtAmount.Text = j
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged, txtQuantity.TextChanged
        'txtAmount.Text = Val(txtFat.Text) * Val(txtQuantity.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cn.Open()
            'Dim no As Integer

            If cmb_sno.Text = "" Or txtFat.Text = "" Or txtQuantity.Text = "" Or txtFat.Text = "" Or txtAmount.Text = "" Or txtTotal_Milk.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                Dim cmd1 As New OleDbCommand("select * from Supplier_Milk_Receiver where Sno=" & Trim(cmb_sno.Text) & " ", cn)
                dr = cmd1.ExecuteReader
                If dr.Read Then
                    no = dr(0)
                End If
                If (no = cmb_sno.Text) Then
                    MsgBox("This Sno is Exist= " & cmb_sno.Text)
                    cmb_sno.Focus()
                Else

                    Dim cmd As New OleDbCommand("insert into Supplier_Milk_Receiver values('" & DateTimePicker1.Value.Date & "'," & cmb_sno.Text & "," & txtFat.Text & "," & txtQuantity.Text & "," & txtAmount.Text & "," & txtTotal_Milk.Text & " ) ", cn)
                    cmd.ExecuteNonQuery()
                    Call textblank()
                    show1()
                    MsgBox("insert successful completed")
                End If
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        Call textblank()
    End Sub
End Class