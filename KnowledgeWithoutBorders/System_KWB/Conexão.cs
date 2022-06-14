using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace System_KWB
{
    class Conexão
    {
        // Esta é uma variavel responsavel pela conexão do Banco de Dados
        public OleDbConnection _Conexão = new OleDbConnection();

        public void Conectar()
        {
            /* A ConnectionString é o caminho de onde se encontra o Banco de Dados, este caminho é encontrado:
             * - Gerenciador de Servidores
             * - Selecionar a Fonte de Dados
             * - Ir na propriedade Cadeia de Conexão e copiar o que possui nela
             * - Quando for colar, altere o caminho Data Source = C:/Pasta para Data Source = |DataDirectory|\Resources\Banco.accdb
             */
            _Conexão.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Resources\BD_KWB.accdb";
            _Conexão.Open();
        }

        public void Desconectar()
        {
            _Conexão.Close();
        }
    }
}
