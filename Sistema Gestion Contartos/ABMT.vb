Imports Oracle.DataAccess.Client
Public Class ABMT
    Public strconexion As String
    Public strcampos As String
    Public conx As OracleConnection
    Public cmd As OracleCommand
    Public datos As OracleDataAdapter
    Dim DS As New DataSet
    Public usandotabla As String
    Private DatReader As OracleDataReader

    Public Sub ConectarBD()
        Try
            strconexion = "Data Source=localhost;" _
                     + "User Id=system;" _
                     + "Password=123456;"
            conx = New OracleConnection
            conx.ConnectionString = strconexion
            conx.Open()
            'MsgBox("CONECTADO!!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Insertar(ByVal TABLA As String, ByVal strcampos As String, ByVal Valores As String)
        Try
            Dim Sql As String = "INSERT INTO " & TABLA & " (" & strcampos & ")" _
                        + " VALUES (" & Valores & ")"
            ConectarBD()
            cmd = New OracleCommand(Sql, conx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            MsgBox("LOS DATOS SE HAN GUARDADO EXITOSAMENTE")
            'MsgBox("***DESCONECTADO***")
            conx.Close()
        End Try
    End Sub

    Public Sub Borrar(ByVal TABLA As String, PARAM_ID As Long)
        Dim Sql As String = "DELETE " & TABLA & " WHERE ID_" & TABLA & " = " & PARAM_ID
        Try
            ConectarBD()
            cmd = New OracleCommand(Sql, conx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conx.Close()
        End Try
    End Sub
    Public Sub cargargrid(datagrid As DataGridView, TABLA As String)
        Try
            ConectarBD()
            Dim PERSONAds As New DataSet
            Dim adaptador As New OracleDataAdapter("select * from " + TABLA, conx)
            adaptador.Fill(PERSONAds, TABLA)
            datagrid.DataSource = PERSONAds.Tables(TABLA)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            'MsgBox("***DESCONECTADO***")
        End Try
    End Sub
    Public Sub consultamaterias(datagrid As DataGridView, DATO As String)
        Try
            ConectarBD()
            Dim PERSONAds As New DataSet
            Dim adaptador As New OracleDataAdapter("SELECT MASIGNACIONES.ID_ASIGNACION, MASIGNATURAS.DESCRIPCION FROM MASIGNATURAS INNER JOIN MASIGNACIONES ON MASIGNATURAS.ID_MASIGNATURAS = MASIGNACIONES.RELAASIGNATURA WHERE MASIGNACIONES.RELAPERSONA = " + DATO, conx)
            adaptador.Fill(PERSONAds, "MASIGNATURAS")
            datagrid.DataSource = PERSONAds.Tables("MASIGNATURAS")
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    Public Sub traerultimoregistroaundatagrid(datagrid As DataGridView, TABLA As String, campo As String)
        Try
            ConectarBD()
            Dim PERSONAds As New DataSet
            'Dim adaptador As New OracleDataAdapter("select * from " + TABLA, conx)
            Dim adaptador As New OracleDataAdapter("SELECT " + campo + " FROM " + TABLA + " WHERE ID_" + TABLA + " =(SELECT MAX(" + TABLA + ".ID_" + TABLA + ") FROM " + TABLA + ")", conx)
            adaptador.Fill(PERSONAds, TABLA)
            datagrid.DataSource = PERSONAds.Tables(TABLA)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            'MsgBox("***DESCONECTADO***")
        End Try
    End Sub
    Public Sub CargarCombo(COMBO As ComboBox, ByVal TABLA As String, DATO As String) ', dato As String)
        Try
            Dim SelecTabla As String = "SELECT * FROM " + TABLA
            ConectarBD()
            cmd = New OracleCommand(SelecTabla, conx)
            DatReader = cmd.ExecuteReader() ' Visual Basic
            ' Dim datos As New OracleDataAdapter(cmd)
            Dim dt As New DataTable
            dt.Load(DatReader, LoadOption.OverwriteChanges)
            COMBO.DataSource = dt
            COMBO.ValueMember = "ID_" + TABLA
            COMBO.DisplayMember = DATO
        Catch ex As Exception ' catches any error
            MessageBox.Show(ex.Message.ToString())
        Finally
            ' In a real application, put cleanup code here.
            conx.Close()
        End Try
    End Sub

    Public Sub Modificar(ByVal TABLA As String, ByVal Modificar_Datos As String, ByVal SelecID As Long)
        Try
            Dim Sql As String = "UPDATE " & TABLA & " SET " & Modificar_Datos & " WHERE ID_" & TABLA & " = " & SelecID
            ConectarBD()
            cmd = New OracleCommand(Sql, conx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conx.Close()
        End Try
    End Sub


End Class

