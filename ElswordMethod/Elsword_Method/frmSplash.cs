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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        int X;

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (X <= 100)
            {
                X++;
            }
            else
            {
                Temporizador.Stop();
                this.Hide();

                frmIntrodução Introdução = new frmIntrodução();
                Introdução.Show();
            }
        }
    }
}
