using System;

namespace Exer30
{
    class Program
    {
        static void Main(string[] args)
        {
            /// S = 1 + 1/2 + 1/3 + ¼ + ... + 1/n

            double n = double.Parse(Console.ReadLine());
            n = Math.Abs(n);

            double soma = 0;

            for (double i = 1; i < n; i++)
            {
                soma += (1 / i);
            }
            Console.WriteLine(soma);
        }
    }
}
