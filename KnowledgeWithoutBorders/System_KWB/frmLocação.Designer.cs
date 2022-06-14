namespace System_KWB
{
    partial class frmLocação
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
            System.Windows.Forms.Label código_da_LocaçãoLabel;
            System.Windows.Forms.Label titulo_do_LivroLabel;
            System.Windows.Forms.Label codigo_do_LivroLabel;
            System.Windows.Forms.Label taxa_de_AtrasoLabel;
            System.Windows.Forms.Label data_de_RetiradaLabel;
            System.Windows.Forms.Label data_de_EntregaLabel;
            System.Windows.Forms.Label matrícula_do_AlunoLabel;
            System.Windows.Forms.Label nome_do_AlunoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocação));
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.locaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locaçãoTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.LocaçãoTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.alunosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.AlunosTableAdapter();
            this.livrosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.LivrosTableAdapter();
            this.código_da_LocaçãoLabel1 = new System.Windows.Forms.Label();
            this.titulo_do_LivroComboBox = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigo_do_LivroComboBox = new System.Windows.Forms.ComboBox();
            this.taxa_de_AtrasoComboBox = new System.Windows.Forms.ComboBox();
            this.data_de_RetiradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_de_EntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.matrícula_do_AlunoComboBox = new System.Windows.Forms.ComboBox();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataMenu = new System.Windows.Forms.ToolStrip();
            this.DataPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.DataAnterior = new System.Windows.Forms.ToolStripButton();
            this.DataProximo = new System.Windows.Forms.ToolStripButton();
            this.DataUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataAdicionar = new System.Windows.Forms.ToolStripButton();
            this.DataRemover = new System.Windows.Forms.ToolStripButton();
            this.DataSalvar = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nome_do_AlunoComboBox = new System.Windows.Forms.ComboBox();
            código_da_LocaçãoLabel = new System.Windows.Forms.Label();
            titulo_do_LivroLabel = new System.Windows.Forms.Label();
            codigo_do_LivroLabel = new System.Windows.Forms.Label();
            taxa_de_AtrasoLabel = new System.Windows.Forms.Label();
            data_de_RetiradaLabel = new System.Windows.Forms.Label();
            data_de_EntregaLabel = new System.Windows.Forms.Label();
            matrícula_do_AlunoLabel = new System.Windows.Forms.Label();
            nome_do_AlunoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_da_LocaçãoLabel
            // 
            código_da_LocaçãoLabel.AutoSize = true;
            código_da_LocaçãoLabel.Location = new System.Drawing.Point(164, 37);
            código_da_LocaçãoLabel.Name = "código_da_LocaçãoLabel";
            código_da_LocaçãoLabel.Size = new System.Drawing.Size(103, 13);
            código_da_LocaçãoLabel.TabIndex = 1;
            código_da_LocaçãoLabel.Text = "Código da Locação:";
            // 
            // titulo_do_LivroLabel
            // 
            titulo_do_LivroLabel.AutoSize = true;
            titulo_do_LivroLabel.Location = new System.Drawing.Point(164, 66);
            titulo_do_LivroLabel.Name = "titulo_do_LivroLabel";
            titulo_do_LivroLabel.Size = new System.Drawing.Size(77, 13);
            titulo_do_LivroLabel.TabIndex = 3;
            titulo_do_LivroLabel.Text = "Titulo do Livro:";
            // 
            // codigo_do_LivroLabel
            // 
            codigo_do_LivroLabel.AutoSize = true;
            codigo_do_LivroLabel.Location = new System.Drawing.Point(164, 93);
            codigo_do_LivroLabel.Name = "codigo_do_LivroLabel";
            codigo_do_LivroLabel.Size = new System.Drawing.Size(84, 13);
            codigo_do_LivroLabel.TabIndex = 5;
            codigo_do_LivroLabel.Text = "Código do Livro:";
            // 
            // taxa_de_AtrasoLabel
            // 
            taxa_de_AtrasoLabel.AutoSize = true;
            taxa_de_AtrasoLabel.Location = new System.Drawing.Point(164, 120);
            taxa_de_AtrasoLabel.Name = "taxa_de_AtrasoLabel";
            taxa_de_AtrasoLabel.Size = new System.Drawing.Size(82, 13);
            taxa_de_AtrasoLabel.TabIndex = 7;
            taxa_de_AtrasoLabel.Text = "Taxa de Atraso:";
            // 
            // data_de_RetiradaLabel
            // 
            data_de_RetiradaLabel.AutoSize = true;
            data_de_RetiradaLabel.Location = new System.Drawing.Point(164, 202);
            data_de_RetiradaLabel.Name = "data_de_RetiradaLabel";
            data_de_RetiradaLabel.Size = new System.Drawing.Size(91, 13);
            data_de_RetiradaLabel.TabIndex = 11;
            data_de_RetiradaLabel.Text = "Data de Retirada:";
            // 
            // data_de_EntregaLabel
            // 
            data_de_EntregaLabel.AutoSize = true;
            data_de_EntregaLabel.Location = new System.Drawing.Point(164, 228);
            data_de_EntregaLabel.Name = "data_de_EntregaLabel";
            data_de_EntregaLabel.Size = new System.Drawing.Size(88, 13);
            data_de_EntregaLabel.TabIndex = 13;
            data_de_EntregaLabel.Text = "Data de Entrega:";
            // 
            // matrícula_do_AlunoLabel
            // 
            matrícula_do_AlunoLabel.AutoSize = true;
            matrícula_do_AlunoLabel.Location = new System.Drawing.Point(164, 174);
            matrícula_do_AlunoLabel.Name = "matrícula_do_AlunoLabel";
            matrícula_do_AlunoLabel.Size = new System.Drawing.Size(100, 13);
            matrícula_do_AlunoLabel.TabIndex = 14;
            matrícula_do_AlunoLabel.Text = "Matrícula do Aluno:";
            // 
            // nome_do_AlunoLabel
            // 
            nome_do_AlunoLabel.AutoSize = true;
            nome_do_AlunoLabel.Location = new System.Drawing.Point(164, 147);
            nome_do_AlunoLabel.Name = "nome_do_AlunoLabel";
            nome_do_AlunoLabel.Size = new System.Drawing.Size(83, 13);
            nome_do_AlunoLabel.TabIndex = 87;
            nome_do_AlunoLabel.Text = "Nome do Aluno:";
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locaçãoBindingSource
            // 
            this.locaçãoBindingSource.DataMember = "Locação";
            this.locaçãoBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // locaçãoTableAdapter
            // 
            this.locaçãoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantinaTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.Itens_da_VendaTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.LocaçãoTableAdapter = this.locaçãoTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_AlunoTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_ProfessorTableAdapter = null;
            this.tableAdapterManager.Pedido_de_LivrosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // código_da_LocaçãoLabel1
            // 
            this.código_da_LocaçãoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Código da Locação", true));
            this.código_da_LocaçãoLabel1.Location = new System.Drawing.Point(273, 37);
            this.código_da_LocaçãoLabel1.Name = "código_da_LocaçãoLabel1";
            this.código_da_LocaçãoLabel1.Size = new System.Drawing.Size(200, 23);
            this.código_da_LocaçãoLabel1.TabIndex = 2;
            this.código_da_LocaçãoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titulo_do_LivroComboBox
            // 
            this.titulo_do_LivroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Titulo do Livro", true));
            this.titulo_do_LivroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titulo_do_LivroComboBox.FormattingEnabled = true;
            this.titulo_do_LivroComboBox.Location = new System.Drawing.Point(273, 63);
            this.titulo_do_LivroComboBox.Name = "titulo_do_LivroComboBox";
            this.titulo_do_LivroComboBox.Size = new System.Drawing.Size(121, 21);
            this.titulo_do_LivroComboBox.TabIndex = 0;
            this.titulo_do_LivroComboBox.SelectedIndexChanged += new System.EventHandler(this.titulo_do_LivroComboBox_SelectedIndexChanged);
            this.titulo_do_LivroComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titulo_do_LivroComboBox_KeyDown);
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // codigo_do_LivroComboBox
            // 
            this.codigo_do_LivroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Codigo do Livro", true));
            this.codigo_do_LivroComboBox.DataSource = this.livrosBindingSource;
            this.codigo_do_LivroComboBox.DisplayMember = "Código do Livro";
            this.codigo_do_LivroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.codigo_do_LivroComboBox.Enabled = false;
            this.codigo_do_LivroComboBox.FormattingEnabled = true;
            this.codigo_do_LivroComboBox.Location = new System.Drawing.Point(273, 90);
            this.codigo_do_LivroComboBox.Name = "codigo_do_LivroComboBox";
            this.codigo_do_LivroComboBox.Size = new System.Drawing.Size(85, 21);
            this.codigo_do_LivroComboBox.TabIndex = 2;
            this.codigo_do_LivroComboBox.ValueMember = "Código do Livro";
            this.codigo_do_LivroComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titulo_do_LivroComboBox_KeyDown);
            // 
            // taxa_de_AtrasoComboBox
            // 
            this.taxa_de_AtrasoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Taxa de Atraso", true));
            this.taxa_de_AtrasoComboBox.DataSource = this.livrosBindingSource;
            this.taxa_de_AtrasoComboBox.DisplayMember = "Taxa de Atraso";
            this.taxa_de_AtrasoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.taxa_de_AtrasoComboBox.Enabled = false;
            this.taxa_de_AtrasoComboBox.FormattingEnabled = true;
            this.taxa_de_AtrasoComboBox.Location = new System.Drawing.Point(273, 117);
            this.taxa_de_AtrasoComboBox.Name = "taxa_de_AtrasoComboBox";
            this.taxa_de_AtrasoComboBox.Size = new System.Drawing.Size(85, 21);
            this.taxa_de_AtrasoComboBox.TabIndex = 3;
            this.taxa_de_AtrasoComboBox.ValueMember = "Taxa de Atraso";
            this.taxa_de_AtrasoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titulo_do_LivroComboBox_KeyDown);
            // 
            // data_de_RetiradaDateTimePicker
            // 
            this.data_de_RetiradaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locaçãoBindingSource, "Data de Retirada", true));
            this.data_de_RetiradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_de_RetiradaDateTimePicker.Location = new System.Drawing.Point(273, 198);
            this.data_de_RetiradaDateTimePicker.Name = "data_de_RetiradaDateTimePicker";
            this.data_de_RetiradaDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.data_de_RetiradaDateTimePicker.TabIndex = 6;
            this.data_de_RetiradaDateTimePicker.ValueChanged += new System.EventHandler(this.data_de_RetiradaDateTimePicker_ValueChanged);
            this.data_de_RetiradaDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titulo_do_LivroComboBox_KeyDown);
            // 
            // data_de_EntregaDateTimePicker
            // 
            this.data_de_EntregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locaçãoBindingSource, "Data de Entrega", true));
            this.data_de_EntregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_de_EntregaDateTimePicker.Location = new System.Drawing.Point(273, 224);
            this.data_de_EntregaDateTimePicker.Name = "data_de_EntregaDateTimePicker";
            this.data_de_EntregaDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.data_de_EntregaDateTimePicker.TabIndex = 7;
            this.data_de_EntregaDateTimePicker.ValueChanged += new System.EventHandler(this.data_de_EntregaDateTimePicker_ValueChanged);
            this.data_de_EntregaDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titulo_do_LivroComboBox_KeyDown);
            // 
            // matrícula_do_AlunoComboBox
            // 
            this.matrícula_do_AlunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Matrícula do Aluno", true));
            this.matrícula_do_AlunoComboBox.DataSource = this.alunosBindingSource;
            this.matrícula_do_AlunoComboBox.DisplayMember = "Matricula";
            this.matrícula_do_AlunoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.matrícula_do_AlunoComboBox.Enabled = false;
            this.matrícula_do_AlunoComboBox.FormattingEnabled = true;
            this.matrícula_do_AlunoComboBox.Location = new System.Drawing.Point(273, 171);
            this.matrícula_do_AlunoComboBox.Name = "matrícula_do_AlunoComboBox";
            this.matrícula_do_AlunoComboBox.Size = new System.Drawing.Size(85, 21);
            this.matrícula_do_AlunoComboBox.TabIndex = 5;
            this.matrícula_do_AlunoComboBox.ValueMember = "Matricula";
            this.matrícula_do_AlunoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titulo_do_LivroComboBox_KeyDown);
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.bD_KWB_DataSet;
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
            this.DataMenu.Size = new System.Drawing.Size(413, 25);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // nome_do_AlunoComboBox
            // 
            this.nome_do_AlunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locaçãoBindingSource, "Nome do Aluno", true));
            this.nome_do_AlunoComboBox.DataSource = this.alunosBindingSource;
            this.nome_do_AlunoComboBox.DisplayMember = "Nome";
            this.nome_do_AlunoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nome_do_AlunoComboBox.FormattingEnabled = true;
            this.nome_do_AlunoComboBox.Location = new System.Drawing.Point(273, 144);
            this.nome_do_AlunoComboBox.Name = "nome_do_AlunoComboBox";
            this.nome_do_AlunoComboBox.Size = new System.Drawing.Size(121, 21);
            this.nome_do_AlunoComboBox.TabIndex = 4;
            this.nome_do_AlunoComboBox.ValueMember = "Nome";
            this.nome_do_AlunoComboBox.SelectedIndexChanged += new System.EventHandler(this.nome_do_AlunoComboBox_SelectedIndexChanged);
            this.nome_do_AlunoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.titulo_do_LivroComboBox_KeyDown);
            // 
            // frmLocação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 254);
            this.Controls.Add(nome_do_AlunoLabel);
            this.Controls.Add(this.nome_do_AlunoComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataMenu);
            this.Controls.Add(matrícula_do_AlunoLabel);
            this.Controls.Add(this.matrícula_do_AlunoComboBox);
            this.Controls.Add(código_da_LocaçãoLabel);
            this.Controls.Add(this.código_da_LocaçãoLabel1);
            this.Controls.Add(titulo_do_LivroLabel);
            this.Controls.Add(this.titulo_do_LivroComboBox);
            this.Controls.Add(codigo_do_LivroLabel);
            this.Controls.Add(this.codigo_do_LivroComboBox);
            this.Controls.Add(taxa_de_AtrasoLabel);
            this.Controls.Add(this.taxa_de_AtrasoComboBox);
            this.Controls.Add(data_de_RetiradaLabel);
            this.Controls.Add(this.data_de_RetiradaDateTimePicker);
            this.Controls.Add(data_de_EntregaLabel);
            this.Controls.Add(this.data_de_EntregaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Locação de Livros";
            this.Load += new System.EventHandler(this.frmAluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locaçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource locaçãoBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.LocaçãoTableAdapter locaçãoTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label código_da_LocaçãoLabel1;
        private System.Windows.Forms.ComboBox titulo_do_LivroComboBox;
        private System.Windows.Forms.ComboBox codigo_do_LivroComboBox;
        private System.Windows.Forms.ComboBox taxa_de_AtrasoComboBox;
        private System.Windows.Forms.DateTimePicker data_de_RetiradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_de_EntregaDateTimePicker;
        private System.Windows.Forms.ComboBox matrícula_do_AlunoComboBox;
        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Resources.BD_KWB_DataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private System.Windows.Forms.ComboBox nome_do_AlunoComboBox;

    }
}