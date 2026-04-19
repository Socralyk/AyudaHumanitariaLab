Public Class EventoDAO

    Public ReadOnly Property Eventos As Collection

    Public Sub New()
        Me.Eventos = New Collection()
    End Sub

    Public Sub LeerTodas()
        Dim e As Evento
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Evento ORDER BY Identificador")

        For Each aux In col
            e = New Evento(CInt(aux(1)))

            e.Fecha = CDate(aux(2)) 'convierte el string de la BD a tipo (Date)
            e.Nombre = aux(3).ToString()
            Me.Eventos.Add(e)
        Next
    End Sub

    Public Sub Leer(ByRef e As Evento)
        Dim col As Collection
        Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Evento WHERE Identificador=" & e.Identificador & ";")

        For Each aux In col
            e.Fecha = CDate(aux(2))
            e.Nombre = aux(3).ToString()
        Next
    End Sub

    Public Function Insertar(ByVal e As Evento) As Integer
        Dim sql As String

        sql = "INSERT INTO Evento (Fecha, Nombre) VALUES ('" & e.Fecha.ToString("yyyy-MM-dd") & "', '" & e.Nombre & "');"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Actualizar(ByVal e As Evento) As Integer
        Dim sql As String
        sql = "UPDATE Evento SET " & "Fecha='" & e.Fecha.ToString("yyyy-MM-dd") & "', " & "Nombre='" & e.Nombre & "' " & "WHERE Identificador=" & e.Identificador & ";"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal e As Evento) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Evento WHERE Identificador=" & e.Identificador & ";")
    End Function

End Class