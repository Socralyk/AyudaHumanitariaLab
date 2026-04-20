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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxPais
        ' 
        TextBoxPais.Anchor = AnchorStyles.Top
        TextBoxPais.Location = New Point(281, 160)
        TextBoxPais.Name = "TextBoxPais"
        TextBoxPais.Size = New Size(125, 27)
        TextBoxPais.TabIndex = 2
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(143, 160)
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
        TextBoxNumContacto.Anchor = AnchorStyles.Top
        TextBoxNumContacto.Location = New Point(6, 160)
        TextBoxNumContacto.Name = "TextBoxNumContacto"
        TextBoxNumContacto.Size = New Size(125, 27)
        TextBoxNumContacto.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(TextBoxNumContacto, 0, 1)
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 2)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 1, 1)
        TableLayoutPanel1.Controls.Add(TextBoxPais, 2, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(413, 351)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(326, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 20)
        Label3.TabIndex = 6
        Label3.Text = "Pais"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(173, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 5
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(18, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 4
        Label1.Text = "NumContacto"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
