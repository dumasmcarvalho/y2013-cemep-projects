using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elsword_Method
{
    public partial class frmIntrodução : Form
    {
        public frmIntrodução()
        {
            InitializeComponent();
        }

        private void frmIntrodução_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Refino_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRefino Refino = new frmRefino();
            Refino.Show();
        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDano Dano = new frmDano();
            Dano.Show();
        }

        private void frmIntrodução_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (MessageBox.Show("Deseja sair do sistema?", "Elsword Method", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            */
        }
    }
}
