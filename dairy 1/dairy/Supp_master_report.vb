'Imports CrystalDecisions.CrystalReports
'Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports System.IO
Public Class Supp_master_report
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")
    'Dim cmd As OleDbCommand
    'Dim da As OleDbDataAdapter
    'Dim ds As DataSet
    'Dim cr As New ReportDocument
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Private Sub Supp_master_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\dairy\dairy\database.mdb")
    '    cn.Open()



    '    da = New OleDbDataAdapter("select * from Supplier", cn)
    '    ds = New DataSet()
    '    da.Fill(ds, "Supplier")


    '    cr.Load("C:\dairy\dairy\CrystalReport1.rpt")

    '    cr.SetDataSource(ds.Tables("Supplier"))

    '    CrystalReportViewer1.ReportSource = cr
    '    CrystalReportViewer1.Show()
    'End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            cn.Open()
            If cmb1.Text = "No" Then
                Dim cmd As New OleDbDataAdapter("select * from Supplier_master where Suppno=" & TextBox1.Text & "", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport1
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()

            ElseIf cmb1.Text = "Name" Then
                Dim cmd As New OleDbDataAdapter("select * from Supplier_master where Suppname='" & TextBox1.Text & "'", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport1
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()

            ElseIf cmb1.Text = "City" Then
                Dim cmd As New OleDbDataAdapter("select * from Supplier_master where Suppcity='" & TextBox1.Text & "'", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport1
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()
            Else
                Dim cmd As New OleDbDataAdapter("select * from Supplier_master", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport1
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub Supp_master_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As New OleDbDataAdapter("select * from Supplier_master", cn)
        Dim dt As New DataTable
        cmd.Fill(dt)
        Dim cr As New CrystalReport1
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cn.Close()
    End Sub
End Class