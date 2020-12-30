using System;

namespace Exer15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }
        }
    }
}
