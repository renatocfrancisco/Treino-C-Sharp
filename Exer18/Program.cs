using System;

namespace Exer18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrar com dois números e imprimi-los em ordem decrescente 

            Console.WriteLine("Insira dois números: ");
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
