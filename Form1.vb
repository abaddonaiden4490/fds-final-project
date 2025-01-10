Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldatatime.Text = Date.Now.ToString("MMMM - dd - yyyy    hh:mm:ss ")
    End Sub

    Private Sub btnpersonal_Click(sender As Object, e As EventArgs) Handles btnpersonal.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btninfo_Click(sender As Object, e As EventArgs) Handles btninfo.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
