Imports System.Math
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI


Public Class Frm_OrderWaitress

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

        Label_DateTime.Text = Today.ToLongDateString
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(ByVal TempEmployeeID As Integer, ByVal TempEmployeeName As String)

        ' This call is required by the designer.
        InitializeComponent()

        EmployeeID = TempEmployeeID
        Label_Employee.Text = TempEmployeeName

        Label_DateTime.Text = Today.ToLongDateString
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Frm_OrderWaitress_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Sp_POSOrderDetailCheck_GetDataHeaderGridControl.Top = 2000
       
        RefreshData()

        Panel_List.Width = Panel_Main.Width - VScrollBar1.Width - 15

        RefreshOrderList()


     
    End Sub


    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Dim p As Point
        p = Panel_List.Location
        p.Y = 5 - e.NewValue
        Panel_List.Location = p
    End Sub


    Public Sub RefreshOrderList()

        For i As Integer = Me.Panel_List.Controls.Count - 1 To 0 Step -1
            Dim ctrl = Me.Panel_List.Controls(i)

            If TypeOf (ctrl) Is DevExpress.XtraEditors.PanelControl Then
                ctrl.Dispose()           '' NOTE: disposing the control also removes it
            End If
        Next


        For i = -1 To GV_Order.RowCount - 1
            If (i >= 0) Then
                newPanel = New DevExpress.XtraEditors.PanelControl
                newPanel.Name = "Panel_" & i
                newPanel.Text = i
                newPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
                newPanel.Appearance.GradientMode = Drawing2D.LinearGradientMode.Vertical

                newPanel.Dock = DockStyle.None

                newPanel.Height = 110
                newPanel.Width = Panel_List.Width / 2 - 5
                '   newButton.Left = 102 * ((i - 1) Mod Floor(Panel_MenuType.Width / 102)) + 2
                newPanel.Top = (newPanel.Height + 5) * Floor(i / 2)
                newPanel.Left = (i Mod 2) * (newPanel.Width + 5)
                '   newButton.Left = 102 * ((i - 1) Mod Floor(Panel_MenuType.Width / 102)) + 2

                newPanel.Tag = i

                'newButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
                'newButton.Appearance.BackColor = Color.LawnGreen
                'newButton.Appearance.GradientMode = Drawing2D.LinearGradientMode.Vertical
                'newButton.Text = GV_MenuType.GetRowCellValue(i - 1, colMenuTypeName_MenuType)
                'newButton.Tag = GV_MenuType.GetRowCellValue(i - 1, colID_MenuType)
                'newButton.Font = New Font(newButton.Font.FontFamily, 12, newButton.Font.Style)
                If (GV_Order.GetRowCellValue(i, colisClosed) = 0) Then
                    newPanel.Appearance.BackColor = Color.Green
                    newPanel.Appearance.BackColor2 = Color.GreenYellow
                Else
                    newPanel.Appearance.BackColor = Color.Red
                    newPanel.Appearance.BackColor2 = Color.DarkOrange
                End If


                Me.Panel_List.Controls.Add(Me.newPanel)


                'newPanel1 = New DevExpress.XtraEditors.PanelControl
                'newPanel1.Name = "PanelStatus_" & i


                'newPanel1.Dock = DockStyle.Left
                'newPanel1.Width = 50
                'If (GV_Order.GetRowCellValue(i, colisClosed) = 0) Then
                '    newPanel1.BackColor = Color.Green
                'Else
                '    newPanel1.BackColor = Color.Red
                'End If
                'newPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
                'Me.newPanel.Controls.Add(Me.newPanel1)


                newLabel = New System.Windows.Forms.Label
                newLabel.Name = "LabelTime_" & i
                newLabel.Text = String.Format("{0:dd MMM yyyy}", GV_Order.GetRowCellValue(i, colOrderDate))
                newLabel.Left = 200
                newLabel.Top = 20
                newLabel.AutoSize = True
                newLabel.Font = New Font(newLabel.Font.FontFamily, 15, newLabel.Font.Style)
                newLabel.BackColor = Color.Transparent

                Me.newPanel.Controls.Add(Me.newLabel)

                newLabel = New System.Windows.Forms.Label
                newLabel.Name = "LabelOrderNo_" & i
                newLabel.Text = GV_Order.GetRowCellValue(i, colOrderNo)
                newLabel.Tag = GV_Order.GetRowCellValue(i, colID)
                newLabel.Left = 10
                newLabel.Top = 20
                newLabel.AutoSize = True
                newLabel.BackColor = Color.Transparent
                newLabel.Font = New Font(newLabel.Font.FontFamily, 15, newLabel.Font.Style)

                Me.newPanel.Controls.Add(Me.newLabel)

                newLabel = New System.Windows.Forms.Label
                newLabel.Name = "LabelTableName_" & i
                newLabel.Text = GV_Order.GetRowCellValue(i, colTableName)
                newLabel.Tag = GV_Order.GetRowCellValue(i, colTableID)
                newLabel.Left = 10
                newLabel.Top = 60
                newLabel.AutoSize = True
                newLabel.BackColor = Color.Transparent
                newLabel.Font = New Font(newLabel.Font.FontFamily, 15, newLabel.Font.Style)

                Me.newPanel.Controls.Add(Me.newLabel)

                newLabel = New System.Windows.Forms.Label
                newLabel.Name = "LabelOrderType_" & i
                newLabel.Tag = GV_Order.GetRowCellValue(i, colOrderTypeID)
                If (newLabel.Tag = 1) Then
                    newLabel.Text = "Dine In"
                ElseIf (newLabel.Tag = 2) Then
                    newLabel.Text = "Take Away"
                ElseIf (newLabel.Tag = 3) Then
                    newLabel.Text = "Delivery"
                ElseIf (newLabel.Tag = 11) Then
                    newLabel.Text = "Reservation"
                Else
                    newLabel.Text = "Other"
                End If
                newLabel.Left = 400
                newLabel.Top = 20
                newLabel.AutoSize = True
                newLabel.BackColor = Color.Transparent
                newLabel.Font = New Font(newLabel.Font.FontFamily, 15, newLabel.Font.Style)

                Me.newPanel.Controls.Add(Me.newLabel)

                AddHandler newPanel.Click, AddressOf Me.Panel_Click


                RoundShapeAll(newPanel)

                Me.Panel_List.Controls.Add(Me.newPanel)
            End If
        Next

        Panel_List.Height = (Ceiling((GV_Order.RowCount) / 2)) * 120
        If (Panel_List.Height <= Panel_Main.Height) Then
            Panel_List.Height = Panel_Main.Height + 1
        End If

        VScrollBar1.Maximum = Panel_List.Height - Panel_Main.Height
        VScrollBar1.Value = 0
    End Sub


    Private Sub Panel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        newPanel = sender
        For i As Integer = Me.newPanel.Controls.Count - 1 To 0 Step -1
            Dim ctrl = Me.newPanel.Controls(i)

            If TypeOf (ctrl) Is System.Windows.Forms.Label And ctrl.Name = "LabelOrderNo_" + newPanel.Tag.ToString Then
                OrderID = ctrl.Tag
                OrderNo = ctrl.Text
            ElseIf TypeOf (ctrl) Is System.Windows.Forms.Label And ctrl.Name = "LabelTableName_" + newPanel.Tag.ToString Then
                TableID = ctrl.Tag
                TableName = ctrl.Text
            ElseIf TypeOf (ctrl) Is System.Windows.Forms.Label And ctrl.Name = "LabelOrderType_" + newPanel.Tag.ToString Then
                OrderTypeID = ctrl.Tag
            End If
        Next

        Dim FrmFront As DevExpress.XtraEditors.XtraForm
        FrmFront = New Frm_Front_old(OrderID, OrderNo, TableID, TableName, OrderTypeID)
        FrmFront.ShowDialog()
        If (FrmFront.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmFront.Dispose()

        End If

    End Sub


    Private Sub SB_DineIn_Click(sender As Object, e As EventArgs) Handles SB_DineIn.Click
        Dim FrmOrder As DevExpress.XtraEditors.XtraForm
        FrmOrder = New Frm_Order_TableChoose(1)
        FrmOrder.ShowDialog()
        If (FrmOrder.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmOrder.Close()
        End If
    End Sub


    Private Sub SB_LogOut_Click(sender As Object, e As EventArgs) Handles SB_LogOut.Click
        Me.Dispose()

        Frm_User.Ed_UserName.EditValue = ""
        Frm_User.Ed_Key.EditValue = ""

        Frm_User.newEdit = Frm_User.Ed_UserName
    End Sub


    Sub RefreshData()
        Try

            Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailCheck_GetDataHeader, 99)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub SB_NewOrder_Click(sender As Object, e As EventArgs) Handles SB_NewOrder.Click
        RefreshData()

        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub SB_TakeAway_Click(sender As Object, e As EventArgs) Handles SB_TakeAway.Click
        Dim FrmKeyboard As DevExpress.XtraEditors.XtraForm
        FrmKeyboard = New Frm_Keyboard(2)
        FrmKeyboard.ShowDialog()
        If (FrmKeyboard.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmKeyboard.Close()
        End If
    End Sub

    Private Sub SB_Delivery_Click(sender As Object, e As EventArgs) Handles SB_Delivery.Click
        Dim FrmCustomerEnter As DevExpress.XtraEditors.XtraForm
        FrmCustomerEnter = New Frm_CustomerEnter()
        FrmCustomerEnter.ShowDialog()
        If (FrmCustomerEnter.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmCustomerEnter.Close()
        End If
    End Sub

End Class