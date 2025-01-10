Imports MySql.Data.MySqlClient

Public Class Form13
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Server=localhost;Database=fdsproject_g11;User ID=root;Password=;Pooling=false;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM fines"
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

        Using adapter As New MySqlDataAdapter("SELECT * from fines", connection)
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

                Dim query As String = "INSERT INTO fines (FINE_ID, DUE_DATE, RETURN_DATE, FINE_AMT) VALUES (@Fine_ID, @Due_Date, @Return_Date, @Fine_Amt)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Fine_ID", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Fine_Amt", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@Due_Date", DateTimePicker1.Value)
                    cmd.Parameters.AddWithValue("@Return_Date", DateTimePicker2.Value)

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
                Dim cmd As New MySqlCommand("UPDATE fines SET DUE_DATE = @Due_Date, RETURN_DATE = @Return_Date, FINE_AMT = @Fine_Amt WHERE FINE_ID = @Fine_ID", connection)
                cmd.Parameters.AddWithValue("@Fine_ID", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Fine_Amt", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Due_Date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@Return_Date", DateTimePicker2.Value)

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
            Dim id As Integer = DataGridView1.SelectedRows(0).Cells("FINE_ID").Value

            Try
                connection.Open()
                Dim query As String = "DELETE FROM fines WHERE FINE_ID=@Fine_ID"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Fine_ID", id)
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
                        Dim query As String = "UPDATE fines SET DUE_DATE = @Due_Date, RETURN_DATE = @Return_Date, FINE_AMT = @Fine_Amt WHERE FINE_ID = @Fine_ID"
                        Using cmd As New MySqlCommand(query, connection)
                            cmd.Parameters.AddWithValue("@Fine_Amt", row.Cells("FINE_AMT").Value.ToString())
                            cmd.Parameters.AddWithValue("@Due_Date", row.Cells("DUE_DATE").Value.ToString())
                            cmd.Parameters.AddWithValue("@Return_Date", row.Cells("RETURN_DATE").Value.ToString())
                            cmd.Parameters.AddWithValue("@Fine_ID", row.Cells("FINE_ID").Value.ToString())
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
        Form12.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            Dim fineId As String = selectedRow.Cells("FINE_ID").Value.ToString()
            Dim dueDate As String = selectedRow.Cells("DUE_DATE").Value.ToString()
            Dim returnDate As String = selectedRow.Cells("RETURN_DATE").Value.ToString()
            Dim fineAmt As String = selectedRow.Cells("FINE_AMT").Value.ToString()

            Dim receiptMessage As String = String.Format("Receipt Information:{0}Fine ID: {1}{0}Due Date: {2}{0}Return Date: {3}{0}Fine Amount: {4}",
                                                           Environment.NewLine, fineId, dueDate, returnDate, fineAmt)

            MessageBox.Show(receiptMessage, "Receipt Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a row to view the receipt.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class