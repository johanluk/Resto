<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReservationSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ReservationSchedule))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_Back = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SB_Next = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Filter = New DevExpress.XtraEditors.SimpleButton()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPOSMDTableReservationGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New POS.DataSet()
        Me.Sp_POSReservationHeader_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_POSReservationHeader_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Reservation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReservationStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReservationEndDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTableID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisDone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Date_End = New DevExpress.XtraEditors.DateEdit()
        Me.Date_Start = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Sp_POSReservationHeader_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POSReservationHeader_GetDataTableAdapter()
        Me.TableAdapterManager = New POS.DataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter = New POS.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_POS_MDTableReservation_GetDataTableAdapter = New POS.DataSetTableAdapters.sp_POS_MDTableReservation_GetDataTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPOSMDTableReservationGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POSReservationHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POSReservationHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Reservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PanelControl2)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit1)
        Me.LayoutControl1.Controls.Add(Me.Sp_POSReservationHeader_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.Date_End)
        Me.LayoutControl1.Controls.Add(Me.Date_Start)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1045, 473)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SB_Back)
        Me.PanelControl2.Location = New System.Drawing.Point(15, 15)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1015, 60)
        Me.PanelControl2.TabIndex = 10
        '
        'SB_Back
        '
        Me.SB_Back.Appearance.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.SB_Back.Appearance.Options.UseFont = True
        Me.SB_Back.Image = CType(resources.GetObject("SB_Back.Image"), System.Drawing.Image)
        Me.SB_Back.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_Back.Location = New System.Drawing.Point(5, 5)
        Me.SB_Back.MinimumSize = New System.Drawing.Size(0, 46)
        Me.SB_Back.Name = "SB_Back"
        Me.SB_Back.Size = New System.Drawing.Size(122, 50)
        Me.SB_Back.TabIndex = 10
        Me.SB_Back.Text = "Back"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SB_Next)
        Me.PanelControl1.Controls.Add(Me.SB_Filter)
        Me.PanelControl1.Location = New System.Drawing.Point(607, 85)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(423, 102)
        Me.PanelControl1.TabIndex = 9
        '
        'SB_Next
        '
        Me.SB_Next.Appearance.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.SB_Next.Appearance.Options.UseFont = True
        Me.SB_Next.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_Next.Location = New System.Drawing.Point(214, 5)
        Me.SB_Next.MinimumSize = New System.Drawing.Size(0, 46)
        Me.SB_Next.Name = "SB_Next"
        Me.SB_Next.Size = New System.Drawing.Size(203, 92)
        Me.SB_Next.TabIndex = 9
        Me.SB_Next.Text = " Next"
        '
        'SB_Filter
        '
        Me.SB_Filter.Appearance.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.SB_Filter.Appearance.Options.UseFont = True
        Me.SB_Filter.Image = CType(resources.GetObject("SB_Filter.Image"), System.Drawing.Image)
        Me.SB_Filter.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SB_Filter.Location = New System.Drawing.Point(5, 5)
        Me.SB_Filter.MinimumSize = New System.Drawing.Size(0, 46)
        Me.SB_Filter.Name = "SB_Filter"
        Me.SB_Filter.Size = New System.Drawing.Size(203, 92)
        Me.SB_Filter.TabIndex = 8
        Me.SB_Filter.Text = " "
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(141, 85)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.LookUpEdit1.Properties.Appearance.Options.UseFont = True
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableCode", "Table Code", 158, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableName", "Table Name", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TableTypeID", "Table Type ID", 189, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.LookUpEdit1.Properties.DataSource = Me.SpPOSMDTableReservationGetDataBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "TableName"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ValueMember = "ID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(182, 46)
        Me.LookUpEdit1.StyleController = Me.LayoutControl1
        Me.LookUpEdit1.TabIndex = 7
        '
        'SpPOSMDTableReservationGetDataBindingSource
        '
        Me.SpPOSMDTableReservationGetDataBindingSource.DataMember = "sp_POS_MDTableReservation_GetData"
        Me.SpPOSMDTableReservationGetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_POSReservationHeader_GetDataGridControl
        '
        Me.Sp_POSReservationHeader_GetDataGridControl.DataSource = Me.Sp_POSReservationHeader_GetDataBindingSource
        Me.Sp_POSReservationHeader_GetDataGridControl.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.Sp_POSReservationHeader_GetDataGridControl.Location = New System.Drawing.Point(12, 194)
        Me.Sp_POSReservationHeader_GetDataGridControl.MainView = Me.GV_Reservation
        Me.Sp_POSReservationHeader_GetDataGridControl.MinimumSize = New System.Drawing.Size(0, 48)
        Me.Sp_POSReservationHeader_GetDataGridControl.Name = "Sp_POSReservationHeader_GetDataGridControl"
        Me.Sp_POSReservationHeader_GetDataGridControl.Size = New System.Drawing.Size(1021, 267)
        Me.Sp_POSReservationHeader_GetDataGridControl.TabIndex = 6
        Me.Sp_POSReservationHeader_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Reservation})
        '
        'Sp_POSReservationHeader_GetDataBindingSource
        '
        Me.Sp_POSReservationHeader_GetDataBindingSource.DataMember = "sp_POSReservationHeader_GetData"
        Me.Sp_POSReservationHeader_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Reservation
        '
        Me.GV_Reservation.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.GV_Reservation.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Reservation.Appearance.Row.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.GV_Reservation.Appearance.Row.Options.UseFont = True
        Me.GV_Reservation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOrderID, Me.colInvoiceNo, Me.colReservationStartDate, Me.colReservationEndDate, Me.colTableID, Me.colCustomerID, Me.colEmployeeID, Me.colisActive, Me.colisDone})
        Me.GV_Reservation.GridControl = Me.Sp_POSReservationHeader_GetDataGridControl
        Me.GV_Reservation.Name = "GV_Reservation"
        Me.GV_Reservation.OptionsDetail.SmartDetailExpand = False
        Me.GV_Reservation.OptionsView.ShowGroupPanel = False
        Me.GV_Reservation.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colOrderID
        '
        Me.colOrderID.FieldName = "OrderID"
        Me.colOrderID.Name = "colOrderID"
        Me.colOrderID.OptionsColumn.AllowEdit = False
        Me.colOrderID.OptionsColumn.AllowFocus = False
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.FieldName = "InvoiceNo"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.OptionsColumn.AllowEdit = False
        Me.colInvoiceNo.OptionsColumn.AllowFocus = False
        Me.colInvoiceNo.Visible = True
        Me.colInvoiceNo.VisibleIndex = 0
        Me.colInvoiceNo.Width = 169
        '
        'colReservationStartDate
        '
        Me.colReservationStartDate.DisplayFormat.FormatString = "dd MMM yyyy HH:mm"
        Me.colReservationStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReservationStartDate.FieldName = "ReservationStartDate"
        Me.colReservationStartDate.Name = "colReservationStartDate"
        Me.colReservationStartDate.OptionsColumn.AllowEdit = False
        Me.colReservationStartDate.OptionsColumn.AllowFocus = False
        Me.colReservationStartDate.Visible = True
        Me.colReservationStartDate.VisibleIndex = 1
        Me.colReservationStartDate.Width = 190
        '
        'colReservationEndDate
        '
        Me.colReservationEndDate.DisplayFormat.FormatString = "dd MMM yyyy HH:mm"
        Me.colReservationEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReservationEndDate.FieldName = "ReservationEndDate"
        Me.colReservationEndDate.Name = "colReservationEndDate"
        Me.colReservationEndDate.OptionsColumn.AllowEdit = False
        Me.colReservationEndDate.OptionsColumn.AllowFocus = False
        Me.colReservationEndDate.Visible = True
        Me.colReservationEndDate.VisibleIndex = 2
        Me.colReservationEndDate.Width = 203
        '
        'colTableID
        '
        Me.colTableID.FieldName = "TableID"
        Me.colTableID.Name = "colTableID"
        Me.colTableID.OptionsColumn.AllowEdit = False
        Me.colTableID.OptionsColumn.AllowFocus = False
        Me.colTableID.Visible = True
        Me.colTableID.VisibleIndex = 3
        Me.colTableID.Width = 148
        '
        'colCustomerID
        '
        Me.colCustomerID.FieldName = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.OptionsColumn.AllowEdit = False
        Me.colCustomerID.OptionsColumn.AllowFocus = False
        Me.colCustomerID.Visible = True
        Me.colCustomerID.VisibleIndex = 4
        Me.colCustomerID.Width = 158
        '
        'colEmployeeID
        '
        Me.colEmployeeID.FieldName = "EmployeeID"
        Me.colEmployeeID.Name = "colEmployeeID"
        Me.colEmployeeID.OptionsColumn.AllowEdit = False
        Me.colEmployeeID.OptionsColumn.AllowFocus = False
        Me.colEmployeeID.Visible = True
        Me.colEmployeeID.VisibleIndex = 5
        Me.colEmployeeID.Width = 151
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        Me.colisActive.OptionsColumn.AllowEdit = False
        Me.colisActive.OptionsColumn.AllowFocus = False
        '
        'colisDone
        '
        Me.colisDone.FieldName = "isDone"
        Me.colisDone.Name = "colisDone"
        Me.colisDone.OptionsColumn.AllowEdit = False
        Me.colisDone.OptionsColumn.AllowFocus = False
        '
        'Date_End
        '
        Me.Date_End.EditValue = New Date(2014, 7, 29, 3, 6, 21, 0)
        Me.Date_End.Location = New System.Drawing.Point(435, 141)
        Me.Date_End.Name = "Date_End"
        Me.Date_End.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.Date_End.Properties.Appearance.Options.UseFont = True
        Me.Date_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_End.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.Date_End.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_End.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.Date_End.Properties.Mask.EditMask = "dd MMM yyyy HH:mm"
        Me.Date_End.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Date_End.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Date_End.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.Date_End.Size = New System.Drawing.Size(162, 46)
        Me.Date_End.StyleController = Me.LayoutControl1
        Me.Date_End.TabIndex = 5
        '
        'Date_Start
        '
        Me.Date_Start.EditValue = New Date(2014, 7, 29, 3, 5, 19, 0)
        Me.Date_Start.Location = New System.Drawing.Point(141, 141)
        Me.Date_Start.Name = "Date_Start"
        Me.Date_Start.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 25.0!)
        Me.Date_Start.Properties.Appearance.Options.UseFont = True
        Me.Date_Start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Start.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.Date_Start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Start.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
        Me.Date_Start.Properties.Mask.EditMask = "dd MMM yyyy HH:mm"
        Me.Date_Start.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Date_Start.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.Date_Start.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.Date_Start.Size = New System.Drawing.Size(158, 46)
        Me.Date_Start.StyleController = Me.LayoutControl1
        Me.Date_Start.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1045, 473)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.Date_Start
        Me.LayoutControlItem1.CustomizationFormText = "Start Date :"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(294, 56)
        Me.LayoutControlItem1.Text = "Start Date :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(123, 33)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Sp_POSReservationHeader_GetDataGridControl
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1025, 271)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me.LookUpEdit1
        Me.LayoutControlItem4.CustomizationFormText = "Table :"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 70)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(318, 56)
        Me.LayoutControlItem4.Text = "Table :"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(123, 33)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.PanelControl1
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(592, 70)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(433, 0)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(433, 30)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(433, 112)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.PanelControl2
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(0, 70)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(110, 70)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1025, 70)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me.Date_End
        Me.LayoutControlItem2.CustomizationFormText = "End Date :"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(294, 126)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(298, 56)
        Me.LayoutControlItem2.Text = "End Date :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(123, 33)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(318, 70)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(274, 56)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'Sp_POSReservationHeader_GetDataTableAdapter
        '
        Me.Sp_POSReservationHeader_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_POS_MDTableReservation_GetDataTableAdapter
        '
        Me.Sp_POS_MDTableReservation_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Frm_ReservationSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 473)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Visual Studio 2013 Dark"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "Frm_ReservationSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ReservationSchedule"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPOSMDTableReservationGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POSReservationHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POSReservationHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Reservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Date_End As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Date_Start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataSet As POS.DataSet
    Friend WithEvents Sp_POSReservationHeader_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POSReservationHeader_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POSReservationHeader_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As POS.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_POSReservationHeader_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Reservation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReservationStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReservationEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTableID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisDone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SB_Filter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SB_Next As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SB_Back As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents QueriesTableAdapter As POS.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SpPOSMDTableReservationGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_POS_MDTableReservation_GetDataTableAdapter As POS.DataSetTableAdapters.sp_POS_MDTableReservation_GetDataTableAdapter
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
