Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class Frm_Customer

    Dim RowFocus As Integer

    Dim UserModified As String
    Dim isNew As Boolean = False
    Dim UserName As String

    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

    Public Sub New()

        InitializeComponent()


    End Sub
    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal _Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon

        My.Settings.Item("ConnectionString") = ConnString
        My.Settings.Username = _Username

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
    Private Sub Frm_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HomeLayout()
    End Sub

    Private Sub Sp_MDCustomer_GetDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Sp_MDCustomer_GetDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub
    Private Sub HomeLayout()
        XtraTabControl1.SelectedTabPageIndex = 0
        FillDataAdapter()
    End Sub

    Private Sub DetailLayout()
        XtraTabControl1.SelectedTabPageIndex = 1

    End Sub

    Private Sub FillDataAdapter()
        Try
            Me.Sp_MDCustomer_GetDataTableAdapter.Fill(Me.DataSet.sp_MDCustomer_GetData, 1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GV_Customer_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GV_Customer.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim menuItemDeleteRow As New DXMenuItem("&Lihat Detail",
          AddressOf OnDetailShowRow, ImageCollection.Images(0))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemDeleteRow)
        End If
    End Sub

    Sub OnDetailShowRow(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Customer.FocusedRowHandle
        Dim DeletedVar1 As String

        DeletedVar1 = GV_Customer.GetRowCellValue(RowFocus, colID).ToString
        Try

            DetailLayout()


            AlertControl.Show(Me, "Success on Delete Data", DeletedVar1)
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Delete Data", ex.Message)
        End Try
    End Sub

    Private Sub SB_SaveDetail_Click(sender As Object, e As EventArgs) Handles SB_SaveDetail.Click
        Try
            If (isNew) Then
                Me.Validate()
                Me.Sp_MDCustomer_GetDataBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSet)
            Else

                SaveData()
            End If
            HomeLayout()
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Submit Data", ex.Message)
        Finally


        End Try

    End Sub
    Function ValidationCheck() As Boolean

        DxErrorProvider.ClearErrors()
        'If (LookUpEdit_Warehouse.Text = "") Then
        '    DxErrorProvider.SetError(LookUpEdit_Warehouse, "Warehouse cannot be empty")
        'End If
        'If (SearchLookUpEdit_Supplier.Text = "") Then
        '    DxErrorProvider.SetError(SearchLookUpEdit_Supplier, "Supplier cannot be empty")
        'End If


        If (DxErrorProvider.HasErrors) Then
            Return False
        Else
            Return True
        End If

    End Function
    Sub SaveData()
        Try
            Dim MaterialReceiveID As Integer
            If (ValidationCheck()) Then
                If (isNew) Then
                    ' LCItem_Grid.Enabled = False

                    ' MRNoTextEdit.EditValue = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(1, "AUTO", 23, MRDateDateEdit.DateTime)
                    '        MRNoTextEdit.Tag = Me.QueriesTableAdapter.fn_InvoiceHeader_GetInvoiceNoAndID(0, "AUTO", 23, MRDateDateEdit.DateTime)
                End If


                '       Me.Sp_SPMaterialReceiveHeader_GetDataTableAdapter.Fill(Me.DataSet_RKR.sp_SPMaterialReceiveHeader_GetData, (DateEditStart.DateTime), (DateEditEnd.DateTime))




                Try
                    GV_Customer.ClearColumnErrors()


                    Me.Validate()

                    Me.Sp_MDCustomer_GetDataBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.DataSet)
                    'Me.Sp_MDCustomer_GetDataTableAdapter.Fill(Me.DataSet.sp_MDCustomer_GetData, 1)

                    'Label_JumlahJenis.Text = colInventoryID_Detail.SummaryItem.SummaryValue.ToString + " Jenis"
                    'Ed_GrossTotal.EditValue = CInt(colSubtotal_Detail.SummaryItem.SummaryValue)
                    'CalculateSummary()

                    'If (GVMaterialReceive_Detail.RowCount < 1) Then
                    '    Me.MasterQueriesTableAdapter.sp_SPMaterialReceiveHeaderDelData(Ed_MRVCode.EditValue, Dt_MRVDate.DateTime)
                    'End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try






                'If (MRNoTextEdit.EditValue = "AUTO") Then
                '    Dim MRVCode As String

                '    Me.Sp_SPMaterialReceiveDetailGetDataBindingSource.EndEdit()
                '    Me.TableAdapterManager.UpdateAll(Me.DataSet)

                '    Me.MasterQueriesTableAdapter.sp_SPMaterialReceiveHeaderInsData(MRVCode, Dt_MRVDate.DateTime, 0, LookUpEdit_Warehouse.EditValue,
                '                                                     CInt(SearchLookUpEdit_Supplier.EditValue), SearchLookUpEdit_Supplier.Text, Ed_SupplierName.EditValue, Ed_SupplierAddress.EditValue, Ed_SupplierCity.EditValue,
                '                                                 0, Ed_DONo.Text, "", Ed_DriverName.Text, Ed_VehicleNo.Text,
                '                                                "IDR", CDec(0), 0, CDec(Ed_GrandTotal.EditValue), Ed_Remark.Text, UserModified)

                '    MaterialReceiveID = CInt(Me.MasterQueriesTableAdapter.sp_SPMaterialReceiveHeaderGetIDMaterialReceive(MRVCode).ToString())
                '    Ed_MRVCode.Tag = MaterialReceiveID
                '    Ed_MRVCode.EditValue = MRVCode
                '    DataSet.sp_SPMaterialReceiveDetail_GetData.Columns("MaterialReceiveID").DefaultValue = MaterialReceiveID
                '    '  Me.MasterQueriesTableAdapter.sp_SPMRVCashDetailInsData(MRVID, GVMaterialReceive_Detail.GetFocusedRowCellValue(colisInventory1))
                'Else

                '    MaterialReceiveID = CInt(Me.MasterQueriesTableAdapter.sp_SPMaterialReceiveHeaderGetIDMaterialReceive(Ed_MRVCode.EditValue).ToString())
                '    Ed_MRVCode.Tag = MaterialReceiveID
                'End If

                'Else
                '    Me.MasterQueriesTableAdapter.sp_SPMaterialReceiveHeaderUpdData(0, CInt(Ed_MRVCode.Tag), Ed_MRVCode.EditValue, Dt_MRVDate.DateTime, LookUpEdit_Warehouse.EditValue,
                '                                                     SearchLookUpEdit_Supplier.EditValue, SearchLookUpEdit_Supplier.Text, Ed_SupplierName.EditValue, Ed_SupplierAddress.EditValue, Ed_SupplierCity.EditValue,
                '                                                   0, Ed_DONo.EditValue, "", Ed_DriverName.EditValue, Ed_VehicleNo.EditValue,
                '                                                  "IDR", 0, 0, CInt(Ed_GrandTotal.EditValue), Ed_Remark.EditValue, UserModified)
                '    AlertControl1.Show(Me, "Success On Update Data", Ed_MRVCode.EditValue)

                'End If
                'ComponentStatus(2)
                'CalculateSummary()

            Else
                AlertControl.Show(Me, "Error on Input Data", "Input Value is not Valid")
                Exit Sub
                '           End If
            End If

        Catch ex As Exception
            AlertControl.Show(Me, "Error on Input Data", ex.Message)
        End Try
    End Sub

    Private Sub SB_BackDetail_Click(sender As Object, e As EventArgs) Handles SB_BackDetail.Click
        HomeLayout()
    End Sub

    Private Sub SB_New_Click(sender As Object, e As EventArgs) Handles SB_New.Click
        DetailLayout()
        isNew = True
        Sp_MDCustomer_GetDataBindingSource.AddNew()
    End Sub
End Class