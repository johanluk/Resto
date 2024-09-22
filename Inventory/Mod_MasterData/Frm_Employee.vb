Public Class Frm_Employee

#Region "Variables"
    Private isNew As Boolean
    Private UserModified As String
    Dim isUpdate As Boolean = False
    Dim OldName As String
    Dim NewName As String
#End Region

    Public Sub New()
        InitializeComponent()

        NavigationFrame1.SelectedPage = NavigationPage1
    End Sub

    Public Sub New(ByVal ConnString As String, ByVal Source As String, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        NavigationFrame1.SelectedPage = NavigationPage1

        My.Settings.Item("ConnectionString") = ConnString

    End Sub

    Private Sub Frm_SPMaterialReceiveCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_MDPosition_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDPosition_GetDataTableAdapter.Fill(Me.DataSet.sp_MDPosition_GetData)
        'TODO: This line of code loads data into the 'DataSet.sp_MDEmployee_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDEmployee_GetDataTableAdapter.Fill(Me.DataSet.sp_MDEmployee_GetData)
        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username

        '  FillDataAdapter()
        ''DxErrorProvider1.ClearErrors()
        ''UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedUser").DefaultValue = "sds"
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedDate").DefaultValue = Now
    End Sub



    Private Sub FillDataAdapter()
        Try
            Me.Sp_MDEmployee_GetDataTableAdapter.Fill(Me.DataSet.sp_MDEmployee_GetData)
            '   Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub


    Function ValidationCheck() As Boolean
        Return True
    End Function




    Private Sub GV_Detail_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Detail.ValidateRow
        Dim Judul_Notif As String = "Transaksi Data"
        Try
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            Me.Sp_MDEmployee_GetDataBindingSource.EndEdit()
            Me.Validate()
            Me.TableAdapterManager.UpdateAll(Me.DataSet)
            'If (isUpdate) Then
            '    Me.QueriesTableAdapter.sp_MDMenuType_Transaction(2,
            '                                                 CInt(InvBrandNoTextEdit.Tag),
            '                                                 InvBrandNoTextEdit.EditValue.ToString,
            '                                                 InvBrandNameTextEdit.EditValue.ToString,
            '                                                 DescriptionMemoEdit.EditValue.ToString,
            '                                                 UserModified)
            '    Judul_Notif = "Perubahan Data"
            'Else
            '    OldName = "New Data"
            '    Me.QueriesTableAdapter.sp_MDMenuType_Transaction(1,
            '                                                 0,
            '                                                 InvBrandNoTextEdit.EditValue.ToString,
            '                                                 InvBrandNameTextEdit.EditValue.ToString,
            '                                                 DescriptionMemoEdit.EditValue.ToString,
            '                                                 UserModified)
            '    Judul_Notif = "Penambahan Data"
            'End If
            NewName = ""
            FillDataAdapter()

            AlertControl.Show(Me, Judul_Notif + " Sukses", OldName + " -> " + NewName)
            SB_Back.PerformClick()
        Catch ex As Exception
            AlertControl.Show(Me, Judul_Notif + " Gagal", ex.Message)
        End Try
    End Sub

    Private Sub SB_Exit_Click(sender As Object, e As EventArgs) Handles SB_Exit.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class