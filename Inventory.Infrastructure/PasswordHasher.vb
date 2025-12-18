Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHasher
    Public Shared Function Hash(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim has = sha.ComputeHash(bytes)
            Return Convert.ToBase64String(has)
        End Using
    End Function
End Class
