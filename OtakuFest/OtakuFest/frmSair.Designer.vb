<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSair
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
        Me.lblMensagem = New System.Windows.Forms.Label
        Me.btnLogout = New System.Windows.Forms.Button
        Me.bntEncerrar = New System.Windows.Forms.Button
        Me.bntCancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Font = New System.Drawing.Font("Anime Ace 2.0 BB", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.Location = New System.Drawing.Point(12, 9)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(253, 14)
        Me.lblMensagem.TabIndex = 0
        Me.lblMensagem.Text = "Escolha uma das opções abaixo:"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(112, 36)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(79, 23)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'bntEncerrar
        '
        Me.bntEncerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bntEncerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntEncerrar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntEncerrar.Location = New System.Drawing.Point(15, 36)
        Me.bntEncerrar.Name = "bntEncerrar"
        Me.bntEncerrar.Size = New System.Drawing.Size(79, 23)
        Me.bntEncerrar.TabIndex = 2
        Me.bntEncerrar.TabStop = False
        Me.bntEncerrar.Text = "&Encerrar"
        Me.bntEncerrar.UseVisualStyleBackColor = False
        '
        'bntCancelar
        '
        Me.bntCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bntCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntCancelar.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntCancelar.Location = New System.Drawing.Point(209, 36)
        Me.bntCancelar.Name = "bntCancelar"
        Me.bntCancelar.Size = New System.Drawing.Size(79, 23)
        Me.bntCancelar.TabIndex = 0
        Me.bntCancelar.TabStop = False
        Me.bntCancelar.Text = "&Cancelar"
        Me.bntCancelar.UseVisualStyleBackColor = False
        '
        'frmSair
        '
        Me.AcceptButton = Me.bntCancelar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(300, 71)
        Me.Controls.Add(Me.bntCancelar)
        Me.Controls.Add(Me.bntEncerrar)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblMensagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialogo de Saida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents bntEncerrar As System.Windows.Forms.Button
    Friend WithEvents bntCancelar As System.Windows.Forms.Button
End Class
