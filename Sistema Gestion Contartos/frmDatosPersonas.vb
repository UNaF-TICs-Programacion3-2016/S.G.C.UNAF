Imports Oracle.DataAccess.Client

Public Enum TipoAccion As Byte
    Alta = 0
    Baja = 1
    Modificacion = 2
End Enum

Public Class frmDatosPersonas
    Private oPersona As New Persona
    Private Conne As New BD
    Friend IdPersona As Integer
    Friend Accion As TipoAccion
    Dim Valores As String
    Dim Campos As String
    Dim Tabla As String

    Private Sub CargarPersonas()
        dgvPersonas.DataSource = Consulta.ConsultarPersonasFull
        dgvPersonas.Columns(0).Visible = False
        dgvPersonas.Refresh()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub frmDatosPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPersonas()
        Deshabilitar()
    End Sub

    Private Sub TomarDatos()
        With oPersona
            .Apellido = txtApellido.Text
            .Nombre = txtNombre.Text
            .Dni = txtDni.Text
            .Cuil = txtCuil.Text
            .Nacionalidad = txtNacionlidad.Text
            .LugarNac = txtLugNac.Text
            .FechaNac = CDate(dtpFechaNac.Text)
            .Direccion = txtDireccion.Text
            .Telefono = txtTelefono.Text
            .Celular = txtCelular.Text
            .Email = txtEmail.Text
        End With
    End Sub

    Sub Deshabilitar()
        txtApellido.Enabled = False
        txtNombre.Enabled = False
        txtDni.Enabled = False
        txtCuil.Enabled = False
        txtNacionlidad.Enabled = False
        txtLugNac.Enabled = False
        dtpFechaNac.Enabled = False
        txtDireccion.Enabled = False
        txtTelefono.Enabled = False
        txtCelular.Enabled = False
        txtEmail.Enabled = False
        btnAceptar.Enabled = False
    End Sub
    Private Sub Habilitar()

        txtApellido.Text = ""
        txtNombre.Text = ""
        txtDni.Text = ""
        txtCuil.Text = ""
        txtNacionlidad.Text = ""
        txtLugNac.Text = ""
        dtpFechaNac.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        txtEmail.Text = ""

        txtApellido.Enabled = True
        txtNombre.Enabled = True
        txtDni.Enabled = True
        txtCuil.Enabled = True
        txtNacionlidad.Enabled = True
        txtLugNac.Enabled = True
        dtpFechaNac.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        txtCelular.Enabled = True
        txtEmail.Enabled = True
        btnAceptar.Enabled = True
    End Sub

    Private Sub MostrarDatos()

        With oPersona
            txtApellido.Text = .Apellido
            txtNombre.Text = .Nombre
            txtDni.Text = .Dni
            txtCuil.Text = .Cuil
            txtNacionlidad.Text = .Nacionalidad
            txtLugNac.Text = .LugarNac
            dtpFechaNac.Text = .FechaNac
            txtDireccion.Text = .Direccion
            txtTelefono.Text = .Telefono
            txtCelular.Text = .Celular
            txtEmail.Text = .Email
        End With
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If Me.Accion = TipoAccion.Alta Then
            TomarDatos()

            Valores = "'" & (oPersona.Apellido) & "', '" & (oPersona.Nombre) & "','" & (oPersona.Dni) & "','" & (oPersona.Cuil) & "', '" & (oPersona.Nacionalidad) & "', '" & (oPersona.LugarNac) & "', '" & (oPersona.FechaNac) & "', '" & (oPersona.Direccion) & "','" & (oPersona.Telefono) & "', '" & (oPersona.Celular) & "', '" & (oPersona.Email) & "'"
            Campos = "APELLIDO, NOMBRE, DNI, CUIL, NACIONALIDAD, LUGARNAC, FECHANAC, DIRECCION, TELEFONO, CELULAR, EMAIL"
            Tabla = "MPERSONAS"
            Conne.Insertar(Tabla, Campos, Valores)
            Deshabilitar()
            MessageBox.Show("Los datos se guardaron correctamente.")
            CargarPersonas()
        ElseIf Me.Accion = TipoAccion.Modificacion Then
            Valores = "APELLIDO ='" & (oPersona.Apellido) & "', NOMBRE = '" & (oPersona.Nombre) & "', DNI='" & (oPersona.Dni) & "', CUIL= '" & (oPersona.Cuil) & "', NACIONALIDAD= '" & (oPersona.Nacionalidad) & "',LUGARNAC= '" & (oPersona.LugarNac) & "', FECHANAC= '" & (oPersona.FechaNac) & "',  DIRECCION= '" & (oPersona.Direccion) & "', TELEFONO='" & (oPersona.Telefono) & "', CELULAR='" & (oPersona.Celular) & "', EMAIL= '" & (oPersona.Email) & "'"
            Tabla = "MPERSONAS"
            Conne.Modificar(Tabla, Valores, IdPersona)
            Deshabilitar()
            MessageBox.Show("Los datos se actualizaron correctamente.")
            CargarPersonas()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IdPersona = -1
        Accion = TipoAccion.Alta

        'habilitardatos
        Habilitar()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Accion = TipoAccion.Modificacion
        oPersona = New Persona(dgvPersonas.CurrentRow.Cells("ID_MPERSONAS").Value)
        MostrarDatos()
        Habilitar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IdPersona = dgvPersonas.CurrentRow.Cells("ID_MPERSONAS").Value
        Accion = TipoAccion.Baja
        Tabla = "MPERSONAS"
        Conne.Borrar(Tabla, IdPersona)
        MessageBox.Show("El registro se eliminó correctamente.")
        CargarPersonas()
    End Sub
End Class