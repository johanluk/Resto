<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CashFlowTransaction
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.Ed_Value = New DevExpress.XtraEditors.SpinEdit()
        Me.CB_CashFlowType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LUE_CashType = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpLookUpDataGetCashFlowTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dataset = New Mod_Purchase.Dataset()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_LookUpData_GetCashFlowTypeTableAdapter = New Mod_Purchase.DatasetTableAdapters.sp_LookUpData_GetCashFlowTypeTableAdapter()
        Me.QueriesTableAdapter = New Mod_Purchase.DatasetTableAdapters.QueriesTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Ed_Value.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CB_CashFlowType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUE_CashType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpLookUpDataGetCashFlowTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SB_Submit)
        Me.LayoutControl1.Controls.Add(Me.Ed_Value)
        Me.LayoutControl1.Controls.Add(Me.CB_CashFlowType)
        Me.LayoutControl1.Controls.Add(Me.LUE_CashType)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(378, 181)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SB_Submit
        '
        Me.SB_Submit.Location = New System.Drawing.Point(12, 102)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.Size = New System.Drawing.Size(354, 23)
        Me.SB_Submit.StyleController = Me.LayoutControl1
        Me.SB_Submit.TabIndex = 7
        Me.SB_Submit.Text = "Submit"
        '
        'Ed_Value
        '
        Me.Ed_Value.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_Value.Location = New System.Drawing.Point(136, 72)
        Me.Ed_Value.Name = "Ed_Value"
        Me.Ed_Value.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_Value.Size = New System.Drawing.Size(230, 26)
        Me.Ed_Value.StyleController = Me.LayoutControl1
        Me.Ed_Value.TabIndex = 6
        '
        'CB_CashFlowType
        '
        Me.CB_CashFlowType.Location = New System.Drawing.Point(136, 42)
        Me.CB_CashFlowType.Name = "CB_CashFlowType"
        Me.CB_CashFlowType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CB_CashFlowType.Properties.DropDownRows = 2
        Me.CB_CashFlowType.Properties.Items.AddRange(New Object() {"Masuk", "Keluar"})
        Me.CB_CashFlowType.Size = New System.Drawing.Size(230, 26)
        Me.CB_CashFlowType.StyleController = Me.LayoutControl1
        Me.CB_CashFlowType.TabIndex = 5
        '
        'LUE_CashType
        '
        Me.LUE_CashType.Location = New System.Drawing.Point(136, 12)
        Me.LUE_CashType.Name = "LUE_CashType"
        Me.LUE_CashType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_CashType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CashName", "Nama", 84, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LUE_CashType.Properties.DataSource = Me.SpLookUpDataGetCashFlowTypeBindingSource
        Me.LUE_CashType.Properties.DisplayMember = "CashName"
        Me.LUE_CashType.Properties.NullText = "-- Pilih"
        Me.LUE_CashType.Properties.ValueMember = "ID"
        Me.LUE_CashType.Size = New System.Drawing.Size(230, 26)
        Me.LUE_CashType.StyleController = Me.LayoutControl1
        Me.LUE_CashType.TabIndex = 4
        '
        'SpLookUpDataGetCashFlowTypeBindingSource
        '
        Me.SpLookUpDataGetCashFlowTypeBindingSource.DataMember = "sp_LookUpData_GetCashFlowType"
        Me.SpLookUpDataGetCashFlowTypeBindingSource.DataSource = Me.Dataset
        '
        'Dataset
        '
        Me.Dataset.DataSetName = "Dataset"
        Me.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(378, 181)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LUE_CashType
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(358, 30)
        Me.LayoutControlItem1.Text = "Jenis Kas :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(112, 18)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 117)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(358, 44)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.CB_CashFlowType
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(358, 30)
        Me.LayoutControlItem2.Text = "Masuk / Keluar :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(112, 18)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Ed_Value
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(358, 30)
        Me.LayoutControlItem3.Text = "Nominal :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(112, 18)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SB_Submit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(358, 27)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'Sp_LookUpData_GetCashFlowTypeTableAdapter
        '
        Me.Sp_LookUpData_GetCashFlowTypeTableAdapter.ClearBeforeFill = True
        '
        'Frm_CashFlowTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 181)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Font = New System.Drawing.Font("Roboto", 11.25!)
        Me.Name = "Frm_CashFlowTransaction"
        Me.Text = "Transaksi Kas"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Ed_Value.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CB_CashFlowType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUE_CashType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpLookUpDataGetCashFlowTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_Value As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents CB_CashFlowType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LUE_CashType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Dataset As Dataset
    Friend WithEvents SpLookUpDataGetCashFlowTypeBindingSource As BindingSource
    Friend WithEvents Sp_LookUpData_GetCashFlowTypeTableAdapter As DatasetTableAdapters.sp_LookUpData_GetCashFlowTypeTableAdapter
    Friend WithEvents QueriesTableAdapter As DatasetTableAdapters.QueriesTableAdapter
End Class
