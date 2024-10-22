Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class Frm_Core


    Dim _OrderID As Integer
    Dim _ServerID As Integer

    Dim UserModified As String = ""
    Dim ButtonCheck As Integer = 1


    Dim ds_type, ds_category As DataTable

    Private Sub PE_New_Click(sender As Object, e As EventArgs) Handles PE_New.Click
        RadioGroup_OrderType.DeselectAll()
        'SearchLookUpEdit_Server.Visible = True
        RadioGroup_OrderType.SelectedIndex = -1
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub PE_Exit_Click(sender As Object, e As EventArgs) Handles PE_Exit.Click
        Me.Close()
    End Sub

    Public Sub OpenForm(ByVal FormName As Object)
        If FormName Is Nothing Then Exit Sub

        If Me.MdiChildren.Length = 0 Then
            'Ini kalau belum terbuka
            FormName.MdiParent = Me
            '   FormName.WindowState = FormWindowState.Maximized
            FormName.Show()
        Else
            Dim a As Object() = Me.MdiChildren
            For i As Byte = 0 To a.GetUpperBound(0)
                If FormName.Name = a(i).name Then
                    a(i).focus()
                    Exit Sub

                End If
            Next
            FormName.MdiParent = Me
            FormName.WindowState = FormWindowState.Maximized
            FormName.Show()
        End If
        'FormNameStaticItem.Caption = FormName.Text & " " & FormName.ProductVersion
    End Sub

    Private Sub Frm_Core_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.View_POS_MenuCategory_FrontList' table. You can move, or remove it, as needed.
        Me.View_POS_MenuCategory_FrontListTableAdapter.Fill(Me.DataSet.View_POS_MenuCategory_FrontList)
        'TODO: This line of code loads data into the 'DataSet.View_MenuType_List' table. You can move, or remove it, as needed.
        Me.View_MenuType_ListTableAdapter.Fill(Me.DataSet.View_MenuType_List)
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetServerList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetServerListTableAdapter.Fill(Me.DataSet.sp_POS_GetServerList)
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetTableList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)

        Panel_Order.Dock = DockStyle.Fill

        Me.View_MenuType_ListTableAdapter.Fill(Me.DataSet.View_MenuType_List)
        Me.View_POS_MenuCategory_FrontListTableAdapter.Fill(Me.DataSet.View_POS_MenuCategory_FrontList)
        ds_type = View_MenuType_ListTableAdapter.GetData
        ds_category = View_POS_MenuCategory_FrontListTableAdapter.GetData


        'OpenForm(getForm(TCode, Me, getServerType(TCode), getDatabaseType(TCode), strSource, ribbonControl, My.Settings.UserName, strAppPath, strWarehouse, strCropYear))
        Dim _Form As XtraForm
        _Form = New Frm_Order()
        'OpenForm(_Form)
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

    Sub RefreshListTable(ByVal _OrderType As Integer)
        Me.Sp_POS_OrderHeader_GetListTableAdapter.Fill(Me.DataSet.sp_POS_OrderHeader_GetList, _OrderType)

        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)

    End Sub

    Private Sub BB_OrderAll_Click(sender As Object, e As EventArgs) Handles BB_OrderAll.Click, BB_OrderTakeAway.Click, BB_OrderOther.Click, BB_OrderDineIn.Click, BB_OrderDelivery.Click
        Dim a As New Bunifu.UI.WinForms.BunifuButton.BunifuButton
        a = sender
        RefreshListTable(CInt(a.Tag))
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

    Sub View_Command(ByVal _OrderId As Integer, ByVal _OrderNo As String, ByVal _TableID As Integer, ByVal _TableName As String, ByVal _OrderTypeID As Integer, ByVal _ServerID As Integer)

        Dim a As DevExpress.XtraEditors.XtraForm
        a = New Frm_ChooseServer(Me.DataSet.sp_POS_GetServerList, _ServerID)
        a.ShowDialog()
        If (a.DialogResult = DialogResult.OK) Then
            Dim FrmFront As DevExpress.XtraEditors.XtraForm
            FrmFront = New Frm_Front(_OrderId, _OrderNo, _TableID, _TableName, _OrderTypeID, _ServerID, ds_type, ds_category)
            FrmFront.MdiParent = Me
            FrmFront.Show()
            Panel_Order.Visible = False
            'FrmFront.ShowDialog()
            'If (FrmFront.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            '    FrmFront.Close()
            '    RefreshListTable(CInt(ButtonCheck))

            '    Panel_Order.Visible = True
            'End If
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
        '    FlyoutPanel1.ShowPopup()
    End Sub

End Class