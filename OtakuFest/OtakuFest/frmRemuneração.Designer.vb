<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemuneração
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
        Dim ID_da_RemuneraçãoLabel As System.Windows.Forms.Label
        Dim Data_da_RemuneraçãoLabel As System.Windows.Forms.Label
        Dim Nome_do_FuncionárioLabel As System.Windows.Forms.Label
        Dim ID_do_FuncionárioLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim Salário_BrutoLabel As System.Windows.Forms.Label
        Dim DescontosLabel As System.Windows.Forms.Label
        Dim Vendas_RealizadasLabel As System.Windows.Forms.Label
        Dim ComissãoLabel As System.Windows.Forms.Label
        Dim Salário_LiquidoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemuneração))
        Me.Banco_OtakuFestDataSet = New OtakuFest.Banco_OtakuFestDataSet
        Me.Remuneração_do_FuncionárioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Remuneração_do_FuncionárioTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.Remuneração_do_FuncionárioTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        Me.FuncionárioTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.FuncionárioTableAdapter
        Me.Remuneração_do_FuncionárioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Remuneração_do_FuncionárioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ID_da_RemuneraçãoLabel1 = New System.Windows.Forms.Label
        Me.Nome_do_FuncionárioComboBox = New System.Windows.Forms.ComboBox
        Me.FuncionárioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_do_FuncionárioComboBox = New System.Windows.Forms.ComboBox
        Me.CargoComboBox = New System.Windows.Forms.ComboBox
        Me.Salário_BrutoTextBox = New System.Windows.Forms.TextBox
        Me.DescontosTextBox = New System.Windows.Forms.TextBox
        Me.Vendas_RealizadasTextBox = New System.Windows.Forms.TextBox
        Me.ComissãoTextBox = New System.Windows.Forms.TextBox
        Me.Salário_LiquidoTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Data_da_RemuneraçãoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Mensagem = New System.Windows.Forms.ToolTip(Me.components)
        ID_da_RemuneraçãoLabel = New System.Windows.Forms.Label
        Data_da_RemuneraçãoLabel = New System.Windows.Forms.Label
        Nome_do_FuncionárioLabel = New System.Windows.Forms.Label
        ID_do_FuncionárioLabel = New System.Windows.Forms.Label
        CargoLabel = New System.Windows.Forms.Label
        Salário_BrutoLabel = New System.Windows.Forms.Label
        DescontosLabel = New System.Windows.Forms.Label
        Vendas_RealizadasLabel = New System.Windows.Forms.Label
        ComissãoLabel = New System.Windows.Forms.Label
        Salário_LiquidoLabel = New System.Windows.Forms.Label
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remuneração_do_FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remuneração_do_FuncionárioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Remuneração_do_FuncionárioBindingNavigator.SuspendLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_da_RemuneraçãoLabel
        '
        ID_da_RemuneraçãoLabel.AutoSize = True
        ID_da_RemuneraçãoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_da_RemuneraçãoLabel.Location = New System.Drawing.Point(98, 48)
        ID_da_RemuneraçãoLabel.Name = "ID_da_RemuneraçãoLabel"
        ID_da_RemuneraçãoLabel.Size = New System.Drawing.Size(150, 14)
        ID_da_RemuneraçãoLabel.TabIndex = 1
        ID_da_RemuneraçãoLabel.Text = "ID da Remuneração:"
        '
        'Data_da_RemuneraçãoLabel
        '
        Data_da_RemuneraçãoLabel.AutoSize = True
        Data_da_RemuneraçãoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_da_RemuneraçãoLabel.Location = New System.Drawing.Point(98, 86)
        Data_da_RemuneraçãoLabel.Name = "Data_da_RemuneraçãoLabel"
        Data_da_RemuneraçãoLabel.Size = New System.Drawing.Size(168, 14)
        Data_da_RemuneraçãoLabel.TabIndex = 3
        Data_da_RemuneraçãoLabel.Text = "Data da Remuneração:"
        '
        'Nome_do_FuncionárioLabel
        '
        Nome_do_FuncionárioLabel.AutoSize = True
        Nome_do_FuncionárioLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_do_FuncionárioLabel.Location = New System.Drawing.Point(98, 119)
        Nome_do_FuncionárioLabel.Name = "Nome_do_FuncionárioLabel"
        Nome_do_FuncionárioLabel.Size = New System.Drawing.Size(168, 14)
        Nome_do_FuncionárioLabel.TabIndex = 5
        Nome_do_FuncionárioLabel.Text = "Nome do Funcionário:"
        '
        'ID_do_FuncionárioLabel
        '
        ID_do_FuncionárioLabel.AutoSize = True
        ID_do_FuncionárioLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_FuncionárioLabel.Location = New System.Drawing.Point(98, 154)
        ID_do_FuncionárioLabel.Name = "ID_do_FuncionárioLabel"
        ID_do_FuncionárioLabel.Size = New System.Drawing.Size(146, 14)
        ID_do_FuncionárioLabel.TabIndex = 7
        ID_do_FuncionárioLabel.Text = "ID do Funcionário:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoLabel.Location = New System.Drawing.Point(98, 189)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(58, 14)
        CargoLabel.TabIndex = 9
        CargoLabel.Text = "Cargo:"
        '
        'Salário_BrutoLabel
        '
        Salário_BrutoLabel.AutoSize = True
        Salário_BrutoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Salário_BrutoLabel.Location = New System.Drawing.Point(98, 224)
        Salário_BrutoLabel.Name = "Salário_BrutoLabel"
        Salário_BrutoLabel.Size = New System.Drawing.Size(118, 14)
        Salário_BrutoLabel.TabIndex = 11
        Salário_BrutoLabel.Text = "Salário Bruto:"
        '
        'DescontosLabel
        '
        DescontosLabel.AutoSize = True
        DescontosLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescontosLabel.Location = New System.Drawing.Point(98, 258)
        DescontosLabel.Name = "DescontosLabel"
        DescontosLabel.Size = New System.Drawing.Size(95, 14)
        DescontosLabel.TabIndex = 13
        DescontosLabel.Text = "Descontos:"
        '
        'Vendas_RealizadasLabel
        '
        Vendas_RealizadasLabel.AutoSize = True
        Vendas_RealizadasLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Vendas_RealizadasLabel.Location = New System.Drawing.Point(98, 292)
        Vendas_RealizadasLabel.Name = "Vendas_RealizadasLabel"
        Vendas_RealizadasLabel.Size = New System.Drawing.Size(149, 14)
        Vendas_RealizadasLabel.TabIndex = 15
        Vendas_RealizadasLabel.Text = "Vendas Realizadas:"
        '
        'ComissãoLabel
        '
        ComissãoLabel.AutoSize = True
        ComissãoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComissãoLabel.Location = New System.Drawing.Point(98, 326)
        ComissãoLabel.Name = "ComissãoLabel"
        ComissãoLabel.Size = New System.Drawing.Size(84, 14)
        ComissãoLabel.TabIndex = 17
        ComissãoLabel.Text = "Comissão:"
        '
        'Salário_LiquidoLabel
        '
        Salário_LiquidoLabel.AutoSize = True
        Salário_LiquidoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Salário_LiquidoLabel.Location = New System.Drawing.Point(98, 360)
        Salário_LiquidoLabel.Name = "Salário_LiquidoLabel"
        Salário_LiquidoLabel.Size = New System.Drawing.Size(128, 14)
        Salário_LiquidoLabel.TabIndex = 19
        Salário_LiquidoLabel.Text = "Salário Liquido:"
        '
        'Banco_OtakuFestDataSet
        '
        Me.Banco_OtakuFestDataSet.DataSetName = "Banco_OtakuFestDataSet"
        Me.Banco_OtakuFestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Remuneração_do_FuncionárioBindingSource
        '
        Me.Remuneração_do_FuncionárioBindingSource.DataMember = "Remuneração do Funcionário"
        Me.Remuneração_do_FuncionárioBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'Remuneração_do_FuncionárioTableAdapter
        '
        Me.Remuneração_do_FuncionárioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Me.FuncionárioTableAdapter
        Me.TableAdapterManager.Itens_da_Venda_CompraTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Pagamento_do_ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Me.Remuneração_do_FuncionárioTableAdapter
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Nothing
        '
        'FuncionárioTableAdapter
        '
        Me.FuncionárioTableAdapter.ClearBeforeFill = True
        '
        'Remuneração_do_FuncionárioBindingNavigator
        '
        Me.Remuneração_do_FuncionárioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Remuneração_do_FuncionárioBindingNavigator.BindingSource = Me.Remuneração_do_FuncionárioBindingSource
        Me.Remuneração_do_FuncionárioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Remuneração_do_FuncionárioBindingNavigator.DeleteItem = Nothing
        Me.Remuneração_do_FuncionárioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Remuneração_do_FuncionárioBindingNavigatorSaveItem})
        Me.Remuneração_do_FuncionárioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Remuneração_do_FuncionárioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Remuneração_do_FuncionárioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Remuneração_do_FuncionárioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Remuneração_do_FuncionárioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Remuneração_do_FuncionárioBindingNavigator.Name = "Remuneração_do_FuncionárioBindingNavigator"
        Me.Remuneração_do_FuncionárioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Remuneração_do_FuncionárioBindingNavigator.Size = New System.Drawing.Size(520, 25)
        Me.Remuneração_do_FuncionárioBindingNavigator.TabIndex = 0
        Me.Remuneração_do_FuncionárioBindingNavigator.Text = "BindingNavigator1"
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
        'Remuneração_do_FuncionárioBindingNavigatorSaveItem
        '
        Me.Remuneração_do_FuncionárioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Remuneração_do_FuncionárioBindingNavigatorSaveItem.Image = CType(resources.GetObject("Remuneração_do_FuncionárioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Remuneração_do_FuncionárioBindingNavigatorSaveItem.Name = "Remuneração_do_FuncionárioBindingNavigatorSaveItem"
        Me.Remuneração_do_FuncionárioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Remuneração_do_FuncionárioBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_da_RemuneraçãoLabel1
        '
        Me.ID_da_RemuneraçãoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "ID da Remuneração", True))
        Me.ID_da_RemuneraçãoLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_da_RemuneraçãoLabel1.Location = New System.Drawing.Point(305, 47)
        Me.ID_da_RemuneraçãoLabel1.Name = "ID_da_RemuneraçãoLabel1"
        Me.ID_da_RemuneraçãoLabel1.Size = New System.Drawing.Size(200, 23)
        Me.ID_da_RemuneraçãoLabel1.TabIndex = 2
        Me.ID_da_RemuneraçãoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Nome_do_FuncionárioComboBox
        '
        Me.Nome_do_FuncionárioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Nome do Funcionário", True))
        Me.Nome_do_FuncionárioComboBox.DataSource = Me.FuncionárioBindingSource
        Me.Nome_do_FuncionárioComboBox.DisplayMember = "Nome do Funcionário"
        Me.Nome_do_FuncionárioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nome_do_FuncionárioComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_do_FuncionárioComboBox.FormattingEnabled = True
        Me.Nome_do_FuncionárioComboBox.Location = New System.Drawing.Point(305, 115)
        Me.Nome_do_FuncionárioComboBox.Name = "Nome_do_FuncionárioComboBox"
        Me.Nome_do_FuncionárioComboBox.Size = New System.Drawing.Size(200, 25)
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
        Me.ID_do_FuncionárioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "ID do Funcionário", True))
        Me.ID_do_FuncionárioComboBox.DataSource = Me.FuncionárioBindingSource
        Me.ID_do_FuncionárioComboBox.DisplayMember = "ID do Funcionário"
        Me.ID_do_FuncionárioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ID_do_FuncionárioComboBox.Enabled = False
        Me.ID_do_FuncionárioComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_FuncionárioComboBox.FormattingEnabled = True
        Me.ID_do_FuncionárioComboBox.Location = New System.Drawing.Point(305, 150)
        Me.ID_do_FuncionárioComboBox.Name = "ID_do_FuncionárioComboBox"
        Me.ID_do_FuncionárioComboBox.Size = New System.Drawing.Size(115, 25)
        Me.ID_do_FuncionárioComboBox.TabIndex = 2
        Me.ID_do_FuncionárioComboBox.ValueMember = "ID do Funcionário"
        '
        'CargoComboBox
        '
        Me.CargoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Cargo", True))
        Me.CargoComboBox.DataSource = Me.FuncionárioBindingSource
        Me.CargoComboBox.DisplayMember = "Cargo"
        Me.CargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CargoComboBox.Enabled = False
        Me.CargoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargoComboBox.FormattingEnabled = True
        Me.CargoComboBox.Location = New System.Drawing.Point(305, 185)
        Me.CargoComboBox.Name = "CargoComboBox"
        Me.CargoComboBox.Size = New System.Drawing.Size(200, 25)
        Me.CargoComboBox.TabIndex = 3
        Me.CargoComboBox.ValueMember = "Cargo"
        '
        'Salário_BrutoTextBox
        '
        Me.Salário_BrutoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Salário Bruto", True))
        Me.Salário_BrutoTextBox.Enabled = False
        Me.Salário_BrutoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salário_BrutoTextBox.Location = New System.Drawing.Point(305, 220)
        Me.Salário_BrutoTextBox.Name = "Salário_BrutoTextBox"
        Me.Salário_BrutoTextBox.Size = New System.Drawing.Size(146, 24)
        Me.Salário_BrutoTextBox.TabIndex = 4
        Me.Salário_BrutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescontosTextBox
        '
        Me.DescontosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Descontos", True))
        Me.DescontosTextBox.Enabled = False
        Me.DescontosTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescontosTextBox.Location = New System.Drawing.Point(305, 254)
        Me.DescontosTextBox.Name = "DescontosTextBox"
        Me.DescontosTextBox.Size = New System.Drawing.Size(146, 24)
        Me.DescontosTextBox.TabIndex = 5
        Me.DescontosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vendas_RealizadasTextBox
        '
        Me.Vendas_RealizadasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Vendas Realizadas", True))
        Me.Vendas_RealizadasTextBox.Enabled = False
        Me.Vendas_RealizadasTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vendas_RealizadasTextBox.Location = New System.Drawing.Point(305, 288)
        Me.Vendas_RealizadasTextBox.Name = "Vendas_RealizadasTextBox"
        Me.Vendas_RealizadasTextBox.Size = New System.Drawing.Size(146, 24)
        Me.Vendas_RealizadasTextBox.TabIndex = 6
        Me.Vendas_RealizadasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Mensagem.SetToolTip(Me.Vendas_RealizadasTextBox, "Vendedores recebem 30% de comissão em relação as suas vendas e Gerentes recebem 6" & _
                "0%")
        '
        'ComissãoTextBox
        '
        Me.ComissãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Comissão", True))
        Me.ComissãoTextBox.Enabled = False
        Me.ComissãoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComissãoTextBox.Location = New System.Drawing.Point(305, 322)
        Me.ComissãoTextBox.Name = "ComissãoTextBox"
        Me.ComissãoTextBox.Size = New System.Drawing.Size(146, 24)
        Me.ComissãoTextBox.TabIndex = 7
        Me.ComissãoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Salário_LiquidoTextBox
        '
        Me.Salário_LiquidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Salário Liquido", True))
        Me.Salário_LiquidoTextBox.Enabled = False
        Me.Salário_LiquidoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salário_LiquidoTextBox.Location = New System.Drawing.Point(305, 356)
        Me.Salário_LiquidoTextBox.Name = "Salário_LiquidoTextBox"
        Me.Salário_LiquidoTextBox.Size = New System.Drawing.Size(146, 24)
        Me.Salário_LiquidoTextBox.TabIndex = 8
        Me.Salário_LiquidoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 366)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Data_da_RemuneraçãoMaskedTextBox
        '
        Me.Data_da_RemuneraçãoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Remuneração_do_FuncionárioBindingSource, "Data da Remuneração", True))
        Me.Data_da_RemuneraçãoMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_da_RemuneraçãoMaskedTextBox.Location = New System.Drawing.Point(305, 82)
        Me.Data_da_RemuneraçãoMaskedTextBox.Mask = "00/00/0000"
        Me.Data_da_RemuneraçãoMaskedTextBox.Name = "Data_da_RemuneraçãoMaskedTextBox"
        Me.Data_da_RemuneraçãoMaskedTextBox.Size = New System.Drawing.Size(115, 24)
        Me.Data_da_RemuneraçãoMaskedTextBox.TabIndex = 0
        Me.Data_da_RemuneraçãoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Mensagem
        '
        Me.Mensagem.ShowAlways = True
        Me.Mensagem.ToolTipTitle = "Mensagem"
        '
        'frmRemuneração
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(520, 395)
        Me.Controls.Add(Me.Data_da_RemuneraçãoMaskedTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(ID_da_RemuneraçãoLabel)
        Me.Controls.Add(Me.ID_da_RemuneraçãoLabel1)
        Me.Controls.Add(Data_da_RemuneraçãoLabel)
        Me.Controls.Add(Nome_do_FuncionárioLabel)
        Me.Controls.Add(Me.Nome_do_FuncionárioComboBox)
        Me.Controls.Add(ID_do_FuncionárioLabel)
        Me.Controls.Add(Me.ID_do_FuncionárioComboBox)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(Me.CargoComboBox)
        Me.Controls.Add(Salário_BrutoLabel)
        Me.Controls.Add(Me.Salário_BrutoTextBox)
        Me.Controls.Add(DescontosLabel)
        Me.Controls.Add(Me.DescontosTextBox)
        Me.Controls.Add(Vendas_RealizadasLabel)
        Me.Controls.Add(Me.Vendas_RealizadasTextBox)
        Me.Controls.Add(ComissãoLabel)
        Me.Controls.Add(Me.ComissãoTextBox)
        Me.Controls.Add(Salário_LiquidoLabel)
        Me.Controls.Add(Me.Salário_LiquidoTextBox)
        Me.Controls.Add(Me.Remuneração_do_FuncionárioBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemuneração"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remuneração do Funcionário"
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remuneração_do_FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remuneração_do_FuncionárioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Remuneração_do_FuncionárioBindingNavigator.ResumeLayout(False)
        Me.Remuneração_do_FuncionárioBindingNavigator.PerformLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents Remuneração_do_FuncionárioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Remuneração_do_FuncionárioTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.Remuneração_do_FuncionárioTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Remuneração_do_FuncionárioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Remuneração_do_FuncionárioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_da_RemuneraçãoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Nome_do_FuncionárioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_do_FuncionárioComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CargoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Salário_BrutoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescontosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vendas_RealizadasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComissãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Salário_LiquidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FuncionárioTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.FuncionárioTableAdapter
    Friend WithEvents FuncionárioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Data_da_RemuneraçãoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Mensagem As System.Windows.Forms.ToolTip
End Class
