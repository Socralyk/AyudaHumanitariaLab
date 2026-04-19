Public Class AgenciaDAO
    Public ReadOnly Property Agencia As Collection

    Public Sub New()
        Me.Agencia = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Agencia
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Agencia ORDER BY Num_Contacto")
        For Each aux In col
            p = New Agencia(aux(1).ToString)
            p.Nombre = aux(2).ToString
            p.Pais = aux(3).ToString
            Me.Agencia.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Agencia)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Agencia WHERE Num_Contacto='" & p.Num_Contacto & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.Pais = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Agencia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Agencia VALUES ('" & p.Num_Contacto & "', '" & p.Nombre & "', '" & p.Pais & "');")
    End Function

    Public Function Actualizar(ByVal p As Agencia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Agencia SET Nombre='" & p.Nombre & "', Pais='" & p.Pais & "' WHERE Num_Contacto='" & p.Num_Contacto & "';")
    End Function

    Public Function Borrar(ByVal p As Agencia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Agencia WHERE Num_Contacto='" & p.Num_Contacto & "';")
    End Function
End Class
