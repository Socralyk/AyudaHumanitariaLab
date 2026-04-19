Public Class Suministro

    Public Property IDSuministro As Integer
    Public Property Descripcion As String
    Public Property Categoria As String
    Public Property PesoUnitario As Double
    Public ReadOnly Property SumDAO As SuministroDAO

    Public Sub New()
        Me.SumDAO = New SuministroDAO
    End Sub

    Public Sub New(id As Integer)
        Me.SumDAO = New SuministroDAO
        Me.IDSuministro = id
    End Sub

    Public Sub LeerTodosSuministros()
        Me.SumDAO.LeerTodas()
    End Sub

    Public Sub LeerSuministro()
        Me.SumDAO.Leer(Me)
    End Sub

    Public Function InsertarSuministro() As Integer
        Return Me.SumDAO.Insertar(Me)
    End Function

    Public Function ActualizarSuministro() As Integer
        Return Me.SumDAO.Actualizar(Me)
    End Function

    Public Function BorrarSuministro() As Integer
        Return Me.SumDAO.Borrar(Me)
    End Function

End Class
