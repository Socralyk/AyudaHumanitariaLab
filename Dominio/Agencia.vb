Public Class Agencia
    Public Property Num_Contacto As Integer
    Public Property Nombre As String
    Public Property Pais As String
    Public ReadOnly Property AgeDAO As AgenciaDAO

    Public Sub New()
        Me.AgeDAO = New AgenciaDAO
    End Sub

    Public Sub New(id1 As Integer)
        Me.AgeDAO = New AgenciaDAO
        Me.Num_Contacto = id1
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.AgeDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.AgeDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.AgeDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.AgeDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.AgeDAO.Borrar(Me)
    End Function

End Class
