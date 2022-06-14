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
    public partial class frmDano : Form
    {
        public frmDano()
        {
            InitializeComponent();
        }

        string Escolha_Radio;

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Dispose();

            frmIntrodução Introdução = new frmIntrodução();
            Introdução.Show();
        }

        private void Rad_Fis_CheckedChanged(object sender, EventArgs e)
        {
            Escolha_Radio = "Físico";
        }

        private void Escolha()
        {
            switch (Escolha_Radio)
            {
                case "Físico":
                {


                    break;
                }
            }

        }
    }
}
