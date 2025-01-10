Imports MySql.Data.MySqlClient

Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Server=localhost;Database=fdsproject_g11;User ID=root;Password=;Pooling=false;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM salary"
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

        Using adapter As New MySqlDataAdapter("SELECT * from salary", connection)
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

                Dim query As String = "INSERT INTO salary (SALARY_ID, Staff_STAFF_ID, SALARY_AMT) VALUES (@Salary_ID, @Staff_Staff_ID, @Salary_Amt)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Salary_ID", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Staff_Staff_ID", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Salary_Amt", TextBox3.Text)

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
                Dim cmd As New MySqlCommand("UPDATE salary SET Staff_STAFF_ID = @Staff_Staff_ID, SALARY_AMT = @Salary_Amt WHERE SALARY_ID = @Salary_ID", connection)
                cmd.Parameters.AddWithValue("@Salary_ID", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Staff_Staff_ID", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Salary_Amt", TextBox3.Text)

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
            Dim id As Integer = DataGridView1.SelectedRows(0).Cells("SALARY_ID").Value

            Try
                connection.Open()
                Dim query As String = "DELETE FROM salary WHERE SALARY_ID=@Salary_ID"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Salary_ID", id)
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
                        Dim query As String = "UPDATE salary SET Staff_STAFF_ID = @Staff_Staff_ID, SALARY_AMT = @Salary_Amt WHERE SALARY_ID = @Salary_ID"
                        Using cmd As New MySqlCommand(query, connection)
                            cmd.Parameters.AddWithValue("@Staff_Staff_ID", row.Cells("Staff_STAFF_ID").Value.ToString())
                            cmd.Parameters.AddWithValue("@Salary_Amt", row.Cells("SALARY_AMT").Value.ToString())
                            cmd.Parameters.AddWithValue("@Salary_ID", row.Cells("SALARY_ID").Value.ToString())
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
        Form16.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.Hide()
        Form18.Show()
    End Sub
End Class