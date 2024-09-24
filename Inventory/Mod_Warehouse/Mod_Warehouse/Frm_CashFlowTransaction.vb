Public Class Frm_CashFlowTransaction
    Private Sub Frm_CashFlowTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim TransactionID As Integer
    Dim TransactioNo As String
    Dim TransactionType As Integer
    Dim CashFlowType As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Sub New(ByVal _TransactionID As Integer, ByVal _TransactionNo As String, ByVal _TransactionType As Integer, ByVal _CashFlowType As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ComboBoxEdit1.EditValue = _CashFlowType - 1


        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class