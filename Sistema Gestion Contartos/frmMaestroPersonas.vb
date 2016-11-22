
Public Class frmMaestroPersonas
    Private oBD As New BD
    Private oPersona As Persona
    Friend IdPersona As Integer
    Friend Accion As TipoAccion
    Private Conne As New BD
    Private TABLA As String


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        IdPersona = -1
        Accion = TipoAccion.Alta
        frmDatosPersonas.Show()
    End Sub

    Private Sub frmMaestroPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPersonas.DataSource = oBD.ObtenerDatosDesdeSQL("SELECT * from MPERSONAS")
        dgvPersonas.Columns(0).Visible = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        IdPersona = dgvPersonas.CurrentRow.Cells("ID_MPERSONAS").Value
        Accion = TipoAccion.Baja
        TABLA = "MPERSONAS"
        Conne.Borrar(TABLA, IdPersona)
        MessageBox.Show("El registro se eliminó correctamente.")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        IdPersona = dgvPersonas.CurrentRow.Cells("RELATITULO").Value
        Accion = TipoAccion.Modificacion
        frmDatosPersonas.Show()
    End Sub

    Private Sub dgvPersonas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellContentClick

    End Sub
End Class