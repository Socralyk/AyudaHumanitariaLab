Public Class Personaje

    Public Property Nombre As String
    Public Property Rango As String

    Public Property detalles As Collection
    Public ReadOnly Property PersonajeDAO As PersonajeDAO

    Public Sub New()
        Me.Nombre = ""
        Me.Rango = ""
        Me.detalles = New Collection()
        Me.PersonajeDAO = New PersonajeDAO()
    End Sub


    Public Sub New(nom As String, ran As String)
        Me.Nombre = nom
        Me.Rango = ran
        Me.detalles = New Collection()
        Me.PersonajeDAO = New PersonajeDAO()
    End Sub


    Public Sub LeerTodosPersonajes()
        Me.PersonajeDAO.LeerTodos()
    End Sub

    Public Sub LeerPersonaje()
        Me.PersonajeDAO.Leer(Me)
    End Sub

    Public Function InsertarPersonaje() As Integer
        Return Me.PersonajeDAO.Insertar(Me)
    End Function

    Public Function ActualizarPersonaje() As Integer
        Return Me.PersonajeDAO.Actualizar(Me)
    End Function

    Public Function BorrarPersonaje() As Integer
        Return Me.PersonajeDAO.Borrar(Me)
    End Function
End Class