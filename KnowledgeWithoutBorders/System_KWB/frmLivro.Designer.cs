namespace System_KWB
{
    partial class frmLivro
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
            System.Windows.Forms.Label código_do_LivroLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label alugadoLabel;
            System.Windows.Forms.Label taxa_de_AtrasoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLivro));
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.código_do_LivroLabel1 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.alugadoCheckBox = new System.Windows.Forms.CheckBox();
            this.taxa_de_AtrasoTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataMenu = new System.Windows.Forms.ToolStrip();
            this.DataPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.DataAnterior = new System.Windows.Forms.ToolStripButton();
            this.DataProximo = new System.Windows.Forms.ToolStripButton();
            this.DataUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataAdicionar = new System.Windows.Forms.ToolStripButton();
            this.DataRemover = new System.Windows.Forms.ToolStripButton();
            this.DataSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DataPesquisar = new System.Windows.Forms.ToolStripButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.Mensagem = new System.Windows.Forms.ToolTip(this.components);
            código_do_LivroLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            alugadoLabel = new System.Windows.Forms.Label();
            taxa_de_AtrasoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DataMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // código_do_LivroLabel
            // 
            código_do_LivroLabel.AutoSize = true;
            código_do_LivroLabel.Location = new System.Drawing.Point(167, 40);
            código_do_LivroLabel.Name = "código_do_LivroLabel";
            código_do_LivroLabel.Size = new System.Drawing.Size(84, 13);
            código_do_LivroLabel.TabIndex = 1;
            código_do_LivroLabel.Text = "Código do Livro:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(167, 69);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 3;
            tituloLabel.Text = "Titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(167, 95);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 5;
            autorLabel.Text = "Autor:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(167, 121);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(45, 13);
            generoLabel.TabIndex = 7;
            generoLabel.Text = "Genero:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Location = new System.Drawing.Point(167, 246);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(43, 13);
            editoraLabel.TabIndex = 9;
            editoraLabel.Text = "Editora:";
            // 
            // alugadoLabel
            // 
            alugadoLabel.AutoSize = true;
            alugadoLabel.Location = new System.Drawing.Point(167, 274);
            alugadoLabel.Name = "alugadoLabel";
            alugadoLabel.Size = new System.Drawing.Size(49, 13);
            alugadoLabel.TabIndex = 11;
            alugadoLabel.Text = "Alugado:";
            // 
            // taxa_de_AtrasoLabel
            // 
            taxa_de_AtrasoLabel.AutoSize = true;
            taxa_de_AtrasoLabel.Location = new System.Drawing.Point(167, 302);
            taxa_de_AtrasoLabel.Name = "taxa_de_AtrasoLabel";
            taxa_de_AtrasoLabel.Size = new System.Drawing.Size(82, 13);
            taxa_de_AtrasoLabel.TabIndex = 13;
            taxa_de_AtrasoLabel.Text = "Taxa de Atraso:";
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.LocaçãoTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_AlunoTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_ProfessorTableAdapter = null;
            this.tableAdapterManager.Pedido_de_LivrosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // código_do_LivroLabel1
            // 
            this.código_do_LivroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Código do Livro", true));
            this.código_do_LivroLabel1.Location = new System.Drawing.Point(257, 40);
            this.código_do_LivroLabel1.Name = "código_do_LivroLabel1";
            this.código_do_LivroLabel1.Size = new System.Drawing.Size(214, 23);
            this.código_do_LivroLabel1.TabIndex = 2;
            this.código_do_LivroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(257, 66);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(214, 20);
            this.tituloTextBox.TabIndex = 0;
            this.tituloTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(257, 92);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(164, 20);
            this.autorTextBox.TabIndex = 1;
            this.autorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // generoTextBox
            // 
            this.generoTextBox.BackColor = System.Drawing.Color.White;
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(257, 147);
            this.generoTextBox.Multiline = true;
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.ReadOnly = true;
            this.generoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generoTextBox.Size = new System.Drawing.Size(104, 90);
            this.generoTextBox.TabIndex = 8;
            this.generoTextBox.TabStop = false;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Editora", true));
            this.editoraTextBox.Location = new System.Drawing.Point(257, 243);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(164, 20);
            this.editoraTextBox.TabIndex = 5;
            this.Mensagem.SetToolTip(this.editoraTextBox, "eae");
            this.editoraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // alugadoCheckBox
            // 
            this.alugadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.livrosBindingSource, "Alugado", true));
            this.alugadoCheckBox.Location = new System.Drawing.Point(257, 269);
            this.alugadoCheckBox.Name = "alugadoCheckBox";
            this.alugadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.alugadoCheckBox.TabIndex = 6;
            this.alugadoCheckBox.Text = "Sim/Não";
            this.alugadoCheckBox.UseVisualStyleBackColor = true;
            this.alugadoCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // taxa_de_AtrasoTextBox
            // 
            this.taxa_de_AtrasoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Taxa de Atraso", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.taxa_de_AtrasoTextBox.Location = new System.Drawing.Point(257, 299);
            this.taxa_de_AtrasoTextBox.Name = "taxa_de_AtrasoTextBox";
            this.taxa_de_AtrasoTextBox.Size = new System.Drawing.Size(104, 20);
            this.taxa_de_AtrasoTextBox.TabIndex = 7;
            this.taxa_de_AtrasoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taxa_de_AtrasoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
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
            this.DataSalvar,
            this.toolStripSeparator1,
            this.DataPesquisar});
            this.DataMenu.Location = new System.Drawing.Point(0, 0);
            this.DataMenu.Name = "DataMenu";
            this.DataMenu.Size = new System.Drawing.Size(488, 25);
            this.DataMenu.TabIndex = 82;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // DataPesquisar
            // 
            this.DataPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("DataPesquisar.Image")));
            this.DataPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataPesquisar.Name = "DataPesquisar";
            this.DataPesquisar.Size = new System.Drawing.Size(74, 22);
            this.DataPesquisar.Text = "Consulta";
            this.DataPesquisar.Click += new System.EventHandler(this.DataPesquisar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(367, 121);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(24, 24);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnAdicionar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = true;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(397, 121);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(24, 24);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnRemover.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // generoComboBox
            // 
            this.generoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Items.AddRange(new object[] {
            "Aventura",
            "Contos",
            "Crônica",
            "Didáticos",
            "Fantasia",
            "Ficção Cientifica",
            "Literatura",
            "Poema",
            "Poesia",
            "Romance",
            "Terror"});
            this.generoComboBox.Location = new System.Drawing.Point(257, 121);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(104, 21);
            this.generoComboBox.TabIndex = 2;
            this.generoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // Mensagem
            // 
            this.Mensagem.AutomaticDelay = 200;
            this.Mensagem.BackColor = System.Drawing.Color.White;
            this.Mensagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.Mensagem.ToolTipTitle = "Campo Inválido";
            // 
            // frmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 327);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.DataMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(código_do_LivroLabel);
            this.Controls.Add(this.código_do_LivroLabel1);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(alugadoLabel);
            this.Controls.Add(this.alugadoCheckBox);
            this.Controls.Add(taxa_de_AtrasoLabel);
            this.Controls.Add(this.taxa_de_AtrasoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLivro";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.frmLivro_Load);
            this.MouseHover += new System.EventHandler(this.frmLivro_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label código_do_LivroLabel1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.CheckBox alugadoCheckBox;
        private System.Windows.Forms.TextBox taxa_de_AtrasoTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox generoComboBox;
        public System.Windows.Forms.ToolTip Mensagem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DataPesquisar;
    }
}