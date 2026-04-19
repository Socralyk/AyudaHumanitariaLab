Public Class Combate
    Public Property Id_combate As Integer
    Public Property Id_evento As Integer
    Public Property nombre_grupo1 As String
    Public Property nombre_grupo2 As String
    Public Property id_mapa As String

    Public Property detalles As Collection
    Public ReadOnly Property CombateDAO As CombateDAO

    Public Sub New()
        Me.Id_combate = 0
        Me.detalles = New Collection()
        Me.CombateDAO = New CombateDAO()

    End Sub

    Public Sub New(id As Integer)
        Me.Id_combate = id
        Me.detalles = New Collection()
        Me.CombateDAO = New CombateDAO()
    End Sub

    Public Sub LeerTodosCombates()
        Me.CombateDAO.LeerTodos()
    End Sub

    Public Sub LeerCombate()
        Me.CombateDAO.Leer(Me)
    End Sub

    Public Function InsertarCombate() As Integer
        Return Me.CombateDAO.Insertar(Me)
    End Function

End Class
