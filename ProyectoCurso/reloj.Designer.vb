<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reloj
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reloj))
        Me.LBLpunt = New System.Windows.Forms.Label()
        Me.BTNgo = New System.Windows.Forms.Button()
        Me.BTNstop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LBLpunt
        '
        Me.LBLpunt.AutoSize = True
        Me.LBLpunt.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLpunt.Location = New System.Drawing.Point(64, 34)
        Me.LBLpunt.Name = "LBLpunt"
        Me.LBLpunt.Size = New System.Drawing.Size(220, 36)
        Me.LBLpunt.TabIndex = 0
        Me.LBLpunt.Text = "Puntuación: 100"
        '
        'BTNgo
        '
        Me.BTNgo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNgo.Location = New System.Drawing.Point(33, 95)
        Me.BTNgo.Name = "BTNgo"
        Me.BTNgo.Size = New System.Drawing.Size(113, 38)
        Me.BTNgo.TabIndex = 1
        Me.BTNgo.Text = "Iniciar"
        Me.BTNgo.UseVisualStyleBackColor = True
        '
        'BTNstop
        '
        Me.BTNstop.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNstop.Location = New System.Drawing.Point(195, 95)
        Me.BTNstop.Name = "BTNstop"
        Me.BTNstop.Size = New System.Drawing.Size(116, 38)
        Me.BTNstop.TabIndex = 2
        Me.BTNstop.Text = "Detener"
        Me.BTNstop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'reloj
        '
        Me.AcceptButton = Me.BTNgo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 156)
        Me.Controls.Add(Me.BTNstop)
        Me.Controls.Add(Me.BTNgo)
        Me.Controls.Add(Me.LBLpunt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reloj"
        Me.Text = "reloj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLpunt As System.Windows.Forms.Label
    Friend WithEvents BTNgo As System.Windows.Forms.Button
    Friend WithEvents BTNstop As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
