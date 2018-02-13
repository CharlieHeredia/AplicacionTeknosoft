Imports System.IO
Public Class Empresa

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'Dim OpenFile As New OpenFileDialog
        'OpenFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        'If (OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK) Then

        'End If
        Dim OpenFolder As New FolderBrowserDialog
        'OpenFolder.RootFolder = "C:"
        If (OpenFolder.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBoxRuta.Text = OpenFolder.SelectedPath
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TextBoxRuta.Text = "" Then
            MsgBox("No se ha seleccionado la ruta.", MsgBoxStyle.Exclamation)
        Else
            If Directory.Exists(TextBoxRuta.Text.Trim()) = False Then
                MsgBox("El directorio no existe.", MsgBoxStyle.Exclamation)
            Else
                ActualizarLineaArchivo(TextBoxRuta.Text.Trim(), 0)
                MsgBox("Configuración guardada.", MsgBoxStyle.Information)
                Me.Close()
            End If
        End If
    End Sub
End Class