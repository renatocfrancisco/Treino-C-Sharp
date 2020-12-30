using System;

namespace Exer24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserir Idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 65)
            {
                Console.WriteLine("Maior de 65 Anos");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Menor de Idade");
            }
            else
            {
                Console.WriteLine("Maior de Idade");
            }
        }
    }
}
