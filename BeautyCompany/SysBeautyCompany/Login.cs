using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace SysBeautyCompany
{
    public partial class FRMLOGIN : Form
    {
        public FRMLOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                FRMPRIN FRMPrin = new FRMPRIN();
                FRMPrin.toolStripStatusLabel4.Text = "Usuário";
                this.Dispose();
                FRMPrin.Show();
            }
            else
            {
                FRMPRIN FRMPrin = new FRMPRIN();
                FRMPrin.toolStripStatusLabel4.Text = textBox1.Text;
                this.Dispose();
                FRMPrin.Show();
            }
        }

        public string LetraMaiuscula(string Input)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(Input.ToLower());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fechar();
        }
      
        private void FRMLOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fechar();
        }

        public void Fechar()
        {
            Application.Exit();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            textBox1.Text = textInfo.ToTitleCase(textBox1.Text);
        }

        private void FRMLOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcaoSelecionada;
            opcaoSelecionada = MessageBox.Show("Deseja Mesmo Sair do Sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcaoSelecionada.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = LetraMaiuscula(textBox1.Text).ToString();
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
}
