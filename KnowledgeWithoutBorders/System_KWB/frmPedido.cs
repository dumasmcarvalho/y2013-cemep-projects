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
    public partial class frmPedido : Form
    {
        bool Ocupado;
        Control Campo = new Control();

        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            this.pedido_de_LivrosTableAdapter.Fill(this.bD_KWB_DataSet.Pedido_de_Livros);

            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            if (pedido_de_LivrosBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (generoComboBox.SelectedIndex == -1)
            {
                Campo = generoComboBox;
                Campo.Focus();
                Mensagem.ToolTipTitle = "Campo Vazio";
                Mensagem.ToolTipIcon = ToolTipIcon.Error;
                Mensagem.Show("Nenhum item foi selecionado", Campo, Campo.Width, Campo.Height);
            }

            else if (generoTextBox.Text == "")
            {
                generoTextBox.Text = generoComboBox.SelectedItem.ToString();
            }

            else
            {
                generoTextBox.Text = generoComboBox.SelectedItem.ToString() + Environment.NewLine + generoTextBox.Text;
            }

            generoComboBox.SelectedIndex = -1;
            generoComboBox.Focus();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (generoTextBox.Text == "")
            {
                Campo = generoTextBox;
                Campo.Focus();
                Mensagem.ToolTipTitle = "Campo Vazio";
                Mensagem.ToolTipIcon = ToolTipIcon.Error;
                Mensagem.Show("Não existem itens para remover", Campo, Campo.Width, Campo.Height);
            }

            else if (generoTextBox.Text != "")
            {

                String[] linhas = generoTextBox.Lines;

                System.Collections.ArrayList lista = new System.Collections.ArrayList(linhas);

                lista.RemoveAt(0);

                linhas = (System.String[])lista.ToArray(Type.GetType("System.String"));

                generoTextBox.Lines = linhas;
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.pedido_de_LivrosBindingSource.Count == 0)
            {
                this.pedido_de_LivrosBindingSource.AddNew();
            }

            else if (this.pedido_de_LivrosBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.pedido_de_LivrosBindingSource.AddNew();
            }

            quantidadeNumericUpDown.Value = 0;
            generoComboBox.SelectedIndex = -1;
            tituloTextBox.Focus();
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.pedido_de_LivrosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.pedido_de_LivrosBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.pedido_de_LivrosBindingSource.RemoveCurrent();
                }
                else
                {
                    this.pedido_de_LivrosBindingSource.Position = this.pedido_de_LivrosBindingSource.Position;
                    this.pedido_de_LivrosTableAdapter.Fill(this.bD_KWB_DataSet.Pedido_de_Livros);
                }
            }

            tituloTextBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.pedido_de_LivrosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.pedido_de_LivrosBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.pedido_de_LivrosBindingSource.EndEdit();

                try
                {
                    this.pedido_de_LivrosTableAdapter.Update(bD_KWB_DataSet.Pedido_de_Livros);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.pedido_de_LivrosTableAdapter.Fill(this.bD_KWB_DataSet.Pedido_de_Livros);
                this.pedido_de_LivrosBindingSource.Position = this.pedido_de_LivrosBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.pedido_de_LivrosBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.pedido_de_LivrosBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.pedido_de_LivrosBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.pedido_de_LivrosBindingSource.MoveLast();
        }

        private void frmPedido_MouseHover(object sender, EventArgs e)
        {
            Mensagem.Hide(this);
        }

        private void tituloTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
