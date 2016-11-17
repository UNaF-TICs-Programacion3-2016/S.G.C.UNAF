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
                     + "Password=123;"
            conx = New OracleConnection
            conx.ConnectionString = strconexion
            conx.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Insertar(ByVal TABLA As String, ByVal Valores As String)
        Try
            Dim Sql As String = "INSERT INTO " & TABLA & " (" & strcampos & ")" _
                        + " VALUES (" & Valores & ")"
            ConectarBD()
            cmd = New OracleCommand(Sql, conx)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
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

    Public Sub CargarCombo(COMBO As ComboBox, ByVal TABLA As String)
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
            COMBO.DisplayMember = "DESCRIPCION"
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

    Public Sub TraerDatos(ByVal DatSet As DataSet, ByVal TABLA As String, Optional ByVal SelecID As Long = -1)
        Dim SelecTabla As String
        Dim Param As New OracleParameter
        If String.IsNullOrEmpty(TABLA) Then Exit Sub
        If SelecID = -1 Then
            DatSet.Tables(TABLA).NewRow()
            Exit Sub
        End If
        SelecTabla = "SELECT * FROM " & TABLA & " WHERE ID_" & TABLA & "= :1"
        Param.OracleDbType = OracleDbType.Long
        Param.Value = SelecID
        Try
            ConectarBD()
            datos = New OracleDataAdapter(SelecTabla, conx)
            With datos
                '.SelectCommand.Connection = Conn
                '.SelectCommand.CommandText = SelectString
                .SelectCommand.Parameters.Add(Param)
                .Fill(DatSet, TABLA)
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
        End Try
    End Sub

End Class

