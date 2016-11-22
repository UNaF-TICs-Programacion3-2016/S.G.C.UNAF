Imports System.Data
Public Class Persona
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
    Private vid As Long
    Private obd As New BD
    Private dt As DataTable

    Public Sub New()

    End Sub
    Public Sub New(ByVal id As String)
        vid = id
        dt = obd.ObtenerDatosDesdeSQL("select * from mpersonas where id_mpersonas = " & id)
    End Sub


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

    Public Function ConsultarTitulos() As DataTable
        Dim dt As DataTable
        dt = obd.ObtenerDatosDesdeSQL("select descripcion,tipo,universidad ,desde,hasta from  mtitulopersona,mtitulos where rela_titulo = id_MtituloS and rela_persona  = " & vid)
        Return dt
    End Function

    Public Function ConsultarAntecedentes() As DataTable '
        Dim dt As DataTable
        dt = obd.ObtenerDatosDesdeSQL("select desde,hasta,organizacion,tipo,cargo, descripcion from  mantpers, MANTECEDENTES_LAB where relaantlab = id_Antecedente_lab and relapersona  = " & vid)
        Return dt
    End Function

    Public Sub Agregartitulo(ByVal titulo As Titulo, ByVal desde As Int16, ByVal hasta As Int16)
        obd.Insertar("mtitulopersona", "rela_persona,rela_titulo,desde,hasta", vid.ToString & "," & titulo.id.ToString & "," & desde.ToString & "," & hasta.ToString)
    End Sub

    Public Sub AgregarAntLab(ByVal Ant As AntLab, ByVal desde As Int16, ByVal hasta As Int16, cargo As String, descripcion As String)
        obd.Insertar("MANTPERS", "RELAPERSONA,RELAANTLAB,DESDE,HASTA,CARGO,DESCRIPCION", vid.ToString & "," & Ant.id.ToString & "," & desde.ToString & "," & hasta.ToString & "," & cargo & "," & descripcion)
    End Sub

    Public Function ConsultarPersonas() As DataTable
        Return obd.ObtenerDatosDesdeSQL("select * from mpersonas")
    End Function

    Public Function ConsularDatosPersona() As DataTable '
        Dim dt As DataTable
        dt = obd.ObtenerDatosDesdeSQL("select * from  mpersonas where id_mpersonas  = " & vid)
        Return dt
    End Function

End Class



