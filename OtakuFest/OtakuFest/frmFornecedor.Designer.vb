<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedor
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
        Dim ID_do_FornecedorLabel As System.Windows.Forms.Label
        Dim Razão_SocialLabel As System.Windows.Forms.Label
        Dim CNPJLabel As System.Windows.Forms.Label
        Dim SetorLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim PaísLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedor))
        Me.FornecedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.FornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.FornecedorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ID_do_FornecedorLabel1 = New System.Windows.Forms.Label
        Me.Razão_SocialTextBox = New System.Windows.Forms.TextBox
        Me.SetorComboBox = New System.Windows.Forms.ComboBox
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CidadeTextBox = New System.Windows.Forms.TextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CNPJMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.EstadoTextBox = New System.Windows.Forms.TextBox
        Me.PaísTextBox = New System.Windows.Forms.TextBox
        Me.FornecedorTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.FornecedorTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        ID_do_FornecedorLabel = New System.Windows.Forms.Label
        Razão_SocialLabel = New System.Windows.Forms.Label
        CNPJLabel = New System.Windows.Forms.Label
        SetorLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        EndereçoLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        PaísLabel = New System.Windows.Forms.Label
        CType(Me.FornecedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FornecedorBindingNavigator.SuspendLayout()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_do_FornecedorLabel
        '
        ID_do_FornecedorLabel.AutoSize = True
        ID_do_FornecedorLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_FornecedorLabel.Location = New System.Drawing.Point(95, 41)
        ID_do_FornecedorLabel.Name = "ID_do_FornecedorLabel"
        ID_do_FornecedorLabel.Size = New System.Drawing.Size(146, 14)
        ID_do_FornecedorLabel.TabIndex = 1
        ID_do_FornecedorLabel.Text = "ID do Fornecedor:"
        '
        'Razão_SocialLabel
        '
        Razão_SocialLabel.AutoSize = True
        Razão_SocialLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Razão_SocialLabel.Location = New System.Drawing.Point(95, 75)
        Razão_SocialLabel.Name = "Razão_SocialLabel"
        Razão_SocialLabel.Size = New System.Drawing.Size(111, 14)
        Razão_SocialLabel.TabIndex = 3
        Razão_SocialLabel.Text = "Razão Social:"
        '
        'CNPJLabel
        '
        CNPJLabel.AutoSize = True
        CNPJLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJLabel.Location = New System.Drawing.Point(95, 107)
        CNPJLabel.Name = "CNPJLabel"
        CNPJLabel.Size = New System.Drawing.Size(47, 14)
        CNPJLabel.TabIndex = 5
        CNPJLabel.Text = "CNPJ:"
        '
        'SetorLabel
        '
        SetorLabel.AutoSize = True
        SetorLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SetorLabel.Location = New System.Drawing.Point(95, 139)
        SetorLabel.Name = "SetorLabel"
        SetorLabel.Size = New System.Drawing.Size(55, 14)
        SetorLabel.TabIndex = 7
        SetorLabel.Text = "Setor:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(95, 172)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(78, 14)
        TelefoneLabel.TabIndex = 9
        TelefoneLabel.Text = "Telefone:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(95, 204)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(36, 14)
        CEPLabel.TabIndex = 11
        CEPLabel.Text = "CEP:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(95, 298)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(58, 14)
        CidadeLabel.TabIndex = 15
        CidadeLabel.Text = "Cidade:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(95, 330)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(59, 14)
        BairroLabel.TabIndex = 17
        BairroLabel.Text = "Bairro:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.Location = New System.Drawing.Point(95, 362)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(78, 14)
        EndereçoLabel.TabIndex = 19
        EndereçoLabel.Text = "Endereço:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(95, 266)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(65, 14)
        EstadoLabel.TabIndex = 36
        EstadoLabel.Text = "Estado:"
        '
        'PaísLabel
        '
        PaísLabel.AutoSize = True
        PaísLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaísLabel.Location = New System.Drawing.Point(95, 235)
        PaísLabel.Name = "PaísLabel"
        PaísLabel.Size = New System.Drawing.Size(41, 14)
        PaísLabel.TabIndex = 37
        PaísLabel.Text = "País:"
        '
        'FornecedorBindingNavigator
        '
        Me.FornecedorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FornecedorBindingNavigator.BindingSource = Me.FornecedorBindingSource
        Me.FornecedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FornecedorBindingNavigator.DeleteItem = Nothing
        Me.FornecedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FornecedorBindingNavigatorSaveItem})
        Me.FornecedorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FornecedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FornecedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FornecedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FornecedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FornecedorBindingNavigator.Name = "FornecedorBindingNavigator"
        Me.FornecedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FornecedorBindingNavigator.Size = New System.Drawing.Size(471, 25)
        Me.FornecedorBindingNavigator.TabIndex = 0
        Me.FornecedorBindingNavigator.Text = "BindingNavigator1"
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
        'FornecedorBindingSource
        '
        Me.FornecedorBindingSource.DataMember = "Fornecedor"
        Me.FornecedorBindingSource.DataSource = Me.Banco_OtakuFestDataSet
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
        'FornecedorBindingNavigatorSaveItem
        '
        Me.FornecedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FornecedorBindingNavigatorSaveItem.Image = CType(resources.GetObject("FornecedorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FornecedorBindingNavigatorSaveItem.Name = "FornecedorBindingNavigatorSaveItem"
        Me.FornecedorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FornecedorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_do_FornecedorLabel1
        '
        Me.ID_do_FornecedorLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "ID do Fornecedor", True))
        Me.ID_do_FornecedorLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_FornecedorLabel1.Location = New System.Drawing.Point(265, 40)
        Me.ID_do_FornecedorLabel1.Name = "ID_do_FornecedorLabel1"
        Me.ID_do_FornecedorLabel1.Size = New System.Drawing.Size(185, 23)
        Me.ID_do_FornecedorLabel1.TabIndex = 2
        Me.ID_do_FornecedorLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Razão_SocialTextBox
        '
        Me.Razão_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Razão Social", True))
        Me.Razão_SocialTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Razão_SocialTextBox.Location = New System.Drawing.Point(268, 71)
        Me.Razão_SocialTextBox.Name = "Razão_SocialTextBox"
        Me.Razão_SocialTextBox.Size = New System.Drawing.Size(182, 24)
        Me.Razão_SocialTextBox.TabIndex = 0
        '
        'SetorComboBox
        '
        Me.SetorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Setor", True))
        Me.SetorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SetorComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetorComboBox.FormattingEnabled = True
        Me.SetorComboBox.Items.AddRange(New Object() {"Alimentos", "Acessórios", "CDs/DVDs", "Mangás", "Vestimentas", "Outros"})
        Me.SetorComboBox.Location = New System.Drawing.Point(268, 135)
        Me.SetorComboBox.Name = "SetorComboBox"
        Me.SetorComboBox.Size = New System.Drawing.Size(154, 25)
        Me.SetorComboBox.TabIndex = 2
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(268, 168)
        Me.TelefoneMaskedTextBox.Mask = "(00) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(154, 24)
        Me.TelefoneMaskedTextBox.TabIndex = 3
        Me.TelefoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(268, 200)
        Me.CEPMaskedTextBox.Mask = "00000-000"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(154, 24)
        Me.CEPMaskedTextBox.TabIndex = 4
        Me.CEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.Location = New System.Drawing.Point(268, 294)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(182, 24)
        Me.CidadeTextBox.TabIndex = 7
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.Location = New System.Drawing.Point(268, 326)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(182, 24)
        Me.BairroTextBox.TabIndex = 8
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(268, 358)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(182, 24)
        Me.EndereçoTextBox.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 365)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'CNPJMaskedTextBox
        '
        Me.CNPJMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "CNPJ", True))
        Me.CNPJMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNPJMaskedTextBox.Location = New System.Drawing.Point(268, 103)
        Me.CNPJMaskedTextBox.Mask = "00,000,000/0000-00"
        Me.CNPJMaskedTextBox.Name = "CNPJMaskedTextBox"
        Me.CNPJMaskedTextBox.Size = New System.Drawing.Size(154, 24)
        Me.CNPJMaskedTextBox.TabIndex = 1
        Me.CNPJMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "Estado", True))
        Me.EstadoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoTextBox.Location = New System.Drawing.Point(268, 263)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(182, 23)
        Me.EstadoTextBox.TabIndex = 6
        '
        'PaísTextBox
        '
        Me.PaísTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FornecedorBindingSource, "País", True))
        Me.PaísTextBox.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaísTextBox.Location = New System.Drawing.Point(268, 232)
        Me.PaísTextBox.Name = "PaísTextBox"
        Me.PaísTextBox.Size = New System.Drawing.Size(182, 23)
        Me.PaísTextBox.TabIndex = 5
        '
        'FornecedorTableAdapter
        '
        Me.FornecedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Me.FornecedorTableAdapter
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Itens_da_Venda_CompraTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Pagamento_do_ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Nothing
        '
        'frmFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(471, 395)
        Me.Controls.Add(PaísLabel)
        Me.Controls.Add(Me.PaísTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(Me.CNPJMaskedTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(ID_do_FornecedorLabel)
        Me.Controls.Add(Me.ID_do_FornecedorLabel1)
        Me.Controls.Add(Razão_SocialLabel)
        Me.Controls.Add(Me.Razão_SocialTextBox)
        Me.Controls.Add(CNPJLabel)
        Me.Controls.Add(SetorLabel)
        Me.Controls.Add(Me.SetorComboBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.CEPMaskedTextBox)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(BairroLabel)
        Me.Controls.Add(Me.BairroTextBox)
        Me.Controls.Add(EndereçoLabel)
        Me.Controls.Add(Me.EndereçoTextBox)
        Me.Controls.Add(Me.FornecedorBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro do Fornecedor"
        CType(Me.FornecedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FornecedorBindingNavigator.ResumeLayout(False)
        Me.FornecedorBindingNavigator.PerformLayout()
        CType(Me.FornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents FornecedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FornecedorTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.FornecedorTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FornecedorBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FornecedorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_do_FornecedorLabel1 As System.Windows.Forms.Label
    Friend WithEvents Razão_SocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TelefoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndereçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CNPJMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EstadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaísTextBox As System.Windows.Forms.TextBox
End Class
