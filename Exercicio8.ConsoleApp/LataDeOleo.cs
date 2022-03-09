using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8.ConsoleApp
{
    public class LataDeOleo
    {
        public double raio;
        public double altura;
        public double resultado;

        public double CalcularLataDeOleo()
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
