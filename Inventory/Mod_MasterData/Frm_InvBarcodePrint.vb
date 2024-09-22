Public Class Frm_InvBarcodePrint

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
        'TODO: This line of code loads data into the 'DataSet.sp_MDMenuType_GetData' table. You can move, or remove it, as needed.
        Me.sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData)
        Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
        Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)
        Me.Sp_MDInvProduct_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvProduct_GetData, 0)


        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        '  FillDataAdapter()
        ''DxErrorProvider1.ClearErrors()
        DataSet.sp_MDInventory_GetData.Columns("ModifiedUser").DefaultValue = UserModified

        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedDate").DefaultValue = Now
    End Sub



    Private Sub FillDataAdapter()
        Try
            Me.sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData)
            '   Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub DateEditEnd_Leave(sender As Object, e As EventArgs)
        FillDataAdapter()
    End Sub




    Private Sub SB_Exit_Click(sender As Object, e As EventArgs) Handles SB_Exit.Click
        Me.Close()
    End Sub


    Private Sub CB_Print_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Print.CheckedChanged
        If (CB_Print.Checked) Then
            colT_PrintCheck.Visible = True
            colT_PrintQty.Visible = True
        Else
            colT_PrintCheck.Visible = False
            colT_PrintQty.Visible = False
        End If
    End Sub

    Private Sub SB_BarcodePrint_Click(sender As Object, e As EventArgs) Handles SB_BarcodePrint.Click

    End Sub
End Class