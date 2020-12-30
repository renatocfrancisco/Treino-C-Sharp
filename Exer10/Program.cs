using System;

namespace Exer10
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            if (x > 20 && x < 90)
            {
                Console.WriteLine(x + " está entre 20 e 90");
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
