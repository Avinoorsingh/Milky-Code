Public Class main_form

    Private Sub SuppliermasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliermasterToolStripMenuItem.Click
        Supp_master.Show()
    End Sub

    Private Sub DairymilkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DairymilkToolStripMenuItem.Click
        Dairy_milk.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Login_master.Close()
        Me.Close()
    End Sub

    Private Sub SupplierreportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierreportToolStripMenuItem.Click
        Supp_master_report.Show()
    End Sub

    Private Sub LocalsalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalsalesToolStripMenuItem.Click
        Local_sale_report.Show()
    End Sub

    Private Sub DairymilkreportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DairymilkreportToolStripMenuItem.Click
        Dairy_milk_report.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CalculaterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculaterToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("pls Contact bY Vijay Patel Student of T.Y.B.C.A ")
    End Sub

    Private Sub TransectionInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransectionInfoToolStripMenuItem.Click
        Transection.Show()
    End Sub

    Private Sub SupplierPaymentreportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierPaymentreportToolStripMenuItem.Click
        Supplier_Payment_Report.Show()
    End Sub

    Private Sub TransectionReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransectionReportToolStripMenuItem.Click
        Transectino_Report.Show()
    End Sub

    Private Sub LocalSaleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalSaleToolStripMenuItem1.Click
        Local_sale.Show()
    End Sub

    Private Sub Supplier_Milk_ReceiverToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supplier_Milk_ReceiverToolStripMenuItem2.Click
        Supplier_Milk_Receiver.Show()
    End Sub

    Private Sub SupplierMilkReceiverReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supplier_Milk_Receiver_ReportToolStripMenuItem.Click
        Supp_Milk_Receiver_report.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Supplier_Payment.Show()
    End Sub
End Class