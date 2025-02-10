'Imports CrystalDecisions.CrystalReports
'Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports System.IO
Public Class Dairy_milk_report
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")
    'Dim cmd As OleDbCommand
    'Dim da As OleDbDataAdapter
    'Dim ds As DataSet
    'Dim cr As New ReportDocument
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Private Sub Dairy_milk_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\dairy\dairy\database.mdb")
    '    cn.Open()



    '    da = New OleDbDataAdapter("select * from Dairy_milk", cn)
    '    ds = New DataSet()
    '    da.Fill(ds, "Dairy_milk")


    '    cr.Load("C:\dairy\dairy\CrystalReport3.rpt")

    '    cr.SetDataSource(ds.Tables("Dairy_milk"))

    '    CrystalReportViewer1.ReportSource = cr
    '    CrystalReportViewer1.Show()
    'End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            cn.Open()
            If cmb1.Text = "Sno" Then
                Dim cmd As New OleDbDataAdapter("select * from Dairy_milk where Sno=" & txt1.Text & "", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport3
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()

            ElseIf cmb1.Text = "Accno" Then
                Dim cmd As New OleDbDataAdapter("select * from Dairy_milk where Accno=" & txt1.Text & "", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport3
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()

            ElseIf cmb1.Text = "BillNo" Then
                Dim cmd As New OleDbDataAdapter("select * from Dairy_milk where Billno=" & txt1.Text & "", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport3
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()
            Else
                Dim cmd As New OleDbDataAdapter("select * from Dairy_milk", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport3
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim cmd As New OleDbDataAdapter("select * from Dairy_milk", cn)
        Dim dt As New DataTable
        cmd.Fill(dt)
        Dim cr As New CrystalReport3
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cn.Close()
    End Sub

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        Try
            cn.Open()
            Dim cmd As New OleDbDataAdapter("select * from Dairy_milk where Cdate>=#" & DateTimePicker1.Value.Date & "# and Cdate<=#" & DateTimePicker2.Value.Date & "#", cn)
            Dim ds As New DataSet
            cmd.Fill(ds, "Dairy_milk")
            Dim cr As New CrystalReport3
            cr.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Show()
            CrystalReportViewer1.Refresh()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class