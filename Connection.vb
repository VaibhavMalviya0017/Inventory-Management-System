Public Class Connection

    Private Shared ConnectionString As String = "Data Source=LAPTOP-M333SSCP\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True"

    Public Shared ReadOnly Property GetString

        Get

            Return ConnectionString

        End Get

    End Property

End Class
