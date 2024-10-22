Imports System.Windows.Forms

Public Class Dialog_OrderType


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

        Me.Close()
    End Sub


    Dim ButtonCheck As Integer = 0
    Dim UserModified As String = ""
    Sub New(_ButtonCheck As Integer, _UserModifed As String)

        ' This call is required by the designer.
        InitializeComponent()
        ButtonCheck = _ButtonCheck
        RadioGroup_OrderType.DeselectAll()
        'SearchLookUpEdit_Server.Visible = True
        RadioGroup_OrderType.SelectedIndex = -1
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Dialog_OrderType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetTableList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetTableListTableAdapter.Fill(Me.DataSet.sp_POS_GetTableList)
        'TODO: This line of code loads data into the 'DataSet.sp_POS_GetServerList' table. You can move, or remove it, as needed.
        Me.Sp_POS_GetServerListTableAdapter.Fill(Me.DataSet.sp_POS_GetServerList)

    End Sub

    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click
        Try
            If (LookUpEdit_Table.EditValue = 0) Then
                Throw New System.Exception("Meja Belum Dipilih")
            End If
            If (ButtonCheck = 0) Then
                Throw New System.Exception("Jenis Pelanggan Belum Dipilih")
            End If
            If (IsDBNull(SearchLookUpEdit_Server.EditValue)) Then
                Throw New System.Exception("Waiter Belum Dipilih")
            End If

            If (IsDBNull(SearchLookUpEdit_Server) = False) Then
                ButtonCheck = RadioGroup_OrderType.SelectedIndex + 1
                If (ButtonCheck = 0) Then
                    'Dim FrmOrder As DevExpress.XtraEditors.XtraForm
                    'FrmOrder = New Frm_Order_TableChoose(1)
                    'FrmOrder.ShowDialog()
                    'If (FrmOrder.DialogResult = System.Windows.Forms.DialogResult.OK) Then
                    '    FrmOrder.Close()
                    'End If
                ElseIf (ButtonCheck = 1) Then
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        LookUpEdit_Table.EditValue, LookUpEdit_Table.Text,
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified)

                ElseIf (ButtonCheck = 2) Then
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        0, "-",
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified
                )

                ElseIf (ButtonCheck = 31) Then
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        0, "-",
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified
                )
                Else
                    Me.QueriesTableAdapter.sp_POS_OrderHeader_Input(Now,
                                                        ButtonCheck,
                                                        0, 0,
                                                        SearchLookUpEdit_Server.EditValue,
                                                        0, 0, 0,
                                                        UserModified)
                End If
            End If
            Frm_Order._ServerID = SearchLookUpEdit_Server.EditValue
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

            Me.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally




        End Try
    End Sub

    Private Sub Dialog_OrderType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class
