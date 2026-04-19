<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JugadoresAñadir
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
        TextBoxIdJugador = New TextBox()
        BotonAñadir = New Button()
        TextBoxNombre = New TextBox()
        TextBoxApellidos = New TextBox()
        TextBoxUsername = New TextBox()
        TextBoxEdad = New TextBox()
        ComboBoxIdGrupo = New ComboBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(TextBoxIdJugador, 0, 0)
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 2)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(TextBoxUsername, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxEdad, 1, 1)
        TableLayoutPanel1.Controls.Add(TextBoxApellidos, 0, 1)
        TableLayoutPanel1.Controls.Add(ComboBoxIdGrupo, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(784, 393)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' TextBoxIdJugador
        ' 
        TextBoxIdJugador.Anchor = AnchorStyles.None
        TextBoxIdJugador.Location = New Point(68, 74)
        TextBoxIdJugador.Name = "TextBoxIdJugador"
        TextBoxIdJugador.Size = New Size(125, 27)
        TextBoxIdJugador.TabIndex = 0
        ' 
        ' BotonAñadir
        ' 
        BotonAñadir.Anchor = AnchorStyles.None
        BotonAñadir.Location = New Point(606, 358)
        BotonAñadir.Name = "BotonAñadir"
        BotonAñadir.Size = New Size(94, 29)
        BotonAñadir.TabIndex = 3
        BotonAñadir.Text = "Añadir"
        BotonAñadir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.None
        TextBoxNombre.Location = New Point(329, 74)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' TextBoxApellidos
        ' 
        TextBoxApellidos.Anchor = AnchorStyles.None
        TextBoxApellidos.Location = New Point(68, 250)
        TextBoxApellidos.Name = "TextBoxApellidos"
        TextBoxApellidos.Size = New Size(125, 27)
        TextBoxApellidos.TabIndex = 2
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Anchor = AnchorStyles.None
        TextBoxUsername.Location = New Point(590, 250)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(125, 27)
        TextBoxUsername.TabIndex = 5
        ' 
        ' TextBoxEdad
        ' 
        TextBoxEdad.Anchor = AnchorStyles.None
        TextBoxEdad.Location = New Point(329, 250)
        TextBoxEdad.Name = "TextBoxEdad"
        TextBoxEdad.Size = New Size(125, 27)
        TextBoxEdad.TabIndex = 6
        ' 
        ' ComboBoxIdGrupo
        ' 
        ComboBoxIdGrupo.Anchor = AnchorStyles.None
        ComboBoxIdGrupo.FormattingEnabled = True
        ComboBoxIdGrupo.Location = New Point(577, 70)
        ComboBoxIdGrupo.Name = "ComboBoxIdGrupo"
        ComboBoxIdGrupo.Size = New Size(151, 28)
        ComboBoxIdGrupo.TabIndex = 7
        ' 
        ' JugadoresAñadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "JugadoresAñadir"
        Size = New Size(784, 393)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxIdJugador As TextBox
    Friend WithEvents BotonAñadir As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellidos As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents ComboBoxIdGrupo As ComboBox

End Class
