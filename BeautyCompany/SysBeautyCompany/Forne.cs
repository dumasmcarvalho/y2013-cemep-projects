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
    public partial class FRMFORN : Form
    {
        public FRMFORN()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK);

        }

        private void FRMFORN_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.banco_Dados_DataSet.Fornecedor);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            razão_SocialTextBox.Focus();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.fornecedorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            }
            else
            {
                this.fornecedorTableAdapter.Fill(this.banco_Dados_DataSet.Fornecedor);
            }
        }

        private void FRMFORN_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
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
