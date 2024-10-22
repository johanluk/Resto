Imports System.Math
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI


Public Class Frm_OrderCashier

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



    Public Sub New(ByVal parent As DevExpress.XtraBars.Ribbon.RibbonForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal ACEConn As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon


        My.Settings.Item("ConnectionString") = ConnString
        My.Settings.Item("ACE_ConnectionString") = ACEConn

    End Sub




#End Region

    Dim GV_OrderRow As Integer
    Dim TableID As Integer
    Dim TableName As String
    Dim OrderID As Integer
    Dim OrderNo As String
    Dim OrderTypeID As Integer

    Dim isClosed As Integer = 0

    Dim EmployeeID As Integer

    Public WithEvents newPanel As DevExpress.XtraEditors.PanelControl

    Public WithEvents newPanel1 As DevExpress.XtraEditors.PanelControl

    Public WithEvents newCheckButton As DevExpress.XtraEditors.CheckButton
    Public WithEvents newLabel As System.Windows.Forms.Label


    Public Sub New()




        ' This call is required by the designer.
        InitializeComponent()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        EmployeeID = 0
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(ByVal TempEmployeeID As Integer, ByVal TempEmployeeName As String)

        ' This call is required by the designer.
        InitializeComponent()

        EmployeeID = TempEmployeeID
        Label_Employee.Text = TempEmployeeName
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Frm_Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_MDOrderType_GetData' table. You can move, or remove it, as needed.
        Me.Sp_POS_MDOrderType_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDOrderType_GetData)
        Me.Sp_POS_MDVoidReason_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDVoidReason_GetData, 0)
        TV_OrderList.OptionsTiles.ItemSize = New Size(Panel_Main.Width / 2 - 20, 120)

        Try

            Me.Sp_POS_MDTable_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDTable_GetData, 0)
            Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailCheck_GetDataHeader, 99)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try




    End Sub




    Private Sub SB_DineIn_Click(sender As Object, e As EventArgs) Handles SB_DineIn.Click
        Dim FrmOrder As DevExpress.XtraEditors.XtraForm
        FrmOrder = New Frm_Order_TableChoose(1)
        FrmOrder.ShowDialog()
        If (FrmOrder.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmOrder.Close()
        End If

    End Sub

    Private Sub SB_TakeAway_Click(sender As Object, e As EventArgs) Handles SB_TakeAway.Click
        Dim FrmKeyboard As DevExpress.XtraEditors.XtraForm
        FrmKeyboard = New Frm_Keyboard(2)
        FrmKeyboard.ShowDialog()
        If (FrmKeyboard.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmKeyboard.Close()
        End If
    End Sub

    Private Sub CB_Tr_Click(sender As Object, e As EventArgs)
        'For i As Integer = Me.Panel_View.Controls.Count - 1 To 0 Step -1
        '    Dim ctrl = Me.Panel_View.Controls(i)


        '    If TypeOf (ctrl) Is DevExpress.XtraEditors.CheckButton Then
        '        newCheckButton = ctrl
        '        newCheckButton.Checked = False
        '        '' NOTE: disposing the control also removes it
        '    End If
        'Next

        Try
            sender.checked = False

            Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailCheck_GetDataHeader, CInt(sender.tag))

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub FlyoutPanelControl_DoubleClick(sender As Object, e As EventArgs) Handles FlyoutPanelControl.DoubleClick

    End Sub
    Sub View_Command()
        Dim FrmFront As DevExpress.XtraEditors.XtraForm
        FrmFront = New Frm_Front_old(OrderID, OrderNo, TableID, TableName, OrderTypeID)
        FrmFront.ShowDialog()
        If (FrmFront.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmFront.Close()
        End If
    End Sub

    Sub Recall_Command()
        If (My.Settings.PositionID = "5" Or My.Settings.PositionID = "6") Then

            Dim FrmFront As DevExpress.XtraEditors.XtraForm
            FrmFront = New Frm_Front_old(OrderID, OrderNo, TableID, TableName, OrderTypeID)
            FrmFront.ShowDialog()
            If (FrmFront.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmFront.Close()

            End If
        Else
            Dim FrmPayment As DevExpress.XtraEditors.XtraForm
            FrmPayment = New Frm_Payment(OrderID, OrderNo, TableID, TableName, OrderTypeID, isClosed)
            FrmPayment.ShowDialog()
            If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmPayment.Close()
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Sub Move_Command()
        FlyoutPanel2.ShowPopup()
    End Sub

    Sub Split_Command()
        Dim FrmSplit As DevExpress.XtraEditors.XtraForm
        FrmSplit = New Frm_BillSplit(OrderID, OrderNo, TableID, TableName, OrderTypeID)
        FrmSplit.ShowDialog()
        If (FrmSplit.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmSplit.Close()
        End If
    End Sub

    Sub Combine_Command()
        Dim FrmCombine As DevExpress.XtraEditors.XtraForm
        FrmCombine = New Frm_BillCombine(OrderID, OrderNo, TableID, TableName, OrderTypeID)
        FrmCombine.ShowDialog()
        If (FrmCombine.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmCombine.Close()
        End If
    End Sub

    Sub Void_Command()
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub SB_Reservation_Click(sender As Object, e As EventArgs)
        Dim FrmOrder As DevExpress.XtraEditors.XtraForm
        FrmOrder = New Frm_Order_TableChoose(11)
        FrmOrder.ShowDialog()
        If (FrmOrder.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmOrder.Close()

            'Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailCheck_GetDataHeader, 99)


        End If
    End Sub

    Private Sub SB_Close_Click(sender As Object, e As EventArgs)

        ' Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub TileNavItem_Order_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles TileNavCategory_OrderDineIn.ElementClick, TileNavCategory_OrderDelivery.ElementClick, TileNavCategory_OrderTakeAway.ElementClick, TileNavCategory_OrderReservation.ElementClick, TileNavCategory_OrderOpen.ElementClick, TileNavCategory_OrderOneDay.ElementClick, TileNavCategory_OrderUpcoming.ElementClick
        Try

            Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailCheck_GetDataHeader, CInt(sender.tag))

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub NavButton_LogOut_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles NavButton_LogOut.ElementClick
        Me.Dispose()

        Frm_User.Ed_UserName.EditValue = ""
        Frm_User.Ed_Key.EditValue = ""
        Frm_User.newEdit = Frm_User.Ed_UserName
    End Sub

    Private Sub SB_Delivery_Click(sender As Object, e As EventArgs) Handles SB_Delivery.Click
        Dim FrmCustomerEnter As DevExpress.XtraEditors.XtraForm
        FrmCustomerEnter = New Frm_CustomerEnter()
        FrmCustomerEnter.ShowDialog()
        If (FrmCustomerEnter.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmCustomerEnter.Close()
        End If
    End Sub

    Private Sub SB_UpdateTable_Click(sender As Object, e As EventArgs) Handles SB_UpdateTable.Click
        Dim Query As String
        Query = "UPDATE T_ORDERHEADER SET TableID = " + LookUpEdit_Table.EditValue.ToString + ", TableName = '" + LookUpEdit_Table.Text.ToString + "'  Where ID = " + OrderID.ToString
        Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)

        FlyoutPanel2.HidePopup()

        Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailCheck_GetDataHeader, 99)
    End Sub

    Private Sub SB_BookOrder_Click(sender As Object, e As EventArgs) Handles SB_BookOrder.Click
        Dim FrmOrder As DevExpress.XtraEditors.XtraForm
        FrmOrder = New Frm_Order_TableChoose(11)
        FrmOrder.ShowDialog()
        If (FrmOrder.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmOrder.Close()
        End If
    End Sub

    Private Sub SB_OneDaySummary_Click(sender As Object, e As EventArgs) Handles SB_OneDaySummary.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport



        report = New Rpt_OneDayCash(Today, My.Settings.UserName, System.Environment.GetEnvironmentVariable("COMPUTERNAME"))
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()

            ' printTool.Print()
            ' printTool.Print(My.Settings.PrinterDocument)
        End Using
        report.Dispose()
    End Sub

    Private Sub TV_OrderList_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles TV_OrderList.ItemClick
       
        ''FlyoutPanel1.OwnerControl = sender

        ''FlyoutPanel2.OwnerControl = sender

        'OrderID = e.Item.Elements(1).ToString
        'OrderNo = e.Item.Elements(0).ToString
        'TableID = e.Item.Elements(2).ToString
        'TableName = e.Item.Elements(3).ToString
        'OrderTypeID = e.Item.Elements(8).ToString

    End Sub

    Private Sub TV_OrderList_ContextButtonClick(sender As Object, e As DevExpress.Utils.ContextItemClickEventArgs) Handles TV_OrderList.ContextButtonClick

        OrderID = TV_OrderList.GetRowCellValue(e.DataItem.rowhandle, colID)
        OrderNo = TV_OrderList.GetRowCellValue(e.DataItem.rowhandle, colOrderNo)
        TableID = TV_OrderList.GetRowCellValue(e.DataItem.rowhandle, colTableID)
        TableName = TV_OrderList.GetRowCellValue(e.DataItem.rowhandle, colTableName)
        OrderTypeID = TV_OrderList.GetRowCellValue(e.DataItem.rowhandle, colOrderTypeID)
        If (e.Item.Name.ToString = "View") Then
            If (CBool(TV_OrderList.GetRowCellValue(e.DataItem.rowhandle, colisClosed)) = False) Then
                View_Command()
            Else
                Recall_Command()
            End If
        ElseIf (e.Item.Name.ToString = "Move") Then
            Move_Command()
        ElseIf (e.Item.Name.ToString = "Split") Then
            Split_Command()
        ElseIf (e.Item.Name.ToString = "Combine") Then
            Combine_Command()
        ElseIf (e.Item.Name.ToString = "Void") Then
            Void_Command()
        End If
    End Sub

    Private Sub TV_OrderList_ItemCustomize(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs) Handles TV_OrderList.ItemCustomize
        Try
            If (CBool(TV_OrderList.GetRowCellValue(e.RowHandle, colisClosed)) = True) Then

                e.Item.Elements(9).Appearance.Normal.BackColor = Color.FromArgb(194, 59, 34)
                e.Item.Elements(9).Appearance.Normal.BackColor2 = Color.FromArgb(&H94, &H23, &HE)
                e.Item.Elements(9).Appearance.Normal.GradientMode = Drawing2D.LinearGradientMode.Vertical
                ' TV_Menu.Appearance.ItemNormal.BackColor
            Else
                e.Item.Elements(9).Appearance.Normal.BackColor = Color.FromArgb(119, 190, 119)
                e.Item.Elements(9).Appearance.Normal.BackColor2 = Color.FromArgb(&H2B, &H75, &H2B)
                e.Item.Elements(9).Appearance.Normal.GradientMode = Drawing2D.LinearGradientMode.Vertical
                'TV_Menu.TileTemplate.Item(ii).Appearance.Normal.BackColor = Color.FromArgb(207, 207, 196)
            End If

            isClosed = IIf((CBool(TV_OrderList.GetRowCellValue(e.RowHandle, colisPrinted)) = True), 1, 0)
            My.Settings.isPrinted = isClosed
        Catch
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Time.Text = TimeOfDay
    End Sub

    Private Sub SB_VoidSubmit_Click(sender As Object, e As EventArgs) Handles SB_VoidSubmit.Click
        If (MsgBox("Anda Yakin Ingin Void Order?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then

            Dim Query As String
          
            Query = "UPDATE T_ORDERDETAIL SET isVoid = 1 , VoidOrderReasonID = " + LookUpEdit_VoidReason.EditValue.ToString +
                   " ,ModifiedDate = GETDATE(), ModifiedUser = '" + My.Settings.UserName +
                   "' Where ID = " + OrderID.ToString
            Me.QueriesTableAdapter.sp_DynamicQuery_UpdData(0, "", "", "", Query)

        End If

        FlyoutPanel1.HidePopup()
    End Sub

    Private Sub SB_CancelMove_Click(sender As Object, e As EventArgs) Handles SB_CancelMove.Click
        FlyoutPanel2.HidePopup()
    End Sub

    Private Sub SB_CancelVoid_Click(sender As Object, e As EventArgs) Handles SB_CancelVoid.Click
        FlyoutPanel1.HidePopup()
    End Sub
End Class