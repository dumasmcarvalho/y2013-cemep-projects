namespace System_KWB
{
    partial class frmFornecedor
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
            System.Windows.Forms.Label código_do_FornecedorLabel;
            System.Windows.Forms.Label razão_SocialLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label nome_para_ContatoLabel;
            System.Windows.Forms.Label rua_AvenidaLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.DataMenu = new System.Windows.Forms.ToolStrip();
            this.DataPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.DataAnterior = new System.Windows.Forms.ToolStripButton();
            this.DataProximo = new System.Windows.Forms.ToolStripButton();
            this.DataUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataAdicionar = new System.Windows.Forms.ToolStripButton();
            this.DataRemover = new System.Windows.Forms.ToolStripButton();
            this.DataSalvar = new System.Windows.Forms.ToolStripButton();
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.código_do_FornecedorLabel1 = new System.Windows.Forms.Label();
            this.razão_SocialTextBox = new System.Windows.Forms.TextBox();
            this.cNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nome_para_ContatoTextBox = new System.Windows.Forms.TextBox();
            this.rua_AvenidaTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            código_do_FornecedorLabel = new System.Windows.Forms.Label();
            razão_SocialLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            nome_para_ContatoLabel = new System.Windows.Forms.Label();
            rua_AvenidaLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_do_FornecedorLabel
            // 
            código_do_FornecedorLabel.AutoSize = true;
            código_do_FornecedorLabel.Location = new System.Drawing.Point(159, 36);
            código_do_FornecedorLabel.Name = "código_do_FornecedorLabel";
            código_do_FornecedorLabel.Size = new System.Drawing.Size(115, 13);
            código_do_FornecedorLabel.TabIndex = 86;
            código_do_FornecedorLabel.Text = "Código do Fornecedor:";
            // 
            // razão_SocialLabel
            // 
            razão_SocialLabel.AutoSize = true;
            razão_SocialLabel.Location = new System.Drawing.Point(159, 65);
            razão_SocialLabel.Name = "razão_SocialLabel";
            razão_SocialLabel.Size = new System.Drawing.Size(73, 13);
            razão_SocialLabel.TabIndex = 88;
            razão_SocialLabel.Text = "Razão Social:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(159, 91);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(37, 13);
            cNPJLabel.TabIndex = 90;
            cNPJLabel.Text = "CNPJ:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(159, 117);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 92;
            telefoneLabel.Text = "Telefone:";
            // 
            // nome_para_ContatoLabel
            // 
            nome_para_ContatoLabel.AutoSize = true;
            nome_para_ContatoLabel.Location = new System.Drawing.Point(159, 143);
            nome_para_ContatoLabel.Name = "nome_para_ContatoLabel";
            nome_para_ContatoLabel.Size = new System.Drawing.Size(102, 13);
            nome_para_ContatoLabel.TabIndex = 94;
            nome_para_ContatoLabel.Text = "Nome para Contato:";
            // 
            // rua_AvenidaLabel
            // 
            rua_AvenidaLabel.AutoSize = true;
            rua_AvenidaLabel.Location = new System.Drawing.Point(159, 169);
            rua_AvenidaLabel.Name = "rua_AvenidaLabel";
            rua_AvenidaLabel.Size = new System.Drawing.Size(74, 13);
            rua_AvenidaLabel.TabIndex = 96;
            rua_AvenidaLabel.Text = "Rua/Avenida:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(159, 195);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 98;
            numeroLabel.Text = "Numero:";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(159, 221);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(74, 13);
            complementoLabel.TabIndex = 100;
            complementoLabel.Text = "Complemento:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(159, 247);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 102;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(159, 273);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 104;
            cidadeLabel.Text = "Cidade:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(159, 299);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 106;
            cEPLabel.Text = "CEP:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(159, 325);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 108;
            estadoLabel.Text = "Estado:";
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
            this.DataMenu.Size = new System.Drawing.Size(475, 25);
            this.DataMenu.TabIndex = 85;
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
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantinaTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.Itens_da_VendaTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.LocaçãoTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_AlunoTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_ProfessorTableAdapter = null;
            this.tableAdapterManager.Pedido_de_LivrosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // código_do_FornecedorLabel1
            // 
            this.código_do_FornecedorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Código do Fornecedor", true));
            this.código_do_FornecedorLabel1.Location = new System.Drawing.Point(280, 36);
            this.código_do_FornecedorLabel1.Name = "código_do_FornecedorLabel1";
            this.código_do_FornecedorLabel1.Size = new System.Drawing.Size(173, 23);
            this.código_do_FornecedorLabel1.TabIndex = 87;
            this.código_do_FornecedorLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // razão_SocialTextBox
            // 
            this.razão_SocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Razão Social", true));
            this.razão_SocialTextBox.Location = new System.Drawing.Point(280, 62);
            this.razão_SocialTextBox.Name = "razão_SocialTextBox";
            this.razão_SocialTextBox.Size = new System.Drawing.Size(173, 20);
            this.razão_SocialTextBox.TabIndex = 0;
            this.razão_SocialTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // cNPJMaskedTextBox
            // 
            this.cNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "CNPJ", true));
            this.cNPJMaskedTextBox.Location = new System.Drawing.Point(280, 88);
            this.cNPJMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cNPJMaskedTextBox.Name = "cNPJMaskedTextBox";
            this.cNPJMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cNPJMaskedTextBox.TabIndex = 1;
            this.cNPJMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cNPJMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(280, 114);
            this.telefoneMaskedTextBox.Mask = "(00) 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefoneMaskedTextBox.TabIndex = 2;
            this.telefoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telefoneMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // nome_para_ContatoTextBox
            // 
            this.nome_para_ContatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Nome para Contato", true));
            this.nome_para_ContatoTextBox.Location = new System.Drawing.Point(280, 140);
            this.nome_para_ContatoTextBox.Name = "nome_para_ContatoTextBox";
            this.nome_para_ContatoTextBox.Size = new System.Drawing.Size(173, 20);
            this.nome_para_ContatoTextBox.TabIndex = 3;
            this.nome_para_ContatoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // rua_AvenidaTextBox
            // 
            this.rua_AvenidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Rua/Avenida", true));
            this.rua_AvenidaTextBox.Location = new System.Drawing.Point(280, 166);
            this.rua_AvenidaTextBox.Name = "rua_AvenidaTextBox";
            this.rua_AvenidaTextBox.Size = new System.Drawing.Size(173, 20);
            this.rua_AvenidaTextBox.TabIndex = 4;
            this.rua_AvenidaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(280, 192);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(60, 20);
            this.numeroTextBox.TabIndex = 5;
            this.numeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(280, 218);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(121, 20);
            this.complementoTextBox.TabIndex = 6;
            this.complementoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(280, 244);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(121, 20);
            this.bairroTextBox.TabIndex = 7;
            this.bairroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(280, 270);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(121, 20);
            this.cidadeTextBox.TabIndex = 8;
            this.cidadeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // cEPMaskedTextBox
            // 
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Location = new System.Drawing.Point(280, 296);
            this.cEPMaskedTextBox.Mask = "00000-000";
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            this.cEPMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cEPMaskedTextBox.TabIndex = 9;
            this.cEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cEPMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "Estado", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.estadoComboBox.Location = new System.Drawing.Point(280, 322);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(60, 21);
            this.estadoComboBox.TabIndex = 10;
            this.estadoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.razão_SocialTextBox_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(código_do_FornecedorLabel);
            this.Controls.Add(this.código_do_FornecedorLabel1);
            this.Controls.Add(razão_SocialLabel);
            this.Controls.Add(this.razão_SocialTextBox);
            this.Controls.Add(cNPJLabel);
            this.Controls.Add(this.cNPJMaskedTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(nome_para_ContatoLabel);
            this.Controls.Add(this.nome_para_ContatoTextBox);
            this.Controls.Add(rua_AvenidaLabel);
            this.Controls.Add(this.rua_AvenidaTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(complementoLabel);
            this.Controls.Add(this.complementoTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.DataMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label código_do_FornecedorLabel1;
        private System.Windows.Forms.TextBox razão_SocialTextBox;
        private System.Windows.Forms.MaskedTextBox cNPJMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox nome_para_ContatoTextBox;
        private System.Windows.Forms.TextBox rua_AvenidaTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}