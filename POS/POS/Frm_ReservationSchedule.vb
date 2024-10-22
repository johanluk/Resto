Public Class Frm_ReservationSchedule 

    Public Sub New()



        ' This call is required by the designer.
        InitializeComponent()

        SetDefaultComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal TableID As Integer)

        InitializeComponent()

        LookUpEdit1.EditValue = TableID

        SetDefaultComponent()
    End Sub

    Sub SetDefaultComponent()
        Date_Start.DateTime = Today
        Date_End.DateTime = Today
    End Sub
    Private Sub Frm_ReservationSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Sp_POS_MDTableReservation_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_MDTableReservation_GetData)
        SB_Next.Enabled = False
    End Sub

    Private Sub SB_Filter_Click(sender As Object, e As EventArgs) Handles SB_Filter.Click
        Try
            Me.Sp_POSReservationHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_POSReservationHeader_GetData, Date_Start.DateTime, Date_End.DateTime, LookUpEdit1.EditValue)
            If (GV_Reservation.RowCount > 0) Then
                SB_Next.Enabled = False
            Else
                SB_Next.Enabled = True
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Me.Close()
    End Sub

    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click
        Dim FrmMenu As DevExpress.XtraEditors.XtraForm
        FrmMenu = New Frm_Front_old(Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderID(Today, sender.tag),
                                Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderNo(Today, sender.tag).ToString,
                                LookUpEdit1.EditValue, LookUpEdit1.Text, 11,
                                Date_Start.DateTime, Date_End.DateTime)
        FrmMenu.ShowDialog()
    End Sub
End Class