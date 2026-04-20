Public Class GruposAñadir
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        Dim pAux As Grupo
        If ComboBoxIDEntrenador.Text = "" Or TextBoxNombre.Text = "" Or TextBoxPaisGrupos.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pAux = New Grupo()
        pAux.ID_Entrenador = ComboBoxIDEntrenador.Text
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
        ComboBoxIDEntrenador.Text = ""
        TextBoxPaisGrupos.Text = ""
        TextBoxNombre.Text = ""
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
