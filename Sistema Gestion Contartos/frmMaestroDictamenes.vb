Public Class frmMaestroDictamenes
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmDatosDictamenes.txtapellido.Text = DataGridView1.CurrentRow.Cells(1).Value
        frmDatosDictamenes.txtnombre.Text = DataGridView1.CurrentRow.Cells(2).Value
        frmDatosDictamenes.txtdni.Text = DataGridView1.CurrentRow.Cells(3).Value
        frmDatosDictamenes.txtasignatura.Text = DataGridView2.CurrentRow.Cells(1).Value
        frmDatosDictamenes.Show()
    End Sub

    Private Sub frmMaestroDictamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oabm As New ABMT
        oabm.cargargrid(DataGridView1, "MPERSONAS")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datobusqueda As String = DataGridView1.CurrentCell.Value
        Dim obam As New ABMT
        obam.consultamaterias(DataGridView2, datobusqueda)
    End Sub
End Class