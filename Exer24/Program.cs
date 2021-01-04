using System;

namespace Exer24
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Entrar com a idade de uma pessoa e informar:
                //• Se é maior de idade
                //• Se é menor de idade
                //• Se é maior de 65 anos


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
