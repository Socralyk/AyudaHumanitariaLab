Public Class CuerpoACuerpoDAO

    Public ReadOnly Property ListaCuerpoACuerpo As Collection

    Public Sub New()
        Me.ListaCuerpoACuerpo = New Collection()
    End Sub

    Public Sub LeerTodas()
        Dim p As CuerpoACuerpo
        Dim col, aux As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM CuerpoACuerpo ORDER BY Nombre")

        For Each aux In col
            p = New CuerpoACuerpo(aux(1).ToString())
            p.Resistencia = CInt(aux(2))
            Me.ListaCuerpoACuerpo.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As CuerpoACuerpo)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM CuerpoACuerpo WHERE Nombre='" & p.Nombre & "';")

        For Each aux In col
            p.Resistencia = CInt(aux(2))
        Next
    End Sub

    Public Function Insertar(ByVal p As CuerpoACuerpo) As Integer
        Dim sql As String
        sql = "INSERT INTO CuerpoACuerpo (Nombre, Resistencia) VALUES ('" & p.Nombre & "', " & p.Resistencia & ");"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Actualizar(ByVal p As CuerpoACuerpo) As Integer
        Dim sql As String
        sql = "UPDATE CuerpoACuerpo SET " & "Resistencia=" & p.Resistencia & " " & "WHERE Nombre='" & p.Nombre & "';"

        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function Borrar(ByVal p As CuerpoACuerpo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM CuerpoACuerpo WHERE Nombre='" & p.Nombre & "';")
    End Function

End Class