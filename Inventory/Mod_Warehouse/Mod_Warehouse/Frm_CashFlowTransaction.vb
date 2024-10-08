Public Class Frm_CashFlowTransaction

    Private Sub Frm_CashFlowTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dataset.sp_LookUpData_GetCashFlowType' table. You can move, or remove it, as needed.
        Me.Sp_LookUpData_GetCashFlowTypeTableAdapter.Fill(Me.Dataset.sp_LookUpData_GetCashFlowType)

    End Sub

    Dim TransactionDate As DateTime
    Dim TransactionID As Integer
    Dim TransactionNo As String
    Dim TransactionType As Integer
    Dim CashFlowType As Integer



    Dim Mode As Integer

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Sub New(ByVal _TransactionDate As Date, ByVal _TransactionID As Integer, ByVal _TransactionNo As String, ByVal _TransactionType As Integer, ByVal _CashFlowType As Integer, ByVal _Mode As Integer)
        Try

            ' This call is required by the designer.
            InitializeComponent()

            LUE_CashType.ReadOnly = True
            CB_CashFlowType.ReadOnly = True

            TransactionDate = _TransactionDate
            TransactionID = _TransactionID
            TransactionNo = _TransactionNo
            TransactionType = _TransactionType
            CashFlowType = _CashFlowType

            If (_Mode = 1) Then
                LUE_CashType.EditValue = CashFlowType - 1  'Tunai
                LUE_CashType.ReadOnly = False
                CB_CashFlowType.EditValue = 0
                CB_CashFlowType.ReadOnly = False
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        Try
            Me.QueriesTableAdapter.sp_TCashFlow_InsUpdData(TransactionDate, TransactionID, TransactionNo, TransactionType, (CB_CashFlowType.SelectedIndex) + 1, CInt(LUE_CashType.EditValue), CInt(Ed_Value.EditValue), My.Settings.UserName)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class