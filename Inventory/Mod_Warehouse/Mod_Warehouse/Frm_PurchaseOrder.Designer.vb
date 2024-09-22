<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PurchaseOrder))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BB_New = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Memo_Description = New DevExpress.XtraEditors.MemoEdit()
        Me.Ed_TransactionNo = New DevExpress.XtraEditors.TextEdit()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_New = New DevExpress.XtraEditors.SimpleButton()
        Me.Label_Subtotal = New DevExpress.XtraEditors.LabelControl()
        Me.LookUp_Usage = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpLookUpDataGetUsageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset = New Mod_Purchase.Dataset()
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
        Me.colPOID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPONo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUoMID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal_Detail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Desc = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Des = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpSPPurchaseOrderHeaderGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.LCGroup_List = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_Detail = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
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
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Memo_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_TransactionNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUp_Usage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetUsageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Des, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPPurchaseOrderHeaderGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repository_LUE_Usage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LCGroup_List, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(45, 42, 45, 42)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BB_New})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonControl.MaxItemId = 2
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.OptionsMenuMinWidth = 495
        Me.RibbonControl.Size = New System.Drawing.Size(1516, 67)
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 843)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1516, 24)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Memo_Description)
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
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 67)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1516, 776)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Memo_Description
        '
        Me.Memo_Description.Location = New System.Drawing.Point(1024, 45)
        Me.Memo_Description.MenuManager = Me.RibbonControl
        Me.Memo_Description.Name = "Memo_Description"
        Me.Memo_Description.Size = New System.Drawing.Size(468, 73)
        Me.Memo_Description.StyleController = Me.LayoutControl1
        Me.Memo_Description.TabIndex = 22
        '
        'Ed_TransactionNo
        '
        Me.Ed_TransactionNo.Location = New System.Drawing.Point(620, 45)
        Me.Ed_TransactionNo.MenuManager = Me.RibbonControl
        Me.Ed_TransactionNo.Name = "Ed_TransactionNo"
        Me.Ed_TransactionNo.Size = New System.Drawing.Size(223, 24)
        Me.Ed_TransactionNo.StyleController = Me.LayoutControl1
        Me.Ed_TransactionNo.TabIndex = 21
        '
        'SB_Back
        '
        Me.SB_Back.ImageOptions.Image = CType(resources.GetObject("SB_Back.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Back.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SB_Back.Location = New System.Drawing.Point(871, 45)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Back.Size = New System.Drawing.Size(48, 36)
        Me.SB_Back.StyleController = Me.LayoutControl1
        Me.SB_Back.TabIndex = 19
        '
        'SB_New
        '
        Me.SB_New.Location = New System.Drawing.Point(519, 139)
        Me.SB_New.Name = "SB_New"
        Me.SB_New.Size = New System.Drawing.Size(324, 23)
        Me.SB_New.StyleController = Me.LayoutControl1
        Me.SB_New.TabIndex = 18
        Me.SB_New.Text = "Transaksi Baru"
        '
        'Label_Subtotal
        '
        Me.Label_Subtotal.Location = New System.Drawing.Point(1409, 746)
        Me.Label_Subtotal.Name = "Label_Subtotal"
        Me.Label_Subtotal.Size = New System.Drawing.Size(95, 18)
        Me.Label_Subtotal.StyleController = Me.LayoutControl1
        Me.Label_Subtotal.TabIndex = 17
        Me.Label_Subtotal.Text = "LabelControl1"
        '
        'LookUp_Usage
        '
        Me.LookUp_Usage.Location = New System.Drawing.Point(620, 101)
        Me.LookUp_Usage.MenuManager = Me.RibbonControl
        Me.LookUp_Usage.Name = "LookUp_Usage"
        Me.LookUp_Usage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUp_Usage.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 25, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UsageName", "Keperluan", 93, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUp_Usage.Properties.DataSource = Me.SpLookUpDataGetUsageBindingSource
        Me.LookUp_Usage.Properties.DisplayMember = "UsageName"
        Me.LookUp_Usage.Properties.NullText = "-- Pilih Keperluan"
        Me.LookUp_Usage.Properties.ValueMember = "ID"
        Me.LookUp_Usage.Size = New System.Drawing.Size(223, 24)
        Me.LookUp_Usage.StyleController = Me.LayoutControl1
        Me.LookUp_Usage.TabIndex = 16
        '
        'SpLookUpDataGetUsageBindingSource
        '
        Me.SpLookUpDataGetUsageBindingSource.DataMember = "sp_LookUpData_GetUsage"
        Me.SpLookUpDataGetUsageBindingSource.DataSource = Me.Dataset
        '
        'Dataset
        '
        Me.Dataset.DataSetName = "Dataset"
        Me.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ed_Subtotal
        '
        Me.Ed_Subtotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_Subtotal.Location = New System.Drawing.Point(1024, 130)
        Me.Ed_Subtotal.MenuManager = Me.RibbonControl
        Me.Ed_Subtotal.Name = "Ed_Subtotal"
        Me.Ed_Subtotal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_Subtotal.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Subtotal.Size = New System.Drawing.Size(370, 24)
        Me.Ed_Subtotal.StyleController = Me.LayoutControl1
        Me.Ed_Subtotal.TabIndex = 15
        '
        'SB_Search
        '
        Me.SB_Search.ImageOptions.Image = CType(resources.GetObject("SB_Search.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Search.Location = New System.Drawing.Point(413, 45)
        Me.SB_Search.Name = "SB_Search"
        Me.SB_Search.Size = New System.Drawing.Size(78, 23)
        Me.SB_Search.StyleController = Me.LayoutControl1
        Me.SB_Search.TabIndex = 14
        Me.SB_Search.Text = "Cari"
        '
        'Dt_End
        '
        Me.Dt_End.EditValue = New Date(2024, 8, 21, 20, 35, 50, 651)
        Me.Dt_End.Location = New System.Drawing.Point(258, 45)
        Me.Dt_End.MenuManager = Me.RibbonControl
        Me.Dt_End.Name = "Dt_End"
        Me.Dt_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.Dt_End.Properties.UseMaskAsDisplayFormat = True
        Me.Dt_End.Size = New System.Drawing.Size(126, 24)
        Me.Dt_End.StyleController = Me.LayoutControl1
        Me.Dt_End.TabIndex = 13
        '
        'Dt_Start
        '
        Me.Dt_Start.EditValue = New Date(2024, 8, 21, 20, 35, 50, 651)
        Me.Dt_Start.Location = New System.Drawing.Point(96, 45)
        Me.Dt_Start.MenuManager = Me.RibbonControl
        Me.Dt_Start.Name = "Dt_Start"
        Me.Dt_Start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.Dt_Start.Properties.UseMaskAsDisplayFormat = True
        Me.Dt_Start.Size = New System.Drawing.Size(122, 24)
        Me.Dt_Start.StyleController = Me.LayoutControl1
        Me.Dt_Start.TabIndex = 12
        '
        'Date_Request
        '
        Me.Date_Request.EditValue = Nothing
        Me.Date_Request.Location = New System.Drawing.Point(620, 73)
        Me.Date_Request.MenuManager = Me.RibbonControl
        Me.Date_Request.Name = "Date_Request"
        Me.Date_Request.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Request.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Request.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.Date_Request.Properties.UseMaskAsDisplayFormat = True
        Me.Date_Request.Size = New System.Drawing.Size(223, 24)
        Me.Date_Request.StyleController = Me.LayoutControl1
        Me.Date_Request.TabIndex = 11
        '
        'SB_Submit
        '
        Me.SB_Submit.ImageOptions.Image = CType(resources.GetObject("SB_Submit.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Submit.Location = New System.Drawing.Point(1398, 122)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Submit.Size = New System.Drawing.Size(94, 40)
        Me.SB_Submit.StyleController = Me.LayoutControl1
        Me.SB_Submit.TabIndex = 10
        Me.SB_Submit.Text = "Submit"
        '
        'GC_PODetail
        '
        Me.GC_PODetail.DataSource = Me.SpSPPurchaseOrderDetailGetDataBindingSource
        Me.GC_PODetail.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GC_PODetail.Location = New System.Drawing.Point(519, 211)
        Me.GC_PODetail.MainView = Me.GV_Detail
        Me.GC_PODetail.Margin = New System.Windows.Forms.Padding(4)
        Me.GC_PODetail.MenuManager = Me.RibbonControl
        Me.GC_PODetail.Name = "GC_PODetail"
        Me.GC_PODetail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_Num, Me.Repo_Des, Me.Repo_Desc})
        Me.GC_PODetail.Size = New System.Drawing.Size(973, 519)
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
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colPOID, Me.colPONo, Me.colInventoryID, Me.colQty, Me.colWeight, Me.colUoMID, Me.colPrice, Me.colDisc, Me.colSubtotal_Detail, Me.colDescription, Me.colModifiedUser})
        Me.GV_Detail.DetailHeight = 485
        Me.GV_Detail.GridControl = Me.GC_PODetail
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GV_Detail.OptionsEditForm.EditFormColumnCount = 4
        Me.GV_Detail.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GV_Detail.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colPOID
        '
        Me.colPOID.FieldName = "POID"
        Me.colPOID.Name = "colPOID"
        '
        'colPONo
        '
        Me.colPONo.FieldName = "PONo"
        Me.colPONo.Name = "colPONo"
        '
        'colInventoryID
        '
        Me.colInventoryID.FieldName = "InventoryID"
        Me.colInventoryID.Name = "colInventoryID"
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        '
        'colWeight
        '
        Me.colWeight.FieldName = "Weight"
        Me.colWeight.Name = "colWeight"
        '
        'colUoMID
        '
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.Name = "colUoMID"
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        '
        'colDisc
        '
        Me.colDisc.FieldName = "Disc"
        Me.colDisc.Name = "colDisc"
        '
        'colSubtotal_Detail
        '
        Me.colSubtotal_Detail.ColumnEdit = Me.Repo_Num
        Me.colSubtotal_Detail.FieldName = "Subtotal"
        Me.colSubtotal_Detail.Name = "colSubtotal_Detail"
        Me.colSubtotal_Detail.OptionsEditForm.RowSpan = 2
        Me.colSubtotal_Detail.OptionsEditForm.UseEditorColRowSpan = False
        Me.colSubtotal_Detail.OptionsEditForm.VisibleIndex = 2
        Me.colSubtotal_Detail.OptionsFilter.AllowFilter = False
        Me.colSubtotal_Detail.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "n0")})
        Me.colSubtotal_Detail.Visible = True
        Me.colSubtotal_Detail.VisibleIndex = 1
        Me.colSubtotal_Detail.Width = 335
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
        'colDescription
        '
        Me.colDescription.Caption = "Pembelanjaan"
        Me.colDescription.ColumnEdit = Me.Repo_Desc
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsEditForm.ColumnSpan = 3
        Me.colDescription.OptionsEditForm.RowSpan = 5
        Me.colDescription.OptionsEditForm.UseEditorColRowSpan = False
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 0
        Me.colDescription.Width = 1261
        '
        'Repo_Desc
        '
        Me.Repo_Desc.Name = "Repo_Desc"
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.Name = "colModifiedUser"
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
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Location = New System.Drawing.Point(24, 83)
        Me.GridControl1.MainView = Me.GV_Header
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repository_LUE_Usage})
        Me.GridControl1.Size = New System.Drawing.Size(467, 669)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Header})
        '
        'SpSPPurchaseOrderHeaderGetDataBindingSource
        '
        Me.SpSPPurchaseOrderHeaderGetDataBindingSource.DataMember = "sp_SPPurchaseOrderHeader_GetData"
        Me.SpSPPurchaseOrderHeaderGetDataBindingSource.DataSource = Me.Dataset
        '
        'GV_Header
        '
        Me.GV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Header, Me.colPONo_Header, Me.colPODate_Header, Me.colisVoid_Header, Me.colDescription_Header, Me.colModifiedUser_Header, Me.colGrandTotal_Header, Me.colUsageID})
        Me.GV_Header.DetailHeight = 485
        Me.GV_Header.GridControl = Me.GridControl1
        Me.GV_Header.Name = "GV_Header"
        Me.GV_Header.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GV_Header.OptionsView.ShowDetailButtons = False
        Me.GV_Header.OptionsView.ShowGroupPanel = False
        Me.GV_Header.OptionsView.ShowIndicator = False
        '
        'colID_Header
        '
        Me.colID_Header.Caption = "No. Request"
        Me.colID_Header.FieldName = "ID"
        Me.colID_Header.MinWidth = 30
        Me.colID_Header.Name = "colID_Header"
        Me.colID_Header.OptionsColumn.AllowEdit = False
        Me.colID_Header.OptionsColumn.AllowFocus = False
        Me.colID_Header.Visible = True
        Me.colID_Header.VisibleIndex = 0
        Me.colID_Header.Width = 112
        '
        'colPONo_Header
        '
        Me.colPONo_Header.FieldName = "PONo"
        Me.colPONo_Header.MinWidth = 30
        Me.colPONo_Header.Name = "colPONo_Header"
        Me.colPONo_Header.OptionsColumn.AllowEdit = False
        Me.colPONo_Header.OptionsColumn.AllowFocus = False
        Me.colPONo_Header.OptionsFilter.AllowFilter = False
        Me.colPONo_Header.Width = 112
        '
        'colPODate_Header
        '
        Me.colPODate_Header.Caption = "Tgl. Request"
        Me.colPODate_Header.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colPODate_Header.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPODate_Header.FieldName = "PODate"
        Me.colPODate_Header.MinWidth = 30
        Me.colPODate_Header.Name = "colPODate_Header"
        Me.colPODate_Header.OptionsColumn.AllowEdit = False
        Me.colPODate_Header.OptionsColumn.AllowFocus = False
        Me.colPODate_Header.Visible = True
        Me.colPODate_Header.VisibleIndex = 1
        Me.colPODate_Header.Width = 112
        '
        'colisVoid_Header
        '
        Me.colisVoid_Header.FieldName = "isVoid"
        Me.colisVoid_Header.MinWidth = 30
        Me.colisVoid_Header.Name = "colisVoid_Header"
        Me.colisVoid_Header.OptionsColumn.AllowEdit = False
        Me.colisVoid_Header.OptionsColumn.AllowFocus = False
        Me.colisVoid_Header.Width = 112
        '
        'colDescription_Header
        '
        Me.colDescription_Header.FieldName = "Description"
        Me.colDescription_Header.MinWidth = 30
        Me.colDescription_Header.Name = "colDescription_Header"
        Me.colDescription_Header.OptionsColumn.AllowEdit = False
        Me.colDescription_Header.OptionsColumn.AllowFocus = False
        Me.colDescription_Header.Width = 112
        '
        'colModifiedUser_Header
        '
        Me.colModifiedUser_Header.FieldName = "ModifiedUser"
        Me.colModifiedUser_Header.MinWidth = 30
        Me.colModifiedUser_Header.Name = "colModifiedUser_Header"
        Me.colModifiedUser_Header.OptionsColumn.AllowEdit = False
        Me.colModifiedUser_Header.OptionsColumn.AllowFocus = False
        Me.colModifiedUser_Header.Width = 112
        '
        'colGrandTotal_Header
        '
        Me.colGrandTotal_Header.DisplayFormat.FormatString = "n0"
        Me.colGrandTotal_Header.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrandTotal_Header.FieldName = "GrandTotal"
        Me.colGrandTotal_Header.MinWidth = 30
        Me.colGrandTotal_Header.Name = "colGrandTotal_Header"
        Me.colGrandTotal_Header.OptionsColumn.AllowEdit = False
        Me.colGrandTotal_Header.OptionsColumn.AllowFocus = False
        Me.colGrandTotal_Header.Visible = True
        Me.colGrandTotal_Header.VisibleIndex = 2
        Me.colGrandTotal_Header.Width = 112
        '
        'colUsageID
        '
        Me.colUsageID.Caption = "Keperluan"
        Me.colUsageID.ColumnEdit = Me.Repository_LUE_Usage
        Me.colUsageID.FieldName = "UsageID"
        Me.colUsageID.Name = "colUsageID"
        Me.colUsageID.OptionsColumn.AllowEdit = False
        Me.colUsageID.OptionsColumn.AllowFocus = False
        Me.colUsageID.OptionsFilter.AllowFilter = False
        Me.colUsageID.Visible = True
        Me.colUsageID.VisibleIndex = 3
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
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem14, Me.LayoutControlGroup2, Me.LCGroup_List, Me.LCGroup_Detail, Me.LCGroup_Header})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1516, 776)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(495, 734)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(902, 22)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Label_Subtotal
        Me.LayoutControlItem14.Location = New System.Drawing.Point(1397, 734)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(99, 22)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem1, Me.LayoutControlItem10, Me.EmptySpaceItem3, Me.LayoutControlItem11, Me.EmptySpaceItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(495, 756)
        Me.LayoutControlGroup2.Text = "Filter"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Dt_Start
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(198, 28)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Tgl. Awal :"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(67, 18)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 38)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(471, 673)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Dt_End
        Me.LayoutControlItem10.Location = New System.Drawing.Point(198, 0)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(166, 28)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(166, 28)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(166, 28)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = " s/d :"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(31, 18)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(364, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(25, 28)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SB_Search
        Me.LayoutControlItem11.Location = New System.Drawing.Point(389, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(82, 27)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(82, 27)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(82, 28)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 28)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(471, 10)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(471, 10)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(471, 10)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LCGroup_List
        '
        Me.LCGroup_List.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LCGroup_List.Location = New System.Drawing.Point(495, 166)
        Me.LCGroup_List.Name = "LCGroup_List"
        Me.LCGroup_List.Size = New System.Drawing.Size(1001, 568)
        Me.LCGroup_List.Text = "Daftar Pemesanan"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GC_PODetail
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(977, 523)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LCGroup_Detail
        '
        Me.LCGroup_Detail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem15, Me.LayoutControlItem3, Me.EmptySpaceItem4, Me.LayoutControlItem12, Me.LayoutControlItem7})
        Me.LCGroup_Detail.Location = New System.Drawing.Point(847, 0)
        Me.LCGroup_Detail.Name = "LCGroup_Detail"
        Me.LCGroup_Detail.Size = New System.Drawing.Size(649, 166)
        Me.LCGroup_Detail.Text = "Detail"
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.SB_Back
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem15.MaxSize = New System.Drawing.Size(52, 40)
        Me.LayoutControlItem15.MinSize = New System.Drawing.Size(52, 40)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(52, 40)
        Me.LayoutControlItem15.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Memo_Description
        Me.LayoutControlItem3.Location = New System.Drawing.Point(52, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(573, 77)
        Me.LayoutControlItem3.Text = "Pemesanan :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(89, 18)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 40)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(52, 81)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Ed_Subtotal
        Me.LayoutControlItem12.Location = New System.Drawing.Point(52, 77)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10)
        Me.LayoutControlItem12.Size = New System.Drawing.Size(475, 44)
        Me.LayoutControlItem12.Text = "Nominal :"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(89, 18)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_Submit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(527, 77)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(98, 44)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(98, 44)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(98, 44)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LCGroup_Header
        '
        Me.LCGroup_Header.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem13, Me.LCItem_NewTransaction, Me.EmptySpaceItem1})
        Me.LCGroup_Header.Location = New System.Drawing.Point(495, 0)
        Me.LCGroup_Header.Name = "LCGroup_Header"
        Me.LCGroup_Header.Size = New System.Drawing.Size(352, 166)
        Me.LCGroup_Header.Text = "Transaksi"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Ed_TransactionNo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(328, 28)
        Me.LayoutControlItem4.Text = "No. Tx :"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(89, 18)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Date_Request
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(328, 28)
        Me.LayoutControlItem8.Text = "Tgl. Request :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(89, 18)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.LookUp_Usage
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(328, 28)
        Me.LayoutControlItem13.Text = "Keperluan :"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(89, 18)
        '
        'LCItem_NewTransaction
        '
        Me.LCItem_NewTransaction.Control = Me.SB_New
        Me.LCItem_NewTransaction.Location = New System.Drawing.Point(0, 94)
        Me.LCItem_NewTransaction.Name = "LCItem_NewTransaction"
        Me.LCItem_NewTransaction.Size = New System.Drawing.Size(328, 27)
        Me.LCItem_NewTransaction.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_NewTransaction.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 84)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(328, 0)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(328, 10)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(328, 10)
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
        'Frm_PurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 867)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_PurchaseOrder"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Form Pemesanan Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Memo_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_TransactionNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUp_Usage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetUsageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Des, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPPurchaseOrderHeaderGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repository_LUE_Usage, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LCGroup_List, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Memo_Description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCGroup_Detail As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Repo_Desc As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPONo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoMID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal_Detail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpLookUpDataGetUsageBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetUsageTableAdapter As DatasetTableAdapters.sp_LookUpData_GetUsageTableAdapter
End Class
