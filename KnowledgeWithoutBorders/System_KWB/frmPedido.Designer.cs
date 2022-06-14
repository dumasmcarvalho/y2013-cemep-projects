namespace System_KWB
{
    partial class frmPedido
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
            System.Windows.Forms.Label código_de_PedidoLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label preçoLabel;
            System.Windows.Forms.Label link_de_CompraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
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
            this.pedido_de_LivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedido_de_LivrosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.Pedido_de_LivrosTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.código_de_PedidoLabel1 = new System.Windows.Forms.Label();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.preçoTextBox = new System.Windows.Forms.TextBox();
            this.link_de_CompraTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.Mensagem = new System.Windows.Forms.ToolTip(this.components);
            código_de_PedidoLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            preçoLabel = new System.Windows.Forms.Label();
            link_de_CompraLabel = new System.Windows.Forms.Label();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_de_LivrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_de_PedidoLabel
            // 
            código_de_PedidoLabel.AutoSize = true;
            código_de_PedidoLabel.Location = new System.Drawing.Point(166, 40);
            código_de_PedidoLabel.Name = "código_de_PedidoLabel";
            código_de_PedidoLabel.Size = new System.Drawing.Size(94, 13);
            código_de_PedidoLabel.TabIndex = 85;
            código_de_PedidoLabel.Text = "Código de Pedido:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(166, 69);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 87;
            tituloLabel.Text = "Titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(166, 95);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 89;
            autorLabel.Text = "Autor:";
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(166, 124);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(45, 13);
            generoLabel.TabIndex = 91;
            generoLabel.Text = "Genero:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Location = new System.Drawing.Point(166, 253);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(43, 13);
            editoraLabel.TabIndex = 93;
            editoraLabel.Text = "Editora:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(166, 278);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 95;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // preçoLabel
            // 
            preçoLabel.AutoSize = true;
            preçoLabel.Location = new System.Drawing.Point(166, 305);
            preçoLabel.Name = "preçoLabel";
            preçoLabel.Size = new System.Drawing.Size(38, 13);
            preçoLabel.TabIndex = 97;
            preçoLabel.Text = "Preço:";
            // 
            // link_de_CompraLabel
            // 
            link_de_CompraLabel.AutoSize = true;
            link_de_CompraLabel.Location = new System.Drawing.Point(166, 331);
            link_de_CompraLabel.Name = "link_de_CompraLabel";
            link_de_CompraLabel.Size = new System.Drawing.Size(84, 13);
            link_de_CompraLabel.TabIndex = 99;
            link_de_CompraLabel.Text = "Link de Compra:";
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
            this.DataMenu.Size = new System.Drawing.Size(503, 25);
            this.DataMenu.TabIndex = 84;
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
            // pedido_de_LivrosBindingSource
            // 
            this.pedido_de_LivrosBindingSource.DataMember = "Pedido de Livros";
            this.pedido_de_LivrosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // pedido_de_LivrosTableAdapter
            // 
            this.pedido_de_LivrosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_AlunoTableAdapter = null;
            this.tableAdapterManager.Pagamento_do_ProfessorTableAdapter = null;
            this.tableAdapterManager.Pedido_de_LivrosTableAdapter = this.pedido_de_LivrosTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // código_de_PedidoLabel1
            // 
            this.código_de_PedidoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_de_LivrosBindingSource, "Código de Pedido", true));
            this.código_de_PedidoLabel1.Location = new System.Drawing.Point(266, 40);
            this.código_de_PedidoLabel1.Name = "código_de_PedidoLabel1";
            this.código_de_PedidoLabel1.Size = new System.Drawing.Size(225, 23);
            this.código_de_PedidoLabel1.TabIndex = 86;
            this.código_de_PedidoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_de_LivrosBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(266, 66);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(225, 20);
            this.tituloTextBox.TabIndex = 88;
            this.tituloTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_de_LivrosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(266, 92);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(149, 20);
            this.autorTextBox.TabIndex = 90;
            this.autorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_de_LivrosBindingSource, "Editora", true));
            this.editoraTextBox.Location = new System.Drawing.Point(266, 250);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(120, 20);
            this.editoraTextBox.TabIndex = 94;
            this.editoraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pedido_de_LivrosBindingSource, "Quantidade", true));
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(266, 276);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.quantidadeNumericUpDown.TabIndex = 96;
            this.quantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidadeNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // preçoTextBox
            // 
            this.preçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_de_LivrosBindingSource, "Preço", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.preçoTextBox.Location = new System.Drawing.Point(266, 302);
            this.preçoTextBox.Name = "preçoTextBox";
            this.preçoTextBox.Size = new System.Drawing.Size(76, 20);
            this.preçoTextBox.TabIndex = 98;
            this.preçoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.preçoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // link_de_CompraTextBox
            // 
            this.link_de_CompraTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.link_de_CompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_de_LivrosBindingSource, "Link de Compra", true));
            this.link_de_CompraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_de_CompraTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.link_de_CompraTextBox.Location = new System.Drawing.Point(266, 328);
            this.link_de_CompraTextBox.Name = "link_de_CompraTextBox";
            this.link_de_CompraTextBox.Size = new System.Drawing.Size(120, 13);
            this.link_de_CompraTextBox.TabIndex = 100;
            this.link_de_CompraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 331);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
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
            this.generoComboBox.Location = new System.Drawing.Point(266, 121);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(104, 21);
            this.generoComboBox.TabIndex = 105;
            this.generoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = true;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(406, 121);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(24, 24);
            this.btnRemover.TabIndex = 104;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            this.btnRemover.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(376, 121);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(24, 24);
            this.btnAdicionar.TabIndex = 103;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            this.btnAdicionar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // generoTextBox
            // 
            this.generoTextBox.BackColor = System.Drawing.Color.White;
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedido_de_LivrosBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(266, 147);
            this.generoTextBox.Multiline = true;
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.ReadOnly = true;
            this.generoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generoTextBox.Size = new System.Drawing.Size(104, 90);
            this.generoTextBox.TabIndex = 102;
            this.generoTextBox.TabStop = false;
            this.generoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tituloTextBox_KeyDown);
            // 
            // Mensagem
            // 
            this.Mensagem.AutomaticDelay = 200;
            this.Mensagem.BackColor = System.Drawing.Color.White;
            this.Mensagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.Mensagem.ToolTipTitle = "Campo Inválido";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 358);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(código_de_PedidoLabel);
            this.Controls.Add(this.código_de_PedidoLabel1);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeNumericUpDown);
            this.Controls.Add(preçoLabel);
            this.Controls.Add(this.preçoTextBox);
            this.Controls.Add(link_de_CompraLabel);
            this.Controls.Add(this.link_de_CompraTextBox);
            this.Controls.Add(this.DataMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Requerimento de Livros";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.MouseHover += new System.EventHandler(this.frmPedido_MouseHover);
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_de_LivrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
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
        private System.Windows.Forms.BindingSource pedido_de_LivrosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.Pedido_de_LivrosTableAdapter pedido_de_LivrosTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label código_de_PedidoLabel1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.TextBox preçoTextBox;
        private System.Windows.Forms.TextBox link_de_CompraTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox generoTextBox;
        public System.Windows.Forms.ToolTip Mensagem;
    }
}