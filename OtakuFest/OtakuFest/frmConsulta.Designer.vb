<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.radioClientes = New System.Windows.Forms.RadioButton
        Me.radioVendas = New System.Windows.Forms.RadioButton
        Me.radioProdutos = New System.Windows.Forms.RadioButton
        Me.lblDados = New System.Windows.Forms.Label
        Me.cpfDados = New System.Windows.Forms.MaskedTextBox
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Banco_OtakuFestDataSet = New OtakuFest.Banco_OtakuFestDataSet
        Me.Venda_CompraDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Venda_CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tipoDados = New System.Windows.Forms.TextBox
        Me.dataDados_antes = New System.Windows.Forms.DateTimePicker
        Me.ClienteTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        Me.ProdutosTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.ProdutosTableAdapter
        Me.Venda_CompraTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.Venda_CompraTableAdapter
        Me.dataDados_depois = New System.Windows.Forms.DateTimePicker
        Me.btnData = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Mensagem = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_CompraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Venda_CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radioClientes
        '
        Me.radioClientes.Appearance = System.Windows.Forms.Appearance.Button
        Me.radioClientes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.radioClientes.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioClientes.Location = New System.Drawing.Point(32, 14)
        Me.radioClientes.Name = "radioClientes"
        Me.radioClientes.Size = New System.Drawing.Size(138, 30)
        Me.radioClientes.TabIndex = 0
        Me.radioClientes.TabStop = True
        Me.radioClientes.Text = "Cliente via CPF"
        Me.radioClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Mensagem.SetToolTip(Me.radioClientes, "O CPF do cliente deve estar completo para poder ser encontrado")
        Me.radioClientes.UseVisualStyleBackColor = False
        '
        'radioVendas
        '
        Me.radioVendas.Appearance = System.Windows.Forms.Appearance.Button
        Me.radioVendas.AutoSize = True
        Me.radioVendas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.radioVendas.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioVendas.Location = New System.Drawing.Point(224, 14)
        Me.radioVendas.Name = "radioVendas"
        Me.radioVendas.Size = New System.Drawing.Size(196, 30)
        Me.radioVendas.TabIndex = 1
        Me.radioVendas.TabStop = True
        Me.radioVendas.Text = "Vendas/Compras via Data"
        Me.radioVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Mensagem.SetToolTip(Me.radioVendas, "A consulta é realizada considerando os dias entre as datas informadas")
        Me.radioVendas.UseVisualStyleBackColor = False
        '
        'radioProdutos
        '
        Me.radioProdutos.Appearance = System.Windows.Forms.Appearance.Button
        Me.radioProdutos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.radioProdutos.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioProdutos.Location = New System.Drawing.Point(474, 14)
        Me.radioProdutos.Name = "radioProdutos"
        Me.radioProdutos.Size = New System.Drawing.Size(138, 30)
        Me.radioProdutos.TabIndex = 2
        Me.radioProdutos.TabStop = True
        Me.radioProdutos.Text = "Produtos via Tipo"
        Me.radioProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Mensagem.SetToolTip(Me.radioProdutos, "É necessário informar o tipo de produto para consulta-los")
        Me.radioProdutos.UseVisualStyleBackColor = False
        '
        'lblDados
        '
        Me.lblDados.AutoSize = True
        Me.lblDados.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDados.Location = New System.Drawing.Point(9, 63)
        Me.lblDados.Name = "lblDados"
        Me.lblDados.Size = New System.Drawing.Size(345, 14)
        Me.lblDados.TabIndex = 5
        Me.lblDados.Text = "Informe o respectivo dado para a consulta:"
        '
        'cpfDados
        '
        Me.cpfDados.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpfDados.Location = New System.Drawing.Point(360, 57)
        Me.cpfDados.Mask = "000,000,000-00"
        Me.cpfDados.Name = "cpfDados"
        Me.cpfDados.Size = New System.Drawing.Size(272, 23)
        Me.cpfDados.TabIndex = 6
        Me.cpfDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cpfDados.Visible = False
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(14, 93)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        Me.ClienteDataGridView.Size = New System.Drawing.Size(618, 294)
        Me.ClienteDataGridView.TabIndex = 7
        Me.ClienteDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID do Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID do Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome do Cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome do Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sexo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RG"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RG"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CPF"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telefone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Celular"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Celular"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Data de Nascimento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Data de Nascimento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CEP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CEP"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Cidade"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cidade"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Bairro"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Bairro"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Endereço"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Endereço"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
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
        'Venda_CompraDataGridView
        '
        Me.Venda_CompraDataGridView.AllowUserToAddRows = False
        Me.Venda_CompraDataGridView.AllowUserToDeleteRows = False
        Me.Venda_CompraDataGridView.AutoGenerateColumns = False
        Me.Venda_CompraDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Venda_CompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Venda_CompraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.Venda_CompraDataGridView.DataSource = Me.Venda_CompraBindingSource
        Me.Venda_CompraDataGridView.Location = New System.Drawing.Point(14, 93)
        Me.Venda_CompraDataGridView.Name = "Venda_CompraDataGridView"
        Me.Venda_CompraDataGridView.ReadOnly = True
        Me.Venda_CompraDataGridView.Size = New System.Drawing.Size(618, 294)
        Me.Venda_CompraDataGridView.TabIndex = 7
        Me.Venda_CompraDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ID da Venda/Compra"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ID da Venda/Compra"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Data da Venda/Compra"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Data da Venda/Compra"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Nome do Funcionário"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nome do Funcionário"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ID do Funcionário"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ID do Funcionário"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Nome do Cliente"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nome do Cliente"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ID do Cliente"
        Me.DataGridViewTextBoxColumn19.HeaderText = "ID do Cliente"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Valor Total"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn20.HeaderText = "Valor Total"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'Venda_CompraBindingSource
        '
        Me.Venda_CompraBindingSource.DataMember = "Venda/Compra"
        Me.Venda_CompraBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'ProdutosDataGridView
        '
        Me.ProdutosDataGridView.AllowUserToAddRows = False
        Me.ProdutosDataGridView.AllowUserToDeleteRows = False
        Me.ProdutosDataGridView.AutoGenerateColumns = False
        Me.ProdutosDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.ProdutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdutosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewImageColumn1})
        Me.ProdutosDataGridView.DataSource = Me.ProdutosBindingSource
        Me.ProdutosDataGridView.Location = New System.Drawing.Point(12, 93)
        Me.ProdutosDataGridView.Name = "ProdutosDataGridView"
        Me.ProdutosDataGridView.ReadOnly = True
        Me.ProdutosDataGridView.Size = New System.Drawing.Size(618, 294)
        Me.ProdutosDataGridView.TabIndex = 8
        Me.ProdutosDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ID do Produto"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ID do Produto"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Descrição"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Descrição"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Tipo de Produto"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Tipo de Produto"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Foto"
        Me.DataGridViewImageColumn1.HeaderText = "Foto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'tipoDados
        '
        Me.tipoDados.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipoDados.Location = New System.Drawing.Point(360, 57)
        Me.tipoDados.Name = "tipoDados"
        Me.tipoDados.Size = New System.Drawing.Size(272, 23)
        Me.tipoDados.TabIndex = 9
        Me.tipoDados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tipoDados.Visible = False
        '
        'dataDados_antes
        '
        Me.dataDados_antes.CalendarFont = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataDados_antes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataDados_antes.Location = New System.Drawing.Point(360, 58)
        Me.dataDados_antes.Name = "dataDados_antes"
        Me.dataDados_antes.Size = New System.Drawing.Size(104, 20)
        Me.dataDados_antes.TabIndex = 10
        Me.dataDados_antes.Visible = False
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
        Me.TableAdapterManager.ProdutosTableAdapter = Me.ProdutosTableAdapter
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Me.Venda_CompraTableAdapter
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'Venda_CompraTableAdapter
        '
        Me.Venda_CompraTableAdapter.ClearBeforeFill = True
        '
        'dataDados_depois
        '
        Me.dataDados_depois.CalendarFont = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataDados_depois.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataDados_depois.Location = New System.Drawing.Point(479, 58)
        Me.dataDados_depois.Name = "dataDados_depois"
        Me.dataDados_depois.Size = New System.Drawing.Size(97, 20)
        Me.dataDados_depois.TabIndex = 11
        Me.dataDados_depois.Visible = False
        '
        'btnData
        '
        Me.btnData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnData.Location = New System.Drawing.Point(582, 56)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(50, 23)
        Me.btnData.TabIndex = 12
        Me.btnData.Text = "&Ok"
        Me.btnData.UseVisualStyleBackColor = False
        Me.btnData.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(620, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Resetar"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Mensagem
        '
        Me.Mensagem.ShowAlways = True
        Me.Mensagem.ToolTipTitle = "Mensagem do Sistema"
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(644, 421)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.dataDados_depois)
        Me.Controls.Add(Me.dataDados_antes)
        Me.Controls.Add(Me.tipoDados)
        Me.Controls.Add(Me.ProdutosDataGridView)
        Me.Controls.Add(Me.Venda_CompraDataGridView)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.cpfDados)
        Me.Controls.Add(Me.lblDados)
        Me.Controls.Add(Me.radioProdutos)
        Me.Controls.Add(Me.radioVendas)
        Me.Controls.Add(Me.radioClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas dos Cadastros"
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_CompraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Venda_CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radioClientes As System.Windows.Forms.RadioButton
    Friend WithEvents radioVendas As System.Windows.Forms.RadioButton
    Friend WithEvents radioProdutos As System.Windows.Forms.RadioButton
    Friend WithEvents lblDados As System.Windows.Forms.Label
    Friend WithEvents cpfDados As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Venda_CompraTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.Venda_CompraTableAdapter
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Venda_CompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutosTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents Venda_CompraDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents tipoDados As System.Windows.Forms.TextBox
    Friend WithEvents dataDados_antes As System.Windows.Forms.DateTimePicker
    Friend WithEvents dataDados_depois As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Mensagem As System.Windows.Forms.ToolTip
End Class
