Public Class MapaDAO

    Public ReadOnly Property Mapas As Collection

    Public Sub New()
        Me.Mapas = New Collection()
    End Sub

    Public Sub LeerTodas()
        Dim m As Mapa
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Mapa ORDER BY Nombre")

        For Each aux In col
            m = New Mapa(aux(1).ToString())
            m.Tamano = aux(2).ToString()
            m.Descripcion = aux(3).ToString()
            Me.Mapas.Add(m)
        Next
    End Sub

    Public Sub Leer(ByRef m As Mapa)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Mapa WHERE Nombre='" & m.Nombre & "';")

        For Each aux In col
            m.Tamano = aux(2).ToString()
            m.Descripcion = aux(3).ToString()
        Next
    End Sub

    Public Function Insertar(ByVal m As Mapa) As Integer
        Dim sql As String
        sql = "INSERT INTO Mapa (Nombre, Tamaño, Descripción) VALUES ('" & m.Nombre & "', '" & m.Tamano & "', '" & m.Descripcion & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Actualizar(ByVal m As Mapa) As Integer
        Dim sql As String
        sql = "UPDATE Mapa SET " & "Tamaño='" & m.Tamano & "', " & "Descripción='" & m.Descripcion & "' " & "WHERE Nombre='" & m.Nombre & "';"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal m As Mapa) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Mapa WHERE Nombre='" & m.Nombre & "';")
    End Function

End Class