Imports DevExpress.Utils.Menu
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class Frm_PurchaseReceivement

    Dim editor_Inv, editor_Sup As TextEdit
    Dim RowFocus As Integer

    Dim UserModified As String
    Dim isNew As Boolean = False

    Dim TempUoM As Integer = 0


    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub 'New
        Public View As GridView
        Public RowHandle As Integer
    End Class


    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl



    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub

    Public Sub New()
        InitializeComponent()
        DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
        DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)
    End Sub

    Public Sub New(ByVal ConnString As String, ByVal Source As String, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        My.Settings.Item("ConnectionString") = ConnString
        MRNoTextEdit.Tag = 0
        DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
        DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)
        DataSet.sp_SPPurchaseReceiveHeader_GetData.Columns("ID").DefaultValue = 0
        DataSet.sp_SPPurchaseReceiveHeader_GetData.Columns("PRVNo").DefaultValue = "AUTO"

        DataSet.sp_SPPurchaseReceiveHeader_GetData.Columns("PRVDate").DefaultValue = Today

    End Sub
    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        My.Settings.Item("ConnectionString") = ConnString
        MRNoTextEdit.Tag = 0
        DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
        DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)
        DataSet.sp_SPPurchaseReceiveHeader_GetData.Columns("ID").DefaultValue = 0
        DataSet.sp_SPPurchaseReceiveHeader_GetData.Columns("PRVNo").DefaultValue = "AUTO"

        DataSet.sp_SPPurchaseReceiveHeader_GetData.Columns("PRVDate").DefaultValue = Today

    End Sub

    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function

    Function ValidationCheck() As Boolean

        DxErrorProvider.ClearErrors()
        'If (LookUpEdit_Warehouse.Text = "") Then
        '    DxErrorProvider.SetError(LookUpEdit_Warehouse, "Warehouse cannot be empty")
        'End If
        If (SearchLookUpEdit_Supplier.Text = "") Then
            DxErrorProvider.SetError(SearchLookUpEdit_Supplier, "Supplier cannot be empty")
        End If


        If (DxErrorProvider.HasErrors) Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub Frm_SPPurchaseReceiveCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_SP_MDUoMDetail_GetData' table. You can move, or remove it, as needed.
        Me.Sp_SP_MDUoMDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_SP_MDUoMDetail_GetData)
        'TODO: This line of code loads data into the 'DataSet.sp_SP_MDUsage_GetData' table. You can move, or remove it, as needed.


        Me.Sp_SP_MDSupplier_GetDataTableAdapter.Fill(Me.DataSet.sp_LookUpData_GetSupplier, "S")
        ''LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        HomeLayout()

        SB_Refresh.PerformClick()
        'DxErrorProvider1.ClearErrors()
        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "/" & My.Settings.Username
        DataSet.sp_SPPurchaseReceiveHeader_GetData.Columns("ModifiedUser").DefaultValue = UserModified

        DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("ModifiedUser").DefaultValue = UserModified
        XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
    End Sub

    Private Sub FillDataAdapter()
        Try
            Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveHeader_GetData, (DateEditStart.DateTime), (DateEditEnd.DateTime))

            '   Me.Sp_SPPurchaseReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub HomeLayout()
        XtraTabControl1.SelectedTabPageIndex = 0
        FillDataAdapter()
    End Sub

    Private Sub DetailLayout()
        XtraTabControl1.SelectedTabPageIndex = 1

    End Sub


    Private Sub GV_Header_RowClick(sender As Object, e As RowClickEventArgs) Handles GV_Header.RowClick
        RowFocus = e.RowHandle
    End Sub

    Private Sub GV_Header_DoubleClick(sender As Object, e As EventArgs) Handles GV_Header.DoubleClick

        GV_Detail.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
        Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveDetail_GetData, CInt(GV_Header.GetRowCellValue(GV_Header.GetSelectedRows(0), colID_Header)))
        Sp_SPPurchase_GetInventoryDataTableAdapter.Fill(Me.DataSet.sp_LookUpData_GetInventory, 23, 0, 0)

        DetailLayout()

        LCItem_Grid.Enabled = True
        LCItem_SBContinue.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        isNew = False

        Label_JumlahJenis.Text = colInventoryID_Detail.SummaryItem.SummaryValue.ToString + " Jenis"
        Ed_GrossTotal.EditValue = CInt(colSubtotal_Detail.SummaryItem.SummaryValue)
        CalculateSummary()

    End Sub


    Private Sub DateEditEnd_Leave(sender As Object, e As EventArgs)
        FillDataAdapter()
    End Sub


    Private Sub GV_Detail_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Detail.ValidateRow
        Try
            Dim MaterialReceiveID As Integer
            If (ValidationCheck()) Then
                If (isNew) Then
                    ' LCItem_Grid.Enabled = False

                    ' MRNoTextEdit.EditValue = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(1, "AUTO", 23, MRDateDateEdit.DateTime)
                    '        MRNoTextEdit.Tag = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(0, "AUTO", 23, MRDateDateEdit.DateTime)
                End If


                '       Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveHeader_GetData, (DateEditStart.DateTime), (DateEditEnd.DateTime))




                Try
                    GV_Detail.ClearColumnErrors()
                    e.Valid = True


                    'If (CInt(GV_Detail.GetRowCellValue(e.RowHandle, colQty_Detail)) <= 0) Then
                    '    GV_Detail.SetColumnError(colQty_Detail, "Qty cannot be 0")
                    '    e.Valid = False
                    'End If
                    If IsDBNull(GV_Detail.GetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colInventoryID_Detail)) Then
                        e.Valid = False
                        AlertControl.Show(Me, "Error on Input Data", "Item Kosong")
                    End If

                    If (e.Valid = False) Then
                        Exit Sub
                    End If
                    If (e.RowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle) Then

                        DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("MRID").DefaultValue = CInt(MRNoTextEdit.Tag)

                        GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colMRID_Detail, CInt(MRNoTextEdit.Tag))
                        GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colisInventory_Detail, 1)

                    End If

                    Me.Validate()

                    Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.DataSet)
                    Me.Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveDetail_GetData, CInt(MRNoTextEdit.Tag))

                    Label_JumlahJenis.Text = colInventoryID_Detail.SummaryItem.SummaryValue.ToString + " Jenis"
                    Ed_GrossTotal.EditValue = CInt(colSubtotal_Detail.SummaryItem.SummaryValue)

                    CalculateSummary()

                    'If (GVMaterialReceive_Detail.RowCount < 1) Then
                    '    Me.MasterQueriesTableAdapter.sp_SPPurchaseReceiveHeaderDelData(Ed_MRVCode.EditValue, Dt_MRVDate.DateTime)
                    'End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try






                'If (MRNoTextEdit.EditValue = "AUTO") Then
                '    Dim MRVCode As String

                '    Me.Sp_SPPurchaseReceiveDetailGetDataBindingSource.EndEdit()
                '    Me.TableAdapterManager.UpdateAll(Me.DataSet)

                '    Me.MasterQueriesTableAdapter.sp_SPPurchaseReceiveHeaderInsData(MRVCode, Dt_MRVDate.DateTime, 0, LookUpEdit_Warehouse.EditValue,
                '                                                     CInt(SearchLookUpEdit_Supplier.EditValue), SearchLookUpEdit_Supplier.Text, Ed_SupplierName.EditValue, Ed_SupplierAddress.EditValue, Ed_SupplierCity.EditValue,
                '                                                 0, Ed_DONo.Text, "", Ed_DriverName.Text, Ed_VehicleNo.Text,
                '                                                "IDR", CDec(0), 0, CDec(Ed_GrandTotal.EditValue), Ed_Remark.Text, UserModified)

                '    MaterialReceiveID = CInt(Me.MasterQueriesTableAdapter.sp_SPPurchaseReceiveHeaderGetIDMaterialReceive(MRVCode).ToString())
                '    Ed_MRVCode.Tag = MaterialReceiveID
                '    Ed_MRVCode.EditValue = MRVCode
                '    DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("MaterialReceiveID").DefaultValue = MaterialReceiveID
                '    '  Me.MasterQueriesTableAdapter.sp_SPMRVCashDetailInsData(MRVID, GVMaterialReceive_Detail.GetFocusedRowCellValue(colisInventory1))
                'Else

                '    MaterialReceiveID = CInt(Me.MasterQueriesTableAdapter.sp_SPPurchaseReceiveHeaderGetIDMaterialReceive(Ed_MRVCode.EditValue).ToString())
                '    Ed_MRVCode.Tag = MaterialReceiveID
                'End If

                'Else
                '    Me.MasterQueriesTableAdapter.sp_SPPurchaseReceiveHeaderUpdData(0, CInt(Ed_MRVCode.Tag), Ed_MRVCode.EditValue, Dt_MRVDate.DateTime, LookUpEdit_Warehouse.EditValue,
                '                                                     SearchLookUpEdit_Supplier.EditValue, SearchLookUpEdit_Supplier.Text, Ed_SupplierName.EditValue, Ed_SupplierAddress.EditValue, Ed_SupplierCity.EditValue,
                '                                                   0, Ed_DONo.EditValue, "", Ed_DriverName.EditValue, Ed_VehicleNo.EditValue,
                '                                                  "IDR", 0, 0, CInt(Ed_GrandTotal.EditValue), Ed_Remark.EditValue, UserModified)
                '    AlertControl1.Show(Me, "Success On Update Data", Ed_MRVCode.EditValue)

                'End If
                'ComponentStatus(2)
                'CalculateSummary()

            Else
                AlertControl.Show(Me, "Error on Input Data", "Input Value is not Valid")
                Exit Sub
                '           End If
            End If

        Catch ex As Exception
            AlertControl.Show(Me, "Error on Input Data", ex.Message)
        End Try
    End Sub
    Sub CalculateSummary()


        Ed_NetValue.EditValue = CInt(Ed_GrossTotal.EditValue) +
                                   CInt(IIf(IsDBNull(Ed_PPnValue.EditValue), 0, Ed_PPnValue.EditValue)) -
                                   CInt(IIf(IsDBNull(Ed_DiscValue.EditValue), 0, Ed_DiscValue.EditValue))
        Ed_Diskon.EditValue = CInt(IIf(IsDBNull(Ed_DiscValue.EditValue), 0, Ed_DiscValue.EditValue))
        Ed_Balance.EditValue = CInt(Ed_NetValue.EditValue) - CInt(Ed_DP.EditValue)
    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        FillDataAdapter()
    End Sub

    Private Sub GV_Detail_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GV_Detail.InitNewRow
        DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("MRID").DefaultValue = CInt(MRNoTextEdit.Tag)
    End Sub

    Private Sub Repo_SearchInventory_Detail_Popup(sender As Object, e As EventArgs) Handles SearchLUE_Inv.Popup
        '    editor_Inv = TryCast(TryCast(sender, IPopupControl).PopupWindow.Controls(2).Controls(0).Controls(7), TextEdit)

    End Sub

    Private Sub SearchLookUpEdit_Supplier_AddNewValue(sender As Object, e As Controls.AddNewValueEventArgs) Handles SearchLookUpEdit_Supplier.AddNewValue
        Try
            Dim NewSupplierForm As New Frm_InputSupplier("-")
            If (NewSupplierForm.ShowDialog() = DialogResult.Cancel) Then
                NewSupplierForm.Dispose()
            Else
                Me.Sp_LookUpData_GetSupplierTableAdapter.Fill(Me.DataSet.sp_LookUpData_GetSupplier)
                NewSupplierForm.Dispose()

            End If
        Catch ex As Exception
            AlertControl.Show(Me, "Refresh", ex.Message)
        End Try

    End Sub

    Private Sub SearchLookUpEdit_Supplier_Popup(sender As Object, e As EventArgs) Handles SearchLookUpEdit_Supplier.Popup
        'editor_Sup =  TryCast(TryCast(sender, IPopupControl).PopupWindow.Controls(2).Controls(0).Controls(7), TextEdit)

    End Sub

    Private Sub GV_Detail_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GV_Detail.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim menuItemDeleteRow As New DXMenuItem("&Delete Row",
          AddressOf OnDeleteRowDetail, ImageCollection1.Images(0))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemDeleteRow)
        End If
    End Sub


    Sub OnDeleteRowDetail(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Detail.FocusedRowHandle
        Dim DeletedVar1 As String

        DeletedVar1 = GV_Detail.GetRowCellValue(RowFocus, colInventoryID_Detail).ToString
        Try
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim info As RowInfo = CType(item.Tag, RowInfo)

            If MessageBox.Show("Are you sure you want to delete data?", "Confirmation", MessageBoxButtons.YesNoCancel) = MsgBoxResult.Yes Then
                info.View.DeleteRow(info.RowHandle)
                Me.Validate()
                Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSet)
                '      SaveData("Delete", DeletedVar1)
            Else
                'BtnRefresh.PerformClick()
                'AlertControl1.Show(Me, "Cancel on Delete Data", DeletedVar1)
            End If
            AlertControl.Show(Me, "Success on Delete Data", DeletedVar1)
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Delete Data", ex.Message)
        End Try
    End Sub

    Private Sub GV_Detail_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GV_Detail.ShowingEditor
        If (GV_Detail.FocusedColumn.FieldName = "InventoryID" And GV_Detail.IsNewItemRow(GV_Detail.FocusedRowHandle) = False) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Repo_SearchInventory_DetailView_RowCellClick(sender As Object, e As RowCellClickEventArgs)
        'Dim TempPrice = CInt(sender.GetRowCellValue(e.RowHandle, colPrice_Repo))
        'TempUoM = CInt(sender.GetRowCellValue(e.RowHandle, colUoMID_Repo))
        'DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("UoM").DefaultValue = TempUoM
        'DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("Price").DefaultValue = TempPrice
        'GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colUoM_Detail, CInt(TempUoM))
        'GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colPrice_Detail, CInt(TempPrice))

    End Sub

    Private Sub SB_Continue_Click(sender As Object, e As EventArgs) Handles SB_Continue.Click

        LCItem_Grid.Enabled = True
        MRNoTextEdit.EditValue = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(1, "AUTO", 23, MRDateDateEdit.DateTime)

        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.EndEdit()
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

        MRNoTextEdit.Tag = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(0, MRNoTextEdit.EditValue.ToString, 23, MRDateDateEdit.DateTime)
        'Sp_SPPurchase_GetInventoryDataTableAdapter.Fill(Me.DataSet.sp_SPPurchase_GetInventoryData, 23, 0, CInt(IIf(IsDBNull(SearchLookUpEdit1.EditValue), 0, SearchLookUpEdit1.EditValue)))

        '  Sp_SPPurchaseReceiveHeader_GetDataGridControl.DataSource = Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource
        'Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveHeader_GetData, (MRDateDateEdit.DateTime), (MRDateDateEdit.DateTime))
        isNew = True

        LCItem_CreateNew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LCItem_SBContinue.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub ComboBoxEdit_Payment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit_Payment.SelectedIndexChanged
        If (ComboBoxEdit_Payment.SelectedIndex = 1) Then
            LCItem_DueDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCItem_LongTerm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCItem_LabelHari.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LCItem_DueDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCItem_LongTerm.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCItem_LabelHari.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub GV_Detail_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_Detail.CellValueChanged

        If e.Column() Is colSubtotal_Detail Then
            GV_Detail.SetRowCellValue(e.RowHandle, colPrice_Detail, CDec(e.Value) /
                                            CInt(GV_Detail.GetRowCellValue(e.RowHandle, colQty_Detail)))
        End If
    End Sub

    Private Sub Ed_DP_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_PPnValue.EditValueChanged, Ed_DP.EditValueChanged, Ed_DiscValue.EditValueChanged
        '     CalculateSummary()

    End Sub

    Private Sub Ed_Termin_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_Termin.EditValueChanged
        Dt_Termin.DateTime = MRDateDateEdit.DateTime.AddDays(CInt(IIf(IsDBNull(Ed_Termin.EditValue), 0, Ed_Termin.EditValue)))

    End Sub

    Private Sub SB_CreateNew_Click(sender As Object, e As EventArgs) Handles SB_CreateNew.Click

        Try


            Dim TempDate As Date
            TempDate = MRDateDateEdit.DateTime

            Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.EndEdit()
            Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource.EndEdit()
            Me.Validate()
            Me.TableAdapterManager.UpdateAll(Me.DataSet)


            Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveDetail_GetData, -1)
            Sp_SPPurchaseReceiveHeader_GetDataBindingSource.AddNew()

            MRNoTextEdit.EditValue = "AUTO"
            ComboBoxEdit_Payment.SelectedIndex = 0

            MRDateDateEdit.DateTime = TempDate

            GV_Detail.OptionsView.NewItemRowPosition = NewItemRowPosition.Top

            LCItem_Grid.Enabled = False

            LCItem_SBContinue.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            isNew = True
        Catch ex As Exception
            AlertControl.Show(Me, "Refresh", ex.Message)
        End Try
    End Sub

    Private Sub SB_Cash_Click(sender As Object, e As EventArgs) Handles SB_Cash.Click
        Try
            Dim NewCashPayment As New PopUp_CashPayment(CInt(Ed_Balance.EditValue), CInt(MRNoTextEdit.Tag), MRNoTextEdit.EditValue.ToString,
                                                        CInt(SearchLookUpEdit_Supplier.EditValue), SearchLookUpEdit_Supplier.Text,
                                                        MRDateDateEdit.DateTime)
            If (NewCashPayment.ShowDialog() = DialogResult.Cancel) Then
                NewCashPayment.Dispose()
            Else

                NewCashPayment.Dispose()
                If (MsgBox("Transaksi telah berhasil dilunasi, apakah anda ingin melanjutkan transaksi penerimaan",
                       MsgBoxStyle.OkCancel,
                        "Transaksi Berhasil")) = MsgBoxResult.Ok Then
                    SB_CreateNew.PerformClick()
                Else
                    SB_Back.PerformClick()
                End If
            End If
        Catch ex As Exception
            AlertControl.Show(Me, "Refresh", ex.Message)
        End Try
    End Sub

    Private Sub CE_DiscPercentage_CheckedChanged(sender As Object, e As EventArgs) Handles CE_MultiDisc.CheckedChanged

    End Sub

    Private Sub Ed_DiscPercentage_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_DiscPercentage.EditValueChanged

    End Sub

    Private Sub SB_Summary_Click(sender As Object, e As EventArgs) Handles SB_Summary.Click

        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_PReceivement_Summary(DateEditStart.DateTime)
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub DateEditStart_EditValueChanged(sender As Object, e As EventArgs) Handles DateEditStart.EditValueChanged, DateEditEnd.EditValueChanged
        FillDataAdapter()
    End Sub

    Private Sub SB_Exit_Click(sender As Object, e As EventArgs) Handles SB_Exit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub SB_New_Click(sender As Object, e As EventArgs) Handles SB_New.Click
        Try
            Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveDetail_GetData, -1)
            DetailLayout()
            Sp_SPPurchaseReceiveHeader_GetDataBindingSource.AddNew()
            MRNoTextEdit.EditValue = "AUTO"
            ComboBoxEdit_Payment.SelectedIndex = 0

            MRDateDateEdit.DateTime = Now

            GV_Detail.OptionsView.NewItemRowPosition = NewItemRowPosition.Top

            LCItem_Grid.Enabled = False
            LCItem_CreateNew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCItem_SBContinue.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            SB_Continue.Visible = True
            'Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_SPPurchaseReceiveDetail_GetData, -1)
            isNew = True

        Catch ex As Exception
            AlertControl.Show(Me, "New Procedure", ex.Message)
        End Try
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            DxErrorProvider.ClearErrors()

            'Sp_SPPurchaseReceiveDetail_GetDataBindingSource.CancelEdit()
            'Sp_SPPurchaseReceiveHeader_GetDataBindingSource.CancelEdit()
            '    Sp_SPPurchaseReceiveHeader_GetDataGridControl.DataSource = Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource

            HomeLayout()
        Catch ex As Exception
            AlertControl.Show(Me, "Check On btnBack_ItemClick()", ex.Message)
        Finally


            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub SB_SupRefresh_Click(sender As Object, e As EventArgs) Handles SB_SupRefresh.Click
        Me.Sp_SP_MDSupplier_GetDataTableAdapter.Fill(Me.DataSet.sp_LookUpData_GetSupplier)

    End Sub

    Private Sub Ed_PPnPercetage_Leave(sender As Object, e As EventArgs) Handles Ed_PPnPercetage.Leave

        If IsDBNull(Ed_PPnPercetage.EditValue) Then
        Else

            Ed_PPnValue.EditValue = CInt((Ed_GrossTotal.EditValue) * Ed_PPnPercetage.EditValue / 100)

            CalculateSummary()
        End If
    End Sub

    Private Sub RepositoryItemSearchLookUpEdit1View_RowClick(sender As Object, e As RowClickEventArgs) Handles RepositoryItemSearchLookUpEdit1View.RowClick
        Dim TempPrice = CInt(sender.GetRowCellValue(e.RowHandle, colPrice_Repo))
        TempUoM = CInt(sender.GetRowCellValue(e.RowHandle, colUoMID_Repo))
        DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("UoMID").DefaultValue = TempUoM
        DataSet.sp_SPPurchaseReceiveDetail_GetData.Columns("Price").DefaultValue = TempPrice
        GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colUoM_Detail, CInt(TempUoM))
        GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colPrice_Detail, CInt(TempPrice))
    End Sub

    Private Sub SB_Save_Click(sender As Object, e As EventArgs) Handles SB_Save.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            DxErrorProvider.ClearErrors()

            If (isNew = False) Then
                Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.EndEdit()
                Me.Validate()
                Me.TableAdapterManager.UpdateAll(Me.DataSet)
            Else

                '    Sp_SPPurchaseReceiveHeader_GetDataGridControl.DataSource = Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource
            End If

        Catch ex As Exception
            AlertControl.Show(Me, "Check On btnBack_ItemClick()", ex.Message)
        Finally


            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub SB_Apply_Click(sender As Object, e As EventArgs) Handles SB_Apply.Click
        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.EndEdit()
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)
    End Sub

    Private Sub Repo_SearchInventory_Detail_AddNewValue(sender As Object, e As DevExpress.XtraEditors.Controls.AddNewValueEventArgs) Handles SearchLUE_Inv.AddNewValue
        Try
            If (RepositoryItemSearchLookUpEdit1View.RowCount = 0) Then
                Dim NewInventoryForm As New Frm_InputInventory("")
                If (NewInventoryForm.ShowDialog() = DialogResult.Cancel) Then
                    NewInventoryForm.Dispose()
                Else
                    Me.Sp_LookUpData_GetInventoryTableAdapter.Fill(Me.DataSet.sp_LookUpData_GetInventory, 0)
                    NewInventoryForm.Dispose()
                End If
            End If
        Catch ex As Exception
            AlertControl.Show(Me, "Refresh", ex.Message)
        End Try
    End Sub
End Class