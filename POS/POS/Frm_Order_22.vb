Imports DevExpress.XtraReports.UI

Public Class Frm_Order_22
    Dim ButtonCheck As Integer = 1

    Dim _OrderID As Integer
    Dim _ServerID As Integer

    Dim UserModified As String

    Dim ds_type, ds_category As DataTable


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
    Private Sub Frm_Front_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetServerList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetServerListTableAdapter.Fill(Me.DataSet.sp_POS_GetServerList)
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetTableList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)
        'TODO: This line of code loads data into the 'DataSet.view_pos_ordertype' table. You can move, or remove it, as needed.
        Me.View_pos_ordertypeTableAdapter.Fill(Me.DataSet.View_POS_OrderType)

        Me.View_MenuType_ListTableAdapter.Fill(Me.DataSet.View_MenuType_List)
        Me.View_POS_MenuCategory_FrontListTableAdapter.Fill(Me.DataSet.View_POS_MenuCategory_FrontList)
        ds_type = View_MenuType_ListTableAdapter.GetData
        ds_category = View_POS_MenuCategory_FrontListTableAdapter.GetData
        'GridControl_OrderList.Dock = DockStyle.Fill
        ButtonCheck = 0
        RefreshListTable(ButtonCheck)

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName

    End Sub

    Sub RefreshListTable(ByVal _OrderType As Integer)
        Me.Sp_POS_OrderHeader_GetListTableAdapter.Fill(Me.DataSet.sp_POS_OrderHeader_GetList, _OrderType)

        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)

    End Sub


    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click
        If (IsDBNull(SearchLookUpEdit_Server) = False) Then
            ButtonCheck = RadioGroup_OrderType.SelectedIndex + 1
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
        End If

        _ServerID = SearchLookUpEdit_Server.EditValue
        FlyoutPanel1.HidePopup()
        RefreshListTable(CInt(ButtonCheck))
    End Sub


    Private Sub WindowsUIButtonPanel_OrderType_ButtonChecked(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)
        'ButtonCheck = e.Button.Properties.Tag
        'If (ButtonCheck = 1) Then
        '    LCItem_ChooseTable.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        'Else
        '    LCItem_ChooseTable.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'End If
    End Sub



    Private Sub TileView_OrderList_ItemRightClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs)

    End Sub

    Sub View_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _ServerID As Integer)

        Dim a As DevExpress.XtraEditors.XtraForm
        a = New Frm_ChooseServer(Me.DataSet.sp_POS_GetServerList, _ServerID)
        a.ShowDialog()
        If (a.DialogResult = DialogResult.OK) Then
            Dim FrmFront As DevExpress.XtraEditors.XtraForm
            FrmFront = New Frm_Front(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID, _ServerID, ds_type, ds_category)
            FrmFront.MdiParent = Me
            FrmFront.Show()
            'FrmFront.ShowDialog()
            If (FrmFront.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmFront.Close()
                RefreshListTable(CInt(ButtonCheck))
            End If
        End If


    End Sub

    Sub Recall_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _isClosed As Boolean)
        If (My.Settings.PositionID = "5" Or My.Settings.PositionID = "6") Then

            Dim FrmFront As DevExpress.XtraEditors.XtraForm
            FrmFront = New Frm_Front_old(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID)
            FrmFront.ShowDialog()
            If (FrmFront.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmFront.Close()

            End If
        Else
            Dim FrmPayment As DevExpress.XtraEditors.XtraForm
            FrmPayment = New Frm_Payment(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID, _isClosed)
            FrmPayment.ShowDialog()
            If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmPayment.Close()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Sub Move_Command()
        FlyoutPanel_TableList.ShowPopup()
    End Sub

    Sub Split_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer)
        Dim FrmSplit As DevExpress.XtraEditors.XtraForm
        FrmSplit = New Frm_BillSplit(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID)
        FrmSplit.ShowDialog()
        If (FrmSplit.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmSplit.Close()
        End If
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

            If (My.Settings.AutoPrint) Then
                printTool.Print(My.Settings.PrinterCashier)
            Else
                printTool.ShowPreviewDialog()
            End If
        End Using
        report.Dispose()
    End Sub

    Sub Void_Command()
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub TileView_OrderList_ContextButtonClick(sender As Object, e As DevExpress.Utils.ContextItemClickEventArgs) Handles TileView_OrderList.ContextButtonClick
        Dim _TableID, _OrderTypeID, _ServerID As Integer
        Dim _OrderNo, _TableName As String
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



    Private Sub BB_OrderAll_Click(sender As Object, e As EventArgs) Handles BB_OrderAll.Click, BB_OrderTakeAway.Click, BB_OrderOther.Click, BB_OrderDineIn.Click, BB_OrderDelivery.Click
        Dim a As New Bunifu.UI.WinForms.BunifuButton.BunifuButton
        a = sender
        RefreshListTable(CInt(a.Tag))
    End Sub


    Private Sub PE_Setting_EditValueChanged(sender As Object, e As EventArgs) Handles PE_Setting.EditValueChanged
        'FlyoutPanel2.ShowPopup()
    End Sub

    Private Sub PE_New_Click(sender As Object, e As EventArgs) Handles PE_New.Click
        RadioGroup_OrderType.DeselectAll()
        'SearchLookUpEdit_Server.Visible = True
        RadioGroup_OrderType.SelectedIndex = -1
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub PE_DailySummary_Click(sender As Object, e As EventArgs) Handles PE_DailySummary.Click
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

    Private Sub BB_Next_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PE_Exit_Click(sender As Object, e As EventArgs) Handles PE_Exit.Click
        Me.Close()

    End Sub

    Private Sub PE_New_EditValueChanged(sender As Object, e As EventArgs) Handles PE_New.EditValueChanged

    End Sub

    Private Sub SB_CloseFlyout_Click(sender As Object, e As EventArgs)

        FlyoutPanel1.HidePopup()
    End Sub


End Class