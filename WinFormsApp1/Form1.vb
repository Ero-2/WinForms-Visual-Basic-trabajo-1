Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click





    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles joya.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As contacto
        x = New contacto()
        x.fechadenacimiento_ = DateTime.Parse("2003/01/01")
        x.nombre_ = nombretxt.Text
        x.telefono_ = telefonotxt.Text
        joya.Text = x.ToString
    End Sub
End Class
