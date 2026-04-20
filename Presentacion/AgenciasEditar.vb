Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class AgenciasEditar
    Private c As Agencia
    Friend Sub agenciaSeleccionada(seleccionado As Agencia)
        c = seleccionado
        TextboxNombre.Text = c.Nombre
        TextBoxPais.Text = c.Pais
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        Dim respuesta As DialogResult
        If TextBoxNombre.Text = "" Or TextBoxPais.Text = "" Or ComboboxNumContacto.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim numContacto As String = ComboboxNumContacto.Text
        Dim nombre As String = TextBoxNombre.Text
        Dim pais As String = TextBoxPais.Text
        Dim pAux As Agencia
        pAux = New Agencia()
        pAux.Num_Contacto = numContacto
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
                pAux.BorrarAgencia()
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
        If TextBoxNombre.Text = "" Or TextBoxPais.Text = "" Or ComboboxNumContacto.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim numContacto As String = ComboboxNumContacto.Text
        Dim nombre As String = TextBoxNombre.Text
        Dim pais As String = TextBoxPais.Text
        Dim pAux As Agencia
        pAux = New Agencia()
        pAux.Num_Contacto = numContacto
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
                pAux.ActualizarAgencia()
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
        ComboboxNumContacto.Text = ""
    End Sub

    Private Sub ComboboxNumContacto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboboxNumContacto.SelectedIndexChanged

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
