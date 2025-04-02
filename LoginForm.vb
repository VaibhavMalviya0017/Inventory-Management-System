Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class LoginForm

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable
    Private Shared LoggedInUsername As String

    Private Sub ExitPictureBox_Click(sender As Object, e As EventArgs) Handles ExitPictureBox.Click

        Application.Exit()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conn = New SqlConnection("Data Source=LAPTOP-M333SSCP\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True")

    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged

        If ShowPasswordCheckBox.Checked = True Then

            PasswordBox.PasswordChar = Nothing

        Else

            PasswordBox.PasswordChar = "*"

        End If

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

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If ValidateData() = False Then

            Return

        End If

        Try

            cmd = New SqlCommand("EXEC verifyUserLogin @u, @p;", conn)
            cmd.Parameters.AddWithValue("@u", UsernameBox.Text)
            cmd.Parameters.AddWithValue("@p", PasswordBox.Text)

            conn.Open()

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            If dt.Rows.Count > 0 Then

                Dim StoredUsername = dt.Rows(0)("Username").ToString()
                Dim StoredPassword = dt.Rows(0)("UserPassword").ToString()

                If StoredUsername.Equals(UsernameBox.Text) And StoredPassword.Equals(PasswordBox.Text) Then

                    MessageBox.Show("Login Success, You'll be Redirected to the Dashboard", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    UserDetails.Username = StoredUsername
                    Dim db As New Dashboard()
                    db.Show()
                    Me.Hide()

                Else

                    MessageBox.Show("Login Failed, Please Try Checking Case Sensitivity", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If

            Else

                MessageBox.Show("Login Failed, Please Verify Your Username and Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub UsernameBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameBox.TextChanged

    End Sub
End Class