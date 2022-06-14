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
    public partial class FRMPAGAM : Form
    {
        public FRMPAGAM()
        {
            InitializeComponent();
        }

        private void Pagam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (dataDateTimePicker.Text == DateTime.Now.ToShortDateString()) { dataDateTimePicker.Text = DateTime.Now.ToShortDateString(); }
            this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK);
        }

        private void FRMPAGAM_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.banco_Dados_DataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Pagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentoTableAdapter.Fill(this.banco_Dados_DataSet.Pagamento);

        }

        /* 
         * Explicação do uso do For
         * 
         * São dois ComboBoxes
         * Um para o ID e o outro para o Nome do Cliente
         * Em ambos, existe a relação de tabelas
         * Onde quando se escolhe o ID x, automaticamente seleciona o index x do ComboBox do Nome
         * A programação é feita na troca de Index
         *
         * */

        private void iD_ClienteComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

          // int x = iD_ClienteComboBox.SelectedIndex;
          // nomeComboBox.SelectedIndex = x;

            for (int x = 0; x <= iD_ClienteComboBox.Items.Count; x++)
            {                
                if (iD_ClienteComboBox.SelectedIndex == x) { nomeComboBox.SelectedIndex = x; }
                if (iD_ClienteComboBox.SelectedIndex == 2) { nomeComboBox.SelectedIndex = 2; }
                if (iD_ClienteComboBox.SelectedIndex == 3) { nomeComboBox.SelectedIndex = 3; }
            }
        }

        private void nomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int x = nomeComboBox.SelectedIndex;
           // iD_ClienteComboBox.SelectedIndex = x;


            for (int x = 0; x <= nomeComboBox.Items.Count; x++)
            {
                if (nomeComboBox.SelectedIndex == x) { iD_ClienteComboBox.SelectedIndex = x; }
                if (nomeComboBox.SelectedIndex == 2) { iD_ClienteComboBox.SelectedIndex = 2; }
                if (nomeComboBox.SelectedIndex == 3) { iD_ClienteComboBox.SelectedIndex = 3; }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.pagamentoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            }
            else
            {
                this.pagamentoTableAdapter.Fill(this.banco_Dados_DataSet.Pagamento);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dataDateTimePicker.Text == DateTime.Now.ToShortDateString()) { dataDateTimePicker.Text = DateTime.Now.ToShortDateString(); }

            this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);

            iD_ClienteComboBox.SelectedIndex = -1;

            forma_PagamentoComboBox.SelectedIndex = -1;

            dataDateTimePicker.Text = DateTime.Now.ToShortDateString();

            iD_ClienteComboBox.Focus();
        }

        private void iD_ClienteComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
