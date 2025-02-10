Public Class main_form

    Private Sub SuppliermasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliermasterToolStripMenuItem.Click
        Supp_master.Show()
    End Sub

    Private Sub LocalsaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalsaleToolStripMenuItem.Click
        Local_sale.Show()
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
End Class