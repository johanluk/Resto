Imports DevExpress.Utils.Menu
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class Frm_Purchasing




    Dim editor_Inv, editor_Sup As TextEdit
    Dim RowFocus As Integer

    Dim UserModified As String
    Dim isNew As Boolean = False

    Dim TempUoM As Integer = 0


    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub 'New
        Public View As GridView
        Public RowHandle As Integer
    End Class


    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl



    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub

    Public Sub New()
        InitializeComponent()
        DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
        DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)
    End Sub

    'Public Sub New(ByVal ConnString As String, ByVal Source As String, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "")
    '    ' This call is required by the designer.
    '    InitializeComponent()


    '    My.Settings.Username = Username
    '    My.Settings.Item("ConnectionString") = ConnString
    '    MRNoTextEdit.Tag = 0
    '    DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
    '    DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)
    '    DataSet.sp_SPMaterialReceiveHeader_GetData.Columns("ID").DefaultValue = 0
    '    DataSet.sp_SPMaterialReceiveHeader_GetData.Columns("MRNo").DefaultValue = "AUTO"

    '    DataSet.sp_SPMaterialReceiveHeader_GetData.Columns("MRDate").DefaultValue = Today

    'End Sub
    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.


        My.Settings.UserName = Username
        My.Settings.Item("ConnectionString") = ConnString
        InitializeComponent()
        frmParentInfo = parent
        parentribbonx = parentribbon

        MRNoTextEdit.Tag = 0
        DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
        DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)
        'DataSet.sp_SPMaterialReceiveHeader_GetData.Columns("ID").DefaultValue = 0
        Dataset.sp_SPPurchaseReceiveHeader_GetData.Columns("PRVNo").DefaultValue = "AUTO"

        Dataset.sp_SPPurchaseReceiveHeader_GetData.Columns("PRVDate").DefaultValue = Today

    End Sub

    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function


    Private Sub Frm_Purchasing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dataset.sp_LookUpData_GetInventory' table. You can move, or remove it, as needed.
        Me.Sp_LookUpData_GetInventoryTableAdapter.Fill(Me.Dataset.sp_LookUpData_GetInventory)
        'TODO: This line of code loads data into the 'Dataset.sp_LookUpData_GetSupplier' table. You can move, or remove it, as needed.
        Me.Sp_LookUpData_GetSupplierTableAdapter.Fill(Me.Dataset.sp_LookUpData_GetSupplier)

        Me.Sp_SPPurchaseReceiveDetail_GetPOInvTableAdapter.Fill(Me.Dataset.sp_SPPurchaseReceiveDetail_GetPOInv, 0)

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "/" & My.Settings.UserName
        Dataset.sp_SPPurchaseReceiveDetail_GetData.Columns("ModifiedUser").DefaultValue = UserModified
        Dataset.sp_SPPurchaseReceiveHeader_GetData.Columns("ModifiedUser").DefaultValue = UserModified
    End Sub


    Private Sub SB_RefreshHeader_Click(sender As Object, e As EventArgs) Handles SB_RefreshHeader.Click
        FillDataAdapter_Header()
    End Sub
    Sub FillDataAdapter_Header()
        Try
            Me.Sp_SPPurchaseReceiveHeader_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseReceiveHeader_GetData, (DateEditStart.DateTime), (DateEditEnd.DateTime))

            '   Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub GV_Header_RowClick(sender As Object, e As RowClickEventArgs) Handles GV_Header.RowClick
        RowFocus = e.RowHandle
    End Sub

    Private Sub SB_NewTransaction_Click(sender As Object, e As EventArgs) Handles SB_NewTransaction.Click

        Try

            Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseReceiveDetail_GetData, -1)
            Sp_SPPurchaseReceiveHeader_GetDataBindingSource.AddNew()
            DisplayDetail()
            MRNoTextEdit.EditValue = "AUTO"

            MRDateDateEdit.DateTime = Now

            GV_Detail.OptionsView.NewItemRowPosition = NewItemRowPosition.Top

            LCItem_CreateNew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCItem_SBContinue.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCItem_SaveUpdateHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCGroup_Supplier.Enabled = True
            SB_AddSupplier.Enabled = True
            CE_PPn.Checked = False
            'Sp_SPMaterialReceiveDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetail_GetData, -1)
            isNew = True

        Catch ex As Exception
            AlertControl.Show(Me, "New Procedure", ex.Message)
        End Try


    End Sub

    Private Sub GV_Header_DoubleClick(sender As Object, e As EventArgs) Handles GV_Header.DoubleClick

        GV_Detail.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
        Sp_SPPurchaseReceiveDetail_GetDataTableAdapter.Fill(Me.Dataset.sp_SPPurchaseReceiveDetail_GetData, CInt(GV_Header.GetRowCellValue(GV_Header.GetSelectedRows(0), colID_Header)))


        DisplayDetail()

        SB_AddSupplier.Enabled = False
        LCGroup_Supplier.Enabled = False

        LCItem_SBContinue.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LCItem_CreateNew.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LCItem_SaveUpdateHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        isNew = False



    End Sub


    Sub DisplayHome()
        LCGroup_Det.Expanded = False
        LCGroup_Header.Expanded = True
    End Sub

    Private Sub SB_Continue_Click(sender As Object, e As EventArgs) Handles SB_Continue.Click


        Try

            If IsDBNull(SearchLookUpEdit_Supplier.EditValue) Then
                AlertControl.Show(Me, "Error on Input Data", "Supplier masih belum terisi")
                Exit Sub
            End If
            MRNoTextEdit.EditValue = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(1, "AUTO", 23, MRDateDateEdit.DateTime)


            Me.Sp_SPPurchaseReceiveHeader_GetDataBindingSource.EndEdit()
            Me.Validate()
            Me.TableAdapterManager.UpdateAll(Me.Dataset)

            MRNoTextEdit.Tag = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(0, MRNoTextEdit.EditValue.ToString, 23, MRDateDateEdit.DateTime)
            'Sp_SPPurchase_GetInventoryDataTableAdapter.Fill(Me.DataSet.sp_SPPurchase_GetInventoryData, 23, 0, CInt(IIf(IsDBNull(SearchLookUpEdit1.EditValue), 0, SearchLookUpEdit1.EditValue)))

            '  Sp_SPMaterialReceiveHeader_GetDataGridControl.DataSource = Me.Sp_SPMaterialReceiveHeader_GetDataBindingSource
            'Me.Sp_SPMaterialReceiveHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveHeader_GetData, (MRDateDateEdit.DateTime), (MRDateDateEdit.DateTime))
            isNew = True


            LCItem_SBContinue.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCItem_SaveUpdateHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LCGroup_Supplier.Enabled = False


        Catch ex As Exception
            AlertControl.Show(Me, "Error on Input Data", ex.Message)
        End Try
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Sp_SPPurchaseReceiveDetail_GetDataBindingSource.CancelEdit()
        Sp_SPPurchaseReceiveHeader_GetDataBindingSource.CancelEdit()

        DisplayHome()
    End Sub


    '--------------------------- Detail


    Private Sub GV_DetailPO_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GV_DetailPO.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle()
            e.Menu.Items.Clear()

            Dim menuDetail As New DXMenuItem("&Masukkan Pesanan",
          AddressOf OnImport, ImageCollection.Images(0))
            menuDetail.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuDetail)

        Else


        End If
    End Sub

    Sub OnImport(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_DetailPO.FocusedRowHandle

    End Sub


    Sub DisplayDetail()
        LCGroup_Det.Expanded = True
        LCGroup_Header.Expanded = False
    End Sub
End Class