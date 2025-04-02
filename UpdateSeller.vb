Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class UpdateSeller

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable
    Private UpdationId As String

    Private Sub UpdateSeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        PopulateTextBoxes()

    End Sub

    Private Sub PopulateTextBoxes()

        Try

            cmd = New SqlCommand("EXEC getSellerById @id;", conn)
            cmd.Parameters.AddWithValue("@id", Me.UpdationId)

            conn.Open()

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            NameBox.Text = dt.Rows(0)("SellerName").ToString()
            EmailBox.Text = dt.Rows(0)("SellerEmail").ToString()
            PhoneNumberBox.Text = dt.Rows(0)("SellerContact").ToString()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Public Sub GetUpdationId(ByVal UpdationId As String)

        Me.UpdationId = UpdationId

    End Sub

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub BackPictureBox_Click(sender As Object, e As EventArgs) Handles BackPictureBox.Click

        Dim sellers As New Sellers()
        sellers.Show()
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

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        If ValidateData() = False Then

            Return

        End If

        Try

            cmd = New SqlCommand("EXEC updateSeller @id, @n, @e, @p;", conn)
            cmd.Parameters.AddWithValue("@id", Me.UpdationId)
            cmd.Parameters.AddWithValue("@n", NameBox.Text)
            cmd.Parameters.AddWithValue("@e", EmailBox.Text)
            cmd.Parameters.AddWithValue("@p", PhoneNumberBox.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Seller Data Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim sellers As New Sellers()
            sellers.Show()
            Me.Hide()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub
End Class