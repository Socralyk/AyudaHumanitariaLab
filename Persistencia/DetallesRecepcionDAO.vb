Public Class DetallesRecepcionDAO

    Public ReadOnly Property DetallesRecepcion As Collection

    Public Sub New()
        Me.DetallesRecepcion = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As DetallesRecepcion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM detalle_recepcion ORDER BY IdRecepcion, IdSuministro")
        For Each aux In col
            p = New DetallesRecepcion(aux(1).ToString, aux(2).ToString)
            p.Cantidad = aux(3).ToString
            Me.DetallesRecepcion.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As DetallesRecepcion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM detalle_recepcion WHERE IdRecepcion='" & p.IDRecepcion & "' AND IdSuministro='" & p.IDSuministro & "';")
        For Each aux In col
            p.Cantidad = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As DetallesRecepcion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO detalle_recepcion VALUES ('" & p.IDRecepcion & "', '" & p.IDSuministro & "', '" & p.Cantidad & "');")
    End Function

    Public Function Actualizar(ByVal p As DetallesRecepcion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE detalle_recepcion SET Cantidad='" & p.Cantidad & "' WHERE IdRecepcion='" & p.IDRecepcion & "' AND IdSuministro='" & p.IDSuministro & "';")
    End Function

    Public Function Borrar(ByVal p As DetallesRecepcion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM detalle_recepcion WHERE IdRecepcion='" & p.IDRecepcion & "' AND IdSuministro='" & p.IDSuministro & "';")
    End Function

End Class

