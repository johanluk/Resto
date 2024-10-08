<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Purchasing
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Purchasing))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset = New Mod_Purchase.Dataset()
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRVID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRVNo_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisInventory_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeight_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUoMID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPersen1_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPersen2_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPersen3_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_DetailPO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_DetailPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID_DetailPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty_DetailPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice_DetailPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierID_DetailPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_InvDetailPO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpLookUpDataGetInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Repo_LUE_SuppDetailPO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpLookUpDataGetSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Header = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRVNo_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRVDate_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Supplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPaymentType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDownPayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisVoid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisPaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransporter = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDriverName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVehicleNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoFaktur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisMultiDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPPnPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPPnValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLongTerm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrandTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_SearchInventory = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInventoryName_Search = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastPrice_Search = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokAkhir_Search = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComboBox_Month = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DateEditStart = New DevExpress.XtraEditors.DateEdit()
        Me.DateEditEnd = New DevExpress.XtraEditors.DateEdit()
        Me.SearchControl11 = New DevExpress.XtraEditors.SearchControl()
        Me.SB_MonthlyReport = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Summary = New DevExpress.XtraEditors.SimpleButton()
        Me.MRNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_NoFaktur = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_LongTerm = New DevExpress.XtraEditors.SpinEdit()
        Me.Dt_DueDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MRDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.Ed_NoDo = New DevExpress.XtraEditors.TextEdit()
        Me.CE_PPn = New DevExpress.XtraEditors.CheckEdit()
        Me.Ed_PPn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.LUE_SupplierCity = New DevExpress.XtraEditors.LookUpEdit()
        Me.SearchLookUpEdit_Supplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GV_Supplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Supp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName_Supp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Supp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LUE_SupplierAddress = New DevExpress.XtraEditors.LookUpEdit()
        Me.SB_AddSupplier = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_InvRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_QtyInput = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Search = New DevExpress.XtraEditors.TextEdit()
        Me.SB_Continue = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCGroup_Det = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_PPn = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_SBContinue = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_SaveUpdateHeader = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_Header = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LCItem_Month = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_DateStart = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_DateEnd = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_SPPurchaseReceiveHeader_GetDataTableAdapter()
        Me.TableAdapterManager = New Mod_Purchase.DatasetTableAdapters.TableAdapterManager()
        Me.Sp_LookUpData_GetSupplierTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetSupplierTableAdapter()
        Me.Sp_LookUpData_GetInventoryTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetInventoryTableAdapter()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_SPPurchaseReceiveDetail_GetPOInvTableAdapter()
        Me.Sp_SPPurchaseReceiveDetail_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_SPPurchaseReceiveDetail_GetDataTableAdapter()
        Me.LCGroup_Supplier = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SB_CreateNew = New DevExpress.XtraEditors.SimpleButton()
        Me.LCItem_CreateNew = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SB_SupRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DetailPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_InvDetailPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_SuppDetailPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_SearchInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox_Month.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_NoFaktur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_LongTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_DueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_DueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_NoDo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_PPn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PPn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_SupplierCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_SupplierAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_QtyInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_PPn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_SBContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_SaveUpdateHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_Month, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_CreateNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1283, 681)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1259, 657)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1257, 629)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SB_CreateNew)
        Me.LayoutControl2.Controls.Add(Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl)
        Me.LayoutControl2.Controls.Add(Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl)
        Me.LayoutControl2.Controls.Add(Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl)
        Me.LayoutControl2.Controls.Add(Me.ComboBox_Month)
        Me.LayoutControl2.Controls.Add(Me.DateEditStart)
        Me.LayoutControl2.Controls.Add(Me.DateEditEnd)
        Me.LayoutControl2.Controls.Add(Me.SearchControl11)
        Me.LayoutControl2.Controls.Add(Me.SB_MonthlyReport)
        Me.LayoutControl2.Controls.Add(Me.SB_Summary)
        Me.LayoutControl2.Controls.Add(Me.MRNoTextEdit)
        Me.LayoutControl2.Controls.Add(Me.Ed_NoFaktur)
        Me.LayoutControl2.Controls.Add(Me.Ed_LongTerm)
        Me.LayoutControl2.Controls.Add(Me.Dt_DueDate)
        Me.LayoutControl2.Controls.Add(Me.Label11)
        Me.LayoutControl2.Controls.Add(Me.MRDateDateEdit)
        Me.LayoutControl2.Controls.Add(Me.Ed_NoDo)
        Me.LayoutControl2.Controls.Add(Me.CE_PPn)
        Me.LayoutControl2.Controls.Add(Me.Ed_PPn)
        Me.LayoutControl2.Controls.Add(Me.LabelControl11)
        Me.LayoutControl2.Controls.Add(Me.SB_Back)
        Me.LayoutControl2.Controls.Add(Me.LUE_SupplierCity)
        Me.LayoutControl2.Controls.Add(Me.SearchLookUpEdit_Supplier)
        Me.LayoutControl2.Controls.Add(Me.LUE_SupplierAddress)
        Me.LayoutControl2.Controls.Add(Me.SB_AddSupplier)
        Me.LayoutControl2.Controls.Add(Me.SB_InvRefresh)
        Me.LayoutControl2.Controls.Add(Me.Ed_QtyInput)
        Me.LayoutControl2.Controls.Add(Me.Ed_Search)
        Me.LayoutControl2.Controls.Add(Me.SB_Continue)
        Me.LayoutControl2.Controls.Add(Me.SB_Save)
        Me.LayoutControl2.Controls.Add(Me.SB_SupRefresh)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-650, 388, 650, 400)
        Me.LayoutControl2.OptionsFocus.MoveFocusRightToLeft = False
        Me.LayoutControl2.Root = Me.Root
        Me.LayoutControl2.Size = New System.Drawing.Size(1257, 629)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'Sp_SPPurchaseReceiveDetail_GetDataGridControl
        '
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.DataSource = Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.Location = New System.Drawing.Point(892, 213)
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.MenuManager = Me.RibbonControl1
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.Name = "Sp_SPPurchaseReceiveDetail_GetDataGridControl"
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.Size = New System.Drawing.Size(681, 349)
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.TabIndex = 68
        Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'Sp_SPPurchaseReceiveDetail_GetDataBindingSource
        '
        Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource.DataMember = "sp_SPPurchaseReceiveDetail_GetData"
        Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource.DataSource = Me.Dataset
        '
        'Dataset
        '
        Me.Dataset.DataSetName = "Dataset"
        Me.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_Detail
        '
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Detail, Me.colPRVID_Detail, Me.colPRVNo_Detail, Me.colisInventory_Detail, Me.colInventoryID_Detail, Me.colQty_Detail, Me.colWeight_Detail, Me.colUoMID_Detail, Me.colPrice_Detail, Me.colDisc_Detail, Me.colSubtotal_Detail, Me.colDescription_Detail, Me.colDiscPersen1_Detail, Me.colDiscPersen2_Detail, Me.colDiscPersen3_Detail, Me.colModifiedUser_Detail})
        Me.GV_Detail.GridControl = Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl
        Me.GV_Detail.Name = "GV_Detail"
        '
        'colID_Detail
        '
        Me.colID_Detail.FieldName = "ID"
        Me.colID_Detail.Name = "colID_Detail"
        Me.colID_Detail.OptionsColumn.AllowEdit = False
        Me.colID_Detail.OptionsColumn.AllowFocus = False
        '
        'colPRVID_Detail
        '
        Me.colPRVID_Detail.FieldName = "PRVID"
        Me.colPRVID_Detail.Name = "colPRVID_Detail"
        Me.colPRVID_Detail.OptionsColumn.AllowEdit = False
        Me.colPRVID_Detail.OptionsColumn.AllowFocus = False
        '
        'colPRVNo_Detail
        '
        Me.colPRVNo_Detail.FieldName = "PRVNo"
        Me.colPRVNo_Detail.Name = "colPRVNo_Detail"
        Me.colPRVNo_Detail.OptionsColumn.AllowEdit = False
        Me.colPRVNo_Detail.OptionsColumn.AllowFocus = False
        '
        'colisInventory_Detail
        '
        Me.colisInventory_Detail.FieldName = "isInventory"
        Me.colisInventory_Detail.Name = "colisInventory_Detail"
        Me.colisInventory_Detail.OptionsColumn.AllowEdit = False
        Me.colisInventory_Detail.OptionsColumn.AllowFocus = False
        '
        'colInventoryID_Detail
        '
        Me.colInventoryID_Detail.Caption = "Nama Barang"
        Me.colInventoryID_Detail.FieldName = "InventoryID"
        Me.colInventoryID_Detail.Name = "colInventoryID_Detail"
        Me.colInventoryID_Detail.OptionsColumn.AllowEdit = False
        Me.colInventoryID_Detail.OptionsColumn.AllowFocus = False
        Me.colInventoryID_Detail.OptionsFilter.AllowFilter = False
        Me.colInventoryID_Detail.Visible = True
        Me.colInventoryID_Detail.VisibleIndex = 0
        '
        'colQty_Detail
        '
        Me.colQty_Detail.FieldName = "Qty"
        Me.colQty_Detail.MaxWidth = 60
        Me.colQty_Detail.MinWidth = 60
        Me.colQty_Detail.Name = "colQty_Detail"
        Me.colQty_Detail.OptionsColumn.AllowEdit = False
        Me.colQty_Detail.OptionsColumn.AllowFocus = False
        Me.colQty_Detail.OptionsFilter.AllowFilter = False
        Me.colQty_Detail.Visible = True
        Me.colQty_Detail.VisibleIndex = 1
        Me.colQty_Detail.Width = 60
        '
        'colWeight_Detail
        '
        Me.colWeight_Detail.FieldName = "Weight"
        Me.colWeight_Detail.Name = "colWeight_Detail"
        Me.colWeight_Detail.OptionsColumn.AllowEdit = False
        Me.colWeight_Detail.OptionsColumn.AllowFocus = False
        '
        'colUoMID_Detail
        '
        Me.colUoMID_Detail.FieldName = "UoMID"
        Me.colUoMID_Detail.Name = "colUoMID_Detail"
        Me.colUoMID_Detail.OptionsColumn.AllowEdit = False
        Me.colUoMID_Detail.OptionsColumn.AllowFocus = False
        '
        'colPrice_Detail
        '
        Me.colPrice_Detail.FieldName = "Price"
        Me.colPrice_Detail.MaxWidth = 120
        Me.colPrice_Detail.MinWidth = 120
        Me.colPrice_Detail.Name = "colPrice_Detail"
        Me.colPrice_Detail.OptionsColumn.AllowEdit = False
        Me.colPrice_Detail.OptionsColumn.AllowFocus = False
        Me.colPrice_Detail.OptionsFilter.AllowFilter = False
        Me.colPrice_Detail.Visible = True
        Me.colPrice_Detail.VisibleIndex = 2
        Me.colPrice_Detail.Width = 120
        '
        'colDisc_Detail
        '
        Me.colDisc_Detail.FieldName = "Disc"
        Me.colDisc_Detail.Name = "colDisc_Detail"
        Me.colDisc_Detail.OptionsColumn.AllowEdit = False
        Me.colDisc_Detail.OptionsColumn.AllowFocus = False
        '
        'colSubtotal_Detail
        '
        Me.colSubtotal_Detail.FieldName = "Subtotal"
        Me.colSubtotal_Detail.MaxWidth = 125
        Me.colSubtotal_Detail.MinWidth = 125
        Me.colSubtotal_Detail.Name = "colSubtotal_Detail"
        Me.colSubtotal_Detail.OptionsColumn.AllowEdit = False
        Me.colSubtotal_Detail.OptionsColumn.AllowFocus = False
        Me.colSubtotal_Detail.OptionsFilter.AllowFilter = False
        Me.colSubtotal_Detail.Visible = True
        Me.colSubtotal_Detail.VisibleIndex = 3
        Me.colSubtotal_Detail.Width = 125
        '
        'colDescription_Detail
        '
        Me.colDescription_Detail.FieldName = "Description"
        Me.colDescription_Detail.Name = "colDescription_Detail"
        Me.colDescription_Detail.OptionsColumn.AllowEdit = False
        Me.colDescription_Detail.OptionsColumn.AllowFocus = False
        '
        'colDiscPersen1_Detail
        '
        Me.colDiscPersen1_Detail.FieldName = "DiscPersen1"
        Me.colDiscPersen1_Detail.Name = "colDiscPersen1_Detail"
        Me.colDiscPersen1_Detail.OptionsColumn.AllowEdit = False
        Me.colDiscPersen1_Detail.OptionsColumn.AllowFocus = False
        '
        'colDiscPersen2_Detail
        '
        Me.colDiscPersen2_Detail.FieldName = "DiscPersen2"
        Me.colDiscPersen2_Detail.Name = "colDiscPersen2_Detail"
        Me.colDiscPersen2_Detail.OptionsColumn.AllowEdit = False
        Me.colDiscPersen2_Detail.OptionsColumn.AllowFocus = False
        '
        'colDiscPersen3_Detail
        '
        Me.colDiscPersen3_Detail.FieldName = "DiscPersen3"
        Me.colDiscPersen3_Detail.Name = "colDiscPersen3_Detail"
        Me.colDiscPersen3_Detail.OptionsColumn.AllowEdit = False
        Me.colDiscPersen3_Detail.OptionsColumn.AllowFocus = False
        '
        'colModifiedUser_Detail
        '
        Me.colModifiedUser_Detail.FieldName = "ModifiedUser"
        Me.colModifiedUser_Detail.Name = "colModifiedUser_Detail"
        Me.colModifiedUser_Detail.OptionsColumn.AllowEdit = False
        Me.colModifiedUser_Detail.OptionsColumn.AllowFocus = False
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(1283, 72)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 753)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1283, 33)
        '
        'Sp_SPPurchaseReceiveDetail_GetPOInvGridControl
        '
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.DataSource = Me.Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.Location = New System.Drawing.Point(434, 213)
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.MainView = Me.GV_DetailPO
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.MenuManager = Me.RibbonControl1
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.Name = "Sp_SPPurchaseReceiveDetail_GetPOInvGridControl"
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_LUE_InvDetailPO, Me.Repo_LUE_SuppDetailPO})
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.Size = New System.Drawing.Size(454, 349)
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.TabIndex = 68
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DetailPO})
        '
        'Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource
        '
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource.DataMember = "sp_SPPurchaseReceiveDetail_GetPOInv"
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource.DataSource = Me.Dataset
        '
        'GV_DetailPO
        '
        Me.GV_DetailPO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_DetailPO, Me.colInventoryID_DetailPO, Me.colQty_DetailPO, Me.colPrice_DetailPO, Me.colSupplierID_DetailPO})
        Me.GV_DetailPO.GridControl = Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl
        Me.GV_DetailPO.GroupCount = 1
        Me.GV_DetailPO.Name = "GV_DetailPO"
        Me.GV_DetailPO.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSupplierID_DetailPO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID_DetailPO
        '
        Me.colID_DetailPO.FieldName = "ID"
        Me.colID_DetailPO.Name = "colID_DetailPO"
        Me.colID_DetailPO.OptionsColumn.AllowEdit = False
        Me.colID_DetailPO.OptionsColumn.AllowFocus = False
        '
        'colInventoryID_DetailPO
        '
        Me.colInventoryID_DetailPO.Caption = "Nama Barang"
        Me.colInventoryID_DetailPO.FieldName = "InventoryID"
        Me.colInventoryID_DetailPO.Name = "colInventoryID_DetailPO"
        Me.colInventoryID_DetailPO.OptionsColumn.AllowEdit = False
        Me.colInventoryID_DetailPO.OptionsColumn.AllowFocus = False
        Me.colInventoryID_DetailPO.OptionsFilter.AllowFilter = False
        Me.colInventoryID_DetailPO.Visible = True
        Me.colInventoryID_DetailPO.VisibleIndex = 0
        Me.colInventoryID_DetailPO.Width = 113
        '
        'colQty_DetailPO
        '
        Me.colQty_DetailPO.DisplayFormat.FormatString = "n0"
        Me.colQty_DetailPO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty_DetailPO.FieldName = "Qty"
        Me.colQty_DetailPO.MaxWidth = 60
        Me.colQty_DetailPO.MinWidth = 60
        Me.colQty_DetailPO.Name = "colQty_DetailPO"
        Me.colQty_DetailPO.OptionsColumn.AllowEdit = False
        Me.colQty_DetailPO.OptionsColumn.AllowFocus = False
        Me.colQty_DetailPO.OptionsFilter.AllowFilter = False
        Me.colQty_DetailPO.Visible = True
        Me.colQty_DetailPO.VisibleIndex = 1
        Me.colQty_DetailPO.Width = 60
        '
        'colPrice_DetailPO
        '
        Me.colPrice_DetailPO.DisplayFormat.FormatString = "n0"
        Me.colPrice_DetailPO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice_DetailPO.FieldName = "Price"
        Me.colPrice_DetailPO.MaxWidth = 120
        Me.colPrice_DetailPO.MinWidth = 120
        Me.colPrice_DetailPO.Name = "colPrice_DetailPO"
        Me.colPrice_DetailPO.OptionsColumn.AllowEdit = False
        Me.colPrice_DetailPO.OptionsColumn.AllowFocus = False
        Me.colPrice_DetailPO.OptionsFilter.AllowFilter = False
        Me.colPrice_DetailPO.Visible = True
        Me.colPrice_DetailPO.VisibleIndex = 2
        Me.colPrice_DetailPO.Width = 120
        '
        'colSupplierID_DetailPO
        '
        Me.colSupplierID_DetailPO.Caption = "Supplier"
        Me.colSupplierID_DetailPO.FieldName = "SupplierID"
        Me.colSupplierID_DetailPO.Name = "colSupplierID_DetailPO"
        Me.colSupplierID_DetailPO.OptionsColumn.AllowEdit = False
        Me.colSupplierID_DetailPO.OptionsColumn.AllowFocus = False
        Me.colSupplierID_DetailPO.OptionsFilter.AllowFilter = False
        Me.colSupplierID_DetailPO.Visible = True
        Me.colSupplierID_DetailPO.VisibleIndex = 3
        '
        'Repo_LUE_InvDetailPO
        '
        Me.Repo_LUE_InvDetailPO.AutoHeight = False
        Me.Repo_LUE_InvDetailPO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_InvDetailPO.DataSource = Me.SpLookUpDataGetInventoryBindingSource
        Me.Repo_LUE_InvDetailPO.DisplayMember = "InventoryName"
        Me.Repo_LUE_InvDetailPO.Name = "Repo_LUE_InvDetailPO"
        Me.Repo_LUE_InvDetailPO.ValueMember = "ID"
        '
        'SpLookUpDataGetInventoryBindingSource
        '
        Me.SpLookUpDataGetInventoryBindingSource.DataMember = "sp_LookUpData_GetInventory"
        Me.SpLookUpDataGetInventoryBindingSource.DataSource = Me.Dataset
        '
        'Repo_LUE_SuppDetailPO
        '
        Me.Repo_LUE_SuppDetailPO.AutoHeight = False
        Me.Repo_LUE_SuppDetailPO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_SuppDetailPO.DataSource = Me.SpLookUpDataGetSupplierBindingSource
        Me.Repo_LUE_SuppDetailPO.DisplayMember = "SupplierName"
        Me.Repo_LUE_SuppDetailPO.Name = "Repo_LUE_SuppDetailPO"
        Me.Repo_LUE_SuppDetailPO.ValueMember = "ID"
        '
        'SpLookUpDataGetSupplierBindingSource
        '
        Me.SpLookUpDataGetSupplierBindingSource.DataMember = "sp_LookUpData_GetSupplier"
        Me.SpLookUpDataGetSupplierBindingSource.DataSource = Me.Dataset
        '
        'Sp_SPPurchaseReceiveHeader_GetDataGridControl
        '
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.DataSource = Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.Location = New System.Drawing.Point(45, 152)
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.MainView = Me.GV_Header
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.Name = "Sp_SPPurchaseReceiveHeader_GetDataGridControl"
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_LUE_Supplier, Me.Repo_SearchInventory})
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.Size = New System.Drawing.Size(340, 436)
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.TabIndex = 68
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Header})
        '
        'Sp_SPPurchaseReceiveHeader_GetDataBindingSource
        '
        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.DataMember = "sp_SPPurchaseReceiveHeader_GetData"
        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.DataSource = Me.Dataset
        '
        'GV_Header
        '
        Me.GV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Header, Me.colPRVNo_Header, Me.colPRVDate_Header, Me.colSupplierID_Header, Me.colPaymentType, Me.colDownPayment, Me.colisVoid, Me.colisPaid, Me.colTransporter, Me.colDriverName, Me.colVehicleNo, Me.colDONo, Me.colNoFaktur, Me.colDescription, Me.colDiscPercentage, Me.colDiscValue, Me.colDisc1, Me.colDisc2, Me.colDisc3, Me.colisMultiDisc, Me.colPPnPercentage, Me.colPPnValue, Me.colLongTerm, Me.colDueDate, Me.colModifiedUser, Me.colGrandTotal})
        Me.GV_Header.GridControl = Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl
        Me.GV_Header.Name = "GV_Header"
        Me.GV_Header.OptionsEditForm.PopupEditFormWidth = 799
        '
        'colID_Header
        '
        Me.colID_Header.FieldName = "ID"
        Me.colID_Header.MinWidth = 19
        Me.colID_Header.Name = "colID_Header"
        Me.colID_Header.OptionsColumn.AllowEdit = False
        Me.colID_Header.OptionsColumn.AllowFocus = False
        '
        'colPRVNo_Header
        '
        Me.colPRVNo_Header.Caption = "No. Penerimaan"
        Me.colPRVNo_Header.FieldName = "PRVNo"
        Me.colPRVNo_Header.MinWidth = 19
        Me.colPRVNo_Header.Name = "colPRVNo_Header"
        Me.colPRVNo_Header.OptionsColumn.AllowEdit = False
        Me.colPRVNo_Header.OptionsColumn.AllowFocus = False
        Me.colPRVNo_Header.Visible = True
        Me.colPRVNo_Header.VisibleIndex = 0
        '
        'colPRVDate_Header
        '
        Me.colPRVDate_Header.Caption = "Tgl. Penerimaan"
        Me.colPRVDate_Header.FieldName = "PRVDate"
        Me.colPRVDate_Header.MinWidth = 19
        Me.colPRVDate_Header.Name = "colPRVDate_Header"
        Me.colPRVDate_Header.OptionsColumn.AllowEdit = False
        Me.colPRVDate_Header.OptionsColumn.AllowFocus = False
        Me.colPRVDate_Header.Visible = True
        Me.colPRVDate_Header.VisibleIndex = 1
        '
        'colSupplierID_Header
        '
        Me.colSupplierID_Header.Caption = "Supplier"
        Me.colSupplierID_Header.ColumnEdit = Me.Repo_LUE_Supplier
        Me.colSupplierID_Header.FieldName = "SupplierID"
        Me.colSupplierID_Header.MinWidth = 19
        Me.colSupplierID_Header.Name = "colSupplierID_Header"
        Me.colSupplierID_Header.OptionsColumn.AllowEdit = False
        Me.colSupplierID_Header.OptionsColumn.AllowFocus = False
        Me.colSupplierID_Header.Visible = True
        Me.colSupplierID_Header.VisibleIndex = 2
        '
        'Repo_LUE_Supplier
        '
        Me.Repo_LUE_Supplier.AutoHeight = False
        Me.Repo_LUE_Supplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Supplier.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Nama Supplier", 105, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "Kota", 37, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_Supplier.DataSource = Me.SpLookUpDataGetSupplierBindingSource
        Me.Repo_LUE_Supplier.DisplayMember = "SupplierName"
        Me.Repo_LUE_Supplier.Name = "Repo_LUE_Supplier"
        Me.Repo_LUE_Supplier.ValueMember = "ID"
        '
        'colPaymentType
        '
        Me.colPaymentType.FieldName = "PaymentType"
        Me.colPaymentType.MinWidth = 19
        Me.colPaymentType.Name = "colPaymentType"
        Me.colPaymentType.OptionsColumn.AllowEdit = False
        Me.colPaymentType.OptionsColumn.AllowFocus = False
        '
        'colDownPayment
        '
        Me.colDownPayment.FieldName = "DownPayment"
        Me.colDownPayment.MinWidth = 19
        Me.colDownPayment.Name = "colDownPayment"
        Me.colDownPayment.OptionsColumn.AllowEdit = False
        Me.colDownPayment.OptionsColumn.AllowFocus = False
        '
        'colisVoid
        '
        Me.colisVoid.FieldName = "isVoid"
        Me.colisVoid.MinWidth = 19
        Me.colisVoid.Name = "colisVoid"
        Me.colisVoid.OptionsColumn.AllowEdit = False
        Me.colisVoid.OptionsColumn.AllowFocus = False
        '
        'colisPaid
        '
        Me.colisPaid.Caption = "Lunas"
        Me.colisPaid.FieldName = "isPaid"
        Me.colisPaid.MinWidth = 19
        Me.colisPaid.Name = "colisPaid"
        Me.colisPaid.OptionsColumn.AllowEdit = False
        Me.colisPaid.OptionsColumn.AllowFocus = False
        Me.colisPaid.Visible = True
        Me.colisPaid.VisibleIndex = 3
        '
        'colTransporter
        '
        Me.colTransporter.FieldName = "Transporter"
        Me.colTransporter.MinWidth = 19
        Me.colTransporter.Name = "colTransporter"
        Me.colTransporter.OptionsColumn.AllowEdit = False
        Me.colTransporter.OptionsColumn.AllowFocus = False
        '
        'colDriverName
        '
        Me.colDriverName.FieldName = "DriverName"
        Me.colDriverName.MinWidth = 19
        Me.colDriverName.Name = "colDriverName"
        Me.colDriverName.OptionsColumn.AllowEdit = False
        Me.colDriverName.OptionsColumn.AllowFocus = False
        '
        'colVehicleNo
        '
        Me.colVehicleNo.FieldName = "VehicleNo"
        Me.colVehicleNo.MinWidth = 19
        Me.colVehicleNo.Name = "colVehicleNo"
        Me.colVehicleNo.OptionsColumn.AllowEdit = False
        Me.colVehicleNo.OptionsColumn.AllowFocus = False
        '
        'colDONo
        '
        Me.colDONo.FieldName = "DONo"
        Me.colDONo.MinWidth = 19
        Me.colDONo.Name = "colDONo"
        Me.colDONo.OptionsColumn.AllowEdit = False
        Me.colDONo.OptionsColumn.AllowFocus = False
        '
        'colNoFaktur
        '
        Me.colNoFaktur.FieldName = "NoFaktur"
        Me.colNoFaktur.MinWidth = 19
        Me.colNoFaktur.Name = "colNoFaktur"
        Me.colNoFaktur.OptionsColumn.AllowEdit = False
        Me.colNoFaktur.OptionsColumn.AllowFocus = False
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 19
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        '
        'colDiscPercentage
        '
        Me.colDiscPercentage.FieldName = "DiscPercentage"
        Me.colDiscPercentage.MinWidth = 19
        Me.colDiscPercentage.Name = "colDiscPercentage"
        Me.colDiscPercentage.OptionsColumn.AllowEdit = False
        Me.colDiscPercentage.OptionsColumn.AllowFocus = False
        '
        'colDiscValue
        '
        Me.colDiscValue.FieldName = "DiscValue"
        Me.colDiscValue.MinWidth = 19
        Me.colDiscValue.Name = "colDiscValue"
        Me.colDiscValue.OptionsColumn.AllowEdit = False
        Me.colDiscValue.OptionsColumn.AllowFocus = False
        '
        'colDisc1
        '
        Me.colDisc1.FieldName = "Disc1"
        Me.colDisc1.MinWidth = 19
        Me.colDisc1.Name = "colDisc1"
        Me.colDisc1.OptionsColumn.AllowEdit = False
        Me.colDisc1.OptionsColumn.AllowFocus = False
        '
        'colDisc2
        '
        Me.colDisc2.FieldName = "Disc2"
        Me.colDisc2.MinWidth = 19
        Me.colDisc2.Name = "colDisc2"
        Me.colDisc2.OptionsColumn.AllowEdit = False
        Me.colDisc2.OptionsColumn.AllowFocus = False
        '
        'colDisc3
        '
        Me.colDisc3.FieldName = "Disc3"
        Me.colDisc3.MinWidth = 19
        Me.colDisc3.Name = "colDisc3"
        Me.colDisc3.OptionsColumn.AllowEdit = False
        Me.colDisc3.OptionsColumn.AllowFocus = False
        '
        'colisMultiDisc
        '
        Me.colisMultiDisc.FieldName = "isMultiDisc"
        Me.colisMultiDisc.MinWidth = 19
        Me.colisMultiDisc.Name = "colisMultiDisc"
        Me.colisMultiDisc.OptionsColumn.AllowEdit = False
        Me.colisMultiDisc.OptionsColumn.AllowFocus = False
        '
        'colPPnPercentage
        '
        Me.colPPnPercentage.FieldName = "PPnPercentage"
        Me.colPPnPercentage.MinWidth = 19
        Me.colPPnPercentage.Name = "colPPnPercentage"
        Me.colPPnPercentage.OptionsColumn.AllowEdit = False
        Me.colPPnPercentage.OptionsColumn.AllowFocus = False
        '
        'colPPnValue
        '
        Me.colPPnValue.FieldName = "PPnValue"
        Me.colPPnValue.MinWidth = 19
        Me.colPPnValue.Name = "colPPnValue"
        Me.colPPnValue.OptionsColumn.AllowEdit = False
        Me.colPPnValue.OptionsColumn.AllowFocus = False
        '
        'colLongTerm
        '
        Me.colLongTerm.FieldName = "LongTerm"
        Me.colLongTerm.MinWidth = 19
        Me.colLongTerm.Name = "colLongTerm"
        Me.colLongTerm.OptionsColumn.AllowEdit = False
        Me.colLongTerm.OptionsColumn.AllowFocus = False
        '
        'colDueDate
        '
        Me.colDueDate.FieldName = "DueDate"
        Me.colDueDate.MinWidth = 19
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.OptionsColumn.AllowEdit = False
        Me.colDueDate.OptionsColumn.AllowFocus = False
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 19
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        '
        'colGrandTotal
        '
        Me.colGrandTotal.FieldName = "GrandTotal"
        Me.colGrandTotal.MinWidth = 19
        Me.colGrandTotal.Name = "colGrandTotal"
        Me.colGrandTotal.OptionsColumn.AllowEdit = False
        Me.colGrandTotal.OptionsColumn.AllowFocus = False
        Me.colGrandTotal.Visible = True
        Me.colGrandTotal.VisibleIndex = 4
        '
        'Repo_SearchInventory
        '
        Me.Repo_SearchInventory.AutoHeight = False
        Me.Repo_SearchInventory.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_SearchInventory.DataSource = Me.SpLookUpDataGetInventoryBindingSource
        Me.Repo_SearchInventory.DisplayMember = "InventoryName"
        Me.Repo_SearchInventory.Name = "Repo_SearchInventory"
        Me.Repo_SearchInventory.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.Repo_SearchInventory.ValueMember = "ID"
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInventoryName_Search, Me.colLastPrice_Search, Me.colStokAkhir_Search})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 799
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colInventoryName_Search
        '
        Me.colInventoryName_Search.Caption = "Nama Barang"
        Me.colInventoryName_Search.FieldName = "InventoryName"
        Me.colInventoryName_Search.MinWidth = 19
        Me.colInventoryName_Search.Name = "colInventoryName_Search"
        Me.colInventoryName_Search.OptionsColumn.AllowEdit = False
        Me.colInventoryName_Search.OptionsColumn.AllowFocus = False
        Me.colInventoryName_Search.Visible = True
        Me.colInventoryName_Search.VisibleIndex = 0
        '
        'colLastPrice_Search
        '
        Me.colLastPrice_Search.Caption = "Harga Terakhir"
        Me.colLastPrice_Search.DisplayFormat.FormatString = "n0"
        Me.colLastPrice_Search.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colLastPrice_Search.FieldName = "LastPrice"
        Me.colLastPrice_Search.MinWidth = 19
        Me.colLastPrice_Search.Name = "colLastPrice_Search"
        Me.colLastPrice_Search.OptionsColumn.AllowEdit = False
        Me.colLastPrice_Search.OptionsColumn.AllowFocus = False
        Me.colLastPrice_Search.Visible = True
        Me.colLastPrice_Search.VisibleIndex = 1
        '
        'colStokAkhir_Search
        '
        Me.colStokAkhir_Search.Caption = "Stok Akhir"
        Me.colStokAkhir_Search.DisplayFormat.FormatString = "n0"
        Me.colStokAkhir_Search.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStokAkhir_Search.FieldName = "StokAkhir"
        Me.colStokAkhir_Search.MinWidth = 19
        Me.colStokAkhir_Search.Name = "colStokAkhir_Search"
        Me.colStokAkhir_Search.OptionsColumn.AllowEdit = False
        Me.colStokAkhir_Search.OptionsColumn.AllowFocus = False
        Me.colStokAkhir_Search.Visible = True
        Me.colStokAkhir_Search.VisibleIndex = 2
        '
        'ComboBox_Month
        '
        Me.ComboBox_Month.Location = New System.Drawing.Point(120, 23)
        Me.ComboBox_Month.Name = "ComboBox_Month"
        Me.ComboBox_Month.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBox_Month.Properties.DropDownRows = 12
        Me.ComboBox_Month.Properties.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "Nopember", "Desember"})
        Me.ComboBox_Month.Size = New System.Drawing.Size(120, 26)
        Me.ComboBox_Month.StyleController = Me.LayoutControl2
        Me.ComboBox_Month.TabIndex = 61
        '
        'DateEditStart
        '
        Me.DateEditStart.EditValue = New Date(2015, 8, 30, 23, 17, 57, 143)
        Me.DateEditStart.Location = New System.Drawing.Point(120, 53)
        Me.DateEditStart.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.DateEditStart.MaximumSize = New System.Drawing.Size(120, 0)
        Me.DateEditStart.MinimumSize = New System.Drawing.Size(120, 0)
        Me.DateEditStart.Name = "DateEditStart"
        Me.DateEditStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.DateEditStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditStart.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateEditStart.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.DateEditStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditStart.Size = New System.Drawing.Size(120, 26)
        Me.DateEditStart.StyleController = Me.LayoutControl2
        Me.DateEditStart.TabIndex = 0
        '
        'DateEditEnd
        '
        Me.DateEditEnd.EditValue = New Date(2015, 8, 30, 23, 17, 57, 143)
        Me.DateEditEnd.Location = New System.Drawing.Point(120, 83)
        Me.DateEditEnd.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.DateEditEnd.MaximumSize = New System.Drawing.Size(120, 0)
        Me.DateEditEnd.MinimumSize = New System.Drawing.Size(120, 0)
        Me.DateEditEnd.Name = "DateEditEnd"
        Me.DateEditEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.DateEditEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditEnd.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateEditEnd.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.DateEditEnd.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditEnd.Size = New System.Drawing.Size(120, 26)
        Me.DateEditEnd.StyleController = Me.LayoutControl2
        Me.DateEditEnd.TabIndex = 2
        '
        'SearchControl11
        '
        Me.SearchControl11.Location = New System.Drawing.Point(175, 113)
        Me.SearchControl11.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.SearchControl11.MinimumSize = New System.Drawing.Size(0, 35)
        Me.SearchControl11.Name = "SearchControl11"
        Me.SearchControl11.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SearchControl11.Properties.Appearance.Options.UseBackColor = True
        Me.SearchControl11.Properties.Appearance.Options.UseFont = True
        Me.SearchControl11.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SearchControl11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl11.Size = New System.Drawing.Size(210, 35)
        Me.SearchControl11.StyleController = Me.LayoutControl2
        Me.SearchControl11.TabIndex = 11
        '
        'SB_MonthlyReport
        '
        Me.SB_MonthlyReport.Location = New System.Drawing.Point(254, 58)
        Me.SB_MonthlyReport.Name = "SB_MonthlyReport"
        Me.SB_MonthlyReport.Size = New System.Drawing.Size(131, 31)
        Me.SB_MonthlyReport.StyleController = Me.LayoutControl2
        Me.SB_MonthlyReport.TabIndex = 57
        Me.SB_MonthlyReport.Text = "Monthly Report"
        '
        'SB_Summary
        '
        Me.SB_Summary.Location = New System.Drawing.Point(254, 23)
        Me.SB_Summary.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.SB_Summary.Name = "SB_Summary"
        Me.SB_Summary.Size = New System.Drawing.Size(131, 31)
        Me.SB_Summary.StyleController = Me.LayoutControl2
        Me.SB_Summary.TabIndex = 5
        Me.SB_Summary.Text = "Today Report"
        '
        'MRNoTextEdit
        '
        Me.MRNoTextEdit.EnterMoveNextControl = True
        Me.MRNoTextEdit.Location = New System.Drawing.Point(619, 23)
        Me.MRNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.MRNoTextEdit.Name = "MRNoTextEdit"
        Me.MRNoTextEdit.Properties.AllowFocused = False
        Me.MRNoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.MRNoTextEdit.Properties.ReadOnly = True
        Me.MRNoTextEdit.Properties.UseReadOnlyAppearance = False
        Me.MRNoTextEdit.Size = New System.Drawing.Size(162, 26)
        Me.MRNoTextEdit.StyleController = Me.LayoutControl2
        Me.MRNoTextEdit.TabIndex = 7
        '
        'Ed_NoFaktur
        '
        Me.Ed_NoFaktur.Location = New System.Drawing.Point(619, 53)
        Me.Ed_NoFaktur.Name = "Ed_NoFaktur"
        Me.Ed_NoFaktur.Size = New System.Drawing.Size(150, 26)
        Me.Ed_NoFaktur.StyleController = Me.LayoutControl2
        Me.Ed_NoFaktur.TabIndex = 55
        '
        'Ed_LongTerm
        '
        Me.Ed_LongTerm.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_LongTerm.Location = New System.Drawing.Point(619, 83)
        Me.Ed_LongTerm.Name = "Ed_LongTerm"
        Me.Ed_LongTerm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_LongTerm.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Ed_LongTerm.Size = New System.Drawing.Size(53, 26)
        Me.Ed_LongTerm.StyleController = Me.LayoutControl2
        Me.Ed_LongTerm.TabIndex = 66
        '
        'Dt_DueDate
        '
        Me.Dt_DueDate.EditValue = Nothing
        Me.Dt_DueDate.Location = New System.Drawing.Point(837, 84)
        Me.Dt_DueDate.Name = "Dt_DueDate"
        Me.Dt_DueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_DueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_DueDate.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.Dt_DueDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Dt_DueDate.Properties.ReadOnly = True
        Me.Dt_DueDate.Size = New System.Drawing.Size(149, 26)
        Me.Dt_DueDate.StyleController = Me.LayoutControl2
        Me.Dt_DueDate.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(676, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 28)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Hari "
        '
        'MRDateDateEdit
        '
        Me.MRDateDateEdit.EditValue = Nothing
        Me.MRDateDateEdit.EnterMoveNextControl = True
        Me.MRDateDateEdit.Location = New System.Drawing.Point(850, 23)
        Me.MRDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.MRDateDateEdit.Name = "MRDateDateEdit"
        Me.MRDateDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.MRDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MRDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MRDateDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.MRDateDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.MRDateDateEdit.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.MRDateDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MRDateDateEdit.Size = New System.Drawing.Size(56, 26)
        Me.MRDateDateEdit.StyleController = Me.LayoutControl2
        Me.MRDateDateEdit.TabIndex = 12
        '
        'Ed_NoDo
        '
        Me.Ed_NoDo.Location = New System.Drawing.Point(838, 53)
        Me.Ed_NoDo.Name = "Ed_NoDo"
        Me.Ed_NoDo.Size = New System.Drawing.Size(149, 26)
        Me.Ed_NoDo.StyleController = Me.LayoutControl2
        Me.Ed_NoDo.TabIndex = 56
        '
        'CE_PPn
        '
        Me.CE_PPn.EditValue = True
        Me.CE_PPn.Location = New System.Drawing.Point(490, 121)
        Me.CE_PPn.Name = "CE_PPn"
        Me.CE_PPn.Properties.Caption = "PPn"
        Me.CE_PPn.Size = New System.Drawing.Size(112, 22)
        Me.CE_PPn.StyleController = Me.LayoutControl2
        Me.CE_PPn.TabIndex = 62
        '
        'Ed_PPn
        '
        Me.Ed_PPn.Location = New System.Drawing.Point(684, 116)
        Me.Ed_PPn.Name = "Ed_PPn"
        Me.Ed_PPn.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_PPn.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.Ed_PPn.Properties.MaskSettings.Set("mask", "n2")
        Me.Ed_PPn.Properties.UseMaskAsDisplayFormat = True
        Me.Ed_PPn.Size = New System.Drawing.Size(87, 26)
        Me.Ed_PPn.StyleController = Me.LayoutControl2
        Me.Ed_PPn.TabIndex = 63
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(777, 121)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(11, 18)
        Me.LabelControl11.StyleController = Me.LayoutControl2
        Me.LabelControl11.TabIndex = 65
        Me.LabelControl11.Text = "%"
        '
        'SB_Back
        '
        Me.SB_Back.ImageOptions.SvgImage = CType(resources.GetObject("SB_Back.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Back.Location = New System.Drawing.Point(435, 29)
        Me.SB_Back.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.Size = New System.Drawing.Size(49, 125)
        Me.SB_Back.StyleController = Me.LayoutControl2
        Me.SB_Back.TabIndex = 40
        Me.SB_Back.Text = " "
        '
        'LUE_SupplierCity
        '
        Me.LUE_SupplierCity.Location = New System.Drawing.Point(1133, 122)
        Me.LUE_SupplierCity.Name = "LUE_SupplierCity"
        Me.LUE_SupplierCity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_SupplierCity.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 46, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LUE_SupplierCity.Properties.DisplayMember = "City"
        Me.LUE_SupplierCity.Properties.NullText = "-"
        Me.LUE_SupplierCity.Properties.ReadOnly = True
        Me.LUE_SupplierCity.Properties.ValueMember = "ID"
        Me.LUE_SupplierCity.Size = New System.Drawing.Size(235, 26)
        Me.LUE_SupplierCity.StyleController = Me.LayoutControl2
        Me.LUE_SupplierCity.TabIndex = 53
        '
        'SearchLookUpEdit_Supplier
        '
        Me.SearchLookUpEdit_Supplier.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SearchLookUpEdit_Supplier.Location = New System.Drawing.Point(1133, 55)
        Me.SearchLookUpEdit_Supplier.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.SearchLookUpEdit_Supplier.Name = "SearchLookUpEdit_Supplier"
        Me.SearchLookUpEdit_Supplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SearchLookUpEdit_Supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit_Supplier.Properties.DisplayMember = "SupplierName"
        Me.SearchLookUpEdit_Supplier.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.SearchLookUpEdit_Supplier.Properties.NullText = ""
        Me.SearchLookUpEdit_Supplier.Properties.NullValuePrompt = "-- Pilih Supplier Dahulu --"
        Me.SearchLookUpEdit_Supplier.Properties.PopupView = Me.GV_Supplier
        Me.SearchLookUpEdit_Supplier.Properties.ShowAddNewButton = True
        Me.SearchLookUpEdit_Supplier.Properties.ValueMember = "ID"
        Me.SearchLookUpEdit_Supplier.Size = New System.Drawing.Size(391, 26)
        Me.SearchLookUpEdit_Supplier.StyleController = Me.LayoutControl2
        Me.SearchLookUpEdit_Supplier.TabIndex = 16
        '
        'GV_Supplier
        '
        Me.GV_Supplier.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GV_Supplier.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GV_Supplier.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV_Supplier.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Supplier.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Supplier.Appearance.FocusedRow.Options.UseFont = True
        Me.GV_Supplier.Appearance.FooterPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Supplier.Appearance.FooterPanel.Options.UseFont = True
        Me.GV_Supplier.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Supplier.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Supplier.Appearance.Row.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.GV_Supplier.Appearance.Row.Options.UseFont = True
        Me.GV_Supplier.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV_Supplier.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Supplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Supp, Me.colSupplierName_Supp, Me.colDescription_Supp, Me.colAddress, Me.colCity})
        Me.GV_Supplier.DetailHeight = 395
        Me.GV_Supplier.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GV_Supplier.Name = "GV_Supplier"
        Me.GV_Supplier.OptionsEditForm.PopupEditFormWidth = 799
        Me.GV_Supplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV_Supplier.OptionsView.ShowGroupPanel = False
        '
        'colID_Supp
        '
        Me.colID_Supp.FieldName = "ID"
        Me.colID_Supp.MinWidth = 25
        Me.colID_Supp.Name = "colID_Supp"
        Me.colID_Supp.OptionsColumn.AllowEdit = False
        Me.colID_Supp.OptionsColumn.AllowFocus = False
        Me.colID_Supp.Width = 96
        '
        'colSupplierName_Supp
        '
        Me.colSupplierName_Supp.Caption = "Nama"
        Me.colSupplierName_Supp.FieldName = "SupplierName"
        Me.colSupplierName_Supp.MinWidth = 25
        Me.colSupplierName_Supp.Name = "colSupplierName_Supp"
        Me.colSupplierName_Supp.OptionsColumn.AllowEdit = False
        Me.colSupplierName_Supp.OptionsColumn.AllowFocus = False
        Me.colSupplierName_Supp.OptionsFilter.AllowAutoFilter = False
        Me.colSupplierName_Supp.OptionsFilter.AllowFilter = False
        Me.colSupplierName_Supp.Visible = True
        Me.colSupplierName_Supp.VisibleIndex = 0
        Me.colSupplierName_Supp.Width = 96
        '
        'colDescription_Supp
        '
        Me.colDescription_Supp.Caption = "Keterangan"
        Me.colDescription_Supp.FieldName = "Description"
        Me.colDescription_Supp.MinWidth = 25
        Me.colDescription_Supp.Name = "colDescription_Supp"
        Me.colDescription_Supp.OptionsColumn.AllowEdit = False
        Me.colDescription_Supp.OptionsColumn.AllowFocus = False
        Me.colDescription_Supp.OptionsFilter.AllowAutoFilter = False
        Me.colDescription_Supp.OptionsFilter.AllowFilter = False
        Me.colDescription_Supp.Visible = True
        Me.colDescription_Supp.VisibleIndex = 1
        Me.colDescription_Supp.Width = 96
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.MinWidth = 19
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.AllowEdit = False
        Me.colAddress.OptionsColumn.AllowFocus = False
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 2
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.MinWidth = 19
        Me.colCity.Name = "colCity"
        Me.colCity.OptionsColumn.AllowEdit = False
        Me.colCity.OptionsColumn.AllowFocus = False
        '
        'LUE_SupplierAddress
        '
        Me.LUE_SupplierAddress.Location = New System.Drawing.Point(1133, 92)
        Me.LUE_SupplierAddress.Name = "LUE_SupplierAddress"
        Me.LUE_SupplierAddress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_SupplierAddress.Properties.DisplayMember = "Address"
        Me.LUE_SupplierAddress.Properties.NullText = "-"
        Me.LUE_SupplierAddress.Properties.ReadOnly = True
        Me.LUE_SupplierAddress.Properties.ValueMember = "ID"
        Me.LUE_SupplierAddress.Size = New System.Drawing.Size(428, 26)
        Me.LUE_SupplierAddress.StyleController = Me.LayoutControl2
        Me.LUE_SupplierAddress.TabIndex = 52
        '
        'SB_AddSupplier
        '
        Me.SB_AddSupplier.ImageOptions.Image = CType(resources.GetObject("SB_AddSupplier.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_AddSupplier.Location = New System.Drawing.Point(1372, 122)
        Me.SB_AddSupplier.Name = "SB_AddSupplier"
        Me.SB_AddSupplier.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_AddSupplier.Size = New System.Drawing.Size(189, 31)
        Me.SB_AddSupplier.StyleController = Me.LayoutControl2
        Me.SB_AddSupplier.TabIndex = 54
        Me.SB_AddSupplier.Text = "Tambah Supplier"
        '
        'SB_InvRefresh
        '
        Me.SB_InvRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_InvRefresh.ImageOptions.SvgImage = CType(resources.GetObject("SB_InvRefresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_InvRefresh.Location = New System.Drawing.Point(489, 169)
        Me.SB_InvRefresh.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.SB_InvRefresh.Name = "SB_InvRefresh"
        Me.SB_InvRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_InvRefresh.Size = New System.Drawing.Size(33, 32)
        Me.SB_InvRefresh.StyleController = Me.LayoutControl2
        Me.SB_InvRefresh.TabIndex = 42
        '
        'Ed_QtyInput
        '
        Me.Ed_QtyInput.Location = New System.Drawing.Point(540, 169)
        Me.Ed_QtyInput.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.Ed_QtyInput.Name = "Ed_QtyInput"
        Me.Ed_QtyInput.Size = New System.Drawing.Size(55, 26)
        Me.Ed_QtyInput.StyleController = Me.LayoutControl2
        Me.Ed_QtyInput.TabIndex = 48
        '
        'Ed_Search
        '
        Me.Ed_Search.Location = New System.Drawing.Point(608, 169)
        Me.Ed_Search.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.Ed_Search.Name = "Ed_Search"
        Me.Ed_Search.Size = New System.Drawing.Size(665, 26)
        Me.Ed_Search.StyleController = Me.LayoutControl2
        Me.Ed_Search.TabIndex = 47
        '
        'SB_Continue
        '
        Me.SB_Continue.ImageOptions.Image = CType(resources.GetObject("SB_Continue.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Continue.Location = New System.Drawing.Point(1427, 169)
        Me.SB_Continue.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.SB_Continue.Name = "SB_Continue"
        Me.SB_Continue.Size = New System.Drawing.Size(146, 40)
        Me.SB_Continue.StyleController = Me.LayoutControl2
        Me.SB_Continue.TabIndex = 25
        Me.SB_Continue.Text = "Input Nota"
        '
        'SB_Save
        '
        Me.SB_Save.ImageOptions.Image = CType(resources.GetObject("SB_Save.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Save.Location = New System.Drawing.Point(1277, 169)
        Me.SB_Save.Margin = New System.Windows.Forms.Padding(4, 1, 4, 1)
        Me.SB_Save.Name = "SB_Save"
        Me.SB_Save.Size = New System.Drawing.Size(146, 40)
        Me.SB_Save.StyleController = Me.LayoutControl2
        Me.SB_Save.TabIndex = 39
        Me.SB_Save.Text = "Save"
        '
        'Root
        '
        Me.Root.AllowBorderColorBlending = True
        Me.Root.CustomizationFormText = "Root"
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCGroup_Det, Me.LCGroup_Header})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1597, 612)
        Me.Root.TextVisible = False
        '
        'LCGroup_Det
        '
        Me.LCGroup_Det.CustomizationFormText = ">> Detail Nota Penerimaan"
        Me.LCGroup_Det.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.LCGroup_Det.ExpandButtonVisible = True
        Me.LCGroup_Det.ExpandOnDoubleClick = True
        Me.LCGroup_Det.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LCGroup_Det.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem4, Me.EmptySpaceItem8, Me.LayoutControlItem8, Me.LayoutControlItem13, Me.LayoutControlItem17, Me.LayoutControlItem4, Me.LayoutControlItem31, Me.LayoutControlItem30, Me.LayoutControlItem2, Me.LCItem_PPn, Me.LayoutControlItem27, Me.LayoutControlItem3, Me.LayoutControlItem34, Me.LayoutControlItem39, Me.LCItem_SBContinue, Me.LCItem_SaveUpdateHeader, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LCGroup_Supplier, Me.LayoutControlItem21, Me.LCItem_CreateNew})
        Me.LCGroup_Det.Location = New System.Drawing.Point(389, 0)
        Me.LCGroup_Det.Name = "LCGroup_Det"
        Me.LCGroup_Det.Size = New System.Drawing.Size(1188, 592)
        Me.LCGroup_Det.Text = ">> Detail Nota Penerimaan"
        Me.LCGroup_Det.TextLocation = DevExpress.Utils.Locations.Left
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.CustomizationFormText = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(476, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(81, 30)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.CustomizationFormText = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(55, 129)
        Me.EmptySpaceItem8.MaxSize = New System.Drawing.Size(502, 0)
        Me.EmptySpaceItem8.MinSize = New System.Drawing.Size(502, 10)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(502, 17)
        Me.EmptySpaceItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.MRNoTextEdit
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "No. Penerimaan :"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(55, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(296, 30)
        Me.LayoutControlItem8.Text = "No. Penerimaan :"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(118, 18)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.MRDateDateEdit
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Tanggal :"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(351, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(125, 30)
        Me.LayoutControlItem13.Text = "Tanggal :"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(60, 18)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Ed_NoFaktur
        Me.LayoutControlItem17.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem17.CustomizationFormText = "No. Faktur :"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(55, 30)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(284, 30)
        Me.LayoutControlItem17.Text = "No. Faktur :"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(118, 18)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.Ed_NoDo
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "No. SJ :"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(339, 30)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(218, 30)
        Me.LayoutControlItem21.Text = "No. SJ :"
        Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(60, 18)
        Me.LayoutControlItem21.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Ed_LongTerm
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Jatuh Tempo :"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(55, 60)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(187, 32)
        Me.LayoutControlItem4.Text = "Jatuh Tempo :"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(118, 18)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.Label11
        Me.LayoutControlItem31.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem31.CustomizationFormText = "LayoutControlItem31"
        Me.LayoutControlItem31.Location = New System.Drawing.Point(242, 60)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(96, 32)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.Dt_DueDate
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "LayoutControlItem30"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(338, 60)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Padding = New DevExpress.XtraLayout.Utils.Padding(67, 3, 3, 3)
        Me.LayoutControlItem30.Size = New System.Drawing.Size(219, 32)
        Me.LayoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextToControlDistance = 0
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CE_PPn
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(55, 92)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(118, 28)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(118, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 8, 3)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(187, 37)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LCItem_PPn
        '
        Me.LCItem_PPn.Control = Me.Ed_PPn
        Me.LCItem_PPn.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCItem_PPn.CustomizationFormText = "LCItem_PPn"
        Me.LCItem_PPn.Location = New System.Drawing.Point(242, 92)
        Me.LCItem_PPn.MaxSize = New System.Drawing.Size(100, 37)
        Me.LCItem_PPn.MinSize = New System.Drawing.Size(100, 37)
        Me.LCItem_PPn.Name = "LCItem_PPn"
        Me.LCItem_PPn.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 3, 3, 3)
        Me.LCItem_PPn.Size = New System.Drawing.Size(100, 37)
        Me.LCItem_PPn.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LCItem_PPn.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_PPn.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.LabelControl11
        Me.LayoutControlItem27.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem27.CustomizationFormText = "LayoutControlItem27"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(342, 92)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 8, 3)
        Me.LayoutControlItem27.Size = New System.Drawing.Size(215, 37)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SearchLookUpEdit_Supplier
        Me.LayoutControlItem15.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem15.CustomizationFormText = "Supplier :"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(525, 37)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(525, 37)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(525, 37)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.Text = "Supplier :"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(118, 18)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.LUE_SupplierAddress
        Me.LayoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem22.CustomizationFormText = "Alamat Supp. :"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 37)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(562, 30)
        Me.LayoutControlItem22.Text = "Alamat Supp. :"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(118, 18)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.LUE_SupplierCity
        Me.LayoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem19.CustomizationFormText = "Kota Supp. :"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 67)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(369, 35)
        Me.LayoutControlItem19.Text = "Kota Supp. :"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(118, 18)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SB_AddSupplier
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem12"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(369, 67)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(193, 35)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(193, 35)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(193, 35)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SB_InvRefresh
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(55, 146)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(37, 36)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(37, 36)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(37, 44)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "LayoutControlItem7"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.Ed_QtyInput
        Me.LayoutControlItem34.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem34.CustomizationFormText = "#"
        Me.LayoutControlItem34.Location = New System.Drawing.Point(92, 146)
        Me.LayoutControlItem34.MaxSize = New System.Drawing.Size(73, 37)
        Me.LayoutControlItem34.MinSize = New System.Drawing.Size(73, 37)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(73, 44)
        Me.LayoutControlItem34.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem34.Text = "#"
        Me.LayoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(9, 18)
        Me.LayoutControlItem34.TextToControlDistance = 5
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.Ed_Search
        Me.LayoutControlItem39.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem39.CustomizationFormText = " "
        Me.LayoutControlItem39.Location = New System.Drawing.Point(165, 146)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(678, 44)
        Me.LayoutControlItem39.Text = " "
        Me.LayoutControlItem39.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(4, 18)
        Me.LayoutControlItem39.TextToControlDistance = 5
        '
        'LCItem_SBContinue
        '
        Me.LCItem_SBContinue.Control = Me.SB_Continue
        Me.LCItem_SBContinue.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCItem_SBContinue.CustomizationFormText = "LCItem_SBContinue"
        Me.LCItem_SBContinue.Location = New System.Drawing.Point(993, 146)
        Me.LCItem_SBContinue.MaxSize = New System.Drawing.Size(150, 44)
        Me.LCItem_SBContinue.MinSize = New System.Drawing.Size(150, 44)
        Me.LCItem_SBContinue.Name = "LCItem_SBContinue"
        Me.LCItem_SBContinue.Size = New System.Drawing.Size(150, 44)
        Me.LCItem_SBContinue.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LCItem_SBContinue.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_SBContinue.TextVisible = False
        '
        'LCItem_SaveUpdateHeader
        '
        Me.LCItem_SaveUpdateHeader.Control = Me.SB_Save
        Me.LCItem_SaveUpdateHeader.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCItem_SaveUpdateHeader.CustomizationFormText = "LCItem_SaveUpdateHeader"
        Me.LCItem_SaveUpdateHeader.Location = New System.Drawing.Point(843, 146)
        Me.LCItem_SaveUpdateHeader.MaxSize = New System.Drawing.Size(150, 44)
        Me.LCItem_SaveUpdateHeader.MinSize = New System.Drawing.Size(150, 44)
        Me.LCItem_SaveUpdateHeader.Name = "LCItem_SaveUpdateHeader"
        Me.LCItem_SaveUpdateHeader.Size = New System.Drawing.Size(150, 44)
        Me.LCItem_SaveUpdateHeader.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LCItem_SaveUpdateHeader.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_SaveUpdateHeader.TextVisible = False
        Me.LCItem_SaveUpdateHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SB_Back
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = " "
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(55, 163)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(55, 163)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 30)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(55, 190)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = " "
        Me.LayoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 5
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 190)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(458, 353)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl
        Me.LayoutControlItem11.Location = New System.Drawing.Point(458, 190)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(685, 353)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LCGroup_Header
        '
        Me.LCGroup_Header.CustomizationFormText = "No. Nota Penerimaan"
        Me.LCGroup_Header.ExpandButtonVisible = True
        Me.LCGroup_Header.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LCGroup_Header.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem5, Me.LCItem_Month, Me.LCItem_DateStart, Me.LCItem_DateEnd, Me.LayoutControlItem5, Me.LayoutControlItem26, Me.LayoutControlItem10, Me.LayoutControlItem7})
        Me.LCGroup_Header.Location = New System.Drawing.Point(0, 0)
        Me.LCGroup_Header.Name = "LCGroup_Header"
        Me.LCGroup_Header.Size = New System.Drawing.Size(389, 592)
        Me.LCGroup_Header.Text = "No. Nota Penerimaan"
        Me.LCGroup_Header.TextLocation = DevExpress.Utils.Locations.Left
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.CustomizationFormText = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(199, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(10, 90)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LCItem_Month
        '
        Me.LCItem_Month.Control = Me.ComboBox_Month
        Me.LCItem_Month.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCItem_Month.CustomizationFormText = "Bulan :"
        Me.LCItem_Month.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_Month.Name = "LCItem_Month"
        Me.LCItem_Month.Size = New System.Drawing.Size(199, 30)
        Me.LCItem_Month.Text = "Bulan :"
        Me.LCItem_Month.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LCItem_Month.TextSize = New System.Drawing.Size(70, 18)
        Me.LCItem_Month.TextToControlDistance = 5
        '
        'LCItem_DateStart
        '
        Me.LCItem_DateStart.Control = Me.DateEditStart
        Me.LCItem_DateStart.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCItem_DateStart.CustomizationFormText = "Tgl. Awal :"
        Me.LCItem_DateStart.Location = New System.Drawing.Point(0, 30)
        Me.LCItem_DateStart.Name = "LCItem_DateStart"
        Me.LCItem_DateStart.Size = New System.Drawing.Size(199, 30)
        Me.LCItem_DateStart.Text = "Tgl. Awal :"
        Me.LCItem_DateStart.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LCItem_DateStart.TextSize = New System.Drawing.Size(70, 19)
        Me.LCItem_DateStart.TextToControlDistance = 5
        '
        'LCItem_DateEnd
        '
        Me.LCItem_DateEnd.Control = Me.DateEditEnd
        Me.LCItem_DateEnd.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCItem_DateEnd.CustomizationFormText = "Tgl. Akhir :"
        Me.LCItem_DateEnd.Location = New System.Drawing.Point(0, 60)
        Me.LCItem_DateEnd.Name = "LCItem_DateEnd"
        Me.LCItem_DateEnd.Size = New System.Drawing.Size(199, 30)
        Me.LCItem_DateEnd.Text = "Tgl. Akhir :"
        Me.LCItem_DateEnd.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LCItem_DateEnd.TextSize = New System.Drawing.Size(70, 19)
        Me.LCItem_DateEnd.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SearchControl11
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Search :"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(344, 39)
        Me.LayoutControlItem5.Text = "Search :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(118, 18)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.SB_MonthlyReport
        Me.LayoutControlItem26.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem26.CustomizationFormText = "LayoutControlItem26"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(209, 35)
        Me.LayoutControlItem26.MaxSize = New System.Drawing.Size(135, 35)
        Me.LayoutControlItem26.MinSize = New System.Drawing.Size(135, 35)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(135, 55)
        Me.LayoutControlItem26.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SB_Summary
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(209, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(135, 35)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(135, 35)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(135, 35)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 129)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(344, 440)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1113, 629)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1283, 681)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.XtraTabControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1263, 661)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'Sp_SPPurchaseReceiveHeader_GetDataTableAdapter
        '
        Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseOrderDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveHeader_GetDataTableAdapter = Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mod_Purchase.DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_LookUpData_GetSupplierTableAdapter
        '
        Me.Sp_LookUpData_GetSupplierTableAdapter.ClearBeforeFill = True
        '
        'Sp_LookUpData_GetInventoryTableAdapter
        '
        Me.Sp_LookUpData_GetInventoryTableAdapter.ClearBeforeFill = True
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Sp_SPPurchaseReceiveDetail_GetPOInvTableAdapter
        '
        Me.Sp_SPPurchaseReceiveDetail_GetPOInvTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPPurchaseReceiveDetail_GetDataTableAdapter
        '
        Me.Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'LCGroup_Supplier
        '
        Me.LCGroup_Supplier.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem19, Me.LayoutControlItem22, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem12})
        Me.LCGroup_Supplier.Location = New System.Drawing.Point(557, 0)
        Me.LCGroup_Supplier.Name = "LCGroup_Supplier"
        Me.LCGroup_Supplier.Size = New System.Drawing.Size(586, 146)
        '
        'SB_CreateNew
        '
        Me.SB_CreateNew.ImageOptions.Image = CType(resources.GetObject("SB_SupRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_CreateNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_CreateNew.Location = New System.Drawing.Point(434, 566)
        Me.SB_CreateNew.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_CreateNew.Name = "SB_CreateNew"
        Me.SB_CreateNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_CreateNew.Size = New System.Drawing.Size(1139, 22)
        Me.SB_CreateNew.StyleController = Me.LayoutControl2
        Me.SB_CreateNew.TabIndex = 69
        Me.SB_CreateNew.Text = "Refresh Supplier"
        '
        'LCItem_CreateNew
        '
        Me.LCItem_CreateNew.Control = Me.SB_CreateNew
        Me.LCItem_CreateNew.Location = New System.Drawing.Point(0, 543)
        Me.LCItem_CreateNew.Name = "LCItem_CreateNew"
        Me.LCItem_CreateNew.Size = New System.Drawing.Size(1143, 26)
        Me.LCItem_CreateNew.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_CreateNew.TextVisible = False
        '
        'SB_SupRefresh
        '
        Me.SB_SupRefresh.ImageOptions.Image = CType(resources.GetObject("SB_SupRefresh1.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_SupRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_SupRefresh.Location = New System.Drawing.Point(1529, 56)
        Me.SB_SupRefresh.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_SupRefresh.Name = "SB_SupRefresh"
        Me.SB_SupRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_SupRefresh.Size = New System.Drawing.Size(31, 28)
        Me.SB_SupRefresh.StyleController = Me.LayoutControl2
        Me.SB_SupRefresh.TabIndex = 42
        Me.SB_SupRefresh.Text = "Refresh Supplier"
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.Font = New System.Drawing.Font("Lato", 11.25!)
        Me.LayoutControlItem16.AppearanceItemCaptionDisabled.Font = New System.Drawing.Font("Lato", 11.25!)
        Me.LayoutControlItem16.Control = Me.SB_SupRefresh
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(525, 0)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(37, 34)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(37, 34)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.OptionsPrint.AppearanceItem.Font = New System.Drawing.Font("Lato", 11.25!)
        Me.LayoutControlItem16.OptionsPrint.AppearanceItemControl.Font = New System.Drawing.Font("Lato", 11.25!)
        Me.LayoutControlItem16.OptionsPrint.AppearanceItemText.Font = New System.Drawing.Font("Lato", 11.25!)
        Me.LayoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
        Me.LayoutControlItem16.Size = New System.Drawing.Size(37, 37)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "LayoutControlItem7"
        Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Right
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextToControlDistance = 0
        Me.LayoutControlItem16.TextVisible = False
        '
        'Frm_Purchasing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 786)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "Frm_Purchasing"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Pembelian"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.Sp_SPPurchaseReceiveDetail_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetPOInvGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DetailPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_InvDetailPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_SuppDetailPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_SearchInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBox_Month.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_NoFaktur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_LongTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_DueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_DueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_NoDo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_PPn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PPn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_SupplierCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_SupplierAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_QtyInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_PPn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_SBContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_SaveUpdateHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_Month, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DateEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_CreateNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ComboBox_Month As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LCGroup_Det As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LCGroup_Header As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LCItem_Month As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DateEditStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SearchControl11 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents SB_MonthlyReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Summary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCItem_DateStart As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_DateEnd As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents MRNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_NoFaktur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_LongTerm As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Dt_DueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As Label
    Friend WithEvents MRDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Ed_NoDo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CE_PPn As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ed_PPn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LUE_SupplierCity As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SearchLookUpEdit_Supplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GV_Supplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Supp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName_Supp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Supp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LUE_SupplierAddress As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SB_AddSupplier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_InvRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_QtyInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_Search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SB_Continue As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_PPn As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_SBContinue As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCItem_SaveUpdateHeader As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Dataset As Dataset
    Friend WithEvents Sp_SPPurchaseReceiveHeader_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_SPPurchaseReceiveHeader_GetDataTableAdapter As DatasetTableAdapters.sp_SPPurchaseReceiveHeader_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DatasetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_SPPurchaseReceiveHeader_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Header As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRVNo_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRVDate_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDownPayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisVoid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisPaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransporter As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDriverName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVehicleNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoFaktur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisMultiDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPPnPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPPnValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLongTerm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrandTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_LUE_Supplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpLookUpDataGetSupplierBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetSupplierTableAdapter As DatasetTableAdapters.sp_LookUpData_GetSupplierTableAdapter
    Friend WithEvents Repo_SearchInventory As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpLookUpDataGetInventoryBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetInventoryTableAdapter As DatasetTableAdapters.sp_LookUpData_GetInventoryTableAdapter
    Friend WithEvents colInventoryName_Search As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastPrice_Search As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokAkhir_Search As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetPOInvBindingSource As BindingSource
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetPOInvTableAdapter As DatasetTableAdapters.sp_SPPurchaseReceiveDetail_GetPOInvTableAdapter
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetPOInvGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_DetailPO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_DetailPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID_DetailPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty_DetailPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice_DetailPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierID_DetailPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetDataTableAdapter As DatasetTableAdapters.sp_SPPurchaseReceiveDetail_GetDataTableAdapter
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRVID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRVNo_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisInventory_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeight_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoMID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscPersen1_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscPersen2_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscPersen3_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Repo_LUE_InvDetailPO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Repo_LUE_SuppDetailPO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LCGroup_Supplier As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SB_CreateNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_SupRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_CreateNew As DevExpress.XtraLayout.LayoutControlItem
End Class
