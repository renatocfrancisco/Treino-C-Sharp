using System;

namespace Exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número: ");
            int num6 = int.Parse(Console.ReadLine());
            if (num6 > 20)
            {
                Console.WriteLine(num6);
            }
        }
    }
}
