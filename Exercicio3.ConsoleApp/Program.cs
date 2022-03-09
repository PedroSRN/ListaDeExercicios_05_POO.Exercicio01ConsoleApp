using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            Console.Write("Digite a ALTURA do cilindro: ");
            cilindro.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a RAIO do cilindro: ");
            cilindro.raio = Convert.ToDouble(Console.ReadLine());

            cilindro.CalcularCilindro();
            cilindro.ImprimeNaTela();
        }
    }
}
