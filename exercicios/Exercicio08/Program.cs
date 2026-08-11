namespace Exercicio08;

class Program
{
    public static void Main()
    {
        Colaborador colaborador01 = new();
        Colaborador colaborador02 = new();
        colaborador01.ValeTrasporte(5000);
        colaborador01.PremioFaltas(0);
        colaborador02.ValeTrasporte(3000);
        colaborador02.PremioFaltas(1);
    }
}
