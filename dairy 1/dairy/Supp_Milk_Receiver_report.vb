Imports System.Data.OleDb
Imports System.Data
Public Class Supp_Milk_Receiver_report
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\TYBCA201011\G.NO-61\R\dairy 1\dairy\database.mdb")
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            cn.Open()
            If cmb1.Text = "SNo" Then
                Dim cmd As New OleDbDataAdapter("select * from Supplier_Milk_Receiver where Sno=" & txt1.Text & "", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport4
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()
            Else
                Dim cmd As New OleDbDataAdapter("select * from Supplier_Milk_Receiver", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport4
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim cmd As New OleDbDataAdapter("select * from Supplier_Milk_Receiver", cn)
        Dim dt As New DataTable
        cmd.Fill(dt)
        Dim cr As New CrystalReport4
        cr.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = cr
        cn.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        Try
            cn.Open()
            Dim cmd As New OleDbDataAdapter("select * from Supplier_Milk_Receiver where Cdate>=#" & DateTimePicker1.Value.Date & "# and Cdate<=#" & DateTimePicker2.Value.Date & "#", cn)
            Dim ds As New DataSet
            cmd.Fill(ds, "Supplier_Milk_Receiver")
            Dim cr As New CrystalReport4
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