namespace exercicio01;

public class Program
{
    public static void Main()
    {
        Produto produto = new Produto();
        Produto produto2 = new Produto();

        produto.Nome = "Cabo HDMI";
        produto.Valor = 500;
        produto.FormaPagamento = "À vista";

        produto2.Nome = "Cabo Display Port";
        produto2.Valor = 500;
        produto2.FormaPagamento = "À prazo";

        produto.RetornarCaracteristicas();
        produto2.RetornarCaracteristicas();
    }
}
