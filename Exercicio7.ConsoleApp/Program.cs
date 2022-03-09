using System;

namespace Exercicio7.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            salarioFuncionario salario = new salarioFuncionario();
            Console.Write("Digite o salario: ");
            salario.salarioBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o total de vendas: ");
            salario.totalDeVendas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o percentual da comissão: ");
            salario.percentual = Convert.ToDouble(Console.ReadLine());

            salario.calcularComissao();
            salario.calcularSalario();
            salario.ImprimeNaTela();
        }
    }
}
