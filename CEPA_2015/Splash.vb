Public Class Splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If (ProgressBar1.Value < ProgressBar1.Maximum) Then
            ProgressBar1.Increment(5)

        Else
            Timer1.Stop()
            Me.Hide()
            Jogo.Show()
        End If
    End Sub


    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Pic11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic11.Click

    End Sub
End Class