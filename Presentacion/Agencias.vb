Public Class Agencias
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    Dim c As Agencia

    Public Sub New()
        ' Esta llamada es necesaria para el diseñador de Windows Forms.
        InitializeComponent()
    End Sub
    Private Sub AñadirCentro_boton_Click(sender As Object, e As EventArgs) Handles AñadirAgencia.Click
        If añadir_boolean Then
            PanelAgencias.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New AgenciasAñadir())
            añadir_boolean = True
        End If
    End Sub

    Private Sub editar_centro_boton_Click(sender As Object, e As EventArgs) Handles EditarAgencia.Click
        If editar_boolean Then
            PanelAgencias.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New AgenciasEditar())
            editar_boolean = True
        End If
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        PanelAgencias.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        PanelAgencias.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub
    Public Sub refrescarlistbox()
        Dim pAux As Agencia
        Me.c = New Agencia
        Me.ListBoxAgencias.Items.Clear()
        Try
            Me.c.LeerTodasAgencias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.AgeDAO.Agencia
            Me.ListBoxAgencias.Items.Add(pAux.Num_Contacto)
        Next
    End Sub
    Private Sub AgenciasPagLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub

    Private Sub ListBoxCentros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAgencias.SelectedIndexChanged
        If Not Me.ListBoxAgencias.SelectedItem Is Nothing Then
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Agencia(Me.ListBoxAgencias.SelectedItem.ToString())

            Try
                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerAgencia()

                ' 3. Creamos la vista de edición
                Dim vistaEditar As New AgenciasEditar()

                ' 4. Llamamos a la función para pasarle los datos
                vistaEditar.agenciaSeleccionada(seleccionado)

                ' 5. Mostramos la vista en el panel usando tu función auxiliar
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el voluntario: " & ex.Message)
            End Try
        End If
    End Sub
End Class
