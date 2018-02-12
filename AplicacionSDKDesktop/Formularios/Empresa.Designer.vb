<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Me.GroupBoxEmpresa = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TextBoxRuta = New System.Windows.Forms.TextBox()
        Me.GroupBoxEmpresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxEmpresa
        '
        Me.GroupBoxEmpresa.Controls.Add(Me.TextBoxRuta)
        Me.GroupBoxEmpresa.Controls.Add(Me.BtnGuardar)
        Me.GroupBoxEmpresa.Controls.Add(Me.Label1)
        Me.GroupBoxEmpresa.Controls.Add(Me.BtnBuscar)
        Me.GroupBoxEmpresa.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxEmpresa.Name = "GroupBoxEmpresa"
        Me.GroupBoxEmpresa.Size = New System.Drawing.Size(303, 100)
        Me.GroupBoxEmpresa.TabIndex = 0
        Me.GroupBoxEmpresa.TabStop = False
        Me.GroupBoxEmpresa.Text = "Ruta de empresa"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(117, 71)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ruta:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(211, 71)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TextBoxRuta
        '
        Me.TextBoxRuta.Location = New System.Drawing.Point(56, 25)
        Me.TextBoxRuta.Name = "TextBoxRuta"
        Me.TextBoxRuta.Size = New System.Drawing.Size(230, 20)
        Me.TextBoxRuta.TabIndex = 2
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 121)
        Me.Controls.Add(Me.GroupBoxEmpresa)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(345, 160)
        Me.MinimumSize = New System.Drawing.Size(345, 160)
        Me.Name = "Empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Empresa"
        Me.GroupBoxEmpresa.ResumeLayout(False)
        Me.GroupBoxEmpresa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxEmpresa As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TextBoxRuta As System.Windows.Forms.TextBox
End Class
