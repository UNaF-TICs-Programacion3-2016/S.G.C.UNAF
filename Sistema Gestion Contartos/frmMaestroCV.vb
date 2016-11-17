Imports Oracle.DataAccess.Client

Public Class frmMaestroCV
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmDatosCV.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPERSONAS.CellContentClick

    End Sub

    Private Sub frmMaestroCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim datosbusqueda As String
        'datosbusqueda = CStr(TextBox4.Text)


        Dim conexion As New OracleConnection()
        Dim PERSONAds As New DataSet
        Dim adaptador As New OracleDataAdapter("SELECT * FROM MPERSONA", conexion)
        'Dim adaptador As New OracleDataAdapter("select MAX(ID_ZAAA) from ZAAA", conexion)
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=system;" _
                                        + "Password=123;"
            adaptador.Fill(PERSONAds, "MPERSONA")
            'tabla = PERSONAds.Tables("ZAAA")
            DataGridPERSONAS.DataSource = PERSONAds.Tables("MPERSONA")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class