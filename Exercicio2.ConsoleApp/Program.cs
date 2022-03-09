using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorDeTemperatura conversor = new ConversorDeTemperatura();
            conversor.fahrenheit = 100;


            conversor.CalcularTemperatura();
            conversor.ImprimeNaTela();

        }
    }
}
