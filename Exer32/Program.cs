using System;

namespace Exer32
{
    class Program
    {
        static void Main(string[] args)
        {
            /// leia cinco grupos de quatro valores (A, B, C, D)
            string[,] matriz = new string[5,4];

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}
