<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionário
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
        Dim ID_do_FuncionárioLabel As System.Windows.Forms.Label
        Dim Nome_do_FuncionárioLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim RGLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim Data_de_NascimentoLabel As System.Windows.Forms.Label
        Dim Data_de_AdmissãoLabel As System.Windows.Forms.Label
        Dim DemitidoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionário))
        Me.FuncionárioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.FuncionárioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Banco_OtakuFestDataSet = New OtakuFest.Banco_OtakuFestDataSet
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
        Me.FuncionárioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ID_do_FuncionárioLabel1 = New System.Windows.Forms.Label
        Me.Nome_do_FuncionárioTextBox = New System.Windows.Forms.TextBox
        Me.CargoComboBox = New System.Windows.Forms.ComboBox
        Me.SexoComboBox = New System.Windows.Forms.ComboBox
        Me.RGMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CelularMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.DemitidoCheckBox = New System.Windows.Forms.CheckBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox
        Me.CidadeTextBox = New System.Windows.Forms.TextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Data_de_NascimentoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Data_de_AdmissãoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.FuncionárioTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.FuncionárioTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        ID_do_FuncionárioLabel = New System.Windows.Forms.Label
        Nome_do_FuncionárioLabel = New System.Windows.Forms.Label
        CargoLabel = New System.Windows.Forms.Label
        SexoLabel = New System.Windows.Forms.Label
        RGLabel = New System.Windows.Forms.Label
        CPFLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        CelularLabel = New System.Windows.Forms.Label
        Data_de_NascimentoLabel = New System.Windows.Forms.Label
        Data_de_AdmissãoLabel = New System.Windows.Forms.Label
        DemitidoLabel = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        EndereçoLabel = New System.Windows.Forms.Label
        CType(Me.FuncionárioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FuncionárioBindingNavigator.SuspendLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_do_FuncionárioLabel
        '
        ID_do_FuncionárioLabel.AutoSize = True
        ID_do_FuncionárioLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_FuncionárioLabel.Location = New System.Drawing.Point(99, 48)
        ID_do_FuncionárioLabel.Name = "ID_do_FuncionárioLabel"
        ID_do_FuncionárioLabel.Size = New System.Drawing.Size(146, 14)
        ID_do_FuncionárioLabel.TabIndex = 1
        ID_do_FuncionárioLabel.Text = "ID do Funcionário:"
        '
        'Nome_do_FuncionárioLabel
        '
        Nome_do_FuncionárioLabel.AutoSize = True
        Nome_do_FuncionárioLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_do_FuncionárioLabel.Location = New System.Drawing.Point(99, 84)
        Nome_do_FuncionárioLabel.Name = "Nome_do_FuncionárioLabel"
        Nome_do_FuncionárioLabel.Size = New System.Drawing.Size(168, 14)
        Nome_do_FuncionárioLabel.TabIndex = 3
        Nome_do_FuncionárioLabel.Text = "Nome do Funcionário:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoLabel.Location = New System.Drawing.Point(99, 122)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(58, 14)
        CargoLabel.TabIndex = 5
        CargoLabel.Text = "Cargo:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexoLabel.Location = New System.Drawing.Point(99, 160)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(48, 14)
        SexoLabel.TabIndex = 7
        SexoLabel.Text = "Sexo:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RGLabel.Location = New System.Drawing.Point(99, 197)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(29, 14)
        RGLabel.TabIndex = 9
        RGLabel.Text = "RG:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPFLabel.Location = New System.Drawing.Point(99, 236)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(36, 14)
        CPFLabel.TabIndex = 11
        CPFLabel.Text = "CPF:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(99, 274)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(78, 14)
        TelefoneLabel.TabIndex = 13
        TelefoneLabel.Text = "Telefone:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CelularLabel.Location = New System.Drawing.Point(99, 312)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(70, 14)
        CelularLabel.TabIndex = 15
        CelularLabel.Text = "Celular:"
        '
        'Data_de_NascimentoLabel
        '
        Data_de_NascimentoLabel.AutoSize = True
        Data_de_NascimentoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_de_NascimentoLabel.Location = New System.Drawing.Point(506, 45)
        Data_de_NascimentoLabel.Name = "Data_de_NascimentoLabel"
        Data_de_NascimentoLabel.Size = New System.Drawing.Size(157, 14)
        Data_de_NascimentoLabel.TabIndex = 17
        Data_de_NascimentoLabel.Text = "Data de Nascimento:"
        '
        'Data_de_AdmissãoLabel
        '
        Data_de_AdmissãoLabel.AutoSize = True
        Data_de_AdmissãoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_de_AdmissãoLabel.Location = New System.Drawing.Point(506, 83)
        Data_de_AdmissãoLabel.Name = "Data_de_AdmissãoLabel"
        Data_de_AdmissãoLabel.Size = New System.Drawing.Size(143, 14)
        Data_de_AdmissãoLabel.TabIndex = 19
        Data_de_AdmissãoLabel.Text = "Data de Admissão:"
        '
        'DemitidoLabel
        '
        DemitidoLabel.AutoSize = True
        DemitidoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DemitidoLabel.Location = New System.Drawing.Point(506, 121)
        DemitidoLabel.Name = "DemitidoLabel"
        DemitidoLabel.Size = New System.Drawing.Size(71, 14)
        DemitidoLabel.TabIndex = 21
        DemitidoLabel.Text = "Demitido:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(506, 159)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(36, 14)
        CEPLabel.TabIndex = 23
        CEPLabel.Text = "CEP:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(506, 197)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(65, 14)
        EstadoLabel.TabIndex = 25
        EstadoLabel.Text = "Estado:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(506, 235)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(58, 14)
        CidadeLabel.TabIndex = 27
        CidadeLabel.Text = "Cidade:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(506, 273)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(59, 14)
        BairroLabel.TabIndex = 29
        BairroLabel.Text = "Bairro:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.Location = New System.Drawing.Point(506, 311)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(78, 14)
        EndereçoLabel.TabIndex = 31
        EndereçoLabel.Text = "Endereço:"
        '
        'FuncionárioBindingNavigator
        '
        Me.FuncionárioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FuncionárioBindingNavigator.BindingSource = Me.FuncionárioBindingSource
        Me.FuncionárioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FuncionárioBindingNavigator.DeleteItem = Nothing
        Me.FuncionárioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FuncionárioBindingNavigatorSaveItem})
        Me.FuncionárioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FuncionárioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FuncionárioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FuncionárioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FuncionárioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FuncionárioBindingNavigator.Name = "FuncionárioBindingNavigator"
        Me.FuncionárioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FuncionárioBindingNavigator.Size = New System.Drawing.Size(885, 25)
        Me.FuncionárioBindingNavigator.TabIndex = 0
        Me.FuncionárioBindingNavigator.Text = "BindingNavigator1"
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
        'FuncionárioBindingSource
        '
        Me.FuncionárioBindingSource.DataMember = "Funcionário"
        Me.FuncionárioBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'Banco_OtakuFestDataSet
        '
        Me.Banco_OtakuFestDataSet.DataSetName = "Banco_OtakuFestDataSet"
        Me.Banco_OtakuFestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'FuncionárioBindingNavigatorSaveItem
        '
        Me.FuncionárioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FuncionárioBindingNavigatorSaveItem.Image = CType(resources.GetObject("FuncionárioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FuncionárioBindingNavigatorSaveItem.Name = "FuncionárioBindingNavigatorSaveItem"
        Me.FuncionárioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FuncionárioBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_do_FuncionárioLabel1
        '
        Me.ID_do_FuncionárioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "ID do Funcionário", True))
        Me.ID_do_FuncionárioLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_FuncionárioLabel1.Location = New System.Drawing.Point(275, 44)
        Me.ID_do_FuncionárioLabel1.Name = "ID_do_FuncionárioLabel1"
        Me.ID_do_FuncionárioLabel1.Size = New System.Drawing.Size(200, 23)
        Me.ID_do_FuncionárioLabel1.TabIndex = 2
        Me.ID_do_FuncionárioLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Nome_do_FuncionárioTextBox
        '
        Me.Nome_do_FuncionárioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Nome do Funcionário", True))
        Me.Nome_do_FuncionárioTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_do_FuncionárioTextBox.Location = New System.Drawing.Point(275, 80)
        Me.Nome_do_FuncionárioTextBox.Name = "Nome_do_FuncionárioTextBox"
        Me.Nome_do_FuncionárioTextBox.Size = New System.Drawing.Size(200, 24)
        Me.Nome_do_FuncionárioTextBox.TabIndex = 0
        '
        'CargoComboBox
        '
        Me.CargoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Cargo", True))
        Me.CargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CargoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargoComboBox.FormattingEnabled = True
        Me.CargoComboBox.Items.AddRange(New Object() {"Limpeza", "Vendas", "Gerência"})
        Me.CargoComboBox.Location = New System.Drawing.Point(275, 118)
        Me.CargoComboBox.Name = "CargoComboBox"
        Me.CargoComboBox.Size = New System.Drawing.Size(141, 25)
        Me.CargoComboBox.TabIndex = 1
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Sexo", True))
        Me.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SexoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.SexoComboBox.Location = New System.Drawing.Point(275, 156)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(141, 25)
        Me.SexoComboBox.TabIndex = 2
        '
        'RGMaskedTextBox
        '
        Me.RGMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "RG", True))
        Me.RGMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGMaskedTextBox.Location = New System.Drawing.Point(275, 194)
        Me.RGMaskedTextBox.Mask = "00,000,000-0"
        Me.RGMaskedTextBox.Name = "RGMaskedTextBox"
        Me.RGMaskedTextBox.Size = New System.Drawing.Size(141, 24)
        Me.RGMaskedTextBox.TabIndex = 3
        Me.RGMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(275, 232)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(141, 24)
        Me.CPFMaskedTextBox.TabIndex = 4
        Me.CPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(275, 270)
        Me.TelefoneMaskedTextBox.Mask = "(00) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(141, 24)
        Me.TelefoneMaskedTextBox.TabIndex = 5
        Me.TelefoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CelularMaskedTextBox
        '
        Me.CelularMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Celular", True))
        Me.CelularMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CelularMaskedTextBox.Location = New System.Drawing.Point(275, 308)
        Me.CelularMaskedTextBox.Mask = "(00) 0000-0000"
        Me.CelularMaskedTextBox.Name = "CelularMaskedTextBox"
        Me.CelularMaskedTextBox.Size = New System.Drawing.Size(141, 24)
        Me.CelularMaskedTextBox.TabIndex = 6
        Me.CelularMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DemitidoCheckBox
        '
        Me.DemitidoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FuncionárioBindingSource, "Demitido", True))
        Me.DemitidoCheckBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DemitidoCheckBox.Location = New System.Drawing.Point(676, 117)
        Me.DemitidoCheckBox.Name = "DemitidoCheckBox"
        Me.DemitidoCheckBox.Size = New System.Drawing.Size(144, 24)
        Me.DemitidoCheckBox.TabIndex = 9
        Me.DemitidoCheckBox.Text = "Sim/Não"
        Me.DemitidoCheckBox.UseVisualStyleBackColor = True
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(676, 155)
        Me.CEPMaskedTextBox.Mask = "00000-000"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(144, 24)
        Me.CEPMaskedTextBox.TabIndex = 10
        Me.CEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Estado", True))
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"Acre", "Alagoas", "Amapá", "Amazonas" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Bahia" & Global.Microsoft.VisualBasic.ChrW(9), "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro ", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(676, 193)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(144, 25)
        Me.EstadoComboBox.TabIndex = 11
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.Location = New System.Drawing.Point(676, 231)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(187, 24)
        Me.CidadeTextBox.TabIndex = 12
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.Location = New System.Drawing.Point(676, 266)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(187, 24)
        Me.BairroTextBox.TabIndex = 13
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(676, 307)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(187, 24)
        Me.EndereçoTextBox.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 319)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Data_de_NascimentoMaskedTextBox
        '
        Me.Data_de_NascimentoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Data de Nascimento", True))
        Me.Data_de_NascimentoMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_de_NascimentoMaskedTextBox.Location = New System.Drawing.Point(676, 41)
        Me.Data_de_NascimentoMaskedTextBox.Mask = "00/00/0000"
        Me.Data_de_NascimentoMaskedTextBox.Name = "Data_de_NascimentoMaskedTextBox"
        Me.Data_de_NascimentoMaskedTextBox.Size = New System.Drawing.Size(144, 24)
        Me.Data_de_NascimentoMaskedTextBox.TabIndex = 7
        Me.Data_de_NascimentoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Data_de_AdmissãoMaskedTextBox
        '
        Me.Data_de_AdmissãoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FuncionárioBindingSource, "Data de Admissão", True))
        Me.Data_de_AdmissãoMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_de_AdmissãoMaskedTextBox.Location = New System.Drawing.Point(676, 79)
        Me.Data_de_AdmissãoMaskedTextBox.Mask = "00/00/0000"
        Me.Data_de_AdmissãoMaskedTextBox.Name = "Data_de_AdmissãoMaskedTextBox"
        Me.Data_de_AdmissãoMaskedTextBox.Size = New System.Drawing.Size(144, 24)
        Me.Data_de_AdmissãoMaskedTextBox.TabIndex = 8
        Me.Data_de_AdmissãoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FuncionárioTableAdapter
        '
        Me.FuncionárioTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Nothing
        '
        'frmFuncionário
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(885, 347)
        Me.Controls.Add(Me.Data_de_AdmissãoMaskedTextBox)
        Me.Controls.Add(Me.Data_de_NascimentoMaskedTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(ID_do_FuncionárioLabel)
        Me.Controls.Add(Me.ID_do_FuncionárioLabel1)
        Me.Controls.Add(Nome_do_FuncionárioLabel)
        Me.Controls.Add(Me.Nome_do_FuncionárioTextBox)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(Me.CargoComboBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(Me.SexoComboBox)
        Me.Controls.Add(RGLabel)
        Me.Controls.Add(Me.RGMaskedTextBox)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularMaskedTextBox)
        Me.Controls.Add(Data_de_NascimentoLabel)
        Me.Controls.Add(Data_de_AdmissãoLabel)
        Me.Controls.Add(DemitidoLabel)
        Me.Controls.Add(Me.DemitidoCheckBox)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.CEPMaskedTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(EndereçoLabel)
        Me.Controls.Add(Me.EndereçoTextBox)
        Me.Controls.Add(Me.FuncionárioBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFuncionário"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        CType(Me.FuncionárioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FuncionárioBindingNavigator.ResumeLayout(False)
        Me.FuncionárioBindingNavigator.PerformLayout()
        CType(Me.FuncionárioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents FuncionárioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FuncionárioTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.FuncionárioTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FuncionárioBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FuncionárioBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_do_FuncionárioLabel1 As System.Windows.Forms.Label
    Friend WithEvents Nome_do_FuncionárioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CargoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SexoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RGMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPFMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CelularMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DemitidoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EstadoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndereçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Data_de_NascimentoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Data_de_AdmissãoMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
