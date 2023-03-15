Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim empleado1 As Empleado = New Empleado()
        empleado1.Apellidos = TextBox1.Text
        empleado1.Nombres = TextBox2.Text
        empleado1.Documentos = TextBox3.Text
        empleado1.Tipo = ComboBox1.Text
        empleado1.TipoContrato = ComboBox2.Text

        DataGridView1.Rows.Insert(0, empleado1.Tipo, empleado1.Apellidos, empleado1.Nombres, empleado1.Documentos, empleado1.Sueldo)


    End Sub
End Class
