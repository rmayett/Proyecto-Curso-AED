Imports System.IO '
Imports iTextSharp.text ' iTextSharp es una biblioteca para el manejo del PDF
Imports iTextSharp.text.pdf
Public Class Tiros
    'subrutina del boton creadPDF para crear el pdf con los datos y tiros del usuario
    Private Sub BTNPDF_Click(sender As Object, e As EventArgs) Handles BTNPDF.Click
        ErrorProvider1.SetError(TXTRuta, "") 'poner el errorprovider vacio
        If TXTRuta.Text <> "" Then 'verifica que posea una ruta
            Try
                Me.ProgressBar1.Value = 10 'da el valor de 10 a la barra de progreso
                Dim documentoPDF As New iTextSharp.text.Document(PageSize.LETTER)
                Dim nombrePDF As String = TXTRuta.Text & ".pdf" 'declaracion de variable que guarda ruta y nombre del pdf  
                Dim pdfw As iTextSharp.text.pdf.PdfWriter 'se utilizara para la creacion del pdf
                Dim cb As PdfContentByte 'se utiliza para la escritura
                Dim fuente As iTextSharp.text.pdf.BaseFont 'se utiliza para la fuente del pdf

                pdfw = PdfWriter.GetInstance(documentoPDF, New FileStream(nombrePDF, FileMode.Create)) 'se crea el archivo pdf
                documentoPDF.Open() 'abre el flujo del archivo
                cb = pdfw.DirectContent

                cb.BeginText()
                fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
                cb.SetFontAndSize(fuente, 12)

                Me.ProgressBar1.Value = 40 'da el valor de 40 a la barra de progreso
                'guarda los datos que le anexamos al pdf
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Proyecto Final Algoritmos y Estructuras de Datos", 175, 750, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Puntaje de " & Form1.TXTname.Text & ":", 250, 700, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Form1.LBLpuntos.Text, 220, 650, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Tiros de " & Form1.TXTname.Text & ":", 250, 600, 0)
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, LBLpuntos.Text, 220, 550, 0)
                Me.ProgressBar1.Value = 60 'da el valor de 60 a la barra de progreso
                cb.EndText()
                Me.ProgressBar1.Value = 80 'da el valor de 80 a la barra de progreso
                documentoPDF.AddAuthor(Form1.TXTname.Text) 'agrega el autor del pdf
                documentoPDF.AddSubject("Tiros de la Ruleta") 'el tema
                documentoPDF.AddCreationDate() 'la fecha de creacion 
                documentoPDF.Close() 'cierra el flujo de datos y guarda todo
                Me.ProgressBar1.Value = 100 'da el valor de 100 a la barra de progreso
                If ProgressBar1.Value.Equals(100) Then
                    BTNPDF.Enabled = False 'des habilita el boton 
                    MsgBox("PDF creado correctamente" & vbCrLf & "Creado en: " & TXTRuta.Text & ".pdf", MsgBoxStyle.Information) 'anuncia que se creo de forma exitosa y donde se guardo
                End If
            Catch ex As Exception 'errores al guardar 
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Fatan datos", MsgBoxStyle.Exclamation) 'abre una ventana indicando un error 
            ErrorProvider1.SetError(TXTRuta, "Escribe la ruta con el nombre del archivo ") 'muestra donde esta el error
        End If
    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click
        Me.Close() 'cierra la ventaana
    End Sub
End Class