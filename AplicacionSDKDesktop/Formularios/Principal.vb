Imports System.IO
Imports Microsoft.VisualBasic.Compatibility
Imports System.Threading
Public Class Principal
    Dim VentanaSocket As New Socket
    Dim VentanaEmpresa As New Empresa
    Private Server As TCPControl
    Private Sub SocketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocketToolStripMenuItem.Click
        VentanaSocket.ShowDialog()
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IsNothing(Server) = False Then
            If TextBoxEstado.BackColor = Color.Green Then
                If MsgBox("Se detendra el servidor", MsgBoxStyle.YesNo, MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    Server.IsListening = False
                    Server.Server.Stop()
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            End If
            
        End If
        
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExistenciaDirectorioSocket()
        ExistenciaArchivoConfiguracion()
        TextBoxEstado.Enabled = False
        TextBoxEstado.BackColor = Color.Red
        ActualizarEtiquetas(LabelInstancia, LabelPuerto, LabelIP, LabelRuta)

    End Sub


    Private Sub SQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLToolStripMenuItem.Click
        Dim VentanaSQL As New SQL
        VentanaSQL.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        VentanaEmpresa.ShowDialog()
    End Sub
    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click
        'HAY UN SERVIDOR CORRIENDO.'
        If IsNothing(Server) = False Then
            If TextBoxEstado.BackColor = Color.Green Then
                If MsgBox("Algunas funciones del Web Service dejaran de funcionar. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Server.IsListening = False
                    Server.Server.Stop()
                    TextBoxEstado.BackColor = Color.Red
                End If
            Else
                MsgBox("El servidor no ha sido iniciado.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("El servidor no ha sido iniciado.", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub IniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarToolStripMenuItem.Click
        'INICIAR SERVIDOR.'
        If IsNothing(Server) Then 'VALIDACIÓN DE SERVIDOR INACTIVO.'
            If DireccionIP = "" Or PuertoG = "" Then 'VERFICACIÓN DE QUE EXISTA CONFIGURACIÓN DE IP Y PUERTO PARA EL SERVIDOR.'
                MsgBox("No se ha configurado el servidor.", MsgBoxStyle.Exclamation)
            Else
                Server = New TCPControl 'SE GENERA UNA NUEVA INSTANCIA LA VARIABLE TIPO TCPControl.'
                TextBoxEstado.BackColor = Color.Green ' INDICADOR DE SERVIDOR INICIALIZADO PARA EL USUARIO.'
                AddHandler Server.Trimbrar, AddressOf OnLineReceived 'SE CAPTURA EL EVENTO Timbrar'
                MsgBox("Servidor Iniciado.", MsgBoxStyle.Information)
            End If
        Else
            'HAY UN SERVIDOR CORRIENDO.'
            If MsgBox("Hay un servidor corriendo, se detendra el servidor. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Server.IsListening = False
                Server.Server.Stop()
                Server = New TCPControl 'SE GENERA UNA NUEVA INSTANCIA LA VARIABLE TIPO TCPControl.'
                AddHandler Server.Trimbrar, AddressOf OnLineReceived 'SE CAPTURA EL EVENTO Timbrar'
            End If
        End If
    End Sub
    Private Sub OnLineReceived(sender As TCPControl, Data As String) 'SUB FUNCIÓN PARA TIMBRAR'
        If Data <> "" Then
            MsgBox("Timbrando : " & Data)
            'CargarSDK()
            Timbrado()
        End If
    End Sub
    Private Function Timbrado()
        Try
            '24/01/2018 NOTA: ESTA FUNCIÓN PROCESARA UN ARCHIVO XML GENERADO POR EL WEB SERVICE.'
            GC.Collect() ' COMIENZA A RECOLECTAR LA BASURA GENERADA, PARA LIMPIARLA DESPUES DE TERMINAR EL PROCESO.'
            Directory.SetCurrentDirectory("C:\Program Files (x86)\Compacw\AdminPAQ\") ' SE ESTABLECE LA LOCALIZACIÓN DEL SDK.'
            fInicializaSDK() 'SE INICIALIZA EL SDK.'
            fAbreEmpresa("\\Server\Empresas\Wurth Mexico")
            Dim aRutaXML As String = "\\server\serverdev\Compartido\Equipo\Jorge\CORRECTO 3.3.xml"
            Dim aCodConcepto As String = "110"
            Dim aUUID As String = ""
            Dim aRutaDDA As String = ""
            Dim aPass As String = "12345678a"
            Dim aRutaFormato As String = "C:\TeknoCom\FE_CFDI_Wurth.htm"
            Dim estado As Integer = fInicializaLicenseInfo(0) ' VALIDACIÓN DE LA LICENCIA DE ADMINPAQ.'
            Dim aMensaje As New Compatibility.VB6.FixedLengthString(350) ' MENSAJE UTILIZADO PARA OBTENER EL ERROR DEL SISTEMA.'
            aMensaje.Value = New String(Chr(0), 349)
            If estado <> 0 Then
                fError(estado, aMensaje.Value, 350) ' OBTIENE EL ERROR.'
                MsgBox("Error Licencia: " & aMensaje.Value) ' MENSAJE DE ERROR.'
            Else
                estado = fTimbraXML(aRutaXML, aCodConcepto, aUUID, aRutaDDA, Application.StartupPath & "\Archivos\", aPass, aRutaFormato)
                If estado <> 0 Then
                    fError(estado, aMensaje.Value, 350)
                    MsgBox("Error Timbrando: " & aMensaje.Value)
                End If
            End If
            fCierraEmpresa()
            fTerminaSDK()
        Catch ex As Exception
            fCierraEmpresa() ' CIERRA LA RUTA DE LA EMRPESA'
            fTerminaSDK() ' TERMINA LA CONEXIÓN CON SDK'
            MsgBox("Error: " & ex.Message)
        End Try

        GC.GetTotalMemory(True) 'LIMPIEZA DE BASURA'

        MsgBox("Saliendo")
    End Function

 
End Class
