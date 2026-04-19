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
        SuspendLayout()
        ' 
        ' ListBoxCombates
        ' 
        ListBoxCombates.FormattingEnabled = True
        ListBoxCombates.Location = New Point(15, 12)
        ListBoxCombates.Name = "ListBoxCombates"
        ListBoxCombates.Size = New Size(150, 104)
        ListBoxCombates.TabIndex = 0
        ' 
        ' Combates
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(ListBoxCombates)
        Name = "Combates"
        Size = New Size(1162, 768)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBoxCombates As ListBox

End Class
