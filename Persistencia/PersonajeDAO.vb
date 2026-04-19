Public Class PersonajeDAO
    Public ReadOnly Property Personajes As Collection

    Public Sub New()
        Me.Personajes = New Collection()
    End Sub


    Public Sub LeerTodos()
        Dim per As Personaje
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT Nombre, Rango FROM Personaje ORDER BY Nombre")

        For Each aux In col
            per = New Personaje(aux(1).ToString(), aux(2).ToString())
            Me.Personajes.Add(per)
        Next
    End Sub


    Public Sub Leer(ByRef per As Personaje)
        Dim col As Collection : Dim aux As Collection
        Dim sql As String = "SELECT * FROM Personaje WHERE Nombre='" & per.Nombre & "';"

        col = AgenteBD.ObtenerAgente.Leer(sql)

        For Each aux In col
            per.Nombre = aux(1).ToString()
            per.Rango = aux(2).ToString()
        Next
    End Sub


    Public Function Insertar(ByVal per As Personaje) As Integer
        Dim sql As String
        sql = "INSERT INTO Personaje (Nombre, Rango) VALUES ('" & per.Nombre & "', '" & per.Rango & "');"
        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function


    Public Function Actualizar(ByVal per As Personaje) As Integer
        Dim sql As String
        sql = "UPDATE Personaje SET Rango='" & per.Rango & "' WHERE Nombre='" & per.Nombre & "';"
        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function


    Public Function Borrar(ByVal per As Personaje) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personaje WHERE Nombre='" & per.Nombre & "';")
    End Function
End Class