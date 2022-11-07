Public Class Form1
    Dim horizontal1Respuesta, horizontal2Respuesta, vertical1Respuesta, vertical2Respuesta As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        horizontal1Respuesta = Horizontal10.Text() + horizontal11.Text() & horizontal12.Text() & horizontal13.Text() & horizontal14.Text() & Horizontal15.Text() & Horizontal16.Text() & Horizontal17.Text() & Horizontal18.Text() & Horizontal19.Text() & Horizontal110.Text()
        horizontal1Respuesta = LCase(horizontal1Respuesta)
        If horizontal1Respuesta = "development" Then
            CheckBox1.Checked() = True
            ErrorHorizontal1.Text = ""
        Else
            ErrorHorizontal1.Text = "Palabra incorrecta"
        End If

        horizontal2Respuesta = Horizontal20.Text() & Horizontal21.Text() & Horizontal22.Text() & TextBox13.Text()
        horizontal2Respuesta = LCase(horizontal2Respuesta)
        If horizontal2Respuesta = "java" Then
            CheckBox2.Checked = True
            ErrorHorizontal2.Text() = ""
        Else
            ErrorHorizontal2.Text() = "Palabra incorrecta"
        End If

        vertical1Respuesta = vertical10.Text() & horizontal11.Text() & vertical12.Text() & vertical13.Text() & Horizontal22.Text() & vertical15.Text() & vertical16.Text()
        vertical1Respuesta = LCase(vertical1Respuesta)
        If vertical1Respuesta = "beloved" Then
            CheckBox3.Checked = True
            ErrorVertcal1.Text() = ""
        Else
            ErrorVertcal1.Text() = "Palabra incorrecta"
        End If

        vertical2Respuesta = Horizontal17.Text() & TextBox21.Text()
        vertical2Respuesta = LCase(vertical2Respuesta)
        If vertical2Respuesta = "my" Then
            CheckBox4.Checked = True
            ErrorVertcal2.Text() = ""
        Else
            ErrorVertcal2.Text() = "Palabra incorrecta"
        End If

    End Sub

End Class
