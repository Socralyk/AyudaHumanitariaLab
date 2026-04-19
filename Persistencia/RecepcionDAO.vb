Public Class RecepcionDAO

    Public ReadOnly Property Recepcion As Collection

    Public Sub New()
        Me.Recepcion = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Recepcion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM recepcion ORDER BY idRecepcion")
        For Each aux In col
            p = New Recepcion(aux(1).ToString)
            p.IDCentro = aux(2).ToString
            p.DNIVoluntario = aux(3).ToString
            p.Fecha = aux(4).ToString
            p.Origen = aux(5).ToString
            Me.Recepcion.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Recepcion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM recepcion WHERE idRecepcion='" & p.IDRecepcion & "';")
        For Each aux In col
            p.IDCentro = aux(2).ToString
            p.DNIVoluntario = aux(3).ToString
            p.Fecha = aux(4).ToString
            p.Origen = aux(5).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Recepcion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO recepcion (idCentro, DniVoluntario, Fecha, Origen) VALUES ('" & p.IDCentro & "', '" & p.DNIVoluntario & "', '" & p.Fecha & "', '" & p.Origen & "');")
    End Function

    Public Function Actualizar(ByVal p As Recepcion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE recepcion SET idCentro= '" & p.IDCentro & "', DniVoluntario= '" & p.DNIVoluntario & "', Fecha= '" & p.Fecha & "', Origen= '" & p.Origen & "' WHERE idRecepcion='" & p.IDRecepcion & "';")
    End Function

    Public Function Borrar(ByVal p As Recepcion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM recepcion WHERE idRecepcion='" & p.IDRecepcion & "';")
    End Function

End Class

