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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 1)
        TableLayoutPanel1.Controls.Add(BotonBorrar, 2, 3)
        TableLayoutPanel1.Controls.Add(BotonEditar, 2, 2)
        TableLayoutPanel1.Controls.Add(TextBoxPais, 1, 1)
        TableLayoutPanel1.Controls.Add(ComboboxIdEntrenador, 2, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(565, 421)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(31, 171)
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
        TextBoxPais.Anchor = AnchorStyles.Top
        TextBoxPais.Location = New Point(219, 171)
        TextBoxPais.Name = "TextBoxPais"
        TextBoxPais.Size = New Size(125, 27)
        TextBoxPais.TabIndex = 4
        ' 
        ' ComboboxIdEntrenador
        ' 
        ComboboxIdEntrenador.Anchor = AnchorStyles.Top
        ComboboxIdEntrenador.FormattingEnabled = True
        ComboboxIdEntrenador.Location = New Point(404, 171)
        ComboboxIdEntrenador.Name = "ComboboxIdEntrenador"
        ComboboxIdEntrenador.Size = New Size(133, 28)
        ComboboxIdEntrenador.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(62, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 7
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(265, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 8
        Label2.Text = "Pais"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(422, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 9
        Label3.Text = "IDEntrenador"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
