using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5.ConsoleApp
{
    internal class Esfera
    {
        public double raio;
        public double resultado;

        public double calcularCalcular()
        {
            resultado = (4 * Math.PI * (raio * raio * raio)) / 3;

            return resultado;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine("O volume da esfera é de:" + resultado);
            Console.ReadLine();
        }
    }
}
