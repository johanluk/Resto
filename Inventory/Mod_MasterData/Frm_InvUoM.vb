Public Class Frm_InvUoM

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
        'TODO: This line of code loads data into the 'DataSet.view_invuom' table. You can move, or remove it, as needed.
        Me.View_invuomTableAdapter.Fill(Me.DataSet.view_invuom)

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        HomeLayout()
        '  FillDataAdapter()
        ''DxErrorProvider1.ClearErrors()
        ''UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedUser").DefaultValue = "sds"
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedDate").DefaultValue = Now
    End Sub



    Private Sub FillDataAdapter()
        Try
            Me.View_invuomTableAdapter.Fill(Me.DataSet.view_invuom)
            '   Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub NewProcess()
        Try
            Me.Cursor = Cursors.WaitCursor
            DetailLayout()
            View_InvUoMGridControl.DataSource = Me.DataSet.view_invuom
            View_InvUoMBindingSource.AddNew()


        Catch ex As Exception
            AlertControl.Show(Me, "ss", ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub HomeLayout()
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        DxErrorProvider.ClearErrors()
        isUpdate = False
        View_InvUoMGridControl.DataSource = View_InvUoMBindingSource
        WindowsUIButtonPanel_Header.Buttons.Item(0).Properties.Enabled = True
        WindowsUIButtonPanel_Header.Buttons.Item(1).Properties.Enabled = False
    End Sub

    Private Sub DetailLayout()
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        DxErrorProvider.ClearErrors()
        View_InvUoMGridControl.DataSource = Me.DataSet.view_invuom
        WindowsUIButtonPanel_Header.Buttons.Item(0).Properties.Enabled = False
        WindowsUIButtonPanel_Header.Buttons.Item(1).Properties.Enabled = True
    End Sub



    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel_Header.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "New"

                NewProcess()
            Case "Save"
                SaveProcess()

            Case "Close"
                Me.Close()
                Me.Dispose()

        End Select
    End Sub

    Function ValidationCheck() As Boolean
        Return True
    End Function

    Sub SaveProcess()
        Dim Judul_Notif As String = "Transaksi Data"
        Try
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            Me.Validate()
            If (isUpdate) Then
                Me.QueriesTableAdapter.sp_MDMenuType_Transaction(2,
                                                             CInt(InvUoMNoTextEdit.Tag),
                                                             InvUoMNoTextEdit.EditValue.ToString,
                                                             InvUoMNameTextEdit.EditValue.ToString,
                                                             DescriptionMemoEdit.EditValue.ToString,
                                                             UserModified)
                Judul_Notif = "Perubahan Data"
            Else
                OldName = "New Data"
                Me.QueriesTableAdapter.sp_MDMenuType_Transaction(1,
                                                             0,
                                                             InvUoMNoTextEdit.EditValue.ToString,
                                                             InvUoMNameTextEdit.EditValue.ToString,
                                                             DescriptionMemoEdit.EditValue.ToString,
                                                             UserModified)
                Judul_Notif = "Penambahan Data"
            End If
            NewName = InvUoMNameTextEdit.EditValue.ToString
            FillDataAdapter()

            AlertControl.Show(Me, Judul_Notif + " Sukses", OldName + " -> " + NewName)
            SB_Back.PerformClick()
        Catch ex As Exception
            AlertControl.Show(Me, Judul_Notif + " Gagal", ex.Message)
        End Try
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanging(sender As Object, e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles XtraTabControl1.SelectedPageChanging
        TransitionManager1.StartTransition(XtraTabControl1)

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        TransitionManager1.EndTransition()
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            DxErrorProvider.ClearErrors()
            View_InvUoMBindingSource.CancelEdit()
            HomeLayout()
        Catch ex As Exception
            AlertControl.Show(Me, "Check On btnBack_ItemClick()", ex.Message)
        Finally
            View_InvUoMGridControl.DataSource = View_InvUoMBindingSource
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GV_Detail_DoubleClick(sender As Object, e As EventArgs) Handles GV_Detail.DoubleClick
        If (GV_Detail.RowCount > 0) Then
            isUpdate = True
            DetailLayout()
        End If
    End Sub
End Class