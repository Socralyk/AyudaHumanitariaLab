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
        PanelCombates = New Panel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBoxCombates
        ' 
        ListBoxCombates.Dock = DockStyle.Left
        ListBoxCombates.FormattingEnabled = True
        ListBoxCombates.Location = New Point(0, 0)
        ListBoxCombates.Margin = New Padding(4, 4, 4, 4)
        ListBoxCombates.Name = "ListBoxCombates"
        ListBoxCombates.Size = New Size(186, 734)
        ListBoxCombates.TabIndex = 0
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {AñadirCombate, EditarCombate})
        StatusStrip1.Location = New Point(186, 702)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 18, 0)
        StatusStrip1.Size = New Size(1220, 32)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' AñadirCombate
        ' 
        AñadirCombate.Name = "AñadirCombate"
        AñadirCombate.Size = New Size(64, 25)
        AñadirCombate.Text = "Añadir"
        ' 
        ' EditarCombate
        ' 
        EditarCombate.Name = "EditarCombate"
        EditarCombate.Size = New Size(57, 25)
        EditarCombate.Text = "Editar"
        ' 
        ' PanelCombates
        ' 
        PanelCombates.Dock = DockStyle.Fill
        PanelCombates.Location = New Point(186, 0)
        PanelCombates.Margin = New Padding(4, 4, 4, 4)
        PanelCombates.Name = "PanelCombates"
        PanelCombates.Size = New Size(1220, 702)
        PanelCombates.TabIndex = 2
        ' 
        ' Combates
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelCombates)
        Controls.Add(StatusStrip1)
        Controls.Add(ListBoxCombates)
        Margin = New Padding(4, 4, 4, 4)
        Name = "Combates"
        Size = New Size(1406, 734)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxCombates As ListBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AñadirCombate As ToolStripStatusLabel
    Friend WithEvents EditarCombate As ToolStripStatusLabel
    Friend WithEvents PanelCombates As Panel

End Class
