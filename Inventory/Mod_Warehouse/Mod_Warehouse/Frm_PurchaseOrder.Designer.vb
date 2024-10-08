<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PurchaseOrder))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BB_New = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_SPPurchaseOrderParent_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset = New Mod_Purchase.Dataset()
        Me.GV_Parent = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPODate_Parent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrandTotal_Parent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValue_Parent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_NewTransaction = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_Price = New DevExpress.XtraEditors.SpinEdit()
        Me.LUE_Supplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpLookUpDataGetSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ed_Qty = New DevExpress.XtraEditors.SpinEdit()
        Me.Ed_TransactionNo = New DevExpress.XtraEditors.TextEdit()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_New = New DevExpress.XtraEditors.SimpleButton()
        Me.Label_Subtotal = New DevExpress.XtraEditors.LabelControl()
        Me.SpSPPurchaseOrderHeaderGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookUp_Usage = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpLookUpDataGetUsageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ed_Subtotal = New DevExpress.XtraEditors.SpinEdit()
        Me.SB_Search = New DevExpress.XtraEditors.SimpleButton()
        Me.Dt_End = New DevExpress.XtraEditors.DateEdit()
        Me.Dt_Start = New DevExpress.XtraEditors.DateEdit()
        Me.Date_Request = New DevExpress.XtraEditors.DateEdit()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.GC_PODetail = New DevExpress.XtraGrid.GridControl()
        Me.SpSPPurchaseOrderDetailGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOID_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Inv = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpLookUpDataGetInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQty_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUoMID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_UoM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Desc = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Sup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Repo_Des = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GV_Header = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPONo_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPODate_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisVoid_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrandTotal_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsageID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repository_LUE_Usage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LUE_Inv = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_List = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_Detail = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_Header = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_NewTransaction = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Sp_SPPurchaseOrderHeader_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_SPPurchaseOrderHeader_GetDataTableAdapter()
        Me.Sp_SPPurchaseOrderDetail_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_SPPurchaseOrderDetail_GetDataTableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.QueriesTableAdapter = New Mod_Purchase.DatasetTableAdapters.QueriesTableAdapter()
        Me.TableAdapterManager = New Mod_Purchase.DatasetTableAdapters.TableAdapterManager()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Sp_LookUpData_GetUsageTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetUsageTableAdapter()
        Me.Sp_LookUpData_GetSupplierTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetSupplierTableAdapter()
        Me.Sp_LookUpData_GetInventoryTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetInventoryTableAdapter()
        Me.Sp_SPPurchaseOrderParent_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_SPPurchaseOrderParent_GetDataTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Sp_SPPurchaseOrderParent_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPPurchaseOrderParent_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Parent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_Supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_TransactionNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPPurchaseOrderHeaderGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUp_Usage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetUsageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Subtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_Start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Request.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Request.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC_PODetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPPurchaseOrderDetailGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Sup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Des, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repository_LUE_Usage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_Inv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_NewTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BB_New})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 2
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(1120, 72)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BB_New
        '
        Me.BB_New.Caption = "New Form"
        Me.BB_New.Id = 1
        Me.BB_New.Name = "BB_New"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 620)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1120, 33)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Sp_SPPurchaseOrderParent_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.SB_NewTransaction)
        Me.LayoutControl1.Controls.Add(Me.Ed_Price)
        Me.LayoutControl1.Controls.Add(Me.LUE_Supplier)
        Me.LayoutControl1.Controls.Add(Me.Ed_Qty)
        Me.LayoutControl1.Controls.Add(Me.Ed_TransactionNo)
        Me.LayoutControl1.Controls.Add(Me.SB_Back)
        Me.LayoutControl1.Controls.Add(Me.SB_New)
        Me.LayoutControl1.Controls.Add(Me.Label_Subtotal)
        Me.LayoutControl1.Controls.Add(Me.LookUp_Usage)
        Me.LayoutControl1.Controls.Add(Me.Ed_Subtotal)
        Me.LayoutControl1.Controls.Add(Me.SB_Search)
        Me.LayoutControl1.Controls.Add(Me.Dt_End)
        Me.LayoutControl1.Controls.Add(Me.Dt_Start)
        Me.LayoutControl1.Controls.Add(Me.Date_Request)
        Me.LayoutControl1.Controls.Add(Me.SB_Submit)
        Me.LayoutControl1.Controls.Add(Me.GC_PODetail)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.LUE_Inv)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1120, 548)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Sp_SPPurchaseOrderParent_GetDataGridControl
        '
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.DataSource = Me.Sp_SPPurchaseOrderParent_GetDataBindingSource
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.Location = New System.Drawing.Point(24, 71)
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.MainView = Me.GV_Parent
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.Margin = New System.Windows.Forms.Padding(2)
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.Name = "Sp_SPPurchaseOrderParent_GetDataGridControl"
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.Size = New System.Drawing.Size(310, 244)
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.TabIndex = 27
        Me.Sp_SPPurchaseOrderParent_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Parent})
        '
        'Sp_SPPurchaseOrderParent_GetDataBindingSource
        '
        Me.Sp_SPPurchaseOrderParent_GetDataBindingSource.DataMember = "sp_SPPurchaseOrderParent_GetData"
        Me.Sp_SPPurchaseOrderParent_GetDataBindingSource.DataSource = Me.Dataset
        '
        'Dataset
        '
        Me.Dataset.DataSetName = "Dataset"
        Me.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_Parent
        '
        Me.GV_Parent.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPODate_Parent, Me.colGrandTotal_Parent, Me.colValue_Parent})
        Me.GV_Parent.DetailHeight = 253
        Me.GV_Parent.GridControl = Me.Sp_SPPurchaseOrderParent_GetDataGridControl
        Me.GV_Parent.Name = "GV_Parent"
        Me.GV_Parent.OptionsEditForm.PopupEditFormWidth = 533
        '
        'colPODate_Parent
        '
        Me.colPODate_Parent.Caption = "Tanggal Request"
        Me.colPODate_Parent.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colPODate_Parent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPODate_Parent.FieldName = "PODate"
        Me.colPODate_Parent.MinWidth = 13
        Me.colPODate_Parent.Name = "colPODate_Parent"
        Me.colPODate_Parent.OptionsColumn.AllowEdit = False
        Me.colPODate_Parent.OptionsColumn.AllowFocus = False
        Me.colPODate_Parent.OptionsFilter.AllowFilter = False
        Me.colPODate_Parent.Visible = True
        Me.colPODate_Parent.VisibleIndex = 0
        Me.colPODate_Parent.Width = 50
        '
        'colGrandTotal_Parent
        '
        Me.colGrandTotal_Parent.Caption = "Total Keperluan"
        Me.colGrandTotal_Parent.DisplayFormat.FormatString = "n0"
        Me.colGrandTotal_Parent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrandTotal_Parent.FieldName = "GrandTotal"
        Me.colGrandTotal_Parent.MinWidth = 13
        Me.colGrandTotal_Parent.Name = "colGrandTotal_Parent"
        Me.colGrandTotal_Parent.OptionsColumn.AllowEdit = False
        Me.colGrandTotal_Parent.OptionsColumn.AllowFocus = False
        Me.colGrandTotal_Parent.OptionsFilter.AllowFilter = False
        Me.colGrandTotal_Parent.Visible = True
        Me.colGrandTotal_Parent.VisibleIndex = 1
        Me.colGrandTotal_Parent.Width = 50
        '
        'colValue_Parent
        '
        Me.colValue_Parent.Caption = "Tunai Masuk"
        Me.colValue_Parent.DisplayFormat.FormatString = "n0"
        Me.colValue_Parent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValue_Parent.FieldName = "Value"
        Me.colValue_Parent.MinWidth = 13
        Me.colValue_Parent.Name = "colValue_Parent"
        Me.colValue_Parent.OptionsColumn.AllowEdit = False
        Me.colValue_Parent.OptionsColumn.AllowFocus = False
        Me.colValue_Parent.OptionsFilter.AllowFilter = False
        Me.colValue_Parent.Visible = True
        Me.colValue_Parent.VisibleIndex = 2
        Me.colValue_Parent.Width = 50
        '
        'SB_NewTransaction
        '
        Me.SB_NewTransaction.ImageOptions.Image = CType(resources.GetObject("SB_NewTransaction.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_NewTransaction.Location = New System.Drawing.Point(839, 134)
        Me.SB_NewTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.SB_NewTransaction.Name = "SB_NewTransaction"
        Me.SB_NewTransaction.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_NewTransaction.Size = New System.Drawing.Size(192, 36)
        Me.SB_NewTransaction.StyleController = Me.LayoutControl1
        Me.SB_NewTransaction.TabIndex = 27
        Me.SB_NewTransaction.Text = "Barang Baru"
        '
        'Ed_Price
        '
        Me.Ed_Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_Price.Location = New System.Drawing.Point(983, 104)
        Me.Ed_Price.Margin = New System.Windows.Forms.Padding(2)
        Me.Ed_Price.MenuManager = Me.RibbonControl
        Me.Ed_Price.Name = "Ed_Price"
        Me.Ed_Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_Price.Size = New System.Drawing.Size(113, 26)
        Me.Ed_Price.StyleController = Me.LayoutControl1
        Me.Ed_Price.TabIndex = 26
        '
        'LUE_Supplier
        '
        Me.LUE_Supplier.Location = New System.Drawing.Point(747, 44)
        Me.LUE_Supplier.Margin = New System.Windows.Forms.Padding(2)
        Me.LUE_Supplier.MenuManager = Me.RibbonControl
        Me.LUE_Supplier.Name = "LUE_Supplier"
        Me.LUE_Supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_Supplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Nama Supplier", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LUE_Supplier.Properties.DataSource = Me.SpLookUpDataGetSupplierBindingSource
        Me.LUE_Supplier.Properties.DisplayMember = "SupplierName"
        Me.LUE_Supplier.Properties.ValueMember = "ID"
        Me.LUE_Supplier.Size = New System.Drawing.Size(349, 26)
        Me.LUE_Supplier.StyleController = Me.LayoutControl1
        Me.LUE_Supplier.TabIndex = 25
        '
        'SpLookUpDataGetSupplierBindingSource
        '
        Me.SpLookUpDataGetSupplierBindingSource.DataMember = "sp_LookUpData_GetSupplier"
        Me.SpLookUpDataGetSupplierBindingSource.DataSource = Me.Dataset
        '
        'Ed_Qty
        '
        Me.Ed_Qty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_Qty.Location = New System.Drawing.Point(747, 104)
        Me.Ed_Qty.Margin = New System.Windows.Forms.Padding(2)
        Me.Ed_Qty.MenuManager = Me.RibbonControl
        Me.Ed_Qty.Name = "Ed_Qty"
        Me.Ed_Qty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_Qty.Size = New System.Drawing.Size(125, 26)
        Me.Ed_Qty.StyleController = Me.LayoutControl1
        Me.Ed_Qty.TabIndex = 24
        '
        'Ed_TransactionNo
        '
        Me.Ed_TransactionNo.Location = New System.Drawing.Point(469, 44)
        Me.Ed_TransactionNo.Margin = New System.Windows.Forms.Padding(2)
        Me.Ed_TransactionNo.MenuManager = Me.RibbonControl
        Me.Ed_TransactionNo.Name = "Ed_TransactionNo"
        Me.Ed_TransactionNo.Size = New System.Drawing.Size(108, 26)
        Me.Ed_TransactionNo.StyleController = Me.LayoutControl1
        Me.Ed_TransactionNo.TabIndex = 21
        '
        'SB_Back
        '
        Me.SB_Back.ImageOptions.Image = CType(resources.GetObject("SB_Back.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Back.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SB_Back.Location = New System.Drawing.Point(605, 44)
        Me.SB_Back.Margin = New System.Windows.Forms.Padding(2)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Back.Size = New System.Drawing.Size(31, 25)
        Me.SB_Back.StyleController = Me.LayoutControl1
        Me.SB_Back.TabIndex = 19
        '
        'SB_New
        '
        Me.SB_New.Location = New System.Drawing.Point(362, 147)
        Me.SB_New.Margin = New System.Windows.Forms.Padding(2)
        Me.SB_New.Name = "SB_New"
        Me.SB_New.Size = New System.Drawing.Size(215, 23)
        Me.SB_New.StyleController = Me.LayoutControl1
        Me.SB_New.TabIndex = 18
        Me.SB_New.Text = "Transaksi Baru"
        '
        'Label_Subtotal
        '
        Me.Label_Subtotal.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SpSPPurchaseOrderHeaderGetDataBindingSource, "ID", True))
        Me.Label_Subtotal.Location = New System.Drawing.Point(1013, 518)
        Me.Label_Subtotal.Margin = New System.Windows.Forms.Padding(2)
        Me.Label_Subtotal.Name = "Label_Subtotal"
        Me.Label_Subtotal.Size = New System.Drawing.Size(95, 18)
        Me.Label_Subtotal.StyleController = Me.LayoutControl1
        Me.Label_Subtotal.TabIndex = 17
        Me.Label_Subtotal.Text = "LabelControl1"
        '
        'SpSPPurchaseOrderHeaderGetDataBindingSource
        '
        Me.SpSPPurchaseOrderHeaderGetDataBindingSource.DataMember = "sp_SPPurchaseOrderHeader_GetData"
        Me.SpSPPurchaseOrderHeaderGetDataBindingSource.DataSource = Me.Dataset
        '
        'LookUp_Usage
        '
        Me.LookUp_Usage.Location = New System.Drawing.Point(469, 104)
        Me.LookUp_Usage.Margin = New System.Windows.Forms.Padding(2)
        Me.LookUp_Usage.MenuManager = Me.RibbonControl
        Me.LookUp_Usage.Name = "LookUp_Usage"
        Me.LookUp_Usage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUp_Usage.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 17, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UsageName", "Keperluan", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUp_Usage.Properties.DataSource = Me.SpLookUpDataGetUsageBindingSource
        Me.LookUp_Usage.Properties.DisplayMember = "UsageName"
        Me.LookUp_Usage.Properties.NullText = "-- Pilih Keperluan"
        Me.LookUp_Usage.Properties.ValueMember = "ID"
        Me.LookUp_Usage.Size = New System.Drawing.Size(108, 26)
        Me.LookUp_Usage.StyleController = Me.LayoutControl1
        Me.LookUp_Usage.TabIndex = 16
        '
        'SpLookUpDataGetUsageBindingSource
        '
        Me.SpLookUpDataGetUsageBindingSource.DataMember = "sp_LookUpData_GetUsage"
        Me.SpLookUpDataGetUsageBindingSource.DataSource = Me.Dataset
        '
        'Ed_Subtotal
        '
        Me.Ed_Subtotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_Subtotal.Location = New System.Drawing.Point(711, 139)
        Me.Ed_Subtotal.Margin = New System.Windows.Forms.Padding(2)
        Me.Ed_Subtotal.MenuManager = Me.RibbonControl
        Me.Ed_Subtotal.Name = "Ed_Subtotal"
        Me.Ed_Subtotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_Subtotal.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Subtotal.Size = New System.Drawing.Size(125, 26)
        Me.Ed_Subtotal.StyleController = Me.LayoutControl1
        Me.Ed_Subtotal.TabIndex = 15
        '
        'SB_Search
        '
        Me.SB_Search.ImageOptions.Image = CType(resources.GetObject("SB_Search.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Search.Location = New System.Drawing.Point(283, 44)
        Me.SB_Search.Margin = New System.Windows.Forms.Padding(2)
        Me.SB_Search.Name = "SB_Search"
        Me.SB_Search.Size = New System.Drawing.Size(51, 15)
        Me.SB_Search.StyleController = Me.LayoutControl1
        Me.SB_Search.TabIndex = 14
        Me.SB_Search.Text = "Cari"
        '
        'Dt_End
        '
        Me.Dt_End.EditValue = New Date(2024, 8, 21, 20, 35, 50, 651)
        Me.Dt_End.Location = New System.Drawing.Point(196, 44)
        Me.Dt_End.Margin = New System.Windows.Forms.Padding(2)
        Me.Dt_End.MenuManager = Me.RibbonControl
        Me.Dt_End.Name = "Dt_End"
        Me.Dt_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.Dt_End.Properties.UseMaskAsDisplayFormat = True
        Me.Dt_End.Size = New System.Drawing.Size(67, 26)
        Me.Dt_End.StyleController = Me.LayoutControl1
        Me.Dt_End.TabIndex = 13
        '
        'Dt_Start
        '
        Me.Dt_Start.EditValue = New Date(2024, 8, 21, 20, 35, 50, 651)
        Me.Dt_Start.Location = New System.Drawing.Point(99, 44)
        Me.Dt_Start.Margin = New System.Windows.Forms.Padding(2)
        Me.Dt_Start.MenuManager = Me.RibbonControl
        Me.Dt_Start.Name = "Dt_Start"
        Me.Dt_Start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.Dt_Start.Properties.UseMaskAsDisplayFormat = True
        Me.Dt_Start.Size = New System.Drawing.Size(53, 26)
        Me.Dt_Start.StyleController = Me.LayoutControl1
        Me.Dt_Start.TabIndex = 12
        '
        'Date_Request
        '
        Me.Date_Request.EditValue = Nothing
        Me.Date_Request.Location = New System.Drawing.Point(469, 74)
        Me.Date_Request.Margin = New System.Windows.Forms.Padding(2)
        Me.Date_Request.MenuManager = Me.RibbonControl
        Me.Date_Request.Name = "Date_Request"
        Me.Date_Request.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Request.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Request.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.Date_Request.Properties.UseMaskAsDisplayFormat = True
        Me.Date_Request.Size = New System.Drawing.Size(108, 26)
        Me.Date_Request.StyleController = Me.LayoutControl1
        Me.Date_Request.TabIndex = 11
        '
        'SB_Submit
        '
        Me.SB_Submit.ImageOptions.Image = CType(resources.GetObject("SB_Submit.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Submit.Location = New System.Drawing.Point(1035, 134)
        Me.SB_Submit.Margin = New System.Windows.Forms.Padding(2)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Submit.Size = New System.Drawing.Size(61, 28)
        Me.SB_Submit.StyleController = Me.LayoutControl1
        Me.SB_Submit.TabIndex = 10
        Me.SB_Submit.Text = "Submit"
        '
        'GC_PODetail
        '
        Me.GC_PODetail.DataSource = Me.SpSPPurchaseOrderDetailGetDataBindingSource
        Me.GC_PODetail.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GC_PODetail.Location = New System.Drawing.Point(362, 218)
        Me.GC_PODetail.MainView = Me.GV_Detail
        Me.GC_PODetail.MenuManager = Me.RibbonControl
        Me.GC_PODetail.Name = "GC_PODetail"
        Me.GC_PODetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_Num, Me.Repo_Des, Me.Repo_Desc, Me.Repo_LUE_Inv, Me.Repo_LUE_Sup, Me.Repo_LUE_UoM})
        Me.GC_PODetail.Size = New System.Drawing.Size(734, 284)
        Me.GC_PODetail.TabIndex = 5
        Me.GC_PODetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'SpSPPurchaseOrderDetailGetDataBindingSource
        '
        Me.SpSPPurchaseOrderDetailGetDataBindingSource.DataMember = "sp_SPPurchaseOrderDetail_GetData"
        Me.SpSPPurchaseOrderDetailGetDataBindingSource.DataSource = Me.Dataset
        '
        'GV_Detail
        '
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colPOID_Detail, Me.colPONo, Me.colInventoryID, Me.colQty_Detail, Me.colWeight, Me.colUoMID, Me.colPrice, Me.colDisc, Me.colSubtotal_Detail, Me.colDescription, Me.colModifiedUser, Me.colSupplierID})
        Me.GV_Detail.GridControl = Me.GC_PODetail
        Me.GV_Detail.GroupCount = 1
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.NewItemRowText = "Input Barang Baru"
        Me.GV_Detail.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GV_Detail.OptionsEditForm.EditFormColumnCount = 6
        Me.GV_Detail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Detail.OptionsView.ShowIndicator = False
        Me.GV_Detail.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSupplierID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 13
        Me.colID.Name = "colID"
        Me.colID.Width = 50
        '
        'colPOID_Detail
        '
        Me.colPOID_Detail.FieldName = "POID"
        Me.colPOID_Detail.MinWidth = 13
        Me.colPOID_Detail.Name = "colPOID_Detail"
        Me.colPOID_Detail.Width = 50
        '
        'colPONo
        '
        Me.colPONo.FieldName = "PONo"
        Me.colPONo.MinWidth = 13
        Me.colPONo.Name = "colPONo"
        Me.colPONo.Width = 50
        '
        'colInventoryID
        '
        Me.colInventoryID.Caption = "Nama Barang"
        Me.colInventoryID.ColumnEdit = Me.Repo_LUE_Inv
        Me.colInventoryID.FieldName = "InventoryID"
        Me.colInventoryID.MinWidth = 13
        Me.colInventoryID.Name = "colInventoryID"
        Me.colInventoryID.OptionsColumn.AllowEdit = False
        Me.colInventoryID.OptionsColumn.AllowFocus = False
        Me.colInventoryID.OptionsEditForm.Caption = "Barang :"
        Me.colInventoryID.OptionsEditForm.ColumnSpan = 2
        Me.colInventoryID.OptionsFilter.AllowFilter = False
        Me.colInventoryID.Visible = True
        Me.colInventoryID.VisibleIndex = 0
        Me.colInventoryID.Width = 241
        '
        'Repo_LUE_Inv
        '
        Me.Repo_LUE_Inv.AutoHeight = False
        Me.Repo_LUE_Inv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Inv.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryName", "Inventory Name", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_Inv.DataSource = Me.SpLookUpDataGetInventoryBindingSource
        Me.Repo_LUE_Inv.DisplayMember = "InventoryName"
        Me.Repo_LUE_Inv.Name = "Repo_LUE_Inv"
        Me.Repo_LUE_Inv.NullText = "-- Pilih Barang"
        Me.Repo_LUE_Inv.ValueMember = "ID"
        '
        'SpLookUpDataGetInventoryBindingSource
        '
        Me.SpLookUpDataGetInventoryBindingSource.DataMember = "sp_LookUpData_GetInventory"
        Me.SpLookUpDataGetInventoryBindingSource.DataSource = Me.Dataset
        '
        'colQty_Detail
        '
        Me.colQty_Detail.ColumnEdit = Me.Repo_Num
        Me.colQty_Detail.FieldName = "Qty"
        Me.colQty_Detail.MinWidth = 13
        Me.colQty_Detail.Name = "colQty_Detail"
        Me.colQty_Detail.OptionsColumn.AllowEdit = False
        Me.colQty_Detail.OptionsColumn.AllowFocus = False
        Me.colQty_Detail.OptionsEditForm.VisibleIndex = 2
        Me.colQty_Detail.Visible = True
        Me.colQty_Detail.VisibleIndex = 1
        Me.colQty_Detail.Width = 56
        '
        'Repo_Num
        '
        Me.Repo_Num.AutoHeight = False
        Me.Repo_Num.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Repo_Num.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.Repo_Num.MaskSettings.Set("mask", "n0")
        Me.Repo_Num.Name = "Repo_Num"
        Me.Repo_Num.UseMaskAsDisplayFormat = True
        '
        'colWeight
        '
        Me.colWeight.FieldName = "Weight"
        Me.colWeight.MinWidth = 13
        Me.colWeight.Name = "colWeight"
        Me.colWeight.Width = 50
        '
        'colUoMID
        '
        Me.colUoMID.ColumnEdit = Me.Repo_LUE_UoM
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.MinWidth = 13
        Me.colUoMID.Name = "colUoMID"
        Me.colUoMID.Width = 50
        '
        'Repo_LUE_UoM
        '
        Me.Repo_LUE_UoM.AutoHeight = False
        Me.Repo_LUE_UoM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_UoM.Name = "Repo_LUE_UoM"
        '
        'colPrice
        '
        Me.colPrice.ColumnEdit = Me.Repo_Num
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MinWidth = 13
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsColumn.AllowEdit = False
        Me.colPrice.OptionsColumn.AllowFocus = False
        Me.colPrice.OptionsEditForm.Caption = "Harga :"
        Me.colPrice.OptionsEditForm.VisibleIndex = 3
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 2
        Me.colPrice.Width = 56
        '
        'colDisc
        '
        Me.colDisc.FieldName = "Disc"
        Me.colDisc.MinWidth = 13
        Me.colDisc.Name = "colDisc"
        Me.colDisc.Width = 50
        '
        'colSubtotal_Detail
        '
        Me.colSubtotal_Detail.ColumnEdit = Me.Repo_Num
        Me.colSubtotal_Detail.FieldName = "Subtotal"
        Me.colSubtotal_Detail.MinWidth = 13
        Me.colSubtotal_Detail.Name = "colSubtotal_Detail"
        Me.colSubtotal_Detail.OptionsEditForm.RowSpan = 2
        Me.colSubtotal_Detail.OptionsEditForm.UseEditorColRowSpan = False
        Me.colSubtotal_Detail.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSubtotal_Detail.OptionsEditForm.VisibleIndex = 2
        Me.colSubtotal_Detail.OptionsFilter.AllowFilter = False
        Me.colSubtotal_Detail.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "n0")})
        Me.colSubtotal_Detail.Visible = True
        Me.colSubtotal_Detail.VisibleIndex = 3
        Me.colSubtotal_Detail.Width = 255
        '
        'colDescription
        '
        Me.colDescription.Caption = "Pembelanjaan"
        Me.colDescription.ColumnEdit = Me.Repo_Desc
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 13
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsEditForm.ColumnSpan = 3
        Me.colDescription.OptionsEditForm.RowSpan = 5
        Me.colDescription.OptionsEditForm.UseEditorColRowSpan = False
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Width = 841
        '
        'Repo_Desc
        '
        Me.Repo_Desc.Name = "Repo_Desc"
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 13
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.Width = 50
        '
        'colSupplierID
        '
        Me.colSupplierID.Caption = "Supplier"
        Me.colSupplierID.ColumnEdit = Me.Repo_LUE_Sup
        Me.colSupplierID.FieldName = "SupplierID"
        Me.colSupplierID.MinWidth = 13
        Me.colSupplierID.Name = "colSupplierID"
        Me.colSupplierID.OptionsEditForm.ColumnSpan = 2
        Me.colSupplierID.OptionsEditForm.VisibleIndex = 1
        Me.colSupplierID.Visible = True
        Me.colSupplierID.VisibleIndex = 3
        Me.colSupplierID.Width = 50
        '
        'Repo_LUE_Sup
        '
        Me.Repo_LUE_Sup.AutoHeight = False
        Me.Repo_LUE_Sup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Sup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SupplierName", "Supplier Name", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_Sup.DataSource = Me.SpLookUpDataGetSupplierBindingSource
        Me.Repo_LUE_Sup.DisplayMember = "SupplierName"
        Me.Repo_LUE_Sup.Name = "Repo_LUE_Sup"
        Me.Repo_LUE_Sup.NullText = "-- Pilih Supplier"
        Me.Repo_LUE_Sup.ValueMember = "ID"
        '
        'Repo_Des
        '
        Me.Repo_Des.AutoHeight = False
        Me.Repo_Des.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Repo_Des.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.Repo_Des.MaskSettings.Set("mask", "n1")
        Me.Repo_Des.Name = "Repo_Des"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SpSPPurchaseOrderHeaderGetDataBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl1.Location = New System.Drawing.Point(24, 319)
        Me.GridControl1.MainView = Me.GV_Header
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repository_LUE_Usage})
        Me.GridControl1.Size = New System.Drawing.Size(310, 205)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Header})
        '
        'GV_Header
        '
        Me.GV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Header, Me.colPONo_Header, Me.colPODate_Header, Me.colisVoid_Header, Me.colDescription_Header, Me.colModifiedUser_Header, Me.colGrandTotal_Header, Me.colUsageID})
        Me.GV_Header.GridControl = Me.GridControl1
        Me.GV_Header.Name = "GV_Header"
        Me.GV_Header.OptionsView.ShowDetailButtons = False
        Me.GV_Header.OptionsView.ShowGroupPanel = False
        Me.GV_Header.OptionsView.ShowIndicator = False
        '
        'colID_Header
        '
        Me.colID_Header.Caption = "No. Request"
        Me.colID_Header.FieldName = "ID"
        Me.colID_Header.Name = "colID_Header"
        Me.colID_Header.OptionsColumn.AllowEdit = False
        Me.colID_Header.OptionsColumn.AllowFocus = False
        Me.colID_Header.Visible = True
        Me.colID_Header.VisibleIndex = 0
        '
        'colPONo_Header
        '
        Me.colPONo_Header.FieldName = "PONo"
        Me.colPONo_Header.Name = "colPONo_Header"
        Me.colPONo_Header.OptionsColumn.AllowEdit = False
        Me.colPONo_Header.OptionsColumn.AllowFocus = False
        Me.colPONo_Header.OptionsFilter.AllowFilter = False
        '
        'colPODate_Header
        '
        Me.colPODate_Header.Caption = "Tgl. Request"
        Me.colPODate_Header.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colPODate_Header.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPODate_Header.FieldName = "PODate"
        Me.colPODate_Header.Name = "colPODate_Header"
        Me.colPODate_Header.OptionsColumn.AllowEdit = False
        Me.colPODate_Header.OptionsColumn.AllowFocus = False
        Me.colPODate_Header.Visible = True
        Me.colPODate_Header.VisibleIndex = 1
        '
        'colisVoid_Header
        '
        Me.colisVoid_Header.FieldName = "isVoid"
        Me.colisVoid_Header.Name = "colisVoid_Header"
        Me.colisVoid_Header.OptionsColumn.AllowEdit = False
        Me.colisVoid_Header.OptionsColumn.AllowFocus = False
        '
        'colDescription_Header
        '
        Me.colDescription_Header.FieldName = "Description"
        Me.colDescription_Header.Name = "colDescription_Header"
        Me.colDescription_Header.OptionsColumn.AllowEdit = False
        Me.colDescription_Header.OptionsColumn.AllowFocus = False
        '
        'colModifiedUser_Header
        '
        Me.colModifiedUser_Header.FieldName = "ModifiedUser"
        Me.colModifiedUser_Header.Name = "colModifiedUser_Header"
        Me.colModifiedUser_Header.OptionsColumn.AllowEdit = False
        Me.colModifiedUser_Header.OptionsColumn.AllowFocus = False
        '
        'colGrandTotal_Header
        '
        Me.colGrandTotal_Header.DisplayFormat.FormatString = "n0"
        Me.colGrandTotal_Header.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrandTotal_Header.FieldName = "GrandTotal"
        Me.colGrandTotal_Header.Name = "colGrandTotal_Header"
        Me.colGrandTotal_Header.OptionsColumn.AllowEdit = False
        Me.colGrandTotal_Header.OptionsColumn.AllowFocus = False
        Me.colGrandTotal_Header.Visible = True
        Me.colGrandTotal_Header.VisibleIndex = 2
        '
        'colUsageID
        '
        Me.colUsageID.Caption = "Keperluan"
        Me.colUsageID.ColumnEdit = Me.Repository_LUE_Usage
        Me.colUsageID.FieldName = "UsageID"
        Me.colUsageID.MinWidth = 13
        Me.colUsageID.Name = "colUsageID"
        Me.colUsageID.OptionsColumn.AllowEdit = False
        Me.colUsageID.OptionsColumn.AllowFocus = False
        Me.colUsageID.OptionsFilter.AllowFilter = False
        Me.colUsageID.Visible = True
        Me.colUsageID.VisibleIndex = 3
        Me.colUsageID.Width = 50
        '
        'Repository_LUE_Usage
        '
        Me.Repository_LUE_Usage.AutoHeight = False
        Me.Repository_LUE_Usage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repository_LUE_Usage.DataSource = Me.SpLookUpDataGetUsageBindingSource
        Me.Repository_LUE_Usage.DisplayMember = "UsageName"
        Me.Repository_LUE_Usage.Name = "Repository_LUE_Usage"
        Me.Repository_LUE_Usage.NullText = "-- Pilih Keperluan"
        Me.Repository_LUE_Usage.ValueMember = "ID"
        '
        'LUE_Inv
        '
        Me.LUE_Inv.Location = New System.Drawing.Point(747, 74)
        Me.LUE_Inv.Margin = New System.Windows.Forms.Padding(2)
        Me.LUE_Inv.MenuManager = Me.RibbonControl
        Me.LUE_Inv.Name = "LUE_Inv"
        Me.LUE_Inv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_Inv.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("InventoryName", "Nama Barang", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LUE_Inv.Properties.DataSource = Me.SpLookUpDataGetInventoryBindingSource
        Me.LUE_Inv.Properties.DisplayMember = "InventoryName"
        Me.LUE_Inv.Properties.ValueMember = "ID"
        Me.LUE_Inv.Size = New System.Drawing.Size(349, 26)
        Me.LUE_Inv.StyleController = Me.LayoutControl1
        Me.LUE_Inv.TabIndex = 23
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem14, Me.LayoutControlGroup2, Me.LCGroup_List, Me.LCGroup_Detail, Me.LCGroup_Header})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1120, 548)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(338, 506)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(663, 22)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Label_Subtotal
        Me.LayoutControlItem14.Location = New System.Drawing.Point(1001, 506)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(99, 22)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem1, Me.LayoutControlItem10, Me.EmptySpaceItem3, Me.LayoutControlItem11, Me.EmptySpaceItem5, Me.LayoutControlItem18})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(338, 528)
        Me.LayoutControlGroup2.Text = "Filter"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Dt_Start
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(132, 20)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(132, 20)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(132, 20)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Tgl. Awal :"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(70, 18)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 275)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(314, 209)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Dt_End
        Me.LayoutControlItem10.Location = New System.Drawing.Point(132, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(111, 20)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(111, 20)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(111, 20)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = " s/d :"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(35, 18)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(243, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(16, 20)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SB_Search
        Me.LayoutControlItem11.Location = New System.Drawing.Point(259, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(55, 19)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(55, 19)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(55, 20)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 20)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(314, 7)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(314, 7)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(314, 7)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.Sp_SPPurchaseOrderParent_GetDataGridControl
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 27)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(314, 248)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LCGroup_List
        '
        Me.LCGroup_List.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LCGroup_List.Location = New System.Drawing.Point(338, 174)
        Me.LCGroup_List.Name = "LCGroup_List"
        Me.LCGroup_List.Size = New System.Drawing.Size(762, 332)
        Me.LCGroup_List.Text = "Daftar Pemesanan"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GC_PODetail
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(738, 288)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LCGroup_Detail
        '
        Me.LCGroup_Detail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.EmptySpaceItem4, Me.LayoutControlItem12, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem16, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem17})
        Me.LCGroup_Detail.Location = New System.Drawing.Point(581, 0)
        Me.LCGroup_Detail.Name = "LCGroup_Detail"
        Me.LCGroup_Detail.Size = New System.Drawing.Size(519, 174)
        Me.LCGroup_Detail.Text = "Detail"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SB_Back
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(35, 29)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(35, 29)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(35, 29)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 29)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(35, 61)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Ed_Subtotal
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 7, 7)
        Me.LayoutControlItem12.Size = New System.Drawing.Size(234, 40)
        Me.LayoutControlItem12.Text = "Nominal :"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(95, 18)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_Submit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(430, 90)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(65, 32)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(65, 32)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(65, 40)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LUE_Inv
        Me.LayoutControlItem5.Location = New System.Drawing.Point(35, 30)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(460, 30)
        Me.LayoutControlItem5.Text = "Pemesanan :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(95, 18)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.LUE_Supplier
        Me.LayoutControlItem16.Location = New System.Drawing.Point(35, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(460, 30)
        Me.LayoutControlItem16.Text = "Supplier :"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(95, 18)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Ed_Qty
        Me.LayoutControlItem6.Location = New System.Drawing.Point(35, 60)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(236, 30)
        Me.LayoutControlItem6.Text = "Jumlah :"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(95, 18)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Ed_Price
        Me.LayoutControlItem3.Location = New System.Drawing.Point(271, 60)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(224, 30)
        Me.LayoutControlItem3.Text = "Harga :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(95, 18)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SB_NewTransaction
        Me.LayoutControlItem17.Location = New System.Drawing.Point(234, 90)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(196, 40)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LCGroup_Header
        '
        Me.LCGroup_Header.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem13, Me.LCItem_NewTransaction, Me.EmptySpaceItem1})
        Me.LCGroup_Header.Location = New System.Drawing.Point(338, 0)
        Me.LCGroup_Header.Name = "LCGroup_Header"
        Me.LCGroup_Header.Size = New System.Drawing.Size(243, 174)
        Me.LCGroup_Header.Text = "Transaksi"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Ed_TransactionNo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(219, 30)
        Me.LayoutControlItem4.Text = "No. Tx :"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(95, 18)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Date_Request
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(219, 30)
        Me.LayoutControlItem8.Text = "Tgl. Request :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(95, 18)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.LookUp_Usage
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(219, 30)
        Me.LayoutControlItem13.Text = "Keperluan :"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(95, 18)
        '
        'LCItem_NewTransaction
        '
        Me.LCItem_NewTransaction.Control = Me.SB_New
        Me.LCItem_NewTransaction.Location = New System.Drawing.Point(0, 103)
        Me.LCItem_NewTransaction.Name = "LCItem_NewTransaction"
        Me.LCItem_NewTransaction.Size = New System.Drawing.Size(219, 27)
        Me.LCItem_NewTransaction.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_NewTransaction.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 90)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(219, 0)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(219, 7)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(219, 13)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'Sp_SPPurchaseOrderHeader_GetDataTableAdapter
        '
        Me.Sp_SPPurchaseOrderHeader_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPPurchaseOrderDetail_GetDataTableAdapter
        '
        Me.Sp_SPPurchaseOrderDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseOrderDetail_GetDataTableAdapter = Me.Sp_SPPurchaseOrderDetail_GetDataTableAdapter
        Me.TableAdapterManager.sp_SPPurchaseReceiveDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mod_Purchase.DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "editdatasource_16x16.png")
        '
        'Sp_LookUpData_GetUsageTableAdapter
        '
        Me.Sp_LookUpData_GetUsageTableAdapter.ClearBeforeFill = True
        '
        'Sp_LookUpData_GetSupplierTableAdapter
        '
        Me.Sp_LookUpData_GetSupplierTableAdapter.ClearBeforeFill = True
        '
        'Sp_LookUpData_GetInventoryTableAdapter
        '
        Me.Sp_LookUpData_GetInventoryTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPPurchaseOrderParent_GetDataTableAdapter
        '
        Me.Sp_SPPurchaseOrderParent_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Frm_PurchaseOrder
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 653)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "Frm_PurchaseOrder"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Form Pemesanan Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Sp_SPPurchaseOrderParent_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPPurchaseOrderParent_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Parent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_Supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_TransactionNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPPurchaseOrderHeaderGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUp_Usage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetUsageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Subtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_Start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Request.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Request.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC_PODetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPPurchaseOrderDetailGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Sup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Des, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repository_LUE_Usage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_Inv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_NewTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GC_PODetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SpSPPurchaseOrderHeaderGetDataBindingSource As BindingSource
    Friend WithEvents Dataset As Dataset
    Friend WithEvents GV_Header As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPONo_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPODate_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisVoid_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrandTotal_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_SPPurchaseOrderHeader_GetDataTableAdapter As DatasetTableAdapters.sp_SPPurchaseOrderHeader_GetDataTableAdapter
    Friend WithEvents SpSPPurchaseOrderDetailGetDataBindingSource As BindingSource
    Friend WithEvents Sp_SPPurchaseOrderDetail_GetDataTableAdapter As DatasetTableAdapters.sp_SPPurchaseOrderDetail_GetDataTableAdapter
    Friend WithEvents BB_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Date_Request As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Search As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Dt_End As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Dt_Start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Repo_Num As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Repo_Des As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents QueriesTableAdapter As DatasetTableAdapters.QueriesTableAdapter
    Friend WithEvents Ed_Subtotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TableAdapterManager As DatasetTableAdapters.TableAdapterManager
    Friend WithEvents LookUp_Usage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label_Subtotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_New As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LCItem_NewTransaction As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LCGroup_List As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LCGroup_Header As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents Ed_TransactionNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colUsageID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repository_LUE_Usage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LCGroup_Detail As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Repo_Desc As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOID_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoMID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpLookUpDataGetUsageBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetUsageTableAdapter As DatasetTableAdapters.sp_LookUpData_GetUsageTableAdapter
    Friend WithEvents Ed_Price As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LUE_Supplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Ed_Qty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpLookUpDataGetSupplierBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetSupplierTableAdapter As DatasetTableAdapters.sp_LookUpData_GetSupplierTableAdapter
    Friend WithEvents SpLookUpDataGetInventoryBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetInventoryTableAdapter As DatasetTableAdapters.sp_LookUpData_GetInventoryTableAdapter
    Friend WithEvents Repo_LUE_Inv As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Repo_LUE_UoM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSupplierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_LUE_Sup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LUE_Inv As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SB_NewTransaction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_SPPurchaseOrderParent_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_SPPurchaseOrderParent_GetDataTableAdapter As DatasetTableAdapters.sp_SPPurchaseOrderParent_GetDataTableAdapter
    Friend WithEvents Sp_SPPurchaseOrderParent_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Parent As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPODate_Parent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrandTotal_Parent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValue_Parent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
End Class
