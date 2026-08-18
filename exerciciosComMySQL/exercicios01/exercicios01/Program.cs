namespace exercicios01;

class Program
{
    public static void Main()
    {
        Conexao c = new();
        c.TestarConexao();

        Pessoa p = new(c.ObterStringDeConexao());
        p.Cadastrar("Gustavo", "Alagoinhas");


    }
}
