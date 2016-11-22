Imports System.Data
Public Class Titulo
    'Private vDescripcion As String
    'Private vTipo As String
    Private vDesde As Integer
    Private vHasta As Integer
    ' Private vUniversidad As String
    Private vid As Long
    Private oBD As New BD
    Private dt As DataTable

    Public Sub New(ByVal id As String)
        vid = id
        dt = oBD.ObtenerDatosDesdeSQL("select * from mtitulos where id_MtituloS = " & id)
    End Sub

    'Property Descripcion As String
    '    Get
    '        Return vDescripcion
    '    End Get
    '    Set(value As String)
    '        vDescripcion = value
    '    End Set
    'End Property

    'Property Tipo As String
    '    Get
    '        Return vTipo
    '    End Get
    '    Set(value As String)
    '        vTipo = value
    '    End Set
    'End Property

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

    'Property Universidad As String
    '    Get
    '        Return vUniversidad
    '    End Get
    '    Set(value As String)
    '        vUniversidad = value
    '    End Set
    'End Property

    Property id As Long
        Get
            Return vid
        End Get
        Set(value As Long)
            vid = value
        End Set
    End Property

End Class
