using System;

namespace Exer7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x + y > 10)
            {
                Console.WriteLine(x + y);
            }
        }
    }
}
