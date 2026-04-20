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
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        BotonAñadir = New Button()
        TextBoxNombre = New TextBox()
        TextBoxPaisGrupos = New TextBox()
        ComboBoxIDEntrenador = New ComboBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 2)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 1)
        TableLayoutPanel1.Controls.Add(TextBoxPaisGrupos, 1, 1)
        TableLayoutPanel1.Controls.Add(ComboBoxIDEntrenador, 2, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(421, 371)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(302, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 11
        Label3.Text = "IDEntrenador"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(193, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 20)
        Label1.TabIndex = 10
        Label1.Text = "Pais"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(38, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 9
        Label2.Text = "Nombre"
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
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(7, 169)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' TextBoxPaisGrupos
        ' 
        TextBoxPaisGrupos.Anchor = AnchorStyles.Top
        TextBoxPaisGrupos.Location = New Point(147, 169)
        TextBoxPaisGrupos.Name = "TextBoxPaisGrupos"
        TextBoxPaisGrupos.Size = New Size(125, 27)
        TextBoxPaisGrupos.TabIndex = 0
        ' 
        ' ComboBoxIDEntrenador
        ' 
        ComboBoxIDEntrenador.Anchor = AnchorStyles.Top
        ComboBoxIDEntrenador.FormattingEnabled = True
        ComboBoxIDEntrenador.Location = New Point(283, 169)
        ComboBoxIDEntrenador.Name = "ComboBoxIDEntrenador"
        ComboBoxIDEntrenador.Size = New Size(134, 28)
        ComboBoxIDEntrenador.TabIndex = 12
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
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPaisGrupos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxIDEntrenador As ComboBox

End Class
