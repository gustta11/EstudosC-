using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using MySql.Data.MySqlClient;

namespace exercicios01
{
    class Conexao
    {
        private readonly string _stringDeConexao;

        private const string _servidor = "localhost";
        private const string _database = "base";

        private const string _usuario = "root";

        private const string _password = "Jaquelinemorais2004@";

        public Conexao()
        {
            _stringDeConexao = $"Server={_servidor};Database ={_database}; User ID={_usuario}; Password={_password}";
        }

        public string ObterStringDeConexao()
        {
            return _stringDeConexao;
        }

        public void TestarConexao()
        {
            try
            {

                using (var conexao = new MySqlConnection(_stringDeConexao))
                {
                    conexao.Open();
                    Console.WriteLine("Conexão efetuada com sucesso!");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Falha ao conectar: {ex.Message}");
            }
        }
    }
}
