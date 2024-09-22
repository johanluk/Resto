<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_InvAtt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InvAtt))
        Me.sp_MDInvProduct_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.sp_MDInvProduct_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GV_Product = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvProductNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvProductName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.TabPane = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNav_Product = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabNav_Brand = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.sp_MDInvBrand_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDInvBrand_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Brand = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandNo_Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandName_Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser_Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.TabNav_Category = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.sp_MDInvCategory_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDInvCategory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Category = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryNo_Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoryName_Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser_Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabNav_Home = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.SB_Exit = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_MDInvBrand_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter()
        Me.Sp_MDInvCategory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter()
        Me.sp_MDInvProduct_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvProduct_GetDataTableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_MDInvProduct_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.TabPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane.SuspendLayout()
        Me.TabNav_Product.SuspendLayout()
        Me.TabNav_Brand.SuspendLayout()
        CType(Me.sp_MDInvBrand_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Brand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNav_Category.SuspendLayout()
        CType(Me.sp_MDInvCategory_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sp_MDInvProduct_GetDataBindingSource
        '
        Me.sp_MDInvProduct_GetDataBindingSource.DataMember = "sp_MDInvProduct_GetData"
        Me.sp_MDInvProduct_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'sp_MDInvProduct_GetDataGridControl
        '
        Me.sp_MDInvProduct_GetDataGridControl.DataSource = Me.sp_MDInvProduct_GetDataBindingSource
        Me.sp_MDInvProduct_GetDataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sp_MDInvProduct_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.sp_MDInvProduct_GetDataGridControl.Location = New System.Drawing.Point(0, 0)
        Me.sp_MDInvProduct_GetDataGridControl.MainView = Me.GV_Product
        Me.sp_MDInvProduct_GetDataGridControl.Name = "sp_MDInvProduct_GetDataGridControl"
        Me.sp_MDInvProduct_GetDataGridControl.Size = New System.Drawing.Size(1034, 311)
        Me.sp_MDInvProduct_GetDataGridControl.TabIndex = 13
        Me.sp_MDInvProduct_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Product})
        '
        'GV_Product
        '
        Me.GV_Product.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Product.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Product.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GV_Product.Appearance.Row.Options.UseFont = True
        Me.GV_Product.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colInvProductNo, Me.colInvProductName, Me.colDescription, Me.colModifiedUser})
        Me.GV_Product.GridControl = Me.sp_MDInvProduct_GetDataGridControl
        Me.GV_Product.Name = "GV_Product"
        Me.GV_Product.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Product.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 23
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.Width = 86
        '
        'colInvProductNo
        '
        Me.colInvProductNo.Caption = "No"
        Me.colInvProductNo.FieldName = "InvProductNo"
        Me.colInvProductNo.MinWidth = 23
        Me.colInvProductNo.Name = "colInvProductNo"
        Me.colInvProductNo.OptionsColumn.AllowEdit = False
        Me.colInvProductNo.OptionsColumn.AllowFocus = False
        Me.colInvProductNo.Visible = True
        Me.colInvProductNo.VisibleIndex = 0
        Me.colInvProductNo.Width = 86
        '
        'colInvProductName
        '
        Me.colInvProductName.Caption = "Name"
        Me.colInvProductName.FieldName = "InvProductName"
        Me.colInvProductName.MinWidth = 23
        Me.colInvProductName.Name = "colInvProductName"
        Me.colInvProductName.OptionsColumn.AllowEdit = False
        Me.colInvProductName.OptionsColumn.AllowFocus = False
        Me.colInvProductName.Visible = True
        Me.colInvProductName.VisibleIndex = 1
        Me.colInvProductName.Width = 86
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 23
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 86
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
        'SearchControl1
        '
        Me.SearchControl1.Client = Me.sp_MDInvProduct_GetDataGridControl
        Me.SearchControl1.Location = New System.Drawing.Point(724, 330)
        Me.SearchControl1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SearchControl1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SearchControl1.Properties.Appearance.Options.UseBackColor = True
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Properties.Client = Me.sp_MDInvProduct_GetDataGridControl
        Me.SearchControl1.Size = New System.Drawing.Size(307, 34)
        Me.SearchControl1.StyleController = Me.LayoutControl2
        Me.SearchControl1.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.TabPane)
        Me.LayoutControl2.Controls.Add(Me.SearchControl1)
        Me.LayoutControl2.Controls.Add(Me.SB_Exit)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 85)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.Root
        Me.LayoutControl2.Size = New System.Drawing.Size(1062, 401)
        Me.LayoutControl2.TabIndex = 15
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'TabPane
        '
        Me.TabPane.Controls.Add(Me.TabNav_Product)
        Me.TabPane.Controls.Add(Me.TabNav_Brand)
        Me.TabPane.Controls.Add(Me.TabNav_Category)
        Me.TabPane.Controls.Add(Me.TabNav_Home)
        Me.TabPane.Location = New System.Drawing.Point(16, 16)
        Me.TabPane.Name = "TabPane"
        Me.TabPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNav_Home, Me.TabNav_Product, Me.TabNav_Brand, Me.TabNav_Category})
        Me.TabPane.RegularSize = New System.Drawing.Size(1030, 293)
        Me.TabPane.SelectedPage = Me.TabNav_Brand
        Me.TabPane.Size = New System.Drawing.Size(1030, 293)
        Me.TabPane.TabIndex = 15
        Me.TabPane.Text = "TabPane1"
        '
        'TabNav_Product
        '
        Me.TabNav_Product.Caption = "Product"
        Me.TabNav_Product.Controls.Add(Me.sp_MDInvProduct_GetDataGridControl)
        Me.TabNav_Product.Name = "TabNav_Product"
        Me.TabNav_Product.Size = New System.Drawing.Size(1034, 311)
        '
        'TabNav_Brand
        '
        Me.TabNav_Brand.Caption = "Brand"
        Me.TabNav_Brand.Controls.Add(Me.sp_MDInvBrand_GetDataGridControl)
        Me.TabNav_Brand.Name = "TabNav_Brand"
        Me.TabNav_Brand.Size = New System.Drawing.Size(1038, 311)
        '
        'sp_MDInvBrand_GetDataGridControl
        '
        Me.sp_MDInvBrand_GetDataGridControl.DataSource = Me.Sp_MDInvBrand_GetDataBindingSource
        Me.sp_MDInvBrand_GetDataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sp_MDInvBrand_GetDataGridControl.Location = New System.Drawing.Point(0, 0)
        Me.sp_MDInvBrand_GetDataGridControl.MainView = Me.GV_Brand
        Me.sp_MDInvBrand_GetDataGridControl.MenuManager = Me.RibbonControl1
        Me.sp_MDInvBrand_GetDataGridControl.Name = "sp_MDInvBrand_GetDataGridControl"
        Me.sp_MDInvBrand_GetDataGridControl.Size = New System.Drawing.Size(1038, 311)
        Me.sp_MDInvBrand_GetDataGridControl.TabIndex = 0
        Me.sp_MDInvBrand_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Brand})
        '
        'Sp_MDInvBrand_GetDataBindingSource
        '
        Me.Sp_MDInvBrand_GetDataBindingSource.DataMember = "sp_MDInvBrand_GetData"
        Me.Sp_MDInvBrand_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Brand
        '
        Me.GV_Brand.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Brand, Me.colBrandNo_Brand, Me.colBrandName_Brand, Me.colDescription_Brand, Me.colModifiedUser_Brand})
        Me.GV_Brand.GridControl = Me.sp_MDInvBrand_GetDataGridControl
        Me.GV_Brand.Name = "GV_Brand"
        Me.GV_Brand.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Brand.OptionsView.ShowGroupPanel = False
        '
        'colID_Brand
        '
        Me.colID_Brand.FieldName = "ID"
        Me.colID_Brand.MinWidth = 23
        Me.colID_Brand.Name = "colID_Brand"
        Me.colID_Brand.OptionsFilter.AllowFilter = False
        Me.colID_Brand.Width = 86
        '
        'colBrandNo_Brand
        '
        Me.colBrandNo_Brand.FieldName = "BrandNo"
        Me.colBrandNo_Brand.MinWidth = 23
        Me.colBrandNo_Brand.Name = "colBrandNo_Brand"
        Me.colBrandNo_Brand.OptionsFilter.AllowFilter = False
        Me.colBrandNo_Brand.Visible = True
        Me.colBrandNo_Brand.VisibleIndex = 0
        Me.colBrandNo_Brand.Width = 86
        '
        'colBrandName_Brand
        '
        Me.colBrandName_Brand.FieldName = "BrandName"
        Me.colBrandName_Brand.MinWidth = 23
        Me.colBrandName_Brand.Name = "colBrandName_Brand"
        Me.colBrandName_Brand.OptionsFilter.AllowFilter = False
        Me.colBrandName_Brand.Visible = True
        Me.colBrandName_Brand.VisibleIndex = 1
        Me.colBrandName_Brand.Width = 86
        '
        'colDescription_Brand
        '
        Me.colDescription_Brand.FieldName = "Description"
        Me.colDescription_Brand.MinWidth = 23
        Me.colDescription_Brand.Name = "colDescription_Brand"
        Me.colDescription_Brand.OptionsFilter.AllowFilter = False
        Me.colDescription_Brand.Visible = True
        Me.colDescription_Brand.VisibleIndex = 2
        Me.colDescription_Brand.Width = 86
        '
        'colModifiedUser_Brand
        '
        Me.colModifiedUser_Brand.FieldName = "ModifiedUser"
        Me.colModifiedUser_Brand.MinWidth = 23
        Me.colModifiedUser_Brand.Name = "colModifiedUser_Brand"
        Me.colModifiedUser_Brand.Width = 86
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
        Me.RibbonControl1.Size = New System.Drawing.Size(1062, 85)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 486)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1062, 39)
        '
        'TabNav_Category
        '
        Me.TabNav_Category.Caption = "Category"
        Me.TabNav_Category.Controls.Add(Me.sp_MDInvCategory_GetDataGridControl)
        Me.TabNav_Category.Name = "TabNav_Category"
        Me.TabNav_Category.Size = New System.Drawing.Size(1034, 311)
        '
        'sp_MDInvCategory_GetDataGridControl
        '
        Me.sp_MDInvCategory_GetDataGridControl.DataSource = Me.Sp_MDInvCategory_GetDataBindingSource
        Me.sp_MDInvCategory_GetDataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sp_MDInvCategory_GetDataGridControl.Location = New System.Drawing.Point(0, 0)
        Me.sp_MDInvCategory_GetDataGridControl.MainView = Me.GV_Category
        Me.sp_MDInvCategory_GetDataGridControl.MenuManager = Me.RibbonControl1
        Me.sp_MDInvCategory_GetDataGridControl.Name = "sp_MDInvCategory_GetDataGridControl"
        Me.sp_MDInvCategory_GetDataGridControl.Size = New System.Drawing.Size(1034, 311)
        Me.sp_MDInvCategory_GetDataGridControl.TabIndex = 0
        Me.sp_MDInvCategory_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Category})
        '
        'Sp_MDInvCategory_GetDataBindingSource
        '
        Me.Sp_MDInvCategory_GetDataBindingSource.DataMember = "sp_MDInvCategory_GetData"
        Me.Sp_MDInvCategory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Category
        '
        Me.GV_Category.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Category, Me.colCategoryNo_Category, Me.colCategoryName_Category, Me.colDescription_Category, Me.colModifiedUser_Category})
        Me.GV_Category.GridControl = Me.sp_MDInvCategory_GetDataGridControl
        Me.GV_Category.Name = "GV_Category"
        Me.GV_Category.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Category.OptionsView.ShowGroupPanel = False
        '
        'colID_Category
        '
        Me.colID_Category.FieldName = "ID"
        Me.colID_Category.MinWidth = 23
        Me.colID_Category.Name = "colID_Category"
        Me.colID_Category.Width = 86
        '
        'colCategoryNo_Category
        '
        Me.colCategoryNo_Category.FieldName = "CategoryNo"
        Me.colCategoryNo_Category.MinWidth = 23
        Me.colCategoryNo_Category.Name = "colCategoryNo_Category"
        Me.colCategoryNo_Category.Visible = True
        Me.colCategoryNo_Category.VisibleIndex = 0
        Me.colCategoryNo_Category.Width = 86
        '
        'colCategoryName_Category
        '
        Me.colCategoryName_Category.FieldName = "CategoryName"
        Me.colCategoryName_Category.MinWidth = 23
        Me.colCategoryName_Category.Name = "colCategoryName_Category"
        Me.colCategoryName_Category.Visible = True
        Me.colCategoryName_Category.VisibleIndex = 1
        Me.colCategoryName_Category.Width = 86
        '
        'colDescription_Category
        '
        Me.colDescription_Category.FieldName = "Description"
        Me.colDescription_Category.MinWidth = 23
        Me.colDescription_Category.Name = "colDescription_Category"
        Me.colDescription_Category.Visible = True
        Me.colDescription_Category.VisibleIndex = 2
        Me.colDescription_Category.Width = 86
        '
        'colModifiedUser_Category
        '
        Me.colModifiedUser_Category.FieldName = "ModifiedUser"
        Me.colModifiedUser_Category.MinWidth = 23
        Me.colModifiedUser_Category.Name = "colModifiedUser_Category"
        Me.colModifiedUser_Category.Width = 86
        '
        'TabNav_Home
        '
        Me.TabNav_Home.Caption = "Home"
        Me.TabNav_Home.Name = "TabNav_Home"
        Me.TabNav_Home.Size = New System.Drawing.Size(1034, 311)
        '
        'SB_Exit
        '
        Me.SB_Exit.ImageOptions.SvgImage = CType(resources.GetObject("SB_Exit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Exit.Location = New System.Drawing.Point(32, 331)
        Me.SB_Exit.Name = "SB_Exit"
        Me.SB_Exit.Size = New System.Drawing.Size(424, 38)
        Me.SB_Exit.StyleController = Me.LayoutControl2
        Me.SB_Exit.TabIndex = 14
        Me.SB_Exit.Text = "&Exit"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1062, 401)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 299)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1036, 76)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SB_Exit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(430, 44)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SearchControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(672, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(23, 2, 2, 2)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(332, 44)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(430, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(242, 44)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TabPane
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1036, 299)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDCustomer_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Me.Sp_MDInvBrand_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Me.Sp_MDInvCategory_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Me.sp_MDInvProduct_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDPromo_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_MDInvBrand_GetDataTableAdapter
        '
        Me.Sp_MDInvBrand_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvCategory_GetDataTableAdapter
        '
        Me.Sp_MDInvCategory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'sp_MDInvProduct_GetDataTableAdapter
        '
        Me.sp_MDInvProduct_GetDataTableAdapter.ClearBeforeFill = True
        '
        'DxErrorProvider
        '
        Me.DxErrorProvider.ContainerControl = Me
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'Frm_InvAtt
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 525)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "Frm_InvAtt"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Inventory Attribute"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_MDInvProduct_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.TabPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane.ResumeLayout(False)
        Me.TabNav_Product.ResumeLayout(False)
        Me.TabNav_Brand.ResumeLayout(False)
        CType(Me.sp_MDInvBrand_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Brand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNav_Category.ResumeLayout(False)
        CType(Me.sp_MDInvCategory_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imageList1 As ImageList
    Friend WithEvents DataSet As DataSet
    Friend WithEvents Sp_SPMaterialReceiveDetailGetDataBindingSource As BindingSource
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents sp_MDInvProduct_GetDataBindingSource As BindingSource
    Friend WithEvents sp_MDInvProduct_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvProduct_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents sp_MDInvProduct_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Product As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvProductNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvProductName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_Exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabPane As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNav_Product As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNav_Brand As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents sp_MDInvBrand_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents Sp_MDInvBrand_GetDataBindingSource As BindingSource
    Friend WithEvents GV_Brand As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandNo_Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandName_Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser_Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabNav_Category As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents sp_MDInvCategory_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents Sp_MDInvCategory_GetDataBindingSource As BindingSource
    Friend WithEvents GV_Category As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryNo_Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryName_Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser_Category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabNav_Home As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_MDInvBrand_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter
    Friend WithEvents Sp_MDInvCategory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
End Class
