using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoDeCombustivel consumo = new ConsumoDeCombustivel();

            Console.Write("Digite a quilometragem INICIAL: ");
            consumo.kmInicio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quilometragem FINAL: ");
            consumo.kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a Quantidade de Conbustivel inicial: ");
            consumo.quantidadeDeLitros = Convert.ToDouble(Console.ReadLine());

            consumo.CalcularConsumoDeCombustivel();
            consumo.ImprimeNaTela();
        }
    }
}
