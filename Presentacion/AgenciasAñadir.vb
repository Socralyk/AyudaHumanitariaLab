Public Class AgenciasAñadir
    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        Dim pAux As Agencia
        If TextBoxNumContacto.Text = "" Or TextBoxNombre.Text = "" Or TextBoxPais.Text = "" Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pAux = New Agencia()
        pAux.Num_Contacto = TextBoxNumContacto.Text
        pAux.Pais = TextBoxPais.Text
        pAux.Nombre = TextBoxNombre.Text
        Try
            pAux.InsertarAgencia()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Dim formularioPadre As Agencias = DirectCast(Me.Parent.Parent, Agencias)
        formularioPadre.refrescarlistbox()
        vaciarTextBox()
    End Sub
    Private Sub vaciarTextBox()
        TextBoxNumContacto.Text = ""
        TextBoxPais.Text = ""
        TextBoxNombre.Text = ""
    End Sub

    Private Sub TextBoxNumContacto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumContacto.TextChanged

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        
    End Sub
End Class
