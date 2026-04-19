Public Class JugadorDAO
    Public ReadOnly Property Jugador As Collection

    Public Sub New()
        Me.Jugador = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Jugador
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugador ORDER BY ID_Jugador")
        For Each aux In col
            p = New Jugador(aux(1).ToString)
            p.Edad = aux(2).ToString
            p.Nombre = aux(3).ToString
            p.Apellidos = aux(4).ToString
            p.Username = aux(5).ToString
            p.ID_Grupo = aux(6).ToString
            Me.Jugador.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Jugador)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugador WHERE ID_Jugador='" & p.ID_Jugador & "';")
        For Each aux In col
            p.Edad = aux(2).ToString
            p.Nombre = aux(3).ToString
            p.Apellidos = aux(4).ToString
            p.Username = aux(5).ToString
            p.ID_Grupo = aux(6).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugador) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugador VALUES ('" & p.ID_Jugador & "', '" & p.Edad & "', '" & p.Nombre & "', '" & p.Apellidos & "', '" & p.Username & "', '" & p.ID_Grupo & "');")
    End Function

    Public Function Actualizar(ByVal p As Jugador) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugador SET Edad='" & p.Edad & "', Nombre='" & p.Nombre & "', '" & p.Apellidos & "', '" & p.Username & "', '" & p.ID_Grupo & "' WHERE ID_Jugador='" & p.ID_Jugador & "';")
    End Function

    Public Function Borrar(ByVal p As Jugador) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugador WHERE ID_Jugador='" & p.ID_Jugador & "';")
    End Function
End Class
