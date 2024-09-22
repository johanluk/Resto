<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InvListStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InvListStock))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.Label_NamaBarang = New DevExpress.XtraEditors.LabelControl()
        Me.CE_ShowNotOK = New DevExpress.XtraEditors.CheckEdit()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_ShowDetailedReport = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.SpMDInventoryGetDataSyncListDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBulan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTahun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Check = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpMDInventoryGetDataSyncListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Header = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInventoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ButtonSync = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoButton_Sync = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoButton_Detail = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colLastSync = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_MDInventory_GetDataSyncListTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetDataSyncListTableAdapter()
        Me.Sp_MDInventory_GetDataSyncList_DetailTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetDataSyncList_DetailTableAdapter()
        Me.QueriesTableAdapter = New Master_Data.DataSetTableAdapters.QueriesTableAdapter()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.CE_ShowNotOK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetDataSyncListDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetDataSyncListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoButton_Sync, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoButton_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SB_Close)
        Me.LayoutControl1.Controls.Add(Me.Label_NamaBarang)
        Me.LayoutControl1.Controls.Add(Me.CE_ShowNotOK)
        Me.LayoutControl1.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl1.Controls.Add(Me.SB_ShowDetailedReport)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-650, 286, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(994, 444)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SB_Close
        '
        Me.SB_Close.ImageOptions.Image = CType(resources.GetObject("SB_Close.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Close.Location = New System.Drawing.Point(568, 12)
        Me.SB_Close.Name = "SB_Close"
        Me.SB_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Close.Size = New System.Drawing.Size(38, 36)
        Me.SB_Close.StyleController = Me.LayoutControl1
        Me.SB_Close.TabIndex = 10
        '
        'Label_NamaBarang
        '
        Me.Label_NamaBarang.Appearance.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NamaBarang.Appearance.Options.UseFont = True
        Me.Label_NamaBarang.Appearance.Options.UseTextOptions = True
        Me.Label_NamaBarang.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Label_NamaBarang.AutoEllipsis = True
        Me.Label_NamaBarang.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_NamaBarang.Location = New System.Drawing.Point(610, 12)
        Me.Label_NamaBarang.MinimumSize = New System.Drawing.Size(0, 50)
        Me.Label_NamaBarang.Name = "Label_NamaBarang"
        Me.Label_NamaBarang.Size = New System.Drawing.Size(372, 50)
        Me.Label_NamaBarang.StyleController = Me.LayoutControl1
        Me.Label_NamaBarang.TabIndex = 9
        Me.Label_NamaBarang.Text = " "
        '
        'CE_ShowNotOK
        '
        Me.CE_ShowNotOK.Location = New System.Drawing.Point(57, 18)
        Me.CE_ShowNotOK.Name = "CE_ShowNotOK"
        Me.CE_ShowNotOK.Properties.Caption = "Tampilkan Stok Tidak Sama"
        Me.CE_ShowNotOK.Size = New System.Drawing.Size(344, 22)
        Me.CE_ShowNotOK.StyleController = Me.LayoutControl1
        Me.CE_ShowNotOK.TabIndex = 8
        '
        'SB_Refresh
        '
        Me.SB_Refresh.ImageOptions.Image = CType(resources.GetObject("SB_Refresh.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Refresh.Location = New System.Drawing.Point(12, 12)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Refresh.Size = New System.Drawing.Size(38, 36)
        Me.SB_Refresh.StyleController = Me.LayoutControl1
        Me.SB_Refresh.TabIndex = 7
        '
        'SB_ShowDetailedReport
        '
        Me.SB_ShowDetailedReport.ImageOptions.Image = CType(resources.GetObject("SB_ShowDetailedReport.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_ShowDetailedReport.Location = New System.Drawing.Point(610, 66)
        Me.SB_ShowDetailedReport.MinimumSize = New System.Drawing.Size(0, 40)
        Me.SB_ShowDetailedReport.Name = "SB_ShowDetailedReport"
        Me.SB_ShowDetailedReport.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_ShowDetailedReport.Size = New System.Drawing.Size(372, 40)
        Me.SB_ShowDetailedReport.StyleController = Me.LayoutControl1
        Me.SB_ShowDetailedReport.TabIndex = 6
        Me.SB_ShowDetailedReport.Text = "Laporan Detail"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.SpMDInventoryGetDataSyncListDetailBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(610, 110)
        Me.GridControl2.MainView = Me.GV_Detail
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_Check})
        Me.GridControl2.Size = New System.Drawing.Size(372, 322)
        Me.GridControl2.TabIndex = 5
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'SpMDInventoryGetDataSyncListDetailBindingSource
        '
        Me.SpMDInventoryGetDataSyncListDetailBindingSource.DataMember = "sp_MDInventory_GetDataSyncList_Detail"
        Me.SpMDInventoryGetDataSyncListDetailBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_Detail
        '
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBulan, Me.colTahun, Me.colInventoryID1, Me.colInventoryName1, Me.colQtyTransaksi, Me.GridColumn1})
        Me.GV_Detail.GridControl = Me.GridControl2
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Detail.OptionsView.ShowGroupPanel = False
        Me.GV_Detail.OptionsView.ShowIndicator = False
        '
        'colBulan
        '
        Me.colBulan.FieldName = "Bulan"
        Me.colBulan.Name = "colBulan"
        Me.colBulan.OptionsColumn.AllowEdit = False
        Me.colBulan.OptionsColumn.AllowFocus = False
        Me.colBulan.OptionsFilter.AllowFilter = False
        Me.colBulan.Visible = True
        Me.colBulan.VisibleIndex = 1
        Me.colBulan.Width = 113
        '
        'colTahun
        '
        Me.colTahun.FieldName = "Tahun"
        Me.colTahun.Name = "colTahun"
        Me.colTahun.OptionsColumn.AllowEdit = False
        Me.colTahun.OptionsColumn.AllowFocus = False
        Me.colTahun.OptionsFilter.AllowFilter = False
        Me.colTahun.Visible = True
        Me.colTahun.VisibleIndex = 0
        Me.colTahun.Width = 113
        '
        'colInventoryID1
        '
        Me.colInventoryID1.FieldName = "InventoryID"
        Me.colInventoryID1.Name = "colInventoryID1"
        Me.colInventoryID1.OptionsColumn.AllowEdit = False
        Me.colInventoryID1.OptionsColumn.AllowFocus = False
        Me.colInventoryID1.Width = 113
        '
        'colInventoryName1
        '
        Me.colInventoryName1.FieldName = "InventoryName"
        Me.colInventoryName1.Name = "colInventoryName1"
        Me.colInventoryName1.OptionsColumn.AllowEdit = False
        Me.colInventoryName1.OptionsColumn.AllowFocus = False
        Me.colInventoryName1.Width = 113
        '
        'colQtyTransaksi
        '
        Me.colQtyTransaksi.DisplayFormat.FormatString = "n0"
        Me.colQtyTransaksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyTransaksi.FieldName = "QtyTransaksi"
        Me.colQtyTransaksi.Name = "colQtyTransaksi"
        Me.colQtyTransaksi.OptionsColumn.AllowEdit = False
        Me.colQtyTransaksi.OptionsColumn.AllowFocus = False
        Me.colQtyTransaksi.OptionsFilter.AllowFilter = False
        Me.colQtyTransaksi.Visible = True
        Me.colQtyTransaksi.VisibleIndex = 2
        Me.colQtyTransaksi.Width = 121
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = ".::."
        Me.GridColumn1.ColumnEdit = Me.Repo_Check
        Me.GridColumn1.FieldName = "isChecked"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AllowFilter = False
        Me.GridColumn1.Width = 26
        '
        'Repo_Check
        '
        Me.Repo_Check.AutoHeight = False
        Me.Repo_Check.Name = "Repo_Check"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SpMDInventoryGetDataSyncListBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 52)
        Me.GridControl1.MainView = Me.GV_Header
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoButton_Sync, Me.RepoButton_Detail})
        Me.GridControl1.Size = New System.Drawing.Size(594, 380)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Header})
        '
        'SpMDInventoryGetDataSyncListBindingSource
        '
        Me.SpMDInventoryGetDataSyncListBindingSource.DataMember = "sp_MDInventory_GetDataSyncList"
        Me.SpMDInventoryGetDataSyncListBindingSource.DataSource = Me.DataSet
        '
        'GV_Header
        '
        Me.GV_Header.Appearance.HeaderPanel.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GV_Header.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInventoryID, Me.colInventoryName, Me.colStokUpdate, Me.colTotal, Me.colStatus, Me.col_ButtonSync, Me.GridColumn2, Me.colLastSync})
        Me.GV_Header.GridControl = Me.GridControl1
        Me.GV_Header.Name = "GV_Header"
        Me.GV_Header.OptionsFilter.AllowFilterEditor = False
        Me.GV_Header.OptionsFilter.AllowMRUFilterList = False
        Me.GV_Header.OptionsFilter.ShowInHeaderSearchResults = DevExpress.XtraGrid.Views.Grid.ShowInHeaderSearchResultsMode.None
        Me.GV_Header.OptionsFind.AlwaysVisible = True
        Me.GV_Header.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Header.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GV_Header.OptionsView.ShowGroupPanel = False
        Me.GV_Header.OptionsView.ShowIndicator = False
        '
        'colInventoryID
        '
        Me.colInventoryID.FieldName = "InventoryID"
        Me.colInventoryID.Name = "colInventoryID"
        Me.colInventoryID.OptionsColumn.AllowEdit = False
        Me.colInventoryID.OptionsColumn.AllowFocus = False
        Me.colInventoryID.OptionsColumn.ReadOnly = True
        '
        'colInventoryName
        '
        Me.colInventoryName.Caption = "Nama Barang"
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsColumn.AllowEdit = False
        Me.colInventoryName.OptionsColumn.AllowFocus = False
        Me.colInventoryName.OptionsColumn.ReadOnly = True
        Me.colInventoryName.OptionsFilter.AllowFilter = False
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 0
        Me.colInventoryName.Width = 237
        '
        'colStokUpdate
        '
        Me.colStokUpdate.Caption = "Inv. Stok"
        Me.colStokUpdate.DisplayFormat.FormatString = "n0"
        Me.colStokUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStokUpdate.FieldName = "StokUpdate"
        Me.colStokUpdate.Name = "colStokUpdate"
        Me.colStokUpdate.OptionsColumn.AllowEdit = False
        Me.colStokUpdate.OptionsColumn.AllowFocus = False
        Me.colStokUpdate.OptionsColumn.ReadOnly = True
        Me.colStokUpdate.OptionsFilter.AllowFilter = False
        Me.colStokUpdate.Visible = True
        Me.colStokUpdate.VisibleIndex = 1
        Me.colStokUpdate.Width = 94
        '
        'colTotal
        '
        Me.colTotal.Caption = "RT Stok"
        Me.colTotal.DisplayFormat.FormatString = "n0"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.OptionsColumn.AllowFocus = False
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.OptionsFilter.AllowFilter = False
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 2
        Me.colTotal.Width = 74
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.AllowEdit = False
        Me.colStatus.OptionsColumn.AllowFocus = False
        Me.colStatus.OptionsColumn.ReadOnly = True
        Me.colStatus.OptionsFilter.AllowFilter = False
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 3
        Me.colStatus.Width = 87
        '
        'col_ButtonSync
        '
        Me.col_ButtonSync.Caption = "Sync"
        Me.col_ButtonSync.ColumnEdit = Me.RepoButton_Sync
        Me.col_ButtonSync.MaxWidth = 55
        Me.col_ButtonSync.MinWidth = 55
        Me.col_ButtonSync.Name = "col_ButtonSync"
        Me.col_ButtonSync.OptionsFilter.AllowFilter = False
        Me.col_ButtonSync.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.col_ButtonSync.Visible = True
        Me.col_ButtonSync.VisibleIndex = 4
        Me.col_ButtonSync.Width = 55
        '
        'RepoButton_Sync
        '
        Me.RepoButton_Sync.AutoHeight = False
        Me.RepoButton_Sync.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepoButton_Sync.Name = "RepoButton_Sync"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "=>"
        Me.GridColumn2.ColumnEdit = Me.RepoButton_Detail
        Me.GridColumn2.MaxWidth = 40
        Me.GridColumn2.MinWidth = 40
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AllowFilter = False
        Me.GridColumn2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 40
        '
        'RepoButton_Detail
        '
        Me.RepoButton_Detail.AutoHeight = False
        Me.RepoButton_Detail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepoButton_Detail.Name = "RepoButton_Detail"
        '
        'colLastSync
        '
        Me.colLastSync.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colLastSync.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colLastSync.FieldName = "Last Sync"
        Me.colLastSync.MaxWidth = 150
        Me.colLastSync.MinWidth = 150
        Me.colLastSync.Name = "colLastSync"
        Me.colLastSync.OptionsColumn.AllowEdit = False
        Me.colLastSync.OptionsColumn.AllowFocus = False
        Me.colLastSync.Visible = True
        Me.colLastSync.VisibleIndex = 6
        Me.colLastSync.Width = 150
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(994, 444)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(598, 384)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(598, 98)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(376, 326)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SB_Refresh
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(42, 40)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(42, 40)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(42, 40)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SB_ShowDetailedReport
        Me.LayoutControlItem3.Location = New System.Drawing.Point(598, 54)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(376, 44)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(376, 44)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(376, 44)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CE_ShowNotOK
        Me.LayoutControlItem5.Location = New System.Drawing.Point(42, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 2, 8, 2)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(351, 40)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(393, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(163, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Label_NamaBarang
        Me.LayoutControlItem6.Location = New System.Drawing.Point(598, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(376, 54)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_Close
        Me.LayoutControlItem7.Location = New System.Drawing.Point(556, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(42, 40)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(42, 40)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(42, 40)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'Sp_MDInventory_GetDataSyncListTableAdapter
        '
        Me.Sp_MDInventory_GetDataSyncListTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetDataSyncList_DetailTableAdapter
        '
        Me.Sp_MDInventory_GetDataSyncList_DetailTableAdapter.ClearBeforeFill = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(994, 72)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 516)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(994, 33)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Frm_InvListStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 549)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "Frm_InvListStock"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = " Sync Stok dan Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.CE_ShowNotOK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetDataSyncListDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetDataSyncListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoButton_Sync, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoButton_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Header As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataSet As DataSet
    Friend WithEvents SpMDInventoryGetDataSyncListBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_GetDataSyncListTableAdapter As DataSetTableAdapters.sp_MDInventory_GetDataSyncListTableAdapter
    Friend WithEvents colInventoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpMDInventoryGetDataSyncListDetailBindingSource As BindingSource
    Friend WithEvents colBulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTahun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetDataSyncList_DetailTableAdapter As DataSetTableAdapters.sp_MDInventory_GetDataSyncList_DetailTableAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_Check As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_ButtonSync As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoButton_Sync As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoButton_Detail As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SB_ShowDetailedReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label_NamaBarang As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CE_ShowNotOK As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents colLastSync As DevExpress.XtraGrid.Columns.GridColumn
End Class
