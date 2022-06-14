Public Class frmPrincipal

    Public Shared Confirmar As Boolean
    Public Shared Ferramenta As Integer

    Private Sub Temporizador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Temporizador.Tick
        lblData.Text = Date.Now.ToLongTimeString & Environment.NewLine & Date.Now.ToShortDateString
    End Sub

    Private Sub Chamar_Saida()
        frmSair.ShowDialog()
        Select Case (frmSair.Escolha)
            Case 1
                Confirmar = True
            Case 2
                Confirmar = False
                frmLogin.Show()
                Me.Hide()
            Case 3
                Application.ExitThread()
        End Select
    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Confirmar = True Then
            frmSair.ShowDialog()
            Select Case (frmSair.Escolha)
                Case 1
                    e.Cancel = True
                Case 2
                    e.Cancel = True
                    frmLogin.Show()
                    Me.Hide()
                Case 3
                    Application.ExitThread()
            End Select
        End If
    End Sub

    Private Sub LogoutEncerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutEncerrarToolStripMenuItem.Click, LogoutEncerrarToolStripButton.Click, LogoutEncerrarToolStripMenuItem1.Click
        Confirmar = False
        Chamar_Saida()
    End Sub

    Private Sub frmPrincipal_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Confirmar = True
        lblDescrição.Text = ""
        Dim Nível As String = lblNível.Text

        Select Case (Nível)
            Case "A"
                'Menus

                MovimentaçãoFinanceiraToolStripMenuItem.Enabled = True
                MovimentaçãoFinanceiraToolStripMenuItem1.Enabled = True

                MercadoriasToolStripMenuItem.Enabled = True
                MercadoriasToolStripMenuItem1.Enabled = True

                ConsultasToolStripMenuItem.Enabled = True
                ConsultasToolStripMenuItem1.Enabled = True

                ' Botões

                ComprasVendasToolStripButton.Enabled = True
                RemuneraçãoToolStripButton.Enabled = True
                PagamentoToolStripButton.Enabled = True
                ProdutosToolStripButton.Enabled = True
                FornecedoresToolStripButton.Enabled = True
                ConsultasToolStripButton.Enabled = True
            Case "B"
                'Menus

                MovimentaçãoFinanceiraToolStripMenuItem.Enabled = False
                MovimentaçãoFinanceiraToolStripMenuItem1.Enabled = False

                MercadoriasToolStripMenuItem.Enabled = True
                MercadoriasToolStripMenuItem1.Enabled = True

                ConsultasToolStripMenuItem.Enabled = True
                ConsultasToolStripMenuItem1.Enabled = True

                ' Botões

                ComprasVendasToolStripButton.Enabled = False
                RemuneraçãoToolStripButton.Enabled = False
                PagamentoToolStripButton.Enabled = False
                ProdutosToolStripButton.Enabled = True
                FornecedoresToolStripButton.Enabled = True
                ConsultasToolStripButton.Enabled = True
            Case "C"
                'Menus

                MovimentaçãoFinanceiraToolStripMenuItem.Enabled = False
                MovimentaçãoFinanceiraToolStripMenuItem1.Enabled = False

                MercadoriasToolStripMenuItem.Enabled = False
                MercadoriasToolStripMenuItem1.Enabled = False

                ConsultasToolStripMenuItem.Enabled = False
                ConsultasToolStripMenuItem1.Enabled = False

                ' Botões

                ComprasVendasToolStripButton.Enabled = False
                RemuneraçãoToolStripButton.Enabled = False
                PagamentoToolStripButton.Enabled = False
                ProdutosToolStripButton.Enabled = False
                FornecedoresToolStripButton.Enabled = False
                ConsultasToolStripButton.Enabled = False
        End Select

    End Sub

    Public Sub Chamar_Clientes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click, ClientesToolStripButton.Click, ClientesToolStripMenuItem1.Click
        frmCliente.ShowDialog()
    End Sub

    Public Sub Chamar_Funcionário(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click, FuncionáriosToolStripButton.Click, FuncionáriosToolStripMenuItem1.Click
        frmFuncionário.ShowDialog()
    End Sub

    Public Sub Chamar_Produto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosToolStripMenuItem.Click, ProdutosToolStripMenuItem1.Click, ProdutosToolStripButton.Click
        frmProduto.ShowDialog()
    End Sub

    Public Sub Chamar_Fornecedor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click, FornecedoresToolStripButton.Click, FornecedoresToolStripMenuItem1.Click
        frmFornecedor.ShowDialog()
    End Sub

    Private Sub Chamar_VendasCompras(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasComprasToolStripMenuItem.Click, ComprasVendasToolStripButton.Click, ComprasVendasToolStripMenuItem.Click
        frmVendaCompra.ShowDialog()
    End Sub

    Public Sub Chamar_Remuneração(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemuneraçãoToolStripMenuItem.Click, RemuneraçãoToolStripButton.Click, RemuneraçãoToolStripMenuItem1.Click
        frmRemuneração.ShowDialog()
    End Sub

    Public Sub Chamar_Pagamento(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagamentoToolStripMenuItem.Click, PagamentoToolStripButton.Click, PagamentoToolStripMenuItem1.Click
        frmPagamento.ShowDialog()
    End Sub

    Public Sub Chamar_Consultas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click, ConsultasToolStripButton.Click, ConsultasToolStripMenuItem1.Click
        frmConsulta.ShowDialog()
    End Sub

    Public Sub Chamar_Sobre(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreOSistemaToolStripMenuItem.Click, SobreOSistemaToolStripButton.Click, SobreOSistemaToolStripMenuItem1.Click
        frmSobre.ShowDialog()
    End Sub

    Public Sub Ferramentas()
        Try
            Select Case (Ferramenta)
                Case 1
                    System.Diagnostics.Process.Start("notepad")
                Case 2
                    System.Diagnostics.Process.Start("calc")
                Case 3
                    frmCalendário.ShowDialog()
                Case 4
                    System.Diagnostics.Process.Start("chrome")
                Case 5
                    System.Diagnostics.Process.Start("excel")
                Case 6
                    System.Diagnostics.Process.Start("winword")
                Case 7
                    System.Diagnostics.Process.Start("explorer")
            End Select
        Catch ex As Exception
            MessageBox.Show("Ferramenta não encontrada no computador ou sistema!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Chamar_Bloco(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click, BlocoDeNotasToolStripMenuItem1.Click, BlocoDeNotasToolStripMenuItem2.Click
        Ferramenta = 1
        Ferramentas()
    End Sub

    Public Sub Chamar_Calculadora(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click, CalculadoraToolStripMenuItem1.Click, CalculadoraToolStripMenuItem2.Click
        Ferramenta = 2
        Ferramentas()
    End Sub

    Public Sub Chamar_Calendário(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendárioToolStripMenuItem.Click, CalendárioToolStripMenuItem2.Click, CalendárioToolStripMenuItem1.Click
        Ferramenta = 3
        Ferramentas()
    End Sub

    Public Sub Chamar_Internet(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavegadorInternetToolStripMenuItem.Click, NavegadorToolStripMenuItem.Click, NavegadorInternetToolStripMenuItem1.Click
        Ferramenta = 4
        Ferramentas()
    End Sub

    Public Sub Chamar_Excel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.Click, ExcelToolStripMenuItem1.Click, ExcelToolStripMenuItem2.Click
        Ferramenta = 5
        Ferramentas()
    End Sub

    Public Sub Chamar_Word(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click, WordToolStripMenuItem1.Click, WordToolStripMenuItem2.Click
        Ferramenta = 6
        Ferramentas()
    End Sub

    Public Sub Chamar_Explorer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.Click, WindowsExplorerToolStripMenuItem1.Click, WindowsExplorerToolStripMenuItem2.Click
        Ferramenta = 7
        Ferramentas()
    End Sub

    Public Sub Limpar_Descrição(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem2.MouseLeave, WordToolStripMenuItem1.MouseLeave, WordToolStripMenuItem.MouseLeave, WindowsExplorerToolStripMenuItem2.MouseLeave, WindowsExplorerToolStripMenuItem1.MouseLeave, WindowsExplorerToolStripMenuItem.MouseLeave, VendasComprasToolStripMenuItem.MouseLeave, SobreOSistemaToolStripMenuItem1.MouseLeave, SobreOSistemaToolStripMenuItem.MouseLeave, SobreOSistemaToolStripButton.MouseLeave, RemuneraçãoToolStripMenuItem1.MouseLeave, RemuneraçãoToolStripMenuItem.MouseLeave, RemuneraçãoToolStripButton.MouseLeave, ProdutosToolStripMenuItem1.MouseLeave, ProdutosToolStripMenuItem.MouseLeave, ProdutosToolStripButton.MouseLeave, PagamentoToolStripMenuItem1.MouseLeave, PagamentoToolStripMenuItem.MouseLeave, PagamentoToolStripButton.MouseLeave, OfficeToolStripMenuItem.MouseLeave, NavegadorToolStripMenuItem.MouseLeave, NavegadorInternetToolStripMenuItem1.MouseLeave, NavegadorInternetToolStripMenuItem.MouseLeave, MovimentaçãoFinanceiraToolStripMenuItem.MouseLeave, MovimentaçãoFinanceiraToolStripMenuItem1.MouseLeave, MicrosoftOfficeToolStripMenuItem1.MouseLeave, MicrosoftOfficeToolStripMenuItem.MouseLeave, MercadoriasToolStripMenuItem1.MouseLeave, MercadoriasToolStripMenuItem.MouseLeave, LogoutEncerrarToolStripMenuItem1.MouseLeave, LogoutEncerrarToolStripMenuItem.MouseLeave, LogoutEncerrarToolStripButton.MouseLeave, FuncionáriosToolStripMenuItem1.MouseLeave, FuncionáriosToolStripMenuItem.MouseLeave, FuncionáriosToolStripButton.MouseLeave, FornecedoresToolStripMenuItem1.MouseLeave, FornecedoresToolStripMenuItem.MouseLeave, FornecedoresToolStripButton.MouseLeave, FerramentasToolStripSplitButton.MouseLeave, FerramentasToolStripMenuItem1.MouseLeave, FerramentasToolStripMenuItem.MouseLeave, ExcelToolStripMenuItem2.MouseLeave, ExcelToolStripMenuItem1.MouseLeave, ExcelToolStripMenuItem.MouseLeave, ConsultasToolStripMenuItem1.MouseLeave, ConsultasToolStripMenuItem.MouseLeave, ConsultasToolStripButton.MouseLeave, ComprasVendasToolStripMenuItem.MouseLeave, ComprasVendasToolStripButton.MouseLeave, ClientesToolStripMenuItem1.MouseLeave, ClientesToolStripMenuItem.MouseLeave, ClientesToolStripButton.MouseLeave, CalendárioToolStripMenuItem2.MouseLeave, CalendárioToolStripMenuItem1.MouseLeave, CalendárioToolStripMenuItem.MouseLeave, CalculadoraToolStripMenuItem2.MouseLeave, CalculadoraToolStripMenuItem1.MouseLeave, CalculadoraToolStripMenuItem.MouseLeave, CadastrosToolStripMenuItem1.MouseLeave, CadastrosToolStripMenuItem.MouseLeave, BlocoDeNotasToolStripMenuItem2.MouseLeave, BlocoDeNotasToolStripMenuItem1.MouseLeave, BlocoDeNotasToolStripMenuItem.MouseLeave
        lblDescrição.Text = ""
    End Sub

    Private Sub Cadastro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrosToolStripMenuItem.MouseHover, CadastrosToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Cadastro de Clientes e " & Environment.NewLine & "Funcionários"
    End Sub

    Private Sub Mercadorias_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MercadoriasToolStripMenuItem.MouseHover, MercadoriasToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Cadastro de Produtos e " & Environment.NewLine & "Fornecedores"
    End Sub

    Private Sub Movimentação__MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimentaçãoFinanceiraToolStripMenuItem.MouseHover, MovimentaçãoFinanceiraToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Controle da Movimentação " & Environment.NewLine & "Financeira"
    End Sub

    Private Sub Ferramentas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FerramentasToolStripMenuItem.MouseHover, FerramentasToolStripMenuItem1.MouseHover, FerramentasToolStripSplitButton.MouseHover
        lblDescrição.Text = "Utilitários do Sistema"
    End Sub

    Private Sub Consultas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.MouseHover, ConsultasToolStripMenuItem1.MouseHover, ConsultasToolStripButton.MouseHover
        lblDescrição.Text = "Pesquisa de Tabelas e Dados"
    End Sub

    Private Sub Sobre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreOSistemaToolStripMenuItem.MouseHover, SobreOSistemaToolStripMenuItem1.MouseHover, SobreOSistemaToolStripButton.MouseHover
        lblDescrição.Text = "Informações Adicionais " & Environment.NewLine & "do Sistema"
    End Sub

    Private Sub Logout_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutEncerrarToolStripMenuItem.MouseHover, LogoutEncerrarToolStripMenuItem1.MouseHover, LogoutEncerrarToolStripButton.MouseHover
        lblDescrição.Text = "Encerra ou Efetua Logout " & Environment.NewLine & "do Sistema"
    End Sub

    Private Sub Clientes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.MouseHover, ClientesToolStripMenuItem1.MouseHover, ClientesToolStripButton.MouseHover
        lblDescrição.Text = "Cadastrar Clientes " & Environment.NewLine & "e seus Dados"
    End Sub

    Private Sub Funcionários_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.MouseHover, FuncionáriosToolStripMenuItem1.MouseHover, FuncionáriosToolStripButton.MouseHover
        lblDescrição.Text = "Cadastrar Funcionários " & Environment.NewLine & "e seus Dados"
    End Sub

    Private Sub Produtos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosToolStripMenuItem1.MouseHover, ProdutosToolStripMenuItem.MouseHover, ProdutosToolStripButton.MouseHover
        lblDescrição.Text = "Cadastrar Produtos e " & Environment.NewLine & "suas Especificações"
    End Sub

    Private Sub Fornecedores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.MouseHover, FornecedoresToolStripMenuItem1.MouseHover, FornecedoresToolStripButton.MouseHover
        lblDescrição.Text = "Cadastrar Fornecedores e" & Environment.NewLine & "seus Dados Comerciais"
    End Sub

    Private Sub Vendas_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasComprasToolStripMenuItem.MouseHover, ComprasVendasToolStripMenuItem.MouseHover, ComprasVendasToolStripButton.MouseHover
        lblDescrição.Text = "Cadastro de Vendas/Compras " & Environment.NewLine & "Realizadas e Respectivos Itens"
    End Sub

    Private Sub Remuneração_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemuneraçãoToolStripMenuItem.MouseHover, RemuneraçãoToolStripMenuItem1.MouseHover, RemuneraçãoToolStripButton.MouseHover
        lblDescrição.Text = "Remuneração do Funcionário"
    End Sub

    Private Sub Pagamento_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagamentoToolStripMenuItem.MouseHover, PagamentoToolStripMenuItem1.MouseHover, PagamentoToolStripButton.MouseHover
        lblDescrição.Text = "Pagamento do Cliente"
    End Sub

    Private Sub Bloco_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlocoDeNotasToolStripMenuItem.MouseHover, BlocoDeNotasToolStripMenuItem2.MouseHover, BlocoDeNotasToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Abre o Bloco de Notas" & Environment.NewLine & "do Computador"
    End Sub

    Private Sub Calculadora_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.MouseHover, CalculadoraToolStripMenuItem2.MouseHover, CalculadoraToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Abre a Calculadora" & Environment.NewLine & "do Computador"
    End Sub

    Private Sub Calendário_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalendárioToolStripMenuItem2.MouseHover, CalendárioToolStripMenuItem.MouseHover, CalendárioToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Abre o Calendário" & Environment.NewLine & "do Sistema"
    End Sub

    Private Sub Navegador_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavegadorToolStripMenuItem.MouseHover, NavegadorInternetToolStripMenuItem1.MouseHover, NavegadorInternetToolStripMenuItem.MouseHover
        lblDescrição.Text = "Abre o Navegador Padrão " & Environment.NewLine & "de Internet do Computador"
    End Sub

    Private Sub Office_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficeToolStripMenuItem.MouseHover, MicrosoftOfficeToolStripMenuItem1.MouseHover, MicrosoftOfficeToolStripMenuItem.MouseHover
        lblDescrição.Text = "Lista Algumas Ferramentas " & Environment.NewLine & "do Microsoft Office"
    End Sub

    Private Sub Excel_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcelToolStripMenuItem.MouseHover, ExcelToolStripMenuItem2.MouseHover, ExcelToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Abre o Excel para " & Environment.NewLine & "Criar ou Editar Planilhas"
    End Sub

    Private Sub Word_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.MouseHover, WordToolStripMenuItem2.MouseHover, WordToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Abre o Word para " & Environment.NewLine & "Criar ou Editar Textos"
    End Sub

    Private Sub Windows_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorerToolStripMenuItem.MouseHover, WindowsExplorerToolStripMenuItem2.MouseHover, WindowsExplorerToolStripMenuItem1.MouseHover
        lblDescrição.Text = "Abre as Pastas o Navegador " & Environment.NewLine & "de Pastas do Computador"
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripButton2.PerformClick()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        My.Computer.Audio.Play(".\Night.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class