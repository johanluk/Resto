
Imports System.IO

Public Class Frm_MenuList

#Region "Variables"
    Private isNew As Boolean
    Private UserModified As String
    Dim isUpdate As Boolean = False
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
        'TODO: This line of code loads data into the 'DataSet.view_menutype_list' table. You can move, or remove it, as needed.
        Me.View_menutype_listTableAdapter.Fill(Me.DataSet.view_menutype_list)
        'TODO: This line of code loads data into the 'DataSet.view_menucategory_list' table. You can move, or remove it, as needed.
        Me.View_menucategory_listTableAdapter.Fill(Me.DataSet.view_menucategory_list)
        'TODO: This line of code loads data into the 'DataSet.view_menulist' table. You can move, or remove it, as needed.
        Me.View_menulistTableAdapter.Fill(Me.DataSet.view_menulist)
        'TODO: This line of code loads data into the 'DataSet.view_menulist' table. You can move, or remove it, as needed.
        Me.View_menulistTableAdapter.Fill(Me.DataSet.view_menulist)

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        '  FillDataAdapter()
        ''DxErrorProvider1.ClearErrors()
        ''UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedUser").DefaultValue = "sds"
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedDate").DefaultValue = Now
    End Sub



    Private Sub FillDataAdapter()
        Try
            View_menulistTableAdapter.Fill(Me.DataSet.view_menulist)
            '   Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub NewProcess()
        Try
            Me.Cursor = Cursors.WaitCursor
            DetailLayout()
            View_menulistGridControl.DataSource = Me.DataSet.view_menulist
            View_menulistBindingSource.AddNew()


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
        WindowsUIButtonPanel_Header.Buttons.Item(0).Properties.Enabled = True
    End Sub

    Private Sub DetailLayout()
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        DxErrorProvider.ClearErrors()
        View_menulistGridControl.DataSource = Me.DataSet.view_menulist
        WindowsUIButtonPanel_Header.Buttons.Item(0).Properties.Enabled = False
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DateEditEnd_Leave(sender As Object, e As EventArgs)
        FillDataAdapter()
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
        Try
            If (ValidationCheck() = False) Then
                Exit Sub
            End If
            'Dim bytes As [Byte]() = ImagePictureEdit.Image.
            'Dim ms As New MemoryStream(ImagePictureEdit.Image)
            Dim mstream As New System.IO.MemoryStream()
            ImagePictureEdit.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            Me.Validate()
            If (isUpdate) Then

                Me.QueriesTableAdapter.sp_MDMenu_Transaction(2,
                                                             CInt(MenuNoTextEdit.Tag),
                                                             MenuNoTextEdit.EditValue.ToString,
                                                             MenuDisplayTextEdit.EditValue.ToString,
                                                             MenuNameTextEdit.EditValue.ToString,
                                                             CInt(MenuCategoryIDLookUpEdit.EditValue),
                                                             0,
                                                             CInt(PriceSpinEdit.EditValue),
                                                             0,
                                                             arrImage,
                                                             DescriptionTextEdit.EditValue.ToString,
                                                             UserModified)
            Else
                Me.QueriesTableAdapter.sp_MDMenu_Transaction(1,
                                                             0,
                                                             MenuNoTextEdit.EditValue.ToString,
                                                             MenuDisplayTextEdit.EditValue.ToString,
                                                             MenuNameTextEdit.EditValue.ToString,
                                                             CInt(MenuCategoryIDLookUpEdit.EditValue),
                                                             0,
                                                             CInt(PriceSpinEdit.EditValue),
                                                             0,
                                                             arrImage,
                                                             DescriptionTextEdit.EditValue.ToString,
                                                             UserModified)

            End If

            FillDataAdapter()

            AlertControl.Show(Me, "Success", MenuNameTextEdit.EditValue.ToString + " Berhasil Disimpan")
            SB_Back.PerformClick()
        Catch ex As Exception
            AlertControl.Show(Me, "Trouble in Input", ex.Message)
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
            View_menulistBindingSource.CancelEdit()
            HomeLayout()
        Catch ex As Exception
            AlertControl.Show(Me, "Check On btnBack_ItemClick()", ex.Message)
        Finally
            View_menulistGridControl.DataSource = View_menulistBindingSource
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GV_Detail_DoubleClick(sender As Object, e As EventArgs) Handles GV_Detail.DoubleClick
        If (GV_Detail.RowCount > 0) Then
            isUpdate = True
            DetailLayout()
        End If
    End Sub


    Private Sub SB_ImageChoose_Click(sender As Object, e As EventArgs) Handles SB_ImageChoose.Click
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ImagePictureEdit.Image = Image.FromFile(OpenFileDialog.FileName)

        End If
    End Sub
End Class