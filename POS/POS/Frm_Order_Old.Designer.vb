<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Order_Old
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
        Me.DataSet = New POS.DataSet()
        Me.Sp_POS_MDTable_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_POS_MDTable_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDTable_GetDataTableAdapter()
        Me.TableAdapterManager = New POS.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_POS_MDTableFloor_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_POS_MDTableFloor_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDTableFloor_GetDataTableAdapter()
        Me.Sp_POS_MDTableFloor_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GV_Floor = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFloor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.QueriesTableAdapter = New POS.DataSetTableAdapters.QueriesTableAdapter()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label_FlyOutPanel = New System.Windows.Forms.Label()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_Job = New DevExpress.XtraEditors.LabelControl()
        Me.Label_User = New DevExpress.XtraEditors.LabelControl()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Sp_POS_MDTable_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GV_Table = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableCode_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableName_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableTypeID_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisCharge_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCapacity_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiveImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDefaultImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoverImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisUsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLength = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequenceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWidth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel_TableView = New DevExpress.XtraEditors.PanelControl()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.Dt_Order = New DevExpress.XtraEditors.DateEdit()
        Me.SB_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Next = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_NumberOfGuest = New DevExpress.XtraEditors.SpinEdit()
        Me.Ed_GuestName = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.OfficeNavigationBar1 = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
        Me.NavigationBarItem1 = New DevExpress.XtraBars.Navigation.NavigationBarItem()
        Me.NavigationBarItem2 = New DevExpress.XtraBars.Navigation.NavigationBarItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DefaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDTable_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDTableFloor_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDTableFloor_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Floor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDTable_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_TableView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TableView.SuspendLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.Dt_Order.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_Order.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_NumberOfGuest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_GuestName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.OfficeNavigationBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_POS_MDTable_GetDataBindingSource
        '
        Me.Sp_POS_MDTable_GetDataBindingSource.DataMember = "sp_POS_MDTable_GetData"
        Me.Sp_POS_MDTable_GetDataBindingSource.DataSource = Me.DataSet
        '
        'Sp_POS_MDTable_GetDataTableAdapter
        '
        Me.Sp_POS_MDTable_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_POS_MDTableFloor_GetDataBindingSource
        '
        Me.Sp_POS_MDTableFloor_GetDataBindingSource.DataMember = "sp_POS_MDTableFloor_GetData"
        Me.Sp_POS_MDTableFloor_GetDataBindingSource.DataSource = Me.DataSet
        '
        'Sp_POS_MDTableFloor_GetDataTableAdapter
        '
        Me.Sp_POS_MDTableFloor_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_MDTableFloor_GetDataGridControl
        '
        Me.Sp_POS_MDTableFloor_GetDataGridControl.DataSource = Me.Sp_POS_MDTableFloor_GetDataBindingSource
        Me.Sp_POS_MDTableFloor_GetDataGridControl.Location = New System.Drawing.Point(269, 223)
        Me.Sp_POS_MDTableFloor_GetDataGridControl.MainView = Me.GV_Floor
        Me.Sp_POS_MDTableFloor_GetDataGridControl.Name = "Sp_POS_MDTableFloor_GetDataGridControl"
        Me.Sp_POS_MDTableFloor_GetDataGridControl.Size = New System.Drawing.Size(300, 220)
        Me.Sp_POS_MDTableFloor_GetDataGridControl.TabIndex = 4
        Me.Sp_POS_MDTableFloor_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Floor})
        '
        'GV_Floor
        '
        Me.GV_Floor.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFloor})
        Me.GV_Floor.GridControl = Me.Sp_POS_MDTableFloor_GetDataGridControl
        Me.GV_Floor.Name = "GV_Floor"
        '
        'colFloor
        '
        Me.colFloor.FieldName = "Floor"
        Me.colFloor.Name = "colFloor"
        Me.colFloor.Visible = True
        Me.colFloor.VisibleIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.LimeGreen
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label_FlyOutPanel)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.SB_Back)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(15, 15)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1042, 79)
        Me.PanelControl1.TabIndex = 0
        '
        'Label_FlyOutPanel
        '
        Me.Label_FlyOutPanel.BackColor = System.Drawing.Color.Transparent
        Me.Label_FlyOutPanel.Location = New System.Drawing.Point(361, 59)
        Me.Label_FlyOutPanel.Name = "Label_FlyOutPanel"
        Me.Label_FlyOutPanel.Size = New System.Drawing.Size(367, 13)
        Me.Label_FlyOutPanel.TabIndex = 6
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl2.Controls.Add(Me.PictureBox1)
        Me.PanelControl2.Controls.Add(Me.Label_Job)
        Me.PanelControl2.Controls.Add(Me.Label_User)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(790, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(250, 75)
        Me.PanelControl2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(175, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 64)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label_Job
        '
        Me.Label_Job.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label_Job.Appearance.Options.UseFont = True
        Me.Label_Job.Appearance.Options.UseTextOptions = True
        Me.Label_Job.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_Job.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_Job.Location = New System.Drawing.Point(5, 40)
        Me.Label_Job.Name = "Label_Job"
        Me.Label_Job.Size = New System.Drawing.Size(164, 16)
        Me.Label_Job.TabIndex = 5
        Me.Label_Job.Text = "Job"
        '
        'Label_User
        '
        Me.Label_User.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label_User.Appearance.Options.UseFont = True
        Me.Label_User.Appearance.Options.UseTextOptions = True
        Me.Label_User.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_User.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.Label_User.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label_User.Location = New System.Drawing.Point(8, 10)
        Me.Label_User.Name = "Label_User"
        Me.Label_User.Size = New System.Drawing.Size(161, 24)
        Me.Label_User.TabIndex = 4
        Me.Label_User.Text = "Usersd"
        '
        'SB_Back
        '
        Me.SB_Back.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.SB_Back.Appearance.Options.UseFont = True
        Me.SB_Back.Dock = System.Windows.Forms.DockStyle.Left
        Me.SB_Back.Location = New System.Drawing.Point(2, 2)
        Me.SB_Back.MaximumSize = New System.Drawing.Size(250, 75)
        Me.SB_Back.MinimumSize = New System.Drawing.Size(250, 75)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.Size = New System.Drawing.Size(250, 75)
        Me.SB_Back.TabIndex = 5
        Me.SB_Back.Text = "Back"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.LabelControl1.Appearance.Options.UseBackColor = True
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(1038, 75)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Map"
        '
        'Sp_POS_MDTable_GetDataGridControl
        '
        Me.Sp_POS_MDTable_GetDataGridControl.DataSource = Me.Sp_POS_MDTable_GetDataBindingSource
        Me.Sp_POS_MDTable_GetDataGridControl.Location = New System.Drawing.Point(598, 207)
        Me.Sp_POS_MDTable_GetDataGridControl.MainView = Me.GV_Table
        Me.Sp_POS_MDTable_GetDataGridControl.Name = "Sp_POS_MDTable_GetDataGridControl"
        Me.Sp_POS_MDTable_GetDataGridControl.Size = New System.Drawing.Size(300, 220)
        Me.Sp_POS_MDTable_GetDataGridControl.TabIndex = 4
        Me.Sp_POS_MDTable_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Table, Me.GridView1})
        '
        'GV_Table
        '
        Me.GV_Table.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Table, Me.colTableCode_Table, Me.colTableName_Table, Me.colTableTypeID_Table, Me.colisCharge_Table, Me.colisActive_Table, Me.colCapacity_Table, Me.colActiveImage, Me.colDefaultImage, Me.colDescription, Me.colHoverImage, Me.colisUsed, Me.colLength, Me.colSequenceID, Me.colWidth, Me.colX, Me.colY})
        Me.GV_Table.GridControl = Me.Sp_POS_MDTable_GetDataGridControl
        Me.GV_Table.Name = "GV_Table"
        '
        'colID_Table
        '
        Me.colID_Table.FieldName = "ID"
        Me.colID_Table.Name = "colID_Table"
        Me.colID_Table.OptionsColumn.AllowEdit = False
        Me.colID_Table.OptionsColumn.AllowFocus = False
        Me.colID_Table.OptionsColumn.ReadOnly = True
        Me.colID_Table.Visible = True
        Me.colID_Table.VisibleIndex = 0
        '
        'colTableCode_Table
        '
        Me.colTableCode_Table.FieldName = "TableCode"
        Me.colTableCode_Table.Name = "colTableCode_Table"
        Me.colTableCode_Table.OptionsColumn.AllowEdit = False
        Me.colTableCode_Table.OptionsColumn.AllowFocus = False
        Me.colTableCode_Table.Visible = True
        Me.colTableCode_Table.VisibleIndex = 1
        '
        'colTableName_Table
        '
        Me.colTableName_Table.FieldName = "TableName"
        Me.colTableName_Table.Name = "colTableName_Table"
        Me.colTableName_Table.OptionsColumn.AllowEdit = False
        Me.colTableName_Table.OptionsColumn.AllowFocus = False
        Me.colTableName_Table.Visible = True
        Me.colTableName_Table.VisibleIndex = 2
        '
        'colTableTypeID_Table
        '
        Me.colTableTypeID_Table.FieldName = "TableTypeID"
        Me.colTableTypeID_Table.Name = "colTableTypeID_Table"
        Me.colTableTypeID_Table.OptionsColumn.AllowEdit = False
        Me.colTableTypeID_Table.OptionsColumn.AllowFocus = False
        Me.colTableTypeID_Table.Visible = True
        Me.colTableTypeID_Table.VisibleIndex = 3
        '
        'colisCharge_Table
        '
        Me.colisCharge_Table.FieldName = "isCharge"
        Me.colisCharge_Table.Name = "colisCharge_Table"
        Me.colisCharge_Table.OptionsColumn.AllowEdit = False
        Me.colisCharge_Table.OptionsColumn.AllowFocus = False
        Me.colisCharge_Table.Visible = True
        Me.colisCharge_Table.VisibleIndex = 4
        '
        'colisActive_Table
        '
        Me.colisActive_Table.FieldName = "isActive"
        Me.colisActive_Table.Name = "colisActive_Table"
        Me.colisActive_Table.OptionsColumn.AllowEdit = False
        Me.colisActive_Table.OptionsColumn.AllowFocus = False
        Me.colisActive_Table.Visible = True
        Me.colisActive_Table.VisibleIndex = 5
        '
        'colCapacity_Table
        '
        Me.colCapacity_Table.FieldName = "Capacity"
        Me.colCapacity_Table.Name = "colCapacity_Table"
        Me.colCapacity_Table.OptionsColumn.AllowEdit = False
        Me.colCapacity_Table.OptionsColumn.AllowFocus = False
        Me.colCapacity_Table.Visible = True
        Me.colCapacity_Table.VisibleIndex = 6
        '
        'colActiveImage
        '
        Me.colActiveImage.FieldName = "ActiveImage"
        Me.colActiveImage.Name = "colActiveImage"
        Me.colActiveImage.Visible = True
        Me.colActiveImage.VisibleIndex = 7
        '
        'colDefaultImage
        '
        Me.colDefaultImage.FieldName = "DefaultImage"
        Me.colDefaultImage.Name = "colDefaultImage"
        Me.colDefaultImage.Visible = True
        Me.colDefaultImage.VisibleIndex = 8
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 9
        '
        'colHoverImage
        '
        Me.colHoverImage.FieldName = "HoverImage"
        Me.colHoverImage.Name = "colHoverImage"
        Me.colHoverImage.Visible = True
        Me.colHoverImage.VisibleIndex = 10
        '
        'colisUsed
        '
        Me.colisUsed.FieldName = "isUsed"
        Me.colisUsed.Name = "colisUsed"
        Me.colisUsed.Visible = True
        Me.colisUsed.VisibleIndex = 11
        '
        'colLength
        '
        Me.colLength.FieldName = "Length"
        Me.colLength.Name = "colLength"
        Me.colLength.Visible = True
        Me.colLength.VisibleIndex = 12
        '
        'colSequenceID
        '
        Me.colSequenceID.FieldName = "SequenceID"
        Me.colSequenceID.Name = "colSequenceID"
        Me.colSequenceID.Visible = True
        Me.colSequenceID.VisibleIndex = 13
        '
        'colWidth
        '
        Me.colWidth.FieldName = "Width"
        Me.colWidth.Name = "colWidth"
        Me.colWidth.Visible = True
        Me.colWidth.VisibleIndex = 14
        '
        'colX
        '
        Me.colX.FieldName = "X"
        Me.colX.Name = "colX"
        Me.colX.Visible = True
        Me.colX.VisibleIndex = 15
        '
        'colY
        '
        Me.colY.FieldName = "Y"
        Me.colY.Name = "colY"
        Me.colY.Visible = True
        Me.colY.VisibleIndex = 16
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Sp_POS_MDTable_GetDataGridControl
        Me.GridView1.Name = "GridView1"
        '
        'Panel_TableView
        '
        Me.Panel_TableView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Panel_TableView.Controls.Add(Me.FlyoutPanel1)
        Me.Panel_TableView.Controls.Add(Me.Sp_POS_MDTableFloor_GetDataGridControl)
        Me.Panel_TableView.Controls.Add(Me.Sp_POS_MDTable_GetDataGridControl)
        Me.Panel_TableView.Location = New System.Drawing.Point(15, 104)
        Me.Panel_TableView.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.Panel_TableView.Name = "Panel_TableView"
        Me.Panel_TableView.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.Panel_TableView.Size = New System.Drawing.Size(1042, 433)
        Me.Panel_TableView.TabIndex = 7
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(320, 16)
        Me.FlyoutPanel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.FlyoutPanel1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.FlyoutPanel1.OwnerControl = Me.Label_FlyOutPanel
        Me.FlyoutPanel1.Size = New System.Drawing.Size(459, 236)
        Me.FlyoutPanel1.TabIndex = 5
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.LayoutControl2)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(459, 236)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.LayoutControl2.Appearance.Control.Options.UseFont = True
        Me.LayoutControl2.Controls.Add(Me.Dt_Order)
        Me.LayoutControl2.Controls.Add(Me.SB_Cancel)
        Me.LayoutControl2.Controls.Add(Me.SB_Next)
        Me.LayoutControl2.Controls.Add(Me.Ed_NumberOfGuest)
        Me.LayoutControl2.Controls.Add(Me.Ed_GuestName)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(7, 7)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(445, 222)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'Dt_Order
        '
        Me.Dt_Order.EditValue = New Date(2014, 10, 14, 19, 11, 36, 0)
        Me.Dt_Order.Location = New System.Drawing.Point(113, 108)
        Me.Dt_Order.Name = "Dt_Order"
        Me.Dt_Order.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Order.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Order.Properties.Mask.EditMask = "dd MMM yyy HH:mm"
        Me.Dt_Order.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Dt_Order.Size = New System.Drawing.Size(320, 44)
        Me.Dt_Order.StyleController = Me.LayoutControl2
        Me.Dt_Order.TabIndex = 8
        '
        'SB_Cancel
        '
        Me.SB_Cancel.Location = New System.Drawing.Point(12, 168)
        Me.SB_Cancel.Name = "SB_Cancel"
        Me.SB_Cancel.Size = New System.Drawing.Size(221, 42)
        Me.SB_Cancel.StyleController = Me.LayoutControl2
        Me.SB_Cancel.TabIndex = 7
        Me.SB_Cancel.Text = "Close"
        '
        'SB_Next
        '
        Me.SB_Next.Location = New System.Drawing.Point(237, 168)
        Me.SB_Next.Name = "SB_Next"
        Me.SB_Next.Size = New System.Drawing.Size(196, 42)
        Me.SB_Next.StyleController = Me.LayoutControl2
        Me.SB_Next.TabIndex = 6
        Me.SB_Next.Text = "Next"
        '
        'Ed_NumberOfGuest
        '
        Me.Ed_NumberOfGuest.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Ed_NumberOfGuest.Location = New System.Drawing.Point(113, 60)
        Me.Ed_NumberOfGuest.Name = "Ed_NumberOfGuest"
        Me.Ed_NumberOfGuest.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_NumberOfGuest.Properties.Mask.EditMask = "n0"
        Me.Ed_NumberOfGuest.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_NumberOfGuest.Size = New System.Drawing.Size(320, 44)
        Me.Ed_NumberOfGuest.StyleController = Me.LayoutControl2
        Me.Ed_NumberOfGuest.TabIndex = 5
        '
        'Ed_GuestName
        '
        Me.Ed_GuestName.EditValue = "-"
        Me.Ed_GuestName.Location = New System.Drawing.Point(113, 12)
        Me.Ed_GuestName.Name = "Ed_GuestName"
        Me.Ed_GuestName.Properties.Appearance.Options.UseTextOptions = True
        Me.Ed_GuestName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Ed_GuestName.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_GuestName.Size = New System.Drawing.Size(320, 44)
        Me.Ed_GuestName.StyleController = Me.LayoutControl2
        Me.Ed_GuestName.TabIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem6, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(445, 222)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Ed_GuestName
        Me.LayoutControlItem3.CustomizationFormText = "Guest : "
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(425, 48)
        Me.LayoutControlItem3.Text = "Guest : "
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(97, 37)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Ed_NumberOfGuest
        Me.LayoutControlItem6.CustomizationFormText = "#Guest :"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(425, 48)
        Me.LayoutControlItem6.Text = "#Guest :"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(97, 37)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 144)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(425, 12)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SB_Next
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(225, 156)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(200, 46)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SB_Cancel
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(225, 46)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Dt_Order
        Me.LayoutControlItem9.CustomizationFormText = "Date :"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(425, 48)
        Me.LayoutControlItem9.Text = "Date :"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(97, 37)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.OfficeNavigationBar1)
        Me.LayoutControl1.Controls.Add(Me.Panel_TableView)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(294, 205, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1072, 603)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'OfficeNavigationBar1
        '
        Me.OfficeNavigationBar1.AutoSize = False
        Me.OfficeNavigationBar1.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden
        Me.OfficeNavigationBar1.Items.AddRange(New DevExpress.XtraBars.Navigation.NavigationBarItem() {Me.NavigationBarItem1, Me.NavigationBarItem2})
        Me.OfficeNavigationBar1.Location = New System.Drawing.Point(12, 544)
        Me.OfficeNavigationBar1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OfficeNavigationBar1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.OfficeNavigationBar1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OfficeNavigationBar1.Name = "OfficeNavigationBar1"
        Me.OfficeNavigationBar1.Size = New System.Drawing.Size(1048, 47)
        Me.OfficeNavigationBar1.TabIndex = 8
        Me.OfficeNavigationBar1.Text = "OfficeNavigationBar1"
        '
        'NavigationBarItem1
        '
        Me.NavigationBarItem1.Name = "NavigationBarItem1"
        Me.NavigationBarItem1.Text = "Item1"
        '
        'NavigationBarItem2
        '
        Me.NavigationBarItem2.Name = "NavigationBarItem2"
        Me.NavigationBarItem2.Text = "Item2"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1072, 603)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 89)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(110, 89)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1052, 89)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Panel_TableView
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 89)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1052, 443)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.OfficeNavigationBar1
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 532)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1052, 51)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'DefaultLookAndFeel
        '
        Me.DefaultLookAndFeel.LookAndFeel.SkinName = "Visual Studio 2013 Light"
        '
        'Frm_Order_Old
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Order_Old"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDTable_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDTableFloor_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDTableFloor_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Floor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDTable_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_TableView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TableView.ResumeLayout(False)
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.Dt_Order.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_Order.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_NumberOfGuest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_GuestName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.OfficeNavigationBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet As POS.DataSet
    Friend WithEvents Sp_POS_MDTable_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDTable_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDTable_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As POS.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_POS_MDTableFloor_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDTableFloor_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDTableFloor_GetDataTableAdapter
    Friend WithEvents Sp_POS_MDTableFloor_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Floor As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFloor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QueriesTableAdapter As POS.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Sp_POS_MDTable_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Table As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableCode_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableTypeID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisCharge_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapacity_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Job As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label_User As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel_TableView As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents OfficeNavigationBar1 As DevExpress.XtraBars.Navigation.OfficeNavigationBar
    Friend WithEvents NavigationBarItem1 As DevExpress.XtraBars.Navigation.NavigationBarItem
    Friend WithEvents NavigationBarItem2 As DevExpress.XtraBars.Navigation.NavigationBarItem
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Label_FlyOutPanel As System.Windows.Forms.Label
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_Next As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_NumberOfGuest As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Ed_GuestName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SB_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Dt_Order As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents colActiveImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDefaultImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoverImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisUsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLength As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequenceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWidth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DefaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
