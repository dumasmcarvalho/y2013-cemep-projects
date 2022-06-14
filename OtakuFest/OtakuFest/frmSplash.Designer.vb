<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Sub_Progresso = New System.Windows.Forms.ProgressBar
        Me.Progresso = New System.Windows.Forms.ProgressBar
        Me.Temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.Mensagem = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Sub_Progresso
        '
        Me.Sub_Progresso.Location = New System.Drawing.Point(12, 208)
        Me.Sub_Progresso.Name = "Sub_Progresso"
        Me.Sub_Progresso.Size = New System.Drawing.Size(476, 10)
        Me.Sub_Progresso.TabIndex = 0
        '
        'Progresso
        '
        Me.Progresso.Location = New System.Drawing.Point(12, 222)
        Me.Progresso.Name = "Progresso"
        Me.Progresso.Size = New System.Drawing.Size(476, 20)
        Me.Progresso.TabIndex = 1
        '
        'Temporizador
        '
        Me.Temporizador.Enabled = True
        '
        'Mensagem
        '
        Me.Mensagem.AutoSize = True
        Me.Mensagem.BackColor = System.Drawing.Color.Transparent
        Me.Mensagem.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mensagem.ForeColor = System.Drawing.Color.Black
        Me.Mensagem.Location = New System.Drawing.Point(12, 186)
        Me.Mensagem.Name = "Mensagem"
        Me.Mensagem.Size = New System.Drawing.Size(210, 16)
        Me.Mensagem.TabIndex = 3
        Me.Mensagem.Text = "Carregando, aguarde..."
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 250)
        Me.Controls.Add(Me.Mensagem)
        Me.Controls.Add(Me.Progresso)
        Me.Controls.Add(Me.Sub_Progresso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela de Splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sub_Progresso As System.Windows.Forms.ProgressBar
    Friend WithEvents Progresso As System.Windows.Forms.ProgressBar
    Friend WithEvents Temporizador As System.Windows.Forms.Timer
    Friend WithEvents Mensagem As System.Windows.Forms.Label

End Class
