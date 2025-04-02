Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class Customers

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        PopulateGridView()
        ResizeGridViewColumns()

    End Sub

    Private Sub ClearAllTextBoxes()

        NameBox.Clear()
        EmailBox.Clear()
        PhoneNumberBox.Clear()

    End Sub

    Private Sub ResizeGridViewColumns()

        CustomersGridView.Columns("DeleteColumn").Width = 115
        CustomersGridView.Columns("UpdateColumn").Width = 115
        CustomersGridView.Columns("CustomerID").Width = 135
        CustomersGridView.Columns("CustomerName").Width = 175

    End Sub

    Private Sub PopulateGridView()

        Try

            conn.Open()
            cmd = New SqlCommand("EXEC displayAllCustomers", conn)

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            If dt.Rows.Count = 0 Then

                NoDataPanel.Visible = True
                CustomersGridView.Visible = False

            Else

                NoDataPanel.Visible = False
                CustomersGridView.Visible = True

            End If

            CustomersGridView.DataSource = dt

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

    Private Function IsValidMail(ByVal EmailAddress As String) As Boolean

        Try

            Dim MailObject As New MailAddress(EmailAddress)
            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Private Function ValidateData() As Boolean

        Dim NameRegex As New Regex("^[A-Za-z ]+$")
        Dim PhoneNumberRegex As New Regex("^[0-9]{10}$")

        If String.IsNullOrWhiteSpace(NameBox.Text) Then

            MessageBox.Show("Name Cannot be Blank", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf Not NameRegex.IsMatch(NameBox.Text) Then

            MessageBox.Show("Please Enter a Valid Name (Only Letters)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf String.IsNullOrWhiteSpace(EmailBox.Text) Then

            MessageBox.Show("Email Address Cannot be Blank", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf IsValidMail(EmailBox.Text) = False Then

            MessageBox.Show("Please Enter a Valid Email Address", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf String.IsNullOrWhiteSpace(PhoneNumberBox.Text) Then

            MessageBox.Show("Phone Number Cannot be Blank", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf Not PhoneNumberRegex.IsMatch(PhoneNumberBox.Text) Then

            MessageBox.Show("Please Enter a Valid (Indian) Phone Number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        End If

        Return True

    End Function

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If ValidateData() = False Then

            Return

        End If

        Try

            cmd = New SqlCommand("EXEC addNewCustomer @n, @e, @p;", conn)
            cmd.Parameters.AddWithValue("@n", NameBox.Text)
            cmd.Parameters.AddWithValue("@e", EmailBox.Text)
            cmd.Parameters.AddWithValue("@p", PhoneNumberBox.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Customer Data Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearAllTextBoxes()

        Catch ex As Exception

            MessageBox.Show("Such a Username Already Exists, Please Try Something Else...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()
            PopulateGridView()

        End Try

    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged

        Try

            conn.Open()

            cmd = New SqlCommand("EXEC searchCustomerByName @n;", conn)
            cmd.Parameters.AddWithValue("@n", SearchBox.Text + "%")

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            CustomersGridView.DataSource = dt

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub CustomersGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomersGridView.CellContentClick

        If e.ColumnIndex.Equals(0) Then

            Try

                If MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then

                    Return

                End If

                Dim DeletionId = CustomersGridView.Rows(e.RowIndex).Cells("CustomerID").Value.ToString()

                cmd = New SqlCommand("EXEC deleteCustomerRecord @id;", conn)
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

                Dim UpdationId = CustomersGridView.Rows(e.RowIndex).Cells("CustomerID").Value.ToString()

                Dim UpdateCust As New UpdateCustomer()

                UpdateCust.GetUpdationId(UpdationId)

                UpdateCust.Show()
                Me.Hide()

            Catch ex As Exception

                ' No need to code here - reason for exception handling:
                ' If the user clicks on the gridview header, it will raise an error

            End Try

        End If

    End Sub

    Private Sub ClearAllRecordsButton_Click(sender As Object, e As EventArgs) Handles ClearAllRecordsButton.Click

        Try

            If MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.Cancel Then

                Return

            End If

            cmd = New SqlCommand("EXEC deleteAllCustomerRecords;", conn)
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