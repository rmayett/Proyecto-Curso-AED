Imports System.Collections.Stack 'anexo de la pila
Imports System.Collections.Generic 'anexo para el uso de la lista
Public Class reloj
    Dim i As Integer = 0
    Dim lista As New List(Of Integer) 'declaracion de la lista de enteros
    Dim pila As New Stack() 'declaracion de la pila 
    Dim op As Integer = 0
    Public punt As Integer = 100 'puntuacion
    Private Sub reloj_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'carga el formulario
        BTNstop.Enabled = False
        Me.Text = "Puntuación del Jugador: " & Form1.TXTname.Text 'muestra la puntuacion inicial
        'se crea la lista con los puntajes de la ruleta 
        lista.Add(20)
        lista.Add(-30)
        lista.Add(10)
        lista.Add(-60)
        lista.Add(50)
        lista.Add(-20)
    End Sub
    'actividad del boton go
    Private Sub BTNgo_Click(sender As Object, e As EventArgs) Handles BTNgo.Click
        BTNstop.Enabled = True
        BTNgo.Enabled = False
        Timer1.Enabled = True 'inicia el timer
    End Sub
    'evento del timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        op += 1 'incremento de la variable op que hace que cambie de color los colores de los puntajes 
        If op >= 6 Then 'reinicia el valor de la variable para volver a empezar desde el primer valor(color de la ruleta) 
            op = 0
        End If
        Select Case op 'va cambiando los colores de los puntajes en la ruleta
            Case 0
                Form1.TXTmin20.BackColor = Color.Gold
                Form1.TXT20.BackColor = Color.DarkBlue
            Case 1
                Form1.TXT20.BackColor = Color.Gold
                Form1.TXTmin30.BackColor = Color.DarkBlue
            Case 2
                Form1.TXTmin30.BackColor = Color.Gold
                Form1.TXT10.BackColor = Color.DarkBlue
            Case 3
                Form1.TXT10.BackColor = Color.Gold
                Form1.TXTmin60.BackColor = Color.DarkBlue
            Case 4
                Form1.TXTmin60.BackColor = Color.Gold
                Form1.TXT50.BackColor = Color.DarkBlue
            Case 5
                Form1.TXT50.BackColor = Color.Gold
                Form1.TXTmin20.BackColor = Color.DarkBlue
        End Select
    End Sub
    'activividad del boton stop detiene el timer
    Private Sub BTNstop_Click(sender As Object, e As EventArgs) Handles BTNstop.Click
        BTNgo.Enabled = True
        BTNstop.Enabled = False
        Timer1.Enabled = False 'detiene el timer
        If lista(op) < 0 Then 'suma los puntos al puntaje total 
            Form1.LBLpuntos.Text = "Perdiste: " & lista(op) & " puntos" 'muestra el puntaje ganado o perdido 
        Else
            Form1.LBLpuntos.Text = "Ganaste: " & lista(op) & " puntos"
        End If
        pila.Push(lista(op))
        punt = punt + pila.Peek 'suma el puntaje  usando el tope de la pila
        LBLpunt.Text = "Puntuacion: " & punt 'imprime el punjae total
        If punt < 1 Then 'verifica si tl puntaje es menor a 1 para saber si el usuario perdio y terminar el juego
            BTNgo.Enabled = False 'se deshabilitan los botones de go y stop
            BTNstop.Enabled = False
            Form1.LBLpuntos.Text = "Perdiste D:" & vbCrLf & "Puntuacion: " & punt
            Me.Close() 'cierra el formulario
            MsgBox("Perdiste :(", MsgBoxStyle.Critical) 'muetsra el mensaje de terminado el juego
            Tiros.Show() 'muetra la ventana para de los tiros hechos y para generar el archivo pdf
            While i <= pila.Count 'muestra los tiros hechos en la ventana de tiros vaciando la pila
                Tiros.LBLpuntos.Text = Tiros.LBLpuntos.Text & vbCrLf & pila.Pop()
                i = +1
            End While
        End If
        If punt > 199 Then 'verifica si el puntaje es mayor a 199 y si el usuario gano y termina el juego
            BTNgo.Enabled = False 'se deshabilitan los botones de go y stop
            BTNstop.Enabled = False
            Form1.LBLpuntos.Text = "Ganaste :D" & vbCrLf & "Puntuacion: " & punt
            Me.Close() 'cierra el formulario 
            MsgBox("¡Felicidades, Ganaste!", MsgBoxStyle.Information) 'muestra el mensaje de terminado el juego 
            Tiros.Show() 'muetra la ventana para de los tiros hechos y para generar el archivo pdf
            While i <= pila.Count 'muestra los tiros hechos en la ventana de tiros vaciando la pila
                Tiros.LBLpuntos.Text = Tiros.LBLpuntos.Text & vbCrLf & pila.Pop()
                i = +1
            End While
        End If
    End Sub
End Class