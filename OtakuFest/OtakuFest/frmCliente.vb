Public Class frmCliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ClienteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            MessageBox.Show("Registro salvo com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Falha ao salvar o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Cliente)

        If ClienteBindingSource.Count = 0 Then
            ClienteBindingSource.AddNew()
            Nome_do_ClienteTextBox.Focus()
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        SexoComboBox.SelectedIndex = -1
        EstadoComboBox.SelectedIndex = -1
        Nome_do_ClienteTextBox.Focus()
    End Sub

    Private Sub frmCliente_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If MessageBox.Show("Deseja excluir o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ClienteBindingSource.RemoveCurrent()
                Me.Validate()
                Me.ClienteBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            Else
                Me.ClienteTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Cliente)
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao excluir o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class