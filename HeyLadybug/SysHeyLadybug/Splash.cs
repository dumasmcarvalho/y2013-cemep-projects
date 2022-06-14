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
    public partial class formsplash : Form
    {
        public formsplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Increment(20);
            }
            else
            {
                timer1.Stop();
                formlogin FORMLOGIN = new formlogin();
                FORMLOGIN.Show();
                //FRMPRIN FRMPrin = new FRMPRIN();
                //FRMPrin.Show();
                this.Hide();
            }
        }
    }
}