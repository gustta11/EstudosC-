using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace exercicios02
{
    class Conexao
    {
        private readonly string _stringDeConexao;

        private const string _servidor = "localhost";
        private const string _database = "concessionaria";
        private const string _password = "Gustavokeven2004@";
        private const string _user = "root";

        public Conexao()
        {
            _stringDeConexao = $"Server={_servidor};Database ={_database}; User ID={_user}; Password={_password}";
        }

        public String ObterStringDeConexao()
        {
            return _stringDeConexao;
        }

        public void TestarConexao()
        {
            try
            {
                using (var Conexao = new MySqlConnection(_stringDeConexao))
                {
                    Conexao.Open();
                    Console.WriteLine("Conexao efetuada com sucesso");
                }
                

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Falha ao conectar:" + ex.Message);
            }
        }
    }
}
