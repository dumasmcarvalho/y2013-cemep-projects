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
    public partial class frmFornecedor : Form
    {
        bool Ocupado;

        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            this.fornecedoresTableAdapter.Fill(this.bD_KWB_DataSet.Fornecedores);

            if (fornecedoresBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.fornecedoresBindingSource.Count == 0)
            {
                this.fornecedoresBindingSource.AddNew();
            }

            else if (this.fornecedoresBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.fornecedoresBindingSource.AddNew();
            }

            estadoComboBox.SelectedIndex = -1;
            razão_SocialTextBox.Focus();
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.fornecedoresBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.fornecedoresBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.fornecedoresBindingSource.RemoveCurrent();
                }
                else
                {
                    this.fornecedoresBindingSource.Position = this.fornecedoresBindingSource.Position;
                    this.fornecedoresTableAdapter.Fill(this.bD_KWB_DataSet.Fornecedores);
                }
            }

            razão_SocialTextBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.fornecedoresBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.fornecedoresBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.fornecedoresBindingSource.EndEdit();

                try
                {
                    this.fornecedoresTableAdapter.Update(bD_KWB_DataSet.Fornecedores);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.fornecedoresTableAdapter.Fill(this.bD_KWB_DataSet.Fornecedores);
                this.fornecedoresBindingSource.Position = this.fornecedoresBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.fornecedoresBindingSource.MoveLast();
        }

        private void razão_SocialTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
