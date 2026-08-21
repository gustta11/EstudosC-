using System.Globalization;
using System.Net.Http.Headers;

namespace exercicios06;

class Program
{

    public static void Main()
    {;

        VerificarNotas v = new();
        Console.WriteLine(v.VerificarSituacao(8.5, 7.5));
 
    }
        
}
