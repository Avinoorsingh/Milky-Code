Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Dairy_milk
    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\dairy\dairy\database.mdb")
    Dim dr As OleDbDataReader
    Dim mytable As DataTable
    Dim rownumber As Integer
    Dim myrow As Data.DataRow
    Dim ds As New DataSet()
    Dim da As New OleDbDataAdapter
    Public Sub get_no()
        Dim no As Integer
        cn.Open()
        Try
            Dim cmd As New OleDbCommand("select count(*) from Dairy_milk", cn)
            no = cmd.ExecuteScalar

            If (no = 0) Then
                txtSNO.Text = 1
            Else
                txtSNO.Text = no + 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub
    Sub show1()
        Dim da As New OleDbDataAdapter("select Suppno,Cdate,Name,Billno,Quantity,Rate,Amount,Paydate from Dairy_milk", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Public Sub textblank()
        txtSNO.Text = ""
        txtACCNO.Text = ""
        ' DateTimePicker1.Value = ""
        txtBILLNO.Text = ""
        txtQAUNTITY.Text = ""
        txtFAT.Text = ""
        txtRATE.Text = ""
        txtAMOUNT.Text = ""
    End Sub
    Public Sub showdata()


        Dim da As New OleDbDataAdapter("select * from Dairy_milk", cn)
        da.Fill(ds, "Dairy_milk")
        mytable = ds.Tables("Dairy_milk")
        myrow = mytable.Rows.Item(rownumber)

        txtSNO.Text = myrow.Item("Suppno").ToString
        DateTimePicker1.Value = myrow.Item("Cdate").ToString
        txtACCNO.Text = myrow.Item("Name").ToString
        txtBILLNO.Text = myrow.Item("Billno").ToString
        txtQAUNTITY.Text = myrow.Item("Quantity").ToString
        txtFAT.Text = myrow.Item("Fat").ToString
        txtRATE.Text = myrow.Item("Rate").ToString
        txtAMOUNT.Text = myrow.Item("Amount").ToString
        DateTimePicker2.Value = myrow.Item("Paydate").ToString

    End Sub
    Private Sub btnNEW_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEW.Click
        Call textblank()
        get_no()
    End Sub

    Private Sub btnINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINSERT.Click
        cn.Open()
        Dim no As Integer
        Try
            If txtSNO.Text = "" Or txtACCNO.Text = "" Or DateTimePicker1.Text = "" Or txtQAUNTITY.Text = "" Or txtFAT.Text = "" Or txtRATE.Text = "" Or txtAMOUNT.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                Dim cmd1 As New OleDbCommand("select * from Dairy_milk where Suppno=" & Trim(txtSNO.Text) & " ", cn)
                dr = cmd1.ExecuteReader
                If dr.Read Then
                    no = dr(0)
                End If
                If (no = txtSNO.Text) Then
                    MsgBox("This Supp_no is Exist= " & txtSNO.Text)
                    txtSNO.Focus()
                Else

                    Dim cmd As New OleDbCommand("insert into Dairy_milk values(" & txtSNO.Text & ",'" & Trim(DateTimePicker1.Text) & "','" & txtACCNO.Text & "'," & txtBILLNO.Text & "," & txtQAUNTITY.Text & "," & txtFAT.Text & "," & txtRATE.Text & "," & txtAMOUNT.Text & ",'" & Trim(DateTimePicker1.Text) & "' ) ", cn)
                    cmd.ExecuteNonQuery()
                    Call textblank()
                    show1()
                    MsgBox("insert successful completed")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        Call textblank()
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        cn.Open()
        Dim cmd As New OleDbCommand("delete from Dairy_milk where Suppno=" & txtSNO.Text & " ", cn)
        cmd.ExecuteNonQuery()
        show1()
        Call textblank()
        cn.Close()
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        Try
            If txtSNO.Text = "" Or txtACCNO.Text = "" Or DateTimePicker1.Text = "" Or txtQAUNTITY.Text = "" Or txtFAT.Text = "" Or txtRATE.Text = "" Or txtAMOUNT.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                cn.Open()
                Dim cmd As New OleDbCommand("update Dairy_milk set Name='" & Trim(txtACCNO.Text) & "',Billno=" & Trim(txtBILLNO.Text) & ",Quantity=" & Trim(txtQAUNTITY.Text) & ",Fat=" & Trim(txtFAT.Text) & ",Rate=" & Trim(txtRATE.Text) & ",Amount=" & Trim(txtAMOUNT.Text) & "  where  Billno=" & txtSNO.Text & " ", cn)
                cmd.ExecuteNonQuery()
                Call textblank()
                show1()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtSNO.Enabled = True
        DataGridView1.Refresh()
        cn.Close()
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        txtSNO.Text = ""
        ' DateTimePicker1.Value = ""
        txtACCNO.Text = ""
        txtBILLNO.Text = ""
        txtQAUNTITY.Text = ""
        txtFAT.Text = ""
        txtRATE.Text = ""
        txtAMOUNT.Text = ""
    End Sub

    Private Sub btnVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVIEW.Click
        cn.Open()
        show1()
        cn.Close()
    End Sub

    Private Sub btnFIRST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFIRST.Click
        rownumber = 0
        showdata()
    End Sub

    Private Sub btnNEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEXT.Click
        rownumber = rownumber + 1

        If rownumber > mytable.Rows.Count - 1 Then

            rownumber = mytable.Rows.Count - 1

        End If

        showdata()
    End Sub

    Private Sub btnPREVIOU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPREVIOU.Click
        rownumber = rownumber - 1

        If rownumber < 0 Then

            rownumber = 0


        End If

        showdata()
        ' MsgBox("Record No:[" & rownumber + 1 & "]")
    End Sub

    Private Sub btnLAST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLAST.Click
        rownumber = mytable.Rows.Count - 1

        showdata()
    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Dim f As Integer
        cn.Open()
        f = 0

        If txtSNO.Text = "" Then
            MsgBox("Please Enter The Value ")
        Else
            Dim cmd As New OleDbCommand("select * from Dairy_milk where Suppno=" & txtSNO.Text & " ", cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                f = 1
                txtSNO.Text = dr(0)
                DateTimePicker1.Text = dr(1).ToString
                txtACCNO.Text = dr(2)
                txtBILLNO.Text = dr(3)
                txtQAUNTITY.Text = dr(4)
                txtFAT.Text = dr(5)
                txtRATE.Text = dr(6)
                txtAMOUNT.Text = dr(7)
                DateTimePicker2.Text = dr(8).ToString

            End If

            If f = 1 Then
                MsgBox(" You have succefully search")
            Else
                MsgBox(" You have not succefully search")
                txtSNO.Focus()
            End If

        End If
        cn.Close()
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Close()
    End Sub

    Private Sub txtRATE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRATE.TextChanged
        txtAMOUNT.Text = Val(txtRATE.Text) * Val(txtQAUNTITY.Text)
    End Sub
End Class