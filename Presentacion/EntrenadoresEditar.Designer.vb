<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntrenadoresEditar
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
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        TextBoxNacionalidad = New TextBox()
        TextBoxApellidos = New TextBox()
        TextBoxNombre = New TextBox()
        BotonBorrar = New Button()
        BotonEditar = New Button()
        ComboboxNumAgencia = New ComboBox()
        TextBoxEdad = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.33333F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333359F))
        TableLayoutPanel1.Controls.Add(Label5, 1, 2)
        TableLayoutPanel1.Controls.Add(Label3, 0, 2)
        TableLayoutPanel1.Controls.Add(Label4, 2, 0)
        TableLayoutPanel1.Controls.Add(Label6, 1, 0)
        TableLayoutPanel1.Controls.Add(Label2, 0, 0)
        TableLayoutPanel1.Controls.Add(TextBoxNacionalidad, 1, 3)
        TableLayoutPanel1.Controls.Add(TextBoxApellidos, 0, 3)
        TableLayoutPanel1.Controls.Add(TextBoxNombre, 0, 1)
        TableLayoutPanel1.Controls.Add(BotonBorrar, 2, 5)
        TableLayoutPanel1.Controls.Add(BotonEditar, 2, 4)
        TableLayoutPanel1.Controls.Add(ComboboxNumAgencia, 2, 1)
        TableLayoutPanel1.Controls.Add(TextBoxEdad, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.454546F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.454546F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.454546F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20.454546F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090909F))
        TableLayoutPanel1.Size = New Size(879, 451)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom
        Label5.AutoSize = True
        Label5.Location = New Point(389, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 16
        Label5.Text = "Nacionalidad"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom
        Label3.AutoSize = True
        Label3.Location = New Point(110, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 15
        Label3.Text = "Apellidos"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom
        Label4.AutoSize = True
        Label4.Location = New Point(684, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 14
        Label4.Text = "NumAgencia"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom
        Label6.AutoSize = True
        Label6.Location = New Point(417, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 20)
        Label6.TabIndex = 13
        Label6.Text = "Edad"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Location = New Point(114, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 10
        Label2.Text = "Nombre"
        ' 
        ' TextBoxNacionalidad
        ' 
        TextBoxNacionalidad.Anchor = AnchorStyles.Top
        TextBoxNacionalidad.Location = New Point(376, 279)
        TextBoxNacionalidad.Name = "TextBoxNacionalidad"
        TextBoxNacionalidad.Size = New Size(125, 27)
        TextBoxNacionalidad.TabIndex = 8
        ' 
        ' TextBoxApellidos
        ' 
        TextBoxApellidos.Anchor = AnchorStyles.Top
        TextBoxApellidos.Location = New Point(83, 279)
        TextBoxApellidos.Name = "TextBoxApellidos"
        TextBoxApellidos.Size = New Size(125, 27)
        TextBoxApellidos.TabIndex = 7
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Anchor = AnchorStyles.Top
        TextBoxNombre.Location = New Point(83, 95)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(125, 27)
        TextBoxNombre.TabIndex = 3
        ' 
        ' BotonBorrar
        ' 
        BotonBorrar.Anchor = AnchorStyles.None
        BotonBorrar.Location = New Point(685, 415)
        BotonBorrar.Name = "BotonBorrar"
        BotonBorrar.Size = New Size(94, 29)
        BotonBorrar.TabIndex = 5
        BotonBorrar.Text = "Borrar"
        BotonBorrar.UseVisualStyleBackColor = True
        ' 
        ' BotonEditar
        ' 
        BotonEditar.Anchor = AnchorStyles.None
        BotonEditar.Location = New Point(685, 373)
        BotonEditar.Name = "BotonEditar"
        BotonEditar.Size = New Size(94, 29)
        BotonEditar.TabIndex = 6
        BotonEditar.Text = "Actualizar"
        BotonEditar.UseVisualStyleBackColor = True
        ' 
        ' ComboboxNumAgencia
        ' 
        ComboboxNumAgencia.Anchor = AnchorStyles.Top
        ComboboxNumAgencia.FormattingEnabled = True
        ComboboxNumAgencia.Location = New Point(665, 95)
        ComboboxNumAgencia.Name = "ComboboxNumAgencia"
        ComboboxNumAgencia.Size = New Size(133, 28)
        ComboboxNumAgencia.TabIndex = 2
        ' 
        ' TextBoxEdad
        ' 
        TextBoxEdad.Anchor = AnchorStyles.Top
        TextBoxEdad.Location = New Point(376, 95)
        TextBoxEdad.Name = "TextBoxEdad"
        TextBoxEdad.Size = New Size(125, 27)
        TextBoxEdad.TabIndex = 9
        ' 
        ' EntrenadoresEditar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "EntrenadoresEditar"
        Size = New Size(879, 451)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents BotonBorrar As Button
    Friend WithEvents BotonEditar As Button
    Friend WithEvents ComboboxNumAgencia As ComboBox
    Friend WithEvents TextBoxEdad As TextBox
    Friend WithEvents TextBoxNacionalidad As TextBox
    Friend WithEvents TextBoxApellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label

End Class
