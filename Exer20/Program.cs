using System;

namespace Exer20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira três números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if (x < y && y < z)
            {
                Console.WriteLine("{0} {1} {2}", x, y, z);
            }
            else if (x < z && z < y)
            {
                Console.WriteLine("{0} {1} {2}", x, z, y);
            }
            else if (y < z && z < x)
            {
                Console.WriteLine("{0} {1} {2}", y, z, x);
            }
            else if (y < x && x < z)
            {
                Console.WriteLine("{0} {1} {2}", y, x, z);
            }
            else if (z < y && z < x)
            {
                Console.WriteLine("{0} {1} {2}", z, y, x);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", z, x, y);
            }
        }
    }
}
