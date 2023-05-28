<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel2 = New Panel()
        IniciarSesión = New Button()
        TextBox1 = New TextBox()
        titulo4 = New Label()
        titulo3 = New Label()
        Id = New TextBox()
        Titulo2 = New Label()
        titulo1 = New Label()
        titulo5 = New Label()
        titulo6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(titulo6)
        Panel1.Controls.Add(titulo5)
        Panel1.Location = New Point(172, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(241, 297)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(IniciarSesión)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(titulo4)
        Panel2.Controls.Add(titulo3)
        Panel2.Controls.Add(Id)
        Panel2.Controls.Add(Titulo2)
        Panel2.Controls.Add(titulo1)
        Panel2.ForeColor = SystemColors.Control
        Panel2.Location = New Point(343, 54)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(302, 297)
        Panel2.TabIndex = 1
        ' 
        ' IniciarSesión
        ' 
        IniciarSesión.BackColor = SystemColors.ActiveCaption
        IniciarSesión.Cursor = Cursors.Hand
        IniciarSesión.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IniciarSesión.Location = New Point(62, 239)
        IniciarSesión.Name = "IniciarSesión"
        IniciarSesión.Size = New Size(187, 23)
        IniciarSesión.TabIndex = 6
        IniciarSesión.Text = "Iniciar Sesión"
        IniciarSesión.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.AcceptsReturn = True
        TextBox1.BackColor = SystemColors.ScrollBar
        TextBox1.Location = New Point(62, 196)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(187, 23)
        TextBox1.TabIndex = 5
        ' 
        ' titulo4
        ' 
        titulo4.AutoSize = True
        titulo4.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        titulo4.ForeColor = SystemColors.AppWorkspace
        titulo4.Location = New Point(29, 180)
        titulo4.Name = "titulo4"
        titulo4.Size = New Size(66, 13)
        titulo4.TabIndex = 4
        titulo4.Text = "Contraseña"
        ' 
        ' titulo3
        ' 
        titulo3.AutoSize = True
        titulo3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        titulo3.ForeColor = SystemColors.AppWorkspace
        titulo3.Location = New Point(27, 128)
        titulo3.Name = "titulo3"
        titulo3.Size = New Size(126, 13)
        titulo3.TabIndex = 3
        titulo3.Text = "Número de documento"
        ' 
        ' Id
        ' 
        Id.AcceptsReturn = True
        Id.BackColor = SystemColors.ScrollBar
        Id.Location = New Point(62, 144)
        Id.Name = "Id"
        Id.Size = New Size(187, 23)
        Id.TabIndex = 2
        ' 
        ' Titulo2
        ' 
        Titulo2.AccessibleRole = AccessibleRole.Grip
        Titulo2.AutoSize = True
        Titulo2.ForeColor = SystemColors.AppWorkspace
        Titulo2.Location = New Point(29, 57)
        Titulo2.Name = "Titulo2"
        Titulo2.Size = New Size(215, 45)
        Titulo2.TabIndex = 1
        Titulo2.Text = "¡Hola! Gracias por visitarnos. " & vbCrLf & "Por favor, ingresa tus credenciales para " & vbCrLf & "acceder a tu cuenta."
        ' 
        ' titulo1
        ' 
        titulo1.AutoSize = True
        titulo1.BackColor = SystemColors.Control
        titulo1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        titulo1.ForeColor = SystemColors.ActiveCaption
        titulo1.Location = New Point(27, 27)
        titulo1.Name = "titulo1"
        titulo1.Size = New Size(112, 19)
        titulo1.TabIndex = 0
        titulo1.Text = "Inicio Sesión"
        ' 
        ' titulo5
        ' 
        titulo5.AutoSize = True
        titulo5.BackColor = Color.Transparent
        titulo5.ForeColor = SystemColors.ActiveCaption
        titulo5.Location = New Point(28, 102)
        titulo5.Name = "titulo5"
        titulo5.Size = New Size(120, 15)
        titulo5.TabIndex = 0
        titulo5.Text = "Gracias Por Visitarnos"
        ' 
        ' titulo6
        ' 
        titulo6.AutoSize = True
        titulo6.BackColor = Color.Transparent
        titulo6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        titulo6.ForeColor = SystemColors.ActiveCaption
        titulo6.Location = New Point(28, 143)
        titulo6.Name = "titulo6"
        titulo6.Size = New Size(113, 19)
        titulo6.TabIndex = 1
        titulo6.Text = "BIENVENIDO"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Titulo2 As Label
    Friend WithEvents titulo1 As Label
    Friend WithEvents titulo3 As Label
    Friend WithEvents Id As TextBox
    Friend WithEvents IniciarSesión As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents titulo4 As Label
    Friend WithEvents titulo6 As Label
    Friend WithEvents titulo5 As Label
End Class
