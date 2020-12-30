using System;

namespace Exer17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                /// Console.WriteLine("{0}.{1}.{2}", var1, var2, etc);
                Console.WriteLine("{0) {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0) {1}", y, x);
            }
        }
    }
}
