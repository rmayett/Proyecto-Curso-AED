Public Class reloj
    Dim op As Integer = 1
    Public punt As Integer = 100
    Private Sub reloj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Puntuación del Jugador: " & Form1.TXTname.Text
    End Sub

    Private Sub BTNgo_Click(sender As Object, e As EventArgs) Handles BTNgo.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        op += 1
        If op > 6 Then
            op = 1
        End If
        Select Case op
            Case 1
                Form1.TXTmin20.BackColor = Color.Gold
                Form1.TXT20.BackColor = Color.DarkBlue
            Case 2
                Form1.TXT20.BackColor = Color.Gold
                Form1.TXTmin30.BackColor = Color.DarkBlue
            Case 3
                Form1.TXTmin30.BackColor = Color.Gold
                Form1.TXT10.BackColor = Color.DarkBlue
            Case 4
                Form1.TXT10.BackColor = Color.Gold
                Form1.TXTmin60.BackColor = Color.DarkBlue
            Case 5
                Form1.TXTmin60.BackColor = Color.Gold
                Form1.TXT50.BackColor = Color.DarkBlue
            Case 6
                Form1.TXT50.BackColor = Color.Gold
                Form1.TXTmin20.BackColor = Color.DarkBlue
        End Select
    End Sub

    Private Sub BTNstop_Click(sender As Object, e As EventArgs) Handles BTNstop.Click
        Timer1.Enabled = False
        If op = 1 Then
            punt = punt + 20
            Form1.LBLpuntos.Text = "Ganaste: 20 Puntos"
        ElseIf op = 2 Then
            punt = punt - 30
            Form1.LBLpuntos.Text = "Perdiste: 30 Puntos"
        ElseIf op = 3 Then
            punt = punt + 10
            Form1.LBLpuntos.Text = "Ganaste: 10 Puntos"
        ElseIf op = 4 Then
            punt = punt - 60
            Form1.LBLpuntos.Text = "Perdiste: 60 Puntos"
        ElseIf op = 5 Then
            punt = punt + 50
            Form1.LBLpuntos.Text = "Ganaste: 50 Puntos"
        ElseIf op = 6 Then
            punt = punt - 20
            Form1.LBLpuntos.Text = "Perdiste: 20 Puntos"
        End If
        LBLpunt.Text = "Puntuacion: " & punt
        If punt < 1 Then
            BTNgo.Enabled = False
            BTNstop.Enabled = False
            Form1.LBLpuntos.Text = "Puntuacion: " & punt
            Me.Close()
            MsgBox("Perdiste :(", MsgBoxStyle.Critical)
        End If
        If punt > 199 Then
            BTNgo.Enabled = False
            BTNstop.Enabled = False
            Form1.LBLpuntos.Text = "Puntuacion: " & punt
            Me.Close()
            MsgBox("¡Felicidades, Ganaste!", MsgBoxStyle.Information)
        End If
    End Sub
End Class