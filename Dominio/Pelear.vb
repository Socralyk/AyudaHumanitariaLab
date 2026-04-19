Public Class Pelear

    Public Property ID_Grupo1 As String
    Public Property ID_Grupo2 As String
    Public Property ID_Combate As Integer

    Public Property detalles As Collection
    Public ReadOnly Property PelearDAO As PelearDAO

    Public Sub New()


        Me.ID_Grupo1 = ""
        Me.ID_Grupo2 = ""
        Me.ID_Combate = 0
        Me.detalles = New Collection()
        Me.PelearDAO = New PelearDAO()
    End Sub

    Public Sub New(idG1 As String, idG2 As String, idC As Integer)
        Me.PelearDAO = New PelearDAO()
        Me.ID_Grupo1 = idG1
        Me.ID_Grupo2 = idG2
        Me.ID_Combate = idC
        Me.detalles = New Collection()
    End Sub

    Public Sub LeerTodasPeleas()
        Me.PelearDAO.LeerTodos()
    End Sub

    Public Sub LeerPelea()
        Me.PelearDAO.Leer(Me)
    End Sub

    Public Function InsertarPelea() As Integer
        Return Me.PelearDAO.Insertar(Me)
    End Function

End Class
