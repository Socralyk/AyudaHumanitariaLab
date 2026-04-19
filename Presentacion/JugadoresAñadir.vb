Public Class JugadoresAñadir
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        Dim pAux As Jugador
        If TextBoxNombre.Text = "" Or TextBoxApellidos.Text = "" Or TextBoxEdad.Text = "" Or TextBoxUsername.Text = "" Or TextBoxIdJugador.Text = "" Or ComboBoxIdGrupo.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pAux = New Jugador()
        pAux.ID_Jugador = TextBoxIdJugador.Text
        pAux.Nombre = TextBoxNombre.Text
        pAux.Apellidos = TextBoxApellidos.Text
        pAux.Edad = TextBoxEdad.Text
        pAux.Username = TextBoxUsername.Text
        pAux.ID_Grupo = ComboBoxIdGrupo.Text
        Try
            pAux.InsertarJugador()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim formularioPadre As Jugadores = DirectCast(Me.Parent.Parent, Jugadores)
        formularioPadre.refrescarlistbox()
        vaciarTextBox()
    End Sub
    Public Sub vaciarTextBox()
        TextBoxNombre.Text = ""
        TextBoxApellidos.Text = ""
        TextBoxEdad.Text = ""
        ComboBoxIdGrupo.Text = ""
        TextBoxUsername.Text = ""
        TextBoxIdJugador.Text = ""
    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
