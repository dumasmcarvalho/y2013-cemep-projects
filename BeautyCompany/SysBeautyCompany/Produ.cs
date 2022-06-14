using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysBeautyCompany
{
    public partial class FRMPROD : Form
    {
        public FRMPROD()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK);
        }

        private void FRMMOV_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.banco_Dados_DataSet.Produto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Valor_Compra = Convert.ToDecimal(valor_CompraTextBox.Text);

            decimal Valor_Reajuste = (Valor_Compra * ((reajusteNumericUpDown.Value / 100))) + Convert.ToDecimal(valor_CompraTextBox.Text);
            valor_VendaTextBox.Text = string.Format("{0:C2}", Valor_Reajuste);

            decimal Valor_Total = Valor_Reajuste * quantidadeNumericUpDown.Value;
            valor_TotalTextBox.Text = string.Format("{0:C2}", Valor_Total);
        }

        private void valor_CompraTextBox_Enter(object sender, EventArgs e)
        {
            valor_CompraTextBox.Text = "";
        }

        private void valor_CompraTextBox_Leave(object sender, EventArgs e)
        {
            if (valor_CompraTextBox.Text == "") valor_CompraTextBox.Text = "0"; 
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            quantidadeNumericUpDown.Value = 0;
            reajusteNumericUpDown.Value = 0;
            produtoTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.produtoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            }
            else
            {
                this.produtoTableAdapter.Fill(this.banco_Dados_DataSet.Produto);
            }
        }

        private void produtoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
