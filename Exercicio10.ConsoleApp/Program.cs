using System;

namespace Exercicio10.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mediaPonderada media = new mediaPonderada(); 

            Console.Write("Digite a NOTA 1: ");
            media.n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso da  NOTA 1: ");
            media.p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a NOTA 2: ");
            media.n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso da NOTA 2: ");
            media.p2 = Convert.ToDouble(Console.ReadLine());

            media.CalcularMedia();
            media.ImprimeNaTela();
        }
    }
}
