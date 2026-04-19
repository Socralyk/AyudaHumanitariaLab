Public Class Jugadores
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    Dim c As Jugador

    Public Sub New()
        ' Esta llamada es necesaria para el diseñador de Windows Forms.
        InitializeComponent()
    End Sub
    Private Sub AñadirCentro_boton_Click(sender As Object, e As EventArgs) Handles AñadirJugadores.Click
        If añadir_boolean Then
            PanelJugadores.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New JugadoresAñadir())
            añadir_boolean = True
        End If
    End Sub

    Private Sub editar_centro_boton_Click(sender As Object, e As EventArgs) Handles EditarJugadores.Click
        If editar_boolean Then
            PanelJugadores.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New JugadoresEditar())
            editar_boolean = True
        End If
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        PanelJugadores.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        PanelJugadores.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub
    Public Sub refrescarlistbox()
        Dim pAux As Jugador
        Me.c = New Jugador
        Me.ListBoxJugadores.Items.Clear()
        Try
            Me.c.LeerTodosJugadores()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.JugDAO.Jugador
            Me.ListBoxJugadores.Items.Add(pAux.ID_Jugador)
        Next
    End Sub
    Private Sub Entrenadorpagload(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub

    Private Sub ListBoxJugadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxJugadores.SelectedIndexChanged
        If Not Me.ListBoxJugadores.SelectedItem Is Nothing Then
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Jugador(Me.ListBoxJugadores.SelectedItem.ToString())

            Try
                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerJugador()

                ' 3. Creamos la vista de edición
                Dim vistaEditar As New JugadoresEditar()

                ' 4. Llamamos a la función para pasarle los datos
                vistaEditar.jugadorSeleccionado(seleccionado)

                ' 5. Mostramos la vista en el panel usando tu función auxiliar
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el jugador: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub PanelJugadores_Paint(sender As Object, e As PaintEventArgs) Handles PanelJugadores.Paint

    End Sub
End Class
