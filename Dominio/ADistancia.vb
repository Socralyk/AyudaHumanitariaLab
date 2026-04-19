Public Class ADistancia

    Public Property Nombre As String
    Public Property DPS As Integer
    Public ReadOnly Property ADistanciaDAO As ADistanciaDAO

    Public Sub New()
        Me.ADistanciaDAO = New ADistanciaDAO()
    End Sub

    Public Sub New(nombrePersonaje As String)
        Me.ADistanciaDAO = New ADistanciaDAO()
        Me.Nombre = nombrePersonaje
    End Sub

    Public Sub LeerTodos()
        Me.ADistanciaDAO.LeerTodas()
    End Sub

    Public Sub Leer()
        Me.ADistanciaDAO.Leer(Me)
    End Sub

    Public Function Insertar() As Integer
        Return Me.ADistanciaDAO.Insertar(Me)
    End Function

    Public Function Actualizar() As Integer
        Return Me.ADistanciaDAO.Actualizar(Me)
    End Function

    Public Function Borrar() As Integer
        Return Me.ADistanciaDAO.Borrar(Me)
    End Function

End Class
