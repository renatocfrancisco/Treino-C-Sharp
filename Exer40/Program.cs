using System;

namespace Exer40
{
    class Program
    {
        static void Main(string[] args)
        {
           // Faça um programa que receba a idade e o peso de sete pessoas.Calcule e mostre:
           //- a quantidade de pessoas com mais de 90 quilos
           //- a média das idades das sete pessoas


            /// a quantidade de pessoas com mais de 90 quilos
            /// a média das idades das sete pessoas
            /// Veiculo[] veiculo = new Veiculo[2];
            /// veiculo[0] = new Automovel("BMW");

            Pessoa[] pessoa = new Pessoa[7];
            int i = 0;
            int count = 0;

            while (i < 7)
            {
                pessoa[i] = new Pessoa();
                Console.WriteLine("Insira a idade e peso: ");
                pessoa[i].Cadastrar(int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                if(pessoa[i].peso > 90) { count++; }
                i++;
            }

            double media = 0;

            //for (int j = 0; j < pessoa.Length; j++)
            //{
            //    media += pessoa[j].idade;
            //}

            foreach (var individuo in pessoa)
            {
                media += individuo.idade;
            }

            Console.WriteLine("Média: {0}", Math.Round(media / pessoa.Length));
            Console.WriteLine("Pessoas com + de 90 Kg: {0}: ", count);

            Console.ReadKey();

        }
    }
}
