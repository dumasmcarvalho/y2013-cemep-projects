<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagamento
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
        Dim ID_do_PagamentoLabel As System.Windows.Forms.Label
        Dim Data_do_PagamentoLabel As System.Windows.Forms.Label
        Dim Forma_de_PagamentoLabel As System.Windows.Forms.Label
        Dim Nome_do_ClienteLabel As System.Windows.Forms.Label
        Dim ID_do_ClienteLabel As System.Windows.Forms.Label
        Dim ExclusivoLabel As System.Windows.Forms.Label
        Dim Valor_TotalLabel As System.Windows.Forms.Label
        Dim DescontosLabel As System.Windows.Forms.Label
        Dim Valor_FinalLabel As System.Windows.Forms.Label
        Dim Data_da_CompraLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagamento))
        Me.Banco_OtakuFestDataSet = New OtakuFest.Banco_OtakuFestDataSet
        Me.Pagamento_do_ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pagamento_do_ClienteTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.Pagamento_do_ClienteTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        Me.ClienteTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
        Me.Venda_CompraTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.Venda_CompraTableAdapter
        Me.Pagamento_do_ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Pagamento_do_ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ID_do_PagamentoLabel1 = New System.Windows.Forms.Label
        Me.Data_do_PagamentoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Forma_de_PagamentoComboBox = New System.Windows.Forms.ComboBox
        Me.Nome_do_ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_do_ClienteComboBox = New System.Windows.Forms.ComboBox
        Me.ExclusivoCheckBox = New System.Windows.Forms.CheckBox
        Me.Valor_TotalComboBox = New System.Windows.Forms.ComboBox
        Me.VendaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescontosTextBox = New System.Windows.Forms.TextBox
        Me.Valor_FinalTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Data_da_CompraComboBox = New System.Windows.Forms.ComboBox
        Me.Mensagem = New System.Windows.Forms.ToolTip(Me.components)
        ID_do_PagamentoLabel = New System.Windows.Forms.Label
        Data_do_PagamentoLabel = New System.Windows.Forms.Label
        Forma_de_PagamentoLabel = New System.Windows.Forms.Label
        Nome_do_ClienteLabel = New System.Windows.Forms.Label
        ID_do_ClienteLabel = New System.Windows.Forms.Label
        ExclusivoLabel = New System.Windows.Forms.Label
        Valor_TotalLabel = New System.Windows.Forms.Label
        DescontosLabel = New System.Windows.Forms.Label
        Valor_FinalLabel = New System.Windows.Forms.Label
        Data_da_CompraLabel = New System.Windows.Forms.Label
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pagamento_do_ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pagamento_do_ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pagamento_do_ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_do_PagamentoLabel
        '
        ID_do_PagamentoLabel.AutoSize = True
        ID_do_PagamentoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_PagamentoLabel.Location = New System.Drawing.Point(95, 44)
        ID_do_PagamentoLabel.Name = "ID_do_PagamentoLabel"
        ID_do_PagamentoLabel.Size = New System.Drawing.Size(138, 14)
        ID_do_PagamentoLabel.TabIndex = 1
        ID_do_PagamentoLabel.Text = "ID do Pagamento:"
        '
        'Data_do_PagamentoLabel
        '
        Data_do_PagamentoLabel.AutoSize = True
        Data_do_PagamentoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_do_PagamentoLabel.Location = New System.Drawing.Point(95, 81)
        Data_do_PagamentoLabel.Name = "Data_do_PagamentoLabel"
        Data_do_PagamentoLabel.Size = New System.Drawing.Size(156, 14)
        Data_do_PagamentoLabel.TabIndex = 3
        Data_do_PagamentoLabel.Text = "Data do Pagamento:"
        '
        'Forma_de_PagamentoLabel
        '
        Forma_de_PagamentoLabel.AutoSize = True
        Forma_de_PagamentoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Forma_de_PagamentoLabel.Location = New System.Drawing.Point(95, 121)
        Forma_de_PagamentoLabel.Name = "Forma_de_PagamentoLabel"
        Forma_de_PagamentoLabel.Size = New System.Drawing.Size(165, 14)
        Forma_de_PagamentoLabel.TabIndex = 5
        Forma_de_PagamentoLabel.Text = "Forma de Pagamento:"
        '
        'Nome_do_ClienteLabel
        '
        Nome_do_ClienteLabel.AutoSize = True
        Nome_do_ClienteLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_do_ClienteLabel.Location = New System.Drawing.Point(94, 203)
        Nome_do_ClienteLabel.Name = "Nome_do_ClienteLabel"
        Nome_do_ClienteLabel.Size = New System.Drawing.Size(131, 14)
        Nome_do_ClienteLabel.TabIndex = 9
        Nome_do_ClienteLabel.Text = "Nome do Cliente:"
        '
        'ID_do_ClienteLabel
        '
        ID_do_ClienteLabel.AutoSize = True
        ID_do_ClienteLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_ClienteLabel.Location = New System.Drawing.Point(94, 244)
        ID_do_ClienteLabel.Name = "ID_do_ClienteLabel"
        ID_do_ClienteLabel.Size = New System.Drawing.Size(109, 14)
        ID_do_ClienteLabel.TabIndex = 11
        ID_do_ClienteLabel.Text = "ID do Cliente:"
        '
        'ExclusivoLabel
        '
        ExclusivoLabel.AutoSize = True
        ExclusivoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExclusivoLabel.Location = New System.Drawing.Point(95, 285)
        ExclusivoLabel.Name = "ExclusivoLabel"
        ExclusivoLabel.Size = New System.Drawing.Size(84, 14)
        ExclusivoLabel.TabIndex = 13
        ExclusivoLabel.Text = "Exclusivo:"
        '
        'Valor_TotalLabel
        '
        Valor_TotalLabel.AutoSize = True
        Valor_TotalLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor_TotalLabel.Location = New System.Drawing.Point(95, 325)
        Valor_TotalLabel.Name = "Valor_TotalLabel"
        Valor_TotalLabel.Size = New System.Drawing.Size(101, 14)
        Valor_TotalLabel.TabIndex = 15
        Valor_TotalLabel.Text = "Valor Total:"
        '
        'DescontosLabel
        '
        DescontosLabel.AutoSize = True
        DescontosLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescontosLabel.Location = New System.Drawing.Point(95, 366)
        DescontosLabel.Name = "DescontosLabel"
        DescontosLabel.Size = New System.Drawing.Size(95, 14)
        DescontosLabel.TabIndex = 17
        DescontosLabel.Text = "Descontos:"
        '
        'Valor_FinalLabel
        '
        Valor_FinalLabel.AutoSize = True
        Valor_FinalLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor_FinalLabel.Location = New System.Drawing.Point(94, 406)
        Valor_FinalLabel.Name = "Valor_FinalLabel"
        Valor_FinalLabel.Size = New System.Drawing.Size(96, 14)
        Valor_FinalLabel.TabIndex = 19
        Valor_FinalLabel.Text = "Valor Final:"
        '
        'Data_da_CompraLabel
        '
        Data_da_CompraLabel.AutoSize = True
        Data_da_CompraLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_da_CompraLabel.Location = New System.Drawing.Point(94, 163)
        Data_da_CompraLabel.Name = "Data_da_CompraLabel"
        Data_da_CompraLabel.Size = New System.Drawing.Size(128, 14)
        Data_da_CompraLabel.TabIndex = 38
        Data_da_CompraLabel.Text = "Data da Compra:"
        '
        'Banco_OtakuFestDataSet
        '
        Me.Banco_OtakuFestDataSet.DataSetName = "Banco_OtakuFestDataSet"
        Me.Banco_OtakuFestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pagamento_do_ClienteBindingSource
        '
        Me.Pagamento_do_ClienteBindingSource.DataMember = "Pagamento do Cliente"
        Me.Pagamento_do_ClienteBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'Pagamento_do_ClienteTableAdapter
        '
        Me.Pagamento_do_ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Itens_da_Venda_CompraTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Pagamento_do_ClienteTableAdapter = Me.Pagamento_do_ClienteTableAdapter
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Me.Venda_CompraTableAdapter
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Venda_CompraTableAdapter
        '
        Me.Venda_CompraTableAdapter.ClearBeforeFill = True
        '
        'Pagamento_do_ClienteBindingNavigator
        '
        Me.Pagamento_do_ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Pagamento_do_ClienteBindingNavigator.BindingSource = Me.Pagamento_do_ClienteBindingSource
        Me.Pagamento_do_ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Pagamento_do_ClienteBindingNavigator.DeleteItem = Nothing
        Me.Pagamento_do_ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Pagamento_do_ClienteBindingNavigatorSaveItem})
        Me.Pagamento_do_ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Pagamento_do_ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Pagamento_do_ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Pagamento_do_ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Pagamento_do_ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Pagamento_do_ClienteBindingNavigator.Name = "Pagamento_do_ClienteBindingNavigator"
        Me.Pagamento_do_ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Pagamento_do_ClienteBindingNavigator.Size = New System.Drawing.Size(456, 25)
        Me.Pagamento_do_ClienteBindingNavigator.TabIndex = 0
        Me.Pagamento_do_ClienteBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'Pagamento_do_ClienteBindingNavigatorSaveItem
        '
        Me.Pagamento_do_ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Pagamento_do_ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("Pagamento_do_ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Pagamento_do_ClienteBindingNavigatorSaveItem.Name = "Pagamento_do_ClienteBindingNavigatorSaveItem"
        Me.Pagamento_do_ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Pagamento_do_ClienteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_do_PagamentoLabel1
        '
        Me.ID_do_PagamentoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "ID do Pagamento", True))
        Me.ID_do_PagamentoLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_PagamentoLabel1.Location = New System.Drawing.Point(277, 43)
        Me.ID_do_PagamentoLabel1.Name = "ID_do_PagamentoLabel1"
        Me.ID_do_PagamentoLabel1.Size = New System.Drawing.Size(163, 23)
        Me.ID_do_PagamentoLabel1.TabIndex = 2
        Me.ID_do_PagamentoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Data_do_PagamentoMaskedTextBox
        '
        Me.Data_do_PagamentoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "Data do Pagamento", True))
        Me.Data_do_PagamentoMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_do_PagamentoMaskedTextBox.Location = New System.Drawing.Point(277, 77)
        Me.Data_do_PagamentoMaskedTextBox.Mask = "00/00/0000"
        Me.Data_do_PagamentoMaskedTextBox.Name = "Data_do_PagamentoMaskedTextBox"
        Me.Data_do_PagamentoMaskedTextBox.Size = New System.Drawing.Size(121, 24)
        Me.Data_do_PagamentoMaskedTextBox.TabIndex = 0
        Me.Data_do_PagamentoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Forma_de_PagamentoComboBox
        '
        Me.Forma_de_PagamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "Forma de Pagamento", True))
        Me.Forma_de_PagamentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Forma_de_PagamentoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forma_de_PagamentoComboBox.FormattingEnabled = True
        Me.Forma_de_PagamentoComboBox.Items.AddRange(New Object() {"Dinheiro", "Cartão"})
        Me.Forma_de_PagamentoComboBox.Location = New System.Drawing.Point(277, 117)
        Me.Forma_de_PagamentoComboBox.Name = "Forma_de_PagamentoComboBox"
        Me.Forma_de_PagamentoComboBox.Size = New System.Drawing.Size(121, 25)
        Me.Forma_de_PagamentoComboBox.TabIndex = 1
        '
        'Nome_do_ClienteComboBox
        '
        Me.Nome_do_ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "Nome do Cliente", True))
        Me.Nome_do_ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.Nome_do_ClienteComboBox.DisplayMember = "Nome do Cliente"
        Me.Nome_do_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nome_do_ClienteComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_do_ClienteComboBox.FormattingEnabled = True
        Me.Nome_do_ClienteComboBox.Location = New System.Drawing.Point(277, 199)
        Me.Nome_do_ClienteComboBox.Name = "Nome_do_ClienteComboBox"
        Me.Nome_do_ClienteComboBox.Size = New System.Drawing.Size(163, 25)
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
        Me.ID_do_ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "ID do Cliente", True))
        Me.ID_do_ClienteComboBox.DataSource = Me.ClienteBindingSource
        Me.ID_do_ClienteComboBox.DisplayMember = "ID do Cliente"
        Me.ID_do_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_do_ClienteComboBox.Enabled = False
        Me.ID_do_ClienteComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_ClienteComboBox.FormattingEnabled = True
        Me.ID_do_ClienteComboBox.Location = New System.Drawing.Point(277, 240)
        Me.ID_do_ClienteComboBox.Name = "ID_do_ClienteComboBox"
        Me.ID_do_ClienteComboBox.Size = New System.Drawing.Size(121, 25)
        Me.ID_do_ClienteComboBox.TabIndex = 4
        Me.ID_do_ClienteComboBox.ValueMember = "ID do Cliente"
        '
        'ExclusivoCheckBox
        '
        Me.ExclusivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pagamento_do_ClienteBindingSource, "Exclusivo", True))
        Me.ExclusivoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExclusivoCheckBox.Location = New System.Drawing.Point(277, 281)
        Me.ExclusivoCheckBox.Name = "ExclusivoCheckBox"
        Me.ExclusivoCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.ExclusivoCheckBox.TabIndex = 5
        Me.ExclusivoCheckBox.Text = "Sim/Não"
        Me.Mensagem.SetToolTip(Me.ExclusivoCheckBox, "Clientes exlusivos ganham 10% de desconto")
        Me.ExclusivoCheckBox.UseVisualStyleBackColor = True
        '
        'Valor_TotalComboBox
        '
        Me.Valor_TotalComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "Valor Total", True))
        Me.Valor_TotalComboBox.DataSource = Me.VendaCompraBindingSource
        Me.Valor_TotalComboBox.DisplayMember = "Valor Total"
        Me.Valor_TotalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Valor_TotalComboBox.Enabled = False
        Me.Valor_TotalComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor_TotalComboBox.FormatString = "C2"
        Me.Valor_TotalComboBox.FormattingEnabled = True
        Me.Valor_TotalComboBox.Location = New System.Drawing.Point(277, 321)
        Me.Valor_TotalComboBox.Name = "Valor_TotalComboBox"
        Me.Valor_TotalComboBox.Size = New System.Drawing.Size(121, 25)
        Me.Valor_TotalComboBox.TabIndex = 6
        Me.Valor_TotalComboBox.ValueMember = "Valor Total"
        '
        'VendaCompraBindingSource
        '
        Me.VendaCompraBindingSource.DataMember = "Venda/Compra"
        Me.VendaCompraBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'DescontosTextBox
        '
        Me.DescontosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "Descontos", True))
        Me.DescontosTextBox.Enabled = False
        Me.DescontosTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescontosTextBox.Location = New System.Drawing.Point(277, 362)
        Me.DescontosTextBox.Name = "DescontosTextBox"
        Me.DescontosTextBox.Size = New System.Drawing.Size(121, 24)
        Me.DescontosTextBox.TabIndex = 7
        Me.DescontosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Valor_FinalTextBox
        '
        Me.Valor_FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "Valor Final", True))
        Me.Valor_FinalTextBox.Enabled = False
        Me.Valor_FinalTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valor_FinalTextBox.Location = New System.Drawing.Point(277, 402)
        Me.Valor_FinalTextBox.Name = "Valor_FinalTextBox"
        Me.Valor_FinalTextBox.Size = New System.Drawing.Size(121, 24)
        Me.Valor_FinalTextBox.TabIndex = 8
        Me.Valor_FinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 412)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Data_da_CompraComboBox
        '
        Me.Data_da_CompraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pagamento_do_ClienteBindingSource, "Data da Compra", True))
        Me.Data_da_CompraComboBox.DataSource = Me.VendaCompraBindingSource
        Me.Data_da_CompraComboBox.DisplayMember = "Data da Venda/Compra"
        Me.Data_da_CompraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Data_da_CompraComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_da_CompraComboBox.FormattingEnabled = True
        Me.Data_da_CompraComboBox.Location = New System.Drawing.Point(277, 159)
        Me.Data_da_CompraComboBox.Name = "Data_da_CompraComboBox"
        Me.Data_da_CompraComboBox.Size = New System.Drawing.Size(121, 25)
        Me.Data_da_CompraComboBox.TabIndex = 2
        Me.Data_da_CompraComboBox.ValueMember = "Data da Venda/Compra"
        '
        'Mensagem
        '
        Me.Mensagem.ShowAlways = True
        Me.Mensagem.ToolTipTitle = "Mensagem"
        '
        'frmPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(456, 442)
        Me.Controls.Add(Data_da_CompraLabel)
        Me.Controls.Add(Me.Data_da_CompraComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(ID_do_PagamentoLabel)
        Me.Controls.Add(Me.ID_do_PagamentoLabel1)
        Me.Controls.Add(Data_do_PagamentoLabel)
        Me.Controls.Add(Me.Data_do_PagamentoMaskedTextBox)
        Me.Controls.Add(Forma_de_PagamentoLabel)
        Me.Controls.Add(Me.Forma_de_PagamentoComboBox)
        Me.Controls.Add(Nome_do_ClienteLabel)
        Me.Controls.Add(Me.Nome_do_ClienteComboBox)
        Me.Controls.Add(ID_do_ClienteLabel)
        Me.Controls.Add(Me.ID_do_ClienteComboBox)
        Me.Controls.Add(ExclusivoLabel)
        Me.Controls.Add(Me.ExclusivoCheckBox)
        Me.Controls.Add(Valor_TotalLabel)
        Me.Controls.Add(Me.Valor_TotalComboBox)
        Me.Controls.Add(DescontosLabel)
        Me.Controls.Add(Me.DescontosTextBox)
        Me.Controls.Add(Valor_FinalLabel)
        Me.Controls.Add(Me.Valor_FinalTextBox)
        Me.Controls.Add(Me.Pagamento_do_ClienteBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamento do Cliente"
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pagamento_do_ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pagamento_do_ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pagamento_do_ClienteBindingNavigator.ResumeLayout(False)
        Me.Pagamento_do_ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents Pagamento_do_ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pagamento_do_ClienteTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.Pagamento_do_ClienteTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Pagamento_do_ClienteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Pagamento_do_ClienteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_do_PagamentoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Data_do_PagamentoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Forma_de_PagamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Nome_do_ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_do_ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExclusivoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Valor_TotalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescontosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Valor_FinalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Data_da_CompraComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Venda_CompraTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.Venda_CompraTableAdapter
    Friend WithEvents VendaCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mensagem As System.Windows.Forms.ToolTip
End Class
