Public Class Form1
    Dim horizontal1Respuesta, horizontal2Respuesta, vertical1Respuesta, vertical2Respuesta As String
    Dim correctas As Integer
    Dim errores1, errores2, errores3, errores4 As Integer
    Dim fin As Boolean
    Dim clicks As Integer

    Function progressBarModifiquer(ByVal a As Integer) As Integer
        a = a * 25
        ProgressBar1.Value() = a
        Return 1
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clicks = clicks + 1

        horizontal1Respuesta = Horizontal10.Text() + horizontal11.Text() & horizontal12.Text() & horizontal13.Text() & horizontal14.Text() & Horizontal15.Text() & Horizontal16.Text() & Horizontal17.Text() & Horizontal18.Text() & Horizontal19.Text() & Horizontal110.Text()
        horizontal1Respuesta = LCase(horizontal1Respuesta)
        If horizontal1Respuesta = "development" Then
            CheckBox1.Checked() = True
            ErrorHorizontal1.Text = ""
            correctas = correctas + 1
            progressBarModifiquer(correctas)
            Horizontal10.Enabled() = False
            horizontal11.Enabled() = False
            horizontal12.Enabled() = False
            horizontal13.Enabled() = False
            horizontal14.Enabled() = False
            Horizontal15.Enabled() = False
            Horizontal16.Enabled() = False
            Horizontal17.Enabled() = False
            Horizontal18.Enabled() = False
            Horizontal19.Enabled() = False
            Horizontal110.Enabled() = False

        Else
            errores1 = errores1 + 1
            ErrorHorizontal1.Text = "Palabra incorrecta"
            If errores1 > 1 Then
                ErrorHorizontal1.Text = "Palabra Perdida"
                Horizontal10.Enabled() = False
                horizontal11.Enabled() = False
                horizontal12.Enabled() = False
                horizontal13.Enabled() = False
                horizontal14.Enabled() = False
                Horizontal15.Enabled() = False
                Horizontal16.Enabled() = False
                Horizontal17.Enabled() = False
                Horizontal18.Enabled() = False
                Horizontal19.Enabled() = False
                Horizontal110.Enabled() = False
            End If
        End If

        horizontal2Respuesta = Horizontal20.Text() & Horizontal21.Text() & Horizontal22.Text() & TextBox13.Text()
        horizontal2Respuesta = LCase(horizontal2Respuesta)
        If horizontal2Respuesta = "java" Then
            correctas = correctas + 1
            CheckBox2.Checked = True
            ErrorHorizontal2.Text() = ""
            progressBarModifiquer(correctas)
            Horizontal20.Enabled() = False
            Horizontal21.Enabled() = False
            Horizontal22.Enabled() = False
            TextBox13.Enabled() = False

        Else
            errores2 = errores2 + 1
            ErrorHorizontal2.Text() = "Palabra incorrecta"
            If errores2 > 1 Then
                ErrorHorizontal2.Text() = "Palabra perdida"
                Horizontal20.Enabled() = False
                Horizontal21.Enabled() = False
                Horizontal22.Enabled() = False
                TextBox13.Enabled() = False
            End If
        End If

        vertical1Respuesta = vertical10.Text() & horizontal11.Text() & vertical12.Text() & vertical13.Text() & Horizontal22.Text() & vertical15.Text() & vertical16.Text()
        vertical1Respuesta = LCase(vertical1Respuesta)
        If vertical1Respuesta = "beloved" Then
            correctas = correctas + 1
            CheckBox3.Checked = True
            ErrorVertcal1.Text() = ""
            progressBarModifiquer(correctas)
            vertical10.Enabled() = False
            horizontal11.Enabled() = False
            vertical12.Enabled() = False
            vertical13.Enabled() = False
            Horizontal22.Enabled() = False
            vertical15.Enabled() = False
            vertical16.Enabled() = False

        Else
            errores3 = errores3 + 1
            ErrorVertcal1.Text() = "Palabra incorrecta"
            If errores3 > 1 Then
                ErrorVertcal1.Text() = "Palabra Perdida"
                progressBarModifiquer(correctas)
                vertical10.Enabled() = False
                horizontal11.Enabled() = False
                vertical12.Enabled() = False
                vertical13.Enabled() = False
                Horizontal22.Enabled() = False
                vertical15.Enabled() = False
                vertical16.Enabled() = False

            End If
        End If

        vertical2Respuesta = Horizontal17.Text() & TextBox21.Text()
        vertical2Respuesta = LCase(vertical2Respuesta)
        If vertical2Respuesta = "my" Then
            correctas = correctas + 1
            CheckBox4.Checked = True
            ErrorVertcal2.Text() = ""
            progressBarModifiquer(correctas)
            Horizontal17.Enabled() = False
            TextBox21.Enabled() = False

        Else
            errores4 = errores4 + 1
            ErrorVertcal2.Text() = "Palabra incorrecta"
            If errores4 > 1 Then
                ErrorVertcal2.Text() = "Palabra perdida"
                Horizontal17.Enabled() = False
                TextBox21.Enabled() = False

            End If
        End If

    End Sub


End Class
