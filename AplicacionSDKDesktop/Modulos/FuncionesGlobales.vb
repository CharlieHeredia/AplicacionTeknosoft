Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Module FuncionesGlobales
    Private Function EncryptFile(ByVal filepath As String, ByVal key As String)
        Dim plainContent As Byte() = File.ReadAllBytes(filepath)
        Dim DES As New DESCryptoServiceProvider()
        Using (DES)
            DES.IV = Encoding.UTF8.GetBytes(key)
            DES.Key = Encoding.UTF8.GetBytes(key)
            DES.Mode = CipherMode.CBC
            DES.Padding = PaddingMode.PKCS7

            Dim memStream = New MemoryStream
            Using (memStream)
                Dim cryptoStream As CryptoStream = New CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write)

                cryptoStream.Write(plainContent, 0, plainContent.Length)
                cryptoStream.FlushFinalBlock()
                File.WriteAllBytes(filepath, memStream.ToArray())
            End Using

        End Using

    End Function
    Private Function DecryptFile(ByVal filepath As String, ByVal key As String)
        Dim encrypted As Byte() = File.ReadAllBytes(filepath)
        Dim DES As New DESCryptoServiceProvider()
        Using (DES)
            DES.IV = Encoding.UTF8.GetBytes(key)
            DES.Key = Encoding.UTF8.GetBytes(key)
            DES.Mode = CipherMode.CBC
            DES.Padding = PaddingMode.PKCS7

            Dim memStream = New MemoryStream
            Using (memStream)
                Dim cryptoStream As CryptoStream = New CryptoStream(memStream, DES.CreateDecryptor(), CryptoStreamMode.Write)

                cryptoStream.Write(encrypted, 0, encrypted.Length)
                cryptoStream.FlushFinalBlock()
                File.WriteAllBytes(filepath, memStream.ToArray())
            End Using
        End Using
    End Function

    Public Function ExistenciaDirectorioSocket() As Boolean
        If Directory.Exists(DirectorioSocket) = False Then 'VERIFICACIÓN DE EXISTENCIA DE DIRECTORIO.'
            Directory.CreateDirectory(DirectorioSocket) 'CREACIÓN DE DIRECTORIO.'
        End If
    End Function
    Public Function RevisarServidor() As Boolean

    End Function
End Module
