Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing

Public Class Rpt_PrintWorkOrder

    Dim OrderNo As String = ""
    Dim OrderID As Integer = 0
    Dim TableName As String = ""
    Dim Mode As Integer = 0
    Dim EmployeeID As Integer = 0


    Private WithEvents printingSystem1 As New PrintingSystem()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        FillDataAdapter()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal _OrderNo As String, ByVal TempOrderID As Integer, ByVal _TableName As String, ByVal TempMode As Integer, ByVal TEmployeeID As Integer, ByVal TTableName As String, ByVal TStatus As Boolean)
        ' This call is required by the designer.
        InitializeComponent()
        FillDataAdapter()

        OrderNo = _OrderNo
        OrderID = TempOrderID
        TableName = _TableName
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
        Me.Sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter.Fill(Me.DataSet_Report1.sp_POSReportTransaction_GetDataPrintOrderDetailMemo,
                                                                                  OrderID, Mode
                                                                                 )
    End Sub

    Private Sub Detail1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail1.BeforePrint
       
        If Detail1.Report.RowCount = 0 Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Rpt_PrintWorkOrder_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint
        XrLabel_TableName.Text = TableName + " - " + OrderNo.Substring(Len(OrderNo) - 3)
    End Sub
End Class