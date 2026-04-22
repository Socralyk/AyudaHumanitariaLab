<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CombatesEditar
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
        A = New Label()
        B = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CuerpoA = New ComboBox()
        DistanciaA = New ComboBox()
        CuerpoB = New ComboBox()
        DistanciaB = New ComboBox()
        BotonActualizar = New Button()
        BotonBorrar = New Button()
        SuspendLayout()
        ' 
        ' A
        ' 
        A.AutoSize = True
        A.BackColor = Color.RosyBrown
        A.Location = New Point(85, 131)
        A.Name = "A"
        A.Size = New Size(236, 25)
        A.TabIndex = 1
        A.Text = "Elige personaje del equipo 1"
        ' 
        ' B
        ' 
        B.AutoSize = True
        B.BackColor = SystemColors.ActiveCaption
        B.Location = New Point(685, 131)
        B.Name = "B"
        B.Size = New Size(236, 25)
        B.TabIndex = 2
        B.Text = "Elige personaje del equipo 2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 274)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 25)
        Label1.TabIndex = 7
        Label1.Text = "Cuerpo a Cuerpo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(611, 274)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 25)
        Label2.TabIndex = 8
        Label2.Text = "Cuerpo a Cuerpo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(356, 274)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 25)
        Label3.TabIndex = 9
        Label3.Text = "A distancia"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(876, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 25)
        Label4.TabIndex = 10
        Label4.Text = "A distancia"
        ' 
        ' CuerpoA
        ' 
        CuerpoA.FormattingEnabled = True
        CuerpoA.Location = New Point(12, 425)
        CuerpoA.Name = "CuerpoA"
        CuerpoA.Size = New Size(182, 33)
        CuerpoA.TabIndex = 11
        ' 
        ' DistanciaA
        ' 
        DistanciaA.FormattingEnabled = True
        DistanciaA.Location = New Point(313, 425)
        DistanciaA.Name = "DistanciaA"
        DistanciaA.Size = New Size(182, 33)
        DistanciaA.TabIndex = 12
        ' 
        ' CuerpoB
        ' 
        CuerpoB.FormattingEnabled = True
        CuerpoB.Location = New Point(563, 425)
        CuerpoB.Name = "CuerpoB"
        CuerpoB.Size = New Size(182, 33)
        CuerpoB.TabIndex = 13
        ' 
        ' DistanciaB
        ' 
        DistanciaB.FormattingEnabled = True
        DistanciaB.Location = New Point(820, 425)
        DistanciaB.Name = "DistanciaB"
        DistanciaB.Size = New Size(182, 33)
        DistanciaB.TabIndex = 14
        ' 
        ' BotonActualizar
        ' 
        BotonActualizar.Anchor = AnchorStyles.None
        BotonActualizar.BackColor = SystemColors.ActiveBorder
        BotonActualizar.Location = New Point(847, 720)
        BotonActualizar.Margin = New Padding(4)
        BotonActualizar.Name = "BotonActualizar"
        BotonActualizar.Size = New Size(118, 36)
        BotonActualizar.TabIndex = 15
        BotonActualizar.Text = "Actualizar"
        BotonActualizar.UseVisualStyleBackColor = False
        ' 
        ' BotonBorrar
        ' 
        BotonBorrar.Anchor = AnchorStyles.None
        BotonBorrar.BackColor = SystemColors.ActiveBorder
        BotonBorrar.Location = New Point(640, 720)
        BotonBorrar.Margin = New Padding(4)
        BotonBorrar.Name = "BotonBorrar"
        BotonBorrar.Size = New Size(118, 36)
        BotonBorrar.TabIndex = 17
        BotonBorrar.Text = "Borrar"
        BotonBorrar.UseVisualStyleBackColor = False
        ' 
        ' CombatesEditar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BotonBorrar)
        Controls.Add(BotonActualizar)
        Controls.Add(DistanciaB)
        Controls.Add(CuerpoB)
        Controls.Add(DistanciaA)
        Controls.Add(CuerpoA)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(B)
        Controls.Add(A)
        Name = "CombatesEditar"
        Size = New Size(1022, 818)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents A As Label
    Friend WithEvents B As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CuerpoA As ComboBox
    Friend WithEvents DistanciaA As ComboBox
    Friend WithEvents CuerpoB As ComboBox
    Friend WithEvents DistanciaB As ComboBox
    Friend WithEvents BotonActualizar As Button
    Friend WithEvents BotonBorrar As Button

End Class
