<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Rpt_PrintWorkOrder
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel_TableName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel_Ket = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter1 = New POS.DataSet_ReportTableAdapters.sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter()
        Me.DataSet_Report1 = New POS.DataSet_Report()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter = New POS.DataSet_ReportTableAdapters.sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.QtyXMenu = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.DataSet_Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10.0!)
        Me.Detail.HeightF = 82.50328!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QtyXMenu]")})
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Consolas", 15.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(641.0!, 82.50328!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_TableName, Me.XrLine1, Me.XrPageInfo1, Me.XrLabel_Ket})
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!)
        Me.TopMargin.HeightF = 117.6458!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.StylePriority.UseFont = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel_TableName
        '
        Me.XrLabel_TableName.Dpi = 254.0!
        Me.XrLabel_TableName.Font = New DevExpress.Drawing.DXFont("Segoe UI", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel_TableName.LocationFloat = New DevExpress.Utils.PointFloat(0!, 39.41668!)
        Me.XrLabel_TableName.Name = "XrLabel_TableName"
        Me.XrLabel_TableName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel_TableName.SizeF = New System.Drawing.SizeF(641.0!, 58.22918!)
        Me.XrLabel_TableName.StylePriority.UseFont = False
        Me.XrLabel_TableName.StylePriority.UseTextAlignment = False
        Me.XrLabel_TableName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLine1.BorderWidth = 1.0!
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.LineStyle = DevExpress.Drawing.DXDashStyle.Custom
        Me.XrLine1.LineWidth = 2.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(2.000019!, 97.64586!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(639.0!, 19.99998!)
        Me.XrLine1.StylePriority.UseBorderDashStyle = False
        Me.XrLine1.StylePriority.UseBorders = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(504.1044!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(136.8956!, 39.41667!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo1.TextFormatString = "{0:HH:mm}"
        '
        'XrLabel_Ket
        '
        Me.XrLabel_Ket.Dpi = 254.0!
        Me.XrLabel_Ket.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StatTambahan]")})
        Me.XrLabel_Ket.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.0!)
        Me.XrLabel_Ket.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel_Ket.Name = "XrLabel_Ket"
        Me.XrLabel_Ket.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel_Ket.SizeF = New System.Drawing.SizeF(402.875!, 39.4167!)
        Me.XrLabel_Ket.StylePriority.UseFont = False
        Me.XrLabel_Ket.StylePriority.UseTextAlignment = False
        Me.XrLabel_Ket.Text = "s"
        Me.XrLabel_Ket.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter1
        '
        Me.Sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter1.ClearBeforeFill = True
        '
        'DataSet_Report1
        '
        Me.DataSet_Report1.DataSetName = "DataSet_Report"
        Me.DataSet_Report1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1})
        Me.DetailReport.DataAdapter = Me.Sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter
        Me.DetailReport.DataMember = "sp_POSReportTransaction_GetDataPrintOrderDetail.sp_POSReportTransaction_GetDataPr" &
    "intOrderDetail_sp_POSReportTransaction_GetDataPrintOrderDetailMemo"
        Me.DetailReport.DataSource = Me.DataSet_Report1
        Me.DetailReport.Dpi = 254.0!
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel4})
        Me.Detail1.Dpi = 254.0!
        Me.Detail1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 10.0!)
        Me.Detail1.HeightF = 39.89921!
        Me.Detail1.MultiColumn.ColumnCount = 2
        Me.Detail1.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail1.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail1.Name = "Detail1"
        Me.Detail1.StylePriority.UseFont = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0004037221!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(33.07195!, 39.89917!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "-"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Memo]")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(33.07235!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(281.438!, 39.89917!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter
        '
        Me.Sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter.ClearBeforeFill = True
        '
        'ReportFooter
        '
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.0!)
        Me.ReportFooter.HeightF = 0!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.StylePriority.UseFont = False
        '
        'QtyXMenu
        '
        Me.QtyXMenu.DataMember = "sp_POSReportTransaction_GetDataPrintOrderDetail"
        Me.QtyXMenu.DisplayName = "QtyXMenu"
        Me.QtyXMenu.Expression = "[Qty]+' X '+[MenuName]"
        Me.QtyXMenu.Name = "QtyXMenu"
        '
        'Rpt_PrintWorkOrder
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.QtyXMenu})
        Me.DataAdapter = Me.Sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter1
        Me.DataMember = "sp_POSReportTransaction_GetDataPrintOrderDetail"
        Me.DataSource = Me.DataSet_Report1
        Me.DesignerOptions.ShowDesignerHints = False
        Me.DesignerOptions.ShowExportWarnings = False
        Me.DesignerOptions.ShowPrintingWarnings = False
        Me.Dpi = 254.0!
        Me.Margins = New DevExpress.Drawing.DXMargins(59, 59, 118, 0)
        Me.PageHeight = 2794
        Me.PageWidth = 759
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 25.0!
        Me.Version = "18.1"
        CType(Me.DataSet_Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter1 As POS.DataSet_ReportTableAdapters.sp_POSReportTransaction_GetDataPrintOrderDetailTableAdapter
    Friend WithEvents DataSet_Report1 As POS.DataSet_Report
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents Sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter As POS.DataSet_ReportTableAdapters.sp_POSReportTransaction_GetDataPrintOrderDetailMemoTableAdapter
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel_Ket As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel_TableName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents QtyXMenu As DevExpress.XtraReports.UI.CalculatedField
End Class
