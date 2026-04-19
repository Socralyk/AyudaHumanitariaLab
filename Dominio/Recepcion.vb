Public Class Recepcion

    Public Property IDRecepcion As Integer
    Public Property IDCentro As Integer
    Public Property DNIVoluntario As String
    Public Property Fecha As Date
    Public Property Origen As String
    Public ReadOnly Property RecDAO As RecepcionDAO

    Public Sub New()
        Me.RecDAO = New RecepcionDAO
    End Sub

    Public Sub New(id1 As Integer)
        Me.RecDAO = New RecepcionDAO
        Me.IDRecepcion = id1
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.RecDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.RecDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.RecDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.RecDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.RecDAO.Borrar(Me)
    End Function

End Class
