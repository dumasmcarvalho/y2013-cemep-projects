namespace SysBeautyCompany
{
    partial class FRMPAGAM
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
            System.Windows.Forms.Label iD_PagamentoLabel;
            System.Windows.Forms.Label iD_ClienteLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label forma_PagamentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPAGAM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_Dados_DataSet = new SysBeautyCompany.Banco_Dados_DataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.iD_PagamentoLabel1 = new System.Windows.Forms.Label();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.forma_PagamentoComboBox = new System.Windows.Forms.ComboBox();
            this.pagamentoTableAdapter = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.PagamentoTableAdapter();
            this.tableAdapterManager = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.ClienteTableAdapter();
            this.pagamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pagamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_PagamentoLabel = new System.Windows.Forms.Label();
            iD_ClienteLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            forma_PagamentoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_Dados_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingNavigator)).BeginInit();
            this.pagamentoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_PagamentoLabel
            // 
            iD_PagamentoLabel.AutoSize = true;
            iD_PagamentoLabel.Location = new System.Drawing.Point(12, 38);
            iD_PagamentoLabel.Name = "iD_PagamentoLabel";
            iD_PagamentoLabel.Size = new System.Drawing.Size(78, 13);
            iD_PagamentoLabel.TabIndex = 0;
            iD_PagamentoLabel.Text = "ID-Pagamento:";
            // 
            // iD_ClienteLabel
            // 
            iD_ClienteLabel.AutoSize = true;
            iD_ClienteLabel.Location = new System.Drawing.Point(12, 73);
            iD_ClienteLabel.Name = "iD_ClienteLabel";
            iD_ClienteLabel.Size = new System.Drawing.Size(56, 13);
            iD_ClienteLabel.TabIndex = 2;
            iD_ClienteLabel.Text = "ID-Cliente:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(12, 109);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 6;
            dataLabel.Text = "Data:";
            // 
            // forma_PagamentoLabel
            // 
            forma_PagamentoLabel.AutoSize = true;
            forma_PagamentoLabel.Location = new System.Drawing.Point(12, 142);
            forma_PagamentoLabel.Name = "forma_PagamentoLabel";
            forma_PagamentoLabel.Size = new System.Drawing.Size(96, 13);
            forma_PagamentoLabel.TabIndex = 8;
            forma_PagamentoLabel.Text = "Forma-Pagamento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nomeComboBox);
            this.panel1.Controls.Add(this.iD_ClienteComboBox);
            this.panel1.Controls.Add(iD_PagamentoLabel);
            this.panel1.Controls.Add(this.iD_PagamentoLabel1);
            this.panel1.Controls.Add(iD_ClienteLabel);
            this.panel1.Controls.Add(dataLabel);
            this.panel1.Controls.Add(this.dataDateTimePicker);
            this.panel1.Controls.Add(forma_PagamentoLabel);
            this.panel1.Controls.Add(this.forma_PagamentoComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 173);
            this.panel1.TabIndex = 0;
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "Nome", true));
            this.nomeComboBox.DataSource = this.clienteBindingSource;
            this.nomeComboBox.DisplayMember = "Nome";
            this.nomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.nomeComboBox.Enabled = false;
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(193, 70);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(192, 21);
            this.nomeComboBox.TabIndex = 1;
            this.nomeComboBox.ValueMember = "ID-Cliente";
            this.nomeComboBox.SelectedIndexChanged += new System.EventHandler(this.nomeComboBox_SelectedIndexChanged);
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "Pagamento";
            this.pagamentoBindingSource.DataSource = this.banco_Dados_DataSet;
            // 
            // banco_Dados_DataSet
            // 
            this.banco_Dados_DataSet.DataSetName = "Banco_Dados_DataSet";
            this.banco_Dados_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.banco_Dados_DataSet;
            // 
            // iD_ClienteComboBox
            // 
            this.iD_ClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.iD_ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "ID-Cliente", true));
            this.iD_ClienteComboBox.DataSource = this.clienteBindingSource;
            this.iD_ClienteComboBox.DisplayMember = "ID-Cliente";
            this.iD_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_ClienteComboBox.FormattingEnabled = true;
            this.iD_ClienteComboBox.Location = new System.Drawing.Point(117, 70);
            this.iD_ClienteComboBox.Name = "iD_ClienteComboBox";
            this.iD_ClienteComboBox.Size = new System.Drawing.Size(70, 21);
            this.iD_ClienteComboBox.TabIndex = 0;
            this.iD_ClienteComboBox.ValueMember = "Nome";
            this.iD_ClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.iD_ClienteComboBox_SelectedIndexChanged_1);
            this.iD_ClienteComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iD_ClienteComboBox_KeyDown);
            // 
            // iD_PagamentoLabel1
            // 
            this.iD_PagamentoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "ID-Pagamento", true));
            this.iD_PagamentoLabel1.Location = new System.Drawing.Point(114, 38);
            this.iD_PagamentoLabel1.Name = "iD_PagamentoLabel1";
            this.iD_PagamentoLabel1.Size = new System.Drawing.Size(271, 23);
            this.iD_PagamentoLabel1.TabIndex = 1;
            this.iD_PagamentoLabel1.Text = "ID-Pagamento";
            this.iD_PagamentoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagamentoBindingSource, "Data", true));
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(117, 105);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.dataDateTimePicker.TabIndex = 2;
            this.dataDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iD_ClienteComboBox_KeyDown);
            // 
            // forma_PagamentoComboBox
            // 
            this.forma_PagamentoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.forma_PagamentoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.forma_PagamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "Forma-Pagamento", true));
            this.forma_PagamentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.forma_PagamentoComboBox.FormattingEnabled = true;
            this.forma_PagamentoComboBox.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.forma_PagamentoComboBox.Location = new System.Drawing.Point(117, 139);
            this.forma_PagamentoComboBox.Name = "forma_PagamentoComboBox";
            this.forma_PagamentoComboBox.Size = new System.Drawing.Size(132, 21);
            this.forma_PagamentoComboBox.TabIndex = 3;
            this.forma_PagamentoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iD_ClienteComboBox_KeyDown);
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = this.pagamentoTableAdapter;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServiçoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SysBeautyCompany.Banco_Dados_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // pagamentoBindingNavigator
            // 
            this.pagamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pagamentoBindingNavigator.BindingSource = this.pagamentoBindingSource;
            this.pagamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pagamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pagamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pagamentoBindingNavigatorSaveItem});
            this.pagamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pagamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pagamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pagamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pagamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pagamentoBindingNavigator.Name = "pagamentoBindingNavigator";
            this.pagamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pagamentoBindingNavigator.Size = new System.Drawing.Size(397, 25);
            this.pagamentoBindingNavigator.TabIndex = 1;
            this.pagamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pagamentoBindingNavigatorSaveItem
            // 
            this.pagamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pagamentoBindingNavigatorSaveItem.Image")));
            this.pagamentoBindingNavigatorSaveItem.Name = "pagamentoBindingNavigatorSaveItem";
            this.pagamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pagamentoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pagamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pagamentoBindingNavigatorSaveItem_Click);
            // 
            // FRMPAGAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 173);
            this.Controls.Add(this.pagamentoBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMPAGAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pagam_FormClosed);
            this.Load += new System.EventHandler(this.FRMPAGAM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_Dados_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingNavigator)).EndInit();
            this.pagamentoBindingNavigator.ResumeLayout(false);
            this.pagamentoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Banco_Dados_DataSet banco_Dados_DataSet;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private Banco_Dados_DataSetTableAdapters.PagamentoTableAdapter pagamentoTableAdapter;
        private Banco_Dados_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pagamentoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pagamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_PagamentoLabel1;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox forma_PagamentoComboBox;
        private Banco_Dados_DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private System.Windows.Forms.ComboBox iD_ClienteComboBox;
    }
}