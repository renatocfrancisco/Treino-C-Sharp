using System;

namespace Exer26
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor < 20)
            {
                Console.WriteLine(valor + (valor * 0.45));
            }
            else
            {
                Console.WriteLine(valor + (valor * 0.30));
            }
        }
    }
}
