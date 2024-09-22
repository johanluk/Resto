Imports DevExpress.XtraReports.UI

Public Class Frm_InputStock

    Dim userModified As String
    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

    Dim newNoBarcode As Boolean = False


    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon

        My.Settings.Item("ConnectionString") = ConnString
        My.Settings.Username = Username

    End Sub
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function

    Private Sub Frm_InputStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_T_Opname_GetList' table. You can move, or remove it, as needed.
        Me.Sp_T_Opname_GetListTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetList)
        'TODO: This line of code loads data into the 'DataSet.sp_MDInventory_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData, 0)
        Ed_NoTransaksi.EditValue = 0
        'TODO: This line of code loads data into the 'DataSet.sp_MDInventory_PrintBarcodeList' table. You can move, or remove it, as needed.
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, CInt(Ed_NoTransaksi.EditValue))
        Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
        Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)
        Me.Sp_MDUoMGetDataTableAdapter.Fill(Me.DataSet.sp_MDUoMGetData, 0)
        userModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username

    End Sub

    Sub RefreshData()
        SB_Refresh.PerformClick()
    End Sub

    Private Sub Ed_Barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ed_Barcode.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            newNoBarcode = False
            Dim temp As Integer
            temp = CInt(Me.QueriesTableAdapter.sp_T_Opname_CheckInvBarcode(Ed_Barcode.EditValue.ToString))
            If (temp <> 0) Then
                Me.QueriesTableAdapter.sp_T_Opname_InsUpdData(Ed_Barcode.EditValue.ToString,
                                                                CInt(Ed_NoTransaksi.EditValue), 1, userModified)

                RefreshData()
                Ed_Barcode.EditValue = ""
            Else


                LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

                Ed_BarcodeInput.EditValue = Ed_Barcode.EditValue
                Ed_InvNo_Input.EditValue = ""
                Ed_InvName_Input.EditValue = ""
                Ed_Qty.EditValue = 1
                Ed_KodeHarga.EditValue = ""
                LookUpEdit1.Reset()
                LookUpEdit2.Reset()
                LookUpEdit3.Reset()
                LookUpEdit1.Select()

            End If
        End If


    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData, 0)
        'TODO: This line of code loads data into the 'DataSet.sp_MDInventory_PrintBarcodeList' table. You can move, or remove it, as needed.
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, CInt(Ed_NoTransaksi.EditValue))



    End Sub

    Private Sub SB_Print_Click(sender As Object, e As EventArgs) Handles SB_Print.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_Opname(CInt(Ed_NoTransaksi.EditValue))
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()

            'printTool.Print()
            '    printTool.Print("myPrinter")
        End Using
    End Sub

    Private Sub Ed_NoTransaksi_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_NoTransaksi.EditValueChanged
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, CInt(Ed_NoTransaksi.EditValue))

    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click


        If (newNoBarcode) Then

            Me.QueriesTableAdapter.sp_T_Opname_InsUpdDataByName(0, Ed_InvNo_Input.EditValue.ToString(), Ed_InvName_Input.EditValue.ToString(),
                                                                MemoEdit1.EditValue.ToString(), Ed_KodeHarga.EditValue.ToString(),
                                                                CInt(Ed_NoTransaksi.EditValue), CInt(Ed_Qty.EditValue), userModified)
            LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Ed_Barcode.Select()

        Else
            Me.QueriesTableAdapter.sp_T_Opname_InsUpdInventory(Ed_BarcodeInput.EditValue.ToString,
                                                           Ed_InvNo_Input.EditValue.ToString,
                                                           Ed_InvName_Input.EditValue.ToString,
                                                           CInt(LookUpEdit1.EditValue),
                                                           CInt(LookUpEdit2.EditValue),
                                                           CInt(LookUpEdit3.EditValue),
                                                           MemoEdit1.Text.ToString,
                                                           Ed_KodeHarga.EditValue.ToString(),
                                                           userModified)
            LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.QueriesTableAdapter.sp_T_Opname_InsUpdData(Ed_BarcodeInput.EditValue.ToString,
                                                                CInt(Ed_NoTransaksi.EditValue), CInt(Ed_Qty.EditValue), userModified)
            Ed_Barcode.Select()

        End If

        RefreshData()
    End Sub

    Private Sub GV_Detail_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Detail.ValidateRow
        Me.Sp_T_Opname_GetDataBindingSource.EndEdit()
        Me.Validate()
        TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub SLE_OpnameHistory_EditValueChanged(sender As Object, e As EventArgs) Handles SLE_OpnameHistory.EditValueChanged

    End Sub

    Private Sub SearchLookUpEdit1View_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles SearchLookUpEdit1View.RowCellClick
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, GridView1.GetFocusedRowCellValue(colNoTransaction))
        Ed_NoTransaksi.EditValue = SLE_OpnameHistory.EditValue
    End Sub

    Private Sub SB_Input_Click(sender As Object, e As EventArgs) Handles SB_Input.Click
        Try


            Me.QueriesTableAdapter.sp_T_Opname_InsUpdDataByName(CInt(SLE_NamaBarang.EditValue), "", "", "", "", CInt(Ed_NoTransaksi.EditValue), 1, userModified)

            RefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub SB_NewOpname_Click(sender As Object, e As EventArgs) Handles SB_NewOpname.Click
        Ed_NoTransaksi.EditValue = QueriesTableAdapter.sp_T_Opname_GetBarcodeNo()
    End Sub


    Private Sub SLE_NamaBarang_AddNewValue(sender As Object, e As DevExpress.XtraEditors.Controls.AddNewValueEventArgs) Handles SLE_NamaBarang.AddNewValue
        Dim temp As Integer

        newNoBarcode = True

        LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        Ed_BarcodeInput.EditValue = "-"
        Ed_InvNo_Input.EditValue = ""
        Ed_InvName_Input.EditValue = ""
        Ed_Qty.EditValue = 1
        Ed_KodeHarga.EditValue = ""
        MemoEdit1.EditValue = ""

        'LookUpEdit1.Select()

        'Me.QueriesTableAdapter.sp_MDInventory_InsData("-", Ed_InvNo_Input.ToString(), Ed_InvName_Input.ToString(), 1, 1, 1, 1, 1, 1, 0, 1, Ed_KodeHarga.EditValue.ToString(), 0, 0, 0, 0, 0, 0, MemoEdit1.EditValue.ToString(), userModified)

    End Sub

    Private Sub SB_Close_Click(sender As Object, e As EventArgs) Handles SB_Close.Click
        Me.Close()
    End Sub
End Class