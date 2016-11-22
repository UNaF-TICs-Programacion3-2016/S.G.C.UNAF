Public Class frmMaestroContratos
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        frmDatosContratos.txtapellido.Text = DataGridView1.CurrentRow.Cells(1).Value
        frmDatosContratos.txtnombre.Text = DataGridView1.CurrentRow.Cells(2).Value
        frmDatosContratos.txtdni.Text = DataGridView1.CurrentRow.Cells(3).Value
        frmDatosContratos.txtcuit.Text = DataGridView1.CurrentRow.Cells(4).Value
        frmDatosContratos.txtdomicilio.Text = DataGridView1.CurrentRow.Cells(8).Value
        frmDatosContratos.txtasignatura.Text = DataGridView2.CurrentRow.Cells(1).Value
        frmDatosContratos.Show()
    End Sub

    Private Sub frmMaestroContratos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim oabm As New ABMT
        oabm.cargargrid(DataGridView1, "MPERSONAS")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim datobusqueda As String = DataGridView1.CurrentCell.Value
        Dim obam As New ABMT
        obam.consultamaterias(DataGridView2, datobusqueda)
    End Sub
End Class