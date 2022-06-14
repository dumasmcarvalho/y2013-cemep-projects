using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System_KWB
{
    public partial class frmEstoque : Form
    {
        bool Ocupado;

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            this.estoqueTableAdapter.Fill(bD_KWB_DataSet.Estoque);
            this.fornecedoresTableAdapter.Fill(this.bD_KWB_DataSet.Fornecedores);
            this.produtosTableAdapter.Fill(this.bD_KWB_DataSet.Produtos);

            if (estoqueBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.estoqueBindingSource.Count == 0)
            {
                this.estoqueBindingSource.AddNew();
            }

            else if (this.estoqueBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.estoqueBindingSource.AddNew();
            }

            nome_do_ProdutoComboBox.SelectedIndex = -1;
            código_do_ProdutoComboBox.SelectedIndex = -1;
            nome_do_FornecedorComboBox.SelectedIndex = -1;
            código_do_FornecedorComboBox.SelectedIndex = -1;

            quantidade_em_EstoqueNumericUpDown.Value = 0;
            estoque_CriticoNumericUpDown.Value = 0;
            comprarCheckBox.Checked = false;
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.estoqueBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.estoqueBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.estoqueBindingSource.RemoveCurrent();
                }
                else
                {
                    this.estoqueBindingSource.Position = this.estoqueBindingSource.Position;
                    this.estoqueTableAdapter.Fill(this.bD_KWB_DataSet.Estoque);
                }
            }

            nome_do_ProdutoComboBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.estoqueBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.estoqueBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.estoqueBindingSource.EndEdit();

                try
                {
                    this.estoqueTableAdapter.Update(bD_KWB_DataSet.Estoque);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.estoqueTableAdapter.Fill(this.bD_KWB_DataSet.Estoque);
                this.estoqueBindingSource.Position = this.estoqueBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.estoqueBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.estoqueBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.estoqueBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.estoqueBindingSource.MoveLast();
        }

        private void nome_do_ProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = nome_do_ProdutoComboBox.SelectedIndex;
            código_do_ProdutoComboBox.SelectedIndex = x;
        }

        private void quantidade_em_EstoqueNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (quantidade_em_EstoqueNumericUpDown.Value < estoque_CriticoNumericUpDown.Value)
            {
                comprarCheckBox.Checked = true;
            }
            else
            {
                comprarCheckBox.Checked = false;
            }
        }

        private void estoque_CriticoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (estoque_CriticoNumericUpDown.Value > quantidade_em_EstoqueNumericUpDown.Value) 
            {
                comprarCheckBox.Checked = true;
            }
            else
            {
                comprarCheckBox.Checked = false;
            }
        }

        private void nome_do_ProdutoComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void nome_do_FornecedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = nome_do_FornecedorComboBox.SelectedIndex;
            código_do_FornecedorComboBox.SelectedIndex = x;
        }
    }
}
