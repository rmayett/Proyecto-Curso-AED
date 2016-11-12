<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tiros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tiros))
        Me.LBLtiros = New System.Windows.Forms.Label()
        Me.LBLpuntos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLtiros
        '
        Me.LBLtiros.AutoSize = True
        Me.LBLtiros.Font = New System.Drawing.Font("Times New Roman", 24.0!)
        Me.LBLtiros.Location = New System.Drawing.Point(78, 20)
        Me.LBLtiros.Name = "LBLtiros"
        Me.LBLtiros.Size = New System.Drawing.Size(221, 36)
        Me.LBLtiros.TabIndex = 0
        Me.LBLtiros.Text = "Tus tiros fueron:"
        '
        'LBLpuntos
        '
        Me.LBLpuntos.AutoSize = True
        Me.LBLpuntos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLpuntos.Location = New System.Drawing.Point(170, 56)
        Me.LBLpuntos.Name = "LBLpuntos"
        Me.LBLpuntos.Size = New System.Drawing.Size(0, 19)
        Me.LBLpuntos.TabIndex = 1
        '
        'Tiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 265)
        Me.Controls.Add(Me.LBLpuntos)
        Me.Controls.Add(Me.LBLtiros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tiros"
        Me.Text = "Tiros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLtiros As System.Windows.Forms.Label
    Friend WithEvents LBLpuntos As System.Windows.Forms.Label
End Class
