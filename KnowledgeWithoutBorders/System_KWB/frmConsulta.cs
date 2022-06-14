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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void Dados_TextChanged(object sender, EventArgs e)
        {
            if (ProfessoresRadio.Checked == true)
            {
                this.professoresTableAdapter.FillByNomeProfessor(bD_KWB_DataSet.Professores, Dados.Text);
            }
            else if (AlunosRadio.Checked == true)
            {
                this.alunosTableAdapter.FillByNomeAluno(bD_KWB_DataSet.Alunos, Dados.Text);
            }
            else if (LivrosRadio.Checked == true)
            {
                this.livrosTableAdapter.FillByTituloLivro(bD_KWB_DataSet.Livros, Dados.Text);
            }
        }

        private void Preencher()
        {
            NomeDados.Enabled = true;
            Dados.Enabled = true;
            Dados.Clear();
            Dados.Focus();
        }

        private void ProfessoresRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ProfessoresRadio.Checked == true)
            {
                NomeDados.Text = "Informe o nome do professor:";
                professoresTableAdapter.Fill(bD_KWB_DataSet.Professores);
                professoresDataGridView.Show();
            }
            else
            {
                professoresDataGridView.Hide();
            }

            Preencher();
        }

        private void AlunosRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (AlunosRadio.Checked == true)
            {
                NomeDados.Text = "Informe o nome do aluno:";
                alunosTableAdapter.Fill(bD_KWB_DataSet.Alunos);
                alunosDataGridView.Show();
            }
            else
            {
                alunosDataGridView.Hide();
            }

            Preencher();
        }

        private void LivrosRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (LivrosRadio.Checked == true)
            {
                NomeDados.Text = "Informe o nome do livro:";
                livrosTableAdapter.Fill(bD_KWB_DataSet.Livros);
                livrosDataGridView.Show();
            }
            else
            {
                livrosDataGridView.Hide();
            }

            Preencher();
        }
    }
}
