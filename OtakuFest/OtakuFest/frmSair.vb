Public Class frmSair

    Public Shared Escolha As Integer

    Private Sub bntCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntCancelar.Click
        Escolha = 1
        Me.Dispose()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Escolha = 2
        Me.Dispose()
    End Sub

    Private Sub bntEncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntEncerrar.Click
        Escolha = 3
        Me.Dispose()
    End Sub
End Class