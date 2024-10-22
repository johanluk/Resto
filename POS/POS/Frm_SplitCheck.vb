Public Class Frm_SplitCheck 

    Private Sub Frm_SplitCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LayoutControlItem13.Width = ((Me.Width - 20) / 4)
        LayoutControlItem8.Width = ((Me.Width - 20) / 4)
        LayoutControlItem9.Width = ((Me.Width - 20) / 4)
        LayoutControlItem10.Width = ((Me.Width - 20) / 4)
        Shape_Header.Width = Me.Width - 40 - ((Me.Width - 20) / 4)
        Label_Header.Width = Me.Width - 80 - ((Me.Width - 20) / 4)
    End Sub
End Class