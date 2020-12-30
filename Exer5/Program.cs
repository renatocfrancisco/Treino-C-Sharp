using System;

namespace Exer5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valor acumulado = P * ((1+i)n -1)/i
            // i = taxa
            // p = aplicação mensal
            // n = número de meses(obs. (1 + i) elevado a n)

            Console.WriteLine("Inserir taxa, aplicação mensal e Nº de Meses");
            double i = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double valorAcumulado = p * ((Math.Pow(1 + i, n) - 1) / 1);
            Console.WriteLine("Valor Acumulado: {0}", valorAcumulado.ToString("F"));
            ///Está certo?
        }
    }
}
