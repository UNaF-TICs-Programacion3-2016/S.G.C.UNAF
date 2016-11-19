Public Class Persona
    Public Dom As New List(Of Domicilio)
    Public Sub AgregarDomicilio(ObjDomicilio As Domicilio)
        Dom.Add(ObjDomicilio)
    End Sub

    Private vIdPersona As Integer
    Private vApellido As String
    Private vNombre As String
    Private vDni As Long
    Private vCuil As String
    Private vNacionalidad As String
    Private vRelaLocalidad As String
    Private vFechaNac As Date

    Public Property IdPersona As Integer
        Get
            Return vIdPersona
        End Get
        Set(value As Integer)
            vIdPersona = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return vApellido
        End Get
        Set(value As String)
            vApellido = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return vNombre
        End Get
        Set(value As String)
            vNombre = value
        End Set
    End Property

    Public Property Dni As Long
        Get
            Return vDni
        End Get
        Set(value As Long)
            vDni = value
        End Set
    End Property

    Public Property Cuil As String
        Get
            Return vCuil
        End Get
        Set(value As String)
            vCuil = value
        End Set
    End Property

    Public Property RelaNacionalidad As Integer
        Get
            Return vNacionalidad
        End Get
        Set(value As Integer)
            vNacionalidad = value
        End Set
    End Property


    Public Property RelaLocalidad As Integer
        Get
            Return vRelaLocalidad
        End Get
        Set(value As Integer)
            vRelaLocalidad = value
        End Set
    End Property


    Public Property FechaNac As Date
        Get
            Return vFechaNac
        End Get
        Set(value As Date)
            vFechaNac = value
        End Set
    End Property



End Class

Public Class Domicilio
    Private vIdDomicilio As Integer
    Private vCalle As String
    Private vAltura As Integer
    Private vRelaBarrio As Integer

    Public Property IdDomicilio As Integer
        Get
            Return vIdDomicilio
        End Get
        Set(value As Integer)
            vIdDomicilio = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return vCalle
        End Get
        Set(value As String)
            vCalle = value
        End Set
    End Property

    Public Property Altura As Integer
        Get
            Return vAltura
        End Get
        Set(value As Integer)
            vAltura = value
        End Set
    End Property


    Public Property RelaBarrio As Integer
        Get
            Return vRelaBarrio
        End Get
        Set(value As Integer)
            vRelaBarrio = value
        End Set
    End Property



End Class
