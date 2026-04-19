Public Class DetallesEnvioDAO

    Public ReadOnly Property DetallesEnvio As Collection

    Public Sub New()
        Me.DetallesEnvio = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As DetallesEnvio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM detalle_envio ORDER BY IdEnvio, IdSuministro")
        For Each aux In col
            p = New DetallesEnvio(aux(1).ToString, aux(2).ToString)
            p.Cantidad = aux(3).ToString
            Me.DetallesEnvio.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As DetallesEnvio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM detalle_envio WHERE IdEnvio='" & p.IDEnvio & "' AND IdSuministro='" & p.IDSuministro & "';")
        For Each aux In col
            p.Cantidad = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As DetallesEnvio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO detalle_envio VALUES ('" & p.IDEnvio & "', '" & p.IDSuministro & "', '" & p.Cantidad & "');")
    End Function

    Public Function Actualizar(ByVal p As DetallesEnvio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE detalle_envio SET Cantidad='" & p.Cantidad & "' WHERE IdEnvio='" & p.IDEnvio & "' AND IdSuministro='" & p.IDSuministro & "';")
    End Function

    Public Function Borrar(ByVal p As DetallesEnvio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM detalle_envio WHERE IdEnvio='" & p.IDEnvio & "' AND IdSuministro='" & p.IDSuministro & "';")
    End Function

End Class

