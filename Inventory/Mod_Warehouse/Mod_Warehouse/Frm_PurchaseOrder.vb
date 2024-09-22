Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Frm_PurchaseOrder

    Dim _User As String = ""
    Dim TempNo As String


#Region "Variables"
    Private isNew As Boolean
    Dim isUpdate As Boolean = False
    Dim userModified As String
    Dim RowFocus As Integer
    Dim dt As DataTable

#End Region



    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

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

    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub 'New
        Public View As GridView
        Public RowHandle As Integer
    End Class


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Frm_PurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dataset.sp_LookUpData_GetUsage' table. You can move, or remove it, as needed.
        Me.Sp_LookUpData_GetUsageTableAdapter.Fill(Me.Dataset.sp_LookUpData_GetUsage)

        Date_Request.DateTime = Now
        Dt_Start.DateTime = DateAdd(DateInterval.Day, -7, Now)
        Dt_End.DateTime = Now

        LCItem_NewTransaction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        SB_Search.PerformClick()
    End Sub

    Sub RefreshData()
        Me.Sp_SPPurchaseOrderDetail_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseOrderDetail_GetData, Ed_TransactionNo.EditValue.ToString())
        Label_Subtotal.Text = "Rp. " + String.Format("{0:#,##0}", colSubtotal_Detail.SummaryItem.SummaryValue)



        LCItem_NewTransaction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Sub ClearData()
        Memo_Description.EditValue = ""
        Ed_Subtotal.EditValue = 0
    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        Dim isError As Boolean = False
        Try
            If (Memo_Description.EditValue.ToString() = "") Then
                AlertControl.Show(Me, "Error on Input Data", "Barang masih belum terisi")
                isError = True
                Exit Sub
            ElseIf CInt(Ed_Subtotal.EditValue) <= 0 Then
                AlertControl.Show(Me, "Error on Input Data", "Qty Harus di atas 0")
                isError = True
                Exit Sub

            End If

            Me.QueriesTableAdapter.sp_SPPurchaseOrderDetail_InsData(Ed_TransactionNo.EditValue.ToString(),
                                                                    Memo_Description.EditValue.ToString(),
                                                                    CInt(Ed_Subtotal.EditValue),
                                                                    _User)



            SB_Search.PerformClick()
            RefreshData()
            ClearData()

            If (isError) Then

                Exit Sub
            End If
        Catch ex As Exception
            If (ex.Message.ToString().Contains("Violation of PRIMARY KEY constraint")) Then
                MessageBox.Show("Barang Sudah Diinput dalam transaksi ini")
            Else

                MessageBox.Show(ex.Message.ToString)
            End If
        End Try
    End Sub

    Private Sub SB_Search_Click(sender As Object, e As EventArgs) Handles SB_Search.Click

        Me.Sp_SPPurchaseOrderHeader_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseOrderHeader_GetData, Dt_Start.DateTime, Dt_End.DateTime)

    End Sub

    Private Sub GV_Detail_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Detail.ValidateRow
        Try
            Dim MaterialReceiveID As Integer

            Dim isError As Boolean = False
            'If IsDBNull(SearchLookUpEdit_Inventory.EditValue) Then
            '    AlertControl.Show(Me, "Error on Input Data", "Barang masih belum terisi")
            '    IsError = True
            '    Exit Sub
            'ElseIf CDec(Ed_QtyInventory.EditValue) <= 0 Then
            '    AlertControl.Show(Me, "Error on Input Data", "Qty Harus di atas 0")
            '    IsError = True
            '    Exit Sub
            'End If

            If (isError = False) Then

                Try
                    GV_Detail.ClearColumnErrors()
                    e.Valid = True


                    'If (CInt(GV_Detail.GetRowCellValue(e.RowHandle, colQty_Detail)) <= 0) Then
                    '    GV_Detail.SetColumnError(colQty_Detail, "Qty cannot be 0")
                    '    e.Valid = False
                    'End If
                    If CDec(GV_Detail.GetRowCellValue(GV_Detail.FocusedRowHandle, colSubtotal_Detail)) <= 0 Then
                        e.Valid = False
                        AlertControl.Show(Me, "Error on Input Data", "Item Harus Di atas 0")
                    End If

                    If (e.Valid = False) Then
                        Exit Sub
                    End If


                    Me.Validate()

                    Me.SpSPPurchaseOrderDetailGetDataBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Dataset)
                    Me.Sp_SPPurchaseOrderDetail_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseOrderDetail_GetData, Date_Request.DateTime)


                    AlertControl.Show(Me, "Success", "Berhasil Dirubah")
                    RefreshData()
                    'If (GVMaterialReceive_Detail.RowCount < 1) Then
                    '    Me.MasterQueriesTableAdapter.sp_SPMaterialReceiveHeaderDelData(Ed_MRVCode.EditValue, Dt_MRVDate.DateTime)
                    'End If
                Catch ex As Exception
                    If (ex.Message.ToString() = "This SqlTransaction has completed; it is no longer usable.") Then
                        MessageBox.Show("Barang Sudah Diinput dalam transaksi ini")
                    Else

                        MessageBox.Show(ex.Message.ToString)
                    End If

                    Me.Sp_SPPurchaseOrderDetail_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseOrderDetail_GetData, Date_Request.DateTime)

                End Try






            Else
                AlertControl.Show(Me, "Error on Input Data", "Input Value is not Valid")
                Exit Sub
                '           End If
            End If

        Catch ex As Exception
            AlertControl.Show(Me, "Error on Input Data", ex.Message)
        End Try
    End Sub

    Private Sub SB_ReportDaily_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GV_Header_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GV_Header.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle()
            e.Menu.Items.Clear()

            Dim menuDetail As New DXMenuItem("&Detail Barang",
          AddressOf OnDetail, ImageCollection.Images(0))
            menuDetail.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuDetail)
            Dim menuReportDaily As New DXMenuItem("&Laporan Harian",
         AddressOf OnReportDaily, ImageCollection.Images(0))
            menuReportDaily.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuReportDaily)
        Else


        End If
    End Sub
    Sub OnDetail(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Header.FocusedRowHandle

        Ed_TransactionNo.EditValue = GV_Header.GetRowCellValue(RowFocus, colPONo_Header)
        LookUp_Usage.EditValue = GV_Header.GetRowCellValue(RowFocus, colUsageID)
        Date_Request.EditValue = GV_Header.GetRowCellValue(RowFocus, colPODate_Header)

        LCGroup_Header.Enabled = False
        LCGroup_List.Enabled = True
        LCGroup_Detail.Enabled = True

        RefreshData()
    End Sub

    Sub OnReportDaily(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Header.FocusedRowHandle
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_PurchaseOrder_Daily(GV_Header.GetRowCellValue(RowFocus, colPODate_Header))
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click


        LCItem_NewTransaction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LookUp_Usage.EditValue = Nothing
        Date_Request.DateTime = Now

        LCGroup_Header.Enabled = True
        LCGroup_List.Enabled = False
        LCGroup_Detail.Enabled = False

    End Sub

    Private Sub SB_New_Click(sender As Object, e As EventArgs) Handles SB_New.Click

        Try
            Dim isError As Boolean = False
            If IsNothing(LookUp_Usage.EditValue) Then
                AlertControl.Show(Me, "Error on Input Data", "Keperluan Belum dipilih")
                isError = True
                Exit Sub
            End If

            TempNo = Me.QueriesTableAdapter.sp_SPPurchaseOrderHeader_InsData(Date_Request.DateTime, CInt(LookUp_Usage.EditValue), userModified)
            If (TempNo = "101") Then
                Throw New ApplicationException("Transaksi Sudah Ada")
            ElseIf (Len(TempNo) = 10) Then
                Ed_TransactionNo.EditValue = TempNo
            Else
                Throw New ApplicationException("Error")

            End If
            LCGroup_Header.Enabled = False
            LCGroup_List.Enabled = True
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Input Data", ex.Message)
        End Try

    End Sub

    Private Sub GV_Detail_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GV_Detail.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle()
            e.Menu.Items.Clear()

            Dim menuDelete As New DXMenuItem("&Hapus Barang",
          AddressOf OnDelete, ImageCollection.Images(0))
            menuDelete.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuDelete)

        Else


        End If
    End Sub

    Sub OnDelete(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Detail.FocusedRowHandle

        GV_Detail.DeleteRow(RowFocus)

        Me.Validate()

        Me.SpSPPurchaseOrderDetailGetDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Dataset)
        Me.Sp_SPPurchaseOrderDetail_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseOrderDetail_GetData, Date_Request.DateTime)


        AlertControl.Show(Me, "Success", "Berhasil Dihapus")

        RefreshData()
    End Sub
End Class