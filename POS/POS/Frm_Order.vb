Imports DevExpress.PivotGrid.OLAP
Imports DevExpress.Utils.Menu
Imports DevExpress.Xpo.DB.Helpers
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports Microsoft.SqlServer
Imports System.Math

Public Class Frm_Order

    Dim _OrderID As Integer
    Dim _TableID, _OrderTypeID As Integer
    Dim _OrderNo, _TableName As String
    Public Shared _ServerID, ButtonCheck As Integer

    Dim UserModified As String

    Dim _MenuTypeID, _MenuCategoryID, _MenuID As Integer

    Dim MemoID As Integer
    Dim _PaymentType As Integer = 1
    Dim _RoundValue As Integer = 0


    Dim RowFocus As Integer

#Region "Initial Procedure"

    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal _ModuleDB As String, ByVal _ACEDB As String,
                   ByVal _PrinterDocument As String, ByVal _PrinterLX As String,
                   ByVal _Printer1 As String, ByVal _Printer2 As String, ByVal _Printer3 As String,
                   ByVal _Printer4 As String, ByVal _Printer5 As String, ByVal _Printer6 As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon
        My.Settings.Item("ConnectionString") = ConnString

        My.Settings.Item("PrinterDocument") = _PrinterDocument
        My.Settings.Item("PrinterLX") = _PrinterLX
        My.Settings.Item("PrinterCashier1") = _Printer1
        My.Settings.Item("PrinterCashier2") = _Printer2
        My.Settings.Item("PrinterThermal") = _Printer3
        My.Settings.Item("PrinterGrill") = _Printer4
        My.Settings.Item("PrinterPantry") = _Printer5
        My.Settings.Item("PrinterGazebo") = _Printer6

    End Sub

    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function

