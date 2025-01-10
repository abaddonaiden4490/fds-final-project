Public Class Form20
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
            MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Logout canceled.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class