Imports Oracle.DataAccess.Client
Public Class frmDatosAspirantes
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmDatosAspirantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGAMOS EL COMBO CON LOS DATOS DE LA TABLA
        Dim insertaridaspirante As Integer = CInt(frmMaestroAspirantes.datosbusqueda.ToString)
        Dim conexion As New OracleConnection()
        Dim comando As New OracleCommand("Select NOMBRE From MASIGNATURAS", conexion)

        Dim lector As OracleDataReader
        Dim tabla As New DataTable()
        Try
            conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=system;" _
                                        + "Password=123;"
            conexion.Open()
            lector = comando.ExecuteReader(CommandBehavior.CloseConnection)
            tabla.Load(lector, LoadOption.OverwriteChanges)
            'cmbnombreasignatura.DataSource = tabla
            'cmbnombreasignatura.DisplayMember = "NOMBRE"
            'cmbnombreasignatura.ValueMember = "NOMBRE"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

End Class