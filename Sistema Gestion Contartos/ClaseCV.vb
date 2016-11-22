Public Class ClaseCV

    Public Titulos As New List(Of Titulo)


    Public Sub AgregarTitulo(ObjTitulo As Titulo)
        Titulos.Add(ObjTitulo)
    End Sub

    Public Antecedentes As New List(Of AntLab)
    Public Sub AgregarAntLab(ObjAntLab As AntLab)
        Antecedentes.Add(ObjAntLab)
    End Sub

    Public Publicaciones As New List(Of Publicacion)
    Public Sub AgregarTitulo(ObjPublicion As Publicacion)
        Publicaciones.Add(ObjPublicion)
    End Sub


End Class
