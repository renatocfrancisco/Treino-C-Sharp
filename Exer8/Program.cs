using System;

namespace Exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            int adicao = 0;
            Console.WriteLine("Primero Número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Número:");
            int y = int.Parse(Console.ReadLine());
            adicao = x + y;

            if (adicao > 20)
            {
                Console.WriteLine(adicao += 5);
            }
            else if (adicao <= 20)
            {
                Console.WriteLine(adicao += 5);
            }
        }
    }
}
