<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespaldoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxServidor = New System.Windows.Forms.GroupBox()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.LabelPuerto = New System.Windows.Forms.Label()
        Me.LabelIP = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxServidorSQL = New System.Windows.Forms.GroupBox()
        Me.LabelInstancia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxEmpresa = New System.Windows.Forms.GroupBox()
        Me.LabelRuta = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RespaldoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxServidor.SuspendLayout()
        Me.GroupBoxServidorSQL.SuspendLayout()
        Me.GroupBoxEmpresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.ServidorToolStripMenuItem, Me.RespaldoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(764, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SQLToolStripMenuItem, Me.SocketToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.RespaldoToolStripMenuItem1})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'SQLToolStripMenuItem
        '
        Me.SQLToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.SQLToolStripMenuItem.Image = CType(resources.GetObject("SQLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SQLToolStripMenuItem.Name = "SQLToolStripMenuItem"
        Me.SQLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SQLToolStripMenuItem.Text = "SQL"
        '
        'SocketToolStripMenuItem
        '
        Me.SocketToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.SocketToolStripMenuItem.Image = CType(resources.GetObject("SocketToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SocketToolStripMenuItem.Name = "SocketToolStripMenuItem"
        Me.SocketToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SocketToolStripMenuItem.Text = "Servidor"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.EmpresaToolStripMenuItem.Image = CType(resources.GetObject("EmpresaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'ServidorToolStripMenuItem
        '
        Me.ServidorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarToolStripMenuItem, Me.DToolStripMenuItem})
        Me.ServidorToolStripMenuItem.Name = "ServidorToolStripMenuItem"
        Me.ServidorToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ServidorToolStripMenuItem.Text = "Servidor"
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.IniciarToolStripMenuItem.Image = CType(resources.GetObject("IniciarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.IniciarToolStripMenuItem.Text = "Iniciar"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.DToolStripMenuItem.Image = CType(resources.GetObject("DToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.DToolStripMenuItem.Text = "Detener"
        '
        'RespaldoToolStripMenuItem
        '
        Me.RespaldoToolStripMenuItem.Name = "RespaldoToolStripMenuItem"
        Me.RespaldoToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.RespaldoToolStripMenuItem.Text = "Respaldo"
        '
        'GroupBoxServidor
        '
        Me.GroupBoxServidor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxServidor.Controls.Add(Me.TextBoxEstado)
        Me.GroupBoxServidor.Controls.Add(Me.LabelEstado)
        Me.GroupBoxServidor.Controls.Add(Me.LabelPuerto)
        Me.GroupBoxServidor.Controls.Add(Me.LabelIP)
        Me.GroupBoxServidor.Controls.Add(Me.Label3)
        Me.GroupBoxServidor.Controls.Add(Me.Label2)
        Me.GroupBoxServidor.Controls.Add(Me.Label1)
        Me.GroupBoxServidor.Location = New System.Drawing.Point(544, 39)
        Me.GroupBoxServidor.Name = "GroupBoxServidor"
        Me.GroupBoxServidor.Size = New System.Drawing.Size(208, 98)
        Me.GroupBoxServidor.TabIndex = 1
        Me.GroupBoxServidor.TabStop = False
        Me.GroupBoxServidor.Text = "Servidor"
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Location = New System.Drawing.Point(93, 66)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEstado.TabIndex = 6
        '
        'LabelEstado
        '
        Me.LabelEstado.AutoSize = True
        Me.LabelEstado.Location = New System.Drawing.Point(93, 69)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(0, 13)
        Me.LabelEstado.TabIndex = 5
        '
        'LabelPuerto
        '
        Me.LabelPuerto.AutoSize = True
        Me.LabelPuerto.Location = New System.Drawing.Point(90, 43)
        Me.LabelPuerto.Name = "LabelPuerto"
        Me.LabelPuerto.Size = New System.Drawing.Size(0, 13)
        Me.LabelPuerto.TabIndex = 4
        '
        'LabelIP
        '
        Me.LabelIP.AutoSize = True
        Me.LabelIP.Location = New System.Drawing.Point(90, 20)
        Me.LabelIP.Name = "LabelIP"
        Me.LabelIP.Size = New System.Drawing.Size(0, 13)
        Me.LabelIP.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Puerto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dirección IP"
        '
        'GroupBoxServidorSQL
        '
        Me.GroupBoxServidorSQL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxServidorSQL.Controls.Add(Me.LabelInstancia)
        Me.GroupBoxServidorSQL.Controls.Add(Me.Label4)
        Me.GroupBoxServidorSQL.Location = New System.Drawing.Point(544, 144)
        Me.GroupBoxServidorSQL.Name = "GroupBoxServidorSQL"
        Me.GroupBoxServidorSQL.Size = New System.Drawing.Size(208, 93)
        Me.GroupBoxServidorSQL.TabIndex = 2
        Me.GroupBoxServidorSQL.TabStop = False
        Me.GroupBoxServidorSQL.Text = "Servidor SQL"
        '
        'LabelInstancia
        '
        Me.LabelInstancia.AutoSize = True
        Me.LabelInstancia.Location = New System.Drawing.Point(18, 60)
        Me.LabelInstancia.Name = "LabelInstancia"
        Me.LabelInstancia.Size = New System.Drawing.Size(0, 13)
        Me.LabelInstancia.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Instancia"
        '
        'GroupBoxEmpresa
        '
        Me.GroupBoxEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxEmpresa.Controls.Add(Me.LabelRuta)
        Me.GroupBoxEmpresa.Controls.Add(Me.Label5)
        Me.GroupBoxEmpresa.Location = New System.Drawing.Point(544, 243)
        Me.GroupBoxEmpresa.Name = "GroupBoxEmpresa"
        Me.GroupBoxEmpresa.Size = New System.Drawing.Size(208, 106)
        Me.GroupBoxEmpresa.TabIndex = 3
        Me.GroupBoxEmpresa.TabStop = False
        Me.GroupBoxEmpresa.Text = "Empresa"
        '
        'LabelRuta
        '
        Me.LabelRuta.AutoSize = True
        Me.LabelRuta.Location = New System.Drawing.Point(7, 44)
        Me.LabelRuta.Name = "LabelRuta"
        Me.LabelRuta.Size = New System.Drawing.Size(0, 13)
        Me.LabelRuta.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ruta"
        '
        'RespaldoToolStripMenuItem1
        '
        Me.RespaldoToolStripMenuItem1.BackColor = System.Drawing.Color.Gainsboro
        Me.RespaldoToolStripMenuItem1.Image = CType(resources.GetObject("RespaldoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RespaldoToolStripMenuItem1.Name = "RespaldoToolStripMenuItem1"
        Me.RespaldoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RespaldoToolStripMenuItem1.Text = "Respaldo"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(764, 362)
        Me.Controls.Add(Me.GroupBoxEmpresa)
        Me.Controls.Add(Me.GroupBoxServidorSQL)
        Me.Controls.Add(Me.GroupBoxServidor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(780, 400)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeknoCom API"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxServidor.ResumeLayout(False)
        Me.GroupBoxServidor.PerformLayout()
        Me.GroupBoxServidorSQL.ResumeLayout(False)
        Me.GroupBoxServidorSQL.PerformLayout()
        Me.GroupBoxEmpresa.ResumeLayout(False)
        Me.GroupBoxEmpresa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SocketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBoxServidor As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelIP As System.Windows.Forms.Label
    Friend WithEvents LabelEstado As System.Windows.Forms.Label
    Friend WithEvents LabelPuerto As System.Windows.Forms.Label
    Friend WithEvents ServidorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBoxServidorSQL As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxEstado As System.Windows.Forms.TextBox
    Friend WithEvents LabelInstancia As System.Windows.Forms.Label
    Friend WithEvents LabelRuta As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RespaldoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RespaldoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
