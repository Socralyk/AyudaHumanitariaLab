Public Class Grupos
    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    Dim c As Grupo

    Public Sub New()
        ' Esta llamada es necesaria para el diseñador de Windows Forms.
        InitializeComponent()
    End Sub
    Private Sub AñadirCentro_boton_Click(sender As Object, e As EventArgs) Handles AñadirGrupos.Click
        If añadir_boolean Then
            PanelGrupos.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New GruposAñadir)
            añadir_boolean = True
        End If
    End Sub

    Private Sub editar_centro_boton_Click(sender As Object, e As EventArgs) Handles EditarGrupos.Click
        If editar_boolean Then
            PanelGrupos.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New GruposEditar)
            editar_boolean = True
        End If
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        PanelGrupos.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        PanelGrupos.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub
    Public Sub refrescarlistbox()
        Dim pAux As Grupo
        Me.c = New Grupo
        Me.ListboxGrupos.Items.Clear()
        Try
            Me.c.LeerTodosGrupos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        For Each pAux In Me.c.GruDAO.Grupo
            Me.ListboxGrupos.Items.Add(pAux.ID_Grupo)
        Next
    End Sub
    Private Sub GrupoPagLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub

    Private Sub ListBoxGrupos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListboxGrupos.SelectedIndexChanged
        If Not Me.ListboxGrupos.SelectedItem Is Nothing Then
            ' 1. Creamos el objeto voluntario con el DNI seleccionado
            Dim seleccionado As New Grupo(Me.ListboxGrupos.SelectedItem.ToString())

            Try
                ' 2. Cargamos sus datos desde la BD
                seleccionado.LeerGrupo()

                ' 3. Creamos la vista de edición
                Dim vistaEditar As New GruposEditar

                ' 4. Llamamos a la función para pasarle los datos
                vistaEditar.GrupoSeleccionado(seleccionado)

                ' 5. Mostramos la vista en el panel usando tu función auxiliar
                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el grupo: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PanelAgencias_Paint(sender As Object, e As PaintEventArgs) Handles PanelGrupos.Paint

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class
