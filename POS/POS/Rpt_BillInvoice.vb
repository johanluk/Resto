Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing

Public Class Rpt_BillInvoice

    Dim OrderID As Integer = 0
    Dim Mode As Integer = 0

    Dim Balance, Promo, PromoValue, PPN, PPNValue, DP, Other As Integer

    Private WithEvents printingSystem1 As New PrintingSystem()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        FillDataAdapter()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal TempOrderID As Integer, ByVal TempMode As Integer, ByVal TBalance As Integer, ByVal TPromo As Integer, ByVal TPromoValue As Integer, ByVal TPPN As Integer, ByVal TPPNValue As Integer, ByVal TDP As Integer, ByVal TOther As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        FillDataAdapter()

        Mode = TempMode

        OrderID = TempOrderID

        Balance = TBalance
        Promo = TPromo
        PromoValue = TPromoValue
        PPN = TPPN
        PPNValue = TPPNValue
        DP = TDP
        Other = TOther
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Rpt_BillInvoice_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        FillDataAdapter()

    End Sub

    Sub FillDataAdapter()
        Me.Sp_POSReportTransaction_GetDataInvoiceDetailTableAdapter1.Fill(Me.DataSet_Report1.sp_POSReportTransaction_GetDataInvoiceDetail,
                                                                                  OrderID, Mode
                                                                                 )

        Me.Sp_POSReportTransaction_GetDataInvoiceHeaderTableAdapter.Fill(Me.DataSet_Report1.sp_POSReportTransaction_GetDataInvoiceHeader,
                                                                                  OrderID, Mode,
                                                                                  Balance, Promo, PromoValue, PPN, PPNValue, DP, Other
                                                                                   )
    End Sub

End Class