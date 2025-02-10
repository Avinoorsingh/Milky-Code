Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Dairy_milk
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")
    Dim dr As OleDbDataReader
    Dim mytable As DataTable
    Dim rownumber As Integer
    Dim myrow As Data.DataRow
    Dim ds As New DataSet()
    Dim da As New OleDbDataAdapter
    Dim b As Double
    Dim no As Integer

    Public Sub get_no()
       
        Try
            cn.Open()
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
        ' Dim da As New OleDbDataAdapter("select Suppno,Cdate,Accno,Billno,Quantity,Rate,Amount,Paydate from Dairy_milk", cn)
        Dim da As New OleDbDataAdapter("select  * from Dairy_milk", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Public Sub textblank()
        txtSNO.Text = ""
        Cmb_Accno.Text = ""
        Cmb_Billno.Text = ""
        txtTotal_Milk.Text = ""
        txtFAT.Text = ""
        'txtRATE.Text = ""
        txtAMOUNT.Text = ""
    End Sub
    Public Sub showdata()


        Dim da As New OleDbDataAdapter("select * from Dairy_milk", cn)
        da.Fill(ds, "Dairy_milk")
        mytable = ds.Tables("Dairy_milk")
        myrow = mytable.Rows.Item(rownumber)

        txtSNO.Text = myrow.Item("Suppno").ToString
        DateTimePicker1.Value = myrow.Item("Cdate").ToString
        Cmb_Accno.Text = myrow.Item("Accno").ToString
        Cmb_Billno.Text = myrow.Item("Billno").ToString
        txtTotal_Milk.Text = myrow.Item("Total_Milk").ToString
        txtFAT.Text = myrow.Item("Fat").ToString
        'txtRATE.Text = myrow.Item("Rate").ToString
        txtAMOUNT.Text = myrow.Item("Amount").ToString
        DateTimePicker2.Value = myrow.Item("Paydate").ToString

    End Sub
    Private Sub btnNEW_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEW.Click
        'Call textblank()
        get_no()
    End Sub

    Private Sub btnINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINSERT.Click
        Try
            cn.Open()
            Dim no As Integer

            If txtSNO.Text = "" Or Cmb_Accno.Text = "" Or DateTimePicker1.Text = "" Or txtTotal_Milk.Text = "" Or txtFAT.Text = "" Or txtAMOUNT.Text = "" Then
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

                    Dim cmd As New OleDbCommand("insert into Dairy_milk values(" & txtSNO.Text & ",'" & DateTimePicker1.Value.Date & "','" & Cmb_Accno.Text & "'," & Cmb_Billno.Text & "," & txtTotal_Milk.Text & "," & txtFAT.Text & "," & txtAMOUNT.Text & ",'" & DateTimePicker1.Value.Date & "' ) ", cn)
                    cmd.ExecuteNonQuery()
                    'Call textblank()
                    show1()
                    MsgBox("insert successful completed")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        'Call textblank()
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Try
            cn.Open()
            Dim cmd As New OleDbCommand("delete from Dairy_milk where Suppno=" & txtSNO.Text & " ", cn)
            cmd.ExecuteNonQuery()
            show1()
            MsgBox("Delete successful completed")
            Call textblank()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     
    End Sub

    Private Sub btnUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUPDATE.Click
        Try

            If txtSNO.Text = "" Or Cmb_Accno.Text = "" Or DateTimePicker1.Text = "" Or txtTotal_Milk.Text = "" Or txtFAT.Text = "" Or txtAMOUNT.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                cn.Open()
                Dim cmd As New OleDbCommand("update Dairy_milk set Cdate='" & DateTimePicker1.Value.Date & "',Accno=" & Cmb_Accno.Text & ",Billno=" & Cmb_Billno.Text & ",Total_Milk=" & txtTotal_Milk.Text & ",Fat=" & txtFAT.Text & ",Amount=" & txtAMOUNT.Text & ",Paydate='" & DateTimePicker2.Value.Date & "' where Suppno=" & txtSNO.Text & " ", cn)
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
        Cmb_Accno.Text = ""
        Cmb_Billno.Text = ""
        txtTotal_Milk.Text = ""
        txtFAT.Text = ""
        'txtRATE.Text = ""
        txtAMOUNT.Text = ""
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

    Private Sub btnPREVIOU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPREVIOU.Click
        Try
            rownumber = rownumber - 1

            If rownumber < 0 Then

                rownumber = 0


            End If

            showdata()
            MsgBox("Previous Record")
            ' MsgBox("Record No:[" & rownumber + 1 & "]")
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

        If txtSNO.Text = "" Then
            MsgBox("Please Enter The Value ")
        Else
            Dim cmd As New OleDbCommand("select * from Dairy_milk where Suppno=" & txtSNO.Text & " ", cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                f = 1
                txtSNO.Text = dr(0)
                DateTimePicker1.Text = dr(1).ToString
                Cmb_Accno.Text = dr(2)
                Cmb_Billno.Text = dr(3)
                txtTotal_Milk.Text = dr(4)
                txtFAT.Text = dr(5)
                'txtRATE.Text = dr(6)
                txtAMOUNT.Text = dr(6)
                DateTimePicker2.Text = dr(7).ToString

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

    Private Sub txtRATE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtAMOUNT.Text = Val(txtRATE.Text) * Val(txtTotal_Milk.Text)
    End Sub

    Private Sub txtSNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSNO.TextChanged
        'If IsNumeric(txtSNO.Text) = False Then
        '    ErrorProvider1.SetError(txtSNO, "Plz Enter Numeric Value ")
        'Else
        '    ErrorProvider1.SetError(txtSNO, " ")
        'End If
    End Sub
    Private Sub txtFAT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFAT.Leave
        Dim j As New Integer
        Try
            If Val(txtFAT.Text) >= 5 And Val(txtFAT.Text) < 10 Then
                b = txtTotal_Milk.Text
                j = b * 20
                txtAMOUNT.Text = j
            ElseIf Val(txtFAT.Text) >= 10 And Val(txtFAT.Text) <= 15 Then
                b = txtTotal_Milk.Text
                j = b * 30
                txtAMOUNT.Text = j
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Dairy_milk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class