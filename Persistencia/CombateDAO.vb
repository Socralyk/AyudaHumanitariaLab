Public Class CombateDAO

    Public ReadOnly Property Combates As Collection

    Public Sub New()
        Me.Combates = New Collection()
    End Sub

    Public Sub LeerTodos()
        Dim com As Combate
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT Id_combate, id_evento, nombre_grupo1, nombre_grupo2, id_mapa FROM Combate ORDER BY Id_combate")

        For Each aux In col
            com = New Combate(CInt(aux(1)))
            com.Id_evento = CInt(aux(2))
            com.nombre_grupo1 = aux(3).ToString()
            com.nombre_grupo2 = aux(4).ToString()
            com.id_mapa = aux(5).ToString()
            Me.Combates.Add(com)
        Next
    End Sub

    Public Sub Leer(ByRef com As Combate)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Combate WHERE Id_combate=" & com.Id_combate & ";")

        For Each aux In col
            com.Id_evento = CInt(aux(2))
            com.nombre_grupo1 = aux(3).ToString()
            com.nombre_grupo2 = aux(4).ToString()
            com.id_mapa = aux(5).ToString()
        Next
    End Sub

    Public Function Insertar(ByVal com As Combate) As Integer
        Dim sql As String
        sql = "INSERT INTO Combate (id_evento, nombre_grupo1, nombre_grupo2, id_mapa) VALUES (" &
              com.Id_evento & ", '" &
              com.nombre_grupo1 & "', '" &
              com.nombre_grupo2 & "', '" &
              com.id_mapa & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Actualizar(ByVal com As Combate) As Integer
        Dim sql As String
        sql = "UPDATE Combate SET " &
              "id_evento=" & com.Id_evento & ", " &
              "nombre_grupo1='" & com.nombre_grupo1 & "', " &
              "nombre_grupo2='" & com.nombre_grupo2 & "', " &
              "id_mapa='" & com.id_mapa & "' " &
              "WHERE Id_combate=" & com.Id_combate & ";"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal com As Combate) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Combate WHERE Id_combate=" & com.Id_combate & ";")
    End Function

End Class
