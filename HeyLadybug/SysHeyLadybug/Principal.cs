using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysHeyLadybug
{
    public partial class formprin : Form
    {
        public void Fechar()
    {
       Application.Exit();
    }
        public formprin()
        {
            InitializeComponent();
            this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToShortTimeString() + "   ";

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void powerpointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpoint");
        }

        private void formprin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcaoSelecionada;
            opcaoSelecionada = MessageBox.Show("Deseja mesmo sair do sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcaoSelecionada.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsobre FORMSOBRE = new formsobre();
            FORMSOBRE.ShowDialog();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formmovimentacao FORMMOVIMENTACAO = new formmovimentacao();
            FORMMOVIMENTACAO.ShowDialog();
        }

        private void formprin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formcliente FORMCLIENTE = new formcliente();
            FORMCLIENTE.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formfuncionario FORMFUNCIONARIO = new formfuncionario();
            FORMFUNCIONARIO.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formproduto FORMPRODUTO = new formproduto();
            FORMPRODUTO.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formfornecedor FORMFORNECEDOR = new formfornecedor();
            FORMFORNECEDOR.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formestoque FORMESTOQUE = new formestoque();
            FORMESTOQUE.ShowDialog();
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendario CALENDARIO = new calendario();
            CALENDARIO.ShowDialog();
        }
    }
}
