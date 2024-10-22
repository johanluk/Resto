Imports System.Math
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI


Public Class Frm_Front


    Dim ButtonCheck As Integer = 1
    Dim _OrderID As Integer
    Dim _ServerID As Integer

    Public TableID As Integer
    Public TableName As String
    Dim OrderID As Integer
    Dim OrderNo As String
    Public OrderTypeID As Integer
    Public OrderDeliveryID As Integer = 0

    Dim ServerID As Integer

    Dim GV_OrderRow As Integer
    Dim UserModified As String

    Dim MemoID As Integer
    Dim _PaymentType As Integer

    Dim _MenuCategoryID As Integer
    Dim _MenuTypeID As Integer
    Dim ds_Type, ds_Category As DataTable


    Dim RowFocus As Integer
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

    Public Sub New(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _ServerID As Integer, ByVal _dsType As DataTable, _dsCategory As DataTable)


        ' This call is required by the designer.
        InitializeComponent()
        OrderID = _OrderId
        OrderNo = _OrderNo
        TableID = _TableID
        TableName = _TableName
        OrderTypeID = _OrderTypeID
        ServerID = _ServerID
        'SB_Back.Text = OrderNo
        SB_TableAndType.Text = TableName + " "


        ds_Type = _dsType
        ds_Category = _dsCategory


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Frm_Front_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetTableList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetServerList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetServerListTableAdapter.Fill(Me.DataSet.sp_POS_GetServerList)
        'TODO: This line of code loads data into the 'DataSet.sp_POS_MDBank_GetData' table. You can move, or remove it, as needed.
        Me.Sp_POS_MDBank_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDBank_GetData)
        Try

            'TODO: This line of code loads data into the 'DataSet.view_pos_menulist_mainlist' table. You can move, or remove it, as needed.
            'TODO: This line of code loads data into the 'DataSet.view_pos_menulist_mainlist' table. You can move, or remove it, as needed.
            '    Me.View_menutype_listTableAdapter.Fill(Me.DataSet.View_MenuType_List)
            '    Me.View_pos_menucategory_frontlistTableAdapter.Fill(Me.DataSet.View_POS_MenuCategory_FrontList)

            'View_menutype_listGridControl.DataSource = ds_Type
            Me.View_menutype_listTableAdapter.Fill(Me.DataSet.View_MenuType_List)
            Me.View_pos_menucategory_frontlistTableAdapter.Fill(Me.DataSet.View_POS_MenuCategory_FrontList)
            Me.View_pos_menulist_mainlistTableAdapter.Fill(Me.DataSet.View_POS_MenuList_MainList)
            Me.Sp_POS_MDVoidReason_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDVoidReason_GetData, 1)


            'TODO: This line of code loads data into the 'DataSet.view_pos_menucategory_frontlist' table. You can move, or remove it, as needed.
            TileView_Category.ActiveFilterString = "(MenuTypeID = 1)"

            '    View_pos_menucategory_frontlistBindingSource.Filter = "MenuTypeID = 1"
            TileView_Menu.ActiveFilterString = "(MenuCategoryID = 0)"
            ' View_pos_menulist_mainlistBindingSource.Filter = "MenuCategoryID = 0"

            'TODO: This line of code loads data into the 'DataSet.view_menutype_list' table. You can move, or remove it, as needed.

            'TODO: This line of code loads data into the 'DataSet.view_pos_ordertype' table. You can move, or remove it, as needed.


            Label_OrderNo.Text = OrderNo
            SB_TableAndType.Text = TableName

            XtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
            TV_MenuMemo.OptionsTiles.ItemSize = New Size(250, (Sp_POS_MDMenuMemo_GetDataGridControl.Height - 50) / 8)

            'TileView_Menu.OptionsTiles.ItemSize = New Size((View_menu_listGridControl.Size.Width - 100) / 5, 100)

            UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName


            'TileView_Menu.ActiveFilterString = "([MenuCategoryID] = " + _MenuCategoryID.ToString + " AND [MenuName] like '%" + Ed_Keyword.EditValue + "%')"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        RefreshData()
    End Sub

    Private Sub TileView_Type_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView_Type.ItemClick
        'View_pos_menucategory_frontlistBindingSource.Filter = "MenuTypeID = " + TileView_Type.GetFocusedRowCellValue(colID).ToString


        FlyoutPanel2.HidePopup()
    End Sub
    Sub RefreshData()
        Me.Sp_POS_OrderDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_OrderDetail_GetData, 0, OrderID)
        Label_Subtotal.Text = "Rp. " + String.Format("{0:#,##0}", colSubtotal_OD.SummaryItem.SummaryValue)
        Label_Subtotal.Tag = colSubtotal_OD.SummaryItem.SummaryValue
        Label_Diskon.Tag = colDiscount_OD.SummaryItem.SummaryValue
        Label_Diskon.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Diskon.Tag))
        Label_PPn.Tag = (CInt(Label_Subtotal.Tag) - CInt(Label_Diskon.Tag)) / 10
        Label_PPn.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Subtotal.Tag) / 10)
        Label_Pembulatan.Tag = (CInt(Label_Subtotal.Tag) - CInt(Label_Diskon.Tag) + CInt(Label_PPn.Tag)) Mod 1000 * 1
        Label_Pembulatan.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Pembulatan.Tag))
        Label_Total.Tag = Label_Subtotal.Tag + Label_PPn.Tag - Label_Pembulatan.Tag
        Label_Total.Text = "Rp. " + String.Format("{0:#,##0}", CInt(Label_Subtotal.Tag + Label_PPn.Tag - Label_Pembulatan.Tag))
    End Sub

    Private Sub TileView_Menu_ItemRightClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TileView_Menu.ItemRightClick
        Me.QueriesTableAdapter.sp_POS_OrderDetail_Input(0, OrderID, CInt(TileView_Menu.GetFocusedRowCellValue(colID_Menu)),
                                                        TileView_Menu.GetFocusedRowCellValue(colMenuName).ToString, 1,
                                                        CInt(TileView_Menu.GetFocusedRowCellValue(colPrice)),
                                                        ServerID, 1, My.Settings.UserName)

        RefreshData()
    End Sub



    Private Sub Ed_Keyword_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_Keyword.EditValueChanged

        'TileView_Menu.ActiveFilterString = "([MenuCategoryID] = " + _MenuCategoryID.ToString + " AND [MenuName] like '%" + Ed_Keyword.EditValue + "%')"
        If (_MenuCategoryID = 0) Then
            TileView_Menu.ActiveFilterString = "([MenuTypeID] = " + _MenuTypeID.ToString + " AND [MenuName] like '%" + Ed_Keyword.EditValue + "%')"
        Else
            TileView_Menu.ActiveFilterString = "([MenuCategoryID] = " + _MenuCategoryID.ToString + " AND [MenuName] like '%" + Ed_Keyword.EditValue + "%')"
        End If
    End Sub
    Private Sub TileView_Category_Click(sender As Object, e As EventArgs)
        '_MenuCategoryID = TileView_Category.GetFocusedRowCellValue(colID_Category).ToString
        ''   View_pos_menulist_mainlistBindingSource.Filter = "MenuCategoryID = " + TileView_Category.GetFocusedRowCellValue(colID_Category).ToString
        'Ed_Keyword.EditValue = ""
    End Sub

    Private Sub SB_100_Click(sender As Object, e As EventArgs)


        If (CB_Plus.Checked) Then
            Ed_Payment.EditValue = CInt(Ed_Payment.EditValue) + CInt(sender.tag())
        ElseIf (CB_Minus.Checked) Then
            Ed_Payment.EditValue = CInt(Ed_Payment.EditValue) - CInt(sender.tag())
        End If

    End Sub


    Private Sub SB_Reset_Click(sender As Object, e As EventArgs) Handles SB_Reset.Click
        Ed_Payment.EditValue = CInt(Label_Total.Tag) - CInt(Ed_CardValue.EditValue)
    End Sub

    Private Sub SB_Payment_Click(sender As Object, e As EventArgs) Handles BB_Payment.Click

        'ComboBoxEdit_Payment.SelectedIndex = 0
        Dim temp As Integer
        temp = CInt((Ceiling(CInt(Label_Total.Tag) / 10000)) * 10000)
        SB_RoundNominal.Text = String.Format("{0:#,##0}", temp)
        SB_RoundNominal.Tag = temp

        Ed_Bill.EditValue = CInt(Label_Total.Tag)
        Ed_CardValue.EditValue = 0

        CB_Tunai.Checked = True

        FlyoutPanel_POSPayment.ShowPopup()
    End Sub


    Private Sub SB_RoundNominal_Click(sender As Object, e As EventArgs) Handles SB_RoundNominal.Click
        Ed_Payment.EditValue = CInt(SB_RoundNominal.Tag)
    End Sub

    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click
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

            If (CInt(Ed_Payment.EditValue + Ed_CardValue.EditValue) >= CInt(Label_Total.Tag)) Then
                If (CInt(Ed_CardValue.EditValue) > CInt(Label_Total.Tag)) Then

                    Throw New System.Exception("Pembayaran Kartu Melebihi Bill")
                ElseIf (_Mode <> 1 And CInt(Ed_CardValue.EditValue) = 0) Then
                    Throw New System.Exception("Nominal Pembayaran Kartu Tidak Boleh Kosong")

                ElseIf (MsgBox("Confirmation Payment", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then

                    InsUpdDetail(_PaymentType, ComboBoxEdit_Payment.Text, LookUpEdit_Bank.EditValue, LookUpEdit_Bank.Text, 0)
                    If (Ed_Payment.EditValue > 0 And Ed_CardValue.EditValue > 0) Then
                        _PaymentDesc = "Pembayaran"
                    Else
                        _PaymentDesc = IIf(CB_Credit.Checked, "Kartu Kredit " + LookUpEdit_Bank.Text,
                                               IIf(CB_Debit.Checked, "Kartu Debit " + LookUpEdit_Bank.Text,
                                                   IIf(CB_QRIS.Checked, "Qris", "Tunai")))
                    End If

                    report = New Rpt_BillInvoicePrint(OrderID, _PaymentDesc, 1, CInt(Label_Subtotal.Tag),
                                                          IIf(_PaymentDesc = "Tunai", CInt(Ed_Payment.EditValue), CInt(Label_Total.Tag)),
                                                          0, 0,
                                                     CInt(10), CInt(Label_PPn.Tag), 0, 0)
                    Using printTool As New ReportPrintTool(report)

                        printTool.ShowPreviewDialog()

                        ' printTool.Print()
                        '    printTool.Print("myPrinter")
                    End Using
                    report.Dispose()
                    DialogResult = DialogResult.OK

                Else

                    Throw New System.Exception("Pembayaran Kurang")
                End If
            Else

                Throw New System.Exception("Pembayaran Dibatalkan")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try

    End Sub

    Sub InsUpdDetail(ByVal _Mode As Integer, ByVal _JenisMode As String, ByVal _BankID As Integer, ByVal _BankName As String, ByVal _CustomerID As Integer)
        Me.QueriesTableAdapter.sp_POSTransaction_InsData(OrderID, Today, OrderTypeID,
                                                        Today,
                                                        _Mode, _BankID, Ed_CardNo.EditValue, My.Settings.EmployeeID, 0, 0, 0,
                                                        CDec(Label_Subtotal.Tag), CInt(10), CInt(Label_PPn.Tag),
                                                         0, 0, 0, 0, 0,
                                                        CDec(Ed_Payment.EditValue), CDec(Ed_CardValue.EditValue), 1000,
                                                        UserModified)
        Dim StrQuery As String
        Dim Param1 As Integer
        Dim Param2 As String
        Param1 = OrderID
        Param2 = OrderNo
        StrQuery = "UPDATE T_OrderHeader Set isPaid = 1, isclosed = 1 Where isclosed = 0 And ID = " + Param1.ToString
        Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "Verifikasi Pembayaran No. Order :  " + Param2.ToString, "Pembayaran secara '" + _JenisMode + "' Berhasil", UserModified, StrQuery)

    End Sub

    Private Sub SB_Cancel_Click(sender As Object, e As EventArgs) Handles SB_Cancel.Click
        XtraTabControl.SelectedTabPage = XtraTabPage_ChooseMenu
    End Sub

    Private Sub SB_PrintPreview_Click(sender As Object, e As EventArgs) Handles BB_PrintPreview.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_BillInvoicePackagePrintPreview(OrderID, 0, CInt(Label_Subtotal.Tag), 0, 0,
                                     CInt(10), CInt(Label_PPn.Tag), 0, 0)
        Using printTool As New ReportPrintTool(report)

            If (My.Settings.AutoPrint) Then
                printTool.Print(My.Settings.PrinterCashier)
            Else
                printTool.ShowPreviewDialog()
            End If
        End Using
        report.Dispose()
    End Sub

    Private Sub SB_Memo_Click(sender As Object, e As EventArgs) Handles SB_Memo.Click
        Dim FrmMemo As DevExpress.XtraEditors.XtraForm
        FrmMemo = New Frm_MenuMemo(IIf(GV_OrderDetail.GetRowCellValue(GV_OrderRow, colisProcess_OD) = 0, False, True),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colMenuID_OD),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID_OD),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colMenuName_OD),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colPrice_OD),
                                    GV_OrderDetail.GetRowCellValue(GV_OrderRow, colQty_OD),
                                    IIf(GV_OrderDetail.GetRowCellValue(GV_OrderRow, colisVoid_OD) = 0, False, True)
                                    )
        FrmMemo.ShowDialog()

        RefreshData()

        'Me.Sp_POSOrderDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_GetData, 0, OrderID)
        'Me.Sp_POSOrderDetailMemo_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailMemo_GetData, GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID))

    End Sub

    Private Sub GV_OrderDetail_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV_OrderDetail.RowClick
        GV_OrderRow = e.RowHandle
        'If (e.Button = MouseButtons.Right And GV_OrderDetail.GetFocusedRowCellValue(colisProcess_OD) = False) Then
        Label_MenuName_Memo.Tag = GV_OrderDetail.GetRowCellValue(GV_OrderRow, colID_OD)
        Label_MenuName_Memo.Text = GV_OrderDetail.GetFocusedRowCellValue(colMenuName_OD)
        Ed_Price.EditValue = GV_OrderDetail.GetRowCellValue(GV_OrderRow, colPrice_OD)
        SpinEdit_Qty.EditValue = GV_OrderDetail.GetRowCellValue(GV_OrderRow, colQty_OD)
        Me.Sp_POS_MDMenuMemo_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDMenuMemo_GetData, GV_OrderDetail.GetFocusedRowCellValue(colMenuID_OD), 0)
        Sp_POSOrderDetailMemo_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailMemo_GetData, CInt(Label_MenuName_Memo.Tag))
        XtraTabControl.SelectedTabPage = XtraTabPage_Memo
        'End If
    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        If (OrderTypeID = 11) Then

        Else

            Dim report As New DevExpress.XtraReports.UI.XtraReport
            Dim CountMenu As Integer = 0
            Dim Query As String

            Try

                report = New Rpt_PrintCO(OrderNo, OrderID, SB_TableAndType.Text, 0, My.Settings.ServerID, Now)
                Using printTool As New ReportPrintTool(report)
                    If (My.Settings.AutoPrint) Then
                        printTool.Print(My.Settings.PrinterCashier)
                    Else
                        printTool.ShowPreviewDialog()
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
            LongCount = Me.QueriesTableAdapter_POS.sp_POSReportTransaction_GetCountData(OrderID)
            Dim PrintDes As Integer
            For index As Integer = 0 To Len(LongCount) - 1
                PrintDes = CInt(LongCount.Chars(index).ToString)
                report = New Rpt_PrintWorkOrder(OrderNo, OrderID, SB_TableAndType.Text, PrintDes, My.Settings.ServerID, TableName, Stat)
                Using printTool As New ReportPrintTool(report)
                    'If (PrintDes = 1) Then

                    If (My.Settings.AutoPrint) Then
                        If (PrintDes = 1) Then
                            If (Len(My.Settings.PrinterPantry) > 5) Then
                                'printTool.Print(My.Settings.PrinterPantry)
                                printTool.ShowPreviewDialog()
                            End If
                        ElseIf (PrintDes = 2) Then
                            If (Len(My.Settings.PrinterKitchen) > 5) Then
                                'printTool.Print(My.Settings.PrinterKitchen)
                                printTool.ShowPreviewDialog()
                            End If
                        ElseIf (PrintDes = 3) Then
                            If (Len(My.Settings.PrinterGrill) > 5) Then
                                'printTool.Print(My.Settings.PrinterGrill)
                                printTool.ShowPreviewDialog()
                            End If
                        ElseIf (PrintDes = 4) Then
                            If (Len(My.Settings.PrinterBar) > 5) Then
                                'printTool.Print(My.Settings.PrinterBar)
                                printTool.ShowPreviewDialog()
                            End If
                        End If
                        'printTool.Print(My.Settings.PrinterKitchen)

                    Else
                        printTool.ShowPreviewDialog()

                    End If
                End Using
                report.Dispose()

            Next

            '-------------------------------------------

            Me.QueriesTableAdapter.sp_POSOrderDetail_KitchenPrint(OrderID, My.Settings.ServerID, UserModified)
            RefreshData()
        End If
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
        Dim val As Boolean = Convert.ToBoolean(view.GetRowCellValue(row, colisProcess_OD))
        Return val
    End Function

    Private Function IsAlreadyVoid(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Integer) As Boolean
        Dim val As Boolean = Convert.ToBoolean(view.GetRowCellValue(row, colisVoid_OD))
        Return val
    End Function


    Private Sub TV_Menu_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_MenuMemo.ItemClick
        Try
            If (Ed_CustomMemo.EditValue = "") Then
                Ed_CustomMemo.EditValue = e.Item.Elements(0).ToString
            Else
                Ed_CustomMemo.EditValue = Ed_CustomMemo.EditValue + ", " + e.Item.Elements(0).ToString
            End If
        Catch
        End Try
    End Sub

    Private Sub SB_Back_Memo_Click(sender As Object, e As EventArgs) Handles SB_Back_Memo.Click
        XtraTabControl.SelectedTabPage = XtraTabPage_ChooseMenu
    End Sub



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

            RefreshData()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SB_Clear_Click(sender As Object, e As EventArgs) Handles SB_Clear.Click
        Ed_CustomMemo.EditValue = ""
    End Sub

    Private Sub SB_SubmitMemo_Click(sender As Object, e As EventArgs) Handles SB_SubmitMemo.Click
        If (Trim(Ed_CustomMemo.EditValue) = "") Then
            MessageBox.Show("Error Input Value")
        Else

            Me.QueriesTableAdapter.sp_POSOrderDetailMemo_InsData(CInt(Label_MenuName_Memo.Tag), Ed_CustomMemo.EditValue, My.Settings.EmployeeID, UserModified)

            Me.Sp_POSOrderDetailMemo_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailMemo_GetData, CInt(Label_MenuName_Memo.Tag))
            Ed_CustomMemo.EditValue = ""
        End If
    End Sub

    Private Sub SB_Remove_Click(sender As Object, e As EventArgs) Handles SB_Remove.Click
        Try
            If (MsgBox("Anda Yakin Ingin Menghapus Menu?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then

                Dim Query As String
                Query = "UPDATE T_ORDERDETAIL SET isVoid = 1 , VoidMenuID = " + LookUpEdit_VoidReason.EditValue.ToString +
                        " ,ModifiedDate = GETDATE(), ModifiedUser = '" + My.Settings.UserName +
                        "' Where ID = " + (GV_OrderDetail.GetRowCellValue(RowFocus, colID_OD).ToString) + " And MenuID = " + (GV_OrderDetail.GetRowCellValue(RowFocus, colMenuID_OD).ToString)
                Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)

                SB_Back_Memo.PerformClick()

                RefreshData()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub GC_Checker_DoubleClick(sender As Object, e As EventArgs) Handles GC_Checker.DoubleClick
        Dim report As New DevExpress.XtraReports.UI.XtraReport
        Try


            report = New Rpt_PrintCO(OrderNo, OrderID, SB_TableAndType.Text, 99, LV_CO.GetFocusedRowCellValue(colNoRequestOrder), LV_CO.GetFocusedRowCellValue(colCreatedDate_Checker))
            Using printTool As New ReportPrintTool(report)
                If (My.Settings.AutoPrint) Then
                    printTool.Print(My.Settings.PrinterCashier)
                Else
                    printTool.ShowPreviewDialog()
                End If
            End Using
            report.Dispose()

        Catch ex As Exception
            MessageBox.Show("Printer Not Set")
        End Try
    End Sub

    Private Sub SB_BackCO_Click(sender As Object, e As EventArgs) Handles SB_BackCO.Click
        XtraTabControl.SelectedTabPage = XtraTabPage_ChooseMenu
    End Sub

    Private Sub SB_TableAndType_Click(sender As Object, e As EventArgs) Handles SB_TableAndType.Click
        XtraTabControl.SelectedTabPage = XtraTabPage_Table

        Me.Sp_POS_CheckerSequenceTableAdapter.Fill(Me.DataSet.sp_POS_CheckerSequence, OrderID)
    End Sub

    Private Sub CB_Non_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Debit.CheckedChanged, CB_Credit.CheckedChanged, CB_QRIS.CheckedChanged, CB_Tunai.CheckedChanged
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

        Ed_Charge.EditValue = (Ed_Payment.EditValue + Ed_CardValue.EditValue) - CInt(Label_Total.Tag)
    End Sub

    Private Sub GV_DetailMemo_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV_DetailMemo.RowClick
        MemoID = e.RowHandle
    End Sub

    Private Sub SB_RemoveMemo_Click(sender As Object, e As EventArgs) Handles SB_RemoveMemo.Click

        Try
            Dim Query As String
            Query = "delete from T_ORDERDETAILMEMO " +
                    " ,ModifiedDate = GETDATE(), ModifiedUser = '" + My.Settings.UserName +
                    "' Where ID = " + MemoID.ToString
            Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SB_Recall_Click(sender As Object, e As EventArgs) Handles SB_Recall.Click
        Try
            If (MsgBox("Anda Yakin Ingin Memanggil Kembali Menu?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then

                Dim Query As String
                Query = "UPDATE T_ORDERDETAIL SET isVoid = 0 , VoidMenuID = 0 ,ModifiedDate = GETDATE(), ModifiedUser = '" + My.Settings.UserName +
                        "' Where ID = " + (Label_MenuName_Memo.Tag).ToString + " And MenuID = " + (GV_OrderDetail.GetRowCellValue(GV_OrderRow, colMenuID_OD).ToString)
                Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "Recall Menu", Ed_RecallReason.EditValue, "", Query)

                SB_Back_Memo.PerformClick()

                RefreshData()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Frm_Front_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        TV_MenuMemo.OptionsTiles.ItemSize = New Size(250, (Sp_POS_MDMenuMemo_GetDataGridControl.Height - 50) / 8)

    End Sub

    Private Sub BB_100_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click, BB_10.Click, BB_1.Click, BB_05.Click
        If (CB_Plus.Checked) Then
            Ed_Payment.EditValue = CInt(Ed_Payment.EditValue) + CInt(sender.tag())
        ElseIf (CB_Minus.Checked) Then
            Ed_Payment.EditValue = CInt(Ed_Payment.EditValue) - CInt(sender.tag())
        End If
    End Sub

    Private Sub BB_ShowUp_Click(sender As Object, e As EventArgs) Handles BB_ShowUp.Click
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub PE_New_EditValueChanged(sender As Object, e As EventArgs)

    End Sub


    Sub RefreshListTable(ByVal _OrderType As Integer)
        Me.Sp_POS_OrderHeader_GetListTableAdapter.Fill(Me.DataSet.sp_POS_OrderHeader_GetList, _OrderType)

        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)

    End Sub

    Private Sub BB_OrderAll_Click(sender As Object, e As EventArgs) Handles BB_OrderAll.Click, BB_OrderTakeAway.Click, BB_OrderOther.Click, BB_OrderDineIn.Click, BB_OrderDelivery.Click
        Dim a As New Bunifu.UI.WinForms.BunifuButton.BunifuButton
        a = sender
        RefreshListTable(CInt(a.Tag))
    End Sub

    Sub View_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _ServerID As Integer)



        OrderID = _OrderId
        Label_OrderNo.Text = _OrderNo
        RefreshData()

        XtraTabControl.SelectedTabPage = XtraTabPage_ChooseMenu
    End Sub
    Sub Recall_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _isClosed As Boolean)

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
            'ElseIf (e.Item.Name.ToString = "CBMove") Then
            '    Move_Command()
            'ElseIf (e.Item.Name.ToString = "CBSplit") Then
            '    Split_Command(_OrderID, _OrderNo, _TableID, _TableName, _OrderTypeID)
            'ElseIf (e.Item.Name.ToString = "CBBill") Then
            '    Combine_Command(_OrderID, _OrderNo, _TableID, _TableName, _OrderTypeID)
            'ElseIf (e.Item.Name.ToString = "CBVoid") Then
            '    Void_Command()
        End If

    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click


        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BE_MenuType_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs)
        FlyoutPanel2.ShowPopup()
    End Sub

    Private Sub BE_MenuCategory_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs)
        FlyoutPanel3.ShowPopup()
    End Sub

    Private Sub GV_OrderDetail_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GV_OrderDetail.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim menuItemUpdateQty As New DXMenuItem("Update Qty",
          AddressOf OnUpdateQty)
            menuItemUpdateQty.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemUpdateQty)
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

    Private Sub TV_MenuType_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_MenuType.ItemClick
        _MenuTypeID = TV_MenuType.GetFocusedRowCellValue(colID_TVType).ToString
        _MenuCategoryID = 0
        TV_MenuCategory.ActiveFilterString = "(MenuTypeID = " + _MenuTypeID.ToString + ")"
        TileView_Menu.ActiveFilterString = "(MenuTypeID = " + _MenuTypeID.ToString + ")"
        Ed_Keyword.EditValue = ""

    End Sub

    Private Sub TV_MenuCategory_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_MenuCategory.ItemClick
        _MenuCategoryID = TV_MenuCategory.GetFocusedRowCellValue(colID_TVCategory).ToString
        'TileView_Menu.ActiveFilterString = "(MenuCategoryID = " + TileView_Category.GetFocusedRowCellValue(colID_Category).ToString + ")"
        Ed_Keyword.EditValue = ""

        TileView_Menu.ActiveFilterString = "(MenuCategoryID = " + _MenuCategoryID.ToString + " )"




    End Sub

    Private Sub Ed_Payment_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_Payment.EditValueChanged

        Ed_Charge.EditValue = (Ed_Payment.EditValue + Ed_CardValue.EditValue) - CInt(Label_Total.Tag)

    End Sub

End Class