using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysHeyLadybug
{
    public partial class formproduto : Form
    {
        public formproduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void formproduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.bDDataSet.Fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bDDataSet.Produto);

        }

        private void valor_CTextBox_Leave(object sender, EventArgs e)
        {
            if (valor_CTextBox.Text == "") 
            {
                MessageBox.Show("O Campo não pode ficar vazio!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                valor_CTextBox.Focus();
            }
            else
            {
                Decimal Valor = Convert.ToDecimal(valor_CTextBox.Text);
                valor_CTextBox.Text = String.Format("{0:C}", Valor);
            }
        }

        private void valor_VTextBox_Leave(object sender, EventArgs e)
        {
            if (valor_VTextBox.Text == "")
            {
                MessageBox.Show("O Campo não pode ficar vazio!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                valor_VTextBox.Focus();
            }
            else
            {
                Decimal Valor = Convert.ToDecimal(valor_VTextBox.Text);
                valor_VTextBox.Text = String.Format("{0:C}", Valor);
            }
        }

        private void valor_CTextBox_Enter(object sender, EventArgs e)
        {
            valor_CTextBox.Text = "";
        }

        private void valor_VTextBox_Enter(object sender, EventArgs e)
        {
            valor_VTextBox.Text = "";
        }
    }
}
