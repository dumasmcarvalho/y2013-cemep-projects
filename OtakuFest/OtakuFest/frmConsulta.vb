Public Class frmConsulta

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)

    End Sub

    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radioClientes.Checked = False
        radioVendas.Checked = False
        radioProdutos.Checked = False
    End Sub

    Private Sub radioClientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioClientes.CheckedChanged
        If radioClientes.Checked = True Then
            ClienteDataGridView.Show()
            cpfDados.Show()
            Me.ClienteTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Cliente)
        Else
            cpfDados.Hide()
            ClienteDataGridView.Hide()
        End If
        Preencher()
    End Sub

    Private Sub radioVendas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioVendas.CheckedChanged
        If radioVendas.Checked = True Then
            Venda_CompraDataGridView.Show()
            dataDados_antes.Show()
            dataDados_depois.Show()
            btnData.Show()
            Me.Venda_CompraTableAdapter.Fill(Me.Banco_OtakuFestDataSet._Venda_Compra)
        Else
            dataDados_antes.Hide()
            dataDados_depois.Hide()
            btnData.Hide()
            Venda_CompraDataGridView.Hide()
        End If
        Preencher()
    End Sub

    Private Sub radioProdutos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioProdutos.CheckedChanged
        If radioProdutos.Checked = True Then
            ProdutosDataGridView.Show()
            tipoDados.Show()
            Me.ProdutosTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Produtos)
        Else
            tipoDados.Hide()
            ProdutosDataGridView.Hide()
        End If
        Preencher()
    End Sub

    Public Sub Preencher()
        cpfDados.Clear()
        dataDados_antes.Value = Date.Now
        dataDados_depois.Value = Date.Now
        tipoDados.Clear()
    End Sub

    Private Sub tipoDados_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tipoDados.TextChanged
        Me.ProdutosTableAdapter.FillByTipo(Me.Banco_OtakuFestDataSet.Produtos, tipoDados.Text)
    End Sub

    Private Sub cpfDados_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpfDados.TextChanged
        Me.ClienteTableAdapter.FillByCPF(Me.Banco_OtakuFestDataSet.Cliente, cpfDados.Text)
    End Sub

    Private Sub btnData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnData.Click
        Me.Venda_CompraTableAdapter.FillByData(Me.Banco_OtakuFestDataSet._Venda_Compra, dataDados_antes.Value, dataDados_depois.Value)
    End Sub
End Class