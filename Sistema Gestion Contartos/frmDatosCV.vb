Imports Oracle.DataAccess.Client

Public Class frmDatosCV
    Private Conexion As New OracleConnection("Data Source=localhost;
                                        User Id=SYSTEM;
                                        Password=123456;")
    Private oPersona As New Persona
    'Private oDomicilio As New Domicilio
    'Private oEntornoDB As New EntornoDB
    'Dim Adaptador As OracleDataAdapter
    'Dim PersonaDS As New DataSet
    'Dim Registro As DataRow

    'Private Sub frmDatosCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    CargarComboLocalidad()
    '    CargarComboNacionalidad()
    '    CargarComboBarrio()

    '    Adaptador = New OracleDataAdapter("Select * From MPERSONA Where ID_PERSONA = " + frmMaestroCV.IdPersona.ToString, Conexion)
    '    If frmMaestroCV.Accion = TipoAccion.Alta Then
    '        Registro = PersonaDS.Tables("Persona").NewRow()
    '        Registro("ID_PERSONA") = -1
    '    Else
    '        Registro = PersonaDS.Tables("Persona").Rows.Item(0)
    '    End If



    'End Sub

    'Sub TomarDatosDePantalla()

    '    oPersona.Apellido = Registro("APELLIDO").ToString
    '    oPersona.Nombre = Registro("NOMBRE").ToString
    '    oPersona.Dni = Registro("DNI").ToString
    '    oPersona.Cuil = Mid$(Registro("CUIL").ToString(), 3, 8)
    '    oPersona.RelaNacionalidad = Registro("RELANACIONALIDAD")
    '    oPersona.RelaLocalidad = Registro("RELALOCALIDAD")
    '    dtpFechaNac.Value = IIf(IsDBNull(Registro("FECHANAC")), Date.Now, Registro("FECHANAC"))


    'End Sub

    'Sub CargarComboLocalidad()
    '    cboLocalidad.DataSource = oEntornoDB.ObtenerDatosDesdeSQL("SELECT ID_LOCALIDAD, DESCRIPCION from MLOCALIDAD")
    '    cboLocalidad.DisplayMember = "DESCRIPCION"
    '    cboLocalidad.ValueMember = "ID_LOCALIDAD"
    'End Sub

    'Sub CargarComboNacionalidad()
    '    cboNacionalidad.DataSource = oEntornoDB.ObtenerDatosDesdeSQL("SELECT ID_NACIONALIDAD, DESCRIPCION from MNACIONALIDAD")
    '    cboNacionalidad.DisplayMember = "DESCRIPCION"
    '    cboNacionalidad.ValueMember = "ID_NACIONALIDAD"
    'End Sub

    'Sub CargarComboBarrio()
    '    cboBarrio.DataSource = oEntornoDB.ObtenerDatosDesdeSQL("SELECT ID_BARRIO, DESCRIPCION from MBARRIO")
    '    cboBarrio.DisplayMember = "DESCRIPCION"
    '    cboBarrio.ValueMember = "ID_BARRIO"
    'End Sub



    'Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
    '    With oPersona
    '        .Apellido = txtApellido.Text
    '        .Nombre = txtNombre.Text
    '        .Dni = txtDni.Text
    '        .Cuil = txtCuil.Text
    '        .RelaNacionalidad = cboNacionalidad.SelectedValue
    '        .RelaLocalidad = cboLocalidad.SelectedValue
    '        .FechaNac = dtpFechaNac.Value
    '    End With

    '    With oDomicilio
    '        .Calle = txtCalle.Text
    '        .Altura = txtAltura.Text
    '        .RelaBarrio = cboBarrio.SelectedValue
    '    End With

    '    oPersona.AgregarDomicilio(oDomicilio)

    '    TabControl1.SelectedIndex = 1
    'End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAceptarAnt.Click

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub dgvAntLab_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAntLab.CellContentClick

    End Sub

    Private Sub frmDatosCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Private Sub btnCancelarAnt_Click(sender As Object, e As EventArgs) Handles btnCancelarAnt.Click

    End Sub

    Private Sub btnCancelarPub_Click(sender As Object, e As EventArgs) Handles btnCancelarPub.Click

    End Sub
End Class