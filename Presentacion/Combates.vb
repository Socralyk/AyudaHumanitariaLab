Public Class Combates
    Dim c As Combate
    Public Sub refrescarlistbox()
        Dim pAux As Combate
        Me.c = New Combate
        Me.ListBoxCombates.Items.Clear()
        Try
            Me.c.LeerTodosCombates()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.CombateDAO.Combates
            Me.ListBoxCombates.Items.Add(pAux.Id_combate)
        Next
    End Sub

    Private Sub ListBoxCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCombates.SelectedIndexChanged
        If Not Me.ListBoxCombates.SelectedItem Is Nothing Then
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Combate(Me.ListBoxCombates.SelectedItem.ToString())

            Try
                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerCombate()

                ' 3. Creamos la vista de edición
                Dim vistaEditar As New CentroLogistico_pag_editar()

                ' 4. Llamamos a la función para pasarle los datos
                vistaEditar.centroseleccionado(seleccionado)

                ' 5. Mostramos la vista en el panel usando tu función auxiliar
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el voluntario: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Combates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
    End Sub
End Class
