Imports System.Math

Public Class Frm_Map

    Public WithEvents newButton As DevExpress.XtraEditors.SimpleButton

    Private Sub RibbonForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_MDTable_GetData' table. You can move, or remove it, as needed.
        Me.Sp_POS_MDTable_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDTable_GetData, 0)

        RefreshTable()

        Dim currentSkin As DevExpress.Skins.Skin
        currentSkin = DevExpress.Skins.CommonSkins.GetSkin(SimpleButton1.LookAndFeel)
        currentSkin.Colors("Control") = Color.Green
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub RefreshTable()
        For i = 0 To GV_Table.RowCount
            newButton = New DevExpress.XtraEditors.SimpleButton
            newButton.Name = "Bt_" & i
            newButton.Text = i
            newButton.Top = 110 * Floor(((i - 1) / Floor(Panel_TableView.Width / 110))) + 10
            newButton.Left = 110 * ((i - 1) Mod Floor(Panel_TableView.Width / 110)) + 10
            newButton.Width = 100
            newButton.Height = 100

            newButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
            newButton.Appearance.BackColor = Color.Red
            newButton.Appearance.BackColor2 = Color.Transparent
            newButton.Appearance.GradientMode = Drawing2D.LinearGradientMode.Vertical
            newButton.Text = GV_Table.GetRowCellValue(i - 1, colTableName_Table)
            newButton.Tag = GV_Table.GetRowCellValue(i - 1, colID_Table)
            newButton.Font = New Font(newButton.Font.FontFamily, 12, newButton.Font.Style)

            AddHandler newButton.Click, AddressOf Me.ButtonTable_Click

            Me.Panel_TableView.Controls.Add(Me.newButton)
        Next
    End Sub
    Private Sub ButtonTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim FrmMenu As DevExpress.XtraEditors.XtraForm
        'FrmMenu = New Frm_Front(Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderID(Today, sender.tag),
        '                        Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderNo(Today, sender.tag),
        '                        1, sender.tag, sender.text)
        FrmMenu.ShowDialog()




    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick


        Me.Panel_TableView.Controls.Clear()
    End Sub

End Class