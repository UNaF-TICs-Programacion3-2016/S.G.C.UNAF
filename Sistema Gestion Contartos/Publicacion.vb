Public Class Publicacion
    Private vAno As Integer
    Private vDescripcion As String

    Property Ano As Integer
        Get
            Return vAno
        End Get
        Set(value As Integer)
            vAno = value
        End Set
    End Property

    Property Descripcion As String
        Get
            Return vDescripcion
        End Get
        Set(value As String)
            vDescripcion = value
        End Set
    End Property
End Class
