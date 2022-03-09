using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10.ConsoleApp
{
    public class mediaPonderada
    {
        public double n1; //n1 = nota 1
        public double n2;
        public double p1;// p1 = peso 1
        public double p2;
       
        public double media;

        public double CalcularMedia()
        {
            media = (n1 * p1 + n2 * p2) / (p1 + p2);
            

            return media;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine("A media ponderada das notas dadas: " + media);
            Console.ReadLine();
        }
    }
}
