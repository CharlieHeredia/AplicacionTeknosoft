Public Class Socket
    Public Property _DireccionIP As String
        Get
            Return TextBoxDireccion.Text.Trim()
        End Get
        Set(value As String)
            TextBoxDireccion.Text = value
        End Set
    End Property
    Public Property _Puerto As String
        Get
            Return TextBoxPuerto.Text.Trim()
        End Get
        Set(value As String)
            TextBoxPuerto.Text = value
        End Set
    End Property
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
        ToolTip1.SetToolTip(GroupBox1, "La dirección IP y el puerto deben coincidir con la configuración del Web Service.")
        ToolTip1.ToolTipTitle = "Nota"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TextBoxDireccion.Text = "" Or TextBoxPuerto.Text = "" Then
            MsgBox("Falta completar un campo", MsgBoxStyle.Exclamation)
        Else
            Dim texto As String = TextBoxDireccion.Text.Trim() + "¬" + TextBoxPuerto.Text.Trim()
            ActualizarLineaArchivo(texto, 1)
            MsgBox("Configuración guardada.", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        'ELIMINAR CONFIGURACIÓN DE DIRECCIÓN IP Y PUERTO.'
        If MsgBox("Se borrará la configuración del servidor. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ActualizarLineaArchivo("EMPTY", 1)
            MsgBox("Configuración borrada.", MsgBoxStyle.Information)
            'ACTUALIZAR ETIQUETAS.'
            TextBoxDireccion.Text = ""
            TextBoxPuerto.Text = ""
            'ACTUALIZAR VARIABLES GLOBALES.'
            DireccionIP = ""
            PuertoG = ""
            Me.Close()
        End If


    End Sub
End Class