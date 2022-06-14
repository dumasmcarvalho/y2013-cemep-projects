Public Class frmProduto

    Private Sub ProdutosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProdutosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            MessageBox.Show("Registro salvo com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Falha ao salvar o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProdutosTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Produtos)
        If ProdutosBindingSource.Count = 0 Then
            ProdutosBindingSource.AddNew()
            DescriçãoTextBox.Focus()
        End If
    End Sub

    Private Sub btnEscolher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscolher.Click
        Try
            Dim Dialogo_Carregar As OpenFileDialog = New OpenFileDialog()
            If (Dialogo_Carregar.ShowDialog() = DialogResult.OK) Then
                Dim Bit As Bitmap = New Bitmap(Dialogo_Carregar.FileName)
                Dialogo_Carregar.DefaultExt = "*.jpg"
                Dialogo_Carregar.Filter = "Imagem (*.jpg)|*.jpg"
                FotoPictureBox.Image = Bit
            End If
        Catch ex As Exception
            MessageBox.Show("Formato de imagem não reconhecido!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Tipo_de_ProdutoComboBox.SelectedIndex = -1
        DescriçãoTextBox.Focus()
    End Sub

    Private Sub BindingNavigatorDeletetem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click
        Try
            If MessageBox.Show("Deseja excluir o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ProdutosBindingSource.RemoveCurrent()
                Me.Validate()
                Me.ProdutosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Banco_OtakuFestDataSet)
            Else
                Me.ProdutosTableAdapter.Fill(Me.Banco_OtakuFestDataSet.Produtos)
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao excluir o registro!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProduto_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class