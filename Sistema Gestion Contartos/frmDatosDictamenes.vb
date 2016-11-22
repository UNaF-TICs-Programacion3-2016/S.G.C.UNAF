Imports System.IO
Imports Microsoft.Office.Interop
Imports word = Microsoft.Office.Interop.Word
Public Class frmDatosDictamenes
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub frmDatosDictamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objabm As New ABMT
        objabm.CargarCombo(ComboBox3, "MCARGOS", "DESCRIPCION")
        objabm.CargarCombo(cmbcarreras, "MCARRERAS", "DESCRIPCION")
        'Dim relaaspirente As String = 
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnguardardictamen_Click(sender As Object, e As EventArgs)
        Dim obasignacion As New clasedictamen
        'obasignacion.tomardatosdepantalla(DataGridView2.)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MSWord As New word.Application
        Dim Documento As Word.Document

        MsgBox("El DOCUMENTO se guardará en : E:\Dario\Escritorio\S.G.C.Unaf\" & txtapellido.Text + txtasignatura.Text + txtdni.Text + DateTimePicker8.Text & "DICTAMEN.docx")
        FileCopy("C:\Users\CaroL\Desktop\S.G.C.Unaf\DICTAMEN MODELO.docx", "C:\Users\CaroL\Desktop\S.G.C.Unaf\" & txtapellido.Text + txtasignatura.Text + txtdni.Text + DateTimePicker8.Text & "DICTAMEN.docx")
        Documento = MSWord.Documents.Open("C:\Users\CaroL\Desktop\S.G.C.Unaf\" & txtapellido.Text + txtasignatura.Text + txtdni.Text + DateTimePicker8.Text & "DICTAMEN.docx")

        Documento.Bookmarks.Item("hora").Range.Text = DateTimePicker1.Text
        Documento.Bookmarks.Item("fecha").Range.Text = DateTimePicker8.Text
        Documento.Bookmarks.Item("cargo").Range.Text = ComboBox3.Text
        Documento.Bookmarks.Item("asignatura").Range.Text = txtasignatura.Text
        Documento.Bookmarks.Item("docente1").Range.Text = ComboBox6.Text
        Documento.Bookmarks.Item("docente2").Range.Text = ComboBox5.Text
        Documento.Bookmarks.Item("docente3").Range.Text = ComboBox4.Text
        Documento.Bookmarks.Item("apellido").Range.Text = txtapellido.Text
        Documento.Bookmarks.Item("nombre").Range.Text = txtnombre.Text
        Documento.Bookmarks.Item("dni").Range.Text = txtdni.Text
        Documento.Bookmarks.Item("apellido2").Range.Text = txtapellido.Text
        Documento.Bookmarks.Item("nombre2").Range.Text = txtnombre.Text
        Documento.Bookmarks.Item("apellido3").Range.Text = txtapellido.Text
        Documento.Bookmarks.Item("nombre3").Range.Text = txtnombre.Text
        Documento.Bookmarks.Item("cargo2").Range.Text = ComboBox3.Text
        Documento.Bookmarks.Item("asignatura2").Range.Text = txtasignatura.Text
        Documento.Bookmarks.Item("carrera").Range.Text = cmbcarreras.Text


        Documento.Save()
        MSWord.Visible = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class