Public Class Envio

    Public Property IDEnvio As Integer
    Public Property IDCentroOrigen As Integer
    Public Property IDCentroDestino As Integer
    Public Property DNIVoluntario As String
    Public Property Fecha As Date
    Public Property Estado As String
    Public ReadOnly Property EnvDAO As EnvioDAO

    Public Sub New()
        Me.EnvDAO = New EnvioDAO
    End Sub

    Public Sub New(id1 As Integer)
        Me.EnvDAO = New EnvioDAO
        Me.IDEnvio = id1
    End Sub

    Public Sub LeerTodosAlmacenamientos()
        Me.EnvDAO.LeerTodas()
    End Sub

    Public Sub LeerAlmacenamiento()
        Me.EnvDAO.Leer(Me)
    End Sub

    Public Function InsertarAlmacenamiento() As Integer
        Return Me.EnvDAO.Insertar(Me)
    End Function

    Public Function ActualizarAlmacenamiento() As Integer
        Return Me.EnvDAO.Actualizar(Me)
    End Function

    Public Function BorrarAlmacenamiento() As Integer
        Return Me.EnvDAO.Borrar(Me)
    End Function

End Class
