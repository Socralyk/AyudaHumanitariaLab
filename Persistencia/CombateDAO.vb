Public Class CombateDAO

    Public ReadOnly Property Combates As Collection

    Public Sub New()
        Me.Combates = New Collection()
    End Sub

    Public Sub LeerTodos()
        Dim com As Combate
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT ID_Combate, ID_Evento, Nombre_Grupo1, Nombre_Grupo2, ID_Mapa FROM Combate ORDER BY ID_Combate")

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
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Combate WHERE ID_Combate=" & com.Id_combate & ";")

        For Each aux In col
            com.Id_evento = CInt(aux(2))
            com.nombre_grupo1 = aux(3).ToString()
            com.nombre_grupo2 = aux(4).ToString()
            com.id_mapa = aux(5).ToString()
        Next
    End Sub

    Public Function Insertar(ByVal com As Combate) As Integer
        Dim sql As String
        sql = "INSERT INTO Combate (ID_Evento, Nombre_grupo1, Nombre_Grupo2, ID_Mapa) VALUES (" &
              com.Id_evento & ", '" &
              com.nombre_grupo1 & "', '" &
              com.nombre_grupo2 & "', '" &
              com.id_mapa & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Actualizar(ByVal com As Combate) As Integer
        Dim sql As String
        sql = "UPDATE Combate SET " &
              "ID_Evento=" & com.Id_evento & ", " &
              "Nombre_Grupo1='" & com.nombre_grupo1 & "', " &
              "Nombre_Grupo2='" & com.nombre_grupo2 & "', " &
              "ID_Mapa='" & com.id_mapa & "' " &
              "WHERE ID_Combate=" & com.Id_combate & ";"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal com As Combate) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Combate WHERE ID_Combate=" & com.Id_combate & ";")
    End Function

End Class
