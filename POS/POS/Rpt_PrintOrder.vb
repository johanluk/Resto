Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing

Public Class Rpt_PrintOrder

    Dim OrderID As Integer = 0
    Dim _NoReqOrder As Integer = 0


    Private WithEvents printingSystem1 As New PrintingSystem()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal TempOrderID As Integer, ByVal TNoReqOrder As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        FillDataAdapter()

        OrderID = TempOrderID
        _NoReqOrder = TNoReqOrder
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Rpt_BillInvoice_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        FillDataAdapter()

    End Sub

    Sub FillDataAdapter()
        Me.Sp_POS_Checker_PrintOrderDetailTableAdapter1.Fill(Me.DataSet_Report1.sp_POS_Checker_PrintOrderDetail,
                                                                                  OrderID, _NoReqOrder)

    End Sub

End Class