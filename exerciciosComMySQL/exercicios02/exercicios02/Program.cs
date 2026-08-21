namespace exercicios02;

class Program
{
    public static void Main()
    {
        Conexao c = new Conexao();

        Carro car = new Carro(c.ObterStringDeConexao());

        //car.Atualizar(4, "Camaro", "Preto");
        //car.Deletar(6);
        car.Cadastrar("Fusion", "Branco");

    }
}
