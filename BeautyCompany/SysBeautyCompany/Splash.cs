using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysBeautyCompany
{
    public partial class FRMSPLASH : Form
    {
        public FRMSPLASH()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum) {
                progressBar1.Increment(20);
                label1.Text = progressBar1.Value + "%";
            }
                else {
                    timer1.Stop();
                    FRMLOGIN FRMLogin = new FRMLOGIN();
                    FRMLogin.Show();
                    //FRMPRIN FRMPrin = new FRMPRIN();
                    //FRMPrin.Show();
                    this.Hide();
                }
         }
     }
 }
