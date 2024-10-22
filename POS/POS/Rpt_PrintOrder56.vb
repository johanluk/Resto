Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing

Public Class Rpt_PrintOrder56

    Dim OrderID As Integer = 0
    Dim Mode As Integer = 0
    Dim EmployeeID As Integer = 0


    Private WithEvents printingSystem1 As New PrintingSystem()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        FillDataAdapter()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal TempOrderID As Integer, ByVal TempMode As Integer, ByVal TEmployeeID As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        FillDataAdapter()

        OrderID = TempOrderID
        Mode = TempMode
        EmployeeID = TEmployeeID
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Rpt_BillInvoice_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        FillDataAdapter()

    End Sub

    Sub FillDataAdapter()
        Me.Sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter1.Fill(Me.DataSet_Report1.sp_POSReportTransaction_GetDataPrintOrderDetail,
                                                                                  OrderID, Mode, EmployeeID
                                                                                 )
    End Sub

End Class