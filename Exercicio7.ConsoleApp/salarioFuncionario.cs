using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7.ConsoleApp
{
    public class salarioFuncionario
    {
        public double salarioBase;
        public double totalDeVendas;
        public double percentual;
        public double comissao;
        //public double salario;

        public double calcularComissao()
        {

            comissao = totalDeVendas * percentual / 100;
            return comissao;
        }
        public double calcularSalario()
        {
            salarioBase = salarioBase + comissao;
            return salarioBase;
        }

        public void ImprimeNaTela()
        {
            Console.WriteLine();
            Console.WriteLine("O seu salario com comissão é de: " + salarioBase);
            Console.ReadLine();
        }
    }
}
