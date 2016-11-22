Module Consulta
    Private obd As New BD
    'consultas para los combos
    Public Function ConsultarPersonas() As DataTable
        Return obd.ObtenerDatosDesdeSQL("select nombre || ' -  ' || apellido as apellido, id_mpersonas from mpersonas")
    End Function

    Public Function ConsultarPersonasFull() As DataTable
        Return obd.ObtenerDatosDesdeSQL("select * from mpersonas")
    End Function
    Public Function ConsultarTitulos() As DataTable
        Return obd.ObtenerDatosDesdeSQL("select descripcion || ' -  ' || universidad as descripcion,id_MtituloS  from  mtitulos")
    End Function

    Public Function ConsultarTipoOrganizaciones() As DataTable
        Return obd.ObtenerDatosDesdeSQL("select Tipo || ' -  ' || organizacion as descripcion,id_Antecedente_lab  from  mantecedentes_lab")
    End Function

End Module
