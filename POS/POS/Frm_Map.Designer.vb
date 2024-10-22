<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Map
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Map))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.Panel_MapView = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_TableView = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Sp_POS_MDTable_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POS_MDTable_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New AHR_POS.DataSet()
        Me.GV_Table = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableCode_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableName_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableTypeID_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisCharge_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCapacity_Table = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Sp_POS_MDTable_GetDataTableAdapter = New AHR_POS.DataSetTableAdapters.sp_POS_MDTable_GetDataTableAdapter()
        Me.TableAdapterManager = New AHR_POS.DataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter = New AHR_POS.DataSetTableAdapters.QueriesTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_MapView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_MapView.SuspendLayout()
        CType(Me.Panel_TableView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_TableView.SuspendLayout()
        CType(Me.Sp_POS_MDTable_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_MDTable_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.OptionsTouch.ShowTouchUISelectorInQAT = True
        Me.RibbonControl.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = True
        Me.RibbonControl.OptionsTouch.TouchUI = True
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl.Size = New System.Drawing.Size(883, 181)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"1st Floor", "2nd Floor"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 577)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(883, 37)
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(388, 164)
        Me.PictureEdit1.MenuManager = Me.RibbonControl
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(65, 64)
        Me.PictureEdit1.TabIndex = 2
        Me.PictureEdit1.Tag = "sd"
        Me.PictureEdit1.ToolTip = "Meja 1"
        Me.PictureEdit1.ToolTipTitle = "sd"
        '
        'Panel_MapView
        '
        Me.Panel_MapView.Controls.Add(Me.PictureEdit1)
        Me.Panel_MapView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_MapView.Location = New System.Drawing.Point(0, 181)
        Me.Panel_MapView.Name = "Panel_MapView"
        Me.Panel_MapView.Size = New System.Drawing.Size(883, 433)
        Me.Panel_MapView.TabIndex = 3
        '
        'Panel_TableView
        '
        Me.Panel_TableView.Controls.Add(Me.SimpleButton1)
        Me.Panel_TableView.Controls.Add(Me.Panel1)
        Me.Panel_TableView.Controls.Add(Me.Sp_POS_MDTable_GetDataGridControl)
        Me.Panel_TableView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_TableView.Location = New System.Drawing.Point(0, 181)
        Me.Panel_TableView.Name = "Panel_TableView"
        Me.Panel_TableView.Size = New System.Drawing.Size(883, 433)
        Me.Panel_TableView.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(226, 89)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 122)
        Me.Panel1.TabIndex = 1
        '
        'Sp_POS_MDTable_GetDataGridControl
        '
        Me.Sp_POS_MDTable_GetDataGridControl.DataSource = Me.Sp_POS_MDTable_GetDataBindingSource
        Me.Sp_POS_MDTable_GetDataGridControl.Enabled = False
        Me.Sp_POS_MDTable_GetDataGridControl.Location = New System.Drawing.Point(533, 69)
        Me.Sp_POS_MDTable_GetDataGridControl.MainView = Me.GV_Table
        Me.Sp_POS_MDTable_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_POS_MDTable_GetDataGridControl.Name = "Sp_POS_MDTable_GetDataGridControl"
        Me.Sp_POS_MDTable_GetDataGridControl.Size = New System.Drawing.Size(300, 220)
        Me.Sp_POS_MDTable_GetDataGridControl.TabIndex = 0
        Me.Sp_POS_MDTable_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Table})
        '
        'Sp_POS_MDTable_GetDataBindingSource
        '
        Me.Sp_POS_MDTable_GetDataBindingSource.DataMember = "sp_POS_MDTable_GetData"
        Me.Sp_POS_MDTable_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_Table
        '
        Me.GV_Table.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Table, Me.colTableCode_Table, Me.colTableName_Table, Me.colTableTypeID_Table, Me.colisCharge_Table, Me.colisActive_Table, Me.colCapacity_Table})
        Me.GV_Table.GridControl = Me.Sp_POS_MDTable_GetDataGridControl
        Me.GV_Table.Name = "GV_Table"
        '
        'colID_Table
        '
        Me.colID_Table.FieldName = "ID"
        Me.colID_Table.Name = "colID_Table"
        Me.colID_Table.OptionsColumn.ReadOnly = True
        Me.colID_Table.Visible = True
        Me.colID_Table.VisibleIndex = 0
        '
        'colTableCode_Table
        '
        Me.colTableCode_Table.FieldName = "TableCode"
        Me.colTableCode_Table.Name = "colTableCode_Table"
        Me.colTableCode_Table.Visible = True
        Me.colTableCode_Table.VisibleIndex = 1
        '
        'colTableName_Table
        '
        Me.colTableName_Table.FieldName = "TableName"
        Me.colTableName_Table.Name = "colTableName_Table"
        Me.colTableName_Table.Visible = True
        Me.colTableName_Table.VisibleIndex = 2
        '
        'colTableTypeID_Table
        '
        Me.colTableTypeID_Table.FieldName = "TableTypeID"
        Me.colTableTypeID_Table.Name = "colTableTypeID_Table"
        Me.colTableTypeID_Table.Visible = True
        Me.colTableTypeID_Table.VisibleIndex = 3
        '
        'colisCharge_Table
        '
        Me.colisCharge_Table.FieldName = "isCharge"
        Me.colisCharge_Table.Name = "colisCharge_Table"
        Me.colisCharge_Table.Visible = True
        Me.colisCharge_Table.VisibleIndex = 4
        '
        'colisActive_Table
        '
        Me.colisActive_Table.FieldName = "isActive"
        Me.colisActive_Table.Name = "colisActive_Table"
        Me.colisActive_Table.Visible = True
        Me.colisActive_Table.VisibleIndex = 5
        '
        'colCapacity_Table
        '
        Me.colCapacity_Table.FieldName = "Capacity"
        Me.colCapacity_Table.Name = "colCapacity_Table"
        Me.colCapacity_Table.Visible = True
        Me.colCapacity_Table.VisibleIndex = 6
        '
        'Sp_POS_MDTable_GetDataTableAdapter
        '
        Me.Sp_POS_MDTable_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = AHR_POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Frm_Map
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 614)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.Panel_TableView)
        Me.Controls.Add(Me.Panel_MapView)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Frm_Map"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Map"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_MapView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_MapView.ResumeLayout(False)
        CType(Me.Panel_TableView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_TableView.ResumeLayout(False)
        CType(Me.Sp_POS_MDTable_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_MDTable_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Panel_MapView As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_TableView As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents DataSet As AHR_POS.DataSet
    Friend WithEvents Sp_POS_MDTable_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDTable_GetDataTableAdapter As AHR_POS.DataSetTableAdapters.sp_POS_MDTable_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As AHR_POS.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_POS_MDTable_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Table As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableCode_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableTypeID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisCharge_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapacity_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QueriesTableAdapter As AHR_POS.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton


End Class
