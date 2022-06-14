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
    public partial class FRMCLIE : Form
    {
        public FRMCLIE()
        {
            InitializeComponent();
        }

        private void FRMCLIE_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.banco_Dados_DataSet.Cliente);
        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);

            sexoComboBox.Items.Clear();
            sexoComboBox.Items.Add("Masculino");
            sexoComboBox.Items.Add("Feminino");

            nomeTextBox.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.clienteTableAdapter.FillByNome(banco_Dados_DataSet.Cliente, textBox1.Text);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            }
            else
            {
                this.clienteTableAdapter.Fill(this.banco_Dados_DataSet.Cliente);
            }
        }

        private void FRMCLIE_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
