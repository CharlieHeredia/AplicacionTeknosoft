Module VariablesGlobales
    Public DireccionIP As String = "" 'DIRECCIÓN IP DEL SERVIDOR'
    Public PuertoG As String = "" 'PUERTO UTILIZADO POR EL SOCKET'
    Public ConfiguraciónCompleta As Boolean = False 'PARA VERIFICAR QUE LA DIRECCIÓN IP Y EL PUERTO SE CONFIGURARON CORRECTAMENTE.'
    Public Key As String = "teknocom"
    Public DirectorioSocket As String = "C:\TeknoCom\Socket"
    Public aRutaFormato As String = "" 'UBICACIÓN DEL ARCHIVO DE FORMATO.'
    Public DirectorioArchivoConfiguracion As String = "C:\TeknoCom\Socket\ConfiguracionSocket.txt"
End Module
