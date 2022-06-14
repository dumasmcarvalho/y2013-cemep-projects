using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElsSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (((textBox2.Text == "Admin") && (textBox1.Text == "123456789")) || ((textBox2.Text == "") && (textBox1.Text == "")))
            {
                frmPrincipal frmp = new frmPrincipal();
                frmp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Inválidos", "Ocorreu um Erro ao Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
