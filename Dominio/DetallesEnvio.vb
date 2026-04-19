Public Class DetallesEnvio

    Public Property IDEnvio As Integer
    Public Property IDSuministro As Integer
    Public Property Cantidad As Integer
    Public ReadOnly Property DetEDAO As DetallesEnvioDAO

    Public Sub New()
        Me.DetEDAO = New DetallesEnvioDAO
    End Sub

    Public Sub New(id1 As Integer, id2 As Integer)
        Me.DetEDAO = New DetallesEnvioDAO
        Me.IDEnvio = id1
        Me.IDSuministro = id2
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
