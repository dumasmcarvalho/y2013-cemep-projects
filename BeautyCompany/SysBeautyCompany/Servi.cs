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
    public partial class FRMSERV : Form
    {
        public FRMSERV()
        {
            InitializeComponent();
        }

        private void Servi_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.banco_Dados_DataSet.Cliente);

            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.banco_Dados_DataSet.Funcionario);

            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Serviço'. Você pode movê-la ou removê-la conforme necessário.
            this.serviçoTableAdapter.Fill(this.banco_Dados_DataSet.Serviço);
        }

        private void serviçoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviçoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.serviçoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            }
            else
            {
                this.serviçoTableAdapter.Fill(this.banco_Dados_DataSet.Serviço);
            }
        }

        private void valorTextBox_Leave(object sender, EventArgs e)
        {
            if (valorTextBox.Text == "") valorTextBox.Text = "0";
            decimal Valor = Convert.ToDecimal(valorTextBox.Text);
            valorTextBox.Text = string.Format("{0:C}", Valor);
        }

        private void valorTextBox_Enter(object sender, EventArgs e)
        {
            valorTextBox.Text = "";
        }

        private void serviçosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviçoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK);
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviçoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);

            funcionarioComboBox.SelectedIndex = -1;
            clienteComboBox.SelectedIndex = -1;

            serviçoTextBox.Focus();
        }

        private void serviçoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
