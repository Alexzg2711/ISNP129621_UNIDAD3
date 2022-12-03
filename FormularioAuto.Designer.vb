<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAuto
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
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.TxtTransmision = New System.Windows.Forms.TextBox()
        Me.TxtPasajeros = New System.Windows.Forms.TextBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.LblTransmision = New System.Windows.Forms.Label()
        Me.LblPasajeros = New System.Windows.Forms.Label()
        Me.TxtColor = New System.Windows.Forms.TextBox()
        Me.TxtAno = New System.Windows.Forms.TextBox()
        Me.LblColor = New System.Windows.Forms.Label()
        Me.LblAno = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblDatosAuto = New System.Windows.Forms.Label()
        Me.GbxIngreso = New System.Windows.Forms.GroupBox()
        Me.BtnAgregarAuto = New System.Windows.Forms.Button()
        Me.LblPlaca = New System.Windows.Forms.Label()
        Me.BtnGenerarPlaca = New System.Windows.Forms.Button()
        Me.TxtPlaca = New System.Windows.Forms.TextBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.DgbDatos = New System.Windows.Forms.DataGridView()
        Me.PLACA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CORREO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbxDatos.SuspendLayout()
        Me.GbxIngreso.SuspendLayout()
        CType(Me.DgbDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.TxtTipo)
        Me.GbxDatos.Controls.Add(Me.TxtTransmision)
        Me.GbxDatos.Controls.Add(Me.TxtPasajeros)
        Me.GbxDatos.Controls.Add(Me.LblTipo)
        Me.GbxDatos.Controls.Add(Me.LblTransmision)
        Me.GbxDatos.Controls.Add(Me.LblPasajeros)
        Me.GbxDatos.Controls.Add(Me.TxtColor)
        Me.GbxDatos.Controls.Add(Me.TxtAno)
        Me.GbxDatos.Controls.Add(Me.LblColor)
        Me.GbxDatos.Controls.Add(Me.LblAno)
        Me.GbxDatos.Controls.Add(Me.TxtModelo)
        Me.GbxDatos.Controls.Add(Me.LblModelo)
        Me.GbxDatos.Controls.Add(Me.TxtMarca)
        Me.GbxDatos.Controls.Add(Me.LblMarca)
        Me.GbxDatos.Controls.Add(Me.LblDatosAuto)
        Me.GbxDatos.Location = New System.Drawing.Point(11, 175)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(876, 180)
        Me.GbxDatos.TabIndex = 9
        Me.GbxDatos.TabStop = False
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(523, 111)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(277, 20)
        Me.TxtTipo.TabIndex = 18
        '
        'TxtTransmision
        '
        Me.TxtTransmision.Location = New System.Drawing.Point(523, 76)
        Me.TxtTransmision.Name = "TxtTransmision"
        Me.TxtTransmision.Size = New System.Drawing.Size(277, 20)
        Me.TxtTransmision.TabIndex = 17
        '
        'TxtPasajeros
        '
        Me.TxtPasajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasajeros.Location = New System.Drawing.Point(523, 42)
        Me.TxtPasajeros.Name = "TxtPasajeros"
        Me.TxtPasajeros.Size = New System.Drawing.Size(277, 20)
        Me.TxtPasajeros.TabIndex = 16
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(486, 114)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(31, 13)
        Me.LblTipo.TabIndex = 15
        Me.LblTipo.Text = "Tipo:"
        '
        'LblTransmision
        '
        Me.LblTransmision.AutoSize = True
        Me.LblTransmision.Location = New System.Drawing.Point(461, 79)
        Me.LblTransmision.Name = "LblTransmision"
        Me.LblTransmision.Size = New System.Drawing.Size(66, 13)
        Me.LblTransmision.TabIndex = 14
        Me.LblTransmision.Text = "Transmision:"
        '
        'LblPasajeros
        '
        Me.LblPasajeros.AutoSize = True
        Me.LblPasajeros.Location = New System.Drawing.Point(461, 45)
        Me.LblPasajeros.Name = "LblPasajeros"
        Me.LblPasajeros.Size = New System.Drawing.Size(56, 13)
        Me.LblPasajeros.TabIndex = 13
        Me.LblPasajeros.Text = "Pasajeros:"
        '
        'TxtColor
        '
        Me.TxtColor.Location = New System.Drawing.Point(69, 140)
        Me.TxtColor.Name = "TxtColor"
        Me.TxtColor.Size = New System.Drawing.Size(277, 20)
        Me.TxtColor.TabIndex = 12
        '
        'TxtAno
        '
        Me.TxtAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAno.Location = New System.Drawing.Point(69, 111)
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.Size = New System.Drawing.Size(277, 20)
        Me.TxtAno.TabIndex = 11
        '
        'LblColor
        '
        Me.LblColor.AutoSize = True
        Me.LblColor.Location = New System.Drawing.Point(7, 143)
        Me.LblColor.Name = "LblColor"
        Me.LblColor.Size = New System.Drawing.Size(34, 13)
        Me.LblColor.TabIndex = 10
        Me.LblColor.Text = "Color:"
        '
        'LblAno
        '
        Me.LblAno.AutoSize = True
        Me.LblAno.Location = New System.Drawing.Point(7, 114)
        Me.LblAno.Name = "LblAno"
        Me.LblAno.Size = New System.Drawing.Size(29, 13)
        Me.LblAno.TabIndex = 9
        Me.LblAno.Text = "Año:"
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(69, 76)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(277, 20)
        Me.TxtModelo.TabIndex = 8
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Location = New System.Drawing.Point(7, 79)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(45, 13)
        Me.LblModelo.TabIndex = 7
        Me.LblModelo.Text = "Modelo:"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(69, 42)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(277, 20)
        Me.TxtMarca.TabIndex = 6
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(7, 45)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(40, 13)
        Me.LblMarca.TabIndex = 5
        Me.LblMarca.Text = "Marca:"
        '
        'LblDatosAuto
        '
        Me.LblDatosAuto.AutoSize = True
        Me.LblDatosAuto.Location = New System.Drawing.Point(7, 16)
        Me.LblDatosAuto.Name = "LblDatosAuto"
        Me.LblDatosAuto.Size = New System.Drawing.Size(80, 13)
        Me.LblDatosAuto.TabIndex = 4
        Me.LblDatosAuto.Text = "Datos del Auto:"
        '
        'GbxIngreso
        '
        Me.GbxIngreso.Controls.Add(Me.BtnAgregarAuto)
        Me.GbxIngreso.Controls.Add(Me.LblPlaca)
        Me.GbxIngreso.Controls.Add(Me.BtnGenerarPlaca)
        Me.GbxIngreso.Controls.Add(Me.TxtPlaca)
        Me.GbxIngreso.Location = New System.Drawing.Point(11, 57)
        Me.GbxIngreso.Name = "GbxIngreso"
        Me.GbxIngreso.Size = New System.Drawing.Size(876, 100)
        Me.GbxIngreso.TabIndex = 8
        Me.GbxIngreso.TabStop = False
        '
        'BtnAgregarAuto
        '
        Me.BtnAgregarAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarAuto.Location = New System.Drawing.Point(618, 43)
        Me.BtnAgregarAuto.Name = "BtnAgregarAuto"
        Me.BtnAgregarAuto.Size = New System.Drawing.Size(160, 23)
        Me.BtnAgregarAuto.TabIndex = 5
        Me.BtnAgregarAuto.Text = "Agregar Auto"
        Me.BtnAgregarAuto.UseVisualStyleBackColor = True
        '
        'LblPlaca
        '
        Me.LblPlaca.AutoSize = True
        Me.LblPlaca.Location = New System.Drawing.Point(7, 16)
        Me.LblPlaca.Name = "LblPlaca"
        Me.LblPlaca.Size = New System.Drawing.Size(75, 13)
        Me.LblPlaca.TabIndex = 3
        Me.LblPlaca.Text = "Ingresar Placa"
        '
        'BtnGenerarPlaca
        '
        Me.BtnGenerarPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarPlaca.Location = New System.Drawing.Point(332, 43)
        Me.BtnGenerarPlaca.Name = "BtnGenerarPlaca"
        Me.BtnGenerarPlaca.Size = New System.Drawing.Size(161, 23)
        Me.BtnGenerarPlaca.TabIndex = 4
        Me.BtnGenerarPlaca.Text = "Generar Placa"
        Me.BtnGenerarPlaca.UseVisualStyleBackColor = True
        '
        'TxtPlaca
        '
        Me.TxtPlaca.Location = New System.Drawing.Point(10, 46)
        Me.TxtPlaca.Name = "TxtPlaca"
        Me.TxtPlaca.Size = New System.Drawing.Size(238, 20)
        Me.TxtPlaca.TabIndex = 1
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(253, 19)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(343, 25)
        Me.LblTitulo.TabIndex = 7
        Me.LblTitulo.Text = "INGRESO DE DATOS DE AUTOS"
        '
        'DgbDatos
        '
        Me.DgbDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgbDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PLACA, Me.NOMBRE, Me.APELLIDO, Me.GENERO, Me.DIRECCION, Me.DUI, Me.EDAD, Me.CORREO})
        Me.DgbDatos.Location = New System.Drawing.Point(21, 369)
        Me.DgbDatos.Name = "DgbDatos"
        Me.DgbDatos.Size = New System.Drawing.Size(843, 118)
        Me.DgbDatos.TabIndex = 10
        '
        'PLACA
        '
        Me.PLACA.HeaderText = "PLACA"
        Me.PLACA.Name = "PLACA"
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "MARCA"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'APELLIDO
        '
        Me.APELLIDO.HeaderText = "MODELO"
        Me.APELLIDO.Name = "APELLIDO"
        '
        'GENERO
        '
        Me.GENERO.HeaderText = "AÑO"
        Me.GENERO.Name = "GENERO"
        '
        'DIRECCION
        '
        Me.DIRECCION.HeaderText = "COLOR"
        Me.DIRECCION.Name = "DIRECCION"
        '
        'DUI
        '
        Me.DUI.HeaderText = "PASAJEROS"
        Me.DUI.Name = "DUI"
        '
        'EDAD
        '
        Me.EDAD.HeaderText = "TRANSMISION"
        Me.EDAD.Name = "EDAD"
        '
        'CORREO
        '
        Me.CORREO.HeaderText = "TIPO"
        Me.CORREO.Name = "CORREO"
        '
        'FormularioAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 499)
        Me.Controls.Add(Me.DgbDatos)
        Me.Controls.Add(Me.GbxDatos)
        Me.Controls.Add(Me.GbxIngreso)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "FormularioAuto"
        Me.Text = "FORMULARIO DE AUTOS"
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        Me.GbxIngreso.ResumeLayout(False)
        Me.GbxIngreso.PerformLayout()
        CType(Me.DgbDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbxDatos As GroupBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents TxtTransmision As TextBox
    Friend WithEvents TxtPasajeros As TextBox
    Friend WithEvents LblTipo As Label
    Friend WithEvents LblTransmision As Label
    Friend WithEvents LblPasajeros As Label
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents TxtAno As TextBox
    Friend WithEvents LblColor As Label
    Friend WithEvents LblAno As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents LblModelo As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblDatosAuto As Label
    Friend WithEvents GbxIngreso As GroupBox
    Friend WithEvents BtnAgregarAuto As Button
    Friend WithEvents LblPlaca As Label
    Friend WithEvents BtnGenerarPlaca As Button
    Friend WithEvents TxtPlaca As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents DgbDatos As DataGridView
    Friend WithEvents PLACA As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO As DataGridViewTextBoxColumn
    Friend WithEvents GENERO As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As DataGridViewTextBoxColumn
    Friend WithEvents DUI As DataGridViewTextBoxColumn
    Friend WithEvents EDAD As DataGridViewTextBoxColumn
    Friend WithEvents CORREO As DataGridViewTextBoxColumn
End Class
