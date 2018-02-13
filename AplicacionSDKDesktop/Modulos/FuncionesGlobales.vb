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
    Public Function ExistenciaArchivoConfiguracion() As Boolean
        If File.Exists(DirectorioArchivoConfiguracion) = False Then
            Dim path = File.Create(DirectorioArchivoConfiguracion) 'SE CREA EL ARCHIVO DE CONFIGURACIÓN.'
            'CREAR LAS LINEAS.'
            '1.Ruta de Empresa
            '2.Puerto y direccion ip
            '3.SQL (usuario,pass,instancia)
            path.Close()
            Dim texto() As String = {"EMPTY", "EMPTY", "EMPTY"}
            File.WriteAllLines(DirectorioArchivoConfiguracion, texto)
            EncryptFile(DirectorioArchivoConfiguracion, Key)
        End If
    End Function
    Public Function ExistenciaDirectorioSocket() As Boolean
        If Directory.Exists(DirectorioSocket) = False Then 'VERIFICACIÓN DE EXISTENCIA DE DIRECTORIO.'
            Directory.CreateDirectory(DirectorioSocket) 'CREACIÓN DE DIRECTORIO.'
        End If
    End Function
    Public Function SepararLineaTexto(ByVal linea As Integer)
        Dim NoSeparado As String = LeerLineaArchivo(linea)
        If NoSeparado = "EMPTY" Then
            Dim arreglo() As String = {"SinConf"} 'EN CASO DE ESTAR VACIA LA INFORMACIÓN DEVULVE ESTA PALABRA.'
            Return arreglo
        Else
            Dim arreglo() As String = Split(NoSeparado, "¬")
            Return arreglo
        End If
    End Function
    Public Function LeerLineaArchivo(ByVal linea As Integer) As String
        'LEE EL ARCHIVO DE CONFIGURACIÓN, REGRESA LA LINEA DE TEXTO QUE SE LE ENVIE COMO PARAMETRO.'
        DecryptFile(DirectorioArchivoConfiguracion, Key)
        Dim lineas() As String = File.ReadAllLines(DirectorioArchivoConfiguracion)
        Dim texto As String = lineas(linea)
        EncryptFile(DirectorioArchivoConfiguracion, Key)
        Return texto
    End Function
    Private Function LeerArchivo()
        'LEE LA INFORMACIÓN DEL ARCHIVO DE CONFIGURACIÓN.'
        'UTILIZADA COMO SUBFUNCIÓN
        DecryptFile(DirectorioArchivoConfiguracion, Key)
        Dim lineas() As String = File.ReadAllLines(DirectorioArchivoConfiguracion)
        EncryptFile(DirectorioArchivoConfiguracion, Key)
        Return lineas
    End Function
    Public Function ActualizarLineaArchivo(ByVal texto As String, ByVal linea As Integer)
        Dim lineas() As String = LeerArchivo()
        lineas(linea) = texto
        Using file As New IO.StreamWriter(DirectorioArchivoConfiguracion) 'CICLO PARA VACIAR EL ARCHIVO TXT.'
            file.Flush()
        End Using
        File.WriteAllLines(DirectorioArchivoConfiguracion, lineas) 'ACTUALIZAR LA INFORMACIÓN EN EL TXT.'
        EncryptFile(DirectorioArchivoConfiguracion, Key)
    End Function
    Public Function ActualizarEtiquetas(ByRef Instancia As Label, ByRef Puerto As Label, ByRef IP As Label, ByRef Ruta As Label)
        Dim arreglo() As String = SepararLineaTexto(2) 'LEE LA LINEA DEL ARCHIVO NO.3 PARA CARGAR LA INFORMACIÓN EN LA APLICACIÓN.'
        If arreglo(0) <> "SinConf" Then
            Instancia.Text = arreglo(2)
        End If
        arreglo = SepararLineaTexto(1)
        If arreglo(0) <> "SinConf" Then
            IP.Text = arreglo(0)
            Puerto.Text = arreglo(1)
        End If
        arreglo = SepararLineaTexto(0)
        If arreglo(0) <> "SinConf" Then
            Ruta.Text = arreglo(0)
        End If
    End Function

End Module
