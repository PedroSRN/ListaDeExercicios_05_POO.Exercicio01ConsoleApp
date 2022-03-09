using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9.ConsoleApp
{
    public class mediaHarmonica
    {
        public double n1;
        public double n2;
        public double n3;
        public double n4;
        public double media;

        public double calcularMedia()
        {
            media = (4 / ((1 / n1) + (1 / n2) + (1 / n3) + (1 / n4)));
            return media;
        }
        
        public void ImprimirNaTela()
        {
            Console.WriteLine("A média harmonica das notas dadas é de: " + media);
            Console.ReadLine();
        }
    }
}
