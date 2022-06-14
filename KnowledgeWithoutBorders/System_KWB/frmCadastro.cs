using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace System_KWB
{
    public partial class frmCadastro : Form
    {
        bool Ocupado, Salvar, Adicionar;
        Control Campo = new Control();

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            this.loginTableAdapter.Fill(this.bD_KWB_DataSet.Login);

            if (loginBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        public void Validação_Dados()
        {
            if (usuárioTextBox.Text == "")
            {
                Campo = usuárioTextBox;
                usuárioTextBox.Focus();
                Usuario_Vazio();
            }

            else if (senhaTextBox.Text == "")
            {
                Campo = senhaTextBox;
                senhaTextBox.Focus();
                Senha_Vazia();
            }

            else if (confirmar_SenhaTextBox.Text == "")
            {
                Campo = confirmar_SenhaTextBox;
                confirmar_SenhaTextBox.Focus();
                Senha_Vazia();
            }

            else if (senhaTextBox.Text != confirmar_SenhaTextBox.Text)
            {
                Campo = confirmar_SenhaTextBox;
                confirmar_SenhaTextBox.Focus();
                Senha_Diferente();
            }

            else if (nível_de_CadastroComboBox.SelectedIndex == -1)
            {
                Campo = nível_de_CadastroComboBox;
                nível_de_CadastroComboBox.Focus();
                Nível_Vazio();
            }

            else if (emailTextBox.Text == "")
            {
                Campo = emailTextBox;
                emailTextBox.Focus();
                Email_Vazio();
            }

            else if (Adicionar == true)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.loginBindingSource.EndEdit();

                try
                {
                    this.loginTableAdapter.Update(bD_KWB_DataSet.Login);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar!" + ex);
                }

                Ocupado = false;

                this.loginTableAdapter.Fill(this.bD_KWB_DataSet.Login);
                this.loginBindingSource.Position = this.loginBindingSource.Position;

                this.loginBindingSource.AddNew();
                nível_de_CadastroComboBox.SelectedIndex = -1;
            }

            else if (Salvar == true)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.loginBindingSource.EndEdit();

                try
                {
                    this.loginTableAdapter.Update(bD_KWB_DataSet.Login);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar!" + ex);
                }

                Ocupado = false;

                this.loginTableAdapter.Fill(this.bD_KWB_DataSet.Login);
                this.loginBindingSource.Position = this.loginBindingSource.Position;
            }
        }

        public void Nível_Vazio()
        {
            Mensagem.ToolTipTitle = "Nível de Cadastro Vazio";
            Mensagem.ToolTipIcon = ToolTipIcon.Error;
            Mensagem.Show("O nível de cadastro não pode estar em branco", Campo, Campo.Width, Campo.Height);
        }

        public void Senha_Vazia()
        {
             Mensagem.ToolTipTitle = "Senha Vazia";
             Mensagem.ToolTipIcon = ToolTipIcon.Error;
             Mensagem.Show("A senha não pode estar em branco", Campo, Campo.Width, Campo.Height);
        }

        public void Senha_Diferente()
        {
            Mensagem.ToolTipTitle = "Senhas Diferentes";
            Mensagem.ToolTipIcon = ToolTipIcon.Error;
            Mensagem.Show("A senha informada não corresponde com a anterior", Campo, Campo.Width, Campo.Height);
            Campo.BackColor = Color.FromArgb(240, 50, 50);
            Campo.Text = null;
        }

        public void Email_Vazio()
        {
            Mensagem.ToolTipTitle = "Email Vazio";
            Mensagem.ToolTipIcon = ToolTipIcon.Error;
            Mensagem.Show("O email não pode estar em branco", Campo, Campo.Width, Campo.Height);
        }

        public void Usuario_Vazio()
        {
            Mensagem.ToolTipTitle = "Usuário Vazio";
            Mensagem.ToolTipIcon = ToolTipIcon.Error;
            Mensagem.Show("O usuário não pode estar em branco", Campo, Campo.Width, Campo.Height);
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.loginBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.loginBindingSource.Count > 0)
            {
                Adicionar = false;
                Salvar = true;
                Validação_Dados();
            }
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.loginBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.loginBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Remover Registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.loginBindingSource.RemoveCurrent();
                }

                else
                {
                    this.loginBindingSource.Position = this.loginBindingSource.Count;
                    this.loginTableAdapter.Fill(this.bD_KWB_DataSet.Login);
                }
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.loginBindingSource.Count == 0)
            {
                this.loginBindingSource.AddNew();
            }

            else if (this.loginBindingSource.Count > 0)
            {
               Salvar = true;
               Adicionar = true;
               Validação_Dados();
            }
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.MoveLast();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.MoveNext();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.MovePrevious();
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.loginBindingSource.MoveFirst();
        }

        private void confirmar_SenhaTextBox_Leave(object sender, EventArgs e)
        {
            if (confirmar_SenhaTextBox.Text != senhaTextBox.Text)
            {
                Mensagem.ToolTipTitle = "Senhas Inválidas";
                Mensagem.Show("A senha informada não corresponde com a anterior", confirmar_SenhaTextBox, confirmar_SenhaTextBox.Width, confirmar_SenhaTextBox.Height);
                confirmar_SenhaTextBox.BackColor = Color.FromArgb(240, 50, 50);
                confirmar_SenhaTextBox.Text = null;
                confirmar_SenhaTextBox.Focus();
            }
            else
            {
                Mensagem.Hide(confirmar_SenhaTextBox);
                confirmar_SenhaTextBox.BackColor = Color.White;
            }
        }

        private void frmCadastro_MouseHover(object sender, EventArgs e)
        {
            Mensagem.Hide(this);
        }

        private void nível_de_CadastroComboBox_Leave(object sender, EventArgs e)
        {
            if (nível_de_CadastroComboBox.SelectedIndex == 3)
            {
                string Senha = Microsoft.VisualBasic.Interaction.InputBox("Informe a senha do sistema: ", "Mensagem do Sistema");

                if (Senha == "10092506")
                {
                    MessageBox.Show("Senha correta, o nível desenvolvedor pode ser usado!");
                }

                else
                {
                    MessageBox.Show("Senha incorreta, o nível desenvolvedor não pode ser usado!");
                    nível_de_CadastroComboBox.SelectedIndex = -1;
                }
            }
        }

        private void usuárioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
