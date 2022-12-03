Public Class Auto

    'Declaracion de propiedades
    Private Placa As String
    Private Marca As String
    Private Modelo As String
    Private Ano As String
    Private Color As String
    Private Pasajeros As String
    Private Transmision As String
    Private Tipo As String

    'Indica si los campos ingresados estan completos
    Private DatosCompletos As Boolean

    'Metodos de propiedad
    'Metodo para  Marca del Auto
    Public Property MarcaAuto() As String
        Get
            Return Marca
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property
    'Metodo para Modelo del Auto
    Public Property ModeloAuto() As String
        Get
            Return Modelo
        End Get
        Set(value As String)
            Modelo = value
        End Set
    End Property
    'Metodo para Ano del Auto
    Public Property AnoAuto() As String
        Get
            Return Ano
        End Get
        Set(value As String)
            Ano = value
        End Set
    End Property
    'Metodo para Cilindrada del Auto
    Public Property ColorAuto() As String
        Get
            Return Color
        End Get
        Set(value As String)
            Color = value
        End Set
    End Property
    'Metodo para Pasajeros del Auto
    Public Property PasajerosAuto() As String
        Get
            Return Pasajeros
        End Get
        Set(value As String)
            Pasajeros = value
        End Set
    End Property
    'Metodo para Transmision del Auto
    Public Property TransmisionAuto() As String
        Get
            Return Transmision
        End Get
        Set(value As String)
            Transmision = value
        End Set
    End Property
    'Metodo para Transmision del Auto
    Public Property TipoAuto() As String
        Get
            Return Tipo
        End Get
        Set(value As String)
            Tipo = value
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
    Public Sub DatosAuto(ByVal PlacaA As String,
                           ByVal MarcaA As String,
                           ByVal ModeloA As String,
                           ByVal AnoA As String,
                           ByVal ColorA As String,
                           ByVal PasajerosA As String,
                           ByVal TransmisionA As String,
                           ByVal TipoA As String)

        DatosCompletos = False 'Asume que los datos recibidos son incorrectos

        If PlacaA.Length = 0 Then
            MsgBox("Debe generar la placa del auto")
            Exit Sub
        Else
            Placa = PlacaA
        End If
        If MarcaA.Length = 0 Then
            MsgBox("Debe escribir la marca del auto")
            Exit Sub
        Else
            Marca = MarcaA
        End If
        If ModeloA.Length = 0 Then
            MsgBox("Debe escribir el modelo del auto")
            Exit Sub
        Else
            Modelo = ModeloA
        End If
        If AnoA.Length = 0 Then
            MsgBox("Debe escribir el ano del auto")
            Exit Sub
        Else
            Ano = AnoA
        End If
        If ColorA.Length = 0 Then
            MsgBox("Debe escribir el color del auto")
            Exit Sub
        Else
            Color = ColorA
        End If
        If PasajerosA.Length = 0 Then
            MsgBox("Debe escribir el numero de pasajeros que tiene el auto")
            Exit Sub
        Else
            Pasajeros = PasajerosA
        End If
        If TransmisionA.Length = 0 Then
            MsgBox("Debe escribir el tipo de transmision del auto")
            Exit Sub
        Else
            Transmision = TransmisionA
        End If
        If TipoA.Length = 0 Then
            MsgBox("Debe escribir el tipo del auto")
            Exit Sub
        Else
            Tipo = TipoA
        End If
    End Sub

    Public Function GenerarCodigo(ByVal Placa As String)
        Dim Letra As String
        Dim Numero1 As Single
        Dim Numero2 As Single
        Dim Guion As String

        Letra = "P"
        Numero1 = Int(Rnd() * 1000) + 65
        Guion = "-"
        Numero2 = Int(Rnd() * 1000) + 80

        Return Letra & Numero1 & Guion & Numero2
    End Function
End Class
