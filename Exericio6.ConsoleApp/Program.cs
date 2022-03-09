using System;

namespace Exericio6.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorDeTemperatura conversor = new ConversorDeTemperatura();
            Console.Write("Digite a temperatura em Celsius: ");
            conversor.celsius = Convert.ToDecimal(Console.ReadLine());

            conversor.CalcularTemperatura();
            conversor.ImprimeNaTela();

        }
    }
}
