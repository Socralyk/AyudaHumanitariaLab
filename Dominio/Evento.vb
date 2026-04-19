Public Class Evento

    Public Property Identificador As Integer
    Public Property Fecha As Date
    Public Property Nombre As String
    Public ReadOnly Property EventoDAO As EventoDAO

    Public Sub New()
        Me.EventoDAO = New EventoDAO()
    End Sub


    Public Sub New(id As Integer)
        Me.EventoDAO = New EventoDAO()
        Me.Identificador = id
    End Sub

    Public Sub LeerTodos()
        Me.EventoDAO.LeerTodas()
    End Sub

    Public Sub Leer()
        Me.EventoDAO.Leer(Me)
    End Sub

    Public Function Insertar() As Integer
        Return Me.EventoDAO.Insertar(Me)
    End Function

    Public Function Actualizar() As Integer
        Return Me.EventoDAO.Actualizar(Me)
    End Function

    Public Function Borrar() As Integer
        Return Me.EventoDAO.Borrar(Me)
    End Function

End Class