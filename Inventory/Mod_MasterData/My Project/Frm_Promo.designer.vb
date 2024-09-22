<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Promo
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Promo))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.Sp_MDPromo_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.CE_PromoGroup_isActive = New DevExpress.XtraEditors.CheckEdit()
        Me.SB_SubmitGroup = New DevExpress.XtraEditors.SimpleButton()
        Me.Sp_MDPromoGroup_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDPromoGroup_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_GroupPromo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromoBundle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromoName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromoPercentage1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyMin1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num_Group = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colQtyMax1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Group = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SB_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_New = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.IsGroupCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.IsPartialCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.QtyMaxSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.QtyMinSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.PromoNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Sp_MDPromo_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GV_Promo = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromoBundle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromoGrosir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromoName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromoPercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyMin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyMax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisPartial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisGroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PromoBundleSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PromoGrosirSpinEdit = New DevExpress.XtraEditors.RadioGroup()
        Me.Ed_PromoPercentage = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PromoGroup_Min = New DevExpress.XtraEditors.SpinEdit()
        Me.Ed_PromoGroup_Max = New DevExpress.XtraEditors.SpinEdit()
        Me.Ed_PromoGroup_Name = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LC_Global = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCPercentage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LC_Grup = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LC_JenisGrosir = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_GrupPromo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_MDPromo_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDPromo_GetDataTableAdapter()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Sp_MDPromoGroup_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDPromoGroup_GetDataTableAdapter()
        Me.QueriesTableAdapter = New Master_Data.DataSet_ReportTableAdapters.QueriesTableAdapter()
        Me.QueriesTableAdapter1 = New Master_Data.DataSetTableAdapters.QueriesTableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDPromo_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_PromoGroup_isActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDPromoGroup_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDPromoGroup_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_GroupPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Num_Group, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsGroupCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsPartialCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyMaxSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyMinSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromoNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDPromo_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Promo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromoBundleSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromoGrosirSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PromoPercentage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PromoGroup_Min.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PromoGroup_Max.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PromoGroup_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Global, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Grup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_JenisGrosir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_GrupPromo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl1.Controls.Add(Me.CE_PromoGroup_isActive)
        Me.LayoutControl1.Controls.Add(Me.SB_SubmitGroup)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDPromoGroup_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.SB_Close)
        Me.LayoutControl1.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl1.Controls.Add(Me.SB_Back)
        Me.LayoutControl1.Controls.Add(Me.SB_Submit)
        Me.LayoutControl1.Controls.Add(Me.SB_New)
        Me.LayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.LayoutControl1.Controls.Add(Me.IsGroupCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.IsPartialCheckEdit)
        Me.LayoutControl1.Controls.Add(Me.QtyMaxSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.QtyMinSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.PromoNameTextEdit)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDPromo_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.PromoBundleSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.PromoGrosirSpinEdit)
        Me.LayoutControl1.Controls.Add(Me.Ed_PromoPercentage)
        Me.LayoutControl1.Controls.Add(Me.Ed_PromoGroup_Min)
        Me.LayoutControl1.Controls.Add(Me.Ed_PromoGroup_Max)
        Me.LayoutControl1.Controls.Add(Me.Ed_PromoGroup_Name)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 85)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1548, 877)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "Description", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(1186, 663)
        Me.MemoEdit1.MenuManager = Me.RibbonControl1
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(314, 30)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 22
        '
        'Sp_MDPromo_GetDataBindingSource
        '
        Me.Sp_MDPromo_GetDataBindingSource.DataMember = "sp_MDPromo_GetData"
        Me.Sp_MDPromo_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonControl1
        '
        Me.RibbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(40, 37, 40, 37)
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.OptionsMenuMinWidth = 440
        Me.RibbonControl1.Size = New System.Drawing.Size(1548, 85)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 962)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1548, 39)
        '
        'CE_PromoGroup_isActive
        '
        Me.CE_PromoGroup_isActive.Location = New System.Drawing.Point(1443, 146)
        Me.CE_PromoGroup_isActive.MenuManager = Me.RibbonControl1
        Me.CE_PromoGroup_isActive.Name = "CE_PromoGroup_isActive"
        Me.CE_PromoGroup_isActive.Properties.Caption = "Aktif"
        Me.CE_PromoGroup_isActive.Size = New System.Drawing.Size(57, 22)
        Me.CE_PromoGroup_isActive.StyleController = Me.LayoutControl1
        Me.CE_PromoGroup_isActive.TabIndex = 21
        '
        'SB_SubmitGroup
        '
        Me.SB_SubmitGroup.Location = New System.Drawing.Point(1176, 308)
        Me.SB_SubmitGroup.Name = "SB_SubmitGroup"
        Me.SB_SubmitGroup.Size = New System.Drawing.Size(324, 28)
        Me.SB_SubmitGroup.StyleController = Me.LayoutControl1
        Me.SB_SubmitGroup.TabIndex = 20
        Me.SB_SubmitGroup.Text = "Submit"
        '
        'Sp_MDPromoGroup_GetDataGridControl
        '
        Me.Sp_MDPromoGroup_GetDataGridControl.DataSource = Me.Sp_MDPromoGroup_GetDataBindingSource
        Me.Sp_MDPromoGroup_GetDataGridControl.Location = New System.Drawing.Point(32, 103)
        Me.Sp_MDPromoGroup_GetDataGridControl.MainView = Me.GV_GroupPromo
        Me.Sp_MDPromoGroup_GetDataGridControl.MenuManager = Me.RibbonControl1
        Me.Sp_MDPromoGroup_GetDataGridControl.Name = "Sp_MDPromoGroup_GetDataGridControl"
        Me.Sp_MDPromoGroup_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_Num_Group})
        Me.Sp_MDPromoGroup_GetDataGridControl.Size = New System.Drawing.Size(1090, 175)
        Me.Sp_MDPromoGroup_GetDataGridControl.TabIndex = 19
        Me.Sp_MDPromoGroup_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_GroupPromo})
        '
        'Sp_MDPromoGroup_GetDataBindingSource
        '
        Me.Sp_MDPromoGroup_GetDataBindingSource.DataMember = "sp_MDPromoGroup_GetData"
        Me.Sp_MDPromoGroup_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_GroupPromo
        '
        Me.GV_GroupPromo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colPromoBundle1, Me.colPromoName1, Me.colPromoPercentage1, Me.colQtyMin1, Me.colQtyMax1, Me.colModifiedUser1, Me.colisActive, Me.colDescription_Group})
        Me.GV_GroupPromo.GridControl = Me.Sp_MDPromoGroup_GetDataGridControl
        Me.GV_GroupPromo.Name = "GV_GroupPromo"
        Me.GV_GroupPromo.OptionsView.ShowGroupPanel = False
        Me.GV_GroupPromo.OptionsView.ShowIndicator = False
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'colPromoBundle1
        '
        Me.colPromoBundle1.Caption = "Promo Global No."
        Me.colPromoBundle1.FieldName = "PromoBundle"
        Me.colPromoBundle1.Name = "colPromoBundle1"
        Me.colPromoBundle1.Visible = True
        Me.colPromoBundle1.VisibleIndex = 0
        Me.colPromoBundle1.Width = 141
        '
        'colPromoName1
        '
        Me.colPromoName1.Caption = "Promo Global Name"
        Me.colPromoName1.FieldName = "PromoName"
        Me.colPromoName1.Name = "colPromoName1"
        Me.colPromoName1.OptionsFilter.AllowFilter = False
        Me.colPromoName1.Visible = True
        Me.colPromoName1.VisibleIndex = 1
        Me.colPromoName1.Width = 149
        '
        'colPromoPercentage1
        '
        Me.colPromoPercentage1.FieldName = "PromoPercentage"
        Me.colPromoPercentage1.Name = "colPromoPercentage1"
        Me.colPromoPercentage1.OptionsFilter.AllowFilter = False
        Me.colPromoPercentage1.Visible = True
        Me.colPromoPercentage1.VisibleIndex = 2
        Me.colPromoPercentage1.Width = 132
        '
        'colQtyMin1
        '
        Me.colQtyMin1.ColumnEdit = Me.Repo_Num_Group
        Me.colQtyMin1.DisplayFormat.FormatString = "n0"
        Me.colQtyMin1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyMin1.FieldName = "QtyMin"
        Me.colQtyMin1.Name = "colQtyMin1"
        Me.colQtyMin1.Visible = True
        Me.colQtyMin1.VisibleIndex = 3
        Me.colQtyMin1.Width = 158
        '
        'Repo_Num_Group
        '
        Me.Repo_Num_Group.AutoHeight = False
        Me.Repo_Num_Group.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Repo_Num_Group.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.Repo_Num_Group.MaskSettings.Set("mask", "n0")
        Me.Repo_Num_Group.Name = "Repo_Num_Group"
        Me.Repo_Num_Group.UseMaskAsDisplayFormat = True
        '
        'colQtyMax1
        '
        Me.colQtyMax1.ColumnEdit = Me.Repo_Num_Group
        Me.colQtyMax1.DisplayFormat.FormatString = "n0"
        Me.colQtyMax1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyMax1.FieldName = "QtyMax"
        Me.colQtyMax1.Name = "colQtyMax1"
        Me.colQtyMax1.Visible = True
        Me.colQtyMax1.VisibleIndex = 4
        Me.colQtyMax1.Width = 163
        '
        'colModifiedUser1
        '
        Me.colModifiedUser1.Caption = "Aktif"
        Me.colModifiedUser1.FieldName = "ModifiedUser"
        Me.colModifiedUser1.Name = "colModifiedUser1"
        Me.colModifiedUser1.OptionsFilter.AllowFilter = False
        '
        'colisActive
        '
        Me.colisActive.Caption = "Aktif"
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        Me.colisActive.Visible = True
        Me.colisActive.VisibleIndex = 6
        Me.colisActive.Width = 161
        '
        'colDescription_Group
        '
        Me.colDescription_Group.FieldName = "Description"
        Me.colDescription_Group.Name = "colDescription_Group"
        Me.colDescription_Group.Visible = True
        Me.colDescription_Group.VisibleIndex = 5
        Me.colDescription_Group.Width = 683
        '
        'SB_Close
        '
        Me.SB_Close.ImageOptions.Image = CType(resources.GetObject("SB_Close.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Close.Location = New System.Drawing.Point(1046, 59)
        Me.SB_Close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Close.Name = "SB_Close"
        Me.SB_Close.Size = New System.Drawing.Size(76, 38)
        Me.SB_Close.StyleController = Me.LayoutControl1
        Me.SB_Close.TabIndex = 19
        '
        'SB_Refresh
        '
        Me.SB_Refresh.ImageOptions.Image = CType(resources.GetObject("SB_Refresh.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Refresh.Location = New System.Drawing.Point(783, 59)
        Me.SB_Refresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Refresh.Size = New System.Drawing.Size(257, 38)
        Me.SB_Refresh.StyleController = Me.LayoutControl1
        Me.SB_Refresh.TabIndex = 18
        '
        'SB_Back
        '
        Me.SB_Back.ImageOptions.Image = CType(resources.GetObject("SB_Back.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Back.Location = New System.Drawing.Point(1160, 59)
        Me.SB_Back.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_Back.Size = New System.Drawing.Size(356, 38)
        Me.SB_Back.StyleController = Me.LayoutControl1
        Me.SB_Back.TabIndex = 17
        Me.SB_Back.Text = "Back"
        '
        'SB_Submit
        '
        Me.SB_Submit.ImageOptions.Image = CType(resources.GetObject("SB_Submit.ImageOptions.Image"), System.Drawing.Image)
        Me.SB_Submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.SB_Submit.Location = New System.Drawing.Point(1176, 765)
        Me.SB_Submit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.Size = New System.Drawing.Size(324, 38)
        Me.SB_Submit.StyleController = Me.LayoutControl1
        Me.SB_Submit.TabIndex = 16
        Me.SB_Submit.Text = "Submit"
        '
        'SB_New
        '
        Me.SB_New.ImageOptions.SvgImage = CType(resources.GetObject("SB_New.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_New.Location = New System.Drawing.Point(32, 59)
        Me.SB_New.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SB_New.Name = "SB_New"
        Me.SB_New.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SB_New.Size = New System.Drawing.Size(227, 30)
        Me.SB_New.StyleController = Me.LayoutControl1
        Me.SB_New.TabIndex = 15
        Me.SB_New.Text = "New Promo"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = True
        Me.RadioGroup1.Location = New System.Drawing.Point(1317, 473)
        Me.RadioGroup1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Partial"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Group")})
        Me.RadioGroup1.Size = New System.Drawing.Size(183, 38)
        Me.RadioGroup1.StyleController = Me.LayoutControl1
        Me.RadioGroup1.TabIndex = 14
        '
        'IsGroupCheckEdit
        '
        Me.IsGroupCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Sp_MDPromo_GetDataBindingSource, "isGroup", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.IsGroupCheckEdit.Location = New System.Drawing.Point(1317, 727)
        Me.IsGroupCheckEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IsGroupCheckEdit.Name = "IsGroupCheckEdit"
        Me.IsGroupCheckEdit.Properties.Caption = "Group"
        Me.IsGroupCheckEdit.Size = New System.Drawing.Size(183, 22)
        Me.IsGroupCheckEdit.StyleController = Me.LayoutControl1
        Me.IsGroupCheckEdit.TabIndex = 13
        '
        'IsPartialCheckEdit
        '
        Me.IsPartialCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Sp_MDPromo_GetDataBindingSource, "isPartial", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.IsPartialCheckEdit.Location = New System.Drawing.Point(1317, 699)
        Me.IsPartialCheckEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.IsPartialCheckEdit.Name = "IsPartialCheckEdit"
        Me.IsPartialCheckEdit.Properties.Caption = "Partial"
        Me.IsPartialCheckEdit.Size = New System.Drawing.Size(183, 22)
        Me.IsPartialCheckEdit.StyleController = Me.LayoutControl1
        Me.IsPartialCheckEdit.TabIndex = 12
        '
        'QtyMaxSpinEdit
        '
        Me.QtyMaxSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "QtyMax", True))
        Me.QtyMaxSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.QtyMaxSpinEdit.Location = New System.Drawing.Point(1350, 605)
        Me.QtyMaxSpinEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QtyMaxSpinEdit.Name = "QtyMaxSpinEdit"
        Me.QtyMaxSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QtyMaxSpinEdit.Properties.MaskSettings.Set("mask", "n0")
        Me.QtyMaxSpinEdit.Properties.UseMaskAsDisplayFormat = True
        Me.QtyMaxSpinEdit.Size = New System.Drawing.Size(150, 30)
        Me.QtyMaxSpinEdit.StyleController = Me.LayoutControl1
        Me.QtyMaxSpinEdit.TabIndex = 11
        '
        'QtyMinSpinEdit
        '
        Me.QtyMinSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "QtyMin", True))
        Me.QtyMinSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.QtyMinSpinEdit.Location = New System.Drawing.Point(1186, 605)
        Me.QtyMinSpinEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QtyMinSpinEdit.Name = "QtyMinSpinEdit"
        Me.QtyMinSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.QtyMinSpinEdit.Properties.MaskSettings.Set("mask", "n0")
        Me.QtyMinSpinEdit.Properties.UseMaskAsDisplayFormat = True
        Me.QtyMinSpinEdit.Size = New System.Drawing.Size(158, 30)
        Me.QtyMinSpinEdit.StyleController = Me.LayoutControl1
        Me.QtyMinSpinEdit.TabIndex = 10
        '
        'PromoNameTextEdit
        '
        Me.PromoNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "PromoName", True))
        Me.PromoNameTextEdit.Location = New System.Drawing.Point(1317, 437)
        Me.PromoNameTextEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PromoNameTextEdit.Name = "PromoNameTextEdit"
        Me.PromoNameTextEdit.Size = New System.Drawing.Size(183, 30)
        Me.PromoNameTextEdit.StyleController = Me.LayoutControl1
        Me.PromoNameTextEdit.TabIndex = 8
        '
        'Sp_MDPromo_GetDataGridControl
        '
        Me.Sp_MDPromo_GetDataGridControl.DataSource = Me.Sp_MDPromo_GetDataBindingSource
        Me.Sp_MDPromo_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Sp_MDPromo_GetDataGridControl.Location = New System.Drawing.Point(32, 284)
        Me.Sp_MDPromo_GetDataGridControl.MainView = Me.GV_Promo
        Me.Sp_MDPromo_GetDataGridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sp_MDPromo_GetDataGridControl.Name = "Sp_MDPromo_GetDataGridControl"
        Me.Sp_MDPromo_GetDataGridControl.Size = New System.Drawing.Size(1090, 561)
        Me.Sp_MDPromo_GetDataGridControl.TabIndex = 4
        Me.Sp_MDPromo_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Promo})
        '
        'GV_Promo
        '
        Me.GV_Promo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colPromoBundle, Me.colPromoGrosir, Me.colPromoName, Me.colPromoPercentage, Me.colQtyMin, Me.colQtyMax, Me.colisPartial, Me.colisGroup, Me.colModifiedUser, Me.colMode, Me.colDescription})
        Me.GV_Promo.DetailHeight = 431
        Me.GV_Promo.GridControl = Me.Sp_MDPromo_GetDataGridControl
        Me.GV_Promo.Name = "GV_Promo"
        Me.GV_Promo.OptionsBehavior.AutoExpandAllGroups = True
        Me.GV_Promo.OptionsPrint.ExpandAllDetails = True
        Me.GV_Promo.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 26
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.Width = 99
        '
        'colPromoBundle
        '
        Me.colPromoBundle.Caption = "Promo Bundle No. "
        Me.colPromoBundle.FieldName = "PromoBundle"
        Me.colPromoBundle.MinWidth = 26
        Me.colPromoBundle.Name = "colPromoBundle"
        Me.colPromoBundle.OptionsColumn.AllowEdit = False
        Me.colPromoBundle.OptionsColumn.AllowFocus = False
        Me.colPromoBundle.Visible = True
        Me.colPromoBundle.VisibleIndex = 0
        Me.colPromoBundle.Width = 99
        '
        'colPromoGrosir
        '
        Me.colPromoGrosir.Caption = "Tipe Grosir"
        Me.colPromoGrosir.FieldName = "PromoGrosir"
        Me.colPromoGrosir.MinWidth = 26
        Me.colPromoGrosir.Name = "colPromoGrosir"
        Me.colPromoGrosir.OptionsColumn.AllowEdit = False
        Me.colPromoGrosir.OptionsColumn.AllowFocus = False
        Me.colPromoGrosir.Visible = True
        Me.colPromoGrosir.VisibleIndex = 1
        Me.colPromoGrosir.Width = 99
        '
        'colPromoName
        '
        Me.colPromoName.FieldName = "PromoName"
        Me.colPromoName.MinWidth = 26
        Me.colPromoName.Name = "colPromoName"
        Me.colPromoName.OptionsColumn.AllowEdit = False
        Me.colPromoName.OptionsColumn.AllowFocus = False
        Me.colPromoName.Visible = True
        Me.colPromoName.VisibleIndex = 2
        Me.colPromoName.Width = 99
        '
        'colPromoPercentage
        '
        Me.colPromoPercentage.FieldName = "PromoPercentage"
        Me.colPromoPercentage.MinWidth = 26
        Me.colPromoPercentage.Name = "colPromoPercentage"
        Me.colPromoPercentage.OptionsColumn.AllowEdit = False
        Me.colPromoPercentage.OptionsColumn.AllowFocus = False
        Me.colPromoPercentage.Width = 99
        '
        'colQtyMin
        '
        Me.colQtyMin.DisplayFormat.FormatString = "n0"
        Me.colQtyMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyMin.FieldName = "QtyMin"
        Me.colQtyMin.MinWidth = 26
        Me.colQtyMin.Name = "colQtyMin"
        Me.colQtyMin.OptionsColumn.AllowEdit = False
        Me.colQtyMin.OptionsColumn.AllowFocus = False
        Me.colQtyMin.Visible = True
        Me.colQtyMin.VisibleIndex = 3
        Me.colQtyMin.Width = 99
        '
        'colQtyMax
        '
        Me.colQtyMax.DisplayFormat.FormatString = "n0"
        Me.colQtyMax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyMax.FieldName = "QtyMax"
        Me.colQtyMax.MinWidth = 26
        Me.colQtyMax.Name = "colQtyMax"
        Me.colQtyMax.OptionsColumn.AllowEdit = False
        Me.colQtyMax.OptionsColumn.AllowFocus = False
        Me.colQtyMax.OptionsFilter.AllowFilter = False
        Me.colQtyMax.Visible = True
        Me.colQtyMax.VisibleIndex = 4
        Me.colQtyMax.Width = 99
        '
        'colisPartial
        '
        Me.colisPartial.FieldName = "isPartial"
        Me.colisPartial.MinWidth = 26
        Me.colisPartial.Name = "colisPartial"
        Me.colisPartial.OptionsColumn.AllowEdit = False
        Me.colisPartial.OptionsColumn.AllowFocus = False
        Me.colisPartial.Width = 99
        '
        'colisGroup
        '
        Me.colisGroup.FieldName = "isGroup"
        Me.colisGroup.MinWidth = 26
        Me.colisGroup.Name = "colisGroup"
        Me.colisGroup.OptionsColumn.AllowEdit = False
        Me.colisGroup.OptionsColumn.AllowFocus = False
        Me.colisGroup.Width = 99
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 26
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        Me.colModifiedUser.Width = 99
        '
        'colMode
        '
        Me.colMode.FieldName = "Mode"
        Me.colMode.MinWidth = 26
        Me.colMode.Name = "colMode"
        Me.colMode.OptionsColumn.AllowEdit = False
        Me.colMode.OptionsColumn.AllowFocus = False
        Me.colMode.Width = 99
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        '
        'PromoBundleSpinEdit
        '
        Me.PromoBundleSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "PromoBundle", True))
        Me.PromoBundleSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PromoBundleSpinEdit.Location = New System.Drawing.Point(1317, 401)
        Me.PromoBundleSpinEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PromoBundleSpinEdit.Name = "PromoBundleSpinEdit"
        Me.PromoBundleSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.PromoBundleSpinEdit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.PromoBundleSpinEdit.Properties.MaskSettings.Set("mask", "d")
        Me.PromoBundleSpinEdit.Size = New System.Drawing.Size(183, 30)
        Me.PromoBundleSpinEdit.StyleController = Me.LayoutControl1
        Me.PromoBundleSpinEdit.TabIndex = 6
        '
        'PromoGrosirSpinEdit
        '
        Me.PromoGrosirSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("SelectedIndex", Me.Sp_MDPromo_GetDataBindingSource, "PromoGrosir", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.PromoGrosirSpinEdit.EditValue = CType(1, Short)
        Me.PromoGrosirSpinEdit.Location = New System.Drawing.Point(1186, 539)
        Me.PromoGrosirSpinEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PromoGrosirSpinEdit.Name = "PromoGrosirSpinEdit"
        Me.PromoGrosirSpinEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PromoGrosirSpinEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PromoGrosirSpinEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PromoGrosirSpinEdit.Properties.Columns = 3
        Me.PromoGrosirSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.PromoGrosirSpinEdit.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Grosir 1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Grosir 2"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Grosir 3")})
        Me.PromoGrosirSpinEdit.Size = New System.Drawing.Size(314, 38)
        Me.PromoGrosirSpinEdit.StyleController = Me.LayoutControl1
        Me.PromoGrosirSpinEdit.TabIndex = 7
        '
        'Ed_PromoPercentage
        '
        Me.Ed_PromoPercentage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "PromoPercentage", True))
        Me.Ed_PromoPercentage.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_PromoPercentage.Location = New System.Drawing.Point(1186, 204)
        Me.Ed_PromoPercentage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_PromoPercentage.Name = "Ed_PromoPercentage"
        Me.Ed_PromoPercentage.Properties.DisplayFormat.FormatString = "n2"
        Me.Ed_PromoPercentage.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Ed_PromoPercentage.Properties.EditFormat.FormatString = "n2"
        Me.Ed_PromoPercentage.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Ed_PromoPercentage.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.Ed_PromoPercentage.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.Ed_PromoPercentage.Size = New System.Drawing.Size(314, 30)
        Me.Ed_PromoPercentage.StyleController = Me.LayoutControl1
        Me.Ed_PromoPercentage.TabIndex = 9
        '
        'Ed_PromoGroup_Min
        '
        Me.Ed_PromoGroup_Min.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "QtyMin", True))
        Me.Ed_PromoGroup_Min.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_PromoGroup_Min.Location = New System.Drawing.Point(1186, 262)
        Me.Ed_PromoGroup_Min.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_PromoGroup_Min.Name = "Ed_PromoGroup_Min"
        Me.Ed_PromoGroup_Min.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_PromoGroup_Min.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_PromoGroup_Min.Properties.UseMaskAsDisplayFormat = True
        Me.Ed_PromoGroup_Min.Size = New System.Drawing.Size(154, 30)
        Me.Ed_PromoGroup_Min.StyleController = Me.LayoutControl1
        Me.Ed_PromoGroup_Min.TabIndex = 10
        '
        'Ed_PromoGroup_Max
        '
        Me.Ed_PromoGroup_Max.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "QtyMax", True))
        Me.Ed_PromoGroup_Max.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_PromoGroup_Max.Location = New System.Drawing.Point(1346, 262)
        Me.Ed_PromoGroup_Max.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_PromoGroup_Max.Name = "Ed_PromoGroup_Max"
        Me.Ed_PromoGroup_Max.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_PromoGroup_Max.Properties.MaskSettings.Set("mask", "n0")
        Me.Ed_PromoGroup_Max.Properties.UseMaskAsDisplayFormat = True
        Me.Ed_PromoGroup_Max.Size = New System.Drawing.Size(154, 30)
        Me.Ed_PromoGroup_Max.StyleController = Me.LayoutControl1
        Me.Ed_PromoGroup_Max.TabIndex = 11
        '
        'Ed_PromoGroup_Name
        '
        Me.Ed_PromoGroup_Name.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Sp_MDPromo_GetDataBindingSource, "PromoName", True))
        Me.Ed_PromoGroup_Name.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Sp_MDPromo_GetDataBindingSource, "ID", True))
        Me.Ed_PromoGroup_Name.Location = New System.Drawing.Point(1317, 146)
        Me.Ed_PromoGroup_Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Ed_PromoGroup_Name.Name = "Ed_PromoGroup_Name"
        Me.Ed_PromoGroup_Name.Size = New System.Drawing.Size(120, 30)
        Me.Ed_PromoGroup_Name.StyleController = Me.LayoutControl1
        Me.Ed_PromoGroup_Name.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1548, 877)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = ".:: Detail ::."
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LC_Global, Me.LC_Grup})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(1128, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(394, 851)
        Me.LayoutControlGroup2.Text = ".:: Detail ::."
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SB_Back
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(362, 44)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 766)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(362, 0)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(362, 10)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(362, 26)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LC_Global
        '
        Me.LC_Global.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem17, Me.LayoutControlItem19, Me.EmptySpaceItem4, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem18, Me.LCPercentage, Me.EmptySpaceItem6})
        Me.LC_Global.Location = New System.Drawing.Point(0, 44)
        Me.LC_Global.Name = "LC_Global"
        Me.LC_Global.Size = New System.Drawing.Size(362, 255)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.Ed_PromoGroup_Name
        Me.LayoutControlItem17.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem17.CustomizationFormText = "Promo Name:"
        Me.LayoutControlItem17.Location = New System.Drawing.Point(10, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(257, 36)
        Me.LayoutControlItem17.Text = "Promo Name:"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.CE_PromoGroup_isActive
        Me.LayoutControlItem19.Location = New System.Drawing.Point(267, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(63, 36)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        Me.LayoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 152)
        Me.EmptySpaceItem4.MaxSize = New System.Drawing.Size(330, 10)
        Me.EmptySpaceItem4.MinSize = New System.Drawing.Size(330, 10)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(330, 10)
        Me.EmptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Ed_PromoGroup_Min
        Me.LayoutControlItem15.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem15.CustomizationFormText = "Qty Min:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(10, 94)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(160, 58)
        Me.LayoutControlItem15.Text = "Qty Min:"
        Me.LayoutControlItem15.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.Ed_PromoGroup_Max
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Qty Max:"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(170, 94)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(160, 58)
        Me.LayoutControlItem16.Text = "Qty Max:"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.SB_SubmitGroup
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 162)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(330, 34)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LCPercentage
        '
        Me.LCPercentage.Control = Me.Ed_PromoPercentage
        Me.LCPercentage.Location = New System.Drawing.Point(10, 36)
        Me.LCPercentage.Name = "LCPercentage"
        Me.LCPercentage.Size = New System.Drawing.Size(320, 58)
        Me.LCPercentage.Text = "Promo % :"
        Me.LCPercentage.TextLocation = DevExpress.Utils.Locations.Top
        Me.LCPercentage.TextSize = New System.Drawing.Size(115, 16)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem6.MaxSize = New System.Drawing.Size(10, 152)
        Me.EmptySpaceItem6.MinSize = New System.Drawing.Size(10, 152)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(10, 152)
        Me.EmptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LC_Grup
        '
        Me.LC_Grup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LC_JenisGrosir, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem3, Me.LayoutControlItem12, Me.EmptySpaceItem5, Me.LayoutControlItem14})
        Me.LC_Grup.Location = New System.Drawing.Point(0, 299)
        Me.LC_Grup.Name = "LC_Grup"
        Me.LC_Grup.Size = New System.Drawing.Size(362, 467)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PromoBundleSpinEdit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(10, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(320, 36)
        Me.LayoutControlItem3.Text = "Promo Bundle:"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.PromoNameTextEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(10, 36)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(320, 36)
        Me.LayoutControlItem5.Text = "Promo Name:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(10, 72)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(320, 44)
        Me.LayoutControlItem2.Text = "Jenis Promo :"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(115, 16)
        Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LC_JenisGrosir
        '
        Me.LC_JenisGrosir.Control = Me.PromoGrosirSpinEdit
        Me.LC_JenisGrosir.Location = New System.Drawing.Point(10, 116)
        Me.LC_JenisGrosir.Name = "LC_JenisGrosir"
        Me.LC_JenisGrosir.Size = New System.Drawing.Size(320, 66)
        Me.LC_JenisGrosir.Text = "Promo Grosir:"
        Me.LC_JenisGrosir.TextLocation = DevExpress.Utils.Locations.Top
        Me.LC_JenisGrosir.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.QtyMinSpinEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(10, 182)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(164, 58)
        Me.LayoutControlItem7.Text = "Qty Min:"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.QtyMaxSpinEdit
        Me.LayoutControlItem8.Location = New System.Drawing.Point(174, 182)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(156, 58)
        Me.LayoutControlItem8.Text = "Qty Max:"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.IsPartialCheckEdit
        Me.LayoutControlItem9.Location = New System.Drawing.Point(10, 298)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(320, 28)
        Me.LayoutControlItem9.Text = "is Partial:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(115, 16)
        Me.LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.IsGroupCheckEdit
        Me.LayoutControlItem10.Location = New System.Drawing.Point(10, 326)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(320, 28)
        Me.LayoutControlItem10.Text = "is Group:"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(115, 16)
        Me.LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 354)
        Me.EmptySpaceItem3.MaxSize = New System.Drawing.Size(330, 10)
        Me.EmptySpaceItem3.MinSize = New System.Drawing.Size(330, 10)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(330, 10)
        Me.EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.SB_Submit
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 364)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(330, 44)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem5.MaxSize = New System.Drawing.Size(10, 306)
        Me.EmptySpaceItem5.MinSize = New System.Drawing.Size(10, 306)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(10, 354)
        Me.EmptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.MemoEdit1
        Me.LayoutControlItem14.Location = New System.Drawing.Point(10, 240)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(320, 58)
        Me.LayoutControlItem14.Text = "Keterangan Promo :"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(115, 16)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem13, Me.LCItem_GrupPromo})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1128, 851)
        Me.LayoutControlGroup3.Text = ".:: Header ::."
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.SB_New
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(233, 44)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(233, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(518, 44)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Sp_MDPromo_GetDataGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 225)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1096, 567)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SB_Refresh
        Me.LayoutControlItem6.Location = New System.Drawing.Point(751, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(263, 44)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.SB_Close
        Me.LayoutControlItem13.Location = New System.Drawing.Point(1014, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(82, 44)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LCItem_GrupPromo
        '
        Me.LCItem_GrupPromo.Control = Me.Sp_MDPromoGroup_GetDataGridControl
        Me.LCItem_GrupPromo.Location = New System.Drawing.Point(0, 44)
        Me.LCItem_GrupPromo.Name = "LCItem_GrupPromo"
        Me.LCItem_GrupPromo.Size = New System.Drawing.Size(1096, 181)
        Me.LCItem_GrupPromo.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_GrupPromo.TextVisible = False
        '
        'Sp_MDPromo_GetDataTableAdapter
        '
        Me.Sp_MDPromo_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDCustomer_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDPromo_GetDataTableAdapter = Me.Sp_MDPromo_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDSupplier_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Sp_MDPromoGroup_GetDataTableAdapter
        '
        Me.Sp_MDPromoGroup_GetDataTableAdapter.ClearBeforeFill = True
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'Frm_Promo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1548, 1001)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Promo"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Master Promo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDPromo_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_PromoGroup_isActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDPromoGroup_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDPromoGroup_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_GroupPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Num_Group, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsGroupCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsPartialCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyMaxSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyMinSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromoNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDPromo_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Promo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromoBundleSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromoGrosirSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PromoPercentage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PromoGroup_Min.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PromoGroup_Max.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PromoGroup_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Global, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Grup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_JenisGrosir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_GrupPromo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataSet As DataSet
    Friend WithEvents Sp_MDPromo_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDPromo_GetDataTableAdapter As DataSetTableAdapters.sp_MDPromo_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents IsGroupCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents IsPartialCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents QtyMaxSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents QtyMinSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents PromoNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Sp_MDPromo_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromoBundle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromoGrosir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromoName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromoPercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyMin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyMax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisPartial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisGroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PromoBundleSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PromoGrosirSpinEdit As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Ed_PromoPercentage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LC_JenisGrosir As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCPercentage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents SB_New As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GV_Promo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colMode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SB_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Sp_MDPromoGroup_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDPromoGroup_GetDataTableAdapter As DataSetTableAdapters.sp_MDPromoGroup_GetDataTableAdapter
    Friend WithEvents Sp_MDPromoGroup_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_GroupPromo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromoBundle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromoName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromoPercentage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyMin1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyMax1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LCItem_GrupPromo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Ed_PromoGroup_Min As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Ed_PromoGroup_Max As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_SubmitGroup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_PromoGroup_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents QueriesTableAdapter As DataSet_ReportTableAdapters.QueriesTableAdapter
    Friend WithEvents QueriesTableAdapter1 As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents CE_PromoGroup_isActive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents LC_Global As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LC_Grup As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colDescription_Group As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Repo_Num_Group As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
