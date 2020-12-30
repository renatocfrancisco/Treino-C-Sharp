using System;

namespace Exer14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("Valores Iguais");
            }
            else
            {
                Console.WriteLine("Valores Diferentes");
            }
        }
    }
}
