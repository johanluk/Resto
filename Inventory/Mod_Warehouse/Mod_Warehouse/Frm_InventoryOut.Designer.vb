<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InventoryOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InventoryOut))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_RefreshInv = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Report = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Refreh = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_EmployeeName = New DevExpress.XtraEditors.TextEdit()
        Me.DateEdit_Time = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit_Date = New DevExpress.XtraEditors.DateEdit()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.Sp_SPInventoryOut_GetData2GridControl = New DevExpress.XtraGrid.GridControl()
        Me.SpSPInventoryOutGetData2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset = New Mod_Purchase.Dataset()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryQty_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryUOM_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeName_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Sp_SPInventoryOut_GetData1GridControl = New DevExpress.XtraGrid.GridControl()
        Me.SpSPInventoryOutGetData1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryQty_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryUOM_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeName_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ed_QtyInv = New DevExpress.XtraEditors.SpinEdit()
        Me.Ed_BarcodeInventory = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit_Employee = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SpSPGetDataEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit_Employee_View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ed_BarcodeEmployee = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit_Inventory = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SpMDInventoryGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUoMID = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableAdapterManager = New Mod_Purchase.DatasetTableAdapters.TableAdapterManager()
        Me.Sp_MDInventory_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.QueriesTableAdapter = New Mod_Purchase.DatasetTableAdapters.QueriesTableAdapter()
        Me.Sp_SPGetData_EmployeeTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_SPGetData_EmployeeTableAdapter()
        Me.Sp_SPInventoryOut_GetData1TableAdapter1 = New Mod_Purchase.DatasetTableAdapters.sp_SPInventoryOut_GetData1TableAdapter()
        Me.Sp_SPInventoryOut_GetData2TableAdapter1 = New Mod_Purchase.DatasetTableAdapters.sp_SPInventoryOut_GetData2TableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Ed_EmployeeName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit_Time.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit_Time.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPInventoryOut_GetData2GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPInventoryOutGetData2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_SPInventoryOut_GetData1GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPInventoryOutGetData1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_QtyInv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_BarcodeInventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Employee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpSPGetDataEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Employee_View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_BarcodeEmployee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Inventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(1475, 67)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 540)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(4)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1475, 24)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SB_RefreshInv)
        Me.LayoutControl1.Controls.Add(Me.SB_Report)
        Me.LayoutControl1.Controls.Add(Me.SB_Refreh)
        Me.LayoutControl1.Controls.Add(Me.Ed_EmployeeName)
        Me.LayoutControl1.Controls.Add(Me.DateEdit_Time)
        Me.LayoutControl1.Controls.Add(Me.DateEdit_Date)
        Me.LayoutControl1.Controls.Add(Me.SB_Submit)
        Me.LayoutControl1.Controls.Add(Me.Sp_SPInventoryOut_GetData2GridControl)
        Me.LayoutControl1.Controls.Add(Me.Sp_SPInventoryOut_GetData1GridControl)
        Me.LayoutControl1.Controls.Add(Me.Ed_QtyInv)
        Me.LayoutControl1.Controls.Add(Me.Ed_BarcodeInventory)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEdit_Employee)
        Me.LayoutControl1.Controls.Add(Me.Ed_BarcodeEmployee)
        Me.LayoutControl1.Controls.Add(Me.SearchLookUpEdit_Inventory)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 67)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1475, 473)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SB_RefreshInv
        '
        Me.SB_RefreshInv.ImageOptions.Image = CType(resources.GetObject("SB_RefreshInv.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_RefreshInv.Location = New System.Drawing.Point(1317, 73)
        Me.SB_RefreshInv.Name = "SB_RefreshInv"
        Me.SB_RefreshInv.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_RefreshInv.Size = New System.Drawing.Size(30, 22)
        Me.SB_RefreshInv.StyleController = Me.LayoutControl1
        Me.SB_RefreshInv.TabIndex = 20
        '
        'SB_Report
        '
        Me.SB_Report.Location = New System.Drawing.Point(195, 39)
        Me.SB_Report.Name = "SB_Report"
        Me.SB_Report.Size = New System.Drawing.Size(95, 23)
        Me.SB_Report.StyleController = Me.LayoutControl1
        Me.SB_Report.TabIndex = 19
        Me.SB_Report.Text = "Laporan"
        '
        'SB_Refreh
        '
        Me.SB_Refreh.Location = New System.Drawing.Point(195, 12)
        Me.SB_Refreh.Name = "SB_Refreh"
        Me.SB_Refreh.Size = New System.Drawing.Size(95, 23)
        Me.SB_Refreh.StyleController = Me.LayoutControl1
        Me.SB_Refreh.TabIndex = 18
        Me.SB_Refreh.Text = "Refresh Data"
        '
        'Ed_EmployeeName
        '
        Me.Ed_EmployeeName.Location = New System.Drawing.Point(449, 101)
        Me.Ed_EmployeeName.MenuManager = Me.RibbonControl
        Me.Ed_EmployeeName.Name = "Ed_EmployeeName"
        Me.Ed_EmployeeName.Size = New System.Drawing.Size(222, 24)
        Me.Ed_EmployeeName.StyleController = Me.LayoutControl1
        Me.Ed_EmployeeName.TabIndex = 17
        '
        'DateEdit_Time
        '
        Me.DateEdit_Time.EditValue = New Date(2024, 6, 29, 0, 0, 0, 0)
        Me.DateEdit_Time.Location = New System.Drawing.Point(12, 12)
        Me.DateEdit_Time.Margin = New System.Windows.Forms.Padding(4)
        Me.DateEdit_Time.MenuManager = Me.RibbonControl
        Me.DateEdit_Time.Name = "DateEdit_Time"
        Me.DateEdit_Time.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit_Time.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit_Time.Properties.DisplayFormat.FormatString = "hh:mm:ss"
        Me.DateEdit_Time.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit_Time.Properties.MaskSettings.Set("mask", "HH:mm:ss")
        Me.DateEdit_Time.Size = New System.Drawing.Size(179, 24)
        Me.DateEdit_Time.StyleController = Me.LayoutControl1
        Me.DateEdit_Time.TabIndex = 16
        '
        'DateEdit_Date
        '
        Me.DateEdit_Date.EditValue = New Date(2024, 6, 29, 12, 44, 13, 570)
        Me.DateEdit_Date.Location = New System.Drawing.Point(12, 40)
        Me.DateEdit_Date.Margin = New System.Windows.Forms.Padding(4)
        Me.DateEdit_Date.MenuManager = Me.RibbonControl
        Me.DateEdit_Date.Name = "DateEdit_Date"
        Me.DateEdit_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit_Date.Properties.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.DateEdit_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit_Date.Properties.MaskSettings.Set("mask", "dd MMM yyyy")
        Me.DateEdit_Date.Size = New System.Drawing.Size(179, 24)
        Me.DateEdit_Date.StyleController = Me.LayoutControl1
        Me.DateEdit_Date.TabIndex = 15
        '
        'SB_Submit
        '
        Me.SB_Submit.Appearance.Options.UseTextOptions = True
        Me.SB_Submit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.SB_Submit.Location = New System.Drawing.Point(1363, 12)
        Me.SB_Submit.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Submit.MaximumSize = New System.Drawing.Size(100, 125)
        Me.SB_Submit.MinimumSize = New System.Drawing.Size(100, 125)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Submit.Size = New System.Drawing.Size(100, 125)
        Me.SB_Submit.StyleController = Me.LayoutControl1
        Me.SB_Submit.TabIndex = 14
        Me.SB_Submit.Text = "Proses Keluar"
        '
        'Sp_SPInventoryOut_GetData2GridControl
        '
        Me.Sp_SPInventoryOut_GetData2GridControl.DataSource = Me.SpSPInventoryOutGetData2BindingSource
        Me.Sp_SPInventoryOut_GetData2GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Sp_SPInventoryOut_GetData2GridControl.Location = New System.Drawing.Point(751, 141)
        Me.Sp_SPInventoryOut_GetData2GridControl.MainView = Me.GridView2
        Me.Sp_SPInventoryOut_GetData2GridControl.Margin = New System.Windows.Forms.Padding(4)
        Me.Sp_SPInventoryOut_GetData2GridControl.MenuManager = Me.RibbonControl
        Me.Sp_SPInventoryOut_GetData2GridControl.Name = "Sp_SPInventoryOut_GetData2GridControl"
        Me.Sp_SPInventoryOut_GetData2GridControl.Size = New System.Drawing.Size(712, 320)
        Me.Sp_SPInventoryOut_GetData2GridControl.TabIndex = 13
        Me.Sp_SPInventoryOut_GetData2GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'SpSPInventoryOutGetData2BindingSource
        '
        Me.SpSPInventoryOutGetData2BindingSource.DataMember = "sp_SPInventoryOut_GetData2"
        Me.SpSPInventoryOutGetData2BindingSource.DataSource = Me.Dataset
        '
        'Dataset
        '
        Me.Dataset.DataSetName = "Dataset"
        Me.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_2, Me.colInventoryName_2, Me.colInventoryQty_2, Me.colInventoryUOM_2, Me.colEmployeeName_2, Me.colCreatedDate_2})
        Me.GridView2.DetailHeight = 485
        Me.GridView2.GridControl = Me.Sp_SPInventoryOut_GetData2GridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colID_2
        '
        Me.colID_2.FieldName = "ID"
        Me.colID_2.MinWidth = 30
        Me.colID_2.Name = "colID_2"
        Me.colID_2.OptionsColumn.AllowEdit = False
        Me.colID_2.OptionsColumn.AllowFocus = False
        Me.colID_2.Width = 112
        '
        'colInventoryName_2
        '
        Me.colInventoryName_2.Caption = "Nama Barang"
        Me.colInventoryName_2.FieldName = "InventoryName"
        Me.colInventoryName_2.MinWidth = 30
        Me.colInventoryName_2.Name = "colInventoryName_2"
        Me.colInventoryName_2.OptionsColumn.AllowEdit = False
        Me.colInventoryName_2.OptionsColumn.AllowFocus = False
        Me.colInventoryName_2.Visible = True
        Me.colInventoryName_2.VisibleIndex = 0
        Me.colInventoryName_2.Width = 112
        '
        'colInventoryQty_2
        '
        Me.colInventoryQty_2.Caption = "Qty"
        Me.colInventoryQty_2.FieldName = "InventoryQty"
        Me.colInventoryQty_2.MaxWidth = 100
        Me.colInventoryQty_2.MinWidth = 100
        Me.colInventoryQty_2.Name = "colInventoryQty_2"
        Me.colInventoryQty_2.OptionsColumn.AllowEdit = False
        Me.colInventoryQty_2.OptionsColumn.AllowFocus = False
        Me.colInventoryQty_2.Visible = True
        Me.colInventoryQty_2.VisibleIndex = 1
        Me.colInventoryQty_2.Width = 100
        '
        'colInventoryUOM_2
        '
        Me.colInventoryUOM_2.Caption = "Satuan"
        Me.colInventoryUOM_2.FieldName = "InventoryUOM"
        Me.colInventoryUOM_2.MaxWidth = 120
        Me.colInventoryUOM_2.MinWidth = 120
        Me.colInventoryUOM_2.Name = "colInventoryUOM_2"
        Me.colInventoryUOM_2.OptionsColumn.AllowEdit = False
        Me.colInventoryUOM_2.OptionsColumn.AllowFocus = False
        Me.colInventoryUOM_2.OptionsFilter.AllowFilter = False
        Me.colInventoryUOM_2.Visible = True
        Me.colInventoryUOM_2.VisibleIndex = 2
        Me.colInventoryUOM_2.Width = 120
        '
        'colEmployeeName_2
        '
        Me.colEmployeeName_2.Caption = "Karyawan"
        Me.colEmployeeName_2.FieldName = "EmployeeName"
        Me.colEmployeeName_2.MinWidth = 30
        Me.colEmployeeName_2.Name = "colEmployeeName_2"
        Me.colEmployeeName_2.OptionsColumn.AllowEdit = False
        Me.colEmployeeName_2.OptionsColumn.AllowFocus = False
        Me.colEmployeeName_2.Visible = True
        Me.colEmployeeName_2.VisibleIndex = 3
        Me.colEmployeeName_2.Width = 112
        '
        'colCreatedDate_2
        '
        Me.colCreatedDate_2.FieldName = "CreatedDate"
        Me.colCreatedDate_2.MinWidth = 30
        Me.colCreatedDate_2.Name = "colCreatedDate_2"
        Me.colCreatedDate_2.OptionsColumn.AllowEdit = False
        Me.colCreatedDate_2.OptionsColumn.AllowFocus = False
        Me.colCreatedDate_2.Width = 112
        '
        'Sp_SPInventoryOut_GetData1GridControl
        '
        Me.Sp_SPInventoryOut_GetData1GridControl.DataSource = Me.SpSPInventoryOutGetData1BindingSource
        Me.Sp_SPInventoryOut_GetData1GridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Sp_SPInventoryOut_GetData1GridControl.Location = New System.Drawing.Point(12, 141)
        Me.Sp_SPInventoryOut_GetData1GridControl.MainView = Me.GridView1
        Me.Sp_SPInventoryOut_GetData1GridControl.Margin = New System.Windows.Forms.Padding(4)
        Me.Sp_SPInventoryOut_GetData1GridControl.MenuManager = Me.RibbonControl
        Me.Sp_SPInventoryOut_GetData1GridControl.Name = "Sp_SPInventoryOut_GetData1GridControl"
        Me.Sp_SPInventoryOut_GetData1GridControl.Size = New System.Drawing.Size(735, 320)
        Me.Sp_SPInventoryOut_GetData1GridControl.TabIndex = 12
        Me.Sp_SPInventoryOut_GetData1GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SpSPInventoryOutGetData1BindingSource
        '
        Me.SpSPInventoryOutGetData1BindingSource.DataMember = "sp_SPInventoryOut_GetData1"
        Me.SpSPInventoryOutGetData1BindingSource.DataSource = Me.Dataset
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_1, Me.colInventoryName_1, Me.colInventoryQty_1, Me.colInventoryUOM_1, Me.colEmployeeName_1, Me.colCreatedDate_1})
        Me.GridView1.DetailHeight = 485
        Me.GridView1.GridControl = Me.Sp_SPInventoryOut_GetData1GridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colID_1
        '
        Me.colID_1.FieldName = "ID"
        Me.colID_1.MinWidth = 30
        Me.colID_1.Name = "colID_1"
        Me.colID_1.OptionsColumn.AllowEdit = False
        Me.colID_1.OptionsColumn.AllowFocus = False
        Me.colID_1.Width = 112
        '
        'colInventoryName_1
        '
        Me.colInventoryName_1.Caption = "Nama Barang"
        Me.colInventoryName_1.FieldName = "InventoryName"
        Me.colInventoryName_1.MinWidth = 30
        Me.colInventoryName_1.Name = "colInventoryName_1"
        Me.colInventoryName_1.OptionsColumn.AllowEdit = False
        Me.colInventoryName_1.OptionsColumn.AllowFocus = False
        Me.colInventoryName_1.Visible = True
        Me.colInventoryName_1.VisibleIndex = 0
        Me.colInventoryName_1.Width = 112
        '
        'colInventoryQty_1
        '
        Me.colInventoryQty_1.Caption = "Qty"
        Me.colInventoryQty_1.FieldName = "InventoryQty"
        Me.colInventoryQty_1.MaxWidth = 100
        Me.colInventoryQty_1.MinWidth = 100
        Me.colInventoryQty_1.Name = "colInventoryQty_1"
        Me.colInventoryQty_1.OptionsColumn.AllowEdit = False
        Me.colInventoryQty_1.OptionsColumn.AllowFocus = False
        Me.colInventoryQty_1.Visible = True
        Me.colInventoryQty_1.VisibleIndex = 1
        Me.colInventoryQty_1.Width = 100
        '
        'colInventoryUOM_1
        '
        Me.colInventoryUOM_1.Caption = "Satuan"
        Me.colInventoryUOM_1.FieldName = "InventoryUOM"
        Me.colInventoryUOM_1.MaxWidth = 120
        Me.colInventoryUOM_1.MinWidth = 120
        Me.colInventoryUOM_1.Name = "colInventoryUOM_1"
        Me.colInventoryUOM_1.OptionsColumn.AllowEdit = False
        Me.colInventoryUOM_1.OptionsColumn.AllowFocus = False
        Me.colInventoryUOM_1.OptionsFilter.AllowFilter = False
        Me.colInventoryUOM_1.Visible = True
        Me.colInventoryUOM_1.VisibleIndex = 2
        Me.colInventoryUOM_1.Width = 120
        '
        'colEmployeeName_1
        '
        Me.colEmployeeName_1.Caption = "Karyawan"
        Me.colEmployeeName_1.FieldName = "EmployeeName"
        Me.colEmployeeName_1.MinWidth = 30
        Me.colEmployeeName_1.Name = "colEmployeeName_1"
        Me.colEmployeeName_1.OptionsColumn.AllowEdit = False
        Me.colEmployeeName_1.OptionsColumn.AllowFocus = False
        Me.colEmployeeName_1.Visible = True
        Me.colEmployeeName_1.VisibleIndex = 3
        Me.colEmployeeName_1.Width = 112
        '
        'colCreatedDate_1
        '
        Me.colCreatedDate_1.FieldName = "CreatedDate"
        Me.colCreatedDate_1.MinWidth = 30
        Me.colCreatedDate_1.Name = "colCreatedDate_1"
        Me.colCreatedDate_1.OptionsColumn.AllowEdit = False
        Me.colCreatedDate_1.OptionsColumn.AllowFocus = False
        Me.colCreatedDate_1.Width = 112
        '
        'Ed_QtyInv
        '
        Me.Ed_QtyInv.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_QtyInv.Location = New System.Drawing.Point(813, 73)
        Me.Ed_QtyInv.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_QtyInv.MenuManager = Me.RibbonControl
        Me.Ed_QtyInv.Name = "Ed_QtyInv"
        Me.Ed_QtyInv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_QtyInv.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_QtyInv.Size = New System.Drawing.Size(72, 24)
        Me.Ed_QtyInv.StyleController = Me.LayoutControl1
        Me.Ed_QtyInv.TabIndex = 9
        '
        'Ed_BarcodeInventory
        '
        Me.Ed_BarcodeInventory.Location = New System.Drawing.Point(813, 45)
        Me.Ed_BarcodeInventory.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_BarcodeInventory.MenuManager = Me.RibbonControl
        Me.Ed_BarcodeInventory.Name = "Ed_BarcodeInventory"
        Me.Ed_BarcodeInventory.Size = New System.Drawing.Size(534, 24)
        Me.Ed_BarcodeInventory.StyleController = Me.LayoutControl1
        Me.Ed_BarcodeInventory.TabIndex = 8
        '
        'SearchLookUpEdit_Employee
        '
        Me.SearchLookUpEdit_Employee.Location = New System.Drawing.Point(449, 73)
        Me.SearchLookUpEdit_Employee.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchLookUpEdit_Employee.MenuManager = Me.RibbonControl
        Me.SearchLookUpEdit_Employee.Name = "SearchLookUpEdit_Employee"
        Me.SearchLookUpEdit_Employee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit_Employee.Properties.DataSource = Me.SpSPGetDataEmployeeBindingSource
        Me.SearchLookUpEdit_Employee.Properties.DisplayMember = "EmployeeNo"
        Me.SearchLookUpEdit_Employee.Properties.NullText = "-- Pilih Karyawan"
        Me.SearchLookUpEdit_Employee.Properties.PopupView = Me.SearchLookUpEdit_Employee_View
        Me.SearchLookUpEdit_Employee.Properties.ValueMember = "EmployeeID"
        Me.SearchLookUpEdit_Employee.Size = New System.Drawing.Size(222, 24)
        Me.SearchLookUpEdit_Employee.StyleController = Me.LayoutControl1
        Me.SearchLookUpEdit_Employee.TabIndex = 7
        '
        'SpSPGetDataEmployeeBindingSource
        '
        Me.SpSPGetDataEmployeeBindingSource.DataMember = "sp_SPGetData_Employee"
        Me.SpSPGetDataEmployeeBindingSource.DataSource = Me.Dataset
        '
        'SearchLookUpEdit_Employee_View
        '
        Me.SearchLookUpEdit_Employee_View.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.SearchLookUpEdit_Employee_View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEmployeeID, Me.colEmployeeNo, Me.colEmployeeName})
        Me.SearchLookUpEdit_Employee_View.DetailHeight = 485
        Me.SearchLookUpEdit_Employee_View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit_Employee_View.Name = "SearchLookUpEdit_Employee_View"
        Me.SearchLookUpEdit_Employee_View.OptionsEditForm.PopupEditFormWidth = 1200
        Me.SearchLookUpEdit_Employee_View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit_Employee_View.OptionsView.ShowGroupPanel = False
        '
        'colEmployeeID
        '
        Me.colEmployeeID.FieldName = "EmployeeID"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.OptionsColumn.AllowEdit = False
        Me.colEmployeeID.OptionsColumn.AllowFocus = False
        '
        'colEmployeeNo
        '
        Me.colEmployeeNo.FieldName = "EmployeeNo"
        Me.colEmployeeNo.Name = "colEmployeeNo"
        Me.colEmployeeNo.OptionsColumn.AllowEdit = False
        Me.colEmployeeNo.OptionsColumn.AllowFocus = False
        '
        'colEmployeeName
        '
        Me.colEmployeeName.FieldName = "EmployeeName"
        Me.colEmployeeName.Name = "colEmployeeName"
        Me.colEmployeeName.OptionsColumn.AllowEdit = False
        Me.colEmployeeName.OptionsColumn.AllowFocus = False
        Me.colEmployeeName.Visible = True
        Me.colEmployeeName.VisibleIndex = 0
        '
        'Ed_BarcodeEmployee
        '
        Me.Ed_BarcodeEmployee.Location = New System.Drawing.Point(449, 45)
        Me.Ed_BarcodeEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_BarcodeEmployee.MenuManager = Me.RibbonControl
        Me.Ed_BarcodeEmployee.Name = "Ed_BarcodeEmployee"
        Me.Ed_BarcodeEmployee.Size = New System.Drawing.Size(222, 24)
        Me.Ed_BarcodeEmployee.StyleController = Me.LayoutControl1
        Me.Ed_BarcodeEmployee.TabIndex = 6
        '
        'SearchLookUpEdit_Inventory
        '
        Me.SearchLookUpEdit_Inventory.Location = New System.Drawing.Point(991, 73)
        Me.SearchLookUpEdit_Inventory.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchLookUpEdit_Inventory.MenuManager = Me.RibbonControl
        Me.SearchLookUpEdit_Inventory.Name = "SearchLookUpEdit_Inventory"
        Me.SearchLookUpEdit_Inventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit_Inventory.Properties.DataSource = Me.SpMDInventoryGetDataBindingSource
        Me.SearchLookUpEdit_Inventory.Properties.DisplayMember = "InventoryName"
        Me.SearchLookUpEdit_Inventory.Properties.NullText = "-- Pilih Barang"
        Me.SearchLookUpEdit_Inventory.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit_Inventory.Properties.ValueMember = "ID"
        Me.SearchLookUpEdit_Inventory.Size = New System.Drawing.Size(322, 24)
        Me.SearchLookUpEdit_Inventory.StyleController = Me.LayoutControl1
        Me.SearchLookUpEdit_Inventory.TabIndex = 5
        '
        'SpMDInventoryGetDataBindingSource
        '
        Me.SpMDInventoryGetDataBindingSource.DataMember = "sp_MDInventory_GetData"
        Me.SpMDInventoryGetDataBindingSource.DataSource = Me.Dataset
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBarcode, Me.colInventoryNo, Me.colInventoryName, Me.colBrandName, Me.colUoMID, Me.colMinStock, Me.colMaxStock, Me.colDescription, Me.colKodeHarga, Me.colHPP, Me.colLastPrice, Me.colStokAwal, Me.colStokAkhir, Me.colPrice, Me.colisActive, Me.colModifiedUser, Me.colModifiedDate})
        Me.SearchLookUpEdit1View.DetailHeight = 485
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 1200
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = True
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.OptionsColumn.AllowEdit = False
        Me.colBarcode.OptionsColumn.AllowFocus = False
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 0
        '
        'colInventoryNo
        '
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsColumn.AllowEdit = False
        Me.colInventoryNo.OptionsColumn.AllowFocus = False
        '
        'colInventoryName
        '
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsColumn.AllowEdit = False
        Me.colInventoryName.OptionsColumn.AllowFocus = False
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 1
        '
        'colBrandName
        '
        Me.colBrandName.FieldName = "BrandName"
        Me.colBrandName.Name = "colBrandName"
        Me.colBrandName.OptionsColumn.AllowEdit = False
        Me.colBrandName.OptionsColumn.AllowFocus = False
        '
        'colUoMID
        '
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.Name = "colUoMID"
        Me.colUoMID.OptionsColumn.AllowEdit = False
        Me.colUoMID.OptionsColumn.AllowFocus = False
        '
        'colMinStock
        '
        Me.colMinStock.FieldName = "MinStock"
        Me.colMinStock.Name = "colMinStock"
        Me.colMinStock.OptionsColumn.AllowEdit = False
        Me.colMinStock.OptionsColumn.AllowFocus = False
        '
        'colMaxStock
        '
        Me.colMaxStock.FieldName = "MaxStock"
        Me.colMaxStock.Name = "colMaxStock"
        Me.colMaxStock.OptionsColumn.AllowEdit = False
        Me.colMaxStock.OptionsColumn.AllowFocus = False
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        '
        'colKodeHarga
        '
        Me.colKodeHarga.FieldName = "KodeHarga"
        Me.colKodeHarga.Name = "colKodeHarga"
        Me.colKodeHarga.OptionsColumn.AllowEdit = False
        Me.colKodeHarga.OptionsColumn.AllowFocus = False
        '
        'colHPP
        '
        Me.colHPP.FieldName = "HPP"
        Me.colHPP.Name = "colHPP"
        Me.colHPP.OptionsColumn.AllowEdit = False
        Me.colHPP.OptionsColumn.AllowFocus = False
        '
        'colLastPrice
        '
        Me.colLastPrice.FieldName = "LastPrice"
        Me.colLastPrice.Name = "colLastPrice"
        Me.colLastPrice.OptionsColumn.AllowEdit = False
        Me.colLastPrice.OptionsColumn.AllowFocus = False
        '
        'colStokAwal
        '
        Me.colStokAwal.FieldName = "StokAwal"
        Me.colStokAwal.Name = "colStokAwal"
        Me.colStokAwal.OptionsColumn.AllowEdit = False
        Me.colStokAwal.OptionsColumn.AllowFocus = False
        '
        'colStokAkhir
        '
        Me.colStokAkhir.FieldName = "StokAkhir"
        Me.colStokAkhir.Name = "colStokAkhir"
        Me.colStokAkhir.OptionsColumn.AllowEdit = False
        Me.colStokAkhir.OptionsColumn.AllowFocus = False
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsColumn.AllowEdit = False
        Me.colPrice.OptionsColumn.AllowFocus = False
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        Me.colisActive.OptionsColumn.AllowEdit = False
        Me.colisActive.OptionsColumn.AllowFocus = False
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.OptionsColumn.AllowEdit = False
        Me.colModifiedDate.OptionsColumn.AllowFocus = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem13, Me.LayoutControlItem12, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1475, 473)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Sp_SPInventoryOut_GetData1GridControl
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 129)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(739, 324)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Sp_SPInventoryOut_GetData2GridControl
        Me.LayoutControlItem10.Location = New System.Drawing.Point(739, 129)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(716, 324)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.DateEdit_Time
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(183, 28)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.DateEdit_Date
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem12.MaxSize = New System.Drawing.Size(183, 33)
        Me.LayoutControlItem12.MinSize = New System.Drawing.Size(183, 33)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(183, 33)
        Me.LayoutControlItem12.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(282, 0)
        Me.EmptySpaceItem2.MaxSize = New System.Drawing.Size(15, 0)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(15, 14)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(15, 129)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(675, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(29, 129)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_Refreh
        Me.LayoutControlItem7.Location = New System.Drawing.Point(183, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(99, 27)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SB_Report
        Me.LayoutControlItem8.Location = New System.Drawing.Point(183, 27)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(99, 34)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SB_Submit
        Me.LayoutControlItem11.Location = New System.Drawing.Point(1351, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(104, 129)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(297, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(378, 129)
        Me.LayoutControlGroup2.Text = ".:: Karyawan ::."
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Ed_BarcodeEmployee
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(354, 28)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(354, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(354, 28)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Barcode :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(116, 18)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SearchLookUpEdit_Employee
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(354, 28)
        Me.LayoutControlItem1.Text = "No Karyawan :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(116, 18)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Ed_EmployeeName
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(354, 28)
        Me.LayoutControlItem6.Text = "Nama Karyawan :"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(116, 18)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem3, Me.LayoutControlItem14})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(704, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(647, 129)
        Me.LayoutControlGroup3.Text = ".:: Barang ::."
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchLookUpEdit_Inventory
        Me.LayoutControlItem2.Location = New System.Drawing.Point(161, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(428, 28)
        Me.LayoutControlItem2.Text = "Nama Barang :"
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(97, 18)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Ed_BarcodeInventory
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(623, 28)
        Me.LayoutControlItem4.Text = "Barcode :"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(80, 18)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Ed_QtyInv
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(161, 28)
        Me.LayoutControlItem5.Text = "Jumlah :"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(80, 18)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 56)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(623, 0)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(623, 10)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(623, 28)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SB_RefreshInv
        Me.LayoutControlItem14.Location = New System.Drawing.Point(589, 28)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(34, 26)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(34, 26)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(34, 28)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 61)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(282, 0)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(282, 10)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(282, 68)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseOrderDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mod_Purchase.DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_MDInventory_GetDataTableAdapter
        '
        Me.Sp_MDInventory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPGetData_EmployeeTableAdapter
        '
        Me.Sp_SPGetData_EmployeeTableAdapter.ClearBeforeFill = True
        '
        'Sp_SPInventoryOut_GetData1TableAdapter1
        '
        Me.Sp_SPInventoryOut_GetData1TableAdapter1.ClearBeforeFill = True
        '
        'Sp_SPInventoryOut_GetData2TableAdapter1
        '
        Me.Sp_SPInventoryOut_GetData2TableAdapter1.ClearBeforeFill = True
        '
        'Frm_InventoryOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 564)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_InventoryOut"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Form Barang Keluar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Ed_EmployeeName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit_Time.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit_Time.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPInventoryOut_GetData2GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPInventoryOutGetData2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_SPInventoryOut_GetData1GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPInventoryOutGetData1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_QtyInv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_BarcodeInventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Employee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpSPGetDataEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Employee_View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_BarcodeEmployee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Inventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Ed_BarcodeEmployee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit_Inventory As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_QtyInv As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Ed_BarcodeInventory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit_Employee As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit_Employee_View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Dataset As Dataset
    Friend WithEvents Sp_SPInventoryOut_GetData1TableAdapter As DatasetTableAdapters.sp_SPInventoryOut_GetData1TableAdapter
    Friend WithEvents TableAdapterManager As DatasetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_SPInventoryOut_GetData1GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryQty_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryUOM_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_SPInventoryOut_GetData2TableAdapter As DatasetTableAdapters.sp_SPInventoryOut_GetData2TableAdapter
    Friend WithEvents Sp_SPInventoryOut_GetData2GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryQty_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryUOM_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DateEdit_Time As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpMDInventoryGetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_GetDataTableAdapter As DatasetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
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
    Friend WithEvents QueriesTableAdapter As DatasetTableAdapters.QueriesTableAdapter
    Friend WithEvents SpSPGetDataEmployeeBindingSource As BindingSource
    Friend WithEvents Sp_SPGetData_EmployeeTableAdapter As DatasetTableAdapters.sp_SPGetData_EmployeeTableAdapter
    Friend WithEvents SpSPInventoryOutGetData1BindingSource As BindingSource
    Friend WithEvents Sp_SPInventoryOut_GetData1TableAdapter1 As DatasetTableAdapters.sp_SPInventoryOut_GetData1TableAdapter
    Friend WithEvents SpSPInventoryOutGetData2BindingSource As BindingSource
    Friend WithEvents Sp_SPInventoryOut_GetData2TableAdapter1 As DatasetTableAdapters.sp_SPInventoryOut_GetData2TableAdapter
    Friend WithEvents Ed_EmployeeName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_RefreshInv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Report As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Refreh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
End Class
