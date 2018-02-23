Public Class Splash
    Dim VentanaPrincipal As Principal
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
        VentanaPrincipal = New Principal()
        VentanaPrincipal.Show()
    End Sub
End Class