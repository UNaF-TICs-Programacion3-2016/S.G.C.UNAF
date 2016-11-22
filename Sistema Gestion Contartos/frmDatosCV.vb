Imports Oracle.DataAccess.Client

Public Class frmDatosCV

    Private Tabla As String
    Private Campos As String
    Private Valores As String
    Private objPersona As Persona



    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim NuevoTitulo As New Titulo(Me.cmbtitulos.SelectedValue) 'IDTITULO
        objPersona.Agregartitulo(NuevoTitulo, Me.txtDesde.Text, Me.txtHasta.Text)
        CargarTitulosPersonas() 'carga los titulos de la persona en la grilla
    End Sub

    Private Sub btnAceptarAnt_Click(sender As Object, e As EventArgs) Handles btnAceptarAnt.Click
        Dim NuevoAntLab As New AntLab(Me.cboOrganizacion.SelectedValue) 'REla
        objPersona.AgregarAntLab(NuevoAntLab, Me.txtDesdeAnt.Text, Me.txtHastaAnt.Text, Me.txtCargo.Text, Me.txtDescripcion.Text)
        CargarAntecedentesPersonas() 'carga los titulos de la persona en la grilla
    End Sub

    Private Sub CargarPersonas()
        cmbPersona.DataSource = Consulta.ConsultarPersonas
        cmbPersona.ValueMember = "id_mpersonas"
        cmbPersona.DisplayMember = "apellido"
    End Sub

    Private Sub CargarOrganizaciones()
        Me.cboOrganizacion.DataSource = Consulta.ConsultarTipoOrganizaciones()
        Me.cboOrganizacion.ValueMember = "ID_ANTECEDENTE_LAB"
        Me.cboOrganizacion.DisplayMember = "descripcion"
    End Sub

    Private Sub CargarTitulos()

        If cmbPersona.SelectedValue = -1 Then Err.Raise("Seleccione una Persona")
        Try
            Me.cmbtitulos.DataSource = Consulta.consultartitulos
            cmbtitulos.DisplayMember = "descripcion"
            cmbtitulos.ValueMember = "id_MtituloS"
        Catch ex As Exception
        End Try



    End Sub
    Private Sub CargarTitulosPersonas()

        If cmbPersona.SelectedValue = -1 Then Err.Raise("seleccione una persona")
        Try
            Me.dgvTitulos.DataSource = objPersona.consultartitulos()
            Me.dgvTitulos.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub CargarAntecedentesPersonas()

        If Me.cboOrganizacion.SelectedValue = -1 Then Err.Raise("seleccione una organizacion")
        Try
            Me.dgvAntLab.DataSource = objPersona.ConsultarAntecedentes()
            Me.dgvAntLab.Refresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub btnver_Click(sender As Object, e As EventArgs) Handles btnver.Click

        objPersona = New Persona(Me.cmbPersona.SelectedValue)

        CargarTitulosPersonas()
        CargarAntecedentesPersonas()

    End Sub

    Private Sub frmDatosCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CARGAR COMBOS
        CargarPersonas()
        CargarTitulos()
        CargarOrganizaciones()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dispose()
    End Sub

End Class