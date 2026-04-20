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
        Label5 = New Label()
        TextBoxNacionalidad = New TextBox()
        BotonAñadir = New Button()
        TextBoxNombre = New TextBox()
        Label2 = New Label()
        TextBoxNumAgencia = New TextBox()
        TextBoxApellidos = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        TextboxIdEntrenador = New TextBox()
        TextBoxEdad = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
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
        TableLayoutPanel1.Controls.Add(TextBoxNacionalidad, 1, 3)
        TableLayoutPanel1.Controls.Add(BotonAñadir, 2, 4)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBoxNumAgencia, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxApellidos, 0, 3)
        TableLayoutPanel1.Controls.Add(Label4, 2, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(TextboxIdEntrenador, 2, 3)
        TableLayoutPanel1.Controls.Add(TextBoxEdad, 1, 1)
        TableLayoutPanel1.Controls.Add(Label6, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 2, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 22.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(714, 388)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Location = New Point(307, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 11
        Label5.Text = "Nacionalidad"
        ' 
        ' TextBoxNacionalidad
        ' 
        TextBoxNacionalidad.Anchor = AnchorStyles.Top
        TextBoxNacionalidad.Location = New Point(293, 264)
        TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        TextBoxNacionalidad.Size = New Size(125, 27)
        TextBoxNacionalidad.TabIndex = 5
        ' 
        ' BotonAñadir
        ' 
        BotonAñadir.Anchor = AnchorStyles.None
        BotonAñadir.Location = New Point(547, 353)
        BotonAñadir.Name = "BotonAñadir"
        BotonAñadir.Size = New Size(94, 29)
        BotonAñadir.TabIndex = 3
        BotonAñadir.Text = "Añadir"
        BotonAñadir.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(56, 90)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(86, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 8
        Label2.Text = "Nombre"
        ' 
        ' TextBoxNumAgencia
        ' 
        TextBoxNumAgencia.Anchor = AnchorStyles.Top
        TextBoxNumAgencia.Location = New Point(532, 90)
        TextBoxNumAgencia.Name = "TextBoxNumAgencia"
        TextBoxNumAgencia.Size = New Size(125, 27)
        TextBoxNumAgencia.TabIndex = 4
        ' 
        ' TextBoxApellidos
        ' 
        TextBoxApellidos.Anchor = AnchorStyles.Top
        TextBoxApellidos.Location = New Point(56, 264)
        TextBoxApellidos.Name = "TextBoxApellidos"
        TextBoxApellidos.Size = New Size(125, 27)
        TextBoxApellidos.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.Location = New Point(547, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 10
        Label4.Text = "NumAgencia"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(82, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 9
        Label3.Text = "Apellidos"
        ' 
        ' TextboxIdEntrenador
        ' 
        TextboxIdEntrenador.Anchor = AnchorStyles.Top
        TextboxIdEntrenador.Location = New Point(532, 264)
        TextboxIdEntrenador.Name = "TextboxIdEntrenador"
        TextboxIdEntrenador.Size = New Size(125, 27)
        TextboxIdEntrenador.TabIndex = 0
        ' 
        ' TextBoxEdad
        ' 
        TextBoxEdad.Anchor = AnchorStyles.Top
        TextBoxEdad.Location = New Point(293, 90)
        TextBoxEdad.Name = "TextBoxEdad"
        TextBoxEdad.Size = New Size(125, 27)
        TextBoxEdad.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Location = New Point(334, 67)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 20)
        Label6.TabIndex = 12
        Label6.Text = "Edad"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Location = New Point(547, 241)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 20)
        Label1.TabIndex = 7
        Label1.Text = "IdEntrenador"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
