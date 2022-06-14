namespace SysBeautyCompany
{
    partial class FRMSERV
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
            System.Windows.Forms.Label iD_ServiçoLabel;
            System.Windows.Forms.Label serviçoLabel;
            System.Windows.Forms.Label funcionarioLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label valorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSERV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_ServiçoLabel1 = new System.Windows.Forms.Label();
            this.serviçoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_Dados_DataSet = new SysBeautyCompany.Banco_Dados_DataSet();
            this.serviçoTextBox = new System.Windows.Forms.TextBox();
            this.funcionarioComboBox = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.serviçoTableAdapter = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.ServiçoTableAdapter();
            this.tableAdapterManager = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.ClienteTableAdapter();
            this.funcionarioTableAdapter = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.FuncionarioTableAdapter();
            this.serviçoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.serviçoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_ServiçoLabel = new System.Windows.Forms.Label();
            serviçoLabel = new System.Windows.Forms.Label();
            funcionarioLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviçoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_Dados_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviçoBindingNavigator)).BeginInit();
            this.serviçoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_ServiçoLabel
            // 
            iD_ServiçoLabel.AutoSize = true;
            iD_ServiçoLabel.Location = new System.Drawing.Point(12, 39);
            iD_ServiçoLabel.Name = "iD_ServiçoLabel";
            iD_ServiçoLabel.Size = new System.Drawing.Size(60, 13);
            iD_ServiçoLabel.TabIndex = 0;
            iD_ServiçoLabel.Text = "ID-Serviço:";
            // 
            // serviçoLabel
            // 
            serviçoLabel.AutoSize = true;
            serviçoLabel.Location = new System.Drawing.Point(12, 76);
            serviçoLabel.Name = "serviçoLabel";
            serviçoLabel.Size = new System.Drawing.Size(46, 13);
            serviçoLabel.TabIndex = 2;
            serviçoLabel.Text = "Serviço:";
            // 
            // funcionarioLabel
            // 
            funcionarioLabel.AutoSize = true;
            funcionarioLabel.Location = new System.Drawing.Point(12, 110);
            funcionarioLabel.Name = "funcionarioLabel";
            funcionarioLabel.Size = new System.Drawing.Size(65, 13);
            funcionarioLabel.TabIndex = 4;
            funcionarioLabel.Text = "Funcionario:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(12, 145);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 6;
            clienteLabel.Text = "Cliente:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(12, 180);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_ServiçoLabel);
            this.panel1.Controls.Add(this.iD_ServiçoLabel1);
            this.panel1.Controls.Add(serviçoLabel);
            this.panel1.Controls.Add(this.serviçoTextBox);
            this.panel1.Controls.Add(funcionarioLabel);
            this.panel1.Controls.Add(this.funcionarioComboBox);
            this.panel1.Controls.Add(clienteLabel);
            this.panel1.Controls.Add(this.clienteComboBox);
            this.panel1.Controls.Add(valorLabel);
            this.panel1.Controls.Add(this.valorTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 212);
            this.panel1.TabIndex = 0;
            // 
            // iD_ServiçoLabel1
            // 
            this.iD_ServiçoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviçoBindingSource, "ID-Serviço", true));
            this.iD_ServiçoLabel1.Location = new System.Drawing.Point(83, 39);
            this.iD_ServiçoLabel1.Name = "iD_ServiçoLabel1";
            this.iD_ServiçoLabel1.Size = new System.Drawing.Size(188, 23);
            this.iD_ServiçoLabel1.TabIndex = 1;
            this.iD_ServiçoLabel1.Text = "ID-Cliente";
            this.iD_ServiçoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serviçoBindingSource
            // 
            this.serviçoBindingSource.DataMember = "Serviço";
            this.serviçoBindingSource.DataSource = this.banco_Dados_DataSet;
            // 
            // banco_Dados_DataSet
            // 
            this.banco_Dados_DataSet.DataSetName = "Banco_Dados_DataSet";
            this.banco_Dados_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviçoTextBox
            // 
            this.serviçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviçoBindingSource, "Serviço", true));
            this.serviçoTextBox.Location = new System.Drawing.Point(83, 73);
            this.serviçoTextBox.Name = "serviçoTextBox";
            this.serviçoTextBox.Size = new System.Drawing.Size(188, 20);
            this.serviçoTextBox.TabIndex = 3;
            this.serviçoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serviçoTextBox_KeyDown);
            // 
            // funcionarioComboBox
            // 
            this.funcionarioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.funcionarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviçoBindingSource, "Funcionario", true));
            this.funcionarioComboBox.DataSource = this.funcionarioBindingSource;
            this.funcionarioComboBox.DisplayMember = "Nome";
            this.funcionarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcionarioComboBox.FormattingEnabled = true;
            this.funcionarioComboBox.Location = new System.Drawing.Point(83, 107);
            this.funcionarioComboBox.Name = "funcionarioComboBox";
            this.funcionarioComboBox.Size = new System.Drawing.Size(138, 21);
            this.funcionarioComboBox.TabIndex = 5;
            this.funcionarioComboBox.ValueMember = "ID-Funcionario";
            this.funcionarioComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serviçoTextBox_KeyDown);
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.banco_Dados_DataSet;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviçoBindingSource, "Cliente", true));
            this.clienteComboBox.DataSource = this.clienteBindingSource;
            this.clienteComboBox.DisplayMember = "Nome";
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(83, 142);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(138, 21);
            this.clienteComboBox.TabIndex = 7;
            this.clienteComboBox.ValueMember = "ID-Cliente";
            this.clienteComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serviçoTextBox_KeyDown);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.banco_Dados_DataSet;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviçoBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(83, 177);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(108, 20);
            this.valorTextBox.TabIndex = 9;
            this.valorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valorTextBox.Enter += new System.EventHandler(this.valorTextBox_Enter);
            this.valorTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serviçoTextBox_KeyDown);
            this.valorTextBox.Leave += new System.EventHandler(this.valorTextBox_Leave);
            // 
            // serviçoTableAdapter
            // 
            this.serviçoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServiçoTableAdapter = this.serviçoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SysBeautyCompany.Banco_Dados_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // serviçoBindingNavigator
            // 
            this.serviçoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviçoBindingNavigator.BindingSource = this.serviçoBindingSource;
            this.serviçoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviçoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.serviçoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.serviçoBindingNavigatorSaveItem});
            this.serviçoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.serviçoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.serviçoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.serviçoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviçoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviçoBindingNavigator.Name = "serviçoBindingNavigator";
            this.serviçoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviçoBindingNavigator.Size = new System.Drawing.Size(288, 25);
            this.serviçoBindingNavigator.TabIndex = 1;
            this.serviçoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
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
            // serviçoBindingNavigatorSaveItem
            // 
            this.serviçoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviçoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviçoBindingNavigatorSaveItem.Image")));
            this.serviçoBindingNavigatorSaveItem.Name = "serviçoBindingNavigatorSaveItem";
            this.serviçoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.serviçoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.serviçoBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviçosBindingNavigatorSaveItem_Click);
            // 
            // FRMSERV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 212);
            this.Controls.Add(this.serviçoBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMSERV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.Servi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviçoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_Dados_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviçoBindingNavigator)).EndInit();
            this.serviçoBindingNavigator.ResumeLayout(false);
            this.serviçoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Banco_Dados_DataSet banco_Dados_DataSet;
        private System.Windows.Forms.BindingSource serviçoBindingSource;
        private Banco_Dados_DataSetTableAdapters.ServiçoTableAdapter serviçoTableAdapter;
        private Banco_Dados_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator serviçoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton serviçoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_ServiçoLabel1;
        private System.Windows.Forms.TextBox serviçoTextBox;
        private System.Windows.Forms.ComboBox funcionarioComboBox;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private Banco_Dados_DataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private Banco_Dados_DataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;



    }
}