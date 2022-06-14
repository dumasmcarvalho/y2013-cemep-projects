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
    public partial class frmRefino : Form
    {
        public frmRefino()
        {
            InitializeComponent();
        }

        int A, B;
        double A_Fis, A_Mag, A_Vid;
        double B_Fis, B_Mag, B_Vid, B_Atq;
        bool Erro;

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

        public void Limpar_Arma()
        {
            A_Atq_Fis.Clear();
            A_Atq_Mag.Clear();
            A_Vida.Clear();

            R_A_Atq_Fis.Clear();
            R_A_Atq_Mag.Clear();
            R_A_Vida.Clear();

            A_Ref.Value = 0;

            A_Atq_Fis.Focus();
        }

        public void Limpar_Armadura()
        {
            B_Def_Fis.Clear();
            B_Def_Mag.Clear();
            B_Vida.Clear();
            B_Ataque.Clear();

            R_B_Def_Fis.Clear();
            R_B_Def_Mag.Clear();
            R_B_Vida.Clear();
            R_B_Ataque.Clear();

            B_Ref.Value = 0;

            B_Def_Fis.Focus();
        }

        public void Atributos_Arma()
        {
            try
            {
                Erro = false;

                A_Fis = Convert.ToDouble(A_Atq_Fis.Text);
                A_Mag = Convert.ToDouble(A_Atq_Mag.Text);
                A_Vid = Convert.ToDouble(A_Vida.Text);
                A = Convert.ToInt32(A_Ref.Value);
            }
            catch (Exception e)
            {
                Erro = true;

                MessageBox.Show("Algum campo está vazio ou em formato incorreto!", "Elsword Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar_Arma();
            }
        }

        public void Atributos_Armadura()
        {
            try
            {
                Erro = false;

                B_Fis = Convert.ToDouble(B_Def_Fis.Text);
                B_Mag = Convert.ToDouble(B_Def_Mag.Text);
                B_Vid = Convert.ToDouble(B_Vida.Text);
                B_Atq = Convert.ToDouble(B_Ataque.Text);
                B = Convert.ToInt32(B_Ref.Value);
            }
            catch (Exception e)
            {
                Erro = true;

                MessageBox.Show("Algum campo está vazio ou em formato incorreto!", "Elsword Method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar_Armadura();
            }
        }

        private void A_Refinar_Click(object sender, EventArgs e)
        {
            if (A_Ref.Value > 12) { A_Ref.Value = 12; } if (A_Ref.Value < 0) { A_Ref.Value = 0; }

            Atributos_Arma();

            if (Erro == false)
            {
                switch (A)
                {
                    case 0:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1).ToString();
                        R_A_Vida.Text = (A_Vid * 1).ToString();
                        break;
                    }

                    case 1:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.03).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.03).ToString();
                        R_A_Vida.Text = (A_Vid * 1.03).ToString();
                        break;
                    }

                    case 2:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.06).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.06).ToString();
                        R_A_Vida.Text = (A_Vid * 1.06).ToString();
                        break;
                    }

                    case 3:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.09).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.09).ToString();
                        R_A_Vida.Text = (A_Vid * 1.09).ToString();
                        break;
                    }

                    case 4:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.16).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.16).ToString();
                        R_A_Vida.Text = (A_Vid * 1.16).ToString();
                        break;
                    }

                    case 5:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.23).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.23).ToString();
                        R_A_Vida.Text = (A_Vid * 1.23).ToString();
                        break;
                    }

                    case 6:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.3).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.3).ToString();
                        R_A_Vida.Text = (A_Vid * 1.3).ToString();
                        break;
                    }

                    case 7:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.45).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.45).ToString();
                        R_A_Vida.Text = (A_Vid * 1.45).ToString();
                        break;
                    }

                    case 8:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.6).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.6).ToString();
                        R_A_Vida.Text = (A_Vid * 1.6).ToString();
                        break;
                    }

                    case 9:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 1.75).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 1.75).ToString();
                        R_A_Vida.Text = (A_Vid * 1.75).ToString();
                        break;
                    }

                    case 10:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 2.15).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 2.15).ToString();
                        R_A_Vida.Text = (A_Vid * 2.15).ToString();
                        break;
                    }

                    case 11:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 2.55).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 2.55).ToString();
                        R_A_Vida.Text = (A_Vid * 2.55).ToString();
                        break;
                    }

                    case 12:
                    {
                        R_A_Atq_Fis.Text = (A_Fis * 2.95).ToString();
                        R_A_Atq_Mag.Text = (A_Mag * 2.95).ToString();
                        R_A_Vida.Text = (A_Vid * 2.95).ToString();
                        break;
                    }
                }
            }
        }

        private void B_Refinar_Click(object sender, EventArgs e)
        {
            if (B_Ref.Value > 12) { B_Ref.Value = 12; } if (B_Ref.Value < 0) { B_Ref.Value = 0; }

            Atributos_Armadura();

            if (Erro == false)
            {
                switch (B)
                {
                    case 0:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1).ToString();
                        R_B_Vida.Text = (B_Vid * 1).ToString();
                        R_B_Ataque.Text = (B_Atq * 1).ToString();
                        break;
                    }

                    case 1:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.03).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.03).ToString();
                        R_B_Vida.Text = (B_Vid * 1.03).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.03).ToString();
                        break;
                    }

                    case 2:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.06).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.06).ToString();
                        R_B_Vida.Text = (B_Vid * 1.06).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.06).ToString();
                        break;
                    }

                    case 3:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.09).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.09).ToString();
                        R_B_Vida.Text = (B_Vid * 1.09).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.09).ToString();
                        break;
                    }

                    case 4:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.16).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.16).ToString();
                        R_B_Vida.Text = (B_Vid * 1.16).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.16).ToString();
                        break;
                    }

                    case 5:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.23).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.23).ToString();
                        R_B_Vida.Text = (B_Vid * 1.23).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.23).ToString();
                        break;
                    }

                    case 6:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.3).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.3).ToString();
                        R_B_Vida.Text = (B_Vid * 1.3).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.3).ToString();
                        break;
                    }

                    case 7:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.45).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.45).ToString();
                        R_B_Vida.Text = (B_Vid * 1.45).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.45).ToString();
                        break;
                    }

                    case 8:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.6).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.6).ToString();
                        R_B_Vida.Text = (B_Vid * 1.6).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.6).ToString();
                        break;
                    }

                    case 9:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 1.75).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 1.75).ToString();
                        R_B_Vida.Text = (B_Vid * 1.75).ToString();
                        R_B_Ataque.Text = (B_Atq * 1.75).ToString();
                        break;
                    }

                    case 10:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 2.15).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 2.15).ToString();
                        R_B_Vida.Text = (B_Vid * 2.15).ToString();
                        R_B_Ataque.Text = (B_Atq * 2.15).ToString();
                        break;
                    }

                    case 11:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 2.55).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 2.55).ToString();
                        R_B_Vida.Text = (B_Vid * 2.55).ToString();
                        R_B_Ataque.Text = (B_Atq * 2.55).ToString();
                        break;
                    }

                    case 12:
                    {
                        R_B_Def_Fis.Text = (B_Fis * 2.95).ToString();
                        R_B_Def_Mag.Text = (B_Mag * 2.95).ToString();
                        R_B_Vida.Text = (B_Vid * 2.95).ToString();
                        R_B_Ataque.Text = (B_Atq * 2.95).ToString();
                        break;
                    }
                }
            }
        }

        private void B_Reiniciar_Click(object sender, EventArgs e)
        {
            Limpar_Armadura();
        }

        private void A_Reiniciar_Click(object sender, EventArgs e)
        {
            Limpar_Arma();
        }
    }
}
