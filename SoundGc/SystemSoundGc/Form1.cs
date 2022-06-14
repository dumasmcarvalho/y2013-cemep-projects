using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemSoundGc
{
    public partial class FRMPRIN : Form
    {
        int time = 0;
        public FRMPRIN()
        {
            InitializeComponent();
        }

        private void SoundElesis()
        {
            System.Media.SoundPlayer SoundElesis = new System.Media.SoundPlayer(Properties.Resources.Elesis);
            SoundElesis.Play();
        }

        private void SoundLire()
        {
            System.Media.SoundPlayer SoundLire = new System.Media.SoundPlayer(Properties.Resources.Lire);
            SoundLire.Play();
        }

        private void SoundArme()
        {
            System.Media.SoundPlayer SoundArme = new System.Media.SoundPlayer(Properties.Resources.Arme);
            SoundArme.Play();
        }

        private void SoundLass()
        {
            System.Media.SoundPlayer SoundLass = new System.Media.SoundPlayer(Properties.Resources.Lass);
            SoundLass.Play();
        }

        private void SoundRyan()
        {
            System.Media.SoundPlayer SoundRyan = new System.Media.SoundPlayer(Properties.Resources.Ryan);
            SoundRyan.Play();
        }

        private void SoundRonan()
        {
            System.Media.SoundPlayer SoundRonan = new System.Media.SoundPlayer(Properties.Resources.Ronan);
            SoundRonan.Play();
        }

        private void SoundJin()
        {
            System.Media.SoundPlayer SoundJin = new System.Media.SoundPlayer(Properties.Resources.Jin);
            SoundJin.Play();
        }

        private void SoundAmy()
        {
            System.Media.SoundPlayer SoundAmy = new System.Media.SoundPlayer(Properties.Resources.Amy);
            SoundAmy.Play();
        }

        private void SoundSieg()
        {
            System.Media.SoundPlayer SoundSieg = new System.Media.SoundPlayer(Properties.Resources.Sieg);
            SoundSieg.Play();
        }

        private void SoundMari()
        {
            System.Media.SoundPlayer SoundMari = new System.Media.SoundPlayer(Properties.Resources.Mari);
            SoundMari.Play();
        }
        private void SoundDio()
        {
            System.Media.SoundPlayer SoundDio = new System.Media.SoundPlayer(Properties.Resources.Dio);
            SoundDio.Play();
        }

        private void SoundZero()
        {
            System.Media.SoundPlayer SoundZero = new System.Media.SoundPlayer(Properties.Resources.Zero);
            SoundZero.Play();
        }

        private void SoundRey()
        {
            System.Media.SoundPlayer SoundRey = new System.Media.SoundPlayer(Properties.Resources.Rey);
            SoundRey.Play();
        }

        private void SoundLupus()
        {
            System.Media.SoundPlayer SoundLupus = new System.Media.SoundPlayer(Properties.Resources.Lupus);
            SoundLupus.Play();
        }

        private void SoundLin()
        {
            System.Media.SoundPlayer SoundLin = new System.Media.SoundPlayer(Properties.Resources.Lin);
            SoundLin.Play();
        }

        private void SoundAzin()
        {
            System.Media.SoundPlayer SoundAzin = new System.Media.SoundPlayer(Properties.Resources.Azin);
            SoundAzin.Play();
        }

        private void SoundHoly()
        {
            System.Media.SoundPlayer SoundHoly = new System.Media.SoundPlayer(Properties.Resources.Holy);
            SoundHoly.Play();
        }

        private void SoundEdel()
        {
            System.Media.SoundPlayer SoundEdel = new System.Media.SoundPlayer(Properties.Resources.Edel);
            SoundEdel.Play();
        }

        private void SoundVeigas()
        {
            System.Media.SoundPlayer SoundVeigas = new System.Media.SoundPlayer(Properties.Resources.Veigas);
            SoundVeigas.Play();
        }

        private void SoundUno()
        {
            System.Media.SoundPlayer SoundUno = new System.Media.SoundPlayer(Properties.Resources.Uno);
            SoundUno.Play();
        }

        public void Exibir()
        {
            L1.Visible = true;
            L2.Visible = true;
            L3.Visible = true;
            L4.Visible = true;
            L5.Visible = true;
            L6.Visible = true;
            L7.Visible = true;
            L8.Visible = true;
            L9.Visible = true;
            L10.Visible = true;

            Nome.Visible = true;
            Afiliados.Visible = true;
            Idade.Visible = true;
            Origem.Visible = true;
            Altura.Visible = true;
            Tipo.Visible = true;
            Aniversario.Visible = true;
            Hobbies.Visible = true;
            Gosta.Visible = true;
            Nao.Visible = true;
            Ponto.Visible = true;

            Nome.Text  = "";
            Afiliados.Text = "";
            Idade.Text = "";
            Origem.Text = "";
            Altura.Text = "";
            Tipo.Text = "";
            Aniversario.Text = "";
            Hobbies.Text = "";
            Gosta.Text = "";
            Nao.Text = "";
            Ponto.Text = "";
        }
        public void Limpar()
        {
            L1.Visible = false;
            L2.Visible = false;
            L3.Visible = false;
            L4.Visible = false;
            L5.Visible = false;
            L6.Visible = false;
            L7.Visible = false;
            L8.Visible = false;
            L9.Visible = false;
            L10.Visible = false;

            Nome.Visible = false;
            Afiliados.Visible = false;
            Idade.Visible = false;
            Origem.Visible = false;
            Altura.Visible = false;
            Tipo.Visible = false;
            Aniversario.Visible = false;
            Hobbies.Visible = false;
            Gosta.Visible = false;
            Nao.Visible = false;
            Ponto.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundElesis();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._01_Elesis;
            pictureBox21.Image = Properties.Resources.Elesis1;
            Nome.Text = "Elesis Sieghart";
            Idade.Text = "17 Anos";
            Origem.Text = "Canaban";
            Afiliados.Text = "Grand Chase";
            Altura.Text = "162cm";
            Tipo.Text = "O";
            Aniversario.Text = "05 de Agosto (Leão)";
            Hobbies.Text = "Treinar com Espada";
            Gosta.Text = "Batalhas Intensas, Tomar Banho";
            Nao.Text = "Batalhas Faceis";
            Ponto.Text = "Vestidos, Fantasmas";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundLire();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._02_Lire;
            pictureBox21.Image = Properties.Resources.Lire1;
            Nome.Text = "Lire Eryuell";
            Idade.Text = "17 Anos";
            Origem.Text = "Ilha de Eryuell";
            Afiliados.Text = "Grand Chase";
            Altura.Text = "166cm";
            Tipo.Text = "A";
            Aniversario.Text = "03 de Dezembro (Sargitario)";
            Hobbies.Text = "Jardinagem";
            Gosta.Text = "Qualquer Coisa Relacionada a Espíritos";
            Nao.Text = "Monstros (Principalmente os Feios)";
            Ponto.Text = "Erros, Perfeccionismo Excessivo";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundArme();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._03_Arme;
            pictureBox21.Image = Properties.Resources.Arme1;
            Nome.Text = "Arme Glanstid";
            Idade.Text = "17 Anos";
            Origem.Text = "Serdin";
            Afiliados.Text = "Grand Chase";
            Altura.Text = "156cm";
            Tipo.Text = "AB";
            Aniversario.Text = "07 de Setembro (Virgem)";
            Hobbies.Text = "Colecionar Itens Mágicos";
            Gosta.Text = "Pesquisar sobre Magia, Cheiro de Documentos Antigos";
            Nao.Text = "Ser Trada como Criança";
            Ponto.Text = "Alimentos Apimentados, Estantes de Livros Altas";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundLass();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._04_Lass;
            pictureBox21.Image = Properties.Resources.Lass1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SoundRyan();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._05_Ryan;
            pictureBox21.Image = Properties.Resources.Ryan1;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SoundRonan();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._06_Ronan;
            pictureBox21.Image = Properties.Resources.Ronan1;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SoundJin();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._07_Jin;
            pictureBox21.Image = Properties.Resources.Jin1;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            SoundAmy();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._08_Amy;
            pictureBox21.Image = Properties.Resources.Amy1;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            SoundSieg();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._09_Sieghart;
            pictureBox21.Image = Properties.Resources.Sieghart;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            SoundMari();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._10_Mari;
            pictureBox21.Image = Properties.Resources.Mari1;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            SoundDio();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._11_Dio;
            pictureBox21.Image = Properties.Resources.Dio1;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            SoundZero();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._12_Zero;
            pictureBox21.Image = Properties.Resources.Zero1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SoundRey();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._13_Lay;
            pictureBox21.Image = Properties.Resources.Rey1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SoundLupus();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._14_Lupus;
            pictureBox21.Image = Properties.Resources.Lupus1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SoundLin();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._15_Rin;
            pictureBox21.Image = Properties.Resources.Lin1;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            SoundAzin();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._16_Asin;
            pictureBox21.Image = Properties.Resources.Azin1;

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            SoundHoly();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._17_Lime;
            pictureBox21.Image = Properties.Resources.Holy1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SoundEdel();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._18_Edel;
            pictureBox21.Image = Properties.Resources.Edel1;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            SoundVeigas();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._19_Veigas;
            pictureBox21.Image = Properties.Resources.Veigas1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            SoundUno();
            Exibir();
            panel1.BackgroundImage = Properties.Resources._20_Uno;
            pictureBox21.Image = Properties.Resources.Uno1;
        }

        private void FRMPRIN_Load(object sender, EventArgs e)
        {
       //     System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(@"C:\Users\Dumas\Documents\Meus Documentos\Outros\Sistemas\Logo.wav");
       //     Sound.Play();
       //     pictureBox21.Load(@"C:\Users\Dumas\Pictures\Memorial de Grand Chase\Fundo\Eternal.jpg");
            panel1.BackgroundImage = Properties.Resources._8;
            
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
       //     System.Media.SoundPlayer Logo = new System.Media.SoundPlayer(@"C:\Users\Dumas\Documents\Meus Documentos\Outros\Sistemas\Hope.wav");
       //     Logo.Play();
       //     pictureBox21.Load(@"C:\Users\Dumas\Pictures\Memorial de Grand Chase\Fundo\Eternal.jpg");
            panel1.BackgroundImage = Properties.Resources._8;
            Limpar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time < 6)
            {
                time++;
            }
            else
            {
              //  System.Media.SoundPlayer Logo = new System.Media.SoundPlayer(@"C:\Users\Dumas\Documents\Meus Documentos\Outros\Sistemas\Hope.wav");
              //  Logo.Play();
                timer1.Stop();
            }
        }
    }
}
