Public Class Frm_CustomerEnter


    Public WithEvents newButton As DevExpress.XtraEditors.SimpleButton
    Public WithEvents newEdit As DevExpress.XtraEditors.TextEdit


    Private UserModified As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SB_Key_Click(sender As Object, e As EventArgs) Handles SB_Key.Click, SimpleButton72.Click, SimpleButton71.Click, SimpleButton70.Click, SimpleButton64.Click, SimpleButton63.Click, SimpleButton62.Click, SimpleButton61.Click, SimpleButton60.Click, SimpleButton6.Click, SimpleButton54.Click, SimpleButton53.Click, SimpleButton52.Click, SimpleButton50.Click, SimpleButton5.Click, SimpleButton45.Click, SimpleButton4.Click, SimpleButton35.Click, SimpleButton32.Click, SimpleButton3.Click, SimpleButton24.Click, SimpleButton23.Click, SimpleButton22.Click, SimpleButton21.Click, SimpleButton20.Click, SimpleButton2.Click, SimpleButton19.Click, SimpleButton15.Click, SimpleButton14.Click, SimpleButton12.Click, SimpleButton1.Click, Bt_110.Click, Bt_109.Click, Bt_108.Click, Bt_107.Click, Bt_106.Click, Bt_105.Click, Bt_104.Click, Bt_103.Click, Bt_102.Click, Bt_101.Click
        newEdit.EditValue = newEdit.EditValue + sender.text
    End Sub

    Private Sub Edit_Data_Click(sender As Object, e As EventArgs) Handles Ed_Phone.Click, Ed_Name.Click, Ed_HP.Click, Ed_City.Click, Ed_Address.Click
        Panel_Alphabet.Enabled = True
        Panel_Number.Enabled = True

        If (sender.name = "ed_Phone" Or sender.name = "ed_HP") Then
            Panel_Alphabet.Enabled = False
        End If
        newEdit = sender
    End Sub

    Private Sub SB_NumberEnter_Click(sender As Object, e As EventArgs) Handles SB_NumberEnter.Click, SB_AlphabetEnter.Click
        Panel_Alphabet.Enabled = False
        Panel_Number.Enabled = False
    End Sub


    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click
        Try

            If (LookUpEdit_Employee.Text = "") Then
                MessageBox.Show("Silakan Terlebih Dahulu Memilih Pengantar")
                Exit Sub
            End If
            Dim OrderDeliveryID As Integer
            OrderDeliveryID = Me.QueriesTableAdapter.sp_POSTransactionDelivery_InsData(0, Ed_Name.EditValue, Ed_Address.EditValue, Ed_Phone.EditValue, Ed_HP.EditValue, Ed_City.EditValue, LookUpEdit_Employee.EditValue, UserModified)


            Dim FrmMenu As DevExpress.XtraEditors.XtraForm
            FrmMenu = New Frm_Front_old(Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderID(Today, sender.tag),
                                    Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderNo(Today, sender.tag),
                                    0, Ed_Name.EditValue, OrderDeliveryID, 3)
            FrmMenu.ShowDialog()
            If (FrmMenu.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmMenu.Dispose()
                Me.Dispose()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frm_CustomerEnter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_MDEmployee_GetData' table. You can move, or remove it, as needed.
        Me.Sp_POS_MDEmployee_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDEmployee_GetData)
        Sp_POSOrderDelivery_GetDataHistoryTableAdapter.Fill(Me.DataSet.sp_POSOrderDelivery_GetDataHistory, "")


        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName


    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub GV_History_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GV_History.RowClick
        Ed_Name.EditValue = GV_History.GetFocusedRowCellValue(colName)
        Ed_Address.EditValue = GV_History.GetFocusedRowCellValue(colAddress)
        Ed_Phone.EditValue = GV_History.GetFocusedRowCellValue(colPhone)
        Ed_HP.EditValue = GV_History.GetFocusedRowCellValue(colHP)
        Ed_City.EditValue = GV_History.GetFocusedRowCellValue(colCity)
    End Sub

    Private Sub SB_Reset_Click(sender As Object, e As EventArgs) Handles SB_Reset.Click
        Ed_Name.EditValue = ""
        Ed_Address.EditValue = ""
        Ed_Phone.EditValue = ""
        Ed_HP.EditValue = ""
        Ed_City.EditValue = ""
    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        Try
            Me.Sp_POSOrderDelivery_GetDataHistoryTableAdapter.Fill(Me.DataSet.sp_POSOrderDelivery_GetDataHistory, Ed_Name.EditValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class