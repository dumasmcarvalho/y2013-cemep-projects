using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace System_KWB
{
    public partial class frmLivro : Form
    {
        bool Ocupado;
        Control Campo = new Control();

        public frmLivro()
        {
            InitializeComponent();
        }

        private void frmLivro_Load(object sender, EventArgs e)
        {
            this.livrosTableAdapter.Fill(this.bD_KWB_DataSet.Livros);

            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            if (livrosBindingSource.Count == 0)
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
            if (this.livrosBindingSource.Count == 0)
            {
                this.livrosBindingSource.AddNew();
            }

            else if (this.livrosBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.livrosBindingSource.AddNew();
            }

            alugadoCheckBox.Checked = false;
            generoComboBox.SelectedIndex = -1;
            tituloTextBox.Focus();
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.livrosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.livrosBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.livrosBindingSource.RemoveCurrent();
                }
                else
                {
                    this.livrosBindingSource.Position = this.livrosBindingSource.Position;
                    this.livrosTableAdapter.Fill(this.bD_KWB_DataSet.Livros);
                }
            }

            tituloTextBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.livrosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.livrosBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.livrosBindingSource.EndEdit();

                try
                {
                    this.livrosTableAdapter.Update(bD_KWB_DataSet.Livros);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.livrosTableAdapter.Fill(this.bD_KWB_DataSet.Livros);
                this.livrosBindingSource.Position = this.livrosBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.livrosBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.livrosBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.livrosBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.livrosBindingSource.MoveLast();
        }

        private void frmLivro_MouseHover(object sender, EventArgs e)
        {
            Mensagem.Hide(this);
        }

        private void DataPesquisar_Click(object sender, EventArgs e)
        {
            frmConsulta Consulta = new frmConsulta();
            Consulta.ShowDialog();
            Consulta.LivrosRadio.PerformClick();
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
