<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgenciasEditar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ComboboxNumContacto = New ComboBox()
        TextBoxNombre = New TextBox()
        TextBoxPais = New TextBox()
        BotonBorrar = New Button()
        BotonEditar = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboboxNumContacto
        ' 
        ComboboxNumContacto.Anchor = AnchorStyles.Top
        ComboboxNumContacto.FormattingEnabled = True
        ComboboxNumContacto.Location = New Point(64, 153)
        ComboboxNumContacto.Name = "ComboboxNumContacto"
        ComboboxNumContacto.Size = New Size(133, 28)
        ComboboxNumContacto.TabIndex = 2
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(331, 153)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 3
        ' 
        ' TextBoxPais
        ' 
        TextBoxPais.Anchor = AnchorStyles.Top
        TextBoxPais.Location = New Point(594, 153)
        TextBoxPais.Name = "TextBoxPais"
        TextBoxPais.Size = New Size(125, 27)
        TextBoxPais.TabIndex = 4
        ' 
        ' BotonBorrar
        ' 
        BotonBorrar.Anchor = AnchorStyles.None
        BotonBorrar.Location = New Point(610, 341)
        BotonBorrar.Name = "BotonBorrar"
        BotonBorrar.Size = New Size(94, 29)
        BotonBorrar.TabIndex = 5
        BotonBorrar.Text = "Borrar"
        BotonBorrar.UseVisualStyleBackColor = True
        ' 
        ' BotonEditar
        ' 
        BotonEditar.Anchor = AnchorStyles.None
        BotonEditar.Location = New Point(610, 304)
        BotonEditar.Name = "BotonEditar"
        BotonEditar.Size = New Size(94, 29)
        BotonEditar.TabIndex = 6
        BotonEditar.Text = "Actualizar"
        BotonEditar.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(BotonBorrar, 2, 3)
        TableLayoutPanel1.Controls.Add(BotonEditar, 2, 2)
        TableLayoutPanel1.Controls.Add(ComboboxNumContacto, 0, 1)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 1, 1)
        TableLayoutPanel1.Controls.Add(TextBoxPais, 2, 1)
        TableLayoutPanel1.Controls.Add(Label2, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(789, 375)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(80, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 9
        Label3.Text = "NumContacto"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(640, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 8
        Label2.Text = "Pais"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(361, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 7
        Label1.Text = "Nombre"
        ' 
        ' AgenciasEditar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "AgenciasEditar"
        Size = New Size(789, 375)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ComboboxNumContacto As ComboBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPais As TextBox
    Friend WithEvents BotonBorrar As Button
    Friend WithEvents BotonEditar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label

End Class
