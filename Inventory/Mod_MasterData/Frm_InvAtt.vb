Public Class Frm_InvAtt

#Region "Variables"
    Private isNew As Boolean
    Private UserModified As String
    Dim isUpdate As Boolean = False
    Dim OldName As String
    Dim NewName As String
#End Region

    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

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

    Private Sub Frm_SPMaterialReceiveCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.view_invproduct' table. You can move, or remove it, as needed.
        Me.sp_MDInvProduct_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvProduct_GetData, 0)
        Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
        Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)

        'FillDataAdapter()
        'DxErrorProvider1.ClearErrors()
        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        DataSet.sp_MDInvProduct_GetData.Columns("ModifiedUser").DefaultValue = UserModified
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedDate").DefaultValue = Now
    End Sub

    Private Sub FillDataAdapter()
        Try
            Me.sp_MDInvProduct_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvProduct_GetData, 0)
            '   Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub


    Function ValidationCheck() As Boolean
        Return True
    End Function

    Private Sub GV_Detail_DoubleClick(sender As Object, e As EventArgs) Handles GV_Product.DoubleClick
        If (GV_Product.RowCount > 0) Then
            isUpdate = True

        End If
    End Sub

    Private Sub SB_Exit_Click(sender As Object, e As EventArgs) Handles SB_Exit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub GV_Product_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Product.ValidateRow
        Try
            Me.sp_MDInvProduct_GetDataBindingSource.EndEdit()
            Me.Validate()
            TableAdapterManager.UpdateAll(Me.DataSet)
            Me.sp_MDInvProduct_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvProduct_GetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub GV_Brand_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Brand.ValidateRow
        Try
            Me.Sp_MDInvBrand_GetDataBindingSource.EndEdit()
            Me.Validate()
            TableAdapterManager.UpdateAll(Me.DataSet)
            Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub GV_Category_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Category.ValidateRow
        Try
            Me.Sp_MDInvCategory_GetDataBindingSource.EndEdit()
            Me.Validate()
            TableAdapterManager.UpdateAll(Me.DataSet)
            Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class