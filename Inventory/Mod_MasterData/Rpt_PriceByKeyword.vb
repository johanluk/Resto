Public Class Rpt_PriceByKeyword

    Dim Keyword As String
    Sub New(ByVal _Keyword As String)
        Keyword = _Keyword
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Rpt_PriceByKeyword_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Me.Sp_SPReport_GetPriceFromKeywordTableAdapter.Fill(Me.DataSet_Report1.sp_SPReport_GetPriceFromKeyword, Keyword)
    End Sub
End Class