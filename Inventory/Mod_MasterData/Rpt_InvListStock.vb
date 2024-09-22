Imports DevExpress.CodeParser.CodeStyle.Formatting.Rules
Imports DevExpress.PivotGrid.OLAP

Public Class Rpt_InvListStock
    Dim Month As Integer
    Dim Year As Integer
    Dim InventoryID As Integer
    Public Sub New(ByVal _Month As Integer, _Year As Integer, _InventoryID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Month = _Month
        Year = _Year
        InventoryID = _InventoryID
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Rpt_InvListStock_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        FillDataAdapter()
    End Sub

    Sub FillDataAdapter()
        Try


            Me.Sp_MDInventory_GetDataSyncList_ReportTableAdapter1.ClearBeforeFill = True


            Me.Sp_MDInventory_GetDataSyncList_ReportTableAdapter1.Fill(Me.DataSet1.sp_MDInventory_GetDataSyncList_Report, 0, 0, InventoryID)
        Catch ex As Exception

        End Try
    End Sub
End Class