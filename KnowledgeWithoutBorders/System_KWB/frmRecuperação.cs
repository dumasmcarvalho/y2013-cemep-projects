using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace System_KWB
{
    public partial class frmRecuperação : Form
    {
        public frmRecuperação()
        {
            InitializeComponent();
        }

        private void buttonRecuperar_Click(object sender, EventArgs e)
        {
             string Query = "SELECT * FROM Login WHERE Email = @Email";

            Conexão Conexão = new Conexão();
            Conexão.Conectar();

            OleDbCommand Comando = new OleDbCommand(Query, Conexão._Conexão);

            Comando.Parameters.AddWithValue("@Email", textEmail.Text);

            OleDbDataReader Validação = Comando.ExecuteReader();

            if (Validação.Read())
            {
                Autenticação.Recuperação(Validação["Usuário"].ToString(), Validação["Senha"].ToString());
                MessageBox.Show(Autenticação.Exibir_Dados());
            }
            else
            {
                MessageBox.Show("O email informado não foi encontrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
