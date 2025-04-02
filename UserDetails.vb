Public Class UserDetails

    Private Shared LoggedInUsername As String

    Public Shared Property Username As String

        Get

            Return LoggedInUsername

        End Get

        Set(ByVal value As String)

            LoggedInUsername = value

        End Set

    End Property

End Class