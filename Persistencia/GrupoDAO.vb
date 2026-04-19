Public Class GrupoDAO
    Public ReadOnly Property Grupo As Collection

    Public Sub New()
        Me.Grupo = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Grupo
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Grupo ORDER BY ID_Grupo")
        For Each aux In col
            p = New Grupo(aux(1).ToString)
            p.Nombre = aux(2).ToString
            p.Pais = aux(3).ToString
            p.ID_Entrenador = aux(4).ToString
            Me.Grupo.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Grupo)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Grupo WHERE ID_Grupo='" & p.ID_Grupo & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
            p.Pais = aux(3).ToString
            p.ID_Entrenador = aux(4).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Grupo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Grupo(Nombre, Pais, ID_Entrenador) VALUES ('" & p.Nombre & "', '" & p.Pais & "', '" & p.ID_Entrenador & "');")
    End Function

    Public Function Actualizar(ByVal p As Grupo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Grupo SET Nombre='" & p.Nombre & "', Pais='" & p.Pais & "', ID_Entrenador='" & p.ID_Entrenador & "' WHERE ID_Grupo='" & p.ID_Grupo & "';")
    End Function

    Public Function Borrar(ByVal p As Grupo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Grupo WHERE ID_Grupo='" & p.ID_Grupo & "';")
    End Function
End Class
