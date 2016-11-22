Imports System.Data
Public Class AntLab
    Private vDesde As Integer
    Private vHasta As Integer
    'Private vOrganizacion As String
    Private vCargo As String
    'Private vTipo As String
    Private vDescripcion As String
    Private vid As Long
    Private obd As New BD
    Private dt As DataTable

    Public Sub New(ByVal id As String)
        vid = id
        'dt = obd.ObtenerDatosDesdeSQL("select * from mantecedentes_lab where id_antecedente_lab = " & id)
    End Sub


    Property Desde As Integer
        Get
            Return vDesde
        End Get
        Set(value As Integer)
            vDesde = value
        End Set
    End Property

    Property Hasta As Integer
        Get
            Return vHasta
        End Get
        Set(value As Integer)
            vHasta = value
        End Set
    End Property

    'Property Organizacion As String
    '    Get
    '        Return vOrganizacion
    '    End Get
    '    Set(value As String)
    '        vOrganizacion = value
    '    End Set
    'End Property

    Property Cargo As String
        Get
            Return vCargo
        End Get
        Set(value As String)
            vCargo = value
        End Set
    End Property

    'Property Tipo As String
    '    Get
    '        Return vTipo
    '    End Get
    '    Set(value As String)
    '        vTipo = value
    '    End Set
    'End Property

    Property Descripcion As String
        Get
            Return vDescripcion
        End Get
        Set(value As String)
            vDescripcion = value
        End Set
    End Property

    Property id As Long
        Get
            Return vid
        End Get
        Set(value As Long)
            vid = value
        End Set
    End Property

End Class
