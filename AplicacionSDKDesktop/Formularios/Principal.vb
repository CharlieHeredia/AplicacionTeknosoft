Public Class Principal
    Dim VentanaSocket As New Socket

    Dim VentanaEmpresa As New Empresa
    Private Sub SocketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocketToolStripMenuItem.Click
        VentanaSocket.ShowDialog()
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
End Class
