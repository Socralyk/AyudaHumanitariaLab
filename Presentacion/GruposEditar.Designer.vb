<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GruposEditar
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
        TextBoxNombre = New TextBox()
        BotonBorrar = New Button()
        BotonEditar = New Button()
        TextBoxPais = New TextBox()
        ComboboxIdEntrenador = New ComboBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 0)
        TableLayoutPanel1.Controls.Add(BotonBorrar, 2, 2)
        TableLayoutPanel1.Controls.Add(BotonEditar, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxPais, 1, 0)
        TableLayoutPanel1.Controls.Add(ComboboxIdEntrenador, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(565, 421)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.None
        TextBoxNombre.Location = New Point(31, 154)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 3
        ' 
        ' BotonBorrar
        ' 
        BotonBorrar.Anchor = AnchorStyles.None
        BotonBorrar.Location = New Point(423, 385)
        BotonBorrar.Name = "BotonBorrar"
        BotonBorrar.Size = New Size(94, 29)
        BotonBorrar.TabIndex = 5
        BotonBorrar.Text = "Borrar"
        BotonBorrar.UseVisualStyleBackColor = True
        ' 
        ' BotonEditar
        ' 
        BotonEditar.Anchor = AnchorStyles.None
        BotonEditar.Location = New Point(423, 342)
        BotonEditar.Name = "BotonEditar"
        BotonEditar.Size = New Size(94, 29)
        BotonEditar.TabIndex = 6
        BotonEditar.Text = "Actualizar"
        BotonEditar.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPais
        ' 
        TextBoxPais.Anchor = AnchorStyles.None
        TextBoxPais.Location = New Point(219, 154)
        TextBoxPais.Name = "TextBoxPais"
        TextBoxPais.Size = New Size(125, 27)
        TextBoxPais.TabIndex = 4
        ' 
        ' ComboboxIdEntrenador
        ' 
        ComboboxIdEntrenador.Anchor = AnchorStyles.None
        ComboboxIdEntrenador.FormattingEnabled = True
        ComboboxIdEntrenador.Location = New Point(404, 154)
        ComboboxIdEntrenador.Name = "ComboboxIdEntrenador"
        ComboboxIdEntrenador.Size = New Size(133, 28)
        ComboboxIdEntrenador.TabIndex = 2
        ' 
        ' GruposEditar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "GruposEditar"
        Size = New Size(565, 421)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents BotonBorrar As Button
    Friend WithEvents BotonEditar As Button
    Friend WithEvents TextBoxPais As TextBox
    Friend WithEvents ComboboxIdEntrenador As ComboBox

End Class
