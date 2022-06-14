using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace System_KWB
{
    public partial class frmCurso : Form
    {
        bool Ocupado;

        Conexão Conexão = new Conexão();
        OleDbCommand Comando = new OleDbCommand();
        OleDbDataAdapter Adapter;
        DataTable Tabela = new DataTable();

        public frmCurso()
        {
            InitializeComponent();

            // Propriedades do DataGrid

            DataGrid.ColumnCount = 6;
            string[] Vetor = { "Código Disciplina", "Nome Disciplina", "Código Curso", "Nome Curso", "Código Professor", "Nome Professor" };

            for (int x = 0; x <= 5; x++)
            {
                DataGrid.Columns[x].Name = Vetor[x];
            }

            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Seleção da Linha

            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGrid.MultiSelect = false;          
        }

        // Inserir no Banco de Dados

        private void Inserir(string nomeDisciplina, int idCurso, string nomeCurso, int idProfessor, string nomeProfessor)
        {
            // SQL para Inserir

            Comando.CommandText = "INSERT INTO Disciplinas (Nome_da_Disciplina, Codigo_do_Curso, Nome_do_Curso, Codigo_do_Professor, Nome_do_Professor) " +
                                        "VALUES (@NOME_DIS, @ID_CUR, @NOME_CUR, @ID_PRO, @NOME_PRO)";
            Comando.Connection = Conexão._Conexão;

            // Adicionando Parametros

            Comando.Parameters.AddWithValue("@NOME_DIS", nomeDisciplina);
            Comando.Parameters.AddWithValue("@ID_CUR", idCurso);
            Comando.Parameters.AddWithValue("@NOME_CUR", nomeCurso);
            Comando.Parameters.AddWithValue("@ID_PRO", idProfessor);
            Comando.Parameters.AddWithValue("@NOME_PRO", nomeProfessor);

            // Conectar e Execute do Insert

            try
            {
                Conexão.Conectar();

                if (Comando.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Inserida a disciplina com sucesso!");
                }

                Conexão.Desconectar();

                int ID = Convert.ToInt32(código_do_CursoLabel3.Text);
                Carregar(ID);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();
            }
        }

        // Preencher Campos da Tabela

        private void Linhas(string idDisciplina, string nomeDisciplina, string idCurso, string nomeCurso, string idProfessor, string nomeProfessor)
        {
            DataGrid.Rows.Add(idDisciplina, nomeDisciplina, idCurso, nomeCurso, idProfessor, nomeProfessor);
        }

        // Recuperação de Dados

        private void Carregar(int idCurso)
        {
            DataGrid.Rows.Clear();

            // SQL de Carregamento

            string SQL = "SELECT * FROM Disciplinas WHERE Codigo_do_Curso = " + idCurso;
            Comando = new OleDbCommand(SQL, Conexão._Conexão);

            try
            {
                Conexão.Conectar();
                Adapter = new OleDbDataAdapter(Comando);

                Adapter.Fill(Tabela);

                // Loop de Incremento de Linhas na Tabela
                foreach (DataRow Row in Tabela.Rows)
                {
                    Linhas(Row[0].ToString(), Row[1].ToString(), Row[2].ToString(), Row[3].ToString(), Row[4].ToString(), Row[5].ToString());
                }

                Conexão.Desconectar();

                // Limpar Tabela

                Tabela.Rows.Clear();                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();
            }

        }

        // Atualizar o Banco de Dados

        private void Atualizar(int idDisciplina, string nomeDisciplina, int idCurso, string nomeCurso, int idProfessor, string nomeProfessor)
        {
            // SQL para Atualizar

            string SQL = "UPDATE Disciplinas SET Nome_da_Disciplina ='" + nomeDisciplina + "', Codigo_do_Curso = " + idCurso + ", Nome_do_Curso = '" + nomeCurso + "', Codigo_do_Professor = " + idProfessor + ", Nome_do_Professor = '" + nomeProfessor + "' WHERE Codigo_da_Disciplina = " + idDisciplina;

            Comando = new OleDbCommand(SQL, Conexão._Conexão);

            // Conectar Conexão, Atualizar, Recuperação, Preencher

            try
            {
                Conexão.Conectar();
                Adapter = new OleDbDataAdapter(Comando);

                Adapter.UpdateCommand = Conexão._Conexão.CreateCommand();
                Adapter.UpdateCommand.CommandText = SQL;

                if (Adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Dados da disciplina foram atualizados!");
                }

                Conexão.Desconectar();

                // Atualizar
                int ID = Convert.ToInt32(código_do_CursoLabel3.Text);
                Carregar(ID);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();
            }
        }

        // Apagar do Banco de Dados

        private void Apagar(int idDisciplina)
        {
            // SQL para Apagar

            string SQL = "DELETE FROM Disciplinas WHERE Codigo_da_Disciplina = " + idDisciplina;

            Comando = new OleDbCommand(SQL, Conexão._Conexão);

            // Conectar Conexão, Executar o Apagamento, Fechar Conexão

            try
            {
                Conexão.Conectar();
                Adapter = new OleDbDataAdapter(Comando);

                Adapter.DeleteCommand = Conexão._Conexão.CreateCommand();
                Adapter.DeleteCommand.CommandText = SQL;

                // Confirmação para Apagar

                if ((MessageBox.Show("Deseja remover a disciplina?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult .OK))
                {
                    if (Comando.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Removida com sucesso!");
                    }

                }

                Conexão.Desconectar();

                int ID = Convert.ToInt32(código_do_CursoLabel3.Text);
                Carregar(ID);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Conexão.Desconectar();                    
            }
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            this.professoresTableAdapter.Fill(this.bD_KWB_DataSet.Professores);
            this.disciplinasTableAdapter.Fill(this.bD_KWB_DataSet.Disciplinas);
            this.cursosTableAdapter.Fill(this.bD_KWB_DataSet.Cursos);

            /*
            btnAtualizar_Professores.FlatAppearance.BorderSize = 0;
            btnAtualizar_Professores.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            */

            if (cursosBindingSource.Count == 0)
            {
                DataAdicionar.PerformClick();
            }
        }

        private void Inserir()
        {
            string SQL = "SELECT Nome FROM Professores WHERE (Demitido = False)";
            Conexão Conexão = new Conexão();
            OleDbDataAdapter Adapter = new OleDbDataAdapter(SQL, Conexão._Conexão);

            Conexão.Conectar();

            DataSet DataSet = new DataSet();
            Adapter.Fill(DataSet, "Professores");

            nome_do_ProfessorComboBox.DataSource = DataSet.Tables["Professores"];
            nome_do_ProfessorComboBox.DisplayMember = "Nome";
            nome_do_ProfessorComboBox.ValueMember = "Nome";

            LimparCampos();

            Conexão.Desconectar();
        }

        private void btnAdicionarDados_Click(object sender, EventArgs e)
        {
            try
            {
                int idCurso = Convert.ToInt32(código_do_CursoLabel3.Text);
                int idProfessor = Convert.ToInt32(código_do_ProfessorComboBox.SelectedValue);

                if (nome_da_DisciplinaTextBox.Text == "")
                {
                    MessageBox.Show("Um ou mais campos não foram preenchidos!", "Aviso");
                }
                else
                {
                    Inserir(nome_da_DisciplinaTextBox.Text, idCurso, nome_do_CursoTextBox.Text, idProfessor, nome_do_ProfessorComboBox.SelectedValue.ToString());
                    LimparCampos();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos!", "Aviso");
            }
        }

        private void btnRemoverDados_Click(object sender, EventArgs e)
        {
            try
            {
                string Selecionada = DataGrid.SelectedRows[0].Cells[0].Value.ToString();

                int ID = Convert.ToInt32(Selecionada);
                Apagar(ID);

                LimparCampos();
            }
            catch(Exception)
            {
                MessageBox.Show("Nenhuma linha foi selecionada!", "Aviso");
            }
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            LimparCampos();
        }

        private void LimparCampos()
        {
            nome_da_DisciplinaTextBox.Clear();
            nome_do_ProfessorComboBox.SelectedIndex = -1;
            código_do_ProfessorComboBox.SelectedIndex = -1;
        }

        private void Repreencher()
        {
            DataGrid.Rows.Clear();
            LimparCampos();

            nome_do_CursoTextBox.Text = nomeTextBox.Text;
            código_do_CursoLabel3.Text = código_do_CursoLabel1.Text;

            int ID = Convert.ToInt32(código_do_CursoLabel3.Text);
            Carregar(ID);
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            try
            {
                string Selecionada = DataGrid.SelectedRows[0].Cells[0].Value.ToString();

                int ID = Convert.ToInt32(Selecionada);
                int idCurso = Convert.ToInt32(código_do_CursoLabel3.Text);
                int idProfessor = Convert.ToInt32(código_do_ProfessorComboBox.SelectedValue);

                Atualizar(ID, nome_da_DisciplinaTextBox.Text, idCurso, nome_do_CursoTextBox.Text, idProfessor, nome_do_ProfessorComboBox.SelectedValue.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Nenhuma linha foi selecionada!", "Aviso");
            }
        }

        private void btnCarregarDados_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(código_do_CursoLabel3.Text);
            Carregar(ID);
        }

        private void DataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                nome_da_DisciplinaTextBox.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();

                código_do_ProfessorComboBox.SelectedIndex = (Convert.ToInt32(DataGrid.SelectedRows[0].Cells[4].Value.ToString())) - 1;

                nome_do_ProfessorComboBox.SelectedIndex = código_do_ProfessorComboBox.SelectedIndex;
            }
            catch(Exception)
            {
                MessageBox.Show("Nenhuma linha foi selecionada!", "Aviso");
            }
        }

        private void DataAdicionar_Click(object sender, EventArgs e)
        {
            if (this.cursosBindingSource.Count == 0)
            {
                this.cursosBindingSource.AddNew();
            }

            else if (this.cursosBindingSource.Count > 0)
            {
                DataSalvar.PerformClick();
                this.cursosBindingSource.AddNew();
            }

            Inserir();
            nomeTextBox.Focus();
            numero_de_VagasNumericUpDown.Value = 0;
            periodoComboBox.SelectedIndex = -1;
        }

        private void DataRemover_Click(object sender, EventArgs e)
        {
            if (this.cursosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem removidos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.cursosBindingSource.Count > 0)
            {
                DialogResult opcaoSelecionada = MessageBox.Show("Deseja excluir o registro?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcaoSelecionada.Equals(DialogResult.Yes))
                {
                    this.cursosBindingSource.RemoveCurrent();
                }
                else
                {
                    this.cursosBindingSource.Position = this.cursosBindingSource.Position;
                    this.cursosTableAdapter.Fill(this.bD_KWB_DataSet.Cursos);
                }
            }

            nomeTextBox.Focus();
        }

        private void DataSalvar_Click(object sender, EventArgs e)
        {
            if (this.cursosBindingSource.Count == 0)
            {
                MessageBox.Show("Não existem registros para serem salvos!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.cursosBindingSource.Count > 0)
            {
                if (Ocupado == true)
                {
                    return;
                }

                Ocupado = true;

                this.Validate();
                this.cursosBindingSource.EndEdit();

                try
                {
                    this.cursosTableAdapter.Update(bD_KWB_DataSet.Cursos);
                    MessageBox.Show("Salvo com Sucesso...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Erro ao Salvar!");
                }

                Ocupado = false;

                this.cursosTableAdapter.Fill(this.bD_KWB_DataSet.Cursos);
                this.cursosBindingSource.Position = this.cursosBindingSource.Position;
            }
        }

        private void DataPrimeiro_Click(object sender, EventArgs e)
        {
            this.cursosBindingSource.MoveFirst();
        }

        private void DataAnterior_Click(object sender, EventArgs e)
        {
            this.cursosBindingSource.MovePrevious();
        }

        private void DataProximo_Click(object sender, EventArgs e)
        {
            this.cursosBindingSource.MoveNext();
        }

        private void DataUltimo_Click(object sender, EventArgs e)
        {
            this.cursosBindingSource.MoveLast();
        }

        private void nome_do_ProfessorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = nome_do_ProfessorComboBox.SelectedIndex;
            código_do_ProfessorComboBox.SelectedIndex = x;
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            Repreencher();
            Inserir();
        }

        private void nomeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
