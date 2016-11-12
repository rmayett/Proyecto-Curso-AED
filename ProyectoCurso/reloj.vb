Imports System.Collections.Stack
Public Class reloj
    Dim i As Integer = 0
    Dim pila As New Stack()
    Dim op As Integer = 1
    Public punt As Integer = 100 'puntuacion
    Private Sub reloj_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'carga el formulario
        Me.Text = "Puntuación del Jugador: " & Form1.TXTname.Text
    End Sub
    'actividad del boton go
    Private Sub BTNgo_Click(sender As Object, e As EventArgs) Handles BTNgo.Click
        Timer1.Enabled = True
    End Sub
    'evento del timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        op += 1 'incremento de la variable op que hace que cambie de color los colores de los puntajes 
        If op > 6 Then 'reinicia el valor de la variable para volver a empezar desde el primer valor 
            op = 1
        End If
        Select Case op 'va cambiando los colores de los puntajes
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
    'activividad del boton stop detiene el timer
    Private Sub BTNstop_Click(sender As Object, e As EventArgs) Handles BTNstop.Click
        Timer1.Enabled = False 'detiene el timer
        If op = 1 Then 'suma los puntos al puntaje total 
            pila.Push(20)
            Form1.LBLpuntos.Text = "Ganaste: 20 Puntos" 'muestra el puntaje ganado o perdido 
        ElseIf op = 2 Then
            pila.Push(-30)
            Form1.LBLpuntos.Text = "Perdiste: 30 Puntos"
        ElseIf op = 3 Then
            pila.Push(10)
            Form1.LBLpuntos.Text = "Ganaste: 10 Puntos"
        ElseIf op = 4 Then
            pila.Push(-60)
            Form1.LBLpuntos.Text = "Perdiste: 60 Puntos"
        ElseIf op = 5 Then
            pila.Push(50)
            Form1.LBLpuntos.Text = "Ganaste: 50 Puntos"
        ElseIf op = 6 Then
            pila.Push(-20)
            Form1.LBLpuntos.Text = "Perdiste: 20 Puntos"
        End If
        punt = punt + pila.Peek
        LBLpunt.Text = "Puntuacion: " & punt 'imprime el punjae total
        If punt < 1 Then 'verifica si tl puntaje es menor a 1 para saber si el usuario perdio y terminar el juego
            BTNgo.Enabled = False
            BTNstop.Enabled = False
            Form1.LBLpuntos.Text = "Puntuacion: " & punt
            Me.Close() 'cierra el formulario
            MsgBox("Perdiste :(", MsgBoxStyle.Critical) 'muetsra el mensaje de terminado el juego
            Tiros.Show()
            While i < pila.Count
                Tiros.LBLpuntos.Text = Tiros.LBLpuntos.Text & vbCrLf & pila.Pop()
                i = +1
            End While
        End If
        If punt > 199 Then 'verifica si el puntaje es mayor a 199 y si el usuario gano y termina el juego
            BTNgo.Enabled = False
            BTNstop.Enabled = False
            Form1.LBLpuntos.Text = "Puntuacion: " & punt
            Me.Close() 'cierra el formulario 
            MsgBox("¡Felicidades, Ganaste!", MsgBoxStyle.Information) 'muestra el mensaje de terminado el juego 
            Tiros.Show()
            While i <= pila.Count
                Tiros.LBLpuntos.Text = Tiros.LBLpuntos.Text & vbCrLf & pila.Pop()
                i = +1
            End While
        End If
    End Sub
End Class