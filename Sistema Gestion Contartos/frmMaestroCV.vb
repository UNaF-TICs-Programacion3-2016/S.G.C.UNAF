
Public Class frmMaestroCV
    'Private oEntornoDB As New EntornoDB
    'Friend IdPersona As Integer
    'Friend Accion As TipoAccion

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'IdPersona = -1
        'Accion = TipoAccion.Alta
        frmDatosCV.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub frmMaestroCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgvPersonas.DataSource = oEntornoDB.ObtenerDatosDesdeSQL("SELECT ID_PERSONA, APELLIDO, NOMBRE, DNI, CUIL from MPERSONA")
    End Sub



    Private Sub dgvPersonas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellContentClick
        'MsgBox(dgvPersonas.CurrentRow.Cells("ID_PERSONA").Value)
    End Sub
End Class