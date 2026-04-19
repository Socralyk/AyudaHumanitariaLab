Public Class Jugador
    Public Property ID_Jugador As String
    Public Property Edad As Integer
    Public Property Nombre As String
    Public Property Apellidos As String
    Public Property Username As String
    Public Property ID_Grupo As Integer
    Public ReadOnly Property JugDAO As JugadorDAO

    Public Sub New()
        Me.JugDAO = New JugadorDAO
    End Sub

    Public Sub New(id1 As String)
        Me.JugDAO = New JugadorDAO
        Me.ID_Jugador = id1
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.JugDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.JugDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.JugDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.JugDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.JugDAO.Borrar(Me)
    End Function
End Class
