namespace System_KWB
{
    partial class frmCantina
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
            System.Windows.Forms.Label produtoLabel;
            System.Windows.Forms.Label descriçãoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valor_UnitarioLabel;
            System.Windows.Forms.Label valor_TotalLabel1;
            System.Windows.Forms.Label vendaLabel1;
            System.Windows.Forms.Label código_da_VendaLabel;
            System.Windows.Forms.Label data_da_VendaLabel;
            System.Windows.Forms.Label valor_TotalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCantina));
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            this.cantinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataMenu = new System.Windows.Forms.ToolStrip();
            this.DataPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.DataAnterior = new System.Windows.Forms.ToolStripButton();
            this.DataProximo = new System.Windows.Forms.ToolStripButton();
            this.DataUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataAdicionar = new System.Windows.Forms.ToolStripButton();
            this.DataRemover = new System.Windows.Forms.ToolStripButton();
            this.DataSalvar = new System.Windows.Forms.ToolStripButton();
            this.código_da_VendaLabel1 = new System.Windows.Forms.Label();
            this.data_da_VendaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabItens = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.vendaLabel2 = new System.Windows.Forms.Label();
            this.produtoComboBox = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriçãoComboBox = new System.Windows.Forms.ComboBox();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor_UnitarioTextBox = new System.Windows.Forms.TextBox();
            this.sub_TotalTextBox = new System.Windows.Forms.TextBox();
            this.produtosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.ProdutosTableAdapter();
            this.itens_da_VendaTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.Itens_da_VendaTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.itens_da_VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantinaTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.CantinaTableAdapter();
            produtoLabel = new System.Windows.Forms.Label();
            descriçãoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valor_UnitarioLabel = new System.Windows.Forms.Label();
            valor_TotalLabel1 = new System.Windows.Forms.Label();
            vendaLabel1 = new System.Windows.Forms.Label();
            código_da_VendaLabel = new System.Windows.Forms.Label();
            data_da_VendaLabel = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaBindingSource)).BeginInit();
            this.DataMenu.SuspendLayout();
            this.tabItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_da_VendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoLabel
            // 
            produtoLabel.AutoSize = true;
            produtoLabel.Location = new System.Drawing.Point(15, 72);
            produtoLabel.Name = "produtoLabel";
            produtoLabel.Size = new System.Drawing.Size(98, 13);
            produtoLabel.TabIndex = 4;
            produtoLabel.Text = "Código do Produto:";
            // 
            // descriçãoLabel
            // 
            descriçãoLabel.AutoSize = true;
            descriçãoLabel.Location = new System.Drawing.Point(15, 45);
            descriçãoLabel.Name = "descriçãoLabel";
            descriçãoLabel.Size = new System.Drawing.Size(90, 13);
            descriçãoLabel.TabIndex = 6;
            descriçãoLabel.Text = "Nome do Produto";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(297, 16);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 8;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valor_UnitarioLabel
            // 
            valor_UnitarioLabel.AutoSize = true;
            valor_UnitarioLabel.Location = new System.Drawing.Point(297, 45);
            valor_UnitarioLabel.Name = "valor_UnitarioLabel";
            valor_UnitarioLabel.Size = new System.Drawing.Size(73, 13);
            valor_UnitarioLabel.TabIndex = 10;
            valor_UnitarioLabel.Text = "Valor Unitario:";
            // 
            // valor_TotalLabel1
            // 
            valor_TotalLabel1.AutoSize = true;
            valor_TotalLabel1.Location = new System.Drawing.Point(297, 75);
            valor_TotalLabel1.Name = "valor_TotalLabel1";
            valor_TotalLabel1.Size = new System.Drawing.Size(56, 13);
            valor_TotalLabel1.TabIndex = 12;
            valor_TotalLabel1.Text = "Sub Total:";
            // 
            // vendaLabel1
            // 
            vendaLabel1.AutoSize = true;
            vendaLabel1.Location = new System.Drawing.Point(15, 16);
            vendaLabel1.Name = "vendaLabel1";
            vendaLabel1.Size = new System.Drawing.Size(92, 13);
            vendaLabel1.TabIndex = 13;
            vendaLabel1.Text = "Código da Venda:";
            // 
            // código_da_VendaLabel
            // 
            código_da_VendaLabel.AutoSize = true;
            código_da_VendaLabel.Location = new System.Drawing.Point(16, 57);
            código_da_VendaLabel.Name = "código_da_VendaLabel";
            código_da_VendaLabel.Size = new System.Drawing.Size(92, 13);
            código_da_VendaLabel.TabIndex = 97;
            código_da_VendaLabel.Text = "Código da Venda:";
            // 
            // data_da_VendaLabel
            // 
            data_da_VendaLabel.AutoSize = true;
            data_da_VendaLabel.Location = new System.Drawing.Point(16, 87);
            data_da_VendaLabel.Name = "data_da_VendaLabel";
            data_da_VendaLabel.Size = new System.Drawing.Size(82, 13);
            data_da_VendaLabel.TabIndex = 99;
            data_da_VendaLabel.Text = "Data da Venda:";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Location = new System.Drawing.Point(16, 118);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(61, 13);
            valor_TotalLabel.TabIndex = 101;
            valor_TotalLabel.Text = "Valor Total:";
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVenda);
            this.tabControl.Controls.Add(this.tabItens);
            this.tabControl.Location = new System.Drawing.Point(156, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(540, 346);
            this.tabControl.TabIndex = 93;
            this.tabControl.TabStop = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabVenda
            // 
            this.tabVenda.Controls.Add(this.valor_TotalTextBox);
            this.tabVenda.Controls.Add(this.DataMenu);
            this.tabVenda.Controls.Add(código_da_VendaLabel);
            this.tabVenda.Controls.Add(this.código_da_VendaLabel1);
            this.tabVenda.Controls.Add(data_da_VendaLabel);
            this.tabVenda.Controls.Add(this.data_da_VendaDateTimePicker);
            this.tabVenda.Controls.Add(valor_TotalLabel);
            this.tabVenda.Location = new System.Drawing.Point(4, 22);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenda.Size = new System.Drawing.Size(532, 320);
            this.tabVenda.TabIndex = 0;
            this.tabVenda.Text = "Venda";
            this.tabVenda.UseVisualStyleBackColor = true;
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cantinaBindingSource, "Valor_Total", true));
            this.valor_TotalTextBox.Enabled = false;
            this.valor_TotalTextBox.Location = new System.Drawing.Point(114, 115);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.Size = new System.Drawing.Size(124, 20);
            this.valor_TotalTextBox.TabIndex = 109;
            this.valor_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantinaBindingSource
            // 
            this.cantinaBindingSource.DataMember = "Cantina";
            this.cantinaBindingSource.DataSource = this.bD_KWB_DataSet;
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
            this.DataMenu.Location = new System.Drawing.Point(3, 3);
            this.DataMenu.Name = "DataMenu";
            this.DataMenu.Size = new System.Drawing.Size(526, 25);
            this.DataMenu.TabIndex = 103;
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
            // código_da_VendaLabel1
            // 
            this.código_da_VendaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cantinaBindingSource, "Código da Venda", true));
            this.código_da_VendaLabel1.Location = new System.Drawing.Point(114, 55);
            this.código_da_VendaLabel1.Name = "código_da_VendaLabel1";
            this.código_da_VendaLabel1.Size = new System.Drawing.Size(162, 23);
            this.código_da_VendaLabel1.TabIndex = 98;
            this.código_da_VendaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // data_da_VendaDateTimePicker
            // 
            this.data_da_VendaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cantinaBindingSource, "Data da Venda", true));
            this.data_da_VendaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_da_VendaDateTimePicker.Location = new System.Drawing.Point(114, 81);
            this.data_da_VendaDateTimePicker.Name = "data_da_VendaDateTimePicker";
            this.data_da_VendaDateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.data_da_VendaDateTimePicker.TabIndex = 0;
            this.data_da_VendaDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // tabItens
            // 
            this.tabItens.AutoScroll = true;
            this.tabItens.Controls.Add(this.btnLimpar);
            this.tabItens.Controls.Add(this.btnAtualizar);
            this.tabItens.Controls.Add(this.btnCarregar);
            this.tabItens.Controls.Add(this.button2);
            this.tabItens.Controls.Add(this.btnAdcionar);
            this.tabItens.Controls.Add(this.DataGrid);
            this.tabItens.Controls.Add(vendaLabel1);
            this.tabItens.Controls.Add(this.vendaLabel2);
            this.tabItens.Controls.Add(produtoLabel);
            this.tabItens.Controls.Add(this.produtoComboBox);
            this.tabItens.Controls.Add(descriçãoLabel);
            this.tabItens.Controls.Add(this.descriçãoComboBox);
            this.tabItens.Controls.Add(quantidadeLabel);
            this.tabItens.Controls.Add(this.quantidadeNumericUpDown);
            this.tabItens.Controls.Add(valor_UnitarioLabel);
            this.tabItens.Controls.Add(this.valor_UnitarioTextBox);
            this.tabItens.Controls.Add(valor_TotalLabel1);
            this.tabItens.Controls.Add(this.sub_TotalTextBox);
            this.tabItens.Location = new System.Drawing.Point(4, 22);
            this.tabItens.Name = "tabItens";
            this.tabItens.Padding = new System.Windows.Forms.Padding(3);
            this.tabItens.Size = new System.Drawing.Size(532, 320);
            this.tabItens.TabIndex = 1;
            this.tabItens.Text = "Itens da Venda";
            this.tabItens.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(453, 111);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 26);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimparDados_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(88, 111);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(64, 26);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            this.btnAtualizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.White;
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.Location = new System.Drawing.Point(383, 111);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(64, 26);
            this.btnCarregar.TabIndex = 8;
            this.btnCarregar.TabStop = false;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregarDados_Click);
            this.btnCarregar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(158, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 26);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnRemoverDados_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.White;
            this.btnAdcionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdcionar.Location = new System.Drawing.Point(18, 111);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(64, 26);
            this.btnAdcionar.TabIndex = 5;
            this.btnAdcionar.TabStop = false;
            this.btnAdcionar.Text = "Adicionar";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdicionarDados_Click);
            this.btnAdcionar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.GridColor = System.Drawing.Color.Silver;
            this.DataGrid.Location = new System.Drawing.Point(18, 140);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(499, 170);
            this.DataGrid.TabIndex = 10;
            this.DataGrid.TabStop = false;
            this.DataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_MouseClick);
            // 
            // vendaLabel2
            // 
            this.vendaLabel2.Location = new System.Drawing.Point(117, 16);
            this.vendaLabel2.Name = "vendaLabel2";
            this.vendaLabel2.Size = new System.Drawing.Size(142, 23);
            this.vendaLabel2.TabIndex = 14;
            this.vendaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // produtoComboBox
            // 
            this.produtoComboBox.DataSource = this.produtosBindingSource;
            this.produtoComboBox.DisplayMember = "Código do Produto";
            this.produtoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.produtoComboBox.Enabled = false;
            this.produtoComboBox.FormattingEnabled = true;
            this.produtoComboBox.Location = new System.Drawing.Point(120, 69);
            this.produtoComboBox.Name = "produtoComboBox";
            this.produtoComboBox.Size = new System.Drawing.Size(75, 21);
            this.produtoComboBox.TabIndex = 1;
            this.produtoComboBox.ValueMember = "Código do Produto";
            this.produtoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // descriçãoComboBox
            // 
            this.descriçãoComboBox.DataSource = this.produtosBindingSource;
            this.descriçãoComboBox.DisplayMember = "Descrição";
            this.descriçãoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descriçãoComboBox.FormattingEnabled = true;
            this.descriçãoComboBox.Location = new System.Drawing.Point(120, 42);
            this.descriçãoComboBox.Name = "descriçãoComboBox";
            this.descriçãoComboBox.Size = new System.Drawing.Size(139, 21);
            this.descriçãoComboBox.TabIndex = 0;
            this.descriçãoComboBox.ValueMember = "Descrição";
            this.descriçãoComboBox.SelectedIndexChanged += new System.EventHandler(this.descriçãoComboBox_SelectedIndexChanged);
            this.descriçãoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(384, 19);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.quantidadeNumericUpDown.TabIndex = 2;
            this.quantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidadeNumericUpDown.ValueChanged += new System.EventHandler(this.quantidadeNumericUpDown_ValueChanged);
            this.quantidadeNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // valor_UnitarioTextBox
            // 
            this.valor_UnitarioTextBox.Location = new System.Drawing.Point(384, 45);
            this.valor_UnitarioTextBox.Name = "valor_UnitarioTextBox";
            this.valor_UnitarioTextBox.Size = new System.Drawing.Size(121, 20);
            this.valor_UnitarioTextBox.TabIndex = 3;
            this.valor_UnitarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valor_UnitarioTextBox.TextChanged += new System.EventHandler(this.valor_UnitarioTextBox_TextChanged);
            this.valor_UnitarioTextBox.Enter += new System.EventHandler(this.valor_UnitarioTextBox_Enter);
            this.valor_UnitarioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            this.valor_UnitarioTextBox.Leave += new System.EventHandler(this.valor_UnitarioTextBox_Leave);
            // 
            // sub_TotalTextBox
            // 
            this.sub_TotalTextBox.Enabled = false;
            this.sub_TotalTextBox.Location = new System.Drawing.Point(384, 72);
            this.sub_TotalTextBox.Name = "sub_TotalTextBox";
            this.sub_TotalTextBox.Size = new System.Drawing.Size(121, 20);
            this.sub_TotalTextBox.TabIndex = 4;
            this.sub_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sub_TotalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_da_VendaDateTimePicker_KeyDown);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // itens_da_VendaTableAdapter
            // 
            this.itens_da_VendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantinaTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = null;
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
            // itens_da_VendaBindingSource
            // 
            this.itens_da_VendaBindingSource.DataMember = "Itens_da_Venda";
            this.itens_da_VendaBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // cantinaTableAdapter
            // 
            this.cantinaTableAdapter.ClearBeforeFill = true;
            // 
            // frmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 369);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendas da Cantina";
            this.Load += new System.EventHandler(this.frmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabVenda.ResumeLayout(false);
            this.tabVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantinaBindingSource)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            this.tabItens.ResumeLayout(false);
            this.tabItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itens_da_VendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVenda;
        private System.Windows.Forms.TabPage tabItens;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource itens_da_VendaBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.Itens_da_VendaTableAdapter itens_da_VendaTableAdapter;
        private System.Windows.Forms.ComboBox produtoComboBox;
        private System.Windows.Forms.ComboBox descriçãoComboBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.TextBox valor_UnitarioTextBox;
        private System.Windows.Forms.TextBox sub_TotalTextBox;
        private System.Windows.Forms.Label vendaLabel2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.BindingSource cantinaBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.CantinaTableAdapter cantinaTableAdapter;
        private System.Windows.Forms.Label código_da_VendaLabel1;
        private System.Windows.Forms.DateTimePicker data_da_VendaDateTimePicker;
        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
    }
}