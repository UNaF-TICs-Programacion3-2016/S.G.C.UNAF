Imports Oracle.DataAccess.Client
Public Class frmDatosCV
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub frmDatosCV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New OracleConnection()
        Dim comando As New OracleCommand("Select * From MLOCALIDAD", conexion)
        Dim lector As OracleDataReader
        Dim tabla As New DataTable()
        Try
            conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=system;" _
                                        + "Password=123;"
            conexion.Open()
            lector = comando.ExecuteReader(CommandBehavior.CloseConnection)
            tabla.Load(lector, LoadOption.OverwriteChanges)
            cmblugardenac.DataSource = tabla
            cmblugardenac.DisplayMember = "DESCRIPCION"
            cmblugardenac.ValueMember = "ID_LOCALIDAD"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtcuilcuit.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub btnguardardatospersonales_Click(sender As Object, e As EventArgs) Handles btnguardardatospersonales.Click

        Dim CADENADEDATOS As String = "'" & txtapellido.Text.ToString & "', '" & txtnombre.Text.ToString & "', '" & CStr(txtdni.Text) & "', '" & CStr(txtcuilcuit.Text) & "', '" & cmbnacionalidad.Text.ToString & "', '" & cmblugardenac.Text.ToString & "', '" & CDate(dtpfechanac.Text) & "'"

        Try
            Dim strdeconec As String
            'Dim CADENADEDATOS As String = TextBox1.Text.ToString & TextBox2.Text.ToString & TextBox3.ToString
            strdeconec = "Data Source=localhost;" _
                     + "User Id=system;" _
                     + "Password=123;"
            'Dim sql As String = "INSERT INTO ZAAA (NOMBRE, APELLIDO, DNI) VALUES ('TUTUTU', 'FAFU', '0000')"
            Dim sql As String = "INSERT INTO PRUEBAMPERSONA (APELLIDO, NOMBRE, DNI, CUIL, NACIONALIDAD, LUGARNAC, FECHANAC) VALUES (" & CADENADEDATOS & ")"
            Dim conexion As New OracleConnection()
            conexion.ConnectionString = strdeconec
            conexion.Open()
            Dim cmd As New OracleCommand(sql, conexion)
            cmd.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

        End Try
    End Sub

    Private Sub btnguardardomicilio_Click(sender As Object, e As EventArgs) Handles btnguardardomicilio.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub btnguardarcontactos_Click(sender As Object, e As EventArgs) Handles btnguardarcontactos.Click
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub btnguardarestudios_Click(sender As Object, e As EventArgs) Handles btnguardarestudios.Click
        TabControl1.SelectedIndex = 4
    End Sub

    Private Sub btnguardarantdocentes_Click(sender As Object, e As EventArgs) Handles btnguardarantdocentes.Click
        TabControl1.SelectedIndex = 5
    End Sub

    Private Sub btnguardarpublicaciones_Click(sender As Object, e As EventArgs) Handles btnguardarpublicaciones.Click
        TabControl1.SelectedIndex = 6
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage2_GotFocus(sender As Object, e As EventArgs) Handles TabPage2.GotFocus

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnsiguiente1_Click(sender As Object, e As EventArgs) Handles btnsiguiente1.Click
        'recuperamos el ultimo id cargado en la tabla personas.
        'Dim datosbusqueda As String
        'datosbusqueda = CStr(TextBox4.Text)
        Dim ultimoid As String
        Dim conexion As New OracleConnection()
        Dim PERSONAds As New DataSet
        Dim adaptador As New OracleDataAdapter("SELECT NOMBRE FROM PRUEBAMPERSONA WHERE ID_PERSONA =(SELECT MAX(PRUEBAMPERSONA.ID_PERSONA) FROM PRUEBAMPERSONA)", conexion)
        'Dim adaptador As New OracleDataAdapter("select MAX(ID_ZAAA) from ZAAA", conexion)
        'Dim tabla As New DataTable
        Try
            conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=system;" _
                                        + "Password=123;"
            adaptador.Fill(PERSONAds, "PRUEBAMPERSONA")
            'tabla = PERSONAds.Tables("ZAAA")
            'DataGridView2.DataSource = PERSONAds.Tables("ZAAA")
            DataGrididactual.DataSource = PERSONAds.Tables("PRUEBAMPERSONA")
            ultimoid = Convert.ToString(DataGrididactual.CurrentRow.Cells(0).Value)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        Finally
            TabControl1.SelectedIndex = 1
        End Try
    End Sub
End Class