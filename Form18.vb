Imports MySql.Data.MySqlClient

Public Class Form18
    Private Sub Button2_Click(sender As Object, e As EventArgs)

        MessageBox.Show("Hello, this is a message box!", "Message Box Title", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Server=localhost;Database=fdsproject_g11;User ID=root;Password=;Pooling=false;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM receipttable"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.Hide()
        Form19.Show()
    End Sub
End Class