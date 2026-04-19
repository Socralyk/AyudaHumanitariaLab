Public Class Voluntariado

    Public Property DNI As String
    Public Property Nombre As String
    Public Property Especialidad As String
    Public Property IDCentro As Integer
    Public ReadOnly Property VolDAO As VoluntariadoDAO

    Public Sub New()
        Me.VolDAO = New VoluntariadoDAO
    End Sub

    Public Sub New(id1 As String)
        Me.VolDAO = New VoluntariadoDAO
        Me.DNI = id1
    End Sub

    Public Sub LeerTodosVoluntarios()
        Me.VolDAO.LeerTodas()
    End Sub

    Public Sub LeerVoluntario()
        Me.VolDAO.Leer(Me)
    End Sub

    Public Function InsertarVoluntario() As Integer
        Return Me.VolDAO.Insertar(Me)
    End Function

    Public Function ActualizarVoluntario() As Integer
        Return Me.VolDAO.Actualizar(Me)
    End Function

    Public Function BorrarVoluntario() As Integer
        Return Me.VolDAO.Borrar(Me)
    End Function

End Class
