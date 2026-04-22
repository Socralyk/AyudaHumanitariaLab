Public Class CombatesAñadir
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles B.Click

    End Sub

    Private Sub CombatesAñadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Cargar Personajes Cuerpo a Cuerpo (Cargamos en los dos combos)


            Dim cac As New CuerpoACuerpoDAO()
            cac.LeerTodas()

            CuerpoA.DataSource = cac.ListaCuerpoACuerpo
            CuerpoA.DisplayMember = "Nombre"
            CuerpoA.ValueMember = "Nombre"
            CuerpoA.SelectedIndex = -1 ' Empezar vacío

            CuerpoB.BindingContext = New BindingContext() ' Clon para independencia
            CuerpoB.DataSource = cac.ListaCuerpoACuerpo
            CuerpoB.DisplayMember = "Nombre"
            CuerpoB.ValueMember = "Nombre"
            CuerpoB.SelectedIndex = -1

            ' Cargar Personajes A Distancia
            Dim dist As New ADistanciaDAO()
            dist.LeerTodas()

            DistanciaA.DataSource = dist.ListaADistancia
            DistanciaA.DisplayMember = "Nombre"
            DistanciaA.ValueMember = "Nombre"
            DistanciaA.SelectedIndex = -1

            DistanciaB.BindingContext = New BindingContext()
            DistanciaB.DataSource = dist.ListaADistancia
            DistanciaB.DisplayMember = "Nombre"
            DistanciaB.ValueMember = "Nombre"
            DistanciaB.SelectedIndex = -1


        Catch ex As Exception
            MessageBox.Show("Error al inicializar: " & ex.Message)
        End Try

    End Sub

    ' Equipo 1: Si elijo cuerpoA, limpio distanciaA
    Private Sub cuerpoA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuerpoA.SelectedIndexChanged
        If CuerpoA.Focused And CuerpoA.SelectedIndex <> -1 Then
            DistanciaA.SelectedIndex = -1
        End If
    End Sub

    ' Equipo 1: Si elijo distanciaA, limpio cuerpoA
    Private Sub distanciaA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DistanciaA.SelectedIndexChanged
        If DistanciaA.Focused And DistanciaA.SelectedIndex <> -1 Then
            CuerpoA.SelectedIndex = -1
        End If
    End Sub

    ' Equipo 2: Si elijo cuerpoB, limpio distanciaB
    Private Sub cuerpoB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuerpoB.SelectedIndexChanged
        If CuerpoB.Focused And CuerpoB.SelectedIndex <> -1 Then
            DistanciaB.SelectedIndex = -1
        End If
    End Sub

    ' Equipo 2: Si elijo distanciaB, limpio cuerpoB
    Private Sub distanciaB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DistanciaB.SelectedIndexChanged
        If DistanciaB.Focused And DistanciaB.SelectedIndex <> -1 Then
            CuerpoB.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        Try


            ' A. Identificar personajes elegidos
            Dim per1 As String = If(CuerpoA.SelectedIndex <> -1, CuerpoA.SelectedValue.ToString(), DistanciaA.SelectedValue?.ToString())
            Dim per2 As String = If(CuerpoB.SelectedIndex <> -1, CuerpoB.SelectedValue.ToString(), DistanciaB.SelectedValue?.ToString())

            ' B. Validar selección
            If String.IsNullOrEmpty(per1) Or String.IsNullOrEmpty(per2) Then
                MessageBox.Show("Cada equipo debe seleccionar un personaje.")
                Exit Sub
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
