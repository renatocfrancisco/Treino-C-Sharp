using System;

namespace Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor da hora aula: ");
            double valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Número de aulas dadas no mês: ");
            double numAulas = double.Parse(Console.ReadLine());
            Console.WriteLine("Desconto (%) do INSS: ");
            int descINSS = int.Parse(Console.ReadLine());

            double salLiquido = (valorHora * numAulas);
            Console.WriteLine("Salário Liquido: " + (salLiquido + (salLiquido * descINSS)));
        }
    }
}
