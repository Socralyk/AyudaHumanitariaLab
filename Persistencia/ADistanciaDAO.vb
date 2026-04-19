Public Class ADistanciaDAO

    Public ReadOnly Property ListaADistancia As Collection

    Public Sub New()
        Me.ListaADistancia = New Collection()
    End Sub

    Public Sub LeerTodas()
        Dim p As ADistancia
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM ADistancia ORDER BY Nombre")

        For Each aux In col
            p = New ADistancia(aux(1).ToString())
            p.DPS = CInt(aux(2))
            Me.ListaADistancia.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As ADistancia)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM ADistancia WHERE Nombre='" & p.Nombre & "';")

        For Each aux In col
            p.DPS = CInt(aux(2))
        Next
    End Sub

    Public Function Insertar(ByVal p As ADistancia) As Integer
        Dim sql As String
        sql = "INSERT INTO ADistancia (Nombre, DPS) VALUES ('" & p.Nombre & "', " & p.DPS & ");"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Actualizar(ByVal p As ADistancia) As Integer
        Dim sql As String
        sql = "UPDATE ADistancia SET " & "DPS=" & p.DPS & " " & "WHERE Nombre='" & p.Nombre & "';"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal p As ADistancia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ADistancia WHERE Nombre='" & p.Nombre & "';")
    End Function

End Class