Public Class Combates

    Dim añadir_boolean As Boolean
    Dim editar_boolean As Boolean
    Dim c As Combate

    Public Sub New()
        ' Esta llamada es necesaria para el diseñador de Windows Forms.
        InitializeComponent()
    End Sub
    Private Sub AñadirCombate_boton_Click(sender As Object, e As EventArgs) Handles AñadirCombate.Click
        If añadir_boolean Then
            PanelCombates.Controls.Clear()
            añadir_boolean = False
        Else
            cambiarvista(New CombatesAñadir)
            añadir_boolean = True
        End If
    End Sub

    Private Sub editar_combate_boton_Click(sender As Object, e As EventArgs) Handles EditarCombate.Click
        If editar_boolean Then
            PanelCombates.Controls.Clear()
            editar_boolean = False
        Else
            cambiarvista(New CombatesEditar)
            editar_boolean = True
        End If
    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        PanelCombates.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        PanelCombates.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub
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
    Private Sub CombatePagLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescarlistbox()
        Me.añadir_boolean = False
        Me.editar_boolean = False
    End Sub

    Private Sub ListBoxCombate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCombates.SelectedIndexChanged
        If Not Me.ListBoxCombates.SelectedItem Is Nothing Then

            Dim seleccionado As New Combate(Me.ListBoxCombates.SelectedItem.ToString())

            Try

                seleccionado.LeerCombate()


                Dim vistaEditar As New CombatesEditar


                vistaEditar.CombateSeleccionado(seleccionado)


                cambiarvista(vistaEditar)
                editar_boolean = True
            Catch ex As Exception
                MessageBox.Show("Error al cargar el grupo: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PanelAgencias_Paint(sender As Object, e As PaintEventArgs) Handles PanelCombates.Paint

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub EditarCombate_Click(sender As Object, e As EventArgs) Handles EditarCombate.Click

    End Sub

    Private Sub PanelCombates_Paint(sender As Object, e As PaintEventArgs) Handles PanelCombates.Paint

    End Sub
End Class
