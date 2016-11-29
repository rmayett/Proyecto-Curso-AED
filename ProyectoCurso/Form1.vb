Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'carga del formulario
        MsgBox("¡Bienvenido al juego de la ruleta!" & vbCrLf & "Antes de empezar, por favor escribe tu nombre", MsgBoxStyle.Information)
    End Sub

    Private Sub BTNok_Click(sender As Object, e As EventArgs) Handles BTNok.Click 'Actividad del boton ok
        LBLbien.Text = "Hola " & TXTname.Text & vbCrLf & "Utiliza la segunda ventana para controlar la ruleta"
        TXTname.Enabled = False
        BTNok.Enabled = False
        BTNrest.Enabled = True
        reloj.Show()
    End Sub
    'activa el boton ok cuando el ususrio ingresa un nombre
    Private Sub TXTname_TextChanged(sender As Object, e As EventArgs) Handles TXTname.TextChanged
        If TXTname.Text <> "" Then
            BTNok.Enabled = True
        End If
    End Sub
    'restablece todo a valores predeterminados 
    Private Sub BTNrest_Click(sender As Object, e As EventArgs) Handles BTNrest.Click
        TXTname.Text = ""
        Tiros.Close() 'se cierran las ventanas
        reloj.Close()
        reloj.punt = 100
        LBLbien.Text = ""
        BTNok.Enabled = True
        TXTname.Enabled = True
        LBLpuntos.Text = ""
        BTNok.Enabled = False
        TXT10.BackColor = Color.Gold
        TXT20.BackColor = Color.Gold
        TXT50.BackColor = Color.Gold
        TXTmin20.BackColor = Color.Gold
        TXTmin30.BackColor = Color.Gold
        TXTmin60.BackColor = Color.Gold
    End Sub
    'subrutina de las reglas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Las reglas con muy sencillas" & vbCrLf & "El jugador empieza con 100 puntos hace girar la ruleta y gana :D o pierde puntos :( para ganar necesitas obtener 200 puntos o mas pero si te quedas sin puntos pierdes" & vbCrLf & "Buena suerte jugador :)", MsgBoxStyle.Information)
    End Sub
End Class
