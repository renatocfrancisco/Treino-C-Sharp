using System;

namespace Exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Entrar com um número e imprimi-lo caso seja maior que 20
            Console.WriteLine("Insira um número: ");
            int num6 = int.Parse(Console.ReadLine());
            if (num6 > 20)
            {
                Console.WriteLine(num6);
            }
        }
    }
}
