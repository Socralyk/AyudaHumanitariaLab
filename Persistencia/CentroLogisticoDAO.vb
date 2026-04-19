Public Class CentroLogisticoDAO

    Public ReadOnly Property CentroLogistico As Collection

    Public Sub New()
        Me.CentroLogistico = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As CentroLogistico
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM centro_logistico ORDER BY IdCentro")
        For Each aux In col
            p = New CentroLogistico(aux(1).ToString)
            p.Nombre = aux(2).ToString
            p.Ciudad = aux(3).ToString
            p.Capacidad = aux(4).ToString
            Me.CentroLogistico.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As CentroLogistico)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM centro_logistico WHERE IdCentro='" & p.IDCentro & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.Ciudad = aux(3).ToString
            p.Capacidad = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As CentroLogistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO centro_logistico (Nombre, Ciudad, CapacidadTM) VALUES ('" & p.Nombre & "', '" & p.Ciudad & "', '" & p.Capacidad & "');")
    End Function

    Public Function Actualizar(ByVal p As CentroLogistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE centro_logistico SET Nombre='" & p.Nombre & "', Ciudad = '" & p.Ciudad & "' , CapacidadTM = '" & p.Capacidad & "' WHERE IdCentro='" & p.IDCentro & "';")
    End Function

    Public Function Borrar(ByVal p As CentroLogistico) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM centro_logistico WHERE IdCentro='" & p.IDCentro & "';")
    End Function

End Class

