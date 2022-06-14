namespace System_KWB
{
    partial class frmEstoque
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
            System.Windows.Forms.Label código_do_EstoqueLabel;
            System.Windows.Forms.Label nome_do_ProdutoLabel;
            System.Windows.Forms.Label código_do_ProdutoLabel;
            System.Windows.Forms.Label código_do_FornecedorLabel;
            System.Windows.Forms.Label quantidade_em_EstoqueLabel;
            System.Windows.Forms.Label estoque_CriticoLabel;
            System.Windows.Forms.Label comprarLabel;
            System.Windows.Forms.Label nome_do_FornecedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.EstoqueTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.código_do_EstoqueLabel1 = new System.Windows.Forms.Label();
            this.nome_do_ProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.código_do_ProdutoComboBox = new System.Windows.Forms.ComboBox();
            this.código_do_FornecedorComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantidade_em_EstoqueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.estoque_CriticoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comprarCheckBox = new System.Windows.Forms.CheckBox();
            this.DataMenu = new System.Windows.Forms.ToolStrip();
            this.DataPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.DataAnterior = new System.Windows.Forms.ToolStripButton();
            this.DataProximo = new System.Windows.Forms.ToolStripButton();
            this.DataUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataAdicionar = new System.Windows.Forms.ToolStripButton();
            this.DataRemover = new System.Windows.Forms.ToolStripButton();
            this.DataSalvar = new System.Windows.Forms.ToolStripButton();
            this.produtosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.ProdutosTableAdapter();
            this.fornecedoresTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.FornecedoresTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nome_do_FornecedorComboBox = new System.Windows.Forms.ComboBox();
            código_do_EstoqueLabel = new System.Windows.Forms.Label();
            nome_do_ProdutoLabel = new System.Windows.Forms.Label();
            código_do_ProdutoLabel = new System.Windows.Forms.Label();
            código_do_FornecedorLabel = new System.Windows.Forms.Label();
            quantidade_em_EstoqueLabel = new System.Windows.Forms.Label();
            estoque_CriticoLabel = new System.Windows.Forms.Label();
            comprarLabel = new System.Windows.Forms.Label();
            nome_do_FornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_em_EstoqueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque_CriticoNumericUpDown)).BeginInit();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_do_EstoqueLabel
            // 
            código_do_EstoqueLabel.AutoSize = true;
            código_do_EstoqueLabel.Location = new System.Drawing.Point(162, 38);
            código_do_EstoqueLabel.Name = "código_do_EstoqueLabel";
            código_do_EstoqueLabel.Size = new System.Drawing.Size(100, 13);
            código_do_EstoqueLabel.TabIndex = 0;
            código_do_EstoqueLabel.Text = "Código do Estoque:";
            // 
            // nome_do_ProdutoLabel
            // 
            nome_do_ProdutoLabel.AutoSize = true;
            nome_do_ProdutoLabel.Location = new System.Drawing.Point(162, 67);
            nome_do_ProdutoLabel.Name = "nome_do_ProdutoLabel";
            nome_do_ProdutoLabel.Size = new System.Drawing.Size(93, 13);
            nome_do_ProdutoLabel.TabIndex = 2;
            nome_do_ProdutoLabel.Text = "Nome do Produto:";
            // 
            // código_do_ProdutoLabel
            // 
            código_do_ProdutoLabel.AutoSize = true;
            código_do_ProdutoLabel.Location = new System.Drawing.Point(162, 94);
            código_do_ProdutoLabel.Name = "código_do_ProdutoLabel";
            código_do_ProdutoLabel.Size = new System.Drawing.Size(98, 13);
            código_do_ProdutoLabel.TabIndex = 4;
            código_do_ProdutoLabel.Text = "Código do Produto:";
            // 
            // código_do_FornecedorLabel
            // 
            código_do_FornecedorLabel.AutoSize = true;
            código_do_FornecedorLabel.Location = new System.Drawing.Point(162, 148);
            código_do_FornecedorLabel.Name = "código_do_FornecedorLabel";
            código_do_FornecedorLabel.Size = new System.Drawing.Size(115, 13);
            código_do_FornecedorLabel.TabIndex = 6;
            código_do_FornecedorLabel.Text = "Código do Fornecedor:";
            // 
            // quantidade_em_EstoqueLabel
            // 
            quantidade_em_EstoqueLabel.AutoSize = true;
            quantidade_em_EstoqueLabel.Location = new System.Drawing.Point(162, 198);
            quantidade_em_EstoqueLabel.Name = "quantidade_em_EstoqueLabel";
            quantidade_em_EstoqueLabel.Size = new System.Drawing.Size(124, 13);
            quantidade_em_EstoqueLabel.TabIndex = 8;
            quantidade_em_EstoqueLabel.Text = "Quantidade em Estoque:";
            // 
            // estoque_CriticoLabel
            // 
            estoque_CriticoLabel.AutoSize = true;
            estoque_CriticoLabel.Location = new System.Drawing.Point(162, 172);
            estoque_CriticoLabel.Name = "estoque_CriticoLabel";
            estoque_CriticoLabel.Size = new System.Drawing.Size(81, 13);
            estoque_CriticoLabel.TabIndex = 10;
            estoque_CriticoLabel.Text = "Estoque Critico:";
            // 
            // comprarLabel
            // 
            comprarLabel.AutoSize = true;
            comprarLabel.Location = new System.Drawing.Point(162, 227);
            comprarLabel.Name = "comprarLabel";
            comprarLabel.Size = new System.Drawing.Size(49, 13);
            comprarLabel.TabIndex = 12;
            comprarLabel.Text = "Comprar:";
            // 
            // nome_do_FornecedorLabel
            // 
            nome_do_FornecedorLabel.AutoSize = true;
            nome_do_FornecedorLabel.Location = new System.Drawing.Point(162, 121);
            nome_do_FornecedorLabel.Name = "nome_do_FornecedorLabel";
            nome_do_FornecedorLabel.Size = new System.Drawing.Size(110, 13);
            nome_do_FornecedorLabel.TabIndex = 87;
            nome_do_FornecedorLabel.Text = "Nome do Fornecedor:";
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantinaTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
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
            // código_do_EstoqueLabel1
            // 
            this.código_do_EstoqueLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Código do Estoque", true));
            this.código_do_EstoqueLabel1.Location = new System.Drawing.Point(292, 38);
            this.código_do_EstoqueLabel1.Name = "código_do_EstoqueLabel1";
            this.código_do_EstoqueLabel1.Size = new System.Drawing.Size(121, 23);
            this.código_do_EstoqueLabel1.TabIndex = 1;
            this.código_do_EstoqueLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nome_do_ProdutoComboBox
            // 
            this.nome_do_ProdutoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Nome do Produto", true));
            this.nome_do_ProdutoComboBox.DataSource = this.produtosBindingSource;
            this.nome_do_ProdutoComboBox.DisplayMember = "Descrição";
            this.nome_do_ProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nome_do_ProdutoComboBox.FormattingEnabled = true;
            this.nome_do_ProdutoComboBox.Location = new System.Drawing.Point(292, 64);
            this.nome_do_ProdutoComboBox.Name = "nome_do_ProdutoComboBox";
            this.nome_do_ProdutoComboBox.Size = new System.Drawing.Size(121, 21);
            this.nome_do_ProdutoComboBox.TabIndex = 0;
            this.nome_do_ProdutoComboBox.ValueMember = "Descrição";
            this.nome_do_ProdutoComboBox.SelectedIndexChanged += new System.EventHandler(this.nome_do_ProdutoComboBox_SelectedIndexChanged);
            this.nome_do_ProdutoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProdutoComboBox_KeyDown);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // código_do_ProdutoComboBox
            // 
            this.código_do_ProdutoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Código do Produto", true));
            this.código_do_ProdutoComboBox.DataSource = this.produtosBindingSource;
            this.código_do_ProdutoComboBox.DisplayMember = "Código do Produto";
            this.código_do_ProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.código_do_ProdutoComboBox.Enabled = false;
            this.código_do_ProdutoComboBox.FormattingEnabled = true;
            this.código_do_ProdutoComboBox.Location = new System.Drawing.Point(292, 91);
            this.código_do_ProdutoComboBox.Name = "código_do_ProdutoComboBox";
            this.código_do_ProdutoComboBox.Size = new System.Drawing.Size(77, 21);
            this.código_do_ProdutoComboBox.TabIndex = 1;
            this.código_do_ProdutoComboBox.ValueMember = "Código do Produto";
            this.código_do_ProdutoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProdutoComboBox_KeyDown);
            // 
            // código_do_FornecedorComboBox
            // 
            this.código_do_FornecedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Código do Fornecedor", true));
            this.código_do_FornecedorComboBox.DataSource = this.fornecedoresBindingSource;
            this.código_do_FornecedorComboBox.DisplayMember = "Código do Fornecedor";
            this.código_do_FornecedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.código_do_FornecedorComboBox.Enabled = false;
            this.código_do_FornecedorComboBox.FormattingEnabled = true;
            this.código_do_FornecedorComboBox.Location = new System.Drawing.Point(292, 145);
            this.código_do_FornecedorComboBox.Name = "código_do_FornecedorComboBox";
            this.código_do_FornecedorComboBox.Size = new System.Drawing.Size(77, 21);
            this.código_do_FornecedorComboBox.TabIndex = 3;
            this.código_do_FornecedorComboBox.ValueMember = "Código do Fornecedor";
            this.código_do_FornecedorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProdutoComboBox_KeyDown);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // quantidade_em_EstoqueNumericUpDown
            // 
            this.quantidade_em_EstoqueNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estoqueBindingSource, "Quantidade em Estoque", true));
            this.quantidade_em_EstoqueNumericUpDown.Location = new System.Drawing.Point(292, 198);
            this.quantidade_em_EstoqueNumericUpDown.Name = "quantidade_em_EstoqueNumericUpDown";
            this.quantidade_em_EstoqueNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.quantidade_em_EstoqueNumericUpDown.TabIndex = 5;
            this.quantidade_em_EstoqueNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidade_em_EstoqueNumericUpDown.ValueChanged += new System.EventHandler(this.quantidade_em_EstoqueNumericUpDown_ValueChanged);
            this.quantidade_em_EstoqueNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProdutoComboBox_KeyDown);
            // 
            // estoque_CriticoNumericUpDown
            // 
            this.estoque_CriticoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estoqueBindingSource, "Estoque Critico", true));
            this.estoque_CriticoNumericUpDown.Location = new System.Drawing.Point(292, 172);
            this.estoque_CriticoNumericUpDown.Name = "estoque_CriticoNumericUpDown";
            this.estoque_CriticoNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.estoque_CriticoNumericUpDown.TabIndex = 4;
            this.estoque_CriticoNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.estoque_CriticoNumericUpDown.ValueChanged += new System.EventHandler(this.estoque_CriticoNumericUpDown_ValueChanged);
            this.estoque_CriticoNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProdutoComboBox_KeyDown);
            // 
            // comprarCheckBox
            // 
            this.comprarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.estoqueBindingSource, "Comprar", true));
            this.comprarCheckBox.Enabled = false;
            this.comprarCheckBox.Location = new System.Drawing.Point(292, 222);
            this.comprarCheckBox.Name = "comprarCheckBox";
            this.comprarCheckBox.Size = new System.Drawing.Size(121, 24);
            this.comprarCheckBox.TabIndex = 6;
            this.comprarCheckBox.Text = "Sim/Não";
            this.comprarCheckBox.UseVisualStyleBackColor = true;
            this.comprarCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProdutoComboBox_KeyDown);
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
            this.DataMenu.Size = new System.Drawing.Size(430, 25);
            this.DataMenu.TabIndex = 86;
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
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // nome_do_FornecedorComboBox
            // 
            this.nome_do_FornecedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Nome do Fornecedor", true));
            this.nome_do_FornecedorComboBox.DataSource = this.fornecedoresBindingSource;
            this.nome_do_FornecedorComboBox.DisplayMember = "Razão Social";
            this.nome_do_FornecedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nome_do_FornecedorComboBox.FormattingEnabled = true;
            this.nome_do_FornecedorComboBox.Location = new System.Drawing.Point(292, 118);
            this.nome_do_FornecedorComboBox.Name = "nome_do_FornecedorComboBox";
            this.nome_do_FornecedorComboBox.Size = new System.Drawing.Size(121, 21);
            this.nome_do_FornecedorComboBox.TabIndex = 2;
            this.nome_do_FornecedorComboBox.ValueMember = "Razão Social";
            this.nome_do_FornecedorComboBox.SelectedIndexChanged += new System.EventHandler(this.nome_do_FornecedorComboBox_SelectedIndexChanged);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 251);
            this.Controls.Add(nome_do_FornecedorLabel);
            this.Controls.Add(this.nome_do_FornecedorComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataMenu);
            this.Controls.Add(código_do_EstoqueLabel);
            this.Controls.Add(this.código_do_EstoqueLabel1);
            this.Controls.Add(nome_do_ProdutoLabel);
            this.Controls.Add(this.nome_do_ProdutoComboBox);
            this.Controls.Add(código_do_ProdutoLabel);
            this.Controls.Add(this.código_do_ProdutoComboBox);
            this.Controls.Add(código_do_FornecedorLabel);
            this.Controls.Add(this.código_do_FornecedorComboBox);
            this.Controls.Add(quantidade_em_EstoqueLabel);
            this.Controls.Add(this.quantidade_em_EstoqueNumericUpDown);
            this.Controls.Add(estoque_CriticoLabel);
            this.Controls.Add(this.estoque_CriticoNumericUpDown);
            this.Controls.Add(comprarLabel);
            this.Controls.Add(this.comprarCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informações do Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade_em_EstoqueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque_CriticoNumericUpDown)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label código_do_EstoqueLabel1;
        private System.Windows.Forms.ComboBox nome_do_ProdutoComboBox;
        private System.Windows.Forms.ComboBox código_do_ProdutoComboBox;
        private System.Windows.Forms.ComboBox código_do_FornecedorComboBox;
        private System.Windows.Forms.NumericUpDown quantidade_em_EstoqueNumericUpDown;
        private System.Windows.Forms.NumericUpDown estoque_CriticoNumericUpDown;
        private System.Windows.Forms.CheckBox comprarCheckBox;
        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox nome_do_FornecedorComboBox;
    }
}