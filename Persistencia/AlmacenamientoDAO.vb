Public Class AlmacenamientoDAO

    Public ReadOnly Property Almacenamiento As Collection

    Public Sub New()
        Me.Almacenamiento = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Almacenamiento
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM almacenamiento ORDER BY IdCentro, IdSuministro")
        For Each aux In col 
            p = New Almacenamiento(aux(1).ToString, aux(2).ToString)
            p.CantidadStock = aux(3).ToString
            Me.Almacenamiento.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Almacenamiento)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM almacenamiento WHERE IdCentro='" & p.IDCentro & "' AND IdSuministro= '" & p.IDSuministro & "';")
        For Each aux In col
            p.CantidadStock = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Almacenamiento) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO almacenamiento VALUES ('" & p.IDCentro & "', '" & p.IDSuministro & "', '" & p.CantidadStock & "');")
    End Function

    Public Function Actualizar(ByVal p As Almacenamiento) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE almacenamiento SET CantidadStock='" & p.CantidadStock & "' WHERE IdCentro='" & p.IDCentro & "' AND IdSuministro= '" & p.IDSuministro & "';")
    End Function

    Public Function Borrar(ByVal p As Almacenamiento) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM almacenamiento WHERE IdCentro='" & p.IDCentro & "' AND IdSuministro= '" & p.IDSuministro & "';")
    End Function

End Class

