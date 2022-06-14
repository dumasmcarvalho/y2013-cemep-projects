namespace SysHeyLadybug
{
    partial class formestoque
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
            System.Windows.Forms.Label cod_EstoqueLabel;
            System.Windows.Forms.Label qtd_EstoqueLabel1;
            System.Windows.Forms.Label produtoLabel;
            System.Windows.Forms.Label fornecedorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formestoque));
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new SysHeyLadybug.BDDataSet();
            this.estoqueTableAdapter = new SysHeyLadybug.BDDataSetTableAdapters.EstoqueTableAdapter();
            this.tableAdapterManager = new SysHeyLadybug.BDDataSetTableAdapters.TableAdapterManager();
            this.produtoTableAdapter = new SysHeyLadybug.BDDataSetTableAdapters.ProdutoTableAdapter();
            this.estoqueBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.estoqueBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_EstoqueTextBox = new System.Windows.Forms.TextBox();
            this.qtd_EstoqueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedorComboBox = new System.Windows.Forms.ComboBox();
            cod_EstoqueLabel = new System.Windows.Forms.Label();
            qtd_EstoqueLabel1 = new System.Windows.Forms.Label();
            produtoLabel = new System.Windows.Forms.Label();
            fornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).BeginInit();
            this.estoqueBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtd_EstoqueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_EstoqueLabel
            // 
            cod_EstoqueLabel.AutoSize = true;
            cod_EstoqueLabel.Location = new System.Drawing.Point(45, 47);
            cod_EstoqueLabel.Name = "cod_EstoqueLabel";
            cod_EstoqueLabel.Size = new System.Drawing.Size(43, 13);
            cod_EstoqueLabel.TabIndex = 1;
            cod_EstoqueLabel.Text = "Código:";
            // 
            // qtd_EstoqueLabel1
            // 
            qtd_EstoqueLabel1.AutoSize = true;
            qtd_EstoqueLabel1.Location = new System.Drawing.Point(45, 146);
            qtd_EstoqueLabel1.Name = "qtd_EstoqueLabel1";
            qtd_EstoqueLabel1.Size = new System.Drawing.Size(65, 13);
            qtd_EstoqueLabel1.TabIndex = 9;
            qtd_EstoqueLabel1.Text = "Quantidade:";
            // 
            // produtoLabel
            // 
            produtoLabel.AutoSize = true;
            produtoLabel.Location = new System.Drawing.Point(45, 80);
            produtoLabel.Name = "produtoLabel";
            produtoLabel.Size = new System.Drawing.Size(47, 13);
            produtoLabel.TabIndex = 10;
            produtoLabel.Text = "Produto:";
            // 
            // fornecedorLabel
            // 
            fornecedorLabel.AutoSize = true;
            fornecedorLabel.Location = new System.Drawing.Point(45, 114);
            fornecedorLabel.Name = "fornecedorLabel";
            fornecedorLabel.Size = new System.Drawing.Size(64, 13);
            fornecedorLabel.TabIndex = 11;
            fornecedorLabel.Text = "Fornecedor:";
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SysHeyLadybug.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaTableAdapter = null;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueBindingNavigator
            // 
            this.estoqueBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estoqueBindingNavigator.BindingSource = this.estoqueBindingSource;
            this.estoqueBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estoqueBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estoqueBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estoqueBindingNavigatorSaveItem});
            this.estoqueBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estoqueBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estoqueBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estoqueBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estoqueBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estoqueBindingNavigator.Name = "estoqueBindingNavigator";
            this.estoqueBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estoqueBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.estoqueBindingNavigator.TabIndex = 0;
            this.estoqueBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
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
            // estoqueBindingNavigatorSaveItem
            // 
            this.estoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estoqueBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estoqueBindingNavigatorSaveItem.Image")));
            this.estoqueBindingNavigatorSaveItem.Name = "estoqueBindingNavigatorSaveItem";
            this.estoqueBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estoqueBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.estoqueBindingNavigatorSaveItem.Click += new System.EventHandler(this.estoqueBindingNavigatorSaveItem_Click);
            // 
            // cod_EstoqueTextBox
            // 
            this.cod_EstoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Cod_Estoque", true));
            this.cod_EstoqueTextBox.Enabled = false;
            this.cod_EstoqueTextBox.Location = new System.Drawing.Point(133, 44);
            this.cod_EstoqueTextBox.Name = "cod_EstoqueTextBox";
            this.cod_EstoqueTextBox.Size = new System.Drawing.Size(85, 20);
            this.cod_EstoqueTextBox.TabIndex = 2;
            this.cod_EstoqueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qtd_EstoqueNumericUpDown
            // 
            this.qtd_EstoqueNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estoqueBindingSource, "Qtd_Estoque", true));
            this.qtd_EstoqueNumericUpDown.Location = new System.Drawing.Point(133, 144);
            this.qtd_EstoqueNumericUpDown.Name = "qtd_EstoqueNumericUpDown";
            this.qtd_EstoqueNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.qtd_EstoqueNumericUpDown.TabIndex = 2;
            this.qtd_EstoqueNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bDDataSet;
            // 
            // produtoComboBox
            // 
            this.produtoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.produtoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.produtoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Produto", true));
            this.produtoComboBox.DataSource = this.produtoBindingSource;
            this.produtoComboBox.DisplayMember = "Descricao";
            this.produtoComboBox.FormattingEnabled = true;
            this.produtoComboBox.Location = new System.Drawing.Point(133, 77);
            this.produtoComboBox.Name = "produtoComboBox";
            this.produtoComboBox.Size = new System.Drawing.Size(184, 21);
            this.produtoComboBox.TabIndex = 0;
            this.produtoComboBox.ValueMember = "Cod_Produto";
            // 
            // fornecedorComboBox
            // 
            this.fornecedorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fornecedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fornecedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Fornecedor", true));
            this.fornecedorComboBox.DataSource = this.produtoBindingSource;
            this.fornecedorComboBox.DisplayMember = "Fornecedor";
            this.fornecedorComboBox.FormattingEnabled = true;
            this.fornecedorComboBox.Location = new System.Drawing.Point(133, 111);
            this.fornecedorComboBox.Name = "fornecedorComboBox";
            this.fornecedorComboBox.Size = new System.Drawing.Size(184, 21);
            this.fornecedorComboBox.TabIndex = 1;
            this.fornecedorComboBox.ValueMember = "Fornecedor";
            // 
            // formestoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 184);
            this.Controls.Add(fornecedorLabel);
            this.Controls.Add(this.fornecedorComboBox);
            this.Controls.Add(produtoLabel);
            this.Controls.Add(this.produtoComboBox);
            this.Controls.Add(qtd_EstoqueLabel1);
            this.Controls.Add(this.qtd_EstoqueNumericUpDown);
            this.Controls.Add(cod_EstoqueLabel);
            this.Controls.Add(this.cod_EstoqueTextBox);
            this.Controls.Add(this.estoqueBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formestoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.formestoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingNavigator)).EndInit();
            this.estoqueBindingNavigator.ResumeLayout(false);
            this.estoqueBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtd_EstoqueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private BDDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estoqueBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_EstoqueTextBox;
        private System.Windows.Forms.NumericUpDown qtd_EstoqueNumericUpDown;
        private BDDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.ComboBox produtoComboBox;
        private System.Windows.Forms.ComboBox fornecedorComboBox;
    }
}