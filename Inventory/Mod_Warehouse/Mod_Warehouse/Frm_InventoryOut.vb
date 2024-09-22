Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraReports.UI

Public Class Frm_InventoryOut

    Dim _User As String




    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal _Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon

        My.Settings.Item("ConnectionString") = ConnString
        My.Settings.UserName = _Username

        _User = _Username

    End Sub

    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function


    Private Sub Frm_InventoryOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEdit_Date.DateTime = Now
        Ed_EmployeeName.EditValue = ""

        'TODO: This line of code loads data into the 'Dataset.sp_SPGetData_Employee' table. You can move, or remove it, as needed.
        Me.Sp_SPGetData_EmployeeTableAdapter.Fill(Me.Dataset.sp_SPGetData_Employee)
        'TODO: This line of code loads data into the 'Dataset.sp_MDInventory_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetData, 1)

        SB_Refreh.PerformClick()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        DateEdit_Time.DateTime = Now
    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        Try
            If IsNothing(SearchLookUpEdit_Employee.EditValue) Then
                AlertControl.Show(Me, "Error on Input Data", "Supplier masih belum terisi")
                Exit Sub
            ElseIf IsNothing(SearchLookUpEdit_Inventory.EditValue) Then
                AlertControl.Show(Me, "Error on Input Data", "Barang masih belum terisi")
                Exit Sub
            End If


            Me.QueriesTableAdapter.sp_SPInventoryOut_InsData(CDate(DateEdit_Date.EditValue),
                                                         CInt(SearchLookUpEdit_Employee.EditValue),
                                                         Ed_EmployeeName.EditValue.ToString(),
                                                         CInt(SearchLookUpEdit_Inventory.EditValue),
                                                         CInt(Ed_QtyInv.EditValue),
                                                         _User)

            SB_Refreh.PerformClick()
            ClearData()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub SB_Refreh_Click(sender As Object, e As EventArgs) Handles SB_Refreh.Click
        Me.Sp_SPInventoryOut_GetData2TableAdapter1.Fill(Me.Dataset.sp_SPInventoryOut_GetData2, DateEdit_Date.DateTime)
        Me.Sp_SPInventoryOut_GetData1TableAdapter1.Fill(Me.Dataset.sp_SPInventoryOut_GetData1, DateEdit_Date.DateTime)
    End Sub

    Sub ClearData()
        SearchLookUpEdit_Employee.EditValue = Nothing
        Ed_BarcodeEmployee.EditValue = ""
        Ed_EmployeeName.EditValue = ""

        Ed_BarcodeInventory.EditValue = ""
        Ed_QtyInv.EditValue = 0
        SearchLookUpEdit_Inventory.EditValue = Nothing
    End Sub

    Private Sub SB_Report_Click(sender As Object, e As EventArgs) Handles SB_Report.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_TransactionOut_Daily(DateEdit_Date.DateTime)
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub SearchLookUpEdit_Employee_View_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles SearchLookUpEdit_Employee_View.RowCellClick
        Ed_EmployeeName.EditValue = SearchLookUpEdit_Employee_View.GetFocusedRowCellValue(colEmployeeName)
    End Sub

    Private Sub SB_RefreshInv_Click(sender As Object, e As EventArgs) Handles SB_RefreshInv.Click
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetData, 1)
    End Sub
End Class