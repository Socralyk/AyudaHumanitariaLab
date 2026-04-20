Public Class EntrenadoresAñadir
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        Dim pAux As Entrenador
        If TextBoxNombre.Text = "" Or TextBoxApellidos.Text = "" Or TextBoxEdad.Text = "" Or TextBoxNacionalidad.Text = "" Or TextBoxNumAgencia.Text = "" Or TextboxIdEntrenador.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pAux = New Entrenador()
        pAux.ID_Entrenador = TextboxIdEntrenador.Text
        pAux.Nombre = TextBoxNombre.Text
        pAux.Apellidos = TextBoxApellidos.Text
        pAux.Edad = TextBoxEdad.Text
        pAux.Nacionalidad = TextBoxNacionalidad.Text
        pAux.Num_Agencia = TextBoxNumAgencia.Text
        Try
            pAux.InsertarEntrenador()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim formularioPadre As Agencias = DirectCast(Me.Parent.Parent, Agencias)
        formularioPadre.refrescarlistbox()
        vaciarTextBox()
    End Sub
    Public Sub vaciarTextBox()
        TextBoxNombre.Text = ""
        TextBoxApellidos.Text = ""
        TextBoxEdad.Text = ""
        TextBoxNacionalidad.Text = ""
        TextBoxNumAgencia.Text = ""
        TextboxIdEntrenador.Text = ""
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
