Public Class ZonaConflicto
    Public Property IDZona As Integer
    Public Property NombreZona As String
    Public Property Pais As String
    Public Property NivelUrgencia As Integer
    Public ReadOnly Property ZonDao As ZonaConflictoDAO

    Public Sub New()
        Me.ZonDao = New ZonaConflictoDAO
    End Sub

    Public Sub New(id As String)
        Me.ZonDao = New ZonaConflictoDAO
        Me.IDZona = id
    End Sub

    Public Sub LeerTodasZonas()
        Me.ZonDao.LeerTodas()
    End Sub

    Public Sub LeerZona()
        Me.ZonDao.Leer(Me)
    End Sub

    Public Function InsertarZona() As Integer
        Return Me.ZonDao.Insertar(Me)
    End Function

    Public Function ActualizarZona() As Integer
        Return Me.ZonDao.Actualizar(Me)
    End Function

    Public Function BorrarZona() As Integer
        Return Me.ZonDao.Borrar(Me)
    End Function

End Class
