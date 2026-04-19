<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GruposAñadir
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
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBoxPaisGrupos = New TextBox()
        BotonAñadir = New Button()
        TextBoxNombre = New TextBox()
        TextBoxIDEntrenador = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxIDEntrenador, 2, 0)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBoxPaisGrupos, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(421, 371)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' TextBoxPaisGrupos
        ' 
        TextBoxPaisGrupos.Anchor = AnchorStyles.None
        TextBoxPaisGrupos.Location = New Point(147, 153)
        TextBoxPaisGrupos.Name = "TextBoxPaisGrupos"
        TextBoxPaisGrupos.Size = New Size(125, 27)
        TextBoxPaisGrupos.TabIndex = 0
        ' 
        ' BotonAñadir
        ' 
        BotonAñadir.Anchor = AnchorStyles.None
        BotonAñadir.Location = New Point(303, 337)
        BotonAñadir.Name = "BotonAñadir"
        BotonAñadir.Size = New Size(94, 29)
        BotonAñadir.TabIndex = 3
        BotonAñadir.Text = "Añadir"
        BotonAñadir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.None
        TextBoxNombre.Location = New Point(7, 153)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' TextBoxIDEntrenador
        ' 
        TextBoxIDEntrenador.Anchor = AnchorStyles.None
        TextBoxIDEntrenador.Location = New Point(288, 153)
        TextBoxIDEntrenador.Name = "TextBoxIDEntrenador"
        TextBoxIDEntrenador.Size = New Size(125, 27)
        TextBoxIDEntrenador.TabIndex = 2
        ' 
        ' GruposAñadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "GruposAñadir"
        Size = New Size(421, 371)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents TextBoxIDEntrenador As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPaisGrupos As TextBox

End Class
