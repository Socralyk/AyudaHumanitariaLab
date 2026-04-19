Public Class Mapa

    Public Property Nombre As String
    Public Property Tamano As String
    Public Property Descripcion As String
    Public ReadOnly Property MapaDAO As MapaDAO

    Public Sub New()
        Me.MapaDAO = New MapaDAO()
    End Sub

    Public Sub New(nombreMapa As String)
        Me.MapaDAO = New MapaDAO()
        Me.Nombre = nombreMapa
    End Sub

    Public Sub LeerTodos()
        Me.MapaDAO.LeerTodas()
    End Sub

    Public Sub Leer()
        Me.MapaDAO.Leer(Me)
    End Sub

    Public Function Insertar() As Integer
        Return Me.MapaDAO.Insertar(Me)
    End Function

    Public Function Actualizar() As Integer
        Return Me.MapaDAO.Actualizar(Me)
    End Function

    Public Function Borrar() As Integer
        Return Me.MapaDAO.Borrar(Me)
    End Function

End Class