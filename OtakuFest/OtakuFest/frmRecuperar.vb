Public Class frmRecuperar

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim Query As String = "SELECT * FROM Login WHERE Email = @Email"
        Dim Comando As New OleDb.OleDbCommand
        Dim Conexão As New OleDb.OleDbConnection
        Dim Consulta As OleDb.OleDbDataReader

        Conexão.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco_OtakuFest.accdb"
        Conexão.Open()
        Comando.Connection = Conexão
        Comando.CommandText = Query
        Comando.Parameters.AddWithValue("@Email", tbxEmail.Text)
        Consulta = Comando.ExecuteReader()

        If (Consulta.HasRows) Then
            Do While (Consulta.Read())
                Autenticação.Recuperação(Consulta("Usuário").ToString(), Consulta("Senha").ToString())
                MessageBox.Show(Autenticação.Exibir_Dados())
            Loop

        Else
            MessageBox.Show("O email informado não foi encontrado!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxEmail.Focus()
            tbxEmail.Text = ""
        End If

        Conexão.Close()
    End Sub

    Private Sub frmRecuperar_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class