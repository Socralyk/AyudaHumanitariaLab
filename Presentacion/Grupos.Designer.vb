<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos
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
        ListboxGrupos = New ListBox()
        PanelGrupos = New Panel()
        AñadirGrupos = New ToolStripStatusLabel()
        EditarGrupos = New ToolStripStatusLabel()
        StatusStrip2 = New StatusStrip()
        StatusStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListboxGrupos
        ' 
        ListboxGrupos.Dock = DockStyle.Left
        ListboxGrupos.FormattingEnabled = True
        ListboxGrupos.Location = New Point(0, 0)
        ListboxGrupos.Name = "ListboxGrupos"
        ListboxGrupos.Size = New Size(150, 405)
        ListboxGrupos.TabIndex = 1
        ' 
        ' PanelGrupos
        ' 
        PanelGrupos.Dock = DockStyle.Fill
        PanelGrupos.Location = New Point(150, 0)
        PanelGrupos.Name = "PanelGrupos"
        PanelGrupos.Size = New Size(783, 405)
        PanelGrupos.TabIndex = 2
        ' 
        ' AñadirGrupos
        ' 
        AñadirGrupos.Name = "AñadirGrupos"
        AñadirGrupos.Size = New Size(53, 20)
        AñadirGrupos.Text = "Añadir"
        ' 
        ' EditarGrupos
        ' 
        EditarGrupos.Name = "EditarGrupos"
        EditarGrupos.Size = New Size(48, 20)
        EditarGrupos.Text = "Editar"
        ' 
        ' StatusStrip2
        ' 
        StatusStrip2.ImageScalingSize = New Size(20, 20)
        StatusStrip2.Items.AddRange(New ToolStripItem() {AñadirGrupos, EditarGrupos})
        StatusStrip2.Location = New Point(0, 405)
        StatusStrip2.Name = "StatusStrip2"
        StatusStrip2.Size = New Size(933, 26)
        StatusStrip2.TabIndex = 0
        StatusStrip2.Text = "StatusStrip2"
        ' 
        ' Grupos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelGrupos)
        Controls.Add(ListboxGrupos)
        Controls.Add(StatusStrip2)
        Name = "Grupos"
        Size = New Size(933, 431)
        StatusStrip2.ResumeLayout(False)
        StatusStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListboxGrupos As ListBox
    Friend WithEvents PanelGrupos As Panel
    Friend WithEvents AñadirGrupos As ToolStripStatusLabel
    Friend WithEvents EditarGrupos As ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As StatusStrip

End Class
