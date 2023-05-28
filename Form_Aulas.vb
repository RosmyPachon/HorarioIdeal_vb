Public Class Form_Aulas
    Private Sub permisos_Click(sender As Object, e As EventArgs) Handles permisos.Click
        Me.Hide()
        Form_permisos.Show()

    End Sub

    Private Sub acciones_Click(sender As Object, e As EventArgs) Handles acciones.Click
        Me.Hide()
        Form_acciones.Show()

    End Sub

    Private Sub Usuario_Click(sender As Object, e As EventArgs) Handles Usuario.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub estudiantes_Click(sender As Object, e As EventArgs) Handles estudiantes.Click
        Me.Hide()
        Form_estudiantes.Show()

    End Sub

    Private Sub profesores_Click(sender As Object, e As EventArgs) Handles profesores.Click
        Me.Hide()
        Form_profesores.Show()

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()

    End Sub
End Class