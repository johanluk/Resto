Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class Frm_Promo

    Private isNew As Boolean
    Private UserModified As String


    Dim RowFocus As Integer


    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl


    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub 'New
        Public View As GridView
        Public RowHandle As Integer
    End Class

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon
        My.Settings.Item("ConnectionString") = ConnString
        My.Settings.Username = Username

    End Sub


    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function

    Sub FillDataAdapter()
        Try
            Me.Sp_MDPromo_GetDataTableAdapter.Fill(Me.DataSet.sp_MDPromo_GetData)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If (RadioGroup1.SelectedIndex = 0) Then
            IsPartialCheckEdit.Checked = True
            IsGroupCheckEdit.Checked = False
            LC_JenisGrosir.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            RadioGroup1.SelectedIndex = 0
            LCPercentage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        ElseIf (RadioGroup1.SelectedIndex = 1) Then
            IsPartialCheckEdit.Checked = False
            IsGroupCheckEdit.Checked = True
            LC_JenisGrosir.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            RadioGroup1.SelectedIndex = 3
            LCPercentage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

        End If
    End Sub

    Private Sub Frm_Promo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_MDPromoGroup_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDPromoGroup_GetDataTableAdapter.Fill(Me.DataSet.sp_MDPromoGroup_GetData)
        FillDataAdapter()

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        DataSet.sp_MDInvProduct_GetData.Columns("ModifiedUser").DefaultValue = UserModified
        LC_Global.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LC_Grup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Private Sub SB_New_Click(sender As Object, e As EventArgs) Handles SB_New.Click


        LayoutControlGroup3.Enabled = False

        Me.Sp_MDPromo_GetDataBindingSource.AddNew()
        RadioGroup1.DeselectAll()
        RadioGroup1.SelectedIndex = 1
        RadioGroup1.SelectedIndex = 0
        PromoGrosirSpinEdit.DeselectAll()
        PromoGrosirSpinEdit.SelectedIndex = 3
        PromoGrosirSpinEdit.SelectedIndex = 0

        IsPartialCheckEdit.Checked = True
        IsGroupCheckEdit.Checked = False
        Ed_PromoPercentage.EditValue = 0

    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        Try

            Me.Validate()
            Me.Sp_MDPromo_GetDataBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet)

            FillDataAdapter()

            LayoutControlGroup3.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Try

            LayoutControlGroup3.Enabled = True
            Me.Sp_MDPromo_GetDataBindingSource.CancelEdit()

            FillDataAdapter()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub SB_Close_Click(sender As Object, e As EventArgs) Handles SB_Close.Click
        Me.Close()
    End Sub

    Private Sub SB_SubmitGroup_Click(sender As Object, e As EventArgs) Handles SB_SubmitGroup.Click
        Me.QueriesTableAdapter1.sp_MDPromoGroup_InsUpdData(0, CInt(Ed_PromoGroup_Name.Tag), Ed_PromoGroup_Name.EditValue.ToString,
                                                           CDec(Ed_PromoPercentage.EditValue),
                                                           CInt(Ed_PromoGroup_Min.EditValue), CInt(Ed_PromoGroup_Max.EditValue),
                                                           "")
        SB_Back.PerformClick()
    End Sub

    Private Sub GV_GroupPromo_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GV_GroupPromo.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim menuItemDeleteRow As New DXMenuItem("&New Group Promo",
          AddressOf OnDeleteRowBarcode, ImageCollection.Images(0))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemDeleteRow)
        End If
    End Sub

    Sub OnDeleteRowBarcode(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_GroupPromo.FocusedRowHandle
        Dim DeletedVar1 As String

        DeletedVar1 = GV_GroupPromo.GetRowCellValue(RowFocus, colID).ToString
        Try
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim info As RowInfo = CType(item.Tag, RowInfo)

            GV_GroupPromo.DeleteRow(info.RowHandle)
            Me.Validate()
            'Me.Sp_MDInventory_PrintBarcodeListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet)
            AlertControl.Show(Me, "Perintah Hapus Berhasil", DeletedVar1 + " DIHAPUS")
        Catch ex As Exception
            AlertControl.Show(Me, "Perintah Hapus Gagal", ex.Message)
        End Try
    End Sub

    Private Sub GV_Promo_RowClick(sender As Object, e As RowClickEventArgs) Handles GV_Promo.RowClick
        If (GV_Promo.GetRowCellValue(e.RowHandle, colMode) = 0) Then
            LC_Grup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LC_Global.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LC_Grup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LC_Global.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        FillDataAdapter()
    End Sub
End Class