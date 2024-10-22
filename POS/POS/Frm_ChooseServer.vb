Public Class Frm_ChooseServer

    Dim ServerData As DataTable
    Dim ServerID As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal _data As DataTable, ByVal _ServerID As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        ServerData = _data
        ServerID = _ServerID
        ' Add any initialization after the InitializeComponent() call.
        SB_Submit.Focus()

    End Sub
    Private Sub Frm_ChooseServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SearchLookUpEdit1.Properties.DataSource = ServerData
        SearchLookUpEdit1.EditValue = ServerID
        SB_Submit.Focus()
    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        My.Settings.ServerID = SearchLookUpEdit1.EditValue
    End Sub

    Private Sub SB_Cancel_Click(sender As Object, e As EventArgs) Handles SB_Cancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class