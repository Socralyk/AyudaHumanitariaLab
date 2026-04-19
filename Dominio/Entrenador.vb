Public Class Entrenador
    Public Property ID_Entrenador As String
    Public Property Num_Agencia As Integer
    Public Property Nombre As String
    Public Property Apellidos As String
    Public Property Nacionalidad As String
    Public Property Edad As Integer
    Public ReadOnly Property EntDAO As EntrenadorDAO

    Public Sub New()
        Me.EntDAO = New EntrenadorDAO
    End Sub

    Public Sub New(id1 As String)
        Me.EntDAO = New EntrenadorDAO
        Me.ID_Entrenador = id1
    End Sub

    Public Sub LeerTodosEntrenadores()
        Me.EntDAO.LeerTodas()
    End Sub

    Public Sub LeerEntrenador()
        Me.EntDAO.Leer(Me)
    End Sub

    Public Function InsertarEntrenador() As Integer
        Return Me.EntDAO.Insertar(Me)
    End Function

    Public Function ActualizarEntrenador() As Integer
        Return Me.EntDAO.Actualizar(Me)
    End Function

    Public Function BorrarEntrenador() As Integer
        Return Me.EntDAO.Borrar(Me)
    End Function

End Class
