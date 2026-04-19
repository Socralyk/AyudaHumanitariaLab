Public Class CuerpoACuerpo

    Public Property Nombre As String
    Public Property Resistencia As Integer
    Public ReadOnly Property CuerpoACuerpoDAO As CuerpoACuerpoDAO

    Public Sub New()
        Me.CuerpoACuerpoDAO = New CuerpoACuerpoDAO()
    End Sub

    Public Sub New(nombrePersonaje As String)
        Me.CuerpoACuerpoDAO = New CuerpoACuerpoDAO()
        Me.Nombre = nombrePersonaje
    End Sub

    Public Sub LeerTodos()
        Me.CuerpoACuerpoDAO.LeerTodas()
    End Sub

    Public Sub Leer()
        Me.CuerpoACuerpoDAO.Leer(Me)
    End Sub

    Public Function Insertar() As Integer
        Return Me.CuerpoACuerpoDAO.Insertar(Me)
    End Function

    Public Function Actualizar() As Integer
        Return Me.CuerpoACuerpoDAO.Actualizar(Me)
    End Function

    Public Function Borrar() As Integer
        Return Me.CuerpoACuerpoDAO.Borrar(Me)
    End Function

End Class