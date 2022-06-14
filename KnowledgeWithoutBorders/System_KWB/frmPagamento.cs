using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace System_KWB
{
    public partial class frmPagamento : Form
    {
        bool Ocupado;
        Control Campo = new Control();

        static double Salario_Bruto;
        static double Descontos;
        static double Valor_Hora;
        static double Horas_Trabalhadas;
        static double Horas_Extras;
        static double Salario_Liquido;

        public frmPagamento()
        {
            InitializeComponent();
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            this.professoresTableAdapter.Fill(this.bD_KWB_DataSet.Professores);
            this.pagamento_do_ProfessorTableAdapter.Fill(this.bD_KWB_DataSet.Pagamento_do_Professor);

            if (pagamento_do_ProfessorBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }

            descontosTextBox.Text = string.Format("{0:C2}", descontosTextBox.Text);
            salario_LiquidoTextBox.Text = string.Format("{0:C2}", salario_LiquidoTextBox.Text);
        }

        private void nome_do_ProfessorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = nome_do_ProfessorComboBox.SelectedIndex;
            código_do_ProfessorComboBox.SelectedIndex = x;
            conta_BancariaComboBox.SelectedIndex = x;
            agênciaComboBox.SelectedIndex = x;
            nome_da_AgênciaComboBox.SelectedIndex = x;
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.pagamento_do_ProfessorBindingSource.Count == 0)
            {
                this.pagamento_do_ProfessorBindingSource.AddNew();
            }

            else if (this.pagamento_do_ProfessorBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.pagamento_do_ProfessorBindingSource.AddNew();
            }

            nome_do_ProfessorComboBox.Focus();
            nome_do_ProfessorComboBox.SelectedIndex = -1;
            nome_da_AgênciaComboBox.SelectedIndex = -1;
            código_do_ProfessorComboBox.SelectedIndex = -1;
            conta_BancariaComboBox.SelectedIndex = -1;
            agênciaComboBox.SelectedIndex = -1;
            nome_da_AgênciaComboBox.SelectedIndex = -1;
            horas_TrabalhadasNumericUpDown.Value = 0;
            data_de_PagamentoDateTimePicker.Value = DateTime.Now;
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.pagamento_do_ProfessorBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.pagamento_do_ProfessorBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.pagamento_do_ProfessorBindingSource.RemoveCurrent();
                }
                else
                {
                    this.pagamento_do_ProfessorBindingSource.Position = this.pagamento_do_ProfessorBindingSource.Position;
                    this.pagamento_do_ProfessorTableAdapter.Fill(this.bD_KWB_DataSet.Pagamento_do_Professor);
                }
            }

            nome_do_ProfessorComboBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (data_de_PagamentoDateTimePicker.Text == "")
            {
                data_de_PagamentoDateTimePicker.Value = DateTime.Now;
            }

            if (this.pagamento_do_ProfessorBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.pagamento_do_ProfessorBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.pagamento_do_ProfessorBindingSource.EndEdit();

                try
                {
                    this.pagamento_do_ProfessorTableAdapter.Update(bD_KWB_DataSet.Pagamento_do_Professor);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.pagamento_do_ProfessorTableAdapter.Fill(this.bD_KWB_DataSet.Pagamento_do_Professor);
                this.pagamento_do_ProfessorBindingSource.Position = this.pagamento_do_ProfessorBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.pagamento_do_ProfessorBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.pagamento_do_ProfessorBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.pagamento_do_ProfessorBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.pagamento_do_ProfessorBindingSource.MoveLast();
        }

        private void salario_BrutoTextBox_Enter(object sender, EventArgs e)
        {
            salario_BrutoTextBox.Clear();
        }

        private void salario_BrutoTextBox_Leave(object sender, EventArgs e)
        {
            if (salario_BrutoTextBox.Text == "")
            {
                salario_BrutoTextBox.Text = "0";
            }
        }

        private void valor_da_HoraTextBox_Enter(object sender, EventArgs e)
        {
            valor_da_HoraTextBox.Clear();
        }

        private void valor_da_HoraTextBox_Leave(object sender, EventArgs e)
        {
            if (valor_da_HoraTextBox.Text == "")
            {
                valor_da_HoraTextBox.Text = "0";
            }
        }

        private void horas_ExtrasTextBox_Enter(object sender, EventArgs e)
        {
            horas_ExtrasTextBox.Clear();
        }

        private void horas_ExtrasTextBox_Leave(object sender, EventArgs e)
        {
            if (horas_ExtrasTextBox.Text == "")
            {
                horas_ExtrasTextBox.Text = "0";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Valor_Hora = Convert.ToDouble(valor_da_HoraTextBox.Text);
                Horas_Trabalhadas = Convert.ToDouble(horas_TrabalhadasNumericUpDown.Value);
                Salario_Bruto = Convert.ToDouble(salario_BrutoTextBox.Text);
                Horas_Extras = Convert.ToDouble(horas_ExtrasTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Algum campo está vazio!");
            }

            try
            {
                Salario_Liquido = (Salario_Bruto + Horas_Extras + (Valor_Hora * Horas_Trabalhadas) - Descontos);
                descontosTextBox.Text = string.Format("{0:C2}", Descontos);
                salario_LiquidoTextBox.Text = string.Format("{0:C2}", Salario_Liquido);
            }
            catch(Exception)
            {
                MessageBox.Show("Algum campo possui valor inválido!");
            }
        }

        private void salario_BrutoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(salario_BrutoTextBox.Text, out Salario_Bruto))
            {
                Descontos = (Salario_Bruto * 0.05);
                descontosTextBox.Text = string.Format("{0:C2}", Descontos);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            salario_BrutoTextBox.Focus();

            salario_BrutoTextBox.Clear();
            Salario_Bruto = 0;
            descontosTextBox.Clear();
            Descontos = 0;
            horas_TrabalhadasNumericUpDown.Value = 0;
            Horas_Trabalhadas = 0;
            valor_da_HoraTextBox.Clear();
            Valor_Hora = 0;
            horas_ExtrasTextBox.Clear();
            Horas_Extras = 0;
            salario_LiquidoTextBox.Clear();
            Salario_Liquido = 0;
        }

        private void nome_do_ProfessorComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
