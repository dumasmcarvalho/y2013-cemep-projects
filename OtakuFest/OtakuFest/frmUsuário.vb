Public Class frmUsuário

    Private Sub LoginBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.LoginBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            MessageBox.Show("Registro salvo com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Falha ao salvar o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsuário_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoginTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Login)
    End Sub

    Private Sub Nível_de_AcessoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nível_de_AcessoComboBox.SelectedIndexChanged
        If Nível_de_AcessoComboBox.SelectedIndex = 3 Then
            If InputBox("Informe a senha do sistema: ", "Mensagem do Sistema") = "2506" Then
                MsgBox("Senha correta, acesso permitido!", MsgBoxStyle.OkOnly, "Mensagem do Sistema")
            Else
                MsgBox("Senha incorreta, acesso negado!", MsgBoxStyle.OkOnly, "Mensagem do Sistema")
                Nível_de_AcessoComboBox.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub frmUsuário_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If MessageBox.Show("Deseja excluir o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                LoginBindingSource.RemoveCurrent()
                Me.Validate()
                Me.LoginBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            Else
                Me.LoginTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Login)
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao excluir o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Nível_de_AcessoComboBox.SelectedIndex = -1
        UsuárioTextBox.Focus()
    End Sub
End Class