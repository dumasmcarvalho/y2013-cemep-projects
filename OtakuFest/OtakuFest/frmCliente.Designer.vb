<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim ID_do_ClienteLabel As System.Windows.Forms.Label
        Dim Nome_do_ClienteLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim RGLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim Data_de_NascimentoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim BairroLabel As System.Windows.Forms.Label
        Dim EndereçoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ID_do_ClienteLabel1 = New System.Windows.Forms.Label
        Me.Nome_do_ClienteTextBox = New System.Windows.Forms.TextBox
        Me.SexoComboBox = New System.Windows.Forms.ComboBox
        Me.RGMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CelularMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CEPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox
        Me.CidadeTextBox = New System.Windows.Forms.TextBox
        Me.BairroTextBox = New System.Windows.Forms.TextBox
        Me.EndereçoTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Data_de_NascimentoMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.ClienteTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        ID_do_ClienteLabel = New System.Windows.Forms.Label
        Nome_do_ClienteLabel = New System.Windows.Forms.Label
        SexoLabel = New System.Windows.Forms.Label
        RGLabel = New System.Windows.Forms.Label
        CPFLabel = New System.Windows.Forms.Label
        TelefoneLabel = New System.Windows.Forms.Label
        CelularLabel = New System.Windows.Forms.Label
        Data_de_NascimentoLabel = New System.Windows.Forms.Label
        CEPLabel = New System.Windows.Forms.Label
        EstadoLabel = New System.Windows.Forms.Label
        CidadeLabel = New System.Windows.Forms.Label
        BairroLabel = New System.Windows.Forms.Label
        EndereçoLabel = New System.Windows.Forms.Label
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_do_ClienteLabel
        '
        ID_do_ClienteLabel.AutoSize = True
        ID_do_ClienteLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_ClienteLabel.Location = New System.Drawing.Point(97, 45)
        ID_do_ClienteLabel.Name = "ID_do_ClienteLabel"
        ID_do_ClienteLabel.Size = New System.Drawing.Size(115, 15)
        ID_do_ClienteLabel.TabIndex = 1
        ID_do_ClienteLabel.Text = "ID do Cliente:"
        '
        'Nome_do_ClienteLabel
        '
        Nome_do_ClienteLabel.AutoSize = True
        Nome_do_ClienteLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_do_ClienteLabel.Location = New System.Drawing.Point(97, 82)
        Nome_do_ClienteLabel.Name = "Nome_do_ClienteLabel"
        Nome_do_ClienteLabel.Size = New System.Drawing.Size(140, 15)
        Nome_do_ClienteLabel.TabIndex = 3
        Nome_do_ClienteLabel.Text = "Nome do Cliente:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexoLabel.Location = New System.Drawing.Point(97, 116)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(52, 15)
        SexoLabel.TabIndex = 5
        SexoLabel.Text = "Sexo:"
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RGLabel.Location = New System.Drawing.Point(97, 151)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(31, 15)
        RGLabel.TabIndex = 7
        RGLabel.Text = "RG:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPFLabel.Location = New System.Drawing.Point(97, 185)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(37, 15)
        CPFLabel.TabIndex = 9
        CPFLabel.Text = "CPF:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(97, 219)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(83, 15)
        TelefoneLabel.TabIndex = 11
        TelefoneLabel.Text = "Telefone:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CelularLabel.Location = New System.Drawing.Point(97, 253)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(72, 15)
        CelularLabel.TabIndex = 13
        CelularLabel.Text = "Celular:"
        '
        'Data_de_NascimentoLabel
        '
        Data_de_NascimentoLabel.AutoSize = True
        Data_de_NascimentoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_de_NascimentoLabel.Location = New System.Drawing.Point(474, 45)
        Data_de_NascimentoLabel.Name = "Data_de_NascimentoLabel"
        Data_de_NascimentoLabel.Size = New System.Drawing.Size(166, 15)
        Data_de_NascimentoLabel.TabIndex = 15
        Data_de_NascimentoLabel.Text = "Data de Nascimento:"
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(474, 78)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(38, 15)
        CEPLabel.TabIndex = 17
        CEPLabel.Text = "CEP:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(474, 112)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(69, 15)
        EstadoLabel.TabIndex = 19
        EstadoLabel.Text = "Estado:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(474, 147)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(61, 15)
        CidadeLabel.TabIndex = 21
        CidadeLabel.Text = "Cidade:"
        '
        'BairroLabel
        '
        BairroLabel.AutoSize = True
        BairroLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BairroLabel.Location = New System.Drawing.Point(474, 181)
        BairroLabel.Name = "BairroLabel"
        BairroLabel.Size = New System.Drawing.Size(63, 15)
        BairroLabel.TabIndex = 23
        BairroLabel.Text = "Bairro:"
        '
        'EndereçoLabel
        '
        EndereçoLabel.AutoSize = True
        EndereçoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndereçoLabel.Location = New System.Drawing.Point(474, 215)
        EndereçoLabel.Name = "EndereçoLabel"
        EndereçoLabel.Size = New System.Drawing.Size(85, 15)
        EndereçoLabel.TabIndex = 25
        EndereçoLabel.Text = "Endereço:"
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Nothing
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(854, 25)
        Me.ClienteBindingNavigator.TabIndex = 0
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.Banco_OtakuFestDataSet
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
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_do_ClienteLabel1
        '
        Me.ID_do_ClienteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ID do Cliente", True))
        Me.ID_do_ClienteLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_ClienteLabel1.Location = New System.Drawing.Point(245, 45)
        Me.ID_do_ClienteLabel1.Name = "ID_do_ClienteLabel1"
        Me.ID_do_ClienteLabel1.Size = New System.Drawing.Size(200, 23)
        Me.ID_do_ClienteLabel1.TabIndex = 2
        Me.ID_do_ClienteLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Nome_do_ClienteTextBox
        '
        Me.Nome_do_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nome do Cliente", True))
        Me.Nome_do_ClienteTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_do_ClienteTextBox.Location = New System.Drawing.Point(245, 79)
        Me.Nome_do_ClienteTextBox.Name = "Nome_do_ClienteTextBox"
        Me.Nome_do_ClienteTextBox.Size = New System.Drawing.Size(200, 24)
        Me.Nome_do_ClienteTextBox.TabIndex = 0
        '
        'SexoComboBox
        '
        Me.SexoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Sexo", True))
        Me.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SexoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoComboBox.FormattingEnabled = True
        Me.SexoComboBox.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.SexoComboBox.Location = New System.Drawing.Point(245, 113)
        Me.SexoComboBox.Name = "SexoComboBox"
        Me.SexoComboBox.Size = New System.Drawing.Size(146, 25)
        Me.SexoComboBox.TabIndex = 1
        '
        'RGMaskedTextBox
        '
        Me.RGMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "RG", True))
        Me.RGMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RGMaskedTextBox.Location = New System.Drawing.Point(245, 148)
        Me.RGMaskedTextBox.Mask = "00.000.000-0"
        Me.RGMaskedTextBox.Name = "RGMaskedTextBox"
        Me.RGMaskedTextBox.Size = New System.Drawing.Size(146, 24)
        Me.RGMaskedTextBox.TabIndex = 2
        Me.RGMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(245, 182)
        Me.CPFMaskedTextBox.Mask = "000,000,000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(146, 24)
        Me.CPFMaskedTextBox.TabIndex = 3
        Me.CPFMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefone", True))
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(245, 216)
        Me.TelefoneMaskedTextBox.Mask = "(00) 0000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(146, 24)
        Me.TelefoneMaskedTextBox.TabIndex = 4
        Me.TelefoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CelularMaskedTextBox
        '
        Me.CelularMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Celular", True))
        Me.CelularMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CelularMaskedTextBox.Location = New System.Drawing.Point(245, 250)
        Me.CelularMaskedTextBox.Mask = "(00) 0000-0000"
        Me.CelularMaskedTextBox.Name = "CelularMaskedTextBox"
        Me.CelularMaskedTextBox.Size = New System.Drawing.Size(146, 24)
        Me.CelularMaskedTextBox.TabIndex = 5
        Me.CelularMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CEPMaskedTextBox
        '
        Me.CEPMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "CEP", True))
        Me.CEPMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPMaskedTextBox.Location = New System.Drawing.Point(652, 73)
        Me.CEPMaskedTextBox.Mask = "00000-000"
        Me.CEPMaskedTextBox.Name = "CEPMaskedTextBox"
        Me.CEPMaskedTextBox.Size = New System.Drawing.Size(145, 24)
        Me.CEPMaskedTextBox.TabIndex = 7
        Me.CEPMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Estado", True))
        Me.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"Acre", "Alagoas", "Amapá", "Amazonas" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Bahia" & Global.Microsoft.VisualBasic.ChrW(9), "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro ", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(652, 107)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(145, 25)
        Me.EstadoComboBox.TabIndex = 8
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Cidade", True))
        Me.CidadeTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.Location = New System.Drawing.Point(652, 142)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(182, 24)
        Me.CidadeTextBox.TabIndex = 9
        '
        'BairroTextBox
        '
        Me.BairroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Bairro", True))
        Me.BairroTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BairroTextBox.Location = New System.Drawing.Point(652, 176)
        Me.BairroTextBox.Name = "BairroTextBox"
        Me.BairroTextBox.Size = New System.Drawing.Size(182, 24)
        Me.BairroTextBox.TabIndex = 10
        '
        'EndereçoTextBox
        '
        Me.EndereçoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Endereço", True))
        Me.EndereçoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndereçoTextBox.Location = New System.Drawing.Point(652, 210)
        Me.EndereçoTextBox.Name = "EndereçoTextBox"
        Me.EndereçoTextBox.Size = New System.Drawing.Size(182, 24)
        Me.EndereçoTextBox.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 260)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Data_de_NascimentoMaskedTextBox
        '
        Me.Data_de_NascimentoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Data de Nascimento", True))
        Me.Data_de_NascimentoMaskedTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_de_NascimentoMaskedTextBox.Location = New System.Drawing.Point(652, 42)
        Me.Data_de_NascimentoMaskedTextBox.Mask = "00/00/0000"
        Me.Data_de_NascimentoMaskedTextBox.Name = "Data_de_NascimentoMaskedTextBox"
        Me.Data_de_NascimentoMaskedTextBox.Size = New System.Drawing.Size(145, 24)
        Me.Data_de_NascimentoMaskedTextBox.TabIndex = 6
        Me.Data_de_NascimentoMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Itens_da_Venda_CompraTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Pagamento_do_ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Nothing
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Nothing
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(854, 289)
        Me.Controls.Add(Me.Data_de_NascimentoMaskedTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(ID_do_ClienteLabel)
        Me.Controls.Add(Me.ID_do_ClienteLabel1)
        Me.Controls.Add(Nome_do_ClienteLabel)
        Me.Controls.Add(Me.Nome_do_ClienteTextBox)
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
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClienteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_do_ClienteLabel1 As System.Windows.Forms.Label
    Friend WithEvents Nome_do_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RGMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPFMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CelularMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CEPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EstadoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BairroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndereçoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Data_de_NascimentoMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
