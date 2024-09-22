Public Class Frm_Core
    Private Sub BBI_MasterInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBI_MasterInventory.ItemClick
        Dim a As New Frm_InvList
        a.MdiParent = Me
        a.Show()
    End Sub

End Class