<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MasterData
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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Sp_MDInventory_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.SpMDInventoryGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_MDInventory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset = New Mod_Purchase.Dataset()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_MDInventory_GetDataTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.TableAdapterManager = New Mod_Purchase.DatasetTableAdapters.TableAdapterManager()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(45, 42, 45, 42)
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.OptionsMenuMinWidth = 495
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1708, 178)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 919)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1708, 24)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_GetDataGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 178)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1708, 741)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Sp_MDInventory_GetDataGridControl
        '
        Me.Sp_MDInventory_GetDataGridControl.DataSource = Me.SpMDInventoryGetDataBindingSource
        Me.Sp_MDInventory_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sp_MDInventory_GetDataGridControl.Location = New System.Drawing.Point(18, 17)
        Me.Sp_MDInventory_GetDataGridControl.MainView = Me.GridView1
        Me.Sp_MDInventory_GetDataGridControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sp_MDInventory_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_MDInventory_GetDataGridControl.Name = "Sp_MDInventory_GetDataGridControl"
        Me.Sp_MDInventory_GetDataGridControl.Size = New System.Drawing.Size(1672, 707)
        Me.Sp_MDInventory_GetDataGridControl.TabIndex = 4
        Me.Sp_MDInventory_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SpMDInventoryGetDataBindingSource
        '
        Me.SpMDInventoryGetDataBindingSource.DataMember = "sp_MDInventory_GetData"
        Me.SpMDInventoryGetDataBindingSource.DataSource = Me.Sp_MDInventory_GetDataBindingSource
        '
        'Sp_MDInventory_GetDataBindingSource
        '
        Me.Sp_MDInventory_GetDataBindingSource.DataSource = Me.Dataset
        Me.Sp_MDInventory_GetDataBindingSource.Position = 0
        '
        'Dataset
        '
        Me.Dataset.DataSetName = "Dataset"
        Me.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBarcode, Me.colInventoryNo, Me.colInventoryName, Me.colBrandName, Me.colUoMID, Me.colMinStock, Me.colMaxStock, Me.colDescription, Me.colKodeHarga, Me.colHPP, Me.colLastPrice, Me.colStokAwal, Me.colStokAkhir, Me.colPrice, Me.colisActive, Me.colModifiedUser, Me.colModifiedDate})
        Me.GridView1.DetailHeight = 485
        Me.GridView1.GridControl = Me.Sp_MDInventory_GetDataGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 1200
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 112
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.MinWidth = 30
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 1
        Me.colBarcode.Width = 112
        '
        'colInventoryNo
        '
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MinWidth = 30
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 2
        Me.colInventoryNo.Width = 112
        '
        'colInventoryName
        '
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.MinWidth = 30
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 3
        Me.colInventoryName.Width = 112
        '
        'colBrandName
        '
        Me.colBrandName.FieldName = "BrandName"
        Me.colBrandName.MinWidth = 30
        Me.colBrandName.Name = "colBrandName"
        Me.colBrandName.Visible = True
        Me.colBrandName.VisibleIndex = 4
        Me.colBrandName.Width = 112
        '
        'colUoMID
        '
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.MinWidth = 30
        Me.colUoMID.Name = "colUoMID"
        Me.colUoMID.Visible = True
        Me.colUoMID.VisibleIndex = 5
        Me.colUoMID.Width = 112
        '
        'colMinStock
        '
        Me.colMinStock.FieldName = "MinStock"
        Me.colMinStock.MinWidth = 30
        Me.colMinStock.Name = "colMinStock"
        Me.colMinStock.Visible = True
        Me.colMinStock.VisibleIndex = 6
        Me.colMinStock.Width = 112
        '
        'colMaxStock
        '
        Me.colMaxStock.FieldName = "MaxStock"
        Me.colMaxStock.MinWidth = 30
        Me.colMaxStock.Name = "colMaxStock"
        Me.colMaxStock.Visible = True
        Me.colMaxStock.VisibleIndex = 7
        Me.colMaxStock.Width = 112
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MinWidth = 30
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 8
        Me.colDescription.Width = 112
        '
        'colKodeHarga
        '
        Me.colKodeHarga.FieldName = "KodeHarga"
        Me.colKodeHarga.MinWidth = 30
        Me.colKodeHarga.Name = "colKodeHarga"
        Me.colKodeHarga.Visible = True
        Me.colKodeHarga.VisibleIndex = 9
        Me.colKodeHarga.Width = 112
        '
        'colHPP
        '
        Me.colHPP.FieldName = "HPP"
        Me.colHPP.MinWidth = 30
        Me.colHPP.Name = "colHPP"
        Me.colHPP.Visible = True
        Me.colHPP.VisibleIndex = 10
        Me.colHPP.Width = 112
        '
        'colLastPrice
        '
        Me.colLastPrice.FieldName = "LastPrice"
        Me.colLastPrice.MinWidth = 30
        Me.colLastPrice.Name = "colLastPrice"
        Me.colLastPrice.Visible = True
        Me.colLastPrice.VisibleIndex = 11
        Me.colLastPrice.Width = 112
        '
        'colStokAwal
        '
        Me.colStokAwal.FieldName = "StokAwal"
        Me.colStokAwal.MinWidth = 30
        Me.colStokAwal.Name = "colStokAwal"
        Me.colStokAwal.Visible = True
        Me.colStokAwal.VisibleIndex = 12
        Me.colStokAwal.Width = 112
        '
        'colStokAkhir
        '
        Me.colStokAkhir.FieldName = "StokAkhir"
        Me.colStokAkhir.MinWidth = 30
        Me.colStokAkhir.Name = "colStokAkhir"
        Me.colStokAkhir.Visible = True
        Me.colStokAkhir.VisibleIndex = 13
        Me.colStokAkhir.Width = 112
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MinWidth = 30
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 14
        Me.colPrice.Width = 112
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.MinWidth = 30
        Me.colisActive.Name = "colisActive"
        Me.colisActive.Visible = True
        Me.colisActive.VisibleIndex = 15
        Me.colisActive.Width = 112
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.MinWidth = 30
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.Visible = True
        Me.colModifiedUser.VisibleIndex = 16
        Me.colModifiedUser.Width = 112
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.MinWidth = 30
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.Visible = True
        Me.colModifiedDate.VisibleIndex = 17
        Me.colModifiedDate.Width = 112
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1708, 741)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Sp_MDInventory_GetDataGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1678, 713)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'Sp_MDInventory_GetDataTableAdapter
        '
        Me.Sp_MDInventory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Me.Sp_MDInventory_GetDataTableAdapter
        Me.TableAdapterManager.sp_SPPurchaseOrderDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveDetail_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_SPPurchaseReceiveHeader_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mod_Purchase.DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Frm_MasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1708, 943)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Font = New System.Drawing.Font("Lato", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frm_MasterData"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Frm_MasterData"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Dataset As Dataset
    Friend WithEvents Sp_MDInventory_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_GetDataTableAdapter As DatasetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DatasetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_MDInventory_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpMDInventoryGetDataBindingSource As BindingSource
End Class
