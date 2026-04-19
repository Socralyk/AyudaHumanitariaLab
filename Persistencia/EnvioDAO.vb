Public Class EnvioDAO

    Public ReadOnly Property Envio As Collection

    Public Sub New()
        Me.Envio = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Envio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM envio ORDER BY idEnvio")
        For Each aux In col
            p = New Envio(aux(1).ToString)
            p.IDCentroOrigen = aux(2).ToString
            p.IDCentroDestino = aux(3).ToString
            p.DNIVoluntario = aux(4).ToString
            p.Fecha = aux(5).ToString
            p.Estado = aux(6).ToString
            Me.Envio.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Envio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM envio WHERE idEnvio='" & p.IDEnvio & "';")
        For Each aux In col
            p.IDCentroOrigen = aux(2).ToString
            p.IDCentroDestino = aux(3).ToString
            p.DNIVoluntario = aux(4).ToString
            p.Fecha = aux(5).ToString
            p.Estado = aux(6).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Envio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO envio (idCentroOrigen, idCentroDestino, DniVoluntario, Fecha, Estado) VALUES ('" & p.IDCentroOrigen & "', '" & p.IDCentroDestino & "', '" & p.DNIVoluntario & "', '" & p.Fecha & "', '" & p.Estado & "');")
    End Function

    Public Function Actualizar(ByVal p As Envio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE envio SET idCentroOrigen = '" & p.IDCentroOrigen & "', idCentroDestino = '" & p.IDCentroDestino & "', DniVoluntario = '" & p.DNIVoluntario & "', Fecha='" & p.Fecha & "', Estado = '" & p.Estado & "' WHERE idEnvio='" & p.IDEnvio & "';")
    End Function

    Public Function Borrar(ByVal p As Envio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM envio WHERE idEnvio='" & p.IDEnvio & "';")
    End Function

End Class

