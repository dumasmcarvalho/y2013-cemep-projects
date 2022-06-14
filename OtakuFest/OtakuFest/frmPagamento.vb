Public Class frmPagamento

    Private Sub frmPagamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Venda_CompraTableAdapter.Fill(Me.Banco_OtakuFestDataSet._Venda_Compra)
        Me.ClienteTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Cliente)
        Me.Pagamento_do_ClienteTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Pagamento_do_Cliente)
        If Pagamento_do_ClienteBindingSource.Count = 0 Then
            Pagamento_do_ClienteBindingSource.AddNew()
            ExclusivoCheckBox.Checked = False
            Valor_FinalTextBox.Clear()
            DescontosTextBox.Clear()
            Data_da_CompraComboBox.Focus()
        End If
    End Sub

    Private Sub Nome_do_ClienteComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome_do_ClienteComboBox.SelectedIndexChanged
        Dim X As Integer = Nome_do_ClienteComboBox.SelectedIndex
        ID_do_ClienteComboBox.SelectedIndex = X
    End Sub

    Private Sub ExclusivoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExclusivoCheckBox.CheckedChanged
        Dim Valor_Total As Decimal = Valor_TotalComboBox.SelectedValue
        Dim Descontos As Decimal
        Dim Valor_Final As Decimal

        If ExclusivoCheckBox.Checked = True Then
            Descontos = Valor_Total * 0.1
            Valor_Final = Valor_Total - Descontos
        Else
            Descontos = 0
            Valor_Final = Valor_Total - Descontos
        End If

        DescontosTextBox.Text = String.Format("{0:C2}", Descontos)
        Valor_FinalTextBox.Text = String.Format("{0:C2}", Valor_Final)
    End Sub

    Private Sub Data_da_CompraComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Data_da_CompraComboBox.SelectedIndexChanged
        Dim X As Integer = Data_da_CompraComboBox.SelectedIndex
        Valor_TotalComboBox.SelectedIndex = X

        Dim Valor_Total As Decimal = Valor_TotalComboBox.SelectedValue
        Dim Descontos As Decimal
        Dim Valor_Final As Decimal

        If ExclusivoCheckBox.Checked = True Then
            Descontos = Valor_Total * 0.1
            Valor_Final = Valor_Total - Descontos
        Else
            Descontos = 0
            Valor_Final = Valor_Total - Descontos
        End If

        DescontosTextBox.Text = String.Format("{0:C2}", Descontos)
        Valor_FinalTextBox.Text = String.Format("{0:C2}", Valor_Final)
    End Sub

    Private Sub Pagamento_do_ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pagamento_do_ClienteBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Pagamento_do_ClienteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            MessageBox.Show("Registro salvo com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Falha ao salvar o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Forma_de_PagamentoComboBox.SelectedIndex = -1
        Data_da_CompraComboBox.SelectedIndex = -1
        Nome_do_ClienteComboBox.SelectedIndex = -1
        ID_do_ClienteComboBox.SelectedIndex = -1
        ExclusivoCheckBox.Checked = False
        Valor_TotalComboBox.SelectedIndex = -1
        Data_do_PagamentoMaskedTextBox.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If MessageBox.Show("Deseja excluir o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Pagamento_do_ClienteBindingSource.RemoveCurrent()
                Me.Validate()
                Me.Pagamento_do_ClienteBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            Else
                Me.Pagamento_do_ClienteTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Pagamento_do_Cliente)
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao excluir o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPagamento_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class