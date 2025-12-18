Imports Microsoft.Extensions.Configuration

Public Class AppConfiguration

    Private Shared _config As IConfiguration

    Shared Sub New()
        _config = New ConfigurationBuilder() _
            .SetBasePath(AppContext.BaseDirectory) _
            .AddJsonFile("appsettings.json", optional:=False, reloadOnChange:=True) _
            .Build()
    End Sub

    Public Shared Function GetConnectionString(name As String) As String
        Return _config.GetConnectionString(name)
    End Function

End Class
