using System;

namespace Exer25
{
    class Program
    {
        static void Main(string[] args)
        {
            double pr1 = double.Parse(Console.ReadLine());
            double pr2 = double.Parse(Console.ReadLine());

            double media = (pr1 + pr2) / 2;
            if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media < 3)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Em Exame");
            }
        }
    }
}
