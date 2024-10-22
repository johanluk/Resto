Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraGrid.Views.Grid

Public Class Frm_MasterData

    Dim UserName As String

#Region "Variables"
    Private isNew As Boolean
    Dim isUpdate As Boolean = False
    Dim userModified As String
    Dim RowFocus As Integer
    Dim dt As DataTable


#End Region
    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl
    Public Sub New()
        InitializeComponent()
        NavigationFrame1.SelectedPage = NavigationPage1
        UserName = My.Settings.UserName
    End Sub

    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal _Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon

        My.Settings.Item("ConnectionString") = ConnString
        My.Settings.UserName = UserName
        NavigationFrame1.SelectedPage = NavigationPage1
        UserName = _Username
    End Sub

    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function

    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub 'New
        Public View As GridView
        Public RowHandle As Integer
    End Class
    Private Sub Frm_MasterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dataset.sp_LookUpData_GetUoM' table. You can move, or remove it, as needed.
        Me.Sp_LookUpData_GetUoMTableAdapter.Fill(Me.Dataset.sp_LookUpData_GetUoM)
        'TODO: This line of code loads data into the 'Dataset.sp_LookUpData_GetInventoryType' table. You can move, or remove it, as needed.
        Me.Sp_LookUpData_GetInventoryTypeTableAdapter.Fill(Me.Dataset.sp_LookUpData_GetInventoryType)
        'TODO: This line of code loads data into the 'Dataset.sp_MDInventory_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetData, 0)
    End Sub



    Private Sub FillDataAdapter()
        Try
            Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub GV_Inventory_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Inventory.ValidateRow
        Try
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            Me.Sp_MDInventory_GetDataBindingSource.EndEdit()
            Me.Validate()
            TableAdapterManager.UpdateAll(Me.Dataset)



        Catch ex As Exception
            AlertControl.Show(Me, "There is some error on transaction", ex.Message)
        End Try
        FillDataAdapter()

    End Sub


    Function ValidationCheck() As Boolean
        Return True
    End Function

    Private Sub SB_AddOpname_Click(sender As Object, e As EventArgs) Handles SB_AddOpname.Click
        Try

            Me.QueriesTableAdapter.sp_MDInventory_InsUpdOpname(0, CInt(Ed_QtyOpname.EditValue), CInt(Label_InventoryName.Tag), userModified)

            Ed_QtyOpname.EditValue = 0
            Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetData, 0)
            Label_InventoryName.Text = "Pilih Barang"
            Label_InventoryName.Tag = 0

            FlyoutPanel1.HidePopup()


            'Me.Sp_MDInventory_GetDataSyncList_DetailTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetDataSyncList_Detail, Label_InventoryName.Tag)
            'Me.Sp_MDInventory_GetDataSyncList_DetailTransactionTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetDataSyncList_DetailTransaction)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GV_Inventory_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GV_Inventory.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row And ((UserName = "sa") Or (UserName = "lia")) Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle()
            e.Menu.Items.Clear()
            Dim menuItemDeleteRow As New DXMenuItem("&Hapus Barang",
          AddressOf OnDeleteRowDetail, ImageCollection.Images(0))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemDeleteRow)
            Dim menuDetail As New DXMenuItem("&Detail Barang",
          AddressOf OnDetail, ImageCollection.Images(0))
            menuDetail.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuDetail)
            Dim menuItemStock As New DXMenuItem("&Stok Opname",
          AddressOf OnItemStock, ImageCollection.Images(0))
            menuItemStock.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemStock)
        Else
            Dim rowHandle As Integer = e.HitInfo.RowHandle()
            e.Menu.Items.Clear()
            Dim menuItemDeleteRow As New DXMenuItem("&Cetak Barcode",
          AddressOf OnDeleteRowDetail, ImageCollection.Images(0))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemDeleteRow)

        End If
    End Sub
    Sub OnDetail(ByVal sender As Object, ByVal e As EventArgs)
        Try

            RowFocus = GV_Inventory.FocusedRowHandle

            'Dim Frm_Detail As Frm_InvListDetail = New Frm_InvListDetail(GV_Inventory.GetRowCellValue(GV_Inventory.FocusedRowHandle(), colInventoryName).ToString,
            '                                                            CInt(GV_Inventory.GetRowCellValue(GV_Inventory.FocusedRowHandle(), colID)))
            'Frm_Detail.Show()

        Catch ex As Exception
            AlertControl.Show(Me, "Instruksi Gagal", ex.Message)
        End Try
    End Sub

    Sub OnItemStock(ByVal sender As Object, ByVal e As EventArgs)
        Try

            '   ToggleSwitch_Detail.IsOn = True
            RowFocus = GV_Inventory.FocusedRowHandle


            FlyoutPanel1.ShowPopup()
            Label_InventoryName.Text = GV_Inventory.GetRowCellValue(GV_Inventory.FocusedRowHandle(), colInventoryName).ToString
            Label_InventoryName.Tag = CInt(GV_Inventory.GetRowCellValue(GV_Inventory.FocusedRowHandle(), colID))

            'Me.Sp_MDInventory_GetDataSyncList_DetailTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetDataSyncList_Detail, Label_InventoryName.Tag)
            'Me.Sp_MDInventory_GetDataSyncList_DetailTransactionTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetDataSyncList_DetailTransaction)

            'FlyoutPanel1.ShowPopup()
        Catch ex As Exception
            AlertControl.Show(Me, "Instruksi Gagal", ex.Message)
        End Try
    End Sub

    Sub OnDeleteRowDetail(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Inventory.FocusedRowHandle
        Dim DeletedVar1 As String

        DeletedVar1 = GV_Inventory.GetRowCellValue(RowFocus, colDescription).ToString
        Try
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim info As RowInfo = CType(item.Tag, RowInfo)

            If MessageBox.Show("Benar Barang Ini Yang Anda Maksud?", "Confirmation", MessageBoxButtons.YesNoCancel) = MsgBoxResult.Yes Then
                ' info.View.DeleteRow(info.RowHandle)
                'Me.QueriesTableAdapter.sp_MDInventory_PrintBarcodeInsList(GV_Detail.GetRowCellValue(info.RowHandle, colBarcode),
                '                                                          GV_Detail.GetRowCellValue(info.RowHandle, colID),
                '                                                          GV_Detail.GetRowCellValue(info.RowHandle, colInventoryNo),

                'Dim row1 As String() = New String() {"1", "1", "1", "1", "1"}
                'GridView1.
                'Dim dr As DataRow = dt.NewRow()
                ''GridView1.AddNewRow()
                'dr(0) = GV_Detail.GetRowCellValue(info.RowHandle, colID)
                'dr(1) = GV_Detail.GetRowCellValue(info.RowHandle, colBarcode)
                'dr(2) = GV_Detail.GetRowCellValue(info.RowHandle, colInventoryNo)
                'dr(3) = GV_Detail.GetRowCellValue(info.RowHandle, colPrice)
                'dr(4) = 0
                'dt.Rows.Add(dr)
                'GridControl1.DataSource = dt

                GV_Inventory.DeleteSelectedRows()
                Me.Sp_MDInventory_GetDataBindingSource.EndEdit()
                Me.Validate()
                TableAdapterManager.UpdateAll(Me.Dataset)

                FillDataAdapter()

                'Me.QueriesTableAdapter.sp_MDInventory_PrintBarcodeInsList("",
                '                                                          CInt(GV_Inventory.GetRowCellValue(info.RowHandle, colID)),
                '                                                          GV_Inventory.GetRowCellValue(info.RowHandle, colInventoryNo).ToString,
                '                                                          0,
                '                                                          0,
                '                                                          userModified)
                'Me.Sp_MDInventory_PrintBarcodeListTableAdapter.Fill(Me.DataSet.sp_MDInventory_PrintBarcodeList)
                'Me.Validate()
                'Me.Sp_POS_CashierTransactionAdditional_GetDataBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.DataSet)
                'Me.Sp_POS_CashierTransactionAdditional_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_CashierTransactionAdditional_GetData, Dt_OrderDate.DateTime)
            Else
                'BtnRefresh.PerformClick()
                'AlertControl1.Show(Me, "Cancel on Delete Data", DeletedVar1)
            End If
            AlertControl.Show(Me, "Hapus Barang Berhasil", "")
        Catch ex As Exception
            AlertControl.Show(Me, "Hapus Barang Gagal", ex.Message)
        End Try
    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        Try
            Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class