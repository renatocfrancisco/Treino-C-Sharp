using System;

namespace Exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor gasto com desepesas: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Gorjeta do Garçom: " + (valor * 0.10));
        }
    }
}
