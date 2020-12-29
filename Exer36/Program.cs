using System;

namespace Exer36
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] faixaEtaria = new double[5];
            int idade;

            for (int i = 0; i < 15; i++)
            {
                idade = int.Parse(Console.ReadLine());
                if(idade <= 15) { faixaEtaria[0]++; }
                else if(idade <= 30) { faixaEtaria[1]++; }
                else if(idade <= 45) { faixaEtaria[2]++; }
                else if(idade <= 60) { faixaEtaria[3]++; }
                else { faixaEtaria[4]++; }
            }
            Console.WriteLine("Porcentagem de pessoas Faixa 1: {0}%\nPorcentagem de Pessoas Faixa 5 {1}%", Math.Round(100 * (faixaEtaria[0] / 15)), Math.Round(100 * (faixaEtaria[4] / 15)));
            
        }
    }
}
