Public Class EntregaDAO

    Public ReadOnly Property Entrega As Collection

    Public Sub New()
        Me.Entrega = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Entrega
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM entrega ORDER BY idEntrega")
        For Each aux In col
            p = New Entrega(aux(1).ToString)
            p.IDCentroOrigen = aux(2).ToString
            p.IDZonaDestino = aux(3).ToString
            p.DNIVoluntario = aux(4).ToString
            p.Fecha = aux(5).ToString
            Me.Entrega.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Entrega)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM entrega WHERE idEntrega='" & p.IDEntrega & "';")
        For Each aux In col
            p.IDCentroOrigen = aux(2).ToString
            p.IDZonaDestino = aux(3).ToString
            p.DNIVoluntario = aux(4).ToString
            p.Fecha = aux(5).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Entrega) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO entrega (idCentroOrigen, idZonaDestino, DniVoluntario, Fecha) VALUES ('" & p.IDCentroOrigen & "', '" & p.IDZonaDestino & "', '" & p.DNIVoluntario & "', '" & p.Fecha & "');")
    End Function

    Public Function Actualizar(ByVal p As Entrega) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE entrega SET idCentroOrigen ='" & p.IDCentroOrigen & "', idZonaDestino ='" & p.IDZonaDestino & "', DniVoluntario ='" & p.DNIVoluntario & "', Fecha ='" & p.Fecha & "' WHERE idEntrega='" & p.IDEntrega & "';")
    End Function

    Public Function Borrar(ByVal p As Entrega) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM entrega WHERE idEntrega='" & p.IDEntrega & "';")
    End Function

End Class

