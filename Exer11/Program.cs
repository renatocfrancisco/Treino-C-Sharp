using System;

namespace Exer11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir um número: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 20)
            {
                Console.WriteLine("Maior que 20");
            }
            else if (x < 20)
            {
                Console.WriteLine("Menor que 20");
            }
            else
            {
                Console.WriteLine("Igual a 20");
            }
        }
    }
}
