Public Class Empresa

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If (OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK) Then

        End If
    End Sub
End Class