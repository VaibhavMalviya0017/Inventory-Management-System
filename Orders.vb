Imports System.Data.SqlClient

Public Class Orders

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable

    Private Sub PopulateGridView()

        Try

            conn.Open()
            cmd = New SqlCommand("EXEC displayAllOrders;", conn)

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            If dt.Rows.Count = 0 Then

                OrdersGridView.Visible = False
                NoDataPanel.Visible = True

            Else

                OrdersGridView.Visible = True
                NoDataPanel.Visible = False

            End If

            OrdersGridView.DataSource = dt

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub BackPictureBox_Click(sender As Object, e As EventArgs) Handles BackPictureBox.Click

        Dim db As New Dashboard()
        db.Show()
        Me.Hide()

    End Sub

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        PopulateGridView()

    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click

        Dim cord As New CreateOrder()
        cord.Show()
        Me.Hide()

    End Sub

    Private Sub OrdersGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersGridView.CellContentClick

        If e.ColumnIndex.Equals(0) Then

            Try

                If MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then

                    Return

                End If

                Dim DeletionId = OrdersGridView.Rows(e.RowIndex).Cells("OrderID").Value.ToString()

                cmd = New SqlCommand("EXEC deleteOrderRecord @id;", conn)
                cmd.Parameters.AddWithValue("@id", DeletionId)

                conn.Open()

                cmd.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally

                conn.Close()
                PopulateGridView()

            End Try

        End If

    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click

        Try

            If MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then

                Return

            End If

            cmd = New SqlCommand("EXEC deleteAllOrders;", conn)

            conn.Open()

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()
            PopulateGridView()

        End Try

    End Sub
End Class