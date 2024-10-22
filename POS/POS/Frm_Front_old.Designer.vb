<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Front_old
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Front_old))
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.GV_OrderDetailMemo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_OrderDetailMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDetailID_OrderDetailMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMemo_OrderDetailMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeID_OrderDetailMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser_OrderDetailMemo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Sp_POSOrderDetail_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POSOrderDetail_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New POS.DataSet()
        Me.GV_OrderDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colorderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit_NumValue = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisHold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisProcess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colflag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisVoid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colMenuCategoryName_MenuCategory = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colID_MenuCategory = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuTypeName_MenuType = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colID_MenuType = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LC_Front = New DevExpress.XtraLayout.LayoutControl()
        Me.Panel_Category = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.Sp_POS_MDMenuCategory_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POS_MDMenuCategory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TV_MenuCategory = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colMenuCategoryCode_MenuCategory = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.CB_LargeSet = New DevExpress.XtraEditors.CheckButton()
        Me.Panel_Type = New DevExpress.XtraEditors.PanelControl()
        Me.Sp_POS_MDMenuType_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POS_MDMenuType_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TV_MenuType = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colMenuTypeCode_MenuType = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.Panel_TypeList = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_EmptyMenu = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_AddMemo = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_SearchMenu = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_OpenOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.Bt_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label_TotalValueOrder = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Label_TableName = New DevExpress.XtraEditors.LabelControl()
        Me.Label_OrderNo = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Bt_UnHold = New DevExpress.XtraEditors.SimpleButton()
        Me.Bt_Payment = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Memo = New DevExpress.XtraEditors.SimpleButton()
        Me.Bt_Hold = New DevExpress.XtraEditors.SimpleButton()
        Me.Label_TypeCategory = New DevExpress.XtraEditors.LabelControl()
        Me.Panel_Menu = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_MenuList = New DevExpress.XtraEditors.PanelControl()
        Me.HScrollBar1 = New DevExpress.XtraEditors.HScrollBar()
        Me.FlyoutPanel2 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl2 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.Ed_Keyword = New DevExpress.XtraEditors.TextEdit()
        Me.SB_Search = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_UpdateKeterangan = New DevExpress.XtraEditors.SimpleButton()
        Me.Memo_Keterangan = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_POS_MDMenu_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POS_MDMenu_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Menu = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Menu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuCode_Menu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuName_Menu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice_Menu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscount_Menu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImage_Menu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisMenuLarge_Menu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_POS_MDMenuType_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDMenuType_GetDataTableAdapter()
        Me.TableAdapterManager = New POS.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_POS_MDMenuCategory_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDMenuCategory_GetDataTableAdapter()
        Me.Sp_POS_MDMenu_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDMenu_GetDataTableAdapter()
        Me.Sp_POSOrderDetail_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POSOrderDetail_GetDataTableAdapter()
        Me.QueriesTableAdapter = New POS.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_POSOrderDetailMemo_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POSOrderDetailMemo_GetDataTableAdapter()
        Me.VScrollBar1 = New DevExpress.XtraEditors.VScrollBar()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.QueriesTableAdapter_Report = New POS.DataSet_ReportTableAdapters.QueriesTableAdapter_Report()
        Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl()
        Me.FlyoutPanel3 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl3 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label_MenuName = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FlyoutPanel4 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl4 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.GV_OrderDetailMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POSOrderDetail_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POSOrderDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_OrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit_NumValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Front, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LC_Front.SuspendLayout()
        CType(Me.Panel_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Category.SuspendLayout()
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDMenuCategory_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDMenuCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TV_MenuCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.Panel_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Type.SuspendLayout()
        CType(Me.Sp_POS_MDMenuType_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDMenuType_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TV_MenuType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_TypeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.Panel_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Menu.SuspendLayout()
        CType(Me.Panel_MenuList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel2.SuspendLayout()
        CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.Ed_Keyword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Memo_Keterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDMenu_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDMenu_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl11.SuspendLayout()
        CType(Me.FlyoutPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel3.SuspendLayout()
        CType(Me.FlyoutPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl3.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl4.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GV_OrderDetailMemo
        '
        Me.GV_OrderDetailMemo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_OrderDetailMemo, Me.colOrderDetailID_OrderDetailMemo, Me.colMemo_OrderDetailMemo, Me.colEmployeeID_OrderDetailMemo, Me.colModifiedUser_OrderDetailMemo})
        Me.GV_OrderDetailMemo.GridControl = Me.Sp_POSOrderDetail_GetDataGridControl
        Me.GV_OrderDetailMemo.Name = "GV_OrderDetailMemo"
        Me.GV_OrderDetailMemo.OptionsView.ShowColumnHeaders = False
        Me.GV_OrderDetailMemo.OptionsView.ShowGroupPanel = False
        Me.GV_OrderDetailMemo.OptionsView.ShowIndicator = False
        '
        'colID_OrderDetailMemo
        '
        Me.colID_OrderDetailMemo.FieldName = "ID"
        Me.colID_OrderDetailMemo.Name = "colID_OrderDetailMemo"
        Me.colID_OrderDetailMemo.OptionsColumn.AllowEdit = False
        Me.colID_OrderDetailMemo.OptionsColumn.AllowFocus = False
        Me.colID_OrderDetailMemo.OptionsColumn.ReadOnly = True
        '
        'colOrderDetailID_OrderDetailMemo
        '
        Me.colOrderDetailID_OrderDetailMemo.FieldName = "OrderDetailID"
        Me.colOrderDetailID_OrderDetailMemo.Name = "colOrderDetailID_OrderDetailMemo"
        Me.colOrderDetailID_OrderDetailMemo.OptionsColumn.AllowEdit = False
        Me.colOrderDetailID_OrderDetailMemo.OptionsColumn.AllowFocus = False
        '
        'colMemo_OrderDetailMemo
        '
        Me.colMemo_OrderDetailMemo.FieldName = "Memo"
        Me.colMemo_OrderDetailMemo.Name = "colMemo_OrderDetailMemo"
        Me.colMemo_OrderDetailMemo.OptionsColumn.AllowEdit = False
        Me.colMemo_OrderDetailMemo.OptionsColumn.AllowFocus = False
        Me.colMemo_OrderDetailMemo.Visible = True
        Me.colMemo_OrderDetailMemo.VisibleIndex = 0
        '
        'colEmployeeID_OrderDetailMemo
        '
        Me.colEmployeeID_OrderDetailMemo.FieldName = "EmployeeID"
        Me.colEmployeeID_OrderDetailMemo.Name = "colEmployeeID_OrderDetailMemo"
        Me.colEmployeeID_OrderDetailMemo.OptionsColumn.AllowEdit = False
        Me.colEmployeeID_OrderDetailMemo.OptionsColumn.AllowFocus = False
        '
        'colModifiedUser_OrderDetailMemo
        '
        Me.colModifiedUser_OrderDetailMemo.FieldName = "ModifiedUser"
        Me.colModifiedUser_OrderDetailMemo.Name = "colModifiedUser_OrderDetailMemo"
        Me.colModifiedUser_OrderDetailMemo.OptionsColumn.AllowEdit = False
        Me.colModifiedUser_OrderDetailMemo.OptionsColumn.AllowFocus = False
        '
        'Sp_POSOrderDetail_GetDataGridControl
        '
        Me.Sp_POSOrderDetail_GetDataGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sp_POSOrderDetail_GetDataGridControl.DataSource = Me.Sp_POSOrderDetail_GetDataBindingSource
        Me.Sp_POSOrderDetail_GetDataGridControl.Font = New System.Drawing.Font("Tahoma", 10.0!)
        GridLevelNode1.LevelTemplate = Me.GV_OrderDetailMemo
        GridLevelNode1.RelationName = "sp_POSOrderDetail_GetData_sp_POSOrderDetailMemo_GetData"
        Me.Sp_POSOrderDetail_GetDataGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Sp_POSOrderDetail_GetDataGridControl.Location = New System.Drawing.Point(866, 76)
        Me.Sp_POSOrderDetail_GetDataGridControl.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.Sp_POSOrderDetail_GetDataGridControl.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.Sp_POSOrderDetail_GetDataGridControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Sp_POSOrderDetail_GetDataGridControl.MainView = Me.GV_OrderDetail
        Me.Sp_POSOrderDetail_GetDataGridControl.Name = "Sp_POSOrderDetail_GetDataGridControl"
        Me.Sp_POSOrderDetail_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit_NumValue})
        Me.Sp_POSOrderDetail_GetDataGridControl.Size = New System.Drawing.Size(317, 364)
        Me.Sp_POSOrderDetail_GetDataGridControl.TabIndex = 8
        Me.Sp_POSOrderDetail_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_OrderDetail, Me.LayoutView1, Me.GV_OrderDetailMemo})
        '
        'Sp_POSOrderDetail_GetDataBindingSource
        '
        Me.Sp_POSOrderDetail_GetDataBindingSource.DataMember = "sp_POSOrderDetail_GetData"
        Me.Sp_POSOrderDetail_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_OrderDetail
        '
        Me.GV_OrderDetail.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GV_OrderDetail.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_OrderDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Transparent
        Me.GV_OrderDetail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_OrderDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_OrderDetail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_OrderDetail.Appearance.Row.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.GV_OrderDetail.Appearance.Row.Options.UseFont = True
        Me.GV_OrderDetail.Appearance.Row.Options.UseTextOptions = True
        Me.GV_OrderDetail.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GV_OrderDetail.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GV_OrderDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GV_OrderDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colorderID, Me.colMenuID, Me.colMenuCode, Me.colMenuName, Me.colQty, Me.colPrice, Me.colDiscount, Me.colSubTotal, Me.colEmployeeID, Me.colModifiedUser, Me.colisHold, Me.colisProcess, Me.colflag, Me.colisVoid})
        Me.GV_OrderDetail.GridControl = Me.Sp_POSOrderDetail_GetDataGridControl
        Me.GV_OrderDetail.Name = "GV_OrderDetail"
        Me.GV_OrderDetail.OptionsCustomization.AllowColumnMoving = False
        Me.GV_OrderDetail.OptionsCustomization.AllowColumnResizing = False
        Me.GV_OrderDetail.OptionsCustomization.AllowFilter = False
        Me.GV_OrderDetail.OptionsCustomization.AllowGroup = False
        Me.GV_OrderDetail.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV_OrderDetail.OptionsCustomization.AllowSort = False
        Me.GV_OrderDetail.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GV_OrderDetail.OptionsDetail.EnableDetailToolTip = True
        Me.GV_OrderDetail.OptionsDetail.EnableMasterViewMode = False
        Me.GV_OrderDetail.OptionsDetail.ShowDetailTabs = False
        Me.GV_OrderDetail.OptionsDetail.SmartDetailExpand = False
        Me.GV_OrderDetail.OptionsView.ShowGroupPanel = False
        Me.GV_OrderDetail.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_OrderDetail.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colorderID
        '
        Me.colorderID.FieldName = "orderID"
        Me.colorderID.Name = "colorderID"
        Me.colorderID.OptionsColumn.AllowEdit = False
        Me.colorderID.OptionsColumn.AllowFocus = False
        '
        'colMenuID
        '
        Me.colMenuID.FieldName = "MenuID"
        Me.colMenuID.Name = "colMenuID"
        Me.colMenuID.OptionsColumn.AllowEdit = False
        Me.colMenuID.OptionsColumn.AllowFocus = False
        '
        'colMenuCode
        '
        Me.colMenuCode.FieldName = "MenuCode"
        Me.colMenuCode.Name = "colMenuCode"
        Me.colMenuCode.OptionsColumn.AllowEdit = False
        Me.colMenuCode.OptionsColumn.AllowFocus = False
        '
        'colMenuName
        '
        Me.colMenuName.FieldName = "MenuName"
        Me.colMenuName.Name = "colMenuName"
        Me.colMenuName.OptionsColumn.AllowEdit = False
        Me.colMenuName.OptionsColumn.AllowFocus = False
        Me.colMenuName.Visible = True
        Me.colMenuName.VisibleIndex = 1
        Me.colMenuName.Width = 193
        '
        'colQty
        '
        Me.colQty.AppearanceCell.Options.UseTextOptions = True
        Me.colQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.AppearanceHeader.Options.UseTextOptions = True
        Me.colQty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQty.Caption = "#"
        Me.colQty.DisplayFormat.FormatString = "n0"
        Me.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.OptionsColumn.AllowFocus = False
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 0
        Me.colQty.Width = 45
        '
        'colPrice
        '
        Me.colPrice.AppearanceCell.Options.UseTextOptions = True
        Me.colPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrice.ColumnEdit = Me.RepositoryItemTextEdit_NumValue
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsColumn.AllowEdit = False
        Me.colPrice.OptionsColumn.AllowFocus = False
        Me.colPrice.Width = 293
        '
        'RepositoryItemTextEdit_NumValue
        '
        Me.RepositoryItemTextEdit_NumValue.AutoHeight = False
        Me.RepositoryItemTextEdit_NumValue.Mask.EditMask = "n0"
        Me.RepositoryItemTextEdit_NumValue.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit_NumValue.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit_NumValue.Name = "RepositoryItemTextEdit_NumValue"
        '
        'colDiscount
        '
        Me.colDiscount.FieldName = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.OptionsColumn.AllowEdit = False
        Me.colDiscount.OptionsColumn.AllowFocus = False
        '
        'colSubTotal
        '
        Me.colSubTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colSubTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSubTotal.Caption = "Total"
        Me.colSubTotal.ColumnEdit = Me.RepositoryItemTextEdit_NumValue
        Me.colSubTotal.DisplayFormat.FormatString = "n0"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.OptionsColumn.AllowEdit = False
        Me.colSubTotal.OptionsColumn.AllowFocus = False
        Me.colSubTotal.OptionsColumn.ReadOnly = True
        Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:0.##}")})
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 2
        Me.colSubTotal.Width = 79
        '
        'colEmployeeID
        '
        Me.colEmployeeID.FieldName = "EmployeeID"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.OptionsColumn.AllowEdit = False
        Me.colEmployeeID.OptionsColumn.AllowFocus = False
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        '
        'colisHold
        '
        Me.colisHold.FieldName = "isHold"
        Me.colisHold.Name = "colisHold"
        Me.colisHold.OptionsColumn.AllowEdit = False
        Me.colisHold.OptionsColumn.AllowFocus = False
        '
        'colisProcess
        '
        Me.colisProcess.FieldName = "isProcess"
        Me.colisProcess.Name = "colisProcess"
        Me.colisProcess.OptionsColumn.AllowEdit = False
        Me.colisProcess.OptionsColumn.AllowFocus = False
        Me.colisProcess.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        '
        'colflag
        '
        Me.colflag.AppearanceCell.Options.UseImage = True
        Me.colflag.AppearanceHeader.Options.UseTextOptions = True
        Me.colflag.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colflag.FieldName = "flag"
        Me.colflag.Image = CType(resources.GetObject("colflag.Image"), System.Drawing.Image)
        Me.colflag.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.colflag.Name = "colflag"
        Me.colflag.Width = 42
        '
        'colisVoid
        '
        Me.colisVoid.FieldName = "isVoid"
        Me.colisVoid.Name = "colisVoid"
        Me.colisVoid.OptionsColumn.AllowEdit = False
        Me.colisVoid.OptionsColumn.AllowFocus = False
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.Sp_POSOrderDetail_GetDataGridControl
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Nothing
        '
        'colMenuCategoryName_MenuCategory
        '
        Me.colMenuCategoryName_MenuCategory.FieldName = "MenuCategoryName"
        Me.colMenuCategoryName_MenuCategory.Name = "colMenuCategoryName_MenuCategory"
        Me.colMenuCategoryName_MenuCategory.Visible = True
        Me.colMenuCategoryName_MenuCategory.VisibleIndex = 2
        '
        'colID_MenuCategory
        '
        Me.colID_MenuCategory.FieldName = "ID"
        Me.colID_MenuCategory.Name = "colID_MenuCategory"
        Me.colID_MenuCategory.OptionsColumn.ReadOnly = True
        Me.colID_MenuCategory.Visible = True
        Me.colID_MenuCategory.VisibleIndex = 0
        '
        'colMenuTypeName_MenuType
        '
        Me.colMenuTypeName_MenuType.FieldName = "MenuTypeName"
        Me.colMenuTypeName_MenuType.Name = "colMenuTypeName_MenuType"
        Me.colMenuTypeName_MenuType.Visible = True
        Me.colMenuTypeName_MenuType.VisibleIndex = 1
        '
        'colID_MenuType
        '
        Me.colID_MenuType.FieldName = "ID"
        Me.colID_MenuType.Name = "colID_MenuType"
        Me.colID_MenuType.OptionsColumn.ReadOnly = True
        Me.colID_MenuType.Visible = True
        Me.colID_MenuType.VisibleIndex = 2
        '
        'LC_Front
        '
        Me.LC_Front.BackColor = System.Drawing.Color.Transparent
        Me.LC_Front.Controls.Add(Me.Sp_POSOrderDetail_GetDataGridControl)
        Me.LC_Front.Controls.Add(Me.Panel_Category)
        Me.LC_Front.Controls.Add(Me.Panel_Type)
        Me.LC_Front.Controls.Add(Me.PanelControl4)
        Me.LC_Front.Controls.Add(Me.PanelControl1)
        Me.LC_Front.Controls.Add(Me.PanelControl3)
        Me.LC_Front.Controls.Add(Me.PanelControl2)
        Me.LC_Front.Controls.Add(Me.Label_TypeCategory)
        Me.LC_Front.Controls.Add(Me.Panel_Menu)
        Me.LC_Front.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Front.Location = New System.Drawing.Point(0, 0)
        Me.LC_Front.Name = "LC_Front"
        Me.LC_Front.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(162, 155, 250, 350)
        Me.LC_Front.Root = Me.LayoutControlGroup1
        Me.LC_Front.Size = New System.Drawing.Size(1198, 629)
        Me.LC_Front.TabIndex = 0
        Me.LC_Front.Text = "LayoutControl1"
        '
        'Panel_Category
        '
        Me.Panel_Category.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel_Category.Appearance.Options.UseBackColor = True
        Me.Panel_Category.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_Category.Controls.Add(Me.PanelControl10)
        Me.Panel_Category.Controls.Add(Me.Sp_POS_MDMenuCategory_GetDataGridControl)
        Me.Panel_Category.Controls.Add(Me.PanelControl9)
        Me.Panel_Category.Location = New System.Drawing.Point(148, 499)
        Me.Panel_Category.Name = "Panel_Category"
        Me.Panel_Category.Size = New System.Drawing.Size(708, 115)
        Me.Panel_Category.TabIndex = 28
        '
        'PanelControl10
        '
        Me.PanelControl10.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.PanelControl10.Appearance.Options.UseBackColor = True
        Me.PanelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl10.Location = New System.Drawing.Point(613, 0)
        Me.PanelControl10.Name = "PanelControl10"
        Me.PanelControl10.Size = New System.Drawing.Size(10, 115)
        Me.PanelControl10.TabIndex = 4
        '
        'Sp_POS_MDMenuCategory_GetDataGridControl
        '
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.DataSource = Me.Sp_POS_MDMenuCategory_GetDataBindingSource
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.Location = New System.Drawing.Point(0, 0)
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.MainView = Me.TV_MenuCategory
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.Name = "Sp_POS_MDMenuCategory_GetDataGridControl"
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.Size = New System.Drawing.Size(623, 115)
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.TabIndex = 3
        Me.Sp_POS_MDMenuCategory_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TV_MenuCategory})
        '
        'Sp_POS_MDMenuCategory_GetDataBindingSource
        '
        Me.Sp_POS_MDMenuCategory_GetDataBindingSource.DataMember = "sp_POS_MDMenuCategory_GetData"
        Me.Sp_POS_MDMenuCategory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'TV_MenuCategory
        '
        Me.TV_MenuCategory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_MenuCategory, Me.colMenuCategoryCode_MenuCategory, Me.colMenuCategoryName_MenuCategory})
        Me.TV_MenuCategory.GridControl = Me.Sp_POS_MDMenuCategory_GetDataGridControl
        Me.TV_MenuCategory.Name = "TV_MenuCategory"
        Me.TV_MenuCategory.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TV_MenuCategory.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(8, 8, 8, 0)
        Me.TV_MenuCategory.OptionsTiles.ItemSize = New System.Drawing.Size(125, 45)
        Me.TV_MenuCategory.OptionsTiles.Padding = New System.Windows.Forms.Padding(5)
        Me.TV_MenuCategory.OptionsTiles.RowCount = 2
        Me.TV_MenuCategory.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TV_MenuCategory.OptionsTiles.ShowGroupText = False
        Me.TV_MenuCategory.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
        TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        TileViewItemElement1.Appearance.Normal.Options.UseFont = True
        TileViewItemElement1.Appearance.Normal.Options.UseTextOptions = True
        TileViewItemElement1.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TileViewItemElement1.Column = Me.colMenuCategoryName_MenuCategory
        TileViewItemElement1.Text = "colMenuCategoryName_MenuCategory"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileViewItemElement2.Column = Me.colID_MenuCategory
        TileViewItemElement2.Text = "colID_MenuCategory"
        TileViewItemElement2.TextLocation = New System.Drawing.Point(100, 0)
        Me.TV_MenuCategory.TileTemplate.Add(TileViewItemElement1)
        Me.TV_MenuCategory.TileTemplate.Add(TileViewItemElement2)
        '
        'colMenuCategoryCode_MenuCategory
        '
        Me.colMenuCategoryCode_MenuCategory.FieldName = "MenuCategoryCode"
        Me.colMenuCategoryCode_MenuCategory.Name = "colMenuCategoryCode_MenuCategory"
        Me.colMenuCategoryCode_MenuCategory.Visible = True
        Me.colMenuCategoryCode_MenuCategory.VisibleIndex = 1
        '
        'PanelControl9
        '
        Me.PanelControl9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PanelControl9.Appearance.Options.UseBackColor = True
        Me.PanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl9.Controls.Add(Me.CB_LargeSet)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl9.Location = New System.Drawing.Point(623, 0)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.PanelControl9.Size = New System.Drawing.Size(85, 115)
        Me.PanelControl9.TabIndex = 2
        '
        'CB_LargeSet
        '
        Me.CB_LargeSet.AllowFocus = False
        Me.CB_LargeSet.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.CB_LargeSet.Appearance.Options.UseFont = True
        Me.CB_LargeSet.Appearance.Options.UseTextOptions = True
        Me.CB_LargeSet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CB_LargeSet.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.CB_LargeSet.Dock = System.Windows.Forms.DockStyle.Right
        Me.CB_LargeSet.Location = New System.Drawing.Point(5, 5)
        Me.CB_LargeSet.LookAndFeel.SkinName = "DevExpress Resto Style"
        Me.CB_LargeSet.MaximumSize = New System.Drawing.Size(75, 109)
        Me.CB_LargeSet.MinimumSize = New System.Drawing.Size(75, 105)
        Me.CB_LargeSet.Name = "CB_LargeSet"
        Me.CB_LargeSet.ShowToolTips = False
        Me.CB_LargeSet.Size = New System.Drawing.Size(75, 105)
        Me.CB_LargeSet.TabIndex = 3
        Me.CB_LargeSet.Text = "Large Set"
        Me.CB_LargeSet.ToolTip = "asdas"
        Me.CB_LargeSet.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Asterisk
        Me.CB_LargeSet.ToolTipTitle = "asdsa"
        '
        'Panel_Type
        '
        Me.Panel_Type.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel_Type.Appearance.Options.UseBackColor = True
        Me.Panel_Type.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_Type.Controls.Add(Me.Sp_POS_MDMenuType_GetDataGridControl)
        Me.Panel_Type.Controls.Add(Me.Panel_TypeList)
        Me.Panel_Type.Location = New System.Drawing.Point(15, 15)
        Me.Panel_Type.Name = "Panel_Type"
        Me.Panel_Type.Size = New System.Drawing.Size(123, 599)
        Me.Panel_Type.TabIndex = 27
        '
        'Sp_POS_MDMenuType_GetDataGridControl
        '
        Me.Sp_POS_MDMenuType_GetDataGridControl.DataSource = Me.Sp_POS_MDMenuType_GetDataBindingSource
        Me.Sp_POS_MDMenuType_GetDataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sp_POS_MDMenuType_GetDataGridControl.Location = New System.Drawing.Point(0, 0)
        Me.Sp_POS_MDMenuType_GetDataGridControl.MainView = Me.TV_MenuType
        Me.Sp_POS_MDMenuType_GetDataGridControl.Name = "Sp_POS_MDMenuType_GetDataGridControl"
        Me.Sp_POS_MDMenuType_GetDataGridControl.Size = New System.Drawing.Size(123, 599)
        Me.Sp_POS_MDMenuType_GetDataGridControl.TabIndex = 2
        Me.Sp_POS_MDMenuType_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TV_MenuType})
        '
        'Sp_POS_MDMenuType_GetDataBindingSource
        '
        Me.Sp_POS_MDMenuType_GetDataBindingSource.DataMember = "sp_POS_MDMenuType_GetData"
        Me.Sp_POS_MDMenuType_GetDataBindingSource.DataSource = Me.DataSet
        '
        'TV_MenuType
        '
        Me.TV_MenuType.Appearance.ItemSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TV_MenuType.Appearance.ItemSelected.Options.UseBackColor = True
        Me.TV_MenuType.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_MenuType, Me.colMenuTypeCode_MenuType, Me.colMenuTypeName_MenuType})
        Me.TV_MenuType.GridControl = Me.Sp_POS_MDMenuType_GetDataGridControl
        Me.TV_MenuType.Name = "TV_MenuType"
        Me.TV_MenuType.OptionsTiles.IndentBetweenGroups = 0
        Me.TV_MenuType.OptionsTiles.ItemSize = New System.Drawing.Size(110, 110)
        Me.TV_MenuType.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TV_MenuType.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TV_MenuType.OptionsTiles.ShowGroupText = False
        TileViewItemElement3.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Top
        TileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        TileViewItemElement3.Appearance.Normal.Options.UseFont = True
        TileViewItemElement3.Appearance.Normal.Options.UseTextOptions = True
        TileViewItemElement3.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TileViewItemElement3.Column = Me.colMenuTypeName_MenuType
        TileViewItemElement3.Text = "colMenuTypeName_MenuType"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement4.Column = Me.colID_MenuType
        TileViewItemElement4.Text = "colID_MenuType"
        TileViewItemElement4.TextLocation = New System.Drawing.Point(100, 0)
        Me.TV_MenuType.TileTemplate.Add(TileViewItemElement3)
        Me.TV_MenuType.TileTemplate.Add(TileViewItemElement4)
        '
        'colMenuTypeCode_MenuType
        '
        Me.colMenuTypeCode_MenuType.FieldName = "MenuTypeCode"
        Me.colMenuTypeCode_MenuType.Name = "colMenuTypeCode_MenuType"
        Me.colMenuTypeCode_MenuType.Visible = True
        Me.colMenuTypeCode_MenuType.VisibleIndex = 0
        '
        'Panel_TypeList
        '
        Me.Panel_TypeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_TypeList.Location = New System.Drawing.Point(5, 0)
        Me.Panel_TypeList.Name = "Panel_TypeList"
        Me.Panel_TypeList.Size = New System.Drawing.Size(100, 337)
        Me.Panel_TypeList.TabIndex = 0
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.DarkGreen
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl4.Controls.Add(Me.SB_EmptyMenu)
        Me.PanelControl4.Controls.Add(Me.PanelControl8)
        Me.PanelControl4.Controls.Add(Me.PanelControl7)
        Me.PanelControl4.Controls.Add(Me.SB_OpenOrder)
        Me.PanelControl4.Controls.Add(Me.PanelControl6)
        Me.PanelControl4.Controls.Add(Me.PanelControl5)
        Me.PanelControl4.Controls.Add(Me.Bt_Back)
        Me.PanelControl4.Controls.Add(Me.SB_Submit)
        Me.PanelControl4.Location = New System.Drawing.Point(148, 15)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 1)
        Me.PanelControl4.Size = New System.Drawing.Size(708, 109)
        Me.PanelControl4.TabIndex = 26
        '
        'SB_EmptyMenu
        '
        Me.SB_EmptyMenu.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_EmptyMenu.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SB_EmptyMenu.Appearance.Options.UseBackColor = True
        Me.SB_EmptyMenu.Appearance.Options.UseFont = True
        Me.SB_EmptyMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.SB_EmptyMenu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SB_EmptyMenu.Location = New System.Drawing.Point(210, 6)
        Me.SB_EmptyMenu.MaximumSize = New System.Drawing.Size(0, 100)
        Me.SB_EmptyMenu.MinimumSize = New System.Drawing.Size(0, 100)
        Me.SB_EmptyMenu.Name = "SB_EmptyMenu"
        Me.SB_EmptyMenu.Size = New System.Drawing.Size(0, 100)
        Me.SB_EmptyMenu.TabIndex = 24
        Me.SB_EmptyMenu.Text = "Reservation Agreement"
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl8.Location = New System.Drawing.Point(394, 6)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(4, 100)
        Me.PanelControl8.TabIndex = 21
        Me.PanelControl8.Visible = False
        '
        'PanelControl7
        '
        Me.PanelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl7.Controls.Add(Me.SB_AddMemo)
        Me.PanelControl7.Controls.Add(Me.SB_SearchMenu)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(210, 6)
        Me.PanelControl7.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(188, 100)
        Me.PanelControl7.TabIndex = 20
        '
        'SB_AddMemo
        '
        Me.SB_AddMemo.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_AddMemo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SB_AddMemo.Appearance.Options.UseBackColor = True
        Me.SB_AddMemo.Appearance.Options.UseFont = True
        Me.SB_AddMemo.Dock = System.Windows.Forms.DockStyle.Top
        Me.SB_AddMemo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SB_AddMemo.Location = New System.Drawing.Point(2, 50)
        Me.SB_AddMemo.MaximumSize = New System.Drawing.Size(0, 100)
        Me.SB_AddMemo.MinimumSize = New System.Drawing.Size(0, 48)
        Me.SB_AddMemo.Name = "SB_AddMemo"
        Me.SB_AddMemo.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.SB_AddMemo.Size = New System.Drawing.Size(184, 48)
        Me.SB_AddMemo.TabIndex = 27
        Me.SB_AddMemo.Text = "Keterangan"
        '
        'SB_SearchMenu
        '
        Me.SB_SearchMenu.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_SearchMenu.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SB_SearchMenu.Appearance.Options.UseBackColor = True
        Me.SB_SearchMenu.Appearance.Options.UseFont = True
        Me.SB_SearchMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.SB_SearchMenu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SB_SearchMenu.Location = New System.Drawing.Point(2, 2)
        Me.SB_SearchMenu.MaximumSize = New System.Drawing.Size(0, 100)
        Me.SB_SearchMenu.MinimumSize = New System.Drawing.Size(100, 48)
        Me.SB_SearchMenu.Name = "SB_SearchMenu"
        Me.SB_SearchMenu.Size = New System.Drawing.Size(184, 48)
        Me.SB_SearchMenu.TabIndex = 26
        Me.SB_SearchMenu.Text = "Search Menu"
        '
        'SB_OpenOrder
        '
        Me.SB_OpenOrder.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_OpenOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SB_OpenOrder.Appearance.Options.UseBackColor = True
        Me.SB_OpenOrder.Appearance.Options.UseFont = True
        Me.SB_OpenOrder.Dock = System.Windows.Forms.DockStyle.Right
        Me.SB_OpenOrder.Image = CType(resources.GetObject("SB_OpenOrder.Image"), System.Drawing.Image)
        Me.SB_OpenOrder.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SB_OpenOrder.Location = New System.Drawing.Point(398, 6)
        Me.SB_OpenOrder.MaximumSize = New System.Drawing.Size(0, 100)
        Me.SB_OpenOrder.MinimumSize = New System.Drawing.Size(100, 100)
        Me.SB_OpenOrder.Name = "SB_OpenOrder"
        Me.SB_OpenOrder.Size = New System.Drawing.Size(100, 100)
        Me.SB_OpenOrder.TabIndex = 19
        Me.SB_OpenOrder.Text = "Open Order"
        Me.SB_OpenOrder.Visible = False
        '
        'PanelControl6
        '
        Me.PanelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl6.Location = New System.Drawing.Point(498, 6)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(4, 100)
        Me.PanelControl6.TabIndex = 18
        '
        'PanelControl5
        '
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl5.Location = New System.Drawing.Point(206, 6)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(4, 100)
        Me.PanelControl5.TabIndex = 16
        '
        'Bt_Back
        '
        Me.Bt_Back.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.Bt_Back.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Bt_Back.Appearance.Options.UseBackColor = True
        Me.Bt_Back.Appearance.Options.UseFont = True
        Me.Bt_Back.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bt_Back.Image = CType(resources.GetObject("Bt_Back.Image"), System.Drawing.Image)
        Me.Bt_Back.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.Bt_Back.Location = New System.Drawing.Point(6, 6)
        Me.Bt_Back.MaximumSize = New System.Drawing.Size(0, 100)
        Me.Bt_Back.MinimumSize = New System.Drawing.Size(200, 100)
        Me.Bt_Back.Name = "Bt_Back"
        Me.Bt_Back.Padding = New System.Windows.Forms.Padding(2)
        Me.Bt_Back.Size = New System.Drawing.Size(200, 100)
        Me.Bt_Back.TabIndex = 15
        Me.Bt_Back.Text = "Back / Hold"
        '
        'SB_Submit
        '
        Me.SB_Submit.AllowFocus = False
        Me.SB_Submit.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SB_Submit.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.SB_Submit.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SB_Submit.Appearance.Options.UseBackColor = True
        Me.SB_Submit.Appearance.Options.UseFont = True
        Me.SB_Submit.Dock = System.Windows.Forms.DockStyle.Right
        Me.SB_Submit.Image = CType(resources.GetObject("SB_Submit.Image"), System.Drawing.Image)
        Me.SB_Submit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SB_Submit.Location = New System.Drawing.Point(502, 6)
        Me.SB_Submit.MaximumSize = New System.Drawing.Size(0, 100)
        Me.SB_Submit.MinimumSize = New System.Drawing.Size(200, 100)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.Padding = New System.Windows.Forms.Padding(2)
        Me.SB_Submit.Size = New System.Drawing.Size(200, 100)
        Me.SB_Submit.TabIndex = 11
        Me.SB_Submit.Text = "Submit"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PanelControl1.Controls.Add(Me.Label_TotalValueOrder)
        Me.PanelControl1.Location = New System.Drawing.Point(866, 440)
        Me.PanelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.PanelControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(317, 40)
        Me.PanelControl1.TabIndex = 23
        '
        'Label_TotalValueOrder
        '
        Me.Label_TotalValueOrder.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label_TotalValueOrder.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label_TotalValueOrder.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label_TotalValueOrder.Appearance.Options.UseBackColor = True
        Me.Label_TotalValueOrder.Appearance.Options.UseFont = True
        Me.Label_TotalValueOrder.Appearance.Options.UseForeColor = True
        Me.Label_TotalValueOrder.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_TotalValueOrder.Location = New System.Drawing.Point(8, 7)
        Me.Label_TotalValueOrder.Name = "Label_TotalValueOrder"
        Me.Label_TotalValueOrder.Size = New System.Drawing.Size(220, 25)
        Me.Label_TotalValueOrder.StyleController = Me.LC_Front
        Me.Label_TotalValueOrder.TabIndex = 16
        Me.Label_TotalValueOrder.Text = "Total :"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PanelControl3.Controls.Add(Me.Label_TableName)
        Me.PanelControl3.Controls.Add(Me.Label_OrderNo)
        Me.PanelControl3.Location = New System.Drawing.Point(866, 15)
        Me.PanelControl3.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.PanelControl3.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.PanelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl3.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(317, 61)
        Me.PanelControl3.TabIndex = 22
        '
        'Label_TableName
        '
        Me.Label_TableName.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label_TableName.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label_TableName.Appearance.Options.UseFont = True
        Me.Label_TableName.Appearance.Options.UseForeColor = True
        Me.Label_TableName.Appearance.Options.UseTextOptions = True
        Me.Label_TableName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_TableName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_TableName.Location = New System.Drawing.Point(5, 5)
        Me.Label_TableName.Name = "Label_TableName"
        Me.Label_TableName.Size = New System.Drawing.Size(313, 25)
        Me.Label_TableName.StyleController = Me.LC_Front
        Me.Label_TableName.TabIndex = 11
        Me.Label_TableName.Text = "Table Name"
        '
        'Label_OrderNo
        '
        Me.Label_OrderNo.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label_OrderNo.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label_OrderNo.Appearance.Options.UseFont = True
        Me.Label_OrderNo.Appearance.Options.UseForeColor = True
        Me.Label_OrderNo.Appearance.Options.UseTextOptions = True
        Me.Label_OrderNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_OrderNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_OrderNo.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.Label_OrderNo.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.Label_OrderNo.Location = New System.Drawing.Point(0, 32)
        Me.Label_OrderNo.Name = "Label_OrderNo"
        Me.Label_OrderNo.Size = New System.Drawing.Size(313, 27)
        Me.Label_OrderNo.StyleController = Me.LC_Front
        Me.Label_OrderNo.TabIndex = 10
        Me.Label_OrderNo.Text = "Order No"
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.DarkGreen
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.Bt_UnHold)
        Me.PanelControl2.Controls.Add(Me.Bt_Payment)
        Me.PanelControl2.Controls.Add(Me.SB_Memo)
        Me.PanelControl2.Controls.Add(Me.Bt_Hold)
        Me.PanelControl2.Location = New System.Drawing.Point(866, 495)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(317, 119)
        Me.PanelControl2.TabIndex = 21
        '
        'Bt_UnHold
        '
        Me.Bt_UnHold.AllowFocus = False
        Me.Bt_UnHold.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.Bt_UnHold.Appearance.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Bt_UnHold.Appearance.Options.UseBackColor = True
        Me.Bt_UnHold.Appearance.Options.UseFont = True
        Me.Bt_UnHold.Appearance.Options.UseTextOptions = True
        Me.Bt_UnHold.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Bt_UnHold.Enabled = False
        Me.Bt_UnHold.Location = New System.Drawing.Point(7, 7)
        Me.Bt_UnHold.Name = "Bt_UnHold"
        Me.Bt_UnHold.Size = New System.Drawing.Size(99, 51)
        Me.Bt_UnHold.TabIndex = 21
        Me.Bt_UnHold.TabStop = False
        Me.Bt_UnHold.Text = "Prep"
        '
        'Bt_Payment
        '
        Me.Bt_Payment.AllowFocus = False
        Me.Bt_Payment.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.Bt_Payment.Appearance.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Bt_Payment.Appearance.Options.UseBackColor = True
        Me.Bt_Payment.Appearance.Options.UseFont = True
        Me.Bt_Payment.Location = New System.Drawing.Point(211, 7)
        Me.Bt_Payment.Name = "Bt_Payment"
        Me.Bt_Payment.Size = New System.Drawing.Size(99, 105)
        Me.Bt_Payment.TabIndex = 17
        Me.Bt_Payment.TabStop = False
        Me.Bt_Payment.Text = "Payment"
        '
        'SB_Memo
        '
        Me.SB_Memo.AllowFocus = False
        Me.SB_Memo.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_Memo.Appearance.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.SB_Memo.Appearance.Options.UseBackColor = True
        Me.SB_Memo.Appearance.Options.UseFont = True
        Me.SB_Memo.Location = New System.Drawing.Point(109, 7)
        Me.SB_Memo.Name = "SB_Memo"
        Me.SB_Memo.Size = New System.Drawing.Size(99, 105)
        Me.SB_Memo.TabIndex = 18
        Me.SB_Memo.TabStop = False
        Me.SB_Memo.Text = "Memo"
        '
        'Bt_Hold
        '
        Me.Bt_Hold.AllowFocus = False
        Me.Bt_Hold.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.Bt_Hold.Appearance.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Bt_Hold.Appearance.Options.UseBackColor = True
        Me.Bt_Hold.Appearance.Options.UseFont = True
        Me.Bt_Hold.Appearance.Options.UseTextOptions = True
        Me.Bt_Hold.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Bt_Hold.Enabled = False
        Me.Bt_Hold.Location = New System.Drawing.Point(7, 61)
        Me.Bt_Hold.Name = "Bt_Hold"
        Me.Bt_Hold.Size = New System.Drawing.Size(99, 51)
        Me.Bt_Hold.TabIndex = 20
        Me.Bt_Hold.TabStop = False
        Me.Bt_Hold.Text = "Hold"
        '
        'Label_TypeCategory
        '
        Me.Label_TypeCategory.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label_TypeCategory.Appearance.ForeColor = System.Drawing.Color.White
        Me.Label_TypeCategory.Appearance.Options.UseFont = True
        Me.Label_TypeCategory.Appearance.Options.UseForeColor = True
        Me.Label_TypeCategory.Appearance.Options.UseTextOptions = True
        Me.Label_TypeCategory.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_TypeCategory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_TypeCategory.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.Label_TypeCategory.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.Label_TypeCategory.LineVisible = True
        Me.Label_TypeCategory.Location = New System.Drawing.Point(153, 139)
        Me.Label_TypeCategory.Name = "Label_TypeCategory"
        Me.Label_TypeCategory.Size = New System.Drawing.Size(698, 23)
        Me.Label_TypeCategory.StyleController = Me.LC_Front
        Me.Label_TypeCategory.TabIndex = 7
        Me.Label_TypeCategory.Text = "-"
        '
        'Panel_Menu
        '
        Me.Panel_Menu.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel_Menu.Appearance.Options.UseBackColor = True
        Me.Panel_Menu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_Menu.Controls.Add(Me.Panel_MenuList)
        Me.Panel_Menu.Controls.Add(Me.HScrollBar1)
        Me.Panel_Menu.Controls.Add(Me.FlyoutPanel2)
        Me.Panel_Menu.Controls.Add(Me.FlyoutPanel1)
        Me.Panel_Menu.Controls.Add(Me.Sp_POS_MDMenu_GetDataGridControl)
        Me.Panel_Menu.Location = New System.Drawing.Point(148, 177)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(708, 307)
        Me.Panel_Menu.TabIndex = 6
        '
        'Panel_MenuList
        '
        Me.Panel_MenuList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_MenuList.Location = New System.Drawing.Point(3, 1)
        Me.Panel_MenuList.Name = "Panel_MenuList"
        Me.Panel_MenuList.Size = New System.Drawing.Size(629, 100)
        Me.Panel_MenuList.TabIndex = 6
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HScrollBar1.LargeChange = 20
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 267)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Opacity = 1.0!
        Me.HScrollBar1.Size = New System.Drawing.Size(708, 40)
        Me.HScrollBar1.SmallChange = 10
        Me.HScrollBar1.TabIndex = 5
        '
        'FlyoutPanel2
        '
        Me.FlyoutPanel2.Controls.Add(Me.FlyoutPanelControl2)
        Me.FlyoutPanel2.Location = New System.Drawing.Point(501, 26)
        Me.FlyoutPanel2.Name = "FlyoutPanel2"
        Me.FlyoutPanel2.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel2.Options.CloseOnOuterClick = True
        Me.FlyoutPanel2.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.FlyoutPanel2.OwnerControl = Me.SB_SearchMenu
        Me.FlyoutPanel2.Size = New System.Drawing.Size(150, 126)
        Me.FlyoutPanel2.TabIndex = 3
        '
        'FlyoutPanelControl2
        '
        Me.FlyoutPanelControl2.Controls.Add(Me.LayoutControl2)
        Me.FlyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl2.FlyoutPanel = Me.FlyoutPanel2
        Me.FlyoutPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl2.Name = "FlyoutPanelControl2"
        Me.FlyoutPanelControl2.Padding = New System.Windows.Forms.Padding(5)
        Me.FlyoutPanelControl2.Size = New System.Drawing.Size(150, 126)
        Me.FlyoutPanelControl2.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LayoutControl2.Appearance.Control.Options.UseFont = True
        Me.LayoutControl2.Controls.Add(Me.Ed_Keyword)
        Me.LayoutControl2.Controls.Add(Me.SB_Search)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(7, 7)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup3
        Me.LayoutControl2.Size = New System.Drawing.Size(136, 112)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'Ed_Keyword
        '
        Me.Ed_Keyword.Location = New System.Drawing.Point(12, 12)
        Me.Ed_Keyword.Name = "Ed_Keyword"
        Me.Ed_Keyword.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Ed_Keyword.Properties.Appearance.Options.UseFont = True
        Me.Ed_Keyword.Size = New System.Drawing.Size(112, 44)
        Me.Ed_Keyword.StyleController = Me.LayoutControl2
        Me.Ed_Keyword.TabIndex = 6
        '
        'SB_Search
        '
        Me.SB_Search.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.SB_Search.Appearance.Options.UseFont = True
        Me.SB_Search.Location = New System.Drawing.Point(12, 60)
        Me.SB_Search.Name = "SB_Search"
        Me.SB_Search.Size = New System.Drawing.Size(112, 33)
        Me.SB_Search.StyleController = Me.LayoutControl2
        Me.SB_Search.TabIndex = 5
        Me.SB_Search.Text = "Search"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(136, 112)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SB_Search
        Me.LayoutControlItem12.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem12.Name = "LayoutControlItem10"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(116, 44)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.Ed_Keyword
        Me.LayoutControlItem13.CustomizationFormText = ".."
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(116, 48)
        Me.LayoutControlItem13.Text = ".."
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(277, 128)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel1.Options.CloseOnOuterClick = True
        Me.FlyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.FlyoutPanel1.OwnerControl = Me.SB_AddMemo
        Me.FlyoutPanel1.Size = New System.Drawing.Size(150, 150)
        Me.FlyoutPanel1.TabIndex = 2
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.LayoutControl1)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(150, 150)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LayoutControl1.Appearance.Control.Options.UseFont = True
        Me.LayoutControl1.Controls.Add(Me.SB_UpdateKeterangan)
        Me.LayoutControl1.Controls.Add(Me.Memo_Keterangan)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(7, 7)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup2
        Me.LayoutControl1.Size = New System.Drawing.Size(136, 136)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SB_UpdateKeterangan
        '
        Me.SB_UpdateKeterangan.Location = New System.Drawing.Point(12, 98)
        Me.SB_UpdateKeterangan.Name = "SB_UpdateKeterangan"
        Me.SB_UpdateKeterangan.Size = New System.Drawing.Size(112, 26)
        Me.SB_UpdateKeterangan.StyleController = Me.LayoutControl1
        Me.SB_UpdateKeterangan.TabIndex = 5
        Me.SB_UpdateKeterangan.Text = "Update"
        '
        'Memo_Keterangan
        '
        Me.Memo_Keterangan.Location = New System.Drawing.Point(12, 32)
        Me.Memo_Keterangan.Name = "Memo_Keterangan"
        Me.Memo_Keterangan.Size = New System.Drawing.Size(112, 62)
        Me.Memo_Keterangan.StyleController = Me.LayoutControl1
        Me.Memo_Keterangan.TabIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(136, 136)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Memo_Keterangan
        Me.LayoutControlItem9.CustomizationFormText = ": Keterangan :"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(116, 86)
        Me.LayoutControlItem9.Text = ": Keterangan :"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(86, 17)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.SB_UpdateKeterangan
        Me.LayoutControlItem10.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(116, 30)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'Sp_POS_MDMenu_GetDataGridControl
        '
        Me.Sp_POS_MDMenu_GetDataGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sp_POS_MDMenu_GetDataGridControl.DataSource = Me.Sp_POS_MDMenu_GetDataBindingSource
        Me.Sp_POS_MDMenu_GetDataGridControl.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Sp_POS_MDMenu_GetDataGridControl.Location = New System.Drawing.Point(287, 94)
        Me.Sp_POS_MDMenu_GetDataGridControl.MainView = Me.GV_Menu
        Me.Sp_POS_MDMenu_GetDataGridControl.Name = "Sp_POS_MDMenu_GetDataGridControl"
        Me.Sp_POS_MDMenu_GetDataGridControl.Size = New System.Drawing.Size(421, 212)
        Me.Sp_POS_MDMenu_GetDataGridControl.TabIndex = 4
        Me.Sp_POS_MDMenu_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Menu})
        '
        'Sp_POS_MDMenu_GetDataBindingSource
        '
        Me.Sp_POS_MDMenu_GetDataBindingSource.DataMember = "sp_POS_MDMenu_GetData"
        Me.Sp_POS_MDMenu_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Menu
        '
        Me.GV_Menu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Menu, Me.colMenuCode_Menu, Me.colMenuName_Menu, Me.colPrice_Menu, Me.colDiscount_Menu, Me.colImage_Menu, Me.colisMenuLarge_Menu})
        Me.GV_Menu.GridControl = Me.Sp_POS_MDMenu_GetDataGridControl
        Me.GV_Menu.Name = "GV_Menu"
        Me.GV_Menu.OptionsFind.ShowClearButton = False
        Me.GV_Menu.OptionsFind.ShowCloseButton = False
        Me.GV_Menu.OptionsFind.ShowFindButton = False
        '
        'colID_Menu
        '
        Me.colID_Menu.FieldName = "ID"
        Me.colID_Menu.Name = "colID_Menu"
        Me.colID_Menu.OptionsColumn.ReadOnly = True
        Me.colID_Menu.Visible = True
        Me.colID_Menu.VisibleIndex = 0
        '
        'colMenuCode_Menu
        '
        Me.colMenuCode_Menu.FieldName = "MenuCode"
        Me.colMenuCode_Menu.Name = "colMenuCode_Menu"
        Me.colMenuCode_Menu.Visible = True
        Me.colMenuCode_Menu.VisibleIndex = 1
        '
        'colMenuName_Menu
        '
        Me.colMenuName_Menu.AppearanceCell.Options.UseTextOptions = True
        Me.colMenuName_Menu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMenuName_Menu.FieldName = "MenuName"
        Me.colMenuName_Menu.Name = "colMenuName_Menu"
        Me.colMenuName_Menu.ToolTip = "11"
        Me.colMenuName_Menu.Visible = True
        Me.colMenuName_Menu.VisibleIndex = 2
        '
        'colPrice_Menu
        '
        Me.colPrice_Menu.DisplayFormat.FormatString = "n0"
        Me.colPrice_Menu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice_Menu.FieldName = "Price"
        Me.colPrice_Menu.Name = "colPrice_Menu"
        Me.colPrice_Menu.Visible = True
        Me.colPrice_Menu.VisibleIndex = 3
        '
        'colDiscount_Menu
        '
        Me.colDiscount_Menu.FieldName = "Discount"
        Me.colDiscount_Menu.Name = "colDiscount_Menu"
        Me.colDiscount_Menu.Visible = True
        Me.colDiscount_Menu.VisibleIndex = 4
        '
        'colImage_Menu
        '
        Me.colImage_Menu.FieldName = "Image"
        Me.colImage_Menu.Name = "colImage_Menu"
        Me.colImage_Menu.Visible = True
        Me.colImage_Menu.VisibleIndex = 5
        '
        'colisMenuLarge_Menu
        '
        Me.colisMenuLarge_Menu.FieldName = "isMenuLarge"
        Me.colisMenuLarge_Menu.Name = "colisMenuLarge_Menu"
        Me.colisMenuLarge_Menu.Visible = True
        Me.colisMenuLarge_Menu.VisibleIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem16, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1198, 629)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Panel_Menu
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(133, 162)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 10)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(718, 322)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseBackColor = True
        Me.LayoutControlItem4.Control = Me.Label_TypeCategory
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(133, 119)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 43)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(70, 43)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(718, 43)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Sp_POSOrderDetail_GetDataGridControl
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(851, 66)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 0)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(327, 364)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.PanelControl3
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(851, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 0)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(327, 66)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.PanelControl1
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(851, 430)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 54)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(110, 54)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 0, 14)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(327, 54)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl4
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(133, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 119)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(115, 119)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(718, 119)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Panel_Type
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(133, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(133, 30)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(133, 609)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.PanelControl2
        Me.LayoutControlItem16.CustomizationFormText = "LayoutControlItem16"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(851, 484)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(327, 125)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(327, 125)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 5)
        Me.LayoutControlItem16.Size = New System.Drawing.Size(327, 125)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseBackColor = True
        Me.LayoutControlItem8.Control = Me.Panel_Category
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(133, 484)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(0, 125)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(110, 125)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem8.Size = New System.Drawing.Size(718, 125)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'Sp_POS_MDMenuType_GetDataTableAdapter
        '
        Me.Sp_POS_MDMenuType_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_POS_MDMenuCategory_GetDataTableAdapter
        '
        Me.Sp_POS_MDMenuCategory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_MDMenu_GetDataTableAdapter
        '
        Me.Sp_POS_MDMenu_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POSOrderDetail_GetDataTableAdapter
        '
        Me.Sp_POSOrderDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POSOrderDetailMemo_GetDataTableAdapter
        '
        Me.Sp_POSOrderDetailMemo_GetDataTableAdapter.ClearBeforeFill = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(112, 68)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Opacity = 1.0!
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 80)
        Me.VScrollBar1.TabIndex = 0
        '
        'AlertControl1
        '
        Me.AlertControl1.AutoFormDelay = 5000
        Me.AlertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast
        Me.AlertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical
        '
        'PanelControl11
        '
        Me.PanelControl11.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PanelControl11.Appearance.Options.UseBackColor = True
        Me.PanelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl11.Controls.Add(Me.FlyoutPanel3)
        Me.PanelControl11.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl11.Name = "PanelControl11"
        Me.PanelControl11.Size = New System.Drawing.Size(200, 100)
        Me.PanelControl11.TabIndex = 0
        '
        'FlyoutPanel3
        '
        Me.FlyoutPanel3.Controls.Add(Me.FlyoutPanelControl3)
        Me.FlyoutPanel3.Location = New System.Drawing.Point(501, 33)
        Me.FlyoutPanel3.Name = "FlyoutPanel3"
        Me.FlyoutPanel3.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel3.Options.CloseOnOuterClick = True
        Me.FlyoutPanel3.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.FlyoutPanel3.OwnerControl = Me.SB_AddMemo
        Me.FlyoutPanel3.Size = New System.Drawing.Size(150, 209)
        Me.FlyoutPanel3.TabIndex = 3
        '
        'FlyoutPanelControl3
        '
        Me.FlyoutPanelControl3.Controls.Add(Me.LayoutControl3)
        Me.FlyoutPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl3.FlyoutPanel = Me.FlyoutPanel3
        Me.FlyoutPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl3.Name = "FlyoutPanelControl3"
        Me.FlyoutPanelControl3.Padding = New System.Windows.Forms.Padding(5)
        Me.FlyoutPanelControl3.Size = New System.Drawing.Size(150, 209)
        Me.FlyoutPanelControl3.TabIndex = 0
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LayoutControl3.Appearance.Control.Options.UseFont = True
        Me.LayoutControl3.Controls.Add(Me.LabelControl2)
        Me.LayoutControl3.Controls.Add(Me.Label_MenuName)
        Me.LayoutControl3.Controls.Add(Me.TextEdit1)
        Me.LayoutControl3.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(7, 7)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup4
        Me.LayoutControl3.Size = New System.Drawing.Size(136, 195)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl2"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(12, 132)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 28)
        Me.LabelControl2.StyleController = Me.LayoutControl3
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "LabelControl2"
        '
        'Label_MenuName
        '
        Me.Label_MenuName.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label_MenuName.Appearance.Options.UseFont = True
        Me.Label_MenuName.Appearance.Options.UseTextOptions = True
        Me.Label_MenuName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_MenuName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_MenuName.Location = New System.Drawing.Point(12, 100)
        Me.Label_MenuName.Name = "Label_MenuName"
        Me.Label_MenuName.Size = New System.Drawing.Size(112, 28)
        Me.Label_MenuName.StyleController = Me.LayoutControl3
        Me.Label_MenuName.TabIndex = 7
        Me.Label_MenuName.Text = "LabelControl1"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(12, 32)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(112, 34)
        Me.TextEdit1.StyleController = Me.LayoutControl3
        Me.TextEdit1.TabIndex = 6
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 70)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 26)
        Me.SimpleButton1.StyleController = Me.LayoutControl3
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Search"
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem17})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(136, 195)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SimpleButton1
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 58)
        Me.LayoutControlItem11.Name = "LayoutControlItem10"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(116, 30)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.TextEdit1
        Me.LayoutControlItem14.CustomizationFormText = ".."
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem13"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(116, 58)
        Me.LayoutControlItem14.Text = ".."
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(8, 17)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Label_MenuName
        Me.LayoutControlItem15.CustomizationFormText = "LayoutControlItem11"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 88)
        Me.LayoutControlItem15.Name = "LayoutControlItem11"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(116, 32)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.LabelControl2
        Me.LayoutControlItem17.CustomizationFormText = "LayoutControlItem14"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem17.Name = "LayoutControlItem14"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(116, 55)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'FlyoutPanel4
        '
        Me.FlyoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanel4.Name = "FlyoutPanel4"
        Me.FlyoutPanel4.Size = New System.Drawing.Size(150, 150)
        Me.FlyoutPanel4.TabIndex = 0
        '
        'FlyoutPanelControl4
        '
        Me.FlyoutPanelControl4.Controls.Add(Me.LayoutControl4)
        Me.FlyoutPanelControl4.FlyoutPanel = Nothing
        Me.FlyoutPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl4.Name = "FlyoutPanelControl4"
        Me.FlyoutPanelControl4.Size = New System.Drawing.Size(200, 100)
        Me.FlyoutPanelControl4.TabIndex = 0
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LayoutControl4.Appearance.Control.Options.UseFont = True
        Me.LayoutControl4.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl4.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup5
        Me.LayoutControl4.Size = New System.Drawing.Size(196, 96)
        Me.LayoutControl4.TabIndex = 0
        Me.LayoutControl4.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 60)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(155, 26)
        Me.SimpleButton2.StyleController = Me.LayoutControl4
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Update"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(12, 32)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(155, 24)
        Me.MemoEdit1.StyleController = Me.LayoutControl4
        Me.MemoEdit1.TabIndex = 4
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup5.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup5.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlGroup5.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem18, Me.LayoutControlItem19})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(179, 98)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.MemoEdit1
        Me.LayoutControlItem18.CustomizationFormText = ": Keterangan :"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem9"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(159, 48)
        Me.LayoutControlItem18.Text = ": Keterangan :"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(86, 17)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.SimpleButton2
        Me.LayoutControlItem19.CustomizationFormText = "LayoutControlItem10"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem19.Name = "LayoutControlItem10"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(159, 30)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'Frm_Front_old
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 629)
        Me.Controls.Add(Me.LC_Front)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "Frm_Front_old"
        Me.Text = "Front Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV_OrderDetailMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POSOrderDetail_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POSOrderDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_OrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit_NumValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Front, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LC_Front.ResumeLayout(False)
        CType(Me.Panel_Category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Category.ResumeLayout(False)
        CType(Me.PanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDMenuCategory_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDMenuCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TV_MenuCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.Panel_Type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Type.ResumeLayout(False)
        CType(Me.Sp_POS_MDMenuType_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDMenuType_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TV_MenuType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_TypeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.Panel_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Menu.ResumeLayout(False)
        CType(Me.Panel_MenuList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel2.ResumeLayout(False)
        CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.Ed_Keyword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Memo_Keterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDMenu_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDMenu_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl11.ResumeLayout(False)
        CType(Me.FlyoutPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel3.ResumeLayout(False)
        CType(Me.FlyoutPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl3.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl4.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LC_Front As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataSet As POS.DataSet
    Friend WithEvents Sp_POS_MDMenuType_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDMenuType_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDMenuType_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As POS.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_POS_MDMenuType_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents Sp_POS_MDMenuCategory_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDMenuCategory_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDMenuCategory_GetDataTableAdapter
    Friend WithEvents Sp_POS_MDMenuCategory_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents Sp_POS_MDMenu_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDMenu_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDMenu_GetDataTableAdapter
    Friend WithEvents Sp_POS_MDMenu_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents Panel_Menu As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label_TypeCategory As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_POSOrderDetail_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POSOrderDetail_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POSOrderDetail_GetDataTableAdapter
    Friend WithEvents Sp_POSOrderDetail_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_OrderDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GV_OrderDetailMemo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_OrderDetailMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDetailID_OrderDetailMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMemo_OrderDetailMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeID_OrderDetailMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser_OrderDetailMemo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QueriesTableAdapter As POS.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Sp_POSOrderDetailMemo_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POSOrderDetailMemo_GetDataTableAdapter
    Friend WithEvents Bt_Hold As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Memo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Bt_Payment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label_TableName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_OrderNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label_TotalValueOrder As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VScrollBar1 As DevExpress.XtraEditors.VScrollBar
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SB_OpenOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Bt_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colisHold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisProcess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colflag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bt_UnHold As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit_NumValue As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Panel_Type As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_TypeList As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Panel_Category As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SB_EmptyMenu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_UpdateKeterangan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Memo_Keterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents FlyoutPanel2 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl2 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_Search As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_Keyword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents QueriesTableAdapter_Report As POS.DataSet_ReportTableAdapters.QueriesTableAdapter_Report
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CB_LargeSet As DevExpress.XtraEditors.CheckButton
    Friend WithEvents SB_AddMemo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_SearchMenu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TV_MenuType As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID_MenuType As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuTypeCode_MenuType As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuTypeName_MenuType As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TV_MenuCategory As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID_MenuCategory As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuCategoryCode_MenuCategory As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuCategoryName_MenuCategory As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colisVoid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel_MenuList As DevExpress.XtraEditors.PanelControl
    Friend WithEvents HScrollBar1 As DevExpress.XtraEditors.HScrollBar
    Friend WithEvents GV_Menu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Menu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuCode_Menu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuName_Menu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice_Menu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount_Menu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImage_Menu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisMenuLarge_Menu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents FlyoutPanel3 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl3 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_MenuName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlyoutPanel4 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl4 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
End Class
