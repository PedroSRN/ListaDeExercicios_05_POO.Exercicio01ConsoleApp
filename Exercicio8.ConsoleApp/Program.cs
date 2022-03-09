using System;

namespace Exercicio8.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LataDeOleo lata = new LataDeOleo();
          
            Console.Write("Digite a ALTURA da lata de óleo: ");
            lata.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a RAIO da lata de óleo: ");
            lata.raio = Convert.ToDouble(Console.ReadLine());

            lata.CalcularLataDeOleo();
            lata.ImprimeNaTela();
        }
    }
}
