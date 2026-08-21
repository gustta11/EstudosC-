using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios02
{
    class Carro
    {
        private readonly string? _stringDeConexao;

        public Carro(string stringConexao)
        {
            _stringDeConexao = stringConexao;
        }

        public void Cadastrar(string nome, string cor)
        {
            string sql = "INSERT INTO carros (nome,cor) VALUES (@nome, @cor)";

            using (var conexao = new MySqlConnection(_stringDeConexao))
            using (var comando = new MySqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@cor", cor);

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Cadastro efetuado com sucesso");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha ao conectar:" + ex.Message);
                }
            }
        }

        public void Consultar()
        {
            string sql = "SELECT * FROM carros";

            using (var conexao = new MySqlConnection(_stringDeConexao))
            using (var comando = new MySqlCommand(sql, conexao))
            {

                try
                {
                    conexao.Open();
                    using (var carros = comando.ExecuteReader())
                    {
                        while (carros.Read())
                        {
                            Console.WriteLine("Nome: " + carros["nome"]);
                            Console.WriteLine("Cor: " + carros["cor"]);
                        }
                    }
                    Console.WriteLine("Consulta realizada com sucesso!!1");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha ao conectar:" + ex.Message);
                }
            }
        }

        public void Atualizar(int id, string nome, string cor)
        {
            string sql = "UPDATE carros SET nome = @nome, cor = @cor WHERE id = @id";

            using (var conexao = new MySqlConnection(_stringDeConexao))
            using (var comando = new MySqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@cor", cor);

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Atualizacao efetuada com sucesso");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha ao conectar:" + ex.Message);
                }
            }
        }

        public void Deletar(int id)
        {
            string sql = "DELETE FROM carros WHERE id = @id";

            using (var conexao = new MySqlConnection(_stringDeConexao))
            using (var comando = new MySqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Remocao efetuada com sucesso");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Falha ao conectar:" + ex.Message);
                }
            }
        }
    }
}
