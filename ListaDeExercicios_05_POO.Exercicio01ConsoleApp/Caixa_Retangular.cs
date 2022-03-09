using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios_05_POO.Exercicio01ConsoleApp
{
    public class Caixa_Retangular
    {
        public decimal comprimento;
        public decimal largura;
        public decimal altura;
        public decimal volume;


        public decimal CalcularRetangulo()
        {
            volume = comprimento*largura*altura;
            return volume;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine("O volume é " + volume);
            Console.ReadLine();
            
        }
    }
}
