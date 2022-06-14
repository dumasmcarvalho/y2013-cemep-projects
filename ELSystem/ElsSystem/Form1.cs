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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Carregamento.Value <= 100)
            {
                Carregamento.Increment(10);
            }
            else
            {
                Timer.Enabled = false;

                this.Hide();

                frmPrincipal frmprin = new frmPrincipal();
                frmprin.Show();

                //frmLogin frmlog = new frmLogin();
                //frmlog.Show();
            }
        }

        private void frmSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }
    }
}
