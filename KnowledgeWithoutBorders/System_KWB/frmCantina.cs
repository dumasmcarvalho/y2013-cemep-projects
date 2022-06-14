using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace System_KWB
{
    public partial class frmCantina : Form
    {
        bool Ocupado;

        static double Sub_Total;
        static double Valor_Unitario;

        Conexão Conexão = new Conexão();
        OleDbCommand Comando = new OleDbCommand();
        OleDbDataAdapter Adapter;
        DataTable Tabela = new DataTable();

        public frmCantina()
        {
            InitializeComponent();

            // Propriedades do DataGrid

            DataGrid.ColumnCount = 7;
            string[] Vetor = { "Código Item", "Código Venda", "Código Produto", "Nome Produto", "Quantidade", "Valor Unitário", "Sub Total" };

            for (int x = 0; x <= 6; x++)
            {
                DataGrid.Columns[x].Name = Vetor[x];
            }

            DataGrid.Columns[5].DefaultCellStyle.Format = "R$ 0.00##";
            DataGrid.Columns[6].DefaultCellStyle.Format = "R$ 0.00##";

            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Seleção da Linha

            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.MultiSelect = false;   
        }

        // Inserir no Banco de Dados

        private void Inserir(int idVenda, int idProduto, string nomeProduto, int Quantidade, double valorUnitario, double subTotal)
        {
            // SQL para Inserir

            Comando.CommandText = "INSERT INTO Itens_da_Venda (Venda, Produto, Descricao, Quantidade, Valor_Unitario, Sub_Total) " +
                                        "VALUES (@VEN, @PRO, @DES, @QUA, @VU, @ST)";
            Comando.Connection = Conexão._Conexão;

            // Adicionando Parametros

            Comando.Parameters.AddWithValue("@VEN", idVenda);
            Comando.Parameters.AddWithValue("@PRO", idProduto);
            Comando.Parameters.AddWithValue("@DES", nomeProduto);
            Comando.Parameters.AddWithValue("@QUA", Quantidade);
            Comando.Parameters.AddWithValue("@VU", valorUnitario);
            Comando.Parameters.AddWithValue("@ST", subTotal);

            // Conectar e Execute do Insert

            try
            {
                Conexão.Conectar();

                if (Comando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Inserido item com sucesso!");
                }

                Conexão.Desconectar();

                int ID = Convert.ToInt32(vendaLabel2.Text);
                Carregar(ID);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();
            }
        }

        // Preencher Campos da Tabela

        private void Linhas(string idItem, string idVenda, string idProduto, string nomeProduto, string Quantidade, double valorUnitario, double subTotal)
        {
            DataGrid.Rows.Add(idItem, idVenda, idProduto, nomeProduto, Quantidade, valorUnitario, subTotal);
        }

        // Recuperação de Dados

        private void Carregar(int idVenda)
        {
            DataGrid.Rows.Clear();

            // SQL de Carregamento

            string SQL = "SELECT * FROM Itens_da_Venda WHERE Venda = " + idVenda;
            Comando = new OleDbCommand(SQL, Conexão._Conexão);

            try
            {
                Conexão.Conectar();
                Adapter = new OleDbDataAdapter(Comando);

                Adapter.Fill(Tabela);

                // Loop de Incremento de Linhas na Tabela
                foreach (DataRow Row in Tabela.Rows)
                {
                    Linhas(Row[0].ToString(), Row[1].ToString(), Row[2].ToString(), Row[3].ToString(), Row[4].ToString(), Convert.ToDouble(Row[5]), Convert.ToDouble(Row[6]));
                }

                Conexão.Desconectar();

                // Limpar Tabela

                Tabela.Rows.Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();
            }
        }

        // Atualizar o Banco de Dados

        private void Atualizar(int idItem, int idVenda, int idProduto, string nomeProduto, int Quantidade, double valorUnitario, double subTotal)
        {
            // SQL para Atualizar

            string SQL = "UPDATE Itens_da_Venda SET Venda = " + idVenda + ", Produto = " + idProduto + ", Descricao = '" + nomeProduto + "', Quantidade = " + Quantidade + ", Valor_Unitario = '" + valorUnitario + "', Sub_Total = '" + subTotal + "' WHERE Codigo_do_Item = " + idItem;

            Comando = new OleDbCommand(SQL, Conexão._Conexão);

            // Conectar Conexão, Atualizar, Recuperação, Preencher

            try
            {
                Conexão.Conectar();
                Adapter = new OleDbDataAdapter(Comando);

                Adapter.UpdateCommand = Conexão._Conexão.CreateCommand();
                Adapter.UpdateCommand.CommandText = SQL;

                if (Adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Item da venda foi atualizado!");
                }

                Conexão.Desconectar();

                // Atualizar
                int ID = Convert.ToInt32(vendaLabel2.Text);
                Carregar(ID);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();
            }
        }

        // Apagar do Banco de Dados

        private void Apagar(int idItem)
        {
            // SQL para Apagar

            string SQL = "DELETE FROM Itens_da_Venda WHERE Codigo_do_Item = " + idItem;

            Comando = new OleDbCommand(SQL, Conexão._Conexão);

            // Conectar Conexão, Executar o Apagamento, Fechar Conexão

            try
            {
                Conexão.Conectar();
                Adapter = new OleDbDataAdapter(Comando);

                Adapter.DeleteCommand = Conexão._Conexão.CreateCommand();
                Adapter.DeleteCommand.CommandText = SQL;

                // Confirmação para Apagar

                if ((MessageBox.Show("Deseja remover o item?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK))
                {
                    if (Comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Item removido com sucesso!");
                    }

                }

                Conexão.Desconectar();

                int ID = Convert.ToInt32(vendaLabel2.Text);
                Carregar(ID);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();
            }
        }


        private void frmCantina_Load(object sender, EventArgs e)
        {
            this.cantinaTableAdapter.Fill(this.bD_KWB_DataSet.Cantina);
            this.produtosTableAdapter.Fill(this.bD_KWB_DataSet.Produtos);
            this.cantinaTableAdapter.Fill(this.bD_KWB_DataSet.Cantina);

            if (cantinaBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }

            valor_TotalTextBox.Text = string.Format("{0:C2}", Valor_Total());
        }

        private void descriçãoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = descriçãoComboBox.SelectedIndex;
            produtoComboBox.SelectedIndex = x;
        }

        private void valor_UnitarioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(valor_UnitarioTextBox.Text, out Valor_Unitario))
            {
                Sub_Total = Convert.ToDouble(quantidadeNumericUpDown.Value) * Convert.ToDouble(valor_UnitarioTextBox.Text);
                sub_TotalTextBox.Text = string.Format("{0:C2}", Sub_Total);
            }
        }

        private void quantidadeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (double.TryParse(valor_UnitarioTextBox.Text, out Valor_Unitario))
            {
                Sub_Total = Convert.ToDouble(quantidadeNumericUpDown.Value) * Convert.ToDouble(valor_UnitarioTextBox.Text);
                sub_TotalTextBox.Text = string.Format("{0:C2}", Sub_Total);
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.cantinaBindingSource.Count == 0)
            {
                this.cantinaBindingSource.AddNew();
            }

            else if (this.cantinaBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.cantinaBindingSource.AddNew();
            }

            data_da_VendaDateTimePicker.Value = DateTime.Now;
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.cantinaBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.cantinaBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Deseja remover o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.cantinaBindingSource.RemoveCurrent();
                }
                else
                {
                    this.cantinaBindingSource.Position = this.cantinaBindingSource.Position;
                    this.cantinaTableAdapter.Fill(this.bD_KWB_DataSet.Cantina);
                }
            }

            data_da_VendaDateTimePicker.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (data_da_VendaDateTimePicker.Text == "")
            {
                data_da_VendaDateTimePicker.Value = DateTime.Now;
            }

            if (this.cantinaBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.cantinaBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.cantinaBindingSource.EndEdit();

                try
                {
                    this.cantinaTableAdapter.Update(bD_KWB_DataSet.Cantina);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.cantinaTableAdapter.Fill(this.bD_KWB_DataSet.Cantina);
                this.cantinaBindingSource.Position = this.cantinaBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.cantinaBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.cantinaBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.cantinaBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.cantinaBindingSource.MoveLast();
        }

        private void LimparCampos()
        {
            quantidadeNumericUpDown.Value = 0;
            valor_UnitarioTextBox.Clear();
            sub_TotalTextBox.Clear();
            produtoComboBox.SelectedIndex = -1;
            descriçãoComboBox.SelectedIndex = -1;
        }

        private void Repreencher()
        {
            DataGrid.Rows.Clear();
            LimparCampos();

            vendaLabel2.Text = código_da_VendaLabel1.Text;

            int ID = Convert.ToInt32(vendaLabel2.Text);
            Carregar(ID);
        }

        private void DataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                produtoComboBox.SelectedIndex = (Convert.ToInt32(DataGrid.SelectedRows[0].Cells[2].Value.ToString())) -1;

                descriçãoComboBox.SelectedIndex = produtoComboBox.SelectedIndex;

                quantidadeNumericUpDown.Value = Convert.ToDecimal(DataGrid.SelectedRows[0].Cells[4].Value);

                valor_UnitarioTextBox.Text = DataGrid.SelectedRows[0].Cells[5].Value.ToString();

                sub_TotalTextBox.Text = DataGrid.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Nenhuma linha foi selecionada!", "Aviso");
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Repreencher();
            valor_TotalTextBox.Text = string.Format("{0:C2}", Valor_Total());
        }

        private void btnAdicionarDados_Click(object sender, EventArgs e)
        {
            try
            {
                int idVenda = Convert.ToInt32(vendaLabel2.Text);
                int idProduto = Convert.ToInt32(produtoComboBox.SelectedValue);
                int Quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);

                if ((Valor_Unitario == 0) || (Sub_Total == 0))
                {
                    MessageBox.Show("Um ou mais campos não foram preenchidos!", "Aviso");
                }
                else
                {
                    Inserir(idVenda, idProduto, descriçãoComboBox.SelectedValue.ToString(), Quantidade, Valor_Unitario, Sub_Total);
                    LimparCampos();
                }
            }
            catch
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos!", "Aviso");
            }
        }

        private void btnRemoverDados_Click(object sender, EventArgs e)
        {
            try
            {
                string Selecionada = DataGrid.SelectedRows[0].Cells[0].Value.ToString();

                int ID = Convert.ToInt32(Selecionada);
                Apagar(ID);

                LimparCampos();
            }
            catch
            {
                MessageBox.Show("Nenhuma linha foi selecionada!", "Aviso");
            }
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            LimparCampos();
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            try
            {
                string Selecionada = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
                int ID = Convert.ToInt32(Selecionada);

                int idVenda = Convert.ToInt32(vendaLabel2.Text);
                int idProduto = Convert.ToInt32(produtoComboBox.SelectedValue);
                int Quantidade = Convert.ToInt32(quantidadeNumericUpDown.Value);

                Atualizar(ID, idVenda, idProduto, descriçãoComboBox.SelectedValue.ToString(), Quantidade, Valor_Unitario, Sub_Total);
            }
            catch
            {
                MessageBox.Show("Nenhuma linha foi selecionada!", "Aviso");
            }
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(vendaLabel2.Text);
            Carregar(ID);
        }

        private double Valor_Total()
        {
            double Total = 0;

            for (int x = 0; x < DataGrid.Rows.Count; x++)
            {
                Total = Total + Convert.ToDouble(DataGrid.Rows[x].Cells[6].Value);
            }

            return Total;
        }

        private void valor_TotalTextBox_TextChanged(object sender, EventArgs e)
        {
            valor_TotalTextBox.Text = string.Format("{0:C2}", Valor_Total());
        }

        private void valor_UnitarioTextBox_Enter(object sender, EventArgs e)
        {
            valor_UnitarioTextBox.Clear();
        }

        private void valor_UnitarioTextBox_Leave(object sender, EventArgs e)
        {
            if (valor_UnitarioTextBox.Text == "")
            {
                valor_UnitarioTextBox.Text = "0";
            }
        }

        private void data_da_VendaDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
