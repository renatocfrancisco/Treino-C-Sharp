using System;

namespace Exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor do Produto: ");
            double valorProd = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor com desconto de 9%: " + (valorProd - valorProd * 0.09));
        }
    }
}
