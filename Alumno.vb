Public Class Alumno

    'Declaracion de propiedades
    Private Codigo As String
    Private Nombre As String
    Private Apellido As String
    Private Sexo As String
    Private Direccion As String
    Private Dui As String
    Private Edad As String
    Private Correo As String

    'Indica si los campos ingresados estan completos
    Private DatosCompletos As Boolean

    'Metodos de propiedad
    'Metodo para Nombre del alumno
    Public Property NombreAlumno() As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    'Metodo para Apellido del alumno
    Public Property ApellidoAlumno() As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property
    'Metodo para Sexo del alumno
    Public Property SexoAlumno() As String
        Get
            Return Sexo
        End Get
        Set(value As String)
            Sexo = value
        End Set
    End Property
    'Metodo para Direccion del alumno
    Public Property DireccionAlumno() As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property
    'Metodo para Correo del alumno
    Public Property CorreoAlumno() As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property
    'Metodo para Dui del alumno
    Public Property DuiAlumno() As String
        Get
            Return Dui
        End Get
        Set(value As String)
            Dui = value
        End Set
    End Property
    'Metodo para Edad del alumno
    Public Property EdadAlumno() As String
        Get
            Return Edad
        End Get
        Set(value As String)
            Edad = value
        End Set
    End Property
    Public ReadOnly Property DatosAceptados() As Boolean
        Get
            Return DatosCompletos
        End Get
    End Property

    'Metodos
    'Constructor de la clase
    Public Sub New()
        DatosCompletos = False
        'Determina si los datos aun no han sido ingresados
    End Sub

    'Determina si los datos ingresados son correctos y asigna los atributos de la clase
    Public Sub DatosAlumno(ByVal CodigoA As String,
                           ByVal NombreA As String,
                           ByVal ApellidoA As String,
                           ByVal SexoA As String,
                           ByVal DireccionA As String,
                           ByVal DuiA As String,
                           ByVal EdadA As String,
                           ByVal CorreoA As String)

        DatosCompletos = False 'Asume que los datos recibidos son incorrectos

        If CodigoA.Length = 0 Then
            MsgBox("Debe generar el codigo del alumno")
            Exit Sub
        Else
            Codigo = CodigoA
        End If
        If NombreA.Length = 0 Then
            MsgBox("Debe escribir el nombre del alumno")
            Exit Sub
        Else
            Nombre = NombreA
        End If
        If ApellidoA.Length = 0 Then
            MsgBox("Debe escribir el apellido del alumno")
            Exit Sub
        Else
            Apellido = ApellidoA
        End If
        If SexoA.Length = 0 Then
            MsgBox("Debe escribir el sexo del alumno, escriba F para femenino o M para masculino")
            Exit Sub
        Else
            Sexo = SexoA
        End If
        If DireccionA.Length = 0 Then
            MsgBox("Debe escribir la direccion del alumno")
            Exit Sub
        Else
            Direccion = DireccionA
        End If
        If DuiA.Length = 0 Or DuiA.Length < 10 Then
            MsgBox("Debe escribir el Dui del alumno, incluyendo el guion")
            Exit Sub
        Else
            Dui = DuiA
        End If
        If EdadA.Length = 0 Then
            MsgBox("Debe escribir la edad del alumno")
            Exit Sub
        Else
            Edad = EdadA
        End If
        If CorreoA.Length = 0 Then
            MsgBox("Debe escribir el correo del alumno")
            Exit Sub
        Else
            Correo = CorreoA
        End If
    End Sub

    Public Function GenerarCodigo(ByVal Nombre As String)
        Dim Valor1 As String
        Dim Valor2 As String
        Dim Numero As Single

        Valor1 = UCase(Left(Nombre, 1))
        Valor2 = Right(Nombre, 2)
        Numero = Int(Rnd() * 1000) + 65

        Return Valor1 & Numero & Valor2
    End Function
End Class
