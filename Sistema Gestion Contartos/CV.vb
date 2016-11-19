Public Class Persona
    'Public Dom As New List(Of Domicilio)
    'Public Sub AgregarDomicilio(ObjDomicilio As Domicilio)
    '    Dom.Add(ObjDomicilio)
    'End Sub

    Private vApellido As String
    Private vNombre As String
    Private vDni As Long
    Private vCuil As String
    Private vNacionalidad As String
    Private vLugarNac As String
    Private vFechaNac As Date
    Private vDireccion As String
    Private vTelefono As String
    Private vCelular As String
    Private vEmail As String

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

    Public Property Nacionalidad As String
        Get
            Return vNacionalidad
        End Get
        Set(value As String)
            vNacionalidad = value
        End Set
    End Property

    Public Property LugarNac As String
        Get
            Return vLugarNac
        End Get
        Set(value As String)
            vLugarNac = value
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

    Public Property Direccion As String
        Get
            Return vDireccion
        End Get
        Set(value As String)
            vDireccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return vTelefono
        End Get
        Set(value As String)
            vTelefono = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return vCelular
        End Get
        Set(value As String)
            vCelular = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return vEmail
        End Get
        Set(value As String)
            vEmail = value
        End Set
    End Property

End Class

