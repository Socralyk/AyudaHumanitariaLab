Public Class GruposEditar

    Private c As Grupo
    Friend Sub GrupoSeleccionado(seleccionado As Grupo)
        c = seleccionado
        TextBoxNombre.Text = c.Nombre
        TextBoxPais.Text = c.Pais
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        Dim respuesta As DialogResult
        If TextBoxNombre.Text = "" Or TextBoxPais.Text = "" Or ComboboxIdEntrenador.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim identrenador As String = ComboboxIdEntrenador.Text
        Dim nombre As String = TextBoxNombre.Text
        Dim pais As String = TextBoxPais.Text
        Dim pAux As Grupo
        pAux = New Grupo()
        pAux.ID_Entrenador = identrenador
        pAux.Nombre = nombre
        pAux.Pais = pais

        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres borrar este voluntario?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.BorrarGrupo()
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
        Dim formularioPadre As Agencias = DirectCast(Me.Parent.Parent, Agencias)
        formularioPadre.refrescarlistbox()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles BotonEditar.Click
        Dim respuesta As DialogResult
        If TextBoxNombre.Text = "" Or TextBoxPais.Text = "" Or ComboboxIdEntrenador.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim identrenador As String = ComboboxIdEntrenador.Text
        Dim nombre As String = TextBoxNombre.Text
        Dim pais As String = TextBoxPais.Text
        Dim pAux As Grupo
        pAux = New Grupo()
        pAux.ID_Entrenador = identrenador
        pAux.Nombre = nombre
        pAux.Pais = pais
        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres editar este voluntario?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.ActualizarGrupo()
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
        Dim formularioPadre As Agencias = DirectCast(Me.Parent.Parent, Agencias)
        formularioPadre.refrescarlistbox()
    End Sub
    Public Sub vaciarTextBox()
        TextBoxNombre.Text = ""
        TextBoxPais.Text = ""
        ComboboxIdEntrenador.Text = ""
    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
