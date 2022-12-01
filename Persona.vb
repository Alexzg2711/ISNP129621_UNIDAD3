Public Class Persona

    'Declaracion de propiedades
    Private Codigo As String
    Private Nombre As String
    Private Apellido As String
    Private Sexo As String
    Private Direccion As String
    Private Dui As Integer
    Private Edad As Integer
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
    'Metodo para Codigo del alumno
    Public Property CodigoAlumno() As String
        Get
            Return Codigo
        End Get
        Set(value As String)
            Codigo = value
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
    Public Property DuiAlumno() As Integer
        Get
            Return Dui
        End Get
        Set(value As Integer)
            Dui = value
        End Set
    End Property
    'Metodo para Edad del alumno
    Public Property EdadAlumno() As Integer
        Get
            Return Edad
        End Get
        Set(value As Integer)
            Edad = value
        End Set
    End Property
End Class
