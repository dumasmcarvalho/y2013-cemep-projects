using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace System_KWB
{
    public partial class frmPrincipal : Form
    {
        int Ferramenta = 0;
        bool Confirmar;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblDescrição.Text = null;
            Confirmar = true;
            string Nível = lblNivel.Text;

            switch (Nível)
            {
                case "Aluno":
                {
                    cadastroToolStripMenuItem.Enabled = false;
                    cadastroToolStripMenuItem1.Enabled = false;
                    alunosToolStripButton.Enabled = false;
                    cursosToolStripButton.Enabled = false;
                    professoresToolStripButton.Enabled = false;

                    pagamentoToolStripMenuItem.Enabled = false;
                    pagamentoToolStripMenuItem1.Enabled = false;
                    mensalidadesToolStripButton.Enabled = false;
                    saláriosToolStripButton.Enabled = false;

                    bibliotecaToolStripMenuItem.Enabled = false;
                    bibliotecaToolStripMenuItem1.Enabled = false;
                    livrosToolStripButton.Enabled = false;
                    aluguelToolStripButton.Enabled = false;
                    pedidosToolStripButton.Enabled = false;
                    break;
                }

                case "Professor":
                {
                    pagamentoToolStripMenuItem.Enabled = false;
                    pagamentoToolStripMenuItem1.Enabled = false;
                    mensalidadesToolStripButton.Enabled = false;
                    saláriosToolStripButton.Enabled = false;
                    break;
                }
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToLongTimeString() + "\n" + DateTime.Now.ToShortDateString();
        }

        public void Chamar_Ferramenta()
        {
            switch (Ferramenta)
            {
                case 1:
                {
                    System.Diagnostics.Process.Start("notepad");
                    break;
                }
                case 2:
                {
                    System.Diagnostics.Process.Start("calc");
                    break;
                }
                case 3:
                {
                    System.Diagnostics.Process.Start("explorer");
                    break;
                }
                case 4:
                {
                    System.Diagnostics.Process.Start("chrome");
                    break;
                }
                case 5:
                {
                    System.Diagnostics.Process.Start("excel");
                    break;
                }
                case 6:
                {
                    System.Diagnostics.Process.Start("winword");
                    break;
                }
            }
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ferramenta = 1;
            Chamar_Ferramenta();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ferramenta = 2;
            Chamar_Ferramenta();
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ferramenta = 3;
            Chamar_Ferramenta();
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ferramenta = 4;
            Chamar_Ferramenta();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ferramenta = 5;
            Chamar_Ferramenta();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ferramenta = 6;
            Chamar_Ferramenta();
        }


        private void pesquisarToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Link = "http://google.com/search?q=" + pesquisarToolStripTextBox.Text;

                    // Link no Navegador Externo
                
                // System.Diagnostics.Process.Start("http://google.com/search?q=" + pesquisarToolStripTextBox.Text);

                    // Documentos no Navegador Interno

                // StreamReader SR = new StreamReader(Arquivo .CHM e Outros);
                // Navegador.DocumentStream = SR.BaseStream;

                    // Links no Navegador Internet

                Navegador.Navigate(Link);

                pesquisarToolStripTextBox.Text = null;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dialogo_Salvar = new SaveFileDialog();

            Dialogo_Salvar.DefaultExt = "*.txt";
            Dialogo_Salvar.Filter = "Documentos de Texto (*.txt)|*.txt";

            if (Dialogo_Salvar.ShowDialog() == System.Windows.Forms.DialogResult.OK && Dialogo_Salvar.FileName.Length > 0)
            {
                anotaçõesRichTextBox.SaveFile(Dialogo_Salvar.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
               OpenFileDialog Dialogo_Carregar = new OpenFileDialog();

               Dialogo_Carregar.DefaultExt = "*.txt";
               Dialogo_Carregar.Filter = "Documentos de Texto (*.txt)|*.txt";

               if(Dialogo_Carregar.ShowDialog() == System.Windows.Forms.DialogResult.OK && Dialogo_Carregar.FileName.Length > 0) 
               {
                  anotaçõesRichTextBox.LoadFile(Dialogo_Carregar.FileName, RichTextBoxStreamType.PlainText);
               }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            anotaçõesRichTextBox.Clear();
            anotaçõesRichTextBox.Focus();
        }

        private void professoresToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastro de Professores";
        }

        private void cursosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastro de Cursos e suas\nDisciplinas";
        }

        private void alunosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastro de Alunos";
        }

        private void mensalidadesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Mensalidade dos Alunos";
        }

        private void saláriosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Salário dos Professores";
        }

        private void livrosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastro de Livros";
        }

        private void pedidosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Requerimento de Livros";
        }

        private void aluguelToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Locação de Livros";
        }

        private void cantinaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Movimentação Financeira\nda Cantina";
        }

        private void fornecedoresToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastro de Fornecedores";
        }

        private void estoqueToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Informações do Estoque\nde Cada Produto";
        }

        private void itensToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastro de Produtos\nda Cantina";
        }

        private void blocoDeNotasToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Abre o Bloco de Notas";
        }

        private void calculadoraToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Abre a Calculadora";
        }

        private void explorerToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Abre o Navegador de Pastas";
        }

        private void internetToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Abre o Navegador de Internet";
        }

        private void officeToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Exibe Algumas Ferramentas do\nMicrosoft Office";
        }

        private void excelToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Abre o Criador/Editor de\nPlanilhas: Excel";
        }

        private void wordToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Abre o Criador/Editor de\nTextos: Word";
        }

        private void pagamentoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Movimento Financeiro\n de Alunos e Professores";
        }

        private void cadastroToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastros de Professores, Cursos\nDisciplinas, Alunos";
        }

        private void bibliotecaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Cadastros Relacionados a\nBiblioteca e seus Livros";
        }

        private void vendasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Movimentação Financeira da\nCantina, Produtos e Estoque";
        }

        private void ferramentasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Algumas Ferramentas do Sistema";
        }

        private void sobreOSistemaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Algumas Informações\nAdicionais do Sistema";
        }

        private void logoutEncerrarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Encerra ou Efetua\nLogout do Sistema";
        }

        private void consultaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            lblDescrição.Text = "Abre a Janela para\nConsulta de Dados";
        }

        public void Chamar_Saida()
        {

            frmMensagem.Show("Deseja encerrar o sistema ou efetuar logout deste usuário?", "Text", "Encerrar", "Logout", "Cancelar");

            switch (frmMensagem.Escolha)
            {
                case 1:
                {
                    Confirmar = false;
                    frmLogin Login = new frmLogin();
                    Login.Show();
                    this.Hide();
                    break;
                }

                case 2:
                {
                    Application.ExitThread();
                    break;
                }

                case 3:
                {
                    Confirmar = true;
                    this.Show();
                    break;
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmar = false;
            Chamar_Saida();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Confirmar == true)
            {
                frmMensagem.Show("Deseja encerrar o sistema ou efetuar logout deste usuário?", "Text", "Encerrar", "Logout", "Cancelar");

                switch (frmMensagem.Escolha)
                {
                    case 1:
                    {
                        e.Cancel = true;
                        Confirmar = false;
                        frmLogin Login = new frmLogin();
                        Login.Show();
                        this.Hide();
                        break;
                    }

                    case 2:
                    {
                        Application.ExitThread();
                        break;
                    }

                    case 3:
                    {
                        e.Cancel = true;
                        this.Show();
                        break;
                    }
                }
            }
        }

        private void frmPrincipal_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\Arquivo_Ajuda\Ajuda.hlp");
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessor Professor = new frmProfessor();
            Professor.ShowDialog();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno Aluno = new frmAluno();
            Aluno.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso Curso = new frmCurso();
            Curso.ShowDialog();
        }

        private void mensalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMensalidade Mensalidade = new frmMensalidade();
            Mensalidade.ShowDialog();
        }

        private void saláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamento Pagamento = new frmPagamento();
            Pagamento.ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro Livro = new frmLivro();
            Livro.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedido Pedido = new frmPedido();
            Pedido.ShowDialog();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocação Aluguel = new frmLocação();
            Aluguel.ShowDialog();
        }

        private void cantinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCantina Cantina = new frmCantina();
            Cantina.ShowDialog();
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto Produto = new frmProduto();
            Produto.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor Fornecedor = new frmFornecedor();
            Fornecedor.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque Estoque = new frmEstoque();
            Estoque.ShowDialog();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            Sobre.ShowDialog();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsulta Consulta = new frmConsulta();
            Consulta.ShowDialog();
        }
    }
}
