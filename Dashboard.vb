Imports System.Data.SqlClient

Public Class Dashboard

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)

        Try

            conn.Open()

            cmd = New SqlCommand("SELECT COUNT(*) FROM Products;", conn)
            Dim ProductsCount = cmd.ExecuteScalar()

            cmd = New SqlCommand("SELECT COUNT(*) FROM Orders;", conn)
            Dim OrdersCount = cmd.ExecuteScalar()

            cmd = New SqlCommand("SELECT COUNT(*) FROM Customers;", conn)
            Dim CustomersCount = cmd.ExecuteScalar()

            cmd = New SqlCommand("SELECT COUNT(*) FROM Sellers;", conn)
            Dim SellersCount = cmd.ExecuteScalar()

            CustomersLabel.Text += CustomersCount.ToString()
            SellersLabel.Text += SellersCount.ToString()
            OrdersLabel.Text += OrdersCount.ToString()
            ProductsLabel.Text += ProductsCount.ToString()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub CustomersPictureBox_Click(sender As Object, e As EventArgs) Handles CustomersPictureBox.Click

        Dim cust As New Customers()
        cust.Show()
        Me.Hide()

    End Sub

    Private Sub LogoutPictureBox_Click(sender As Object, e As EventArgs) Handles LogoutPictureBox.Click

        Dim lf As New LoginForm()
        lf.Show()
        Me.Hide()

    End Sub

    Private Sub SellersPictureBox_Click(sender As Object, e As EventArgs) Handles SellersPictureBox.Click

        Dim sellers As New Sellers()
        sellers.Show()
        Me.Hide()

    End Sub

    Private Sub ProductsPictureBox_Click(sender As Object, e As EventArgs) Handles ProductsPictureBox.Click

        Dim prod As New Products()
        prod.Show()
        Me.Hide()

    End Sub

    Private Sub AccountPictureBox_Click(sender As Object, e As EventArgs) Handles AccountPictureBox.Click

        Dim ua As New UserAccount()
        ua.Show()
        Me.Hide()

    End Sub

    Private Sub OrdersPictureBox_Click(sender As Object, e As EventArgs) Handles OrdersPictureBox.Click

        Dim ord As New Orders()
        ord.Show()
        Me.Hide()

    End Sub
End Class