<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Employee
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim WindowsUIButtonImageOptions5 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions6 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions7 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions8 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Employee))
        Me.StyleController1 = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.Sp_MDEmployee_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDEmployee_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPositionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoLookUp_Position = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDPosition_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_Exit = New DevExpress.XtraEditors.SimpleButton()
        Me.WindowsUIButtonPanel_Header = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LC_ItemWindowsPanel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_MDEmployee_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDEmployee_GetDataTableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Sp_MDPosition_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDPosition_GetDataTableAdapter()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDEmployee_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDEmployee_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoLookUp_Position, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDPosition_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowsUIButtonPanel_Header.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_ItemWindowsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleController1
        '
        Me.StyleController1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.StyleController1.Appearance.Options.UseFont = True
        Me.StyleController1.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.StyleController1.LookAndFeel.UseDefaultLookAndFeel = False
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 0)
        Me.NavigationFrame1.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Padding = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.Size = New System.Drawing.Size(1084, 678)
        Me.NavigationFrame1.TabIndex = 12
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "NavigationPage1"
        Me.NavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1084, 678)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SearchControl1)
        Me.LayoutControl1.Controls.Add(Me.SB_Exit)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDEmployee_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.WindowsUIButtonPanel_Header)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(318, 217, 432, 350)
        Me.LayoutControl1.Padding = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1084, 678)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SearchControl1
        '
        Me.SearchControl1.Client = Me.Sp_MDEmployee_GetDataGridControl
        Me.SearchControl1.Location = New System.Drawing.Point(610, 548)
        Me.SearchControl1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SearchControl1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SearchControl1.Properties.Appearance.Options.UseBackColor = True
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Properties.Client = Me.Sp_MDEmployee_GetDataGridControl
        Me.SearchControl1.Size = New System.Drawing.Size(460, 42)
        Me.SearchControl1.StyleController = Me.LayoutControl1
        Me.SearchControl1.TabIndex = 0
        '
        'Sp_MDEmployee_GetDataGridControl
        '
        Me.Sp_MDEmployee_GetDataGridControl.DataSource = Me.Sp_MDEmployee_GetDataBindingSource
        Me.Sp_MDEmployee_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Sp_MDEmployee_GetDataGridControl.Location = New System.Drawing.Point(5, 15)
        Me.Sp_MDEmployee_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_MDEmployee_GetDataGridControl.Name = "Sp_MDEmployee_GetDataGridControl"
        Me.Sp_MDEmployee_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoLookUp_Position})
        Me.Sp_MDEmployee_GetDataGridControl.Size = New System.Drawing.Size(1074, 495)
        Me.Sp_MDEmployee_GetDataGridControl.TabIndex = 13
        Me.Sp_MDEmployee_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'Sp_MDEmployee_GetDataBindingSource
        '
        Me.Sp_MDEmployee_GetDataBindingSource.DataMember = "sp_MDEmployee_GetData"
        Me.Sp_MDEmployee_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Detail
        '
        Me.GV_Detail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Detail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Detail.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GV_Detail.Appearance.Row.Options.UseFont = True
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colEmployeeNo, Me.colEmployeeName, Me.colPositionID, Me.colDescription, Me.colModifiedUser})
        Me.GV_Detail.GridControl = Me.Sp_MDEmployee_GetDataGridControl
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.GV_Detail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Detail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Detail.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        '
        'colEmployeeNo
        '
        Me.colEmployeeNo.Caption = "No. Pegawai"
        Me.colEmployeeNo.FieldName = "EmployeeNo"
        Me.colEmployeeNo.Name = "colEmployeeNo"
        Me.colEmployeeNo.OptionsColumn.AllowEdit = False
        Me.colEmployeeNo.OptionsColumn.AllowFocus = False
        Me.colEmployeeNo.OptionsColumn.ReadOnly = True
        Me.colEmployeeNo.OptionsEditForm.Caption = "No. Pegawai :"
        Me.colEmployeeNo.OptionsFilter.AllowFilter = False
        Me.colEmployeeNo.Visible = True
        Me.colEmployeeNo.VisibleIndex = 0
        '
        'colEmployeeName
        '
        Me.colEmployeeName.Caption = "Nama Pegawai"
        Me.colEmployeeName.FieldName = "EmployeeName"
        Me.colEmployeeName.Name = "colEmployeeName"
        Me.colEmployeeName.OptionsEditForm.Caption = "Nama Pegawai :"
        Me.colEmployeeName.OptionsFilter.AllowFilter = False
        Me.colEmployeeName.Visible = True
        Me.colEmployeeName.VisibleIndex = 1
        '
        'colPositionID
        '
        Me.colPositionID.Caption = "Jabatan"
        Me.colPositionID.ColumnEdit = Me.RepoLookUp_Position
        Me.colPositionID.FieldName = "PositionID"
        Me.colPositionID.Name = "colPositionID"
        Me.colPositionID.OptionsEditForm.Caption = "Jabatan :"
        Me.colPositionID.OptionsFilter.AllowFilter = False
        Me.colPositionID.Visible = True
        Me.colPositionID.VisibleIndex = 2
        '
        'RepoLookUp_Position
        '
        Me.RepoLookUp_Position.AutoHeight = False
        Me.RepoLookUp_Position.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepoLookUp_Position.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PositionName", "Jabatan", 77, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepoLookUp_Position.DataSource = Me.Sp_MDPosition_GetDataBindingSource
        Me.RepoLookUp_Position.DisplayMember = "PositionName"
        Me.RepoLookUp_Position.Name = "RepoLookUp_Position"
        Me.RepoLookUp_Position.NullText = "[Pilih Jabatan]"
        Me.RepoLookUp_Position.ValueMember = "ID"
        '
        'Sp_MDPosition_GetDataBindingSource
        '
        Me.Sp_MDPosition_GetDataBindingSource.DataMember = "sp_MDPosition_GetData"
        Me.Sp_MDPosition_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colDescription
        '
        Me.colDescription.Caption = "Keterangan"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsEditForm.Caption = "Keterangan :"
        Me.colDescription.OptionsEditForm.ColumnSpan = 3
        Me.colDescription.OptionsEditForm.UseEditorColRowSpan = False
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        '
        'SB_Exit
        '
        Me.SB_Exit.Location = New System.Drawing.Point(14, 548)
        Me.SB_Exit.Name = "SB_Exit"
        Me.SB_Exit.Size = New System.Drawing.Size(114, 42)
        Me.SB_Exit.StyleController = Me.LayoutControl1
        Me.SB_Exit.TabIndex = 14
        Me.SB_Exit.Text = "&Exit"
        '
        'WindowsUIButtonPanel_Header
        '
        Me.WindowsUIButtonPanel_Header.AutoSizeInLayoutControl = False
        Me.WindowsUIButtonPanel_Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.WindowsUIButtonPanel_Header.ButtonBackgroundImages = Me.ImageCollection
        Me.WindowsUIButtonPanel_Header.ButtonInterval = 5
        WindowsUIButtonImageOptions5.Image = CType(resources.GetObject("WindowsUIButtonImageOptions5.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions5.Location = DevExpress.XtraBars.Docking2010.ImageLocation.AboveText
        WindowsUIButtonImageOptions6.Image = CType(resources.GetObject("WindowsUIButtonImageOptions6.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions6.Location = DevExpress.XtraBars.Docking2010.ImageLocation.AboveText
        WindowsUIButtonImageOptions7.Image = CType(resources.GetObject("WindowsUIButtonImageOptions7.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions8.Image = CType(resources.GetObject("WindowsUIButtonImageOptions8.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions8.Location = DevExpress.XtraBars.Docking2010.ImageLocation.AboveText
        Me.WindowsUIButtonPanel_Header.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("New", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", True, WindowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Button", False, WindowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Close", True, WindowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel_Header.Controls.Add(Me.PanelControl1)
        Me.WindowsUIButtonPanel_Header.EnableImageTransparency = True
        Me.WindowsUIButtonPanel_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.WindowsUIButtonPanel_Header.ForeColor = System.Drawing.Color.White
        Me.WindowsUIButtonPanel_Header.Images = Me.imageList1
        Me.WindowsUIButtonPanel_Header.Location = New System.Drawing.Point(2, 606)
        Me.WindowsUIButtonPanel_Header.MaximumSize = New System.Drawing.Size(0, 70)
        Me.WindowsUIButtonPanel_Header.MinimumSize = New System.Drawing.Size(0, 70)
        Me.WindowsUIButtonPanel_Header.Name = "WindowsUIButtonPanel_Header"
        Me.WindowsUIButtonPanel_Header.PeekFormOptions.ShowOnItemHover = True
        Me.WindowsUIButtonPanel_Header.Size = New System.Drawing.Size(1080, 70)
        Me.WindowsUIButtonPanel_Header.TabIndex = 7
        Me.WindowsUIButtonPanel_Header.Text = "WindowsUIButtonPanel_Header"
        Me.WindowsUIButtonPanel_Header.WrapButtons = True
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(40, 40)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "Normal.png")
        Me.ImageCollection.Images.SetKeyName(1, "Hot.png")
        Me.ImageCollection.Images.SetKeyName(2, "Pressed.png")
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(803, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(277, 70)
        Me.PanelControl1.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LC_ItemWindowsPanel, Me.LayoutControlItem6, Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1084, 678)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LC_ItemWindowsPanel
        '
        Me.LC_ItemWindowsPanel.Control = Me.WindowsUIButtonPanel_Header
        Me.LC_ItemWindowsPanel.Location = New System.Drawing.Point(0, 594)
        Me.LC_ItemWindowsPanel.Name = "LC_ItemWindowsPanel"
        Me.LC_ItemWindowsPanel.Size = New System.Drawing.Size(1084, 74)
        Me.LC_ItemWindowsPanel.TextSize = New System.Drawing.Size(0, 0)
        Me.LC_ItemWindowsPanel.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Sp_MDEmployee_GetDataGridControl
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1084, 505)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 505)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1084, 89)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(118, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(470, 46)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SB_Exit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(118, 46)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SearchControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(588, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(472, 46)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "NavigationPage2"
        Me.NavigationPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1084, 678)
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Me.Sp_MDEmployee_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_MDEmployee_GetDataTableAdapter
        '
        Me.Sp_MDEmployee_GetDataTableAdapter.ClearBeforeFill = True
        '
        'DxErrorProvider
        '
        Me.DxErrorProvider.ContainerControl = Me
        '
        'Sp_MDPosition_GetDataTableAdapter
        '
        Me.Sp_MDPosition_GetDataTableAdapter.ClearBeforeFill = True
        '
        'SB_Back
        '
        Me.SB_Back.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_Back.Location = New System.Drawing.Point(12, 480)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.Size = New System.Drawing.Size(223, 36)
        Me.SB_Back.TabIndex = 10
        '
        'Frm_Employee
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 678)
        Me.ControlBox = False
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Employee"
        Me.Text = "Frm_SPMaterialReceiveCash"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StyleController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDEmployee_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDEmployee_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoLookUp_Position, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDPosition_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowsUIButtonPanel_Header.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_ItemWindowsPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents imageList1 As ImageList
    Friend WithEvents DataSet As DataSet
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents Sp_SPMaterialReceiveDetailGetDataBindingSource As BindingSource
    Friend WithEvents WindowsUIButtonPanel_Header As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents LC_ItemWindowsPanel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_MDEmployee_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents StyleController1 As DevExpress.XtraEditors.StyleController
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents Sp_MDEmployee_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDEmployee_GetDataTableAdapter As DataSetTableAdapters.sp_MDEmployee_GetDataTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPositionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepoLookUp_Position As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Sp_MDPosition_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDPosition_GetDataTableAdapter As DataSetTableAdapters.sp_MDPosition_GetDataTableAdapter
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
