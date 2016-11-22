Imports word = Microsoft.Office.Interop.Word
Public Class frmDatosContratos
    Private Sub frmDatosContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objabm As New ABMT
        objabm.CargarCombo(ComboBox3, "MCARGOS", "DESCRIPCION")
        objabm.CargarCombo(ComboBox4, "MCARRERAS", "DESCRIPCION")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnimprimircontrato_Click(sender As Object, e As EventArgs) Handles btnimprimircontrato.Click
        Dim MSWord As New word.Application
        Dim Documento As word.Document

        MsgBox("El DOCUMENTO se guardará en : C:\Users\CaroL\Desktop\S.G.C.Unaf\" & txtapellido.Text + txtasignatura.Text + txtdni.Text + DateTimePicker8.Text & "CONTRATO.docx")
        FileCopy("C:\Users\CaroL\Desktop\S.G.C.Unaf\CONTRATO MODELO.docx", "C:\Users\CaroL\Desktop\S.G.C.Unaf\" & txtapellido.Text + txtasignatura.Text + txtdni.Text & "CONTRATO.docx")
        Documento = MSWord.Documents.Open("C:\Users\CaroL\Desktop\S.G.C.Unaf\" & txtapellido.Text + txtasignatura.Text + txtdni.Text & "CONTRATO.docx")

        Documento.Bookmarks.Item("fecha").Range.Text = DateTimePicker8.Text
        Documento.Bookmarks.Item("apellido").Range.Text = txtapellido.Text
        Documento.Bookmarks.Item("nombre").Range.Text = txtnombre.Text
        Documento.Bookmarks.Item("dni").Range.Text = txtdni.Text
        Documento.Bookmarks.Item("cuit").Range.Text = txtcuit.Text
        Documento.Bookmarks.Item("domicilio").Range.Text = txtdomicilio.Text
        Documento.Bookmarks.Item("cargo").Range.Text = ComboBox3.Text
        Documento.Bookmarks.Item("asignatura").Range.Text = txtasignatura.Text
        Documento.Bookmarks.Item("carrera").Range.Text = ComboBox4.Text
        Documento.Bookmarks.Item("desde").Range.Text = DateTimePicker1.Text
        Documento.Bookmarks.Item("hasta").Range.Text = DateTimePicker2.Text
        Documento.Bookmarks.Item("monto").Range.Text = TextBox5.Text
        Documento.Bookmarks.Item("desde2").Range.Text = DateTimePicker1.Text
        Documento.Bookmarks.Item("hasta2").Range.Text = DateTimePicker2.Text
        Documento.Save()
        MSWord.Visible = True
    End Sub
End Class