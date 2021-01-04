using System;

namespace Exer36
{
    class Program
    {
        static void Main(string[] args)
        {
//            Faça um programa que receba idade de 15 pessoas e que calcule e mostre:
                    //- a quantidade de pessoas em cada faixa etária
                    //- a percentagem de pessoas na primeira e na última faixa etária, com relação ao total de pessoas.


           Console.WriteLine("Digite 15 Idades: ");
            double[] faixaEtaria = new double[5];
            int idade;
            var x = new Random();

            for (int i = 0; i < 15; i++)
            {
                //idade = int.Parse(Console.ReadLine());
                idade = x.Next(70);
                Console.WriteLine(idade);
                if(idade <= 15) { faixaEtaria[0]++; }
                else if(idade <= 30) { faixaEtaria[1]++; }
                else if(idade <= 45) { faixaEtaria[2]++; }
                else if(idade <= 60) { faixaEtaria[3]++; }
                else { faixaEtaria[4]++; }
            }
            Console.WriteLine(" Faixa 1: {0} Pessoas \n Faixa 2: {1} Pessoas \n Faixa 3: {2} Pessoas \n Faixa 4: {3} Pessoas \n Faixa 5: {4} Pessoas \n", faixaEtaria[0], faixaEtaria[1], faixaEtaria[2], faixaEtaria[3], faixaEtaria[4]);
            Console.WriteLine("Porcentagem de pessoas Faixa 1: {0}%\nPorcentagem de Pessoas Faixa 5 {1}%", Math.Round(100 * (faixaEtaria[0] / 15)), Math.Round(100 * (faixaEtaria[4] / 15)));
            
        }
    }
}
