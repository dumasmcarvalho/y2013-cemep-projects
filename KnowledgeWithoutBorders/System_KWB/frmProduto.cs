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
    public partial class frmProduto : Form
    {
        bool Ocupado;

        public frmProduto()
        {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            this.produtosTableAdapter.Fill(this.bD_KWB_DataSet.Produtos);

            if (produtosBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo_Carregar = new OpenFileDialog();
            if (Dialogo_Carregar.ShowDialog() == DialogResult.OK)
            {
                Bitmap Bit = new Bitmap(Dialogo_Carregar.FileName);

                Dialogo_Carregar.DefaultExt = "*.jpg";
                Dialogo_Carregar.Filter = "Imagem (*.jpg)|*.jpg";

                fotoPictureBox.Image = Bit;
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.produtosBindingSource.Count == 0)
            {
                this.produtosBindingSource.AddNew();
            }

            else if (this.produtosBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.produtosBindingSource.AddNew();
            }

            descriçãoTextBox.Focus();
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.produtosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.produtosBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.produtosBindingSource.RemoveCurrent();
                }
                else
                {
                    this.produtosBindingSource.Position = this.produtosBindingSource.Position;
                    this.produtosTableAdapter.Fill(this.bD_KWB_DataSet.Produtos);
                }
            }

            descriçãoTextBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.produtosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.produtosBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.produtosBindingSource.EndEdit();

                try
                {
                    this.produtosTableAdapter.Update(bD_KWB_DataSet.Produtos);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.produtosTableAdapter.Fill(this.bD_KWB_DataSet.Produtos);
                this.produtosBindingSource.Position = this.produtosBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.produtosBindingSource.MoveLast();
        }

        private void descriçãoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
