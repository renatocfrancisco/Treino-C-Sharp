using System;

namespace Exer7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primero Número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Número:");
            int y = int.Parse(Console.ReadLine());

            if (x + y > 10)
            {
                Console.WriteLine(x + y);
            }
        }
    }
}
