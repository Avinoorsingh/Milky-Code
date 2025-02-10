Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb
Imports System.IO
Public Class Local_sale_report
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim cr As New ReportDocument
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Local_sale_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn As New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=C:\dairy\dairy\database.mdb")
        cn.Open()



        da = New OleDbDataAdapter("select * from Local_sale", cn)
        ds = New DataSet()
        da.Fill(ds, "Local_sale")


        cr.Load("C:\dairy\dairy\CrystalReport2.rpt")

        cr.SetDataSource(ds.Tables("Local_sale"))

        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Show()
    End Sub
End Class