<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrenadores
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
        ListboxEntrenadores = New ListBox()
        StatusStrip1 = New StatusStrip()
        AñadirEntrenadores = New ToolStripStatusLabel()
        EditarEntrenadores = New ToolStripStatusLabel()
        PanelEntrenadores = New Panel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListboxEntrenadores
        ' 
        ListboxEntrenadores.Dock = DockStyle.Left
        ListboxEntrenadores.FormattingEnabled = True
        ListboxEntrenadores.Location = New Point(0, 0)
        ListboxEntrenadores.Name = "ListboxEntrenadores"
        ListboxEntrenadores.Size = New Size(150, 406)
        ListboxEntrenadores.TabIndex = 2
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {AñadirEntrenadores, EditarEntrenadores})
        StatusStrip1.Location = New Point(0, 406)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(743, 26)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' AñadirEntrenadores
        ' 
        AñadirEntrenadores.Name = "AñadirEntrenadores"
        AñadirEntrenadores.Size = New Size(53, 20)
        AñadirEntrenadores.Text = "Añadir"
        ' 
        ' EditarEntrenadores
        ' 
        EditarEntrenadores.Name = "EditarEntrenadores"
        EditarEntrenadores.Size = New Size(48, 20)
        EditarEntrenadores.Text = "Editar"
        ' 
        ' PanelEntrenadores
        ' 
        PanelEntrenadores.Dock = DockStyle.Fill
        PanelEntrenadores.Location = New Point(150, 0)
        PanelEntrenadores.Name = "PanelEntrenadores"
        PanelEntrenadores.Size = New Size(593, 406)
        PanelEntrenadores.TabIndex = 4
        ' 
        ' Entrenadores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelEntrenadores)
        Controls.Add(ListboxEntrenadores)
        Controls.Add(StatusStrip1)
        Name = "Entrenadores"
        Size = New Size(743, 432)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListboxEntrenadores As ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AñadirEntrenadores As ToolStripStatusLabel
    Friend WithEvents EditarEntrenadores As ToolStripStatusLabel
    Friend WithEvents PanelEntrenadores As Panel

End Class
