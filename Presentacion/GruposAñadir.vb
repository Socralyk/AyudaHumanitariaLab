Public Class GruposAñadir
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        Dim pAux As Grupo
        If TextBoxIDEntrenador.Text = "" Or TextBoxNombre.Text = "" Or TextBoxPaisGrupos.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pAux = New Grupo()
        pAux.ID_Entrenador = TextBoxIDEntrenador.Text
        pAux.Pais = TextBoxPaisGrupos.Text
        pAux.Nombre = TextBoxNombre.Text
        Try
            pAux.InsertarGrupo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim formularioPadre As Agencias = DirectCast(Me.Parent.Parent, Agencias)
        formularioPadre.refrescarlistbox()
        vaciarTextBox()
    End Sub
    Private Sub vaciarTextBox()
        TextBoxIDEntrenador.Text = ""
        TextBoxPaisGrupos.Text = ""
        TextBoxNombre.Text = ""
    End Sub

End Class
