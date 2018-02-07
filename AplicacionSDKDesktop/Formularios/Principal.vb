Public Class Principal
    Dim VentanaSocket As New Socket
    Private Sub SocketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocketToolStripMenuItem.Click
        VentanaSocket.ShowDialog()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExistenciaDirectorioSocket()
    End Sub

   
End Class
