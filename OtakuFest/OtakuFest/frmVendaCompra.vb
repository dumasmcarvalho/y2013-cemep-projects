Public Class frmVendaCompra

    Public Shared TValor_Unitário, TSub_Total As Double
    Dim Comando As New OleDb.OleDbCommand
    Dim Conexão As New OleDb.OleDbConnection
    Dim Adapter As OleDb.OleDbDataAdapter
    Dim Tabela As DataTable = New DataTable()

    Private Sub Venda_CompraBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Venda_CompraBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Venda_CompraBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            MessageBox.Show("Registro salvo com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Falha ao salvar o registro", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCompraVenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Cliente)
        Me.FuncionárioTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Funcionário)
        Me.ProdutosTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Produtos)
        Me.Itens_da_Venda_CompraTableAdapter.Fill(Me.Banco_OtakuFestDataSet._Itens_da_Venda_Compra)
        Me.Venda_CompraTableAdapter.Fill(Me.Banco_OtakuFestDataSet._Venda_Compra)

        If Venda_CompraBindingSource.Count = 0 Then
            Venda_CompraBindingSource.AddNew()
            Data_da_Venda_CompraMaskedTextBox.Focus()
        End If

        Tabela_Itens.ColumnCount = 7
        Tabela_Itens.Columns(0).Name = "ID do Item"
        Tabela_Itens.Columns(1).Name = "ID da Venda/Compra"
        Tabela_Itens.Columns(2).Name = "ID do Produto"
        Tabela_Itens.Columns(3).Name = "Descrição"
        Tabela_Itens.Columns(4).Name = "Quantidade"
        Tabela_Itens.Columns(5).Name = "Valor Unitário"
        Tabela_Itens.Columns(6).Name = "Sub Total"

        Tabela_Itens.Columns(5).DefaultCellStyle.Format = "R$ 0.00##"
        Tabela_Itens.Columns(6).DefaultCellStyle.Format = "R$ 0.00##"

        Tabela_Itens.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Tabela_Itens.MultiSelect = False

        Conexão.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Banco_OtakuFest.accdb"
        Comando.Connection = Conexão
    End Sub

    Public Sub Inserir(ByVal ID_Venda As Integer, ByVal ID_Produto As Integer, ByVal Descrição As String, ByVal Quantidade As Integer, ByVal Valor_Unitário As Double, ByVal Sub_Total As Double)
        Comando.CommandText = "INSERT INTO [Itens da Venda/Compra] ([ID da Venda/Compra], [ID do Produto], Descrição, Quantidade, [Valor Unitário], [Sub Total]) VALUES (@IDV, @IDP, @DES, @QUA, @VAL, @SUB)"

        Comando.Parameters.AddWithValue("@IDV", ID_Venda)
        Comando.Parameters.AddWithValue("@IDP", ID_Produto)
        Comando.Parameters.AddWithValue("@DES", Descrição)
        Comando.Parameters.AddWithValue("@QUA", Quantidade)
        Comando.Parameters.AddWithValue("@VAL", Valor_Unitário)
        Comando.Parameters.AddWithValue("@SUB", Sub_Total)

        Try
            Conexão.Open()

            If Comando.ExecuteNonQuery > 0 Then
                MessageBox.Show("Inserido com sucesso!")
            End If

            Conexão.Close()
            Dim ID As Integer = Integer.Parse(ID_da_Venda_CompraLabel3.Text)
            Carregar(ID)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conexão.Close()
        End Try
    End Sub

    Public Sub Preencher(ByVal ID_Item As Integer, ByVal ID_Venda As Integer, ByVal ID_Produto As Integer, ByVal Descrição As String, ByVal Quantidade As Integer, ByVal Valor_Unitário As Double, ByVal Sub_Total As Double)
        Tabela_Itens.Rows.Add(ID_Item, ID_Venda, ID_Produto, Descrição, Quantidade, Valor_Unitário, Sub_Total)
    End Sub

    Public Sub Carregar(ByVal ID_Venda As Integer)
        Tabela_Itens.Rows.Clear()
        Comando = New OleDb.OleDbCommand("SELECT * FROM [Itens da Venda/Compra] WHERE [ID da Venda/Compra] = " & ID_Venda, Conexão)

        Try
            Conexão.Open()
            Adapter = New OleDb.OleDbDataAdapter(Comando)
            Adapter.Fill(Tabela)

            For Each Row As DataRow In Tabela.Rows
                Preencher(Row(0).ToString(), Row(1).ToString(), Row(2).ToString(), Row(3).ToString(), Row(4).ToString(), Double.Parse(Row(5)), Double.Parse(Row(6)))
            Next Row

            Conexão.Close()
            Tabela.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conexão.Close()
        End Try
    End Sub

    Public Sub Atualizar(ByVal ID_Item As Integer, ByVal ID_Venda As Integer, ByVal ID_Produto As Integer, ByVal Descrição As String, ByVal Quantidade As Integer, ByVal Valor_Unitário As Double, ByVal Sub_Total As Double)
        Dim SQL As String = "UPDATE [Itens da Venda/Compra] SET [ID da Venda/Compra] = " & ID_Venda & ", [ID do Produto] = " & ID_Produto & ", Descrição = '" & Descrição & "', Quantidade = " & Quantidade & ", [Valor Unitário] = '" & Valor_Unitário & "', [Sub Total] = '" & Sub_Total & "' WHERE [ID do Item] = " & ID_Item
        Comando = New OleDb.OleDbCommand(SQL, Conexão)

        Try
            Conexão.Open()
            Adapter = New OleDb.OleDbDataAdapter(Comando)

            Adapter.UpdateCommand = Conexão.CreateCommand()
            Adapter.UpdateCommand.CommandText = Comando.CommandText

            If Adapter.UpdateCommand.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Atualizado com sucesso!")
            End If

            Conexão.Close()
            Dim ID As Integer = Integer.Parse(ID_da_Venda_CompraLabel3.Text)
            Carregar(ID)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conexão.Close()
        End Try
    End Sub

    Public Sub Apagar(ByVal ID_Item As Integer)
        Comando = New OleDb.OleDbCommand("DELETE FROM [Itens da Venda/Compra] WHERE [ID do Item] = " & ID_Item, Conexão)

        Try
            Adapter.DeleteCommand = Conexão.CreateCommand()
            Adapter.DeleteCommand.CommandText = Comando.CommandText
            Conexão.Open()

            If MsgBox("Deseja remover o item?", vbQuestion + vbYesNo, "Mensagem do Sistema") = vbYes Then
                If Comando.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Removido com sucesso!")
                End If
            End If

            Conexão.Close()
            Dim ID As Integer = Integer.Parse(ID_da_Venda_CompraLabel3.Text)
            Carregar(ID)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conexão.Close()
        End Try

    End Sub

    Private Sub Tabela_Itens_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tabela_Itens.MouseClick
        Try
            ID_do_ProdutoComboBox.SelectedIndex = Integer.Parse(Tabela_Itens.SelectedRows(0).Cells(2).Value.ToString()) - 1
            DescriçãoComboBox.SelectedIndex = ID_do_ProdutoComboBox.SelectedIndex
            QuantidadeNumericUpDown.Value = Decimal.Parse(Tabela_Itens.SelectedRows(0).Cells(4).Value.ToString())
            Valor_UnitárioTextBox.Text = Tabela_Itens.SelectedRows(0).Cells(5).Value
            Sub_TotalTextBox.Text = Tabela_Itens.SelectedRows(0).Cells(6).Value

        Catch ex As Exception
            MessageBox.Show("Nenhuma linha foi selecionada!")
        End Try
    End Sub

    Public Sub Repreencher()
        Tabela_Itens.Rows.Clear()
        Limpar_Campos()

        ID_da_Venda_CompraLabel3.Text = ID_da_Venda_CompraLabel1.Text
        Dim ID As Integer = Integer.Parse(ID_da_Venda_CompraLabel3.Text)
        Carregar(ID)
    End Sub

    Public Sub Limpar_Campos()
        DescriçãoComboBox.SelectedIndex = -1
        ID_do_ProdutoComboBox.SelectedIndex = -1
        QuantidadeNumericUpDown.Value = 1
        Valor_UnitárioTextBox.Clear()
        Sub_TotalTextBox.Clear()
    End Sub

    Private Sub Controles_Páginas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Controles_Páginas.SelectedIndexChanged
        Repreencher()
    End Sub

    Private Sub DescriçãoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescriçãoComboBox.SelectedIndexChanged
        Dim X As Integer = DescriçãoComboBox.SelectedIndex
        ID_do_ProdutoComboBox.SelectedIndex = X
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        Try
            Dim ID_Venda As Integer = Integer.Parse(ID_da_Venda_CompraLabel3.Text)
            Dim ID_Produto As Integer = Integer.Parse(ID_do_ProdutoComboBox.SelectedValue)
            Dim Quantidade As Integer = Integer.Parse(QuantidadeNumericUpDown.Value)

            If ((TValor_Unitário = 0) Or (TSub_Total = 0)) Then
                MessageBox.Show("Um ou mais campos não foram preenchidos!")
            Else
                Inserir(ID_Venda, ID_Produto, DescriçãoComboBox.SelectedValue.ToString(), Quantidade, TValor_Unitário, TSub_Total)
                Limpar_Campos()
            End If

        Catch ex As Exception
            MessageBox.Show("Um ou mais campos não foram preenchidos!")
        End Try
    End Sub

    Private Sub Valor_UnitárioTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Valor_UnitárioTextBox.TextChanged
        If (Double.TryParse(Valor_UnitárioTextBox.Text, TValor_Unitário)) Then
            TSub_Total = QuantidadeNumericUpDown.Value * Double.Parse(Valor_UnitárioTextBox.Text)
            Sub_TotalTextBox.Text = String.Format("{0:C2}", TSub_Total)
        End If
    End Sub

    Private Sub QuantidadeNumericUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuantidadeNumericUpDown.ValueChanged
        If (Double.TryParse(Valor_UnitárioTextBox.Text, TValor_Unitário)) Then
            TSub_Total = QuantidadeNumericUpDown.Value * Double.Parse(Valor_UnitárioTextBox.Text)
            Sub_TotalTextBox.Text = String.Format("{0:C2}", TSub_Total)
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Nome_do_FuncionárioComboBox.SelectedIndex = -1
        ID_do_FuncionárioComboBox.SelectedIndex = -1
        Nome_do_ClienteComboBox.SelectedIndex = -1
        ID_do_ClienteComboBox.SelectedIndex = -1
        Data_da_Venda_CompraMaskedTextBox.Focus()
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        Try
            Dim Linha_Selecionada As String = Tabela_Itens.SelectedRows(0).Cells(0).Value.ToString()
            Dim ID As Integer = Integer.Parse(Linha_Selecionada)
            Apagar(ID)
            Limpar_Campos()
        Catch ex As Exception
            MessageBox.Show("Nenhuma linha foi selecionada!")
        End Try
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Try
            Dim Linha_Selecionada As String = Tabela_Itens.SelectedRows(0).Cells(0).Value.ToString()
            Dim ID As Integer = Integer.Parse(Linha_Selecionada)

            Dim ID_Venda As Integer = Integer.Parse(ID_da_Venda_CompraLabel3.Text)
            Dim ID_Produto As Integer = Integer.Parse(ID_do_ProdutoComboBox.SelectedValue)
            Dim Quantidade As Integer = Integer.Parse(QuantidadeNumericUpDown.Value)

            If ((TValor_Unitário = 0) Or (TSub_Total = 0)) Then
                MessageBox.Show("Um ou mais campos não foram preenchidos!")
            Else
                Atualizar(ID, ID_Venda, ID_Produto, DescriçãoComboBox.SelectedValue.ToString(), Quantidade, TValor_Unitário, TSub_Total)
                Limpar_Campos()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        Dim ID As Integer = Integer.Parse(ID_da_Venda_CompraLabel3.Text)
        Carregar(ID)
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Tabela_Itens.Rows.Clear()
        Limpar_Campos()
    End Sub

    Private Sub Valor_UnitárioTextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Valor_UnitárioTextBox.Enter
        Valor_UnitárioTextBox.Clear()
    End Sub

    Private Sub frmVendaCompra_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        Repreencher()
        Valor_TotalTextBox.Text = String.Format("{0:C2}", Valor_Total())
    End Sub

    Public Function Valor_Total()
        Dim TTotal As Decimal = 0
        Dim X As Integer = 0

        While (X < Tabela_Itens.Rows.Count)
            TTotal = TTotal + Tabela_Itens.Rows(X).Cells(6).Value
            X = X + 1
        End While

        Return TTotal
    End Function

    Private Sub Nome_do_FuncionárioComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome_do_FuncionárioComboBox.SelectedIndexChanged
        Dim X As Integer = Nome_do_FuncionárioComboBox.SelectedIndex
        ID_do_FuncionárioComboBox.SelectedIndex = X
    End Sub

    Private Sub Nome_do_ClienteComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nome_do_ClienteComboBox.SelectedIndexChanged
        Dim X As Integer = Nome_do_ClienteComboBox.SelectedIndex
        ID_do_ClienteComboBox.SelectedIndex = X
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If MessageBox.Show("Deseja excluir o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Venda_CompraBindingSource.RemoveCurrent()
                Me.Validate()
                Me.Venda_CompraBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            Else
                Me.Venda_CompraTableAdapter.Fill(Me.Banco_OtakuFestDataSet._Venda_Compra)
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao excluir o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class