<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OrderCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OrderCashier))
        Dim TileItemElement25 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement26 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement27 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement28 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement29 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement30 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement31 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement32 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim ContextButton6 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton7 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton8 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton9 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton10 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim TileViewItemElement11 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement12 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement13 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement14 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement15 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement16 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement17 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement18 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement19 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement20 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colOrderNo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colTableID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colTableName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colOrderTypeName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SpPOSMDOrderTypeGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New POS.DataSet()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colisClosed = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colOrderTypeID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.NavButton2 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.NavButton_LogOut = New DevExpress.XtraBars.Navigation.NavButton()
        Me.TileNavCategory_OrderOpen = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.TileNavCategory_OrderDineIn = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.TileNavCategory_OrderTakeAway = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.TileNavCategory_OrderDelivery = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.TileNavCategory_OrderReservation = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.TileNavCategory_OrderUpcoming = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.TileNavCategory_OrderOneDay = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.TileNavItem1 = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.Panel_Main = New DevExpress.XtraEditors.PanelControl()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl = New DevExpress.Utils.FlyoutPanelControl()
        Me.LC_VoidReason = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_CancelVoid = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_VoidSubmit = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit_VoidReason = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPOSMDVoidReasonGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FlyoutPanel2 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_CancelMove = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_UpdateTable = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit_Table = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPOSMDTableGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TV_OrderList = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colTransactionPaidValue = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colisPrinted = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPrintCount = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_OneDaySummary = New DevExpress.XtraEditors.SimpleButton()
        Me.Label_Employee = New DevExpress.XtraEditors.LabelControl()
        Me.Label_Time = New DevExpress.XtraEditors.LabelControl()
        Me.SB_BookOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Delivery = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_TakeAway = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_DineIn = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TableAdapterManager = New POS.DataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter = New POS.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter = New POS.DataSetTableAdapters.sp_POSOrderDetailCheck_GetDataHeaderTableAdapter()
        Me.Sp_POS_MDTable_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDTable_GetDataTableAdapter()
        Me.Sp_POS_MDOrderType_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDOrderType_GetDataTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Sp_POS_MDVoidReason_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDVoidReason_GetDataTableAdapter()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSMDOrderTypeGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TileNavPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Main.SuspendLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl.SuspendLayout()
        CType(Me.LC_VoidReason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LC_VoidReason.SuspendLayout()
        CType(Me.LookUpEdit_VoidReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSMDVoidReasonGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel2.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LookUpEdit_Table.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSMDTableGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TV_OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colOrderNo
        '
        Me.colOrderNo.FieldName = "OrderNo"
        Me.colOrderNo.Name = "colOrderNo"
        Me.colOrderNo.Visible = True
        Me.colOrderNo.VisibleIndex = 3
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colTableID
        '
        Me.colTableID.FieldName = "TableID"
        Me.colTableID.Name = "colTableID"
        Me.colTableID.Visible = True
        Me.colTableID.VisibleIndex = 4
        '
        'colTableName
        '
        Me.colTableName.FieldName = "TableName"
        Me.colTableName.Name = "colTableName"
        Me.colTableName.OptionsColumn.ReadOnly = True
        Me.colTableName.Visible = True
        Me.colTableName.VisibleIndex = 5
        '
        'colOrderTypeName
        '
        Me.colOrderTypeName.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colOrderTypeName.FieldName = "OrderTypeName"
        Me.colOrderTypeName.Name = "colOrderTypeName"
        Me.colOrderTypeName.Visible = True
        Me.colOrderTypeName.VisibleIndex = 10
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.SpPOSMDOrderTypeGetDataBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "OrderType"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'SpPOSMDOrderTypeGetDataBindingSource
        '
        Me.SpPOSMDOrderTypeGetDataBindingSource.DataMember = "sp_POS_MDOrderType_GetData"
        Me.SpPOSMDOrderTypeGetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colOrderDate
        '
        Me.colOrderDate.DisplayFormat.FormatString = "dd MMM yyy, HH:mm"
        Me.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 1
        '
        'colSubTotal
        '
        Me.colSubTotal.DisplayFormat.FormatString = "n0"
        Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.OptionsColumn.ReadOnly = True
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 6
        '
        'colisClosed
        '
        Me.colisClosed.FieldName = "isClosed"
        Me.colisClosed.Name = "colisClosed"
        Me.colisClosed.Visible = True
        Me.colisClosed.VisibleIndex = 8
        '
        'colOrderTypeID
        '
        Me.colOrderTypeID.FieldName = "OrderTypeID"
        Me.colOrderTypeID.Name = "colOrderTypeID"
        Me.colOrderTypeID.Visible = True
        Me.colOrderTypeID.VisibleIndex = 9
        '
        'LayoutControl1
        '
        Me.LayoutControl1.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControl1.Controls.Add(Me.TileNavPane1)
        Me.LayoutControl1.Controls.Add(Me.Panel_Main)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(480, 277, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1045, 634)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TileNavPane1
        '
        Me.TileNavPane1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TileNavPane1.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.0!)
        Me.TileNavPane1.Appearance.Options.UseBackColor = True
        Me.TileNavPane1.Appearance.Options.UseFont = True
        Me.TileNavPane1.AppearanceHovered.BackColor = System.Drawing.Color.Transparent
        Me.TileNavPane1.AppearanceHovered.Options.UseBackColor = True
        Me.TileNavPane1.AppearanceSelected.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!)
        Me.TileNavPane1.AppearanceSelected.Options.UseFont = True
        Me.TileNavPane1.BackColor = System.Drawing.Color.DimGray
        Me.TileNavPane1.ButtonPadding = New System.Windows.Forms.Padding(12)
        Me.TileNavPane1.Buttons.Add(Me.NavButton2)
        Me.TileNavPane1.Buttons.Add(Me.NavButton_LogOut)
        Me.TileNavPane1.Categories.AddRange(New DevExpress.XtraBars.Navigation.TileNavCategory() {Me.TileNavCategory_OrderOpen, Me.TileNavCategory_OrderDineIn, Me.TileNavCategory_OrderTakeAway, Me.TileNavCategory_OrderDelivery, Me.TileNavCategory_OrderReservation, Me.TileNavCategory_OrderUpcoming, Me.TileNavCategory_OrderOneDay})
        '
        'TileNavCategory1
        '
        Me.TileNavPane1.DefaultCategory.Items.AddRange(New DevExpress.XtraBars.Navigation.TileNavItem() {Me.TileNavItem1})
        Me.TileNavPane1.DefaultCategory.Name = "TileNavCategory1"
        Me.TileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.OwnerCollection = Nothing
        '
        '
        '
        Me.TileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Location = New System.Drawing.Point(10, 10)
        Me.TileNavPane1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TileNavPane1.LookAndFeel.SkinName = "Seven Classic"
        Me.TileNavPane1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TileNavPane1.Name = "TileNavPane1"
        Me.TileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Size = New System.Drawing.Size(1025, 67)
        Me.TileNavPane1.TabIndex = 7
        Me.TileNavPane1.Text = "TileNavPane1"
        '
        'NavButton2
        '
        Me.NavButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left
        Me.NavButton2.Appearance.BackColor = System.Drawing.Color.Gray
        Me.NavButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NavButton2.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 25.0!)
        Me.NavButton2.Appearance.Options.UseBackColor = True
        Me.NavButton2.Appearance.Options.UseFont = True
        Me.NavButton2.AppearanceHovered.BackColor = System.Drawing.Color.Transparent
        Me.NavButton2.AppearanceHovered.Font = New System.Drawing.Font("Lucida Calligraphy", 25.0!)
        Me.NavButton2.AppearanceHovered.Options.UseBackColor = True
        Me.NavButton2.AppearanceHovered.Options.UseFont = True
        Me.NavButton2.AppearanceSelected.Font = New System.Drawing.Font("Lucida Calligraphy", 25.0!)
        Me.NavButton2.AppearanceSelected.Options.UseFont = True
        Me.NavButton2.Caption = "Order Type"
        Me.NavButton2.IsMain = True
        Me.NavButton2.Name = "NavButton2"
        '
        'NavButton_LogOut
        '
        Me.NavButton_LogOut.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.NavButton_LogOut.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.NavButton_LogOut.Appearance.Options.UseFont = True
        Me.NavButton_LogOut.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.NavButton_LogOut.AppearanceHovered.Options.UseFont = True
        Me.NavButton_LogOut.AppearanceSelected.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.NavButton_LogOut.AppearanceSelected.Options.UseFont = True
        Me.NavButton_LogOut.Caption = "Log Out"
        Me.NavButton_LogOut.Glyph = CType(resources.GetObject("NavButton_LogOut.Glyph"), System.Drawing.Image)
        Me.NavButton_LogOut.Name = "NavButton_LogOut"
        '
        'TileNavCategory_OrderOpen
        '
        Me.TileNavCategory_OrderOpen.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderOpen.Appearance.Options.UseFont = True
        Me.TileNavCategory_OrderOpen.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderOpen.AppearanceHovered.Options.UseFont = True
        Me.TileNavCategory_OrderOpen.AppearanceSelected.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderOpen.AppearanceSelected.Options.UseFont = True
        Me.TileNavCategory_OrderOpen.Caption = "Open Order"
        Me.TileNavCategory_OrderOpen.Name = "TileNavCategory_OrderOpen"
        Me.TileNavCategory_OrderOpen.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavCategory_OrderOpen.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileNavCategory_OrderOpen.OwnerCollection = Me.TileNavPane1.Categories
        Me.TileNavCategory_OrderOpen.Tag = "99"
        '
        '
        '
        Me.TileNavCategory_OrderOpen.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileNavCategory_OrderOpen.Tile.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Olive
        Me.TileNavCategory_OrderOpen.Tile.AppearanceItem.Normal.FontSizeDelta = 1
        Me.TileNavCategory_OrderOpen.Tile.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TileNavCategory_OrderOpen.Tile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileNavCategory_OrderOpen.Tile.AppearanceItem.Normal.Options.UseFont = True
        Me.TileNavCategory_OrderOpen.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement25.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement25.Text = "Open Order"
        TileItemElement25.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileNavCategory_OrderOpen.Tile.Elements.Add(TileItemElement25)
        Me.TileNavCategory_OrderOpen.Tile.Name = "TileBarItem8"
        Me.TileNavCategory_OrderOpen.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        '
        'TileNavCategory_OrderDineIn
        '
        Me.TileNavCategory_OrderDineIn.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderDineIn.Appearance.Options.UseFont = True
        Me.TileNavCategory_OrderDineIn.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderDineIn.AppearanceHovered.Options.UseFont = True
        Me.TileNavCategory_OrderDineIn.AppearanceSelected.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TileNavCategory_OrderDineIn.AppearanceSelected.Options.UseFont = True
        Me.TileNavCategory_OrderDineIn.Caption = "Dine In Order"
        Me.TileNavCategory_OrderDineIn.Name = "TileNavCategory_OrderDineIn"
        Me.TileNavCategory_OrderDineIn.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavCategory_OrderDineIn.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileNavCategory_OrderDineIn.OwnerCollection = Me.TileNavPane1.Categories
        Me.TileNavCategory_OrderDineIn.Tag = "1"
        '
        '
        '
        Me.TileNavCategory_OrderDineIn.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileNavCategory_OrderDineIn.Tile.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Green
        Me.TileNavCategory_OrderDineIn.Tile.AppearanceItem.Normal.FontSizeDelta = 1
        Me.TileNavCategory_OrderDineIn.Tile.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TileNavCategory_OrderDineIn.Tile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileNavCategory_OrderDineIn.Tile.AppearanceItem.Normal.Options.UseFont = True
        Me.TileNavCategory_OrderDineIn.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement26.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement26.Text = "Dine In Order"
        TileItemElement26.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileNavCategory_OrderDineIn.Tile.Elements.Add(TileItemElement26)
        Me.TileNavCategory_OrderDineIn.Tile.Name = "TileBarItem2"
        Me.TileNavCategory_OrderDineIn.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        '
        'TileNavCategory_OrderTakeAway
        '
        Me.TileNavCategory_OrderTakeAway.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderTakeAway.Appearance.Options.UseFont = True
        Me.TileNavCategory_OrderTakeAway.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderTakeAway.AppearanceHovered.Options.UseFont = True
        Me.TileNavCategory_OrderTakeAway.AppearanceSelected.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderTakeAway.AppearanceSelected.Options.UseFont = True
        Me.TileNavCategory_OrderTakeAway.Caption = "Take Away Order"
        Me.TileNavCategory_OrderTakeAway.Name = "TileNavCategory_OrderTakeAway"
        Me.TileNavCategory_OrderTakeAway.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavCategory_OrderTakeAway.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileNavCategory_OrderTakeAway.OwnerCollection = Me.TileNavPane1.Categories
        Me.TileNavCategory_OrderTakeAway.Tag = "2"
        '
        '
        '
        Me.TileNavCategory_OrderTakeAway.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TileNavCategory_OrderTakeAway.Tile.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Teal
        Me.TileNavCategory_OrderTakeAway.Tile.AppearanceItem.Normal.FontSizeDelta = 1
        Me.TileNavCategory_OrderTakeAway.Tile.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TileNavCategory_OrderTakeAway.Tile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileNavCategory_OrderTakeAway.Tile.AppearanceItem.Normal.Options.UseFont = True
        Me.TileNavCategory_OrderTakeAway.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement27.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement27.Text = "Take Away Order"
        TileItemElement27.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileNavCategory_OrderTakeAway.Tile.Elements.Add(TileItemElement27)
        Me.TileNavCategory_OrderTakeAway.Tile.Name = "TileBarItem3"
        Me.TileNavCategory_OrderTakeAway.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        '
        'TileNavCategory_OrderDelivery
        '
        Me.TileNavCategory_OrderDelivery.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderDelivery.Appearance.Options.UseFont = True
        Me.TileNavCategory_OrderDelivery.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderDelivery.AppearanceHovered.Options.UseFont = True
        Me.TileNavCategory_OrderDelivery.AppearanceSelected.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderDelivery.AppearanceSelected.Options.UseFont = True
        Me.TileNavCategory_OrderDelivery.Caption = "Delivery Order"
        Me.TileNavCategory_OrderDelivery.Name = "TileNavCategory_OrderDelivery"
        Me.TileNavCategory_OrderDelivery.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavCategory_OrderDelivery.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileNavCategory_OrderDelivery.OwnerCollection = Me.TileNavPane1.Categories
        Me.TileNavCategory_OrderDelivery.Tag = "3"
        '
        '
        '
        Me.TileNavCategory_OrderDelivery.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TileNavCategory_OrderDelivery.Tile.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Navy
        Me.TileNavCategory_OrderDelivery.Tile.AppearanceItem.Normal.FontSizeDelta = 1
        Me.TileNavCategory_OrderDelivery.Tile.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TileNavCategory_OrderDelivery.Tile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileNavCategory_OrderDelivery.Tile.AppearanceItem.Normal.Options.UseFont = True
        Me.TileNavCategory_OrderDelivery.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement28.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement28.Text = "Delivery Order"
        TileItemElement28.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileNavCategory_OrderDelivery.Tile.Elements.Add(TileItemElement28)
        Me.TileNavCategory_OrderDelivery.Tile.Name = "TileBarItem4"
        Me.TileNavCategory_OrderDelivery.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        '
        'TileNavCategory_OrderReservation
        '
        Me.TileNavCategory_OrderReservation.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderReservation.Appearance.Options.UseFont = True
        Me.TileNavCategory_OrderReservation.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderReservation.AppearanceHovered.Options.UseFont = True
        Me.TileNavCategory_OrderReservation.AppearanceSelected.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderReservation.AppearanceSelected.Options.UseFont = True
        Me.TileNavCategory_OrderReservation.Caption = "Reservation Order"
        Me.TileNavCategory_OrderReservation.Name = "TileNavCategory_OrderReservation"
        Me.TileNavCategory_OrderReservation.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavCategory_OrderReservation.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileNavCategory_OrderReservation.OwnerCollection = Me.TileNavPane1.Categories
        Me.TileNavCategory_OrderReservation.Tag = "11"
        '
        '
        '
        Me.TileNavCategory_OrderReservation.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TileNavCategory_OrderReservation.Tile.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Purple
        Me.TileNavCategory_OrderReservation.Tile.AppearanceItem.Normal.FontSizeDelta = 1
        Me.TileNavCategory_OrderReservation.Tile.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TileNavCategory_OrderReservation.Tile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileNavCategory_OrderReservation.Tile.AppearanceItem.Normal.Options.UseFont = True
        Me.TileNavCategory_OrderReservation.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement29.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement29.Text = "Reservation Order"
        TileItemElement29.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileNavCategory_OrderReservation.Tile.Elements.Add(TileItemElement29)
        Me.TileNavCategory_OrderReservation.Tile.Name = "TileBarItem5"
        Me.TileNavCategory_OrderReservation.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        '
        'TileNavCategory_OrderUpcoming
        '
        Me.TileNavCategory_OrderUpcoming.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderUpcoming.Appearance.Options.UseFont = True
        Me.TileNavCategory_OrderUpcoming.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderUpcoming.AppearanceHovered.Options.UseFont = True
        Me.TileNavCategory_OrderUpcoming.AppearanceSelected.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderUpcoming.AppearanceSelected.Options.UseFont = True
        Me.TileNavCategory_OrderUpcoming.Caption = "Upcoming Order"
        Me.TileNavCategory_OrderUpcoming.Name = "TileNavCategory_OrderUpcoming"
        Me.TileNavCategory_OrderUpcoming.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavCategory_OrderUpcoming.OwnerCollection = Me.TileNavPane1.Categories
        Me.TileNavCategory_OrderUpcoming.Tag = "88"
        '
        '
        '
        Me.TileNavCategory_OrderUpcoming.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon
        Me.TileNavCategory_OrderUpcoming.Tile.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 9.25!)
        Me.TileNavCategory_OrderUpcoming.Tile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileNavCategory_OrderUpcoming.Tile.AppearanceItem.Normal.Options.UseFont = True
        Me.TileNavCategory_OrderUpcoming.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement30.Text = "Upcoming Order"
        TileItemElement30.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileNavCategory_OrderUpcoming.Tile.Elements.Add(TileItemElement30)
        Me.TileNavCategory_OrderUpcoming.Tile.Name = "TileBarItem2"
        '
        'TileNavCategory_OrderOneDay
        '
        Me.TileNavCategory_OrderOneDay.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderOneDay.Appearance.Options.UseFont = True
        Me.TileNavCategory_OrderOneDay.AppearanceHovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderOneDay.AppearanceHovered.Options.UseFont = True
        Me.TileNavCategory_OrderOneDay.AppearanceSelected.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileNavCategory_OrderOneDay.AppearanceSelected.Options.UseFont = True
        Me.TileNavCategory_OrderOneDay.Caption = "One Day Order"
        Me.TileNavCategory_OrderOneDay.Name = "TileNavCategory_OrderOneDay"
        Me.TileNavCategory_OrderOneDay.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavCategory_OrderOneDay.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileNavCategory_OrderOneDay.OwnerCollection = Me.TileNavPane1.Categories
        Me.TileNavCategory_OrderOneDay.Tag = "0"
        '
        '
        '
        Me.TileNavCategory_OrderOneDay.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TileNavCategory_OrderOneDay.Tile.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Maroon
        Me.TileNavCategory_OrderOneDay.Tile.AppearanceItem.Normal.FontSizeDelta = 1
        Me.TileNavCategory_OrderOneDay.Tile.AppearanceItem.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TileNavCategory_OrderOneDay.Tile.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileNavCategory_OrderOneDay.Tile.AppearanceItem.Normal.Options.UseFont = True
        Me.TileNavCategory_OrderOneDay.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement31.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileItemElement31.Text = "One Day Order"
        TileItemElement31.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        Me.TileNavCategory_OrderOneDay.Tile.Elements.Add(TileItemElement31)
        Me.TileNavCategory_OrderOneDay.Tile.Name = "TileBarItem6"
        Me.TileNavCategory_OrderOneDay.Tile.ShowItemShadow = DevExpress.Utils.DefaultBoolean.[True]
        '
        'TileNavItem1
        '
        Me.TileNavItem1.Caption = "TileNavItem1"
        Me.TileNavItem1.Name = "TileNavItem1"
        Me.TileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavItem1.OwnerCollection = Me.TileNavPane1.DefaultCategory.Items
        '
        '
        '
        Me.TileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement32.Text = "TileNavItem1"
        Me.TileNavItem1.Tile.Elements.Add(TileItemElement32)
        Me.TileNavItem1.Tile.Name = "TileBarItem1"
        '
        'Panel_Main
        '
        Me.Panel_Main.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel_Main.Appearance.Options.UseBackColor = True
        Me.Panel_Main.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_Main.Controls.Add(Me.FlyoutPanel1)
        Me.Panel_Main.Controls.Add(Me.FlyoutPanel2)
        Me.Panel_Main.Controls.Add(Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl)
        Me.Panel_Main.Location = New System.Drawing.Point(185, 87)
        Me.Panel_Main.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.Panel_Main.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_Main.Size = New System.Drawing.Size(845, 532)
        Me.Panel_Main.TabIndex = 6
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(25, 141)
        Me.FlyoutPanel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.FlyoutPanel1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel1.OwnerControl = Me
        Me.FlyoutPanel1.Size = New System.Drawing.Size(516, 146)
        Me.FlyoutPanel1.TabIndex = 7
        '
        'FlyoutPanelControl
        '
        Me.FlyoutPanelControl.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlyoutPanelControl.Appearance.Options.UseBackColor = True
        Me.FlyoutPanelControl.Controls.Add(Me.LC_VoidReason)
        Me.FlyoutPanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl.Name = "FlyoutPanelControl"
        Me.FlyoutPanelControl.Padding = New System.Windows.Forms.Padding(5)
        Me.FlyoutPanelControl.Size = New System.Drawing.Size(516, 146)
        Me.FlyoutPanelControl.TabIndex = 0
        '
        'LC_VoidReason
        '
        Me.LC_VoidReason.Controls.Add(Me.SB_CancelVoid)
        Me.LC_VoidReason.Controls.Add(Me.SB_VoidSubmit)
        Me.LC_VoidReason.Controls.Add(Me.LookUpEdit_VoidReason)
        Me.LC_VoidReason.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_VoidReason.Location = New System.Drawing.Point(7, 7)
        Me.LC_VoidReason.Name = "LC_VoidReason"
        Me.LC_VoidReason.Root = Me.LayoutControlGroup3
        Me.LC_VoidReason.Size = New System.Drawing.Size(502, 132)
        Me.LC_VoidReason.TabIndex = 0
        Me.LC_VoidReason.Text = "LayoutControl3"
        '
        'SB_CancelVoid
        '
        Me.SB_CancelVoid.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_CancelVoid.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.SB_CancelVoid.Appearance.Options.UseFont = True
        Me.SB_CancelVoid.Appearance.Options.UseForeColor = True
        Me.SB_CancelVoid.Image = CType(resources.GetObject("SB_CancelVoid.Image"), System.Drawing.Image)
        Me.SB_CancelVoid.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SB_CancelVoid.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SB_CancelVoid.Location = New System.Drawing.Point(252, 68)
        Me.SB_CancelVoid.Name = "SB_CancelVoid"
        Me.SB_CancelVoid.Size = New System.Drawing.Size(238, 50)
        Me.SB_CancelVoid.StyleController = Me.LC_VoidReason
        Me.SB_CancelVoid.TabIndex = 6
        Me.SB_CancelVoid.Text = "Cancel"
        '
        'SB_VoidSubmit
        '
        Me.SB_VoidSubmit.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_VoidSubmit.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.SB_VoidSubmit.Appearance.Options.UseFont = True
        Me.SB_VoidSubmit.Appearance.Options.UseForeColor = True
        Me.SB_VoidSubmit.Image = CType(resources.GetObject("SB_VoidSubmit.Image"), System.Drawing.Image)
        Me.SB_VoidSubmit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SB_VoidSubmit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SB_VoidSubmit.Location = New System.Drawing.Point(12, 68)
        Me.SB_VoidSubmit.Name = "SB_VoidSubmit"
        Me.SB_VoidSubmit.Size = New System.Drawing.Size(236, 50)
        Me.SB_VoidSubmit.StyleController = Me.LC_VoidReason
        Me.SB_VoidSubmit.TabIndex = 5
        Me.SB_VoidSubmit.Text = "Submit"
        '
        'LookUpEdit_VoidReason
        '
        Me.LookUpEdit_VoidReason.Location = New System.Drawing.Point(12, 12)
        Me.LookUpEdit_VoidReason.Name = "LookUpEdit_VoidReason"
        Me.LookUpEdit_VoidReason.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LookUpEdit_VoidReason.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDownHeader.Options.UseTextOptions = True
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LookUpEdit_VoidReason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_VoidReason.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VoidReason", "", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center)})
        Me.LookUpEdit_VoidReason.Properties.DataSource = Me.SpPOSMDVoidReasonGetDataBindingSource
        Me.LookUpEdit_VoidReason.Properties.DisplayMember = "VoidReason"
        Me.LookUpEdit_VoidReason.Properties.NullText = "Choose Void Reason....."
        Me.LookUpEdit_VoidReason.Properties.ValueMember = "ID"
        Me.LookUpEdit_VoidReason.Size = New System.Drawing.Size(478, 52)
        Me.LookUpEdit_VoidReason.StyleController = Me.LC_VoidReason
        Me.LookUpEdit_VoidReason.TabIndex = 4
        '
        'SpPOSMDVoidReasonGetDataBindingSource
        '
        Me.SpPOSMDVoidReasonGetDataBindingSource.DataMember = "sp_POS_MDVoidReason_GetData"
        Me.SpPOSMDVoidReasonGetDataBindingSource.DataSource = Me.DataSet
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(502, 132)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.LookUpEdit_VoidReason
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(482, 56)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_VoidSubmit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(240, 56)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SB_CancelVoid
        Me.LayoutControlItem8.Location = New System.Drawing.Point(240, 56)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(242, 56)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'FlyoutPanel2
        '
        Me.FlyoutPanel2.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel2.Location = New System.Drawing.Point(25, 293)
        Me.FlyoutPanel2.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.FlyoutPanel2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FlyoutPanel2.Name = "FlyoutPanel2"
        Me.FlyoutPanel2.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel2.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel2.OwnerControl = Me
        Me.FlyoutPanel2.Size = New System.Drawing.Size(451, 175)
        Me.FlyoutPanel2.TabIndex = 8
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.LayoutControl2)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel2
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(451, 175)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControl2.Controls.Add(Me.SB_CancelMove)
        Me.LayoutControl2.Controls.Add(Me.SB_UpdateTable)
        Me.LayoutControl2.Controls.Add(Me.LookUpEdit_Table)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(7, 7)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(437, 161)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SB_CancelMove
        '
        Me.SB_CancelMove.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_CancelMove.Appearance.Options.UseFont = True
        Me.SB_CancelMove.Location = New System.Drawing.Point(241, 99)
        Me.SB_CancelMove.Name = "SB_CancelMove"
        Me.SB_CancelMove.Size = New System.Drawing.Size(184, 50)
        Me.SB_CancelMove.StyleController = Me.LayoutControl2
        Me.SB_CancelMove.TabIndex = 6
        Me.SB_CancelMove.Text = "Cancel"
        '
        'SB_UpdateTable
        '
        Me.SB_UpdateTable.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_UpdateTable.Appearance.Options.UseFont = True
        Me.SB_UpdateTable.Location = New System.Drawing.Point(12, 99)
        Me.SB_UpdateTable.Name = "SB_UpdateTable"
        Me.SB_UpdateTable.Size = New System.Drawing.Size(225, 50)
        Me.SB_UpdateTable.StyleController = Me.LayoutControl2
        Me.SB_UpdateTable.TabIndex = 5
        Me.SB_UpdateTable.Text = "Move Table"
        '
        'LookUpEdit_Table
        '
        Me.LookUpEdit_Table.Location = New System.Drawing.Point(12, 43)
        Me.LookUpEdit_Table.Name = "LookUpEdit_Table"
        Me.LookUpEdit_Table.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LookUpEdit_Table.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit_Table.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LookUpEdit_Table.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LookUpEdit_Table.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_Table.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 42, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableCode", "Table Code", 108, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableName", "Table Name", 114, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableTypeID", "Table Type ID", 128, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("isCharge", "is Charge", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("isActive", "is Active", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Capacity", "Capacity", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit_Table.Properties.DataSource = Me.SpPOSMDTableGetDataBindingSource
        Me.LookUpEdit_Table.Properties.DisplayMember = "TableName"
        Me.LookUpEdit_Table.Properties.NullText = ""
        Me.LookUpEdit_Table.Properties.ShowHeader = False
        Me.LookUpEdit_Table.Properties.ValueMember = "ID"
        Me.LookUpEdit_Table.Size = New System.Drawing.Size(413, 52)
        Me.LookUpEdit_Table.StyleController = Me.LayoutControl2
        Me.LookUpEdit_Table.TabIndex = 4
        '
        'SpPOSMDTableGetDataBindingSource
        '
        Me.SpPOSMDTableGetDataBindingSource.DataMember = "sp_POS_MDTable_GetData"
        Me.SpPOSMDTableGetDataBindingSource.DataSource = Me.DataSet
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(437, 161)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem2.Control = Me.LookUpEdit_Table
        Me.LayoutControlItem2.CustomizationFormText = "Meja :"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(417, 87)
        Me.LayoutControlItem2.Text = ".:: Pindah Meja ::."
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(142, 28)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SB_UpdateTable
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 87)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(229, 54)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SB_CancelMove
        Me.LayoutControlItem9.Location = New System.Drawing.Point(229, 87)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(188, 54)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'Sp_POSOrderDetailCheck_GetDataHeaderGridControl
        '
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.DataSource = Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Location = New System.Drawing.Point(5, 5)
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.MainView = Me.TV_OrderList
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Name = "Sp_POSOrderDetailCheck_GetDataHeaderGridControl"
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Size = New System.Drawing.Size(835, 522)
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.TabIndex = 7
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TV_OrderList})
        '
        'Sp_POSOrderDetailCheck_GetDataHeaderBindingSource
        '
        Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource.DataMember = "sp_POSOrderDetailCheck_GetDataHeader"
        Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource.DataSource = Me.DataSet
        '
        'TV_OrderList
        '
        Me.TV_OrderList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOrderDate, Me.colCreatedDate, Me.colOrderNo, Me.colTableID, Me.colTableName, Me.colSubTotal, Me.colTransactionPaidValue, Me.colisClosed, Me.colOrderTypeID, Me.colOrderTypeName, Me.colisPrinted, Me.colPrintCount})
        Me.TV_OrderList.ContextButtonOptions.AnimationType = DevExpress.Utils.ContextAnimationType.OpacityAnimation
        ContextButton6.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear
        ContextButton6.Id = New System.Guid("ceb38142-dda8-4ce0-9e3f-27ed1318b13f")
        ContextButton6.Name = "View"
        ContextButton7.Alignment = DevExpress.Utils.ContextItemAlignment.BottomFar
        ContextButton7.Id = New System.Guid("1ad43fc5-51c8-41eb-9bcd-71b84323f35c")
        ContextButton7.Name = "Void"
        ContextButton8.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear
        ContextButton8.Id = New System.Guid("f4f5b43d-b9f9-4b3e-9785-437d0c869894")
        ContextButton8.Name = "Move"
        ContextButton9.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear
        ContextButton9.Id = New System.Guid("8df5ca19-e6a7-413b-861a-49f3332936c8")
        ContextButton9.Name = "Split"
        ContextButton10.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear
        ContextButton10.Id = New System.Guid("8721404a-6295-4f48-9020-b07814d8cdf4")
        ContextButton10.Name = "Combine"
        Me.TV_OrderList.ContextButtons.Add(ContextButton6)
        Me.TV_OrderList.ContextButtons.Add(ContextButton7)
        Me.TV_OrderList.ContextButtons.Add(ContextButton8)
        Me.TV_OrderList.ContextButtons.Add(ContextButton9)
        Me.TV_OrderList.ContextButtons.Add(ContextButton10)
        Me.TV_OrderList.GridControl = Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl
        Me.TV_OrderList.Name = "TV_OrderList"
        Me.TV_OrderList.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TV_OrderList.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TV_OrderList.OptionsTiles.RowCount = 2
        Me.TV_OrderList.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TV_OrderList.OptionsTiles.ShowGroupText = False
        Me.TV_OrderList.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
        TileViewItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        TileViewItemElement11.Appearance.Normal.Options.UseFont = True
        TileViewItemElement11.Column = Me.colOrderNo
        TileViewItemElement11.Text = "colOrderNo"
        TileViewItemElement12.Column = Me.colID
        TileViewItemElement12.Text = "colID"
        TileViewItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement12.TextLocation = New System.Drawing.Point(0, -100)
        TileViewItemElement13.Column = Me.colTableID
        TileViewItemElement13.Text = "colTableID"
        TileViewItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement13.TextLocation = New System.Drawing.Point(0, -100)
        TileViewItemElement14.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        TileViewItemElement14.Appearance.Normal.Options.UseFont = True
        TileViewItemElement14.Column = Me.colTableName
        TileViewItemElement14.Text = "colTableName"
        TileViewItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft
        TileViewItemElement15.Appearance.Normal.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Underline)
        TileViewItemElement15.Appearance.Normal.Options.UseFont = True
        TileViewItemElement15.Column = Me.colOrderTypeName
        TileViewItemElement15.Text = "colOrderTypeName"
        TileViewItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        TileViewItemElement16.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        TileViewItemElement16.Appearance.Normal.Options.UseFont = True
        TileViewItemElement16.Column = Me.colOrderDate
        TileViewItemElement16.Text = "colOrderDate"
        TileViewItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement17.Appearance.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        TileViewItemElement17.Appearance.Normal.Options.UseFont = True
        TileViewItemElement17.Column = Me.colSubTotal
        TileViewItemElement17.Text = "colSubTotal"
        TileViewItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
        TileViewItemElement18.Column = Me.colisClosed
        TileViewItemElement18.Text = "colisClosed"
        TileViewItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement18.TextLocation = New System.Drawing.Point(0, -100)
        TileViewItemElement19.Column = Me.colOrderTypeID
        TileViewItemElement19.Text = "colOrderTypeID"
        TileViewItemElement19.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement19.TextLocation = New System.Drawing.Point(0, -100)
        TileViewItemElement20.Appearance.Normal.BackColor = System.Drawing.Color.Maroon
        TileViewItemElement20.Appearance.Normal.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        TileViewItemElement20.Appearance.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TileViewItemElement20.Appearance.Normal.Options.UseBackColor = True
        TileViewItemElement20.Height = 1
        TileViewItemElement20.StretchHorizontal = True
        TileViewItemElement20.StretchVertical = True
        TileViewItemElement20.Text = ""
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement11)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement12)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement13)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement14)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement15)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement16)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement17)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement18)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement19)
        Me.TV_OrderList.TileTemplate.Add(TileViewItemElement20)
        '
        'colCreatedDate
        '
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = True
        Me.colCreatedDate.VisibleIndex = 2
        '
        'colTransactionPaidValue
        '
        Me.colTransactionPaidValue.FieldName = "TransactionPaidValue"
        Me.colTransactionPaidValue.Name = "colTransactionPaidValue"
        Me.colTransactionPaidValue.OptionsColumn.ReadOnly = True
        Me.colTransactionPaidValue.Visible = True
        Me.colTransactionPaidValue.VisibleIndex = 7
        '
        'colisPrinted
        '
        Me.colisPrinted.FieldName = "isPrinted"
        Me.colisPrinted.Name = "colisPrinted"
        Me.colisPrinted.Visible = True
        Me.colisPrinted.VisibleIndex = 11
        '
        'colPrintCount
        '
        Me.colPrintCount.FieldName = "PrintCount"
        Me.colPrintCount.Name = "colPrintCount"
        Me.colPrintCount.Visible = True
        Me.colPrintCount.VisibleIndex = 12
        '
        'PanelControl1
        '
        Me.PanelControl1.AllowTouchScroll = True
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelControl1.Appearance.BorderColor = System.Drawing.Color.Yellow
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseBorderColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelControl1.Controls.Add(Me.SB_OneDaySummary)
        Me.PanelControl1.Controls.Add(Me.Label_Employee)
        Me.PanelControl1.Controls.Add(Me.Label_Time)
        Me.PanelControl1.Controls.Add(Me.SB_BookOrder)
        Me.PanelControl1.Controls.Add(Me.SB_Delivery)
        Me.PanelControl1.Controls.Add(Me.SB_TakeAway)
        Me.PanelControl1.Controls.Add(Me.SB_DineIn)
        Me.PanelControl1.Location = New System.Drawing.Point(15, 87)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelControl1.Size = New System.Drawing.Size(160, 532)
        Me.PanelControl1.TabIndex = 4
        '
        'SB_OneDaySummary
        '
        Me.SB_OneDaySummary.AllowFocus = False
        Me.SB_OneDaySummary.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_OneDaySummary.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_OneDaySummary.Appearance.Options.UseBackColor = True
        Me.SB_OneDaySummary.Appearance.Options.UseFont = True
        Me.SB_OneDaySummary.Appearance.Options.UseTextOptions = True
        Me.SB_OneDaySummary.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SB_OneDaySummary.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SB_OneDaySummary.Location = New System.Drawing.Point(7, 408)
        Me.SB_OneDaySummary.Name = "SB_OneDaySummary"
        Me.SB_OneDaySummary.Size = New System.Drawing.Size(146, 48)
        Me.SB_OneDaySummary.TabIndex = 17
        Me.SB_OneDaySummary.Tag = "1"
        Me.SB_OneDaySummary.Text = "One Day Summary"
        '
        'Label_Employee
        '
        Me.Label_Employee.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label_Employee.Appearance.Options.UseFont = True
        Me.Label_Employee.Appearance.Options.UseTextOptions = True
        Me.Label_Employee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_Employee.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Label_Employee.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_Employee.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_Employee.Location = New System.Drawing.Point(7, 456)
        Me.Label_Employee.Name = "Label_Employee"
        Me.Label_Employee.Size = New System.Drawing.Size(146, 40)
        Me.Label_Employee.TabIndex = 16
        Me.Label_Employee.Text = "Employee Name"
        '
        'Label_Time
        '
        Me.Label_Time.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Label_Time.Appearance.Options.UseFont = True
        Me.Label_Time.Appearance.Options.UseTextOptions = True
        Me.Label_Time.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_Time.AutoEllipsis = True
        Me.Label_Time.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_Time.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Label_Time.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label_Time.Location = New System.Drawing.Point(7, 496)
        Me.Label_Time.Name = "Label_Time"
        Me.Label_Time.Size = New System.Drawing.Size(146, 29)
        Me.Label_Time.TabIndex = 15
        Me.Label_Time.Text = "LabelControl1"
        '
        'SB_BookOrder
        '
        Me.SB_BookOrder.AllowFocus = False
        Me.SB_BookOrder.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_BookOrder.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_BookOrder.Appearance.Options.UseBackColor = True
        Me.SB_BookOrder.Appearance.Options.UseFont = True
        Me.SB_BookOrder.Appearance.Options.UseTextOptions = True
        Me.SB_BookOrder.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SB_BookOrder.Location = New System.Drawing.Point(5, 315)
        Me.SB_BookOrder.Name = "SB_BookOrder"
        Me.SB_BookOrder.Size = New System.Drawing.Size(150, 100)
        Me.SB_BookOrder.TabIndex = 7
        Me.SB_BookOrder.Tag = "1"
        Me.SB_BookOrder.Text = "Book Order"
        '
        'SB_Delivery
        '
        Me.SB_Delivery.AllowFocus = False
        Me.SB_Delivery.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_Delivery.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_Delivery.Appearance.Options.UseBackColor = True
        Me.SB_Delivery.Appearance.Options.UseFont = True
        Me.SB_Delivery.Location = New System.Drawing.Point(5, 211)
        Me.SB_Delivery.Name = "SB_Delivery"
        Me.SB_Delivery.Size = New System.Drawing.Size(150, 100)
        Me.SB_Delivery.TabIndex = 3
        Me.SB_Delivery.Text = "Delivery"
        '
        'SB_TakeAway
        '
        Me.SB_TakeAway.AllowFocus = False
        Me.SB_TakeAway.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_TakeAway.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_TakeAway.Appearance.Options.UseBackColor = True
        Me.SB_TakeAway.Appearance.Options.UseFont = True
        Me.SB_TakeAway.Appearance.Options.UseTextOptions = True
        Me.SB_TakeAway.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SB_TakeAway.Location = New System.Drawing.Point(5, 108)
        Me.SB_TakeAway.Name = "SB_TakeAway"
        Me.SB_TakeAway.Size = New System.Drawing.Size(150, 100)
        Me.SB_TakeAway.TabIndex = 2
        Me.SB_TakeAway.Text = "Take Away"
        '
        'SB_DineIn
        '
        Me.SB_DineIn.AllowFocus = False
        Me.SB_DineIn.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_DineIn.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_DineIn.Appearance.Options.UseBackColor = True
        Me.SB_DineIn.Appearance.Options.UseFont = True
        Me.SB_DineIn.Location = New System.Drawing.Point(5, 5)
        Me.SB_DineIn.Name = "SB_DineIn"
        Me.SB_DineIn.Size = New System.Drawing.Size(150, 100)
        Me.SB_DineIn.TabIndex = 1
        Me.SB_DineIn.Tag = "1"
        Me.SB_DineIn.Text = "Dine In"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1045, 634)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Panel_Main
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(170, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(855, 542)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TileNavPane1
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(0, 72)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(100, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1025, 72)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(170, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(170, 30)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(170, 542)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter
        '
        Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_MDTable_GetDataTableAdapter
        '
        Me.Sp_POS_MDTable_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_MDOrderType_GetDataTableAdapter
        '
        Me.Sp_POS_MDOrderType_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Sp_POS_MDVoidReason_GetDataTableAdapter
        '
        Me.Sp_POS_MDVoidReason_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Frm_OrderCashier
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 634)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "Frm_OrderCashier"
        Me.Text = "Cashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSMDOrderTypeGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TileNavPane1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Main.ResumeLayout(False)
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl.ResumeLayout(False)
        CType(Me.LC_VoidReason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LC_VoidReason.ResumeLayout(False)
        CType(Me.LookUpEdit_VoidReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSMDVoidReasonGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel2.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LookUpEdit_Table.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSMDTableGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TV_OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SB_Delivery As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_TakeAway As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_DineIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataSet As POS.DataSet
    Friend WithEvents TableAdapterManager As POS.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents QueriesTableAdapter As POS.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents Sp_POSOrderDetailCheck_GetDataHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter As POS.DataSetTableAdapters.sp_POSOrderDetailCheck_GetDataHeaderTableAdapter
    Friend WithEvents Panel_Main As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents Sp_POSOrderDetailCheck_GetDataHeaderGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents NavButton2 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents TileNavCategory_OrderOpen As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TileNavCategory_OrderDineIn As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents TileNavCategory_OrderTakeAway As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents TileNavCategory_OrderDelivery As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents TileNavCategory_OrderReservation As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents TileNavCategory_OrderOneDay As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents TileNavItem1 As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents NavButton_LogOut As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents FlyoutPanel2 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LookUpEdit_Table As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_UpdateTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpPOSMDTableGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDTable_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDTable_GetDataTableAdapter
    Friend WithEvents SB_BookOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TileNavCategory_OrderUpcoming As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents TV_OrderList As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colOrderNo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colTableID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colTableName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colTransactionPaidValue As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colisClosed As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colOrderTypeID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SpPOSMDOrderTypeGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDOrderType_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDOrderType_GetDataTableAdapter
    Friend WithEvents colOrderTypeName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SB_OneDaySummary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label_Employee As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_Time As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LC_VoidReason As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_VoidSubmit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit_VoidReason As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpPOSMDVoidReasonGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_POS_MDVoidReason_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDVoidReason_GetDataTableAdapter
    Friend WithEvents SB_CancelVoid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_CancelMove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colisPrinted As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPrintCount As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
