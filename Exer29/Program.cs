using System;

namespace Exer29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            while (n <= 2000)
            {
                if ((n % 11) == 5)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
        }
    }
}
