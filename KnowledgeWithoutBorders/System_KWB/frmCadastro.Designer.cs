namespace System_KWB
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label código_do_CadastroLabel;
            System.Windows.Forms.Label nível_de_CadastroLabel;
            System.Windows.Forms.Label usuárioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label confirmar_SenhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.código_do_CadastroLabel1 = new System.Windows.Forms.Label();
            this.nível_de_CadastroComboBox = new System.Windows.Forms.ComboBox();
            this.usuárioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.confirmar_SenhaTextBox = new System.Windows.Forms.TextBox();
            this.loginTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.DataMenu = new System.Windows.Forms.ToolStrip();
            this.DataPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.DataAnterior = new System.Windows.Forms.ToolStripButton();
            this.DataProximo = new System.Windows.Forms.ToolStripButton();
            this.DataUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataAdicionar = new System.Windows.Forms.ToolStripButton();
            this.DataRemover = new System.Windows.Forms.ToolStripButton();
            this.DataSalvar = new System.Windows.Forms.ToolStripButton();
            this.Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            código_do_CadastroLabel = new System.Windows.Forms.Label();
            nível_de_CadastroLabel = new System.Windows.Forms.Label();
            usuárioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            confirmar_SenhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_do_CadastroLabel
            // 
            código_do_CadastroLabel.AutoSize = true;
            código_do_CadastroLabel.Location = new System.Drawing.Point(168, 37);
            código_do_CadastroLabel.Name = "código_do_CadastroLabel";
            código_do_CadastroLabel.Size = new System.Drawing.Size(103, 13);
            código_do_CadastroLabel.TabIndex = 1;
            código_do_CadastroLabel.Text = "Código do Cadastro:";
            // 
            // nível_de_CadastroLabel
            // 
            nível_de_CadastroLabel.AutoSize = true;
            nível_de_CadastroLabel.Location = new System.Drawing.Point(168, 176);
            nível_de_CadastroLabel.Name = "nível_de_CadastroLabel";
            nível_de_CadastroLabel.Size = new System.Drawing.Size(96, 13);
            nível_de_CadastroLabel.TabIndex = 3;
            nível_de_CadastroLabel.Text = "Nível de Cadastro:";
            // 
            // usuárioLabel
            // 
            usuárioLabel.AutoSize = true;
            usuárioLabel.Location = new System.Drawing.Point(168, 75);
            usuárioLabel.Name = "usuárioLabel";
            usuárioLabel.Size = new System.Drawing.Size(46, 13);
            usuárioLabel.TabIndex = 5;
            usuárioLabel.Text = "Usuário:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(168, 109);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 7;
            senhaLabel.Text = "Senha:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(168, 211);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // confirmar_SenhaLabel
            // 
            confirmar_SenhaLabel.AutoSize = true;
            confirmar_SenhaLabel.Location = new System.Drawing.Point(168, 143);
            confirmar_SenhaLabel.Name = "confirmar_SenhaLabel";
            confirmar_SenhaLabel.Size = new System.Drawing.Size(88, 13);
            confirmar_SenhaLabel.TabIndex = 13;
            confirmar_SenhaLabel.Text = "Confirmar Senha:";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // código_do_CadastroLabel1
            // 
            this.código_do_CadastroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Código do Cadastro", true));
            this.código_do_CadastroLabel1.Location = new System.Drawing.Point(295, 38);
            this.código_do_CadastroLabel1.Name = "código_do_CadastroLabel1";
            this.código_do_CadastroLabel1.Size = new System.Drawing.Size(233, 23);
            this.código_do_CadastroLabel1.TabIndex = 0;
            this.código_do_CadastroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nível_de_CadastroComboBox
            // 
            this.nível_de_CadastroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Nível de Cadastro", true));
            this.nível_de_CadastroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nível_de_CadastroComboBox.FormattingEnabled = true;
            this.nível_de_CadastroComboBox.Items.AddRange(new object[] {
            "Aluno",
            "Diretor",
            "Professor",
            "Desenvolvedor"});
            this.nível_de_CadastroComboBox.Location = new System.Drawing.Point(298, 174);
            this.nível_de_CadastroComboBox.MaxLength = 50;
            this.nível_de_CadastroComboBox.Name = "nível_de_CadastroComboBox";
            this.nível_de_CadastroComboBox.Size = new System.Drawing.Size(148, 21);
            this.nível_de_CadastroComboBox.TabIndex = 3;
            this.nível_de_CadastroComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuárioTextBox_KeyDown);
            this.nível_de_CadastroComboBox.Leave += new System.EventHandler(this.nível_de_CadastroComboBox_Leave);
            // 
            // usuárioTextBox
            // 
            this.usuárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Usuário", true));
            this.usuárioTextBox.Location = new System.Drawing.Point(298, 72);
            this.usuárioTextBox.MaxLength = 20;
            this.usuárioTextBox.Name = "usuárioTextBox";
            this.usuárioTextBox.Size = new System.Drawing.Size(148, 20);
            this.usuárioTextBox.TabIndex = 0;
            this.usuárioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuárioTextBox_KeyDown);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(298, 107);
            this.senhaTextBox.MaxLength = 10;
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.senhaTextBox.TabIndex = 1;
            this.senhaTextBox.UseSystemPasswordChar = true;
            this.senhaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuárioTextBox_KeyDown);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(298, 209);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(233, 20);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuárioTextBox_KeyDown);
            // 
            // confirmar_SenhaTextBox
            // 
            this.confirmar_SenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Confirmar Senha", true));
            this.confirmar_SenhaTextBox.Location = new System.Drawing.Point(298, 141);
            this.confirmar_SenhaTextBox.MaxLength = 10;
            this.confirmar_SenhaTextBox.Name = "confirmar_SenhaTextBox";
            this.confirmar_SenhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.confirmar_SenhaTextBox.TabIndex = 2;
            this.confirmar_SenhaTextBox.UseSystemPasswordChar = true;
            this.confirmar_SenhaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuárioTextBox_KeyDown);
            this.confirmar_SenhaTextBox.Leave += new System.EventHandler(this.confirmar_SenhaTextBox_Leave);
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantinaTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.Itens_da_VendaTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.LocaçãoTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.Pagamento_do_AlunoTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_ProfessorTableAdapter = null;
            this.tableAdapterManager.Pedido_de_LivrosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataMenu
            // 
            this.DataMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DataMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataPrimeiro,
            this.DataAnterior,
            this.DataProximo,
            this.DataUltimo,
            this.toolStripSeparator3,
            this.DataAdicionar,
            this.DataRemover,
            this.DataSalvar});
            this.DataMenu.Location = new System.Drawing.Point(0, 0);
            this.DataMenu.Name = "DataMenu";
            this.DataMenu.Size = new System.Drawing.Size(541, 25);
            this.DataMenu.TabIndex = 23;
            this.DataMenu.Text = "DataMenu";
            // 
            // DataPrimeiro
            // 
            this.DataPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("DataPrimeiro.Image")));
            this.DataPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataPrimeiro.Name = "DataPrimeiro";
            this.DataPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.DataPrimeiro.Text = "Primeiro Registro";
            this.DataPrimeiro.ToolTipText = "Primeiro Registro";
            this.DataPrimeiro.Click += new System.EventHandler(this.DataPrimeiro_Click);
            // 
            // DataAnterior
            // 
            this.DataAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataAnterior.Image = ((System.Drawing.Image)(resources.GetObject("DataAnterior.Image")));
            this.DataAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataAnterior.Name = "DataAnterior";
            this.DataAnterior.Size = new System.Drawing.Size(23, 22);
            this.DataAnterior.Text = "Registro Anterior";
            this.DataAnterior.Click += new System.EventHandler(this.DataAnterior_Click);
            // 
            // DataProximo
            // 
            this.DataProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataProximo.Image = ((System.Drawing.Image)(resources.GetObject("DataProximo.Image")));
            this.DataProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataProximo.Name = "DataProximo";
            this.DataProximo.Size = new System.Drawing.Size(23, 22);
            this.DataProximo.Text = "Próximo Registro";
            this.DataProximo.Click += new System.EventHandler(this.DataProximo_Click);
            // 
            // DataUltimo
            // 
            this.DataUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataUltimo.Image = ((System.Drawing.Image)(resources.GetObject("DataUltimo.Image")));
            this.DataUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataUltimo.Name = "DataUltimo";
            this.DataUltimo.Size = new System.Drawing.Size(23, 22);
            this.DataUltimo.Text = "Ultimo Registro";
            this.DataUltimo.Click += new System.EventHandler(this.DataUltimo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DataAdicionar
            // 
            this.DataAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("DataAdicionar.Image")));
            this.DataAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataAdicionar.Name = "DataAdicionar";
            this.DataAdicionar.Size = new System.Drawing.Size(23, 22);
            this.DataAdicionar.Text = "Adicionar Registro";
            this.DataAdicionar.ToolTipText = "Adicionar Registro";
            this.DataAdicionar.Click += new System.EventHandler(this.DataAdicionar_Click);
            // 
            // DataRemover
            // 
            this.DataRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataRemover.Image = ((System.Drawing.Image)(resources.GetObject("DataRemover.Image")));
            this.DataRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataRemover.Name = "DataRemover";
            this.DataRemover.Size = new System.Drawing.Size(23, 22);
            this.DataRemover.Text = "Remover Registro";
            this.DataRemover.ToolTipText = "Remover Registro";
            this.DataRemover.Click += new System.EventHandler(this.DataRemover_Click);
            // 
            // DataSalvar
            // 
            this.DataSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DataSalvar.Image = ((System.Drawing.Image)(resources.GetObject("DataSalvar.Image")));
            this.DataSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataSalvar.Name = "DataSalvar";
            this.DataSalvar.Size = new System.Drawing.Size(23, 22);
            this.DataSalvar.Text = "Salvar";
            this.DataSalvar.ToolTipText = "Salvar Registro";
            this.DataSalvar.Click += new System.EventHandler(this.DataSalvar_Click);
            // 
            // Mensagem
            // 
            this.Mensagem.AutomaticDelay = 200;
            this.Mensagem.BackColor = System.Drawing.Color.White;
            this.Mensagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.Mensagem.ToolTipTitle = "Campo Inválido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 239);
            this.Controls.Add(this.DataMenu);
            this.Controls.Add(confirmar_SenhaLabel);
            this.Controls.Add(this.confirmar_SenhaTextBox);
            this.Controls.Add(código_do_CadastroLabel);
            this.Controls.Add(nível_de_CadastroLabel);
            this.Controls.Add(this.nível_de_CadastroComboBox);
            this.Controls.Add(usuárioLabel);
            this.Controls.Add(this.usuárioTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.código_do_CadastroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Usuário/Senha";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.MouseHover += new System.EventHandler(this.frmCadastro_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label código_do_CadastroLabel1;
        private System.Windows.Forms.ComboBox nível_de_CadastroComboBox;
        private System.Windows.Forms.TextBox usuárioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox confirmar_SenhaTextBox;
        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        public System.Windows.Forms.ToolTip Mensagem;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}