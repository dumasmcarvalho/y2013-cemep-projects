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
    public partial class frmPrincipal : Form
    {
        frmRefino frmref = new frmRefino();
        double Ataque_Fisico;
        double Ataque_Magico;
        double Ataque;
        double Vida_Arma;
        double Vida_Armadura;
        double Defesa_Fisica;
        double Defesa_Magica;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Arma_Refino_CheckedChanged(object sender, EventArgs e)
        {
            if (Arma_Refino.Checked == true)
            {
                Atq_Fisico.Enabled = true;
                Atq_Magico.Enabled = true;
                Arma_Vida.Enabled = true;

                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;

                Def_Magica.Enabled = false;
                Def_Fisica.Enabled = false;
                Ataque_Comum.Enabled = false;
                Armadura_Vida.Enabled = false;

                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
                label8.Enabled = false;

                Armadura_Refino.Enabled = true;

                label1.Enabled = true;
                Nivel_Refino.Enabled = true;
                Calc_Refino.Enabled = true;
                Rein_Refino.Enabled = true;
            }
        }

        private void Armadura_Refino_CheckedChanged(object sender, EventArgs e)
        {
            if (Armadura_Refino.Checked == true)
            {
                Def_Magica.Enabled = true;
                Def_Fisica.Enabled = true;
                Ataque_Comum.Enabled = true;
                Armadura_Vida.Enabled = true;

                label5.Enabled = true;
                label6.Enabled = true;
                label7.Enabled = true;
                label8.Enabled = true;
                
                Atq_Fisico.Enabled = false;
                Atq_Magico.Enabled = false;
                Arma_Vida.Enabled = false;

                label2.Enabled = false;
                label3.Enabled = false;
                label4.Enabled = false;
                
                Arma_Refino.Enabled = true;

                label1.Enabled = true;
                Nivel_Refino.Enabled = true;
                Calc_Refino.Enabled = true;
                Rein_Refino.Enabled = true;
            }
        }

        private void Calc_Refino_Click(object sender, EventArgs e)
        {
            double Arma_Fisico = Convert.ToDouble(Atq_Fisico.Text);
            double Arma_Magico = Convert.ToDouble(Atq_Magico.Text);
            double Var_Vida_Arma = Convert.ToDouble(Arma_Vida.Text);

            double Ataque = Convert.ToDouble(Ataque_Comum.Text);
            double Armadura_Fisico = Convert.ToDouble(Def_Fisica.Text);
            double Armadura_Magico = Convert.ToDouble(Def_Magica.Text);
            double Var_Vida_Armadura = Convert.ToDouble(Armadura_Vida.Text);

            int Value = Convert.ToInt32(Nivel_Refino.Value);

            if (Arma_Refino.Checked == true)
            {

                switch (Value)
                {
                    case 1:
                        Ataque_Fisico = Arma_Fisico * 1.03;
                        Ataque_Magico = Arma_Magico * 1.03;
                        Vida_Arma = Var_Vida_Arma * 1.03;
                        break;

                    case 2:
                        Ataque_Fisico = Arma_Fisico * 1.06;
                        Ataque_Magico = Arma_Magico * 1.06;
                        Vida_Arma = Var_Vida_Arma * 1.06;
                        break;

                    case 3:
                        Ataque_Fisico = Arma_Fisico * 1.09;
                        Ataque_Magico = Arma_Magico * 1.09;
                        Vida_Arma = Var_Vida_Arma * 1.09;
                        break;

                    case 4:
                        Ataque_Fisico = Arma_Fisico * 1.16;
                        Ataque_Magico = Arma_Magico * 1.16;
                        Vida_Arma = Var_Vida_Arma * 1.16;
                        break;

                    case 5:
                        Ataque_Fisico = Arma_Fisico * 1.23;
                        Ataque_Magico = Arma_Magico * 1.23;
                        Vida_Arma = Var_Vida_Arma * 1.23;
                        break;

                    case 6:
                        Ataque_Fisico = Arma_Fisico * 1.3;
                        Ataque_Magico = Arma_Magico * 1.3;
                        Vida_Arma = Var_Vida_Arma * 1.3;
                        break;

                    case 7:
                        Ataque_Fisico = Arma_Fisico * 1.45;
                        Ataque_Magico = Arma_Magico * 1.45;
                        Vida_Arma = Var_Vida_Arma * 1.45;
                        break;

                    case 8:
                        Ataque_Fisico = Arma_Fisico * 1.6;
                        Ataque_Magico = Arma_Magico * 1.6;
                        Vida_Arma = Var_Vida_Arma * 1.6;
                        break;

                    case 9:
                        Ataque_Fisico = Arma_Fisico * 1.75;
                        Ataque_Magico = Arma_Magico * 1.75;
                        Vida_Arma = Var_Vida_Arma * 1.75;
                        break;

                    case 10:
                        Ataque_Fisico = Arma_Fisico * 2.15;
                        Ataque_Magico = Arma_Magico * 2.15;
                        Vida_Arma = Var_Vida_Arma * 2.15;
                        break;

                    case 11:
                        Ataque_Fisico = Arma_Fisico * 2.55;
                        Ataque_Magico = Arma_Magico * 2.55;
                        Vida_Arma = Var_Vida_Arma * 2.55;
                        break;

                    case 12:
                        Ataque_Fisico = Arma_Fisico * 2.95;
                        Ataque_Magico = Arma_Magico * 2.95;
                        Vida_Arma = Var_Vida_Arma * 2.95;
                        break;

                    default:
                        Ataque_Fisico = Arma_Fisico * 1;
                        Ataque_Magico = Arma_Magico * 1;
                        Vida_Arma = Var_Vida_Arma * 1;
                        break;
                }
            }

            if (Armadura_Refino.Checked == true)
            {
                switch (Value)
                {
                    case 1:
                        Ataque = Ataque * 1.03;
                        Defesa_Fisica = Armadura_Fisico * 1.03;
                        Defesa_Magica = Armadura_Magico * 1.03;
                        Vida_Armadura = Var_Vida_Armadura * 1.03;
                        break;

                    case 2:
                        Ataque = Ataque * 1.06;
                        Defesa_Fisica = Armadura_Fisico * 1.06;
                        Defesa_Magica = Armadura_Magico * 1.06;
                        Vida_Armadura = Var_Vida_Armadura * 1.06;
                        break;
                    
                    case 3:
                        Ataque = Ataque * 1.09;
                        Defesa_Fisica = Armadura_Fisico * 1.09;
                        Defesa_Magica = Armadura_Magico * 1.09;
                        Vida_Armadura = Var_Vida_Armadura * 1.09;
                        break;

                    case 4:
                        Ataque = Ataque * 1.16;
                        Defesa_Fisica = Armadura_Fisico * 1.16;
                        Defesa_Magica = Armadura_Magico * 1.16;
                        Vida_Armadura = Var_Vida_Armadura * 1.16;
                        break;

                    case 5:
                        Ataque = Ataque * 1.23;
                        Defesa_Fisica = Armadura_Fisico * 1.23;
                        Defesa_Magica = Armadura_Magico * 1.23;
                        Vida_Armadura = Var_Vida_Armadura * 1.23;
                        break;

                    case 6:
                        Ataque = Ataque * 1.30;
                        Defesa_Fisica = Armadura_Fisico * 1.30;
                        Defesa_Magica = Armadura_Magico * 1.30;
                        Vida_Armadura = Var_Vida_Armadura * 1.30;
                        break;

                    case 7:
                        Ataque = Ataque * 1.45;
                        Defesa_Fisica = Armadura_Fisico * 1.45;
                        Defesa_Magica = Armadura_Magico * 1.45;
                        Vida_Armadura = Var_Vida_Armadura * 1.45;
                        break;

                    case 8:
                        Ataque = Ataque * 1.60;
                        Defesa_Fisica = Armadura_Fisico * 1.60;
                        Defesa_Magica = Armadura_Magico * 1.60;
                        Vida_Armadura = Var_Vida_Armadura * 1.60;
                        break;

                    case 9:
                        Ataque = Ataque * 1.75;
                        Defesa_Fisica = Armadura_Fisico * 1.75;
                        Defesa_Magica = Armadura_Magico * 1.75;
                        Vida_Armadura = Var_Vida_Armadura * 1.75;
                        break;

                    case 10:
                        Ataque = Ataque * 2.15;
                        Defesa_Fisica = Armadura_Fisico * 2.15;
                        Defesa_Magica = Armadura_Magico * 2.15;
                        Vida_Armadura = Var_Vida_Armadura * 2.15;
                        break;

                    case 11:
                        Ataque = Ataque * 2.55;
                        Defesa_Fisica = Armadura_Fisico * 2.55;
                        Defesa_Magica = Armadura_Magico * 2.55;
                        Vida_Armadura = Var_Vida_Armadura * 2.55;
                        break;

                    case 12:
                        Ataque = Ataque * 2.95;
                        Defesa_Fisica = Armadura_Fisico * 2.95;
                        Defesa_Magica = Armadura_Magico * 2.95;
                        Vida_Armadura = Var_Vida_Armadura * 2.95;
                        break;
                        
                    default:
                        Ataque = Ataque * 1;
                        Defesa_Fisica = Armadura_Fisico * 1;
                        Defesa_Magica = Armadura_Magico * 1;
                        Vida_Armadura = Var_Vida_Armadura * 1;
                        break;
                }
            }

            Atualizar();

        }

        public void Atualizar()
        {
            frmref.Atq_Fisico.Text = Convert.ToString(Ataque_Fisico);
            frmref.Atq_Magico.Text = Convert.ToString(Ataque_Magico);
            frmref.Arma_Vida.Text = Convert.ToString(Vida_Arma);

            frmref.Ataque_Comum.Text = Convert.ToString(Ataque);
            frmref.Def_Fisica.Text = Convert.ToString(Defesa_Fisica);
            frmref.Def_Magica.Text = Convert.ToString(Defesa_Magica);
            frmref.Armadura_Vida.Text = Convert.ToString(Vida_Armadura);

            frmref.groupBox1.Text = "Pós Refino: + " + Nivel_Refino.Value + " "; 

            frmref.ShowDialog();
        }

        private void Rein_Refino_Click(object sender, EventArgs e)
        {
            Atq_Fisico.Text = "0";
            Atq_Magico.Text = "0";
            Arma_Vida.Text = "0";

            Def_Magica.Text = "0";
            Def_Fisica.Text = "0";
            Ataque_Comum.Text = "0";
            Armadura_Vida.Text = "0";

            Def_Magica.Enabled = false;
            Def_Fisica.Enabled = false;
            Ataque_Comum.Enabled = false;
            Armadura_Vida.Enabled = false;

            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            
            Atq_Fisico.Enabled = false;
            Atq_Magico.Enabled = false;
            Arma_Vida.Enabled = false;

            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            Armadura_Refino.Checked = false;
            Armadura_Refino.Enabled = true;
            Arma_Refino.Checked = false;
            Arma_Refino.Enabled = true;

            label1.Enabled = false;
            Nivel_Refino.Enabled = false;
            Calc_Refino.Enabled = false;
            Rein_Refino.Enabled = false;

            Nivel_Refino.Value = 0;
        }

        private void Calc_Dano_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        public void Calcular()
        {
            double Calc_Fis = Convert.ToDouble(Ataque_Fisico_Dano.Text);
            double Calc_Mag = Convert.ToDouble(Ataque_Magico_Dano.Text);
            double Calc_FisMag = (Calc_Fis + Calc_Mag) / 2;
            double Porcentagem = Convert.ToDouble(Porcentagem_Dano.Text);
            double Multiplos = Convert.ToDouble(Quantidade_Dano.Text);
            double Dano;

            if (Fisico_Dano.Checked == true)
            {

                if ((Quantidade.Checked == true) && (Critico.Checked == true))
                {

                    Dano = (((Calc_Fis * Porcentagem) / 100) * Multiplos) * 1.5;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else if (Quantidade.Checked == true)
                {
                    Dano = ((Calc_Fis * Porcentagem) / 100) * Multiplos;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else if (Critico.Checked == true)
                {
                    Dano = ((Calc_Fis * Porcentagem) / 100) * 1.5;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else
                {
                    Dano = (Calc_Fis * Porcentagem) / 100;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
            }

            else if (Magico_Dano.Checked == true)
            {

                if ((Quantidade.Checked == true) && (Critico.Checked == true))
                {

                    Dano = (((Calc_Mag * Porcentagem) / 100) * Multiplos) * 1.5;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else if (Quantidade.Checked == true)
                {
                    Dano = ((Calc_Mag * Porcentagem) / 100) * Multiplos;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else if (Critico.Checked == true)
                {
                    Dano = ((Calc_Mag * Porcentagem) / 100) * 1.5;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else
                {
                    Dano = (Calc_Mag * Porcentagem) / 100;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
            }

            else if (FisMag_Dano.Checked == true)
            {
                if ((Quantidade.Checked == true) && (Critico.Checked == true))
                {

                    Dano = (((Calc_FisMag * Porcentagem) / 100) * Multiplos) * 1.5;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else if (Quantidade.Checked == true)
                {
                    Dano = ((Calc_FisMag * Porcentagem) / 100) * Multiplos;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else if (Critico.Checked == true)
                {
                    Dano = ((Calc_FisMag * Porcentagem) / 100) * 1.5;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
                else
                {
                    Dano = (Calc_FisMag * Porcentagem) / 100;
                    Dano_Final.Text = Convert.ToString(Dano);
                }
            }
        }

        private void Rein_Dano_Click(object sender, EventArgs e)
        {
            Porcentagem_Dano.Text = "0";
            Quantidade_Dano.Text = "1";
            Dano_Final.Text = "0";
            Fisico_Dano.Checked = false;
            Magico_Dano.Checked = false;
            FisMag_Dano.Checked = false;
            Critico.Checked = false;
            Quantidade.Checked = false;
            Omitir();
            Ataque_Fisico_Dano.Text = "0";
            Ataque_Magico_Dano.Text = "0";
        }

        private void Quantidade_CheckedChanged(object sender, EventArgs e)
        {
            if (Quantidade.Checked == true)
            {
                Quantidade_Dano.Enabled = true;
            }
            else
            {
                Quantidade_Dano.Enabled = false;
                Quantidade_Dano.Text = "1";
            }
        }

        private void Atq_Fisico_Enter(object sender, EventArgs e)
        {
            Atq_Fisico.Text = "";
        }

        private void Atq_Magico_Enter(object sender, EventArgs e)
        {
            Atq_Magico.Text = "";
        }

        private void Arma_Vida_Enter(object sender, EventArgs e)
        {
            Arma_Vida.Text = "";

        }

        private void Ataque_Comum_Enter(object sender, EventArgs e)
        {
            Ataque_Comum.Text = "";
        }

        private void Armadura_Vida_Enter(object sender, EventArgs e)
        {
            Armadura_Vida.Text = "";
        }

        private void Def_Fisica_Enter(object sender, EventArgs e)
        {
            Def_Fisica.Text = "";
        }

        private void Def_Magica_Enter(object sender, EventArgs e)
        {
            Def_Magica.Text = "";
        }

        private void Ataque_Dano_Enter(object sender, EventArgs e)
        {
            Ataque_Fisico_Dano.Text = "";
        }

        private void Porcentagem_Dano_Enter(object sender, EventArgs e)
        {
            Porcentagem_Dano.Text = "";
        }

        private void Quantidade_Dano_Enter(object sender, EventArgs e)
        {
            Quantidade_Dano.Text = "";
        }

        private void Atq_Fisico_Leave(object sender, EventArgs e)
        {
            if (Atq_Fisico.Text == "") { Atq_Fisico.Text = "0"; }
        }

        private void Atq_Magico_Leave(object sender, EventArgs e)
        {
            if (Atq_Magico.Text == "") { Atq_Magico.Text = "0"; }
        }

        private void Arma_Vida_Leave(object sender, EventArgs e)
        {
            if (Arma_Vida.Text == "") { Arma_Vida.Text = "0"; }
        }

        private void Ataque_Comum_Leave(object sender, EventArgs e)
        {
            if (Ataque_Comum.Text == "") { Ataque_Comum.Text = "0"; }
        }

        private void Armadura_Vida_Leave(object sender, EventArgs e)
        {
            if (Armadura_Vida.Text == "") { Armadura_Vida.Text = "0"; }
        }

        private void Def_Fisica_Leave(object sender, EventArgs e)
        {
            if (Def_Fisica.Text == "") { Def_Fisica.Text = "0"; }
        }

        private void Def_Magica_Leave(object sender, EventArgs e)
        {
            if (Def_Magica.Text == "") { Def_Magica.Text = "0"; }
        }

        private void Ataque_Dano_Leave(object sender, EventArgs e)
        {
            if (Ataque_Fisico_Dano.Text == "") { Ataque_Fisico_Dano.Text = "0"; }
        }

        private void Porcentagem_Dano_Leave(object sender, EventArgs e)
        {
            if (Porcentagem_Dano.Text == "") { Porcentagem_Dano.Text = "0"; }
        }

        private void Quantidade_Dano_Leave(object sender, EventArgs e)
        {
            if (Quantidade_Dano.Text == "") { Quantidade_Dano.Text = "0"; }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Ajuda_Click(object sender, EventArgs e)
        {
            frmSobre frmsob = new frmSobre();
            frmsob.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Ajuda, "Clique aqui para saber mais sobre o sistema em uso...");
            toolTip1.SetToolTip(this.Critico, "É levado em consideração que todos os golpes serão criticos, ou seja, vezes 1.5.");
            toolTip1.SetToolTip(this.label22, "É a soma da quantidade de Elstones do 1º, 2º e 3º encantamento.");
            toolTip1.SetToolTip(this.label24, "É a quantidade de Elstones referente ao nível de encantamento (Em relação ao nível de equipamento).");

            this.Size = new Size(624, 373);
            Controle_Page.Size = new Size(594, 321);
            Ajuda.Location = new Point(580, 9);
            this.CenterToScreen();

        }

        private void Arma_Encanto_CheckedChanged(object sender, EventArgs e)
        {
            if (Arma_Encanto.Checked == true)
            {
                Nivel_Equipamento.Enabled = true;
                Nivel_Encanto.Enabled = true;
                Nivel_Equipamento.Value = 1;
                Nivel_Encanto.Value = 1;
                Nivel_Encanto.Maximum = 3;
                Nivel_Referente.Text = "0";
                Quantidade_Elstones.Text = "0";
                label20.Enabled = true;
                Calc_Encanto.Enabled = true;
                Rein_Encanto.Enabled = true;
                label22.Enabled = true;
                label23.Enabled = true;
                label24.Enabled = true;
                Quantidade_Elstones.Enabled = true;
                Nivel_Referente.Enabled = true;
            }
        }

        private void Armadura_Encanto_CheckedChanged(object sender, EventArgs e)
        {
            if (Armadura_Encanto.Checked == true)
            {
                Nivel_Equipamento.Enabled = true;
                Nivel_Encanto.Enabled = true;
                Nivel_Equipamento.Value = 1;
                Nivel_Encanto.Value = 1;
                Nivel_Encanto.Maximum = 2;
                Nivel_Referente.Text = "0";
                Quantidade_Elstones.Text = "0";
                label20.Enabled = true;
                Calc_Encanto.Enabled = true;
                Rein_Encanto.Enabled = true;
                label22.Enabled = true;
                label23.Enabled = true;
                label24.Enabled = true;
                Quantidade_Elstones.Enabled = true;
                Nivel_Referente.Enabled = true;
            }
        }

        private void Calc_Encanto_Click(object sender, EventArgs e)
        {
            int Encanto = Convert.ToInt32(Nivel_Encanto.Value);
            double Nivel = Convert.ToDouble(Nivel_Equipamento.Value);
            double Elstones;
            double Elstones_Nivel;

            if (Arma_Encanto.Checked == true)
            {
                switch (Encanto)
                {
                    case 1:
                        Elstones = Nivel / 2;
                        Elstones_Nivel = Nivel / 2;
                        Nivel_Referente.Text = Convert.ToString(Elstones_Nivel);
                        Quantidade_Elstones.Text = Convert.ToString(Elstones);
                        break;

                    case 2:
                        Elstones = (Nivel * 1.5) + (Nivel / 2);
                        Elstones_Nivel = Nivel * 1.5;
                        Nivel_Referente.Text = Convert.ToString(Elstones_Nivel);
                        Quantidade_Elstones.Text = Convert.ToString(Elstones);
                        break;

                    case 3:
                        Elstones = (Nivel * 3) + (Nivel * 1.5) + (Nivel / 2);
                        Elstones_Nivel = Nivel * 3;
                        Nivel_Referente.Text = Convert.ToString(Elstones_Nivel);
                        Quantidade_Elstones.Text = Convert.ToString(Elstones);
                        break;
                }
            }
            else
            {
                switch (Encanto)
                {
                    case 1:
                        Elstones = Nivel / 8;
                        Elstones_Nivel = Nivel / 8;
                        Nivel_Referente.Text = Convert.ToString(Elstones_Nivel);
                        Quantidade_Elstones.Text = Convert.ToString(Elstones);
                        break;

                    case 2:
                        Elstones = (Nivel * 0.375) + (Nivel / 8);
                        Elstones_Nivel = Nivel * 0.375;
                        Nivel_Referente.Text = Convert.ToString(Elstones_Nivel);
                        Quantidade_Elstones.Text = Convert.ToString(Elstones);
                        break;
                }
            }
        }

        private void Rein_Encanto_Click(object sender, EventArgs e)
        {
            Nivel_Encanto.Value = 1;
            Nivel_Equipamento.Value = 1;
            Nivel_Encanto.Enabled = false;
            Nivel_Equipamento.Enabled = false;
            Nivel_Referente.Text = "0";
            Quantidade_Elstones.Text = "0";
            Arma_Encanto.Checked = false;
            Armadura_Encanto.Checked = false;
            label20.Enabled = false;
            Calc_Encanto.Enabled = false;
            Rein_Encanto.Enabled = false;
            label22.Enabled = false;
            label23.Enabled = false;
            label24.Enabled = false;
            Quantidade_Elstones.Enabled = false;
            Nivel_Referente.Enabled = false;
        }

        private void Fisico_Dano_CheckedChanged(object sender, EventArgs e)
        {
            if (Fisico_Dano.Checked == true) 
            {
                label10.Enabled = true;
                Ataque_Fisico_Dano.Enabled = true;
                Ataque_Fisico_Dano.Focus();
                Exibir();

                Critico.Checked = false;
                Quantidade.Checked = false;

                label25.Enabled = false;
                Ataque_Magico_Dano.Enabled = false;
                Ataque_Magico_Dano.Text = "0";
                Porcentagem_Dano.Text = "0";
                Quantidade_Dano.Text = "0";
                Dano_Final.Text = "0";
            }
        }

        private void Magico_Dano_CheckedChanged(object sender, EventArgs e)
        {
            if (Magico_Dano.Checked == true)
            {
                label25.Enabled = true;
                Ataque_Magico_Dano.Enabled = true;
                Ataque_Magico_Dano.Focus();
                Exibir();

                Critico.Checked = false;
                Quantidade.Checked = false;

                label10.Enabled = false;
                Ataque_Fisico_Dano.Enabled = false;
                Ataque_Fisico_Dano.Text = "0";
                Porcentagem_Dano.Text = "0";
                Quantidade_Dano.Text = "0";
                Dano_Final.Text = "0";
            }
        }

        private void FisMag_Dano_CheckedChanged(object sender, EventArgs e)
        {
            if (FisMag_Dano.Checked == true)
            {
                label25.Enabled = true;
                Ataque_Magico_Dano.Enabled = true;
                label10.Enabled = true;
                Ataque_Fisico_Dano.Enabled = true;
                Exibir();

                Ataque_Fisico_Dano.Text = "0";
                Ataque_Magico_Dano.Text = "0";
                Porcentagem_Dano.Text = "0";
                Quantidade_Dano.Text = "0";
                Dano_Final.Text = "0";
            }
        }

        public void Exibir()
        {
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            Quantidade.Enabled = true;
            Porcentagem_Dano.Enabled = true;
            Critico.Enabled = true;
            Dano_Final.Enabled = true;
            Calc_Dano.Enabled = true;
            Rein_Dano.Enabled = true;
        }

        public void Omitir()
        {
            label10.Enabled = false;
            label25.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            label13.Enabled = false;
            Quantidade.Enabled = false;
            Porcentagem_Dano.Enabled = false;
            Quantidade_Dano.Enabled = false;
            Critico.Enabled = false;
            Dano_Final.Enabled = false;
            Calc_Dano.Enabled = false;
            Rein_Dano.Enabled = false;
            Ataque_Fisico_Dano.Enabled = false;
            Ataque_Magico_Dano.Enabled = false;
        }

        private void Ataque_Magico_Dano_Enter(object sender, EventArgs e)
        {
            Ataque_Magico_Dano.Text = "";
        }

        private void Ataque_Magico_Dano_Leave(object sender, EventArgs e)
        {
            if (Ataque_Magico_Dano.Text == "") { Ataque_Magico_Dano.Text = "0"; }
        }

        private void Ataque_Fisico_Dano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Ataque_Magico_Dano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Quantidade_Dano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Atq_Fisico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void Atq_Magico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Arma_Vida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Ataque_Comum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Def_Fisica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Def_Magica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Armadura_Vida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void Controle_Abas_Selected(object sender, TabControlEventArgs e)
        {
            if (Controle_Page.SelectedTab == Page_Refino)
            {
                this.Size = new Size(624, 373);
                this.CenterToScreen();
                Controle_Page.Size = new Size(594, 321);
                Ajuda.Location = new Point(580, 9);
            }

            else if (Controle_Page.SelectedTab == Page_Dano)
            {
                this.Size = new Size(726, 488);
                this.CenterToScreen();
                Controle_Page.Size = new Size(696, 435);
                Ajuda.Location = new Point(682, 9);
            }

            else if (Controle_Page.SelectedTab == Page_Encantamento)
            {
                this.Size = new Size(726, 414);
                this.CenterToScreen();
                Controle_Page.Size = new Size(698, 361);
                Ajuda.Location = new Point(682, 9);
            }
            else
            {
                this.Size = new Size(624, 373);
                this.CenterToScreen();
                Controle_Page.Size = new Size(594, 321);
                Ajuda.Location = new Point(580, 9);
            }
        }

        private void Quantidade_Dano_TextChanged(object sender, EventArgs e)
        {
            if (Quantidade_Dano.Text == "0") { Quantidade_Dano.Text = "1"; }
        }
    }
}