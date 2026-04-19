Public Class Grupo
    Public Property ID_Grupo As Integer
    Public Property Nombre As String
    Public Property Pais As String
    Public Property ID_Entrenador As String
    Public ReadOnly Property GruDAO As GrupoDAO

    Public Sub New()
        Me.GruDAO = New GrupoDAO
    End Sub

    Public Sub New(id1 As Integer)
        Me.GruDAO = New GrupoDAO
        Me.ID_Grupo = id1
    End Sub

    Public Sub LeerTodosGrupos()
        Me.GruDAO.LeerTodas()
    End Sub

    Public Sub LeerGrupo()
        Me.GruDAO.Leer(Me)
    End Sub

    Public Function InsertarGrupo() As Integer
        Return Me.GruDAO.Insertar(Me)
    End Function

    Public Function ActualizarGrupo() As Integer
        Return Me.GruDAO.Actualizar(Me)
    End Function

    Public Function BorrarGrupo() As Integer
        Return Me.GruDAO.Borrar(Me)
    End Function

End Class
