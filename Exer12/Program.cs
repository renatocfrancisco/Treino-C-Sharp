using System;

namespace Exer12
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            string sexo = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());

            if (idade < 25)
            {
                Console.WriteLine(nome + " ACEITA");
            }
            else
            {
                Console.WriteLine(nome + " NÃO ACEITA");
            }
        }
    }
}
