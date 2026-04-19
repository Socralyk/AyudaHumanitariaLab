Public Class SuministroDAO

    Public ReadOnly Property Suministro As Collection

    Public Sub New()
        Me.Suministro = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Suministro
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Suministro ORDER BY IdSuministro")
        For Each aux In col
            p = New Suministro(aux(1).ToString)
            p.Descripcion = aux(2).ToString
            p.Categoria = aux(3).ToString
            p.PesoUnitario = aux(4).ToString
            Me.Suministro.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Suministro)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM suministro WHERE IdSuministro='" & p.IDSuministro & "';")
        For Each aux In col
            p.Descripcion = aux(2).ToString
            p.Categoria = aux(3).ToString
            p.PesoUnitario = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Suministro) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO suministro (Descripcion, Categoria, PesoUnitario) VALUES ('" & p.Descripcion & "', '" & p.Categoria & "', '" & p.PesoUnitario & "');")
    End Function

    Public Function Actualizar(ByVal p As Suministro) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE suministro SET Descripcion='" & p.Descripcion & "', Categoria = '" & p.Categoria & "', PesoUnitario = '" & p.PesoUnitario & "' WHERE idSuministro='" & p.IDSuministro & "';")
    End Function

    Public Function Borrar(ByVal p As Suministro) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM suministro WHERE IdSuministro='" & p.IDSuministro & "';")
    End Function

End Class

