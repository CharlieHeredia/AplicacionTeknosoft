Imports System.Data.Sql
Public Class SQL

    Private Sub SQL_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'LIMPIAR LOS ITEMS DEL COMBOBOX.'
        ComboBox1.Items.Clear()
    End Sub

    Private Sub SQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim instan As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance ' DECLARACIÓN DE VARIABLE. UTILIZADA PARA OBTENER LAS INSTANCIAS EN RED.''
        Dim talablainsta = New DataTable() ' NUEVA INSTANCIA DE UNA TABLA.'
        talablainsta = instan.GetDataSources() ' OBTIENE LA INFORMACIÓN DE LAS INSTANCIAS EN LA RED.'
        For Each row As DataRow In talablainsta.Rows
            ComboBox1.Items.Add(row.Item(0) & "\" & row.Item(1)) 'NOMBRE DEL EQUIPO \ NOMBRE DE INSTANCIA'
        Next
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'GUARDAR LA CONFIGURACIÓN EN EL ARCHIVO.'
        'LINEA 3 SQL.'
        If TextBoxUser.Text = "" Or TextBoxPass.Text = "" Or ComboBox1.SelectedItem = "" Then
            MsgBox("Falta llenar algun dato", MsgBoxStyle.Exclamation)
        Else
            Dim texto As String = TextBoxUser.Text.Trim() + "¬" + TextBoxPass.Text.Trim() + "¬" + ComboBox1.SelectedItem.ToString.Trim()
            ActualizarLineaArchivo(texto, 2)
            MsgBox("Configuración guardada.", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
End Class