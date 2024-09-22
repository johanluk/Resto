<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InvListDetail
    Inherits DevExpress.XtraEditors.DirectXForm

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DirectXFormContainerControl1 = New DevExpress.XtraEditors.DirectXFormContainerControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelBarang = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.SpMDInventoryGetHPPHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.GV_HPP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpMDInventoryGetTransactionDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_HistoryTransaction = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPOSNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPOSDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_MDInventory_GetTransactionDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetTransactionDataTableAdapter()
        Me.Sp_MDInventory_GetHPPHistoryTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetHPPHistoryTableAdapter()
        Me.DirectXFormContainerControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetHPPHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_HPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetTransactionDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_HistoryTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DirectXFormContainerControl1
        '
        Me.DirectXFormContainerControl1.Controls.Add(Me.LayoutControl1)
        Me.DirectXFormContainerControl1.Location = New System.Drawing.Point(1, 29)
        Me.DirectXFormContainerControl1.Name = "DirectXFormContainerControl1"
        Me.DirectXFormContainerControl1.Size = New System.Drawing.Size(1316, 665)
        Me.DirectXFormContainerControl1.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelBarang)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1316, 665)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LabelBarang
        '
        Me.LabelBarang.Appearance.Font = New System.Drawing.Font("Lato", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelBarang.Appearance.Options.UseFont = True
        Me.LabelBarang.Location = New System.Drawing.Point(13, 13)
        Me.LabelBarang.Name = "LabelBarang"
        Me.LabelBarang.Size = New System.Drawing.Size(171, 33)
        Me.LabelBarang.StyleController = Me.LayoutControl1
        Me.LabelBarang.TabIndex = 8
        Me.LabelBarang.Text = "LabelControl2"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.SpMDInventoryGetHPPHistoryBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(750, 50)
        Me.GridControl2.MainView = Me.GV_HPP
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(553, 602)
        Me.GridControl2.TabIndex = 5
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_HPP})
        '
        'SpMDInventoryGetHPPHistoryBindingSource
        '
        Me.SpMDInventoryGetHPPHistoryBindingSource.DataMember = "sp_MDInventory_GetHPPHistory"
        Me.SpMDInventoryGetHPPHistoryBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_HPP
        '
        Me.GV_HPP.Appearance.HeaderPanel.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_HPP.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_HPP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colMRNo, Me.colMRDate, Me.colSupplierName, Me.colHPP})
        Me.GV_HPP.DetailHeight = 394
        Me.GV_HPP.GridControl = Me.GridControl2
        Me.GV_HPP.Name = "GV_HPP"
        Me.GV_HPP.OptionsEditForm.PopupEditFormWidth = 900
        Me.GV_HPP.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_HPP.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 22
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.Width = 84
        '
        'colMRNo
        '
        Me.colMRNo.Caption = "No. Pembelian"
        Me.colMRNo.FieldName = "MRNo"
        Me.colMRNo.MaxWidth = 169
        Me.colMRNo.MinWidth = 169
        Me.colMRNo.Name = "colMRNo"
        Me.colMRNo.OptionsColumn.AllowEdit = False
        Me.colMRNo.OptionsColumn.AllowFocus = False
        Me.colMRNo.OptionsFilter.AllowFilter = False
        Me.colMRNo.Visible = True
        Me.colMRNo.VisibleIndex = 0
        Me.colMRNo.Width = 169
        '
        'colMRDate
        '
        Me.colMRDate.Caption = "Tgl. Beli"
        Me.colMRDate.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colMRDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMRDate.FieldName = "MRDate"
        Me.colMRDate.MaxWidth = 112
        Me.colMRDate.MinWidth = 112
        Me.colMRDate.Name = "colMRDate"
        Me.colMRDate.OptionsColumn.AllowEdit = False
        Me.colMRDate.OptionsColumn.AllowFocus = False
        Me.colMRDate.Visible = True
        Me.colMRDate.VisibleIndex = 1
        Me.colMRDate.Width = 112
        '
        'colSupplierName
        '
        Me.colSupplierName.Caption = "Supplier"
        Me.colSupplierName.FieldName = "SupplierName"
        Me.colSupplierName.MinWidth = 11
        Me.colSupplierName.Name = "colSupplierName"
        Me.colSupplierName.OptionsColumn.AllowEdit = False
        Me.colSupplierName.OptionsColumn.AllowFocus = False
        Me.colSupplierName.Visible = True
        Me.colSupplierName.VisibleIndex = 2
        Me.colSupplierName.Width = 169
        '
        'colHPP
        '
        Me.colHPP.Caption = "Harga Beli"
        Me.colHPP.DisplayFormat.FormatString = "n0"
        Me.colHPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHPP.FieldName = "HPP"
        Me.colHPP.MaxWidth = 112
        Me.colHPP.MinWidth = 112
        Me.colHPP.Name = "colHPP"
        Me.colHPP.OptionsColumn.AllowEdit = False
        Me.colHPP.OptionsColumn.AllowFocus = False
        Me.colHPP.OptionsFilter.AllowFilter = False
        Me.colHPP.Visible = True
        Me.colHPP.VisibleIndex = 3
        Me.colHPP.Width = 112
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SpMDInventoryGetTransactionDataBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(13, 50)
        Me.GridControl1.MainView = Me.GV_HistoryTransaction
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(733, 602)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_HistoryTransaction})
        '
        'SpMDInventoryGetTransactionDataBindingSource
        '
        Me.SpMDInventoryGetTransactionDataBindingSource.DataMember = "sp_MDInventory_GetTransactionData"
        Me.SpMDInventoryGetTransactionDataBindingSource.DataSource = Me.DataSet
        '
        'GV_HistoryTransaction
        '
        Me.GV_HistoryTransaction.Appearance.HeaderPanel.Font = New System.Drawing.Font("Lato", 13.0!, System.Drawing.FontStyle.Bold)
        Me.GV_HistoryTransaction.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_HistoryTransaction.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInventoryNo, Me.colInventoryName, Me.colSalesPOSNo, Me.colSalesPOSDate, Me.colOpname, Me.colTransaksi})
        Me.GV_HistoryTransaction.DetailHeight = 394
        Me.GV_HistoryTransaction.GridControl = Me.GridControl1
        Me.GV_HistoryTransaction.Name = "GV_HistoryTransaction"
        Me.GV_HistoryTransaction.OptionsEditForm.PopupEditFormWidth = 900
        Me.GV_HistoryTransaction.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_HistoryTransaction.OptionsView.ShowIndicator = False
        '
        'colInventoryNo
        '
        Me.colInventoryNo.Caption = "Mode"
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MaxWidth = 169
        Me.colInventoryNo.MinWidth = 169
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsColumn.AllowEdit = False
        Me.colInventoryNo.OptionsColumn.AllowFocus = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 0
        Me.colInventoryNo.Width = 169
        '
        'colInventoryName
        '
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.MinWidth = 22
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsColumn.AllowEdit = False
        Me.colInventoryName.OptionsColumn.AllowFocus = False
        Me.colInventoryName.Width = 84
        '
        'colSalesPOSNo
        '
        Me.colSalesPOSNo.Caption = "No. Transaksi"
        Me.colSalesPOSNo.FieldName = "SalesPOSNo"
        Me.colSalesPOSNo.MaxWidth = 202
        Me.colSalesPOSNo.MinWidth = 202
        Me.colSalesPOSNo.Name = "colSalesPOSNo"
        Me.colSalesPOSNo.OptionsColumn.AllowEdit = False
        Me.colSalesPOSNo.OptionsColumn.AllowFocus = False
        Me.colSalesPOSNo.Visible = True
        Me.colSalesPOSNo.VisibleIndex = 1
        Me.colSalesPOSNo.Width = 202
        '
        'colSalesPOSDate
        '
        Me.colSalesPOSDate.Caption = "Tgl. Transaksi"
        Me.colSalesPOSDate.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colSalesPOSDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSalesPOSDate.FieldName = "SalesPOSDate"
        Me.colSalesPOSDate.MaxWidth = 146
        Me.colSalesPOSDate.MinWidth = 146
        Me.colSalesPOSDate.Name = "colSalesPOSDate"
        Me.colSalesPOSDate.OptionsColumn.AllowEdit = False
        Me.colSalesPOSDate.OptionsColumn.AllowFocus = False
        Me.colSalesPOSDate.Visible = True
        Me.colSalesPOSDate.VisibleIndex = 2
        Me.colSalesPOSDate.Width = 146
        '
        'colOpname
        '
        Me.colOpname.Caption = "Masuk"
        Me.colOpname.DisplayFormat.FormatString = "n0"
        Me.colOpname.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOpname.FieldName = "Opname"
        Me.colOpname.MaxWidth = 90
        Me.colOpname.MinWidth = 90
        Me.colOpname.Name = "colOpname"
        Me.colOpname.OptionsColumn.AllowEdit = False
        Me.colOpname.OptionsColumn.AllowFocus = False
        Me.colOpname.OptionsFilter.AllowFilter = False
        Me.colOpname.Visible = True
        Me.colOpname.VisibleIndex = 3
        Me.colOpname.Width = 90
        '
        'colTransaksi
        '
        Me.colTransaksi.Caption = "Keluar"
        Me.colTransaksi.DisplayFormat.FormatString = "n0"
        Me.colTransaksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTransaksi.FieldName = "Transaksi"
        Me.colTransaksi.MaxWidth = 90
        Me.colTransaksi.MinWidth = 90
        Me.colTransaksi.Name = "colTransaksi"
        Me.colTransaksi.OptionsColumn.AllowEdit = False
        Me.colTransaksi.OptionsColumn.AllowFocus = False
        Me.colTransaksi.OptionsFilter.AllowFilter = False
        Me.colTransaksi.Visible = True
        Me.colTransaksi.VisibleIndex = 4
        Me.colTransaksi.Width = 90
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1316, 665)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 37)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(737, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(737, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(737, 606)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.GridControl2
        Me.LayoutControlItem2.Location = New System.Drawing.Point(737, 37)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(557, 606)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.LabelBarang
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1294, 37)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'Sp_MDInventory_GetTransactionDataTableAdapter
        '
        Me.Sp_MDInventory_GetTransactionDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetHPPHistoryTableAdapter
        '
        Me.Sp_MDInventory_GetHPPHistoryTableAdapter.ClearBeforeFill = True
        '
        'Frm_InvListDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ChildControls.Add(Me.DirectXFormContainerControl1)
        Me.ClientSize = New System.Drawing.Size(1318, 695)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Frm_InvListDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Barang"
        Me.DirectXFormContainerControl1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetHPPHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_HPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetTransactionDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_HistoryTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DirectXFormContainerControl1 As DevExpress.XtraEditors.DirectXFormContainerControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_HistoryTransaction As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpMDInventoryGetTransactionDataBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPOSNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPOSDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetTransactionDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetTransactionDataTableAdapter
    Friend WithEvents Label_Barang As Label
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SpMDInventoryGetHPPHistoryBindingSource As BindingSource
    Friend WithEvents GV_HPP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_MDInventory_GetHPPHistoryTableAdapter As DataSetTableAdapters.sp_MDInventory_GetHPPHistoryTableAdapter
    Friend WithEvents LabelBarang As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
