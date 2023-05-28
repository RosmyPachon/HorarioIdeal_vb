<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_asignaturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_asignaturas))
        Panel2 = New Panel()
        Label2 = New Label()
        Contenedor = New Panel()
        Usuarios = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        Nombres = New DataGridViewTextBoxColumn()
        Apellidos = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Eliminar = New DataGridViewButtonColumn()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        roles = New Button()
        PictureBox13 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        salir = New Button()
        horarios = New Button()
        asinaturas = New Button()
        grados = New Button()
        aulas = New Button()
        profesores = New Button()
        estudiantes = New Button()
        Usuario = New Button()
        PictureBox5 = New PictureBox()
        acciones = New Button()
        PictureBox4 = New PictureBox()
        permisos = New Button()
        PictureBox2 = New PictureBox()
        Inicio = New Button()
        rol = New Label()
        User = New Label()
        PictureBox1 = New PictureBox()
        Titulo = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Contenedor.SuspendLayout()
        CType(Usuarios, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(165, 8)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(923, 53)
        Panel2.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaption
        Label2.Location = New Point(35, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(241, 23)
        Label2.TabIndex = 1
        Label2.Text = "Administrar Asignaturas"
        ' 
        ' Contenedor
        ' 
        Contenedor.BackColor = Color.White
        Contenedor.Controls.Add(Usuarios)
        Contenedor.Location = New Point(305, 121)
        Contenedor.Name = "Contenedor"
        Contenedor.Size = New Size(613, 271)
        Contenedor.TabIndex = 27
        ' 
        ' Usuarios
        ' 
        Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Usuarios.Columns.AddRange(New DataGridViewColumn() {id, Nombres, Apellidos, DataGridViewTextBoxColumn1, Eliminar})
        Usuarios.Location = New Point(42, 86)
        Usuarios.Name = "Usuarios"
        Usuarios.RowTemplate.Height = 25
        Usuarios.Size = New Size(541, 150)
        Usuarios.TabIndex = 2
        ' 
        ' id
        ' 
        id.HeaderText = "Id"
        id.Name = "id"
        ' 
        ' Nombres
        ' 
        Nombres.HeaderText = "Nombres"
        Nombres.Name = "Nombres"
        ' 
        ' Apellidos
        ' 
        Apellidos.HeaderText = "Apellidos"
        Apellidos.Name = "Apellidos"
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Rol"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Accion"
        Eliminar.Name = "Eliminar"
        Eliminar.Resizable = DataGridViewTriState.True
        Eliminar.SortMode = DataGridViewColumnSortMode.Automatic
        Eliminar.Text = "Eliminar"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(roles)
        Panel1.Controls.Add(PictureBox13)
        Panel1.Controls.Add(PictureBox12)
        Panel1.Controls.Add(PictureBox11)
        Panel1.Controls.Add(PictureBox10)
        Panel1.Controls.Add(PictureBox9)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(salir)
        Panel1.Controls.Add(horarios)
        Panel1.Controls.Add(asinaturas)
        Panel1.Controls.Add(grados)
        Panel1.Controls.Add(aulas)
        Panel1.Controls.Add(profesores)
        Panel1.Controls.Add(estudiantes)
        Panel1.Controls.Add(Usuario)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(acciones)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(permisos)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Inicio)
        Panel1.Controls.Add(rol)
        Panel1.Controls.Add(User)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Titulo)
        Panel1.Location = New Point(1, 8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(167, 596)
        Panel1.TabIndex = 26
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(14, 148)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 23)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' roles
        ' 
        roles.Cursor = Cursors.Hand
        roles.FlatAppearance.BorderSize = 0
        roles.FlatStyle = FlatStyle.Flat
        roles.Location = New Point(14, 148)
        roles.Name = "roles"
        roles.Size = New Size(119, 23)
        roles.TabIndex = 11
        roles.Text = "Roles"
        roles.TextAlign = ContentAlignment.BottomCenter
        roles.UseVisualStyleBackColor = True
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(18, 548)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(29, 31)
        PictureBox13.TabIndex = 2
        PictureBox13.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(18, 460)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(26, 26)
        PictureBox12.TabIndex = 2
        PictureBox12.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(14, 412)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(27, 27)
        PictureBox11.TabIndex = 2
        PictureBox11.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(15, 383)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(27, 23)
        PictureBox10.TabIndex = 2
        PictureBox10.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(15, 353)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(25, 24)
        PictureBox9.TabIndex = 2
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(14, 324)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(30, 23)
        PictureBox8.TabIndex = 2
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(14, 295)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(26, 23)
        PictureBox7.TabIndex = 2
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(14, 266)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(26, 26)
        PictureBox6.TabIndex = 2
        PictureBox6.TabStop = False
        ' 
        ' salir
        ' 
        salir.BackColor = Color.Transparent
        salir.Cursor = Cursors.Hand
        salir.FlatAppearance.BorderSize = 0
        salir.FlatStyle = FlatStyle.Flat
        salir.Location = New Point(18, 548)
        salir.Name = "salir"
        salir.Size = New Size(119, 23)
        salir.TabIndex = 9
        salir.Text = "Salir"
        salir.TextAlign = ContentAlignment.BottomCenter
        salir.UseVisualStyleBackColor = False
        ' 
        ' horarios
        ' 
        horarios.BackColor = Color.Transparent
        horarios.Cursor = Cursors.Hand
        horarios.FlatAppearance.BorderSize = 0
        horarios.FlatStyle = FlatStyle.Flat
        horarios.Location = New Point(14, 460)
        horarios.Name = "horarios"
        horarios.Size = New Size(119, 23)
        horarios.TabIndex = 9
        horarios.Text = "Horarios"
        horarios.TextAlign = ContentAlignment.BottomCenter
        horarios.UseVisualStyleBackColor = False
        ' 
        ' asinaturas
        ' 
        asinaturas.BackColor = Color.Transparent
        asinaturas.Cursor = Cursors.Hand
        asinaturas.FlatAppearance.BorderSize = 0
        asinaturas.FlatStyle = FlatStyle.Flat
        asinaturas.Location = New Point(15, 416)
        asinaturas.Name = "asinaturas"
        asinaturas.Size = New Size(119, 23)
        asinaturas.TabIndex = 9
        asinaturas.Text = "Asignaturas"
        asinaturas.TextAlign = ContentAlignment.BottomCenter
        asinaturas.UseVisualStyleBackColor = False
        ' 
        ' grados
        ' 
        grados.BackColor = Color.Transparent
        grados.Cursor = Cursors.Hand
        grados.FlatAppearance.BorderSize = 0
        grados.FlatStyle = FlatStyle.Flat
        grados.Location = New Point(14, 382)
        grados.Name = "grados"
        grados.Size = New Size(119, 23)
        grados.TabIndex = 9
        grados.Text = "Grados"
        grados.TextAlign = ContentAlignment.BottomCenter
        grados.UseVisualStyleBackColor = False
        ' 
        ' aulas
        ' 
        aulas.BackColor = Color.Transparent
        aulas.Cursor = Cursors.Hand
        aulas.FlatAppearance.BorderSize = 0
        aulas.FlatStyle = FlatStyle.Flat
        aulas.Location = New Point(14, 353)
        aulas.Name = "aulas"
        aulas.Size = New Size(119, 23)
        aulas.TabIndex = 9
        aulas.Text = "Aulas"
        aulas.TextAlign = ContentAlignment.BottomCenter
        aulas.UseVisualStyleBackColor = False
        ' 
        ' profesores
        ' 
        profesores.BackColor = Color.Transparent
        profesores.Cursor = Cursors.Hand
        profesores.FlatAppearance.BorderSize = 0
        profesores.FlatStyle = FlatStyle.Flat
        profesores.Location = New Point(14, 324)
        profesores.Name = "profesores"
        profesores.Size = New Size(119, 23)
        profesores.TabIndex = 9
        profesores.Text = "Profesores"
        profesores.TextAlign = ContentAlignment.BottomCenter
        profesores.UseVisualStyleBackColor = False
        ' 
        ' estudiantes
        ' 
        estudiantes.BackColor = Color.Transparent
        estudiantes.Cursor = Cursors.Hand
        estudiantes.FlatAppearance.BorderSize = 0
        estudiantes.FlatStyle = FlatStyle.Flat
        estudiantes.Location = New Point(14, 295)
        estudiantes.Name = "estudiantes"
        estudiantes.Size = New Size(119, 23)
        estudiantes.TabIndex = 10
        estudiantes.Text = "Estudiantes"
        estudiantes.TextAlign = ContentAlignment.BottomCenter
        estudiantes.UseVisualStyleBackColor = False
        ' 
        ' Usuario
        ' 
        Usuario.BackColor = Color.Transparent
        Usuario.Cursor = Cursors.Hand
        Usuario.FlatAppearance.BorderSize = 0
        Usuario.FlatStyle = FlatStyle.Flat
        Usuario.Location = New Point(14, 266)
        Usuario.Name = "Usuario"
        Usuario.Size = New Size(119, 23)
        Usuario.TabIndex = 9
        Usuario.Text = "Usuarios"
        Usuario.TextAlign = ContentAlignment.BottomCenter
        Usuario.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(14, 209)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(30, 26)
        PictureBox5.TabIndex = 2
        PictureBox5.TabStop = False
        ' 
        ' acciones
        ' 
        acciones.BackColor = Color.Transparent
        acciones.Cursor = Cursors.Hand
        acciones.FlatAppearance.BorderSize = 0
        acciones.FlatStyle = FlatStyle.Flat
        acciones.Location = New Point(14, 209)
        acciones.Name = "acciones"
        acciones.Size = New Size(119, 23)
        acciones.TabIndex = 8
        acciones.Text = "Acciones"
        acciones.TextAlign = ContentAlignment.BottomCenter
        acciones.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(14, 177)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 26)
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' permisos
        ' 
        permisos.Cursor = Cursors.Hand
        permisos.FlatAppearance.BorderSize = 0
        permisos.FlatStyle = FlatStyle.Flat
        permisos.Location = New Point(14, 180)
        permisos.Name = "permisos"
        permisos.Size = New Size(119, 23)
        permisos.TabIndex = 7
        permisos.Text = "Permisos "
        permisos.TextAlign = ContentAlignment.BottomCenter
        permisos.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(14, 98)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 27)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Inicio
        ' 
        Inicio.Cursor = Cursors.Hand
        Inicio.FlatAppearance.BorderSize = 0
        Inicio.FlatStyle = FlatStyle.Flat
        Inicio.Location = New Point(3, 102)
        Inicio.Name = "Inicio"
        Inicio.Size = New Size(119, 23)
        Inicio.TabIndex = 5
        Inicio.Text = "Inicio"
        Inicio.TextAlign = ContentAlignment.BottomCenter
        Inicio.UseVisualStyleBackColor = True
        ' 
        ' rol
        ' 
        rol.AutoSize = True
        rol.ForeColor = SystemColors.AppWorkspace
        rol.Location = New Point(45, 62)
        rol.Name = "rol"
        rol.Size = New Size(113, 15)
        rol.TabIndex = 4
        rol.Text = "Super Adminstrador"
        ' 
        ' User
        ' 
        User.AutoSize = True
        User.ForeColor = SystemColors.AppWorkspace
        User.Location = New Point(44, 47)
        User.Name = "User"
        User.Size = New Size(89, 15)
        User.TabIndex = 3
        User.Text = "Rosmy Pachón "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 24)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Titulo
        ' 
        Titulo.AutoSize = True
        Titulo.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Titulo.ForeColor = SystemColors.ActiveCaption
        Titulo.Location = New Point(14, 15)
        Titulo.Name = "Titulo"
        Titulo.Size = New Size(137, 23)
        Titulo.TabIndex = 0
        Titulo.Text = "Horario Ideal"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(299, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 25
        ' 
        ' Form_asignaturas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 604)
        Controls.Add(Panel2)
        Controls.Add(Contenedor)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form_asignaturas"
        Text = "Form_asignaturas"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Contenedor.ResumeLayout(False)
        CType(Usuarios, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Contenedor As Panel
    Friend WithEvents Usuarios As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents roles As Button
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents salir As Button
    Friend WithEvents horarios As Button
    Friend WithEvents asinaturas As Button
    Friend WithEvents grados As Button
    Friend WithEvents aulas As Button
    Friend WithEvents profesores As Button
    Friend WithEvents estudiantes As Button
    Friend WithEvents Usuario As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents acciones As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents permisos As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Inicio As Button
    Friend WithEvents rol As Label
    Friend WithEvents User As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Titulo As Label
    Friend WithEvents Label1 As Label
End Class
