<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendaCompra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ID_da_Venda_CompraLabel As System.Windows.Forms.Label
        Dim Data_da_Venda_CompraLabel As System.Windows.Forms.Label
        Dim Nome_do_FuncionárioLabel As System.Windows.Forms.Label
        Dim ID_do_FuncionárioLabel As System.Windows.Forms.Label
        Dim Nome_do_ClienteLabel As System.Windows.Forms.Label
        Dim ID_do_ClienteLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim ID_do_ProdutoLabel As System.Windows.Forms.Label
        Dim Valor_UnitárioLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim Sub_TotalLabel As System.Windows.Forms.Label
        Dim ID_da_Venda_CompraLabel2 As System.Windows.Forms.Label
        Dim Valor_TotalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendaCompra))
        Me.Banco_OtakuFestDataSet = New OtakuFest.Banco_OtakuFestDataSet
        Me.Venda_CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Venda_CompraTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.Venda_CompraTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        Me.Itens_da_Venda_CompraTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.Itens_da_Venda_CompraTableAdapter
        Me.ProdutosTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.ProdutosTableAdapter
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Controles_Páginas = New System.Windows.Forms.TabControl
        Me.Página_Um = New System.Windows.Forms.TabPage
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.Venda_CompraBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Venda_CompraBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ID_da_Venda_CompraLabel1 = New System.Windows.Forms.Label
        Me.Data_da_Venda_CompraMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Nome_do_FuncionárioComboBox = New System.Windows.Forms.ComboBox
        Me.FuncionárioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_do_FuncionárioComboBox = New System.Windows.Forms.ComboBox
        Me.Nome_do_ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_do_ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.Valor_TotalTextBox = New System.Windows.Forms.TextBox
        Me.Página_Dois = New System.Windows.Forms.TabPage
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.btnRemover = New System.Windows.Forms.Button
        Me.btnAdicionar = New System.Windows.Forms.Button
        Me.ID_da_Venda_CompraLabel3 = New System.Windows.Forms.Label
        Me.Itens_da_Venda_CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sub_TotalTextBox = New System.Windows.Forms.TextBox
        Me.QuantidadeNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Valor_UnitárioTextBox = New System.Windows.Forms.TextBox
        Me.ID_do_ProdutoComboBox = New System.Windows.Forms.ComboBox
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriçãoComboBox = New System.Windows.Forms.ComboBox
        Me.Tabela_Itens = New System.Windows.Forms.DataGridView
        Me.FuncionárioTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.FuncionárioTableAdapter
        Me.ClienteTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
        ID_da_Venda_CompraLabel = New System.Windows.Forms.Label
        Data_da_Venda_CompraLabel = New System.Windows.Forms.Label
        Nome_do_FuncionárioLabel = New System.Windows.Forms.Label
        ID_do_FuncionárioLabel = New System.Windows.Forms.Label
        Nome_do_ClienteLabel = New System.Windows.Forms.Label
        ID_do_ClienteLabel = New System.Windows.Forms.Label
        DescriçãoLabel = New System.Windows.Forms.Label
        ID_do_ProdutoLabel = New System.Windows.Forms.Label
        Valor_UnitárioLabel = New System.Windows.Forms.Label
        QuantidadeLabel = New System.Windows.Forms.Label
        Sub_TotalLabel = New System.Windows.Forms.Label
        ID_da_Venda_CompraLabel2 = New System.Windows.Forms.Label
        Valor_TotalLabel = New System.Windows.Forms.Label
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Controles_Páginas.SuspendLayout()
        Me.Página_Um.SuspendLayout()
        CType(Me.Venda_CompraBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Venda_CompraBindingNavigator.SuspendLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Página_Dois.SuspendLayout()
        CType(Me.Itens_da_Venda_CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabela_Itens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_da_Venda_CompraLabel
        '
        ID_da_Venda_CompraLabel.AutoSize = True
        ID_da_Venda_CompraLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_da_Venda_CompraLabel.Location = New System.Drawing.Point(18, 51)
        ID_da_Venda_CompraLabel.Name = "ID_da_Venda_CompraLabel"
        ID_da_Venda_CompraLabel.Size = New System.Drawing.Size(160, 14)
        ID_da_Venda_CompraLabel.TabIndex = 15
        ID_da_Venda_CompraLabel.Text = "ID da Venda/Compra:"
        '
        'Data_da_Venda_CompraLabel
        '
        Data_da_Venda_CompraLabel.AutoSize = True
        Data_da_Venda_CompraLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_da_Venda_CompraLabel.Location = New System.Drawing.Point(18, 88)
        Data_da_Venda_CompraLabel.Name = "Data_da_Venda_CompraLabel"
        Data_da_Venda_CompraLabel.Size = New System.Drawing.Size(178, 14)
        Data_da_Venda_CompraLabel.TabIndex = 17
        Data_da_Venda_CompraLabel.Text = "Data da Venda/Compra:"
        '
        'Nome_do_FuncionárioLabel
        '
        Nome_do_FuncionárioLabel.AutoSize = True
        Nome_do_FuncionárioLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_do_FuncionárioLabel.Location = New System.Drawing.Point(18, 122)
        Nome_do_FuncionárioLabel.Name = "Nome_do_FuncionárioLabel"
        Nome_do_FuncionárioLabel.Size = New System.Drawing.Size(168, 14)
        Nome_do_FuncionárioLabel.TabIndex = 19
        Nome_do_FuncionárioLabel.Text = "Nome do Funcionário:"
        '
        'ID_do_FuncionárioLabel
        '
        ID_do_FuncionárioLabel.AutoSize = True
        ID_do_FuncionárioLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_FuncionárioLabel.Location = New System.Drawing.Point(18, 157)
        ID_do_FuncionárioLabel.Name = "ID_do_FuncionárioLabel"
        ID_do_FuncionárioLabel.Size = New System.Drawing.Size(146, 14)
        ID_do_FuncionárioLabel.TabIndex = 21
        ID_do_FuncionárioLabel.Text = "ID do Funcionário:"
        '
        'Nome_do_ClienteLabel
        '
        Nome_do_ClienteLabel.AutoSize = True
        Nome_do_ClienteLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_do_ClienteLabel.Location = New System.Drawing.Point(18, 192)
        Nome_do_ClienteLabel.Name = "Nome_do_ClienteLabel"
        Nome_do_ClienteLabel.Size = New System.Drawing.Size(131, 14)
        Nome_do_ClienteLabel.TabIndex = 23
        Nome_do_ClienteLabel.Text = "Nome do Cliente:"
        '
        'ID_do_ClienteLabel
        '
        ID_do_ClienteLabel.AutoSize = True
        ID_do_ClienteLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_ClienteLabel.Location = New System.Drawing.Point(18, 227)
        ID_do_ClienteLabel.Name = "ID_do_ClienteLabel"
        ID_do_ClienteLabel.Size = New System.Drawing.Size(109, 14)
        ID_do_ClienteLabel.TabIndex = 25
        ID_do_ClienteLabel.Text = "ID do Cliente:"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriçãoLabel.Location = New System.Drawing.Point(21, 58)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(84, 14)
        DescriçãoLabel.TabIndex = 37
        DescriçãoLabel.Text = "Descrição:"
        '
        'ID_do_ProdutoLabel
        '
        ID_do_ProdutoLabel.AutoSize = True
        ID_do_ProdutoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_ProdutoLabel.Location = New System.Drawing.Point(21, 96)
        ID_do_ProdutoLabel.Name = "ID_do_ProdutoLabel"
        ID_do_ProdutoLabel.Size = New System.Drawing.Size(120, 14)
        ID_do_ProdutoLabel.TabIndex = 38
        ID_do_ProdutoLabel.Text = "ID do Produto:"
        '
        'Valor_UnitárioLabel
        '
        Valor_UnitárioLabel.AutoSize = True
        Valor_UnitárioLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor_UnitárioLabel.Location = New System.Drawing.Point(350, 23)
        Valor_UnitárioLabel.Name = "Valor_UnitárioLabel"
        Valor_UnitárioLabel.Size = New System.Drawing.Size(118, 14)
        Valor_UnitárioLabel.TabIndex = 39
        Valor_UnitárioLabel.Text = "Valor Unitário:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantidadeLabel.Location = New System.Drawing.Point(350, 58)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(94, 14)
        QuantidadeLabel.TabIndex = 40
        QuantidadeLabel.Text = "Quantidade:"
        '
        'Sub_TotalLabel
        '
        Sub_TotalLabel.AutoSize = True
        Sub_TotalLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sub_TotalLabel.Location = New System.Drawing.Point(350, 96)
        Sub_TotalLabel.Name = "Sub_TotalLabel"
        Sub_TotalLabel.Size = New System.Drawing.Size(86, 14)
        Sub_TotalLabel.TabIndex = 41
        Sub_TotalLabel.Text = "Sub Total:"
        '
        'ID_da_Venda_CompraLabel2
        '
        ID_da_Venda_CompraLabel2.AutoSize = True
        ID_da_Venda_CompraLabel2.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_da_Venda_CompraLabel2.Location = New System.Drawing.Point(21, 23)
        ID_da_Venda_CompraLabel2.Name = "ID_da_Venda_CompraLabel2"
        ID_da_Venda_CompraLabel2.Size = New System.Drawing.Size(160, 14)
        ID_da_Venda_CompraLabel2.TabIndex = 42
        ID_da_Venda_CompraLabel2.Text = "ID da Venda/Compra:"
        '
        'Valor_TotalLabel
        '
        Valor_TotalLabel.AutoSize = True
        Valor_TotalLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor_TotalLabel.Location = New System.Drawing.Point(18, 262)
        Valor_TotalLabel.Name = "Valor_TotalLabel"
        Valor_TotalLabel.Size = New System.Drawing.Size(101, 14)
        Valor_TotalLabel.TabIndex = 27
        Valor_TotalLabel.Text = "Valor Total:"
        '
        'Banco_OtakuFestDataSet
        '
        Me.Banco_OtakuFestDataSet.DataSetName = "Banco_OtakuFestDataSet"
        Me.Banco_OtakuFestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Venda_CompraBindingSource
        '
        Me.Venda_CompraBindingSource.DataMember = "Venda/Compra"
        Me.Venda_CompraBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'Venda_CompraTableAdapter
        '
        Me.Venda_CompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Itens_da_Venda_CompraTableAdapter = Me.Itens_da_Venda_CompraTableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Pagamento_do_ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Me.ProdutosTableAdapter
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Me.Venda_CompraTableAdapter
        '
        'Itens_da_Venda_CompraTableAdapter
        '
        Me.Itens_da_Venda_CompraTableAdapter.ClearBeforeFill = True
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 393)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(425, 259)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'Controles_Páginas
        '
        Me.Controles_Páginas.Controls.Add(Me.Página_Um)
        Me.Controles_Páginas.Controls.Add(Me.Página_Dois)
        Me.Controles_Páginas.Location = New System.Drawing.Point(87, 12)
        Me.Controles_Páginas.Name = "Controles_Páginas"
        Me.Controles_Páginas.SelectedIndex = 0
        Me.Controles_Páginas.Size = New System.Drawing.Size(610, 374)
        Me.Controles_Páginas.TabIndex = 37
        Me.Controles_Páginas.TabStop = False
        '
        'Página_Um
        '
        Me.Página_Um.Controls.Add(Me.btnCalcular)
        Me.Página_Um.Controls.Add(Me.Venda_CompraBindingNavigator)
        Me.Página_Um.Controls.Add(ID_da_Venda_CompraLabel)
        Me.Página_Um.Controls.Add(Me.ID_da_Venda_CompraLabel1)
        Me.Página_Um.Controls.Add(Data_da_Venda_CompraLabel)
        Me.Página_Um.Controls.Add(Me.Data_da_Venda_CompraMaskedTextBox)
        Me.Página_Um.Controls.Add(Nome_do_FuncionárioLabel)
        Me.Página_Um.Controls.Add(Me.Nome_do_FuncionárioComboBox)
        Me.Página_Um.Controls.Add(ID_do_FuncionárioLabel)
        Me.Página_Um.Controls.Add(Me.ID_do_FuncionárioComboBox)
        Me.Página_Um.Controls.Add(Nome_do_ClienteLabel)
        Me.Página_Um.Controls.Add(Me.Nome_do_ClienteComboBox)
        Me.Página_Um.Controls.Add(ID_do_ClienteLabel)
        Me.Página_Um.Controls.Add(Me.ID_do_ClienteComboBox)
        Me.Página_Um.Controls.Add(Valor_TotalLabel)
        Me.Página_Um.Controls.Add(Me.Valor_TotalTextBox)
        Me.Página_Um.Location = New System.Drawing.Point(4, 22)
        Me.Página_Um.Name = "Página_Um"
        Me.Página_Um.Padding = New System.Windows.Forms.Padding(3)
        Me.Página_Um.Size = New System.Drawing.Size(602, 348)
        Me.Página_Um.TabIndex = 0
        Me.Página_Um.Text = "Vendas/Compras"
        Me.Página_Um.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCalcular.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(325, 259)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'Venda_CompraBindingNavigator
        '
        Me.Venda_CompraBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Venda_CompraBindingNavigator.BindingSource = Me.Venda_CompraBindingSource
        Me.Venda_CompraBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Venda_CompraBindingNavigator.DeleteItem = Nothing
        Me.Venda_CompraBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Venda_CompraBindingNavigatorSaveItem})
        Me.Venda_CompraBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.Venda_CompraBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Venda_CompraBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Venda_CompraBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Venda_CompraBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Venda_CompraBindingNavigator.Name = "Venda_CompraBindingNavigator"
        Me.Venda_CompraBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Venda_CompraBindingNavigator.Size = New System.Drawing.Size(596, 25)
        Me.Venda_CompraBindingNavigator.TabIndex = 29
        Me.Venda_CompraBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Venda_CompraBindingNavigatorSaveItem
        '
        Me.Venda_CompraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Venda_CompraBindingNavigatorSaveItem.Image = CType(resources.GetObject("Venda_CompraBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Venda_CompraBindingNavigatorSaveItem.Name = "Venda_CompraBindingNavigatorSaveItem"
        Me.Venda_CompraBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Venda_CompraBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_da_Venda_CompraLabel1
        '
        Me.ID_da_Venda_CompraLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_CompraBindingSource, "ID da Venda/Compra", True))
        Me.ID_da_Venda_CompraLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_da_Venda_CompraLabel1.Location = New System.Drawing.Point(217, 50)
        Me.ID_da_Venda_CompraLabel1.Name = "ID_da_Venda_CompraLabel1"
        Me.ID_da_Venda_CompraLabel1.Size = New System.Drawing.Size(121, 23)
        Me.ID_da_Venda_CompraLabel1.TabIndex = 16
        Me.ID_da_Venda_CompraLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Data_da_Venda_CompraMaskedTextBox
        '
        Me.Data_da_Venda_CompraMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_CompraBindingSource, "Data da Venda/Compra", True))
        Me.Data_da_Venda_CompraMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_da_Venda_CompraMaskedTextBox.Location = New System.Drawing.Point(217, 84)
        Me.Data_da_Venda_CompraMaskedTextBox.Mask = "00/00/0000"
        Me.Data_da_Venda_CompraMaskedTextBox.Name = "Data_da_Venda_CompraMaskedTextBox"
        Me.Data_da_Venda_CompraMaskedTextBox.Size = New System.Drawing.Size(102, 24)
        Me.Data_da_Venda_CompraMaskedTextBox.TabIndex = 0
        Me.Data_da_Venda_CompraMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nome_do_FuncionárioComboBox
        '
        Me.Nome_do_FuncionárioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_CompraBindingSource, "Nome do Funcionário", True))
        Me.Nome_do_FuncionárioComboBox.DataSource = Me.FuncionárioBindingSource
        Me.Nome_do_FuncionárioComboBox.DisplayMember = "Nome do Funcionário"
        Me.Nome_do_FuncionárioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nome_do_FuncionárioComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_do_FuncionárioComboBox.FormattingEnabled = True
        Me.Nome_do_FuncionárioComboBox.Location = New System.Drawing.Point(217, 118)
        Me.Nome_do_FuncionárioComboBox.Name = "Nome_do_FuncionárioComboBox"
        Me.Nome_do_FuncionárioComboBox.Size = New System.Drawing.Size(177, 25)
        Me.Nome_do_FuncionárioComboBox.TabIndex = 1
        Me.Nome_do_FuncionárioComboBox.ValueMember = "Nome do Funcionário"
        '
        'FuncionárioBindingSource
        '
        Me.FuncionárioBindingSource.DataMember = "Funcionário"
        Me.FuncionárioBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'ID_do_FuncionárioComboBox
        '
        Me.ID_do_FuncionárioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_CompraBindingSource, "ID do Funcionário", True))
        Me.ID_do_FuncionárioComboBox.DataSource = Me.FuncionárioBindingSource
        Me.ID_do_FuncionárioComboBox.DisplayMember = "ID do Funcionário"
        Me.ID_do_FuncionárioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_do_FuncionárioComboBox.Enabled = False
        Me.ID_do_FuncionárioComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_FuncionárioComboBox.FormattingEnabled = True
        Me.ID_do_FuncionárioComboBox.Location = New System.Drawing.Point(217, 153)
        Me.ID_do_FuncionárioComboBox.Name = "ID_do_FuncionárioComboBox"
        Me.ID_do_FuncionárioComboBox.Size = New System.Drawing.Size(102, 25)
        Me.ID_do_FuncionárioComboBox.TabIndex = 2
        Me.ID_do_FuncionárioComboBox.ValueMember = "ID do Funcionário"
        '
        'Nome_do_ClienteComboBox
        '
        Me.Nome_do_ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_CompraBindingSource, "Nome do Cliente", True))
        Me.Nome_do_ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.Nome_do_ClienteComboBox.DisplayMember = "Nome do Cliente"
        Me.Nome_do_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nome_do_ClienteComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_do_ClienteComboBox.FormattingEnabled = True
        Me.Nome_do_ClienteComboBox.Location = New System.Drawing.Point(217, 188)
        Me.Nome_do_ClienteComboBox.Name = "Nome_do_ClienteComboBox"
        Me.Nome_do_ClienteComboBox.Size = New System.Drawing.Size(177, 25)
        Me.Nome_do_ClienteComboBox.TabIndex = 3
        Me.Nome_do_ClienteComboBox.ValueMember = "Nome do Cliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'ID_do_ClienteComboBox
        '
        Me.ID_do_ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_CompraBindingSource, "ID do Cliente", True))
        Me.ID_do_ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.ID_do_ClienteComboBox.DisplayMember = "ID do Cliente"
        Me.ID_do_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_do_ClienteComboBox.Enabled = False
        Me.ID_do_ClienteComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_ClienteComboBox.FormattingEnabled = True
        Me.ID_do_ClienteComboBox.Location = New System.Drawing.Point(217, 223)
        Me.ID_do_ClienteComboBox.Name = "ID_do_ClienteComboBox"
        Me.ID_do_ClienteComboBox.Size = New System.Drawing.Size(102, 25)
        Me.ID_do_ClienteComboBox.TabIndex = 4
        Me.ID_do_ClienteComboBox.ValueMember = "ID do Cliente"
        '
        'Valor_TotalTextBox
        '
        Me.Valor_TotalTextBox.BackColor = System.Drawing.Color.White
        Me.Valor_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Venda_CompraBindingSource, "Valor Total", True))
        Me.Valor_TotalTextBox.Enabled = False
        Me.Valor_TotalTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor_TotalTextBox.Location = New System.Drawing.Point(217, 258)
        Me.Valor_TotalTextBox.Name = "Valor_TotalTextBox"
        Me.Valor_TotalTextBox.Size = New System.Drawing.Size(102, 24)
        Me.Valor_TotalTextBox.TabIndex = 5
        Me.Valor_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Página_Dois
        '
        Me.Página_Dois.AutoScroll = True
        Me.Página_Dois.Controls.Add(Me.btnLimpar)
        Me.Página_Dois.Controls.Add(Me.btnAtualizar)
        Me.Página_Dois.Controls.Add(Me.btnCarregar)
        Me.Página_Dois.Controls.Add(Me.btnRemover)
        Me.Página_Dois.Controls.Add(Me.btnAdicionar)
        Me.Página_Dois.Controls.Add(ID_da_Venda_CompraLabel2)
        Me.Página_Dois.Controls.Add(Me.ID_da_Venda_CompraLabel3)
        Me.Página_Dois.Controls.Add(Sub_TotalLabel)
        Me.Página_Dois.Controls.Add(Me.Sub_TotalTextBox)
        Me.Página_Dois.Controls.Add(QuantidadeLabel)
        Me.Página_Dois.Controls.Add(Me.QuantidadeNumericUpDown)
        Me.Página_Dois.Controls.Add(Valor_UnitárioLabel)
        Me.Página_Dois.Controls.Add(Me.Valor_UnitárioTextBox)
        Me.Página_Dois.Controls.Add(ID_do_ProdutoLabel)
        Me.Página_Dois.Controls.Add(Me.ID_do_ProdutoComboBox)
        Me.Página_Dois.Controls.Add(DescriçãoLabel)
        Me.Página_Dois.Controls.Add(Me.DescriçãoComboBox)
        Me.Página_Dois.Controls.Add(Me.Tabela_Itens)
        Me.Página_Dois.Location = New System.Drawing.Point(4, 22)
        Me.Página_Dois.Name = "Página_Dois"
        Me.Página_Dois.Padding = New System.Windows.Forms.Padding(3)
        Me.Página_Dois.Size = New System.Drawing.Size(602, 348)
        Me.Página_Dois.TabIndex = 1
        Me.Página_Dois.Text = "Itens da Venda/Compra"
        Me.Página_Dois.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(24, 303)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 29)
        Me.btnLimpar.TabIndex = 48
        Me.btnLimpar.TabStop = False
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtualizar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.Location = New System.Drawing.Point(24, 205)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 29)
        Me.btnAtualizar.TabIndex = 47
        Me.btnAtualizar.TabStop = False
        Me.btnAtualizar.Text = "&Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'btnCarregar
        '
        Me.btnCarregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCarregar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregar.Location = New System.Drawing.Point(24, 268)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(75, 29)
        Me.btnCarregar.TabIndex = 46
        Me.btnCarregar.TabStop = False
        Me.btnCarregar.Text = "&Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = False
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemover.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.Location = New System.Drawing.Point(24, 170)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 29)
        Me.btnRemover.TabIndex = 45
        Me.btnRemover.TabStop = False
        Me.btnRemover.Text = "&Remover"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Location = New System.Drawing.Point(24, 135)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 29)
        Me.btnAdicionar.TabIndex = 44
        Me.btnAdicionar.TabStop = False
        Me.btnAdicionar.Text = "&Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = False
        '
        'ID_da_Venda_CompraLabel3
        '
        Me.ID_da_Venda_CompraLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Itens_da_Venda_CompraBindingSource, "ID da Venda/Compra", True))
        Me.ID_da_Venda_CompraLabel3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_da_Venda_CompraLabel3.Location = New System.Drawing.Point(187, 20)
        Me.ID_da_Venda_CompraLabel3.Name = "ID_da_Venda_CompraLabel3"
        Me.ID_da_Venda_CompraLabel3.Size = New System.Drawing.Size(142, 23)
        Me.ID_da_Venda_CompraLabel3.TabIndex = 43
        Me.ID_da_Venda_CompraLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Itens_da_Venda_CompraBindingSource
        '
        Me.Itens_da_Venda_CompraBindingSource.DataMember = "Itens da Venda/Compra"
        Me.Itens_da_Venda_CompraBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'Sub_TotalTextBox
        '
        Me.Sub_TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Itens_da_Venda_CompraBindingSource, "Sub Total", True))
        Me.Sub_TotalTextBox.Enabled = False
        Me.Sub_TotalTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_TotalTextBox.Location = New System.Drawing.Point(477, 92)
        Me.Sub_TotalTextBox.Name = "Sub_TotalTextBox"
        Me.Sub_TotalTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Sub_TotalTextBox.TabIndex = 4
        Me.Sub_TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QuantidadeNumericUpDown
        '
        Me.QuantidadeNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Itens_da_Venda_CompraBindingSource, "Quantidade", True))
        Me.QuantidadeNumericUpDown.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantidadeNumericUpDown.Location = New System.Drawing.Point(477, 53)
        Me.QuantidadeNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantidadeNumericUpDown.Name = "QuantidadeNumericUpDown"
        Me.QuantidadeNumericUpDown.Size = New System.Drawing.Size(67, 24)
        Me.QuantidadeNumericUpDown.TabIndex = 3
        Me.QuantidadeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.QuantidadeNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Valor_UnitárioTextBox
        '
        Me.Valor_UnitárioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Itens_da_Venda_CompraBindingSource, "Valor Unitário", True))
        Me.Valor_UnitárioTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor_UnitárioTextBox.Location = New System.Drawing.Point(477, 17)
        Me.Valor_UnitárioTextBox.Name = "Valor_UnitárioTextBox"
        Me.Valor_UnitárioTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Valor_UnitárioTextBox.TabIndex = 2
        Me.Valor_UnitárioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ID_do_ProdutoComboBox
        '
        Me.ID_do_ProdutoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Itens_da_Venda_CompraBindingSource, "ID do Produto", True))
        Me.ID_do_ProdutoComboBox.DataSource = Me.ProdutosBindingSource
        Me.ID_do_ProdutoComboBox.DisplayMember = "ID do Produto"
        Me.ID_do_ProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_do_ProdutoComboBox.Enabled = False
        Me.ID_do_ProdutoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_ProdutoComboBox.FormattingEnabled = True
        Me.ID_do_ProdutoComboBox.Location = New System.Drawing.Point(190, 92)
        Me.ID_do_ProdutoComboBox.Name = "ID_do_ProdutoComboBox"
        Me.ID_do_ProdutoComboBox.Size = New System.Drawing.Size(98, 25)
        Me.ID_do_ProdutoComboBox.TabIndex = 1
        Me.ID_do_ProdutoComboBox.ValueMember = "ID do Produto"
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'DescriçãoComboBox
        '
        Me.DescriçãoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Itens_da_Venda_CompraBindingSource, "Descrição", True))
        Me.DescriçãoComboBox.DataSource = Me.ProdutosBindingSource
        Me.DescriçãoComboBox.DisplayMember = "Descrição"
        Me.DescriçãoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DescriçãoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriçãoComboBox.FormattingEnabled = True
        Me.DescriçãoComboBox.Location = New System.Drawing.Point(190, 53)
        Me.DescriçãoComboBox.Name = "DescriçãoComboBox"
        Me.DescriçãoComboBox.Size = New System.Drawing.Size(139, 25)
        Me.DescriçãoComboBox.TabIndex = 0
        Me.DescriçãoComboBox.ValueMember = "Descrição"
        '
        'Tabela_Itens
        '
        Me.Tabela_Itens.AllowUserToAddRows = False
        Me.Tabela_Itens.AllowUserToDeleteRows = False
        Me.Tabela_Itens.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Tabela_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabela_Itens.Location = New System.Drawing.Point(117, 135)
        Me.Tabela_Itens.Name = "Tabela_Itens"
        Me.Tabela_Itens.ReadOnly = True
        Me.Tabela_Itens.Size = New System.Drawing.Size(460, 197)
        Me.Tabela_Itens.TabIndex = 37
        Me.Tabela_Itens.TabStop = False
        '
        'FuncionárioTableAdapter
        '
        Me.FuncionárioTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'frmVendaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(709, 396)
        Me.Controls.Add(Me.Controles_Páginas)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Vendas/Compras"
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Controles_Páginas.ResumeLayout(False)
        Me.Página_Um.ResumeLayout(False)
        Me.Página_Um.PerformLayout()
        CType(Me.Venda_CompraBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Venda_CompraBindingNavigator.ResumeLayout(False)
        Me.Venda_CompraBindingNavigator.PerformLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Página_Dois.ResumeLayout(False)
        Me.Página_Dois.PerformLayout()
        CType(Me.Itens_da_Venda_CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantidadeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabela_Itens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents Venda_CompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Venda_CompraTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.Venda_CompraTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Controles_Páginas As System.Windows.Forms.TabControl
    Friend WithEvents Página_Um As System.Windows.Forms.TabPage
    Friend WithEvents Venda_CompraBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Venda_CompraBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_da_Venda_CompraLabel1 As System.Windows.Forms.Label
    Friend WithEvents Data_da_Venda_CompraMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Nome_do_FuncionárioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_do_FuncionárioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Nome_do_ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_do_ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Página_Dois As System.Windows.Forms.TabPage
    Friend WithEvents Itens_da_Venda_CompraTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.Itens_da_Venda_CompraTableAdapter
    Friend WithEvents Tabela_Itens As System.Windows.Forms.DataGridView
    Friend WithEvents Itens_da_Venda_CompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sub_TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantidadeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Valor_UnitárioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_do_ProdutoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescriçãoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents ProdutosTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents ProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_da_Venda_CompraLabel3 As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Valor_TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FuncionárioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionárioTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.FuncionárioTableAdapter
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
End Class
