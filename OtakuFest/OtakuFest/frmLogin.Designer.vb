<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnEntrar = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbxUsuário = New System.Windows.Forms.TextBox
        Me.tbxSenha = New System.Windows.Forms.TextBox
        Me.lblCadastro = New System.Windows.Forms.LinkLabel
        Me.lblRecuperar = New System.Windows.Forms.LinkLabel
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.Location = New System.Drawing.Point(306, 157)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "&Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(387, 157)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha:"
        '
        'tbxUsuário
        '
        Me.tbxUsuário.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUsuário.Location = New System.Drawing.Point(216, 28)
        Me.tbxUsuário.Name = "tbxUsuário"
        Me.tbxUsuário.Size = New System.Drawing.Size(246, 24)
        Me.tbxUsuário.TabIndex = 0
        '
        'tbxSenha
        '
        Me.tbxSenha.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSenha.Location = New System.Drawing.Point(216, 91)
        Me.tbxSenha.Name = "tbxSenha"
        Me.tbxSenha.Size = New System.Drawing.Size(246, 24)
        Me.tbxSenha.TabIndex = 1
        Me.tbxSenha.UseSystemPasswordChar = True
        '
        'lblCadastro
        '
        Me.lblCadastro.ActiveLinkColor = System.Drawing.Color.Black
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCadastro.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadastro.Location = New System.Drawing.Point(342, 55)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(116, 15)
        Me.lblCadastro.TabIndex = 2
        Me.lblCadastro.TabStop = True
        Me.lblCadastro.Text = "Não possui cadastro?"
        '
        'lblRecuperar
        '
        Me.lblRecuperar.ActiveLinkColor = System.Drawing.Color.Black
        Me.lblRecuperar.AutoSize = True
        Me.lblRecuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRecuperar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecuperar.Location = New System.Drawing.Point(362, 118)
        Me.lblRecuperar.Name = "lblRecuperar"
        Me.lblRecuperar.Size = New System.Drawing.Size(100, 15)
        Me.lblRecuperar.TabIndex = 3
        Me.lblRecuperar.TabStop = True
        Me.lblRecuperar.Text = "Esqueceu de algo?"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(474, 191)
        Me.Controls.Add(Me.lblRecuperar)
        Me.Controls.Add(Me.lblCadastro)
        Me.Controls.Add(Me.tbxSenha)
        Me.Controls.Add(Me.tbxUsuário)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 220)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 220)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login: OtakuFest"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxUsuário As System.Windows.Forms.TextBox
    Friend WithEvents tbxSenha As System.Windows.Forms.TextBox
    Friend WithEvents lblCadastro As System.Windows.Forms.LinkLabel
    Friend WithEvents lblRecuperar As System.Windows.Forms.LinkLabel
End Class
