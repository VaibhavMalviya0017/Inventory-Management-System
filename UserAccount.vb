Imports System.Data.SqlClient

Public Class UserAccount

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private sda As SqlDataAdapter
    Private dt As DataTable

    Private Sub UserAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(Connection.GetString)
        PopulateLabelWithData()

    End Sub

    Private Sub PopulateLabelWithData()

        Try

            cmd = New SqlCommand("EXEC displayUserRecord @u;", conn)
            cmd.Parameters.AddWithValue("@u", UserDetails.Username)

            conn.Open()

            sda = New SqlDataAdapter(cmd)
            dt = New DataTable()

            sda.Fill(dt)

            UsernameLabel.Text = dt.Rows(0)("Username").ToString()
            PasswordLabel.Text = dt.Rows(0)("UserPassword").ToString()

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

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Try

            If MessageBox.Show("Are You Sure? This Action Cannot be Undone", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.Cancel Then

                Return

            End If

            cmd = New SqlCommand("EXEC deleteUserRecord @u;", conn)
            cmd.Parameters.AddWithValue("@u", UserDetails.Username)

            conn.Open()

            cmd.ExecuteNonQuery()

            MessageBox.Show("Your Account has Been Successfully Deleted...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim lf As New LoginForm
            lf.Show()
            Me.Hide()

        Catch ex As Exception

            MessageBox.Show("An Error Ocurred: " + ex.Message + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            conn.Close()

        End Try

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        Dim eua As New EditUserAccount()
        eua.Show()
        Me.Hide()

    End Sub
End Class