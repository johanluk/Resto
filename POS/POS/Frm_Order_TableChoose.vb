Imports System.Math
Imports System.IO
Imports DevExpress.XtraEditors.Controls



Public Class Frm_Order_TableChoose



    Dim OrderTypeID As Integer
    Dim ParamName As String

    Dim OrderID As Integer
    Dim OrderNo As String
    Dim TableID As Integer
    Dim TableName As String

    Public WithEvents newButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents newPanel As DevExpress.XtraEditors.PanelControl
    Public WithEvents newPictureEdit As DevExpress.XtraEditors.PictureEdit

    Dim newOff As DevExpress.XtraBars.Navigation.NavigationBarItem



    Private Sub Frm_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Shape_Header.Left = 10
        'Shape_Header.Top = 5
        LabelControl1.Width = Me.Width - 100
        'LabelControl1.Top = 15
        'LabelControl1.Height = 30
        Me.Sp_POS_MDTableFloor_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDTableFloor_GetData)
        RefreshFloor()
        Me.Sp_POS_MDTable_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDTable_GetData, GV_Floor.GetRowCellValue(0, colFloor))

        '    Label_FloorName.Text = GV_Floor.GetRowCellValue(0, colFloor)

        RefreshTable()


        Label_FlyOutPanel.Left = (PanelControl1.Width - Label_FlyOutPanel.Width) / 2
        Sp_POS_MDTable_GetDataGridControl.Top = 2000
        Sp_POS_MDTableFloor_GetDataGridControl.Top = 2000

        Dt_Order.DateTime = Now
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OrderType As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        OrderTypeID = OrderType
        Label_User.Text = My.Settings.UserName
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OrderType As Integer, ByVal ParamNameTemp As String)

        ' This call is required by the designer.
        InitializeComponent()
        OrderTypeID = OrderType
        ParamName = ParamNameTemp
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub RefreshFloor()

        OfficeNavigationBar1.Items.Clear()
        For i = 0 To GV_Floor.RowCount - 1

            newOff = New DevExpress.XtraBars.Navigation.NavigationBarItem
            newOff.Tag = GV_Floor.GetRowCellValue(i, colFloor)
            newOff.Text = GV_Floor.GetRowCellValue(i, colFloor).ToString
            OfficeNavigationBar1.Items.Add(newOff)
            'newButton = New DevExpress.XtraEditors.SimpleButton
            'newButton.Name = "Bt_Floor_" & i
            'newButton.Top = 52 * Floor(((i - 1) / Floor(Panel_Floor.Width / 52))) + 2
            'newButton.Left = 102 * ((i - 1) Mod Floor(Panel_Floor.Width / 102)) + 2
            'newButton.Width = 100
            'newButton.Height = 50

            'newButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            'newButton.Appearance.BackColor = Color.Red
            'newButton.Appearance.BackColor2 = Color.Transparent
            'newButton.Appearance.GradientMode = Drawing2D.LinearGradientMode.Vertical
            'newButton.Text = GV_Floor.GetRowCellValue(i - 1, colFloor)
            'newButton.Tag = GV_Floor.GetRowCellValue(i - 1, colFloor)
            'newButton.Font = New Font(newButton.Font.FontFamily, 12, newButton.Font.Style)

            'AddHandler newButton.Click, AddressOf Me.ButtonFloor_Click
            'Me.Panel_Floor.Controls.Add(Me.newButton)
        Next
    End Sub
    Private Sub ButtonFloor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For i As Integer = Me.Panel_TableView.Controls.Count - 1 To 0 Step -1
            Dim ctrl = Me.Panel_TableView.Controls(i)

            If TypeOf (ctrl) Is DevExpress.XtraEditors.SimpleButton Then
                ctrl.Dispose()           '' NOTE: disposing the control also removes it
            End If
        Next
        '     Label_FloorName.Text = sender.text
        Me.Sp_POS_MDTable_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDTable_GetData, sender.tag)

        RefreshTable()



    End Sub

    Public Sub RefreshTable()

        Dim StringToDraw As String = "Hi there!! :-)"
        Dim MyBrush As New SolidBrush(Color.Black)
        Dim StringFont As New Font("Arial", 20)
        Dim PixelsAcross As Integer = 0
        Dim PixelsDown As Integer = 0
        Dim g As Graphics
        Try
            For i = Me.PanelControl1.Controls.Count - 1 To 0 Step -1
                Dim ctrl = Me.PanelControl1.Controls(i)

                If TypeOf (ctrl) Is DevExpress.XtraEditors.PictureEdit Then
                    ctrl.Dispose()           '' NOTE: disposing the control also removes it
                End If
            Next

            For i = 0 To GV_Table.RowCount - 1

                '---
                newPictureEdit = New DevExpress.XtraEditors.PictureEdit
                newPictureEdit.Name = "PictureEdit_" & i
                newPictureEdit.Text = i
                newPictureEdit.Top = GV_Table.GetRowCellValue(i, colY)
                newPictureEdit.Left = GV_Table.GetRowCellValue(i, colX)
                newPictureEdit.Width = GV_Table.GetRowCellValue(i, colWidth)
                newPictureEdit.Height = GV_Table.GetRowCellValue(i, colLength)
                newPictureEdit.Tag = i
                ' newPictureEdit.Tag = GV_Table.GetRowCellValue(i, colID_Table)

                newPictureEdit.Properties.AllowFocused = False
                newPictureEdit.BackColor = Color.Transparent
                newPictureEdit.BorderStyle = BorderStyles.NoBorder
                newPictureEdit.Properties.SizeMode = PictureSizeMode.Zoom

                newPictureEdit.ShowToolTips = True
                newPictureEdit.ToolTip = GV_Table.GetRowCellValue(i, colTableName_Table)
                '   newPanel.BorderStyle = BorderStyles.NoBorder
                If (IsDBNull(GV_Table.GetRowCellValue(i, colDefaultImage)) = False) Then
                    If (GV_Table.GetRowCellValue(i, colisUsed) = True) Then
                        newPictureEdit.Image = ByteToImage(GV_Table.GetRowCellValue(i, colActiveImage))
                    Else
                        newPictureEdit.Image = ByteToImage(GV_Table.GetRowCellValue(i, colDefaultImage))
                    End If
                    newPictureEdit.SendToBack()


                End If



                AddHandler newPictureEdit.Click, AddressOf Me.ButtonTable_Click

                Me.Panel_TableView.Controls.Add(Me.newPictureEdit)

            Next
        Catch ex As Exception
            AlertControl1.Show(Me, "Error on Save Data", ex.Message)
        End Try


        ' For i = 0 To GV_Table.RowCount - 1
        'newButton = New DevExpress.XtraEditors.SimpleButton
        'newButton.Name = "Bt_" & i
        'newButton.Text = i
        'newButton.Top = 102 * Floor(((i) / Floor(Panel_TableView.Width / 102))) + 2
        'newButton.Left = 102 * ((i) Mod Floor(Panel_TableView.Width / 102)) + 2
        'newButton.Width = 100
        'newButton.Height = 100

        'newButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        'newButton.Appearance.BackColor = Color.Blue
        'newButton.Appearance.GradientMode = Drawing2D.LinearGradientMode.Vertical
        'newButton.Text = GV_Table.GetRowCellValue(i, colTableName_Table)
        'newButton.Tag = GV_Table.GetRowCellValue(i, colID_Table)
        'newButton.Font = New Font(newButton.Font.FontFamily, 12, newButton.Font.Style)

        'AddHandler newButton.Click, AddressOf Me.ButtonTable_Click

        'Me.Panel_TableView.Controls.Add(Me.newButton)
        '  Next
    End Sub


    Public Shared Function ByteToImage(blob As Byte()) As Bitmap
        Dim mStream As New MemoryStream()
        Dim pData As Byte() = blob
        mStream.Write(pData, 0, Convert.ToInt32(pData.Length))
        Dim bm As New Bitmap(mStream, False)
        mStream.Dispose()
        Return bm

    End Function

    Private Sub ButtonTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        TableID = GV_Table.GetRowCellValue(sender.tag, colID_Table)
        TableName = GV_Table.GetRowCellValue(sender.tag, colTableName_Table)
        OrderID = Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderID(Today, TableID)
        OrderNo = Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderNo(Today, TableID).ToString


        LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        If (OrderTypeID = 11) Then
            LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        End If
        FlyoutPanel1.ShowPopup()

    End Sub

    'Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick


    '    Me.Panel_TableView.Controls.Clear()
    'End Sub

    Private Sub SB_Close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub OfficeNavigationBar1_ItemClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs) Handles OfficeNavigationBar1.ItemClick
        '     Label_FloorName.Text = e.Item.Text
        Me.Sp_POS_MDTable_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDTable_GetData, e.Item.Tag)

        RefreshTable()
    End Sub

    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click

        If (Ed_GuestName.EditValue <> "" And Ed_NumberOfGuest.EditValue > 0) Then
            NextProcess(Ed_GuestName.EditValue, Ed_NumberOfGuest.EditValue)

        Else
            MessageBox.Show("Data Tidak Lengkap")

        End If
    End Sub

    Sub NextProcess(ByVal TempGuestName As String, ByVal TempNoGuest As Integer)


        If (OrderTypeID = 11) Then

            OrderID = Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderID(Dt_Order.DateTime, TableID)
            OrderNo = Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderNo(Dt_Order.DateTime, TableID).ToString
        End If

        Dim FrmMenu As DevExpress.XtraEditors.XtraForm
        If (OrderTypeID = 11) Then
            FrmMenu = New Frm_Front_old(OrderID, OrderNo, TableID, TableName, OrderTypeID, TempGuestName, TempNoGuest, Dt_Order.DateTime, Dt_Order.DateTime, "Dine In")
        Else
            FrmMenu = New Frm_Front_old(OrderID, OrderNo, TableID, TableName, OrderTypeID, TempGuestName, TempNoGuest, "Dine In")
        End If

        FrmMenu.ShowDialog()
        If (FrmMenu.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmMenu.Close()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub SB_Cancel_Click(sender As Object, e As EventArgs) Handles SB_Cancel.Click
        FlyoutPanel1.HidePopup()
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Frm_Order_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown


    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click
        Dim StringToDraw As String = "Hi there!! :-)"
        Dim MyBrush As New SolidBrush(Color.White)
        Dim StringFont As New Font("Arial", 12)
        Dim PixelsAcross As Integer = 0
        Dim PixelsDown As Integer = 0
        Dim g As Graphics
        Dim TName As String
        For i = Me.Panel_TableView.Controls.Count - 1 To 0 Step -1
            Dim ctrl = Me.Panel_TableView.Controls(i)

            If TypeOf (ctrl) Is DevExpress.XtraEditors.PictureEdit Then
                g = ctrl.CreateGraphics()
                TName = GV_Table.GetRowCellValue(ctrl.Tag, colTableName_Table)
                g.DrawString(TName, StringFont, MyBrush, 8, ctrl.Height / 2 - 14)

                '' NOTE: disposing the control also removes it
            End If
        Next
    End Sub
End Class