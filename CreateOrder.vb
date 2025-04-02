Imports System.Data.SqlClient

Public Class CreateOrder

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub BackPictureBox_Click(sender As Object, e As EventArgs) Handles BackPictureBox.Click

        Dim ord As New Orders()
        ord.Show()
        Me.Hide()

    End Sub

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        OrderDatePicker.Value = DateTime.Today

    End Sub

    Private Sub CustomerIdBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIdBox.TextChanged

        Try

            cmd = New SqlCommand("EXEC getCustomerById @id;", conn)
            cmd.Parameters.AddWithValue("@id", CustomerIdBox.Text)

            conn.Open()

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            CustomerNameLabel.Text = dt.Rows(0)("CustomerName").ToString()
            CustomerEmailLabel.Text = dt.Rows(0)("CustomerEmail").ToString()
            CustomerPhoneLabel.Text = dt.Rows(0)("CustomerContact").ToString()

        Catch ex As Exception

            CustomerNameLabel.Text = "No Data"
            CustomerEmailLabel.Text = "No Data"
            CustomerPhoneLabel.Text = "No Data"

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub ProductIdBox_TextChanged(sender As Object, e As EventArgs) Handles ProductIdBox.TextChanged

        Try

            cmd = New SqlCommand("EXEC getProductById @id;", conn)
            cmd.Parameters.AddWithValue("@id", ProductIdBox.Text)

            conn.Open()

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            ProductNameLabel.Text = dt.Rows(0)("ProductName").ToString()
            ProductPriceLabel.Text = dt.Rows(0)("Price").ToString()
            ProductQtyLabel.Text = dt.Rows(0)("Quantity").ToString()

        Catch ex As Exception

            ProductNameLabel.Text = "No Data"
            ProductPriceLabel.Text = "No Data"
            ProductQtyLabel.Text = "No Data"

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click

        If CustomerNameLabel.Text.Equals("No Data") Then

            MessageBox.Show("No Customer with such ID Exists, Please Verify it...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        ElseIf ProductNameLabel.Text.Equals("No Data") Then

            MessageBox.Show("No Product with such ID Exists, Please Verify it...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        ElseIf ProductQtyLabel.Text.Equals("0") Then

            MessageBox.Show("The Product Quantity is 0, It cannot be Issued", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        ElseIf String.IsNullOrWhiteSpace(QuantityBox.Text) Then

            MessageBox.Show("Product Quantity Cannot be Blank...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        ElseIf Integer.Parse(QuantityBox.Text) > Integer.Parse(ProductQtyLabel.Text) Then

            MessageBox.Show("The Product Quantity is Less the Asked for, Cannot create Order...", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        End If

        Try

            cmd = New SqlCommand("EXEC createNewOrder @cid, @pid, @od, @qty;", conn)
            cmd.Parameters.AddWithValue("@cid", CustomerIdBox.Text)
            cmd.Parameters.AddWithValue("@pid", ProductIdBox.Text)
            cmd.Parameters.AddWithValue("@od", OrderDatePicker.Value)
            cmd.Parameters.AddWithValue("@qty", QuantityBox.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Order Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show("An Error Occurred: " & ex.Message & "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

        Try

            cmd = New SqlCommand("EXEC decrementProductQuantity @qty, @pid;", conn)
            cmd.Parameters.AddWithValue("@pid", ProductIdBox.Text)
            cmd.Parameters.AddWithValue("@qty", QuantityBox.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show("An Error Occurred: " & ex.Message & "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

        Dim ord As New Orders()
        ord.Show()
        Me.Hide()

    End Sub

    Private Sub CustomerIdBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustomerIdBox.KeyPress

        If e.KeyChar >= "0"c And e.KeyChar <= "9"c Or e.KeyChar = ChrW(8) Then

            CustomerErrorLabel.Visible = False
            e.Handled = False

        Else
            CustomerErrorLabel.Visible = True
            e.Handled = True

        End If

    End Sub

    Private Sub ProductIdBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductIdBox.KeyPress

        If e.KeyChar >= "0"c And e.KeyChar <= "9"c Or e.KeyChar = ChrW(8) Then

            ProductErrorLabel.Visible = False
            e.Handled = False

        Else
            ProductErrorLabel.Visible = True
            e.Handled = True

        End If

    End Sub

    Private Sub QuantityBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityBox.KeyPress

        If e.KeyChar >= "0"c And e.KeyChar <= "9"c Or e.KeyChar = ChrW(8) Then

            QuantityErrorLabel.Visible = False
            e.Handled = False

        Else
            QuantityErrorLabel.Visible = True
            e.Handled = True

        End If

    End Sub

End Class