Imports Clientes
Public Class FormRegistro
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empleado As Empleado = New Empleado()
        empleado.Apellidos = txtApellidos.Text
        empleado.Nombres = txtNombres.Text
        empleado.Documento = txtDocumento.Text
        empleado.Tipo = cboTipo.Text
        empleado.TipoContrato = cboContrato.Text

        empleado.calcularSueldo(750)
        dgvEmpleaods.Rows.Insert(0, empleado.Tipo, empleado.Nombres, empleado.Apellidos, empleado.Documento, empleado.Sueldo)
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class