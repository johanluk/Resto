<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Order
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Order))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim ContextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton2 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton3 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton4 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton5 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton6 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton7 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.colOrderNo_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colOrderTypeID_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RepositoryItemLookUpEdit_OrderTypeName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ViewPOSOrderTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New POS.DataSet()
        Me.colTableName_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colSubTotal_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colOrderDate_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuTypeName_TVType = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuCategoryName_TVCategory = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuDisplay = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_CloseFlyOut1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Next = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioGroup_OrderType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit_Server = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SpPOSGetServerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEdit_Table = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SpPOSGetTableListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchLookUpEdit_Table = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableTypeID_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableName_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GridControl_OrderList = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POS_OrderHeader_GetListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TileView_OrderList = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colOrderID_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colTableID_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colisClosed_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colEmployeeID_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colTableType_OrderList = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.PE_New = New DevExpress.XtraEditors.PictureEdit()
        Me.View_pos_ordertypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_pos_ordertypeTableAdapter = New POS.DataSetTableAdapters.View_POS_OrderTypeTableAdapter()
        Me.TableAdapterManager = New POS.DataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter = New POS.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_POS_OrderHeader_GetListTableAdapter = New POS.DataSetTableAdapters.sp_POS_OrderHeader_GetListTableAdapter()
        Me.Sp_POS_GetTableListTableAdapter = New POS.DataSetTableAdapters.sp_POS_GetTableListTableAdapter()
        Me.Sp_POS_GetServerListTableAdapter = New POS.DataSetTableAdapters.sp_POS_GetServerListTableAdapter()
        Me.FlyoutPanel_TableList = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl2 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_CancelMove = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_UpdateTable = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchLookUpEdit_TableMove = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_TableMove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableName_TableMove = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FlyoutPanel_ServerList = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl3 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_CancelServer = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_SubmitServer = New DevExpress.XtraEditors.SimpleButton()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_ServerList = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeName_ServerList = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.FlyoutPanel2 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl4 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_CancelChange = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_ChangePassword = New DevExpress.XtraEditors.SimpleButton()
        Me.Edit_OldPass = New DevExpress.XtraEditors.TextEdit()
        Me.Edit_NewPass = New DevExpress.XtraEditors.TextEdit()
        Me.Edit_CheckPass = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_POS_ChangePasswordTableAdapter = New POS.DataSetTableAdapters.sp_POS_ChangePasswordTableAdapter()
        Me.View_MenuType_ListTableAdapter = New POS.DataSetTableAdapters.View_MenuType_ListTableAdapter()
        Me.View_POS_MenuCategory_FrontListTableAdapter = New POS.DataSetTableAdapters.View_POS_MenuCategory_FrontListTableAdapter()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.SB_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_OrderOther = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_OrderDelivery = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_OrderTakeAway = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_OrderDineIn = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_OrderAll = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelBuatFlyOut = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl5 = New DevExpress.XtraLayout.LayoutControl()
        Me.Label_OrderNo = New DevExpress.XtraEditors.LabelControl()
        Me.GC_MenuType = New DevExpress.XtraGrid.GridControl()
        Me.ViewMenuTypeListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TV_MenuType = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colID_TVType = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colImage4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.ViewPOSMenuCategoryFrontListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TV_MenuCategory = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colID_TVCategory = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuTypeID1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colImage3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_TableAndType = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_Keyword = New DevExpress.XtraEditors.TextEdit()
        Me.View_menu_listGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ViewPOSMenuListMainListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TileView_Menu = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.colID_Menu = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuNo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuCategoryID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colCategoryName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colMenuTypeID = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colTypeName = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colUoM = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colImage1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpPOSOrderDetailGetDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_OrderDetail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderID_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuID_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuDisplay_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMenuName_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrice_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscount_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubtotal_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeID_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisProcess_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisHold_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisVoid_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate_OD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SB_Preview = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Payment = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label_Diskon = New DevExpress.XtraEditors.LabelControl()
        Me.Label_Pembulatan = New DevExpress.XtraEditors.LabelControl()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.Label_Total = New DevExpress.XtraEditors.LabelControl()
        Me.Label_PPn = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label_Subtotal = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_MenuType = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_MenuCategory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_Keyword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.FlyoutPanel_Cancel = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl_Cancel = New DevExpress.Utils.FlyoutPanelControl()
        Me.LookUpEdit_VoidReason = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPOSMDVoidReasonGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SB_Remove = New DevExpress.XtraEditors.SimpleButton()
        Me.FlyoutPanel_UpdateQty = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl_UpdateQty = New DevExpress.Utils.FlyoutPanelControl()
        Me.Label_MenuName_Memo = New DevExpress.XtraEditors.LabelControl()
        Me.SpinEdit_Qty = New DevExpress.XtraEditors.SpinEdit()
        Me.Ed_Price = New DevExpress.XtraEditors.TextEdit()
        Me.SB_Update = New DevExpress.XtraEditors.SimpleButton()
        Me.FlyoutPanel_POSPayment = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl_POSPayment = New DevExpress.Utils.FlyoutPanelControl()
        Me.SB_Validasi = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_20000 = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_2000 = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_Rounding = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SB_5000 = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_1000 = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_10000 = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_50000 = New DevExpress.XtraEditors.SimpleButton()
        Me.CB_Tunai = New DevExpress.XtraEditors.CheckButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Ed_Bill = New DevExpress.XtraEditors.TextEdit()
        Me.Label_Bank = New DevExpress.XtraEditors.LabelControl()
        Me.SB_FinishPayment = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_CardValue = New DevExpress.XtraEditors.TextEdit()
        Me.CB_Debit = New DevExpress.XtraEditors.CheckButton()
        Me.CB_Credit = New DevExpress.XtraEditors.CheckButton()
        Me.CB_QRIS = New DevExpress.XtraEditors.CheckButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Minus = New DevExpress.XtraEditors.CheckButton()
        Me.CB_Plus = New DevExpress.XtraEditors.CheckButton()
        Me.Ed_Change = New DevExpress.XtraEditors.TextEdit()
        Me.SB_RoundNominal = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Reset = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit_Bank = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPOSMDBankGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ed_CardNo = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Payment = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.SB_BackCO = New DevExpress.XtraEditors.SimpleButton()
        Me.GC_Checker = New DevExpress.XtraGrid.GridControl()
        Me.SpPOSCheckerSequenceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LV_CO = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colNoRequestOrder = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colNoRequestOrder = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colMenuName1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.layoutViewField_colMenuName1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colCreatedDate_Checker = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colCreatedDate = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colOrderID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SpPOSOrderDetailGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Sp_POS_MDVoidReason_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDVoidReason_GetDataTableAdapter()
        Me.Sp_POSOrderDetail_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POSOrderDetail_GetDataTableAdapter()
        Me.View_POS_MenuList_MainListTableAdapter = New POS.DataSetTableAdapters.View_POS_MenuList_MainListTableAdapter()
        Me.Sp_POS_OrderDetail_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_OrderDetail_GetDataTableAdapter()
        Me.Sp_POS_MDBank_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDBank_GetDataTableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.Sp_POS_CheckerSequenceTableAdapter = New POS.DataSetTableAdapters.sp_POS_CheckerSequenceTableAdapter()
        Me.Sp_POSReportTransaction_GetDataInvoiceDetailTableAdapter = New POS.DataSet_ReportTableAdapters.sp_POSReportTransaction_GetDataInvoiceDetailTableAdapter()
        CType(Me.RepositoryItemLookUpEdit_OrderTypeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPOSOrderTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.RadioGroup_OrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Server.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSGetServerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_Table.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSGetTableListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl_OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_OrderHeader_GetListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView_OrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PE_New.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_pos_ordertypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel_TableList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel_TableList.SuspendLayout()
        CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.SearchLookUpEdit_TableMove.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel_ServerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel_ServerList.SuspendLayout()
        CType(Me.FlyoutPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl3.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel2.SuspendLayout()
        CType(Me.FlyoutPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl4.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.Edit_OldPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit_NewPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit_CheckPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl5.SuspendLayout()
        CType(Me.GC_MenuType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewMenuTypeListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TV_MenuType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPOSMenuCategoryFrontListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TV_MenuCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.Ed_Keyword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_menu_listGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewPOSMenuListMainListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSOrderDetailGetDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_OrderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_MenuType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_MenuCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_Keyword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.FlyoutPanel_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel_Cancel.SuspendLayout()
        CType(Me.FlyoutPanelControl_Cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl_Cancel.SuspendLayout()
        CType(Me.LookUpEdit_VoidReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSMDVoidReasonGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel_UpdateQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel_UpdateQty.SuspendLayout()
        CType(Me.FlyoutPanelControl_UpdateQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl_UpdateQty.SuspendLayout()
        CType(Me.SpinEdit_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel_POSPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel_POSPayment.SuspendLayout()
        CType(Me.FlyoutPanelControl_POSPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl_POSPayment.SuspendLayout()
        CType(Me.Ed_Rounding.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Bill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_CardValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Change.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_Bank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSMDBankGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_CardNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Payment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GC_Checker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSCheckerSequenceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LV_CO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colNoRequestOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colMenuName1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCreatedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSOrderDetailGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colOrderNo_OrderList
        '
        Me.colOrderNo_OrderList.FieldName = "OrderNo"
        Me.colOrderNo_OrderList.MinWidth = 30
        Me.colOrderNo_OrderList.Name = "colOrderNo_OrderList"
        Me.colOrderNo_OrderList.OptionsColumn.AllowEdit = False
        Me.colOrderNo_OrderList.OptionsColumn.AllowFocus = False
        Me.colOrderNo_OrderList.Visible = True
        Me.colOrderNo_OrderList.VisibleIndex = 1
        Me.colOrderNo_OrderList.Width = 112
        '
        'colOrderTypeID_OrderList
        '
        Me.colOrderTypeID_OrderList.ColumnEdit = Me.RepositoryItemLookUpEdit_OrderTypeName
        Me.colOrderTypeID_OrderList.FieldName = "OrderTypeID"
        Me.colOrderTypeID_OrderList.MinWidth = 30
        Me.colOrderTypeID_OrderList.Name = "colOrderTypeID_OrderList"
        Me.colOrderTypeID_OrderList.OptionsColumn.AllowEdit = False
        Me.colOrderTypeID_OrderList.OptionsColumn.AllowFocus = False
        Me.colOrderTypeID_OrderList.Visible = True
        Me.colOrderTypeID_OrderList.VisibleIndex = 3
        Me.colOrderTypeID_OrderList.Width = 112
        '
        'RepositoryItemLookUpEdit_OrderTypeName
        '
        Me.RepositoryItemLookUpEdit_OrderTypeName.AutoHeight = False
        Me.RepositoryItemLookUpEdit_OrderTypeName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_OrderTypeName.DataSource = Me.ViewPOSOrderTypeBindingSource
        Me.RepositoryItemLookUpEdit_OrderTypeName.DisplayMember = "OrderType"
        Me.RepositoryItemLookUpEdit_OrderTypeName.Name = "RepositoryItemLookUpEdit_OrderTypeName"
        Me.RepositoryItemLookUpEdit_OrderTypeName.ValueMember = "ID"
        '
        'ViewPOSOrderTypeBindingSource
        '
        Me.ViewPOSOrderTypeBindingSource.DataMember = "View_POS_OrderType"
        Me.ViewPOSOrderTypeBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colTableName_OrderList
        '
        Me.colTableName_OrderList.FieldName = "TableName"
        Me.colTableName_OrderList.MinWidth = 30
        Me.colTableName_OrderList.Name = "colTableName_OrderList"
        Me.colTableName_OrderList.OptionsColumn.AllowEdit = False
        Me.colTableName_OrderList.OptionsColumn.AllowFocus = False
        Me.colTableName_OrderList.Visible = True
        Me.colTableName_OrderList.VisibleIndex = 5
        Me.colTableName_OrderList.Width = 112
        '
        'colSubTotal_OrderList
        '
        Me.colSubTotal_OrderList.DisplayFormat.FormatString = "n0"
        Me.colSubTotal_OrderList.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubTotal_OrderList.FieldName = "SubTotal"
        Me.colSubTotal_OrderList.MinWidth = 30
        Me.colSubTotal_OrderList.Name = "colSubTotal_OrderList"
        Me.colSubTotal_OrderList.OptionsColumn.AllowEdit = False
        Me.colSubTotal_OrderList.OptionsColumn.AllowFocus = False
        Me.colSubTotal_OrderList.Visible = True
        Me.colSubTotal_OrderList.VisibleIndex = 7
        Me.colSubTotal_OrderList.Width = 112
        '
        'colOrderDate_OrderList
        '
        Me.colOrderDate_OrderList.DisplayFormat.FormatString = "HH.mm"
        Me.colOrderDate_OrderList.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOrderDate_OrderList.FieldName = "OrderDate"
        Me.colOrderDate_OrderList.MinWidth = 30
        Me.colOrderDate_OrderList.Name = "colOrderDate_OrderList"
        Me.colOrderDate_OrderList.OptionsColumn.AllowEdit = False
        Me.colOrderDate_OrderList.OptionsColumn.AllowFocus = False
        Me.colOrderDate_OrderList.Visible = True
        Me.colOrderDate_OrderList.VisibleIndex = 2
        Me.colOrderDate_OrderList.Width = 112
        '
        'colMenuTypeName_TVType
        '
        Me.colMenuTypeName_TVType.FieldName = "MenuTypeName"
        Me.colMenuTypeName_TVType.Name = "colMenuTypeName_TVType"
        Me.colMenuTypeName_TVType.Visible = True
        Me.colMenuTypeName_TVType.VisibleIndex = 1
        '
        'colMenuCategoryName_TVCategory
        '
        Me.colMenuCategoryName_TVCategory.FieldName = "MenuCategoryName"
        Me.colMenuCategoryName_TVCategory.Name = "colMenuCategoryName_TVCategory"
        Me.colMenuCategoryName_TVCategory.Visible = True
        Me.colMenuCategoryName_TVCategory.VisibleIndex = 1
        '
        'colMenuDisplay
        '
        Me.colMenuDisplay.FieldName = "MenuDisplay"
        Me.colMenuDisplay.MinWidth = 30
        Me.colMenuDisplay.Name = "colMenuDisplay"
        Me.colMenuDisplay.Visible = True
        Me.colMenuDisplay.VisibleIndex = 2
        Me.colMenuDisplay.Width = 112
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(16, 347)
        Me.FlyoutPanel1.Margin = New System.Windows.Forms.Padding(4, 69, 4, 4)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel1.Options.CloseOnHidingOwner = False
        Me.FlyoutPanel1.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.FlyoutPanel1.OptionsButtonPanel.ButtonPanelHeight = 35
        Me.FlyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.FlyoutPanel1.OwnerControl = Me
        Me.FlyoutPanel1.Size = New System.Drawing.Size(884, 314)
        Me.FlyoutPanel1.TabIndex = 0
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.LayoutControl1)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(884, 314)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PanelControl3)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(880, 310)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.SB_CloseFlyOut1)
        Me.PanelControl3.Controls.Add(Me.SB_Next)
        Me.PanelControl3.Controls.Add(Me.RadioGroup_OrderType)
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.SpinEdit1)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.SearchLookUpEdit_Server)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit_Table)
        Me.PanelControl3.Controls.Add(Me.Label1)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(856, 286)
        Me.PanelControl3.TabIndex = 9
        '
        'SB_CloseFlyOut1
        '
        Me.SB_CloseFlyOut1.AllowFocus = False
        Me.SB_CloseFlyOut1.AutoSize = True
        Me.SB_CloseFlyOut1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SB_CloseFlyOut1.ImageOptions.Image = CType(resources.GetObject("SB_CloseFlyOut1.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_CloseFlyOut1.Location = New System.Drawing.Point(814, 16)
        Me.SB_CloseFlyOut1.Name = "SB_CloseFlyOut1"
        Me.SB_CloseFlyOut1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_CloseFlyOut1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.SB_CloseFlyOut1.Size = New System.Drawing.Size(22, 22)
        Me.SB_CloseFlyOut1.TabIndex = 18
        '
        'SB_Next
        '
        Me.SB_Next.ImageOptions.Image = Global.POS.My.Resources.Resources.next_page_100px
        Me.SB_Next.Location = New System.Drawing.Point(702, 149)
        Me.SB_Next.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Next.Name = "SB_Next"
        Me.SB_Next.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Next.Size = New System.Drawing.Size(98, 85)
        Me.SB_Next.TabIndex = 17
        '
        'RadioGroup_OrderType
        '
        Me.RadioGroup_OrderType.EditValue = CType(30, Short)
        Me.RadioGroup_OrderType.Location = New System.Drawing.Point(25, 28)
        Me.RadioGroup_OrderType.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioGroup_OrderType.Name = "RadioGroup_OrderType"
        Me.RadioGroup_OrderType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup_OrderType.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.RadioGroup_OrderType.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup_OrderType.Properties.Appearance.Options.UseFont = True
        Me.RadioGroup_OrderType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup_OrderType.Properties.Columns = 1
        Me.RadioGroup_OrderType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Dine In", True, CType(0, Short)), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Take Away", True, CType(1, Short)), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(30, Short), "Delivery - Crew", True, CType(30, Short)), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(31, Short), "Delivery - Grab", True, CType(31, Short)), New DevExpress.XtraEditors.Controls.RadioGroupItem(32, "Delivery - GoJek", True, CType(32, Short)), New DevExpress.XtraEditors.Controls.RadioGroupItem(41, "Reservasi")})
        Me.RadioGroup_OrderType.Size = New System.Drawing.Size(245, 220)
        Me.RadioGroup_OrderType.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(343, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pengunjung :"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(516, 150)
        Me.SpinEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.SpinEdit1.MaximumSize = New System.Drawing.Size(75, 48)
        Me.SpinEdit1.MinimumSize = New System.Drawing.Size(75, 48)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.SpinEdit1.Properties.Appearance.Options.UseFont = True
        Me.SpinEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.SpinEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.SpinEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.SpinEdit1.Properties.MaskSettings.Set("mask", "n0")
        Me.SpinEdit1.Size = New System.Drawing.Size(75, 48)
        Me.SpinEdit1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(375, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "No. Meja :"
        '
        'SearchLookUpEdit_Server
        '
        Me.SearchLookUpEdit_Server.Location = New System.Drawing.Point(518, 38)
        Me.SearchLookUpEdit_Server.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchLookUpEdit_Server.MaximumSize = New System.Drawing.Size(282, 48)
        Me.SearchLookUpEdit_Server.MinimumSize = New System.Drawing.Size(282, 48)
        Me.SearchLookUpEdit_Server.Name = "SearchLookUpEdit_Server"
        Me.SearchLookUpEdit_Server.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.SearchLookUpEdit_Server.Properties.Appearance.Options.UseFont = True
        Me.SearchLookUpEdit_Server.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit_Server.Properties.DataSource = Me.SpPOSGetServerListBindingSource
        Me.SearchLookUpEdit_Server.Properties.DisplayMember = "EmployeeName"
        Me.SearchLookUpEdit_Server.Properties.NullText = "-- Pilih Waiter"
        Me.SearchLookUpEdit_Server.Properties.PopupView = Me.SearchLookUpEdit2View
        Me.SearchLookUpEdit_Server.Properties.ValueMember = "ID"
        Me.SearchLookUpEdit_Server.Size = New System.Drawing.Size(282, 48)
        Me.SearchLookUpEdit_Server.TabIndex = 15
        '
        'SpPOSGetServerListBindingSource
        '
        Me.SpPOSGetServerListBindingSource.DataMember = "sp_POS_GetServerList"
        Me.SpPOSGetServerListBindingSource.DataSource = Me.DataSet
        '
        'SearchLookUpEdit2View
        '
        Me.SearchLookUpEdit2View.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SearchLookUpEdit2View.Appearance.HeaderPanel.Options.UseFont = True
        Me.SearchLookUpEdit2View.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.SearchLookUpEdit2View.Appearance.Row.Options.UseFont = True
        Me.SearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colEmployeeName})
        Me.SearchLookUpEdit2View.DetailHeight = 485
        Me.SearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit2View.Name = "SearchLookUpEdit2View"
        Me.SearchLookUpEdit2View.OptionsEditForm.PopupEditFormWidth = 1200
        Me.SearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
        Me.SearchLookUpEdit2View.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Width = 112
        '
        'colEmployeeName
        '
        Me.colEmployeeName.Caption = "Nama Waiter"
        Me.colEmployeeName.FieldName = "EmployeeName"
        Me.colEmployeeName.MinWidth = 30
        Me.colEmployeeName.Name = "colEmployeeName"
        Me.colEmployeeName.OptionsColumn.AllowEdit = False
        Me.colEmployeeName.OptionsColumn.AllowFocus = False
        Me.colEmployeeName.Visible = True
        Me.colEmployeeName.VisibleIndex = 0
        Me.colEmployeeName.Width = 112
        '
        'LookUpEdit_Table
        '
        Me.LookUpEdit_Table.Location = New System.Drawing.Point(518, 93)
        Me.LookUpEdit_Table.Margin = New System.Windows.Forms.Padding(4)
        Me.LookUpEdit_Table.MaximumSize = New System.Drawing.Size(0, 69)
        Me.LookUpEdit_Table.MinimumSize = New System.Drawing.Size(249, 48)
        Me.LookUpEdit_Table.Name = "LookUpEdit_Table"
        Me.LookUpEdit_Table.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LookUpEdit_Table.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit_Table.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_Table.Properties.DataSource = Me.SpPOSGetTableListBindingSource
        Me.LookUpEdit_Table.Properties.DisplayMember = "TableName"
        Me.LookUpEdit_Table.Properties.NullText = "-- Pilih Meja"
        Me.LookUpEdit_Table.Properties.PopupView = Me.SearchLookUpEdit_Table
        Me.LookUpEdit_Table.Properties.ValueMember = "ID"
        Me.LookUpEdit_Table.Size = New System.Drawing.Size(283, 48)
        Me.LookUpEdit_Table.TabIndex = 6
        '
        'SpPOSGetTableListBindingSource
        '
        Me.SpPOSGetTableListBindingSource.DataMember = "sp_POS_GetTableList"
        Me.SpPOSGetTableListBindingSource.DataSource = Me.DataSet
        '
        'SearchLookUpEdit_Table
        '
        Me.SearchLookUpEdit_Table.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.SearchLookUpEdit_Table.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.SearchLookUpEdit_Table.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.SearchLookUpEdit_Table.Appearance.HeaderPanel.Options.UseFont = True
        Me.SearchLookUpEdit_Table.Appearance.Row.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.SearchLookUpEdit_Table.Appearance.Row.Options.UseFont = True
        Me.SearchLookUpEdit_Table.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Table, Me.colTableTypeID_Table, Me.colTableName_Table})
        Me.SearchLookUpEdit_Table.DetailHeight = 485
        Me.SearchLookUpEdit_Table.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit_Table.Name = "SearchLookUpEdit_Table"
        Me.SearchLookUpEdit_Table.OptionsEditForm.PopupEditFormWidth = 1200
        Me.SearchLookUpEdit_Table.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit_Table.OptionsView.EnableAppearanceEvenRow = True
        Me.SearchLookUpEdit_Table.OptionsView.ShowGroupPanel = False
        '
        'colID_Table
        '
        Me.colID_Table.FieldName = "ID"
        Me.colID_Table.MinWidth = 30
        Me.colID_Table.Name = "colID_Table"
        Me.colID_Table.OptionsColumn.AllowEdit = False
        Me.colID_Table.OptionsColumn.AllowFocus = False
        Me.colID_Table.Width = 112
        '
        'colTableTypeID_Table
        '
        Me.colTableTypeID_Table.FieldName = "TableTypeID"
        Me.colTableTypeID_Table.MinWidth = 30
        Me.colTableTypeID_Table.Name = "colTableTypeID_Table"
        Me.colTableTypeID_Table.OptionsColumn.AllowEdit = False
        Me.colTableTypeID_Table.OptionsColumn.AllowFocus = False
        Me.colTableTypeID_Table.Width = 112
        '
        'colTableName_Table
        '
        Me.colTableName_Table.FieldName = "TableName"
        Me.colTableName_Table.MaxWidth = 300
        Me.colTableName_Table.MinWidth = 300
        Me.colTableName_Table.Name = "colTableName_Table"
        Me.colTableName_Table.OptionsColumn.AllowEdit = False
        Me.colTableName_Table.OptionsColumn.AllowFocus = False
        Me.colTableName_Table.Visible = True
        Me.colTableName_Table.VisibleIndex = 0
        Me.colTableName_Table.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(403, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Waiter :"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(880, 310)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PanelControl3
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(860, 290)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'GridControl_OrderList
        '
        Me.GridControl_OrderList.DataSource = Me.Sp_POS_OrderHeader_GetListBindingSource
        Me.GridControl_OrderList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl_OrderList.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl_OrderList.Location = New System.Drawing.Point(0, 0)
        Me.GridControl_OrderList.MainView = Me.TileView_OrderList
        Me.GridControl_OrderList.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl_OrderList.Name = "GridControl_OrderList"
        Me.GridControl_OrderList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_OrderTypeName})
        Me.GridControl_OrderList.Size = New System.Drawing.Size(1308, 606)
        Me.GridControl_OrderList.TabIndex = 42
        Me.GridControl_OrderList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView_OrderList})
        '
        'Sp_POS_OrderHeader_GetListBindingSource
        '
        Me.Sp_POS_OrderHeader_GetListBindingSource.DataMember = "sp_POS_OrderHeader_GetList"
        Me.Sp_POS_OrderHeader_GetListBindingSource.DataSource = Me.DataSet
        '
        'TileView_OrderList
        '
        Me.TileView_OrderList.Appearance.ItemNormal.BackColor = System.Drawing.Color.Yellow
        Me.TileView_OrderList.Appearance.ItemNormal.BackColor2 = System.Drawing.Color.Green
        Me.TileView_OrderList.Appearance.ItemNormal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TileView_OrderList.Appearance.ItemNormal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TileView_OrderList.Appearance.ItemNormal.Options.UseBackColor = True
        Me.TileView_OrderList.Appearance.ItemNormal.Options.UseFont = True
        Me.TileView_OrderList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID_OrderList, Me.colOrderNo_OrderList, Me.colOrderDate_OrderList, Me.colOrderTypeID_OrderList, Me.colTableID_OrderList, Me.colTableName_OrderList, Me.colisClosed_OrderList, Me.colSubTotal_OrderList, Me.colEmployeeID_OrderList, Me.colTableType_OrderList})
        Me.TileView_OrderList.ColumnSet.GroupColumn = Me.colTableType_OrderList
        ContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
        ContextButton1.AppearanceHover.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton1.AppearanceHover.ForeColor = System.Drawing.Color.White
        ContextButton1.AppearanceHover.Options.UseFont = True
        ContextButton1.AppearanceHover.Options.UseForeColor = True
        ContextButton1.AppearanceNormal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton1.AppearanceNormal.Options.UseFont = True
        ContextButton1.Caption = "View"
        ContextButton1.Id = New System.Guid("efedcc03-e597-43e1-96cc-836b8948b7cf")
        ContextButton1.Name = "CBView"
        ContextButton2.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
        ContextButton2.Caption = "    "
        ContextButton2.Id = New System.Guid("1fb0ea64-d067-4772-85c6-d6eb04a8e3a1")
        ContextButton2.Name = "ContextButton"
        ContextButton3.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
        ContextButton3.AppearanceHover.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton3.AppearanceHover.ForeColor = System.Drawing.Color.White
        ContextButton3.AppearanceHover.Options.UseFont = True
        ContextButton3.AppearanceHover.Options.UseForeColor = True
        ContextButton3.AppearanceNormal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton3.AppearanceNormal.Options.UseFont = True
        ContextButton3.Caption = "Move"
        ContextButton3.Id = New System.Guid("8a589af6-1fad-4365-843f-ce3a02b7e905")
        ContextButton3.Name = "CBMove"
        ContextButton4.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
        ContextButton4.AppearanceHover.ForeColor = System.Drawing.Color.White
        ContextButton4.AppearanceHover.Options.UseForeColor = True
        ContextButton4.Caption = "      "
        ContextButton4.Id = New System.Guid("76de5bcc-8ad8-4be0-8002-3ff7e96da216")
        ContextButton4.Name = "ContextButton"
        ContextButton5.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
        ContextButton5.AppearanceHover.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton5.AppearanceHover.ForeColor = System.Drawing.Color.White
        ContextButton5.AppearanceHover.Options.UseFont = True
        ContextButton5.AppearanceHover.Options.UseForeColor = True
        ContextButton5.AppearanceNormal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton5.AppearanceNormal.ForeColor = System.Drawing.Color.Black
        ContextButton5.AppearanceNormal.Options.UseFont = True
        ContextButton5.AppearanceNormal.Options.UseForeColor = True
        ContextButton5.Caption = "Split"
        ContextButton5.Id = New System.Guid("a35785e4-d5d3-44b2-a838-6c2234df2568")
        ContextButton5.Name = "CBSplit"
        ContextButton6.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
        ContextButton6.Caption = "       "
        ContextButton6.Id = New System.Guid("59b42cb8-26c4-4936-a4ce-d6622c013a98")
        ContextButton6.Name = "ContextButton"
        ContextButton7.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Bottom
        ContextButton7.AppearanceHover.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton7.AppearanceHover.ForeColor = System.Drawing.Color.White
        ContextButton7.AppearanceHover.Options.UseFont = True
        ContextButton7.AppearanceHover.Options.UseForeColor = True
        ContextButton7.AppearanceNormal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        ContextButton7.AppearanceNormal.ForeColor = System.Drawing.Color.Black
        ContextButton7.AppearanceNormal.Options.UseFont = True
        ContextButton7.AppearanceNormal.Options.UseForeColor = True
        ContextButton7.Caption = "Bill"
        ContextButton7.Id = New System.Guid("b9803d73-40e9-4c8b-9c83-d69b0ee544a2")
        ContextButton7.Name = "CBBill"
        Me.TileView_OrderList.ContextButtons.Add(ContextButton1)
        Me.TileView_OrderList.ContextButtons.Add(ContextButton2)
        Me.TileView_OrderList.ContextButtons.Add(ContextButton3)
        Me.TileView_OrderList.ContextButtons.Add(ContextButton4)
        Me.TileView_OrderList.ContextButtons.Add(ContextButton5)
        Me.TileView_OrderList.ContextButtons.Add(ContextButton6)
        Me.TileView_OrderList.ContextButtons.Add(ContextButton7)
        Me.TileView_OrderList.DetailHeight = 485
        Me.TileView_OrderList.GridControl = Me.GridControl_OrderList
        Me.TileView_OrderList.Name = "TileView_OrderList"
        Me.TileView_OrderList.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TileView_OrderList.OptionsTiles.ItemBackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        Me.TileView_OrderList.OptionsTiles.ItemSize = New System.Drawing.Size(300, 120)
        Me.TileView_OrderList.OptionsTiles.RowCount = 0
        Me.TileView_OrderList.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTableType_OrderList, DevExpress.Data.ColumnSortOrder.Ascending)})
        TileViewItemElement1.Column = Me.colOrderNo_OrderList
        TileViewItemElement1.Text = "colOrderNo_OrderList"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement2.Column = Me.colOrderTypeID_OrderList
        TileViewItemElement2.Text = "colOrderTypeID_OrderList"
        TileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        TileViewItemElement3.Appearance.Normal.Options.UseFont = True
        TileViewItemElement3.Column = Me.colTableName_OrderList
        TileViewItemElement3.Text = "colTableName_OrderList"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement3.TextLocation = New System.Drawing.Point(0, -10)
        TileViewItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        TileViewItemElement4.Appearance.Normal.Options.UseFont = True
        TileViewItemElement4.Column = Me.colSubTotal_OrderList
        TileViewItemElement4.Text = "colSubTotal_OrderList"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight
        TileViewItemElement4.TextLocation = New System.Drawing.Point(0, -10)
        TileViewItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.DarkGreen
        TileViewItemElement5.Appearance.Normal.Options.UseBackColor = True
        TileViewItemElement5.StretchHorizontal = True
        TileViewItemElement5.StretchVertical = True
        TileViewItemElement5.Text = ""
        TileViewItemElement5.Width = 500
        TileViewItemElement6.Column = Me.colOrderDate_OrderList
        TileViewItemElement6.Text = "colOrderDate_OrderList"
        TileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
        TileViewItemElement6.TextLocation = New System.Drawing.Point(0, -25)
        Me.TileView_OrderList.TileTemplate.Add(TileViewItemElement1)
        Me.TileView_OrderList.TileTemplate.Add(TileViewItemElement2)
        Me.TileView_OrderList.TileTemplate.Add(TileViewItemElement3)
        Me.TileView_OrderList.TileTemplate.Add(TileViewItemElement4)
        Me.TileView_OrderList.TileTemplate.Add(TileViewItemElement5)
        Me.TileView_OrderList.TileTemplate.Add(TileViewItemElement6)
        '
        'colOrderID_OrderList
        '
        Me.colOrderID_OrderList.FieldName = "OrderID"
        Me.colOrderID_OrderList.MinWidth = 30
        Me.colOrderID_OrderList.Name = "colOrderID_OrderList"
        Me.colOrderID_OrderList.OptionsColumn.AllowEdit = False
        Me.colOrderID_OrderList.OptionsColumn.AllowFocus = False
        Me.colOrderID_OrderList.Visible = True
        Me.colOrderID_OrderList.VisibleIndex = 0
        Me.colOrderID_OrderList.Width = 112
        '
        'colTableID_OrderList
        '
        Me.colTableID_OrderList.FieldName = "TableID"
        Me.colTableID_OrderList.MinWidth = 30
        Me.colTableID_OrderList.Name = "colTableID_OrderList"
        Me.colTableID_OrderList.OptionsColumn.AllowEdit = False
        Me.colTableID_OrderList.OptionsColumn.AllowFocus = False
        Me.colTableID_OrderList.Visible = True
        Me.colTableID_OrderList.VisibleIndex = 4
        Me.colTableID_OrderList.Width = 112
        '
        'colisClosed_OrderList
        '
        Me.colisClosed_OrderList.FieldName = "isClosed"
        Me.colisClosed_OrderList.MinWidth = 30
        Me.colisClosed_OrderList.Name = "colisClosed_OrderList"
        Me.colisClosed_OrderList.OptionsColumn.AllowEdit = False
        Me.colisClosed_OrderList.OptionsColumn.AllowFocus = False
        Me.colisClosed_OrderList.Visible = True
        Me.colisClosed_OrderList.VisibleIndex = 6
        Me.colisClosed_OrderList.Width = 112
        '
        'colEmployeeID_OrderList
        '
        Me.colEmployeeID_OrderList.FieldName = "EmployeeID"
        Me.colEmployeeID_OrderList.MinWidth = 30
        Me.colEmployeeID_OrderList.Name = "colEmployeeID_OrderList"
        Me.colEmployeeID_OrderList.Visible = True
        Me.colEmployeeID_OrderList.VisibleIndex = 8
        Me.colEmployeeID_OrderList.Width = 112
        '
        'colTableType_OrderList
        '
        Me.colTableType_OrderList.FieldName = "TableType"
        Me.colTableType_OrderList.Name = "colTableType_OrderList"
        Me.colTableType_OrderList.OptionsColumn.AllowEdit = False
        Me.colTableType_OrderList.OptionsColumn.AllowFocus = False
        '
        'PE_New
        '
        Me.PE_New.Dock = System.Windows.Forms.DockStyle.Left
        Me.PE_New.EditValue = CType(resources.GetObject("PE_New.EditValue"), Object)
        Me.PE_New.Location = New System.Drawing.Point(0, 0)
        Me.PE_New.Margin = New System.Windows.Forms.Padding(4)
        Me.PE_New.Name = "PE_New"
        Me.PE_New.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PE_New.Properties.Appearance.Options.UseBackColor = True
        Me.PE_New.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PE_New.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PE_New.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PE_New.Size = New System.Drawing.Size(75, 81)
        Me.PE_New.TabIndex = 2
        '
        'View_pos_ordertypeBindingSource
        '
        Me.View_pos_ordertypeBindingSource.DataMember = "view_pos_ordertype"
        Me.View_pos_ordertypeBindingSource.DataSource = Me.DataSet
        '
        'View_pos_ordertypeTableAdapter
        '
        Me.View_pos_ordertypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_POS_OrderHeader_GetListTableAdapter
        '
        Me.Sp_POS_OrderHeader_GetListTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_GetTableListTableAdapter
        '
        Me.Sp_POS_GetTableListTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_GetServerListTableAdapter
        '
        Me.Sp_POS_GetServerListTableAdapter.ClearBeforeFill = True
        '
        'FlyoutPanel_TableList
        '
        Me.FlyoutPanel_TableList.Controls.Add(Me.FlyoutPanelControl2)
        Me.FlyoutPanel_TableList.Location = New System.Drawing.Point(6, 46)
        Me.FlyoutPanel_TableList.Margin = New System.Windows.Forms.Padding(4)
        Me.FlyoutPanel_TableList.Name = "FlyoutPanel_TableList"
        Me.FlyoutPanel_TableList.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel_TableList.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel_TableList.OptionsButtonPanel.ButtonPanelHeight = 42
        Me.FlyoutPanel_TableList.OwnerControl = Me
        Me.FlyoutPanel_TableList.ParentForm = Me
        Me.FlyoutPanel_TableList.Size = New System.Drawing.Size(430, 242)
        Me.FlyoutPanel_TableList.TabIndex = 9
        '
        'FlyoutPanelControl2
        '
        Me.FlyoutPanelControl2.Controls.Add(Me.LayoutControl2)
        Me.FlyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl2.FlyoutPanel = Me.FlyoutPanel_TableList
        Me.FlyoutPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlyoutPanelControl2.Name = "FlyoutPanelControl2"
        Me.FlyoutPanelControl2.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.FlyoutPanelControl2.Size = New System.Drawing.Size(430, 242)
        Me.FlyoutPanelControl2.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.SB_CancelMove)
        Me.LayoutControl2.Controls.Add(Me.SB_UpdateTable)
        Me.LayoutControl2.Controls.Add(Me.SearchLookUpEdit_TableMove)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(10, 9)
        Me.LayoutControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(410, 224)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'SB_CancelMove
        '
        Me.SB_CancelMove.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_CancelMove.Appearance.Options.UseFont = True
        Me.SB_CancelMove.Location = New System.Drawing.Point(213, 102)
        Me.SB_CancelMove.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_CancelMove.Name = "SB_CancelMove"
        Me.SB_CancelMove.Size = New System.Drawing.Size(185, 50)
        Me.SB_CancelMove.StyleController = Me.LayoutControl2
        Me.SB_CancelMove.TabIndex = 6
        Me.SB_CancelMove.Text = "Cancel"
        '
        'SB_UpdateTable
        '
        Me.SB_UpdateTable.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_UpdateTable.Appearance.Options.UseFont = True
        Me.SB_UpdateTable.Location = New System.Drawing.Point(12, 102)
        Me.SB_UpdateTable.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_UpdateTable.Name = "SB_UpdateTable"
        Me.SB_UpdateTable.Size = New System.Drawing.Size(197, 50)
        Me.SB_UpdateTable.StyleController = Me.LayoutControl2
        Me.SB_UpdateTable.TabIndex = 5
        Me.SB_UpdateTable.Text = "Move Table"
        '
        'SearchLookUpEdit_TableMove
        '
        Me.SearchLookUpEdit_TableMove.Location = New System.Drawing.Point(12, 44)
        Me.SearchLookUpEdit_TableMove.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchLookUpEdit_TableMove.Name = "SearchLookUpEdit_TableMove"
        Me.SearchLookUpEdit_TableMove.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SearchLookUpEdit_TableMove.Properties.Appearance.Options.UseFont = True
        Me.SearchLookUpEdit_TableMove.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SearchLookUpEdit_TableMove.Properties.AppearanceDropDown.Options.UseFont = True
        Me.SearchLookUpEdit_TableMove.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit_TableMove.Properties.DataSource = Me.SpPOSGetTableListBindingSource
        Me.SearchLookUpEdit_TableMove.Properties.DisplayMember = "TableName"
        Me.SearchLookUpEdit_TableMove.Properties.NullText = ""
        Me.SearchLookUpEdit_TableMove.Properties.PopupView = Me.GridView1
        Me.SearchLookUpEdit_TableMove.Properties.ValueMember = "ID"
        Me.SearchLookUpEdit_TableMove.Size = New System.Drawing.Size(386, 54)
        Me.SearchLookUpEdit_TableMove.StyleController = Me.LayoutControl2
        Me.SearchLookUpEdit_TableMove.TabIndex = 4
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_TableMove, Me.colTableName_TableMove})
        Me.GridView1.DetailHeight = 485
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colID_TableMove
        '
        Me.colID_TableMove.FieldName = "ID"
        Me.colID_TableMove.MinWidth = 30
        Me.colID_TableMove.Name = "colID_TableMove"
        Me.colID_TableMove.OptionsColumn.AllowEdit = False
        Me.colID_TableMove.OptionsColumn.AllowFocus = False
        Me.colID_TableMove.Width = 112
        '
        'colTableName_TableMove
        '
        Me.colTableName_TableMove.FieldName = "TableName"
        Me.colTableName_TableMove.MinWidth = 30
        Me.colTableName_TableMove.Name = "colTableName_TableMove"
        Me.colTableName_TableMove.OptionsColumn.AllowEdit = False
        Me.colTableName_TableMove.OptionsColumn.AllowFocus = False
        Me.colTableName_TableMove.Visible = True
        Me.colTableName_TableMove.VisibleIndex = 0
        Me.colTableName_TableMove.Width = 112
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
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(410, 224)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem4.Control = Me.SearchLookUpEdit_TableMove
        Me.LayoutControlItem4.CustomizationFormText = "Meja :"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem2"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(390, 90)
        Me.LayoutControlItem4.Text = ".:: Pindah Meja ::."
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(142, 28)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SB_UpdateTable
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(201, 114)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SB_CancelMove
        Me.LayoutControlItem9.Location = New System.Drawing.Point(201, 90)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(189, 114)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'FlyoutPanel_ServerList
        '
        Me.FlyoutPanel_ServerList.Controls.Add(Me.FlyoutPanelControl3)
        Me.FlyoutPanel_ServerList.Location = New System.Drawing.Point(444, 41)
        Me.FlyoutPanel_ServerList.Margin = New System.Windows.Forms.Padding(4)
        Me.FlyoutPanel_ServerList.Name = "FlyoutPanel_ServerList"
        Me.FlyoutPanel_ServerList.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel_ServerList.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel_ServerList.Options.CloseOnOuterClick = True
        Me.FlyoutPanel_ServerList.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.FlyoutPanel_ServerList.OptionsButtonPanel.ButtonPanelHeight = 42
        Me.FlyoutPanel_ServerList.OwnerControl = Me
        Me.FlyoutPanel_ServerList.ParentForm = Me
        Me.FlyoutPanel_ServerList.Size = New System.Drawing.Size(355, 242)
        Me.FlyoutPanel_ServerList.TabIndex = 10
        '
        'FlyoutPanelControl3
        '
        Me.FlyoutPanelControl3.Controls.Add(Me.LayoutControl3)
        Me.FlyoutPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl3.FlyoutPanel = Me.FlyoutPanel_ServerList
        Me.FlyoutPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.FlyoutPanelControl3.Name = "FlyoutPanelControl3"
        Me.FlyoutPanelControl3.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.FlyoutPanelControl3.Size = New System.Drawing.Size(355, 242)
        Me.FlyoutPanelControl3.TabIndex = 0
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.SB_CancelServer)
        Me.LayoutControl3.Controls.Add(Me.SB_SubmitServer)
        Me.LayoutControl3.Controls.Add(Me.SearchLookUpEdit1)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(10, 9)
        Me.LayoutControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.Root = Me.LayoutControlGroup3
        Me.LayoutControl3.Size = New System.Drawing.Size(335, 224)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'SB_CancelServer
        '
        Me.SB_CancelServer.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_CancelServer.Appearance.Options.UseFont = True
        Me.SB_CancelServer.Location = New System.Drawing.Point(174, 102)
        Me.SB_CancelServer.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_CancelServer.Name = "SB_CancelServer"
        Me.SB_CancelServer.Size = New System.Drawing.Size(149, 50)
        Me.SB_CancelServer.StyleController = Me.LayoutControl3
        Me.SB_CancelServer.TabIndex = 6
        Me.SB_CancelServer.Text = "Cancel"
        '
        'SB_SubmitServer
        '
        Me.SB_SubmitServer.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_SubmitServer.Appearance.Options.UseFont = True
        Me.SB_SubmitServer.Location = New System.Drawing.Point(12, 102)
        Me.SB_SubmitServer.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_SubmitServer.Name = "SB_SubmitServer"
        Me.SB_SubmitServer.Size = New System.Drawing.Size(158, 50)
        Me.SB_SubmitServer.StyleController = Me.LayoutControl3
        Me.SB_SubmitServer.TabIndex = 5
        Me.SB_SubmitServer.Text = "Submit"
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(12, 44)
        Me.SearchLookUpEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SearchLookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.SearchLookUpEdit1.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SearchLookUpEdit1.Properties.AppearanceDropDown.Options.UseFont = True
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.DataSource = Me.SpPOSGetServerListBindingSource
        Me.SearchLookUpEdit1.Properties.DisplayMember = "EmployeeName"
        Me.SearchLookUpEdit1.Properties.NullText = ""
        Me.SearchLookUpEdit1.Properties.PopupView = Me.GridView2
        Me.SearchLookUpEdit1.Properties.ValueMember = "ID"
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(311, 54)
        Me.SearchLookUpEdit1.StyleController = Me.LayoutControl3
        Me.SearchLookUpEdit1.TabIndex = 4
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_ServerList, Me.colEmployeeName_ServerList})
        Me.GridView2.DetailHeight = 485
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colID_ServerList
        '
        Me.colID_ServerList.FieldName = "ID"
        Me.colID_ServerList.MinWidth = 30
        Me.colID_ServerList.Name = "colID_ServerList"
        Me.colID_ServerList.OptionsColumn.AllowEdit = False
        Me.colID_ServerList.OptionsColumn.AllowFocus = False
        Me.colID_ServerList.Width = 112
        '
        'colEmployeeName_ServerList
        '
        Me.colEmployeeName_ServerList.FieldName = "EmployeeName"
        Me.colEmployeeName_ServerList.MinWidth = 30
        Me.colEmployeeName_ServerList.Name = "colEmployeeName_ServerList"
        Me.colEmployeeName_ServerList.OptionsColumn.AllowEdit = False
        Me.colEmployeeName_ServerList.OptionsColumn.AllowFocus = False
        Me.colEmployeeName_ServerList.Visible = True
        Me.colEmployeeName_ServerList.VisibleIndex = 0
        Me.colEmployeeName_ServerList.Width = 112
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup3.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LayoutControlGroup3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(335, 224)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem6.Control = Me.SearchLookUpEdit1
        Me.LayoutControlItem6.CustomizationFormText = "Meja :"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem2"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(315, 90)
        Me.LayoutControlItem6.Text = ".:: Runner ::."
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(96, 28)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_SubmitServer
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem7.Name = "LayoutControlItem5"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(162, 114)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SB_CancelServer
        Me.LayoutControlItem8.Location = New System.Drawing.Point(162, 90)
        Me.LayoutControlItem8.Name = "LayoutControlItem9"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(153, 114)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'FlyoutPanel2
        '
        Me.FlyoutPanel2.Controls.Add(Me.FlyoutPanelControl4)
        Me.FlyoutPanel2.Location = New System.Drawing.Point(824, 41)
        Me.FlyoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlyoutPanel2.Name = "FlyoutPanel2"
        Me.FlyoutPanel2.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel2.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel2.OptionsButtonPanel.ButtonPanelHeight = 42
        Me.FlyoutPanel2.OwnerControl = Me
        Me.FlyoutPanel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.FlyoutPanel2.ParentForm = Me
        Me.FlyoutPanel2.Size = New System.Drawing.Size(472, 282)
        Me.FlyoutPanel2.TabIndex = 11
        '
        'FlyoutPanelControl4
        '
        Me.FlyoutPanelControl4.Controls.Add(Me.LayoutControl4)
        Me.FlyoutPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl4.FlyoutPanel = Me.FlyoutPanel2
        Me.FlyoutPanelControl4.Location = New System.Drawing.Point(10, 0)
        Me.FlyoutPanelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.FlyoutPanelControl4.Name = "FlyoutPanelControl4"
        Me.FlyoutPanelControl4.Padding = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.FlyoutPanelControl4.Size = New System.Drawing.Size(452, 282)
        Me.FlyoutPanelControl4.TabIndex = 0
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.SB_CancelChange)
        Me.LayoutControl4.Controls.Add(Me.SB_ChangePassword)
        Me.LayoutControl4.Controls.Add(Me.Edit_OldPass)
        Me.LayoutControl4.Controls.Add(Me.Edit_NewPass)
        Me.LayoutControl4.Controls.Add(Me.Edit_CheckPass)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(10, 9)
        Me.LayoutControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup4
        Me.LayoutControl4.Size = New System.Drawing.Size(432, 264)
        Me.LayoutControl4.TabIndex = 0
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'SB_CancelChange
        '
        Me.SB_CancelChange.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_CancelChange.Appearance.Options.UseFont = True
        Me.SB_CancelChange.Location = New System.Drawing.Point(271, 132)
        Me.SB_CancelChange.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_CancelChange.Name = "SB_CancelChange"
        Me.SB_CancelChange.Size = New System.Drawing.Size(149, 50)
        Me.SB_CancelChange.StyleController = Me.LayoutControl4
        Me.SB_CancelChange.TabIndex = 6
        Me.SB_CancelChange.Text = "Batal"
        '
        'SB_ChangePassword
        '
        Me.SB_ChangePassword.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_ChangePassword.Appearance.Options.UseFont = True
        Me.SB_ChangePassword.Location = New System.Drawing.Point(12, 132)
        Me.SB_ChangePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_ChangePassword.Name = "SB_ChangePassword"
        Me.SB_ChangePassword.Size = New System.Drawing.Size(255, 50)
        Me.SB_ChangePassword.StyleController = Me.LayoutControl4
        Me.SB_ChangePassword.TabIndex = 5
        Me.SB_ChangePassword.Text = "Ganti Kata Kunci"
        '
        'Edit_OldPass
        '
        Me.Edit_OldPass.Location = New System.Drawing.Point(176, 12)
        Me.Edit_OldPass.Margin = New System.Windows.Forms.Padding(4)
        Me.Edit_OldPass.Name = "Edit_OldPass"
        Me.Edit_OldPass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Edit_OldPass.Properties.Appearance.Options.UseFont = True
        Me.Edit_OldPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Edit_OldPass.Size = New System.Drawing.Size(244, 36)
        Me.Edit_OldPass.StyleController = Me.LayoutControl4
        Me.Edit_OldPass.TabIndex = 4
        '
        'Edit_NewPass
        '
        Me.Edit_NewPass.Location = New System.Drawing.Point(176, 52)
        Me.Edit_NewPass.Margin = New System.Windows.Forms.Padding(4)
        Me.Edit_NewPass.Name = "Edit_NewPass"
        Me.Edit_NewPass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Edit_NewPass.Properties.Appearance.Options.UseFont = True
        Me.Edit_NewPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Edit_NewPass.Size = New System.Drawing.Size(244, 36)
        Me.Edit_NewPass.StyleController = Me.LayoutControl4
        Me.Edit_NewPass.TabIndex = 4
        '
        'Edit_CheckPass
        '
        Me.Edit_CheckPass.Location = New System.Drawing.Point(176, 92)
        Me.Edit_CheckPass.Margin = New System.Windows.Forms.Padding(4)
        Me.Edit_CheckPass.Name = "Edit_CheckPass"
        Me.Edit_CheckPass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Edit_CheckPass.Properties.Appearance.Options.UseFont = True
        Me.Edit_CheckPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Edit_CheckPass.Size = New System.Drawing.Size(244, 36)
        Me.Edit_CheckPass.StyleController = Me.LayoutControl4
        Me.Edit_CheckPass.TabIndex = 4
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup4.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.LayoutControlGroup4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14})
        Me.LayoutControlGroup4.Name = "Root"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(432, 264)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem10.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem10.Control = Me.Edit_OldPass
        Me.LayoutControlItem10.CustomizationFormText = "Meja :"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem2"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(412, 40)
        Me.LayoutControlItem10.Text = "Kata Kunci Lama :"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(152, 28)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SB_ChangePassword
        Me.LayoutControlItem11.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem11.Name = "LayoutControlItem5"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(259, 124)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SB_CancelChange
        Me.LayoutControlItem12.Location = New System.Drawing.Point(259, 120)
        Me.LayoutControlItem12.Name = "LayoutControlItem9"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(153, 124)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.Edit_NewPass
        Me.LayoutControlItem13.CustomizationFormText = "Meja :"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem13.Name = "LayoutControlItem10"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(412, 40)
        Me.LayoutControlItem13.Text = "Kata Kunci Baru :"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(152, 28)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Edit_CheckPass
        Me.LayoutControlItem14.CustomizationFormText = "Meja :"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem14.Name = "LayoutControlItem11"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(412, 40)
        Me.LayoutControlItem14.Text = "Cek Ulang Sandi :"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(152, 28)
        '
        'Sp_POS_ChangePasswordTableAdapter
        '
        Me.Sp_POS_ChangePasswordTableAdapter.ClearBeforeFill = True
        '
        'View_MenuType_ListTableAdapter
        '
        Me.View_MenuType_ListTableAdapter.ClearBeforeFill = True
        '
        'View_POS_MenuCategory_FrontListTableAdapter
        '
        Me.View_POS_MenuCategory_FrontListTableAdapter.ClearBeforeFill = True
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.SB_Close)
        Me.PanelHeader.Controls.Add(Me.SB_OrderOther)
        Me.PanelHeader.Controls.Add(Me.SB_OrderDelivery)
        Me.PanelHeader.Controls.Add(Me.SB_OrderTakeAway)
        Me.PanelHeader.Controls.Add(Me.SB_OrderDineIn)
        Me.PanelHeader.Controls.Add(Me.SB_OrderAll)
        Me.PanelHeader.Controls.Add(Me.PE_New)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelHeader.MaximumSize = New System.Drawing.Size(0, 111)
        Me.PanelHeader.MinimumSize = New System.Drawing.Size(0, 81)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1308, 81)
        Me.PanelHeader.TabIndex = 41
        '
        'SB_Close
        '
        Me.SB_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.SB_Close.ImageOptions.Image = CType(resources.GetObject("SB_Close.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Close.Location = New System.Drawing.Point(1244, 0)
        Me.SB_Close.Name = "SB_Close"
        Me.SB_Close.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Close.Size = New System.Drawing.Size(64, 81)
        Me.SB_Close.TabIndex = 45
        '
        'SB_OrderOther
        '
        Me.SB_OrderOther.Location = New System.Drawing.Point(980, 17)
        Me.SB_OrderOther.Name = "SB_OrderOther"
        Me.SB_OrderOther.Size = New System.Drawing.Size(212, 57)
        Me.SB_OrderOther.TabIndex = 44
        Me.SB_OrderOther.Tag = "4"
        Me.SB_OrderOther.Text = "Other"
        '
        'SB_OrderDelivery
        '
        Me.SB_OrderDelivery.Location = New System.Drawing.Point(762, 17)
        Me.SB_OrderDelivery.Name = "SB_OrderDelivery"
        Me.SB_OrderDelivery.Size = New System.Drawing.Size(212, 57)
        Me.SB_OrderDelivery.TabIndex = 43
        Me.SB_OrderDelivery.Tag = "3"
        Me.SB_OrderDelivery.Text = "Delivery"
        '
        'SB_OrderTakeAway
        '
        Me.SB_OrderTakeAway.Location = New System.Drawing.Point(544, 17)
        Me.SB_OrderTakeAway.Name = "SB_OrderTakeAway"
        Me.SB_OrderTakeAway.Size = New System.Drawing.Size(212, 57)
        Me.SB_OrderTakeAway.TabIndex = 42
        Me.SB_OrderTakeAway.Tag = "2"
        Me.SB_OrderTakeAway.Text = "Take Away"
        '
        'SB_OrderDineIn
        '
        Me.SB_OrderDineIn.Location = New System.Drawing.Point(322, 17)
        Me.SB_OrderDineIn.Name = "SB_OrderDineIn"
        Me.SB_OrderDineIn.Size = New System.Drawing.Size(212, 57)
        Me.SB_OrderDineIn.TabIndex = 41
        Me.SB_OrderDineIn.Tag = "1"
        Me.SB_OrderDineIn.Text = "Dine In"
        '
        'SB_OrderAll
        '
        Me.SB_OrderAll.Location = New System.Drawing.Point(104, 17)
        Me.SB_OrderAll.Name = "SB_OrderAll"
        Me.SB_OrderAll.Size = New System.Drawing.Size(212, 57)
        Me.SB_OrderAll.TabIndex = 40
        Me.SB_OrderAll.Tag = "0"
        Me.SB_OrderAll.Text = "All"
        '
        'PanelBuatFlyOut
        '
        Me.PanelBuatFlyOut.Location = New System.Drawing.Point(938, 377)
        Me.PanelBuatFlyOut.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelBuatFlyOut.Name = "PanelBuatFlyOut"
        Me.PanelBuatFlyOut.Size = New System.Drawing.Size(483, 112)
        Me.PanelBuatFlyOut.TabIndex = 43
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.FlyoutPanel2)
        Me.PanelControl1.Controls.Add(Me.FlyoutPanel_TableList)
        Me.PanelControl1.Controls.Add(Me.FlyoutPanel1)
        Me.PanelControl1.Controls.Add(Me.FlyoutPanel_ServerList)
        Me.PanelControl1.Controls.Add(Me.GridControl_OrderList)
        Me.PanelControl1.Controls.Add(Me.PanelBuatFlyOut)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 81)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1308, 606)
        Me.PanelControl1.TabIndex = 44
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 72)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1310, 715)
        Me.XtraTabControl1.TabIndex = 40
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Controls.Add(Me.PanelHeader)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1308, 687)
        Me.XtraTabPage1.Text = "XtraTabPage1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LayoutControl5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1308, 687)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'LayoutControl5
        '
        Me.LayoutControl5.Controls.Add(Me.Label_OrderNo)
        Me.LayoutControl5.Controls.Add(Me.GC_MenuType)
        Me.LayoutControl5.Controls.Add(Me.GridControl3)
        Me.LayoutControl5.Controls.Add(Me.PanelControl2)
        Me.LayoutControl5.Controls.Add(Me.Ed_Keyword)
        Me.LayoutControl5.Controls.Add(Me.View_menu_listGridControl)
        Me.LayoutControl5.Controls.Add(Me.GridControl1)
        Me.LayoutControl5.Controls.Add(Me.Panel1)
        Me.LayoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl5.Name = "LayoutControl5"
        Me.LayoutControl5.Root = Me.LayoutControlGroup5
        Me.LayoutControl5.Size = New System.Drawing.Size(1308, 687)
        Me.LayoutControl5.TabIndex = 1
        Me.LayoutControl5.Text = "LayoutControl5"
        '
        'Label_OrderNo
        '
        Me.Label_OrderNo.Appearance.Font = New System.Drawing.Font("Bahnschrift", 15.0!)
        Me.Label_OrderNo.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label_OrderNo.Appearance.Options.UseFont = True
        Me.Label_OrderNo.Appearance.Options.UseForeColor = True
        Me.Label_OrderNo.Appearance.Options.UseTextOptions = True
        Me.Label_OrderNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_OrderNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_OrderNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Label_OrderNo.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.Label_OrderNo.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.Label_OrderNo.LineVisible = True
        Me.Label_OrderNo.Location = New System.Drawing.Point(12, 74)
        Me.Label_OrderNo.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_OrderNo.Name = "Label_OrderNo"
        Me.Label_OrderNo.Size = New System.Drawing.Size(291, 24)
        Me.Label_OrderNo.StyleController = Me.LayoutControl5
        Me.Label_OrderNo.TabIndex = 41
        Me.Label_OrderNo.Text = "No. Order"
        '
        'GC_MenuType
        '
        Me.GC_MenuType.DataSource = Me.ViewMenuTypeListBindingSource
        Me.GC_MenuType.Location = New System.Drawing.Point(13, 159)
        Me.GC_MenuType.MainView = Me.TV_MenuType
        Me.GC_MenuType.Name = "GC_MenuType"
        Me.GC_MenuType.Size = New System.Drawing.Size(282, 166)
        Me.GC_MenuType.TabIndex = 12
        Me.GC_MenuType.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TV_MenuType})
        '
        'ViewMenuTypeListBindingSource
        '
        Me.ViewMenuTypeListBindingSource.DataMember = "View_MenuType_List"
        Me.ViewMenuTypeListBindingSource.DataSource = Me.DataSet
        '
        'TV_MenuType
        '
        Me.TV_MenuType.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_TVType, Me.colMenuTypeName_TVType, Me.colImage4})
        Me.TV_MenuType.GridControl = Me.GC_MenuType
        Me.TV_MenuType.Name = "TV_MenuType"
        Me.TV_MenuType.OptionsTiles.ColumnCount = 2
        Me.TV_MenuType.OptionsTiles.IndentBetweenItems = 3
        Me.TV_MenuType.OptionsTiles.ItemSize = New System.Drawing.Size(120, 60)
        Me.TV_MenuType.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TV_MenuType.OptionsTiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TV_MenuType.OptionsTiles.StretchItems = True
        Me.TV_MenuType.TileRows.Add(TableRowDefinition1)
        TileViewItemElement7.Column = Me.colMenuTypeName_TVType
        TileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement7.Text = "colMenuTypeName2"
        TileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TV_MenuType.TileTemplate.Add(TileViewItemElement7)
        '
        'colID_TVType
        '
        Me.colID_TVType.FieldName = "ID"
        Me.colID_TVType.Name = "colID_TVType"
        Me.colID_TVType.Visible = True
        Me.colID_TVType.VisibleIndex = 0
        '
        'colImage4
        '
        Me.colImage4.FieldName = "Image"
        Me.colImage4.Name = "colImage4"
        Me.colImage4.Visible = True
        Me.colImage4.VisibleIndex = 2
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.ViewPOSMenuCategoryFrontListBindingSource
        Me.GridControl3.Location = New System.Drawing.Point(13, 331)
        Me.GridControl3.MainView = Me.TV_MenuCategory
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(282, 333)
        Me.GridControl3.TabIndex = 11
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TV_MenuCategory})
        '
        'ViewPOSMenuCategoryFrontListBindingSource
        '
        Me.ViewPOSMenuCategoryFrontListBindingSource.DataMember = "View_POS_MenuCategory_FrontList"
        Me.ViewPOSMenuCategoryFrontListBindingSource.DataSource = Me.DataSet
        '
        'TV_MenuCategory
        '
        Me.TV_MenuCategory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_TVCategory, Me.colMenuCategoryName_TVCategory, Me.colMenuTypeID1, Me.colImage3})
        Me.TV_MenuCategory.GridControl = Me.GridControl3
        Me.TV_MenuCategory.Name = "TV_MenuCategory"
        Me.TV_MenuCategory.OptionsTiles.ColumnCount = 1
        Me.TV_MenuCategory.OptionsTiles.ItemSize = New System.Drawing.Size(200, 60)
        Me.TV_MenuCategory.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TV_MenuCategory.OptionsTiles.StretchItems = True
        Me.TV_MenuCategory.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
        Me.TV_MenuCategory.TileColumns.Add(TableColumnDefinition1)
        Me.TV_MenuCategory.TileRows.Add(TableRowDefinition2)
        Me.TV_MenuCategory.TileRows.Add(TableRowDefinition3)
        TileViewItemElement8.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Left
        TileViewItemElement8.Column = Me.colMenuCategoryName_TVCategory
        TileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement8.StretchHorizontal = True
        TileViewItemElement8.Text = "colMenuCategoryName_TVCategory"
        TileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        Me.TV_MenuCategory.TileTemplate.Add(TileViewItemElement8)
        '
        'colID_TVCategory
        '
        Me.colID_TVCategory.FieldName = "ID"
        Me.colID_TVCategory.Name = "colID_TVCategory"
        Me.colID_TVCategory.Visible = True
        Me.colID_TVCategory.VisibleIndex = 0
        '
        'colMenuTypeID1
        '
        Me.colMenuTypeID1.FieldName = "MenuTypeID"
        Me.colMenuTypeID1.Name = "colMenuTypeID1"
        Me.colMenuTypeID1.Visible = True
        Me.colMenuTypeID1.VisibleIndex = 2
        '
        'colImage3
        '
        Me.colImage3.FieldName = "Image"
        Me.colImage3.Name = "colImage3"
        Me.colImage3.Visible = True
        Me.colImage3.VisibleIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.SB_Back)
        Me.PanelControl2.Controls.Add(Me.SB_TableAndType)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl2.MaximumSize = New System.Drawing.Size(0, 76)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(291, 58)
        Me.PanelControl2.TabIndex = 6
        '
        'SB_Back
        '
        Me.SB_Back.AllowFocus = False
        Me.SB_Back.Dock = System.Windows.Forms.DockStyle.Left
        Me.SB_Back.ImageOptions.SvgImage = CType(resources.GetObject("SB_Back.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Back.Location = New System.Drawing.Point(0, 0)
        Me.SB_Back.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Back.Size = New System.Drawing.Size(56, 58)
        Me.SB_Back.TabIndex = 16
        '
        'SB_TableAndType
        '
        Me.SB_TableAndType.AllowFocus = False
        Me.SB_TableAndType.Appearance.Font = New System.Drawing.Font("Bahnschrift", 16.0!)
        Me.SB_TableAndType.Appearance.Options.UseFont = True
        Me.SB_TableAndType.Appearance.Options.UseTextOptions = True
        Me.SB_TableAndType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SB_TableAndType.AutoSize = True
        Me.SB_TableAndType.Location = New System.Drawing.Point(86, 17)
        Me.SB_TableAndType.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_TableAndType.MinimumSize = New System.Drawing.Size(200, 0)
        Me.SB_TableAndType.Name = "SB_TableAndType"
        Me.SB_TableAndType.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_TableAndType.Size = New System.Drawing.Size(200, 30)
        Me.SB_TableAndType.TabIndex = 15
        Me.SB_TableAndType.Text = "Table Name"
        '
        'Ed_Keyword
        '
        Me.Ed_Keyword.Location = New System.Drawing.Point(13, 107)
        Me.Ed_Keyword.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_Keyword.Name = "Ed_Keyword"
        Me.Ed_Keyword.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Ed_Keyword.Properties.Appearance.Options.UseFont = True
        Me.Ed_Keyword.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Keyword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Ed_Keyword.Size = New System.Drawing.Size(289, 46)
        Me.Ed_Keyword.StyleController = Me.LayoutControl5
        Me.Ed_Keyword.TabIndex = 9
        '
        'View_menu_listGridControl
        '
        Me.View_menu_listGridControl.DataSource = Me.ViewPOSMenuListMainListBindingSource
        Me.View_menu_listGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.View_menu_listGridControl.EmbeddedNavigator.ShowToolTips = False
        Me.View_menu_listGridControl.Location = New System.Drawing.Point(307, 20)
        Me.View_menu_listGridControl.MainView = Me.TileView_Menu
        Me.View_menu_listGridControl.Margin = New System.Windows.Forms.Padding(4)
        Me.View_menu_listGridControl.Name = "View_menu_listGridControl"
        Me.View_menu_listGridControl.Size = New System.Drawing.Size(531, 645)
        Me.View_menu_listGridControl.TabIndex = 5
        Me.View_menu_listGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView_Menu})
        '
        'ViewPOSMenuListMainListBindingSource
        '
        Me.ViewPOSMenuListMainListBindingSource.DataMember = "View_POS_MenuList_MainList"
        Me.ViewPOSMenuListMainListBindingSource.DataSource = Me.DataSet
        '
        'TileView_Menu
        '
        Me.TileView_Menu.Appearance.ItemNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TileView_Menu.Appearance.ItemNormal.Options.UseBackColor = True
        Me.TileView_Menu.AppearancePrint.FilterPanel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TileView_Menu.AppearancePrint.FilterPanel.Options.UseFont = True
        Me.TileView_Menu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TileView_Menu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Menu, Me.colMenuNo, Me.colMenuDisplay, Me.colMenuName, Me.colMenuCategoryID, Me.colCategoryName, Me.colMenuTypeID, Me.colTypeName, Me.colUoM, Me.colPrice, Me.colImage1, Me.colDescription})
        Me.TileView_Menu.DetailHeight = 485
        Me.TileView_Menu.GridControl = Me.View_menu_listGridControl
        Me.TileView_Menu.Name = "TileView_Menu"
        Me.TileView_Menu.OptionsBehavior.AllowSmoothScrolling = True
        Me.TileView_Menu.OptionsTiles.IndentBetweenItems = 4
        Me.TileView_Menu.OptionsTiles.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never
        Me.TileView_Menu.OptionsTiles.ItemSize = New System.Drawing.Size(150, 100)
        Me.TileView_Menu.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView_Menu.OptionsTiles.Padding = New System.Windows.Forms.Padding(6)
        Me.TileView_Menu.OptionsTiles.RowCount = 0
        Me.TileView_Menu.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None
        Me.TileView_Menu.OptionsTiles.ShowGroupText = False
        Me.TileView_Menu.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top
        TileViewItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        TileViewItemElement9.Appearance.Normal.Options.UseFont = True
        TileViewItemElement9.Appearance.Normal.Options.UseTextOptions = True
        TileViewItemElement9.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        TileViewItemElement9.Column = Me.colMenuDisplay
        TileViewItemElement9.Text = "colMenuDisplay"
        TileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        Me.TileView_Menu.TileTemplate.Add(TileViewItemElement9)
        '
        'colID_Menu
        '
        Me.colID_Menu.FieldName = "ID"
        Me.colID_Menu.MinWidth = 30
        Me.colID_Menu.Name = "colID_Menu"
        Me.colID_Menu.Visible = True
        Me.colID_Menu.VisibleIndex = 0
        Me.colID_Menu.Width = 112
        '
        'colMenuNo
        '
        Me.colMenuNo.FieldName = "MenuNo"
        Me.colMenuNo.MinWidth = 30
        Me.colMenuNo.Name = "colMenuNo"
        Me.colMenuNo.Visible = True
        Me.colMenuNo.VisibleIndex = 1
        Me.colMenuNo.Width = 112
        '
        'colMenuName
        '
        Me.colMenuName.FieldName = "MenuName"
        Me.colMenuName.MinWidth = 30
        Me.colMenuName.Name = "colMenuName"
        Me.colMenuName.Visible = True
        Me.colMenuName.VisibleIndex = 3
        Me.colMenuName.Width = 112
        '
        'colMenuCategoryID
        '
        Me.colMenuCategoryID.FieldName = "MenuCategoryID"
        Me.colMenuCategoryID.MinWidth = 30
        Me.colMenuCategoryID.Name = "colMenuCategoryID"
        Me.colMenuCategoryID.Visible = True
        Me.colMenuCategoryID.VisibleIndex = 4
        Me.colMenuCategoryID.Width = 112
        '
        'colCategoryName
        '
        Me.colCategoryName.FieldName = "CategoryName"
        Me.colCategoryName.MinWidth = 30
        Me.colCategoryName.Name = "colCategoryName"
        Me.colCategoryName.Visible = True
        Me.colCategoryName.VisibleIndex = 5
        Me.colCategoryName.Width = 112
        '
        'colMenuTypeID
        '
        Me.colMenuTypeID.FieldName = "MenuTypeID"
        Me.colMenuTypeID.MinWidth = 30
        Me.colMenuTypeID.Name = "colMenuTypeID"
        Me.colMenuTypeID.Visible = True
        Me.colMenuTypeID.VisibleIndex = 6
        Me.colMenuTypeID.Width = 112
        '
        'colTypeName
        '
        Me.colTypeName.FieldName = "TypeName"
        Me.colTypeName.MinWidth = 30
        Me.colTypeName.Name = "colTypeName"
        Me.colTypeName.Visible = True
        Me.colTypeName.VisibleIndex = 7
        Me.colTypeName.Width = 112
        '
        'colUoM
        '
        Me.colUoM.FieldName = "UoM"
        Me.colUoM.MinWidth = 30
        Me.colUoM.Name = "colUoM"
        Me.colUoM.Visible = True
        Me.colUoM.VisibleIndex = 8
        Me.colUoM.Width = 112
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MinWidth = 30
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 9
        Me.colPrice.Width = 112
        '
        'colImage1
        '
        Me.colImage1.FieldName = "Image"
        Me.colImage1.MinWidth = 30
        Me.colImage1.Name = "colImage1"
        Me.colImage1.Visible = True
        Me.colImage1.VisibleIndex = 10
        Me.colImage1.Width = 112
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 30
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 11
        Me.colDescription.Width = 112
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SpPOSOrderDetailGetDataBindingSource1
        Me.GridControl1.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.White
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseBorderColor = True
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Location = New System.Drawing.Point(873, 179)
        Me.GridControl1.MainView = Me.GV_OrderDetail
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_Num})
        Me.GridControl1.Size = New System.Drawing.Size(410, 473)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_OrderDetail})
        '
        'SpPOSOrderDetailGetDataBindingSource1
        '
        Me.SpPOSOrderDetailGetDataBindingSource1.DataMember = "sp_POS_OrderDetail_GetData"
        Me.SpPOSOrderDetailGetDataBindingSource1.DataSource = Me.DataSet
        '
        'GV_OrderDetail
        '
        Me.GV_OrderDetail.Appearance.FocusedRow.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GV_OrderDetail.Appearance.FocusedRow.Options.UseFont = True
        Me.GV_OrderDetail.Appearance.FooterPanel.BackColor = System.Drawing.Color.Transparent
        Me.GV_OrderDetail.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Transparent
        Me.GV_OrderDetail.Appearance.FooterPanel.Font = New System.Drawing.Font("Cambria", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GV_OrderDetail.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_OrderDetail.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_OrderDetail.Appearance.FooterPanel.Options.UseFont = True
        Me.GV_OrderDetail.Appearance.GroupFooter.BackColor = System.Drawing.Color.Transparent
        Me.GV_OrderDetail.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_OrderDetail.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Transparent
        Me.GV_OrderDetail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_OrderDetail.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_OrderDetail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_OrderDetail.Appearance.Row.Font = New System.Drawing.Font("Bahnschrift", 10.0!)
        Me.GV_OrderDetail.Appearance.Row.Options.UseFont = True
        Me.GV_OrderDetail.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV_OrderDetail.Appearance.SelectedRow.Font = New System.Drawing.Font("Bahnschrift", 10.0!)
        Me.GV_OrderDetail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_OrderDetail.Appearance.SelectedRow.Options.UseFont = True
        Me.GV_OrderDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GV_OrderDetail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_OD, Me.colOrderID_OD, Me.colMenuID_OD, Me.colMenuDisplay_OD, Me.colMenuName_OD, Me.colQty_OD, Me.colPrice_OD, Me.colDiscount_OD, Me.colSubtotal_OD, Me.colEmployeeID_OD, Me.colisProcess_OD, Me.colisHold_OD, Me.colisVoid_OD, Me.colModifiedDate_OD})
        Me.GV_OrderDetail.DetailHeight = 485
        Me.GV_OrderDetail.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GV_OrderDetail.GridControl = Me.GridControl1
        Me.GV_OrderDetail.Name = "GV_OrderDetail"
        Me.GV_OrderDetail.OptionsCustomization.AllowColumnMoving = False
        Me.GV_OrderDetail.OptionsCustomization.AllowColumnResizing = False
        Me.GV_OrderDetail.OptionsCustomization.AllowFilter = False
        Me.GV_OrderDetail.OptionsCustomization.AllowGroup = False
        Me.GV_OrderDetail.OptionsCustomization.AllowSort = False
        Me.GV_OrderDetail.OptionsEditForm.PopupEditFormWidth = 1200
        Me.GV_OrderDetail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_OrderDetail.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GV_OrderDetail.OptionsView.ShowDetailButtons = False
        Me.GV_OrderDetail.OptionsView.ShowFooter = True
        Me.GV_OrderDetail.OptionsView.ShowGroupPanel = False
        Me.GV_OrderDetail.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GV_OrderDetail.OptionsView.ShowIndicator = False
        '
        'colID_OD
        '
        Me.colID_OD.FieldName = "ID"
        Me.colID_OD.MinWidth = 30
        Me.colID_OD.Name = "colID_OD"
        Me.colID_OD.OptionsColumn.AllowEdit = False
        Me.colID_OD.OptionsColumn.AllowFocus = False
        Me.colID_OD.Width = 112
        '
        'colOrderID_OD
        '
        Me.colOrderID_OD.FieldName = "OrderID"
        Me.colOrderID_OD.MinWidth = 30
        Me.colOrderID_OD.Name = "colOrderID_OD"
        Me.colOrderID_OD.OptionsColumn.AllowEdit = False
        Me.colOrderID_OD.OptionsColumn.AllowFocus = False
        Me.colOrderID_OD.Width = 112
        '
        'colMenuID_OD
        '
        Me.colMenuID_OD.FieldName = "MenuID"
        Me.colMenuID_OD.MinWidth = 30
        Me.colMenuID_OD.Name = "colMenuID_OD"
        Me.colMenuID_OD.OptionsColumn.AllowEdit = False
        Me.colMenuID_OD.OptionsColumn.AllowFocus = False
        Me.colMenuID_OD.Width = 112
        '
        'colMenuDisplay_OD
        '
        Me.colMenuDisplay_OD.Caption = "Menu"
        Me.colMenuDisplay_OD.FieldName = "MenuDisplay"
        Me.colMenuDisplay_OD.MinWidth = 30
        Me.colMenuDisplay_OD.Name = "colMenuDisplay_OD"
        Me.colMenuDisplay_OD.OptionsColumn.AllowEdit = False
        Me.colMenuDisplay_OD.OptionsColumn.AllowFocus = False
        Me.colMenuDisplay_OD.OptionsFilter.AllowFilter = False
        Me.colMenuDisplay_OD.Visible = True
        Me.colMenuDisplay_OD.VisibleIndex = 1
        Me.colMenuDisplay_OD.Width = 354
        '
        'colMenuName_OD
        '
        Me.colMenuName_OD.FieldName = "MenuName"
        Me.colMenuName_OD.MinWidth = 30
        Me.colMenuName_OD.Name = "colMenuName_OD"
        Me.colMenuName_OD.OptionsColumn.AllowEdit = False
        Me.colMenuName_OD.OptionsColumn.AllowFocus = False
        Me.colMenuName_OD.Width = 112
        '
        'colQty_OD
        '
        Me.colQty_OD.Caption = "#"
        Me.colQty_OD.ColumnEdit = Me.Repo_Num
        Me.colQty_OD.DisplayFormat.FormatString = "n0"
        Me.colQty_OD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQty_OD.FieldName = "Qty"
        Me.colQty_OD.MaxWidth = 40
        Me.colQty_OD.MinWidth = 40
        Me.colQty_OD.Name = "colQty_OD"
        Me.colQty_OD.OptionsColumn.AllowEdit = False
        Me.colQty_OD.OptionsColumn.AllowFocus = False
        Me.colQty_OD.OptionsFilter.AllowFilter = False
        Me.colQty_OD.Visible = True
        Me.colQty_OD.VisibleIndex = 0
        Me.colQty_OD.Width = 40
        '
        'Repo_Num
        '
        Me.Repo_Num.Appearance.Options.UseTextOptions = True
        Me.Repo_Num.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Repo_Num.AutoHeight = False
        Me.Repo_Num.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Repo_Num.MaskSettings.Set("mask", "n0")
        Me.Repo_Num.Name = "Repo_Num"
        Me.Repo_Num.UseMaskAsDisplayFormat = True
        '
        'colPrice_OD
        '
        Me.colPrice_OD.ColumnEdit = Me.Repo_Num
        Me.colPrice_OD.FieldName = "Price"
        Me.colPrice_OD.MinWidth = 30
        Me.colPrice_OD.Name = "colPrice_OD"
        Me.colPrice_OD.OptionsColumn.AllowEdit = False
        Me.colPrice_OD.OptionsColumn.AllowFocus = False
        Me.colPrice_OD.Width = 112
        '
        'colDiscount_OD
        '
        Me.colDiscount_OD.FieldName = "Discount"
        Me.colDiscount_OD.MinWidth = 30
        Me.colDiscount_OD.Name = "colDiscount_OD"
        Me.colDiscount_OD.OptionsColumn.AllowEdit = False
        Me.colDiscount_OD.OptionsColumn.AllowFocus = False
        Me.colDiscount_OD.Width = 112
        '
        'colSubtotal_OD
        '
        Me.colSubtotal_OD.Caption = "Sub Total"
        Me.colSubtotal_OD.ColumnEdit = Me.Repo_Num
        Me.colSubtotal_OD.DisplayFormat.FormatString = "n0"
        Me.colSubtotal_OD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotal_OD.FieldName = "Subtotal"
        Me.colSubtotal_OD.MaxWidth = 120
        Me.colSubtotal_OD.MinWidth = 120
        Me.colSubtotal_OD.Name = "colSubtotal_OD"
        Me.colSubtotal_OD.OptionsColumn.AllowEdit = False
        Me.colSubtotal_OD.OptionsColumn.AllowFocus = False
        Me.colSubtotal_OD.OptionsFilter.AllowFilter = False
        Me.colSubtotal_OD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "{0:n0}")})
        Me.colSubtotal_OD.Visible = True
        Me.colSubtotal_OD.VisibleIndex = 2
        Me.colSubtotal_OD.Width = 120
        '
        'colEmployeeID_OD
        '
        Me.colEmployeeID_OD.FieldName = "EmployeeID"
        Me.colEmployeeID_OD.MinWidth = 30
        Me.colEmployeeID_OD.Name = "colEmployeeID_OD"
        Me.colEmployeeID_OD.OptionsColumn.AllowEdit = False
        Me.colEmployeeID_OD.OptionsColumn.AllowFocus = False
        Me.colEmployeeID_OD.Width = 112
        '
        'colisProcess_OD
        '
        Me.colisProcess_OD.FieldName = "isProcess"
        Me.colisProcess_OD.MinWidth = 30
        Me.colisProcess_OD.Name = "colisProcess_OD"
        Me.colisProcess_OD.OptionsColumn.AllowEdit = False
        Me.colisProcess_OD.OptionsColumn.AllowFocus = False
        Me.colisProcess_OD.Width = 112
        '
        'colisHold_OD
        '
        Me.colisHold_OD.FieldName = "isHold"
        Me.colisHold_OD.MinWidth = 30
        Me.colisHold_OD.Name = "colisHold_OD"
        Me.colisHold_OD.OptionsColumn.AllowEdit = False
        Me.colisHold_OD.OptionsColumn.AllowFocus = False
        Me.colisHold_OD.Width = 112
        '
        'colisVoid_OD
        '
        Me.colisVoid_OD.FieldName = "isVoid"
        Me.colisVoid_OD.MinWidth = 30
        Me.colisVoid_OD.Name = "colisVoid_OD"
        Me.colisVoid_OD.OptionsColumn.AllowEdit = False
        Me.colisVoid_OD.OptionsColumn.AllowFocus = False
        Me.colisVoid_OD.Width = 112
        '
        'colModifiedDate_OD
        '
        Me.colModifiedDate_OD.FieldName = "ModifiedDate"
        Me.colModifiedDate_OD.MinWidth = 30
        Me.colModifiedDate_OD.Name = "colModifiedDate_OD"
        Me.colModifiedDate_OD.OptionsColumn.AllowEdit = False
        Me.colModifiedDate_OD.OptionsColumn.AllowFocus = False
        Me.colModifiedDate_OD.Width = 112
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SB_Preview)
        Me.Panel1.Controls.Add(Me.SB_Payment)
        Me.Panel1.Controls.Add(Me.LabelControl8)
        Me.Panel1.Controls.Add(Me.LabelControl7)
        Me.Panel1.Controls.Add(Me.Label_Diskon)
        Me.Panel1.Controls.Add(Me.Label_Pembulatan)
        Me.Panel1.Controls.Add(Me.SB_Submit)
        Me.Panel1.Controls.Add(Me.Label_Total)
        Me.Panel1.Controls.Add(Me.Label_PPn)
        Me.Panel1.Controls.Add(Me.LabelControl3)
        Me.Panel1.Controls.Add(Me.Label_Subtotal)
        Me.Panel1.Location = New System.Drawing.Point(873, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 133)
        Me.Panel1.TabIndex = 22
        '
        'SB_Preview
        '
        Me.SB_Preview.ImageOptions.Image = CType(resources.GetObject("SB_Preview.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Preview.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_Preview.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.SB_Preview.Location = New System.Drawing.Point(16, 13)
        Me.SB_Preview.Name = "SB_Preview"
        Me.SB_Preview.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Preview.Size = New System.Drawing.Size(53, 53)
        Me.SB_Preview.TabIndex = 44
        Me.SB_Preview.Text = "Preview"
        '
        'SB_Payment
        '
        Me.SB_Payment.Appearance.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Bold)
        Me.SB_Payment.Appearance.Options.UseFont = True
        Me.SB_Payment.ImageOptions.Image = CType(resources.GetObject("SB_Payment.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Payment.Location = New System.Drawing.Point(17, 73)
        Me.SB_Payment.Name = "SB_Payment"
        Me.SB_Payment.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Payment.Size = New System.Drawing.Size(116, 56)
        Me.SB_Payment.TabIndex = 43
        Me.SB_Payment.Text = "Payment"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.AutoEllipsis = True
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl8.Location = New System.Drawing.Point(136, 11)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(119, 19)
        Me.LabelControl8.TabIndex = 42
        Me.LabelControl8.Text = "Sub Total :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoEllipsis = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl7.Location = New System.Drawing.Point(157, 90)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(136, 19)
        Me.LabelControl7.TabIndex = 41
        Me.LabelControl7.Text = "Pembulatan :"
        Me.LabelControl7.Visible = False
        '
        'Label_Diskon
        '
        Me.Label_Diskon.Appearance.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label_Diskon.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label_Diskon.Appearance.Options.UseFont = True
        Me.Label_Diskon.Appearance.Options.UseForeColor = True
        Me.Label_Diskon.Appearance.Options.UseTextOptions = True
        Me.Label_Diskon.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_Diskon.AutoEllipsis = True
        Me.Label_Diskon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label_Diskon.Location = New System.Drawing.Point(177, 103)
        Me.Label_Diskon.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_Diskon.Name = "Label_Diskon"
        Me.Label_Diskon.Size = New System.Drawing.Size(116, 19)
        Me.Label_Diskon.TabIndex = 40
        Me.Label_Diskon.Text = "Nom Diskon"
        Me.Label_Diskon.Visible = False
        '
        'Label_Pembulatan
        '
        Me.Label_Pembulatan.Appearance.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label_Pembulatan.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label_Pembulatan.Appearance.Options.UseFont = True
        Me.Label_Pembulatan.Appearance.Options.UseForeColor = True
        Me.Label_Pembulatan.Appearance.Options.UseTextOptions = True
        Me.Label_Pembulatan.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_Pembulatan.AutoEllipsis = True
        Me.Label_Pembulatan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label_Pembulatan.Location = New System.Drawing.Point(157, 73)
        Me.Label_Pembulatan.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_Pembulatan.Name = "Label_Pembulatan"
        Me.Label_Pembulatan.Size = New System.Drawing.Size(116, 19)
        Me.Label_Pembulatan.TabIndex = 39
        Me.Label_Pembulatan.Text = "PPn 10 % :"
        Me.Label_Pembulatan.Visible = False
        '
        'SB_Submit
        '
        Me.SB_Submit.ImageOptions.Image = CType(resources.GetObject("SB_Submit.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Submit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_Submit.Location = New System.Drawing.Point(76, 22)
        Me.SB_Submit.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Submit.Size = New System.Drawing.Size(57, 44)
        Me.SB_Submit.TabIndex = 17
        Me.SB_Submit.Text = "Payment"
        '
        'Label_Total
        '
        Me.Label_Total.Appearance.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Total.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label_Total.Appearance.Options.UseFont = True
        Me.Label_Total.Appearance.Options.UseForeColor = True
        Me.Label_Total.Appearance.Options.UseTextOptions = True
        Me.Label_Total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_Total.AutoEllipsis = True
        Me.Label_Total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label_Total.Location = New System.Drawing.Point(233, 81)
        Me.Label_Total.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_Total.Name = "Label_Total"
        Me.Label_Total.Size = New System.Drawing.Size(163, 29)
        Me.Label_Total.TabIndex = 19
        Me.Label_Total.Text = "Total"
        '
        'Label_PPn
        '
        Me.Label_PPn.Appearance.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label_PPn.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label_PPn.Appearance.Options.UseFont = True
        Me.Label_PPn.Appearance.Options.UseForeColor = True
        Me.Label_PPn.Appearance.Options.UseTextOptions = True
        Me.Label_PPn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_PPn.AutoEllipsis = True
        Me.Label_PPn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label_PPn.Location = New System.Drawing.Point(263, 40)
        Me.Label_PPn.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_PPn.Name = "Label_PPn"
        Me.Label_PPn.Size = New System.Drawing.Size(133, 19)
        Me.Label_PPn.TabIndex = 18
        Me.Label_PPn.Text = "Pajak  :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoEllipsis = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl3.Location = New System.Drawing.Point(104, 41)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(151, 19)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Pajak Daerah :"
        '
        'Label_Subtotal
        '
        Me.Label_Subtotal.Appearance.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Subtotal.Appearance.ForeColor = System.Drawing.Color.Red
        Me.Label_Subtotal.Appearance.Options.UseFont = True
        Me.Label_Subtotal.Appearance.Options.UseForeColor = True
        Me.Label_Subtotal.Appearance.Options.UseTextOptions = True
        Me.Label_Subtotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_Subtotal.AutoEllipsis = True
        Me.Label_Subtotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label_Subtotal.Location = New System.Drawing.Point(263, 13)
        Me.Label_Subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_Subtotal.Name = "Label_Subtotal"
        Me.Label_Subtotal.Size = New System.Drawing.Size(133, 19)
        Me.Label_Subtotal.TabIndex = 14
        Me.Label_Subtotal.Text = "Charge "
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LCItem_MenuType, Me.LCItem_MenuCategory, Me.LayoutControlItem2, Me.LayoutControlItem15, Me.LayoutControlGroup6, Me.LCItem_Keyword})
        Me.LayoutControlGroup5.Name = "Root"
        Me.LayoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 20)
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1308, 687)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.View_menu_listGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(295, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem4"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(535, 657)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LCItem_MenuType
        '
        Me.LCItem_MenuType.Control = Me.GC_MenuType
        Me.LCItem_MenuType.Location = New System.Drawing.Point(0, 146)
        Me.LCItem_MenuType.MaxSize = New System.Drawing.Size(295, 172)
        Me.LCItem_MenuType.MinSize = New System.Drawing.Size(295, 172)
        Me.LCItem_MenuType.Name = "LCItem_MenuType"
        Me.LCItem_MenuType.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 10, 3, 3)
        Me.LCItem_MenuType.Size = New System.Drawing.Size(295, 172)
        Me.LCItem_MenuType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LCItem_MenuType.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_MenuType.TextVisible = False
        '
        'LCItem_MenuCategory
        '
        Me.LCItem_MenuCategory.Control = Me.GridControl3
        Me.LCItem_MenuCategory.Location = New System.Drawing.Point(0, 318)
        Me.LCItem_MenuCategory.Name = "LCItem_MenuCategory"
        Me.LCItem_MenuCategory.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 10, 3, 3)
        Me.LCItem_MenuCategory.Size = New System.Drawing.Size(295, 339)
        Me.LCItem_MenuCategory.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_MenuCategory.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem3"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(295, 62)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Label_OrderNo
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem15.Name = "LayoutControlItem12"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(295, 28)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AppearanceGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup6.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlGroup6.ExpandButtonVisible = True
        Me.LayoutControlGroup6.GroupStyle = DevExpress.Utils.GroupStyle.Light
        Me.LayoutControlGroup6.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem16, Me.LayoutControlItem36})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(830, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(458, 657)
        Me.LayoutControlGroup6.Text = ".:: Detail Pembelanjaan ::."
        Me.LayoutControlGroup6.TextLocation = DevExpress.Utils.Locations.Left
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.GridControl1
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 151)
        Me.LayoutControlItem16.Name = "LayoutControlItem1"
        Me.LayoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 3)
        Me.LayoutControlItem16.Size = New System.Drawing.Size(416, 483)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.Panel1
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem36.MaxSize = New System.Drawing.Size(416, 151)
        Me.LayoutControlItem36.MinSize = New System.Drawing.Size(416, 151)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 15)
        Me.LayoutControlItem36.Size = New System.Drawing.Size(416, 151)
        Me.LayoutControlItem36.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextVisible = False
        '
        'LCItem_Keyword
        '
        Me.LCItem_Keyword.Control = Me.Ed_Keyword
        Me.LCItem_Keyword.Location = New System.Drawing.Point(0, 90)
        Me.LCItem_Keyword.Name = "LCItem_Keyword"
        Me.LCItem_Keyword.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 7, 3)
        Me.LCItem_Keyword.Size = New System.Drawing.Size(295, 56)
        Me.LCItem_Keyword.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_Keyword.TextVisible = False
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.FlyoutPanel_Cancel)
        Me.XtraTabPage3.Controls.Add(Me.FlyoutPanel_UpdateQty)
        Me.XtraTabPage3.Controls.Add(Me.FlyoutPanel_POSPayment)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1308, 687)
        Me.XtraTabPage3.Text = "XtraTabPage3"
        '
        'FlyoutPanel_Cancel
        '
        Me.FlyoutPanel_Cancel.Controls.Add(Me.FlyoutPanelControl_Cancel)
        Me.FlyoutPanel_Cancel.Location = New System.Drawing.Point(828, 316)
        Me.FlyoutPanel_Cancel.Name = "FlyoutPanel_Cancel"
        Me.FlyoutPanel_Cancel.Options.CloseOnOuterClick = True
        Me.FlyoutPanel_Cancel.OwnerControl = Me.GridControl1
        Me.FlyoutPanel_Cancel.Size = New System.Drawing.Size(350, 162)
        Me.FlyoutPanel_Cancel.TabIndex = 84
        '
        'FlyoutPanelControl_Cancel
        '
        Me.FlyoutPanelControl_Cancel.Controls.Add(Me.LookUpEdit_VoidReason)
        Me.FlyoutPanelControl_Cancel.Controls.Add(Me.SB_Remove)
        Me.FlyoutPanelControl_Cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl_Cancel.FlyoutPanel = Me.FlyoutPanel_Cancel
        Me.FlyoutPanelControl_Cancel.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl_Cancel.Name = "FlyoutPanelControl_Cancel"
        Me.FlyoutPanelControl_Cancel.Size = New System.Drawing.Size(350, 162)
        Me.FlyoutPanelControl_Cancel.TabIndex = 0
        '
        'LookUpEdit_VoidReason
        '
        Me.LookUpEdit_VoidReason.Location = New System.Drawing.Point(18, 35)
        Me.LookUpEdit_VoidReason.Margin = New System.Windows.Forms.Padding(4)
        Me.LookUpEdit_VoidReason.Name = "LookUpEdit_VoidReason"
        Me.LookUpEdit_VoidReason.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LookUpEdit_VoidReason.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.LookUpEdit_VoidReason.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.LookUpEdit_VoidReason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_VoidReason.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("VoidReason", "Void Reason", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit_VoidReason.Properties.DataSource = Me.SpPOSMDVoidReasonGetDataBindingSource
        Me.LookUpEdit_VoidReason.Properties.DisplayMember = "VoidReason"
        Me.LookUpEdit_VoidReason.Properties.NullText = ""
        Me.LookUpEdit_VoidReason.Properties.ValueMember = "ID"
        Me.LookUpEdit_VoidReason.Size = New System.Drawing.Size(316, 40)
        Me.LookUpEdit_VoidReason.TabIndex = 77
        '
        'SpPOSMDVoidReasonGetDataBindingSource
        '
        Me.SpPOSMDVoidReasonGetDataBindingSource.DataMember = "sp_POS_MDVoidReason_GetData"
        Me.SpPOSMDVoidReasonGetDataBindingSource.DataSource = Me.DataSet
        '
        'SB_Remove
        '
        Me.SB_Remove.Appearance.Font = New System.Drawing.Font("Segoe UI", 25.0!)
        Me.SB_Remove.Appearance.Options.UseFont = True
        Me.SB_Remove.Location = New System.Drawing.Point(19, 106)
        Me.SB_Remove.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Remove.Name = "SB_Remove"
        Me.SB_Remove.Size = New System.Drawing.Size(315, 50)
        Me.SB_Remove.TabIndex = 78
        Me.SB_Remove.Text = "Submit"
        '
        'FlyoutPanel_UpdateQty
        '
        Me.FlyoutPanel_UpdateQty.Controls.Add(Me.FlyoutPanelControl_UpdateQty)
        Me.FlyoutPanel_UpdateQty.Location = New System.Drawing.Point(828, 56)
        Me.FlyoutPanel_UpdateQty.Name = "FlyoutPanel_UpdateQty"
        Me.FlyoutPanel_UpdateQty.Options.CloseOnOuterClick = True
        Me.FlyoutPanel_UpdateQty.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.FlyoutPanel_UpdateQty.OwnerControl = Me.GridControl1
        Me.FlyoutPanel_UpdateQty.Size = New System.Drawing.Size(420, 202)
        Me.FlyoutPanel_UpdateQty.TabIndex = 83
        '
        'FlyoutPanelControl_UpdateQty
        '
        Me.FlyoutPanelControl_UpdateQty.Controls.Add(Me.Label_MenuName_Memo)
        Me.FlyoutPanelControl_UpdateQty.Controls.Add(Me.SpinEdit_Qty)
        Me.FlyoutPanelControl_UpdateQty.Controls.Add(Me.Ed_Price)
        Me.FlyoutPanelControl_UpdateQty.Controls.Add(Me.SB_Update)
        Me.FlyoutPanelControl_UpdateQty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl_UpdateQty.FlyoutPanel = Me.FlyoutPanel_UpdateQty
        Me.FlyoutPanelControl_UpdateQty.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl_UpdateQty.Name = "FlyoutPanelControl_UpdateQty"
        Me.FlyoutPanelControl_UpdateQty.Size = New System.Drawing.Size(420, 202)
        Me.FlyoutPanelControl_UpdateQty.TabIndex = 0
        '
        'Label_MenuName_Memo
        '
        Me.Label_MenuName_Memo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label_MenuName_Memo.Appearance.Options.UseFont = True
        Me.Label_MenuName_Memo.Appearance.Options.UseTextOptions = True
        Me.Label_MenuName_Memo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_MenuName_Memo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.Label_MenuName_Memo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_MenuName_Memo.Location = New System.Drawing.Point(6, 12)
        Me.Label_MenuName_Memo.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_MenuName_Memo.Name = "Label_MenuName_Memo"
        Me.Label_MenuName_Memo.Size = New System.Drawing.Size(408, 42)
        Me.Label_MenuName_Memo.TabIndex = 79
        Me.Label_MenuName_Memo.Text = "LabelControl3"
        '
        'SpinEdit_Qty
        '
        Me.SpinEdit_Qty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit_Qty.Location = New System.Drawing.Point(27, 132)
        Me.SpinEdit_Qty.Margin = New System.Windows.Forms.Padding(4)
        Me.SpinEdit_Qty.Name = "SpinEdit_Qty"
        Me.SpinEdit_Qty.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.SpinEdit_Qty.Properties.Appearance.Options.UseFont = True
        Me.SpinEdit_Qty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit_Qty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.SpinEdit_Qty.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.SpinEdit_Qty.Properties.MaskSettings.Set("mask", "n0")
        Me.SpinEdit_Qty.Size = New System.Drawing.Size(127, 46)
        Me.SpinEdit_Qty.TabIndex = 5
        '
        'Ed_Price
        '
        Me.Ed_Price.EditValue = "0"
        Me.Ed_Price.Location = New System.Drawing.Point(48, 62)
        Me.Ed_Price.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_Price.Name = "Ed_Price"
        Me.Ed_Price.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Ed_Price.Properties.Appearance.Options.UseFont = True
        Me.Ed_Price.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Price.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ed_Price.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Price.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Price.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Price.Properties.ReadOnly = True
        Me.Ed_Price.Size = New System.Drawing.Size(294, 48)
        Me.Ed_Price.TabIndex = 80
        '
        'SB_Update
        '
        Me.SB_Update.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_Update.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SB_Update.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.SB_Update.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.SB_Update.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.SB_Update.Appearance.Options.UseBackColor = True
        Me.SB_Update.Appearance.Options.UseBorderColor = True
        Me.SB_Update.Appearance.Options.UseFont = True
        Me.SB_Update.Appearance.Options.UseTextOptions = True
        Me.SB_Update.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SB_Update.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SB_Update.Location = New System.Drawing.Point(187, 135)
        Me.SB_Update.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Update.Name = "SB_Update"
        Me.SB_Update.Size = New System.Drawing.Size(209, 44)
        Me.SB_Update.TabIndex = 76
        Me.SB_Update.Text = "Update"
        '
        'FlyoutPanel_POSPayment
        '
        Me.FlyoutPanel_POSPayment.Controls.Add(Me.FlyoutPanelControl_POSPayment)
        Me.FlyoutPanel_POSPayment.Location = New System.Drawing.Point(97, 17)
        Me.FlyoutPanel_POSPayment.Name = "FlyoutPanel_POSPayment"
        Me.FlyoutPanel_POSPayment.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Center
        Me.FlyoutPanel_POSPayment.Options.CloseOnOuterClick = True
        Me.FlyoutPanel_POSPayment.OwnerControl = Me
        Me.FlyoutPanel_POSPayment.Size = New System.Drawing.Size(547, 722)
        Me.FlyoutPanel_POSPayment.TabIndex = 35
        '
        'FlyoutPanelControl_POSPayment
        '
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_Validasi)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_20000)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_2000)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Ed_Rounding)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.LabelControl5)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_5000)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_1000)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_10000)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_50000)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.CB_Tunai)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.LabelControl11)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.LabelControl1)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Ed_Bill)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Label_Bank)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_FinishPayment)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Ed_CardValue)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.CB_Debit)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.CB_Credit)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.CB_QRIS)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Label4)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.CB_Minus)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.CB_Plus)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Ed_Change)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_RoundNominal)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.SB_Reset)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.LabelControl4)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.LabelControl2)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.LookUpEdit_Bank)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Ed_CardNo)
        Me.FlyoutPanelControl_POSPayment.Controls.Add(Me.Ed_Payment)
        Me.FlyoutPanelControl_POSPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl_POSPayment.FlyoutPanel = Me.FlyoutPanel_POSPayment
        Me.FlyoutPanelControl_POSPayment.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl_POSPayment.Name = "FlyoutPanelControl_POSPayment"
        Me.FlyoutPanelControl_POSPayment.Size = New System.Drawing.Size(547, 722)
        Me.FlyoutPanelControl_POSPayment.TabIndex = 0
        '
        'SB_Validasi
        '
        Me.SB_Validasi.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.SB_Validasi.Appearance.Options.UseFont = True
        Me.SB_Validasi.ImageOptions.Image = CType(resources.GetObject("SB_Validasi.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Validasi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SB_Validasi.Location = New System.Drawing.Point(23, 71)
        Me.SB_Validasi.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Validasi.Name = "SB_Validasi"
        Me.SB_Validasi.Size = New System.Drawing.Size(114, 106)
        Me.SB_Validasi.TabIndex = 46
        Me.SB_Validasi.Text = "Validasi"
        '
        'SB_20000
        '
        Me.SB_20000.Location = New System.Drawing.Point(134, 511)
        Me.SB_20000.Name = "SB_20000"
        Me.SB_20000.Size = New System.Drawing.Size(102, 59)
        Me.SB_20000.TabIndex = 45
        Me.SB_20000.Tag = "20000"
        Me.SB_20000.Text = "20.000"
        '
        'SB_2000
        '
        Me.SB_2000.Location = New System.Drawing.Point(26, 641)
        Me.SB_2000.Name = "SB_2000"
        Me.SB_2000.Size = New System.Drawing.Size(102, 59)
        Me.SB_2000.TabIndex = 44
        Me.SB_2000.Tag = "2000"
        Me.SB_2000.Text = "2.000"
        '
        'Ed_Rounding
        '
        Me.Ed_Rounding.EditValue = "-1000"
        Me.Ed_Rounding.Location = New System.Drawing.Point(255, 21)
        Me.Ed_Rounding.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_Rounding.Name = "Ed_Rounding"
        Me.Ed_Rounding.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Ed_Rounding.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Ed_Rounding.Properties.Appearance.Options.UseBackColor = True
        Me.Ed_Rounding.Properties.Appearance.Options.UseFont = True
        Me.Ed_Rounding.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Rounding.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Rounding.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ed_Rounding.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Rounding.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Rounding.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Rounding.Properties.ReadOnly = True
        Me.Ed_Rounding.Size = New System.Drawing.Size(248, 40)
        Me.Ed_Rounding.TabIndex = 43
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(48, 30)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(188, 25)
        Me.LabelControl5.TabIndex = 42
        Me.LabelControl5.Text = "Pembulatan Tunai :"
        '
        'SB_5000
        '
        Me.SB_5000.Location = New System.Drawing.Point(134, 576)
        Me.SB_5000.Name = "SB_5000"
        Me.SB_5000.Size = New System.Drawing.Size(102, 59)
        Me.SB_5000.TabIndex = 41
        Me.SB_5000.Tag = "5000"
        Me.SB_5000.Text = "5.000"
        '
        'SB_1000
        '
        Me.SB_1000.Location = New System.Drawing.Point(134, 641)
        Me.SB_1000.Name = "SB_1000"
        Me.SB_1000.Size = New System.Drawing.Size(102, 59)
        Me.SB_1000.TabIndex = 40
        Me.SB_1000.Tag = "1000"
        Me.SB_1000.Text = "1.000"
        '
        'SB_10000
        '
        Me.SB_10000.Location = New System.Drawing.Point(26, 576)
        Me.SB_10000.Name = "SB_10000"
        Me.SB_10000.Size = New System.Drawing.Size(102, 59)
        Me.SB_10000.TabIndex = 39
        Me.SB_10000.Tag = "10000"
        Me.SB_10000.Text = "10.000"
        '
        'SB_50000
        '
        Me.SB_50000.Location = New System.Drawing.Point(24, 511)
        Me.SB_50000.Name = "SB_50000"
        Me.SB_50000.Size = New System.Drawing.Size(102, 59)
        Me.SB_50000.TabIndex = 38
        Me.SB_50000.Tag = "50000"
        Me.SB_50000.Text = "50.000"
        '
        'CB_Tunai
        '
        Me.CB_Tunai.AllowFocus = False
        Me.CB_Tunai.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Tunai.Appearance.Options.UseFont = True
        Me.CB_Tunai.GroupIndex = 1
        Me.CB_Tunai.Location = New System.Drawing.Point(24, 448)
        Me.CB_Tunai.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Tunai.Name = "CB_Tunai"
        Me.CB_Tunai.Size = New System.Drawing.Size(136, 50)
        Me.CB_Tunai.TabIndex = 37
        Me.CB_Tunai.TabStop = False
        Me.CB_Tunai.Tag = "1"
        Me.CB_Tunai.Text = "Hanya Tunai"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl11.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl11.LineVisible = True
        Me.LabelControl11.Location = New System.Drawing.Point(24, 209)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(482, 18)
        Me.LabelControl11.TabIndex = 36
        Me.LabelControl11.Text = "Non Tunai"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl1.LineVisible = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 418)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(482, 18)
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "Tunai"
        '
        'Ed_Bill
        '
        Me.Ed_Bill.EditValue = "0"
        Me.Ed_Bill.Location = New System.Drawing.Point(255, 73)
        Me.Ed_Bill.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_Bill.Name = "Ed_Bill"
        Me.Ed_Bill.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Ed_Bill.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Ed_Bill.Properties.Appearance.Options.UseBackColor = True
        Me.Ed_Bill.Properties.Appearance.Options.UseFont = True
        Me.Ed_Bill.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Bill.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Bill.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ed_Bill.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Bill.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Bill.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Bill.Properties.ReadOnly = True
        Me.Ed_Bill.Size = New System.Drawing.Size(248, 40)
        Me.Ed_Bill.TabIndex = 34
        '
        'Label_Bank
        '
        Me.Label_Bank.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Bank.Appearance.Options.UseFont = True
        Me.Label_Bank.Location = New System.Drawing.Point(194, 80)
        Me.Label_Bank.Margin = New System.Windows.Forms.Padding(4)
        Me.Label_Bank.Name = "Label_Bank"
        Me.Label_Bank.Size = New System.Drawing.Size(42, 25)
        Me.Label_Bank.TabIndex = 20
        Me.Label_Bank.Text = "Bill :"
        '
        'SB_FinishPayment
        '
        Me.SB_FinishPayment.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.SB_FinishPayment.Appearance.Options.UseFont = True
        Me.SB_FinishPayment.Enabled = False
        Me.SB_FinishPayment.ImageOptions.Image = CType(resources.GetObject("SB_FinishPayment.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_FinishPayment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SB_FinishPayment.Location = New System.Drawing.Point(343, 581)
        Me.SB_FinishPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_FinishPayment.Name = "SB_FinishPayment"
        Me.SB_FinishPayment.Size = New System.Drawing.Size(163, 119)
        Me.SB_FinishPayment.TabIndex = 8
        Me.SB_FinishPayment.Text = "Pembayaran"
        '
        'Ed_CardValue
        '
        Me.Ed_CardValue.EditValue = "0"
        Me.Ed_CardValue.Location = New System.Drawing.Point(255, 357)
        Me.Ed_CardValue.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_CardValue.Name = "Ed_CardValue"
        Me.Ed_CardValue.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Ed_CardValue.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Ed_CardValue.Properties.Appearance.Options.UseBackColor = True
        Me.Ed_CardValue.Properties.Appearance.Options.UseFont = True
        Me.Ed_CardValue.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_CardValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_CardValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ed_CardValue.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_CardValue.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_CardValue.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_CardValue.Size = New System.Drawing.Size(251, 44)
        Me.Ed_CardValue.TabIndex = 8
        '
        'CB_Debit
        '
        Me.CB_Debit.AllowFocus = False
        Me.CB_Debit.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Debit.Appearance.Options.UseFont = True
        Me.CB_Debit.GroupIndex = 1
        Me.CB_Debit.Location = New System.Drawing.Point(23, 236)
        Me.CB_Debit.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Debit.Name = "CB_Debit"
        Me.CB_Debit.Size = New System.Drawing.Size(109, 50)
        Me.CB_Debit.TabIndex = 9
        Me.CB_Debit.TabStop = False
        Me.CB_Debit.Text = "Debit"
        '
        'CB_Credit
        '
        Me.CB_Credit.AllowFocus = False
        Me.CB_Credit.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Credit.Appearance.Options.UseFont = True
        Me.CB_Credit.GroupIndex = 1
        Me.CB_Credit.Location = New System.Drawing.Point(23, 294)
        Me.CB_Credit.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Credit.Name = "CB_Credit"
        Me.CB_Credit.Size = New System.Drawing.Size(109, 50)
        Me.CB_Credit.TabIndex = 10
        Me.CB_Credit.TabStop = False
        Me.CB_Credit.Text = "Kredit"
        '
        'CB_QRIS
        '
        Me.CB_QRIS.AllowFocus = False
        Me.CB_QRIS.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_QRIS.Appearance.Options.UseFont = True
        Me.CB_QRIS.GroupIndex = 1
        Me.CB_QRIS.Location = New System.Drawing.Point(23, 352)
        Me.CB_QRIS.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_QRIS.Name = "CB_QRIS"
        Me.CB_QRIS.Size = New System.Drawing.Size(109, 50)
        Me.CB_QRIS.TabIndex = 24
        Me.CB_QRIS.TabStop = False
        Me.CB_QRIS.Text = "QRIS"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 249)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bank :"
        '
        'CB_Minus
        '
        Me.CB_Minus.AllowFocus = False
        Me.CB_Minus.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Minus.Appearance.Options.UseFont = True
        Me.CB_Minus.GroupIndex = 0
        Me.CB_Minus.Location = New System.Drawing.Point(255, 645)
        Me.CB_Minus.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Minus.Name = "CB_Minus"
        Me.CB_Minus.Size = New System.Drawing.Size(69, 55)
        Me.CB_Minus.TabIndex = 4
        Me.CB_Minus.TabStop = False
        Me.CB_Minus.Text = "-"
        '
        'CB_Plus
        '
        Me.CB_Plus.AllowFocus = False
        Me.CB_Plus.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Plus.Appearance.Options.UseFont = True
        Me.CB_Plus.Checked = True
        Me.CB_Plus.GroupIndex = 0
        Me.CB_Plus.Location = New System.Drawing.Point(255, 581)
        Me.CB_Plus.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Plus.Name = "CB_Plus"
        Me.CB_Plus.Size = New System.Drawing.Size(69, 54)
        Me.CB_Plus.TabIndex = 3
        Me.CB_Plus.Text = "+"
        '
        'Ed_Change
        '
        Me.Ed_Change.EditValue = "0"
        Me.Ed_Change.Location = New System.Drawing.Point(255, 127)
        Me.Ed_Change.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_Change.Name = "Ed_Change"
        Me.Ed_Change.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ed_Change.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Ed_Change.Properties.Appearance.Options.UseBackColor = True
        Me.Ed_Change.Properties.Appearance.Options.UseFont = True
        Me.Ed_Change.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Change.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Change.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ed_Change.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Change.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Change.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Change.Size = New System.Drawing.Size(248, 44)
        Me.Ed_Change.TabIndex = 14
        '
        'SB_RoundNominal
        '
        Me.SB_RoundNominal.AllowFocus = False
        Me.SB_RoundNominal.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SB_RoundNominal.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.SB_RoundNominal.Appearance.Options.UseBackColor = True
        Me.SB_RoundNominal.Appearance.Options.UseFont = True
        Me.SB_RoundNominal.Appearance.Options.UseTextOptions = True
        Me.SB_RoundNominal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SB_RoundNominal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SB_RoundNominal.Location = New System.Drawing.Point(255, 511)
        Me.SB_RoundNominal.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_RoundNominal.Name = "SB_RoundNominal"
        Me.SB_RoundNominal.Size = New System.Drawing.Size(157, 39)
        Me.SB_RoundNominal.TabIndex = 0
        Me.SB_RoundNominal.Text = "85,000"
        '
        'SB_Reset
        '
        Me.SB_Reset.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_Reset.Appearance.Options.UseFont = True
        Me.SB_Reset.Location = New System.Drawing.Point(420, 511)
        Me.SB_Reset.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_Reset.Name = "SB_Reset"
        Me.SB_Reset.Size = New System.Drawing.Size(86, 39)
        Me.SB_Reset.TabIndex = 10
        Me.SB_Reset.Tag = "1000"
        Me.SB_Reset.Text = "Net"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(168, 464)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 25)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "Tunai :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(145, 143)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 25)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Kembali :"
        '
        'LookUpEdit_Bank
        '
        Me.LookUpEdit_Bank.Location = New System.Drawing.Point(255, 239)
        Me.LookUpEdit_Bank.Margin = New System.Windows.Forms.Padding(4)
        Me.LookUpEdit_Bank.Name = "LookUpEdit_Bank"
        Me.LookUpEdit_Bank.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LookUpEdit_Bank.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit_Bank.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LookUpEdit_Bank.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LookUpEdit_Bank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_Bank.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 76, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankCode", "Bank Code", 216, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BankName", "Bank Name", 226, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit_Bank.Properties.DataSource = Me.SpPOSMDBankGetDataBindingSource
        Me.LookUpEdit_Bank.Properties.DisplayMember = "BankName"
        Me.LookUpEdit_Bank.Properties.NullText = "[Pilih Bank]"
        Me.LookUpEdit_Bank.Properties.ValueMember = "ID"
        Me.LookUpEdit_Bank.Size = New System.Drawing.Size(248, 40)
        Me.LookUpEdit_Bank.TabIndex = 22
        '
        'SpPOSMDBankGetDataBindingSource
        '
        Me.SpPOSMDBankGetDataBindingSource.DataMember = "sp_POS_MDBank_GetData"
        Me.SpPOSMDBankGetDataBindingSource.DataSource = Me.DataSet
        '
        'Ed_CardNo
        '
        Me.Ed_CardNo.EditValue = ""
        Me.Ed_CardNo.Location = New System.Drawing.Point(255, 295)
        Me.Ed_CardNo.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_CardNo.Name = "Ed_CardNo"
        Me.Ed_CardNo.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Ed_CardNo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Ed_CardNo.Properties.Appearance.Options.UseBackColor = True
        Me.Ed_CardNo.Properties.Appearance.Options.UseFont = True
        Me.Ed_CardNo.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_CardNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_CardNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ed_CardNo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_CardNo.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.SimpleMaskManager))
        Me.Ed_CardNo.Properties.MaskSettings.Set("mask", "0000 0000 0000 0000")
        Me.Ed_CardNo.Size = New System.Drawing.Size(248, 38)
        Me.Ed_CardNo.TabIndex = 7
        '
        'Ed_Payment
        '
        Me.Ed_Payment.EditValue = "0"
        Me.Ed_Payment.Location = New System.Drawing.Point(255, 453)
        Me.Ed_Payment.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_Payment.Name = "Ed_Payment"
        Me.Ed_Payment.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Ed_Payment.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!)
        Me.Ed_Payment.Properties.Appearance.Options.UseBackColor = True
        Me.Ed_Payment.Properties.Appearance.Options.UseFont = True
        Me.Ed_Payment.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_Payment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_Payment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ed_Payment.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Payment.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_Payment.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_Payment.Size = New System.Drawing.Size(251, 44)
        Me.Ed_Payment.TabIndex = 1
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.SB_BackCO)
        Me.XtraTabPage4.Controls.Add(Me.GC_Checker)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1308, 687)
        Me.XtraTabPage4.Text = "XtraTabPage4"
        '
        'SB_BackCO
        '
        Me.SB_BackCO.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.SB_BackCO.Appearance.Options.UseFont = True
        Me.SB_BackCO.Dock = System.Windows.Forms.DockStyle.Top
        Me.SB_BackCO.Location = New System.Drawing.Point(0, 0)
        Me.SB_BackCO.Margin = New System.Windows.Forms.Padding(4)
        Me.SB_BackCO.Name = "SB_BackCO"
        Me.SB_BackCO.Size = New System.Drawing.Size(1308, 35)
        Me.SB_BackCO.StyleController = Me.LayoutControl4
        Me.SB_BackCO.TabIndex = 7
        Me.SB_BackCO.Text = "Back"
        '
        'GC_Checker
        '
        Me.GC_Checker.DataSource = Me.SpPOSCheckerSequenceBindingSource
        Me.GC_Checker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Checker.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GC_Checker.Location = New System.Drawing.Point(0, 0)
        Me.GC_Checker.MainView = Me.LV_CO
        Me.GC_Checker.Margin = New System.Windows.Forms.Padding(20)
        Me.GC_Checker.Name = "GC_Checker"
        Me.GC_Checker.Padding = New System.Windows.Forms.Padding(10)
        Me.GC_Checker.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemMemoEdit1})
        Me.GC_Checker.Size = New System.Drawing.Size(1308, 687)
        Me.GC_Checker.TabIndex = 6
        Me.GC_Checker.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LV_CO})
        '
        'SpPOSCheckerSequenceBindingSource
        '
        Me.SpPOSCheckerSequenceBindingSource.DataMember = "sp_POS_CheckerSequence"
        Me.SpPOSCheckerSequenceBindingSource.DataSource = Me.DataSet
        '
        'LV_CO
        '
        Me.LV_CO.CardMinSize = New System.Drawing.Size(171, 151)
        Me.LV_CO.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colNoRequestOrder, Me.colMenuName1, Me.colCreatedDate_Checker})
        Me.LV_CO.DetailHeight = 485
        Me.LV_CO.GridControl = Me.GC_Checker
        Me.LV_CO.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colOrderID})
        Me.LV_CO.Name = "LV_CO"
        Me.LV_CO.OptionsView.AllowBorderColorBlending = True
        Me.LV_CO.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.LV_CO.OptionsView.ShowCardExpandButton = False
        Me.LV_CO.OptionsView.ShowFieldHints = False
        Me.LV_CO.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.LV_CO.OptionsView.ShowHeaderPanel = False
        Me.LV_CO.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
        Me.LV_CO.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNoRequestOrder, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.LV_CO.TemplateCard = Me.LayoutViewCard1
        '
        'colNoRequestOrder
        '
        Me.colNoRequestOrder.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.colNoRequestOrder.AppearanceCell.Options.UseFont = True
        Me.colNoRequestOrder.FieldName = "NoRequestOrder"
        Me.colNoRequestOrder.LayoutViewField = Me.layoutViewField_colNoRequestOrder
        Me.colNoRequestOrder.MinWidth = 30
        Me.colNoRequestOrder.Name = "colNoRequestOrder"
        Me.colNoRequestOrder.OptionsColumn.AllowEdit = False
        Me.colNoRequestOrder.OptionsColumn.AllowFocus = False
        Me.colNoRequestOrder.OptionsColumn.AllowMove = False
        Me.colNoRequestOrder.OptionsColumn.AllowShowHide = False
        Me.colNoRequestOrder.OptionsColumn.AllowSize = False
        Me.colNoRequestOrder.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNoRequestOrder.OptionsFilter.AllowFilter = False
        Me.colNoRequestOrder.Width = 112
        '
        'layoutViewField_colNoRequestOrder
        '
        Me.layoutViewField_colNoRequestOrder.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.layoutViewField_colNoRequestOrder.AppearanceItemCaption.Options.UseFont = True
        Me.layoutViewField_colNoRequestOrder.AppearanceItemCaption.Options.UseTextOptions = True
        Me.layoutViewField_colNoRequestOrder.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.layoutViewField_colNoRequestOrder.EditorPreferredWidth = 52
        Me.layoutViewField_colNoRequestOrder.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colNoRequestOrder.Name = "layoutViewField_colNoRequestOrder"
        Me.layoutViewField_colNoRequestOrder.Size = New System.Drawing.Size(39, 24)
        Me.layoutViewField_colNoRequestOrder.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colNoRequestOrder.TextVisible = False
        '
        'colMenuName1
        '
        Me.colMenuName1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.colMenuName1.AppearanceCell.Options.UseFont = True
        Me.colMenuName1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colMenuName1.AppearanceHeader.Options.UseFont = True
        Me.colMenuName1.AppearanceHeader.Options.UseTextOptions = True
        Me.colMenuName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMenuName1.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colMenuName1.FieldName = "MenuName"
        Me.colMenuName1.LayoutViewField = Me.layoutViewField_colMenuName1
        Me.colMenuName1.MinWidth = 30
        Me.colMenuName1.Name = "colMenuName1"
        Me.colMenuName1.OptionsColumn.AllowEdit = False
        Me.colMenuName1.OptionsColumn.AllowFocus = False
        Me.colMenuName1.OptionsColumn.AllowMove = False
        Me.colMenuName1.OptionsColumn.AllowShowHide = False
        Me.colMenuName1.OptionsColumn.AllowSize = False
        Me.colMenuName1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colMenuName1.OptionsFilter.AllowFilter = False
        Me.colMenuName1.Width = 112
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'layoutViewField_colMenuName1
        '
        Me.layoutViewField_colMenuName1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.layoutViewField_colMenuName1.AppearanceItemCaption.Options.UseFont = True
        Me.layoutViewField_colMenuName1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.layoutViewField_colMenuName1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.layoutViewField_colMenuName1.EditorPreferredWidth = 273
        Me.layoutViewField_colMenuName1.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_colMenuName1.Name = "layoutViewField_colMenuName1"
        Me.layoutViewField_colMenuName1.Size = New System.Drawing.Size(186, 66)
        Me.layoutViewField_colMenuName1.StartNewLine = True
        Me.layoutViewField_colMenuName1.TextLocation = DevExpress.Utils.Locations.Top
        Me.layoutViewField_colMenuName1.TextSize = New System.Drawing.Size(90, 20)
        '
        'colCreatedDate_Checker
        '
        Me.colCreatedDate_Checker.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.colCreatedDate_Checker.AppearanceCell.Options.UseFont = True
        Me.colCreatedDate_Checker.DisplayFormat.FormatString = "HH:mm:ss"
        Me.colCreatedDate_Checker.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCreatedDate_Checker.FieldName = "CreatedDate"
        Me.colCreatedDate_Checker.LayoutViewField = Me.layoutViewField_colCreatedDate
        Me.colCreatedDate_Checker.MinWidth = 30
        Me.colCreatedDate_Checker.Name = "colCreatedDate_Checker"
        Me.colCreatedDate_Checker.OptionsColumn.AllowEdit = False
        Me.colCreatedDate_Checker.OptionsColumn.AllowFocus = False
        Me.colCreatedDate_Checker.OptionsColumn.AllowMove = False
        Me.colCreatedDate_Checker.OptionsColumn.AllowShowHide = False
        Me.colCreatedDate_Checker.OptionsColumn.AllowSize = False
        Me.colCreatedDate_Checker.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colCreatedDate_Checker.OptionsFilter.AllowFilter = False
        Me.colCreatedDate_Checker.Width = 112
        '
        'layoutViewField_colCreatedDate
        '
        Me.layoutViewField_colCreatedDate.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.layoutViewField_colCreatedDate.AppearanceItemCaption.Options.UseFont = True
        Me.layoutViewField_colCreatedDate.AppearanceItemCaption.Options.UseTextOptions = True
        Me.layoutViewField_colCreatedDate.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.layoutViewField_colCreatedDate.EditorPreferredWidth = 214
        Me.layoutViewField_colCreatedDate.Location = New System.Drawing.Point(39, 0)
        Me.layoutViewField_colCreatedDate.Name = "layoutViewField_colCreatedDate"
        Me.layoutViewField_colCreatedDate.Size = New System.Drawing.Size(147, 24)
        Me.layoutViewField_colCreatedDate.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colCreatedDate.TextVisible = False
        '
        'layoutViewField_colOrderID
        '
        Me.layoutViewField_colOrderID.EditorPreferredWidth = 171
        Me.layoutViewField_colOrderID.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colOrderID.Name = "layoutViewField_colOrderID"
        Me.layoutViewField_colOrderID.Size = New System.Drawing.Size(114, 26)
        Me.layoutViewField_colOrderID.StartNewLine = True
        Me.layoutViewField_colOrderID.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colOrderID.TextVisible = False
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colNoRequestOrder, Me.layoutViewField_colMenuName1, Me.layoutViewField_colCreatedDate})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'SpPOSOrderDetailGetDataBindingSource
        '
        Me.SpPOSOrderDetailGetDataBindingSource.DataMember = "sp_POSOrderDetail_GetData"
        Me.SpPOSOrderDetailGetDataBindingSource.DataSource = Me.DataSet
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(1310, 72)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Sp_POS_MDVoidReason_GetDataTableAdapter
        '
        Me.Sp_POS_MDVoidReason_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POSOrderDetail_GetDataTableAdapter
        '
        Me.Sp_POSOrderDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'View_POS_MenuList_MainListTableAdapter
        '
        Me.View_POS_MenuList_MainListTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_OrderDetail_GetDataTableAdapter
        '
        Me.Sp_POS_OrderDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_MDBank_GetDataTableAdapter
        '
        Me.Sp_POS_MDBank_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_CheckerSequenceTableAdapter
        '
        Me.Sp_POS_CheckerSequenceTableAdapter.ClearBeforeFill = True
        '
        'Sp_POSReportTransaction_GetDataInvoiceDetailTableAdapter
        '
        Me.Sp_POSReportTransaction_GetDataInvoiceDetailTableAdapter.ClearBeforeFill = True
        '
        'Frm_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 787)
        Me.ControlBox = False
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.IconOptions.ShowIcon = False
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Order"
        Me.Ribbon = Me.RibbonControl1
        Me.Text = "POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemLookUpEdit_OrderTypeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPOSOrderTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.RadioGroup_OrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Server.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSGetServerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_Table.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSGetTableListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl_OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_OrderHeader_GetListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView_OrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PE_New.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_pos_ordertypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel_TableList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel_TableList.ResumeLayout(False)
        CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.SearchLookUpEdit_TableMove.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel_ServerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel_ServerList.ResumeLayout(False)
        CType(Me.FlyoutPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl3.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel2.ResumeLayout(False)
        CType(Me.FlyoutPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl4.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.Edit_OldPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit_NewPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit_CheckPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl5.ResumeLayout(False)
        CType(Me.GC_MenuType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewMenuTypeListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TV_MenuType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPOSMenuCategoryFrontListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TV_MenuCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.Ed_Keyword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_menu_listGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewPOSMenuListMainListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSOrderDetailGetDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_OrderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_MenuType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_MenuCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_Keyword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.FlyoutPanel_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel_Cancel.ResumeLayout(False)
        CType(Me.FlyoutPanelControl_Cancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl_Cancel.ResumeLayout(False)
        CType(Me.LookUpEdit_VoidReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSMDVoidReasonGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel_UpdateQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel_UpdateQty.ResumeLayout(False)
        CType(Me.FlyoutPanelControl_UpdateQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl_UpdateQty.ResumeLayout(False)
        CType(Me.SpinEdit_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel_POSPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel_POSPayment.ResumeLayout(False)
        CType(Me.FlyoutPanelControl_POSPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl_POSPayment.ResumeLayout(False)
        Me.FlyoutPanelControl_POSPayment.PerformLayout()
        CType(Me.Ed_Rounding.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Bill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_CardValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Change.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_Bank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSMDBankGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_CardNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Payment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GC_Checker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSCheckerSequenceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LV_CO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colNoRequestOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colMenuName1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCreatedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colOrderID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSOrderDetailGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As DataSet
    Friend WithEvents View_pos_ordertypeBindingSource As BindingSource
    Friend WithEvents View_pos_ordertypeTableAdapter As DataSetTableAdapters.View_POS_OrderTypeTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents Sp_POS_OrderHeader_GetListBindingSource As BindingSource
    Friend WithEvents Sp_POS_OrderHeader_GetListTableAdapter As DataSetTableAdapters.sp_POS_OrderHeader_GetListTableAdapter
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ViewPOSOrderTypeBindingSource As BindingSource
    Friend WithEvents SpPOSGetTableListBindingSource As BindingSource
    Friend WithEvents Sp_POS_GetTableListTableAdapter As DataSetTableAdapters.sp_POS_GetTableListTableAdapter
    Friend WithEvents LookUpEdit_Table As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit_Table As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableTypeID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpPOSGetServerListBindingSource As BindingSource
    Friend WithEvents Sp_POS_GetServerListTableAdapter As DataSetTableAdapters.sp_POS_GetServerListTableAdapter
    Friend WithEvents FlyoutPanel_TableList As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl2 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_CancelMove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_UpdateTable As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SearchLookUpEdit_TableMove As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_TableMove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName_TableMove As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FlyoutPanel_ServerList As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl3 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_CancelServer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_SubmitServer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_ServerList As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName_ServerList As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FlyoutPanel2 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl4 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_CancelChange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_ChangePassword As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Edit_OldPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Edit_NewPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Edit_CheckPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_POS_ChangePasswordTableAdapter As DataSetTableAdapters.sp_POS_ChangePasswordTableAdapter
    Friend WithEvents View_MenuType_ListTableAdapter As DataSetTableAdapters.View_MenuType_ListTableAdapter
    Friend WithEvents View_POS_MenuCategory_FrontListTableAdapter As DataSetTableAdapters.View_POS_MenuCategory_FrontListTableAdapter
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents GridControl_OrderList As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileView_OrderList As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colOrderID_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colOrderNo_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colOrderDate_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colOrderTypeID_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents RepositoryItemLookUpEdit_OrderTypeName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colTableID_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colTableName_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colisClosed_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colSubTotal_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colEmployeeID_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioGroup_OrderType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelBuatFlyOut As Panel
    Friend WithEvents SearchLookUpEdit_Server As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PE_New As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SB_Next As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SB_OrderOther As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_OrderDelivery As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_OrderTakeAway As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_OrderDineIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_OrderAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents LayoutControl5 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Label_OrderNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GC_MenuType As DevExpress.XtraGrid.GridControl
    Friend WithEvents TV_MenuType As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID_TVType As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuTypeName_TVType As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colImage4 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents TV_MenuCategory As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID_TVCategory As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuCategoryName_TVCategory As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuTypeID1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colImage3 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_TableAndType As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_Keyword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents View_menu_listGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents TileView_Menu As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents colID_Menu As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuNo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuDisplay As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuCategoryID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colCategoryName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colMenuTypeID As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colTypeName As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colUoM As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colImage1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_OrderDetail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderID_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuID_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuDisplay_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMenuName_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscount_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeID_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisProcess_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisHold_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisVoid_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate_OD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_Diskon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_Pembulatan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label_Total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_PPn As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_Subtotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_MenuType As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_MenuCategory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_Keyword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FlyoutPanel_POSPayment As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl_POSPayment As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents CB_Tunai As DevExpress.XtraEditors.CheckButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Ed_Bill As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label_Bank As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SB_FinishPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_CardValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CB_Debit As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CB_Credit As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CB_QRIS As DevExpress.XtraEditors.CheckButton
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_Minus As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CB_Plus As DevExpress.XtraEditors.CheckButton
    Friend WithEvents Ed_Change As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SB_RoundNominal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Reset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit_Bank As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Ed_CardNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_Payment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FlyoutPanel_Cancel As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl_Cancel As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LookUpEdit_VoidReason As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpPOSMDVoidReasonGetDataBindingSource As BindingSource
    Friend WithEvents SB_Remove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FlyoutPanel_UpdateQty As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl_UpdateQty As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents Label_MenuName_Memo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit_Qty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Ed_Price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SB_Update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Sp_POS_MDVoidReason_GetDataTableAdapter As DataSetTableAdapters.sp_POS_MDVoidReason_GetDataTableAdapter
    Friend WithEvents SpPOSOrderDetailGetDataBindingSource As BindingSource
    Friend WithEvents Repo_Num As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Sp_POSOrderDetail_GetDataTableAdapter As DataSetTableAdapters.sp_POSOrderDetail_GetDataTableAdapter
    Friend WithEvents ViewMenuTypeListBindingSource As BindingSource
    Friend WithEvents ViewPOSMenuCategoryFrontListBindingSource As BindingSource
    Friend WithEvents ViewPOSMenuListMainListBindingSource As BindingSource
    Friend WithEvents View_POS_MenuList_MainListTableAdapter As DataSetTableAdapters.View_POS_MenuList_MainListTableAdapter
    Friend WithEvents SpPOSOrderDetailGetDataBindingSource1 As BindingSource
    Friend WithEvents Sp_POS_OrderDetail_GetDataTableAdapter As DataSetTableAdapters.sp_POS_OrderDetail_GetDataTableAdapter
    Friend WithEvents SB_Payment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Preview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpPOSMDBankGetDataBindingSource As BindingSource
    Friend WithEvents Sp_POS_MDBank_GetDataTableAdapter As DataSetTableAdapters.sp_POS_MDBank_GetDataTableAdapter
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SB_BackCO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC_Checker As DevExpress.XtraGrid.GridControl
    Friend WithEvents LV_CO As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colNoRequestOrder As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colNoRequestOrder As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colMenuName1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents layoutViewField_colMenuName1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colCreatedDate_Checker As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colCreatedDate As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colOrderID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents SpPOSCheckerSequenceBindingSource As BindingSource
    Friend WithEvents Sp_POS_CheckerSequenceTableAdapter As DataSetTableAdapters.sp_POS_CheckerSequenceTableAdapter
    Friend WithEvents SB_50000 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_5000 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_1000 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_10000 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_Rounding As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SB_Validasi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_20000 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_2000 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTableType_OrderList As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents SB_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_CloseFlyOut1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Sp_POSReportTransaction_GetDataInvoiceDetailTableAdapter As DataSet_ReportTableAdapters.sp_POSReportTransaction_GetDataInvoiceDetailTableAdapter
End Class
