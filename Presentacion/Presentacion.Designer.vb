<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        MenuStrip1 = New MenuStrip()
        AgenciaToolStripMenuItem = New ToolStripMenuItem()
        EventosToolStripMenuItem = New ToolStripMenuItem()
        CombatesToolStripMenuItem = New ToolStripMenuItem()
        MapasToolStripMenuItem1 = New ToolStripMenuItem()
        EntrenadorToolStripMenuItem = New ToolStripMenuItem()
        AgenciasToolStripMenuItem = New ToolStripMenuItem()
        EntrenadoresToolStripMenuItem1 = New ToolStripMenuItem()
        EntrandoresToolStripMenuItem = New ToolStripMenuItem()
        GruposToolStripMenuItem = New ToolStripMenuItem()
        JugadoresToolStripMenuItem2 = New ToolStripMenuItem()
        JugadoresToolStripMenuItem = New ToolStripMenuItem()
        PersonajesToolStripMenuItem1 = New ToolStripMenuItem()
        ADistanciaToolStripMenuItem = New ToolStripMenuItem()
        CuerpoACuerpoToolStripMenuItem1 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AgenciaToolStripMenuItem, EntrenadorToolStripMenuItem, EntrandoresToolStripMenuItem, JugadoresToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AgenciaToolStripMenuItem
        ' 
        AgenciaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EventosToolStripMenuItem, CombatesToolStripMenuItem, MapasToolStripMenuItem1})
        AgenciaToolStripMenuItem.Name = "AgenciaToolStripMenuItem"
        AgenciaToolStripMenuItem.Size = New Size(148, 24)
        AgenciaToolStripMenuItem.Text = "Gestión de torneos"
        ' 
        ' EventosToolStripMenuItem
        ' 
        EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        EventosToolStripMenuItem.Size = New Size(159, 26)
        EventosToolStripMenuItem.Text = "Eventos"
        ' 
        ' CombatesToolStripMenuItem
        ' 
        CombatesToolStripMenuItem.Name = "CombatesToolStripMenuItem"
        CombatesToolStripMenuItem.Size = New Size(159, 26)
        CombatesToolStripMenuItem.Text = "Combates"
        ' 
        ' MapasToolStripMenuItem1
        ' 
        MapasToolStripMenuItem1.Name = "MapasToolStripMenuItem1"
        MapasToolStripMenuItem1.Size = New Size(159, 26)
        MapasToolStripMenuItem1.Text = "Mapas"
        ' 
        ' EntrenadorToolStripMenuItem
        ' 
        EntrenadorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgenciasToolStripMenuItem, EntrenadoresToolStripMenuItem1})
        EntrenadorToolStripMenuItem.Name = "EntrenadorToolStripMenuItem"
        EntrenadorToolStripMenuItem.Size = New Size(148, 24)
        EntrenadorToolStripMenuItem.Text = "Recursos Humanos"
        ' 
        ' AgenciasToolStripMenuItem
        ' 
        AgenciasToolStripMenuItem.Name = "AgenciasToolStripMenuItem"
        AgenciasToolStripMenuItem.Size = New Size(179, 26)
        AgenciasToolStripMenuItem.Text = "Agencias"
        ' 
        ' EntrenadoresToolStripMenuItem1
        ' 
        EntrenadoresToolStripMenuItem1.Name = "EntrenadoresToolStripMenuItem1"
        EntrenadoresToolStripMenuItem1.Size = New Size(179, 26)
        EntrenadoresToolStripMenuItem1.Text = "Entrenadores"
        ' 
        ' EntrandoresToolStripMenuItem
        ' 
        EntrandoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GruposToolStripMenuItem, JugadoresToolStripMenuItem2})
        EntrandoresToolStripMenuItem.Name = "EntrandoresToolStripMenuItem"
        EntrandoresToolStripMenuItem.Size = New Size(108, 24)
        EntrandoresToolStripMenuItem.Text = "Competición"
        ' 
        ' GruposToolStripMenuItem
        ' 
        GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        GruposToolStripMenuItem.Size = New Size(159, 26)
        GruposToolStripMenuItem.Text = "Grupos"
        ' 
        ' JugadoresToolStripMenuItem2
        ' 
        JugadoresToolStripMenuItem2.Name = "JugadoresToolStripMenuItem2"
        JugadoresToolStripMenuItem2.Size = New Size(159, 26)
        JugadoresToolStripMenuItem2.Text = "Jugadores"
        ' 
        ' JugadoresToolStripMenuItem
        ' 
        JugadoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PersonajesToolStripMenuItem1})
        JugadoresToolStripMenuItem.Name = "JugadoresToolStripMenuItem"
        JugadoresToolStripMenuItem.Size = New Size(84, 24)
        JugadoresToolStripMenuItem.Text = "Catálogo"
        ' 
        ' PersonajesToolStripMenuItem1
        ' 
        PersonajesToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ADistanciaToolStripMenuItem, CuerpoACuerpoToolStripMenuItem1})
        PersonajesToolStripMenuItem1.Name = "PersonajesToolStripMenuItem1"
        PersonajesToolStripMenuItem1.Size = New Size(161, 26)
        PersonajesToolStripMenuItem1.Text = "Personajes"
        ' 
        ' ADistanciaToolStripMenuItem
        ' 
        ADistanciaToolStripMenuItem.Name = "ADistanciaToolStripMenuItem"
        ADistanciaToolStripMenuItem.Size = New Size(202, 26)
        ADistanciaToolStripMenuItem.Text = "A distancia"
        ' 
        ' CuerpoACuerpoToolStripMenuItem1
        ' 
        CuerpoACuerpoToolStripMenuItem1.Name = "CuerpoACuerpoToolStripMenuItem1"
        CuerpoACuerpoToolStripMenuItem1.Size = New Size(202, 26)
        CuerpoACuerpoToolStripMenuItem1.Text = "Cuerpo a cuerpo"
        ' 
        ' Presentacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Presentacion"
        Text = "Presentacion"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrenadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrandoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CombatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrenadoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JugadoresToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PersonajesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ADistanciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuerpoACuerpoToolStripMenuItem1 As ToolStripMenuItem
End Class
