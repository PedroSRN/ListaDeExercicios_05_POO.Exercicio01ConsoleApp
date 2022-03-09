using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericio6.ConsoleApp
{
    internal class ConversorDeTemperatura
    {
        public decimal fahrenheit;
        public decimal celsius;




        public decimal CalcularTemperatura()
        {
            fahrenheit = (celsius * 1.8M) + 32;

            return fahrenheit;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine("O valor convertido para fahrenheit é de: " + fahrenheit);
            Console.ReadLine();
        }
    }
}
