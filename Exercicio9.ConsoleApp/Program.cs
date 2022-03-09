using System;

namespace Exercicio9.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mediaHarmonica media = new mediaHarmonica();    
            Console.Write("Digite a NOTA 1: ");
            media.n1= Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a NOTA 2: ");
            media.n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a NOTA 3: ");
            media.n3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a NOTA 4: ");
            media.n4 = Convert.ToDouble(Console.ReadLine());

            media.calcularMedia();
            media.ImprimirNaTela();
        }
    }
}
