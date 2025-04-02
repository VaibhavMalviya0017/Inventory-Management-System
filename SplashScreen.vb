Public Class SplashScreen

    Private Sub SplashScreenTimer_Tick(sender As Object, e As EventArgs) Handles SplashScreenTimer.Tick

        If MainPanel.Width >= BackgroundPanel.Width Then

            SplashScreenTimer.Stop()
            Dim lf As New LoginForm()
            lf.Show()
            Me.Hide()

        Else

            MainPanel.Width += 5

        End If

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
