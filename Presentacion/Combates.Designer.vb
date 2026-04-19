<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Combates
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
        ListBoxCombates = New ListBox()
        StatusStrip1 = New StatusStrip()
        AñadirCombate = New ToolStripStatusLabel()
        EditarCombate = New ToolStripStatusLabel()
        BorrarCombate = New ToolStripStatusLabel()
        PanelCombates = New Panel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBoxCombates
        ' 
        ListBoxCombates.Dock = DockStyle.Left
        ListBoxCombates.FormattingEnabled = True
        ListBoxCombates.Location = New Point(0, 0)
        ListBoxCombates.Name = "ListBoxCombates"
        ListBoxCombates.Size = New Size(150, 587)
        ListBoxCombates.TabIndex = 0
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {AñadirCombate, EditarCombate, BorrarCombate})
        StatusStrip1.Location = New Point(150, 561)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(975, 26)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' AñadirCombate
        ' 
        AñadirCombate.Name = "AñadirCombate"
        AñadirCombate.Size = New Size(53, 20)
        AñadirCombate.Text = "Añadir"
        ' 
        ' EditarCombate
        ' 
        EditarCombate.Name = "EditarCombate"
        EditarCombate.Size = New Size(48, 20)
        EditarCombate.Text = "Editar"
        ' 
        ' BorrarCombate
        ' 
        BorrarCombate.Name = "BorrarCombate"
        BorrarCombate.Size = New Size(50, 20)
        BorrarCombate.Text = "Borrar"
        ' 
        ' PanelCombates
        ' 
        PanelCombates.Dock = DockStyle.Fill
        PanelCombates.Location = New Point(150, 0)
        PanelCombates.Name = "PanelCombates"
        PanelCombates.Size = New Size(975, 561)
        PanelCombates.TabIndex = 2
        ' 
        ' Combates
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelCombates)
        Controls.Add(StatusStrip1)
        Controls.Add(ListBoxCombates)
        Name = "Combates"
        Size = New Size(1125, 587)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxCombates As ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AñadirCombate As ToolStripStatusLabel
    Friend WithEvents EditarCombate As ToolStripStatusLabel
    Friend WithEvents BorrarCombate As ToolStripStatusLabel
    Friend WithEvents PanelCombates As Panel

End Class
