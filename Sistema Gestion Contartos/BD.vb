Imports Oracle.DataAccess.Client
Public Class BD
    Private strconexion As String
    Private strcampos As String
    Private conx As OracleConnection
    Private cmd As OracleCommand
    Public datos As OracleDataAdapter
    Dim DS As New DataSet
    Public usandotabla As String
    Private DatReader As OracleDataReader


    Public Sub ConectarBD()
        Try
            strconexion = "Data Source=localhost;" _
                     + "User Id=SYSTEM;" _
                     + "Password=123456;"
            conx = New OracleConnection
            conx.ConnectionString = strconexion
            conx.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Insertar(ByVal TABLA As String, ByVal strcampos As String, ByVal Valores As String)
        Try
            Dim Sql As String = "INSERT INTO " & TABLA & " (" & strcampos & ")" _
                        + " VALUES (" & Valores & ")"
            ConectarBD()
            cmd = New OracleCommand(Sql, conx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conx.Close()
        End Try
    End Sub

    Public Sub Borrar(ByVal TABLA As String, PARAM_ID As Long)
        Dim Sql As String = "DELETE " & TABLA & " WHERE ID_" & TABLA & " = " & PARAM_ID
        Try
            ConectarBD()
            cmd = New OracleCommand(Sql, conx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conx.Close()
        End Try
    End Sub

    Public Sub Modificar(ByVal TABLA As String, ByVal Modificar_Datos As String, ByVal SelecID As Long)
        Try
            Dim Sql As String = "UPDATE " & TABLA & " SET " & Modificar_Datos & " WHERE ID_" & TABLA & " = " & SelecID
            ConectarBD()
            cmd = New OracleCommand(Sql, conx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conx.Close()
        End Try
    End Sub


    Public Function ObtenerDatosDesdeSQL(SQL As String) As DataTable

        Dim DS As New DataSet
        Dim Tabla As New DataTable

        ConectarBD()

        Dim Adaptador As New OracleDataAdapter(SQL, conx)

        Adaptador.Fill(DS, "TABLA")

        Tabla = DS.Tables("TABLA")

        Return Tabla

    End Function


End Class
