Imports System.Data.OleDb
Public Class Transectino_Report
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\dairy\dairy\database.mdb")
    Private Sub bntCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntCheck.Click
        Try
            cn.Open()
            If cmb1.Text = "Accno" Then
                Dim cmd As New OleDbDataAdapter("select * from Transection where Accno=" & txt1.Text & "", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport5
                cr.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = cr
                cn.Close()
            Else
                Dim cmd As New OleDbDataAdapter("select * from Transection ", cn)
                Dim dt As New DataTable
                cmd.Fill(dt)
                Dim cr As New CrystalReport5
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
        Dim cmd As New OleDbDataAdapter("select * from Transection", cn)
        Dim dt As New DataTable
        cmd.Fill(dt)
        Dim cr As New CrystalReport5
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
            Dim cmd As New OleDbDataAdapter("select * from Transection where Paydate>=#" & DateTimePicker1.Value.Date & "# and Paydate<=#" & DateTimePicker2.Value.Date & "#", cn)
            Dim ds As New DataSet
            cmd.Fill(ds, "Transection")
            Dim cr As New CrystalReport5
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
 