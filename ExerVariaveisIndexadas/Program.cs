using System;
using System.Collections.Generic;

namespace ExerVariaveisIndexadas
{
    class Program
    {
        static void Main(string[] args)
        {
            /// crie um vetor de 10 posições do tipo inteiro
            /// 

            int[] vetor = new int[] {2,4,6,8,10,12,14,16,18,20};
            List<int> multiplicar = new List<int>();
            
            for(int i = 0; i < vetor.Length; i++)
            {
                multiplicar.Add(vetor[i] * 10);
                Console.WriteLine(multiplicar[i]);
            }


            ///--------------

            string[,] arraynomes = new string[5, 2];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Qual o primeiro nome");
                arraynomes[i, 0] = Console.ReadLine();
                Console.WriteLine("Qual o sobrenome do(a) " + arraynomes[i, 0]);
                arraynomes[i, 1] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} {1}", arraynomes[i, 0], arraynomes[i,1]);
            }
        }
    }
}
