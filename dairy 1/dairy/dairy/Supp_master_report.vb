Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports System.IO
Public Class Supp_master_report
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cr As New ReportDocument
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Supp_master_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\dairy\dairy\database.mdb")
        cn.Open()



        da = New OleDbDataAdapter("select * from Supplier", cn)
        ds = New DataSet()
        da.Fill(ds, "Supplier")


        cr.Load("C:\dairy\dairy\CrystalReport1.rpt")

        cr.SetDataSource(ds.Tables("Supplier"))

        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Show()
    End Sub
End Class