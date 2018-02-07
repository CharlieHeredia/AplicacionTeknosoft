Public Class Socket

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
        ToolTip1.SetToolTip(GroupBox1, "La dirección IP y el puerto deben coincidir con la configuración del Web Service.")
        ToolTip1.ToolTipTitle = "Nota"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class