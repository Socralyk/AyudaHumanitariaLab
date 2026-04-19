Public Class PelearDAO

    Public ReadOnly Property Peleas As Collection

    Public Sub New()
        Me.Peleas = New Collection()
    End Sub

    Public Sub LeerTodos()
        Dim pel As Pelear
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT ID_Grupo1, ID_Grupo2, ID_Combate FROM Pelear ORDER BY ID_Combate")

        For Each aux In col

            pel = New Pelear(aux(1).ToString(), aux(2).ToString(), CInt(aux(3)))
            Me.Peleas.Add(pel)
        Next
    End Sub

    Public Sub Leer(ByRef pel As Pelear)
        Dim col As Collection : Dim aux As Collection
        Dim sql As String = "SELECT * FROM Pelear WHERE ID_Grupo1='" & pel.ID_Grupo1 &
                            "' AND ID_Grupo2='" & pel.ID_Grupo2 &
                            "' AND ID_Combate=" & pel.ID_Combate & ";"

        col = AgenteBD.ObtenerAgente.Leer(sql)

        For Each aux In col

            pel.ID_Combate = CInt(aux(3))
            pel.ID_Grupo1 = aux(1).ToString()
            pel.ID_Grupo2 = aux(2).ToString()
        Next

    End Sub

    Public Function Insertar(ByVal pel As Pelear) As Integer
        Dim sql As String
        sql = "INSERT INTO Pelear (ID_Grupo1, ID_Grupo2, ID_Combate) VALUES ('" &
              pel.ID_Grupo1 & "', '" &
              pel.ID_Grupo2 & "', " &
              pel.ID_Combate & ");"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Actualizar(ByVal pel As Pelear) As Integer
        Dim sql As String
        sql = "UPDATE Pelear SET ID_Grupo1='" & pel.ID_Grupo1 & "', " &
              "ID_Grupo2='" & pel.ID_Grupo2 & "', " &
              "ID_Combate=" & pel.ID_Combate & " " &
              "WHERE ID_Grupo1='" & pel.ID_Grupo1 & "' AND ID_Grupo2='" & pel.ID_Grupo2 &
              "' AND ID_Combate=" & pel.ID_Combate & ";"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal pel As Pelear) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Pelear WHERE ID_Grupo1='" & pel.ID_Grupo1 &
                                              "' AND ID_Grupo2='" & pel.ID_Grupo2 &
                                              "' AND ID_Combate=" & pel.ID_Combate & ";")
    End Function


End Class
