Public Class CentroLogistico

    Public Property IDCentro As Integer
    Public Property Nombre As String
    Public Property Ciudad As String
    Public Property Capacidad As Double
    Public ReadOnly Property CenDAO As CentroLogisticoDAO

    Public Sub New()
        Me.CenDAO = New CentroLogisticoDAO
    End Sub

    Public Sub New(id As String)
        Me.CenDAO = New CentroLogisticoDAO
        Me.IDCentro = id
    End Sub

    Public Sub LeerTodosCentros()
        Me.CenDAO.LeerTodas()
    End Sub

    Public Sub LeerCentro()
        Me.CenDAO.Leer(Me)
    End Sub

    Public Function InsertarCentro() As Integer
        Return Me.CenDAO.Insertar(Me)
    End Function

    Public Function ActualizarCentro() As Integer
        Return Me.CenDAO.Actualizar(Me)
    End Function

    Public Function BorrarCentro() As Integer
        Return Me.CenDAO.Borrar(Me)
    End Function

End Class
