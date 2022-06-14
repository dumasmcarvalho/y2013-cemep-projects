Public Class frmSplash

    Private Sub Temporizador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Temporizador.Tick
        If Sub_Progresso.Value < Sub_Progresso.Maximum Then
            Sub_Progresso.Increment(5)
        ElseIf (Progresso.Value < Progresso.Maximum) Then
            Sub_Progresso.Value = 0
            Progresso.Increment(25)
        End If

        Select Case (Progresso.Value)
            Case 25
                Mensagem.Text = "Carregando o banco de dados..."
            Case 50
                Mensagem.Text = "Organizando ferramentas..."
            Case 75
                Mensagem.Text = "Inicializando o sistema..."
        End Select

        If (Progresso.Value = Progresso.Maximum) Then
            Temporizador.Stop()
            Me.Hide()
            frmLogin.ShowDialog()
        End If
    End Sub
End Class
