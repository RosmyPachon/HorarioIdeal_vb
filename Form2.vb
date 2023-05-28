Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form2
    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles Inicio.Click

    End Sub

    Private Sub acciones_Click(sender As Object, e As EventArgs) Handles acciones.Click
        Me.Hide()
        Form_acciones.Show()


    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Me.Close()
    End Sub

    Dim tabla As New DataTable()

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Usuarios.CellContentClick

    End Sub

    Private Sub estudiantes_Click(sender As Object, e As EventArgs) Handles estudiantes.Click
        Me.Hide()
        Form_estudiantes.Show()
    End Sub

    Private Sub roles_Click(sender As Object, e As EventArgs) Handles roles.Click
        Me.Hide()
        Form_roles.Show()

    End Sub

    Private Sub permisos_Click(sender As Object, e As EventArgs) Handles permisos.Click
        Me.Hide()
        Form_permisos.Show()

    End Sub

    Private Sub profesores_Click(sender As Object, e As EventArgs) Handles profesores.Click
        Me.Hide()
        Form_profesores.Show()

    End Sub

    Private Sub aulas_Click(sender As Object, e As EventArgs) Handles aulas.Click
        Me.Hide()
        Form_Aulas.Show()


    End Sub

    Private Sub grados_Click(sender As Object, e As EventArgs) Handles grados.Click
        Me.Hide()
        Form_grados.Show()


    End Sub

    Private Sub asinaturas_Click(sender As Object, e As EventArgs) Handles asinaturas.Click
        Me.Hide()
        Form_asignaturas.Show()


    End Sub

    Private Sub horarios_Click(sender As Object, e As EventArgs) Handles horarios.Click
        Me.Hide()
        Form_horarios.Show()


    End Sub
End Class