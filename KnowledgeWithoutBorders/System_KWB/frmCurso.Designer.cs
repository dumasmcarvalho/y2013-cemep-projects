namespace System_KWB
{
    partial class frmCurso
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
            System.Windows.Forms.Label código_do_CursoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label periodoLabel;
            System.Windows.Forms.Label código_de_AutenticidadeLabel;
            System.Windows.Forms.Label numero_de_VagasLabel;
            System.Windows.Forms.Label duraçãoLabel;
            System.Windows.Forms.Label nome_da_DisciplinaLabel;
            System.Windows.Forms.Label código_do_ProfessorLabel;
            System.Windows.Forms.Label nome_do_ProfessorLabel;
            System.Windows.Forms.Label nome_do_CursoLabel;
            System.Windows.Forms.Label código_do_CursoLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurso));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCurso = new System.Windows.Forms.TabPage();
            this.DataMenu = new System.Windows.Forms.ToolStrip();
            this.DataPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.DataAnterior = new System.Windows.Forms.ToolStripButton();
            this.DataProximo = new System.Windows.Forms.ToolStripButton();
            this.DataUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DataAdicionar = new System.Windows.Forms.ToolStripButton();
            this.DataRemover = new System.Windows.Forms.ToolStripButton();
            this.DataSalvar = new System.Windows.Forms.ToolStripButton();
            this.código_do_CursoLabel1 = new System.Windows.Forms.Label();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.periodoComboBox = new System.Windows.Forms.ComboBox();
            this.código_de_AutenticidadeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.numero_de_VagasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.duraçãoTextBox = new System.Windows.Forms.TextBox();
            this.tabDisciplinas = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.código_do_CursoLabel3 = new System.Windows.Forms.Label();
            this.nome_do_CursoTextBox = new System.Windows.Forms.TextBox();
            this.nome_do_ProfessorComboBox = new System.Windows.Forms.ComboBox();
            this.código_do_ProfessorComboBox = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nome_da_DisciplinaTextBox = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.disciplinasTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.DisciplinasTableAdapter();
            this.disciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.CursosTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.professoresTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.ProfessoresTableAdapter();
            código_do_CursoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            periodoLabel = new System.Windows.Forms.Label();
            código_de_AutenticidadeLabel = new System.Windows.Forms.Label();
            numero_de_VagasLabel = new System.Windows.Forms.Label();
            duraçãoLabel = new System.Windows.Forms.Label();
            nome_da_DisciplinaLabel = new System.Windows.Forms.Label();
            código_do_ProfessorLabel = new System.Windows.Forms.Label();
            nome_do_ProfessorLabel = new System.Windows.Forms.Label();
            nome_do_CursoLabel = new System.Windows.Forms.Label();
            código_do_CursoLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabCurso.SuspendLayout();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_de_VagasNumericUpDown)).BeginInit();
            this.tabDisciplinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // código_do_CursoLabel
            // 
            código_do_CursoLabel.AutoSize = true;
            código_do_CursoLabel.Location = new System.Drawing.Point(16, 48);
            código_do_CursoLabel.Name = "código_do_CursoLabel";
            código_do_CursoLabel.Size = new System.Drawing.Size(88, 13);
            código_do_CursoLabel.TabIndex = 80;
            código_do_CursoLabel.Text = "Código do Curso:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(16, 85);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 82;
            nomeLabel.Text = "Nome:";
            // 
            // periodoLabel
            // 
            periodoLabel.AutoSize = true;
            periodoLabel.Location = new System.Drawing.Point(16, 119);
            periodoLabel.Name = "periodoLabel";
            periodoLabel.Size = new System.Drawing.Size(46, 13);
            periodoLabel.TabIndex = 84;
            periodoLabel.Text = "Periodo:";
            // 
            // código_de_AutenticidadeLabel
            // 
            código_de_AutenticidadeLabel.AutoSize = true;
            código_de_AutenticidadeLabel.Location = new System.Drawing.Point(16, 154);
            código_de_AutenticidadeLabel.Name = "código_de_AutenticidadeLabel";
            código_de_AutenticidadeLabel.Size = new System.Drawing.Size(126, 13);
            código_de_AutenticidadeLabel.TabIndex = 86;
            código_de_AutenticidadeLabel.Text = "Código de Autenticidade:";
            // 
            // numero_de_VagasLabel
            // 
            numero_de_VagasLabel.AutoSize = true;
            numero_de_VagasLabel.Location = new System.Drawing.Point(16, 185);
            numero_de_VagasLabel.Name = "numero_de_VagasLabel";
            numero_de_VagasLabel.Size = new System.Drawing.Size(95, 13);
            numero_de_VagasLabel.TabIndex = 88;
            numero_de_VagasLabel.Text = "Numero de Vagas:";
            // 
            // duraçãoLabel
            // 
            duraçãoLabel.AutoSize = true;
            duraçãoLabel.Location = new System.Drawing.Point(16, 222);
            duraçãoLabel.Name = "duraçãoLabel";
            duraçãoLabel.Size = new System.Drawing.Size(51, 13);
            duraçãoLabel.TabIndex = 90;
            duraçãoLabel.Text = "Duração:";
            // 
            // nome_da_DisciplinaLabel
            // 
            nome_da_DisciplinaLabel.AutoSize = true;
            nome_da_DisciplinaLabel.Location = new System.Drawing.Point(10, 81);
            nome_da_DisciplinaLabel.Name = "nome_da_DisciplinaLabel";
            nome_da_DisciplinaLabel.Size = new System.Drawing.Size(101, 13);
            nome_da_DisciplinaLabel.TabIndex = 103;
            nome_da_DisciplinaLabel.Text = "Nome da Disciplina:";
            // 
            // código_do_ProfessorLabel
            // 
            código_do_ProfessorLabel.AutoSize = true;
            código_do_ProfessorLabel.Location = new System.Drawing.Point(257, 81);
            código_do_ProfessorLabel.Name = "código_do_ProfessorLabel";
            código_do_ProfessorLabel.Size = new System.Drawing.Size(105, 13);
            código_do_ProfessorLabel.TabIndex = 104;
            código_do_ProfessorLabel.Text = "Código do Professor:";
            // 
            // nome_do_ProfessorLabel
            // 
            nome_do_ProfessorLabel.AutoSize = true;
            nome_do_ProfessorLabel.Location = new System.Drawing.Point(258, 54);
            nome_do_ProfessorLabel.Name = "nome_do_ProfessorLabel";
            nome_do_ProfessorLabel.Size = new System.Drawing.Size(100, 13);
            nome_do_ProfessorLabel.TabIndex = 105;
            nome_do_ProfessorLabel.Text = "Nome do Professor:";
            // 
            // nome_do_CursoLabel
            // 
            nome_do_CursoLabel.AutoSize = true;
            nome_do_CursoLabel.Location = new System.Drawing.Point(10, 55);
            nome_do_CursoLabel.Name = "nome_do_CursoLabel";
            nome_do_CursoLabel.Size = new System.Drawing.Size(83, 13);
            nome_do_CursoLabel.TabIndex = 107;
            nome_do_CursoLabel.Text = "Nome do Curso:";
            // 
            // código_do_CursoLabel2
            // 
            código_do_CursoLabel2.AutoSize = true;
            código_do_CursoLabel2.Location = new System.Drawing.Point(10, 26);
            código_do_CursoLabel2.Name = "código_do_CursoLabel2";
            código_do_CursoLabel2.Size = new System.Drawing.Size(88, 13);
            código_do_CursoLabel2.TabIndex = 108;
            código_do_CursoLabel2.Text = "Código do Curso:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCurso);
            this.tabControl.Controls.Add(this.tabDisciplinas);
            this.tabControl.Location = new System.Drawing.Point(158, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(536, 349);
            this.tabControl.TabIndex = 94;
            this.tabControl.TabStop = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // tabCurso
            // 
            this.tabCurso.Controls.Add(this.DataMenu);
            this.tabCurso.Controls.Add(código_do_CursoLabel);
            this.tabCurso.Controls.Add(this.código_do_CursoLabel1);
            this.tabCurso.Controls.Add(nomeLabel);
            this.tabCurso.Controls.Add(this.nomeTextBox);
            this.tabCurso.Controls.Add(periodoLabel);
            this.tabCurso.Controls.Add(this.periodoComboBox);
            this.tabCurso.Controls.Add(código_de_AutenticidadeLabel);
            this.tabCurso.Controls.Add(this.código_de_AutenticidadeMaskedTextBox);
            this.tabCurso.Controls.Add(numero_de_VagasLabel);
            this.tabCurso.Controls.Add(this.numero_de_VagasNumericUpDown);
            this.tabCurso.Controls.Add(duraçãoLabel);
            this.tabCurso.Controls.Add(this.duraçãoTextBox);
            this.tabCurso.Location = new System.Drawing.Point(4, 22);
            this.tabCurso.Name = "tabCurso";
            this.tabCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurso.Size = new System.Drawing.Size(528, 323);
            this.tabCurso.TabIndex = 0;
            this.tabCurso.Text = "Curso";
            this.tabCurso.UseVisualStyleBackColor = true;
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
            this.DataMenu.Size = new System.Drawing.Size(522, 25);
            this.DataMenu.TabIndex = 92;
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
            // código_do_CursoLabel1
            // 
            this.código_do_CursoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "Código do Curso", true));
            this.código_do_CursoLabel1.Location = new System.Drawing.Point(152, 48);
            this.código_do_CursoLabel1.Name = "código_do_CursoLabel1";
            this.código_do_CursoLabel1.Size = new System.Drawing.Size(121, 23);
            this.código_do_CursoLabel1.TabIndex = 81;
            this.código_do_CursoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(152, 82);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeTextBox.TabIndex = 0;
            this.nomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // periodoComboBox
            // 
            this.periodoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "Periodo", true));
            this.periodoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodoComboBox.FormattingEnabled = true;
            this.periodoComboBox.Items.AddRange(new object[] {
            "Diurno",
            "Noturno",
            "Integral"});
            this.periodoComboBox.Location = new System.Drawing.Point(152, 116);
            this.periodoComboBox.Name = "periodoComboBox";
            this.periodoComboBox.Size = new System.Drawing.Size(121, 21);
            this.periodoComboBox.TabIndex = 1;
            this.periodoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // código_de_AutenticidadeMaskedTextBox
            // 
            this.código_de_AutenticidadeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "Código de Autenticidade", true));
            this.código_de_AutenticidadeMaskedTextBox.Location = new System.Drawing.Point(152, 151);
            this.código_de_AutenticidadeMaskedTextBox.Mask = "0000-0";
            this.código_de_AutenticidadeMaskedTextBox.Name = "código_de_AutenticidadeMaskedTextBox";
            this.código_de_AutenticidadeMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.código_de_AutenticidadeMaskedTextBox.TabIndex = 2;
            this.código_de_AutenticidadeMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.código_de_AutenticidadeMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // numero_de_VagasNumericUpDown
            // 
            this.numero_de_VagasNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursosBindingSource, "Numero de Vagas", true));
            this.numero_de_VagasNumericUpDown.Location = new System.Drawing.Point(152, 185);
            this.numero_de_VagasNumericUpDown.Name = "numero_de_VagasNumericUpDown";
            this.numero_de_VagasNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.numero_de_VagasNumericUpDown.TabIndex = 3;
            this.numero_de_VagasNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numero_de_VagasNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // duraçãoTextBox
            // 
            this.duraçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "Duração", true));
            this.duraçãoTextBox.Location = new System.Drawing.Point(152, 219);
            this.duraçãoTextBox.Name = "duraçãoTextBox";
            this.duraçãoTextBox.Size = new System.Drawing.Size(121, 20);
            this.duraçãoTextBox.TabIndex = 4;
            this.duraçãoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // tabDisciplinas
            // 
            this.tabDisciplinas.AutoScroll = true;
            this.tabDisciplinas.Controls.Add(this.btnLimpar);
            this.tabDisciplinas.Controls.Add(código_do_CursoLabel2);
            this.tabDisciplinas.Controls.Add(this.código_do_CursoLabel3);
            this.tabDisciplinas.Controls.Add(nome_do_CursoLabel);
            this.tabDisciplinas.Controls.Add(this.nome_do_CursoTextBox);
            this.tabDisciplinas.Controls.Add(nome_do_ProfessorLabel);
            this.tabDisciplinas.Controls.Add(this.nome_do_ProfessorComboBox);
            this.tabDisciplinas.Controls.Add(código_do_ProfessorLabel);
            this.tabDisciplinas.Controls.Add(this.código_do_ProfessorComboBox);
            this.tabDisciplinas.Controls.Add(nome_da_DisciplinaLabel);
            this.tabDisciplinas.Controls.Add(this.nome_da_DisciplinaTextBox);
            this.tabDisciplinas.Controls.Add(this.btnAtualizar);
            this.tabDisciplinas.Controls.Add(this.btnCarregar);
            this.tabDisciplinas.Controls.Add(this.button2);
            this.tabDisciplinas.Controls.Add(this.btnAdcionar);
            this.tabDisciplinas.Controls.Add(this.DataGrid);
            this.tabDisciplinas.Location = new System.Drawing.Point(4, 22);
            this.tabDisciplinas.Name = "tabDisciplinas";
            this.tabDisciplinas.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisciplinas.Size = new System.Drawing.Size(528, 323);
            this.tabDisciplinas.TabIndex = 1;
            this.tabDisciplinas.Text = "Disciplinas";
            this.tabDisciplinas.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(448, 120);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(64, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimparDados_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // código_do_CursoLabel3
            // 
            this.código_do_CursoLabel3.Location = new System.Drawing.Point(119, 26);
            this.código_do_CursoLabel3.Name = "código_do_CursoLabel3";
            this.código_do_CursoLabel3.Size = new System.Drawing.Size(138, 23);
            this.código_do_CursoLabel3.TabIndex = 109;
            this.código_do_CursoLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nome_do_CursoTextBox
            // 
            this.nome_do_CursoTextBox.Enabled = false;
            this.nome_do_CursoTextBox.Location = new System.Drawing.Point(122, 52);
            this.nome_do_CursoTextBox.Name = "nome_do_CursoTextBox";
            this.nome_do_CursoTextBox.Size = new System.Drawing.Size(118, 20);
            this.nome_do_CursoTextBox.TabIndex = 0;
            this.nome_do_CursoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // nome_do_ProfessorComboBox
            // 
            this.nome_do_ProfessorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nome_do_ProfessorComboBox.FormattingEnabled = true;
            this.nome_do_ProfessorComboBox.Location = new System.Drawing.Point(369, 51);
            this.nome_do_ProfessorComboBox.Name = "nome_do_ProfessorComboBox";
            this.nome_do_ProfessorComboBox.Size = new System.Drawing.Size(143, 21);
            this.nome_do_ProfessorComboBox.TabIndex = 2;
            this.nome_do_ProfessorComboBox.SelectedIndexChanged += new System.EventHandler(this.nome_do_ProfessorComboBox_SelectedIndexChanged);
            this.nome_do_ProfessorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // código_do_ProfessorComboBox
            // 
            this.código_do_ProfessorComboBox.DataSource = this.professoresBindingSource;
            this.código_do_ProfessorComboBox.DisplayMember = "Codigo do Professor";
            this.código_do_ProfessorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.código_do_ProfessorComboBox.Enabled = false;
            this.código_do_ProfessorComboBox.FormattingEnabled = true;
            this.código_do_ProfessorComboBox.Location = new System.Drawing.Point(369, 78);
            this.código_do_ProfessorComboBox.Name = "código_do_ProfessorComboBox";
            this.código_do_ProfessorComboBox.Size = new System.Drawing.Size(71, 21);
            this.código_do_ProfessorComboBox.TabIndex = 3;
            this.código_do_ProfessorComboBox.ValueMember = "Codigo do Professor";
            this.código_do_ProfessorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // nome_da_DisciplinaTextBox
            // 
            this.nome_da_DisciplinaTextBox.Location = new System.Drawing.Point(122, 78);
            this.nome_da_DisciplinaTextBox.Name = "nome_da_DisciplinaTextBox";
            this.nome_da_DisciplinaTextBox.Size = new System.Drawing.Size(118, 20);
            this.nome_da_DisciplinaTextBox.TabIndex = 1;
            this.nome_da_DisciplinaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Location = new System.Drawing.Point(83, 120);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(64, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            this.btnAtualizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.White;
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.Location = new System.Drawing.Point(378, 120);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(64, 23);
            this.btnCarregar.TabIndex = 7;
            this.btnCarregar.TabStop = false;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregarDados_Click);
            this.btnCarregar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(153, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnRemoverDados_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.White;
            this.btnAdcionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdcionar.Location = new System.Drawing.Point(13, 120);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(64, 23);
            this.btnAdcionar.TabIndex = 4;
            this.btnAdcionar.TabStop = false;
            this.btnAdcionar.Text = "Adicionar";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdicionarDados_Click);
            this.btnAdcionar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.GridColor = System.Drawing.Color.Silver;
            this.DataGrid.Location = new System.Drawing.Point(13, 149);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(499, 167);
            this.DataGrid.TabIndex = 9;
            this.DataGrid.TabStop = false;
            this.DataGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_MouseClick);
            // 
            // disciplinasTableAdapter
            // 
            this.disciplinasTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinasBindingSource
            // 
            this.disciplinasBindingSource.DataMember = "Disciplinas";
            this.disciplinasBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantinaTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = this.cursosTableAdapter;
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
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Cursos e suas Disciplinas";
            this.Load += new System.EventHandler(this.frmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabCurso.ResumeLayout(false);
            this.tabCurso.PerformLayout();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_de_VagasNumericUpDown)).EndInit();
            this.tabDisciplinas.ResumeLayout(false);
            this.tabDisciplinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.CursosTableAdapter cursosTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCurso;
        private System.Windows.Forms.ToolStrip DataMenu;
        private System.Windows.Forms.ToolStripButton DataPrimeiro;
        private System.Windows.Forms.ToolStripButton DataAnterior;
        private System.Windows.Forms.ToolStripButton DataProximo;
        private System.Windows.Forms.ToolStripButton DataUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DataAdicionar;
        private System.Windows.Forms.ToolStripButton DataRemover;
        private System.Windows.Forms.ToolStripButton DataSalvar;
        private System.Windows.Forms.Label código_do_CursoLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox periodoComboBox;
        private System.Windows.Forms.MaskedTextBox código_de_AutenticidadeMaskedTextBox;
        private System.Windows.Forms.NumericUpDown numero_de_VagasNumericUpDown;
        private System.Windows.Forms.TextBox duraçãoTextBox;
        private System.Windows.Forms.TabPage tabDisciplinas;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.BindingSource disciplinasBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.DisciplinasTableAdapter disciplinasTableAdapter;
        private System.Windows.Forms.Label código_do_CursoLabel3;
        private System.Windows.Forms.TextBox nome_do_CursoTextBox;
        private System.Windows.Forms.ComboBox nome_do_ProfessorComboBox;
        private System.Windows.Forms.ComboBox código_do_ProfessorComboBox;
        private System.Windows.Forms.TextBox nome_da_DisciplinaTextBox;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
    }
}