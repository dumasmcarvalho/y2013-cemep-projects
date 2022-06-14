namespace SysBeautyCompany
{
    partial class FRMPROD
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
            System.Windows.Forms.Label iD_ProdutoLabel;
            System.Windows.Forms.Label produtoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valor_CompraLabel;
            System.Windows.Forms.Label reajusteLabel;
            System.Windows.Forms.Label valor_VendaLabel;
            System.Windows.Forms.Label valor_TotalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPROD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iD_ProdutoLabel1 = new System.Windows.Forms.Label();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_Dados_DataSet = new SysBeautyCompany.Banco_Dados_DataSet();
            this.produtoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor_CompraTextBox = new System.Windows.Forms.TextBox();
            this.reajusteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor_VendaTextBox = new System.Windows.Forms.TextBox();
            this.valor_TotalTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new SysBeautyCompany.Banco_Dados_DataSetTableAdapters.TableAdapterManager();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iD_ProdutoLabel = new System.Windows.Forms.Label();
            produtoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valor_CompraLabel = new System.Windows.Forms.Label();
            reajusteLabel = new System.Windows.Forms.Label();
            valor_VendaLabel = new System.Windows.Forms.Label();
            valor_TotalLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_Dados_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reajusteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_ProdutoLabel
            // 
            iD_ProdutoLabel.AutoSize = true;
            iD_ProdutoLabel.Location = new System.Drawing.Point(12, 37);
            iD_ProdutoLabel.Name = "iD_ProdutoLabel";
            iD_ProdutoLabel.Size = new System.Drawing.Size(61, 13);
            iD_ProdutoLabel.TabIndex = 4;
            iD_ProdutoLabel.Text = "ID-Produto:";
            // 
            // produtoLabel
            // 
            produtoLabel.AutoSize = true;
            produtoLabel.Location = new System.Drawing.Point(12, 70);
            produtoLabel.Name = "produtoLabel";
            produtoLabel.Size = new System.Drawing.Size(47, 13);
            produtoLabel.TabIndex = 6;
            produtoLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(12, 169);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 8;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valor_CompraLabel
            // 
            valor_CompraLabel.AutoSize = true;
            valor_CompraLabel.Location = new System.Drawing.Point(12, 105);
            valor_CompraLabel.Name = "valor_CompraLabel";
            valor_CompraLabel.Size = new System.Drawing.Size(73, 13);
            valor_CompraLabel.TabIndex = 10;
            valor_CompraLabel.Text = "Valor-Compra:";
            // 
            // reajusteLabel
            // 
            reajusteLabel.AutoSize = true;
            reajusteLabel.Location = new System.Drawing.Point(12, 137);
            reajusteLabel.Name = "reajusteLabel";
            reajusteLabel.Size = new System.Drawing.Size(69, 13);
            reajusteLabel.TabIndex = 12;
            reajusteLabel.Text = "Reajuste (%):";
            // 
            // valor_VendaLabel
            // 
            valor_VendaLabel.AutoSize = true;
            valor_VendaLabel.Location = new System.Drawing.Point(12, 204);
            valor_VendaLabel.Name = "valor_VendaLabel";
            valor_VendaLabel.Size = new System.Drawing.Size(68, 13);
            valor_VendaLabel.TabIndex = 14;
            valor_VendaLabel.Text = "Valor-Venda:";
            // 
            // valor_TotalLabel
            // 
            valor_TotalLabel.AutoSize = true;
            valor_TotalLabel.Location = new System.Drawing.Point(12, 237);
            valor_TotalLabel.Name = "valor_TotalLabel";
            valor_TotalLabel.Size = new System.Drawing.Size(61, 13);
            valor_TotalLabel.TabIndex = 16;
            valor_TotalLabel.Text = "Valor-Total:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iD_ProdutoLabel);
            this.panel1.Controls.Add(this.iD_ProdutoLabel1);
            this.panel1.Controls.Add(produtoLabel);
            this.panel1.Controls.Add(this.produtoTextBox);
            this.panel1.Controls.Add(quantidadeLabel);
            this.panel1.Controls.Add(this.quantidadeNumericUpDown);
            this.panel1.Controls.Add(valor_CompraLabel);
            this.panel1.Controls.Add(this.valor_CompraTextBox);
            this.panel1.Controls.Add(reajusteLabel);
            this.panel1.Controls.Add(this.reajusteNumericUpDown);
            this.panel1.Controls.Add(valor_VendaLabel);
            this.panel1.Controls.Add(this.valor_VendaTextBox);
            this.panel1.Controls.Add(valor_TotalLabel);
            this.panel1.Controls.Add(this.valor_TotalTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 267);
            this.panel1.TabIndex = 1;
            // 
            // iD_ProdutoLabel1
            // 
            this.iD_ProdutoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "ID-Produto", true));
            this.iD_ProdutoLabel1.Location = new System.Drawing.Point(91, 37);
            this.iD_ProdutoLabel1.Name = "iD_ProdutoLabel1";
            this.iD_ProdutoLabel1.Size = new System.Drawing.Size(195, 23);
            this.iD_ProdutoLabel1.TabIndex = 5;
            this.iD_ProdutoLabel1.Text = "ID-Produto";
            this.iD_ProdutoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.banco_Dados_DataSet;
            // 
            // banco_Dados_DataSet
            // 
            this.banco_Dados_DataSet.DataSetName = "Banco_Dados_DataSet";
            this.banco_Dados_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoTextBox
            // 
            this.produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Produto", true));
            this.produtoTextBox.Location = new System.Drawing.Point(91, 69);
            this.produtoTextBox.Name = "produtoTextBox";
            this.produtoTextBox.Size = new System.Drawing.Size(195, 20);
            this.produtoTextBox.TabIndex = 0;
            this.produtoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.produtoTextBox_KeyDown);
            // 
            // quantidadeNumericUpDown
            // 
            this.quantidadeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource, "Quantidade", true));
            this.quantidadeNumericUpDown.Location = new System.Drawing.Point(92, 167);
            this.quantidadeNumericUpDown.Name = "quantidadeNumericUpDown";
            this.quantidadeNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.quantidadeNumericUpDown.TabIndex = 3;
            this.quantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantidadeNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.produtoTextBox_KeyDown);
            // 
            // valor_CompraTextBox
            // 
            this.valor_CompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor-Compra", true));
            this.valor_CompraTextBox.Location = new System.Drawing.Point(91, 102);
            this.valor_CompraTextBox.Name = "valor_CompraTextBox";
            this.valor_CompraTextBox.Size = new System.Drawing.Size(107, 20);
            this.valor_CompraTextBox.TabIndex = 1;
            this.valor_CompraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valor_CompraTextBox.Enter += new System.EventHandler(this.valor_CompraTextBox_Enter);
            this.valor_CompraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.produtoTextBox_KeyDown);
            this.valor_CompraTextBox.Leave += new System.EventHandler(this.valor_CompraTextBox_Leave);
            // 
            // reajusteNumericUpDown
            // 
            this.reajusteNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource, "Reajuste", true));
            this.reajusteNumericUpDown.Location = new System.Drawing.Point(91, 135);
            this.reajusteNumericUpDown.Name = "reajusteNumericUpDown";
            this.reajusteNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.reajusteNumericUpDown.TabIndex = 2;
            this.reajusteNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reajusteNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.produtoTextBox_KeyDown);
            // 
            // valor_VendaTextBox
            // 
            this.valor_VendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor-Venda", true));
            this.valor_VendaTextBox.Location = new System.Drawing.Point(91, 201);
            this.valor_VendaTextBox.Name = "valor_VendaTextBox";
            this.valor_VendaTextBox.Size = new System.Drawing.Size(107, 20);
            this.valor_VendaTextBox.TabIndex = 15;
            this.valor_VendaTextBox.TabStop = false;
            this.valor_VendaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor_TotalTextBox
            // 
            this.valor_TotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor-Total", true));
            this.valor_TotalTextBox.Location = new System.Drawing.Point(91, 234);
            this.valor_TotalTextBox.Name = "valor_TotalTextBox";
            this.valor_TotalTextBox.Size = new System.Drawing.Size(107, 20);
            this.valor_TotalTextBox.TabIndex = 17;
            this.valor_TotalTextBox.TabStop = false;
            this.valor_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.produtoTextBox_KeyDown);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.ServiçoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SysBeautyCompany.Banco_Dados_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingNavigatorSaveItem});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(307, 25);
            this.produtoBindingNavigator.TabIndex = 2;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
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
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingNavigatorSaveItem.Image")));
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
            // 
            // FRMPROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 267);
            this.Controls.Add(this.produtoBindingNavigator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMPROD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FRMMOV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_Dados_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reajusteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Banco_Dados_DataSet banco_Dados_DataSet;
        private Banco_Dados_DataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private Banco_Dados_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_ProdutoLabel1;
        private System.Windows.Forms.TextBox produtoTextBox;
        private System.Windows.Forms.NumericUpDown quantidadeNumericUpDown;
        private System.Windows.Forms.TextBox valor_CompraTextBox;
        private System.Windows.Forms.NumericUpDown reajusteNumericUpDown;
        private System.Windows.Forms.TextBox valor_VendaTextBox;
        private System.Windows.Forms.TextBox valor_TotalTextBox;
    }
}