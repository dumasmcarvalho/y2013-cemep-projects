namespace System_KWB
{
    partial class frmPagamento
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
            System.Windows.Forms.Label código_do_PagamentoLabel;
            System.Windows.Forms.Label nome_do_ProfessorLabel;
            System.Windows.Forms.Label código_do_ProfessorLabel;
            System.Windows.Forms.Label conta_BancariaLabel;
            System.Windows.Forms.Label agênciaLabel;
            System.Windows.Forms.Label nome_da_AgênciaLabel;
            System.Windows.Forms.Label data_de_PagamentoLabel;
            System.Windows.Forms.Label salario_BrutoLabel;
            System.Windows.Forms.Label descontosLabel;
            System.Windows.Forms.Label valor_da_HoraLabel;
            System.Windows.Forms.Label horas_ExtrasLabel;
            System.Windows.Forms.Label salario_LiquidoLabel;
            System.Windows.Forms.Label horas_TrabalhadasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.bD_KWB_DataSet = new System_KWB.Resources.BD_KWB_DataSet();
            this.pagamento_do_ProfessorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamento_do_ProfessorTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.Pagamento_do_ProfessorTableAdapter();
            this.tableAdapterManager = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager();
            this.professoresTableAdapter = new System_KWB.Resources.BD_KWB_DataSetTableAdapters.ProfessoresTableAdapter();
            this.código_do_PagamentoLabel1 = new System.Windows.Forms.Label();
            this.nome_do_ProfessorComboBox = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.código_do_ProfessorComboBox = new System.Windows.Forms.ComboBox();
            this.conta_BancariaComboBox = new System.Windows.Forms.ComboBox();
            this.agênciaComboBox = new System.Windows.Forms.ComboBox();
            this.nome_da_AgênciaComboBox = new System.Windows.Forms.ComboBox();
            this.data_de_PagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salario_BrutoTextBox = new System.Windows.Forms.TextBox();
            this.descontosTextBox = new System.Windows.Forms.TextBox();
            this.valor_da_HoraTextBox = new System.Windows.Forms.TextBox();
            this.horas_ExtrasTextBox = new System.Windows.Forms.TextBox();
            this.salario_LiquidoTextBox = new System.Windows.Forms.TextBox();
            this.horas_TrabalhadasNumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            código_do_PagamentoLabel = new System.Windows.Forms.Label();
            nome_do_ProfessorLabel = new System.Windows.Forms.Label();
            código_do_ProfessorLabel = new System.Windows.Forms.Label();
            conta_BancariaLabel = new System.Windows.Forms.Label();
            agênciaLabel = new System.Windows.Forms.Label();
            nome_da_AgênciaLabel = new System.Windows.Forms.Label();
            data_de_PagamentoLabel = new System.Windows.Forms.Label();
            salario_BrutoLabel = new System.Windows.Forms.Label();
            descontosLabel = new System.Windows.Forms.Label();
            valor_da_HoraLabel = new System.Windows.Forms.Label();
            horas_ExtrasLabel = new System.Windows.Forms.Label();
            salario_LiquidoLabel = new System.Windows.Forms.Label();
            horas_TrabalhadasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamento_do_ProfessorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas_TrabalhadasNumericUpDown)).BeginInit();
            this.DataMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_do_PagamentoLabel
            // 
            código_do_PagamentoLabel.AutoSize = true;
            código_do_PagamentoLabel.Location = new System.Drawing.Point(164, 39);
            código_do_PagamentoLabel.Name = "código_do_PagamentoLabel";
            código_do_PagamentoLabel.Size = new System.Drawing.Size(115, 13);
            código_do_PagamentoLabel.TabIndex = 1;
            código_do_PagamentoLabel.Text = "Código do Pagamento:";
            // 
            // nome_do_ProfessorLabel
            // 
            nome_do_ProfessorLabel.AutoSize = true;
            nome_do_ProfessorLabel.Location = new System.Drawing.Point(164, 68);
            nome_do_ProfessorLabel.Name = "nome_do_ProfessorLabel";
            nome_do_ProfessorLabel.Size = new System.Drawing.Size(100, 13);
            nome_do_ProfessorLabel.TabIndex = 3;
            nome_do_ProfessorLabel.Text = "Nome do Professor:";
            // 
            // código_do_ProfessorLabel
            // 
            código_do_ProfessorLabel.AutoSize = true;
            código_do_ProfessorLabel.Location = new System.Drawing.Point(164, 95);
            código_do_ProfessorLabel.Name = "código_do_ProfessorLabel";
            código_do_ProfessorLabel.Size = new System.Drawing.Size(105, 13);
            código_do_ProfessorLabel.TabIndex = 5;
            código_do_ProfessorLabel.Text = "Código do Professor:";
            // 
            // conta_BancariaLabel
            // 
            conta_BancariaLabel.AutoSize = true;
            conta_BancariaLabel.Location = new System.Drawing.Point(164, 122);
            conta_BancariaLabel.Name = "conta_BancariaLabel";
            conta_BancariaLabel.Size = new System.Drawing.Size(83, 13);
            conta_BancariaLabel.TabIndex = 7;
            conta_BancariaLabel.Text = "Conta Bancaria:";
            // 
            // agênciaLabel
            // 
            agênciaLabel.AutoSize = true;
            agênciaLabel.Location = new System.Drawing.Point(164, 149);
            agênciaLabel.Name = "agênciaLabel";
            agênciaLabel.Size = new System.Drawing.Size(49, 13);
            agênciaLabel.TabIndex = 9;
            agênciaLabel.Text = "Agência:";
            // 
            // nome_da_AgênciaLabel
            // 
            nome_da_AgênciaLabel.AutoSize = true;
            nome_da_AgênciaLabel.Location = new System.Drawing.Point(164, 176);
            nome_da_AgênciaLabel.Name = "nome_da_AgênciaLabel";
            nome_da_AgênciaLabel.Size = new System.Drawing.Size(95, 13);
            nome_da_AgênciaLabel.TabIndex = 11;
            nome_da_AgênciaLabel.Text = "Nome da Agência:";
            // 
            // data_de_PagamentoLabel
            // 
            data_de_PagamentoLabel.AutoSize = true;
            data_de_PagamentoLabel.Location = new System.Drawing.Point(164, 204);
            data_de_PagamentoLabel.Name = "data_de_PagamentoLabel";
            data_de_PagamentoLabel.Size = new System.Drawing.Size(105, 13);
            data_de_PagamentoLabel.TabIndex = 13;
            data_de_PagamentoLabel.Text = "Data de Pagamento:";
            // 
            // salario_BrutoLabel
            // 
            salario_BrutoLabel.AutoSize = true;
            salario_BrutoLabel.Location = new System.Drawing.Point(164, 229);
            salario_BrutoLabel.Name = "salario_BrutoLabel";
            salario_BrutoLabel.Size = new System.Drawing.Size(70, 13);
            salario_BrutoLabel.TabIndex = 15;
            salario_BrutoLabel.Text = "Salario Bruto:";
            // 
            // descontosLabel
            // 
            descontosLabel.AutoSize = true;
            descontosLabel.Location = new System.Drawing.Point(164, 255);
            descontosLabel.Name = "descontosLabel";
            descontosLabel.Size = new System.Drawing.Size(61, 13);
            descontosLabel.TabIndex = 17;
            descontosLabel.Text = "Descontos:";
            // 
            // valor_da_HoraLabel
            // 
            valor_da_HoraLabel.AutoSize = true;
            valor_da_HoraLabel.Location = new System.Drawing.Point(164, 307);
            valor_da_HoraLabel.Name = "valor_da_HoraLabel";
            valor_da_HoraLabel.Size = new System.Drawing.Size(75, 13);
            valor_da_HoraLabel.TabIndex = 21;
            valor_da_HoraLabel.Text = "Valor da Hora:";
            // 
            // horas_ExtrasLabel
            // 
            horas_ExtrasLabel.AutoSize = true;
            horas_ExtrasLabel.Location = new System.Drawing.Point(164, 333);
            horas_ExtrasLabel.Name = "horas_ExtrasLabel";
            horas_ExtrasLabel.Size = new System.Drawing.Size(70, 13);
            horas_ExtrasLabel.TabIndex = 23;
            horas_ExtrasLabel.Text = "Horas Extras:";
            // 
            // salario_LiquidoLabel
            // 
            salario_LiquidoLabel.AutoSize = true;
            salario_LiquidoLabel.Location = new System.Drawing.Point(164, 359);
            salario_LiquidoLabel.Name = "salario_LiquidoLabel";
            salario_LiquidoLabel.Size = new System.Drawing.Size(79, 13);
            salario_LiquidoLabel.TabIndex = 25;
            salario_LiquidoLabel.Text = "Salario Liquido:";
            // 
            // horas_TrabalhadasLabel
            // 
            horas_TrabalhadasLabel.AutoSize = true;
            horas_TrabalhadasLabel.Location = new System.Drawing.Point(164, 280);
            horas_TrabalhadasLabel.Name = "horas_TrabalhadasLabel";
            horas_TrabalhadasLabel.Size = new System.Drawing.Size(100, 13);
            horas_TrabalhadasLabel.TabIndex = 26;
            horas_TrabalhadasLabel.Text = "Horas Trabalhadas:";
            // 
            // bD_KWB_DataSet
            // 
            this.bD_KWB_DataSet.DataSetName = "BD_KWB_DataSet";
            this.bD_KWB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagamento_do_ProfessorBindingSource
            // 
            this.pagamento_do_ProfessorBindingSource.DataMember = "Pagamento do Professor";
            this.pagamento_do_ProfessorBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // pagamento_do_ProfessorTableAdapter
            // 
            this.pagamento_do_ProfessorTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Pagamento_do_ProfessorTableAdapter = this.pagamento_do_ProfessorTableAdapter;
            this.tableAdapterManager.Pedido_de_LivrosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = System_KWB.Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // código_do_PagamentoLabel1
            // 
            this.código_do_PagamentoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Código do Pagamento", true));
            this.código_do_PagamentoLabel1.Location = new System.Drawing.Point(285, 39);
            this.código_do_PagamentoLabel1.Name = "código_do_PagamentoLabel1";
            this.código_do_PagamentoLabel1.Size = new System.Drawing.Size(200, 23);
            this.código_do_PagamentoLabel1.TabIndex = 2;
            this.código_do_PagamentoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nome_do_ProfessorComboBox
            // 
            this.nome_do_ProfessorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Nome do Professor", true));
            this.nome_do_ProfessorComboBox.DataSource = this.professoresBindingSource;
            this.nome_do_ProfessorComboBox.DisplayMember = "Nome";
            this.nome_do_ProfessorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nome_do_ProfessorComboBox.FormattingEnabled = true;
            this.nome_do_ProfessorComboBox.Location = new System.Drawing.Point(285, 65);
            this.nome_do_ProfessorComboBox.Name = "nome_do_ProfessorComboBox";
            this.nome_do_ProfessorComboBox.Size = new System.Drawing.Size(170, 21);
            this.nome_do_ProfessorComboBox.TabIndex = 0;
            this.nome_do_ProfessorComboBox.ValueMember = "Nome";
            this.nome_do_ProfessorComboBox.SelectedIndexChanged += new System.EventHandler(this.nome_do_ProfessorComboBox_SelectedIndexChanged);
            this.nome_do_ProfessorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.bD_KWB_DataSet;
            // 
            // código_do_ProfessorComboBox
            // 
            this.código_do_ProfessorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Código do Professor", true));
            this.código_do_ProfessorComboBox.DataSource = this.professoresBindingSource;
            this.código_do_ProfessorComboBox.DisplayMember = "Codigo do Professor";
            this.código_do_ProfessorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.código_do_ProfessorComboBox.Enabled = false;
            this.código_do_ProfessorComboBox.FormattingEnabled = true;
            this.código_do_ProfessorComboBox.Location = new System.Drawing.Point(285, 92);
            this.código_do_ProfessorComboBox.Name = "código_do_ProfessorComboBox";
            this.código_do_ProfessorComboBox.Size = new System.Drawing.Size(88, 21);
            this.código_do_ProfessorComboBox.TabIndex = 1;
            this.código_do_ProfessorComboBox.ValueMember = "Codigo do Professor";
            this.código_do_ProfessorComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // conta_BancariaComboBox
            // 
            this.conta_BancariaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Conta Bancaria", true));
            this.conta_BancariaComboBox.DataSource = this.professoresBindingSource;
            this.conta_BancariaComboBox.DisplayMember = "Conta Bancaria";
            this.conta_BancariaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.conta_BancariaComboBox.Enabled = false;
            this.conta_BancariaComboBox.FormattingEnabled = true;
            this.conta_BancariaComboBox.Location = new System.Drawing.Point(285, 119);
            this.conta_BancariaComboBox.Name = "conta_BancariaComboBox";
            this.conta_BancariaComboBox.Size = new System.Drawing.Size(88, 21);
            this.conta_BancariaComboBox.TabIndex = 2;
            this.conta_BancariaComboBox.ValueMember = "Conta Bancaria";
            this.conta_BancariaComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // agênciaComboBox
            // 
            this.agênciaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Agência", true));
            this.agênciaComboBox.DataSource = this.professoresBindingSource;
            this.agênciaComboBox.DisplayMember = "Agência";
            this.agênciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.agênciaComboBox.Enabled = false;
            this.agênciaComboBox.FormattingEnabled = true;
            this.agênciaComboBox.Location = new System.Drawing.Point(285, 146);
            this.agênciaComboBox.Name = "agênciaComboBox";
            this.agênciaComboBox.Size = new System.Drawing.Size(88, 21);
            this.agênciaComboBox.TabIndex = 3;
            this.agênciaComboBox.ValueMember = "Agência";
            this.agênciaComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // nome_da_AgênciaComboBox
            // 
            this.nome_da_AgênciaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Nome da Agência", true));
            this.nome_da_AgênciaComboBox.DataSource = this.professoresBindingSource;
            this.nome_da_AgênciaComboBox.DisplayMember = "Nome da Agência";
            this.nome_da_AgênciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.nome_da_AgênciaComboBox.Enabled = false;
            this.nome_da_AgênciaComboBox.FormattingEnabled = true;
            this.nome_da_AgênciaComboBox.Location = new System.Drawing.Point(285, 173);
            this.nome_da_AgênciaComboBox.Name = "nome_da_AgênciaComboBox";
            this.nome_da_AgênciaComboBox.Size = new System.Drawing.Size(170, 21);
            this.nome_da_AgênciaComboBox.TabIndex = 4;
            this.nome_da_AgênciaComboBox.ValueMember = "Nome da Agência";
            this.nome_da_AgênciaComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // data_de_PagamentoDateTimePicker
            // 
            this.data_de_PagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagamento_do_ProfessorBindingSource, "Data de Pagamento", true));
            this.data_de_PagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_de_PagamentoDateTimePicker.Location = new System.Drawing.Point(285, 200);
            this.data_de_PagamentoDateTimePicker.Name = "data_de_PagamentoDateTimePicker";
            this.data_de_PagamentoDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.data_de_PagamentoDateTimePicker.TabIndex = 5;
            this.data_de_PagamentoDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // salario_BrutoTextBox
            // 
            this.salario_BrutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Salario Bruto", true));
            this.salario_BrutoTextBox.Location = new System.Drawing.Point(285, 226);
            this.salario_BrutoTextBox.Name = "salario_BrutoTextBox";
            this.salario_BrutoTextBox.Size = new System.Drawing.Size(122, 20);
            this.salario_BrutoTextBox.TabIndex = 6;
            this.salario_BrutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mensagem.SetToolTip(this.salario_BrutoTextBox, "5% do Salario Bruto será convertido em Descontos");
            this.salario_BrutoTextBox.TextChanged += new System.EventHandler(this.salario_BrutoTextBox_TextChanged);
            this.salario_BrutoTextBox.Enter += new System.EventHandler(this.salario_BrutoTextBox_Enter);
            this.salario_BrutoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            this.salario_BrutoTextBox.Leave += new System.EventHandler(this.salario_BrutoTextBox_Leave);
            // 
            // descontosTextBox
            // 
            this.descontosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Descontos", true));
            this.descontosTextBox.Enabled = false;
            this.descontosTextBox.Location = new System.Drawing.Point(285, 252);
            this.descontosTextBox.Name = "descontosTextBox";
            this.descontosTextBox.Size = new System.Drawing.Size(122, 20);
            this.descontosTextBox.TabIndex = 7;
            this.descontosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descontosTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // valor_da_HoraTextBox
            // 
            this.valor_da_HoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Valor da Hora", true));
            this.valor_da_HoraTextBox.Location = new System.Drawing.Point(285, 304);
            this.valor_da_HoraTextBox.Name = "valor_da_HoraTextBox";
            this.valor_da_HoraTextBox.Size = new System.Drawing.Size(122, 20);
            this.valor_da_HoraTextBox.TabIndex = 9;
            this.valor_da_HoraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valor_da_HoraTextBox.Enter += new System.EventHandler(this.valor_da_HoraTextBox_Enter);
            this.valor_da_HoraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            this.valor_da_HoraTextBox.Leave += new System.EventHandler(this.valor_da_HoraTextBox_Leave);
            // 
            // horas_ExtrasTextBox
            // 
            this.horas_ExtrasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Horas Extras", true));
            this.horas_ExtrasTextBox.Location = new System.Drawing.Point(285, 330);
            this.horas_ExtrasTextBox.Name = "horas_ExtrasTextBox";
            this.horas_ExtrasTextBox.Size = new System.Drawing.Size(122, 20);
            this.horas_ExtrasTextBox.TabIndex = 10;
            this.horas_ExtrasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.horas_ExtrasTextBox.Enter += new System.EventHandler(this.horas_ExtrasTextBox_Enter);
            this.horas_ExtrasTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            this.horas_ExtrasTextBox.Leave += new System.EventHandler(this.horas_ExtrasTextBox_Leave);
            // 
            // salario_LiquidoTextBox
            // 
            this.salario_LiquidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamento_do_ProfessorBindingSource, "Salario Liquido", true));
            this.salario_LiquidoTextBox.Enabled = false;
            this.salario_LiquidoTextBox.Location = new System.Drawing.Point(285, 356);
            this.salario_LiquidoTextBox.Name = "salario_LiquidoTextBox";
            this.salario_LiquidoTextBox.Size = new System.Drawing.Size(122, 20);
            this.salario_LiquidoTextBox.TabIndex = 13;
            this.salario_LiquidoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salario_LiquidoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // horas_TrabalhadasNumericUpDown
            // 
            this.horas_TrabalhadasNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagamento_do_ProfessorBindingSource, "Horas Trabalhadas", true));
            this.horas_TrabalhadasNumericUpDown.Location = new System.Drawing.Point(285, 278);
            this.horas_TrabalhadasNumericUpDown.Name = "horas_TrabalhadasNumericUpDown";
            this.horas_TrabalhadasNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.horas_TrabalhadasNumericUpDown.TabIndex = 8;
            this.horas_TrabalhadasNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.horas_TrabalhadasNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
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
            this.DataMenu.Size = new System.Drawing.Size(482, 25);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // Mensagem
            // 
            this.Mensagem.AutomaticDelay = 300;
            this.Mensagem.AutoPopDelay = 3000;
            this.Mensagem.InitialDelay = 300;
            this.Mensagem.ReshowDelay = 50;
            this.Mensagem.ShowAlways = true;
            this.Mensagem.StripAmpersands = true;
            this.Mensagem.ToolTipTitle = "Mensagem";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(413, 322);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(61, 26);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(413, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 26);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nome_do_ProfessorComboBox_KeyDown);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 385);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataMenu);
            this.Controls.Add(horas_TrabalhadasLabel);
            this.Controls.Add(this.horas_TrabalhadasNumericUpDown);
            this.Controls.Add(código_do_PagamentoLabel);
            this.Controls.Add(this.código_do_PagamentoLabel1);
            this.Controls.Add(nome_do_ProfessorLabel);
            this.Controls.Add(this.nome_do_ProfessorComboBox);
            this.Controls.Add(código_do_ProfessorLabel);
            this.Controls.Add(this.código_do_ProfessorComboBox);
            this.Controls.Add(conta_BancariaLabel);
            this.Controls.Add(this.conta_BancariaComboBox);
            this.Controls.Add(agênciaLabel);
            this.Controls.Add(this.agênciaComboBox);
            this.Controls.Add(nome_da_AgênciaLabel);
            this.Controls.Add(this.nome_da_AgênciaComboBox);
            this.Controls.Add(data_de_PagamentoLabel);
            this.Controls.Add(this.data_de_PagamentoDateTimePicker);
            this.Controls.Add(salario_BrutoLabel);
            this.Controls.Add(this.salario_BrutoTextBox);
            this.Controls.Add(descontosLabel);
            this.Controls.Add(this.descontosTextBox);
            this.Controls.Add(valor_da_HoraLabel);
            this.Controls.Add(this.valor_da_HoraTextBox);
            this.Controls.Add(horas_ExtrasLabel);
            this.Controls.Add(this.horas_ExtrasTextBox);
            this.Controls.Add(salario_LiquidoLabel);
            this.Controls.Add(this.salario_LiquidoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salário dos Professores";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_KWB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamento_do_ProfessorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horas_TrabalhadasNumericUpDown)).EndInit();
            this.DataMenu.ResumeLayout(false);
            this.DataMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Resources.BD_KWB_DataSet bD_KWB_DataSet;
        private System.Windows.Forms.BindingSource pagamento_do_ProfessorBindingSource;
        private Resources.BD_KWB_DataSetTableAdapters.Pagamento_do_ProfessorTableAdapter pagamento_do_ProfessorTableAdapter;
        private Resources.BD_KWB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Resources.BD_KWB_DataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.Label código_do_PagamentoLabel1;
        private System.Windows.Forms.ComboBox nome_do_ProfessorComboBox;
        private System.Windows.Forms.ComboBox código_do_ProfessorComboBox;
        private System.Windows.Forms.ComboBox conta_BancariaComboBox;
        private System.Windows.Forms.ComboBox agênciaComboBox;
        private System.Windows.Forms.ComboBox nome_da_AgênciaComboBox;
        private System.Windows.Forms.DateTimePicker data_de_PagamentoDateTimePicker;
        private System.Windows.Forms.TextBox salario_BrutoTextBox;
        private System.Windows.Forms.TextBox descontosTextBox;
        private System.Windows.Forms.TextBox valor_da_HoraTextBox;
        private System.Windows.Forms.TextBox horas_ExtrasTextBox;
        private System.Windows.Forms.TextBox salario_LiquidoTextBox;
        private System.Windows.Forms.NumericUpDown horas_TrabalhadasNumericUpDown;
        private System.Windows.Forms.BindingSource professoresBindingSource;
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
        private System.Windows.Forms.ToolTip Mensagem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;

    }
}