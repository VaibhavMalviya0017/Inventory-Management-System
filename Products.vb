Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Products

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        PopulateGridView()
        ResizeGridViewColumns()

    End Sub

    Private Sub ResizeGridViewColumns()

        ProductsGridView.Columns("DeleteColumn").Width = 115
        ProductsGridView.Columns("UpdateColumn").Width = 115
        ProductsGridView.Columns("ProductID").Width = 135
        ProductsGridView.Columns("Quantity").Width = 175

    End Sub

    Private Sub ClearAllTextBoxes()

        NameBox.Clear()
        PriceBox.Clear()
        QuantityBox.Clear()

    End Sub

    Private Sub PopulateGridView()

        Try

            conn.Open()
            cmd = New SqlCommand("EXEC displayAllProducts", conn)

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            If dt.Rows.Count = 0 Then

                NoDataPanel.Visible = True
                ProductsGridView.Visible = False

            Else

                NoDataPanel.Visible = False
                ProductsGridView.Visible = True

            End If

            ProductsGridView.DataSource = dt

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Function ValidateData() As Boolean

        Dim NameRegex As New Regex("^[A-Za-z0-9 ]+$")
        Dim QuantityRegex As New Regex("^[0-9]+$")
        Dim PriceRegex As New Regex("^\d{1,10}(\.\d{1,2})?$") ' This one is done by ChatGPT

        If String.IsNullOrWhiteSpace(NameBox.Text) Then

            MessageBox.Show("Product Name Cannot be Blank", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf Not NameRegex.IsMatch(NameBox.Text) Then

            MessageBox.Show("Please Enter a Valid Name (Only Letters / Digits)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf String.IsNullOrWhiteSpace(PriceBox.Text) Then

            MessageBox.Show("Price Cannot be Blank", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf Not PriceRegex.IsMatch(PriceBox.Text) Then

            MessageBox.Show("Please Enter a Valid Price (E.g. 1200.00 or 1200)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf String.IsNullOrWhiteSpace(QuantityBox.Text) Then

            MessageBox.Show("Quantity Cannot be Blank", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf Not QuantityRegex.IsMatch(QuantityBox.Text) Then

            MessageBox.Show("Please Enter a Valid Quantity", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        End If

        Return True

    End Function

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If ValidateData() = False Then

            Return

        End If

        Try

            cmd = New SqlCommand("EXEC addNewProduct @n, @p, @q;", conn)
            cmd.Parameters.AddWithValue("@n", NameBox.Text)
            cmd.Parameters.AddWithValue("@p", PriceBox.Text)
            cmd.Parameters.AddWithValue("@q", QuantityBox.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Product Data Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearAllTextBoxes()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()
            PopulateGridView()

        End Try

    End Sub

    Private Sub ClearAllRecordsButton_Click(sender As Object, e As EventArgs) Handles ClearAllRecordsButton.Click

        Try

            If MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then

                Return

            End If

            cmd = New SqlCommand("EXEC deleteAllProductRecords;", conn)
            conn.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()
            PopulateGridView()

        End Try

    End Sub

    Private Sub ProductsGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsGridView.CellContentClick

        If e.ColumnIndex.Equals(0) Then

            Try

                If MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then

                    Return

                End If

                Dim DeletionId = ProductsGridView.Rows(e.RowIndex).Cells("ProductID").Value.ToString()

                cmd = New SqlCommand("EXEC deleteProductRecord @id;", conn)
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

        If e.ColumnIndex.Equals(1) Then

            Try

                Dim UpdationId = ProductsGridView.Rows(e.RowIndex).Cells("ProductID").Value.ToString()

                Dim updateProd As New UpdateProduct()

                updateProd.GetUpdationId(UpdationId)

                updateProd.Show()
                Me.Hide()

            Catch ex As Exception

                ' No need to code here - reason for exception handling:
                ' If the user clicks on the gridview header, it will raise an error

            End Try

        End If

    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

        Try

            conn.Open()

            cmd = New SqlCommand("EXEC searchProductByName @n;", conn)
            cmd.Parameters.AddWithValue("@n", SearchBox.Text + "%")

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            ProductsGridView.DataSource = dt

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub BackPictureBox_Click(sender As Object, e As EventArgs) Handles BackPictureBox.Click

        Dim db As New Dashboard()
        db.Show()
        Me.Hide()

    End Sub
End Class