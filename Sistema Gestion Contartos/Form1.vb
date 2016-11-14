Public Class frmMenu


    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NuevoCVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoCVToolStripMenuItem.Click
        frmMaestroCV.Show()
    End Sub

    Private Sub AsignarMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarMateriaToolStripMenuItem.Click
        frmMaestroAspirantes.Show()
    End Sub

    Private Sub NuevoDictamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDictamenToolStripMenuItem.Click
        frmMaestroDictamenes.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NuevoContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoContratoToolStripMenuItem.Click
        frmMaestroContratos.Show()
    End Sub
End Class
