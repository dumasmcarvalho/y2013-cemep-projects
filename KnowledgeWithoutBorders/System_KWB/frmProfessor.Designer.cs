namespace System_KWB
{
    partial class frmProfessor
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label conta_BancariaLabel;
            System.Windows.Forms.Label agênciaLabel;
            System.Windows.Forms.Label nome_da_AgênciaLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label rua_AvenidaLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label carga_HorariaLabel;
            System.Windows.Forms.Label formação_ProfissionalLabel;
            System.Windows.Forms.Label especialidadeLabel;
            System.Windows.Forms.Label idiomasLabel;
            System.Windows.Forms.Label data_de_AdmissãoLabel;
            System.Windows.Forms.Label codigo_do_ProfessorLabel;
            System.Windows.Forms.Label demitidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
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
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.ProfessoresTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.rGMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.conta_BancariaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.agênciaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nome_da_AgênciaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rua_AvenidaTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.carga_HorariaTextBox = new System.Windows.Forms.TextBox();
            this.formação_ProfissionalTextBox = new System.Windows.Forms.TextBox();
            this.especialidadeTextBox = new System.Windows.Forms.TextBox();
            this.idiomasTextBox = new System.Windows.Forms.TextBox();
            this.data_de_AdmissãoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codigo_do_ProfessorLabel1 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.demitidoCheckBox = new System.Windows.Forms.CheckBox();
            nomeLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            conta_BancariaLabel = new System.Windows.Forms.Label();
            agênciaLabel = new System.Windows.Forms.Label();
            nome_da_AgênciaLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            rua_AvenidaLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            carga_HorariaLabel = new System.Windows.Forms.Label();
            formação_ProfissionalLabel = new System.Windows.Forms.Label();
            especialidadeLabel = new System.Windows.Forms.Label();
            idiomasLabel = new System.Windows.Forms.Label();
            data_de_AdmissãoLabel = new System.Windows.Forms.Label();
            codigo_do_ProfessorLabel = new System.Windows.Forms.Label();
            demitidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(166, 65);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 81;
            nomeLabel.Text = "Nome:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(166, 91);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 83;
            sexoLabel.Text = "Sexo:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(166, 118);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 85;
            rGLabel.Text = "RG:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(166, 144);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 87;
            cPFLabel.Text = "CPF:";
            // 
            // conta_BancariaLabel
            // 
            conta_BancariaLabel.AutoSize = true;
            conta_BancariaLabel.Location = new System.Drawing.Point(166, 170);
            conta_BancariaLabel.Name = "conta_BancariaLabel";
            conta_BancariaLabel.Size = new System.Drawing.Size(83, 13);
            conta_BancariaLabel.TabIndex = 89;
            conta_BancariaLabel.Text = "Conta Bancaria:";
            // 
            // agênciaLabel
            // 
            agênciaLabel.AutoSize = true;
            agênciaLabel.Location = new System.Drawing.Point(166, 196);
            agênciaLabel.Name = "agênciaLabel";
            agênciaLabel.Size = new System.Drawing.Size(49, 13);
            agênciaLabel.TabIndex = 91;
            agênciaLabel.Text = "Agência:";
            // 
            // nome_da_AgênciaLabel
            // 
            nome_da_AgênciaLabel.AutoSize = true;
            nome_da_AgênciaLabel.Location = new System.Drawing.Point(166, 222);
            nome_da_AgênciaLabel.Name = "nome_da_AgênciaLabel";
            nome_da_AgênciaLabel.Size = new System.Drawing.Size(95, 13);
            nome_da_AgênciaLabel.TabIndex = 93;
            nome_da_AgênciaLabel.Text = "Nome da Agência:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(166, 248);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 95;
            cEPLabel.Text = "CEP:";
            // 
            // rua_AvenidaLabel
            // 
            rua_AvenidaLabel.AutoSize = true;
            rua_AvenidaLabel.Location = new System.Drawing.Point(166, 274);
            rua_AvenidaLabel.Name = "rua_AvenidaLabel";
            rua_AvenidaLabel.Size = new System.Drawing.Size(74, 13);
            rua_AvenidaLabel.TabIndex = 97;
            rua_AvenidaLabel.Text = "Rua/Avenida:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(166, 300);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 99;
            numeroLabel.Text = "Numero:";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(166, 326);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(74, 13);
            complementoLabel.TabIndex = 101;
            complementoLabel.Text = "Complemento:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(166, 352);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 103;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(166, 378);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 105;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(166, 407);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 107;
            estadoLabel.Text = "Estado:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(513, 43);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 109;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(513, 69);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 111;
            celularLabel.Text = "Celular:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(513, 95);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 113;
            emailLabel.Text = "Email:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(513, 118);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 115;
            fotoLabel.Text = "Foto:";
            // 
            // carga_HorariaLabel
            // 
            carga_HorariaLabel.AutoSize = true;
            carga_HorariaLabel.Location = new System.Drawing.Point(513, 270);
            carga_HorariaLabel.Name = "carga_HorariaLabel";
            carga_HorariaLabel.Size = new System.Drawing.Size(75, 13);
            carga_HorariaLabel.TabIndex = 117;
            carga_HorariaLabel.Text = "Carga Horaria:";
            // 
            // formação_ProfissionalLabel
            // 
            formação_ProfissionalLabel.AutoSize = true;
            formação_ProfissionalLabel.Location = new System.Drawing.Point(513, 296);
            formação_ProfissionalLabel.Name = "formação_ProfissionalLabel";
            formação_ProfissionalLabel.Size = new System.Drawing.Size(113, 13);
            formação_ProfissionalLabel.TabIndex = 119;
            formação_ProfissionalLabel.Text = "Formação Profissional:";
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(513, 322);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(76, 13);
            especialidadeLabel.TabIndex = 121;
            especialidadeLabel.Text = "Especialidade:";
            // 
            // idiomasLabel
            // 
            idiomasLabel.AutoSize = true;
            idiomasLabel.Location = new System.Drawing.Point(513, 348);
            idiomasLabel.Name = "idiomasLabel";
            idiomasLabel.Size = new System.Drawing.Size(46, 13);
            idiomasLabel.TabIndex = 123;
            idiomasLabel.Text = "Idiomas:";
            // 
            // data_de_AdmissãoLabel
            // 
            data_de_AdmissãoLabel.AutoSize = true;
            data_de_AdmissãoLabel.Location = new System.Drawing.Point(513, 375);
            data_de_AdmissãoLabel.Name = "data_de_AdmissãoLabel";
            data_de_AdmissãoLabel.Size = new System.Drawing.Size(96, 13);
            data_de_AdmissãoLabel.TabIndex = 125;
            data_de_AdmissãoLabel.Text = "Data de Admissão:";
            // 
            // codigo_do_ProfessorLabel
            // 
            codigo_do_ProfessorLabel.AutoSize = true;
            codigo_do_ProfessorLabel.Location = new System.Drawing.Point(166, 40);
            codigo_do_ProfessorLabel.Name = "codigo_do_ProfessorLabel";
            codigo_do_ProfessorLabel.Size = new System.Drawing.Size(105, 13);
            codigo_do_ProfessorLabel.TabIndex = 128;
            codigo_do_ProfessorLabel.Text = "Codigo do Professor:";
            // 
            // demitidoLabel
            // 
            demitidoLabel.AutoSize = true;
            demitidoLabel.Location = new System.Drawing.Point(514, 402);
            demitidoLabel.Name = "demitidoLabel";
            demitidoLabel.Size = new System.Drawing.Size(51, 13);
            demitidoLabel.TabIndex = 130;
            demitidoLabel.Text = "Demitido:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
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
            this.DataMenu.Size = new System.Drawing.Size(871, 25);
            this.DataMenu.TabIndex = 78;
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
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Pedido_de_LivrosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(285, 62);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 0;
            this.nomeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Sexo", true));
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outros"});
            this.sexoComboBox.Location = new System.Drawing.Point(285, 88);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(142, 21);
            this.sexoComboBox.TabIndex = 1;
            this.sexoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // rGMaskedTextBox
            // 
            this.rGMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "RG", true));
            this.rGMaskedTextBox.Location = new System.Drawing.Point(285, 115);
            this.rGMaskedTextBox.Mask = "00,000,000-0";
            this.rGMaskedTextBox.Name = "rGMaskedTextBox";
            this.rGMaskedTextBox.Size = new System.Drawing.Size(142, 20);
            this.rGMaskedTextBox.TabIndex = 2;
            this.rGMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rGMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // cPFMaskedTextBox
            // 
            this.cPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "CPF", true));
            this.cPFMaskedTextBox.Location = new System.Drawing.Point(285, 141);
            this.cPFMaskedTextBox.Mask = "000,000,000-00";
            this.cPFMaskedTextBox.Name = "cPFMaskedTextBox";
            this.cPFMaskedTextBox.Size = new System.Drawing.Size(142, 20);
            this.cPFMaskedTextBox.TabIndex = 3;
            this.cPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cPFMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // conta_BancariaMaskedTextBox
            // 
            this.conta_BancariaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Conta Bancaria", true));
            this.conta_BancariaMaskedTextBox.Location = new System.Drawing.Point(285, 167);
            this.conta_BancariaMaskedTextBox.Mask = "00,000-0";
            this.conta_BancariaMaskedTextBox.Name = "conta_BancariaMaskedTextBox";
            this.conta_BancariaMaskedTextBox.Size = new System.Drawing.Size(142, 20);
            this.conta_BancariaMaskedTextBox.TabIndex = 4;
            this.conta_BancariaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.conta_BancariaMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // agênciaMaskedTextBox
            // 
            this.agênciaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Agência", true));
            this.agênciaMaskedTextBox.Location = new System.Drawing.Point(285, 193);
            this.agênciaMaskedTextBox.Mask = "0000";
            this.agênciaMaskedTextBox.Name = "agênciaMaskedTextBox";
            this.agênciaMaskedTextBox.Size = new System.Drawing.Size(142, 20);
            this.agênciaMaskedTextBox.TabIndex = 5;
            this.agênciaMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.agênciaMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // nome_da_AgênciaMaskedTextBox
            // 
            this.nome_da_AgênciaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Nome da Agência", true));
            this.nome_da_AgênciaMaskedTextBox.Location = new System.Drawing.Point(285, 219);
            this.nome_da_AgênciaMaskedTextBox.Name = "nome_da_AgênciaMaskedTextBox";
            this.nome_da_AgênciaMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.nome_da_AgênciaMaskedTextBox.TabIndex = 6;
            this.nome_da_AgênciaMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // cEPMaskedTextBox
            // 
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Location = new System.Drawing.Point(285, 245);
            this.cEPMaskedTextBox.Mask = "00000-000";
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            this.cEPMaskedTextBox.Size = new System.Drawing.Size(142, 20);
            this.cEPMaskedTextBox.TabIndex = 7;
            this.cEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cEPMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // rua_AvenidaTextBox
            // 
            this.rua_AvenidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Rua/Avenida", true));
            this.rua_AvenidaTextBox.Location = new System.Drawing.Point(285, 271);
            this.rua_AvenidaTextBox.Name = "rua_AvenidaTextBox";
            this.rua_AvenidaTextBox.Size = new System.Drawing.Size(200, 20);
            this.rua_AvenidaTextBox.TabIndex = 8;
            this.rua_AvenidaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(285, 297);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(68, 20);
            this.numeroTextBox.TabIndex = 9;
            this.numeroTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(285, 323);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(200, 20);
            this.complementoTextBox.TabIndex = 10;
            this.complementoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(285, 349);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(200, 20);
            this.bairroTextBox.TabIndex = 11;
            this.bairroTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(285, 375);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 12;
            this.cidadeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Estado", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.estadoComboBox.Location = new System.Drawing.Point(285, 404);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(68, 21);
            this.estadoComboBox.TabIndex = 13;
            this.estadoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(632, 40);
            this.telefoneMaskedTextBox.Mask = "(00) 0000-0000";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(144, 20);
            this.telefoneMaskedTextBox.TabIndex = 14;
            this.telefoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.telefoneMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(632, 66);
            this.celularMaskedTextBox.Mask = "(00) 0000-0000";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(144, 20);
            this.celularMaskedTextBox.TabIndex = 15;
            this.celularMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.celularMaskedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(632, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 16;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.professoresBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(632, 118);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(144, 143);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 116;
            this.fotoPictureBox.TabStop = false;
            // 
            // carga_HorariaTextBox
            // 
            this.carga_HorariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Carga Horaria", true));
            this.carga_HorariaTextBox.Location = new System.Drawing.Point(632, 267);
            this.carga_HorariaTextBox.Name = "carga_HorariaTextBox";
            this.carga_HorariaTextBox.Size = new System.Drawing.Size(144, 20);
            this.carga_HorariaTextBox.TabIndex = 18;
            this.carga_HorariaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // formação_ProfissionalTextBox
            // 
            this.formação_ProfissionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Formação Profissional", true));
            this.formação_ProfissionalTextBox.Location = new System.Drawing.Point(632, 293);
            this.formação_ProfissionalTextBox.Name = "formação_ProfissionalTextBox";
            this.formação_ProfissionalTextBox.Size = new System.Drawing.Size(200, 20);
            this.formação_ProfissionalTextBox.TabIndex = 19;
            this.formação_ProfissionalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // especialidadeTextBox
            // 
            this.especialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Especialidade", true));
            this.especialidadeTextBox.Location = new System.Drawing.Point(632, 319);
            this.especialidadeTextBox.Name = "especialidadeTextBox";
            this.especialidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.especialidadeTextBox.TabIndex = 20;
            this.especialidadeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // idiomasTextBox
            // 
            this.idiomasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Idiomas", true));
            this.idiomasTextBox.Location = new System.Drawing.Point(632, 345);
            this.idiomasTextBox.Name = "idiomasTextBox";
            this.idiomasTextBox.Size = new System.Drawing.Size(200, 20);
            this.idiomasTextBox.TabIndex = 21;
            this.idiomasTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // data_de_AdmissãoDateTimePicker
            // 
            this.data_de_AdmissãoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.professoresBindingSource, "Data de Admissão", true));
            this.data_de_AdmissãoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_de_AdmissãoDateTimePicker.Location = new System.Drawing.Point(632, 371);
            this.data_de_AdmissãoDateTimePicker.Name = "data_de_AdmissãoDateTimePicker";
            this.data_de_AdmissãoDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.data_de_AdmissãoDateTimePicker.TabIndex = 22;
            this.data_de_AdmissãoDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // codigo_do_ProfessorLabel1
            // 
            this.codigo_do_ProfessorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.professoresBindingSource, "Codigo do Professor", true));
            this.codigo_do_ProfessorLabel1.Location = new System.Drawing.Point(285, 33);
            this.codigo_do_ProfessorLabel1.Name = "codigo_do_ProfessorLabel1";
            this.codigo_do_ProfessorLabel1.Size = new System.Drawing.Size(200, 23);
            this.codigo_do_ProfessorLabel1.TabIndex = 129;
            this.codigo_do_ProfessorLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.White;
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.Location = new System.Drawing.Point(782, 238);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(50, 23);
            this.btnCarregar.TabIndex = 17;
            this.btnCarregar.Text = "...";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            this.btnCarregar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // Mensagem
            // 
            this.Mensagem.AutomaticDelay = 200;
            this.Mensagem.BackColor = System.Drawing.Color.White;
            this.Mensagem.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.Mensagem.ToolTipTitle = "Senha Inválida";
            // 
            // demitidoCheckBox
            // 
            this.demitidoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.professoresBindingSource, "Demitido", true));
            this.demitidoCheckBox.Location = new System.Drawing.Point(632, 397);
            this.demitidoCheckBox.Name = "demitidoCheckBox";
            this.demitidoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.demitidoCheckBox.TabIndex = 23;
            this.demitidoCheckBox.Text = "Sim/Não";
            this.demitidoCheckBox.UseVisualStyleBackColor = true;
            this.demitidoCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 443);
            this.Controls.Add(demitidoLabel);
            this.Controls.Add(this.demitidoCheckBox);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(codigo_do_ProfessorLabel);
            this.Controls.Add(this.codigo_do_ProfessorLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGMaskedTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFMaskedTextBox);
            this.Controls.Add(conta_BancariaLabel);
            this.Controls.Add(this.conta_BancariaMaskedTextBox);
            this.Controls.Add(agênciaLabel);
            this.Controls.Add(this.agênciaMaskedTextBox);
            this.Controls.Add(nome_da_AgênciaLabel);
            this.Controls.Add(this.nome_da_AgênciaMaskedTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
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
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(carga_HorariaLabel);
            this.Controls.Add(this.carga_HorariaTextBox);
            this.Controls.Add(formação_ProfissionalLabel);
            this.Controls.Add(this.formação_ProfissionalTextBox);
            this.Controls.Add(especialidadeLabel);
            this.Controls.Add(this.especialidadeTextBox);
            this.Controls.Add(idiomasLabel);
            this.Controls.Add(this.idiomasTextBox);
            this.Controls.Add(data_de_AdmissãoLabel);
            this.Controls.Add(this.data_de_AdmissãoDateTimePicker);
            this.Controls.Add(this.DataMenu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Professores";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomeTextBox_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.MaskedTextBox rGMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cPFMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox conta_BancariaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox agênciaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox nome_da_AgênciaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
        private System.Windows.Forms.TextBox rua_AvenidaTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.TextBox carga_HorariaTextBox;
        private System.Windows.Forms.TextBox formação_ProfissionalTextBox;
        private System.Windows.Forms.TextBox especialidadeTextBox;
        private System.Windows.Forms.TextBox idiomasTextBox;
        private System.Windows.Forms.DateTimePicker data_de_AdmissãoDateTimePicker;
        private System.Windows.Forms.Label codigo_do_ProfessorLabel1;
        private System.Windows.Forms.Button btnCarregar;
        public System.Windows.Forms.ToolTip Mensagem;
        private System.Windows.Forms.CheckBox demitidoCheckBox;
        private System.Windows.Forms.ToolStripButton DataPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}