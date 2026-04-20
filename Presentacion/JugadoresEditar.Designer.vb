<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JugadoresEditar
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
        TextBoxUsername = New TextBox()
        TextBoxApellidos = New TextBox()
        TextBoxNombre = New TextBox()
        BotonBorrar = New Button()
        BotonEditar = New Button()
        ComboBoxIdGrupo = New ComboBox()
        TextBoxEdad = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Label5, 1, 2)
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBoxUsername, 1, 3)
        TableLayoutPanel1.Controls.Add(TextBoxApellidos, 0, 3)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 1)
        TableLayoutPanel1.Controls.Add(BotonBorrar, 2, 5)
        TableLayoutPanel1.Controls.Add(BotonEditar, 2, 4)
        TableLayoutPanel1.Controls.Add(ComboBoxIdGrupo, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxEdad, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(762, 423)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Anchor = AnchorStyles.Top
        TextBoxUsername.Location = New Point(317, 255)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(125, 27)
        TextBoxUsername.TabIndex = 8
        ' 
        ' TextBoxApellidos
        ' 
        TextBoxApellidos.Anchor = AnchorStyles.Top
        TextBoxApellidos.Location = New Point(64, 255)
        TextBoxApellidos.Name = "TextBoxApellidos"
        TextBoxApellidos.Size = New Size(125, 27)
        TextBoxApellidos.TabIndex = 7
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(64, 87)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 3
        ' 
        ' BotonBorrar
        ' 
        BotonBorrar.Anchor = AnchorStyles.None
        BotonBorrar.Location = New Point(587, 386)
        BotonBorrar.Name = "BotonBorrar"
        BotonBorrar.Size = New Size(94, 29)
        BotonBorrar.TabIndex = 5
        BotonBorrar.Text = "Borrar"
        BotonBorrar.UseVisualStyleBackColor = True
        ' 
        ' BotonEditar
        ' 
        BotonEditar.Anchor = AnchorStyles.None
        BotonEditar.Location = New Point(587, 342)
        BotonEditar.Name = "BotonEditar"
        BotonEditar.Size = New Size(94, 29)
        BotonEditar.TabIndex = 6
        BotonEditar.Text = "Actualizar"
        BotonEditar.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxIdGrupo
        ' 
        ComboBoxIdGrupo.Anchor = AnchorStyles.Top
        ComboBoxIdGrupo.FormattingEnabled = True
        ComboBoxIdGrupo.Location = New Point(568, 87)
        ComboBoxIdGrupo.Name = "ComboBoxIdGrupo"
        ComboBoxIdGrupo.Size = New Size(133, 28)
        ComboBoxIdGrupo.TabIndex = 2
        ' 
        ' TextBoxEdad
        ' 
        TextBoxEdad.Anchor = AnchorStyles.Top
        TextBoxEdad.Location = New Point(317, 87)
        TextBoxEdad.Name = "TextBoxEdad"
        TextBoxEdad.Size = New Size(125, 27)
        TextBoxEdad.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(94, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 10
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(358, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 11
        Label1.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(602, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 20)
        Label3.TabIndex = 12
        Label3.Text = "IDGrupo"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Location = New Point(90, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 13
        Label4.Text = "Apellidos"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Location = New Point(342, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 20)
        Label5.TabIndex = 14
        Label5.Text = "Username"
        ' 
        ' JugadoresEditar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "JugadoresEditar"
        Size = New Size(762, 423)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxApellidos As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents BotonBorrar As Button
    Friend WithEvents BotonEditar As Button
    Friend WithEvents ComboBoxIdGrupo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
