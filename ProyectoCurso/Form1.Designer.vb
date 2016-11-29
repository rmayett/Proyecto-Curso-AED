<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTname = New System.Windows.Forms.TextBox()
        Me.BTNok = New System.Windows.Forms.Button()
        Me.BTNrest = New System.Windows.Forms.Button()
        Me.LBLbien = New System.Windows.Forms.Label()
        Me.TXT20 = New System.Windows.Forms.TextBox()
        Me.TXTmin30 = New System.Windows.Forms.TextBox()
        Me.TXTmin20 = New System.Windows.Forms.TextBox()
        Me.TXTmin60 = New System.Windows.Forms.TextBox()
        Me.TXT50 = New System.Windows.Forms.TextBox()
        Me.TXT10 = New System.Windows.Forms.TextBox()
        Me.LBLpuntos = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escribe tu nombre:"
        '
        'TXTname
        '
        Me.TXTname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTname.Location = New System.Drawing.Point(170, 9)
        Me.TXTname.Name = "TXTname"
        Me.TXTname.Size = New System.Drawing.Size(218, 29)
        Me.TXTname.TabIndex = 1
        '
        'BTNok
        '
        Me.BTNok.Enabled = False
        Me.BTNok.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNok.Location = New System.Drawing.Point(445, 13)
        Me.BTNok.Name = "BTNok"
        Me.BTNok.Size = New System.Drawing.Size(124, 34)
        Me.BTNok.TabIndex = 2
        Me.BTNok.Text = "Comenzar"
        Me.BTNok.UseVisualStyleBackColor = True
        '
        'BTNrest
        '
        Me.BTNrest.Enabled = False
        Me.BTNrest.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNrest.Location = New System.Drawing.Point(445, 53)
        Me.BTNrest.Name = "BTNrest"
        Me.BTNrest.Size = New System.Drawing.Size(124, 35)
        Me.BTNrest.TabIndex = 3
        Me.BTNrest.Text = "Reiniciar"
        Me.BTNrest.UseVisualStyleBackColor = True
        '
        'LBLbien
        '
        Me.LBLbien.AutoSize = True
        Me.LBLbien.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLbien.ForeColor = System.Drawing.Color.Red
        Me.LBLbien.Location = New System.Drawing.Point(16, 74)
        Me.LBLbien.Name = "LBLbien"
        Me.LBLbien.Size = New System.Drawing.Size(0, 21)
        Me.LBLbien.TabIndex = 4
        '
        'TXT20
        '
        Me.TXT20.BackColor = System.Drawing.Color.Gold
        Me.TXT20.Enabled = False
        Me.TXT20.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT20.Location = New System.Drawing.Point(260, 167)
        Me.TXT20.Name = "TXT20"
        Me.TXT20.Size = New System.Drawing.Size(100, 29)
        Me.TXT20.TabIndex = 5
        Me.TXT20.Text = "20"
        Me.TXT20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTmin30
        '
        Me.TXTmin30.BackColor = System.Drawing.Color.Gold
        Me.TXTmin30.Enabled = False
        Me.TXTmin30.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTmin30.Location = New System.Drawing.Point(445, 202)
        Me.TXTmin30.Name = "TXTmin30"
        Me.TXTmin30.Size = New System.Drawing.Size(100, 29)
        Me.TXTmin30.TabIndex = 6
        Me.TXTmin30.Text = "-30"
        Me.TXTmin30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTmin20
        '
        Me.TXTmin20.BackColor = System.Drawing.Color.Gold
        Me.TXTmin20.Enabled = False
        Me.TXTmin20.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTmin20.Location = New System.Drawing.Point(63, 202)
        Me.TXTmin20.Name = "TXTmin20"
        Me.TXTmin20.Size = New System.Drawing.Size(100, 29)
        Me.TXTmin20.TabIndex = 7
        Me.TXTmin20.Text = "-20"
        Me.TXTmin20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXTmin60
        '
        Me.TXTmin60.BackColor = System.Drawing.Color.Gold
        Me.TXTmin60.Enabled = False
        Me.TXTmin60.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTmin60.Location = New System.Drawing.Point(260, 290)
        Me.TXTmin60.Name = "TXTmin60"
        Me.TXTmin60.Size = New System.Drawing.Size(100, 29)
        Me.TXTmin60.TabIndex = 8
        Me.TXTmin60.Text = "-60"
        Me.TXTmin60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT50
        '
        Me.TXT50.BackColor = System.Drawing.Color.Gold
        Me.TXT50.Enabled = False
        Me.TXT50.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT50.Location = New System.Drawing.Point(63, 258)
        Me.TXT50.Name = "TXT50"
        Me.TXT50.Size = New System.Drawing.Size(100, 29)
        Me.TXT50.TabIndex = 9
        Me.TXT50.Text = "50"
        Me.TXT50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT10
        '
        Me.TXT10.BackColor = System.Drawing.Color.Gold
        Me.TXT10.Enabled = False
        Me.TXT10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT10.Location = New System.Drawing.Point(445, 258)
        Me.TXT10.Name = "TXT10"
        Me.TXT10.Size = New System.Drawing.Size(100, 29)
        Me.TXT10.TabIndex = 10
        Me.TXT10.Text = "10"
        Me.TXT10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBLpuntos
        '
        Me.LBLpuntos.AutoSize = True
        Me.LBLpuntos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLpuntos.Location = New System.Drawing.Point(218, 237)
        Me.LBLpuntos.Name = "LBLpuntos"
        Me.LBLpuntos.Size = New System.Drawing.Size(0, 21)
        Me.LBLpuntos.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(445, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Reglas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.BTNok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 343)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLpuntos)
        Me.Controls.Add(Me.TXT10)
        Me.Controls.Add(Me.TXT50)
        Me.Controls.Add(Me.TXTmin60)
        Me.Controls.Add(Me.TXTmin20)
        Me.Controls.Add(Me.TXTmin30)
        Me.Controls.Add(Me.TXT20)
        Me.Controls.Add(Me.LBLbien)
        Me.Controls.Add(Me.BTNrest)
        Me.Controls.Add(Me.BTNok)
        Me.Controls.Add(Me.TXTname)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "La Ruleta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTname As System.Windows.Forms.TextBox
    Friend WithEvents BTNok As System.Windows.Forms.Button
    Friend WithEvents BTNrest As System.Windows.Forms.Button
    Friend WithEvents LBLbien As System.Windows.Forms.Label
    Friend WithEvents TXT20 As System.Windows.Forms.TextBox
    Friend WithEvents TXTmin30 As System.Windows.Forms.TextBox
    Friend WithEvents TXTmin20 As System.Windows.Forms.TextBox
    Friend WithEvents TXTmin60 As System.Windows.Forms.TextBox
    Friend WithEvents TXT50 As System.Windows.Forms.TextBox
    Friend WithEvents TXT10 As System.Windows.Forms.TextBox
    Friend WithEvents LBLpuntos As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
