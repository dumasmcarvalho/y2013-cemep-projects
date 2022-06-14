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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (Progresso.Value == 25)
            {
                Descrição.Text = "Configurando os Formulários...";
            }

            if (Progresso.Value == 50)
            {
                Descrição.Text = "Atualizando o Banco de Dados...";
            }

            if (Progresso.Value == 75)
            {
                Descrição.Text = "Carregando Ferramentas...";
            }

            if (Progresso.Value < Progresso.Maximum)
            {
                Progresso.Increment(5);
            }
            else
            {
                Temporizador.Stop();
                this.Hide();
                frmLogin Login = new frmLogin();
                Login.Show();

            //  frmPrincipal Principal = new frmPrincipal();
            //  Principal.Show();
            }
        }

        private void pictureCancelar_Click(object sender, EventArgs e)
        {
            Temporizador.Stop();

            DialogResult opcaoSelecionada;
            opcaoSelecionada = MessageBox.Show("Deseja realmente sair do sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcaoSelecionada.Equals(DialogResult.No))
            {
                Temporizador.Start();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
