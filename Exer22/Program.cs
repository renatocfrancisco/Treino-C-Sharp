using System;
using System.Collections.Generic;

namespace Exer22
{
    class Program
    {
        static void Main(string[] args)
        {
//            Entrar com três números e armazená-los em três variáveis com seguintes nomes: maior, intermediário e
//menor(suponha números diferentes).


            int maior, intermed, menor = 0;

            Console.WriteLine("Insira três números inteiros: ");

            List<int> lista = new List<int>();

            int quant = 3;

            for (int i = 0; i < quant; i++)
            {
                lista.Add(int.Parse(Console.ReadLine()));
            }

            lista.Sort();
            lista.Reverse();

            maior = lista[0];
            intermed = lista[1];
            menor = lista[2];

            Console.WriteLine("Maior: {0} / Intermedíario: {1} / Menor: {2}", maior, intermed, menor);

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());

            //if (x > y && y > z)
            //{
            //    maior = x;
            //    intermed = y;
            //    menor = z;
            //}
            //else if (x > z && z > y)
            //{
            //    maior = x;
            //    intermed = z;
            //    menor = y;
            //}
            //else if (y > z && z > x)
            //{
            //    maior = y;
            //    intermed = z;
            //    menor = x;
            //}
            //else if (y > x && x > z)
            //{
            //    maior = y;
            //    intermed = x;
            //    menor = z;
            //}
            //else if (z > y && z > x)
            //{
            //    maior = z;
            //    intermed = y;
            //    menor = x;
            //}
            //else
            //{
            //    maior = z;
            //    intermed = x;
            //    menor = y;
            //}
        }
    }
}
