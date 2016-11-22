Public Class Asignacion
    Private relapersona As Integer
    Private relaasignatura As Integer
    Public datoslista As String
    Public tabla As String
    Public campos As String
    Public Sub tomardatosdepantalla(ByVal relapersona As String, ByVal relaasignatura As String)
        With Me
            .relapersona = relapersona
            .relaasignatura = relaasignatura
            .datoslista = "'" + .relapersona + "', '" + .relaasignatura + "'"
            .tabla = "MASIGNACIONES"
            .campos = "RELAPERSONA, RELAASIGNATURA"
        End With
    End Sub

End Class
