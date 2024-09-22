Public Class Frm_InvListDetail

    Dim _Name As String
    Public Sub New(ByVal _InventoryName As String, ByVal _InventoryID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        _Name = _InventoryName
        LabelBarang.Tag = _InventoryID
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Frm_InvListDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_MDInventory_GetHPPHistoryTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetHPPHistory, CInt(LabelBarang.Tag))
        Me.Sp_MDInventory_GetTransactionDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetTransactionData, CInt(LabelBarang.Tag))

        LabelBarang.Text = _Name
    End Sub
End Class