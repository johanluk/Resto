<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_InvList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InvList))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Export = New DevExpress.XtraEditors.SimpleButton()
        Me.ToggleSwitch_Detail = New DevExpress.XtraEditors.ToggleSwitch()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BI_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.Sp_MDInventory_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.sp_MDInventory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUoMID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_UoM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpLookUpDataGetUoMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colMinStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colHPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokAwal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceBuy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_InventoryType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpLookUpDataGetInventoryTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BE_BarcodeToogle = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.BBI_CreateList = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_DeleteAll = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpMDInventoryGetTransactionDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInventoryNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPOSNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPOSDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Sp_MDInventory_GetHPPHistoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDInventory_GetHPPHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_HPP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRNo_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRDate_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPP_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_BarcodePrice = New DevExpress.XtraEditors.SimpleButton()
        Me.Sp_MDInventory_PrintBarcodeListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDInventory_PrintBarcodeListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Barcode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBarcode_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoNum_Barcode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrice_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_BarcodePrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCGroup_Barcode = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_MDUoMGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_MDInvBrand_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_MDInvCategory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_MDInvProduct_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.sp_MDInventory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_MDInventory_PrintBarcodeListTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_PrintBarcodeListTableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sp_MDInvBrand_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter()
        Me.Sp_MDInvCategory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter()
        Me.Sp_MDInvProduct_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvProduct_GetDataTableAdapter()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.QueriesTableAdapter = New Master_Data.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_MDUoMGetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDUoMGetDataTableAdapter()
        Me.Sp_MDInventory_GetTransactionDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetTransactionDataTableAdapter()
        Me.Sp_MDInventory_GetHPPHistoryTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetHPPHistoryTableAdapter()
        Me.ToastNotificationsManager1 = New DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(Me.components)
        Me.Sp_LookUpData_GetUoMTableAdapter = New Master_Data.DataSetTableAdapters.sp_LookUpData_GetUoMTableAdapter()
        Me.Sp_LookUpData_GetInventoryTypeTableAdapter = New Master_Data.DataSetTableAdapters.sp_LookUpData_GetInventoryTypeTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ToggleSwitch_Detail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetUoMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_InventoryType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetInventoryTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetTransactionDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetHPPHistoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetHPPHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_HPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoNum_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToastNotificationsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SB_Close)
        Me.LayoutControl1.Controls.Add(Me.SB_Export)
        Me.LayoutControl1.Controls.Add(Me.ToggleSwitch_Detail)
        Me.LayoutControl1.Controls.Add(Me.SearchControl1)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl1.Controls.Add(Me.SB_DeleteAll)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_GetHPPHistoryGridControl)
        Me.LayoutControl1.Controls.Add(Me.SB_BarcodePrice)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_PrintBarcodeListGridControl)
        Me.LayoutControl1.Controls.Add(Me.SB_BarcodePrint)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(318, 217, 432, 350)
        Me.LayoutControl1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1439, 693)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SB_Close
        '
        Me.SB_Close.ImageOptions.SvgImage = CType(resources.GetObject("SB_Close.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Close.Location = New System.Drawing.Point(886, 11)
        Me.SB_Close.Name = "SB_Close"
        Me.SB_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Close.Size = New System.Drawing.Size(86, 32)
        Me.SB_Close.StyleController = Me.LayoutControl1
        Me.SB_Close.TabIndex = 28
        Me.SB_Close.Text = "Close"
        '
        'SB_Export
        '
        Me.SB_Export.ImageOptions.SvgImage = CType(resources.GetObject("SB_Export.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Export.Location = New System.Drawing.Point(757, 11)
        Me.SB_Export.Name = "SB_Export"
        Me.SB_Export.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Export.Size = New System.Drawing.Size(125, 32)
        Me.SB_Export.StyleController = Me.LayoutControl1
        Me.SB_Export.TabIndex = 27
        Me.SB_Export.Text = "Export Data"
        '
        'ToggleSwitch_Detail
        '
        Me.ToggleSwitch_Detail.Location = New System.Drawing.Point(482, 11)
        Me.ToggleSwitch_Detail.MenuManager = Me.RibbonControl1
        Me.ToggleSwitch_Detail.Name = "ToggleSwitch_Detail"
        Me.ToggleSwitch_Detail.Properties.Appearance.Font = New System.Drawing.Font("Lato", 12.0!)
        Me.ToggleSwitch_Detail.Properties.Appearance.Options.UseFont = True
        Me.ToggleSwitch_Detail.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ToggleSwitch_Detail.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ToggleSwitch_Detail.Properties.OffText = "Hide Detail"
        Me.ToggleSwitch_Detail.Properties.OnText = "Show Detail"
        Me.ToggleSwitch_Detail.Size = New System.Drawing.Size(156, 24)
        Me.ToggleSwitch_Detail.StyleController = Me.LayoutControl1
        Me.ToggleSwitch_Detail.TabIndex = 26
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("a", New System.Guid("cfe14a9d-4219-46dd-9464-7c5104465a20"))})
        Me.RibbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(38, 34, 38, 34)
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem2, Me.BI_Search, Me.BE_BarcodeToogle, Me.BBI_CreateList})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.OptionsMenuMinWidth = 424
        Me.RibbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.RibbonPageCategory1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1, Me.RepositoryItemToggleSwitch1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl1.Size = New System.Drawing.Size(1439, 72)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Refresh"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BI_Search
        '
        Me.BI_Search.Caption = "Find Inventory :"
        Me.BI_Search.Edit = Me.RepositoryItemSearchControl1
        Me.BI_Search.EditWidth = 200
        Me.BI_Search.Id = 4
        Me.BI_Search.Name = "BI_Search"
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemSearchControl1.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'Sp_MDInventory_GetDataGridControl
        '
        Me.Sp_MDInventory_GetDataGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.Sp_MDInventory_GetDataGridControl.DataSource = Me.sp_MDInventory_GetDataBindingSource
        Me.Sp_MDInventory_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Sp_MDInventory_GetDataGridControl.Font = New System.Drawing.Font("Lato", 11.0!)
        Me.Sp_MDInventory_GetDataGridControl.Location = New System.Drawing.Point(2, 50)
        Me.Sp_MDInventory_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_MDInventory_GetDataGridControl.Name = "Sp_MDInventory_GetDataGridControl"
        Me.Sp_MDInventory_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_Num, Me.Repo_LUE_UoM, Me.Repo_LUE_InventoryType})
        Me.Sp_MDInventory_GetDataGridControl.Size = New System.Drawing.Size(970, 624)
        Me.Sp_MDInventory_GetDataGridControl.TabIndex = 13
        Me.Sp_MDInventory_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'sp_MDInventory_GetDataBindingSource
        '
        Me.sp_MDInventory_GetDataBindingSource.DataMember = "sp_MDInventory_GetData"
        Me.sp_MDInventory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_Detail
        '
        Me.GV_Detail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Detail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colInventoryNo, Me.colInventoryName, Me.colUoMID, Me.colMinStock, Me.colMaxStock, Me.colDescription, Me.colModifiedUser, Me.colBarcode, Me.colPrice, Me.colHPP, Me.colStokAwal, Me.colStokAkhir, Me.colKodeHarga, Me.colisActive, Me.colPriceBuy, Me.colBrandName, Me.colInventoryType})
        Me.GV_Detail.DetailHeight = 394
        Me.GV_Detail.GridControl = Me.Sp_MDInventory_GetDataGridControl
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow
        Me.GV_Detail.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_Detail.OptionsEditForm.EditFormColumnCount = 4
        Me.GV_Detail.OptionsEditForm.PopupEditFormWidth = 900
        Me.GV_Detail.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_Detail.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_Detail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Detail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Detail.OptionsView.ShowAutoFilterRow = True
        Me.GV_Detail.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 26
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colID.Width = 97
        '
        'colInventoryNo
        '
        Me.colInventoryNo.Caption = "No. Barang"
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MaxWidth = 135
        Me.colInventoryNo.MinWidth = 135
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsEditForm.StartNewRow = True
        Me.colInventoryNo.OptionsEditForm.VisibleIndex = 21
        Me.colInventoryNo.OptionsFilter.AllowFilter = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 0
        Me.colInventoryNo.Width = 135
        '
        'colInventoryName
        '
        Me.colInventoryName.Caption = "Nama"
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.MinWidth = 11
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsEditForm.Caption = "Nama :"
        Me.colInventoryName.OptionsEditForm.ColumnSpan = 2
        Me.colInventoryName.OptionsEditForm.UseEditorColRowSpan = False
        Me.colInventoryName.OptionsEditForm.VisibleIndex = 22
        Me.colInventoryName.OptionsFilter.AllowFilter = False
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 3
        Me.colInventoryName.Width = 11
        '
        'colUoMID
        '
        Me.colUoMID.Caption = "Satuan"
        Me.colUoMID.ColumnEdit = Me.Repo_LUE_UoM
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.MaxWidth = 100
        Me.colUoMID.MinWidth = 100
        Me.colUoMID.Name = "colUoMID"
        Me.colUoMID.OptionsEditForm.Caption = "Satuan :"
        Me.colUoMID.OptionsEditForm.VisibleIndex = 32
        Me.colUoMID.OptionsFilter.AllowFilter = False
        Me.colUoMID.Visible = True
        Me.colUoMID.VisibleIndex = 4
        Me.colUoMID.Width = 100
        '
        'Repo_LUE_UoM
        '
        Me.Repo_LUE_UoM.AutoHeight = False
        Me.Repo_LUE_UoM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_UoM.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 28, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMNo", "Uo MNo", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMName", "Satuan", 87, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMCode", "Uo MCode", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedDate", "Modified Date", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_UoM.DataSource = Me.SpLookUpDataGetUoMBindingSource
        Me.Repo_LUE_UoM.DisplayMember = "UoMName"
        Me.Repo_LUE_UoM.Name = "Repo_LUE_UoM"
        Me.Repo_LUE_UoM.NullText = "-- Pilih Satuan"
        Me.Repo_LUE_UoM.ValueMember = "ID"
        '
        'SpLookUpDataGetUoMBindingSource
        '
        Me.SpLookUpDataGetUoMBindingSource.DataMember = "sp_LookUpData_GetUoM"
        Me.SpLookUpDataGetUoMBindingSource.DataSource = Me.DataSet
        '
        'colMinStock
        '
        Me.colMinStock.FieldName = "MinStock"
        Me.colMinStock.MinWidth = 26
        Me.colMinStock.Name = "colMinStock"
        Me.colMinStock.Width = 97
        '
        'colMaxStock
        '
        Me.colMaxStock.FieldName = "MaxStock"
        Me.colMaxStock.MinWidth = 26
        Me.colMaxStock.Name = "colMaxStock"
        Me.colMaxStock.Width = 97
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MaxWidth = 192
        Me.colDescription.MinWidth = 192
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None
        Me.colDescription.OptionsEditForm.ColumnSpan = 4
        Me.colDescription.OptionsEditForm.StartNewRow = True
        Me.colDescription.OptionsEditForm.UseEditorColRowSpan = False
        Me.colDescription.OptionsEditForm.VisibleIndex = 51
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 7
        Me.colDescription.Width = 192
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 26
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        Me.colModifiedUser.Width = 97
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.MaxWidth = 142
        Me.colBarcode.MinWidth = 142
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.OptionsEditForm.VisibleIndex = 12
        Me.colBarcode.OptionsFilter.AllowFilter = False
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 1
        Me.colBarcode.Width = 142
        '
        'colPrice
        '
        Me.colPrice.Caption = "Harga Retail"
        Me.colPrice.ColumnEdit = Me.Repo_Num
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MaxWidth = 128
        Me.colPrice.MinWidth = 128
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsEditForm.Caption = "Retail:"
        Me.colPrice.OptionsEditForm.ColumnSpan = 2
        Me.colPrice.OptionsEditForm.StartNewRow = True
        Me.colPrice.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPrice.OptionsEditForm.VisibleIndex = 41
        Me.colPrice.OptionsFilter.AllowFilter = False
        Me.colPrice.Width = 128
        '
        'Repo_Num
        '
        Me.Repo_Num.AutoHeight = False
        Me.Repo_Num.Mask.EditMask = "n0"
        Me.Repo_Num.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Repo_Num.Mask.UseMaskAsDisplayFormat = True
        Me.Repo_Num.Name = "Repo_Num"
        '
        'colHPP
        '
        Me.colHPP.ColumnEdit = Me.Repo_Num
        Me.colHPP.FieldName = "HPP"
        Me.colHPP.MinWidth = 26
        Me.colHPP.Name = "colHPP"
        Me.colHPP.Width = 57
        '
        'colStokAwal
        '
        Me.colStokAwal.ColumnEdit = Me.Repo_Num
        Me.colStokAwal.FieldName = "StokAwal"
        Me.colStokAwal.MinWidth = 26
        Me.colStokAwal.Name = "colStokAwal"
        Me.colStokAwal.Width = 57
        '
        'colStokAkhir
        '
        Me.colStokAkhir.Caption = "Stok"
        Me.colStokAkhir.DisplayFormat.FormatString = "n0"
        Me.colStokAkhir.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStokAkhir.FieldName = "StokAkhir"
        Me.colStokAkhir.MaxWidth = 56
        Me.colStokAkhir.MinWidth = 56
        Me.colStokAkhir.Name = "colStokAkhir"
        Me.colStokAkhir.OptionsColumn.AllowEdit = False
        Me.colStokAkhir.OptionsColumn.AllowFocus = False
        Me.colStokAkhir.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colStokAkhir.OptionsFilter.AllowFilter = False
        Me.colStokAkhir.Visible = True
        Me.colStokAkhir.VisibleIndex = 2
        Me.colStokAkhir.Width = 56
        '
        'colKodeHarga
        '
        Me.colKodeHarga.Caption = "Kode"
        Me.colKodeHarga.FieldName = "KodeHarga"
        Me.colKodeHarga.MaxWidth = 64
        Me.colKodeHarga.MinWidth = 64
        Me.colKodeHarga.Name = "colKodeHarga"
        Me.colKodeHarga.OptionsEditForm.VisibleIndex = 13
        Me.colKodeHarga.OptionsFilter.AllowFilter = False
        Me.colKodeHarga.Width = 64
        '
        'colisActive
        '
        Me.colisActive.Caption = " "
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.MaxWidth = 26
        Me.colisActive.MinWidth = 26
        Me.colisActive.Name = "colisActive"
        Me.colisActive.OptionsEditForm.Caption = "Barang Aktif"
        Me.colisActive.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Near
        Me.colisActive.OptionsEditForm.VisibleIndex = 14
        Me.colisActive.OptionsFilter.AllowFilter = False
        Me.colisActive.Visible = True
        Me.colisActive.VisibleIndex = 9
        Me.colisActive.Width = 26
        '
        'colPriceBuy
        '
        Me.colPriceBuy.Caption = "Harga Akhir"
        Me.colPriceBuy.ColumnEdit = Me.Repo_Num
        Me.colPriceBuy.FieldName = "LastPrice"
        Me.colPriceBuy.MaxWidth = 102
        Me.colPriceBuy.MinWidth = 102
        Me.colPriceBuy.Name = "colPriceBuy"
        Me.colPriceBuy.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colPriceBuy.OptionsEditForm.VisibleIndex = 31
        Me.colPriceBuy.OptionsFilter.AllowFilter = False
        Me.colPriceBuy.Visible = True
        Me.colPriceBuy.VisibleIndex = 8
        Me.colPriceBuy.Width = 102
        '
        'colBrandName
        '
        Me.colBrandName.Caption = "Merk"
        Me.colBrandName.FieldName = "BrandName"
        Me.colBrandName.MaxWidth = 150
        Me.colBrandName.MinWidth = 150
        Me.colBrandName.Name = "colBrandName"
        Me.colBrandName.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colBrandName.OptionsEditForm.VisibleIndex = 33
        Me.colBrandName.OptionsFilter.AllowFilter = False
        Me.colBrandName.Visible = True
        Me.colBrandName.VisibleIndex = 6
        Me.colBrandName.Width = 150
        '
        'colInventoryType
        '
        Me.colInventoryType.Caption = "Tipe Barang"
        Me.colInventoryType.ColumnEdit = Me.Repo_LUE_InventoryType
        Me.colInventoryType.FieldName = "InventoryType"
        Me.colInventoryType.MaxWidth = 120
        Me.colInventoryType.MinWidth = 120
        Me.colInventoryType.Name = "colInventoryType"
        Me.colInventoryType.OptionsEditForm.StartNewRow = True
        Me.colInventoryType.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colInventoryType.OptionsEditForm.VisibleIndex = 31
        Me.colInventoryType.Visible = True
        Me.colInventoryType.VisibleIndex = 5
        Me.colInventoryType.Width = 120
        '
        'Repo_LUE_InventoryType
        '
        Me.Repo_LUE_InventoryType.AutoHeight = False
        Me.Repo_LUE_InventoryType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_InventoryType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryType", "Inventory Type", 113, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryTypeName", "Tipe Barang", 155, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_InventoryType.DataSource = Me.SpLookUpDataGetInventoryTypeBindingSource
        Me.Repo_LUE_InventoryType.DisplayMember = "InventoryTypeName"
        Me.Repo_LUE_InventoryType.Name = "Repo_LUE_InventoryType"
        Me.Repo_LUE_InventoryType.NullText = "-- Pilih Tipe Barang"
        Me.Repo_LUE_InventoryType.ValueMember = "InventoryType"
        '
        'SpLookUpDataGetInventoryTypeBindingSource
        '
        Me.SpLookUpDataGetInventoryTypeBindingSource.DataMember = "sp_LookUpData_GetInventoryType"
        Me.SpLookUpDataGetInventoryTypeBindingSource.DataSource = Me.DataSet
        '
        'BE_BarcodeToogle
        '
        Me.BE_BarcodeToogle.Caption = "Toogle Barcode"
        Me.BE_BarcodeToogle.Edit = Me.RepositoryItemToggleSwitch1
        Me.BE_BarcodeToogle.Id = 5
        Me.BE_BarcodeToogle.Name = "BE_BarcodeToogle"
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Hide Detail"
        Me.RepositoryItemToggleSwitch1.OnText = "Show Detail"
        '
        'BBI_CreateList
        '
        Me.BBI_CreateList.Caption = "Create List"
        Me.BBI_CreateList.Id = 6
        Me.BBI_CreateList.Name = "BBI_CreateList"
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Text = "RibbonPageCategory1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 765)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1439, 33)
        '
        'SearchControl1
        '
        Me.SearchControl1.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.DxErrorProvider.SetIconAlignment(Me.SearchControl1, System.Windows.Forms.ErrorIconAlignment.MiddleRight)
        Me.SearchControl1.Location = New System.Drawing.Point(129, 11)
        Me.SearchControl1.MenuManager = Me.RibbonControl1
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Properties.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.SearchControl1.Properties.NullValuePrompt = "-- Ketik di sini untuk filter pencarian"
        Me.SearchControl1.Size = New System.Drawing.Size(349, 26)
        Me.SearchControl1.StyleController = Me.LayoutControl1
        Me.SearchControl1.TabIndex = 25
        '
        'SB_Refresh
        '
        Me.SB_Refresh.AllowFocus = False
        Me.SB_Refresh.ImageOptions.SvgImage = CType(resources.GetObject("SB_Refresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Refresh.Location = New System.Drawing.Point(652, 11)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Refresh.Size = New System.Drawing.Size(101, 32)
        Me.SB_Refresh.StyleController = Me.LayoutControl1
        Me.SB_Refresh.TabIndex = 24
        Me.SB_Refresh.Text = "Refresh"
        '
        'SB_DeleteAll
        '
        Me.SB_DeleteAll.Location = New System.Drawing.Point(1018, 535)
        Me.SB_DeleteAll.Name = "SB_DeleteAll"
        Me.SB_DeleteAll.Size = New System.Drawing.Size(430, 23)
        Me.SB_DeleteAll.StyleController = Me.LayoutControl1
        Me.SB_DeleteAll.TabIndex = 23
        Me.SB_DeleteAll.Text = "Hapus Data List Barcode"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SpMDInventoryGetTransactionDataBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(1006, 640)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(302, 357)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SpMDInventoryGetTransactionDataBindingSource
        '
        Me.SpMDInventoryGetTransactionDataBindingSource.DataMember = "sp_MDInventory_GetTransactionData"
        Me.SpMDInventoryGetTransactionDataBindingSource.DataSource = Me.DataSet
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInventoryNo1, Me.colInventoryName1, Me.colSalesPOSNo, Me.colSalesPOSDate, Me.colOpname, Me.colTransaksi})
        Me.GridView1.DetailHeight = 394
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 900
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colInventoryNo1
        '
        Me.colInventoryNo1.FieldName = "InventoryNo"
        Me.colInventoryNo1.MinWidth = 26
        Me.colInventoryNo1.Name = "colInventoryNo1"
        Me.colInventoryNo1.OptionsColumn.AllowEdit = False
        Me.colInventoryNo1.OptionsColumn.AllowFocus = False
        Me.colInventoryNo1.Visible = True
        Me.colInventoryNo1.VisibleIndex = 0
        Me.colInventoryNo1.Width = 97
        '
        'colInventoryName1
        '
        Me.colInventoryName1.FieldName = "InventoryName"
        Me.colInventoryName1.MinWidth = 26
        Me.colInventoryName1.Name = "colInventoryName1"
        Me.colInventoryName1.OptionsColumn.AllowEdit = False
        Me.colInventoryName1.OptionsColumn.AllowFocus = False
        Me.colInventoryName1.Visible = True
        Me.colInventoryName1.VisibleIndex = 1
        Me.colInventoryName1.Width = 97
        '
        'colSalesPOSNo
        '
        Me.colSalesPOSNo.FieldName = "SalesPOSNo"
        Me.colSalesPOSNo.MinWidth = 26
        Me.colSalesPOSNo.Name = "colSalesPOSNo"
        Me.colSalesPOSNo.OptionsColumn.AllowEdit = False
        Me.colSalesPOSNo.OptionsColumn.AllowFocus = False
        Me.colSalesPOSNo.Visible = True
        Me.colSalesPOSNo.VisibleIndex = 2
        Me.colSalesPOSNo.Width = 97
        '
        'colSalesPOSDate
        '
        Me.colSalesPOSDate.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colSalesPOSDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSalesPOSDate.FieldName = "SalesPOSDate"
        Me.colSalesPOSDate.MinWidth = 26
        Me.colSalesPOSDate.Name = "colSalesPOSDate"
        Me.colSalesPOSDate.OptionsColumn.AllowEdit = False
        Me.colSalesPOSDate.OptionsColumn.AllowFocus = False
        Me.colSalesPOSDate.Visible = True
        Me.colSalesPOSDate.VisibleIndex = 3
        Me.colSalesPOSDate.Width = 97
        '
        'colOpname
        '
        Me.colOpname.DisplayFormat.FormatString = "n0"
        Me.colOpname.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOpname.FieldName = "Opname"
        Me.colOpname.MinWidth = 26
        Me.colOpname.Name = "colOpname"
        Me.colOpname.OptionsColumn.AllowEdit = False
        Me.colOpname.OptionsColumn.AllowFocus = False
        Me.colOpname.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Opname", "{0:n0}")})
        Me.colOpname.Visible = True
        Me.colOpname.VisibleIndex = 4
        Me.colOpname.Width = 97
        '
        'colTransaksi
        '
        Me.colTransaksi.DisplayFormat.FormatString = "n0"
        Me.colTransaksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTransaksi.FieldName = "Transaksi"
        Me.colTransaksi.MinWidth = 26
        Me.colTransaksi.Name = "colTransaksi"
        Me.colTransaksi.OptionsColumn.AllowEdit = False
        Me.colTransaksi.OptionsColumn.AllowFocus = False
        Me.colTransaksi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Transaksi", "{0:n0}")})
        Me.colTransaksi.Visible = True
        Me.colTransaksi.VisibleIndex = 5
        Me.colTransaksi.Width = 97
        '
        'Sp_MDInventory_GetHPPHistoryGridControl
        '
        Me.Sp_MDInventory_GetHPPHistoryGridControl.DataSource = Me.Sp_MDInventory_GetHPPHistoryBindingSource
        Me.Sp_MDInventory_GetHPPHistoryGridControl.Location = New System.Drawing.Point(1006, 623)
        Me.Sp_MDInventory_GetHPPHistoryGridControl.MainView = Me.GV_HPP
        Me.Sp_MDInventory_GetHPPHistoryGridControl.MenuManager = Me.RibbonControl1
        Me.Sp_MDInventory_GetHPPHistoryGridControl.Name = "Sp_MDInventory_GetHPPHistoryGridControl"
        Me.Sp_MDInventory_GetHPPHistoryGridControl.Size = New System.Drawing.Size(390, 259)
        Me.Sp_MDInventory_GetHPPHistoryGridControl.TabIndex = 22
        Me.Sp_MDInventory_GetHPPHistoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_HPP})
        '
        'Sp_MDInventory_GetHPPHistoryBindingSource
        '
        Me.Sp_MDInventory_GetHPPHistoryBindingSource.DataMember = "sp_MDInventory_GetHPPHistory"
        Me.Sp_MDInventory_GetHPPHistoryBindingSource.DataSource = Me.DataSet
        '
        'GV_HPP
        '
        Me.GV_HPP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_HPP, Me.colMRNo_HPP, Me.colMRDate_HPP, Me.colSupplierName_HPP, Me.colHPP_HPP})
        Me.GV_HPP.DetailHeight = 394
        Me.GV_HPP.GridControl = Me.Sp_MDInventory_GetHPPHistoryGridControl
        Me.GV_HPP.Name = "GV_HPP"
        Me.GV_HPP.OptionsEditForm.PopupEditFormWidth = 900
        Me.GV_HPP.OptionsView.ShowGroupPanel = False
        '
        'colID_HPP
        '
        Me.colID_HPP.FieldName = "ID"
        Me.colID_HPP.MinWidth = 26
        Me.colID_HPP.Name = "colID_HPP"
        Me.colID_HPP.OptionsColumn.AllowEdit = False
        Me.colID_HPP.OptionsColumn.AllowFocus = False
        Me.colID_HPP.Width = 97
        '
        'colMRNo_HPP
        '
        Me.colMRNo_HPP.FieldName = "MRNo"
        Me.colMRNo_HPP.MinWidth = 26
        Me.colMRNo_HPP.Name = "colMRNo_HPP"
        Me.colMRNo_HPP.OptionsColumn.AllowEdit = False
        Me.colMRNo_HPP.OptionsColumn.AllowFocus = False
        Me.colMRNo_HPP.Visible = True
        Me.colMRNo_HPP.VisibleIndex = 3
        Me.colMRNo_HPP.Width = 97
        '
        'colMRDate_HPP
        '
        Me.colMRDate_HPP.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colMRDate_HPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMRDate_HPP.FieldName = "MRDate"
        Me.colMRDate_HPP.MinWidth = 26
        Me.colMRDate_HPP.Name = "colMRDate_HPP"
        Me.colMRDate_HPP.OptionsColumn.AllowEdit = False
        Me.colMRDate_HPP.OptionsColumn.AllowFocus = False
        Me.colMRDate_HPP.Visible = True
        Me.colMRDate_HPP.VisibleIndex = 2
        Me.colMRDate_HPP.Width = 97
        '
        'colSupplierName_HPP
        '
        Me.colSupplierName_HPP.FieldName = "SupplierName"
        Me.colSupplierName_HPP.MinWidth = 26
        Me.colSupplierName_HPP.Name = "colSupplierName_HPP"
        Me.colSupplierName_HPP.OptionsColumn.AllowEdit = False
        Me.colSupplierName_HPP.OptionsColumn.AllowFocus = False
        Me.colSupplierName_HPP.Visible = True
        Me.colSupplierName_HPP.VisibleIndex = 1
        Me.colSupplierName_HPP.Width = 97
        '
        'colHPP_HPP
        '
        Me.colHPP_HPP.DisplayFormat.FormatString = "n0"
        Me.colHPP_HPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHPP_HPP.FieldName = "HPP"
        Me.colHPP_HPP.MinWidth = 26
        Me.colHPP_HPP.Name = "colHPP_HPP"
        Me.colHPP_HPP.OptionsColumn.AllowEdit = False
        Me.colHPP_HPP.OptionsColumn.AllowFocus = False
        Me.colHPP_HPP.Visible = True
        Me.colHPP_HPP.VisibleIndex = 0
        Me.colHPP_HPP.Width = 97
        '
        'SB_BarcodePrice
        '
        Me.SB_BarcodePrice.ImageOptions.SvgImage = CType(resources.GetObject("SB_BarcodePrice.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_BarcodePrice.Location = New System.Drawing.Point(1231, 562)
        Me.SB_BarcodePrice.Name = "SB_BarcodePrice"
        Me.SB_BarcodePrice.Size = New System.Drawing.Size(217, 36)
        Me.SB_BarcodePrice.StyleController = Me.LayoutControl1
        Me.SB_BarcodePrice.TabIndex = 20
        Me.SB_BarcodePrice.Text = "&Barcode Print With Price"
        '
        'Sp_MDInventory_PrintBarcodeListGridControl
        '
        Me.Sp_MDInventory_PrintBarcodeListGridControl.DataSource = Me.Sp_MDInventory_PrintBarcodeListBindingSource
        Me.Sp_MDInventory_PrintBarcodeListGridControl.Location = New System.Drawing.Point(1018, 54)
        Me.Sp_MDInventory_PrintBarcodeListGridControl.MainView = Me.GV_Barcode
        Me.Sp_MDInventory_PrintBarcodeListGridControl.MenuManager = Me.RibbonControl1
        Me.Sp_MDInventory_PrintBarcodeListGridControl.Name = "Sp_MDInventory_PrintBarcodeListGridControl"
        Me.Sp_MDInventory_PrintBarcodeListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoNum_Barcode})
        Me.Sp_MDInventory_PrintBarcodeListGridControl.Size = New System.Drawing.Size(430, 477)
        Me.Sp_MDInventory_PrintBarcodeListGridControl.TabIndex = 18
        Me.Sp_MDInventory_PrintBarcodeListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Barcode})
        '
        'Sp_MDInventory_PrintBarcodeListBindingSource
        '
        Me.Sp_MDInventory_PrintBarcodeListBindingSource.DataMember = "sp_MDInventory_PrintBarcodeList"
        Me.Sp_MDInventory_PrintBarcodeListBindingSource.DataSource = Me.DataSet
        '
        'GV_Barcode
        '
        Me.GV_Barcode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBarcode_List, Me.colInventoryNo_List, Me.colQty_List, Me.colPrice_List, Me.colInventoryID_List})
        Me.GV_Barcode.DetailHeight = 394
        Me.GV_Barcode.GridControl = Me.Sp_MDInventory_PrintBarcodeListGridControl
        Me.GV_Barcode.Name = "GV_Barcode"
        Me.GV_Barcode.OptionsEditForm.PopupEditFormWidth = 900
        Me.GV_Barcode.OptionsView.ShowGroupPanel = False
        Me.GV_Barcode.OptionsView.ShowIndicator = False
        '
        'colBarcode_List
        '
        Me.colBarcode_List.FieldName = "Barcode"
        Me.colBarcode_List.MinWidth = 26
        Me.colBarcode_List.Name = "colBarcode_List"
        Me.colBarcode_List.OptionsColumn.AllowEdit = False
        Me.colBarcode_List.OptionsColumn.AllowFocus = False
        Me.colBarcode_List.Visible = True
        Me.colBarcode_List.VisibleIndex = 0
        Me.colBarcode_List.Width = 114
        '
        'colInventoryNo_List
        '
        Me.colInventoryNo_List.FieldName = "InventoryNo"
        Me.colInventoryNo_List.MinWidth = 26
        Me.colInventoryNo_List.Name = "colInventoryNo_List"
        Me.colInventoryNo_List.OptionsColumn.AllowEdit = False
        Me.colInventoryNo_List.OptionsColumn.AllowFocus = False
        Me.colInventoryNo_List.OptionsFilter.AllowFilter = False
        Me.colInventoryNo_List.Visible = True
        Me.colInventoryNo_List.VisibleIndex = 1
        Me.colInventoryNo_List.Width = 199
        '
        'colQty_List
        '
        Me.colQty_List.ColumnEdit = Me.RepoNum_Barcode
        Me.colQty_List.FieldName = "Qty"
        Me.colQty_List.MinWidth = 26
        Me.colQty_List.Name = "colQty_List"
        Me.colQty_List.OptionsFilter.AllowFilter = False
        Me.colQty_List.Visible = True
        Me.colQty_List.VisibleIndex = 2
        Me.colQty_List.Width = 71
        '
        'RepoNum_Barcode
        '
        Me.RepoNum_Barcode.AutoHeight = False
        Me.RepoNum_Barcode.Mask.EditMask = "n0"
        Me.RepoNum_Barcode.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepoNum_Barcode.Mask.UseMaskAsDisplayFormat = True
        Me.RepoNum_Barcode.Name = "RepoNum_Barcode"
        '
        'colPrice_List
        '
        Me.colPrice_List.ColumnEdit = Me.RepoNum_Barcode
        Me.colPrice_List.FieldName = "Price"
        Me.colPrice_List.MinWidth = 26
        Me.colPrice_List.Name = "colPrice_List"
        Me.colPrice_List.OptionsColumn.AllowEdit = False
        Me.colPrice_List.OptionsColumn.AllowFocus = False
        Me.colPrice_List.OptionsFilter.AllowFilter = False
        Me.colPrice_List.Width = 163
        '
        'colInventoryID_List
        '
        Me.colInventoryID_List.FieldName = "InventoryID"
        Me.colInventoryID_List.MinWidth = 26
        Me.colInventoryID_List.Name = "colInventoryID_List"
        Me.colInventoryID_List.OptionsFilter.AllowFilter = False
        Me.colInventoryID_List.Width = 97
        '
        'SB_BarcodePrint
        '
        Me.SB_BarcodePrint.ImageOptions.SvgImage = CType(resources.GetObject("SB_BarcodePrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_BarcodePrint.Location = New System.Drawing.Point(1018, 562)
        Me.SB_BarcodePrint.Name = "SB_BarcodePrint"
        Me.SB_BarcodePrint.Size = New System.Drawing.Size(209, 36)
        Me.SB_BarcodePrint.StyleController = Me.LayoutControl1
        Me.SB_BarcodePrint.TabIndex = 14
        Me.SB_BarcodePrint.Text = "&Barcode Print w/o Price"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCGroup_Barcode, Me.LayoutControlItem12, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 9, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1474, 676)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LCGroup_Barcode
        '
        Me.LCGroup_Barcode.AppearanceGroup.Options.UseTextOptions = True
        Me.LCGroup_Barcode.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LCGroup_Barcode.ExpandButtonVisible = True
        Me.LCGroup_Barcode.ExpandOnDoubleClick = True
        Me.LCGroup_Barcode.GroupStyle = DevExpress.Utils.GroupStyle.Light
        Me.LCGroup_Barcode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup8, Me.LayoutControlGroup6, Me.LayoutControlGroup7})
        Me.LCGroup_Barcode.Location = New System.Drawing.Point(974, 0)
        Me.LCGroup_Barcode.Name = "LCGroup_Barcode"
        Me.LCGroup_Barcode.Size = New System.Drawing.Size(500, 667)
        Me.LCGroup_Barcode.Text = "Show Detail"
        Me.LCGroup_Barcode.TextLocation = DevExpress.Utils.Locations.Left
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup8.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup8.ExpandButtonVisible = True
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem5})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(458, 592)
        Me.LayoutControlGroup8.Text = ".: Barcode Print List :."
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Sp_MDInventory_PrintBarcodeListGridControl
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(434, 481)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SB_DeleteAll
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 481)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(434, 27)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SB_BarcodePrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 508)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(213, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SB_BarcodePrice
        Me.LayoutControlItem5.Location = New System.Drawing.Point(213, 508)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(221, 40)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup6.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup6.ExpandButtonVisible = True
        Me.LayoutControlGroup6.Expanded = False
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 592)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(458, 26)
        Me.LayoutControlGroup6.Text = ".: HPP :."
        Me.LayoutControlGroup6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Sp_MDInventory_GetHPPHistoryGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 11, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(394, 272)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup7.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup7.ExpandButtonVisible = True
        Me.LayoutControlGroup7.Expanded = False
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 618)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(458, 26)
        Me.LayoutControlGroup7.Text = ".: Histori Transaksi :."
        Me.LayoutControlGroup7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(306, 361)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Sp_MDInventory_GetDataGridControl
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 39)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(974, 628)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_Refresh
        Me.LayoutControlItem7.Location = New System.Drawing.Point(650, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(105, 36)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(105, 36)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(105, 39)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(640, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 39)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SearchControl1
        Me.LayoutControlItem8.ImageOptions.SvgImage = CType(resources.GetObject("LayoutControlItem8.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(480, 39)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(480, 39)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(480, 39)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Cari Barang :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(115, 24)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.ToggleSwitch_Detail
        Me.LayoutControlItem9.Location = New System.Drawing.Point(480, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(160, 39)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SB_Export
        Me.LayoutControlItem10.Location = New System.Drawing.Point(755, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(129, 36)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(129, 36)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(129, 39)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SB_Close
        Me.LayoutControlItem11.Location = New System.Drawing.Point(884, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(90, 36)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(90, 36)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(90, 39)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'Sp_MDUoMGetDataBindingSource
        '
        Me.Sp_MDUoMGetDataBindingSource.DataMember = "sp_MDUoMGetData"
        Me.Sp_MDUoMGetDataBindingSource.DataSource = Me.DataSet
        '
        'Sp_MDInvBrand_GetDataBindingSource
        '
        Me.Sp_MDInvBrand_GetDataBindingSource.DataMember = "sp_MDInvBrand_GetData"
        Me.Sp_MDInvBrand_GetDataBindingSource.DataSource = Me.DataSet
        '
        'Sp_MDInvCategory_GetDataBindingSource
        '
        Me.Sp_MDInvCategory_GetDataBindingSource.DataMember = "sp_MDInvCategory_GetData"
        Me.Sp_MDInvCategory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'Sp_MDInvProduct_GetDataBindingSource
        '
        Me.Sp_MDInvProduct_GetDataBindingSource.DataMember = "sp_MDInvProduct_GetData"
        Me.Sp_MDInvProduct_GetDataBindingSource.DataSource = Me.DataSet
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 72)
        Me.NavigationFrame1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.Size = New System.Drawing.Size(1439, 693)
        Me.NavigationFrame1.TabIndex = 12
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1439, 693)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1439, 693)
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(40, 40)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "Normal.png")
        Me.ImageCollection.Images.SetKeyName(1, "Hot.png")
        Me.ImageCollection.Images.SetKeyName(2, "Pressed.png")
        '
        'sp_MDInventory_GetDataTableAdapter
        '
        Me.sp_MDInventory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDCustomer_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Me.sp_MDInventory_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Me.Sp_MDInventory_PrintBarcodeListTableAdapter
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDSupplier_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_MDInventory_PrintBarcodeListTableAdapter
        '
        Me.Sp_MDInventory_PrintBarcodeListTableAdapter.ClearBeforeFill = True
        '
        'DxErrorProvider
        '
        Me.DxErrorProvider.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(379, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(362, 76)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sp_MDInvBrand_GetDataTableAdapter
        '
        Me.Sp_MDInvBrand_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvCategory_GetDataTableAdapter
        '
        Me.Sp_MDInvCategory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvProduct_GetDataTableAdapter
        '
        Me.Sp_MDInvProduct_GetDataTableAdapter.ClearBeforeFill = True
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Sp_MDUoMGetDataTableAdapter
        '
        Me.Sp_MDUoMGetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetTransactionDataTableAdapter
        '
        Me.Sp_MDInventory_GetTransactionDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetHPPHistoryTableAdapter
        '
        Me.Sp_MDInventory_GetHPPHistoryTableAdapter.ClearBeforeFill = True
        '
        'ToastNotificationsManager1
        '
        Me.ToastNotificationsManager1.ApplicationId = "975a85d0-8bf8-43ac-baa0-e64007f78ab0"
        '
        'Sp_LookUpData_GetUoMTableAdapter
        '
        Me.Sp_LookUpData_GetUoMTableAdapter.ClearBeforeFill = True
        '
        'Sp_LookUpData_GetInventoryTypeTableAdapter
        '
        Me.Sp_LookUpData_GetInventoryTypeTableAdapter.ClearBeforeFill = True
        '
        'Frm_InvList
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Name = "Frm_InvList"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Master Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ToggleSwitch_Detail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetUoMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_InventoryType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetInventoryTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetTransactionDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetHPPHistoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetHPPHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_HPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoNum_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToastNotificationsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As DataSet
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents sp_MDInventory_GetDataBindingSource As BindingSource
    Friend WithEvents sp_MDInventory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_MDInventory_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoMID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Sp_MDInvProduct_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInvCategory_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInvBrand_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInvBrand_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter
    Friend WithEvents Sp_MDInvCategory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter
    Friend WithEvents Sp_MDInvProduct_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvProduct_GetDataTableAdapter
    Friend WithEvents SB_BarcodePrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents colBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_Num As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Sp_MDInventory_PrintBarcodeListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Barcode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepoNum_Barcode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents colBarcode_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryNo_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_PrintBarcodeListBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_PrintBarcodeListTableAdapter As DataSetTableAdapters.sp_MDInventory_PrintBarcodeListTableAdapter
    Friend WithEvents Repo_LUE_UoM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Sp_MDUoMGetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDUoMGetDataTableAdapter As DataSetTableAdapters.sp_MDUoMGetDataTableAdapter
    Friend WithEvents colHPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokAwal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SB_BarcodePrice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colStokAkhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SpMDInventoryGetTransactionDataBindingSource As BindingSource
    Friend WithEvents colInventoryNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPOSNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPOSDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetTransactionDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetTransactionDataTableAdapter
    Friend WithEvents colOpname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetHPPHistoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_HPP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Sp_MDInventory_GetHPPHistoryBindingSource As BindingSource
    Friend WithEvents colID_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRNo_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRDate_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPP_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetHPPHistoryTableAdapter As DataSetTableAdapters.sp_MDInventory_GetHPPHistoryTableAdapter
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colPriceBuy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BI_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents BE_BarcodeToogle As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents BBI_CreateList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SB_DeleteAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCGroup_Barcode As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToastNotificationsManager1 As DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToggleSwitch_Detail As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpLookUpDataGetUoMBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetUoMTableAdapter As DataSetTableAdapters.sp_LookUpData_GetUoMTableAdapter
    Friend WithEvents Repo_LUE_InventoryType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpLookUpDataGetInventoryTypeBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetInventoryTypeTableAdapter As DataSetTableAdapters.sp_LookUpData_GetInventoryTypeTableAdapter
    Friend WithEvents colInventoryType As DevExpress.XtraGrid.Columns.GridColumn
End Class
