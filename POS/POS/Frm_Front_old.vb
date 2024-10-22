Imports System.Math
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors

Public Class Frm_Front_old


#Region "Variables"
    Private isNew As Boolean
    Private UserModified As String

    Dim rowfocus As Integer
    Dim AlertParamName As String
    Dim AlertParamEditName As String
#End Region

#Region "Initial Procedure"

    Private frmParentInfo As DevExpress.XtraBars.Ribbon.RibbonForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

#End Region

    Dim GV_OrderRow As Integer
    Public TableID As Integer
    Public TableName As String
    Dim OrderID As Integer
    Dim OrderNo As String
    Public OrderTypeID As Integer
    Public OrderDeliveryID As Integer = 0

    Public DateStart As DateTime
    Public DateEnd As DateTime

    Public GuestName As String = ""
    Public GuestCount As Integer = 0

    Dim TypeName As String
    Dim TypeID As String
    Dim CategoryName As String
    Dim CategoryID As Integer = 0

    Dim RefreshMode As Boolean = False

    Dim TitleMenu As String
    Public WithEvents newButton As DevExpress.XtraEditors.SimpleButton
    Public Sub New()

        DevExpress.Skins.SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.RestoSkin).Assembly)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal OrderIdTemp As Integer, ByVal TOrderNo As String, ByVal TableIDTemp As Integer, ByVal TTableName As String)

        DevExpress.Skins.SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.RestoSkin).Assembly)
        ' This call is required by the designer.
        InitializeComponent()

        TableName = TTableName
        OrderNo = TOrderNo
        Label_OrderNo.Text = OrderNo
        Label_TableName.Text = TableName
        OrderID = OrderIdTemp
        TableID = TableIDTemp

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OrderIdTemp As Integer, ByVal TOrderNo As String, ByVal TableIDTemp As Integer, ByVal TTableName As String, ByVal OrderType As Integer, ByVal Temp_DateStart As DateTime, ByVal Temp_DateEnd As DateTime)

        DevExpress.Skins.SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.RestoSkin).Assembly)
        ' This call is required by the designer.
        InitializeComponent()
        TableName = TTableName
        OrderNo = TOrderNo
        Label_OrderNo.Text = OrderNo
        Label_TableName.Text = TableName
        OrderID = OrderIdTemp
        TableID = TableIDTemp
        OrderTypeID = OrderType

        If (OrderType = 11) Then 'reservation
            Bt_Payment.Text = "Next"

        Else
            Bt_Payment.Text = "Payment"
        End If

        DateStart = Temp_DateStart
        DateEnd = Temp_DateEnd
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OrderIdTemp As Integer, ByVal TOrderNo As String, ByVal TableIDTemp As Integer, ByVal TTableName As String, ByVal OrderType As Integer, ByVal TempGuest As String, ByVal TempNoGuest As Integer, Optional ByVal TempTemp As String = "")

        DevExpress.Skins.SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.RestoSkin).Assembly)
        ' This call is required by the designer.
        InitializeComponent()

        TableName = TTableName
        OrderNo = TOrderNo
        Label_OrderNo.Text = OrderNo
        Label_TableName.Text = TableName
        OrderID = OrderIdTemp
        TableID = TableIDTemp
        OrderTypeID = OrderType

        GuestName = TempGuest
        GuestCount = TempNoGuest

        If (OrderType = 11) Then 'reservation
            Bt_Payment.Text = "Next"
        Else
            Bt_Payment.Text = "Payment"
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OrderIdTemp As Integer, ByVal TOrderNo As String, ByVal TableIDTemp As Integer, ByVal TTableName As String, ByVal OrderType As Integer, ByVal TempGuest As String, ByVal TempNoGuest As Integer, ByVal TDateStart As DateTime, ByVal TDateEnd As DateTime, Optional ByVal TempTemp As String = "")

        DevExpress.Skins.SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.RestoSkin).Assembly)
        ' This call is required by the designer.
        InitializeComponent()

        TableName = TTableName
        OrderNo = TOrderNo
        Label_OrderNo.Text = OrderNo
        Label_TableName.Text = TableName
        OrderID = OrderIdTemp
        TableID = TableIDTemp
        OrderTypeID = OrderType

        GuestName = TempGuest
        GuestCount = TempNoGuest

        If (OrderType = 11) Then 'reservation
            Bt_Payment.Text = "Next"
        Else
            Bt_Payment.Text = "Payment"
        End If

        DateStart = TDateStart
        DateEnd = TDateEnd
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OrderIdTemp As Integer, ByVal TOrderNo As String, ByVal TableIDTemp As Integer, ByVal TTableName As String, ByVal OrderDeliveryIDTemp As Integer, ByVal OrderType As Integer)

        DevExpress.Skins.SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.RestoSkin).Assembly)
        ' This call is required by the designer.
        InitializeComponent()


        TableName = TTableName
        OrderNo = TOrderNo
        Label_OrderNo.Text = OrderNo
        Label_TableName.Text = TableName
        OrderID = OrderIdTemp
        TableID = TableIDTemp
        OrderTypeID = OrderType
        OrderDeliveryID = OrderDeliveryIDTemp


        If (OrderType = 11) Then 'reservation
            Bt_Payment.Text = "Next"
        Else
            Bt_Payment.Text = "Payment"
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(ByVal OrderIdTemp As Integer, ByVal TOrderNo As String, ByVal TableIDTemp As Integer, ByVal TTableName As String, ByVal OrderType As Integer)

        DevExpress.Skins.SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.RestoSkin).Assembly)
        ' This call is required by the designer.
        InitializeComponent()

        TableName = TTableName
        OrderNo = TOrderNo
        Label_OrderNo.Text = OrderNo
        Label_TableName.Text = TableName
        OrderID = OrderIdTemp
        TableID = TableIDTemp
        OrderTypeID = OrderType


        If (OrderType = 11) Then 'reservation
            Bt_Payment.Text = "Next"
        Else
            Bt_Payment.Text = "Payment"
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FillDataAdapter()

        Me.Sp_POSOrderDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_GetData, 0, OrderID)
        Me.Sp_POSOrderDetailMemo_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailMemo_GetData, OrderID)

        Label_TotalValueOrder.Text = "Rp. " + String.Format("{0:#,##0.00}", colSubTotal.SummaryItem.SummaryValue)

        If (GV_OrderDetail.RowCount > 0) Then
            Bt_Payment.Enabled = True
        Else
            Bt_Payment.Enabled = False
        End If
    End Sub


    Private Sub Frm_Front_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_MDMenuType_GetData' table. You can move, or remove it, as needed.

        'If (My.Settings.PositionID = 3) Then
        '    Dim FrmPayment As DevExpress.XtraEditors.XtraForm
        '    FrmPayment = New Frm_Payment(OrderID, Label_OrderNo.Text, TableID, Label_TableName.Text, OrderTypeID)
        '    FrmPayment.ShowDialog()
        '    If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '        FrmPayment.Close()
        '        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        '    End If
        'End If

        DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch
        DevExpress.XtraEditors.WindowsFormsSettings.ShowTouchScrollBarOnMouseMove = True

        If (My.Settings.PositionID = 1) Then
            Bt_Payment.Visible = False
            SB_Memo.Width = 201
        Else
            Bt_Payment.Visible = True
            SB_Memo.Width = 99
        End If
        Me.Sp_POS_MDMenuType_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenuType_GetData)

        CB_LargeSet.Visible = False

        FillDataAdapter()
        Dim Query As String
        Query = "select [Description] from T_OrderHeader Where ID = " + OrderID.ToString
        Memo_Keterangan.EditValue = Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName

        Panel_MenuList.Height = Panel_Menu.Height - 50
        Sp_POS_MDMenu_GetDataGridControl.Top = 1500
        '   Panel_MenuList.Height = Panel_Menu.Height - 50

        RoundShapeTop(PanelControl3)
        RoundShapeBottom(PanelControl1)


        '   Bt_Payment.Enabled = False

    End Sub

    Private Sub TV_MenuType_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_MenuType.ItemClick

        Me.Sp_POS_MDMenuCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenuCategory_GetData, e.Item.Elements.Item(1).ToString)
        TitleMenu = TV_MenuType.GetRowCellValue(e.Item.Tag, colMenuTypeName_MenuType)
        CB_LargeSet.Visible = True

        TypeName = e.Item.Elements.Item(0).ToString
        TypeID = e.Item.Elements.Item(1).ToString

        For i As Integer = Me.Panel_MenuList.Controls.Count - 1 To 0 Step -1
            Dim ctrl = Me.Panel_MenuList.Controls(i)

            If TypeOf (ctrl) Is DevExpress.XtraEditors.SimpleButton Then
                ctrl.Dispose()           '' NOTE: disposing the control also removes it
            End If
        Next

        Label_TypeCategory.Text = TypeName
    End Sub


    Private Sub TV_MenuCategory_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_MenuCategory.ItemClick

        If (CB_LargeSet.Checked) Then
            Me.Sp_POS_MDMenu_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenu_GetData, e.Item.Elements.Item(1).ToString, 1, "")
        Else
            Me.Sp_POS_MDMenu_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenu_GetData, e.Item.Elements.Item(1).ToString, 0, "")

        End If

        CategoryName = e.Item.Elements.Item(0).ToString
        CategoryID = e.Item.Elements.Item(1).ToString

        Label_TypeCategory.Text = TypeName + " - " + CategoryName

        For i As Integer = Me.Panel_MenuList.Controls.Count - 1 To 0 Step -1
            Dim ctrl = Me.Panel_MenuList.Controls(i)

            If TypeOf (ctrl) Is DevExpress.XtraEditors.SimpleButton Then
                ctrl.Dispose()           '' NOTE: disposing the control also removes it
            End If
        Next

        RefreshMenu()
    End Sub

    Public Sub RefreshMenu()
        For i = 0 To GV_Menu.RowCount - 1
            If (i >= 0) Then
                newButton = New DevExpress.XtraEditors.SimpleButton
                newButton.Name = "Bt_Menu" & i
                newButton.Text = i
                newButton.Height = (Panel_MenuList.Height - 40) / 5
                newButton.Width = 200
                '   newButton.Left = 102 * ((i - 1) Mod Floor(Panel_MenuType.Width / 102)) + 2
                newButton.Top = (i Mod 5) * (newButton.Height + 5) + 5
                newButton.Left = (newButton.Width + 5) * Floor(i / 5) + 5


                newButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
                '   If(GV_Menu.GetRowCellValue(i, col)
                If (i Mod 2 = 0) Then
                    newButton.Appearance.BackColor = Color.Gray
                Else
                    newButton.Appearance.BackColor = Color.DarkSlateGray
                End If
                newButton.Appearance.GradientMode = Drawing2D.LinearGradientMode.Vertical
                newButton.Text = GV_Menu.GetRowCellValue(i, colMenuName_Menu)
                newButton.Tag = GV_Menu.GetRowCellValue(i, colID_Menu)
                If (IsDBNull(GV_Menu.GetRowCellValue(i, colImage_Menu)) = False And i >= 0) Then
                    newButton.Image = ImageFromBytes(GV_Menu.GetRowCellValue(i, colImage_Menu))
                End If
                newButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
                newButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
                newButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom


                newButton.Font = New Font(newButton.Font.FontFamily, 12, newButton.Font.Style)

                If (CB_LargeSet.Checked) Then
                    newButton.Appearance.ForeColor = Color.PaleVioletRed
                Else

                    newButton.Appearance.ForeColor = Color.White
                End If

                newButton.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
                newButton.ToolTip = String.Format("{0:#,##0}", GV_Menu.GetRowCellValue(i, colPrice_Menu))
                newButton.ToolTipTitle = "Price"
                newButton.ShowToolTips = True

                AddHandler newButton.Click, AddressOf Me.ButtonMenu_Click

                Me.Panel_MenuList.Controls.Add(Me.newButton)
            End If
        Next

        Panel_MenuList.Width = CInt(Ceiling(GV_Menu.RowCount / 5)) * 210
        Panel_MenuList.Left = 5
        If (Panel_MenuList.Width <= Panel_Menu.Width) Then
            Panel_MenuList.Width = Panel_Menu.Width + 1
        End If
        HScrollBar1.Maximum = Panel_MenuList.Width - Panel_Menu.Width
        HScrollBar1.Value = 0
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim p As Point
        p = Panel_MenuList.Location
        p.X = 5 - e.NewValue
        Panel_MenuList.Location = p
    End Sub

    Function ImageFromBytes(ByVal bytes As Byte()) As Image
        Using ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub ButtonMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try


            If (Me.QueriesTableAdapter.sp_POSOrderHeader_CheckOrderNo(Label_OrderNo.Text) = 0) Then
                If (OrderTypeID = 11) Then
                    Me.QueriesTableAdapter.sp_POSOrderHeader_InsData(Label_OrderNo.Text, DateStart, OrderTypeID, TableID, Label_TableName.Text, 0, My.Settings.EmployeeID, 0, 0, DateStart, DateEnd, GuestName, GuestCount, UserModified)
                Else
                    Me.QueriesTableAdapter.sp_POSOrderHeader_InsData(Label_OrderNo.Text, Today, OrderTypeID, TableID, Label_TableName.Text, OrderDeliveryID, My.Settings.EmployeeID, 0, 0, Today, Today, GuestName, GuestCount, UserModified)

                End If

            End If
            Me.QueriesTableAdapter.sp_POSOrderDetail_InsUpdData(OrderID, sender.tag, TableID, sender.text, 1, 0, 0, 0, My.Settings.EmployeeID, 0, UserModified)



            FillDataAdapter()

            Label_TotalValueOrder.Text = "Rp. " + String.Format("{0:#,##0.00}", colSubTotal.SummaryItem.SummaryValue)
            AlertControl1.Show(Me, "Success on Adding Menu", sender.text.ToString + " berhasil ditambahkan")
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub TV_Menu_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs)
    '    Try


    '        If (Me.QueriesTableAdapter.sp_POSOrderHeader_CheckOrderNo(Label_OrderNo.Text) = 0) Then
    '            If (OrderTypeID = 11) Then
    '                Me.QueriesTableAdapter.sp_POSOrderHeader_InsData(Label_OrderNo.Text, DateStart, OrderTypeID, TableID, Label_TableName.Text, 0, My.Settings.EmployeeID, 0, 0, DateStart, DateEnd, GuestName, GuestCount, UserModified)
    '            Else
    '                Me.QueriesTableAdapter.sp_POSOrderHeader_InsData(Label_OrderNo.Text, Today, OrderTypeID, TableID, Label_TableName.Text, OrderDeliveryID, My.Settings.EmployeeID, 0, 0, Today, Today, GuestName, GuestCount, UserModified)

    '            End If

    '        End If
    '        Me.QueriesTableAdapter.sp_POSOrderDetail_InsUpdData(OrderID, e.Item.Elements.Item(1).ToString, TableID, e.Item.Elements.Item(0).ToString, 1, 0, 0, 0, My.Settings.EmployeeID, 0, UserModified)

    '        FillDataAdapter()

    '        Label_TotalValueOrder.Text = "Rp. " + String.Format("{0:#,##0.00}", colSubTotal.SummaryItem.SummaryValue)
    '        AlertControl1.Show(Me, "Success on Adding Menu", e.Item.Elements.Item(0).ToString + " berhasil ditambahkan")


    '    Catch ex As Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub TV_Menu_ItemCustomize(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs)

    '    If (RefreshMode) Then

    '        Try
    '            If (CBool(TV_Menu.GetRowCellValue(e.RowHandle, colisMenuLarge_Menu)) = True) Then
    '                e.Item.Elements(0).Appearance.Normal.Font = New Font(e.Item.Elements(0).Appearance.Normal.Font, FontStyle.Bold)
    '                e.Item.Elements(0).Appearance.Normal.ForeColor = Color.OrangeRed
    '            Else
    '                e.Item.Elements(0).Appearance.Normal.Font = New Font(e.Item.Elements(0).Appearance.Normal.Font, FontStyle.Regular)
    '                e.Item.Elements(0).Appearance.Normal.ForeColor = Color.Gold
    '            End If
    '            If (e.RowHandle Mod 2 = 1) Then

    '                e.Item.Elements(2).Appearance.Normal.BackColor = Color.FromArgb(130, 105, 83)

    '                ' TV_Menu.Appearance.ItemNormal.BackColor
    '            Else
    '                e.Item.Elements(2).Appearance.Normal.BackColor = Color.FromArgb(185, 111, 111)
    '                'TV_Menu.TileTemplate.Item(ii).Appearance.Normal.BackColor = Color.FromArgb(207, 207, 196)
    '            End If
    '        Catch
    '        End Try

    '    End If
    '    If (e.RowHandle >= TV_Menu.RowCount - 1) Then
    '        RefreshMode = False
    '    End If

    'End Sub


    Private Sub CB_LargeSet_CheckedChanged(sender As Object, e As EventArgs) Handles CB_LargeSet.CheckedChanged
        If (CB_LargeSet.Checked) Then

            Me.Sp_POS_MDMenu_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenu_GetData, CategoryID, 1, "")
        Else
            Me.Sp_POS_MDMenu_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenu_GetData, CategoryID, 0, "")

        End If


        RefreshMenu()
    End Sub


    Private Sub SB_OpenOrder_Click(sender As Object, e As EventArgs) Handles SB_OpenOrder.Click
        If (My.Settings.PositionID = "2" Or My.Settings.PositionID = "4" Or My.Settings.PositionID = "5" Or My.Settings.PositionID = "6") Then

            Dim FrmMenuOpenOrder As DevExpress.XtraEditors.XtraForm
            FrmMenuOpenOrder = New Frm_MenuOpenOrder(0, OrderTypeID, Me.OrderID, Label_OrderNo.Text, TableName, TableID, OrderDeliveryID,
                                                     DateStart, DateEnd, GuestName, GuestCount)
            FrmMenuOpenOrder.ShowDialog()
            FrmMenuOpenOrder.Dispose()

            FillDataAdapter()
        End If
    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        'If (OrderTypeID = 11) Then

        'Else

        '    Dim report As New DevExpress.XtraReports.UI.XtraReport
        '    Dim CountMenu As Integer = 0
        '    Dim Query As String

        '    Try

        '        report = New Rpt_PrintOrderNew(OrderID, 0, My.Settings.EmployeeID)
        '        Using printTool As New ReportPrintTool(report)
        '            'printTool.ShowPreviewDialog()
        '            'printTool.Print()
        '            printTool.Print(My.Settings.PrinterCashier)
        '        End Using
        '        report.Dispose()

        '    Catch ex As Exception
        '        MessageBox.Show("Printer Not Set")
        '    End Try

        '    Dim Stat As Boolean = True
        '    If (CInt(colisProcess.SummaryItem.SummaryValue) = 0) Then
        '        Stat = False
        '    End If
        '    Try
        '        CountMenu = Me.QueriesTableAdapter_Report.sp_POSReportTransaction_GetCountRecord(OrderID, 10)
        '        If (CountMenu > 0) Then
        '            report = New Rpt_PrintWorkOrder(OrderID, 10, My.Settings.EmployeeID, TableName, Stat)
        '            Using printTool As New ReportPrintTool(report)
        '                ' printTool.ShowPreviewDialog()
        '                printTool.Print(My.Settings.PrinterKitchen)
        '            End Using
        '            report.Dispose()
        '        End If

        '    Catch ex As Exception
        '        MessageBox.Show("Printer Kitchen Not Set")
        '    End Try


        '    Try
        '        CountMenu = Me.QueriesTableAdapter_Report.sp_POSReportTransaction_GetCountRecord(OrderID, 11)
        '        If (CountMenu > 0) Then
        '            report = New Rpt_PrintWorkOrder(OrderID, 11, My.Settings.EmployeeID, TableName, Stat)
        '            Using printTool As New ReportPrintTool(report)
        '                'printTool.ShowPreviewDialog()
        '                printTool.Print(My.Settings.PrinterBar)
        '            End Using
        '            report.Dispose()
        '        End If

        '    Catch ex As Exception
        '        MessageBox.Show("Printer Bar Not Set")
        '    End Try

        '    Try
        '        CountMenu = Me.QueriesTableAdapter_Report.sp_POSReportTransaction_GetCountRecord(OrderID, 12)
        '        If (CountMenu > 0) Then
        '            report = New Rpt_PrintWorkOrder(OrderID, 12, My.Settings.EmployeeID, TableName, Stat)
        '            Using printTool As New ReportPrintTool(report)
        '                'printTool.ShowPreviewDialog()
        '                printTool.Print(My.Settings.PrinterGrill)
        '            End Using
        '            report.Dispose()
        '        End If

        '    Catch ex As Exception
        '        MessageBox.Show("Printer Pantry Not Set")
        '    End Try

        '    Me.QueriesTableAdapter.sp_POSOrderDetail_KitchenPrint(OrderID, My.Settings.EmployeeID, UserModified)
        '    FillDataAdapter()
        'End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SB_Memo.Click
        Dim FrmMemo As DevExpress.XtraEditors.XtraForm
        FrmMemo = New Frm_MenuMemo(IIf(GV_OrderDetail.GetRowCellValue(GV_OrderRow, colisProcess) = 0, False, True),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colMenuID),
                                   GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID),
                                   GV_OrderDetail.GetRowCellValue(GV_OrderRow, colMenuName),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colPrice),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colQty),
                                    IIf(GV_OrderDetail.GetRowCellValue(GV_OrderRow, colisVoid) = 0, False, True)
                                    )
        FrmMemo.ShowDialog()


        FillDataAdapter()

        Me.Sp_POSOrderDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_GetData, 0, OrderID)
        Me.Sp_POSOrderDetailMemo_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailMemo_GetData, GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID))

    End Sub

    Private Sub Bt_Payment_Click(sender As Object, e As EventArgs) Handles Bt_Payment.Click
        'If (OrderTypeID = 12) Then

        '    Dim StrQuery As String
        '    Dim Param1 As Integer
        '    Param1 = GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID)
        '    StrQuery = "select count(ID) from T_ReservationHeader where OrderID = " + OrderID.ToString
        '    Param1 = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", UserModified, StrQuery)

        '    If (Param1 = 0) Then

        '        Dim FrmReservation As DevExpress.XtraEditors.XtraForm
        '        FrmReservation = New Frm_Reservation(OrderID, Label_OrderNo.Text, TableID, Label_TableName.Text, 11)
        '        FrmReservation.ShowDialog()
        '        If (FrmReservation.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '            FrmReservation.Close()
        '            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        '        End If
        '    Else
        '        Dim FrmPayment As DevExpress.XtraEditors.XtraForm
        '        FrmPayment = New Frm_Payment(OrderID, Label_OrderNo.Text, TableID, Label_TableName.Text, OrderTypeID)
        '        FrmPayment.ShowDialog()
        '        If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '            FrmPayment.Close()
        '            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        '        End If
        '    End If
        'Else

        Dim FrmPayment As DevExpress.XtraEditors.XtraForm

        FrmPayment = New Frm_Payment(OrderID, Label_OrderNo.Text, TableID, Label_TableName.Text, OrderTypeID, 0)
        FrmPayment.ShowDialog()
        If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmPayment.Close()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If
        'End If

    End Sub

    Private Sub GV_OrderDetail_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV_OrderDetail.RowStyle
        If (IsAlreadyVoid(GV_OrderDetail, e.RowHandle)) Then
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Strikeout)
        Else
            If (IsAlreadySent(GV_OrderDetail, e.RowHandle)) Then
                e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Italic)
            Else
                e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Regular)
            End If
        End If

    End Sub
    Private Function IsAlreadySent(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Integer) As Boolean
        Dim val As Boolean = Convert.ToBoolean(view.GetRowCellValue(row, colisProcess))
        Return val
    End Function

    Private Function IsAlreadyVoid(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Integer) As Boolean
        Dim val As Boolean = Convert.ToBoolean(view.GetRowCellValue(row, colisVoid))
        Return val
    End Function

    Private Sub Bt_Hold_Click(sender As Object, e As EventArgs) Handles Bt_Hold.Click
        Dim StrQuery As String
        Dim Param1 As Integer
        Param1 = GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID)
        StrQuery = "UPDATE T_OrderDetail set isHold = 1 Where isHold = 0 and isProcess = 0 and ID = " + Param1
        Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "Update Order Detail : " + Param1, "Hold Menu : isHold from 0 to 1", UserModified, StrQuery)

    End Sub

    Private Sub GV_OrderDetail_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV_OrderDetail.RowClick
        GV_OrderRow = e.RowHandle
    End Sub

    Private Sub Bt_Back_Click(sender As Object, e As EventArgs) Handles Bt_Back.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub Bt_UnHold_Click(sender As Object, e As EventArgs) Handles Bt_UnHold.Click
        Dim StrQuery As String
        Dim Param1 As Integer
        Param1 = GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID)
        StrQuery = "UPDATE T_OrderDetail set isHold = 0 Where isHold = 1 and isProcess = 0 and ID = " + Param1
        Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "Update Order Detail : " + Param1, "UnHold Menu : isHold from 1 to 0", UserModified, StrQuery)

    End Sub

    Private Sub SB_AddMemo_Click(sender As Object, e As EventArgs) Handles SB_AddMemo.Click
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub SB_UpdateKeterangan_Click(sender As Object, e As EventArgs) Handles SB_UpdateKeterangan.Click, SimpleButton2.Click
        Dim Query As String
        Query = "UPDATE T_ORDERHeader SET [Description] = '" + Memo_Keterangan.EditValue.ToString + "' Where ID = " + OrderID.ToString
        Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)

        FlyoutPanel1.HidePopup()
    End Sub

    Private Sub SB_Search_Click(sender As Object, e As EventArgs) Handles SB_Search.Click
        Me.Sp_POS_MDMenu_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenu_GetData, -1, 0, Ed_Keyword.EditValue)
        '    RefreshMenu()
        Label_TypeCategory.Text = " All Menu Filtered "
        RefreshMenu()
        FlyoutPanel2.HidePopup()

        RefreshMode = True
    End Sub

    Private Sub SB_SearchMenu_Click(sender As Object, e As EventArgs) Handles SB_SearchMenu.Click
        FlyoutPanel2.ShowPopup()
        Ed_Keyword.Focus()

    End Sub




    Private Sub Ed_Keyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ed_Keyword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SB_Search.PerformClick()
        End If
    End Sub
End Class