Public Class Entrega

    Public Property IDEntrega As Integer
    Public Property IDCentroOrigen As Integer
    Public Property IDZonaDestino As Integer
    Public Property DNIVoluntario As String
    Public Property Fecha As Date
    Public ReadOnly Property EntDAO As EntregaDAO

    Public Sub New()
        Me.EntDAO = New EntregaDAO
    End Sub

    Public Sub New(id1 As Integer)
        Me.EntDAO = New EntregaDAO
        Me.IDEntrega = id1
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.EntDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.EntDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.EntDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.EntDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.EntDAO.Borrar(Me)
    End Function

End Class
