Public Class CombatesEditar
    Private comb As Combate

    ' Método que recibe el objeto seleccionado desde el formulario principal
    Friend Sub CombateSeleccionado(ByVal seleccionado As Combate)
        comb = seleccionado


    End Sub


    Private Sub CombatesEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar Personajes Cuerpo a Cuerpo
            Dim cac As New CuerpoACuerpoDAO()
            cac.LeerTodas()
            ConfigurarCombo(CuerpoA, cac.ListaCuerpoACuerpo)
            ConfigurarCombo(CuerpoB, cac.ListaCuerpoACuerpo, True)

            ' Cargar Personajes A Distancia
            Dim dist As New ADistanciaDAO()
            dist.LeerTodas()
            ConfigurarCombo(DistanciaA, dist.ListaADistancia)
            ConfigurarCombo(DistanciaB, dist.ListaADistancia, True)

        Catch ex As Exception
            MessageBox.Show("Error al inicializar edición: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfigurarCombo(ByVal combo As ComboBox, ByVal lista As Object, Optional ByVal clonar As Boolean = False)
        If clonar Then combo.BindingContext = New BindingContext()
        combo.DataSource = lista
        combo.DisplayMember = "Nombre"
        combo.ValueMember = "Nombre"
        combo.SelectedIndex = -1
    End Sub


    Private Sub BotonActualizar_Click(sender As Object, e As EventArgs) Handles BotonActualizar.Click
        ' 1. Identificar personajes
        Dim per1 As String = If(CuerpoA.SelectedIndex <> -1, CuerpoA.SelectedValue.ToString(), DistanciaA.SelectedValue?.ToString())
        Dim per2 As String = If(CuerpoB.SelectedIndex <> -1, CuerpoB.SelectedValue.ToString(), DistanciaB.SelectedValue?.ToString())

        ' 2. Validar
        If String.IsNullOrEmpty(per1) Or String.IsNullOrEmpty(per2) Then
            MessageBox.Show("Faltan datos por rellenar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que quieres editar estas elecciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try

                Dim e1 As New Elegir(comb.Id_combate, 1, per1) ' Asumiendo jugador 1 y 2
                Dim e2 As New Elegir(comb.Id_combate, 2, per2)

                e1.ActualizarElegir()
                e2.ActualizarElegir()

                MessageBox.Show("Editado con éxito.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Operación cancelada.")
        End If

        FinalizarEdicion()
    End Sub

    ' --- LÓGICA DE BORRAR ---
    Private Sub BotonBorrar_Click(sender As Object, e As EventArgs) Handles BotonBorrar.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que quieres borrar este combate?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Try
                comb.BorrarCombate()
                MessageBox.Show("Borrado con éxito.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Operación cancelada.")
        End If

        FinalizarEdicion()
    End Sub


    Private Sub CuerpoA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuerpoA.SelectedIndexChanged
        If CuerpoA.Focused And CuerpoA.SelectedIndex <> -1 Then DistanciaA.SelectedIndex = -1
    End Sub

    Private Sub DistanciaA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DistanciaA.SelectedIndexChanged
        If DistanciaA.Focused And DistanciaA.SelectedIndex <> -1 Then CuerpoA.SelectedIndex = -1
    End Sub

    Private Sub CuerpoB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuerpoB.SelectedIndexChanged
        If CuerpoB.Focused And CuerpoB.SelectedIndex <> -1 Then DistanciaB.SelectedIndex = -1
    End Sub

    Private Sub DistanciaB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DistanciaB.SelectedIndexChanged
        If DistanciaB.Focused And DistanciaB.SelectedIndex <> -1 Then CuerpoB.SelectedIndex = -1
    End Sub

    Private Sub FinalizarEdicion()
        VaciarCombos()

        Dim formularioPadre As Combates = DirectCast(Me.Parent.Parent, Combates)
        formularioPadre.refrescarlistbox()
    End Sub

    Public Sub VaciarCombos()
        CuerpoA.SelectedIndex = -1
        DistanciaA.SelectedIndex = -1
        CuerpoB.SelectedIndex = -1
        DistanciaB.SelectedIndex = -1
    End Sub



    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuerpoB.SelectedIndexChanged

    End Sub


End Class
