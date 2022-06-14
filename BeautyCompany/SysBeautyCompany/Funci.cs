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
    public partial class FRMFUNCI : Form
    {
        public FRMFUNCI()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if ((data_de_AdmissãoDateTimePicker.Text == DateTime.Now.ToShortDateString()) || (data_de_AdmissãoDateTimePicker.Text == "")) { data_de_AdmissãoDateTimePicker.Text = DateTime.Now.ToShortDateString(); }
            if ((data_de_NascimentoDateTimePicker.Text == DateTime.Now.ToShortDateString()) || (data_de_NascimentoDateTimePicker.Text == "")) { data_de_NascimentoDateTimePicker.Text = DateTime.Now.ToShortDateString(); }
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK);
        }

        private void FRMFUNCI_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_Dados_DataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.banco_Dados_DataSet.Funcionario);

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if ((data_de_AdmissãoDateTimePicker.Text == DateTime.Now.ToShortDateString()) || (data_de_AdmissãoDateTimePicker.Text == "")) { data_de_AdmissãoDateTimePicker.Text = DateTime.Now.ToShortDateString(); }
            if ((data_de_NascimentoDateTimePicker.Text == DateTime.Now.ToShortDateString()) || (data_de_NascimentoDateTimePicker.Text == "")) { data_de_NascimentoDateTimePicker.Text = DateTime.Now.ToShortDateString(); }

            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);

            cargoComboBox.SelectedIndex = -1;
            sexoComboBox.SelectedIndex = -1;

            data_de_AdmissãoDateTimePicker.Text = DateTime.Now.ToShortDateString();
            data_de_NascimentoDateTimePicker.Text = DateTime.Now.ToShortDateString();
            nomeTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.banco_Dados_DataSet);
            }
            else
            {
                this.funcionarioTableAdapter.Fill(this.banco_Dados_DataSet.Funcionario);
            }
        }

        private void FRMFUNCI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.FillByNome(banco_Dados_DataSet.Funcionario, textBox1.Text);
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
