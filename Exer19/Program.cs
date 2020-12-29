using System;

namespace Exer19
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x > z) Console.WriteLine(" O maior é " + x);
                else Console.WriteLine(" O maior é " + z);
            }
            else
            {
                if (y > z) Console.WriteLine(" O maior é " + y);
                else Console.WriteLine(" O maior é " + z);
            }
        }
    }
}
