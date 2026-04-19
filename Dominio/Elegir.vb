Public Class Elegir

    Public Property ID_Combate As Integer
    Public Property ID_Jugador As Integer
    Public Property Nombre_Personaje As String

    Public Property detalles As Collection
    Public ReadOnly Property ElegirDAO As ElegirDAO

    Public Sub New()
        Me.ID_Combate = 0
        Me.ID_Jugador = 0
        Me.Nombre_Personaje = ""
        Me.detalles = New Collection()
        Me.ElegirDAO = New ElegirDAO()
    End Sub

    Public Sub New(idC As Integer, idJ As Integer, nomP As String)
        Me.ID_Combate = idC
        Me.ID_Jugador = idJ
        Me.Nombre_Personaje = nomP
        Me.detalles = New Collection()
        Me.ElegirDAO = New ElegirDAO()
    End Sub

    Public Sub LeerTodasElecciones()
        Me.ElegirDAO.LeerTodos()
    End Sub

    Public Sub LeerElegir()
        Me.ElegirDAO.Leer(Me)
    End Sub

    Public Function InsertarElegir() As Integer
        Return Me.ElegirDAO.Insertar(Me)
    End Function



End Class
