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
    public partial class formcliente : Form
    {
        public formcliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);
            dat_NascDateTimePicker.Text = "";
        }

        private void formcliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.bDDataSet.Cliente);

        }

        private void formcliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
