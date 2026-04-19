<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntrenadoresAñadir
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
        TextBoxEdad = New TextBox()
        TextBoxNacionalidad = New TextBox()
        TextBoxNumAgencia = New TextBox()
        TextboxIdEntrenador = New TextBox()
        BotonAñadir = New Button()
        TextBoxNombre = New TextBox()
        TextBoxApellidos = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(TextBoxEdad, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxNacionalidad, 1, 1)
        TableLayoutPanel1.Controls.Add(TextBoxNumAgencia, 0, 1)
        TableLayoutPanel1.Controls.Add(TextboxIdEntrenador, 0, 0)
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 2)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(TextBoxApellidos, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(714, 388)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' TextBoxEdad
        ' 
        TextBoxEdad.Anchor = AnchorStyles.None
        TextBoxEdad.Location = New Point(532, 247)
        TextBoxEdad.Name = "TextBoxEdad"
        TextBoxEdad.Size = New Size(125, 27)
        TextBoxEdad.TabIndex = 6
        ' 
        ' TextBoxNacionalidad
        ' 
        TextBoxNacionalidad.Anchor = AnchorStyles.None
        TextBoxNacionalidad.Location = New Point(294, 247)
        TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        TextBoxNacionalidad.Size = New Size(125, 27)
        TextBoxNacionalidad.TabIndex = 5
        ' 
        ' TextBoxNumAgencia
        ' 
        TextBoxNumAgencia.Anchor = AnchorStyles.None
        TextBoxNumAgencia.Location = New Point(56, 247)
        TextBoxNumAgencia.Name = "TextBoxNumAgencia"
        TextBoxNumAgencia.Size = New Size(125, 27)
        TextBoxNumAgencia.TabIndex = 4
        ' 
        ' TextboxIdEntrenador
        ' 
        TextboxIdEntrenador.Anchor = AnchorStyles.None
        TextboxIdEntrenador.Location = New Point(56, 73)
        TextboxIdEntrenador.Name = "TextboxIdEntrenador"
        TextboxIdEntrenador.Size = New Size(125, 27)
        TextboxIdEntrenador.TabIndex = 0
        ' 
        ' BotonAñadir
        ' 
        BotonAñadir.Anchor = AnchorStyles.None
        BotonAñadir.Location = New Point(548, 353)
        BotonAñadir.Name = "BotonAñadir"
        BotonAñadir.Size = New Size(94, 29)
        BotonAñadir.TabIndex = 3
        BotonAñadir.Text = "Añadir"
        BotonAñadir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.None
        TextBoxNombre.Location = New Point(294, 73)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' TextBoxApellidos
        ' 
        TextBoxApellidos.Anchor = AnchorStyles.None
        TextBoxApellidos.Location = New Point(532, 73)
        TextBoxApellidos.Name = "TextBoxApellidos"
        TextBoxApellidos.Size = New Size(125, 27)
        TextBoxApellidos.TabIndex = 2
        ' 
        ' EntrenadoresAñadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "EntrenadoresAñadir"
        Size = New Size(714, 388)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents TextBoxNumAgencia As TextBox
    Friend WithEvents TextboxIdEntrenador As TextBox
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellidos As TextBox

End Class
