Imports MySql.Data.MySqlClient

Public Class Form11
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.Hide()
        Form12.Show()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Server=localhost;Database=fdsproject_g11;User ID=root;Password=;Pooling=false;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM bookcategory"
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

    Private Sub LoadDataIntoDataGridView()
        Dim connectionString As String = "Server=localhost;Database=fdsproject_g11;User ID=root;Password=;Pooling=false;"
        Dim connection As New MySqlConnection(connectionString)

        Using adapter As New MySqlDataAdapter("SELECT * from bookcategory", connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim connString As String = "server=localhost;user id=root;password=;database=fdsproject_g11"

        Using connection As New MySqlConnection(connString)
            Try
                connection.Open()

                Dim query As String = "INSERT INTO bookcategory (BookCategoryID, Book_BOOK_ID, Book_Publisher_PUB_ID, Category_CAT_ID) VALUES (@BookCategoryID, @Book_BOOK_ID, @Book_Publisher_PUB_ID, @Category_CAT_ID)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@BookCategoryID", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Book_BOOK_ID", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Book_Publisher_PUB_ID", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@Category_CAT_ID", TextBox4.Text)
                    cmd.ExecuteNonQuery()
                End Using

            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using

        LoadDataIntoDataGridView()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim connectionString As String = "Server=localhost;Database=fdsproject_g11;User ID=root;Password=;Pooling=false;"
        Dim connection As New MySqlConnection(connectionString)

        connection.Open()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim cmd As New MySqlCommand("UPDATE bookcategory SET Book_BOOK_ID = @Book_BOOK_ID, Book_Publisher_PUB_ID = @Book_Publisher_PUB_ID, Category_CAT_ID = @Category_CAT_ID WHERE BookCategoryID = @BookCategoryID", connection)
                cmd.Parameters.AddWithValue("@BookCategoryID", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Book_BOOK_ID", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Book_Publisher_PUB_ID", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Category_CAT_ID", TextBox4.Text)
                cmd.ExecuteNonQuery()
            End If
        Next
        MessageBox.Show("Data Updated Successfully!")

        LoadDataIntoDataGridView()
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        Dim connectionString As String = "server=localhost;user id=root;password=;database=fdsproject_g11"
        Dim connection As New MySqlConnection(connectionString)

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index
            Dim id As Integer = DataGridView1.SelectedRows(0).Cells("BookCategoryID").Value

            Try
                connection.Open()
                Dim query As String = "DELETE FROM bookcategory WHERE BookCategoryID=@BookCategoryID"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@BookCategoryID", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully")

                LoadData()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Please select a row to delete")
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim connectionString As String = "server=localhost;user id=root;password=;database=fdsproject_g11"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim query As String = "UPDATE bookcategory SET Book_BOOK_ID = @Book_BOOK_ID, Book_Publisher_PUB_ID = @Book_Publisher_PUB_ID, Category_CAT_ID = @Category_CAT_ID WHERE BookCategoryID = @BookCategoryID"
                        Using cmd As New MySqlCommand(query, connection)
                            cmd.Parameters.AddWithValue("@Book_BOOK_ID", row.Cells("Book_BOOK_ID").Value.ToString())
                            cmd.Parameters.AddWithValue("@Book_Publisher_PUB_ID", row.Cells("Book_Publisher_PUB_ID").Value.ToString())
                            cmd.Parameters.AddWithValue("@Category_CAT_ID", row.Cells("Category_CAT_ID").Value.ToString())
                            cmd.Parameters.AddWithValue("@BookCategoryID", row.Cells("BookCategoryID").Value.ToString())
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next

                MessageBox.Show("Changes saved successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving changes: " & ex.Message)
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Form10.Show()
    End Sub
End Class