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
        TextBoxUsername = New TextBox()
        TextBoxEdad = New TextBox()
        TextBoxApellidos = New TextBox()
        ComboBoxIdGrupo = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Label6, 2, 2)
        TableLayoutPanel1.Controls.Add(Label5, 1, 2)
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 4)
        TableLayoutPanel1.Controls.Add(TextBoxApellidos, 0, 3)
        TableLayoutPanel1.Controls.Add(ComboBoxIdGrupo, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 1)
        TableLayoutPanel1.Controls.Add(TextBoxIdJugador, 2, 3)
        TableLayoutPanel1.Controls.Add(TextBoxEdad, 1, 1)
        TableLayoutPanel1.Controls.Add(TextBoxUsername, 1, 3)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(784, 393)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' TextBoxIdJugador
        ' 
        TextBoxIdJugador.Anchor = AnchorStyles.Top
        TextBoxIdJugador.Location = New Point(590, 267)
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
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(68, 91)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Anchor = AnchorStyles.Top
        TextBoxUsername.Location = New Point(329, 267)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(125, 27)
        TextBoxUsername.TabIndex = 5
        ' 
        ' TextBoxEdad
        ' 
        TextBoxEdad.Anchor = AnchorStyles.Top
        TextBoxEdad.Location = New Point(329, 91)
        TextBoxEdad.Name = "TextBoxEdad"
        TextBoxEdad.Size = New Size(125, 27)
        TextBoxEdad.TabIndex = 6
        ' 
        ' TextBoxApellidos
        ' 
        TextBoxApellidos.Anchor = AnchorStyles.Top
        TextBoxApellidos.Location = New Point(68, 267)
        TextBoxApellidos.Name = "TextBoxApellidos"
        TextBoxApellidos.Size = New Size(125, 27)
        TextBoxApellidos.TabIndex = 2
        ' 
        ' ComboBoxIdGrupo
        ' 
        ComboBoxIdGrupo.Anchor = AnchorStyles.Top
        ComboBoxIdGrupo.FormattingEnabled = True
        ComboBoxIdGrupo.Location = New Point(577, 91)
        ComboBoxIdGrupo.Name = "ComboBoxIdGrupo"
        ComboBoxIdGrupo.Size = New Size(151, 28)
        ComboBoxIdGrupo.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(98, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 11
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(370, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 12
        Label1.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(620, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 13
        Label3.Text = "IDGrupo"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Location = New Point(94, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 14
        Label4.Text = "Apellidos"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Location = New Point(354, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 20)
        Label5.TabIndex = 15
        Label5.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Location = New Point(614, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 20)
        Label6.TabIndex = 16
        Label6.Text = "IDJugador"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
