using System;

namespace Exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x + y > 20)
            {
                int if1 = x + y + 8;
                Console.WriteLine(if1);
                if (if1 <= 20)
                {
                    Console.WriteLine(if1 + 5);
                }
            }
        }
    }
}
