Public Class Rpt_Opname
    Dim NoTransaction As Integer
    Sub New(ByVal _NoTran As Integer)
        NoTransaction = _NoTran
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Rpt_Opname_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Me.Sp_T_Opname_GetDataTableAdapter1.Fill(Me.DataSet.sp_T_Opname_GetData, NoTransaction)
    End Sub
End Class