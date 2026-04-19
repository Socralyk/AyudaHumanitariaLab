Public Class Entrenadores
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    Dim c As Entrenador

    Public Sub New()
        ' Esta llamada es necesaria para el diseñador de Windows Forms.
        InitializeComponent()
    End Sub
    Private Sub AñadirCentro_boton_Click(sender As Object, e As EventArgs) Handles AñadirEntrenadores.Click
        If añadir_boolean Then
            PanelEntrenadores.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New EntrenadoresAñadir())
            añadir_boolean = True
        End If
    End Sub

    Private Sub editar_centro_boton_Click(sender As Object, e As EventArgs) Handles EditarEntrenadores.Click
        If editar_boolean Then
            PanelEntrenadores.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New EntrenadoresEditar())
            editar_boolean = True
        End If
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        PanelEntrenadores.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        PanelEntrenadores.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub
    Public Sub refrescarlistbox()
        Dim pAux As Entrenador
        Me.c = New Entrenador
        Me.ListboxEntrenadores.Items.Clear()
        Try
            Me.c.LeerTodosEntrenadores()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.EntDAO.Entrenador
            Me.ListboxEntrenadores.Items.Add(pAux.ID_Entrenador)
        Next
    End Sub
    Private Sub Entrenadorpagload(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub

    Private Sub ListBoxEntrenadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListboxEntrenadores.SelectedIndexChanged
        If Not Me.ListboxEntrenadores.SelectedItem Is Nothing Then
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Entrenador(Me.ListboxEntrenadores.SelectedItem.ToString())

            Try
                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerEntrenador()

                ' 3. Creamos la vista de edición
                Dim vistaEditar As New EntrenadoresEditar()

                ' 4. Llamamos a la función para pasarle los datos
                vistaEditar.entrenadorSeleccionado(seleccionado)

                ' 5. Mostramos la vista en el panel usando tu función auxiliar
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el entrenador: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PanelEntrenadores_Paint(sender As Object, e As PaintEventArgs) Handles PanelEntrenadores.Paint

    End Sub
End Class
