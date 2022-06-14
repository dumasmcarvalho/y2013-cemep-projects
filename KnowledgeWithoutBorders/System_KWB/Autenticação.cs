using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System_KWB
{
    class Autenticação
    {
        // Variaveis usadas para realizar a autenticação de usuário e senha
        static string Usuário;
        static string Senha;
        static string Nível;

        public static void Login(string _Usuário, string _Senha, string _Nível)
        {
            // As variaveis abaixo não podem ser iguais as que foram usadas nos parametros do método Login() já que devemos 
            // receber os valores do mesmo
            Usuário = _Usuário;
            Senha = _Senha;
            Nível = _Nível;
        }

        public static void Recuperação(string _Usuário, string _Senha)
        {
            Usuário = _Usuário;
            Senha = _Senha;
        }

        public static String Exibir_Nível()
        {
            return Nível;
        }

        public static String Exibir_Usuario()
        {
            return Usuário;
        }

        public static String Exibir_Dados()
        {
            return "Usuário: " + Usuário + "\nSenha: " + Senha;
        }
    }
}
