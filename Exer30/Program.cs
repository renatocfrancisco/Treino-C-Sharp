using System;

namespace Exer30
{
    class Program
    {
        static void Main(string[] args)
        {
            /// S = 1 + 1/2 + 1/3 + ¼ + ... + 1/n

            Console.WriteLine("Inserir um número: ");
            double n = double.Parse(Console.ReadLine());

            double soma = 1;

            for (double i = 2; i < (n+1); i++)
            {
                soma += (1 / i);
            }
            Console.WriteLine(soma.ToString("F"));
        }
    }
}
