Public Class Frm_MasterData
    Private Sub Frm_MasterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dataset.sp_MDInventory_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.Dataset.sp_MDInventory_GetData, 0)

    End Sub

End Class