Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Titulo2.Click

    End Sub

    Private Sub Id_TextChanged(sender As Object, e As EventArgs) Handles Id.TextChanged

    End Sub

    Private Sub titulo5_Click(sender As Object, e As EventArgs) Handles titulo5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub IniciarSesión_Click(sender As Object, e As EventArgs) Handles IniciarSesión.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
