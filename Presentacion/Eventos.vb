Public Class Eventos
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Public Sub refrescarlistbox()
        Dim pAux As Eventos
        Me.c = New Evento
        Me.ListBoxCentros.Items.Clear()
        Try
            Me.c.LeerTodosCentros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CentroDAO.Centro
            Me.ListBoxCentros.Items.Add(pAux.id)
        Next
    End Sub
End Class
