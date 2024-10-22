Public Class Frm_DisplayMonitor
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Frm_DisplayMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rpt_BillInvoicePreview.OrderID = CInt(0)
        DocumentViewer1.InitiateDocumentCreation()
    End Sub
End Class