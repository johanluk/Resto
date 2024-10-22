Imports System.Math

Public Class Frm_BillCombine

#Region "Variables"

    Private UserModified As String


    Dim AlertParamName As String
    Dim AlertParamEditName As String
#End Region

    Private dt1, dt2, dt3, dt4 As DataTable
    Dim aaa As Integer = 0
    Dim OrderID As Integer
    Dim OrderNo As String
    Dim TableID As Integer
    Dim TableName As String
    Dim OrderTypeID As Integer
    Dim Temp As String = ";"

    Public WithEvents newCheckButton As DevExpress.XtraEditors.CheckButton

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal VarOrderID As Integer, ByVal VarOrderNo As String, ByVal VarTableID As Integer, ByVal VarTableName As String, ByVal VarOrderTypeID As Integer)
        InitializeComponent()
        OrderID = VarOrderID
        OrderNo = VarOrderNo
        TableID = VarTableID
        TableName = VarTableName
        OrderTypeID = VarOrderTypeID

    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName


        '   Panel_Check2.Width = ((Me.Width - 6) / 4)
        '    Panel_Check2.Left = Panel_Check1.Left + Panel_Check1.Width + 2



        Panel_Check1.Height = Me.Height
        Panel_Check2.Height = Me.Height

        '   GridControl1.DataSource = dt2

        SB_Submit.Width = Panel_Control.Width - SB_Submit.Left - 4

        Try
            Me.Sp_POSOrderDetailCheck_GetDataHeaderTableAdapter.Fill(Me.DataSet.sp_POSOrderDetailCheck_GetDataHeader, 101)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        RefreshOrderList()

        '    Me.Sp_POSOrderDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_GetData, OrderID)

        Label_OrderNo1.Text = OrderNo

        SettingGridControl()

        CB_OriginMode.Checked = True
        CB_PreviewAll.Checked = False
        Try
            LoadPreview("")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub RefreshOrderList()

        For i As Integer = Me.PanelControl3.Controls.Count - 1 To 0 Step -1
            Dim ctrl = Me.PanelControl3.Controls(i)

            If TypeOf (ctrl) Is DevExpress.XtraEditors.PanelControl Then
                ctrl.Dispose()           '' NOTE: disposing the control also removes it
            End If
        Next
        Dim counter As Integer = 1
        For i = 1 To GridView2.RowCount
            If (i >= 0) Then
                newCheckButton = New DevExpress.XtraEditors.CheckButton
                newCheckButton.Font = CB_Template.Font
                newCheckButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
                newCheckButton.Name = "Bt_MenuCategory" & counter
                newCheckButton.Text = counter
                newCheckButton.Top = 2
                newCheckButton.Top = 102 * Floor(((counter - 1) / Floor(PanelControl3.Width / 202))) + 2
                newCheckButton.Left = 202 * ((counter - 1) Mod Floor(PanelControl3.Width / 202)) + 2
                newCheckButton.Width = 200
                newCheckButton.Height = 100
                newCheckButton.AllowFocus = False
                newCheckButton.Appearance.BackColor = Color.Green
                newCheckButton.Appearance.BackColor2 = Color.GreenYellow
                newCheckButton.Appearance.GradientMode = Drawing2D.LinearGradientMode.Vertical
                newCheckButton.Text = GridView2.GetRowCellValue(i - 1, colOrderNo) + vbNewLine + "ss"
                newCheckButton.Tag = GridView2.GetRowCellValue(i - 1, colID1)

                If (newCheckButton.Tag = OrderID) Then
                    newCheckButton.Visible = False
                Else
                    newCheckButton.Visible = True
                    counter += 1
                End If

                AddHandler newCheckButton.CheckedChanged, AddressOf Me.ListOrder_Click

                Me.PanelControl3.Controls.Add(Me.newCheckButton)


            End If
        Next
    End Sub
    Private Sub ListOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            LoadPreview("")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub LoadPreview(ByVal TempID As String)

        Temp = ""
        Try
            For i As Integer = Me.PanelControl3.Controls.Count - 1 To 1 Step -1
                Dim ctrl = Me.PanelControl3.Controls(i)

                If TypeOf (ctrl) Is DevExpress.XtraEditors.CheckButton Then
                    newCheckButton = ctrl
                    If (newCheckButton.Checked) Then
                        Temp = Temp + newCheckButton.Tag.ToString + ";"
                    End If
                    '' NOTE: disposing the control also removes it
                End If
            Next
            ' Temp = Temp + "'"
            '   Me.Sp_POSOrderDetail_CombinePreviewGetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_CombinePreviewGetData, Temp, 1)

            If (CB_PreviewAll.Checked) Then
                Temp = OrderID.ToString + ";" + Temp
                Me.Sp_POSOrderDetail_CombinePreviewGetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_CombinePreviewGetData, Temp, 1)

            Else
                If (CB_OriginMode.Checked) Then
                    Me.Sp_POSOrderDetail_CombinePreviewGetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_CombinePreviewGetData, OrderID.ToString + ";", 1)
                Else

                    Me.Sp_POSOrderDetail_CombinePreviewGetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_CombinePreviewGetData, Temp + ";", 1)

                End If

            End If
            dt4.Clear()
            For row As Integer = 0 To GridView3.RowCount - 1
                Dim dr As DataRow = dt4.NewRow()
                dr(0) = GridView3.GetRowCellValue(row, colID2)
                dr(1) = GridView3.GetRowCellValue(row, colQty1)
                dr(2) = GridView3.GetRowCellValue(row, colMenuName1)
                dr(3) = GridView3.GetRowCellValue(row, colSubTotal1)
                dt4.Rows.Add(dr)

                GridControl4.DataSource = dt4

            Next
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub

    Sub SettingGridControl()


        dt4 = New DataTable
        dt4.Columns.Add("ID4")
        dt4.Columns.Add("Qty4")
        dt4.Columns.Add("MenuName4")
        dt4.Columns.Add("SubTotal4")

        GridControl4.DataSource = dt4

        GVCheck4.Columns("ID4").Visible = False
        GVCheck4.Columns("Qty4").OptionsColumn.AllowEdit = False
        GVCheck4.Columns("Qty4").OptionsColumn.AllowFocus = False
        GVCheck4.Columns("Qty4").Width = 30
        GVCheck4.Columns("Qty4").Caption = "#"
        GVCheck4.Columns("Qty4").ColumnEdit = RepositoryItemTextEdit_Num
        GVCheck4.Columns("MenuName4").OptionsColumn.AllowEdit = False
        GVCheck4.Columns("MenuName4").OptionsColumn.AllowFocus = False
        GVCheck4.Columns("MenuName4").Width = 150
        GVCheck4.Columns("MenuName4").Caption = "Nama Menu"
        GVCheck4.Columns("SubTotal4").OptionsColumn.AllowEdit = False
        GVCheck4.Columns("SubTotal4").OptionsColumn.AllowFocus = False
        GVCheck4.Columns("SubTotal4").Width = 80
        GVCheck4.Columns("SubTotal4").Caption = "Total"
        GVCheck4.Columns("SubTotal4").ColumnEdit = RepositoryItemTextEdit_Num

        GVCheck4.OptionsView.ShowIndicator = False
        GVCheck4.OptionsView.ShowDetailButtons = False
        GVCheck4.OptionsView.ShowGroupPanel = False
        GVCheck4.OptionsView.ShowHorizontalLines = False
    End Sub

    Sub LoadDefaultCheck()
        For row As Integer = 0 To GVOrder.RowCount - 1
            Dim dr As DataRow = dt1.NewRow()
            dr(0) = GVOrder.GetRowCellValue(row, colID)
            dr(1) = GVOrder.GetRowCellValue(row, colQty)
            dr(2) = GVOrder.GetRowCellValue(row, colMenuName)
            dr(3) = GVOrder.GetRowCellValue(row, colSubTotal)
            dt1.Rows.Add(dr)

        Next
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Me.Close()
    End Sub

    Private Sub SB1_Payment_Click(sender As Object, e As EventArgs)
        Dim FrmPayment As DevExpress.XtraEditors.XtraForm
        FrmPayment = New Frm_Payment(OrderID, Label_OrderNo1.Text, TableID, TableName, OrderTypeID, 0)
        FrmPayment.ShowDialog()
        If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmPayment.Close()

        End If
    End Sub


    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click

        Me.QueriesTableAdapter.sp_POSOrderHeader_SplitCombineInsData(OrderNo, Today, OrderTypeID, TableID, TableName, 0, 0, 0, 0, 0, UserModified)

        Dim Temp As String = OrderID.ToString + ";"
        Try
            For i As Integer = Me.PanelControl3.Controls.Count - 1 To 1 Step -1
                Dim ctrl = Me.PanelControl3.Controls(i)

                If TypeOf (ctrl) Is DevExpress.XtraEditors.CheckButton Then
                    newCheckButton = ctrl
                    If (newCheckButton.Checked) Then
                        Temp = Temp + newCheckButton.Tag.ToString + ";"
                    End If
                    '' NOTE: disposing the control also removes it
                End If
            Next
            ' Temp = Temp + "'"
            '   Me.Sp_POSOrderDetail_CombinePreviewGetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_CombinePreviewGetData, Temp, 1)
            Me.QueriesTableAdapter.sp_POSOrderDetail_SplitCombineInsUpdData(1, Temp, OrderID, 0, 0, UserModified)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Dim FrmPayment As DevExpress.XtraEditors.XtraForm
        'FrmPayment = New Frm_Payment(OrderID, OrderNo, TableID, TableName, OrderTypeID, 0)
        'FrmPayment.ShowDialog()
        'If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '    FrmPayment.Close()
        '    Me.Close()
        'End If

        Me.Close()
        'Me.QueriesTableAdapter.sp_POSOrderHeader_InsData(Label_OrderNo2.Text, Today, OrderTypeID, TableID, TableName, 0, 0, 0, UserModified)
        'OrderIDNew = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", "",
        '                                                          "select ID from T_OrderHeader where orderno = '" + Label_OrderNo2.Text + "'")

        'For row As Integer = 0 To GVCheck2.RowCount - 1

        '    Me.QueriesTableAdapter.sp_POSOrderDetail_SplitDetailData(OrderIDNew, CInt(GVCheck2.GetRowCellValue(row, "ID2")), UserModified)

        'Next
        'Dim FrmPayment As DevExpress.XtraEditors.XtraForm
        'FrmPayment = New Frm_Payment(OrderIDNew, Label_OrderNo2.Text, TableID, TableName, OrderTypeID)
        'FrmPayment.ShowDialog()
        'If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
        '    FrmPayment.Close()

        'End If
    End Sub


    Private Sub SB_SelectAll_Click(sender As Object, e As EventArgs) Handles SB_SelectAll.Click
        Try
            For i As Integer = Me.PanelControl3.Controls.Count - 1 To 1 Step -1
                Dim ctrl = Me.PanelControl3.Controls(i)

                If TypeOf (ctrl) Is DevExpress.XtraEditors.CheckButton Then
                    newCheckButton = ctrl
                    newCheckButton.Checked = True
                End If
            Next
            LoadPreview("")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SB_DeselectAll_Click(sender As Object, e As EventArgs) Handles SB_DeselectAll.Click
        Try

            For i As Integer = Me.PanelControl3.Controls.Count - 1 To 1 Step -1
                Dim ctrl = Me.PanelControl3.Controls(i)

                If TypeOf (ctrl) Is DevExpress.XtraEditors.CheckButton Then
                    newCheckButton = ctrl
                    newCheckButton.Checked = False
                End If
            Next
            Temp = ";"
            LoadPreview("")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CB_PreviewAll_CheckedChanged(sender As Object, e As EventArgs)
        CB_OriginMode.Checked = True

    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        LoadPreview("")
    End Sub
End Class