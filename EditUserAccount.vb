Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class EditUserAccount

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable
    Private UpdationId As String

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub BackPictureBox_Click(sender As Object, e As EventArgs) Handles BackPictureBox.Click

        Dim ua As New UserAccount()
        ua.Show()
        Me.Hide()

    End Sub

    Private Sub EditUserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        PopulateTextBoxes()

    End Sub

    Private Sub PopulateTextBoxes()

        Try

            cmd = New SqlCommand("EXEC displayUserRecord @u;", conn)
            cmd.Parameters.AddWithValue("@u", UserDetails.Username)

            conn.Open()

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            UpdationId = dt.Rows(0)("UserId").ToString()
            UsernameBox.Text = dt.Rows(0)("Username").ToString()
            PasswordBox.Text = dt.Rows(0)("UserPassword").ToString()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Function ValidateData() As Boolean

        Dim UsernameRegex As New Regex("^[A-Za-z ]+$")

        If String.IsNullOrWhiteSpace(UsernameBox.Text) Then

            MessageBox.Show("Username Cannot be Blank", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf Not UsernameRegex.IsMatch(UsernameBox.Text) Then

            MessageBox.Show("Username is Invalid (Enter only Letters)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf String.IsNullOrWhiteSpace(PasswordBox.Text) Then

            MessageBox.Show("Password Cannot be Blank", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        ElseIf PasswordBox.Text.Length < 8 Then

            MessageBox.Show("Password is too Short (Must be atleast 8 Characters)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False

        End If

        Return True

    End Function

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        If ValidateData() = False Then

            Return

        End If

        Try

            cmd = New SqlCommand("EXEC udpateUserRecord @id, @u, @p;", conn)
            cmd.Parameters.AddWithValue("@id", UpdationId)
            cmd.Parameters.AddWithValue("@u", UsernameBox.Text)
            cmd.Parameters.AddWithValue("@p", PasswordBox.Text)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Account Updated, Please Login Again...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim lf As New LoginForm()
            lf.Show()
            Me.Hide()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub
End Class