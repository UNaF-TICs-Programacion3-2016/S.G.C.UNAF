Imports Oracle.DataAccess.Client
Public Class frmMaestroAspirantes
    Friend datosbusqueda As String
    Friend buscarid As String
    Friend DATO As String
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Dim CAMPOS As String = 
        Dim obinsercion as New ABMT
        obinsercion.Insertar("MASIGNACIONES", "RELAPERSONA, RELAASIGNATURA", "'" & dgvlistadeaspirantes.CurrentCell.Value & "', '" & dgvlistadematerias.CurrentCell.Value & "'")
        Button1.Enabled = True
    End Sub

    Private Sub frmMaestroAspirantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oabm As New ABMT
        Dim TABLA As String = "MPERSONAS"
        Dim TABLAASIG As String = "MASIGNATURAS"
        DATO = "DESCRIPCION"
        oabm.cargargrid(dgvlistadeaspirantes, TABLA)
        oabm.cargargrid(dgvlistadematerias, "MASIGNATURAS")
        'oabm.CargarCombo(cmbnombreasignatura, TABLAASIG, DATO)
    End Sub


    Private Sub btnvermaterias_Click(sender As Object, e As EventArgs) Handles btnvermaterias.Click
        buscarid = dgvlistadeaspirantes.CurrentCell.Value
        Dim OABM As New ABMT
        OABM.consultamaterias(dgvmatsaspirante, buscarid)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDatosDictamenes.txtapellido.Text = dgvlistadeaspirantes.CurrentRow.Cells(1).Value
        frmDatosDictamenes.txtnombre.Text = dgvlistadeaspirantes.CurrentRow.Cells(2).Value
        frmDatosDictamenes.txtdni.Text = dgvlistadeaspirantes.CurrentRow.Cells(3).Value
        frmDatosDictamenes.txtasignatura.Text = dgvlistadematerias.CurrentRow.Cells(1).Value
        frmDatosDictamenes.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class