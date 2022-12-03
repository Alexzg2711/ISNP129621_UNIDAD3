<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividad
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
        Me.DgbDatos = New System.Windows.Forms.DataGridView()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.BtnGenerarCodigo = New System.Windows.Forms.Button()
        Me.GbxIngreso = New System.Windows.Forms.GroupBox()
        Me.BtnAgregarAlumno = New System.Windows.Forms.Button()
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtDui = New System.Windows.Forms.TextBox()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.LblDui = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblGenero = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblDatosAlumno = New System.Windows.Forms.Label()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgbDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxIngreso.SuspendLayout()
        Me.GbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgbDatos
        '
        Me.DgbDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.APELLIDO, Me.GENERO, Me.DIRECCION, Me.DUI, Me.EDAD, Me.CORREO})
        Me.DgbDatos.Location = New System.Drawing.Point(47, 371)
        Me.DgbDatos.Name = "DgbDatos"
        Me.DgbDatos.Size = New System.Drawing.Size(843, 118)
        Me.DgbDatos.TabIndex = 0
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(10, 46)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(238, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(220, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(419, 25)
        Me.LblTitulo.TabIndex = 2
        Me.LblTitulo.Text = "INGRESO DE DATOS DE ESTUDIANTES"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Location = New System.Drawing.Point(7, 16)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(96, 13)
        Me.LblCodigo.TabIndex = 3
        Me.LblCodigo.Text = "Ingresar Codigo"
        '
        'BtnGenerarCodigo
        '
        Me.BtnGenerarCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarCodigo.Location = New System.Drawing.Point(332, 43)
        Me.BtnGenerarCodigo.Name = "BtnGenerarCodigo"
        Me.BtnGenerarCodigo.Size = New System.Drawing.Size(161, 23)
        Me.BtnGenerarCodigo.TabIndex = 4
        Me.BtnGenerarCodigo.Text = "Generar Codigo"
        Me.BtnGenerarCodigo.UseVisualStyleBackColor = True
        '
        'GbxIngreso
        '
        Me.GbxIngreso.Controls.Add(Me.BtnAgregarAlumno)
        Me.GbxIngreso.Controls.Add(Me.LblCodigo)
        Me.GbxIngreso.Controls.Add(Me.BtnGenerarCodigo)
        Me.GbxIngreso.Controls.Add(Me.TxtCodigo)
        Me.GbxIngreso.Location = New System.Drawing.Point(28, 57)
        Me.GbxIngreso.Name = "GbxIngreso"
        Me.GbxIngreso.Size = New System.Drawing.Size(876, 100)
        Me.GbxIngreso.TabIndex = 5
        Me.GbxIngreso.TabStop = False
        '
        'BtnAgregarAlumno
        '
        Me.BtnAgregarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarAlumno.Location = New System.Drawing.Point(618, 43)
        Me.BtnAgregarAlumno.Name = "BtnAgregarAlumno"
        Me.BtnAgregarAlumno.Size = New System.Drawing.Size(160, 23)
        Me.BtnAgregarAlumno.TabIndex = 5
        Me.BtnAgregarAlumno.Text = "Agregar Alumno"
        Me.BtnAgregarAlumno.UseVisualStyleBackColor = True
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.TxtCorreo)
        Me.GbxDatos.Controls.Add(Me.TxtEdad)
        Me.GbxDatos.Controls.Add(Me.TxtDui)
        Me.GbxDatos.Controls.Add(Me.LblCorreo)
        Me.GbxDatos.Controls.Add(Me.LblEdad)
        Me.GbxDatos.Controls.Add(Me.LblDui)
        Me.GbxDatos.Controls.Add(Me.TxtDireccion)
        Me.GbxDatos.Controls.Add(Me.TxtGenero)
        Me.GbxDatos.Controls.Add(Me.LblDireccion)
        Me.GbxDatos.Controls.Add(Me.LblGenero)
        Me.GbxDatos.Controls.Add(Me.TxtApellido)
        Me.GbxDatos.Controls.Add(Me.LblApellido)
        Me.GbxDatos.Controls.Add(Me.TxtNombre)
        Me.GbxDatos.Controls.Add(Me.LblNombre)
        Me.GbxDatos.Controls.Add(Me.LblDatosAlumno)
        Me.GbxDatos.Location = New System.Drawing.Point(28, 175)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(876, 180)
        Me.GbxDatos.TabIndex = 6
        Me.GbxDatos.TabStop = False
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(523, 111)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(277, 20)
        Me.TxtCorreo.TabIndex = 18
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(523, 76)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(277, 20)
        Me.TxtEdad.TabIndex = 17
        '
        'TxtDui
        '
        Me.TxtDui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDui.Location = New System.Drawing.Point(523, 42)
        Me.TxtDui.Name = "TxtDui"
        Me.TxtDui.Size = New System.Drawing.Size(277, 20)
        Me.TxtDui.TabIndex = 16
        Me.TxtDui.Text = "00000000-0"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(402, 114)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(116, 13)
        Me.LblCorreo.TabIndex = 15
        Me.LblCorreo.Text = "Correo Electronico:"
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Location = New System.Drawing.Point(461, 79)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(40, 13)
        Me.LblEdad.TabIndex = 14
        Me.LblEdad.Text = "Edad:"
        '
        'LblDui
        '
        Me.LblDui.AutoSize = True
        Me.LblDui.Location = New System.Drawing.Point(461, 45)
        Me.LblDui.Name = "LblDui"
        Me.LblDui.Size = New System.Drawing.Size(30, 13)
        Me.LblDui.TabIndex = 13
        Me.LblDui.Text = "Dui:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(69, 140)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(277, 20)
        Me.TxtDireccion.TabIndex = 12
        '
        'TxtGenero
        '
        Me.TxtGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGenero.Location = New System.Drawing.Point(69, 111)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(277, 20)
        Me.TxtGenero.TabIndex = 11
        Me.TxtGenero.Text = "M o F"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(7, 143)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(65, 13)
        Me.LblDireccion.TabIndex = 10
        Me.LblDireccion.Text = "Direccion:"
        '
        'LblGenero
        '
        Me.LblGenero.AutoSize = True
        Me.LblGenero.Location = New System.Drawing.Point(7, 114)
        Me.LblGenero.Name = "LblGenero"
        Me.LblGenero.Size = New System.Drawing.Size(52, 13)
        Me.LblGenero.TabIndex = 9
        Me.LblGenero.Text = "Genero:"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(69, 76)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(277, 20)
        Me.TxtApellido.TabIndex = 8
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(7, 79)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(56, 13)
        Me.LblApellido.TabIndex = 7
        Me.LblApellido.Text = "Apellido:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(69, 42)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(277, 20)
        Me.TxtNombre.TabIndex = 6
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(7, 45)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(54, 13)
        Me.LblNombre.TabIndex = 5
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDatosAlumno
        '
        Me.LblDatosAlumno.AutoSize = True
        Me.LblDatosAlumno.Location = New System.Drawing.Point(7, 16)
        Me.LblDatosAlumno.Name = "LblDatosAlumno"
        Me.LblDatosAlumno.Size = New System.Drawing.Size(110, 13)
        Me.LblDatosAlumno.TabIndex = 4
        Me.LblDatosAlumno.Text = "Datos del Alumno:"
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'APELLIDO
        '
        Me.APELLIDO.HeaderText = "APELLIDO"
        Me.APELLIDO.Name = "APELLIDO"
        '
        'GENERO
        '
        Me.GENERO.HeaderText = "GENERO"
        Me.GENERO.Name = "GENERO"
        '
        'DIRECCION
        '
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        '
        'DUI
        '
        Me.DUI.HeaderText = "DUI"
        Me.DUI.Name = "DUI"
        '
        'EDAD
        '
        Me.EDAD.HeaderText = "EDAD"
        Me.EDAD.Name = "EDAD"
        '
        'CORREO
        '
        Me.CORREO.HeaderText = "CORREO ELECTRONICO"
        Me.CORREO.Name = "CORREO"
        '
        'FrmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 501)
        Me.Controls.Add(Me.GbxDatos)
        Me.Controls.Add(Me.GbxIngreso)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.DgbDatos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmActividad"
        Me.Text = "TAREA EVALUADA ACTIVIDAD UNIDAD 2"
        CType(Me.DgbDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxIngreso.ResumeLayout(False)
        Me.GbxIngreso.PerformLayout()
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgbDatos As DataGridView
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblCodigo As Label
    Friend WithEvents BtnGenerarCodigo As Button
    Friend WithEvents GbxIngreso As GroupBox
    Friend WithEvents BtnAgregarAlumno As Button
    Friend WithEvents GbxDatos As GroupBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblGenero As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents LblApellido As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblDatosAlumno As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtDui As TextBox
    Friend WithEvents LblCorreo As Label
    Friend WithEvents LblEdad As Label
    Friend WithEvents LblDui As Label
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO As DataGridViewTextBoxColumn
    Friend WithEvents GENERO As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As DataGridViewTextBoxColumn
    Friend WithEvents DUI As DataGridViewTextBoxColumn
    Friend WithEvents EDAD As DataGridViewTextBoxColumn
    Friend WithEvents CORREO As DataGridViewTextBoxColumn
End Class
