Public Class ElegirDAO
    Public ReadOnly Property Elegires As Collection

    Public Sub New()
        Me.Elegires = New Collection()
    End Sub

    Public Sub LeerTodos()
        Dim ele As Elegir
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT ID_Combate, ID_Jugador, Nombre_Personaje FROM Elegir ORDER BY ID_Combate")

        For Each aux In col

            ele = New Elegir(CInt(aux(1)), CInt(aux(2)), aux(3).ToString())
            Me.Elegires.Add(ele)
        Next
    End Sub

    Public Sub Leer(ByRef ele As Elegir)
        Dim col As Collection : Dim aux As Collection

        Dim sql As String = "SELECT * FROM Elegir WHERE ID_Combate=" & ele.ID_Combate &
                            " AND ID_Jugador=" & ele.ID_Jugador &
                            " AND Nombre_Personaje='" & ele.Nombre_Personaje & "';"

        col = AgenteBD.ObtenerAgente.Leer(sql)

        For Each aux In col
            ele.ID_Combate = CInt(aux(1))
            ele.ID_Jugador = CInt(aux(2))
            ele.Nombre_Personaje = aux(3).ToString()
        Next
    End Sub

    Public Function Insertar(ByVal ele As Elegir) As Integer
        Dim sql As String

        sql = "INSERT INTO Elegir (ID_Combate, ID_Jugador, Nombre_Personaje) VALUES (" &
              ele.ID_Combate & ", " &
              ele.ID_Jugador & ", '" &
              ele.Nombre_Personaje & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function


    Public Function Actualizar(ByVal ele As Elegir) As Integer
        Dim sql As String
        sql = "UPDATE Elegir SET ID_Combate=" & ele.ID_Combate & ", " &
              "ID_Jugador=" & ele.ID_Jugador & ", " &
              "Nombre_Personaje='" & ele.Nombre_Personaje & "' " &
              "WHERE ID_Combate=" & ele.ID_Combate & " AND ID_Jugador=" & ele.ID_Jugador &
              " AND Nombre_Personaje='" & ele.Nombre_Personaje & "';"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal ele As Elegir) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Elegir WHERE ID_Combate=" & ele.ID_Combate &
                                              " AND ID_Jugador=" & ele.ID_Jugador &
                                              " AND Nombre_Personaje='" & ele.Nombre_Personaje & "';")
    End Function
End Class