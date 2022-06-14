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
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formprin FORMPRIN = new formprin();

            if (textBox1.Text == "")
            {
                FORMPRIN.Show();
                FORMPRIN.toolStripStatusLabel1.Text = "Usuario";
                this.Dispose();
            }
            else
            {
                FORMPRIN.Show();
                FORMPRIN.toolStripStatusLabel1.Text = textBox1.Text;
                this.Dispose();
            }
        }
    }
}
