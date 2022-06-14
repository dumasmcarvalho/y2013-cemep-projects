Public Class frmRemuneração

    Public Shared Salário_Bruto, Descontos, Vendas_Realizadas, Comissão, Salário_Liquido As Decimal

    Private Sub Remuneração_do_FuncionárioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remuneração_do_FuncionárioBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Remuneração_do_FuncionárioBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            MessageBox.Show("Registro salvo com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Falha ao salvar o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRemuneração_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FuncionárioTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Funcionário)
        Me.Remuneração_do_FuncionárioTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Remuneração_do_Funcionário)
        If Remuneração_do_FuncionárioBindingSource.Count = 0 Then
            Remuneração_do_FuncionárioBindingSource.AddNew()
            Data_da_RemuneraçãoMaskedTextBox.Focus()
        End If
    End Sub

    Private Sub Nome_do_FuncionárioComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome_do_FuncionárioComboBox.SelectedIndexChanged
        Dim X As Integer = Nome_do_FuncionárioComboBox.SelectedIndex
        ID_do_FuncionárioComboBox.SelectedIndex = X
        CargoComboBox.SelectedIndex = X

        Select Case (CargoComboBox.SelectedValue)
            Case "Limpeza"
                Salário_Bruto = 800
                Vendas_RealizadasTextBox.Enabled = False
            Case "Vendas"
                Salário_Bruto = 1200
                Vendas_RealizadasTextBox.Enabled = True
            Case "Gerência"
                Salário_Bruto = 1800
                Vendas_RealizadasTextBox.Enabled = True
        End Select

        Vendas_RealizadasTextBox.Text = ""
        ComissãoTextBox.Text = ""
        Salário_LiquidoTextBox.Text = ""
        Salário_BrutoTextBox.Text = Salário_Bruto.ToString("R$ 0.00##")
    End Sub

    Private Sub Salário_BrutoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salário_BrutoTextBox.TextChanged
        If (CargoComboBox.SelectedValue = "Limpeza") Then
            Descontos = 0
            Vendas_Realizadas = 0
            Comissão = 0
            Vendas_RealizadasTextBox.Text = Vendas_Realizadas.ToString("R$ 0.00##")
        Else
            Descontos = Salário_Bruto * 0.05
        End If

        DescontosTextBox.Text = Descontos.ToString("R$ 0.00##")
    End Sub

    Private Sub Vendas_RealizadasTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vendas_RealizadasTextBox.TextChanged
        If CargoComboBox.SelectedValue <> "Limpeza" Then
            If Vendas_RealizadasTextBox.Text.Trim <> "" Then
                Vendas_Realizadas = Decimal.Parse(Vendas_RealizadasTextBox.Text)
            Else
                Vendas_Realizadas = 0
            End If

            Select Case (CargoComboBox.SelectedValue)
                Case "Vendas"
                    Comissão = Vendas_Realizadas * 0.3
                Case "Gerência"
                    Comissão = Vendas_Realizadas * 0.6
            End Select
        End If

        ComissãoTextBox.Text = Comissão.ToString("R$ 0.00##")
        Salário_Liquido = (Salário_Bruto - Descontos) + Comissão
        Salário_LiquidoTextBox.Text = Salário_Liquido.ToString("R$ 0.00##")
    End Sub

    Private Sub Vendas_RealizadasTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Vendas_RealizadasTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Nome_do_FuncionárioComboBox.SelectedIndex = -1
        ID_do_FuncionárioComboBox.SelectedIndex = -1
        CargoComboBox.SelectedIndex = -1
        Data_da_RemuneraçãoMaskedTextBox.Focus()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If MessageBox.Show("Deseja excluir o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Remuneração_do_FuncionárioBindingSource.RemoveCurrent()
                Me.Validate()
                Me.Remuneração_do_FuncionárioBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            Else
                Me.Remuneração_do_FuncionárioTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Remuneração_do_Funcionário)
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao excluir o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRemuneração_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class