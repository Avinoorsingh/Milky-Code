Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Supp_master
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")
    Dim dr As OleDbDataReader
    Dim mytable As DataTable
    Dim rownumber As Integer
    Dim myrow As Data.DataRow
    Dim ds As New DataSet()
    Dim da As New OleDbDataAdapter
    Public Sub get_no()
        Try
            cn.Open()
            Dim no As Integer
            Dim cmd As New OleDbCommand("select count(*) from Supplier_master", cn)
            no = cmd.ExecuteScalar

            If (no = 0) Then
                txtSNO.Text = 1
            Else
                txtSNO.Text = no + 1
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub show1()
        Dim da As New OleDbDataAdapter("select * from Supplier_master", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub


    Private Sub btnNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEW.Click
        Call textblank()
        get_no()
    End Sub
    Public Sub textblank()
        txtSNO.Text = ""
        txtSNAME.Text = ""
        txtSADD.Text = ""
        txtSCITY.Text = ""
        txtSPINCODE.Text = ""
    End Sub

    Private Sub btnINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnINSERT.Click
        Try
            cn.Open()
            Dim no As Integer

            If txtSNO.Text = "" Or txtSNAME.Text = "" Or txtSADD.Text = "" Or txtSCITY.Text = "" Or txtSPINCODE.Text = "" Then
                MsgBox("Please enter the value ")
            Else
                Dim cmd1 As New OleDbCommand("select * from Supplier_master where Suppno=" & Trim(txtSNO.Text) & " ", cn)
                dr = cmd1.ExecuteReader
                If dr.Read Then
                    no = dr(0)
                End If
                If (no = txtSNO.Text) Then
                    MsgBox("This Supp_no is Exist= " & txtSNO.Text)
                    txtSNO.Focus()
                Else
                    Dim cmd As New OleDbCommand("insert into Supplier_master values(" & txtSNO.Text & ",'" & txtSNAME.Text & "','" & txtSADD.Text & "','" & txtSCITY.Text & "'," & txtSPINCODE.Text & " ) ", cn)
                    cmd.ExecuteNonQuery()
                    txtSNO.Text = ""
                    txtSNAME.Text = ""
                    txtSADD.Text = ""
                    txtSCITY.Text = ""
                    txtSPINCODE.Text = ""
                    show1()
                    MsgBox("insert successful completed")
                End If
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call textblank()
    End Sub

    Private Sub btnDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDELETE.Click
        Try
            cn.Open()
            Dim cmd As New OleDbCommand("delete from Supplier_master where suppno=" & txtSNO.Text & " ", cn)
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
            cn.Open()
            If txtSNO.Text = "" Or txtSNAME.Text = "" Or txtSADD.Text = "" Or txtSCITY.Text = "" Or txtSPINCODE.Text = "" Then
                MsgBox("Please enter the value ")
            Else

                Dim cmd As New OleDbCommand("update Supplier_master set Suppname='" & Trim(txtSNAME.Text) & "',Suppadd='" & Trim(txtSADD.Text) & "',Suppcity='" & Trim(txtSCITY.Text) & "',Pincode=" & Trim(txtSPINCODE.Text) & " where  Suppno=" & txtSNO.Text & " ", cn)
                cmd.ExecuteNonQuery()
                Call textblank()
                show1()
                MsgBox("update successful completed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtSNO.Enabled = True
        DataGridView1.Refresh()
        cn.Close()
    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Try
            cn.Open()
            Dim f As Integer
            f = 0

            If txtSNO.Text = "" Then
                MsgBox("Please Enter The Value ")
            Else
                Dim cmd As New OleDbCommand("select * from  Supplier_master where suppno=" & txtSNO.Text & " ", cn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    f = 1
                    txtSNO.Text = dr(0)
                    txtSNAME.Text = dr(1)
                    txtSADD.Text = dr(2)
                    txtSCITY.Text = dr(3)
                    txtSPINCODE.Text = dr(4)

                End If

                If f = 1 Then
                    MsgBox(" You have succefully search")
                Else
                    MsgBox(" You have not succefully search")
                    txtSNO.Focus()
                End If

            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        txtSNO.Text = ""
        txtSNAME.Text = ""
        txtSADD.Text = ""
        txtSCITY.Text = ""
        txtSPINCODE.Text = ""
    End Sub

    Private Sub btnVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVIEW.Click
        '    cn.Open()
        show1()
    End Sub

    Private Sub btnFIRST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFIRST.Click
        Try
            rownumber = 0
            showdata()
            MsgBox(" First record")
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
            MsgBox(" Next record")
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
            MsgBox(" Previous record")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     
    End Sub

    Private Sub btnLAST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLAST.Click
        Try
            rownumber = mytable.Rows.Count - 1
            showdata()
            MsgBox(" Last record")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub showdata()
        Dim da As New OleDbDataAdapter("select * from Supplier_master", cn)
        da.Fill(ds, "Supplier_master")
        mytable = ds.Tables("Supplier_master")
        myrow = mytable.Rows.Item(rownumber)

        txtSNO.Text = myrow.Item("Suppno").ToString
        txtSNAME.Text = myrow.Item("Suppname").ToString
        txtSADD.Text = myrow.Item("Suppadd").ToString
        txtSCITY.Text = myrow.Item("Suppcity").ToString
        txtSPINCODE.Text = myrow.Item("Pincode").ToString
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        cn.Close()
        Me.Close()
    End Sub

    Private Sub Supp_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.Open()

        Dim da As New OleDbDataAdapter("select * from Supplier_master", cn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        show1()
        cn.Close()
    End Sub

    'Private Sub txtSNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If IsNumeric(cmb_suppno.Text) = False Then
    '        ErrorProvider1.SetError(cmb_suppno, "Plz Enter Numeric Value ")
    '    Else
    '        ErrorProvider1.SetError(cmb_suppno, " ")
    '    End If
    'End Sub

    'Private Sub txtSNAME_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSNAME.TextChanged
    '    If IsNumeric(txtSNAME.Text) = True Then
    '        ErrorProvider1.SetError(txtSNAME, "Plz Enter String Value ")
    '    Else
    '        ErrorProvider1.SetError(txtSNAME, " ")
    '    End If
    'End Sub
End Class