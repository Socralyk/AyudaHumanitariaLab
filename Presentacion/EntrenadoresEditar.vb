Public Class EntrenadoresEditar
    Private c As Entrenador
    Friend Sub entrenadorSeleccionado(seleccionado As Entrenador)
        c = seleccionado
        TextBoxNombre.Text = c.Nombre
        TextBoxApellidos.Text = c.Apellidos
        TextBoxEdad.Text = c.Edad
        TextBoxNacionalidad.Text = c.Nacionalidad
        ComboboxNumAgencia.Text = c.Num_Agencia
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        Dim respuesta As DialogResult
        If TextBoxNombre.Text = "" Or TextBoxApellidos.Text = "" Or TextBoxEdad.Text = "" Or TextBoxNacionalidad.Text = "" Or ComboboxNumAgencia.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim nombre As String = TextBoxNombre.Text
        Dim apellidos As String = TextBoxApellidos.Text
        Dim edad As String = TextBoxEdad.Text
        Dim nacionalidad As String = TextBoxNacionalidad.Text
        Dim numagencia As String = ComboboxNumAgencia.Text
        Dim pAux As Entrenador
        pAux = New Entrenador()
        pAux.Nombre = nombre
        pAux.Apellidos = apellidos
        pAux.Edad = edad
        pAux.Nacionalidad = nacionalidad
        pAux.Num_Agencia = numagencia

        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres borrar este voluntario?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.BorrarEntrenador()
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
        Dim formularioPadre As Entrenadores = DirectCast(Me.Parent.Parent, Entrenadores)
        formularioPadre.refrescarlistbox()
    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles BotonEditar.Click
        Dim respuesta As DialogResult
        If TextBoxNombre.Text = "" Or TextBoxApellidos.Text = "" Or TextBoxEdad.Text = "" Or TextBoxNacionalidad.Text = "" Or ComboboxNumAgencia.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim numagencia As String = ComboboxNumAgencia.Text
        Dim nombre As String = TextBoxNombre.Text
        Dim apellidos As String = TextBoxApellidos.Text
        Dim edad As String = TextBoxEdad.Text
        Dim nacionalidad As String = TextBoxNacionalidad.Text
        Dim pAux As Entrenador
        pAux = New Entrenador()
        pAux.Nombre = nombre
        pAux.Apellidos = apellidos
        pAux.Edad = edad
        pAux.Nacionalidad = nacionalidad
        pAux.Num_Agencia = numagencia

        ' Mostramos el mensaje con botones Yes y No, y un icono de interrogación
        respuesta = MessageBox.Show("¿Estás seguro de que quieres editar este voluntario?",
                                        "Confirmación",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
        ' Evaluamos la respuesta
        If respuesta = DialogResult.Yes Then
            Try
                ' Aquí va el código si el usuario pulsa SÍ
                pAux.ActualizarEntrenador()
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
        Dim formularioPadre As Entrenadores = DirectCast(Me.Parent.Parent, Entrenadores)
        formularioPadre.refrescarlistbox()
    End Sub
    Public Sub vaciarTextBox()
        TextBoxNombre.Text = ""
        TextBoxApellidos.Text = ""
        TextBoxEdad.Text = ""
        TextBoxNacionalidad.Text = ""
        ComboboxNumAgencia.Text = ""
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
