Public Class Splash
    Dim VentanaPrincipal As New Principal
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        NotifyIconTeknoComAPI.Visible = True
        Threading.Thread.Sleep(1000)
        For i As Integer = 100 To i = 0 Step -1
            Me.Opacity -= 0.01
            Threading.Thread.Sleep(30)
        Next
        Me.ShowInTaskbar = False
        Me.NotifyIconTeknoComAPI.ShowBalloonTip(100, "TeknoCom API", "Bienvenidos", ToolTipIcon.Info)
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Try
            VentanaPrincipal.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If ServidorFuncionando = True Then
            If MsgBox("Hay un servidor corriendo, se detendra el servidor. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Server.IsListening = False
                'Server.Server.Stop()
                ServidorFuncionando = False
                VentanaPrincipal._Estado = False
                Application.ExitThread()
            End If
        Else
            Application.ExitThread() 'CERRAR APLICACIÓN.'
        End If
    End Sub
End Class