using System;

namespace Exer18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                /// Console.WriteLine("{0}.{1}.{2}", mon, da, yer);
                Console.WriteLine("{0) {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0) {1}", y, x);
            }
        }
    }
}
