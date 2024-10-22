Public Class Frm_BillSplit

#Region "Variables"

    Private UserModified As String


    Dim AlertParamName As String
    Dim AlertParamEditName As String
#End Region

    Private dt1, dt2, dt3, dt4 As DataTable
    Private TempGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Private TempGridViewFocusedRow As Integer
    Private TempGridQty As DevExpress.XtraGrid.Columns.GridColumn
    Private TempGridSubTotal As DevExpress.XtraGrid.Columns.GridColumn

    Dim ProcessStatus As Boolean = False
    Dim OrderID As Integer
    Dim OrderIDNew As Integer
    Dim OrderNo As String
    Dim TableID As Integer
    Dim TableName As String
    Dim OrderTypeID As Integer
    Dim SB_SplitButton As Integer

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

        Panel_Check1.Width = ((Me.Width - 6) / 4)
        Panel_Check1.Left = 0
        Panel_Check2.Width = ((Me.Width - 6) / 4)
        Panel_Check2.Left = Panel_Check1.Left + Panel_Check1.Width + 2
        Panel_Check3.Width = ((Me.Width - 6) / 4)
        Panel_Check3.Left = Panel_Check2.Left + Panel_Check2.Width + 2
        Panel_Check4.Width = ((Me.Width - 6) / 4)
        Panel_Check4.Left = Panel_Check3.Left + Panel_Check3.Width + 2

        Panel_Check1.Height = Me.Height
        Panel_Check2.Height = Me.Height
        Panel_Check3.Height = Me.Height
        Panel_Check4.Height = Me.Height

        '   GridControl1.DataSource = dt2

        SB_Process.Width = Panel_Payment1.Width - SB_Process.Left - 4
        SB2_Process.Width = Panel_Payment2.Width - SB2_Process.Left - 4
        SB3_Process.Width = Panel_Payment3.Width - SB3_Process.Left - 4
        SB4_Process.Width = Panel_Payment4.Width - SB4_Process.Left - 4


        SB_Payment.Width = Panel_Payment1.Width - SB_Payment.Left - 4
        SB2_Payment.Width = Panel_Payment2.Width - SB2_Payment.Left - 4
        SB3_Payment.Width = Panel_Payment3.Width - SB3_Payment.Left - 4
        SB4_Payment.Width = Panel_Payment4.Width - SB4_Payment.Left - 4

        SB_Reset.Width = Panel_Control.Width - SB_Reset.Left - 4

        Sp_POSOrderDetail_CombinePreviewGetDataGridControl.Top = 2000

        ' Me.Sp_POSOrderDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_GetData, OrderID)

        Try
            Me.Sp_POSOrderDetail_CombinePreviewGetDataTableAdapter.Fill(Me.DataSet.sp_POSOrderDetail_CombinePreviewGetData, OrderID.ToString, 0) ' OrderID.ToString)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
        Label_OrderNo1.Text = OrderNo

        SettingGridControl()


        Dim OrderNoNew = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", "",
                                                                        "select top 1 orderNo from T_OrderHeader order by ID DESC")


        Dim SeqNumber As Integer
        SeqNumber = CInt(OrderNoNew.ToString.Substring(Len(OrderNoNew) - 3, 3))
        Label_OrderNo2.Text = OrderNoNew.ToString.Substring(0, Len(OrderNoNew) - 3) + Format(SeqNumber + 1, "000")
        Label_OrderNo3.Text = OrderNoNew.ToString.Substring(0, Len(OrderNoNew) - 3) + Format(SeqNumber + 2, "000")
        Label_OrderNo4.Text = OrderNoNew.ToString.Substring(0, Len(OrderNoNew) - 3) + Format(SeqNumber + 3, "000")
        LoadDefaultCheck()



    End Sub

    Sub SettingGridControl()
        dt1 = New DataTable
        dt1.Columns.Add("ID1")
        dt1.Columns.Add("Qty1")
        dt1.Columns.Add("MenuName1")
        dt1.Columns.Add("Price1")
        dt1.Columns.Add("SubTotal1")

        GridControl1.DataSource = dt1

        GVCheck1.Columns("ID1").Visible = False
        GVCheck1.Columns("Qty1").OptionsColumn.AllowEdit = False
        GVCheck1.Columns("Qty1").OptionsColumn.AllowFocus = False
        GVCheck1.Columns("Qty1").Caption = "#"
        GVCheck1.Columns("Qty1").Width = 40
        GVCheck1.Columns("MenuName1").OptionsColumn.AllowEdit = False
        GVCheck1.Columns("MenuName1").OptionsColumn.AllowFocus = False
        GVCheck1.Columns("Price1").Visible = False
        GVCheck1.Columns("Price1").ColumnEdit = RepositoryItemTextEdit_Num1
        GVCheck1.Columns("SubTotal1").OptionsColumn.AllowEdit = False
        GVCheck1.Columns("SubTotal1").OptionsColumn.AllowFocus = False
        GVCheck1.Columns("SubTotal1").ColumnEdit = RepositoryItemTextEdit_Num1
        GVCheck1.Columns("SubTotal1").Width = 100

        GVCheck1.OptionsView.ShowIndicator = False
        GVCheck1.OptionsView.ShowDetailButtons = False
        GVCheck1.OptionsView.ShowGroupPanel = False
        GVCheck1.OptionsView.ShowHorizontalLines = False


        dt2 = New DataTable
        dt2.Columns.Add("ID2")
        dt2.Columns.Add("Qty2")
        dt2.Columns.Add("MenuName2")
        dt2.Columns.Add("Price2")
        dt2.Columns.Add("SubTotal2")

        GridControl2.DataSource = dt2

        GVCheck2.Columns("ID2").Visible = False
        GVCheck2.Columns("Qty2").OptionsColumn.AllowEdit = False
        GVCheck2.Columns("Qty2").OptionsColumn.AllowFocus = False
        GVCheck2.Columns("Qty2").Caption = "#"
        GVCheck2.Columns("Qty2").Width = 40
        GVCheck2.Columns("MenuName2").OptionsColumn.AllowEdit = False
        GVCheck2.Columns("MenuName2").OptionsColumn.AllowFocus = False
        GVCheck2.Columns("MenuName2").Caption = "Nama Menu"
        GVCheck2.Columns("Price2").Visible = False
        GVCheck2.Columns("Price2").ColumnEdit = RepositoryItemTextEdit_Num2
        GVCheck2.Columns("SubTotal2").OptionsColumn.AllowEdit = False
        GVCheck2.Columns("SubTotal2").OptionsColumn.AllowFocus = False
        GVCheck2.Columns("SubTotal2").Caption = "Total"
        GVCheck2.Columns("SubTotal2").Width = 100
        GVCheck2.Columns("SubTotal2").ColumnEdit = RepositoryItemTextEdit_Num2

        GVCheck2.OptionsView.ShowIndicator = False
        GVCheck2.OptionsView.ShowDetailButtons = False
        GVCheck2.OptionsView.ShowGroupPanel = False
        GVCheck2.OptionsView.ShowHorizontalLines = False


        dt3 = New DataTable
        dt3.Columns.Add("ID3")
        dt3.Columns.Add("Qty3")
        dt3.Columns.Add("MenuName3")
        dt3.Columns.Add("Price3")
        dt3.Columns.Add("SubTotal3")

        GridControl3.DataSource = dt3

        GVCheck3.Columns("ID3").Visible = False
        GVCheck3.Columns("Qty3").OptionsColumn.AllowEdit = False
        GVCheck3.Columns("Qty3").OptionsColumn.AllowFocus = False
        GVCheck3.Columns("Qty3").Caption = "#"
        GVCheck3.Columns("Qty3").Width = 40
        GVCheck3.Columns("MenuName3").OptionsColumn.AllowEdit = False
        GVCheck3.Columns("MenuName3").OptionsColumn.AllowFocus = False
        GVCheck3.Columns("MenuName3").Caption = "Nama Menu"
        GVCheck3.Columns("Price3").Visible = False
        GVCheck3.Columns("Price3").ColumnEdit = RepositoryItemTextEdit_Num3
        GVCheck3.Columns("SubTotal3").OptionsColumn.AllowEdit = False
        GVCheck3.Columns("SubTotal3").OptionsColumn.AllowFocus = False
        GVCheck3.Columns("SubTotal3").ColumnEdit = RepositoryItemTextEdit_Num3
        GVCheck3.Columns("SubTotal3").Caption = "Total"
        GVCheck3.Columns("SubTotal3").Width = 100

        GVCheck3.OptionsView.ShowIndicator = False
        GVCheck3.OptionsView.ShowDetailButtons = False
        GVCheck3.OptionsView.ShowGroupPanel = False
        GVCheck3.OptionsView.ShowHorizontalLines = False


        dt4 = New DataTable
        dt4.Columns.Add("ID4")
        dt4.Columns.Add("Qty4")
        dt4.Columns.Add("MenuName4")
        dt4.Columns.Add("Price4")
        dt4.Columns.Add("SubTotal4")

        GridControl4.DataSource = dt4

        GVCheck4.Columns("ID4").Visible = False
        GVCheck4.Columns("Qty4").OptionsColumn.AllowEdit = False
        GVCheck4.Columns("Qty4").OptionsColumn.AllowFocus = False
        GVCheck4.Columns("Qty4").Caption = "#"
        GVCheck4.Columns("Qty4").Width = 40
        GVCheck4.Columns("MenuName4").OptionsColumn.AllowEdit = False
        GVCheck4.Columns("MenuName4").OptionsColumn.AllowFocus = False
        GVCheck4.Columns("MenuName4").Caption = "Nama Menu"
        GVCheck4.Columns("Price4").Visible = False
        GVCheck4.Columns("Price4").ColumnEdit = RepositoryItemTextEdit_Num4
        GVCheck4.Columns("SubTotal4").OptionsColumn.AllowEdit = False
        GVCheck4.Columns("SubTotal4").OptionsColumn.AllowFocus = False
        GVCheck4.Columns("SubTotal4").ColumnEdit = RepositoryItemTextEdit_Num4
        GVCheck4.Columns("SubTotal4").Caption = "Total"
        GVCheck4.Columns("SubTotal4").Width = 100

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
            dr(3) = GVOrder.GetRowCellValue(row, colPrice)
            dr(4) = GVOrder.GetRowCellValue(row, colSubTotal)
            dt1.Rows.Add(dr)

            GridControl1.DataSource = dt1

        Next
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Me.Close()
    End Sub

    Private Sub SB1_Payment_Click(sender As Object, e As EventArgs) Handles SB_Payment.Click


        Dim FrmPayment As DevExpress.XtraEditors.XtraForm
        FrmPayment = New Frm_Payment(OrderID, Label_OrderNo1.Text, TableID, TableName, OrderTypeID, 0)
        FrmPayment.ShowDialog()
        If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
            FrmPayment.Close()

        End If
    End Sub

    Private Sub SB_Reset_Click(sender As Object, e As EventArgs) Handles SB_Reset.Click
        If (ProcessStatus) Then
            MessageBox.Show("Split Process Telah dilakukan")
        Else

            dt1.Clear()
            dt2.Clear()
            dt3.Clear()
            dt4.Clear()
            LoadDefaultCheck()
        End If

    End Sub

    Private Sub SB2_Payment_Click(sender As Object, e As EventArgs) Handles SB2_Payment.Click
        Try
            ProcessStatus = True
            Dim FrmPayment As DevExpress.XtraEditors.XtraForm
            FrmPayment = New Frm_Payment(OrderIDNew, Label_OrderNo2.Text, TableID, TableName, OrderTypeID, 0)
            FrmPayment.ShowDialog()
            If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmPayment.Close()
                LCGroup_PanelCheck2.Enabled = False
            End If
        Catch
        End Try

    End Sub

    Private Sub SB_Split_Click(sender As Object, e As EventArgs) Handles SB_Split1.Click, SB_Split4.Click, SB_Split3.Click, SB_Split2.Click
        SB_SplitButton = sender.Tag
        If (SB_SplitButton = 1) Then
            TempGridView = GVCheck1
            TempGridViewFocusedRow = GVCheck1.FocusedRowHandle
            TempGridQty = GVCheck1.Columns("Qty1")
            TempGridSubTotal = GVCheck1.Columns("SubTotal1")
            CB_1.Enabled = False

            Label_FlyOutMenuID.Text = GVCheck1.GetRowCellValue(GVCheck1.FocusedRowHandle, "ID1")
            Label_FlyOutMaxQty.Text = GVCheck1.GetRowCellValue(GVCheck1.FocusedRowHandle, "Qty1")
            Label_FlyOutMenuName.Text = GVCheck1.GetRowCellValue(GVCheck1.FocusedRowHandle, "MenuName1")
            Label_FlyOutPrice.Text = GVCheck1.GetRowCellValue(GVCheck1.FocusedRowHandle, "Price1")
        ElseIf (SB_SplitButton = 2) Then
            TempGridView = GVCheck2
            TempGridViewFocusedRow = GVCheck2.FocusedRowHandle
            TempGridQty = GVCheck2.Columns("Qty2")
            TempGridSubTotal = GVCheck2.Columns("SubTotal2")
            CB_2.Enabled = False

            Label_FlyOutMenuID.Text = GVCheck2.GetRowCellValue(GVCheck2.FocusedRowHandle, "ID2")
            Label_FlyOutMaxQty.Text = GVCheck2.GetRowCellValue(GVCheck2.FocusedRowHandle, "Qty2")
            Label_FlyOutMenuName.Text = GVCheck2.GetRowCellValue(GVCheck2.FocusedRowHandle, "MenuName2")
            Label_FlyOutPrice.Text = GVCheck2.GetRowCellValue(GVCheck2.FocusedRowHandle, "Price2")
        ElseIf (SB_SplitButton = 3) Then
            TempGridView = GVCheck3
            TempGridViewFocusedRow = GVCheck3.FocusedRowHandle
            TempGridQty = GVCheck3.Columns("Qty3")
            TempGridSubTotal = GVCheck3.Columns("SubTotal3")
            CB_3.Enabled = False

            Label_FlyOutMenuID.Text = GVCheck3.GetRowCellValue(GVCheck3.FocusedRowHandle, "ID3")
            Label_FlyOutMaxQty.Text = GVCheck3.GetRowCellValue(GVCheck3.FocusedRowHandle, "Qty3")
            Label_FlyOutMenuName.Text = GVCheck3.GetRowCellValue(GVCheck3.FocusedRowHandle, "MenuName3")
            Label_FlyOutPrice.Text = GVCheck3.GetRowCellValue(GVCheck3.FocusedRowHandle, "Price3")
        ElseIf (SB_SplitButton = 4) Then
            TempGridView = GVCheck4
            TempGridViewFocusedRow = GVCheck4.FocusedRowHandle
            TempGridQty = GVCheck4.Columns("Qty4")
            TempGridSubTotal = GVCheck4.Columns("SubTotal4")
            CB_4.Enabled = False

            Label_FlyOutMenuID.Text = GVCheck4.GetRowCellValue(GVCheck4.FocusedRowHandle, "ID4")
            Label_FlyOutMaxQty.Text = GVCheck4.GetRowCellValue(GVCheck4.FocusedRowHandle, "Qty4")
            Label_FlyOutMenuName.Text = GVCheck4.GetRowCellValue(GVCheck4.FocusedRowHandle, "MenuName4")
            Label_FlyOutPrice.Text = GVCheck4.GetRowCellValue(GVCheck4.FocusedRowHandle, "Price4")
        End If

        SpinEdit_FlyOutQty.EditValue = 0
        SpinEdit_FlyOutQty.Properties.MinValue = 0
        SpinEdit_FlyOutQty.Properties.MaxValue = CInt(Label_FlyOutMaxQty.Text)
        SpinEdit_FlyOutQty.Focus()
        FlyoutPanel1.ShowPopup()
    End Sub

    Private Sub SB_FlyoutCancel_Click(sender As Object, e As EventArgs) Handles SB_FlyoutCancel.Click
        If (SB_SplitButton = 1) Then
            CB_1.Enabled = True
        ElseIf (SB_SplitButton = 2) Then
            CB_2.Enabled = True
        ElseIf (SB_SplitButton = 3) Then
            CB_3.Enabled = True
        ElseIf (SB_SplitButton = 4) Then
            CB_4.Enabled = True
        End If
        FlyoutPanel1.HidePopup()
    End Sub

    Private Sub SB_FlyoutSubmit_Click(sender As Object, e As EventArgs) Handles SB_FlyoutSubmit.Click
        Dim ValueExist As Boolean = False
        Dim RowValueExist As Integer = 0
        If (SpinEdit_FlyOutQty.EditValue = 0) Then
            MessageBox.Show("Masih kosong")
            SB_FlyoutCancel.PerformClick()
            Exit Sub

        End If
        If (CInt(SpinEdit_FlyOutQty.EditValue) > CInt(Label_FlyOutMaxQty.Text)) Then
            MessageBox.Show("Melebihi")
            SB_FlyoutCancel.PerformClick()
            Exit Sub

        End If
        If (CB_1.Checked) Then
            For i As Integer = 0 To GVCheck1.RowCount Step 1
                If (GVCheck1.GetRowCellValue(i, "ID1") = Label_FlyOutMenuID.Text) Then
                    ValueExist = True
                    RowValueExist = i
                End If
            Next
            If (ValueExist) Then
                GVCheck1.SetRowCellValue(RowValueExist, "Qty1", GVCheck1.GetRowCellValue(RowValueExist, "Qty1") + CInt(SpinEdit_FlyOutQty.EditValue))
                GVCheck1.SetRowCellValue(RowValueExist, "SubTotal1", (GVCheck1.GetRowCellValue(RowValueExist, "Qty1") + CInt(SpinEdit_FlyOutQty.EditValue)) * CInt(Label_FlyOutPrice.Text))

                SB_Process.Enabled = True
                SB_Payment.Enabled = False
            Else
                Dim dr As DataRow = dt1.NewRow()
                dr(0) = Label_FlyOutMenuID.Text
                dr(1) = SpinEdit_FlyOutQty.EditValue
                dr(2) = Label_FlyOutMenuName.Text
                dr(3) = Label_FlyOutPrice.Text
                dr(4) = (CInt(SpinEdit_FlyOutQty.EditValue) * CInt(Label_FlyOutPrice.Text)).ToString
                dt1.Rows.Add(dr)
                GridControl1.DataSource = dt1

                SB_Process.Enabled = True
                SB_Payment.Enabled = False
            End If

        ElseIf (CB_2.Checked) Then
            For i As Integer = 0 To GVCheck2.RowCount Step 1
                If (GVCheck2.GetRowCellValue(i, "ID2") = Label_FlyOutMenuID.Text) Then
                    ValueExist = True
                    RowValueExist = i
                End If
            Next
            If (ValueExist) Then
                GVCheck2.SetRowCellValue(RowValueExist, "Qty2", GVCheck2.GetRowCellValue(RowValueExist, "Qty2") + CInt(SpinEdit_FlyOutQty.EditValue))
                GVCheck2.SetRowCellValue(RowValueExist, "SubTotal2", (GVCheck2.GetRowCellValue(RowValueExist, "Qty2") + CInt(SpinEdit_FlyOutQty.EditValue)) * CInt(Label_FlyOutPrice.Text))

                SB2_Process.Enabled = True
                SB2_Payment.Enabled = False
            Else
                Dim dr As DataRow = dt2.NewRow()
                dr(0) = Label_FlyOutMenuID.Text
                dr(1) = SpinEdit_FlyOutQty.EditValue
                dr(2) = Label_FlyOutMenuName.Text
                dr(3) = Label_FlyOutPrice.Text
                dr(4) = (CInt(SpinEdit_FlyOutQty.EditValue) * CInt(Label_FlyOutPrice.Text)).ToString
                dt2.Rows.Add(dr)
                GridControl2.DataSource = dt2

                SB2_Process.Enabled = True
                SB2_Payment.Enabled = False
            End If
        ElseIf (CB_3.Checked) Then
            For i As Integer = 0 To GVCheck3.RowCount Step 1
                If (GVCheck3.GetRowCellValue(i, "ID3") = Label_FlyOutMenuID.Text) Then
                    ValueExist = True
                    RowValueExist = i
                End If
            Next
            If (ValueExist) Then
                GVCheck3.SetRowCellValue(RowValueExist, "Qty3", GVCheck3.GetRowCellValue(RowValueExist, "Qty3") + CInt(SpinEdit_FlyOutQty.EditValue))
                GVCheck3.SetRowCellValue(RowValueExist, "SubTotal3", (GVCheck3.GetRowCellValue(RowValueExist, "Qty3") + CInt(SpinEdit_FlyOutQty.EditValue)) * CInt(Label_FlyOutPrice.Text))

                SB3_Process.Enabled = True
                SB3_Payment.Enabled = False
            Else
                Dim dr As DataRow = dt3.NewRow()
                dr(0) = Label_FlyOutMenuID.Text
                dr(1) = SpinEdit_FlyOutQty.EditValue
                dr(2) = Label_FlyOutMenuName.Text
                dr(3) = Label_FlyOutPrice.Text
                dr(4) = (CInt(SpinEdit_FlyOutQty.EditValue) * CInt(Label_FlyOutPrice.Text)).ToString
                dt3.Rows.Add(dr)
                GridControl3.DataSource = dt3

                SB3_Process.Enabled = True
                SB3_Payment.Enabled = False
            End If
        ElseIf (CB_4.Checked) Then
            For i As Integer = 0 To GVCheck4.RowCount Step 1
                If (GVCheck4.GetRowCellValue(i, "ID4") = Label_FlyOutMenuID.Text) Then
                    ValueExist = True
                    RowValueExist = i
                End If
            Next
            If (ValueExist) Then
                GVCheck4.SetRowCellValue(RowValueExist, "Qty4", GVCheck4.GetRowCellValue(RowValueExist, "Qty4") + CInt(SpinEdit_FlyOutQty.EditValue))
                GVCheck4.SetRowCellValue(RowValueExist, "SubTotal4", (GVCheck4.GetRowCellValue(RowValueExist, "Qty4") + CInt(SpinEdit_FlyOutQty.EditValue)) * CInt(Label_FlyOutPrice.Text))

                SB4_Process.Enabled = True
                SB4_Payment.Enabled = False

            Else
                Dim dr As DataRow = dt4.NewRow()
                dr(0) = Label_FlyOutMenuID.Text
                dr(1) = SpinEdit_FlyOutQty.EditValue
                dr(2) = Label_FlyOutMenuName.Text
                dr(3) = Label_FlyOutPrice.Text
                dr(4) = (CInt(SpinEdit_FlyOutQty.EditValue) * CInt(Label_FlyOutPrice.Text)).ToString
                dt4.Rows.Add(dr)
                GridControl4.DataSource = dt4

                SB4_Process.Enabled = True
                SB4_Payment.Enabled = False
            End If
        End If
        TempGridView.SetRowCellValue(TempGridViewFocusedRow, TempGridQty, CInt(Label_FlyOutMaxQty.Text) - SpinEdit_FlyOutQty.EditValue)
        TempGridView.SetRowCellValue(TempGridViewFocusedRow, TempGridSubTotal, (CInt(Label_FlyOutMaxQty.Text) - SpinEdit_FlyOutQty.EditValue) * CInt(Label_FlyOutPrice.Text))

        SB_Process.Enabled = True
        SB_Payment.Enabled = False

        If (SB_SplitButton = 1) Then
            CB_1.Enabled = True
        ElseIf (SB_SplitButton = 2) Then
            CB_2.Enabled = True
        ElseIf (SB_SplitButton = 3) Then
            CB_3.Enabled = True
        ElseIf (SB_SplitButton = 4) Then
            CB_4.Enabled = True
        End If
        FlyoutPanel1.HidePopup()
    End Sub

    Private Sub FlyoutPanel1_ButtonClick(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs)
        MessageBox.Show(e.Button.Tag.ToString)
    End Sub

    Private Sub SB_Process_Click(sender As Object, e As EventArgs) Handles SB_Process.Click
        If (SB2_Process.Enabled = False And SB3_Process.Enabled = False And SB4_Process.Enabled = False) Then

            SB_Process.Enabled = False
            SB_Payment.Enabled = True
            ProcessStatus = True
        Else
            MessageBox.Show("Masih Ada Order yang belum diproses")
        End If
    End Sub

    Private Sub SB2_Process_Click(sender As Object, e As EventArgs) Handles SB2_Process.Click
        Try

            SB2_Process.Enabled = False
            SB2_Payment.Enabled = True

            Me.QueriesTableAdapter.sp_POSOrderHeader_SplitCombineInsData(Label_OrderNo2.Text, Today, OrderTypeID, TableID, TableName, 0, 0, 0, OrderID, 0, UserModified)
            OrderIDNew = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", "",
                                                                      "select ID from T_OrderHeader where orderno = '" + Label_OrderNo2.Text + "'")

            For row As Integer = 0 To GVCheck2.RowCount - 1

                '         Me.QueriesTableAdapter.sp_POSOrderDetail_SplitDetailData(OrderIDNew, CInt(GVCheck2.GetRowCellValue(row, "ID2")), UserModified)
                Me.QueriesTableAdapter.sp_POSOrderDetail_SplitCombineInsUpdData(0, OrderID, OrderIDNew, CInt(GVCheck2.GetRowCellValue(row, "ID2")), CInt(GVCheck2.GetRowCellValue(row, "Qty2")), UserModified)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SB3_Process_Click(sender As Object, e As EventArgs) Handles SB3_Process.Click
        Try
            SB3_Process.Enabled = False
            SB3_Payment.Enabled = True

            Me.QueriesTableAdapter.sp_POSOrderHeader_SplitCombineInsData(Label_OrderNo3.Text, Today, OrderTypeID, TableID, TableName, 0, 0, 0, OrderID, 0, UserModified)
            OrderIDNew = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", "",
                                                                      "select ID from T_OrderHeader where orderno = '" + Label_OrderNo3.Text + "'")

            For row As Integer = 0 To GVCheck3.RowCount - 1

                '         Me.QueriesTableAdapter.sp_POSOrderDetail_SplitDetailData(OrderIDNew, CInt(GVCheck2.GetRowCellValue(row, "ID2")), UserModified)
                Me.QueriesTableAdapter.sp_POSOrderDetail_SplitCombineInsUpdData(0, OrderID, OrderIDNew, CInt(GVCheck3.GetRowCellValue(row, "ID3")), CInt(GVCheck3.GetRowCellValue(row, "Qty3")), UserModified)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SB4_Process_Click(sender As Object, e As EventArgs) Handles SB4_Process.Click
        Try
            SB4_Process.Enabled = False
            SB4_Payment.Enabled = True

            Me.QueriesTableAdapter.sp_POSOrderHeader_SplitCombineInsData(Label_OrderNo4.Text, Today, OrderTypeID, TableID, TableName, 0, 0, 0, OrderID, 0, UserModified)
            OrderIDNew = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", "",
                                                                      "select ID from T_OrderHeader where orderno = '" + Label_OrderNo4.Text + "'")

            For row As Integer = 0 To GVCheck4.RowCount - 1

                '         Me.QueriesTableAdapter.sp_POSOrderDetail_SplitDetailData(OrderIDNew, CInt(GVCheck2.GetRowCellValue(row, "ID2")), UserModified)
                Me.QueriesTableAdapter.sp_POSOrderDetail_SplitCombineInsUpdData(0, OrderID, OrderIDNew, CInt(GVCheck4.GetRowCellValue(row, "ID4")), CInt(GVCheck4.GetRowCellValue(row, "Qty4")), UserModified)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SB3_Payment_Click(sender As Object, e As EventArgs) Handles SB3_Payment.Click
        Try

            ProcessStatus = True

            Dim FrmPayment As DevExpress.XtraEditors.XtraForm
            FrmPayment = New Frm_Payment(OrderIDNew, Label_OrderNo3.Text, TableID, TableName, OrderTypeID, 0)
            FrmPayment.ShowDialog()
            If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmPayment.Close()
                LCGroup_PanelCheck3.Enabled = False
            End If
        Catch
        End Try

    End Sub

    Private Sub SB4_Payment_Click(sender As Object, e As EventArgs) Handles SB4_Payment.Click
        Try

            ProcessStatus = True

            Dim FrmPayment As DevExpress.XtraEditors.XtraForm
            FrmPayment = New Frm_Payment(OrderIDNew, Label_OrderNo4.Text, TableID, TableName, OrderTypeID, 0)
            FrmPayment.ShowDialog()
            If (FrmPayment.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmPayment.Close()
                LCGroup_PanelCheck4.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class