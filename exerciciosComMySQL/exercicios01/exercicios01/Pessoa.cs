using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace exercicios01
{
    class Pessoa
    {
        private readonly string? _stringDeConexao;

        public Pessoa(string stringConexao)
        {
            _stringDeConexao = stringConexao;
        }

        public void Cadastrar(string nome, string cidade)
        {
            string sql = "INSERT INTO pessoas (nome,cidade) VALUES (@nome, @cidade)";

            using (var conexao = new MySqlConnection(_stringDeConexao))
            using (var comando = new MySqlCommand(sql,conexao))
            {
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@cidade", cidade);

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Cadastro efetuado com sucesso");

                } catch (Exception ex) {
                    Console.WriteLine("Falha ao conectar:" + ex.Message);
                }
            }
        }
    }
}
