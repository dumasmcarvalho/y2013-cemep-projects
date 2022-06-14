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
    public partial class frmAluno : Form
    {
        bool Ocupado;

        public frmAluno()
        {
            InitializeComponent();
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            this.cursosTableAdapter.Fill(this.bD_KWB_DataSet.Cursos);
            this.alunosTableAdapter.Fill(this.bD_KWB_DataSet.Alunos);

            if (this.alunosBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

       private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.alunosBindingSource.Count == 0)
            {
                this.alunosBindingSource.AddNew();
            }

            else if (this.alunosBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.alunosBindingSource.AddNew(); 
            }

            nomeTextBox.Focus();
            sexoComboBox.SelectedIndex = -1;
            estadoComboBox.SelectedIndex = -1;
            cursoComboBox.SelectedIndex = -1;
            certificado_de_ConclusãoCheckBox.Checked = false;
            data_de_NascimentoDateTimePicker.Value = DateTime.Now;
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.alunosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.alunosBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.alunosBindingSource.RemoveCurrent();
                }
                else
                {
                    this.alunosBindingSource.Position = this.alunosBindingSource.Position;
                    this.alunosTableAdapter.Fill(this.bD_KWB_DataSet.Alunos);
                }
            }

            nomeTextBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (data_de_NascimentoDateTimePicker.Text == "")
            {
                data_de_NascimentoDateTimePicker.Value = DateTime.Now;
            }

            if (this.alunosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.alunosBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.alunosBindingSource.EndEdit();

                try
                {
                    this.alunosTableAdapter.Update(bD_KWB_DataSet.Alunos);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.alunosTableAdapter.Fill(this.bD_KWB_DataSet.Alunos);
                this.alunosBindingSource.Position = this.alunosBindingSource.Position;  
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.alunosBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.alunosBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.alunosBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.alunosBindingSource.MoveLast();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo_Carregar = new OpenFileDialog();

            if (Dialogo_Carregar.ShowDialog() == DialogResult.OK)
            {
                Bitmap Bit = new Bitmap(Dialogo_Carregar.FileName);

                Dialogo_Carregar.DefaultExt = "*.jpg";
                Dialogo_Carregar.Filter = "Imagem (*.jpg)|*.jpg";

                fotoPictureBox.Image = Bit;
            }
        }

        private void DataPesquisar_Click(object sender, EventArgs e)
        {
            frmConsulta Consulta = new frmConsulta();
            Consulta.ShowDialog();
            Consulta.AlunosRadio.PerformClick();
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
