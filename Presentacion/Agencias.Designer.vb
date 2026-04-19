<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agencias
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
        StatusStrip1 = New StatusStrip()
        AñadirAgencia = New ToolStripStatusLabel()
        EditarAgencia = New ToolStripStatusLabel()
        ListBoxAgencias = New ListBox()
        PanelAgencias = New Panel()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {AñadirAgencia, EditarAgencia})
        StatusStrip1.Location = New Point(0, 669)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1005, 26)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' AñadirAgencia
        ' 
        AñadirAgencia.Name = "AñadirAgencia"
        AñadirAgencia.Size = New Size(53, 20)
        AñadirAgencia.Text = "Añadir"
        ' 
        ' EditarAgencia
        ' 
        EditarAgencia.Name = "EditarAgencia"
        EditarAgencia.Size = New Size(48, 20)
        EditarAgencia.Text = "Editar"
        ' 
        ' ListBoxAgencias
        ' 
        ListBoxAgencias.Dock = DockStyle.Left
        ListBoxAgencias.FormattingEnabled = True
        ListBoxAgencias.Location = New Point(0, 0)
        ListBoxAgencias.Name = "ListBoxAgencias"
        ListBoxAgencias.Size = New Size(150, 669)
        ListBoxAgencias.TabIndex = 1
        ' 
        ' PanelAgencias
        ' 
        PanelAgencias.Dock = DockStyle.Fill
        PanelAgencias.Location = New Point(150, 0)
        PanelAgencias.Name = "PanelAgencias"
        PanelAgencias.Size = New Size(855, 669)
        PanelAgencias.TabIndex = 2
        ' 
        ' Agencias
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelAgencias)
        Controls.Add(ListBoxAgencias)
        Controls.Add(StatusStrip1)
        Name = "Agencias"
        Size = New Size(1005, 695)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AñadirAgencia As ToolStripStatusLabel
    Friend WithEvents EditarAgencia As ToolStripStatusLabel
    Friend WithEvents ListBoxAgencias As ListBox
    Friend WithEvents PanelAgencias As Panel

End Class
