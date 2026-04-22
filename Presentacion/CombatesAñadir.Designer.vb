<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CombatesAñadir
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
        CuerpoA = New ComboBox()
        CuerpoB = New ComboBox()
        DistanciaA = New ComboBox()
        DistanciaB = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        BotonAñadir = New Button()
        SuspendLayout()
        ' 
        ' A
        ' 
        A.AutoSize = True
        A.BackColor = Color.RosyBrown
        A.Location = New Point(131, 108)
        A.Name = "A"
        A.Size = New Size(236, 25)
        A.TabIndex = 0
        A.Text = "Elige personaje del equipo 1"
        ' 
        ' B
        ' 
        B.AutoSize = True
        B.BackColor = SystemColors.ActiveCaption
        B.Location = New Point(821, 108)
        B.Name = "B"
        B.Size = New Size(236, 25)
        B.TabIndex = 1
        B.Text = "Elige personaje del equipo 2"
        ' 
        ' CuerpoA
        ' 
        CuerpoA.FormattingEnabled = True
        CuerpoA.Location = New Point(34, 327)
        CuerpoA.Name = "CuerpoA"
        CuerpoA.Size = New Size(182, 33)
        CuerpoA.TabIndex = 2
        ' 
        ' CuerpoB
        ' 
        CuerpoB.FormattingEnabled = True
        CuerpoB.Location = New Point(707, 327)
        CuerpoB.Name = "CuerpoB"
        CuerpoB.Size = New Size(182, 33)
        CuerpoB.TabIndex = 3
        ' 
        ' DistanciaA
        ' 
        DistanciaA.FormattingEnabled = True
        DistanciaA.Location = New Point(340, 327)
        DistanciaA.Name = "DistanciaA"
        DistanciaA.Size = New Size(182, 33)
        DistanciaA.TabIndex = 4
        ' 
        ' DistanciaB
        ' 
        DistanciaB.FormattingEnabled = True
        DistanciaB.Location = New Point(1024, 327)
        DistanciaB.Name = "DistanciaB"
        DistanciaB.Size = New Size(182, 33)
        DistanciaB.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 278)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 25)
        Label1.TabIndex = 6
        Label1.Text = "Cuerpo a Cuerpo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(725, 278)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 25)
        Label2.TabIndex = 7
        Label2.Text = "Cuerpo a Cuerpo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(382, 278)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 25)
        Label3.TabIndex = 8
        Label3.Text = "A distancia"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1066, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 25)
        Label4.TabIndex = 9
        Label4.Text = "A distancia"
        ' 
        ' BotonAñadir
        ' 
        BotonAñadir.Anchor = AnchorStyles.None
        BotonAñadir.BackColor = SystemColors.ActiveBorder
        BotonAñadir.Location = New Point(1046, 717)
        BotonAñadir.Margin = New Padding(4)
        BotonAñadir.Name = "BotonAñadir"
        BotonAñadir.Size = New Size(118, 36)
        BotonAñadir.TabIndex = 10
        BotonAñadir.Text = "Añadir"
        BotonAñadir.UseVisualStyleBackColor = False
        ' 
        ' CombatesAñadir
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(BotonAñadir)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DistanciaB)
        Controls.Add(DistanciaA)
        Controls.Add(CuerpoB)
        Controls.Add(CuerpoA)
        Controls.Add(B)
        Controls.Add(A)
        Name = "CombatesAñadir"
        Size = New Size(1221, 783)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents A As Label
    Friend WithEvents B As Label
    Friend WithEvents CuerpoA As ComboBox
    Friend WithEvents CuerpoB As ComboBox
    Friend WithEvents DistanciaA As ComboBox
    Friend WithEvents DistanciaB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BotonAñadir As Button

End Class
