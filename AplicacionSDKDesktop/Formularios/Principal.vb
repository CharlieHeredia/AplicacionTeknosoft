﻿Public Class Principal
    Dim VentanaSocket As New Socket
    Dim VentanaSQL As New SQL
    Dim VentanaEmpresa As New Empresa
    Private Sub SocketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocketToolStripMenuItem.Click
        VentanaSocket.ShowDialog()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExistenciaDirectorioSocket()
        ExistenciaArchivoConfiguracion()
    End Sub

   
    Private Sub SQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SQLToolStripMenuItem.Click
        VentanaSQL.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        VentanaEmpresa.ShowDialog()
    End Sub
End Class
