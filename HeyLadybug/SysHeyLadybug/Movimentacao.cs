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
    public partial class formmovimentacao : Form
    {
        public formmovimentacao()
        {
            InitializeComponent();
        }

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void formmovimentacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDDataSet.Funcionario);
            // TODO: This line of code loads data into the 'bDDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.bDDataSet.Venda);
            // TODO: This line of code loads data into the 'bDDataSet.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.bDDataSet.Venda);

        }

        private void vendaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            dat_VendaDateTimePicker.Text = "";

        }

        private void valor_TTextBox_Leave(object sender, EventArgs e)
        {
            if (valor_TTextBox.Text == "")
            {
                MessageBox.Show("O Campo não pode ficar vazio!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                valor_TTextBox.Focus();
            }
            else
            {
                Decimal Valor = Convert.ToDecimal(valor_TTextBox.Text);
                valor_TTextBox.Text = String.Format("{0:C}", Valor);
            }
        }

        private void valor_TTextBox_Enter(object sender, EventArgs e)
        {
            valor_TTextBox.Text = "";
        }
    }
}