namespace System_KWB
{
    partial class frmMensalidade
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
            System.Windows.Forms.Label código_da_MensalidadeLabel;
            System.Windows.Forms.Label nome_do_AlunoLabel;
            System.Windows.Forms.Label matrícula_do_AlunoLabel;
            System.Windows.Forms.Label nome_do_CursoLabel;
            System.Windows.Forms.Label código_do_CursoLabel;
            System.Windows.Forms.Label ano_do_CursoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigo_da_ParcelaLabel;
            System.Windows.Forms.Label forma_de_PagamentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensalidade));
            this.código_da_MensalidadeLabel1 = new System.Windows.Forms.Label();
            this.pagamento_do_AlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.nome_do_AlunoComboBox = new System.Windows.Forms.ComboBox();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matrícula_do_AlunoComboBox = new System.Windows.Forms.ComboBox();
            this.nome_do_CursoComboBox = new System.Windows.Forms.ComboBox();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.código_do_CursoComboBox = new System.Windows.Forms.ComboBox();
            this.ano_do_CursoComboBox = new System.Windows.Forms.ComboBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.codigo_da_ParcelaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.forma_de_PagamentoComboBox = new System.Windows.Forms.ComboBox();
            this.pagamento_do_AlunoTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.Pagamento_do_AlunoTableAdapter();
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
            this.alunosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.AlunosTableAdapter();
            this.cursosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.CursosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            código_da_MensalidadeLabel = new System.Windows.Forms.Label();
            nome_do_AlunoLabel = new System.Windows.Forms.Label();
            matrícula_do_AlunoLabel = new System.Windows.Forms.Label();
            nome_do_CursoLabel = new System.Windows.Forms.Label();
            código_do_CursoLabel = new System.Windows.Forms.Label();
            ano_do_CursoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigo_da_ParcelaLabel = new System.Windows.Forms.Label();
            forma_de_PagamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pagamento_do_AlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_da_MensalidadeLabel
            // 
            código_da_MensalidadeLabel.AutoSize = true;
            código_da_MensalidadeLabel.Location = new System.Drawing.Point(165, 38);
            código_da_MensalidadeLabel.Name = "código_da_MensalidadeLabel";
            código_da_MensalidadeLabel.Size = new System.Drawing.Size(121, 13);
            código_da_MensalidadeLabel.TabIndex = 1;
            código_da_MensalidadeLabel.Text = "Código da Mensalidade:";
            // 
            // nome_do_AlunoLabel
            // 
            nome_do_AlunoLabel.AutoSize = true;
            nome_do_AlunoLabel.Location = new System.Drawing.Point(165, 67);
            nome_do_AlunoLabel.Name = "nome_do_AlunoLabel";
            nome_do_AlunoLabel.Size = new System.Drawing.Size(83, 13);
            nome_do_AlunoLabel.TabIndex = 3;
            nome_do_AlunoLabel.Text = "Nome do Aluno:";
            // 
            // matrícula_do_AlunoLabel
            // 
            matrícula_do_AlunoLabel.AutoSize = true;
            matrícula_do_AlunoLabel.Location = new System.Drawing.Point(165, 94);
            matrícula_do_AlunoLabel.Name = "matrícula_do_AlunoLabel";
            matrícula_do_AlunoLabel.Size = new System.Drawing.Size(100, 13);
            matrícula_do_AlunoLabel.TabIndex = 5;
            matrícula_do_AlunoLabel.Text = "Matrícula do Aluno:";
            // 
            // nome_do_CursoLabel
            // 
            nome_do_CursoLabel.AutoSize = true;
            nome_do_CursoLabel.Location = new System.Drawing.Point(165, 121);
            nome_do_CursoLabel.Name = "nome_do_CursoLabel";
            nome_do_CursoLabel.Size = new System.Drawing.Size(83, 13);
            nome_do_CursoLabel.TabIndex = 7;
            nome_do_CursoLabel.Text = "Nome do Curso:";
            // 
            // código_do_CursoLabel
            // 
            código_do_CursoLabel.AutoSize = true;
            código_do_CursoLabel.Location = new System.Drawing.Point(165, 148);
            código_do_CursoLabel.Name = "código_do_CursoLabel";
            código_do_CursoLabel.Size = new System.Drawing.Size(88, 13);
            código_do_CursoLabel.TabIndex = 9;
            código_do_CursoLabel.Text = "Código do Curso:";
            // 
            // ano_do_CursoLabel
            // 
            ano_do_CursoLabel.AutoSize = true;
            ano_do_CursoLabel.Location = new System.Drawing.Point(165, 175);
            ano_do_CursoLabel.Name = "ano_do_CursoLabel";
            ano_do_CursoLabel.Size = new System.Drawing.Size(74, 13);
            ano_do_CursoLabel.TabIndex = 11;
            ano_do_CursoLabel.Text = "Ano do Curso:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(165, 202);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 13;
            valorLabel.Text = "Valor:";
            // 
            // codigo_da_ParcelaLabel
            // 
            codigo_da_ParcelaLabel.AutoSize = true;
            codigo_da_ParcelaLabel.Location = new System.Drawing.Point(165, 228);
            codigo_da_ParcelaLabel.Name = "codigo_da_ParcelaLabel";
            codigo_da_ParcelaLabel.Size = new System.Drawing.Size(97, 13);
            codigo_da_ParcelaLabel.TabIndex = 15;
            codigo_da_ParcelaLabel.Text = "Codigo da Parcela:";
            // 
            // forma_de_PagamentoLabel
            // 
            forma_de_PagamentoLabel.AutoSize = true;
            forma_de_PagamentoLabel.Location = new System.Drawing.Point(165, 254);
            forma_de_PagamentoLabel.Name = "forma_de_PagamentoLabel";
            forma_de_PagamentoLabel.Size = new System.Drawing.Size(111, 13);
            forma_de_PagamentoLabel.TabIndex = 17;
            forma_de_PagamentoLabel.Text = "Forma de Pagamento:";
            // 
            // código_da_MensalidadeLabel1
            // 
            this.código_da_MensalidadeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Código da Mensalidade", true));
            this.código_da_MensalidadeLabel1.Location = new System.Drawing.Point(292, 38);
            this.código_da_MensalidadeLabel1.Name = "código_da_MensalidadeLabel1";
            this.código_da_MensalidadeLabel1.Size = new System.Drawing.Size(121, 23);
            this.código_da_MensalidadeLabel1.TabIndex = 2;
            this.código_da_MensalidadeLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pagamento_do_AlunoBindingSource
            // 
            this.pagamento_do_AlunoBindingSource.DataMember = "Pagamento do Aluno";
            this.pagamento_do_AlunoBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nome_do_AlunoComboBox
            // 
            this.nome_do_AlunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Nome do Aluno", true));
            this.nome_do_AlunoComboBox.DataSource = this.alunosBindingSource;
            this.nome_do_AlunoComboBox.DisplayMember = "Nome";
            this.nome_do_AlunoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nome_do_AlunoComboBox.FormattingEnabled = true;
            this.nome_do_AlunoComboBox.Location = new System.Drawing.Point(292, 64);
            this.nome_do_AlunoComboBox.Name = "nome_do_AlunoComboBox";
            this.nome_do_AlunoComboBox.Size = new System.Drawing.Size(167, 21);
            this.nome_do_AlunoComboBox.TabIndex = 0;
            this.nome_do_AlunoComboBox.ValueMember = "Nome";
            this.nome_do_AlunoComboBox.SelectedIndexChanged += new System.EventHandler(this.nome_do_AlunoComboBox_SelectedIndexChanged);
            this.nome_do_AlunoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // matrícula_do_AlunoComboBox
            // 
            this.matrícula_do_AlunoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Matrícula do Aluno", true));
            this.matrícula_do_AlunoComboBox.DataSource = this.alunosBindingSource;
            this.matrícula_do_AlunoComboBox.DisplayMember = "Matricula";
            this.matrícula_do_AlunoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.matrícula_do_AlunoComboBox.Enabled = false;
            this.matrícula_do_AlunoComboBox.FormattingEnabled = true;
            this.matrícula_do_AlunoComboBox.Location = new System.Drawing.Point(292, 91);
            this.matrícula_do_AlunoComboBox.Name = "matrícula_do_AlunoComboBox";
            this.matrícula_do_AlunoComboBox.Size = new System.Drawing.Size(78, 21);
            this.matrícula_do_AlunoComboBox.TabIndex = 1;
            this.matrícula_do_AlunoComboBox.ValueMember = "Matricula";
            this.matrícula_do_AlunoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            // 
            // nome_do_CursoComboBox
            // 
            this.nome_do_CursoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Nome do Curso", true));
            this.nome_do_CursoComboBox.DataSource = this.cursosBindingSource;
            this.nome_do_CursoComboBox.DisplayMember = "Nome";
            this.nome_do_CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.nome_do_CursoComboBox.Enabled = false;
            this.nome_do_CursoComboBox.FormattingEnabled = true;
            this.nome_do_CursoComboBox.Location = new System.Drawing.Point(292, 118);
            this.nome_do_CursoComboBox.Name = "nome_do_CursoComboBox";
            this.nome_do_CursoComboBox.Size = new System.Drawing.Size(167, 21);
            this.nome_do_CursoComboBox.TabIndex = 2;
            this.nome_do_CursoComboBox.ValueMember = "Nome";
            this.nome_do_CursoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // código_do_CursoComboBox
            // 
            this.código_do_CursoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Código do Curso", true));
            this.código_do_CursoComboBox.DataSource = this.alunosBindingSource;
            this.código_do_CursoComboBox.DisplayMember = "Curso";
            this.código_do_CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.código_do_CursoComboBox.Enabled = false;
            this.código_do_CursoComboBox.FormattingEnabled = true;
            this.código_do_CursoComboBox.Location = new System.Drawing.Point(292, 145);
            this.código_do_CursoComboBox.Name = "código_do_CursoComboBox";
            this.código_do_CursoComboBox.Size = new System.Drawing.Size(78, 21);
            this.código_do_CursoComboBox.TabIndex = 3;
            this.código_do_CursoComboBox.ValueMember = "Curso";
            this.código_do_CursoComboBox.SelectedIndexChanged += new System.EventHandler(this.código_do_CursoComboBox_SelectedIndexChanged);
            this.código_do_CursoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            // 
            // ano_do_CursoComboBox
            // 
            this.ano_do_CursoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Ano do Curso", true));
            this.ano_do_CursoComboBox.DataSource = this.alunosBindingSource;
            this.ano_do_CursoComboBox.DisplayMember = "Ano do Curso";
            this.ano_do_CursoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ano_do_CursoComboBox.Enabled = false;
            this.ano_do_CursoComboBox.FormattingEnabled = true;
            this.ano_do_CursoComboBox.Location = new System.Drawing.Point(292, 172);
            this.ano_do_CursoComboBox.Name = "ano_do_CursoComboBox";
            this.ano_do_CursoComboBox.Size = new System.Drawing.Size(121, 21);
            this.ano_do_CursoComboBox.TabIndex = 4;
            this.ano_do_CursoComboBox.ValueMember = "Ano do Curso";
            this.ano_do_CursoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Valor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.valorTextBox.Location = new System.Drawing.Point(292, 199);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(78, 20);
            this.valorTextBox.TabIndex = 5;
            this.valorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valorTextBox.Enter += new System.EventHandler(this.valorTextBox_Enter);
            this.valorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            this.valorTextBox.Leave += new System.EventHandler(this.valorTextBox_Leave);
            // 
            // codigo_da_ParcelaMaskedTextBox
            // 
            this.codigo_da_ParcelaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Codigo da Parcela", true));
            this.codigo_da_ParcelaMaskedTextBox.Location = new System.Drawing.Point(292, 225);
            this.codigo_da_ParcelaMaskedTextBox.Mask = "00-000";
            this.codigo_da_ParcelaMaskedTextBox.Name = "codigo_da_ParcelaMaskedTextBox";
            this.codigo_da_ParcelaMaskedTextBox.Size = new System.Drawing.Size(78, 20);
            this.codigo_da_ParcelaMaskedTextBox.TabIndex = 6;
            this.codigo_da_ParcelaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codigo_da_ParcelaMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            // 
            // forma_de_PagamentoComboBox
            // 
            this.forma_de_PagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_AlunoBindingSource, "Forma de Pagamento", true));
            this.forma_de_PagamentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.forma_de_PagamentoComboBox.FormattingEnabled = true;
            this.forma_de_PagamentoComboBox.Items.AddRange(new object[] {
            "Boleto",
            "Cartão",
            "Cheque",
            "Dinheiro",
            "Depósito"});
            this.forma_de_PagamentoComboBox.Location = new System.Drawing.Point(292, 251);
            this.forma_de_PagamentoComboBox.Name = "forma_de_PagamentoComboBox";
            this.forma_de_PagamentoComboBox.Size = new System.Drawing.Size(121, 21);
            this.forma_de_PagamentoComboBox.TabIndex = 7;
            this.forma_de_PagamentoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_AlunoComboBox_KeyDown);
            // 
            // pagamento_do_AlunoTableAdapter
            // 
            this.pagamento_do_AlunoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Pagamento_do_AlunoTableAdapter = this.pagamento_do_AlunoTableAdapter;
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
            this.DataMenu.Size = new System.Drawing.Size(469, 25);
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
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // frmMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 284);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataMenu);
            this.Controls.Add(código_da_MensalidadeLabel);
            this.Controls.Add(this.código_da_MensalidadeLabel1);
            this.Controls.Add(nome_do_AlunoLabel);
            this.Controls.Add(this.nome_do_AlunoComboBox);
            this.Controls.Add(matrícula_do_AlunoLabel);
            this.Controls.Add(this.matrícula_do_AlunoComboBox);
            this.Controls.Add(nome_do_CursoLabel);
            this.Controls.Add(this.nome_do_CursoComboBox);
            this.Controls.Add(código_do_CursoLabel);
            this.Controls.Add(this.código_do_CursoComboBox);
            this.Controls.Add(ano_do_CursoLabel);
            this.Controls.Add(this.ano_do_CursoComboBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(codigo_da_ParcelaLabel);
            this.Controls.Add(this.codigo_da_ParcelaMaskedTextBox);
            this.Controls.Add(forma_de_PagamentoLabel);
            this.Controls.Add(this.forma_de_PagamentoComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMensalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensalidade do Aluno";
            this.Load += new System.EventHandler(this.frmMensalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagamento_do_AlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource pagamento_do_AlunoBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.Pagamento_do_AlunoTableAdapter pagamento_do_AlunoTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label código_da_MensalidadeLabel1;
        private System.Windows.Forms.ComboBox nome_do_AlunoComboBox;
        private System.Windows.Forms.ComboBox matrícula_do_AlunoComboBox;
        private System.Windows.Forms.ComboBox nome_do_CursoComboBox;
        private System.Windows.Forms.ComboBox código_do_CursoComboBox;
        private System.Windows.Forms.ComboBox ano_do_CursoComboBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.MaskedTextBox codigo_da_ParcelaMaskedTextBox;
        private System.Windows.Forms.ComboBox forma_de_PagamentoComboBox;
        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.CursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}