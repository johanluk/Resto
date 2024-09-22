Public Class Frm_TransactionDaily
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        DateEdit_Date.DateTime = Now
        DateEdit_Time.DateTime = Now
    End Sub
End Class