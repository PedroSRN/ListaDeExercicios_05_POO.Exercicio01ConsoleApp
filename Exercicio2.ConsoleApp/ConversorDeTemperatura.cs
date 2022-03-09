using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.ConsoleApp
{
    public class ConversorDeTemperatura
    {
        public decimal fahrenheit;
        public decimal celsius;
       



        public decimal CalcularTemperatura()
        {
            celsius = (fahrenheit-32) / 1.8M;

            return celsius;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine("A temperatura convertida para Celsius é:" + celsius);
            Console.ReadLine();
        }

    }
}
