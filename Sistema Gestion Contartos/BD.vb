Imports Oracle.DataAccess.Client
Public Class EntornoDB

    Private Conn As New OracleConnection

    'Public Sub New()
    '    Conexion.ConnectionString = "Data Source=localhost;" _
    '                                        + "User Id=SYSTEM;" _
    '                                        + "Password=123456;"
    'End Sub

    'Public ReadOnly Property Conexion As OracleConnection
    '    Get
    '        Return Conn
    '    End Get
    'End Property

    'Private Sub Conectar()
    '    Try
    '        Conexion.Open()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub Desconectar()
    '    Try
    '        Conexion.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Public Function ObtenerDatosDesdeSQL(SQL As String) As DataTable

    '    Dim DS As New DataSet
    '    Dim DT As New DataTable
    '    Dim Adaptador As New OracleDataAdapter(SQL, Conexion)

    '    Adaptador.Fill(DS, "Tabla")

    '    DT = DS.Tables("Tabla")

    '    Return DT

    'End Function





End Class
