Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI

Public Class Rpt_LabelBarcodePrice13
    Private Sub Rpt_LabelBarcode_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Me.Sp_MDInventory_PrintBarcodeListLabelTableAdapter.Fill(Me.DataSet_Report1.sp_MDInventory_PrintBarcodeListLabel)
    End Sub

    Private Sub XrBarCode1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrBarCode1.BeforePrint
        Dim generator As BarCodeGeneratorBase = Nothing
        Dim value As String = Convert.ToString(Me.GetCurrentColumnValue("Barcode"))
        If ((Strings.Left(value.ToString, 6) = "000000") Or (value.Length = 6)) Then
            generator = New CodabarGenerator()
        Else
            generator = New EAN13Generator()

        End If
        TryCast(sender, XRBarCode).Symbology = generator
    End Sub
End Class