Public Class Form_estudiantes
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub roles_Click(sender As Object, e As EventArgs) Handles roles.Click

    End Sub

    Private Sub Usuario_Click(sender As Object, e As EventArgs) Handles Usuario.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
    End Sub
End Class