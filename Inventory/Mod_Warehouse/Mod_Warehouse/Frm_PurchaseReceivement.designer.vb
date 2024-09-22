<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PurchaseReceivement
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PurchaseReceivement))
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colInvNo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colInvID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colParam1Name = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colInvDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Mod_MasterData.Dataset()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Sp_SPPurchaseReceiveDetail_GetDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_SPPurchaseReceiveDetail_GetDataTableAdapter()
        Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_SPPurchaseReceiveHeader_GetDataTableAdapter()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GV_Header = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMRNo_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRDate_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrandTotal_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Supplier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpSPMDSupplierGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colUsageID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDueDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.ToggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
        Me.DateEditStart = New DevExpress.XtraEditors.DateEdit()
        Me.SB_Summary = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Exit = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.SB_New = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditEnd = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SpSPMDUsageGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LC_Frame2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LUE_SupplierCity = New DevExpress.XtraEditors.LookUpEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.LUE_SupplierAddress = New DevExpress.XtraEditors.LookUpEdit()
        Me.SB_Apply = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_QtyInput = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Barcode = New DevExpress.XtraEditors.TextEdit()
        Me.CE_MultiDisc = New DevExpress.XtraEditors.CheckEdit()
        Me.Ed_Disc3 = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Disc2 = New DevExpress.XtraEditors.TextEdit()
        Me.SB_SupRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.CE_PPnPercentage = New DevExpress.XtraEditors.CheckEdit()
        Me.Label_JumlahJenis = New DevExpress.XtraEditors.LabelControl()
        Me.Dt_Termin = New DevExpress.XtraEditors.DateEdit()
        Me.SB_InventoryCheck = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Cash = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Print = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SB_Continue = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBoxEdit_Payment = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.MRDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.MRNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRNo_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisInventory_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchLUE_Inv = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.Sp_SPPurchase_GetInventoryDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUoMID_Repo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice_Repo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num_Detail = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colUoM_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPersen1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPersen2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscPersen3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchLookUpEdit_Supplier = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GV_Supplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Supp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName_Supp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Supp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.CE_Print = New DevExpress.XtraEditors.CheckEdit()
        Me.Ed_GrossTotal = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_NetValue = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_DP = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Balance = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_DiscPercentage = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Termin = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_DiscValue = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PPnValue = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PPnPercetage = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Diskon = New DevExpress.XtraEditors.TextEdit()
        Me.LCGroup_Detail = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator3 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.EmptySpaceItem17 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem12 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_Grid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCG_PPn = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_LongTerm = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_LabelHari = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_DueDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_JumlahJenis = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCItem_TaxTotal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_TaxTotal1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem15 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LCItem_SBContinue = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SpSPMDInventoryGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpSPMDUoMDetailGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PopupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.SpSPPurchaseGetPurchaseHeaderDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TV_Header = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colParam2Date = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colParam2Text = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colParam1ID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpSPPurchaseGetPurchaseDetailDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_DetailData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SpMDUoMGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.Sp_LookUpData_GetSupplierTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_LookUpData_GetSupplierTableAdapter()
        Me.QueriesTableAdapter = New Mod_MasterData.DatasetTableAdapters.QueriesTableAdapter()
        Me.Sp_SP_MDInventory_GetDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_LookUpData_GetInventoryTableAdapter()
        Me.Sp_SP_MDUsage_GetDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_SP_MDUsage_GetDataTableAdapter()
        Me.Sp_MDUoMGetDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_MDUoMGetDataTableAdapter()
        Me.Sp_SP_MDUoMDetail_GetDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_SP_MDUoMDetail_GetDataTableAdapter()
        Me.Sp_SPPurchase_GetPurchaseDetailDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_SPPurchaseReceiveDetail_GetDataTableAdapter()
        Me.Sp_SPPurchase_GetPurchaseHeaderDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_SPPurchaseReceiveHeader_GetDataTableAdapter()
        Me.Sp_SPPurchase_GetInventoryDataTableAdapter = New Mod_MasterData.DatasetTableAdapters.sp_LookUpData_GetInventoryTableAdapter()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.TableAdapterManager = New Mod_MasterData.DatasetTableAdapters.TableAdapterManager()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.LCItem_CreateNew = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SB_CreateNew = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPMDSupplierGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEditEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPMDUsageGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Frame2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LC_Frame2.SuspendLayout()
        CType(Me.LUE_SupplierCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_SupplierAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_QtyInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Barcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_MultiDisc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Disc3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Disc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_PPnPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_Termin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_Termin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit_Payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MRNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveDetailGetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLUE_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchase_GetInventoryDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Num_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_Print.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_GrossTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_NetValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_DP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_DiscPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Termin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_DiscValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PPnValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PPnPercetage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Diskon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCG_PPn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_LongTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_LabelHari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_JumlahJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_TaxTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_TaxTotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_SBContinue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPMDInventoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPMDUoMDetailGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupContainerControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPPurchaseGetPurchaseHeaderDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPPurchaseGetPurchaseDetailDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_DetailData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.LCItem_CreateNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colInvNo
        '
        Me.colInvNo.FieldName = "InvNo"
        Me.colInvNo.MinWidth = 21
        Me.colInvNo.Name = "colInvNo"
        Me.colInvNo.Visible = True
        Me.colInvNo.VisibleIndex = 1
        Me.colInvNo.Width = 76
        '
        'colInvID
        '
        Me.colInvID.FieldName = "InvID"
        Me.colInvID.MinWidth = 21
        Me.colInvID.Name = "colInvID"
        Me.colInvID.Visible = True
        Me.colInvID.VisibleIndex = 0
        Me.colInvID.Width = 76
        '
        'colParam1Name
        '
        Me.colParam1Name.FieldName = "Param1Name"
        Me.colParam1Name.MinWidth = 21
        Me.colParam1Name.Name = "colParam1Name"
        Me.colParam1Name.Visible = True
        Me.colParam1Name.VisibleIndex = 3
        Me.colParam1Name.Width = 76
        '
        'colInvDate
        '
        Me.colInvDate.FieldName = "InvDate"
        Me.colInvDate.MinWidth = 21
        Me.colInvDate.Name = "colInvDate"
        Me.colInvDate.Visible = True
        Me.colInvDate.VisibleIndex = 2
        Me.colInvDate.Width = 76
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(40, 40)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "Normal.png")
        Me.ImageCollection.Images.SetKeyName(1, "Hot.png")
        Me.ImageCollection.Images.SetKeyName(2, "Pressed.png")
        '
        'Sp_SPPurchaseReceiveHeader_GetDataBindingSource
        '
        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.DataMember = "sp_SPPurchaseReceiveHeader_GetData"
        Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "Normal.png")
        Me.imageList1.Images.SetKeyName(1, "Hot.png")
        Me.imageList1.Images.SetKeyName(2, "Pressed.png")
        '
        'Sp_SPPurchaseReceiveDetail_GetDataTableAdapter
        '
        Me.Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPPurchaseReceiveHeader_GetDataTableAdapter
        '
        Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter.ClearBeforeFill = True
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(168, 54)
        Me.SearchControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SearchControl1.MinimumSize = New System.Drawing.Size(0, 34)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SearchControl1.Properties.Appearance.Options.UseBackColor = True
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Size = New System.Drawing.Size(1101, 34)
        Me.SearchControl1.StyleController = Me.LayoutControl2
        Me.SearchControl1.TabIndex = 11
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl)
        Me.LayoutControl2.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl2.Controls.Add(Me.ToggleSwitch1)
        Me.LayoutControl2.Controls.Add(Me.SearchControl1)
        Me.LayoutControl2.Controls.Add(Me.DateEditStart)
        Me.LayoutControl2.Controls.Add(Me.SB_Summary)
        Me.LayoutControl2.Controls.Add(Me.SB_Exit)
        Me.LayoutControl2.Controls.Add(Me.SB_New)
        Me.LayoutControl2.Controls.Add(Me.DateEditEnd)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.Root
        Me.LayoutControl2.Size = New System.Drawing.Size(1501, 846)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'Sp_SPPurchaseReceiveHeader_GetDataGridControl
        '
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.DataSource = Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.Location = New System.Drawing.Point(16, 98)
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.MainView = Me.GV_Header
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.Name = "Sp_SPPurchaseReceiveHeader_GetDataGridControl"
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_Supplier})
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.Size = New System.Drawing.Size(1469, 732)
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.TabIndex = 8
        Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Header})
        '
        'GV_Header
        '
        Me.GV_Header.Appearance.HeaderPanel.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Header.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray
        Me.GV_Header.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_Header.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Header.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_Header.Appearance.Row.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.GV_Header.Appearance.Row.Options.UseFont = True
        Me.GV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMRNo_Header, Me.colMRDate_Header, Me.colGrandTotal_Header, Me.colID_Header, Me.colSupplierID_Header, Me.colUsageID_Header, Me.colDescription, Me.colDueDate})
        Me.GV_Header.DetailHeight = 394
        Me.GV_Header.GridControl = Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl
        Me.GV_Header.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrandTotal", Nothing, "(Grand Total: SUM={0:n0})")})
        Me.GV_Header.Name = "GV_Header"
        Me.GV_Header.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Header.OptionsView.ShowDetailButtons = False
        Me.GV_Header.OptionsView.ShowFooter = True
        Me.GV_Header.OptionsView.ShowGroupPanel = False
        Me.GV_Header.OptionsView.ShowIndicator = False
        Me.GV_Header.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_Header.RowHeight = 39
        Me.GV_Header.RowSeparatorHeight = 6
        '
        'colMRNo_Header
        '
        Me.colMRNo_Header.Caption = "MR No"
        Me.colMRNo_Header.FieldName = "MRNo"
        Me.colMRNo_Header.MinWidth = 26
        Me.colMRNo_Header.Name = "colMRNo_Header"
        Me.colMRNo_Header.OptionsColumn.AllowEdit = False
        Me.colMRNo_Header.OptionsColumn.AllowFocus = False
        Me.colMRNo_Header.OptionsFilter.AllowFilter = False
        Me.colMRNo_Header.Visible = True
        Me.colMRNo_Header.VisibleIndex = 0
        Me.colMRNo_Header.Width = 297
        '
        'colMRDate_Header
        '
        Me.colMRDate_Header.Caption = "MR Date"
        Me.colMRDate_Header.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colMRDate_Header.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMRDate_Header.FieldName = "MRDate"
        Me.colMRDate_Header.MaxWidth = 154
        Me.colMRDate_Header.MinWidth = 154
        Me.colMRDate_Header.Name = "colMRDate_Header"
        Me.colMRDate_Header.OptionsColumn.AllowEdit = False
        Me.colMRDate_Header.OptionsColumn.AllowFocus = False
        Me.colMRDate_Header.OptionsFilter.AllowFilter = False
        Me.colMRDate_Header.Visible = True
        Me.colMRDate_Header.VisibleIndex = 1
        Me.colMRDate_Header.Width = 154
        '
        'colGrandTotal_Header
        '
        Me.colGrandTotal_Header.DisplayFormat.FormatString = "n0"
        Me.colGrandTotal_Header.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrandTotal_Header.FieldName = "GrandTotal"
        Me.colGrandTotal_Header.MaxWidth = 154
        Me.colGrandTotal_Header.MinWidth = 154
        Me.colGrandTotal_Header.Name = "colGrandTotal_Header"
        Me.colGrandTotal_Header.OptionsColumn.AllowEdit = False
        Me.colGrandTotal_Header.OptionsColumn.AllowFocus = False
        Me.colGrandTotal_Header.OptionsFilter.AllowFilter = False
        Me.colGrandTotal_Header.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GrandTotal", "{0:n0}")})
        Me.colGrandTotal_Header.Visible = True
        Me.colGrandTotal_Header.VisibleIndex = 5
        Me.colGrandTotal_Header.Width = 154
        '
        'colID_Header
        '
        Me.colID_Header.FieldName = "ID"
        Me.colID_Header.MinWidth = 26
        Me.colID_Header.Name = "colID_Header"
        Me.colID_Header.OptionsColumn.AllowEdit = False
        Me.colID_Header.OptionsColumn.AllowFocus = False
        Me.colID_Header.Width = 96
        '
        'colSupplierID_Header
        '
        Me.colSupplierID_Header.Caption = "Supplier"
        Me.colSupplierID_Header.ColumnEdit = Me.Repo_Supplier
        Me.colSupplierID_Header.FieldName = "SupplierID"
        Me.colSupplierID_Header.MaxWidth = 256
        Me.colSupplierID_Header.MinWidth = 256
        Me.colSupplierID_Header.Name = "colSupplierID_Header"
        Me.colSupplierID_Header.OptionsColumn.AllowEdit = False
        Me.colSupplierID_Header.OptionsColumn.AllowFocus = False
        Me.colSupplierID_Header.OptionsFilter.AllowFilter = False
        Me.colSupplierID_Header.Visible = True
        Me.colSupplierID_Header.VisibleIndex = 2
        Me.colSupplierID_Header.Width = 256
        '
        'Repo_Supplier
        '
        Me.Repo_Supplier.AutoHeight = False
        Me.Repo_Supplier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_Supplier.DataSource = Me.SpSPMDSupplierGetDataBindingSource
        Me.Repo_Supplier.DisplayMember = "SupplierName"
        Me.Repo_Supplier.Name = "Repo_Supplier"
        Me.Repo_Supplier.ValueMember = "ID"
        '
        'SpSPMDSupplierGetDataBindingSource
        '
        Me.SpSPMDSupplierGetDataBindingSource.DataMember = "sp_SP_MDSupplier_GetData"
        Me.SpSPMDSupplierGetDataBindingSource.DataSource = Me.DataSet
        '
        'colUsageID_Header
        '
        Me.colUsageID_Header.Caption = "Keperluan"
        Me.colUsageID_Header.FieldName = "UsageID"
        Me.colUsageID_Header.MinWidth = 26
        Me.colUsageID_Header.Name = "colUsageID_Header"
        Me.colUsageID_Header.OptionsColumn.AllowEdit = False
        Me.colUsageID_Header.OptionsColumn.AllowFocus = False
        Me.colUsageID_Header.OptionsFilter.AllowFilter = False
        Me.colUsageID_Header.Width = 166
        '
        'colDescription
        '
        Me.colDescription.Caption = "Keterangan"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MaxWidth = 256
        Me.colDescription.MinWidth = 256
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        Me.colDescription.Width = 256
        '
        'colDueDate
        '
        Me.colDueDate.Caption = "Jatuh Tempo"
        Me.colDueDate.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colDueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDueDate.FieldName = "DueDate"
        Me.colDueDate.MaxWidth = 154
        Me.colDueDate.MinWidth = 154
        Me.colDueDate.Name = "colDueDate"
        Me.colDueDate.OptionsColumn.AllowEdit = False
        Me.colDueDate.OptionsColumn.AllowFocus = False
        Me.colDueDate.OptionsFilter.AllowFilter = False
        Me.colDueDate.Visible = True
        Me.colDueDate.VisibleIndex = 4
        Me.colDueDate.Width = 154
        '
        'SB_Refresh
        '
        Me.SB_Refresh.ImageOptions.Image = CType(resources.GetObject("SB_Refresh.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Refresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_Refresh.Location = New System.Drawing.Point(1275, 54)
        Me.SB_Refresh.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Refresh.Size = New System.Drawing.Size(62, 38)
        Me.SB_Refresh.StyleController = Me.LayoutControl2
        Me.SB_Refresh.TabIndex = 7
        Me.SB_Refresh.Text = "Refresh"
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.Location = New System.Drawing.Point(453, 16)
        Me.ToggleSwitch1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Properties.OffText = "Belum Terbayar"
        Me.ToggleSwitch1.Properties.OnText = "Terbayar"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(173, 24)
        Me.ToggleSwitch1.StyleController = Me.LayoutControl2
        Me.ToggleSwitch1.TabIndex = 6
        '
        'DateEditStart
        '
        Me.DateEditStart.EditValue = New Date(2015, 8, 30, 23, 17, 57, 143)
        Me.DateEditStart.Location = New System.Drawing.Point(98, 16)
        Me.DateEditStart.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.DateEditStart.Name = "DateEditStart"
        Me.DateEditStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.DateEditStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditStart.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateEditStart.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.DateEditStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditStart.Size = New System.Drawing.Size(133, 32)
        Me.DateEditStart.StyleController = Me.LayoutControl2
        Me.DateEditStart.TabIndex = 0
        '
        'SB_Summary
        '
        Me.SB_Summary.Location = New System.Drawing.Point(632, 16)
        Me.SB_Summary.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Summary.Name = "SB_Summary"
        Me.SB_Summary.Size = New System.Drawing.Size(108, 28)
        Me.SB_Summary.StyleController = Me.LayoutControl2
        Me.SB_Summary.TabIndex = 5
        Me.SB_Summary.Text = "Daily Report"
        '
        'SB_Exit
        '
        Me.SB_Exit.ImageOptions.ImageIndex = 1
        Me.SB_Exit.ImageOptions.ImageList = Me.ImageCollection1
        Me.SB_Exit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SB_Exit.Location = New System.Drawing.Point(1419, 54)
        Me.SB_Exit.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Exit.Name = "SB_Exit"
        Me.SB_Exit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Exit.Size = New System.Drawing.Size(66, 28)
        Me.SB_Exit.StyleController = Me.LayoutControl2
        Me.SB_Exit.TabIndex = 10
        Me.SB_Exit.Text = "&Exit"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "add_32x32.png")
        Me.ImageCollection1.InsertGalleryImage("cancel_16x16.png", "office2013/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/cancel_16x16.png"), 1)
        Me.ImageCollection1.Images.SetKeyName(1, "cancel_16x16.png")
        '
        'SB_New
        '
        Me.SB_New.ImageOptions.ImageIndex = 0
        Me.SB_New.ImageOptions.ImageList = Me.ImageCollection1
        Me.SB_New.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SB_New.Location = New System.Drawing.Point(1343, 54)
        Me.SB_New.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_New.Name = "SB_New"
        Me.SB_New.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_New.Size = New System.Drawing.Size(70, 28)
        Me.SB_New.StyleController = Me.LayoutControl2
        Me.SB_New.TabIndex = 9
        Me.SB_New.Text = "&New"
        '
        'DateEditEnd
        '
        Me.DateEditEnd.EditValue = New Date(2015, 8, 30, 23, 17, 57, 143)
        Me.DateEditEnd.Location = New System.Drawing.Point(319, 16)
        Me.DateEditEnd.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.DateEditEnd.Name = "DateEditEnd"
        Me.DateEditEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.DateEditEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEditEnd.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.DateEditEnd.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.DateEditEnd.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.DateEditEnd.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEditEnd.Size = New System.Drawing.Size(128, 32)
        Me.DateEditEnd.StyleController = Me.LayoutControl2
        Me.DateEditEnd.TabIndex = 2
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem8, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem31, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.LayoutControlItem14, Me.LayoutControlItem32, Me.LayoutControlItem38})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1501, 846)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(1119, 0)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(356, 38)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1475, 738)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SearchControl1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 38)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1259, 44)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(136, 18)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.ToggleSwitch1
        Me.LayoutControlItem9.Location = New System.Drawing.Point(437, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(179, 38)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DateEditStart
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(221, 38)
        Me.LayoutControlItem2.Text = "Date Start"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(77, 18)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.SB_Summary
        Me.LayoutControlItem31.Location = New System.Drawing.Point(616, 0)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(114, 38)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(730, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(389, 38)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.DateEditEnd
        Me.LayoutControlItem4.Location = New System.Drawing.Point(221, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(216, 38)
        Me.LayoutControlItem4.Text = "Date End"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(77, 18)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SB_Refresh
        Me.LayoutControlItem14.Location = New System.Drawing.Point(1259, 38)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(68, 44)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.SB_New
        Me.LayoutControlItem32.Location = New System.Drawing.Point(1327, 38)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(76, 44)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.SB_Exit
        Me.LayoutControlItem38.Location = New System.Drawing.Point(1403, 38)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(72, 44)
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextVisible = False
        '
        'SpSPMDUsageGetDataBindingSource
        '
        Me.SpSPMDUsageGetDataBindingSource.DataMember = "sp_SP_MDUsage_GetData"
        Me.SpSPMDUsageGetDataBindingSource.DataSource = Me.DataSet
        '
        'LC_Frame2
        '
        Me.LC_Frame2.Appearance.Control.Options.UseFont = True
        Me.LC_Frame2.Controls.Add(Me.LUE_SupplierCity)
        Me.LC_Frame2.Controls.Add(Me.LUE_SupplierAddress)
        Me.LC_Frame2.Controls.Add(Me.SB_Apply)
        Me.LC_Frame2.Controls.Add(Me.Ed_QtyInput)
        Me.LC_Frame2.Controls.Add(Me.Ed_Barcode)
        Me.LC_Frame2.Controls.Add(Me.CE_MultiDisc)
        Me.LC_Frame2.Controls.Add(Me.Ed_Disc3)
        Me.LC_Frame2.Controls.Add(Me.Ed_Disc2)
        Me.LC_Frame2.Controls.Add(Me.SB_SupRefresh)
        Me.LC_Frame2.Controls.Add(Me.LabelControl1)
        Me.LC_Frame2.Controls.Add(Me.SB_Back)
        Me.LC_Frame2.Controls.Add(Me.SB_Save)
        Me.LC_Frame2.Controls.Add(Me.CE_PPnPercentage)
        Me.LC_Frame2.Controls.Add(Me.Label_JumlahJenis)
        Me.LC_Frame2.Controls.Add(Me.SB_CreateNew)
        Me.LC_Frame2.Controls.Add(Me.Dt_Termin)
        Me.LC_Frame2.Controls.Add(Me.SB_InventoryCheck)
        Me.LC_Frame2.Controls.Add(Me.SB_Cash)
        Me.LC_Frame2.Controls.Add(Me.SB_Print)
        Me.LC_Frame2.Controls.Add(Me.LookUpEdit1)
        Me.LC_Frame2.Controls.Add(Me.SB_Continue)
        Me.LC_Frame2.Controls.Add(Me.ComboBoxEdit_Payment)
        Me.LC_Frame2.Controls.Add(Me.MRDateDateEdit)
        Me.LC_Frame2.Controls.Add(Me.MRNoTextEdit)
        Me.LC_Frame2.Controls.Add(Me.Sp_SPPurchaseReceiveDetailGetDataGridControl)
        Me.LC_Frame2.Controls.Add(Me.SearchLookUpEdit_Supplier)
        Me.LC_Frame2.Controls.Add(Me.MemoEdit1)
        Me.LC_Frame2.Controls.Add(Me.CE_Print)
        Me.LC_Frame2.Controls.Add(Me.Ed_GrossTotal)
        Me.LC_Frame2.Controls.Add(Me.Ed_NetValue)
        Me.LC_Frame2.Controls.Add(Me.Ed_DP)
        Me.LC_Frame2.Controls.Add(Me.Ed_Balance)
        Me.LC_Frame2.Controls.Add(Me.Ed_DiscPercentage)
        Me.LC_Frame2.Controls.Add(Me.Ed_Termin)
        Me.LC_Frame2.Controls.Add(Me.Ed_DiscValue)
        Me.LC_Frame2.Controls.Add(Me.Ed_PPnValue)
        Me.LC_Frame2.Controls.Add(Me.Ed_PPnPercetage)
        Me.LC_Frame2.Controls.Add(Me.Ed_Diskon)
        Me.LC_Frame2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Frame2.Location = New System.Drawing.Point(0, 0)
        Me.LC_Frame2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LC_Frame2.Name = "LC_Frame2"
        Me.LC_Frame2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(318, 167, 450, 400)
        Me.LC_Frame2.Root = Me.LCGroup_Detail
        Me.LC_Frame2.Size = New System.Drawing.Size(1501, 846)
        Me.LC_Frame2.TabIndex = 0
        Me.LC_Frame2.Text = "LayoutControl2"
        '
        'LUE_SupplierCity
        '
        Me.LUE_SupplierCity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "SupplierID", True))
        Me.LUE_SupplierCity.Location = New System.Drawing.Point(1081, 89)
        Me.LUE_SupplierCity.MenuManager = Me.RibbonControl1
        Me.LUE_SupplierCity.Name = "LUE_SupplierCity"
        Me.LUE_SupplierCity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_SupplierCity.Properties.DataSource = Me.SpSPMDSupplierGetDataBindingSource
        Me.LUE_SupplierCity.Properties.DisplayMember = "City"
        Me.LUE_SupplierCity.Properties.NullText = "-"
        Me.LUE_SupplierCity.Properties.ReadOnly = True
        Me.LUE_SupplierCity.Properties.ValueMember = "ID"
        Me.LUE_SupplierCity.Size = New System.Drawing.Size(400, 32)
        Me.LUE_SupplierCity.StyleController = Me.LC_Frame2
        Me.LUE_SupplierCity.TabIndex = 53
        '
        'RibbonControl1
        '
        Me.RibbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(39, 34, 39, 34)
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.OptionsMenuMinWidth = 424
        Me.RibbonControl1.Size = New System.Drawing.Size(1503, 88)
        '
        'LUE_SupplierAddress
        '
        Me.LUE_SupplierAddress.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "SupplierID", True))
        Me.LUE_SupplierAddress.Location = New System.Drawing.Point(1081, 51)
        Me.LUE_SupplierAddress.MenuManager = Me.RibbonControl1
        Me.LUE_SupplierAddress.Name = "LUE_SupplierAddress"
        Me.LUE_SupplierAddress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_SupplierAddress.Properties.DataSource = Me.SpSPMDSupplierGetDataBindingSource
        Me.LUE_SupplierAddress.Properties.DisplayMember = "Address"
        Me.LUE_SupplierAddress.Properties.NullText = "-"
        Me.LUE_SupplierAddress.Properties.ReadOnly = True
        Me.LUE_SupplierAddress.Properties.ValueMember = "ID"
        Me.LUE_SupplierAddress.Size = New System.Drawing.Size(400, 32)
        Me.LUE_SupplierAddress.StyleController = Me.LC_Frame2
        Me.LUE_SupplierAddress.TabIndex = 52
        '
        'SB_Apply
        '
        Me.SB_Apply.Location = New System.Drawing.Point(1293, 137)
        Me.SB_Apply.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SB_Apply.Name = "SB_Apply"
        Me.SB_Apply.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Apply.Size = New System.Drawing.Size(188, 28)
        Me.SB_Apply.StyleController = Me.LC_Frame2
        Me.SB_Apply.TabIndex = 49
        Me.SB_Apply.Text = "Apply  Changes"
        '
        'Ed_QtyInput
        '
        Me.Ed_QtyInput.EditValue = 1
        Me.Ed_QtyInput.Location = New System.Drawing.Point(132, 137)
        Me.Ed_QtyInput.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_QtyInput.Name = "Ed_QtyInput"
        Me.Ed_QtyInput.Size = New System.Drawing.Size(50, 32)
        Me.Ed_QtyInput.StyleController = Me.LC_Frame2
        Me.Ed_QtyInput.TabIndex = 48
        '
        'Ed_Barcode
        '
        Me.Ed_Barcode.Location = New System.Drawing.Point(196, 137)
        Me.Ed_Barcode.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_Barcode.MenuManager = Me.RibbonControl1
        Me.Ed_Barcode.Name = "Ed_Barcode"
        Me.Ed_Barcode.Size = New System.Drawing.Size(177, 32)
        Me.Ed_Barcode.StyleController = Me.LC_Frame2
        Me.Ed_Barcode.TabIndex = 47
        '
        'CE_MultiDisc
        '
        Me.CE_MultiDisc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "isMultiDisc", True))
        Me.CE_MultiDisc.Location = New System.Drawing.Point(1021, 332)
        Me.CE_MultiDisc.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CE_MultiDisc.MenuManager = Me.RibbonControl1
        Me.CE_MultiDisc.Name = "CE_MultiDisc"
        Me.CE_MultiDisc.Properties.Caption = "Multi Disc"
        Me.CE_MultiDisc.Size = New System.Drawing.Size(125, 22)
        Me.CE_MultiDisc.StyleController = Me.LC_Frame2
        Me.CE_MultiDisc.TabIndex = 45
        '
        'Ed_Disc3
        '
        Me.Ed_Disc3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "Disc3", True))
        Me.Ed_Disc3.Location = New System.Drawing.Point(1230, 371)
        Me.Ed_Disc3.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_Disc3.Name = "Ed_Disc3"
        Me.Ed_Disc3.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_Disc3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_Disc3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Disc3.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Disc3.Properties.MaskSettings.Set("mask", "n2")
        Me.Ed_Disc3.Properties.MaxLength = 5
        Me.Ed_Disc3.Properties.Padding = New System.Windows.Forms.Padding(0, 1, -1, 0)
        Me.Ed_Disc3.Size = New System.Drawing.Size(63, 33)
        Me.Ed_Disc3.StyleController = Me.LC_Frame2
        Me.Ed_Disc3.TabIndex = 44
        '
        'Ed_Disc2
        '
        Me.Ed_Disc2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "Disc2", True))
        Me.Ed_Disc2.Location = New System.Drawing.Point(1161, 371)
        Me.Ed_Disc2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_Disc2.Name = "Ed_Disc2"
        Me.Ed_Disc2.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_Disc2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_Disc2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Disc2.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Disc2.Properties.MaskSettings.Set("mask", "n2")
        Me.Ed_Disc2.Properties.MaxLength = 5
        Me.Ed_Disc2.Properties.Padding = New System.Windows.Forms.Padding(0, 1, -1, 0)
        Me.Ed_Disc2.Size = New System.Drawing.Size(63, 33)
        Me.Ed_Disc2.StyleController = Me.LC_Frame2
        Me.Ed_Disc2.TabIndex = 43
        '
        'SB_SupRefresh
        '
        Me.SB_SupRefresh.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_SupRefresh.ImageOptions.SvgImage = CType(resources.GetObject("SB_SupRefresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_SupRefresh.Location = New System.Drawing.Point(379, 137)
        Me.SB_SupRefresh.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_SupRefresh.Name = "SB_SupRefresh"
        Me.SB_SupRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_SupRefresh.Size = New System.Drawing.Size(32, 30)
        Me.SB_SupRefresh.StyleController = Me.LC_Frame2
        Me.SB_SupRefresh.TabIndex = 42
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(1314, 269)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 18)
        Me.LabelControl1.StyleController = Me.LC_Frame2
        Me.LabelControl1.TabIndex = 41
        Me.LabelControl1.Text = "Hari"
        '
        'SB_Back
        '
        Me.SB_Back.ImageOptions.SvgImage = CType(resources.GetObject("SB_Back.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Back.Location = New System.Drawing.Point(13, 137)
        Me.SB_Back.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Back.Size = New System.Drawing.Size(99, 38)
        Me.SB_Back.StyleController = Me.LC_Frame2
        Me.SB_Back.TabIndex = 40
        Me.SB_Back.Text = "&Back"
        '
        'SB_Save
        '
        Me.SB_Save.ImageOptions.Image = CType(resources.GetObject("SB_Save.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Save.Location = New System.Drawing.Point(1005, 734)
        Me.SB_Save.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Save.Name = "SB_Save"
        Me.SB_Save.Size = New System.Drawing.Size(476, 38)
        Me.SB_Save.StyleController = Me.LC_Frame2
        Me.SB_Save.TabIndex = 39
        Me.SB_Save.Text = "Cetak"
        '
        'CE_PPnPercentage
        '
        Me.CE_PPnPercentage.Location = New System.Drawing.Point(1423, 332)
        Me.CE_PPnPercentage.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CE_PPnPercentage.Name = "CE_PPnPercentage"
        Me.CE_PPnPercentage.Properties.AllowFocused = False
        Me.CE_PPnPercentage.Properties.Caption = "%"
        Me.CE_PPnPercentage.Size = New System.Drawing.Size(42, 22)
        Me.CE_PPnPercentage.StyleController = Me.LC_Frame2
        Me.CE_PPnPercentage.TabIndex = 38
        '
        'Label_JumlahJenis
        '
        Me.Label_JumlahJenis.Appearance.Options.UseTextOptions = True
        Me.Label_JumlahJenis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_JumlahJenis.AutoEllipsis = True
        Me.Label_JumlahJenis.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_JumlahJenis.Location = New System.Drawing.Point(13, 754)
        Me.Label_JumlahJenis.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Label_JumlahJenis.Name = "Label_JumlahJenis"
        Me.Label_JumlahJenis.Size = New System.Drawing.Size(986, 18)
        Me.Label_JumlahJenis.StyleController = Me.LC_Frame2
        Me.Label_JumlahJenis.TabIndex = 36
        Me.Label_JumlahJenis.Text = "0 Jenis"
        '
        'Dt_Termin
        '
        Me.Dt_Termin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "DueDate", True))
        Me.Dt_Termin.EditValue = Nothing
        Me.Dt_Termin.Location = New System.Drawing.Point(1360, 262)
        Me.Dt_Termin.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Dt_Termin.Name = "Dt_Termin"
        Me.Dt_Termin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Dt_Termin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Termin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Termin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Dt_Termin.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.Dt_Termin.Properties.ReadOnly = True
        Me.Dt_Termin.Size = New System.Drawing.Size(105, 32)
        Me.Dt_Termin.StyleController = Me.LC_Frame2
        Me.Dt_Termin.TabIndex = 34
        '
        'SB_InventoryCheck
        '
        Me.SB_InventoryCheck.ImageOptions.Image = CType(resources.GetObject("SB_InventoryCheck.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_InventoryCheck.Location = New System.Drawing.Point(29, 794)
        Me.SB_InventoryCheck.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_InventoryCheck.Name = "SB_InventoryCheck"
        Me.SB_InventoryCheck.Size = New System.Drawing.Size(637, 38)
        Me.SB_InventoryCheck.StyleController = Me.LC_Frame2
        Me.SB_InventoryCheck.TabIndex = 32
        Me.SB_InventoryCheck.Text = "Lihat Stok"
        '
        'SB_Cash
        '
        Me.SB_Cash.Appearance.Options.UseTextOptions = True
        Me.SB_Cash.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SB_Cash.ImageOptions.Image = CType(resources.GetObject("SB_Cash.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Cash.Location = New System.Drawing.Point(1005, 426)
        Me.SB_Cash.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Cash.Name = "SB_Cash"
        Me.SB_Cash.Size = New System.Drawing.Size(476, 38)
        Me.SB_Cash.StyleController = Me.LC_Frame2
        Me.SB_Cash.TabIndex = 31
        Me.SB_Cash.Text = "&Cash Payment"
        '
        'SB_Print
        '
        Me.SB_Print.ImageOptions.Image = CType(resources.GetObject("SB_Print.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Print.Location = New System.Drawing.Point(1016, 794)
        Me.SB_Print.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Print.Name = "SB_Print"
        Me.SB_Print.Size = New System.Drawing.Size(449, 38)
        Me.SB_Print.StyleController = Me.LC_Frame2
        Me.SB_Print.TabIndex = 30
        Me.SB_Print.Text = "Cetak"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "WHID", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(431, 13)
        Me.LookUpEdit1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.LookUpEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.NullText = "-- Pilih Tujuan Gudang --"
        Me.LookUpEdit1.Properties.Padding = New System.Windows.Forms.Padding(-1, 0, -1, 1)
        Me.LookUpEdit1.Size = New System.Drawing.Size(214, 33)
        Me.LookUpEdit1.StyleController = Me.LC_Frame2
        Me.LookUpEdit1.TabIndex = 27
        '
        'SB_Continue
        '
        Me.SB_Continue.Location = New System.Drawing.Point(624, 137)
        Me.SB_Continue.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_Continue.Name = "SB_Continue"
        Me.SB_Continue.Size = New System.Drawing.Size(240, 28)
        Me.SB_Continue.StyleController = Me.LC_Frame2
        Me.SB_Continue.TabIndex = 25
        Me.SB_Continue.Text = "&Submit Header"
        '
        'ComboBoxEdit_Payment
        '
        Me.ComboBoxEdit_Payment.DataBindings.Add(New System.Windows.Forms.Binding("SelectedIndex", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "PaymentType", True))
        Me.ComboBoxEdit_Payment.EditValue = "Credit"
        Me.ComboBoxEdit_Payment.Location = New System.Drawing.Point(1116, 224)
        Me.ComboBoxEdit_Payment.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ComboBoxEdit_Payment.Name = "ComboBoxEdit_Payment"
        Me.ComboBoxEdit_Payment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxEdit_Payment.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit_Payment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit_Payment.Properties.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.ComboBoxEdit_Payment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBoxEdit_Payment.Size = New System.Drawing.Size(349, 32)
        Me.ComboBoxEdit_Payment.StyleController = Me.LC_Frame2
        Me.ComboBoxEdit_Payment.TabIndex = 18
        '
        'MRDateDateEdit
        '
        Me.MRDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "MRDate", True))
        Me.MRDateDateEdit.EditValue = Nothing
        Me.MRDateDateEdit.EnterMoveNextControl = True
        Me.MRDateDateEdit.Location = New System.Drawing.Point(122, 51)
        Me.MRDateDateEdit.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MRDateDateEdit.Name = "MRDateDateEdit"
        Me.MRDateDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.MRDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MRDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MRDateDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent
        Me.MRDateDateEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.MRDateDateEdit.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.MRDateDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.MRDateDateEdit.Size = New System.Drawing.Size(221, 32)
        Me.MRDateDateEdit.StyleController = Me.LC_Frame2
        Me.MRDateDateEdit.TabIndex = 12
        '
        'MRNoTextEdit
        '
        Me.MRNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "MRNo", True))
        Me.MRNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "ID", True))
        Me.MRNoTextEdit.EnterMoveNextControl = True
        Me.MRNoTextEdit.Location = New System.Drawing.Point(122, 13)
        Me.MRNoTextEdit.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MRNoTextEdit.Name = "MRNoTextEdit"
        Me.MRNoTextEdit.Properties.AllowFocused = False
        Me.MRNoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.MRNoTextEdit.Properties.ReadOnly = True
        Me.MRNoTextEdit.Properties.UseReadOnlyAppearance = False
        Me.MRNoTextEdit.Size = New System.Drawing.Size(221, 32)
        Me.MRNoTextEdit.StyleController = Me.LC_Frame2
        Me.MRNoTextEdit.TabIndex = 7
        '
        'Sp_SPPurchaseReceiveDetailGetDataGridControl
        '
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.DataSource = Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.Location = New System.Drawing.Point(14, 182)
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.Name = "Sp_SPPurchaseReceiveDetailGetDataGridControl"
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.SearchLUE_Inv, Me.Repo_Num_Detail})
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.Size = New System.Drawing.Size(984, 565)
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.TabIndex = 4
        Me.Sp_SPPurchaseReceiveDetailGetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'Sp_SPPurchaseReceiveDetail_GetDataBindingSource
        '
        Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource.DataMember = "sp_SPPurchaseReceiveDetail_GetData"
        Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Detail
        '
        Me.GV_Detail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Detail.Appearance.Row.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.GV_Detail.Appearance.Row.Options.UseFont = True
        Me.GV_Detail.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Detail.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_Detail.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_Detail.AppearancePrint.HeaderPanel.Options.UseBackColor = True
        Me.GV_Detail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GV_Detail.ColumnPanelRowHeight = 34
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Detail, Me.colMRID_Detail, Me.colMRNo_Detail, Me.colisInventory_Detail, Me.colInventoryID_Detail, Me.colQty_Detail, Me.colUoM_Detail, Me.colPrice_Detail, Me.colSubtotal_Detail, Me.colDescription_Detail, Me.colModifiedUser_Detail, Me.colModifiedDate_Detail, Me.colDiscPersen1, Me.colDiscPersen2, Me.colDiscPersen3, Me.colDisc})
        Me.GV_Detail.DetailHeight = 394
        Me.GV_Detail.DetailVerticalIndent = 11
        Me.GV_Detail.FixedLineWidth = 12
        Me.GV_Detail.GridControl = Me.Sp_SPPurchaseReceiveDetailGetDataGridControl
        Me.GV_Detail.LevelIndent = 39
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_Detail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Detail.OptionsView.ShowGroupPanel = False
        Me.GV_Detail.OptionsView.ShowIndicator = False
        Me.GV_Detail.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_Detail.RowHeight = 34
        Me.GV_Detail.ViewCaptionHeight = 11
        '
        'colID_Detail
        '
        Me.colID_Detail.FieldName = "ID"
        Me.colID_Detail.MinWidth = 26
        Me.colID_Detail.Name = "colID_Detail"
        Me.colID_Detail.Width = 129
        '
        'colMRID_Detail
        '
        Me.colMRID_Detail.FieldName = "MRID"
        Me.colMRID_Detail.MinWidth = 26
        Me.colMRID_Detail.Name = "colMRID_Detail"
        Me.colMRID_Detail.OptionsColumn.AllowEdit = False
        Me.colMRID_Detail.OptionsColumn.AllowFocus = False
        Me.colMRID_Detail.Width = 96
        '
        'colMRNo_Detail
        '
        Me.colMRNo_Detail.FieldName = "MRNo"
        Me.colMRNo_Detail.MinWidth = 26
        Me.colMRNo_Detail.Name = "colMRNo_Detail"
        Me.colMRNo_Detail.OptionsColumn.AllowEdit = False
        Me.colMRNo_Detail.OptionsColumn.AllowFocus = False
        Me.colMRNo_Detail.Width = 96
        '
        'colisInventory_Detail
        '
        Me.colisInventory_Detail.FieldName = "isInventory"
        Me.colisInventory_Detail.MinWidth = 26
        Me.colisInventory_Detail.Name = "colisInventory_Detail"
        Me.colisInventory_Detail.OptionsColumn.AllowEdit = False
        Me.colisInventory_Detail.OptionsColumn.AllowFocus = False
        Me.colisInventory_Detail.Width = 96
        '
        'colInventoryID_Detail
        '
        Me.colInventoryID_Detail.Caption = "Barang"
        Me.colInventoryID_Detail.ColumnEdit = Me.SearchLUE_Inv
        Me.colInventoryID_Detail.FieldName = "InventoryID"
        Me.colInventoryID_Detail.MinWidth = 15
        Me.colInventoryID_Detail.Name = "colInventoryID_Detail"
        Me.colInventoryID_Detail.OptionsFilter.AllowFilter = False
        Me.colInventoryID_Detail.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "InventoryID", "{0:n0}")})
        Me.colInventoryID_Detail.Visible = True
        Me.colInventoryID_Detail.VisibleIndex = 0
        Me.colInventoryID_Detail.Width = 65
        '
        'SearchLUE_Inv
        '
        Me.SearchLUE_Inv.AutoHeight = False
        Me.SearchLUE_Inv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLUE_Inv.DataSource = Me.Sp_SPPurchase_GetInventoryDataBindingSource
        Me.SearchLUE_Inv.DisplayMember = "Name"
        Me.SearchLUE_Inv.Name = "SearchLUE_Inv"
        Me.SearchLUE_Inv.PopupView = Me.RepositoryItemSearchLookUpEdit1View
        Me.SearchLUE_Inv.ShowAddNewButton = True
        Me.SearchLUE_Inv.ValueMember = "ID"
        '
        'Sp_SPPurchase_GetInventoryDataBindingSource
        '
        Me.Sp_SPPurchase_GetInventoryDataBindingSource.DataMember = "sp_SPPurchase_GetInventoryData"
        Me.Sp_SPPurchase_GetInventoryDataBindingSource.DataSource = Me.DataSet
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colInventoryNo, Me.colName, Me.colBrand, Me.colCategory, Me.colType, Me.colUoMID_Repo, Me.colRemark, Me.colPrice_Repo})
        Me.RepositoryItemSearchLookUpEdit1View.DetailHeight = 394
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.MinWidth = 26
        Me.colID1.Name = "colID1"
        Me.colID1.OptionsColumn.AllowEdit = False
        Me.colID1.OptionsColumn.AllowFocus = False
        Me.colID1.Width = 96
        '
        'colInventoryNo
        '
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MinWidth = 26
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsColumn.AllowEdit = False
        Me.colInventoryNo.OptionsColumn.AllowFocus = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 0
        Me.colInventoryNo.Width = 96
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.MinWidth = 26
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.AllowEdit = False
        Me.colName.OptionsColumn.AllowFocus = False
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        Me.colName.Width = 96
        '
        'colBrand
        '
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.MinWidth = 26
        Me.colBrand.Name = "colBrand"
        Me.colBrand.OptionsColumn.AllowEdit = False
        Me.colBrand.OptionsColumn.AllowFocus = False
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 2
        Me.colBrand.Width = 96
        '
        'colCategory
        '
        Me.colCategory.FieldName = "Category"
        Me.colCategory.MinWidth = 26
        Me.colCategory.Name = "colCategory"
        Me.colCategory.OptionsColumn.AllowEdit = False
        Me.colCategory.OptionsColumn.AllowFocus = False
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 3
        Me.colCategory.Width = 96
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.MinWidth = 26
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.AllowEdit = False
        Me.colType.OptionsColumn.AllowFocus = False
        Me.colType.Width = 96
        '
        'colUoMID_Repo
        '
        Me.colUoMID_Repo.FieldName = "UoMID"
        Me.colUoMID_Repo.MinWidth = 26
        Me.colUoMID_Repo.Name = "colUoMID_Repo"
        Me.colUoMID_Repo.OptionsColumn.AllowEdit = False
        Me.colUoMID_Repo.OptionsColumn.AllowFocus = False
        Me.colUoMID_Repo.Visible = True
        Me.colUoMID_Repo.VisibleIndex = 4
        Me.colUoMID_Repo.Width = 96
        '
        'colRemark
        '
        Me.colRemark.FieldName = "Remark"
        Me.colRemark.MinWidth = 26
        Me.colRemark.Name = "colRemark"
        Me.colRemark.OptionsColumn.AllowEdit = False
        Me.colRemark.OptionsColumn.AllowFocus = False
        Me.colRemark.Width = 96
        '
        'colPrice_Repo
        '
        Me.colPrice_Repo.DisplayFormat.FormatString = "n0"
        Me.colPrice_Repo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice_Repo.FieldName = "Price"
        Me.colPrice_Repo.MinWidth = 26
        Me.colPrice_Repo.Name = "colPrice_Repo"
        Me.colPrice_Repo.OptionsColumn.AllowEdit = False
        Me.colPrice_Repo.OptionsColumn.AllowFocus = False
        Me.colPrice_Repo.Visible = True
        Me.colPrice_Repo.VisibleIndex = 5
        Me.colPrice_Repo.Width = 96
        '
        'colQty_Detail
        '
        Me.colQty_Detail.Caption = "Qty"
        Me.colQty_Detail.ColumnEdit = Me.Repo_Num_Detail
        Me.colQty_Detail.DisplayFormat.FormatString = "n0"
        Me.colQty_Detail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty_Detail.FieldName = "Qty"
        Me.colQty_Detail.MaxWidth = 76
        Me.colQty_Detail.MinWidth = 76
        Me.colQty_Detail.Name = "colQty_Detail"
        Me.colQty_Detail.OptionsFilter.AllowFilter = False
        Me.colQty_Detail.Visible = True
        Me.colQty_Detail.VisibleIndex = 1
        Me.colQty_Detail.Width = 76
        '
        'Repo_Num_Detail
        '
        Me.Repo_Num_Detail.AutoHeight = False
        Me.Repo_Num_Detail.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Repo_Num_Detail.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.Repo_Num_Detail.MaskSettings.Set("mask", "n0")
        Me.Repo_Num_Detail.Name = "Repo_Num_Detail"
        Me.Repo_Num_Detail.UseMaskAsDisplayFormat = True
        '
        'colUoM_Detail
        '
        Me.colUoM_Detail.Caption = "Satuan"
        Me.colUoM_Detail.FieldName = "UoMID"
        Me.colUoM_Detail.MaxWidth = 76
        Me.colUoM_Detail.MinWidth = 76
        Me.colUoM_Detail.Name = "colUoM_Detail"
        Me.colUoM_Detail.OptionsColumn.AllowEdit = False
        Me.colUoM_Detail.OptionsColumn.AllowFocus = False
        Me.colUoM_Detail.OptionsFilter.AllowFilter = False
        Me.colUoM_Detail.Width = 76
        '
        'colPrice_Detail
        '
        Me.colPrice_Detail.Caption = "Harga"
        Me.colPrice_Detail.ColumnEdit = Me.Repo_Num_Detail
        Me.colPrice_Detail.DisplayFormat.FormatString = "n0"
        Me.colPrice_Detail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice_Detail.FieldName = "Price"
        Me.colPrice_Detail.MaxWidth = 154
        Me.colPrice_Detail.MinWidth = 154
        Me.colPrice_Detail.Name = "colPrice_Detail"
        Me.colPrice_Detail.OptionsFilter.AllowFilter = False
        Me.colPrice_Detail.Visible = True
        Me.colPrice_Detail.VisibleIndex = 2
        Me.colPrice_Detail.Width = 154
        '
        'colSubtotal_Detail
        '
        Me.colSubtotal_Detail.ColumnEdit = Me.Repo_Num_Detail
        Me.colSubtotal_Detail.DisplayFormat.FormatString = "n0"
        Me.colSubtotal_Detail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotal_Detail.FieldName = "Subtotal"
        Me.colSubtotal_Detail.MaxWidth = 150
        Me.colSubtotal_Detail.MinWidth = 150
        Me.colSubtotal_Detail.Name = "colSubtotal_Detail"
        Me.colSubtotal_Detail.OptionsFilter.AllowFilter = False
        Me.colSubtotal_Detail.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "{0:n0}")})
        Me.colSubtotal_Detail.Visible = True
        Me.colSubtotal_Detail.VisibleIndex = 7
        Me.colSubtotal_Detail.Width = 150
        '
        'colDescription_Detail
        '
        Me.colDescription_Detail.FieldName = "Description"
        Me.colDescription_Detail.MaxWidth = 193
        Me.colDescription_Detail.MinWidth = 193
        Me.colDescription_Detail.Name = "colDescription_Detail"
        Me.colDescription_Detail.OptionsColumn.AllowEdit = False
        Me.colDescription_Detail.OptionsColumn.AllowFocus = False
        Me.colDescription_Detail.OptionsFilter.AllowFilter = False
        Me.colDescription_Detail.Visible = True
        Me.colDescription_Detail.VisibleIndex = 8
        Me.colDescription_Detail.Width = 193
        '
        'colModifiedUser_Detail
        '
        Me.colModifiedUser_Detail.FieldName = "ModifiedUser"
        Me.colModifiedUser_Detail.MinWidth = 26
        Me.colModifiedUser_Detail.Name = "colModifiedUser_Detail"
        Me.colModifiedUser_Detail.OptionsColumn.AllowEdit = False
        Me.colModifiedUser_Detail.OptionsColumn.AllowFocus = False
        Me.colModifiedUser_Detail.Width = 96
        '
        'colModifiedDate_Detail
        '
        Me.colModifiedDate_Detail.FieldName = "ModifiedDate"
        Me.colModifiedDate_Detail.MinWidth = 26
        Me.colModifiedDate_Detail.Name = "colModifiedDate_Detail"
        Me.colModifiedDate_Detail.OptionsColumn.AllowEdit = False
        Me.colModifiedDate_Detail.OptionsColumn.AllowFocus = False
        Me.colModifiedDate_Detail.Width = 96
        '
        'colDiscPersen1
        '
        Me.colDiscPersen1.Caption = "Disc 1(%)"
        Me.colDiscPersen1.ColumnEdit = Me.Repo_Num_Detail
        Me.colDiscPersen1.DisplayFormat.FormatString = "n2"
        Me.colDiscPersen1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiscPersen1.FieldName = "DiscPersen1"
        Me.colDiscPersen1.MaxWidth = 80
        Me.colDiscPersen1.MinWidth = 80
        Me.colDiscPersen1.Name = "colDiscPersen1"
        Me.colDiscPersen1.OptionsFilter.AllowFilter = False
        Me.colDiscPersen1.Visible = True
        Me.colDiscPersen1.VisibleIndex = 3
        Me.colDiscPersen1.Width = 80
        '
        'colDiscPersen2
        '
        Me.colDiscPersen2.Caption = "Disc 2(%)"
        Me.colDiscPersen2.ColumnEdit = Me.Repo_Num_Detail
        Me.colDiscPersen2.DisplayFormat.FormatString = "n2"
        Me.colDiscPersen2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiscPersen2.FieldName = "DiscPersen2"
        Me.colDiscPersen2.MaxWidth = 80
        Me.colDiscPersen2.MinWidth = 80
        Me.colDiscPersen2.Name = "colDiscPersen2"
        Me.colDiscPersen2.OptionsFilter.AllowFilter = False
        Me.colDiscPersen2.Visible = True
        Me.colDiscPersen2.VisibleIndex = 4
        Me.colDiscPersen2.Width = 80
        '
        'colDiscPersen3
        '
        Me.colDiscPersen3.Caption = "Disc 3(%)"
        Me.colDiscPersen3.ColumnEdit = Me.Repo_Num_Detail
        Me.colDiscPersen3.DisplayFormat.FormatString = "n2"
        Me.colDiscPersen3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiscPersen3.FieldName = "DiscPersen3"
        Me.colDiscPersen3.MaxWidth = 80
        Me.colDiscPersen3.MinWidth = 80
        Me.colDiscPersen3.Name = "colDiscPersen3"
        Me.colDiscPersen3.OptionsFilter.AllowFilter = False
        Me.colDiscPersen3.Visible = True
        Me.colDiscPersen3.VisibleIndex = 5
        Me.colDiscPersen3.Width = 80
        '
        'colDisc
        '
        Me.colDisc.Caption = "Disc (Rp)"
        Me.colDisc.ColumnEdit = Me.Repo_Num_Detail
        Me.colDisc.DisplayFormat.FormatString = "n0"
        Me.colDisc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDisc.FieldName = "Disc"
        Me.colDisc.MaxWidth = 96
        Me.colDisc.MinWidth = 96
        Me.colDisc.Name = "colDisc"
        Me.colDisc.OptionsFilter.AllowFilter = False
        Me.colDisc.Visible = True
        Me.colDisc.VisibleIndex = 6
        Me.colDisc.Width = 96
        '
        'SearchLookUpEdit_Supplier
        '
        Me.SearchLookUpEdit_Supplier.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "SupplierID", True))
        Me.SearchLookUpEdit_Supplier.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SearchLookUpEdit_Supplier.Location = New System.Drawing.Point(1081, 13)
        Me.SearchLookUpEdit_Supplier.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SearchLookUpEdit_Supplier.Name = "SearchLookUpEdit_Supplier"
        Me.SearchLookUpEdit_Supplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SearchLookUpEdit_Supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit_Supplier.Properties.DataSource = Me.SpSPMDSupplierGetDataBindingSource
        Me.SearchLookUpEdit_Supplier.Properties.DisplayMember = "SupplierName"
        Me.SearchLookUpEdit_Supplier.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.SearchLookUpEdit_Supplier.Properties.NullText = ""
        Me.SearchLookUpEdit_Supplier.Properties.NullValuePrompt = "-- Pilih Supplier Dahulu --"
        Me.SearchLookUpEdit_Supplier.Properties.PopupView = Me.GV_Supplier
        Me.SearchLookUpEdit_Supplier.Properties.ShowAddNewButton = True
        Me.SearchLookUpEdit_Supplier.Properties.ValueMember = "ID"
        Me.SearchLookUpEdit_Supplier.Size = New System.Drawing.Size(400, 32)
        Me.SearchLookUpEdit_Supplier.StyleController = Me.LC_Frame2
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
        Me.GV_Supplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Supp, Me.colSupplierName_Supp, Me.colDescription_Supp, Me.colAddress})
        Me.GV_Supplier.DetailHeight = 394
        Me.GV_Supplier.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GV_Supplier.Name = "GV_Supplier"
        Me.GV_Supplier.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GV_Supplier.OptionsView.ShowGroupPanel = False
        '
        'colID_Supp
        '
        Me.colID_Supp.FieldName = "ID"
        Me.colID_Supp.MinWidth = 26
        Me.colID_Supp.Name = "colID_Supp"
        Me.colID_Supp.Width = 96
        '
        'colSupplierName_Supp
        '
        Me.colSupplierName_Supp.Caption = "Nama"
        Me.colSupplierName_Supp.FieldName = "SupplierName"
        Me.colSupplierName_Supp.MinWidth = 26
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
        Me.colDescription_Supp.MinWidth = 26
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
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.AllowEdit = False
        Me.colAddress.OptionsColumn.AllowFocus = False
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 2
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "Description", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(122, 89)
        Me.MemoEdit1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.MemoEdit1.Size = New System.Drawing.Size(523, 32)
        Me.MemoEdit1.StyleController = Me.LC_Frame2
        Me.MemoEdit1.TabIndex = 20
        '
        'CE_Print
        '
        Me.CE_Print.Location = New System.Drawing.Point(900, 793)
        Me.CE_Print.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.CE_Print.Name = "CE_Print"
        Me.CE_Print.Properties.Caption = "Lunas"
        Me.CE_Print.Size = New System.Drawing.Size(110, 22)
        Me.CE_Print.StyleController = Me.LC_Frame2
        Me.CE_Print.TabIndex = 21
        '
        'Ed_GrossTotal
        '
        Me.Ed_GrossTotal.EditValue = 0
        Me.Ed_GrossTotal.Location = New System.Drawing.Point(1206, 513)
        Me.Ed_GrossTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.Ed_GrossTotal.Name = "Ed_GrossTotal"
        Me.Ed_GrossTotal.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_GrossTotal.Properties.Appearance.Options.UseFont = True
        Me.Ed_GrossTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_GrossTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_GrossTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_GrossTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_GrossTotal.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_GrossTotal.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_GrossTotal.Properties.Padding = New System.Windows.Forms.Padding(0, 0, -1, 1)
        Me.Ed_GrossTotal.Size = New System.Drawing.Size(259, 33)
        Me.Ed_GrossTotal.StyleController = Me.LC_Frame2
        Me.Ed_GrossTotal.TabIndex = 33
        '
        'Ed_NetValue
        '
        Me.Ed_NetValue.EditValue = 0
        Me.Ed_NetValue.Location = New System.Drawing.Point(1206, 591)
        Me.Ed_NetValue.Margin = New System.Windows.Forms.Padding(0)
        Me.Ed_NetValue.Name = "Ed_NetValue"
        Me.Ed_NetValue.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_NetValue.Properties.Appearance.Options.UseFont = True
        Me.Ed_NetValue.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_NetValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_NetValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_NetValue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_NetValue.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_NetValue.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_NetValue.Properties.Padding = New System.Windows.Forms.Padding(0, 0, -1, 1)
        Me.Ed_NetValue.Size = New System.Drawing.Size(259, 33)
        Me.Ed_NetValue.StyleController = Me.LC_Frame2
        Me.Ed_NetValue.TabIndex = 33
        '
        'Ed_DP
        '
        Me.Ed_DP.EditValue = 0
        Me.Ed_DP.Location = New System.Drawing.Point(1206, 630)
        Me.Ed_DP.Margin = New System.Windows.Forms.Padding(0)
        Me.Ed_DP.Name = "Ed_DP"
        Me.Ed_DP.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_DP.Properties.Appearance.Options.UseFont = True
        Me.Ed_DP.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_DP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_DP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_DP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_DP.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_DP.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_DP.Properties.Padding = New System.Windows.Forms.Padding(0, 0, -1, 1)
        Me.Ed_DP.Size = New System.Drawing.Size(259, 33)
        Me.Ed_DP.StyleController = Me.LC_Frame2
        Me.Ed_DP.TabIndex = 33
        '
        'Ed_Balance
        '
        Me.Ed_Balance.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "GrandTotal", True))
        Me.Ed_Balance.EditValue = 0
        Me.Ed_Balance.Location = New System.Drawing.Point(1206, 669)
        Me.Ed_Balance.Margin = New System.Windows.Forms.Padding(0)
        Me.Ed_Balance.Name = "Ed_Balance"
        Me.Ed_Balance.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_Balance.Properties.Appearance.Options.UseFont = True
        Me.Ed_Balance.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Balance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Balance.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_Balance.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Balance.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Balance.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Balance.Properties.Padding = New System.Windows.Forms.Padding(0, 0, -1, 1)
        Me.Ed_Balance.Size = New System.Drawing.Size(259, 33)
        Me.Ed_Balance.StyleController = Me.LC_Frame2
        Me.Ed_Balance.TabIndex = 33
        '
        'Ed_DiscPercentage
        '
        Me.Ed_DiscPercentage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "Disc1", True))
        Me.Ed_DiscPercentage.Location = New System.Drawing.Point(1090, 371)
        Me.Ed_DiscPercentage.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_DiscPercentage.MaximumSize = New System.Drawing.Size(64, 0)
        Me.Ed_DiscPercentage.Name = "Ed_DiscPercentage"
        Me.Ed_DiscPercentage.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_DiscPercentage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_DiscPercentage.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_DiscPercentage.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_DiscPercentage.Properties.MaskSettings.Set("mask", "n2")
        Me.Ed_DiscPercentage.Properties.MaxLength = 5
        Me.Ed_DiscPercentage.Properties.Padding = New System.Windows.Forms.Padding(0, 1, -1, 0)
        Me.Ed_DiscPercentage.Size = New System.Drawing.Size(64, 33)
        Me.Ed_DiscPercentage.StyleController = Me.LC_Frame2
        Me.Ed_DiscPercentage.TabIndex = 33
        '
        'Ed_Termin
        '
        Me.Ed_Termin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "LongTerm", True))
        Me.Ed_Termin.EditValue = 0
        Me.Ed_Termin.Location = New System.Drawing.Point(1146, 262)
        Me.Ed_Termin.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_Termin.Name = "Ed_Termin"
        Me.Ed_Termin.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_Termin.Properties.Appearance.Options.UseFont = True
        Me.Ed_Termin.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Termin.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Termin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_Termin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Termin.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Termin.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Termin.Properties.Padding = New System.Windows.Forms.Padding(0, 1, -1, 0)
        Me.Ed_Termin.Size = New System.Drawing.Size(162, 33)
        Me.Ed_Termin.StyleController = Me.LC_Frame2
        Me.Ed_Termin.TabIndex = 33
        '
        'Ed_DiscValue
        '
        Me.Ed_DiscValue.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "DiscValue", True))
        Me.Ed_DiscValue.Location = New System.Drawing.Point(1160, 332)
        Me.Ed_DiscValue.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_DiscValue.Name = "Ed_DiscValue"
        Me.Ed_DiscValue.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_DiscValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_DiscValue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_DiscValue.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_DiscValue.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_DiscValue.Properties.Padding = New System.Windows.Forms.Padding(0, 0, -1, 1)
        Me.Ed_DiscValue.Size = New System.Drawing.Size(133, 33)
        Me.Ed_DiscValue.StyleController = Me.LC_Frame2
        Me.Ed_DiscValue.TabIndex = 33
        '
        'Ed_PPnValue
        '
        Me.Ed_PPnValue.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "PPnValue", True))
        Me.Ed_PPnValue.Location = New System.Drawing.Point(1355, 371)
        Me.Ed_PPnValue.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_PPnValue.Name = "Ed_PPnValue"
        Me.Ed_PPnValue.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_PPnValue.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_PPnValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_PPnValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_PPnValue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_PPnValue.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_PPnValue.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_PPnValue.Properties.Padding = New System.Windows.Forms.Padding(0, 0, -1, 1)
        Me.Ed_PPnValue.Size = New System.Drawing.Size(110, 33)
        Me.Ed_PPnValue.StyleController = Me.LC_Frame2
        Me.Ed_PPnValue.TabIndex = 33
        '
        'Ed_PPnPercetage
        '
        Me.Ed_PPnPercetage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, "PPnPercentage", True))
        Me.Ed_PPnPercetage.Location = New System.Drawing.Point(1355, 332)
        Me.Ed_PPnPercetage.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Ed_PPnPercetage.Name = "Ed_PPnPercetage"
        Me.Ed_PPnPercetage.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_PPnPercetage.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_PPnPercetage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_PPnPercetage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_PPnPercetage.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_PPnPercetage.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_PPnPercetage.Properties.MaskSettings.Set("mask", "n2")
        Me.Ed_PPnPercetage.Properties.MaxLength = 5
        Me.Ed_PPnPercetage.Properties.Padding = New System.Windows.Forms.Padding(0, 1, -1, 0)
        Me.Ed_PPnPercetage.Size = New System.Drawing.Size(62, 33)
        Me.Ed_PPnPercetage.StyleController = Me.LC_Frame2
        Me.Ed_PPnPercetage.TabIndex = 33
        '
        'Ed_Diskon
        '
        Me.Ed_Diskon.EditValue = 0
        Me.Ed_Diskon.Location = New System.Drawing.Point(1206, 552)
        Me.Ed_Diskon.Margin = New System.Windows.Forms.Padding(0)
        Me.Ed_Diskon.Name = "Ed_Diskon"
        Me.Ed_Diskon.Properties.Appearance.BackColor2 = System.Drawing.Color.Black
        Me.Ed_Diskon.Properties.Appearance.Options.UseFont = True
        Me.Ed_Diskon.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Diskon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Diskon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Ed_Diskon.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Diskon.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Diskon.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Diskon.Properties.Padding = New System.Windows.Forms.Padding(0, 0, -1, 1)
        Me.Ed_Diskon.Size = New System.Drawing.Size(259, 33)
        Me.Ed_Diskon.StyleController = Me.LC_Frame2
        Me.Ed_Diskon.TabIndex = 33
        '
        'LCGroup_Detail
        '
        Me.LCGroup_Detail.AllowBorderColorBlending = True
        Me.LCGroup_Detail.AppearanceGroup.Options.UseFont = True
        Me.LCGroup_Detail.AppearanceItemCaption.Options.UseFont = True
        Me.LCGroup_Detail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LCGroup_Detail.GroupBordersVisible = False
        Me.LCGroup_Detail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.SimpleSeparator3, Me.EmptySpaceItem17, Me.LayoutControlGroup2, Me.LCItem_Grid, Me.LCG_PPn, Me.LCItem_JumlahJenis, Me.LayoutControlGroup1, Me.LayoutControlItem21, Me.LayoutControlItem39, Me.LayoutControlItem34, Me.LayoutControlItem6, Me.LayoutControlItem13, Me.EmptySpaceItem7, Me.LayoutControlItem8, Me.LayoutControlItem20, Me.LCItem_CreateNew, Me.EmptySpaceItem15, Me.EmptySpaceItem2, Me.EmptySpaceItem6, Me.LayoutControlItem7, Me.LayoutControlItem1, Me.LayoutControlItem19, Me.EmptySpaceItem4, Me.LayoutControlItem15, Me.LayoutControlItem22, Me.EmptySpaceItem5, Me.LayoutControlItem12, Me.LCItem_SBContinue})
        Me.LCGroup_Detail.Name = "Root"
        Me.LCGroup_Detail.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0)
        Me.LCGroup_Detail.Size = New System.Drawing.Size(1484, 852)
        Me.LCGroup_Detail.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.MemoEdit1
        Me.LayoutControlItem16.Location = New System.Drawing.Point(10, 76)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(638, 0)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(638, 38)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(638, 38)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "Keterangan :"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(93, 18)
        '
        'SimpleSeparator3
        '
        Me.SimpleSeparator3.AllowHotTrack = False
        Me.SimpleSeparator3.Location = New System.Drawing.Point(0, 841)
        Me.SimpleSeparator3.Name = "SimpleSeparator3"
        Me.SimpleSeparator3.Size = New System.Drawing.Size(1484, 1)
        '
        'EmptySpaceItem17
        '
        Me.EmptySpaceItem17.AllowHotTrack = False
        Me.EmptySpaceItem17.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem17.MaxSize = New System.Drawing.Size(10, 0)
        Me.EmptySpaceItem17.MinSize = New System.Drawing.Size(10, 10)
        Me.EmptySpaceItem17.Name = "EmptySpaceItem17"
        Me.EmptySpaceItem17.Size = New System.Drawing.Size(10, 841)
        Me.EmptySpaceItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem17.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem12, Me.LayoutControlItem25, Me.LayoutControlItem23, Me.LayoutControlItem24})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(10, 765)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1474, 76)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'EmptySpaceItem12
        '
        Me.EmptySpaceItem12.AllowHotTrack = False
        Me.EmptySpaceItem12.Location = New System.Drawing.Point(643, 0)
        Me.EmptySpaceItem12.Name = "EmptySpaceItem12"
        Me.EmptySpaceItem12.Size = New System.Drawing.Size(223, 44)
        Me.EmptySpaceItem12.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.SB_InventoryCheck
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(643, 44)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.SB_Print
        Me.LayoutControlItem23.Location = New System.Drawing.Point(987, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(455, 44)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.CE_Print
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(866, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Padding = New DevExpress.XtraLayout.Utils.Padding(8, 3, 2, 2)
        Me.LayoutControlItem24.Size = New System.Drawing.Size(121, 44)
        Me.LayoutControlItem24.Text = "LayoutControlItem7"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextVisible = False
        '
        'LCItem_Grid
        '
        Me.LCItem_Grid.Control = Me.Sp_SPPurchaseReceiveDetailGetDataGridControl
        Me.LCItem_Grid.Location = New System.Drawing.Point(10, 168)
        Me.LCItem_Grid.Name = "LCItem_Grid"
        Me.LCItem_Grid.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
        Me.LCItem_Grid.Size = New System.Drawing.Size(992, 573)
        Me.LCItem_Grid.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_Grid.TextVisible = False
        '
        'LCG_PPn
        '
        Me.LCG_PPn.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem3, Me.LayoutControlItem11, Me.LCItem_LongTerm, Me.LCItem_LabelHari, Me.LCItem_DueDate, Me.LayoutControlItem30, Me.LayoutControlItem10, Me.LayoutControlItem18, Me.LayoutControlItem26, Me.LayoutControlItem36, Me.LayoutControlItem37, Me.LayoutControlItem35, Me.LayoutControlItem33})
        Me.LCG_PPn.Location = New System.Drawing.Point(1002, 168)
        Me.LCG_PPn.Name = "LCG_PPn"
        Me.LCG_PPn.Size = New System.Drawing.Size(482, 245)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 77)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(450, 31)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(450, 31)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(450, 31)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.ComboBoxEdit_Payment
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(450, 38)
        Me.LayoutControlItem11.Text = "Pembayaran :"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(90, 18)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'LCItem_LongTerm
        '
        Me.LCItem_LongTerm.Control = Me.Ed_Termin
        Me.LCItem_LongTerm.CustomizationFormText = "Biaya Lain-lain :"
        Me.LCItem_LongTerm.Location = New System.Drawing.Point(0, 38)
        Me.LCItem_LongTerm.Name = "LCItem_LongTerm"
        Me.LCItem_LongTerm.Size = New System.Drawing.Size(293, 39)
        Me.LCItem_LongTerm.Text = "Lama Termin :"
        Me.LCItem_LongTerm.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LCItem_LongTerm.TextLocation = DevExpress.Utils.Locations.Left
        Me.LCItem_LongTerm.TextSize = New System.Drawing.Size(120, 20)
        Me.LCItem_LongTerm.TextToControlDistance = 5
        '
        'LCItem_LabelHari
        '
        Me.LCItem_LabelHari.Control = Me.LabelControl1
        Me.LCItem_LabelHari.Location = New System.Drawing.Point(293, 38)
        Me.LCItem_LabelHari.Name = "LCItem_LabelHari"
        Me.LCItem_LabelHari.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 10, 2)
        Me.LCItem_LabelHari.Size = New System.Drawing.Size(35, 39)
        Me.LCItem_LabelHari.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_LabelHari.TextVisible = False
        '
        'LCItem_DueDate
        '
        Me.LCItem_DueDate.Control = Me.Dt_Termin
        Me.LCItem_DueDate.Location = New System.Drawing.Point(328, 38)
        Me.LCItem_DueDate.Name = "LCItem_DueDate"
        Me.LCItem_DueDate.Size = New System.Drawing.Size(122, 39)
        Me.LCItem_DueDate.Text = "  "
        Me.LCItem_DueDate.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_DueDate.TextSize = New System.Drawing.Size(6, 18)
        Me.LCItem_DueDate.TextToControlDistance = 5
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.Ed_DiscPercentage
        Me.LayoutControlItem30.CustomizationFormText = "Biaya Lain-lain :"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 147)
        Me.LayoutControlItem30.MaxSize = New System.Drawing.Size(140, 28)
        Me.LayoutControlItem30.MinSize = New System.Drawing.Size(140, 28)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(140, 39)
        Me.LayoutControlItem30.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem30.Text = "Diskon :"
        Me.LayoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem30.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(64, 20)
        Me.LayoutControlItem30.TextToControlDistance = 5
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Ed_Disc2
        Me.LayoutControlItem10.Location = New System.Drawing.Point(140, 147)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(69, 28)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(69, 28)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(69, 39)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.Ed_Disc3
        Me.LayoutControlItem18.Location = New System.Drawing.Point(209, 147)
        Me.LayoutControlItem18.MaxSize = New System.Drawing.Size(69, 28)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(69, 28)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(69, 39)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.CE_MultiDisc
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 108)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(131, 39)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.Ed_PPnPercetage
        Me.LayoutControlItem36.CustomizationFormText = "Biaya Lain-lain :"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(278, 108)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(124, 39)
        Me.LayoutControlItem36.Text = "PPn :"
        Me.LayoutControlItem36.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem36.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(51, 20)
        Me.LayoutControlItem36.TextToControlDistance = 5
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.CE_PPnPercentage
        Me.LayoutControlItem37.Location = New System.Drawing.Point(402, 108)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(48, 39)
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.Ed_PPnValue
        Me.LayoutControlItem35.CustomizationFormText = "Biaya Lain-lain :"
        Me.LayoutControlItem35.Location = New System.Drawing.Point(278, 147)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(172, 39)
        Me.LayoutControlItem35.Text = " "
        Me.LayoutControlItem35.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem35.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(51, 20)
        Me.LayoutControlItem35.TextToControlDistance = 5
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.Ed_DiscValue
        Me.LayoutControlItem33.CustomizationFormText = "Biaya Lain-lain :"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(131, 108)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(147, 39)
        Me.LayoutControlItem33.Text = " "
        Me.LayoutControlItem33.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem33.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(3, 20)
        Me.LayoutControlItem33.TextToControlDistance = 5
        '
        'LCItem_JumlahJenis
        '
        Me.LCItem_JumlahJenis.AppearanceItemCaption.Options.UseFont = True
        Me.LCItem_JumlahJenis.Control = Me.Label_JumlahJenis
        Me.LCItem_JumlahJenis.Location = New System.Drawing.Point(10, 741)
        Me.LCItem_JumlahJenis.Name = "LCItem_JumlahJenis"
        Me.LCItem_JumlahJenis.Size = New System.Drawing.Size(992, 24)
        Me.LCItem_JumlahJenis.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_JumlahJenis.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_TaxTotal, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.LCItem_TaxTotal1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(1002, 457)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(482, 254)
        Me.LayoutControlGroup1.Text = ".::."
        '
        'LCItem_TaxTotal
        '
        Me.LCItem_TaxTotal.AppearanceItemCaption.Options.UseFont = True
        Me.LCItem_TaxTotal.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LCItem_TaxTotal.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LCItem_TaxTotal.Control = Me.Ed_GrossTotal
        Me.LCItem_TaxTotal.CustomizationFormText = "Biaya Lain-lain :"
        Me.LCItem_TaxTotal.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_TaxTotal.Name = "LCItem_TaxTotal"
        Me.LCItem_TaxTotal.Size = New System.Drawing.Size(450, 39)
        Me.LCItem_TaxTotal.Text = "Sub Total :"
        Me.LCItem_TaxTotal.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LCItem_TaxTotal.TextLocation = DevExpress.Utils.Locations.Left
        Me.LCItem_TaxTotal.TextSize = New System.Drawing.Size(180, 20)
        Me.LCItem_TaxTotal.TextToControlDistance = 5
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem27.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem27.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem27.Control = Me.Ed_NetValue
        Me.LayoutControlItem27.CustomizationFormText = "Biaya Lain-lain :"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(450, 39)
        Me.LayoutControlItem27.Text = "Total Keseluruhan :"
        Me.LayoutControlItem27.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem27.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(180, 20)
        Me.LayoutControlItem27.TextToControlDistance = 5
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem28.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem28.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem28.Control = Me.Ed_DP
        Me.LayoutControlItem28.CustomizationFormText = "Biaya Lain-lain :"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 117)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(450, 39)
        Me.LayoutControlItem28.Text = "Uang Muka :"
        Me.LayoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(180, 20)
        Me.LayoutControlItem28.TextToControlDistance = 5
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem29.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem29.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem29.Control = Me.Ed_Balance
        Me.LayoutControlItem29.CustomizationFormText = "Biaya Lain-lain :"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(450, 39)
        Me.LayoutControlItem29.Text = "Saldo Terhutang :"
        Me.LayoutControlItem29.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem29.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(180, 20)
        Me.LayoutControlItem29.TextToControlDistance = 5
        '
        'LCItem_TaxTotal1
        '
        Me.LCItem_TaxTotal1.AppearanceItemCaption.Options.UseFont = True
        Me.LCItem_TaxTotal1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LCItem_TaxTotal1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LCItem_TaxTotal1.Control = Me.Ed_Diskon
        Me.LCItem_TaxTotal1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCItem_TaxTotal1.CustomizationFormText = "Biaya Lain-lain :"
        Me.LCItem_TaxTotal1.Location = New System.Drawing.Point(0, 39)
        Me.LCItem_TaxTotal1.Name = "LCItem_TaxTotal1"
        Me.LCItem_TaxTotal1.Size = New System.Drawing.Size(450, 39)
        Me.LCItem_TaxTotal1.Text = "Diskon :"
        Me.LCItem_TaxTotal1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LCItem_TaxTotal1.TextLocation = DevExpress.Utils.Locations.Left
        Me.LCItem_TaxTotal1.TextSize = New System.Drawing.Size(180, 20)
        Me.LCItem_TaxTotal1.TextToControlDistance = 5
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.SB_Cash
        Me.LayoutControlItem21.Location = New System.Drawing.Point(1002, 413)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(482, 44)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SB_Apply
        Me.LayoutControlItem12.Location = New System.Drawing.Point(1290, 124)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(194, 44)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.Ed_Barcode
        Me.LayoutControlItem39.Location = New System.Drawing.Point(185, 124)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(191, 44)
        Me.LayoutControlItem39.Text = " "
        Me.LayoutControlItem39.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(3, 18)
        Me.LayoutControlItem39.TextToControlDistance = 5
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.Ed_QtyInput
        Me.LayoutControlItem34.Location = New System.Drawing.Point(115, 124)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(70, 44)
        Me.LayoutControlItem34.Text = "#"
        Me.LayoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(9, 18)
        Me.LayoutControlItem34.TextToControlDistance = 5
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SB_Back
        Me.LayoutControlItem6.Location = New System.Drawing.Point(10, 124)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(105, 44)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(105, 44)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(105, 44)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.MRDateDateEdit
        Me.LayoutControlItem13.Location = New System.Drawing.Point(10, 38)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(336, 38)
        Me.LayoutControlItem13.Text = "Tanggal :"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(93, 18)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(346, 0)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(19, 76)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.MRNoTextEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(10, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(336, 38)
        Me.LayoutControlItem8.Text = "No. Order :"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(93, 18)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.LookUpEdit1
        Me.LayoutControlItem20.Location = New System.Drawing.Point(365, 0)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(283, 76)
        Me.LayoutControlItem20.Text = "Gudang :"
        Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(58, 18)
        Me.LayoutControlItem20.TextToControlDistance = 5
        '
        'EmptySpaceItem15
        '
        Me.EmptySpaceItem15.AllowHotTrack = False
        Me.EmptySpaceItem15.Location = New System.Drawing.Point(10, 114)
        Me.EmptySpaceItem15.Name = "EmptySpaceItem15"
        Me.EmptySpaceItem15.Size = New System.Drawing.Size(1474, 10)
        Me.EmptySpaceItem15.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(867, 124)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(423, 44)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(414, 124)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(0, 12)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(10, 12)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(69, 44)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LCItem_SBContinue
        '
        Me.LCItem_SBContinue.Control = Me.SB_Continue
        Me.LCItem_SBContinue.Location = New System.Drawing.Point(621, 124)
        Me.LCItem_SBContinue.Name = "LCItem_SBContinue"
        Me.LCItem_SBContinue.Size = New System.Drawing.Size(246, 44)
        Me.LCItem_SBContinue.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_SBContinue.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_SupRefresh
        Me.LayoutControlItem7.Location = New System.Drawing.Point(376, 124)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(38, 44)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SB_Save
        Me.LayoutControlItem1.Location = New System.Drawing.Point(1002, 721)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(482, 44)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.LUE_SupplierCity
        Me.LayoutControlItem19.Location = New System.Drawing.Point(969, 76)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(515, 38)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(515, 38)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(515, 38)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Kota Supp. :"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(93, 18)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(1002, 711)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(482, 10)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SearchLookUpEdit_Supplier
        Me.LayoutControlItem15.Location = New System.Drawing.Point(969, 0)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(515, 38)
        Me.LayoutControlItem15.Text = "Supplier :"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(93, 18)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.LUE_SupplierAddress
        Me.LayoutControlItem22.Location = New System.Drawing.Point(969, 38)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(515, 38)
        Me.LayoutControlItem22.Text = "Alamat Supp. :"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(93, 18)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(648, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(321, 114)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'SpSPMDInventoryGetDataBindingSource
        '
        Me.SpSPMDInventoryGetDataBindingSource.DataMember = "sp_SP_MDInventory_GetData"
        Me.SpSPMDInventoryGetDataBindingSource.DataSource = Me.DataSet
        '
        'SpSPMDUoMDetailGetDataBindingSource
        '
        Me.SpSPMDUoMDetailGetDataBindingSource.DataMember = "sp_SP_MDUoMDetail_GetData"
        Me.SpSPMDUoMDetailGetDataBindingSource.DataSource = Me.DataSet
        '
        'PopupContainerControl1
        '
        Me.PopupContainerControl1.Controls.Add(Me.GridControl2)
        Me.PopupContainerControl1.Controls.Add(Me.GridControl1)
        Me.PopupContainerControl1.Location = New System.Drawing.Point(126, 87)
        Me.PopupContainerControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PopupContainerControl1.Name = "PopupContainerControl1"
        Me.PopupContainerControl1.Size = New System.Drawing.Size(1088, 406)
        Me.PopupContainerControl1.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.SpSPPurchaseGetPurchaseHeaderDataBindingSource
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.TV_Header
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(652, 406)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TV_Header})
        '
        'SpSPPurchaseGetPurchaseHeaderDataBindingSource
        '
        Me.SpSPPurchaseGetPurchaseHeaderDataBindingSource.DataMember = "sp_SPPurchase_GetPurchaseHeaderData"
        Me.SpSPPurchaseGetPurchaseHeaderDataBindingSource.DataSource = Me.DataSet
        '
        'TV_Header
        '
        Me.TV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvID, Me.colInvNo, Me.colInvDate, Me.colParam1Name, Me.colParam2Date, Me.colParam2Text, Me.colParam1ID})
        Me.TV_Header.GridControl = Me.GridControl2
        Me.TV_Header.Name = "TV_Header"
        Me.TV_Header.TileColumns.Add(TableColumnDefinition1)
        Me.TV_Header.TileColumns.Add(TableColumnDefinition2)
        Me.TV_Header.TileColumns.Add(TableColumnDefinition3)
        Me.TV_Header.TileRows.Add(TableRowDefinition1)
        Me.TV_Header.TileRows.Add(TableRowDefinition2)
        Me.TV_Header.TileRows.Add(TableRowDefinition3)
        TileViewItemElement1.Column = Me.colInvNo
        TileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement1.Text = "colInvNo"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.Column = Me.colInvID
        TileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement2.RowIndex = 1
        TileViewItemElement2.Text = "colInvID"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.Column = Me.colParam1Name
        TileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement3.RowIndex = 2
        TileViewItemElement3.Text = "colParam1Name"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.Column = Me.colInvDate
        TileViewItemElement4.ColumnIndex = 2
        TileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement4.Text = "colInvDate"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TV_Header.TileTemplate.Add(TileViewItemElement1)
        Me.TV_Header.TileTemplate.Add(TileViewItemElement2)
        Me.TV_Header.TileTemplate.Add(TileViewItemElement3)
        Me.TV_Header.TileTemplate.Add(TileViewItemElement4)
        '
        'colParam2Date
        '
        Me.colParam2Date.FieldName = "Param2Date"
        Me.colParam2Date.MinWidth = 21
        Me.colParam2Date.Name = "colParam2Date"
        Me.colParam2Date.Visible = True
        Me.colParam2Date.VisibleIndex = 4
        Me.colParam2Date.Width = 76
        '
        'colParam2Text
        '
        Me.colParam2Text.FieldName = "Param2Text"
        Me.colParam2Text.MinWidth = 21
        Me.colParam2Text.Name = "colParam2Text"
        Me.colParam2Text.Visible = True
        Me.colParam2Text.VisibleIndex = 5
        Me.colParam2Text.Width = 76
        '
        'colParam1ID
        '
        Me.colParam1ID.FieldName = "Param1ID"
        Me.colParam1ID.MinWidth = 21
        Me.colParam1ID.Name = "colParam1ID"
        Me.colParam1ID.Visible = True
        Me.colParam1ID.VisibleIndex = 6
        Me.colParam1ID.Width = 76
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SpSPPurchaseGetPurchaseDetailDataBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GridControl1.Location = New System.Drawing.Point(652, 0)
        Me.GridControl1.MainView = Me.GV_DetailData
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(436, 406)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_DetailData})
        '
        'SpSPPurchaseGetPurchaseDetailDataBindingSource
        '
        Me.SpSPPurchaseGetPurchaseDetailDataBindingSource.DataMember = "sp_SPPurchase_GetPurchaseDetailData"
        Me.SpSPPurchaseGetPurchaseDetailDataBindingSource.DataSource = Me.DataSet
        '
        'GV_DetailData
        '
        Me.GV_DetailData.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.GV_DetailData.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GV_DetailData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV_DetailData.Appearance.FocusedRow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_DetailData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_DetailData.Appearance.FocusedRow.Options.UseFont = True
        Me.GV_DetailData.Appearance.FooterPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_DetailData.Appearance.FooterPanel.Options.UseFont = True
        Me.GV_DetailData.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_DetailData.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_DetailData.Appearance.Row.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.GV_DetailData.Appearance.Row.Options.UseFont = True
        Me.GV_DetailData.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV_DetailData.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_DetailData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colInName, Me.colInQty, Me.colInWeight, Me.colInPrice, Me.colInDisc, Me.colInST})
        Me.GV_DetailData.GridControl = Me.GridControl1
        Me.GV_DetailData.Name = "GV_DetailData"
        Me.GV_DetailData.OptionsView.ShowGroupPanel = False
        Me.GV_DetailData.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 21
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.Width = 76
        '
        'colInName
        '
        Me.colInName.FieldName = "InName"
        Me.colInName.MinWidth = 21
        Me.colInName.Name = "colInName"
        Me.colInName.OptionsColumn.AllowEdit = False
        Me.colInName.OptionsColumn.AllowFocus = False
        Me.colInName.Visible = True
        Me.colInName.VisibleIndex = 0
        Me.colInName.Width = 315
        '
        'colInQty
        '
        Me.colInQty.Caption = "Qty"
        Me.colInQty.FieldName = "InQty"
        Me.colInQty.MinWidth = 21
        Me.colInQty.Name = "colInQty"
        Me.colInQty.OptionsColumn.AllowEdit = False
        Me.colInQty.OptionsColumn.AllowFocus = False
        Me.colInQty.OptionsFilter.AllowFilter = False
        Me.colInQty.Visible = True
        Me.colInQty.VisibleIndex = 1
        Me.colInQty.Width = 81
        '
        'colInWeight
        '
        Me.colInWeight.Caption = "Berat"
        Me.colInWeight.FieldName = "InWeight"
        Me.colInWeight.MinWidth = 21
        Me.colInWeight.Name = "colInWeight"
        Me.colInWeight.OptionsColumn.AllowEdit = False
        Me.colInWeight.OptionsColumn.AllowFocus = False
        Me.colInWeight.OptionsFilter.AllowFilter = False
        Me.colInWeight.Visible = True
        Me.colInWeight.VisibleIndex = 2
        Me.colInWeight.Width = 147
        '
        'colInPrice
        '
        Me.colInPrice.FieldName = "InPrice"
        Me.colInPrice.MinWidth = 21
        Me.colInPrice.Name = "colInPrice"
        Me.colInPrice.OptionsColumn.AllowEdit = False
        Me.colInPrice.OptionsColumn.AllowFocus = False
        Me.colInPrice.Width = 76
        '
        'colInDisc
        '
        Me.colInDisc.FieldName = "InDisc"
        Me.colInDisc.MinWidth = 21
        Me.colInDisc.Name = "colInDisc"
        Me.colInDisc.OptionsColumn.AllowEdit = False
        Me.colInDisc.OptionsColumn.AllowFocus = False
        Me.colInDisc.Width = 76
        '
        'colInST
        '
        Me.colInST.FieldName = "InST"
        Me.colInST.MinWidth = 21
        Me.colInST.Name = "colInST"
        Me.colInST.OptionsColumn.AllowEdit = False
        Me.colInST.OptionsColumn.AllowFocus = False
        Me.colInST.Width = 76
        '
        'SpMDUoMGetDataBindingSource
        '
        Me.SpMDUoMGetDataBindingSource.DataMember = "sp_MDUoMGetData"
        Me.SpMDUoMGetDataBindingSource.DataSource = Me.DataSet
        '
        'DxErrorProvider
        '
        Me.DxErrorProvider.ContainerControl = Me
        '
        'Sp_LookUpData_GetSupplierTableAdapter
        '
        Me.Sp_LookUpData_GetSupplierTableAdapter.ClearBeforeFill = True
        '
        'Sp_LookUpData_GetInventoryTableAdapter
        '
        Me.Sp_LookUpData_GetInventoryTableAdapter.ClearBeforeFill = True
        '
        'Sp_SP_MDUsage_GetDataTableAdapter
        '
        Me.Sp_SP_MDUsage_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDUoMGetDataTableAdapter
        '
        Me.Sp_MDUoMGetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_SP_MDUoMDetail_GetDataTableAdapter
        '
        Me.Sp_SP_MDUoMDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPPurchase_GetPurchaseDetailDataTableAdapter
        '
        Me.Sp_SPPurchase_GetPurchaseDetailDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPPurchase_GetPurchaseHeaderDataTableAdapter
        '
        Me.Sp_SPPurchase_GetPurchaseHeaderDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPPurchase_GetInventoryDataTableAdapter
        '
        Me.Sp_SPPurchase_GetInventoryDataTableAdapter.ClearBeforeFill = True
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_InventoryList_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDBrandGetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDCategoryGetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDTypeGetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPInvoiceDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPInvoiceHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveDetail_GetDataTableAdapter = Me.Sp_SPPurchaseReceiveDetail_GetDataTableAdapter
        Me.TableAdapterManager.sp_SPPurchaseReceiveHeader_GetDataTableAdapter = Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter
        Me.TableAdapterManager.sp_SPPurchaseOrderDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseOrderHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchasePaymentDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchasePaymentHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseRQDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseRQHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mod_MasterData.DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 88)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1503, 877)
        Me.XtraTabControl1.TabIndex = 12
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1501, 846)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LC_Frame2)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1501, 846)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.PopupContainerControl1)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1501, 846)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'LCItem_CreateNew
        '
        Me.LCItem_CreateNew.Control = Me.SB_CreateNew
        Me.LCItem_CreateNew.Location = New System.Drawing.Point(483, 124)
        Me.LCItem_CreateNew.Name = "LCItem_CreateNew"
        Me.LCItem_CreateNew.Size = New System.Drawing.Size(138, 44)
        Me.LCItem_CreateNew.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_CreateNew.TextVisible = False
        '
        'SB_CreateNew
        '
        Me.SB_CreateNew.Location = New System.Drawing.Point(486, 137)
        Me.SB_CreateNew.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.SB_CreateNew.Name = "SB_CreateNew"
        Me.SB_CreateNew.Size = New System.Drawing.Size(132, 28)
        Me.SB_CreateNew.StyleController = Me.LC_Frame2
        Me.SB_CreateNew.TabIndex = 35
        Me.SB_CreateNew.Text = "&Recreate Invoice"
        '
        'Frm_PurchaseReceivement
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1503, 965)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_PurchaseReceivement"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penerimaan Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.Sp_SPPurchaseReceiveHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPMDSupplierGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEditEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPMDUsageGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Frame2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LC_Frame2.ResumeLayout(False)
        CType(Me.LUE_SupplierCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_SupplierAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_QtyInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Barcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_MultiDisc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Disc3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Disc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_PPnPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_Termin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_Termin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit_Payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MRNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveDetailGetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseReceiveDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLUE_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchase_GetInventoryDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Num_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_Print.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_GrossTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_NetValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_DP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_DiscPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Termin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_DiscValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PPnValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PPnPercetage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Diskon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCG_PPn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_LongTerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_LabelHari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_JumlahJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_TaxTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_TaxTotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_SBContinue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPMDInventoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPMDUoMDetailGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupContainerControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPPurchaseGetPurchaseHeaderDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TV_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPPurchaseGetPurchaseDetailDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_DetailData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.LCItem_CreateNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents imageList1 As ImageList
    Friend WithEvents Sp_SPPurchaseReceiveHeader_GetDataBindingSource As BindingSource
    Friend WithEvents DateEditEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEditStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Sp_SPPurchaseReceiveHeader_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Header As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMRNo_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRDate_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrandTotal_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LC_Frame2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LCGroup_Detail As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Sp_SPPurchaseReceiveDetailGetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCItem_Grid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents MRDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MRNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents colID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRNo_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisInventory_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoM_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataSet As Dataset
    Friend WithEvents Sp_SPPurchaseReceiveHeader_GetDataTableAdapter As DatasetTableAdapters.sp_SPPurchaseReceiveHeader_GetDataTableAdapter
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_SPPurchaseReceiveDetail_GetDataTableAdapter As DatasetTableAdapters.sp_SPPurchaseReceiveDetail_GetDataTableAdapter
    Friend WithEvents SearchLookUpEdit_Supplier As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SpSPMDSupplierGetDataBindingSource As BindingSource
    Friend WithEvents GV_Supplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Sp_LookUpData_GetSupplierTableAdapter As DatasetTableAdapters.sp_LookUpData_GetSupplierTableAdapter
    Friend WithEvents colSupplierName_Supp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Supp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpSPMDInventoryGetDataBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetInventoryTableAdapter As DatasetTableAdapters.sp_LookUpData_GetInventoryTableAdapter
    Friend WithEvents colID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpSPMDUsageGetDataBindingSource As BindingSource
    Friend WithEvents Sp_SP_MDUsage_GetDataTableAdapter As DataSetTableAdapters.sp_SP_MDUsage_GetDataTableAdapter
    Friend WithEvents colUsageID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComboBoxEdit_Payment As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDueDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents SpMDUoMGetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDUoMGetDataTableAdapter As DataSetTableAdapters.sp_MDUoMGetDataTableAdapter
    Friend WithEvents SpSPMDUoMDetailGetDataBindingSource As BindingSource
    Friend WithEvents Sp_SP_MDUoMDetail_GetDataTableAdapter As DataSetTableAdapters.sp_SP_MDUoMDetail_GetDataTableAdapter
    Friend WithEvents SB_Continue As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCItem_SBContinue As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_InventoryCheck As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Cash As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CE_Print As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_GrossTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCItem_TaxTotal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_NetValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_DP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_Balance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_DiscPercentage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Dt_Termin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Ed_Termin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_DiscValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCItem_LongTerm As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_DueDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label_JumlahJenis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleSeparator3 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LCItem_JumlahJenis As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_PPnValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CE_PPnPercentage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Ed_PPnPercetage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem12 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SB_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Summary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SpSPPurchaseGetPurchaseHeaderDataBindingSource As BindingSource
    Friend WithEvents TV_Header As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colInvID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colInvNo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colInvDate As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colParam1Name As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colParam2Date As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colParam2Text As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colParam1ID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SpSPPurchaseGetPurchaseDetailDataBindingSource As BindingSource
    Friend WithEvents GV_DetailData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_SPPurchase_GetPurchaseDetailDataTableAdapter As DataSetTableAdapters.sp_SPPurchase_GetPurchaseDetailDataTableAdapter
    Friend WithEvents Sp_SPPurchase_GetPurchaseHeaderDataTableAdapter As DataSetTableAdapters.sp_SPPurchase_GetPurchaseHeaderDataTableAdapter
    Friend WithEvents SB_Exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_New As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem17 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LCItem_LabelHari As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Sp_SPPurchase_GetInventoryDataBindingSource As BindingSource
    Friend WithEvents Sp_SPPurchase_GetInventoryDataTableAdapter As DataSetTableAdapters.sp_SPPurchase_GetInventoryDataTableAdapter
    Friend WithEvents SB_SupRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Repo_Supplier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SearchLUE_Inv As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoMID_Repo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ed_Disc3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_Disc2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CE_MultiDisc As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colDiscPersen1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscPersen2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscPersen3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_QtyInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_Barcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colPrice_Repo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_Supp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SB_Apply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCG_PPn As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem15 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LUE_SupplierAddress As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LUE_SupplierCity As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Ed_Diskon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCItem_TaxTotal1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Repo_Num_Detail As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SB_CreateNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCItem_CreateNew As DevExpress.XtraLayout.LayoutControlItem
End Class
