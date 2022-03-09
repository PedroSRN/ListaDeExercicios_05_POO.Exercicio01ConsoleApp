using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.ConsoleApp
{
    internal class ConsumoDeCombustivel
    {
        public double kmInicio;
        public double kmFinal;
        public double quantidadeDeLitros;
        public double resultado;

        public double CalcularConsumoDeCombustivel()
        {
            double consumo =  kmFinal - kmInicio;

            resultado = consumo / quantidadeDeLitros;
                
            return resultado;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine("O seu consumo de combustivel foi de: " + resultado);
            Console.ReadLine();
        }
    }
}
