using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System_KWB
{
    public partial class frmMensalidade : Form
    {
        bool Ocupado;

        public frmMensalidade()
        {
            InitializeComponent();
        }

        private void frmMensalidade_Load(object sender, EventArgs e)
        {
            this.cursosTableAdapter.Fill(this.bD_KWB_DataSet.Cursos);
            this.alunosTableAdapter.Fill(this.bD_KWB_DataSet.Alunos);
            this.pagamento_do_AlunoTableAdapter.Fill(this.bD_KWB_DataSet.Pagamento_do_Aluno);

            if (pagamento_do_AlunoBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        private void código_do_CursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = código_do_CursoComboBox.SelectedIndex;
            nome_do_CursoComboBox.SelectedIndex = x;
        }

        private void nome_do_AlunoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = nome_do_CursoComboBox.SelectedIndex;
            matrícula_do_AlunoComboBox.SelectedIndex = x;
            código_do_CursoComboBox.SelectedIndex = x;
            ano_do_CursoComboBox.SelectedIndex = x;
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.pagamento_do_AlunoBindingSource.Count == 0)
            {
                this.pagamento_do_AlunoBindingSource.AddNew();
            }

            else if (this.pagamento_do_AlunoBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.pagamento_do_AlunoBindingSource.AddNew();
            }

            nome_do_AlunoComboBox.Focus();
            nome_do_AlunoComboBox.SelectedIndex = -1;
            nome_do_CursoComboBox.SelectedIndex = -1;
            matrícula_do_AlunoComboBox.SelectedIndex = -1;
            código_do_CursoComboBox.SelectedIndex = -1;
            ano_do_CursoComboBox.SelectedIndex = -1;
            forma_de_PagamentoComboBox.SelectedIndex = -1;
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.pagamento_do_AlunoBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.pagamento_do_AlunoBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.pagamento_do_AlunoBindingSource.RemoveCurrent();
                }
                else
                {
                    this.pagamento_do_AlunoBindingSource.Position = this.pagamento_do_AlunoBindingSource.Position;
                    this.pagamento_do_AlunoTableAdapter.Fill(this.bD_KWB_DataSet.Pagamento_do_Aluno);
                }
            }

            nome_do_AlunoComboBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.pagamento_do_AlunoBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.pagamento_do_AlunoBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.pagamento_do_AlunoBindingSource.EndEdit();

                try
                {
                    this.pagamento_do_AlunoTableAdapter.Update(bD_KWB_DataSet.Pagamento_do_Aluno);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.pagamento_do_AlunoTableAdapter.Fill(this.bD_KWB_DataSet.Pagamento_do_Aluno);
                this.pagamento_do_AlunoBindingSource.Position = this.pagamento_do_AlunoBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.pagamento_do_AlunoBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.pagamento_do_AlunoBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.pagamento_do_AlunoBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.pagamento_do_AlunoBindingSource.MoveLast();
        }

        private void valorTextBox_Enter(object sender, EventArgs e)
        {
            valorTextBox.Clear();
        }

        private void valorTextBox_Leave(object sender, EventArgs e)
        {
            if (valorTextBox.Text == "")
            {
                valorTextBox.Text = "0";
            }
        }

        private void nome_do_AlunoComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
