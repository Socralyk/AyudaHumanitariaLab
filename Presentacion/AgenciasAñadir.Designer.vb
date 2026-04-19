<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgenciasAñadir
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
        TextBoxPais = New TextBox()
        TextBoxNombre = New TextBox()
        BotonAñadir = New Button()
        TextBoxNumContacto = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxPais
        ' 
        TextBoxPais.Anchor = AnchorStyles.None
        TextBoxPais.Location = New Point(281, 144)
        TextBoxPais.Name = "TextBoxPais"
        TextBoxPais.Size = New Size(125, 27)
        TextBoxPais.TabIndex = 2
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.None
        TextBoxNombre.Location = New Point(143, 144)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' BotonAñadir
        ' 
        BotonAñadir.Anchor = AnchorStyles.None
        BotonAñadir.Location = New Point(296, 318)
        BotonAñadir.Name = "BotonAñadir"
        BotonAñadir.Size = New Size(94, 29)
        BotonAñadir.TabIndex = 3
        BotonAñadir.Text = "Añadir"
        BotonAñadir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNumContacto
        ' 
        TextBoxNumContacto.Anchor = AnchorStyles.None
        TextBoxNumContacto.Location = New Point(6, 144)
        TextBoxNumContacto.Name = "TextBoxNumContacto"
        TextBoxNumContacto.Size = New Size(125, 27)
        TextBoxNumContacto.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(TextBoxNumContacto, 0, 0)
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(TextBoxPais, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(413, 351)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' AgenciasAñadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "AgenciasAñadir"
        Size = New Size(413, 351)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBoxPais As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents TextBoxNumContacto As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
