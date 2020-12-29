using System;

namespace Exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            double despesas = double.Parse(Console.ReadLine());
            Console.WriteLine("Gorjeta do Garçom: " + (despesas * 0.10));
        }
    }
}
