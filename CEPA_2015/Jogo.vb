Public Class Jogo
    Dim Clicou As Boolean = False
    Dim ImagemUm, ImagemDois As String
    Dim X As Integer = 300

    Sub Verificar()

        Pic1.Enabled = True
        Pic2.Enabled = True
        Pic3.Enabled = True
        Pic4.Enabled = True
        Pic5.Enabled = True
        Pic6.Enabled = True
        Pic7.Enabled = True
        Pic8.Enabled = True
        Pic9.Enabled = True
        Pic10.Enabled = True
        Pic11.Enabled = True
        Pic12.Enabled = True
        Pic13.Enabled = True
        Pic14.Enabled = True
        Pic15.Enabled = True
        Pic16.Enabled = True

        If ImagemUm = ImagemDois Then
            MsgBox("Acertou!")
        Else
            MsgBox("Errou!")
            My.Computer.Audio.Play(My.Resources.Errou, AudioPlayMode.WaitToComplete)

            Pic1.Image = My.Resources.Inte
            Pic2.Image = My.Resources.Inte
            Pic3.Image = My.Resources.Inte
            Pic4.Image = My.Resources.Inte
            Pic5.Image = My.Resources.Inte
            Pic6.Image = My.Resources.Inte
            Pic7.Image = My.Resources.Inte
            Pic8.Image = My.Resources.Inte
            Pic9.Image = My.Resources.Inte
            Pic10.Image = My.Resources.Inte
            Pic11.Image = My.Resources.Inte
            Pic12.Image = My.Resources.Inte
            Pic13.Image = My.Resources.Inte
            Pic14.Image = My.Resources.Inte
            Pic15.Image = My.Resources.Inte
            Pic16.Image = My.Resources.Inte
        End If
    End Sub

    Private Sub Pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic1.Click
        If Clicou = False Then
            Clicou = True
            Pic1.Image = My.Resources.P1
            Pic1.Enabled = False
            ImagemUm = "a"
        Else
            Clicou = False
            Pic1.Image = My.Resources.P1
            ImagemDois = "a"

            Verificar()
        End If
    End Sub

    Private Sub Pic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic4.Click
        If Clicou = False Then
            Clicou = True
            Pic4.Image = My.Resources.P5
            Pic4.Enabled = False
            ImagemUm = "e"
        Else
            Clicou = False
            Pic4.Image = My.Resources.P5
            ImagemDois = "e"

            Verificar()
        End If
    End Sub

    Private Sub Pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic2.Click
        If Clicou = False Then
            Clicou = True
            Pic2.Image = My.Resources.P6
            Pic2.Enabled = False
            ImagemUm = "b"
        Else
            Clicou = False
            Pic2.Image = My.Resources.P6
            ImagemDois = "b"

            Verificar()
        End If
    End Sub

    Private Sub Pic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic3.Click
        If Clicou = False Then
            Clicou = True
            Pic3.Image = My.Resources.P8
            Pic3.Enabled = False
            ImagemUm = "c"
        Else
            Clicou = False
            Pic3.Image = My.Resources.P8
            ImagemDois = "c"

            Verificar()
        End If
    End Sub

    Private Sub Pic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic5.Click
        If Clicou = False Then
            Clicou = True
            Pic5.Image = My.Resources.P8
            Pic5.Enabled = False
            ImagemUm = "c"
        Else
            Clicou = False
            Pic5.Image = My.Resources.P8
            ImagemDois = "c"

            Verificar()
        End If

    End Sub

    Private Sub Pic6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic6.Click
        If Clicou = False Then
            Clicou = True
            Pic6.Image = My.Resources.P2
            Pic6.Enabled = False
            ImagemUm = "f"
        Else
            Clicou = False
            Pic6.Image = My.Resources.P2
            ImagemDois = "f"

            Verificar()
        End If
    End Sub

    Private Sub Pic7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic7.Click
        If Clicou = False Then
            Clicou = True
            Pic7.Image = My.Resources.P4
            Pic7.Enabled = False
            ImagemUm = "d"
        Else
            Clicou = False
            Pic7.Image = My.Resources.P4
            ImagemDois = "d"

            Verificar()
        End If
    End Sub

    Private Sub Pic8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic8.Click
        If Clicou = False Then
            Clicou = True
            Pic8.Image = My.Resources.P7
            Pic8.Enabled = False
            ImagemUm = "g"
        Else
            Clicou = False
            Pic8.Image = My.Resources.P7
            ImagemDois = "g"

            Verificar()
        End If
    End Sub

    Private Sub Pic9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic9.Click
        If Clicou = False Then
            Clicou = True
            Pic9.Image = My.Resources.P7
            Pic9.Enabled = False
            ImagemUm = "g"
        Else
            Clicou = False
            Pic9.Image = My.Resources.P7
            ImagemDois = "g"

            Verificar()
        End If
    End Sub

    Private Sub Pic10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic10.Click
        If Clicou = False Then
            Clicou = True
            Pic10.Image = My.Resources.P3
            Pic10.Enabled = False
            ImagemUm = "h"
        Else
            Clicou = False
            Pic10.Image = My.Resources.P3
            ImagemDois = "h"

            Verificar()
        End If
    End Sub

    Private Sub Pic11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic11.Click
        If Clicou = False Then
            Clicou = True
            Pic11.Image = My.Resources.P6
            Pic11.Enabled = False
            ImagemUm = "b"
        Else
            Clicou = False
            Pic11.Image = My.Resources.P6
            ImagemDois = "b"

            Verificar()
        End If
    End Sub

    Private Sub Pic12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic12.Click
        If Clicou = False Then
            Clicou = True
            Pic12.Image = My.Resources.P5
            Pic12.Enabled = False
            ImagemUm = "e"
        Else
            Clicou = False
            Pic12.Image = My.Resources.P5
            ImagemDois = "e"

            Verificar()
        End If
    End Sub

    Private Sub Pic13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic13.Click
        If Clicou = False Then
            Clicou = True
            Pic13.Image = My.Resources.P2
            Pic13.Enabled = False
            ImagemUm = "f"
        Else
            Clicou = False
            Pic13.Image = My.Resources.P2
            ImagemDois = "f"

            Verificar()
        End If
    End Sub

    Private Sub Pic14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic14.Click
        If Clicou = False Then
            Clicou = True
            Pic14.Image = My.Resources.P1
            Pic14.Enabled = False
            ImagemUm = "a"
        Else
            Clicou = False
            Pic14.Image = My.Resources.P1
            ImagemDois = "a"

            Verificar()
        End If
    End Sub

    Private Sub Pic15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic15.Click
        If Clicou = False Then
            Clicou = True
            Pic15.Image = My.Resources.P4
            Pic15.Enabled = False
            ImagemUm = "d"
        Else
            Clicou = False
            Pic15.Image = My.Resources.P4
            ImagemDois = "d"

            Verificar()
        End If
    End Sub

    Private Sub Pic16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic16.Click
        If Clicou = False Then
            Clicou = True
            Pic16.Image = My.Resources.P3
            Pic16.Enabled = False
            ImagemUm = "h"
        Else
            Clicou = False
            Pic16.Image = My.Resources.P3
            ImagemDois = "h"

            Verificar()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If X > 0 Then
            X = X - 1
            Label1.Text = X.ToString()
        End If
    End Sub

    Private Sub Jogo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Principal.TextBox1.Text
    End Sub
End Class