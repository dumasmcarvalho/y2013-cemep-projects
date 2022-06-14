using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Timer
{
    public partial class Mensagem : Form
    {
        public Mensagem()
        {
            InitializeComponent();
        }

        public static int Seg;

        private void Mensagem_Activated(object sender, EventArgs e)
        {
            TimerRegressivo.Start();
            System.Media.SystemSounds.Exclamation.Play();
            Seg = 10;
        }

        private void TimerRegressivo_Tick(object sender, EventArgs e)
        {
            if (Seg > 0) { Seg--; label1.Text = "O computador será desligado em: " + Convert.ToString(Seg) + " Segundos..."; } else { TimerRegressivo.Stop(); this.Close(); Process.Start("Shutdown", "-s -f"); Application.Exit(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerRegressivo.Stop();
            this.Dispose();
            ChamarTempo();
        }

        public void ChamarTempo()
        {
            Temporizador Tempo = new Temporizador();
            Tempo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "-s -f");
            Application.Exit();
        }

        private void Mensagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
