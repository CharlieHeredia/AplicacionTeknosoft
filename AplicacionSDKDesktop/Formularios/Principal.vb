Public Class Principal
    Dim VentanaSocket As New Socket
    Dim VentanaSQL As New SQL
    Private Sub SocketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocketToolStripMenuItem.Click
        VentanaSocket.ShowDialog()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExistenciaDirectorioSocket()
    End Sub

   
    Private Sub SQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLToolStripMenuItem.Click
        VentanaSQL.ShowDialog()
    End Sub
End Class
