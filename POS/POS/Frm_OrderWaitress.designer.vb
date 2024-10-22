<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OrderWaitress
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_HeaderMid = New DevExpress.XtraEditors.PanelControl()
        Me.Label_Employee = New DevExpress.XtraEditors.LabelControl()
        Me.Label_DateTime = New DevExpress.XtraEditors.LabelControl()
        Me.SB_LogOut = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_NewOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel_Main = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_List = New DevExpress.XtraEditors.PanelControl()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.SB_Delivery = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_TakeAway = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_DineIn = New DevExpress.XtraEditors.SimpleButton()
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New POS.DataSet()
        Me.GV_Order = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransactionPaidValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisClosed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VScrollBar1 = New DevExpress.XtraEditors.VScrollBar()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TableAdapterManager = New POS.DataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter = New POS.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter = New POS.DataSetTableAdapters.sp_POSOrderDetailCheck_GetDataHeaderTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.Panel_HeaderMid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_HeaderMid.SuspendLayout()
        CType(Me.Panel_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Main.SuspendLayout()
        CType(Me.Panel_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_List.SuspendLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.BackColor = System.Drawing.Color.Transparent
        Me.LayoutControl1.Controls.Add(Me.PanelControl2)
        Me.LayoutControl1.Controls.Add(Me.Panel_Main)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(480, 277, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1028, 497)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Panel_HeaderMid)
        Me.PanelControl2.Controls.Add(Me.SB_LogOut)
        Me.PanelControl2.Controls.Add(Me.SB_NewOrder)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 15)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelControl2.Size = New System.Drawing.Size(998, 89)
        Me.PanelControl2.TabIndex = 8
        '
        'Panel_HeaderMid
        '
        Me.Panel_HeaderMid.Controls.Add(Me.Label_Employee)
        Me.Panel_HeaderMid.Controls.Add(Me.Label_DateTime)
        Me.Panel_HeaderMid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_HeaderMid.Location = New System.Drawing.Point(257, 7)
        Me.Panel_HeaderMid.Name = "Panel_HeaderMid"
        Me.Panel_HeaderMid.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_HeaderMid.Size = New System.Drawing.Size(484, 75)
        Me.Panel_HeaderMid.TabIndex = 6
        '
        'Label_Employee
        '
        Me.Label_Employee.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label_Employee.Appearance.Options.UseFont = True
        Me.Label_Employee.Appearance.Options.UseTextOptions = True
        Me.Label_Employee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_Employee.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Label_Employee.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label_Employee.Location = New System.Drawing.Point(7, 28)
        Me.Label_Employee.Name = "Label_Employee"
        Me.Label_Employee.Size = New System.Drawing.Size(470, 40)
        Me.Label_Employee.TabIndex = 1
        Me.Label_Employee.Text = "Employee Name"
        '
        'Label_DateTime
        '
        Me.Label_DateTime.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label_DateTime.Appearance.Options.UseFont = True
        Me.Label_DateTime.Appearance.Options.UseTextOptions = True
        Me.Label_DateTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label_DateTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_DateTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_DateTime.Location = New System.Drawing.Point(7, 7)
        Me.Label_DateTime.Name = "Label_DateTime"
        Me.Label_DateTime.Size = New System.Drawing.Size(470, 21)
        Me.Label_DateTime.TabIndex = 0
        Me.Label_DateTime.Text = "LabelControl1"
        '
        'SB_LogOut
        '
        Me.SB_LogOut.AllowFocus = False
        Me.SB_LogOut.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_LogOut.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_LogOut.Appearance.Options.UseBackColor = True
        Me.SB_LogOut.Appearance.Options.UseFont = True
        Me.SB_LogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SB_LogOut.Dock = System.Windows.Forms.DockStyle.Right
        Me.SB_LogOut.Location = New System.Drawing.Point(741, 7)
        Me.SB_LogOut.Name = "SB_LogOut"
        Me.SB_LogOut.Size = New System.Drawing.Size(250, 75)
        Me.SB_LogOut.TabIndex = 5
        Me.SB_LogOut.Tag = "11"
        Me.SB_LogOut.Text = "Log Out"
        '
        'SB_NewOrder
        '
        Me.SB_NewOrder.AllowFocus = False
        Me.SB_NewOrder.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_NewOrder.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_NewOrder.Appearance.Options.UseBackColor = True
        Me.SB_NewOrder.Appearance.Options.UseFont = True
        Me.SB_NewOrder.Dock = System.Windows.Forms.DockStyle.Left
        Me.SB_NewOrder.Location = New System.Drawing.Point(7, 7)
        Me.SB_NewOrder.Name = "SB_NewOrder"
        Me.SB_NewOrder.Size = New System.Drawing.Size(250, 75)
        Me.SB_NewOrder.TabIndex = 1
        Me.SB_NewOrder.Text = "New Order"
        '
        'Panel_Main
        '
        Me.Panel_Main.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel_Main.Appearance.Options.UseBackColor = True
        Me.Panel_Main.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_Main.Controls.Add(Me.Panel_List)
        Me.Panel_Main.Controls.Add(Me.VScrollBar1)
        Me.Panel_Main.Location = New System.Drawing.Point(15, 114)
        Me.Panel_Main.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.Panel_Main.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Panel_Main.Name = "Panel_Main"
        Me.Panel_Main.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_Main.Size = New System.Drawing.Size(998, 368)
        Me.Panel_Main.TabIndex = 6
        '
        'Panel_List
        '
        Me.Panel_List.AllowTouchScroll = True
        Me.Panel_List.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel_List.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.Panel_List.Appearance.Options.UseBackColor = True
        Me.Panel_List.Appearance.Options.UseBorderColor = True
        Me.Panel_List.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_List.Controls.Add(Me.FlyoutPanel1)
        Me.Panel_List.Controls.Add(Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl)
        Me.Panel_List.FireScrollEventOnMouseWheel = True
        Me.Panel_List.Location = New System.Drawing.Point(5, 5)
        Me.Panel_List.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.Panel_List.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Panel_List.Name = "Panel_List"
        Me.Panel_List.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_List.Size = New System.Drawing.Size(948, 431)
        Me.Panel_List.TabIndex = 8
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(3, 8)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel1.Options.CloseOnOuterClick = True
        Me.FlyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.FlyoutPanel1.OwnerControl = Me.SB_NewOrder
        Me.FlyoutPanel1.Size = New System.Drawing.Size(249, 243)
        Me.FlyoutPanel1.TabIndex = 8
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.SB_Delivery)
        Me.FlyoutPanelControl1.Controls.Add(Me.SB_TakeAway)
        Me.FlyoutPanelControl1.Controls.Add(Me.SB_DineIn)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(249, 243)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'SB_Delivery
        '
        Me.SB_Delivery.AllowFocus = False
        Me.SB_Delivery.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_Delivery.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_Delivery.Appearance.Options.UseBackColor = True
        Me.SB_Delivery.Appearance.Options.UseFont = True
        Me.SB_Delivery.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SB_Delivery.Location = New System.Drawing.Point(5, 163)
        Me.SB_Delivery.Name = "SB_Delivery"
        Me.SB_Delivery.Size = New System.Drawing.Size(239, 75)
        Me.SB_Delivery.TabIndex = 4
        Me.SB_Delivery.Text = "Delivery"
        '
        'SB_TakeAway
        '
        Me.SB_TakeAway.AllowFocus = False
        Me.SB_TakeAway.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_TakeAway.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_TakeAway.Appearance.Options.UseBackColor = True
        Me.SB_TakeAway.Appearance.Options.UseFont = True
        Me.SB_TakeAway.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SB_TakeAway.Location = New System.Drawing.Point(5, 84)
        Me.SB_TakeAway.Name = "SB_TakeAway"
        Me.SB_TakeAway.Size = New System.Drawing.Size(239, 75)
        Me.SB_TakeAway.TabIndex = 3
        Me.SB_TakeAway.Text = "Take Away"
        '
        'SB_DineIn
        '
        Me.SB_DineIn.AllowFocus = False
        Me.SB_DineIn.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.SB_DineIn.Appearance.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB_DineIn.Appearance.Options.UseBackColor = True
        Me.SB_DineIn.Appearance.Options.UseFont = True
        Me.SB_DineIn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SB_DineIn.Location = New System.Drawing.Point(5, 5)
        Me.SB_DineIn.Name = "SB_DineIn"
        Me.SB_DineIn.Size = New System.Drawing.Size(239, 75)
        Me.SB_DineIn.TabIndex = 2
        Me.SB_DineIn.Text = "Dine In"
        '
        'Sp_POSOrderDetailCheck_GetDataHeaderGridControl
        '
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.DataSource = Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Location = New System.Drawing.Point(429, 54)
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.MainView = Me.GV_Order
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Name = "Sp_POSOrderDetailCheck_GetDataHeaderGridControl"
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Size = New System.Drawing.Size(300, 220)
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.TabIndex = 7
        Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Order})
        '
        'Sp_POSOrderDetailCheck_GetDataHeaderBindingSource
        '
        Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource.DataMember = "sp_POSOrderDetailCheck_GetDataHeader"
        Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_Order
        '
        Me.GV_Order.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOrderDate, Me.colCreatedDate, Me.colOrderNo, Me.colTableID, Me.colTableName, Me.colSubTotal, Me.colTransactionPaidValue, Me.colisClosed, Me.colOrderTypeID})
        Me.GV_Order.GridControl = Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl
        Me.GV_Order.Name = "GV_Order"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colOrderDate
        '
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 1
        '
        'colCreatedDate
        '
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = True
        Me.colCreatedDate.VisibleIndex = 2
        '
        'colOrderNo
        '
        Me.colOrderNo.FieldName = "OrderNo"
        Me.colOrderNo.Name = "colOrderNo"
        Me.colOrderNo.Visible = True
        Me.colOrderNo.VisibleIndex = 3
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
        'colSubTotal
        '
        Me.colSubTotal.FieldName = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.OptionsColumn.ReadOnly = True
        Me.colSubTotal.Visible = True
        Me.colSubTotal.VisibleIndex = 6
        '
        'colTransactionPaidValue
        '
        Me.colTransactionPaidValue.FieldName = "TransactionPaidValue"
        Me.colTransactionPaidValue.Name = "colTransactionPaidValue"
        Me.colTransactionPaidValue.OptionsColumn.ReadOnly = True
        Me.colTransactionPaidValue.Visible = True
        Me.colTransactionPaidValue.VisibleIndex = 7
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
        'VScrollBar1
        '
        Me.VScrollBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.LargeChange = 20
        Me.VScrollBar1.Location = New System.Drawing.Point(953, 5)
        Me.VScrollBar1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.VScrollBar1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Opacity = 1.0!
        Me.VScrollBar1.Size = New System.Drawing.Size(40, 358)
        Me.VScrollBar1.TabIndex = 7
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1028, 497)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Panel_Main
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 99)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1008, 378)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl2
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 99)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(110, 99)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1008, 99)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
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
        'Frm_OrderWaitress
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 497)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "Frm_OrderWaitress"
        Me.Text = "Cashier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.Panel_HeaderMid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_HeaderMid.ResumeLayout(False)
        CType(Me.Panel_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Main.ResumeLayout(False)
        CType(Me.Panel_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_List.ResumeLayout(False)
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POSOrderDetailCheck_GetDataHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_NewOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataSet As POS.DataSet
    Friend WithEvents TableAdapterManager As POS.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents QueriesTableAdapter As POS.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents Sp_POSOrderDetailCheck_GetDataHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter As POS.DataSetTableAdapters.sp_POSOrderDetailCheck_GetDataHeaderTableAdapter
    Friend WithEvents Panel_Main As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VScrollBar1 As DevExpress.XtraEditors.VScrollBar
    Friend WithEvents Panel_List As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SB_LogOut As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Sp_POSOrderDetailCheck_GetDataHeaderGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Order As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransactionPaidValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisClosed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Panel_HeaderMid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label_Employee As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_DateTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents SB_Delivery As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_TakeAway As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_DineIn As DevExpress.XtraEditors.SimpleButton
End Class
