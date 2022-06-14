<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduto
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
        Dim ID_do_ProdutoLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim Tipo_de_ProdutoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduto))
        Dim FotoLabel As System.Windows.Forms.Label
        Me.ID_do_ProdutoLabel1 = New System.Windows.Forms.Label
        Me.ProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Banco_OtakuFestDataSet = New OtakuFest.Banco_OtakuFestDataSet
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox
        Me.Tipo_de_ProdutoComboBox = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnEscolher = New System.Windows.Forms.Button
        Me.ProdutosTableAdapter = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.ProdutosTableAdapter
        Me.TableAdapterManager = New OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
        Me.ProdutosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProdutosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox
        ID_do_ProdutoLabel = New System.Windows.Forms.Label
        DescriçãoLabel = New System.Windows.Forms.Label
        Tipo_de_ProdutoLabel = New System.Windows.Forms.Label
        FotoLabel = New System.Windows.Forms.Label
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdutosBindingNavigator.SuspendLayout()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_do_ProdutoLabel
        '
        ID_do_ProdutoLabel.AutoSize = True
        ID_do_ProdutoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_do_ProdutoLabel.Location = New System.Drawing.Point(97, 48)
        ID_do_ProdutoLabel.Name = "ID_do_ProdutoLabel"
        ID_do_ProdutoLabel.Size = New System.Drawing.Size(120, 14)
        ID_do_ProdutoLabel.TabIndex = 1
        ID_do_ProdutoLabel.Text = "ID do Produto:"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriçãoLabel.Location = New System.Drawing.Point(97, 85)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(84, 14)
        DescriçãoLabel.TabIndex = 3
        DescriçãoLabel.Text = "Descrição:"
        '
        'Tipo_de_ProdutoLabel
        '
        Tipo_de_ProdutoLabel.AutoSize = True
        Tipo_de_ProdutoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_de_ProdutoLabel.Location = New System.Drawing.Point(97, 119)
        Tipo_de_ProdutoLabel.Name = "Tipo_de_ProdutoLabel"
        Tipo_de_ProdutoLabel.Size = New System.Drawing.Size(130, 14)
        Tipo_de_ProdutoLabel.TabIndex = 5
        Tipo_de_ProdutoLabel.Text = "Tipo de Produto:"
        '
        'ID_do_ProdutoLabel1
        '
        Me.ID_do_ProdutoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "ID do Produto", True))
        Me.ID_do_ProdutoLabel1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_do_ProdutoLabel1.Location = New System.Drawing.Point(248, 47)
        Me.ID_do_ProdutoLabel1.Name = "ID_do_ProdutoLabel1"
        Me.ID_do_ProdutoLabel1.Size = New System.Drawing.Size(185, 23)
        Me.ID_do_ProdutoLabel1.TabIndex = 2
        Me.ID_do_ProdutoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProdutosBindingSource
        '
        Me.ProdutosBindingSource.DataMember = "Produtos"
        Me.ProdutosBindingSource.DataSource = Me.Banco_OtakuFestDataSet
        '
        'Banco_OtakuFestDataSet
        '
        Me.Banco_OtakuFestDataSet.DataSetName = "Banco_OtakuFestDataSet"
        Me.Banco_OtakuFestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "Descrição", True))
        Me.DescriçãoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(248, 81)
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(185, 24)
        Me.DescriçãoTextBox.TabIndex = 0
        '
        'Tipo_de_ProdutoComboBox
        '
        Me.Tipo_de_ProdutoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdutosBindingSource, "Tipo de Produto", True))
        Me.Tipo_de_ProdutoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Tipo_de_ProdutoComboBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_de_ProdutoComboBox.FormattingEnabled = True
        Me.Tipo_de_ProdutoComboBox.Items.AddRange(New Object() {"Alimentos", "Acessórios", "CDs/DVDs", "Mangás", "Vestimentas", "Outros"})
        Me.Tipo_de_ProdutoComboBox.Location = New System.Drawing.Point(248, 115)
        Me.Tipo_de_ProdutoComboBox.Name = "Tipo_de_ProdutoComboBox"
        Me.Tipo_de_ProdutoComboBox.Size = New System.Drawing.Size(185, 25)
        Me.Tipo_de_ProdutoComboBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 252)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'btnEscolher
        '
        Me.btnEscolher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEscolher.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscolher.Location = New System.Drawing.Point(248, 238)
        Me.btnEscolher.Name = "btnEscolher"
        Me.btnEscolher.Size = New System.Drawing.Size(55, 23)
        Me.btnEscolher.TabIndex = 2
        Me.btnEscolher.Text = "..."
        Me.btnEscolher.UseVisualStyleBackColor = True
        '
        'ProdutosTableAdapter
        '
        Me.ProdutosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.FornecedorTableAdapter = Nothing
        Me.TableAdapterManager.FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.Itens_da_Venda_CompraTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.Pagamento_do_ClienteTableAdapter = Nothing
        Me.TableAdapterManager.ProdutosTableAdapter = Me.ProdutosTableAdapter
        Me.TableAdapterManager.Remuneração_do_FuncionárioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Venda_CompraTableAdapter = Nothing
        '
        'ProdutosBindingNavigator
        '
        Me.ProdutosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProdutosBindingNavigator.BindingSource = Me.ProdutosBindingSource
        Me.ProdutosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProdutosBindingNavigator.DeleteItem = Nothing
        Me.ProdutosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProdutosBindingNavigatorSaveItem})
        Me.ProdutosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProdutosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProdutosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProdutosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProdutosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProdutosBindingNavigator.Name = "ProdutosBindingNavigator"
        Me.ProdutosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProdutosBindingNavigator.Size = New System.Drawing.Size(449, 25)
        Me.ProdutosBindingNavigator.TabIndex = 39
        Me.ProdutosBindingNavigator.Text = "BindingNavigator1"
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
        'ProdutosBindingNavigatorSaveItem
        '
        Me.ProdutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProdutosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProdutosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProdutosBindingNavigatorSaveItem.Name = "ProdutosBindingNavigatorSaveItem"
        Me.ProdutosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProdutosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FotoLabel.Location = New System.Drawing.Point(97, 155)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(48, 14)
        FotoLabel.TabIndex = 39
        FotoLabel.Text = "Foto:"
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackColor = System.Drawing.Color.Gainsboro
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProdutosBindingSource, "Foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(309, 155)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(124, 106)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPictureBox.TabIndex = 40
        Me.FotoPictureBox.TabStop = False
        '
        'frmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(449, 280)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.ProdutosBindingNavigator)
        Me.Controls.Add(Me.btnEscolher)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(ID_do_ProdutoLabel)
        Me.Controls.Add(Me.ID_do_ProdutoLabel1)
        Me.Controls.Add(DescriçãoLabel)
        Me.Controls.Add(Me.DescriçãoTextBox)
        Me.Controls.Add(Tipo_de_ProdutoLabel)
        Me.Controls.Add(Me.Tipo_de_ProdutoComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Produtos"
        CType(Me.ProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_OtakuFestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdutosBindingNavigator.ResumeLayout(False)
        Me.ProdutosBindingNavigator.PerformLayout()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID_do_ProdutoLabel1 As System.Windows.Forms.Label
    Friend WithEvents DescriçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_de_ProdutoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEscolher As System.Windows.Forms.Button
    Friend WithEvents Banco_OtakuFestDataSet As OtakuFest.Banco_OtakuFestDataSet
    Friend WithEvents ProdutosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdutosTableAdapter As OtakuFest.Banco_OtakuFestDataSetTableAdapters.ProdutosTableAdapter
    Friend WithEvents TableAdapterManager As OtakuFest.Banco_OtakuFestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProdutosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProdutosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
End Class
