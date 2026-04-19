<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jugadores
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        ListBoxJugadores = New ListBox()
        StatusStrip1 = New StatusStrip()
        AñadirJugadores = New ToolStripStatusLabel()
        EditarJugadores = New ToolStripStatusLabel()
        PanelJugadores = New Panel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBoxJugadores
        ' 
        ListBoxJugadores.Dock = DockStyle.Left
        ListBoxJugadores.FormattingEnabled = True
        ListBoxJugadores.Location = New Point(0, 0)
        ListBoxJugadores.Name = "ListBoxJugadores"
        ListBoxJugadores.Size = New Size(150, 486)
        ListBoxJugadores.TabIndex = 2
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {AñadirJugadores, EditarJugadores})
        StatusStrip1.Location = New Point(0, 486)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(947, 26)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' AñadirJugadores
        ' 
        AñadirJugadores.Name = "AñadirJugadores"
        AñadirJugadores.Size = New Size(53, 20)
        AñadirJugadores.Text = "Añadir"
        ' 
        ' EditarJugadores
        ' 
        EditarJugadores.Name = "EditarJugadores"
        EditarJugadores.Size = New Size(48, 20)
        EditarJugadores.Text = "Editar"
        ' 
        ' PanelJugadores
        ' 
        PanelJugadores.Dock = DockStyle.Fill
        PanelJugadores.Location = New Point(150, 0)
        PanelJugadores.Name = "PanelJugadores"
        PanelJugadores.Size = New Size(797, 486)
        PanelJugadores.TabIndex = 4
        ' 
        ' Jugadores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelJugadores)
        Controls.Add(ListBoxJugadores)
        Controls.Add(StatusStrip1)
        Name = "Jugadores"
        Size = New Size(947, 512)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxJugadores As ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AñadirJugadores As ToolStripStatusLabel
    Friend WithEvents EditarJugadores As ToolStripStatusLabel
    Friend WithEvents PanelJugadores As Panel

End Class
