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
        Dim arreglo() As String = SepararLineaTexto(2) 'LEE LA LINEA DEL ARCHIVO NO.3 PARA CARGAR LA INFORMACIÓN EN LA APLICACIÓN.'
        If arreglo(0) <> "SinConf" Then
            LabelInstancia.Text = arreglo(2)
        End If
        arreglo = SepararLineaTexto(1)
        If arreglo(0) <> "SinConf" Then
            LabelIP.Text = arreglo(0)
            LabelPuerto.Text = arreglo(1)
        End If
        arreglo = SepararLineaTexto(0)
        If arreglo(0) <> "SinConf" Then
            LabelRuta.Text = arreglo(0)
        End If
    End Sub

   
    Private Sub SQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLToolStripMenuItem.Click
        Dim VentanaSQL As New SQL
        VentanaSQL.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        VentanaEmpresa.ShowDialog()
    End Sub
End Class
