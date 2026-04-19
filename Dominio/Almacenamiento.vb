Public Class Almacenamiento

    Public Property IDCentro As Integer
    Public Property IDSuministro As Integer
    Public Property CantidadStock As Integer
    Public ReadOnly Property AlmDAO As AlmacenamientoDAO

    Public Sub New()
        Me.AlmDAO = New AlmacenamientoDAO
    End Sub

    Public Sub New(id1 As Integer, id2 As Integer)
        Me.AlmDAO = New AlmacenamientoDAO
        Me.IDCentro = id1
        Me.IDSuministro = id2
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.AlmDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.AlmDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.AlmDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.AlmDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.AlmDAO.Borrar(Me)
    End Function

End Class
