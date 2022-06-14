using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysBeautyCompany
{
    public partial class FRMPRIN : Form
    {
        public FRMPRIN()
        {
            InitializeComponent();
            this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void calendárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendario();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios();
        }


        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores();
        }

        private void sobreSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Fechar();
        }

        public void Fechar()
        {
            Application.Exit();
        }

        public void Clientes()
        {
            FRMCLIE FRMClie = new FRMCLIE();
            FRMClie.ShowDialog();
        }

        public void Funcionarios()
        {
            FRMFUNCI FRMFunci = new FRMFUNCI();
            FRMFunci.ShowDialog();
        }

        public void Fornecedores()
        {
            FRMFORN FRMForn = new FRMFORN();
            FRMForn.ShowDialog();
        }

        public void Sobre()
        {
            FRMSOBRE FRMSobre = new FRMSOBRE();
            FRMSobre.ShowDialog();
        }

        public void Produtos()
        {
            FRMPROD FRMProd = new FRMPROD();
            FRMProd.ShowDialog();
        }

        public void Calendario()
        {
            FRMCALEND FRMCalend = new FRMCALEND();
            FRMCalend.ShowDialog();
        }

        public void Pagamento()
        {
            FRMPAGAM FRMPagam = new FRMPAGAM();
            FRMPagam.ShowDialog();
        }

        public void Serviços()
        {
            FRMSERV FRMServ = new FRMSERV();
            FRMServ.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fechar();
        }

        private void sobreOSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sobre();
        }

        private void blocoDeNotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void calendárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calendario();
        }

        private void explorerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void wordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fornecedores();
        }

        private void FRMPRIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcaoSelecionada;
            opcaoSelecionada = MessageBox.Show("Deseja Mesmo Sair do Sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcaoSelecionada.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void FRMPRIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        private void produtosServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos();
        }

        private void produtosServiçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produtos();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagamento();
        }

        private void pagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pagamento();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviços();
        }

        private void serviçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Serviços();
        }
    }
}
