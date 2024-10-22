Imports System.Threading.Tasks
Imports DevExpress.XtraEditors

Public Class XtraForm1
    Private Sub AccordionControlElement3_Click(sender As Object, e As EventArgs) Handles AccordionControlElement3.Click

    End Sub

    Private Sub AccordionControlElement5_Click(sender As Object, e As EventArgs) Handles AccordionControlElement5.Click
        Dim a As New Frm_Order()
        a.MdiParent = Me

        a.WindowState = FormWindowState.Maximized
        a.Show()
    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class