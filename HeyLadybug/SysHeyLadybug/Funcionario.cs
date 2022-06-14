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
    public partial class formfuncionario : Form
    {
        public formfuncionario()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            dat_NascDateTimePicker.Text = "";
        }

        private void formfuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDDataSet.Funcionario);

        }

        private void formfuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
