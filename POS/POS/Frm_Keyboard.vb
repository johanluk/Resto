Public Class Frm_Keyboard 


    Dim OrderTypeID As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal OrderType As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        OrderTypeID = OrderType

        If (OrderType = 2) Then
            Label_Title.Text = "Input Customer Name"
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub Frm_Keyboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim leb As Integer
        leb = EmptySpaceItem3.Width + EmptySpaceItem4.Width
        EmptySpaceItem3.Width = leb / 2
        EmptySpaceItem4.Width = leb / 2
    End Sub

    Private Sub Bt_101_Click(sender As Object, e As EventArgs) Handles Bt_101.Click, SimpleButton9.Click, SimpleButton8.Click, SimpleButton72.Click, SimpleButton71.Click, SimpleButton70.Click, SimpleButton7.Click, SimpleButton65.Click, SimpleButton64.Click, SimpleButton63.Click, SimpleButton62.Click, SimpleButton61.Click, SimpleButton60.Click, SimpleButton6.Click, SimpleButton54.Click, SimpleButton53.Click, SimpleButton52.Click, SimpleButton50.Click, SimpleButton5.Click, SimpleButton45.Click, SimpleButton42.Click, SimpleButton4.Click, SimpleButton35.Click, SimpleButton33.Click, SimpleButton32.Click, SimpleButton3.Click, SimpleButton28.Click, SimpleButton24.Click, SimpleButton23.Click, SimpleButton22.Click, SimpleButton21.Click, SimpleButton20.Click, SimpleButton2.Click, SimpleButton19.Click, SimpleButton16.Click, SimpleButton15.Click, SimpleButton14.Click, SimpleButton12.Click, SimpleButton10.Click, SimpleButton1.Click, Bt_110.Click, Bt_109.Click, Bt_108.Click, Bt_107.Click, Bt_106.Click, Bt_105.Click, Bt_104.Click, Bt_103.Click, Bt_102.Click, Bt_100.Click
        Ed_Input.EditValue = Ed_Input.EditValue + sender.text
    End Sub

    Private Sub SB_Enter_Click(sender As Object, e As EventArgs) Handles SB_Enter.Click
        If (OrderTypeID = 2) Then
            Dim FrmMenu As DevExpress.XtraEditors.XtraForm
            FrmMenu = New Frm_Front_old(Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderID(Today, sender.tag),
                                    Me.QueriesTableAdapter.sp_POSOrderHeader_GetOrderNo(Today, sender.tag),
                                     0, Ed_Input.EditValue, OrderTypeID)
            FrmMenu.ShowDialog()
            If (FrmMenu.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                FrmMenu.Close()
            End If
        End If

        
        
    End Sub

    Private Sub SB_BackSpace_Click(sender As Object, e As EventArgs) Handles SB_BackSpace.Click
        Ed_Input.EditValue = Ed_Input.EditValue.ToString.Substring(0, IIf(Len(Ed_Input.EditValue) - 1 < 0, 0, Len(Ed_Input.EditValue) - 1))
    End Sub

    Private Sub SB_Space_Click(sender As Object, e As EventArgs) Handles SB_Space.Click
        Ed_Input.EditValue = Ed_Input.EditValue + " "
    End Sub

    Private Sub SB_Close_Click(sender As Object, e As EventArgs) Handles SB_Close.Click
        Me.Close()
    End Sub
End Class