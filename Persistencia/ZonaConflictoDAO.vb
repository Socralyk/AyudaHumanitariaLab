Public Class ZonaConflictoDAO

    Public ReadOnly Property ZonaConflicto As Collection

    Public Sub New()
        Me.ZonaConflicto = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As ZonaConflicto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM zona_conflicto ORDER BY IdZona")
        For Each aux In col
            p = New ZonaConflicto(aux(1).ToString)
            p.NombreZona = aux(2).ToString
            p.Pais = aux(3).ToString
            p.NivelUrgencia = aux(4).ToString
            Me.ZonaConflicto.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As ZonaConflicto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM zona_conflicto WHERE IdZona='" & p.IDZona & "';")
        For Each aux In col
            p.NombreZona = aux(2).ToString
            p.Pais = aux(3).ToString
            p.NivelUrgencia = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As ZonaConflicto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO zona_conflicto VALUES ('" & p.IDZona & "', '" & p.NombreZona & "', '" & p.Pais & "', '" & p.NivelUrgencia & "');")
    End Function

    Public Function Actualizar(ByVal p As ZonaConflicto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE zona_conflicto SET NombreZona='" & p.NombreZona & "', Pais = '" & p.Pais & "', NivelUrgencia = '" & p.NivelUrgencia & "' WHERE IdZona='" & p.IDZona & "';")
    End Function

    Public Function Borrar(ByVal p As ZonaConflicto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM zona_conflicto WHERE IdZona='" & p.IDZona & "';")
    End Function

End Class

