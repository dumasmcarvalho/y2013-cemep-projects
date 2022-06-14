using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Temporizador : Form
    {
        public Temporizador()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TempoAtual.Text = DateTime.Now.ToLongTimeString();
        }

        private void TimerOn_Tick(object sender, EventArgs e)
        {
            if (TempoAtual.Text == MascaraHorario.Text) { ChamarMsg(); TimerOn.Stop(); MascaraHorario.Text = ""; MascaraHorario.ReadOnly = false; MascaraHorario.Focus(); }
        }

        public void ChamarMsg()
        {
            Mensagem Msg = new Mensagem();
            Msg.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerOn.Start();
            MascaraHorario.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimerOn.Stop();
            MascaraHorario.Text = "";
            MascaraHorario.ReadOnly = false;
            MascaraHorario.Focus();
        }

        private void Temporizador_Load(object sender, EventArgs e)
        {
            TempoAtual.Text = DateTime.Now.ToLongTimeString();
        }

        private void Temporizador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
