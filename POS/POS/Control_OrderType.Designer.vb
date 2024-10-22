<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_OrderType
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_Next = New DevExpress.XtraEditors.SimpleButton()
        Me.RadioGroup_OrderType = New DevExpress.XtraEditors.RadioGroup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit_Server = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SpPOSGetServerListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New POS.DataSet()
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
        Me.Sp_POS_GetServerListTableAdapter = New POS.DataSetTableAdapters.sp_POS_GetServerListTableAdapter()
        Me.Sp_POS_GetTableListTableAdapter = New POS.DataSetTableAdapters.sp_POS_GetTableListTableAdapter()
        Me.QueriesTableAdapter = New POS.DataSetTableAdapters.QueriesTableAdapter()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.RadioGroup_OrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Server.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSGetServerListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_Table.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSGetTableListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.SB_Next)
        Me.PanelControl3.Controls.Add(Me.RadioGroup_OrderType)
        Me.PanelControl3.Controls.Add(Me.Label3)
        Me.PanelControl3.Controls.Add(Me.SpinEdit1)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.SearchLookUpEdit_Server)
        Me.PanelControl3.Controls.Add(Me.LookUpEdit_Table)
        Me.PanelControl3.Controls.Add(Me.Label1)
        Me.PanelControl3.Location = New System.Drawing.Point(13, 18)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(760, 273)
        Me.PanelControl3.TabIndex = 10
        '
        'SB_Next
        '
        Me.SB_Next.ImageOptions.Image = Global.POS.My.Resources.Resources.next_page_100px
        Me.SB_Next.Location = New System.Drawing.Point(630, 149)
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
        Me.Label3.Location = New System.Drawing.Point(271, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pengunjung :"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(444, 150)
        Me.SpinEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.SpinEdit1.MaximumSize = New System.Drawing.Size(75, 48)
        Me.SpinEdit1.MinimumSize = New System.Drawing.Size(75, 48)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.SpinEdit1.Properties.Appearance.Options.UseFont = True
        Me.SpinEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.SpinEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.SpinEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.SpinEdit1.Properties.MaskSettings.Set("mask", "n0")
        Me.SpinEdit1.Size = New System.Drawing.Size(75, 36)
        Me.SpinEdit1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(303, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "No. Meja :"
        '
        'SearchLookUpEdit_Server
        '
        Me.SearchLookUpEdit_Server.Location = New System.Drawing.Point(446, 38)
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
        Me.SearchLookUpEdit_Server.Size = New System.Drawing.Size(282, 32)
        Me.SearchLookUpEdit_Server.TabIndex = 15
        '
        'SpPOSGetServerListBindingSource
        '
        Me.SpPOSGetServerListBindingSource.DataMember = "sp_POS_GetServerList"
        Me.SpPOSGetServerListBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.LookUpEdit_Table.EditValue = "--"
        Me.LookUpEdit_Table.Location = New System.Drawing.Point(446, 93)
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
        Me.LookUpEdit_Table.Size = New System.Drawing.Size(249, 48)
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
        Me.Label1.Location = New System.Drawing.Point(331, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Waiter :"
        '
        'Sp_POS_GetServerListTableAdapter
        '
        Me.Sp_POS_GetServerListTableAdapter.ClearBeforeFill = True
        '
        'Sp_POS_GetTableListTableAdapter
        '
        Me.Sp_POS_GetTableListTableAdapter.ClearBeforeFill = True
        '
        'Control_OrderType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "Control_OrderType"
        Me.Size = New System.Drawing.Size(786, 307)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.RadioGroup_OrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Server.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSGetServerListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_Table.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSGetTableListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SB_Next As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioGroup_OrderType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label3 As Label
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchLookUpEdit_Server As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookUpEdit_Table As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit_Table As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableTypeID_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableName_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents SpPOSGetServerListBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents SpPOSGetTableListBindingSource As BindingSource
    Friend WithEvents Sp_POS_GetServerListTableAdapter As DataSetTableAdapters.sp_POS_GetServerListTableAdapter
    Friend WithEvents Sp_POS_GetTableListTableAdapter As DataSetTableAdapters.sp_POS_GetTableListTableAdapter
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
End Class
