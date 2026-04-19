Public Class DetallesRecepcion

    Public Property IDRecepcion As Integer
    Public Property IDSuministro As Integer
    Public Property Cantidad As Integer
    Public ReadOnly Property DetRDAO As DetallesRecepcionDAO

    Public Sub New()
        Me.DetRDAO = New DetallesRecepcionDAO
    End Sub

    Public Sub New(id1 As Integer, id2 As Integer)
        Me.DetRDAO = New DetallesRecepcionDAO
        Me.Cantidad = id1
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.DetRDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.DetRDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.DetRDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.DetRDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.DetRDAO.Borrar(Me)
    End Function

End Class
