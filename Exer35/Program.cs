using System;

namespace Exer35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 Idades: ");
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                int idade = int.Parse(Console.ReadLine());
                if (idade >= 18) { count++; }
            }
            Console.WriteLine("{0} Pessoas", count);
        }
    }
}
