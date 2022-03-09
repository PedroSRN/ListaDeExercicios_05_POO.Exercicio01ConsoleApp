using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            Console.Write("Digite o raio da esfera: ");
            esfera.raio = Convert.ToDouble(Console.ReadLine());

            esfera.calcularCalcular();
            esfera.ImprimeNaTela();
        }
    }
}
