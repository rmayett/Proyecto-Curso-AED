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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tiros))
        Me.LBLtiros = New System.Windows.Forms.Label()
        Me.LBLpuntos = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BTNPDF = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TXTRuta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNexit = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLtiros
        '
        Me.LBLtiros.AutoSize = True
        Me.LBLtiros.Font = New System.Drawing.Font("Times New Roman", 24.0!)
        Me.LBLtiros.Location = New System.Drawing.Point(77, 5)
        Me.LBLtiros.Name = "LBLtiros"
        Me.LBLtiros.Size = New System.Drawing.Size(221, 36)
        Me.LBLtiros.TabIndex = 0
        Me.LBLtiros.Text = "Tus tiros fueron:"
        '
        'LBLpuntos
        '
        Me.LBLpuntos.AutoSize = True
        Me.LBLpuntos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLpuntos.Location = New System.Drawing.Point(169, 41)
        Me.LBLpuntos.Name = "LBLpuntos"
        Me.LBLpuntos.Size = New System.Drawing.Size(0, 19)
        Me.LBLpuntos.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'BTNPDF
        '
        Me.BTNPDF.Location = New System.Drawing.Point(13, 228)
        Me.BTNPDF.Name = "BTNPDF"
        Me.BTNPDF.Size = New System.Drawing.Size(83, 23)
        Me.BTNPDF.TabIndex = 2
        Me.BTNPDF.Text = "Generar PDF"
        Me.BTNPDF.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 199)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'TXTRuta
        '
        Me.TXTRuta.Location = New System.Drawing.Point(13, 173)
        Me.TXTRuta.Name = "TXTRuta"
        Me.TXTRuta.Size = New System.Drawing.Size(100, 20)
        Me.TXTRuta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ruta y nombre del archivo:"
        '
        'BTNexit
        '
        Me.BTNexit.Location = New System.Drawing.Point(316, 228)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(75, 23)
        Me.BTNexit.TabIndex = 6
        Me.BTNexit.Text = "Salir"
        Me.BTNexit.UseVisualStyleBackColor = True
        '
        'Tiros
        '
        Me.AcceptButton = Me.BTNPDF
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 265)
        Me.Controls.Add(Me.BTNexit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTRuta)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BTNPDF)
        Me.Controls.Add(Me.LBLpuntos)
        Me.Controls.Add(Me.LBLtiros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tiros"
        Me.Text = "Tiros"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLtiros As System.Windows.Forms.Label
    Friend WithEvents LBLpuntos As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BTNPDF As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BTNexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTRuta As System.Windows.Forms.TextBox
End Class
