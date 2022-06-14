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
    public partial class frmProfessor : Form
    {
        bool Ocupado;

        public frmProfessor()
        {
            InitializeComponent();
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            this.professoresTableAdapter.Fill(this.bD_KWB_DataSet.Professores);

            if (this.professoresBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.professoresBindingSource.Count == 0)
            {
                this.professoresBindingSource.AddNew();
            }

            else if (this.professoresBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.professoresBindingSource.AddNew(); 
            }

            sexoComboBox.SelectedIndex = -1;
            estadoComboBox.SelectedIndex = -1;
            demitidoCheckBox.Checked = false;
            data_de_AdmissãoDateTimePicker.Value = DateTime.Now;
            nomeTextBox.Focus();     
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.professoresBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.professoresBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.professoresBindingSource.RemoveCurrent();
                }
                else
                {
                    this.professoresBindingSource.Position = this.professoresBindingSource.Position;
                    this.professoresTableAdapter.Fill(this.bD_KWB_DataSet.Professores);
                }
            }

            nomeTextBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (data_de_AdmissãoDateTimePicker.Text == "")
            {
                data_de_AdmissãoDateTimePicker.Value = DateTime.Now;
            }

            if (this.professoresBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.professoresBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.professoresBindingSource.EndEdit();

                try
                {
                    this.professoresTableAdapter.Update(bD_KWB_DataSet.Professores);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.professoresTableAdapter.Fill(this.bD_KWB_DataSet.Professores);
                this.professoresBindingSource.Position = this.professoresBindingSource.Position;  
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.professoresBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.professoresBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.professoresBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.professoresBindingSource.MoveLast();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo_Carregar = new OpenFileDialog();
            Dialogo_Carregar.ShowDialog();

            Bitmap Bit = new Bitmap(Dialogo_Carregar.FileName);

            Dialogo_Carregar.DefaultExt = "*.jpg";
            Dialogo_Carregar.Filter = "Imagem (*.jpg)|*.jpg";

            fotoPictureBox.Image = Bit;
        }

        private void DataPesquisar_Click(object sender, EventArgs e)
        {
            frmConsulta Consulta = new frmConsulta();
            Consulta.ShowDialog();
            Consulta.ProfessoresRadio.PerformClick();
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
