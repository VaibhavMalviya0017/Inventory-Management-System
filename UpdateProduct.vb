Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UpdateProduct

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable
    Private UpdationId As String

    Public Sub GetUpdationId(ByVal UpdationId As String)

        Me.UpdationId = UpdationId

    End Sub

    Private Sub UpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        PopulateTextBoxes()

    End Sub

    Private Sub PopulateTextBoxes()

        Try

            cmd = New SqlCommand("EXEC getProductById @id;", conn)
            cmd.Parameters.AddWithValue("@id", Me.UpdationId)

            conn.Open()

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            NameBox.Text = dt.Rows(0)("ProductName").ToString()
            PriceBox.Text = dt.Rows(0)("Price").ToString()
            QuantityBox.Text = dt.Rows(0)("Quantity").ToString()

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

        Dim prod As New Products()
        prod.Show()
        Me.Hide()

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

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        If ValidateData() = False Then

            Return

        End If

        Try

            cmd = New SqlCommand("EXEC updateProduct @id, @n, @p, @q;", conn)
            cmd.Parameters.AddWithValue("@id", Me.UpdationId)
            cmd.Parameters.AddWithValue("@n", NameBox.Text)
            cmd.Parameters.AddWithValue("@p", PriceBox.Text)
            cmd.Parameters.AddWithValue("@q", QuantityBox.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Product Data Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim prod As New Products()
            prod.Show()
            Me.Hide()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub
End Class