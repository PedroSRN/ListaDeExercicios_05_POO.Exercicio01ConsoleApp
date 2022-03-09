using System;

namespace ListaDeExercicios_05_POO.Exercicio01ConsoleApp
{
    internal class Program
    {
        //1) Crie um programa para calcular o volume de uma caixa retangular
        static void Main(string[] args)
        {
            Caixa_Retangular caixa = new Caixa_Retangular();
            caixa.altura = 30;
            caixa.largura = 40;
            caixa.comprimento = 55;

            caixa.CalcularRetangulo();
            caixa.ImprimeNaTela();
           
        }
    }
}
