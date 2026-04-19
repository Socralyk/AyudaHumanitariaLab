Public Class DetallesEntrega

    Public Property IdDetalleEntrega As Integer
    Public Property IDEntrega As Integer
    Public Property IDSuministro As Integer
    Public ReadOnly Property DetEDAO As DetallesEntregaDAO

    Public Sub New()
        Me.DetEDAO = New DetallesEntregaDAO
    End Sub

    Public Sub New(id1 As Integer)
        Me.DetEDAO = New DetallesEntregaDAO
        Me.IdDetalleEntrega = id1
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.DetEDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.DetEDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.DetEDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.DetEDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.DetEDAO.Borrar(Me)
    End Function

End Class
