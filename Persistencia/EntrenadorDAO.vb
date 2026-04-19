Public Class EntrenadorDAO
    Public ReadOnly Property Entrenador As Collection

    Public Sub New()
        Me.Entrenador = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Entrenador
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Entrenador ORDER BY ID_Entrenador")
        For Each aux In col
            p = New Entrenador(aux(1).ToString)
            p.Num_Agencia = aux(2).ToString
            p.Nombre = aux(3).ToString
            p.Apellidos = aux(4).ToString
            p.Nacionalidad = aux(5).ToString
            p.Edad = aux(6).ToString
            Me.Entrenador.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Entrenador)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Entrenador WHERE ID_Entrenador='" & p.ID_Entrenador & "';")
        For Each aux In col
            p.Num_Agencia = aux(2).ToString
            p.Nombre = aux(3).ToString
            p.Apellidos = aux(4).ToString
            p.Nacionalidad = aux(5).ToString
            p.Edad = aux(6).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Entrenador) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Entrenador VALUES ('" & p.ID_Entrenador & "', '" & p.Num_Agencia & "', '" & p.Nombre & "', '" & p.Apellidos & "', '" & p.Nacionalidad & "', '" & p.Edad & "');")
    End Function

    Public Function Actualizar(ByVal p As Entrenador) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Entrenador SET Num_Agencia='" & p.Num_Agencia & "', Nombre='" & p.Nombre & "', '" & p.Apellidos & "', '" & p.Nacionalidad & "', '" & p.Edad & "' WHERE ID_Entrenador='" & p.ID_Entrenador & "';")
    End Function

    Public Function Borrar(ByVal p As Entrenador) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Entrenador WHERE ID_Entrenador='" & p.ID_Entrenador & "';")
    End Function
End Class
