<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InputStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InputStock))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_PrintBarcode = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Input = New DevExpress.XtraEditors.SimpleButton()
        Me.SLE_NamaBarang = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.Sp_MDInventory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBarcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SLE_OpnameHistory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SpTOpnameGetListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNoTransaction1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpnameDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_NewOpname = New DevExpress.XtraEditors.SimpleButton()
        Me.CB_Warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Ed_KodeHarga = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Qty = New DevExpress.XtraEditors.TextEdit()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpMDUoMGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpMDInvCategoryGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpMDInvBrandGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ed_BarcodeInput = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_InvName_Input = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_InvNo_Input = New DevExpress.XtraEditors.TextEdit()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Print = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Sp_T_Opname_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_T_Opname_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoTransaction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Inv = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ed_Barcode = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_NoTransaksi = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_T_Opname_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_T_Opname_GetDataTableAdapter()
        Me.Sp_MDInventory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.QueriesTableAdapter = New Master_Data.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_MDInvBrand_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter()
        Me.Sp_MDInvCategory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter()
        Me.Sp_MDUoMGetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDUoMGetDataTableAdapter()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Sp_T_Opname_GetListTableAdapter = New Master_Data.DataSetTableAdapters.sp_T_Opname_GetListTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SLE_NamaBarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SLE_OpnameHistory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpTOpnameGetListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CB_Warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_KodeHarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInvCategoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInvBrandGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_BarcodeInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_InvName_Input.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_InvNo_Input.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_T_Opname_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_T_Opname_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Barcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_NoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Appearance.Control.Options.UseFont = True
        Me.LayoutControl1.Controls.Add(Me.SB_Close)
        Me.LayoutControl1.Controls.Add(Me.SB_PrintBarcode)
        Me.LayoutControl1.Controls.Add(Me.SB_Input)
        Me.LayoutControl1.Controls.Add(Me.SLE_NamaBarang)
        Me.LayoutControl1.Controls.Add(Me.SLE_OpnameHistory)
        Me.LayoutControl1.Controls.Add(Me.SB_NewOpname)
        Me.LayoutControl1.Controls.Add(Me.CB_Warehouse)
        Me.LayoutControl1.Controls.Add(Me.Ed_KodeHarga)
        Me.LayoutControl1.Controls.Add(Me.Ed_Qty)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit3)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit2)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit1)
        Me.LayoutControl1.Controls.Add(Me.Ed_BarcodeInput)
        Me.LayoutControl1.Controls.Add(Me.Ed_InvName_Input)
        Me.LayoutControl1.Controls.Add(Me.Ed_InvNo_Input)
        Me.LayoutControl1.Controls.Add(Me.SB_Submit)
        Me.LayoutControl1.Controls.Add(Me.SB_Print)
        Me.LayoutControl1.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl1.Controls.Add(Me.Sp_T_Opname_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.Ed_Barcode)
        Me.LayoutControl1.Controls.Add(Me.Ed_NoTransaksi)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 85)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1124, 556)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SB_Close
        '
        Me.SB_Close.ImageOptions.SvgImage = CType(resources.GetObject("SB_Close.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Close.Location = New System.Drawing.Point(977, 16)
        Me.SB_Close.Name = "SB_Close"
        Me.SB_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Close.Size = New System.Drawing.Size(114, 30)
        Me.SB_Close.StyleController = Me.LayoutControl1
        Me.SB_Close.TabIndex = 24
        Me.SB_Close.Text = "Close"
        '
        'SB_PrintBarcode
        '
        Me.SB_PrintBarcode.ImageOptions.SvgImage = CType(resources.GetObject("SB_PrintBarcode.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_PrintBarcode.Location = New System.Drawing.Point(977, 88)
        Me.SB_PrintBarcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_PrintBarcode.Name = "SB_PrintBarcode"
        Me.SB_PrintBarcode.Size = New System.Drawing.Size(114, 30)
        Me.SB_PrintBarcode.StyleController = Me.LayoutControl1
        Me.SB_PrintBarcode.TabIndex = 23
        Me.SB_PrintBarcode.Text = "Print Barcode"
        '
        'SB_Input
        '
        Me.SB_Input.ImageOptions.SvgImage = CType(resources.GetObject("SB_Input.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Input.Location = New System.Drawing.Point(762, 88)
        Me.SB_Input.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Input.Name = "SB_Input"
        Me.SB_Input.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Input.Size = New System.Drawing.Size(82, 30)
        Me.SB_Input.StyleController = Me.LayoutControl1
        Me.SB_Input.TabIndex = 22
        Me.SB_Input.Text = "Input"
        '
        'SLE_NamaBarang
        '
        Me.SLE_NamaBarang.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Sp_MDInventory_GetDataBindingSource, "ID", True))
        Me.SLE_NamaBarang.Location = New System.Drawing.Point(512, 88)
        Me.SLE_NamaBarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SLE_NamaBarang.MenuManager = Me.RibbonControl1
        Me.SLE_NamaBarang.Name = "SLE_NamaBarang"
        Me.SLE_NamaBarang.Properties.Appearance.Font = New System.Drawing.Font("Lato", 12.0!)
        Me.SLE_NamaBarang.Properties.Appearance.Options.UseFont = True
        Me.SLE_NamaBarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLE_NamaBarang.Properties.DataSource = Me.Sp_MDInventory_GetDataBindingSource
        Me.SLE_NamaBarang.Properties.DisplayMember = "InventoryName"
        Me.SLE_NamaBarang.Properties.NullText = "-- Pilih Barang"
        Me.SLE_NamaBarang.Properties.PopupView = Me.GridView1
        Me.SLE_NamaBarang.Properties.ShowAddNewButton = True
        Me.SLE_NamaBarang.Properties.ValueMember = "ID"
        Me.SLE_NamaBarang.Size = New System.Drawing.Size(244, 34)
        Me.SLE_NamaBarang.StyleController = Me.LayoutControl1
        Me.SLE_NamaBarang.TabIndex = 21
        '
        'Sp_MDInventory_GetDataBindingSource
        '
        Me.Sp_MDInventory_GetDataBindingSource.DataMember = "sp_MDInventory_GetData"
        Me.Sp_MDInventory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonControl1
        '
        Me.RibbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(38, 36, 38, 36)
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.OptionsMenuMinWidth = 424
        Me.RibbonControl1.Size = New System.Drawing.Size(1124, 85)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 641)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1124, 39)
        Me.RibbonStatusBar1.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBarcode1, Me.colInventoryName})
        Me.GridView1.DetailHeight = 416
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colBarcode1
        '
        Me.colBarcode1.FieldName = "Barcode"
        Me.colBarcode1.MinWidth = 26
        Me.colBarcode1.Name = "colBarcode1"
        Me.colBarcode1.OptionsColumn.AllowEdit = False
        Me.colBarcode1.OptionsColumn.ReadOnly = True
        Me.colBarcode1.Visible = True
        Me.colBarcode1.VisibleIndex = 1
        Me.colBarcode1.Width = 97
        '
        'colInventoryName
        '
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.MinWidth = 26
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsColumn.AllowEdit = False
        Me.colInventoryName.OptionsColumn.ReadOnly = True
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 0
        Me.colInventoryName.Width = 97
        '
        'SLE_OpnameHistory
        '
        Me.SLE_OpnameHistory.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SpTOpnameGetListBindingSource, "NoTransaction", True))
        Me.SLE_OpnameHistory.EditValue = "0"
        Me.SLE_OpnameHistory.Location = New System.Drawing.Point(245, 16)
        Me.SLE_OpnameHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SLE_OpnameHistory.MenuManager = Me.RibbonControl1
        Me.SLE_OpnameHistory.Name = "SLE_OpnameHistory"
        Me.SLE_OpnameHistory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SLE_OpnameHistory.Properties.DataSource = Me.SpTOpnameGetListBindingSource
        Me.SLE_OpnameHistory.Properties.DisplayMember = "NoTransaction"
        Me.SLE_OpnameHistory.Properties.NullText = "-- Lihat Transaksi Opname yang pernah dibuat"
        Me.SLE_OpnameHistory.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SLE_OpnameHistory.Properties.ValueMember = "NoTransaction"
        Me.SLE_OpnameHistory.Size = New System.Drawing.Size(491, 30)
        Me.SLE_OpnameHistory.StyleController = Me.LayoutControl1
        Me.SLE_OpnameHistory.TabIndex = 20
        '
        'SpTOpnameGetListBindingSource
        '
        Me.SpTOpnameGetListBindingSource.DataMember = "sp_T_Opname_GetList"
        Me.SpTOpnameGetListBindingSource.DataSource = Me.DataSet
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoTransaction1, Me.colOpnameDate, Me.colID1})
        Me.SearchLookUpEdit1View.DetailHeight = 416
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colNoTransaction1
        '
        Me.colNoTransaction1.Caption = "No. Opname"
        Me.colNoTransaction1.FieldName = "NoTransaction"
        Me.colNoTransaction1.MinWidth = 26
        Me.colNoTransaction1.Name = "colNoTransaction1"
        Me.colNoTransaction1.OptionsColumn.AllowEdit = False
        Me.colNoTransaction1.OptionsColumn.AllowFocus = False
        Me.colNoTransaction1.Visible = True
        Me.colNoTransaction1.VisibleIndex = 0
        Me.colNoTransaction1.Width = 97
        '
        'colOpnameDate
        '
        Me.colOpnameDate.Caption = "Tgl. Opname"
        Me.colOpnameDate.FieldName = "OpnameDate"
        Me.colOpnameDate.MinWidth = 26
        Me.colOpnameDate.Name = "colOpnameDate"
        Me.colOpnameDate.OptionsColumn.AllowEdit = False
        Me.colOpnameDate.OptionsColumn.AllowFocus = False
        Me.colOpnameDate.Visible = True
        Me.colOpnameDate.VisibleIndex = 1
        Me.colOpnameDate.Width = 97
        '
        'colID1
        '
        Me.colID1.Caption = "Qty"
        Me.colID1.FieldName = "ID"
        Me.colID1.MinWidth = 26
        Me.colID1.Name = "colID1"
        Me.colID1.OptionsColumn.AllowEdit = False
        Me.colID1.OptionsColumn.AllowFocus = False
        Me.colID1.Visible = True
        Me.colID1.VisibleIndex = 2
        Me.colID1.Width = 97
        '
        'SB_NewOpname
        '
        Me.SB_NewOpname.AllowFocus = False
        Me.SB_NewOpname.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.SB_NewOpname.ImageOptions.SvgImage = CType(resources.GetObject("SB_NewOpname.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_NewOpname.Location = New System.Drawing.Point(16, 16)
        Me.SB_NewOpname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_NewOpname.MinimumSize = New System.Drawing.Size(0, 54)
        Me.SB_NewOpname.Name = "SB_NewOpname"
        Me.SB_NewOpname.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_NewOpname.Size = New System.Drawing.Size(106, 54)
        Me.SB_NewOpname.StyleController = Me.LayoutControl1
        Me.SB_NewOpname.TabIndex = 19
        Me.SB_NewOpname.Text = "New Opname"
        '
        'CB_Warehouse
        '
        Me.CB_Warehouse.Location = New System.Drawing.Point(579, 52)
        Me.CB_Warehouse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CB_Warehouse.MenuManager = Me.RibbonControl1
        Me.CB_Warehouse.Name = "CB_Warehouse"
        Me.CB_Warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CB_Warehouse.Properties.Items.AddRange(New Object() {"Harmoni"})
        Me.CB_Warehouse.Size = New System.Drawing.Size(157, 30)
        Me.CB_Warehouse.StyleController = Me.LayoutControl1
        Me.CB_Warehouse.TabIndex = 18
        '
        'Ed_KodeHarga
        '
        Me.Ed_KodeHarga.Location = New System.Drawing.Point(898, 423)
        Me.Ed_KodeHarga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_KodeHarga.MenuManager = Me.RibbonControl1
        Me.Ed_KodeHarga.Name = "Ed_KodeHarga"
        Me.Ed_KodeHarga.Size = New System.Drawing.Size(177, 30)
        Me.Ed_KodeHarga.StyleController = Me.LayoutControl1
        Me.Ed_KodeHarga.TabIndex = 17
        '
        'Ed_Qty
        '
        Me.Ed_Qty.Location = New System.Drawing.Point(898, 387)
        Me.Ed_Qty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_Qty.MenuManager = Me.RibbonControl1
        Me.Ed_Qty.Name = "Ed_Qty"
        Me.Ed_Qty.Size = New System.Drawing.Size(177, 30)
        Me.Ed_Qty.StyleController = Me.LayoutControl1
        Me.Ed_Qty.TabIndex = 16
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(898, 459)
        Me.MemoEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(177, 30)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 15
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.Location = New System.Drawing.Point(898, 279)
        Me.LookUpEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMCode", "Uo MCode", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMName", "Uo MName", 92, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 115, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedDate", "Modified Date", 111, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit3.Properties.DataSource = Me.SpMDUoMGetDataBindingSource
        Me.LookUpEdit3.Properties.DisplayMember = "UoMName"
        Me.LookUpEdit3.Properties.ValueMember = "ID"
        Me.LookUpEdit3.Size = New System.Drawing.Size(177, 30)
        Me.LookUpEdit3.StyleController = Me.LayoutControl1
        Me.LookUpEdit3.TabIndex = 14
        '
        'SpMDUoMGetDataBindingSource
        '
        Me.SpMDUoMGetDataBindingSource.DataMember = "sp_MDUoMGetData"
        Me.SpMDUoMGetDataBindingSource.DataSource = Me.DataSet
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.Location = New System.Drawing.Point(898, 243)
        Me.LookUpEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryNo", "Category No", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name", 126, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 98, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 115, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit2.Properties.DataSource = Me.SpMDInvCategoryGetDataBindingSource
        Me.LookUpEdit2.Properties.DisplayMember = "CategoryName"
        Me.LookUpEdit2.Properties.ValueMember = "ID"
        Me.LookUpEdit2.Size = New System.Drawing.Size(177, 30)
        Me.LookUpEdit2.StyleController = Me.LayoutControl1
        Me.LookUpEdit2.TabIndex = 13
        '
        'SpMDInvCategoryGetDataBindingSource
        '
        Me.SpMDInvCategoryGetDataBindingSource.DataMember = "sp_MDInvCategory_GetData"
        Me.SpMDInvCategoryGetDataBindingSource.DataSource = Me.DataSet
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(898, 207)
        Me.LookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandNo", "Brand No", 81, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "Brand Name", 105, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 98, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 115, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit1.Properties.DataSource = Me.SpMDInvBrandGetDataBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "BrandName"
        Me.LookUpEdit1.Properties.ValueMember = "ID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(177, 30)
        Me.LookUpEdit1.StyleController = Me.LayoutControl1
        Me.LookUpEdit1.TabIndex = 12
        '
        'SpMDInvBrandGetDataBindingSource
        '
        Me.SpMDInvBrandGetDataBindingSource.DataMember = "sp_MDInvBrand_GetData"
        Me.SpMDInvBrandGetDataBindingSource.DataSource = Me.DataSet
        '
        'Ed_BarcodeInput
        '
        Me.Ed_BarcodeInput.Location = New System.Drawing.Point(898, 171)
        Me.Ed_BarcodeInput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_BarcodeInput.Name = "Ed_BarcodeInput"
        Me.Ed_BarcodeInput.Size = New System.Drawing.Size(177, 30)
        Me.Ed_BarcodeInput.StyleController = Me.LayoutControl1
        Me.Ed_BarcodeInput.TabIndex = 11
        '
        'Ed_InvName_Input
        '
        Me.Ed_InvName_Input.Location = New System.Drawing.Point(898, 351)
        Me.Ed_InvName_Input.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_InvName_Input.Name = "Ed_InvName_Input"
        Me.Ed_InvName_Input.Size = New System.Drawing.Size(177, 30)
        Me.Ed_InvName_Input.StyleController = Me.LayoutControl1
        Me.Ed_InvName_Input.TabIndex = 10
        '
        'Ed_InvNo_Input
        '
        Me.Ed_InvNo_Input.Location = New System.Drawing.Point(898, 315)
        Me.Ed_InvNo_Input.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_InvNo_Input.Name = "Ed_InvNo_Input"
        Me.Ed_InvNo_Input.Size = New System.Drawing.Size(177, 30)
        Me.Ed_InvNo_Input.StyleController = Me.LayoutControl1
        Me.Ed_InvNo_Input.TabIndex = 9
        '
        'SB_Submit
        '
        Me.SB_Submit.Location = New System.Drawing.Point(781, 495)
        Me.SB_Submit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.Size = New System.Drawing.Size(294, 28)
        Me.SB_Submit.StyleController = Me.LayoutControl1
        Me.SB_Submit.TabIndex = 8
        Me.SB_Submit.Text = "&Submit"
        '
        'SB_Print
        '
        Me.SB_Print.ImageOptions.SvgImage = CType(resources.GetObject("SB_Print.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Print.Location = New System.Drawing.Point(898, 88)
        Me.SB_Print.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Print.Name = "SB_Print"
        Me.SB_Print.Size = New System.Drawing.Size(73, 30)
        Me.SB_Print.StyleController = Me.LayoutControl1
        Me.SB_Print.TabIndex = 7
        Me.SB_Print.Text = "&Print"
        '
        'SB_Refresh
        '
        Me.SB_Refresh.AllowFocus = False
        Me.SB_Refresh.ImageOptions.SvgImage = CType(resources.GetObject("SB_Refresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Refresh.Location = New System.Drawing.Point(16, 88)
        Me.SB_Refresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Refresh.Size = New System.Drawing.Size(106, 30)
        Me.SB_Refresh.StyleController = Me.LayoutControl1
        Me.SB_Refresh.TabIndex = 6
        Me.SB_Refresh.Text = "Refresh"
        '
        'Sp_T_Opname_GetDataGridControl
        '
        Me.Sp_T_Opname_GetDataGridControl.DataSource = Me.Sp_T_Opname_GetDataBindingSource
        Me.Sp_T_Opname_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Sp_T_Opname_GetDataGridControl.Location = New System.Drawing.Point(16, 128)
        Me.Sp_T_Opname_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_T_Opname_GetDataGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sp_T_Opname_GetDataGridControl.Name = "Sp_T_Opname_GetDataGridControl"
        Me.Sp_T_Opname_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_LUE_Inv})
        Me.Sp_T_Opname_GetDataGridControl.Size = New System.Drawing.Size(743, 423)
        Me.Sp_T_Opname_GetDataGridControl.TabIndex = 1
        Me.Sp_T_Opname_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'Sp_T_Opname_GetDataBindingSource
        '
        Me.Sp_T_Opname_GetDataBindingSource.DataMember = "sp_T_Opname_GetData"
        Me.Sp_T_Opname_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Detail
        '
        Me.GV_Detail.Appearance.Row.Font = New System.Drawing.Font("Lato", 11.0!)
        Me.GV_Detail.Appearance.Row.Options.UseFont = True
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNoTransaction, Me.colBarcode, Me.colInventoryID, Me.colQty, Me.colDescription, Me.colModifiedUser, Me.colInventoryNo, Me.colPrice})
        Me.GV_Detail.DetailHeight = 416
        Me.GV_Detail.GridControl = Me.Sp_T_Opname_GetDataGridControl
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Detail.OptionsView.ShowFooter = True
        Me.GV_Detail.OptionsView.ShowGroupPanel = False
        Me.GV_Detail.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 26
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.Width = 97
        '
        'colNoTransaction
        '
        Me.colNoTransaction.Caption = "#No"
        Me.colNoTransaction.FieldName = "NoTransaction"
        Me.colNoTransaction.MinWidth = 26
        Me.colNoTransaction.Name = "colNoTransaction"
        Me.colNoTransaction.OptionsColumn.AllowEdit = False
        Me.colNoTransaction.OptionsColumn.AllowFocus = False
        Me.colNoTransaction.OptionsFilter.AllowFilter = False
        Me.colNoTransaction.Width = 42
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.MinWidth = 26
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.OptionsColumn.AllowEdit = False
        Me.colBarcode.OptionsColumn.AllowFocus = False
        Me.colBarcode.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Barcode", "{0} Jenis")})
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 0
        Me.colBarcode.Width = 178
        '
        'colInventoryID
        '
        Me.colInventoryID.Caption = "Nama Barang"
        Me.colInventoryID.ColumnEdit = Me.Repo_LUE_Inv
        Me.colInventoryID.FieldName = "InventoryID"
        Me.colInventoryID.MinWidth = 26
        Me.colInventoryID.Name = "colInventoryID"
        Me.colInventoryID.OptionsColumn.AllowEdit = False
        Me.colInventoryID.OptionsColumn.AllowFocus = False
        Me.colInventoryID.Visible = True
        Me.colInventoryID.VisibleIndex = 2
        Me.colInventoryID.Width = 168
        '
        'Repo_LUE_Inv
        '
        Me.Repo_LUE_Inv.AutoHeight = False
        Me.Repo_LUE_Inv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Inv.DataSource = Me.Sp_MDInventory_GetDataBindingSource
        Me.Repo_LUE_Inv.DisplayMember = "InventoryName"
        Me.Repo_LUE_Inv.Name = "Repo_LUE_Inv"
        Me.Repo_LUE_Inv.ValueMember = "ID"
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.MaxWidth = 64
        Me.colQty.MinWidth = 64
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsFilter.AllowFilter = False
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "Total = {0:n0} barang")})
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 3
        Me.colQty.Width = 64
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 26
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 4
        Me.colDescription.Width = 153
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 26
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.Width = 97
        '
        'colInventoryNo
        '
        Me.colInventoryNo.Caption = "No. Inventory"
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MinWidth = 26
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsColumn.AllowEdit = False
        Me.colInventoryNo.OptionsColumn.AllowFocus = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 1
        Me.colInventoryNo.Width = 92
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MinWidth = 26
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 5
        Me.colPrice.Width = 97
        '
        'Ed_Barcode
        '
        Me.Ed_Barcode.Location = New System.Drawing.Point(186, 88)
        Me.Ed_Barcode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_Barcode.Name = "Ed_Barcode"
        Me.Ed_Barcode.Properties.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Ed_Barcode.Properties.Appearance.Options.UseBackColor = True
        Me.Ed_Barcode.Size = New System.Drawing.Size(203, 30)
        Me.Ed_Barcode.StyleController = Me.LayoutControl1
        Me.Ed_Barcode.TabIndex = 5
        '
        'Ed_NoTransaksi
        '
        Me.Ed_NoTransaksi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_NoTransaksi.Location = New System.Drawing.Point(245, 52)
        Me.Ed_NoTransaksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_NoTransaksi.Name = "Ed_NoTransaksi"
        Me.Ed_NoTransaksi.Size = New System.Drawing.Size(272, 30)
        Me.Ed_NoTransaksi.StyleController = Me.LayoutControl1
        Me.Ed_NoTransaksi.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem20, Me.EmptySpaceItem2, Me.LayoutControlItem5, Me.LayoutControlItem21, Me.LayoutControlItem18, Me.EmptySpaceItem5, Me.LayoutControlItem22, Me.LayoutControlItem19})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1107, 567)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(749, 112)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(332, 429)
        Me.LayoutControlGroup2.Text = ".:: Detail ::."
        Me.LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Ed_InvName_Input
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 180)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem8.Text = "Inv Name :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SB_Submit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 324)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(300, 34)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Ed_InvNo_Input
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem7.Text = "Inv No. :"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Ed_BarcodeInput
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem9.Text = "Barcode :"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(101, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 358)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(300, 0)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(300, 12)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(300, 12)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.LookUpEdit1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem10.Text = "Brand :"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(101, 16)
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.LookUpEdit2
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem11.Text = "Category :"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(101, 16)
        Me.LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.LookUpEdit3
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 108)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem12.Text = "Satuan :"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(101, 16)
        Me.LayoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.MemoEdit1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 288)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem13.Text = "Desc :"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Ed_Qty
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem14.Text = "Qty :"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Ed_KodeHarga
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(300, 36)
        Me.LayoutControlItem15.Text = "Kode Harga :"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Sp_T_Opname_GetDataGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 112)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(749, 429)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Ed_NoTransaksi
        Me.LayoutControlItem1.Location = New System.Drawing.Point(112, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(395, 36)
        Me.LayoutControlItem1.Text = "No. Transaksi :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.CB_Warehouse
        Me.LayoutControlItem16.Location = New System.Drawing.Point(507, 36)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(219, 31)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(219, 31)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(219, 36)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "Gudang :"
        Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(51, 16)
        Me.LayoutControlItem16.TextToControlDistance = 5
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SB_NewOpname
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(112, 31)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(112, 31)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(112, 72)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SB_Refresh
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(112, 36)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(112, 36)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(112, 40)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Ed_Barcode
        Me.LayoutControlItem2.Location = New System.Drawing.Point(112, 72)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(267, 40)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(267, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(267, 40)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Barcode :"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 16)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.SLE_NamaBarang
        Me.LayoutControlItem19.Location = New System.Drawing.Point(379, 72)
        Me.LayoutControlItem19.MaxSize = New System.Drawing.Size(367, 40)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(367, 40)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(367, 40)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Nama Barang :"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(101, 16)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.SB_Input
        Me.LayoutControlItem20.Location = New System.Drawing.Point(746, 72)
        Me.LayoutControlItem20.MaxSize = New System.Drawing.Size(88, 36)
        Me.LayoutControlItem20.MinSize = New System.Drawing.Size(88, 36)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(88, 40)
        Me.LayoutControlItem20.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(834, 72)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(48, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SB_Print
        Me.LayoutControlItem5.Location = New System.Drawing.Point(882, 72)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(79, 36)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(79, 36)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(79, 40)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.SB_PrintBarcode
        Me.LayoutControlItem21.Location = New System.Drawing.Point(961, 72)
        Me.LayoutControlItem21.MaxSize = New System.Drawing.Size(120, 36)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(120, 36)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(120, 40)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.SLE_OpnameHistory
        Me.LayoutControlItem18.Location = New System.Drawing.Point(112, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(614, 36)
        Me.LayoutControlItem18.Text = "Opname History :"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(101, 16)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(726, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(235, 72)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.SB_Close
        Me.LayoutControlItem22.Location = New System.Drawing.Point(961, 0)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(120, 36)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(120, 36)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(120, 72)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'Sp_T_Opname_GetDataTableAdapter
        '
        Me.Sp_T_Opname_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetDataTableAdapter
        '
        Me.Sp_MDInventory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvBrand_GetDataTableAdapter
        '
        Me.Sp_MDInvBrand_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvCategory_GetDataTableAdapter
        '
        Me.Sp_MDInvCategory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDUoMGetDataTableAdapter
        '
        Me.Sp_MDUoMGetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDCustomer_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Me.Sp_MDInvBrand_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Me.Sp_MDInvCategory_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Me.Sp_MDInventory_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Me.Sp_T_Opname_GetDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Sp_T_Opname_GetListTableAdapter
        '
        Me.Sp_T_Opname_GetListTableAdapter.ClearBeforeFill = True
        '
        'Frm_InputStock
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_InputStock"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Input Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SLE_NamaBarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SLE_OpnameHistory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpTOpnameGetListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CB_Warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_KodeHarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInvCategoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInvBrandGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_BarcodeInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_InvName_Input.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_InvNo_Input.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_T_Opname_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_T_Opname_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Barcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_NoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Ed_Barcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_T_Opname_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_T_Opname_GetDataBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoTransaction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_LUE_Inv As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Sp_T_Opname_GetDataTableAdapter As DataSetTableAdapters.sp_T_Opname_GetDataTableAdapter
    Friend WithEvents Sp_MDInventory_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_BarcodeInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_InvName_Input As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_InvNo_Input As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpMDUoMGetDataBindingSource As BindingSource
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpMDInvCategoryGetDataBindingSource As BindingSource
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpMDInvBrandGetDataBindingSource As BindingSource
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_MDInvBrand_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter
    Friend WithEvents Sp_MDInvCategory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter
    Friend WithEvents Sp_MDUoMGetDataTableAdapter As DataSetTableAdapters.sp_MDUoMGetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Ed_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_KodeHarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SLE_OpnameHistory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SB_NewOpname As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CB_Warehouse As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Ed_NoTransaksi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SpTOpnameGetListBindingSource As BindingSource
    Friend WithEvents Sp_T_Opname_GetListTableAdapter As DataSetTableAdapters.sp_T_Opname_GetListTableAdapter
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SB_Input As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SLE_NamaBarang As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_PrintBarcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colBarcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoTransaction1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpnameDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SB_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
End Class
