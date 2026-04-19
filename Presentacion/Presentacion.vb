Public Class Presentacion
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Private Sub cambiarvista(vistanueva As Control)
        PanelMuestra.Controls.Clear()
        vistanueva.Dock = DockStyle.Fill
        PanelMuestra.Controls.Add(vistanueva)
        vistanueva.BringToFront()
    End Sub

    Private Sub EntrenadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrenadorToolStripMenuItem.Click

    End Sub

    Private Sub AgenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgenciaToolStripMenuItem.Click

    End Sub

    Private Sub MapasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MapasToolStripMenuItem1.Click
        cambiarvista(New Mapas())
    End Sub

    Private Sub CombatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CombatesToolStripMenuItem.Click
        cambiarvista(New Combates())
    End Sub

    Private Sub EventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventosToolStripMenuItem.Click
        cambiarvista(New Eventos())
    End Sub

    Private Sub AgenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgenciasToolStripMenuItem.Click
        cambiarvista(New Agencias())
    End Sub

    Private Sub EntrenadoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EntrenadoresToolStripMenuItem1.Click
        cambiarvista(New Entrenadores())
    End Sub

    Private Sub GruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem.Click
        cambiarvista(New Grupos())
    End Sub

    Private Sub JugadoresToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles JugadoresToolStripMenuItem2.Click
        cambiarvista(New Jugadores())
    End Sub

    Private Sub ADistanciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADistanciaToolStripMenuItem.Click
        cambiarvista(New PersonajesADistancia())
    End Sub

    Private Sub CuerpoACuerpoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CuerpoACuerpoToolStripMenuItem1.Click
        cambiarvista(New PersonajesCuerpoACuerpo())
    End Sub
End Class