#End Region

    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub 'New
        Public View As GridView
        Public RowHandle As Integer
    End Class


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal _EmployeeID As Integer, ByVal _EmployeeName As String)

        ' This call is required by the designer.
        InitializeComponent()
        'NavButton_CashierName.Tag = _EmployeeID
        'NavButton_CashierName.Caption = _EmployeeName

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Frm_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_MDBank_GetData' table. You can move, or remove it, as needed.
        Me.Sp_POS_MDBank_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDBank_GetData)

        Me.Sp_POS_GetServerListTableAdapter.Fill(Me.DataSet.sp_POS_GetServerList)
        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)

        Me.View_pos_ordertypeTableAdapter.Fill(Me.DataSet.View_POS_OrderType)
        Me.View_MenuType_ListTableAdapter.Fill(Me.DataSet.View_MenuType_List)
        Me.View_POS_MenuCategory_FrontListTableAdapter.Fill(Me.DataSet.View_POS_MenuCategory_FrontList)
        Me.View_POS_MenuList_MainListTableAdapter.Fill(Me.DataSet.View_POS_MenuList_MainList)
        Me.Sp_POS_MDVoidReason_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDVoidReason_GetData, 1)

        XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

        'GridControl_OrderList.Dock = DockStyle.Fill
        ButtonCheck = -1
        RefreshListTable(ButtonCheck)

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName

    End Sub

    Sub RefreshListTable(ByVal _OrderType As Integer)
        Me.Sp_POS_OrderHeader_GetListTableAdapter.Fill(Me.DataSet.sp_POS_OrderHeader_GetList, _OrderType)

        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)

    End Sub


    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click
        Try
            If (IsNothing(SearchLookUpEdit_Server.EditValue)) Then
                Throw New System.Exception("Waiter Belum Dipilih")
            Else
                _ServerID = SearchLookUpEdit_Server.EditValue
            End If

            If (IsNothing(LookUpEdit_Table.EditValue)) Then
                Throw New System.Exception("Meja Belum Dipilih")
            End If
            ButtonCheck = RadioGroup_OrderType.SelectedIndex + 1
            If (ButtonCheck = -1) Then
                Throw New System.Exception("Jenis Pelanggan Belum Dipilih")
            End If


            If (ButtonCheck = 0) Then
                    'Dim FrmOrder As DevExpress.XtraEditors.XtraForm
                    'FrmOrder = New Frm_Order_TableChoose(1)
                    'FrmOrder.ShowDialog()
                    'If (FrmOrder.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                    '    FrmOrder.Close()
                    'End If
                ElseIf (ButtonCheck = 1) Then
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        LookUpEdit_Table.EditValue, LookUpEdit_Table.Text,
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified)

                ElseIf (ButtonCheck = 2) Then
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        0, "-",
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified
                )

                ElseIf (ButtonCheck = 31) Then
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        0, "-",
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified
                )
                Else
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        0, 0,
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified)
                End If


            FlyoutPanel1.HidePopup()


            RefreshListTable(CInt(ButtonCheck))
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally

        End Try


    End Sub





    Sub View_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _ServerID As Integer)

        Dim a As DevExpress.XtraEditors.XtraForm
        a = New Frm_ChooseServer(Me.DataSet.sp_POS_GetServerList, _ServerID)
        a.ShowDialog()
        If (a.DialogResult = DialogResult.OK) Then

            XtraTabControl1.SelectedTabPageIndex = 1
            POS_LoadDetail()


        End If


    End Sub

    Sub Recall_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _isClosed As Boolean)
        'If (My.Settings.PositionID = "5" Or My.Settings.PositionID = "6") Then

        '    Dim FrmFront As DevExpress.XtraEditors.XtraForm
        '    FrmFront = New Frm_Front_old(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID)
        '    FrmFront.ShowDialog()
        '    If (FrmFront.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '        FrmFront.Close()

        '    End If
        'Else
        '    Dim FrmPayment As DevExpress.XtraEditors.XtraForm
        '    FrmPayment = New Frm_Payment(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID, _isClosed)
        '    FrmPayment.ShowDialog()
        '    If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '        FrmPayment.Close()
        '        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        '    End If
        'End If
    End Sub

    Sub Move_Command()
        FlyoutPanel_TableList.ShowPopup()
    End Sub

    Sub Split_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer)
        'Dim FrmSplit As DevExpress.XtraEditors.XtraForm
        'FrmSplit = New Frm_BillSplit(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID)
        'FrmSplit.ShowDialog()
        'If (FrmSplit.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '    FrmSplit.Close()
        'End If
    End Sub

    Sub Combine_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer)
        'Dim FrmCombine As DevExpress.XtraEditors.XtraForm
        'FrmCombine = New Frm_BillCombine(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID)
        'FrmCombine.ShowDialog()
        'If (FrmCombine.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '    FrmCombine.Close()
        'End If

        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_BillInvoicePackagePrintPreview(_OrderId, 0, CInt(0), 0, 0,
                                     CInt(10), CInt(0), 0, 0)
        Using printTool As New ReportPrintTool(report)

            If (My.Settings.PrinterCashier1 = "-") Then
                printTool.ShowPreviewDialog()
            Else
                printTool.Print(My.Settings.PrinterCashier1)
            End If
        End Using
        report.Dispose()
    End Sub

    Sub Void_Command()
        FlyoutPanel1.ShowPopup()
    End Sub


    Private Sub TileView_OrderList_ContextButtonClick(sender As Object, e As DevExpress.Utils.ContextItemClickEventArgs) Handles TileView_OrderList.ContextButtonClick

        Dim _isClosed As Boolean
        _OrderID = TileView_OrderList.GetRowCellValue(e.DataItem.RowHandle, colOrderID_OrderList)
        _OrderNo = TileView_OrderList.GetRowCellValue(e.DataItem.RowHandle, colOrderNo_OrderList)
        _TableID = TileView_OrderList.GetRowCellValue(e.DataItem.RowHandle, colTableID_OrderList)
        _TableName = TileView_OrderList.GetRowCellValue(e.DataItem.RowHandle, colTableName_OrderList)
        _OrderTypeID = TileView_OrderList.GetRowCellValue(e.DataItem.RowHandle, colOrderTypeID_OrderList)
        _isClosed = TileView_OrderList.GetRowCellValue(e.DataItem.RowHandle, colisClosed_OrderList)
        _ServerID = TileView_OrderList.GetRowCellValue(e.DataItem.RowHandle, colEmployeeID_OrderList)

        If (e.Item.Name.ToString = "CBView") Then
            If (_isClosed = False) Then
                View_Command(_OrderID, _OrderNo, _TableID, _TableName, _OrderTypeID, _ServerID)
            Else
                Recall_Command(_OrderID, _OrderNo, _TableID, _TableName, _OrderTypeID, _isClosed)
            End If
        ElseIf (e.Item.Name.ToString = "CBMove") Then
            Move_Command()
        ElseIf (e.Item.Name.ToString = "CBSplit") Then
            Split_Command(_OrderID, _OrderNo, _TableID, _TableName, _OrderTypeID)
        ElseIf (e.Item.Name.ToString = "CBBill") Then
            Combine_Command(_OrderID, _OrderNo, _TableID, _TableName, _OrderTypeID)
        ElseIf (e.Item.Name.ToString = "CBVoid") Then
            Void_Command()
        End If
    End Sub

    Private Sub TileView_OrderList_ItemCustomize(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs)
        Try
            If (CBool(TileView_OrderList.GetRowCellValue(e.RowHandle, colisClosed_OrderList)) = True) Then

                e.Item.Elements(4).Appearance.Normal.BackColor = Color.FromArgb(194, 59, 34)
                e.Item.Elements(4).Appearance.Normal.BackColor2 = Color.FromArgb(&H94, &H23, &HE)
                e.Item.Elements(4).Appearance.Normal.GradientMode = Drawing2D.LinearGradientMode.Vertical
                ' TV_Menu.Appearance.ItemNormal.BackColor
            Else
                e.Item.Elements(4).Appearance.Normal.BackColor = Color.FromArgb(159, 190, 119)
                e.Item.Elements(4).Appearance.Normal.BackColor2 = Color.FromArgb(&H2B, &H75, &H2B)
                e.Item.Elements(4).Appearance.Normal.GradientMode = Drawing2D.LinearGradientMode.Vertical
                'TV_Menu.TileTemplate.Item(ii).Appearance.Normal.BackColor = Color.FromArgb(207, 207, 196)
            End If


            If (TileView_OrderList.GetRowCellValue(e.RowHandle, colSubTotal_OrderList) = 0) Then

                e.Item.Elements(4).Appearance.Normal.BackColor = Color.FromArgb(184, 59, 34)
                e.Item.Elements(4).Appearance.Normal.BackColor2 = Color.FromArgb(&H84, &H23, &HE)
                e.Item.Elements(4).Appearance.Normal.GradientMode = Drawing2D.LinearGradientMode.Vertical
                ' TV_Menu.Appearance.ItemNormal.BackColor
            End If
            'isClosed = IIf((CBool(TileView_OrderList.GetRowCellValue(e.RowHandle, colisPrinted)) = True), 1, 0)
            'My.Settings.isPrinted = isClosed
        Catch
        End Try
    End Sub

    Private Sub FlyoutPanel1_Shown(sender As Object, e As DevExpress.Utils.FlyoutPanelEventArgs) Handles FlyoutPanel1.Shown

        RadioGroup_OrderType.EditValue = -1
    End Sub

    Private Sub SB_UpdateTable_Click(sender As Object, e As EventArgs) Handles SB_UpdateTable.Click
        Me.QueriesTableAdapter.sp_POS_MoveTable(_OrderID.ToString, 2, 0, SearchLookUpEdit_TableMove.EditValue, SearchLookUpEdit_TableMove.Text.ToString, UserModified)
        SB_CancelMove.PerformClick()

        RefreshListTable(ButtonCheck)
    End Sub

    Private Sub SB_CancelMove_Click(sender As Object, e As EventArgs) Handles SB_CancelMove.Click
        FlyoutPanel_TableList.HidePopup()
    End Sub

    Private Sub SB_ChangePassword_Click(sender As Object, e As EventArgs) Handles SB_ChangePassword.Click
        Try
            If (Edit_CheckPass.EditValue = Edit_NewPass.EditValue) Then
                Me.Sp_POS_ChangePasswordTableAdapter.Fill(Me.DataSet.sp_POS_ChangePassword, My.Settings.UserName, Edit_OldPass.EditValue, Edit_NewPass.EditValue)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MessageBox.Show("Pergantian Password Sukses")
            SB_CancelChange.PerformClick()
        End Try

    End Sub


    Private Sub SB_CancelChange_Click(sender As Object, e As EventArgs) Handles SB_CancelChange.Click
        FlyoutPanel2.HidePopup()
    End Sub

    Private Sub SB_CancelServer_Click(sender As Object, e As EventArgs) Handles SB_CancelServer.Click
        FlyoutPanel_ServerList.HidePopup()
    End Sub

    Private Sub SB_SubmitServer_Click(sender As Object, e As EventArgs) Handles SB_SubmitServer.Click
        _ServerID = SearchLookUpEdit_Server.EditValue
        GridControl_OrderList.Visible = False
    End Sub



    Private Sub BB_OrderAll_Click(sender As Object, e As EventArgs) Handles SB_OrderTakeAway.Click, SB_OrderOther.Click, SB_OrderDineIn.Click, SB_OrderDelivery.Click, SB_OrderAll.Click
        Dim a As New SimpleButton
        a = sender
        RefreshListTable(CInt(a.Tag))
    End Sub


    Private Sub PE_Setting_EditValueChanged(sender As Object, e As EventArgs)
        'FlyoutPanel2.ShowPopup()
    End Sub

    Private Sub PE_New_Click(sender As Object, e As EventArgs) Handles PE_New.Click
        RadioGroup_OrderType.DeselectAll()
        'SearchLookUpEdit_Server.Visible = True
        ButtonCheck = -1
        RadioGroup_OrderType.SelectedIndex = -1
        FlyoutPanel1.ShowPopup()

        RefreshListTable(CInt(ButtonCheck))
    End Sub

    Private Sub SB_CloseFlyOut1_Click(sender As Object, e As EventArgs) Handles SB_CloseFlyOut1.Click
        FlyoutPanel1.HidePopup()
    End Sub

    Private Sub PE_DailySummary_Click(sender As Object, e As EventArgs)
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_OneDayCash(Today, My.Settings.UserName, System.Environment.GetEnvironmentVariable("COMPUTERNAME"))
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()

            ' printTool.Print()
            ' printTool.Print(My.Settings.PrinterDocument)
        End Using
        report.Dispose()
    End Sub

    Private Sub RadioGroup_OrderType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup_OrderType.SelectedIndexChanged
        SearchLookUpEdit_Server.Visible = True
    End Sub



    Private Sub SB_CloseFlyout_Click(sender As Object, e As EventArgs)

        FlyoutPanel1.HidePopup()
    End Sub

    '-------------- AREA DETAIL POS -----------------

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        XtraTabControl1.SelectedTabPageIndex = 0
        RefreshListTable(0)
    End Sub

    Sub POS_LoadDetail()
        SB_TableAndType.Text = _TableName + " "
        Label_OrderNo.Text = _OrderNo
        POS_RefreshDetail()
    End Sub

    Private Sub TileView_Menu_ItemRightClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView_Menu.ItemRightClick
        Me.QueriesTableAdapter.sp_POS_OrderDetail_Input(0, _OrderID, CInt(TileView_Menu.GetFocusedRowCellValue(colID_Menu)),
                                                    TileView_Menu.GetFocusedRowCellValue(colMenuName).ToString, 1,
                                                    CInt(TileView_Menu.GetFocusedRowCellValue(colPrice)),
                                                    _ServerID, 1, My.Settings.UserName)

        POS_RefreshDetail()
    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        If (_OrderTypeID = 11) Then

        Else

            Dim report As New DevExpress.XtraReports.UI.XtraReport
            Dim CountMenu As Integer = 0
            Dim Query As String

            Try

                report = New Rpt_PrintCO(_OrderNo, _OrderID, SB_TableAndType.Text, 0, My.Settings.ServerID, Now)
                Using printTool As New ReportPrintTool(report)
                    If (My.Settings.PrinterCashier1 = "-") Then
                        printTool.ShowPreviewDialog()
                    Else
                        printTool.Print(My.Settings.PrinterCashier1)
                    End If

                End Using
                report.Dispose()

            Catch ex As Exception
                MessageBox.Show("Printer Not Set")
            End Try

            Dim Stat As Boolean = True
            If (CInt(colisProcess_OD.SummaryItem.SummaryValue) = 0) Then
                Stat = False
            End If
            Dim LongCount As String
            LongCount = Me.QueriesTableAdapter.sp_POSReportTransaction_GetCountData(_OrderID)
            Dim PrintDes As Integer
            For index As Integer = 0 To Len(LongCount) - 1
                PrintDes = CInt(LongCount.Chars(index).ToString)
                report = New Rpt_PrintWorkOrder(_OrderNo, _OrderID, SB_TableAndType.Text, PrintDes, My.Settings.ServerID, _TableName, Stat)
                Using printTool As New ReportPrintTool(report)
                    'If (PrintDes = 1) Then

                    If (My.Settings.AutoPrint) Then
                        If (PrintDes = 1) Then
                            If (My.Settings.PrinterPantry = "-") Then
                                printTool.ShowPreviewDialog()
                            Else
                                printTool.Print(My.Settings.PrinterPantry)
                            End If
                            'ElseIf (PrintDes = 2) Then
                            '    If (Len(My.Settings.PrinterLX) > 5) Then
                            '        'printTool.Print(My.Settings.PrinterKitchen)
                            '        printTool.ShowPreviewDialog()
                            '    End If
                        ElseIf (PrintDes = 3) Then
                            If (My.Settings.PrinterGrill = "-") Then
                                printTool.ShowPreviewDialog()
                            Else
                                printTool.Print(My.Settings.PrinterGrill)
                            End If
                            'ElseIf (PrintDes = 4) Then
                            '    If (Len(My.Settings.PrinterBar) > 5) Then
                            '        'printTool.Print(My.Settings.PrinterBar)
                            '        printTool.ShowPreviewDialog()
                            '    End If
                        End If
                        'printTool.Print(My.Settings.PrinterKitchen)

                    Else
                        printTool.ShowPreviewDialog()

                    End If
                End Using
                report.Dispose()

            Next

            '-------------------------------------------

            Me.QueriesTableAdapter.sp_POSOrderDetail_KitchenPrint(_OrderID, My.Settings.ServerID, UserModified)
            POS_RefreshDetail()
        End If
    End Sub

    Private Sub SB_Payment_Click(sender As Object, e As EventArgs) Handles SB_Payment.Click

        'ComboBoxEdit_Payment.SelectedIndex = 0

        SB_RoundNominal.Tag = CInt((Ceiling(CInt(Label_Total.Tag) / 10000)) * 10000)
        SB_RoundNominal.Text = String.Format("{0:#,##0}", CInt(SB_RoundNominal.Tag))

        Ed_Rounding.EditValue = 0
        Ed_Change.EditValue = 0
        Ed_Bill.EditValue = CInt(Label_Total.Tag)
        Ed_CardValue.EditValue = 0
        Ed_Payment.EditValue = 0
        CB_Tunai.Checked = True
        SB_FinishPayment.Enabled = False

        FlyoutPanel_POSPayment.ShowPopup()
    End Sub

    Private Sub SB_Preview_Click(sender As Object, e As EventArgs) Handles SB_Preview.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_BillInvoicePackagePrintPreview(_OrderID, 0, CInt(Label_Subtotal.Tag), 0, 0,
                                     CInt(10), CInt(Label_PPn.Tag), 0, 0)
        Using printTool As New ReportPrintTool(report)


            printTool.ShowPreviewDialog()

        End Using
        report.Dispose()
    End Sub

    Private Sub GV_OrderDetail_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GV_OrderDetail.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim menuItemUpdateQty As New DXMenuItem("Update Qty", AddressOf OnUpdateQty)
            menuItemUpdateQty.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemUpdateQty)
            Dim menuItemCancel As New DXMenuItem("Cancel Menu", AddressOf OnCancelMenu)
            menuItemCancel.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemCancel)
        End If
    End Sub
    Sub OnUpdateQty(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_OrderDetail.FocusedRowHandle
        Dim DeletedVar1 As String

        Label_MenuName_Memo.Tag = GV_OrderDetail.GetRowCellValue(RowFocus, colID_OD)
        Label_MenuName_Memo.Text = GV_OrderDetail.GetRowCellValue(RowFocus, colMenuDisplay_OD)
        Ed_Price.EditValue = GV_OrderDetail.GetRowCellValue(RowFocus, colPrice_OD)
        SpinEdit_Qty.EditValue = GV_OrderDetail.GetRowCellValue(RowFocus, colQty_OD)



        DeletedVar1 = GV_OrderDetail.GetRowCellValue(RowFocus, colID_OD).ToString
        Try
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim info As RowInfo = CType(item.Tag, RowInfo)

            FlyoutPanel_UpdateQty.ShowPopup()
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Delete Data", ex.Message)
        End Try
    End Sub

    Sub OnCancelMenu(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_OrderDetail.FocusedRowHandle
        Dim DeletedVar1 As String

        LookUpEdit_VoidReason.Tag = GV_OrderDetail.GetRowCellValue(RowFocus, colID_OD)

        DeletedVar1 = GV_OrderDetail.GetRowCellValue(RowFocus, colID_OD).ToString
        Try
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim info As RowInfo = CType(item.Tag, RowInfo)

            FlyoutPanel_Cancel.ShowPopup()
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Delete Data", ex.Message)
        End Try
    End Sub

    Private Sub GV_OrderDetail_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GV_OrderDetail.RowStyle
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
        Dim val As Boolean = Convert.ToBoolean(view.GetRowCellValue(row, colisProcess_OD))
        Return val
    End Function

    Private Function IsAlreadyVoid(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Integer) As Boolean
        Dim val As Boolean = Convert.ToBoolean(view.GetRowCellValue(row, colisVoid_OD))
        Return val
    End Function

    Private Sub SB_Update_Click(sender As Object, e As EventArgs) Handles SB_Update.Click
        Try
            Dim Query As String
            Query = "UPDATE T_ORDERDETAIL SET QTY = " + CInt(SpinEdit_Qty.EditValue).ToString +
            " ,price = " + CInt(Ed_Price.EditValue).ToString +
            " ,SubTotal = " + (CInt(SpinEdit_Qty.EditValue) * CInt(Ed_Price.EditValue)).ToString +
            " ,ModifiedDate = GETDATE(), ModifiedUser = '" + My.Settings.UserName +
            "' Where ID = " + GV_OrderDetail.GetRowCellValue(RowFocus, colID_OD).ToString +
            " and MenuID = " + GV_OrderDetail.GetRowCellValue(RowFocus, colMenuID_OD).ToString
            Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)

            'If (AdminApproval) Then
            '    Query = "UPDATE T_ORDERDETAIL SET price = " + Ed_Price.EditValue.ToString +
            '        ", SubTotal = " + (CInt(Ed_Qty.EditValue) * CInt(Ed_Price.EditValue)).ToString +
            '        " ,ModifiedDate = GETDATE(), ModifiedUser = '" + My.Settings.UserName +
            '        "' Where ID = " + OrderDetailID.ToString + " and MenuID = " + MenuID.ToString
            '    Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)
            'End If

            POS_RefreshDetail()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Ed_Keyword_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_Keyword.EditValueChanged
        If (_MenuCategoryID = 0) Then
            TileView_Menu.ActiveFilterString = "([MenuTypeID] = " + _MenuTypeID.ToString + " AND [MenuName] like '%" + Ed_Keyword.EditValue + "%')"
        Else
            TileView_Menu.ActiveFilterString = "([MenuCategoryID] = " + _MenuCategoryID.ToString + " AND [MenuName] like '%" + Ed_Keyword.EditValue + "%')"
        End If
    End Sub

    Private Sub SB_TableAndType_Click(sender As Object, e As EventArgs) Handles SB_TableAndType.Click
        XtraTabControl1.SelectedTabPageIndex = 3

        Me.Sp_POS_CheckerSequenceTableAdapter.Fill(Me.DataSet.sp_POS_CheckerSequence, _OrderID)
    End Sub

    Private Sub GC_Checker_DoubleClick(sender As Object, e As EventArgs) Handles GC_Checker.DoubleClick
        Dim report As New DevExpress.XtraReports.UI.XtraReport
        Try


            report = New Rpt_PrintCO(_OrderNo, _OrderID, SB_TableAndType.Text, 99, LV_CO.GetFocusedRowCellValue(colNoRequestOrder), LV_CO.GetFocusedRowCellValue(colCreatedDate_Checker))
            Using printTool As New ReportPrintTool(report)
                If (My.Settings.PrinterCashier1 = "-") Then
                    printTool.ShowPreviewDialog()
                Else
                    printTool.Print(My.Settings.PrinterCashier1)
                End If
            End Using
            report.Dispose()

        Catch ex As Exception
            MessageBox.Show("Printer Not Set")
        End Try
    End Sub

    Private Sub SB_BackCO_Click(sender As Object, e As EventArgs) Handles SB_BackCO.Click
        XtraTabControl1.SelectedTabPageIndex = 1
    End Sub

    Private Sub SB_FinishPayment_Click(sender As Object, e As EventArgs) Handles SB_FinishPayment.Click
        Dim _PaymentDesc As String = ""
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        Try

            Dim _Mode As Integer = 1
            If (CB_Debit.Checked = True) Then
                _Mode = 2
            ElseIf (CB_Credit.Checked = True) Then
                _Mode = 3
            ElseIf (CB_QRIS.Checked) Then
                _Mode = 5
                'ElseIf (CB_OVO.Checked) Then
                '    _Mode = 6
            End If

            If (CInt(Ed_Payment.EditValue + Ed_CardValue.EditValue) >= CInt(Label_Total.Tag) - CInt(Label_Pembulatan.Tag)) Then
                If (CInt(Ed_CardValue.EditValue) > CInt(Label_Total.Tag)) Then

                    Throw New System.Exception("Pembayaran Kartu Melebihi Bill")
                ElseIf (_Mode <> 1 And CInt(Ed_CardValue.EditValue) = 0) Then
                    Throw New System.Exception("Nominal Pembayaran Kartu Tidak Boleh Kosong")

                Else
                    If (MsgBox("Confirmation Payment", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then

                        InsUpdDetail(_PaymentType, "Pembayaran", LookUpEdit_Bank.EditValue, LookUpEdit_Bank.Text, 0)
                        _PaymentDesc = "Pembayaran"
                        'If (Ed_Payment.EditValue > 0 And Ed_CardValue.EditValue > 0) Then
                        '    _PaymentDesc = "Pembayaran"
                        'Else
                        '    _PaymentDesc = IIf(CB_Credit.Checked, "Kartu Kredit " + LookUpEdit_Bank.Text,
                        '                           IIf(CB_Debit.Checked, "Kartu Debit " + LookUpEdit_Bank.Text,
                        '                               IIf(CB_QRIS.Checked, "Qris", "Tunai")))
                        'End If


                        If Ed_CardValue.EditValue > 0 Then
                            Try


                                Me.QueriesTableAdapter.sp_BO_AdminTransaction_MoveServer(_OrderID, Now)

                                Me.Sp_POS_CheckerSequenceTableAdapter.Fill(Me.DataSet.sp_POS_CheckerSequence, _OrderID)
                                Dim reportCO As New DevExpress.XtraReports.UI.XtraReport
                                Dim report2 As New XtraReport
                                report2 = New Rpt_BillInvoicePrint(_OrderID, _PaymentDesc, 2, CInt(Label_Subtotal.Tag),
                                                                  IIf(_PaymentDesc = "Tunai", CInt(Ed_Payment.EditValue), CInt(Label_Total.Tag)),
                                                                  0, 0,
                                                             CInt(10), CInt(Label_PPn.Tag), 0, 0)
                                Using printTool2 As New ReportPrintTool(report2)
                                    'printTool2.ShowPreviewDialog()
                                    If (My.Settings.PrinterCashier2 <> "-") Then

                                        printTool2.Print(My.Settings.PrinterCashier2)
                                    Else
                                        printTool2.ShowPreviewDialog()
                                    End If

                                End Using
                                report2.Dispose()

                                For i As Integer = 0 To LV_CO.RowCount - 1
                                    reportCO = New Rpt_PrintCO(_OrderNo, _OrderID, SB_TableAndType.Text, 99, i, Now)
                                    Using printTool2 As New ReportPrintTool(reportCO)
                                        printTool2.ShowPreviewDialog()
                                        If (My.Settings.PrinterCashier2 <> "-") Then

                                            printTool2.Print(My.Settings.PrinterCashier2)
                                        Else
                                            printTool2.ShowPreviewDialog()
                                        End If

                                    End Using
                                Next

                                reportCO.Dispose()
                            Catch ex As Exception

                                MessageBox.Show("Printer Not Set")
                            End Try

                        End If

                        If (Ed_Rounding.EditValue = 0) Then
                            report = New Rpt_BillInvoicePrint(_OrderID, _PaymentDesc, 1, CInt(Label_Subtotal.Tag),
                                                              IIf(_PaymentDesc = "Tunai", CInt(Ed_Payment.EditValue), CInt(Label_Total.Tag)),
                                                              0, 0,
                                                         CInt(10), CInt(Label_PPn.Tag), 0, 0)

                        Else
                            report = New Rpt_BillInvoicePrintWithRounding(_OrderID, _PaymentDesc, 1, CInt(Label_Subtotal.Tag),
                                                                 IIf(_PaymentDesc = "Tunai", CInt(Ed_Payment.EditValue), CInt(Label_Total.Tag)),
                                                                 0, 0,
                                                            CInt(10), CInt(Label_PPn.Tag), 0, 0)




                        End If
                        Using printTool As New ReportPrintTool(report)

                            If (My.Settings.PrinterCashier1 = "-") Then
                                printTool.ShowPreviewDialog()
                            Else
                                printTool.Print(My.Settings.PrinterCashier1)
                            End If


                            ' printTool.Print()
                            '    printTool.Print("myPrinter")
                        End Using

                        report.Dispose()
                        FlyoutPanel_POSPayment.HidePopup()
                        XtraTabControl1.SelectedTabPageIndex = 0
                        RefreshListTable(0)



                    Else

                        Throw New System.Exception("Pembayaran Kurang")
                    End If




                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    Sub InsUpdDetail(ByVal _Mode As Integer, ByVal _JenisMode As String, ByVal _BankID As Integer, ByVal _BankName As String, ByVal _CustomerID As Integer)
        Me.QueriesTableAdapter.sp_POSTransaction_InsData(_OrderID, Today, _OrderTypeID,
                                                        Today,
                                                        _Mode, _BankID, Ed_CardNo.EditValue, My.Settings.EmployeeID, 0, 0, 0,
                                                        CDec(Label_Subtotal.Tag), CInt(10), CInt(Label_PPn.Tag),
                                                         0, 0, 0, 0, 0,
                                                        CDec(Ed_Payment.EditValue), CDec(Ed_CardValue.EditValue), _RoundValue * -1,
                                                        UserModified)



        Dim StrQuery As String
        Dim Param1 As Integer
        Dim Param2 As String
        Param1 = _OrderID
        Param2 = _OrderNo
        StrQuery = "UPDATE T_OrderHeader Set isPaid = 1, isclosed = 1 Where isclosed = 0 And ID = " + Param1.ToString
        Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "Verifikasi Pembayaran No. Order :  " + Param2.ToString, "Pembayaran secara '" + _JenisMode + "' Berhasil", UserModified, StrQuery)

    End Sub

    Private Sub CB_Tunai_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Tunai.CheckedChanged, CB_QRIS.CheckedChanged, CB_Debit.CheckedChanged, CB_Credit.CheckedChanged
        Dim _TempCB As CheckButton
        _TempCB = sender
        If (_TempCB.Tag = 1) Then
            LookUpEdit_Bank.Visible = True
            Label_Bank.Visible = True
            Ed_CardNo.Visible = True
            Ed_CardNo.EditValue = ""
            Ed_CardValue.Visible = True
            Ed_CardValue.EditValue = 0
            Ed_Payment.EditValue = 0
            _PaymentType = 1


            If Ed_CardValue.EditValue = 0 Then
                Ed_Rounding.EditValue = _RoundValue
                Ed_Bill.EditValue = CInt(Label_Total.Tag) + Ed_Rounding.EditValue

            Else
                Ed_Rounding.EditValue = 0
                Ed_Bill.EditValue = CInt(Label_Total.Tag)
            End If

            Ed_Change.EditValue = 0 - Ed_Bill.EditValue

            'SB_NetCard.Enabled = False
        Else
            LookUpEdit_Bank.Visible = True
            Ed_CardNo.Visible = True
            Label_Bank.Visible = True
            Ed_CardNo.EditValue = ""
            Ed_CardValue.Visible = True
            Ed_CardValue.EditValue = CInt(Label_Total.Tag)
            Ed_Payment.EditValue = 0
            If (CB_Debit.Checked) Then
                _PaymentType = 2
            ElseIf (CB_Credit.Checked) Then
                _PaymentType = 3
            ElseIf (CB_QRIS.Checked) Then
                LookUpEdit_Bank.Visible = False
                Ed_CardNo.Visible = False
                _PaymentType = 5
                'ElseIf (CB_OVO.Checked) Then
                '    _PaymentType = 6
            Else
                _PaymentType = 6
            End If
            'SB_NetCard.Enabled = True
        End If
    End Sub

    Private Sub Ed_CardValue_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_CardValue.EditValueChanged


        If Ed_CardValue.EditValue = 0 And Ed_Payment.EditValue > 0 Then
            Ed_Rounding.EditValue = _RoundValue
            Ed_Bill.EditValue = CInt(Label_Total.Tag) + Ed_Rounding.EditValue

        Else
            Ed_Rounding.EditValue = 0
            Ed_Bill.EditValue = CInt(Label_Total.Tag)
        End If
        Ed_Change.EditValue = (Ed_Payment.EditValue + Ed_CardValue.EditValue) - (CInt(Label_Total.Tag) + Ed_Rounding.EditValue)
        SB_FinishPayment.Enabled = False
    End Sub

    Private Sub Ed_Payment_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_Payment.EditValueChanged

        If Ed_CardValue.EditValue = 0 Then
            Ed_Rounding.EditValue = _RoundValue
            Ed_Bill.EditValue = CInt(Label_Total.Tag) + Ed_Rounding.EditValue

        Else
            Ed_Rounding.EditValue = 0
            Ed_Bill.EditValue = CInt(Label_Total.Tag)
        End If
        Ed_Change.EditValue = (Ed_Payment.EditValue + Ed_CardValue.EditValue) - (CInt(Label_Total.Tag) + Ed_Rounding.EditValue)

        SB_FinishPayment.Enabled = False
    End Sub

    Private Sub SB_RoundNominal_Click(sender As Object, e As EventArgs) Handles SB_RoundNominal.Click
        Ed_Payment.EditValue = CInt(SB_RoundNominal.Tag)
    End Sub

    Private Sub SB_Reset_Click(sender As Object, e As EventArgs) Handles SB_Reset.Click

        Ed_Payment.EditValue = CInt(Label_Total.Tag) - CInt(Ed_CardValue.EditValue) + CInt(Ed_Rounding.EditValue)

    End Sub

    Private Sub SB_50000_Click(sender As Object, e As EventArgs) Handles SB_50000.Click, SB_5000.Click, SB_10000.Click, SB_1000.Click, SB_20000.Click, SB_2000.Click
        If (CB_Plus.Checked) Then
            Ed_Payment.EditValue = CInt(Ed_Payment.EditValue) + CInt(sender.tag())
        ElseIf (CB_Minus.Checked) Then
            Ed_Payment.EditValue = CInt(Ed_Payment.EditValue) - CInt(sender.tag())
        End If
    End Sub

    Private Sub SB_Validasi_Click(sender As Object, e As EventArgs) Handles SB_Validasi.Click
        Try
            If (Ed_Change.EditValue = CInt(Label_Total.Tag)) Then
                Throw New System.Exception("Masih Belum Melakukan Input Pembayaran")
            ElseIf (Ed_Change.EditValue < 0) Then
                Throw New System.Exception("Nominal Pembayaran Kurang")
            ElseIf (Ed_Change.EditValue > 100000) Then
                Throw New System.Exception("Nominal Pembayaran Terlalu Banyak")
            Else
                SB_FinishPayment.Enabled = True
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label_Diskon_Click(sender As Object, e As EventArgs) Handles Label_Diskon.Click

    End Sub

    Private Sub SB_Close_Click(sender As Object, e As EventArgs) Handles SB_Close.Click
        Me.Close()
    End Sub


    Private Sub SB_Remove_Click(sender As Object, e As EventArgs) Handles SB_Remove.Click
        Try
            If (MsgBox("Anda Yakin Ingin Menghapus Menu?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then

                Dim Query As String
                Query = "UPDATE T_ORDERDETAIL SET isVoid = 1 , VoidMenuID = " + LookUpEdit_VoidReason.EditValue.ToString +
                        " ,ModifiedDate = GETDATE(), ModifiedUser = '" + My.Settings.UserName +
                        "' Where ID = " + (GV_OrderDetail.GetRowCellValue(RowFocus, colID_OD).ToString) + " And MenuID = " + (GV_OrderDetail.GetRowCellValue(RowFocus, colMenuID_OD).ToString)
                Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)

                FlyoutPanel_Cancel.HidePopup()


            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub POS_RefreshDetail()
        Me.Sp_POS_OrderDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_OrderDetail_GetData, 0, _OrderID)
        Label_Subtotal.Text = "Rp. " + String.Format("{0:#,##0}", colSubtotal_OD.SummaryItem.SummaryValue)
        Label_Subtotal.Tag = colSubtotal_OD.SummaryItem.SummaryValue
        Label_Diskon.Tag = colDiscount_OD.SummaryItem.SummaryValue
        Label_Diskon.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Diskon.Tag))
        Label_PPn.Tag = (CInt(Label_Subtotal.Tag) - CInt(Label_Diskon.Tag)) / 10
        Label_PPn.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Subtotal.Tag) / 10)
        _RoundValue = ((CInt(Label_Subtotal.Tag) - CInt(Label_Diskon.Tag) + CInt(Label_PPn.Tag)) Mod 1000) * -1
        Label_Pembulatan.Tag = (CInt(Label_Subtotal.Tag) - CInt(Label_Diskon.Tag) + CInt(Label_PPn.Tag)) Mod 1000 * 1
        Label_Pembulatan.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Pembulatan.Tag))
        Label_Total.Tag = Label_Subtotal.Tag + Label_PPn.Tag
        Label_Total.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Subtotal.Tag + Label_PPn.Tag))
    End Sub



    Private Sub TV_MenuCategory_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_MenuCategory.ItemClick
        _MenuCategoryID = TV_MenuCategory.GetFocusedRowCellValue(colID_TVCategory).ToString
        'TileView_Menu.ActiveFilterString = "(MenuCategoryID = " + TileView_Category.GetFocusedRowCellValue(colID_Category).ToString + ")"
        Ed_Keyword.EditValue = ""

        TileView_Menu.ActiveFilterString = "(MenuCategoryID = " + _MenuCategoryID.ToString + " )"
    End Sub

    Private Sub TileView_Menu_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView_Menu.ItemClick

    End Sub

    Private Sub TV_MenuType_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_MenuType.ItemClick
        _MenuTypeID = TV_MenuType.GetFocusedRowCellValue(colID_TVType).ToString
        _MenuCategoryID = 0
        TV_MenuCategory.ActiveFilterString = "(MenuTypeID = " + _MenuTypeID.ToString + ")"
        TileView_Menu.ActiveFilterString = "(MenuTypeID = " + _MenuTypeID.ToString + ")"
        Ed_Keyword.EditValue = ""
    End Sub

End Class