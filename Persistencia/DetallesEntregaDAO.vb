Public Class DetallesEntregaDAO

    Public ReadOnly Property DetallesEntrega As Collection

    Public Sub New()
        Me.DetallesEntrega = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As DetallesEntrega
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM detalle_entrega ORDER BY IdDetalleEntrega")
        For Each aux In col
            p = New DetallesEntrega(aux(1).ToString)
            p.IDEntrega = aux(2).ToString
            p.IDSuministro = aux(3).ToString
            Me.DetallesEntrega.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As DetallesEntrega)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM detalle_entrega WHERE IdDetalleEntrega='" & p.IdDetalleEntrega & "';")
        For Each aux In col
            p.Cantidad = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As DetallesEntrega) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO detalle_entrega VALUES ('" & p.IdDetalleEntrega & "', '" & p.IDEntrega & "', '" & p.IDSuministro & "');")
    End Function

    Public Function Actualizar(ByVal p As DetallesEntrega) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE detalle_entrega SET idEntrega='" & p.IDEntrega & "', idSuministro= '" & p.IDSuministro & "' WHERE IdDetalleEntrega='" & p.IdDetalleEntrega & "';")
    End Function

    Public Function Borrar(ByVal p As DetallesEntrega) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM detalle_entrega WHERE IdDetalleEntrega='" & p.IdDetalleEntrega & "';")
    End Function

End Class

