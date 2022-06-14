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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcaoSelecionada;
            opcaoSelecionada = MessageBox.Show("Deseja realmente sair do sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcaoSelecionada.Equals(DialogResult.No))
            {
                e.Cancel = true;
                textUsuario.Focus();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void buttonEntrar_Click(object sender, EventArgs e)
        {
            // A Query será a função SQL para selecionar aquilo que queremos
            string Query = "SELECT * FROM Login WHERE Usuário = @Usuário and Senha = @Senha";

            // Criar uma conexão, e em seguida conecta-la
            Conexão Conexão = new Conexão();
            Conexão.Conectar();

            // OleDbCommand será o comando a ser utilizado, queremeos selecionar algo, então o comoando deve possuir a (Query, Conexão)
            OleDbCommand Comando = new OleDbCommand(Query, Conexão._Conexão);

            // Neste momento estamos adicionando os parametros @Usuário será o campo SQL representativo da textUsuário
            Comando.Parameters.AddWithValue("@Usuário", textUsuario.Text);
            Comando.Parameters.AddWithValue("@Senha", textSenha.Text);

            // OleDbDataReader será uma forma de validar se foi encontrado ou não o campo selecionado pela Query, Comando.ExecuteReader() será
            // o método a ser executado
            OleDbDataReader Validação = Comando.ExecuteReader();

            // Este if sera a comparação se o comando foi validado ou não
            if (Validação.Read())
            {
                // Se a validação for valida, iremos buscar o método da classe Autenticação.Login, porém desta vez no () sera adicionado os valores
                // correspondentes ao nome do campo das tabelas
                Autenticação.Login(Validação["Usuário"].ToString(), Validação["Senha"].ToString(), Validação["Nível de Cadastro"].ToString());

                MessageBox.Show("Logado com sucesso", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // this.Dispose();
                this.Hide();
                frmPrincipal Principal = new frmPrincipal();
                Principal.lblUsuario.Text = Autenticação.Exibir_Usuario();
                Principal.lblNivel.Text = Autenticação.Exibir_Nível();
                Principal.Show();
            }
            else
            {
                // Caso ele não for validado, ocorrerá a mensagem de erro e todos campos serão limpos com o foco para o textUsuário
                MessageBox.Show("Usuário e/ou senha não encontrados", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textUsuario.Focus();
                textUsuario.Text = "";
                textSenha.Text = "";
            }
        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro Cadastro = new frmCadastro();
            Cadastro.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperação Recuperação = new frmRecuperação();
            Recuperação.ShowDialog();
        }
    }
}
