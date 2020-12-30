using System;

namespace Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
//            3.Criar um algoritmo que efetue o cálculo do salário líquido de um professor. Os dados fornecidos serão: valor
//              da hora aula, numero de aulas dadas no mês e percentual de desconto do INSS.

            Console.WriteLine("Valor da hora aula: ");
            double valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Número de aulas dadas no mês: ");
            double numAulas = double.Parse(Console.ReadLine());
            Console.WriteLine("Desconto (%) do INSS: ");
            double descINSS = double.Parse(Console.ReadLine());
            descINSS /= 100;

            double salLiquido = (valorHora * numAulas);
            Console.WriteLine("Salário Liquido: " + (salLiquido - (salLiquido * descINSS)));
        }
    }
}
