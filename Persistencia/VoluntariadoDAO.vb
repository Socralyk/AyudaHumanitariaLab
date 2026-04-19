Public Class VoluntariadoDAO

    Public ReadOnly Property Voluntariado As Collection

    Public Sub New()
        Me.Voluntariado = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Voluntariado
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Voluntario ORDER BY DNI")
        For Each aux In col
            p = New Voluntariado(aux(1).ToString)
            p.Nombre = aux(2).ToString
            p.Especialidad = aux(3).ToString
            p.IDCentro = aux(4).ToString
            Me.Voluntariado.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Voluntariado)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Voluntario WHERE DNI='" & p.DNI & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.Especialidad = aux(3).ToString
            p.IDCentro = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Voluntariado) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Voluntario VALUES ('" & p.DNI & "', '" & p.Nombre & "', '" & p.Especialidad & "', '" & p.IDCentro & "');")
    End Function

    Public Function Actualizar(ByVal p As Voluntariado) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE voluntario SET Nombre='" & p.Nombre & "', Especialidad = '" & p.Especialidad & "', IdCentro = '" & p.IDCentro & "' WHERE DNI='" & p.DNI & "';")
    End Function

    Public Function Borrar(ByVal p As Voluntariado) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM voluntario WHERE DNI='" & p.DNI & "';")
    End Function

End Class

