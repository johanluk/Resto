Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports DevExpress.XtraReports.UI

Public Class Frm_InvListStock

    Public InventoryID As Integer
    Dim UserName As String


    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl
    Public Sub New()
        InitializeComponent()
        UserName = My.Settings.Username
    End Sub

    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal _Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon

        My.Settings.Item("ConnectionString") = ConnString
        My.Settings.Username = UserName

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

    Private Sub Frm_InvListStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_MDInventory_GetDataSyncList' table. You can move, or remove it, as needed.
        Me.Sp_MDInventory_GetDataSyncListTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetDataSyncList)

    End Sub


    Private Sub RepoButton_Detail_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepoButton_Detail.ButtonClick
        Try
            Label_NamaBarang.Text = GV_Header.GetRowCellValue(GV_Header.FocusedRowHandle, colInventoryName)
            InventoryID = GV_Header.GetRowCellValue(GV_Header.FocusedRowHandle, colInventoryID)
            Me.Sp_MDInventory_GetDataSyncList_DetailTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetDataSyncList_Detail, InventoryID)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SB_ShowDetailedReport_Click(sender As Object, e As EventArgs) Handles SB_ShowDetailedReport.Click
        Try

            Dim report As New DevExpress.XtraReports.UI.XtraReport


            report = New Rpt_InvListStock(0, 0, InventoryID)

            Using printTool As New ReportPrintTool(report)

                printTool.ShowPreviewDialog()



            End Using

        Catch ex As Exception

        End Try

    End Sub

    Private Sub SB_Close_Click(sender As Object, e As EventArgs) Handles SB_Close.Click
        Me.Close()

    End Sub

    Private Sub RepoButton_Sync_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepoButton_Sync.ButtonClick
        Try
            If (MsgBox("Yakin Akan Melakukan Sync ? ", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes) Then
                Me.QueriesTableAdapter.sp_MDInventory_GetDataSync_Update(
                 GV_Header.GetRowCellValue(GV_Header.FocusedRowHandle, colInventoryID),
                 CInt(GV_Header.GetRowCellValue(GV_Header.FocusedRowHandle, colTotal)))

                SB_Refresh.PerformClick()
            Else

            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        Me.Sp_MDInventory_GetDataSyncListTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetDataSyncList)
    End Sub

    Private Sub CE_ShowNotOK_CheckedChanged(sender As Object, e As EventArgs) Handles CE_ShowNotOK.CheckedChanged
        If (CE_ShowNotOK.CheckState) Then
            GV_Header.ActiveFilterString = "Contains([Status], 'Perlu Sync')"
        Else
            GV_Header.ActiveFilterString = ""
        End If
    End Sub
End Class