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
    public partial class frmMensagem : Form
    {
        public frmMensagem()
        {
            InitializeComponent();
        }

        public static frmMensagem MsgBox; 

        public static DialogResult Resultado = DialogResult.No;

        public static int Escolha;

        public static DialogResult Show(string Text, string Caption, string Encerrar, string Logout, string Cancelar)
        {
            MsgBox = new frmMensagem();

            MsgBox.lblMensagem.Text = Text;

            MsgBox.btnEncerrar.Text = Encerrar;
            MsgBox.btnLogout.Text = Logout;
            MsgBox.btnCancelar.Text = Cancelar;

            Resultado = DialogResult.No;

            MsgBox.ShowDialog();

            return Resultado;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Escolha = 1;
            this.Close();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Escolha = 2;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Escolha = 3;
            this.Close();
        }
    }
}
