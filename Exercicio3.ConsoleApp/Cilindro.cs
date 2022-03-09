using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.ConsoleApp
{
    public class Cilindro
    {
        public double raio;
        public double altura;
        public double resultado;
        
        public double CalcularCilindro()
        {
            resultado = Math.PI * (raio * raio) * altura;

            return resultado;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine();
            Console.WriteLine("O volume do cilindro é de " + resultado);
            Console.ReadLine();
        }
    }
}
