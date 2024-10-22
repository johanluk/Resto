<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MasterData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MasterData))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit_InvType = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpLookUpDataGetInventoryTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset = New Mod_Purchase.Dataset()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.Sp_MDInventory_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDInventory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Inventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUoMID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_UoM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpLookUpDataGetUoMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colMinStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokAwal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_InvType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_MDInventory_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.TableAdapterManager = New Mod_Purchase.DatasetTableAdapters.TableAdapterManager()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.Label_InventoryName = New DevExpress.XtraEditors.LabelControl()
        Me.SB_AddOpname = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_QtyOpname = New DevExpress.XtraEditors.SpinEdit()
        Me.SB_ResetOpname = New DevExpress.XtraEditors.SimpleButton()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.QueriesTableAdapter = New Mod_Purchase.DatasetTableAdapters.QueriesTableAdapter()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Sp_LookUpData_GetInventoryTypeTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetInventoryTypeTableAdapter()
        Me.Sp_LookUpData_GetUoMTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetUoMTableAdapter()
        Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LookUpEdit_InvType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetInventoryTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetUoMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_InvType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.Ed_QtyOpname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(45, 42, 45, 42)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.OptionsMenuMinWidth = 495
        Me.RibbonControl.Size = New System.Drawing.Size(1283, 72)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 536)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1283, 33)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit_InvType)
        Me.LayoutControl1.Controls.Add(Me.SearchControl1)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_GetDataGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1283, 464)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SB_Refresh
        '
        Me.SB_Refresh.Location = New System.Drawing.Point(1162, 12)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Refresh.Size = New System.Drawing.Size(109, 23)
        Me.SB_Refresh.StyleController = Me.LayoutControl1
        Me.SB_Refresh.TabIndex = 7
        Me.SB_Refresh.Text = "Refresh"
        '
        'LookUpEdit_InvType
        '
        Me.LookUpEdit_InvType.Location = New System.Drawing.Point(941, 12)
        Me.LookUpEdit_InvType.MenuManager = Me.RibbonControl
        Me.LookUpEdit_InvType.Name = "LookUpEdit_InvType"
        Me.LookUpEdit_InvType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_InvType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryType", "Inventory Type", 115, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryTypeName", "Tipe Barang", 159, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit_InvType.Properties.DataSource = Me.SpLookUpDataGetInventoryTypeBindingSource
        Me.LookUpEdit_InvType.Properties.DisplayMember = "InventoryTypeName"
        Me.LookUpEdit_InvType.Properties.NullText = "-- Pilih Tipe Barang"
        Me.LookUpEdit_InvType.Properties.ValueMember = "InventoryType"
        Me.LookUpEdit_InvType.Size = New System.Drawing.Size(217, 26)
        Me.LookUpEdit_InvType.StyleController = Me.LayoutControl1
        Me.LookUpEdit_InvType.TabIndex = 6
        '
        'SpLookUpDataGetInventoryTypeBindingSource
        '
        Me.SpLookUpDataGetInventoryTypeBindingSource.DataMember = "sp_LookUpData_GetInventoryType"
        Me.SpLookUpDataGetInventoryTypeBindingSource.DataSource = Me.Dataset
        '
        'Dataset
        '
        Me.Dataset.DataSetName = "Dataset"
        Me.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(115, 12)
        Me.SearchControl1.MenuManager = Me.RibbonControl
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Size = New System.Drawing.Size(719, 26)
        Me.SearchControl1.StyleController = Me.LayoutControl1
        Me.SearchControl1.TabIndex = 5
        '
        'Sp_MDInventory_GetDataGridControl
        '
        Me.Sp_MDInventory_GetDataGridControl.DataSource = Me.Sp_MDInventory_GetDataBindingSource
        Me.Sp_MDInventory_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Sp_MDInventory_GetDataGridControl.Location = New System.Drawing.Point(12, 42)
        Me.Sp_MDInventory_GetDataGridControl.MainView = Me.GV_Inventory
        Me.Sp_MDInventory_GetDataGridControl.Margin = New System.Windows.Forms.Padding(4)
        Me.Sp_MDInventory_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_MDInventory_GetDataGridControl.Name = "Sp_MDInventory_GetDataGridControl"
        Me.Sp_MDInventory_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_LUE_UoM, Me.Repo_LUE_InvType})
        Me.Sp_MDInventory_GetDataGridControl.Size = New System.Drawing.Size(1259, 410)
        Me.Sp_MDInventory_GetDataGridControl.TabIndex = 4
        Me.Sp_MDInventory_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Inventory})
        '
        'Sp_MDInventory_GetDataBindingSource
        '
        Me.Sp_MDInventory_GetDataBindingSource.DataMember = "sp_MDInventory_GetData"
        Me.Sp_MDInventory_GetDataBindingSource.DataSource = Me.Dataset
        '
        'GV_Inventory
        '
        Me.GV_Inventory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBarcode, Me.colInventoryNo, Me.colInventoryName, Me.colBrandName, Me.colUoMID, Me.colMinStock, Me.colMaxStock, Me.colDescription, Me.colKodeHarga, Me.colHPP, Me.colLastPrice, Me.colStokAwal, Me.colStokAkhir, Me.colPrice, Me.colisActive, Me.colModifiedUser, Me.colModifiedDate, Me.colInventoryType, Me.colImage})
        Me.GV_Inventory.DetailHeight = 485
        Me.GV_Inventory.GridControl = Me.Sp_MDInventory_GetDataGridControl
        Me.GV_Inventory.GroupCount = 1
        Me.GV_Inventory.Name = "GV_Inventory"
        Me.GV_Inventory.OptionsBehavior.AutoExpandAllGroups = True
        Me.GV_Inventory.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GV_Inventory.OptionsEditForm.EditFormColumnCount = 4
        Me.GV_Inventory.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GV_Inventory.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Inventory.OptionsView.ShowIndicator = False
        Me.GV_Inventory.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colInventoryType, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.Caption = "Tipe Barang"
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 30
        Me.colID.Name = "colID"
        Me.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colID.OptionsEditForm.VisibleIndex = 23
        Me.colID.Width = 112
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.MinWidth = 30
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.OptionsEditForm.Caption = "Barcode :"
        Me.colBarcode.OptionsEditForm.VisibleIndex = 12
        Me.colBarcode.OptionsFilter.AllowFilter = False
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 1
        Me.colBarcode.Width = 140
        '
        'colInventoryNo
        '
        Me.colInventoryNo.Caption = "No. Barang"
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MinWidth = 30
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsEditForm.Caption = "No. Barang :"
        Me.colInventoryNo.OptionsEditForm.VisibleIndex = 11
        Me.colInventoryNo.OptionsFilter.AllowFilter = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 0
        Me.colInventoryNo.Width = 148
        '
        'colInventoryName
        '
        Me.colInventoryName.Caption = "Nama Barang"
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.MinWidth = 30
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsEditForm.ColumnSpan = 3
        Me.colInventoryName.OptionsEditForm.StartNewRow = True
        Me.colInventoryName.OptionsEditForm.UseEditorColRowSpan = False
        Me.colInventoryName.OptionsEditForm.VisibleIndex = 31
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 2
        Me.colInventoryName.Width = 112
        '
        'colBrandName
        '
        Me.colBrandName.Caption = "Merk"
        Me.colBrandName.FieldName = "BrandName"
        Me.colBrandName.MinWidth = 30
        Me.colBrandName.Name = "colBrandName"
        Me.colBrandName.Width = 112
        '
        'colUoMID
        '
        Me.colUoMID.Caption = "Satuan"
        Me.colUoMID.ColumnEdit = Me.Repo_LUE_UoM
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.MaxWidth = 100
        Me.colUoMID.MinWidth = 100
        Me.colUoMID.Name = "colUoMID"
        Me.colUoMID.OptionsEditForm.VisibleIndex = 22
        Me.colUoMID.OptionsFilter.AllowFilter = False
        Me.colUoMID.Visible = True
        Me.colUoMID.VisibleIndex = 3
        Me.colUoMID.Width = 100
        '
        'Repo_LUE_UoM
        '
        Me.Repo_LUE_UoM.AutoHeight = False
        Me.Repo_LUE_UoM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_UoM.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 26, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMName", "Satuan", 88, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_UoM.DataSource = Me.SpLookUpDataGetUoMBindingSource
        Me.Repo_LUE_UoM.DisplayMember = "UoMName"
        Me.Repo_LUE_UoM.Name = "Repo_LUE_UoM"
        Me.Repo_LUE_UoM.NullText = "-- Pilih Satuan"
        Me.Repo_LUE_UoM.ValueMember = "ID"
        '
        'SpLookUpDataGetUoMBindingSource
        '
        Me.SpLookUpDataGetUoMBindingSource.DataMember = "sp_LookUpData_GetUoM"
        Me.SpLookUpDataGetUoMBindingSource.DataSource = Me.Dataset
        '
        'colMinStock
        '
        Me.colMinStock.FieldName = "MinStock"
        Me.colMinStock.MinWidth = 30
        Me.colMinStock.Name = "colMinStock"
        Me.colMinStock.Width = 112
        '
        'colMaxStock
        '
        Me.colMaxStock.FieldName = "MaxStock"
        Me.colMaxStock.MinWidth = 30
        Me.colMaxStock.Name = "colMaxStock"
        Me.colMaxStock.Width = 112
        '
        'colDescription
        '
        Me.colDescription.Caption = "Keterangan"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 30
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsEditForm.Caption = "Keterangan :"
        Me.colDescription.OptionsEditForm.ColumnSpan = 3
        Me.colDescription.OptionsEditForm.StartNewRow = True
        Me.colDescription.OptionsEditForm.UseEditorColRowSpan = False
        Me.colDescription.OptionsEditForm.VisibleIndex = 31
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 4
        Me.colDescription.Width = 192
        '
        'colKodeHarga
        '
        Me.colKodeHarga.FieldName = "KodeHarga"
        Me.colKodeHarga.MinWidth = 30
        Me.colKodeHarga.Name = "colKodeHarga"
        Me.colKodeHarga.Width = 112
        '
        'colHPP
        '
        Me.colHPP.FieldName = "HPP"
        Me.colHPP.MinWidth = 30
        Me.colHPP.Name = "colHPP"
        Me.colHPP.Width = 112
        '
        'colLastPrice
        '
        Me.colLastPrice.FieldName = "LastPrice"
        Me.colLastPrice.MinWidth = 30
        Me.colLastPrice.Name = "colLastPrice"
        Me.colLastPrice.Width = 112
        '
        'colStokAwal
        '
        Me.colStokAwal.FieldName = "StokAwal"
        Me.colStokAwal.MinWidth = 30
        Me.colStokAwal.Name = "colStokAwal"
        Me.colStokAwal.Width = 112
        '
        'colStokAkhir
        '
        Me.colStokAkhir.FieldName = "StokAkhir"
        Me.colStokAkhir.MaxWidth = 100
        Me.colStokAkhir.MinWidth = 100
        Me.colStokAkhir.Name = "colStokAkhir"
        Me.colStokAkhir.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colStokAkhir.OptionsEditForm.VisibleIndex = 13
        Me.colStokAkhir.OptionsFilter.AllowFilter = False
        Me.colStokAkhir.Visible = True
        Me.colStokAkhir.VisibleIndex = 5
        Me.colStokAkhir.Width = 100
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MinWidth = 30
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Width = 112
        '
        'colisActive
        '
        Me.colisActive.Caption = " "
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.MaxWidth = 30
        Me.colisActive.MinWidth = 30
        Me.colisActive.Name = "colisActive"
        Me.colisActive.OptionsEditForm.Caption = "Status :"
        Me.colisActive.OptionsEditForm.VisibleIndex = 14
        Me.colisActive.OptionsFilter.AllowFilter = False
        Me.colisActive.Visible = True
        Me.colisActive.VisibleIndex = 6
        Me.colisActive.Width = 30
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 30
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.Width = 112
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.MinWidth = 30
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.Width = 112
        '
        'colInventoryType
        '
        Me.colInventoryType.Caption = "Tipe Barang"
        Me.colInventoryType.ColumnEdit = Me.Repo_LUE_InvType
        Me.colInventoryType.FieldName = "InventoryType"
        Me.colInventoryType.Name = "colInventoryType"
        Me.colInventoryType.OptionsEditForm.StartNewRow = True
        Me.colInventoryType.OptionsEditForm.VisibleIndex = 21
        Me.colInventoryType.Visible = True
        Me.colInventoryType.VisibleIndex = 6
        '
        'Repo_LUE_InvType
        '
        Me.Repo_LUE_InvType.AutoHeight = False
        Me.Repo_LUE_InvType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_InvType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryType", "Inventory Type", 115, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryTypeName", "Tipe Barang", 159, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_InvType.DataSource = Me.SpLookUpDataGetInventoryTypeBindingSource
        Me.Repo_LUE_InvType.DisplayMember = "InventoryTypeName"
        Me.Repo_LUE_InvType.Name = "Repo_LUE_InvType"
        Me.Repo_LUE_InvType.NullText = "-- PIlih Tipe Barang"
        Me.Repo_LUE_InvType.ValueMember = "InventoryType"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1283, 464)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Sp_MDInventory_GetDataGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1263, 414)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(826, 30)
        Me.LayoutControlItem2.Text = "Cari Barang :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(91, 18)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.LookUpEdit_InvType
        Me.LayoutControlItem3.Location = New System.Drawing.Point(826, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(324, 30)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(324, 30)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(324, 30)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Tipe Barang :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(91, 18)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SB_Refresh
        Me.LayoutControlItem4.Location = New System.Drawing.Point(1150, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(113, 27)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(113, 27)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(113, 30)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'Sp_MDInventory_GetDataTableAdapter
        '
        Me.Sp_MDInventory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Me.Sp_MDInventory_GetDataTableAdapter
        Me.TableAdapterManager.sp_SPPurchaseOrderDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mod_Purchase.DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 72)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.Size = New System.Drawing.Size(1283, 464)
        Me.NavigationFrame1.TabIndex = 5
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1283, 464)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Controls.Add(Me.FlyoutPanel1)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1283, 464)
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(783, 35)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right
        Me.FlyoutPanel1.Options.CloseOnOuterClick = True
        Me.FlyoutPanel1.OwnerControl = Me
        Me.FlyoutPanel1.Size = New System.Drawing.Size(361, 408)
        Me.FlyoutPanel1.TabIndex = 0
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.Label_InventoryName)
        Me.FlyoutPanelControl1.Controls.Add(Me.SB_AddOpname)
        Me.FlyoutPanelControl1.Controls.Add(Me.Ed_QtyOpname)
        Me.FlyoutPanelControl1.Controls.Add(Me.SB_ResetOpname)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(361, 408)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'Label_InventoryName
        '
        Me.Label_InventoryName.Appearance.Font = New System.Drawing.Font("Lato", 15.0!)
        Me.Label_InventoryName.Appearance.Options.UseFont = True
        Me.Label_InventoryName.Appearance.Options.UseTextOptions = True
        Me.Label_InventoryName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Label_InventoryName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_InventoryName.Location = New System.Drawing.Point(21, 23)
        Me.Label_InventoryName.Name = "Label_InventoryName"
        Me.Label_InventoryName.Size = New System.Drawing.Size(321, 62)
        Me.Label_InventoryName.TabIndex = 10
        Me.Label_InventoryName.Text = "Nama Barang"
        '
        'SB_AddOpname
        '
        Me.SB_AddOpname.Location = New System.Drawing.Point(127, 91)
        Me.SB_AddOpname.Name = "SB_AddOpname"
        Me.SB_AddOpname.Size = New System.Drawing.Size(215, 36)
        Me.SB_AddOpname.TabIndex = 12
        Me.SB_AddOpname.Text = "Tambahkan Stok Opname"
        '
        'Ed_QtyOpname
        '
        Me.Ed_QtyOpname.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_QtyOpname.Location = New System.Drawing.Point(21, 96)
        Me.Ed_QtyOpname.Name = "Ed_QtyOpname"
        Me.Ed_QtyOpname.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_QtyOpname.Size = New System.Drawing.Size(100, 26)
        Me.Ed_QtyOpname.TabIndex = 11
        '
        'SB_ResetOpname
        '
        Me.SB_ResetOpname.Location = New System.Drawing.Point(21, 133)
        Me.SB_ResetOpname.Name = "SB_ResetOpname"
        Me.SB_ResetOpname.Size = New System.Drawing.Size(321, 36)
        Me.SB_ResetOpname.TabIndex = 13
        Me.SB_ResetOpname.Text = "Reset Stok ke Nol"
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "alignhorizontalcenter_16x16.png")
        '
        'Sp_LookUpData_GetInventoryTypeTableAdapter
        '
        Me.Sp_LookUpData_GetInventoryTypeTableAdapter.ClearBeforeFill = True
        '
        'Sp_LookUpData_GetUoMTableAdapter
        '
        Me.Sp_LookUpData_GetUoMTableAdapter.ClearBeforeFill = True
        '
        'colImage
        '
        Me.colImage.FieldName = "Image"
        Me.colImage.Name = "colImage"
        Me.colImage.OptionsEditForm.RowSpan = 4
        Me.colImage.OptionsEditForm.UseEditorColRowSpan = False
        Me.colImage.Visible = True
        Me.colImage.VisibleIndex = 7
        '
        'Frm_MasterData
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 569)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Font = New System.Drawing.Font("Lato", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_MasterData"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Data Barang"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LookUpEdit_InvType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetInventoryTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetUoMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_InvType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.Ed_QtyOpname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Dataset As Dataset
    Friend WithEvents Sp_MDInventory_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_GetDataTableAdapter As DatasetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DatasetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_MDInventory_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Inventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoMID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokAwal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokAkhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colInventoryType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents LookUpEdit_InvType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents Label_InventoryName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SB_AddOpname As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_QtyOpname As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SB_ResetOpname As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents QueriesTableAdapter As DatasetTableAdapters.QueriesTableAdapter
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents SpLookUpDataGetInventoryTypeBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetInventoryTypeTableAdapter As DatasetTableAdapters.sp_LookUpData_GetInventoryTypeTableAdapter
    Friend WithEvents Repo_LUE_UoM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpLookUpDataGetUoMBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetUoMTableAdapter As DatasetTableAdapters.sp_LookUpData_GetUoMTableAdapter
    Friend WithEvents Repo_LUE_InvType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colImage As DevExpress.XtraGrid.Columns.GridColumn
End Class
