Public Class clasedictamen
    Private relasignaciones As String
    Private cargo As String
    Private fecha As String
    Private hora As String
    Private asignatura As String
    Public datoslista As String
    Public tabla As String
    Public campos As String
    Public Sub tomardatosdepantalla(ByVal relasignaciones As String, ByVal cargo As String, ByVal fecha As String, ByVal hora As String, ByVal ASIGNATURA As String)
        With Me
            .relasignaciones = relasignaciones
            .cargo = cargo
            .fecha = fecha
            .hora = hora
            .asignatura = ASIGNATURA
            .datoslista = "'" + .relasignaciones + "', '" + .cargo + "', '" + .fecha + "', '" + .hora + "', '" + .asignatura + "'"
            .tabla = "MDICTAMENES"
            .campos = "RELAASIGNACIONES, CARGO, FECHA, HORA, ASIGNATURA"
        End With
    End Sub

End Class
