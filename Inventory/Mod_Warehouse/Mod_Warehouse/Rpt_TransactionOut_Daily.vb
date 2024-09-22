Public Class Rpt_TransactionOut_Daily


    Dim DtStart As Date
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal _StartDate As Date)

        ' This call is required by the designer.
        InitializeComponent()
        DtStart = _StartDate
        XrLabel_ParamDate.Text = DtStart.ToLongDateString
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub FillDataAdapter()
        Try

            Me.sp_SPInventoryOut_GetReportDailyTableAdapter.ClearBeforeFill = True

            Me.sp_SPInventoryOut_GetReportDailyTableAdapter.Fill(Me.Dataset1.sp_SPInventoryOut_GetReportDaily, DtStart)

        Catch ex As Exception
            MessageBox.Show("Data Kosong")
        End Try
    End Sub

    Private Sub Rpt_TransactionOut_Daily_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        FillDataAdapter()

    End Sub
End Class