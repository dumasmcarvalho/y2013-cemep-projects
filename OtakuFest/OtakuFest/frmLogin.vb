Public Class frmLogin

    Public Shared Confirmar As Boolean

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim Query As String = "SELECT * FROM Login WHERE Usuário = @Usuário and Senha = @Senha"
        Dim Comando As New OleDb.OleDbCommand
        Dim Conexão As New OleDb.OleDbConnection
        Dim Consulta As OleDb.OleDbDataReader

        Conexão.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco_OtakuFest.accdb"
        Conexão.Open()
        Comando.Connection = Conexão
        Comando.CommandText = Query
        Comando.Parameters.AddWithValue("@Usuário", tbxUsuário.Text)
        Comando.Parameters.AddWithValue("@Senha", tbxSenha.Text)
        Consulta = Comando.ExecuteReader()

        If (Consulta.HasRows) Then
            Do While (Consulta.Read())
                Autenticação.Login(Consulta("Usuário").ToString(), Consulta("Senha").ToString(), Consulta("Nível de Acesso").ToString())
                MessageBox.Show("Autenticado com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Confirmar = False
                frmPrincipal.lblUsuário.Text = Autenticação.Exibir_Usuário()
                frmPrincipal.lblNível.Text = Autenticação.Exibir_Nível()
                frmPrincipal.Show()
                Me.Dispose()
            Loop

        Else
            MessageBox.Show("Usuário e/ou senha incorretos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxUsuário.Focus()
            tbxUsuário.Text = ""
            tbxSenha.Text = ""
        End If

        Conexão.Close()
    End Sub

    Private Sub frmLogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Confirmar = True Then
            If MsgBox("Deseja encerrar o aplicativo?", _
                vbQuestion + vbYesNo, "Sair do Sistema") = vbYes Then
                Application.ExitThread()
            Else
                e.Cancel = True
                tbxUsuário.Focus()
            End If
        End If
    End Sub

    Private Sub lblCadastro_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblCadastro.LinkClicked
        frmUsuário.ShowDialog()
    End Sub

    Private Sub lblRecuperar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblRecuperar.LinkClicked
        frmRecuperar.ShowDialog()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Confirmar = True
    End Sub
End Class