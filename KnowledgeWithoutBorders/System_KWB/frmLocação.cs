using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace System_KWB
{
    public partial class frmLocação : Form
    {
        bool Ocupado;

        public frmLocação()
        {
            InitializeComponent();
        }

        private void frmAluguel_Load(object sender, EventArgs e)
        {
            this.alunosTableAdapter.Fill(this.bD_KWB_DataSet.Alunos);
            this.livrosTableAdapter.Fill(this.bD_KWB_DataSet.Livros);
            this.locaçãoTableAdapter.Fill(this.bD_KWB_DataSet.Locação);

            /*
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            */

            if (locaçãoBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }

            Inserir();
        }

        private void Inserir()
        {
            string SQL = "SELECT Titulo FROM Livros WHERE (Alugado = True)";
            Conexão Conexão = new Conexão();
            OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conexão._Conexão);

            Conexão.Conectar();

            DataSet DataSet = new DataSet();
            Adapter.Fill(DataSet, "Livros");

            titulo_do_LivroComboBox.DataSource = DataSet.Tables["Livros"];
            titulo_do_LivroComboBox.DisplayMember = "Titulo";
            titulo_do_LivroComboBox.ValueMember = "Titulo";

            titulo_do_LivroComboBox.SelectedIndex = -1;
            codigo_do_LivroComboBox.SelectedIndex = -1;
            taxa_de_AtrasoComboBox.SelectedIndex = -1;

            Conexão.Desconectar();

            titulo_do_LivroComboBox.Focus();
        }

        private void titulo_do_LivroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = titulo_do_LivroComboBox.SelectedIndex;
            codigo_do_LivroComboBox.SelectedIndex = x;
            taxa_de_AtrasoComboBox.SelectedIndex = x;
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.locaçãoBindingSource.Count == 0)
            {
                this.locaçãoBindingSource.AddNew();
            }

            else if (this.locaçãoBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.locaçãoBindingSource.AddNew();
            }

            Inserir();
            titulo_do_LivroComboBox.SelectedIndex = -1;
            codigo_do_LivroComboBox.SelectedIndex = -1;
            taxa_de_AtrasoComboBox.SelectedIndex = -1;
            nome_do_AlunoComboBox.SelectedIndex = -1;
            matrícula_do_AlunoComboBox.SelectedIndex = -1;
            data_de_EntregaDateTimePicker.Value = DateTime.Now.Date;
            data_de_RetiradaDateTimePicker.Value = DateTime.Now.Date;
            titulo_do_LivroComboBox.Focus();
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.locaçãoBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.locaçãoBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.locaçãoBindingSource.RemoveCurrent();
                }
                else
                {
                    this.locaçãoBindingSource.Position = this.locaçãoBindingSource.Position;
                    this.locaçãoTableAdapter.Fill(this.bD_KWB_DataSet.Locação);
                }
            }

            titulo_do_LivroComboBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (data_de_RetiradaDateTimePicker.Text == "")
            {
                data_de_RetiradaDateTimePicker.Value = DateTime.Now;
            }

            if (data_de_EntregaDateTimePicker.Text == "")
            {
                data_de_EntregaDateTimePicker.Value = DateTime.Now;
            }

            if (this.locaçãoBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.locaçãoBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.locaçãoBindingSource.EndEdit();

                try
                {
                    this.locaçãoTableAdapter.Update(bD_KWB_DataSet.Locação);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.locaçãoTableAdapter.Fill(this.bD_KWB_DataSet.Locação);
                this.locaçãoBindingSource.Position = this.locaçãoBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.locaçãoBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.locaçãoBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.locaçãoBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.locaçãoBindingSource.MoveLast();
        }

        private void nome_do_AlunoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = nome_do_AlunoComboBox.SelectedIndex;
            matrícula_do_AlunoComboBox.SelectedIndex = x;
        }

        private void titulo_do_LivroComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void data_de_RetiradaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            data_de_EntregaDateTimePicker.Value = DateTime.Now;
        }

        private void data_de_EntregaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (data_de_EntregaDateTimePicker.Value < data_de_RetiradaDateTimePicker.Value)
            {
                MessageBox.Show(this, "A data de retirada não pode ser superior a data de entrega!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                data_de_RetiradaDateTimePicker.Value = DateTime.Now;
                data_de_RetiradaDateTimePicker.Focus();
            }
        }
    }
}
