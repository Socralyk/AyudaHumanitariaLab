Public Class JugadoresEditar

    Public c As Jugador
    Friend Sub jugadorSeleccionado(seleccionado As Jugador)
        c = seleccionado
        TextBoxNombre.Text = c.Nombre
        TextBoxApellidos.Text = c.Apellidos
        TextBoxEdad.Text = c.Edad
        TextBoxUsername.Text = c.Username
        ComboBoxIdGrupo.Text = c.ID_Grupo
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        Dim respuesta As DialogResult
        If TextBoxNombre.Text = "" Or TextBoxApellidos.Text = "" Or TextBoxEdad.Text = "" Or TextBoxUsername.Text = "" Or ComboBoxIdGrupo.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim nombre As String = TextBoxNombre.Text
        Dim apellidos As String = TextBoxApellidos.Text
        Dim edad As String = TextBoxEdad.Text
        Dim username As String = TextBoxUsername.Text
        Dim idgrupo As String = ComboBoxIdGrupo.Text
        Dim pAux As Jugador
        pAux = New Jugador()
        pAux.Nombre = nombre
        pAux.Apellidos = apellidos
        pAux.Edad = edad
        pAux.Username = username
        pAux.ID_Grupo = idgrupo

        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres borrar este voluntario?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.BorrarJugador()
                MessageBox.Show("borrado con éxito.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            ' Aquí va el código (o nada) si el usuario pulsa NO
            MessageBox.Show("Operación cancelada.")
        End If
        vaciarTextBox()
        Dim formularioPadre As Jugadores = DirectCast(Me.Parent.Parent, Jugadores)
        formularioPadre.refrescarlistbox()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles BotonEditar.Click
        Dim respuesta As DialogResult
        If TextBoxNombre.Text = "" Or TextBoxApellidos.Text = "" Or TextBoxEdad.Text = "" Or TextBoxUsername.Text = "" Or ComboBoxIdGrupo.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim nombre As String = TextBoxNombre.Text
        Dim apellidos As String = TextBoxApellidos.Text
        Dim edad As String = TextBoxEdad.Text
        Dim username As String = TextBoxUsername.Text
        Dim idgrupo As String = ComboBoxIdGrupo.Text
        Dim pAux As Jugador
        pAux = New Jugador()
        pAux.Nombre = nombre
        pAux.Apellidos = apellidos
        pAux.Edad = edad
        pAux.Username = username
        pAux.ID_Grupo = idgrupo

        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres editar este voluntario?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.ActualizarJugador()
                MessageBox.Show("editado con éxito.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            ' Aquí va el código (o nada) si el usuario pulsa NO
            MessageBox.Show("Operación cancelada.")
        End If
        vaciarTextBox()
        Dim formularioPadre As Jugadores = DirectCast(Me.Parent.Parent, Jugadores)
        formularioPadre.refrescarlistbox()
    End Sub
    Public Sub vaciarTextBox()
        TextBoxNombre.Text = ""
        TextBoxApellidos.Text = ""
        TextBoxEdad.Text = ""
        TextBoxUsername.Text = ""
        ComboBoxIdGrupo.Text = ""
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
