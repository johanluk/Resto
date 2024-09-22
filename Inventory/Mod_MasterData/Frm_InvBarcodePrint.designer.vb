<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_InvBarcodePrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InvBarcodePrint))
        Dim Transition1 As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
        Dim FadeTransition1 As DevExpress.Utils.Animation.FadeTransition = New DevExpress.Utils.Animation.FadeTransition()
        Dim Transition2 As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
        Me.SB_Exit = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.CB_Print = New DevExpress.XtraEditors.CheckButton()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.Sp_MDInventory_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.sp_MDInventory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Brand = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDInvBrand_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Category = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDInvCategory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Product = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDInvProduct_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colUoMID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colT_PrintQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colT_PrintCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_BarcodePrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.sp_MDInventory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.TransitionManager1 = New DevExpress.Utils.Animation.TransitionManager(Me.components)
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sp_MDInvBrand_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter()
        Me.Sp_MDInvCategory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter()
        Me.Sp_MDInvProduct_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvProduct_GetDataTableAdapter()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Brand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SB_Exit
        '
        Me.SB_Exit.ImageOptions.SvgImage = CType(resources.GetObject("SB_Exit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Exit.Location = New System.Drawing.Point(21, 514)
        Me.SB_Exit.Name = "SB_Exit"
        Me.SB_Exit.Size = New System.Drawing.Size(106, 38)
        Me.SB_Exit.StyleController = Me.LayoutControl1
        Me.SB_Exit.TabIndex = 16
        Me.SB_Exit.Text = "&Exit"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.CB_Print)
        Me.LayoutControl1.Controls.Add(Me.SearchControl1)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.SB_BarcodePrint)
        Me.LayoutControl1.Controls.Add(Me.SB_Exit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(318, 217, 432, 350)
        Me.LayoutControl1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1487, 571)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'CB_Print
        '
        Me.CB_Print.AllowFocus = False
        Me.CB_Print.ImageOptions.SvgImage = CType(resources.GetObject("CB_Print.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.CB_Print.Location = New System.Drawing.Point(921, 514)
        Me.CB_Print.Name = "CB_Print"
        Me.CB_Print.Size = New System.Drawing.Size(130, 38)
        Me.CB_Print.StyleController = Me.LayoutControl1
        Me.CB_Print.TabIndex = 17
        Me.CB_Print.Text = "&Print"
        '
        'SearchControl1
        '
        Me.SearchControl1.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.SearchControl1.Location = New System.Drawing.Point(1223, 516)
        Me.SearchControl1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SearchControl1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SearchControl1.Properties.Appearance.Options.UseBackColor = True
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Properties.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.SearchControl1.Size = New System.Drawing.Size(244, 34)
        Me.SearchControl1.StyleController = Me.LayoutControl1
        Me.SearchControl1.TabIndex = 0
        '
        'Sp_MDInventory_GetDataGridControl
        '
        Me.Sp_MDInventory_GetDataGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.Sp_MDInventory_GetDataGridControl.DataSource = Me.sp_MDInventory_GetDataBindingSource
        Me.Sp_MDInventory_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Sp_MDInventory_GetDataGridControl.Location = New System.Drawing.Point(3, 11)
        Me.Sp_MDInventory_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_MDInventory_GetDataGridControl.Name = "Sp_MDInventory_GetDataGridControl"
        Me.Sp_MDInventory_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_LUE_Brand, Me.Repo_LUE_Category, Me.Repo_LUE_Product, Me.Repo_Num})
        Me.Sp_MDInventory_GetDataGridControl.Size = New System.Drawing.Size(1481, 454)
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
        Me.GV_Detail.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GV_Detail.Appearance.Row.Options.UseFont = True
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colInventoryNo, Me.colInventoryName, Me.colBrandID, Me.colCategoryID, Me.colProductID, Me.colUoMID, Me.colMinStock, Me.colMaxStock, Me.colDescription, Me.colisActive, Me.colModifiedUser, Me.colBarcode, Me.colPrice, Me.colT_PrintQty, Me.colT_PrintCheck})
        Me.GV_Detail.GridControl = Me.Sp_MDInventory_GetDataGridControl
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_Detail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Detail.OptionsView.ShowGroupPanel = False
        Me.GV_Detail.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 23
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colID.Width = 86
        '
        'colInventoryNo
        '
        Me.colInventoryNo.Caption = "Kode"
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MinWidth = 23
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colInventoryNo.OptionsFilter.AllowFilter = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 0
        Me.colInventoryNo.Width = 128
        '
        'colInventoryName
        '
        Me.colInventoryName.Caption = "Nama"
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.MinWidth = 23
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsEditForm.Caption = "Nama :"
        Me.colInventoryName.OptionsFilter.AllowFilter = False
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 1
        Me.colInventoryName.Width = 147
        '
        'colBrandID
        '
        Me.colBrandID.Caption = "Brand"
        Me.colBrandID.ColumnEdit = Me.Repo_LUE_Brand
        Me.colBrandID.FieldName = "InventoryBrandID"
        Me.colBrandID.MinWidth = 23
        Me.colBrandID.Name = "colBrandID"
        Me.colBrandID.OptionsEditForm.Caption = "Merk :"
        Me.colBrandID.OptionsFilter.AllowFilter = False
        Me.colBrandID.Visible = True
        Me.colBrandID.VisibleIndex = 2
        Me.colBrandID.Width = 147
        '
        'Repo_LUE_Brand
        '
        Me.Repo_LUE_Brand.AutoHeight = False
        Me.Repo_LUE_Brand.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Brand.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "Brand Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_Brand.DataSource = Me.Sp_MDInvBrand_GetDataBindingSource
        Me.Repo_LUE_Brand.DisplayMember = "BrandName"
        Me.Repo_LUE_Brand.Name = "Repo_LUE_Brand"
        Me.Repo_LUE_Brand.ValueMember = "ID"
        '
        'Sp_MDInvBrand_GetDataBindingSource
        '
        Me.Sp_MDInvBrand_GetDataBindingSource.DataMember = "sp_MDInvBrand_GetData"
        Me.Sp_MDInvBrand_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colCategoryID
        '
        Me.colCategoryID.Caption = "Kategori"
        Me.colCategoryID.ColumnEdit = Me.Repo_LUE_Category
        Me.colCategoryID.FieldName = "InventoryCategoryID"
        Me.colCategoryID.MinWidth = 23
        Me.colCategoryID.Name = "colCategoryID"
        Me.colCategoryID.OptionsEditForm.Caption = "Kategori :"
        Me.colCategoryID.OptionsFilter.AllowFilter = False
        Me.colCategoryID.Visible = True
        Me.colCategoryID.VisibleIndex = 3
        Me.colCategoryID.Width = 147
        '
        'Repo_LUE_Category
        '
        Me.Repo_LUE_Category.AutoHeight = False
        Me.Repo_LUE_Category.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Category.DataSource = Me.Sp_MDInvCategory_GetDataBindingSource
        Me.Repo_LUE_Category.DisplayMember = "CategoryName"
        Me.Repo_LUE_Category.Name = "Repo_LUE_Category"
        Me.Repo_LUE_Category.ValueMember = "ID"
        '
        'Sp_MDInvCategory_GetDataBindingSource
        '
        Me.Sp_MDInvCategory_GetDataBindingSource.DataMember = "sp_MDInvCategory_GetData"
        Me.Sp_MDInvCategory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colProductID
        '
        Me.colProductID.Caption = "Produk"
        Me.colProductID.ColumnEdit = Me.Repo_LUE_Product
        Me.colProductID.FieldName = "InventoryProductID"
        Me.colProductID.MinWidth = 23
        Me.colProductID.Name = "colProductID"
        Me.colProductID.OptionsFilter.AllowFilter = False
        Me.colProductID.Visible = True
        Me.colProductID.VisibleIndex = 4
        Me.colProductID.Width = 147
        '
        'Repo_LUE_Product
        '
        Me.Repo_LUE_Product.AutoHeight = False
        Me.Repo_LUE_Product.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Product.DataSource = Me.Sp_MDInvProduct_GetDataBindingSource
        Me.Repo_LUE_Product.DisplayMember = "ProductName"
        Me.Repo_LUE_Product.Name = "Repo_LUE_Product"
        Me.Repo_LUE_Product.ValueMember = "ID"
        '
        'Sp_MDInvProduct_GetDataBindingSource
        '
        Me.Sp_MDInvProduct_GetDataBindingSource.DataMember = "sp_MDInvProduct_GetData"
        Me.Sp_MDInvProduct_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colUoMID
        '
        Me.colUoMID.Caption = "Satuan"
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.MinWidth = 23
        Me.colUoMID.Name = "colUoMID"
        Me.colUoMID.OptionsEditForm.Caption = "Satuan :"
        Me.colUoMID.OptionsFilter.AllowFilter = False
        Me.colUoMID.Visible = True
        Me.colUoMID.VisibleIndex = 5
        Me.colUoMID.Width = 103
        '
        'colMinStock
        '
        Me.colMinStock.FieldName = "MinStock"
        Me.colMinStock.MinWidth = 23
        Me.colMinStock.Name = "colMinStock"
        Me.colMinStock.Width = 86
        '
        'colMaxStock
        '
        Me.colMaxStock.FieldName = "MaxStock"
        Me.colMaxStock.MinWidth = 23
        Me.colMaxStock.Name = "colMaxStock"
        Me.colMaxStock.Width = 86
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 23
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 6
        Me.colDescription.Width = 162
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.MinWidth = 23
        Me.colisActive.Name = "colisActive"
        Me.colisActive.OptionsColumn.AllowEdit = False
        Me.colisActive.OptionsColumn.AllowFocus = False
        Me.colisActive.Width = 86
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 23
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        Me.colModifiedUser.Width = 86
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.MinWidth = 23
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.OptionsFilter.AllowFilter = False
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 7
        Me.colBarcode.Width = 195
        '
        'colPrice
        '
        Me.colPrice.ColumnEdit = Me.Repo_Num
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MinWidth = 23
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsFilter.AllowFilter = False
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 8
        Me.colPrice.Width = 239
        '
        'Repo_Num
        '
        Me.Repo_Num.AutoHeight = False
        Me.Repo_Num.Mask.EditMask = "n0"
        Me.Repo_Num.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Repo_Num.Mask.UseMaskAsDisplayFormat = True
        Me.Repo_Num.Name = "Repo_Num"
        '
        'colT_PrintQty
        '
        Me.colT_PrintQty.Caption = "Qty"
        Me.colT_PrintQty.FieldName = "T_PrintQty"
        Me.colT_PrintQty.MaxWidth = 46
        Me.colT_PrintQty.MinWidth = 46
        Me.colT_PrintQty.Name = "colT_PrintQty"
        Me.colT_PrintQty.OptionsFilter.AllowFilter = False
        Me.colT_PrintQty.Visible = True
        Me.colT_PrintQty.VisibleIndex = 9
        Me.colT_PrintQty.Width = 46
        '
        'colT_PrintCheck
        '
        Me.colT_PrintCheck.Caption = " "
        Me.colT_PrintCheck.FieldName = "T_PrintCheck"
        Me.colT_PrintCheck.MaxWidth = 23
        Me.colT_PrintCheck.MinWidth = 23
        Me.colT_PrintCheck.Name = "colT_PrintCheck"
        Me.colT_PrintCheck.OptionsFilter.AllowFilter = False
        Me.colT_PrintCheck.Visible = True
        Me.colT_PrintCheck.VisibleIndex = 10
        Me.colT_PrintCheck.Width = 23
        '
        'SB_BarcodePrint
        '
        Me.SB_BarcodePrint.ImageOptions.SvgImage = CType(resources.GetObject("SB_BarcodePrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_BarcodePrint.Location = New System.Drawing.Point(1057, 514)
        Me.SB_BarcodePrint.Name = "SB_BarcodePrint"
        Me.SB_BarcodePrint.Size = New System.Drawing.Size(153, 38)
        Me.SB_BarcodePrint.StyleController = Me.LayoutControl1
        Me.SB_BarcodePrint.TabIndex = 14
        Me.SB_BarcodePrint.Text = "&Barcode Print"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlGroup5})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1487, 571)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Sp_MDInventory_GetDataGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1487, 460)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem5})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 460)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1487, 103)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SB_Exit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(112, 44)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SB_BarcodePrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1036, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(159, 44)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SearchControl1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(1195, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(256, 37)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(256, 37)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 5, 2)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(256, 44)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(112, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(0, 37)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(10, 37)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(788, 44)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CB_Print
        Me.LayoutControlItem5.Location = New System.Drawing.Point(900, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(136, 44)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.StyleController1.Appearance.Options.UseFont = True
        Me.StyleController1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.StyleController1.LookAndFeel.UseDefaultLookAndFeel = False
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 85)
        Me.NavigationFrame1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.Size = New System.Drawing.Size(1487, 571)
        Me.NavigationFrame1.TabIndex = 12
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1487, 571)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1487, 571)
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.sp_MDCustomer_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDPromo_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TransitionManager1
        '
        Transition1.Control = Nothing
        Transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5
        Transition1.LineWaitingIndicatorProperties.Caption = ""
        Transition1.LineWaitingIndicatorProperties.Description = ""
        Transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5
        Transition1.RingWaitingIndicatorProperties.Caption = ""
        Transition1.RingWaitingIndicatorProperties.Description = ""
        Transition1.TransitionType = FadeTransition1
        Transition1.WaitingAnimatorType = DevExpress.Utils.Animation.WaitingAnimatorType.Bar
        Transition1.WaitingIndicatorProperties.Caption = ""
        Transition1.WaitingIndicatorProperties.Description = ""
        Transition2.BarWaitingIndicatorProperties.Caption = ""
        Transition2.BarWaitingIndicatorProperties.Description = ""
        Transition2.Control = Nothing
        Transition2.EasingMode = DevExpress.Data.Utils.EasingMode.EaseOut
        Transition2.LineWaitingIndicatorProperties.AnimationElementCount = 5
        Transition2.LineWaitingIndicatorProperties.Caption = ""
        Transition2.LineWaitingIndicatorProperties.Description = ""
        Transition2.RingWaitingIndicatorProperties.AnimationElementCount = 5
        Transition2.RingWaitingIndicatorProperties.Caption = ""
        Transition2.RingWaitingIndicatorProperties.Description = ""
        Transition2.WaitingAnimatorType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        Transition2.WaitingIndicatorProperties.Caption = ""
        Transition2.WaitingIndicatorProperties.Description = ""
        Me.TransitionManager1.Transitions.Add(Transition1)
        Me.TransitionManager1.Transitions.Add(Transition2)
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
        'RibbonControl1
        '
        Me.RibbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(34, 30, 34, 30)
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.OptionsMenuMinWidth = 377
        Me.RibbonControl1.Size = New System.Drawing.Size(1487, 85)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 656)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1487, 39)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Frm_InvBarcodePrint
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1487, 695)
        Me.ControlBox = False
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "Frm_InvBarcodePrint"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Frm_SPMaterialReceiveCash"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Brand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imageList1 As ImageList
    Friend WithEvents DataSet As DataSet
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents sp_MDInventory_GetDataBindingSource As BindingSource
    Friend WithEvents sp_MDInventory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_MDInventory_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TransitionManager1 As DevExpress.Utils.Animation.TransitionManager
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents Repo_LUE_Brand As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Repo_LUE_Category As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Repo_LUE_Product As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SB_BarcodePrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents CB_Print As DevExpress.XtraEditors.CheckButton
    Friend WithEvents colBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_Num As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colT_PrintQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colT_PrintCheck As DevExpress.XtraGrid.Columns.GridColumn
End Class
