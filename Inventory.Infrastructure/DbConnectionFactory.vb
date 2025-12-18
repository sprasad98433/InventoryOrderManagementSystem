Imports Microsoft.Data.SqlClient
Imports Inventory.Infrastructure.Config

Public Class DbConnectionFactory

    Public Shared Function Create() As SqlConnection
        Dim connStr As String =
            AppConfiguration.GetConnectionString("DBConn")

        Return New SqlConnection(connStr)
    End Function

End Class

